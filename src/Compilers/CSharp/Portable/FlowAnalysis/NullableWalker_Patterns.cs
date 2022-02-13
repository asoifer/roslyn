// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed partial class NullableWalker
    {
        private void LearnFromAnyNullPatterns(
                    BoundExpression expression,
                    BoundPattern pattern)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10904, 938, 1191);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 1077, 1109);

                int
                slot = f_10904_1088_1108(this, expression)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 1123, 1180);

                f_10904_1123_1179(this, slot, f_10904_1154_1169(expression), pattern);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10904, 938, 1191);

                int
                f_10904_1088_1108(Microsoft.CodeAnalysis.CSharp.NullableWalker
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.MakeSlot(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 1088, 1108);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10904_1154_1169(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 1154, 1169);
                    return return_v;
                }


                int
                f_10904_1123_1179(Microsoft.CodeAnalysis.CSharp.NullableWalker
                this_param, int
                inputSlot, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                inputType, Microsoft.CodeAnalysis.CSharp.BoundPattern
                pattern)
                {
                    this_param.LearnFromAnyNullPatterns(inputSlot, inputType, pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 1123, 1179);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10904, 938, 1191);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10904, 938, 1191);
            }
        }

        private void VisitPatternForRewriting(BoundPattern pattern)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10904, 1203, 1604);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 1436, 1470);

                f_10904_1436_1469(!IsConditionalState);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 1484, 1509);

                var
                currentState = State
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 1523, 1556);

                f_10904_1523_1555(this, pattern);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 1570, 1593);

                f_10904_1570_1592(this, currentState);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10904, 1203, 1604);

                int
                f_10904_1436_1469(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 1436, 1469);
                    return 0;
                }


                int
                f_10904_1523_1555(Microsoft.CodeAnalysis.CSharp.NullableWalker
                this_param, Microsoft.CodeAnalysis.CSharp.BoundPattern
                node)
                {
                    this_param.VisitWithoutDiagnostics((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 1523, 1555);
                    return 0;
                }


                int
                f_10904_1570_1592(Microsoft.CodeAnalysis.CSharp.NullableWalker
                this_param, Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState
                newState)
                {
                    this_param.SetState(newState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 1570, 1592);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10904, 1203, 1604);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10904, 1203, 1604);
            }
        }

        public override BoundNode VisitSubpattern(BoundSubpattern node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10904, 1616, 1761);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 1704, 1724);

                f_10904_1704_1723(this, f_10904_1710_1722(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 1738, 1750);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10904, 1616, 1761);

                Microsoft.CodeAnalysis.CSharp.BoundPattern
                f_10904_1710_1722(Microsoft.CodeAnalysis.CSharp.BoundSubpattern
                this_param)
                {
                    var return_v = this_param.Pattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 1710, 1722);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode?
                f_10904_1704_1723(Microsoft.CodeAnalysis.CSharp.NullableWalker
                this_param, Microsoft.CodeAnalysis.CSharp.BoundPattern
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 1704, 1723);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10904, 1616, 1761);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10904, 1616, 1761);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitRecursivePattern(BoundRecursivePattern node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10904, 1773, 2080);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 1873, 1898);

                f_10904_1873_1897(this, f_10904_1879_1896(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 1912, 1952);

                f_10904_1912_1951(this, f_10904_1931_1950(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 1966, 2002);

                f_10904_1966_2001(this, f_10904_1985_2000(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 2016, 2043);

                f_10904_2016_2042(this, f_10904_2022_2041(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 2057, 2069);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10904, 1773, 2080);

                Microsoft.CodeAnalysis.CSharp.BoundTypeExpression?
                f_10904_1879_1896(Microsoft.CodeAnalysis.CSharp.BoundRecursivePattern
                this_param)
                {
                    var return_v = this_param.DeclaredType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 1879, 1896);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode?
                f_10904_1873_1897(Microsoft.CodeAnalysis.CSharp.NullableWalker
                this_param, Microsoft.CodeAnalysis.CSharp.BoundTypeExpression?
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode?)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 1873, 1897);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSubpattern>
                f_10904_1931_1950(Microsoft.CodeAnalysis.CSharp.BoundRecursivePattern
                this_param)
                {
                    var return_v = this_param.Deconstruction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 1931, 1950);
                    return return_v;
                }


                int
                f_10904_1912_1951(Microsoft.CodeAnalysis.CSharp.NullableWalker
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSubpattern>
                nodes)
                {
                    this_param.VisitAndUnsplitAll<Microsoft.CodeAnalysis.CSharp.BoundSubpattern>(nodes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 1912, 1951);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSubpattern>
                f_10904_1985_2000(Microsoft.CodeAnalysis.CSharp.BoundRecursivePattern
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 1985, 2000);
                    return return_v;
                }


                int
                f_10904_1966_2001(Microsoft.CodeAnalysis.CSharp.NullableWalker
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSubpattern>
                nodes)
                {
                    this_param.VisitAndUnsplitAll<Microsoft.CodeAnalysis.CSharp.BoundSubpattern>(nodes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 1966, 2001);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10904_2022_2041(Microsoft.CodeAnalysis.CSharp.BoundRecursivePattern
                this_param)
                {
                    var return_v = this_param.VariableAccess;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 2022, 2041);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode?
                f_10904_2016_2042(Microsoft.CodeAnalysis.CSharp.NullableWalker
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode?)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 2016, 2042);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10904, 1773, 2080);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10904, 1773, 2080);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitConstantPattern(BoundConstantPattern node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10904, 2092, 2245);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 2190, 2208);

                f_10904_2190_2207(this, f_10904_2196_2206(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 2222, 2234);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10904, 2092, 2245);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10904_2196_2206(Microsoft.CodeAnalysis.CSharp.BoundConstantPattern
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 2196, 2206);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode?
                f_10904_2190_2207(Microsoft.CodeAnalysis.CSharp.NullableWalker
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 2190, 2207);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10904, 2092, 2245);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10904, 2092, 2245);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitDeclarationPattern(BoundDeclarationPattern node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10904, 2257, 2464);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 2361, 2388);

                f_10904_2361_2387(this, f_10904_2367_2386(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 2402, 2427);

                f_10904_2402_2426(this, f_10904_2408_2425(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 2441, 2453);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10904, 2257, 2464);

                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10904_2367_2386(Microsoft.CodeAnalysis.CSharp.BoundDeclarationPattern
                this_param)
                {
                    var return_v = this_param.VariableAccess;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 2367, 2386);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode?
                f_10904_2361_2387(Microsoft.CodeAnalysis.CSharp.NullableWalker
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode?)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 2361, 2387);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                f_10904_2408_2425(Microsoft.CodeAnalysis.CSharp.BoundDeclarationPattern
                this_param)
                {
                    var return_v = this_param.DeclaredType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 2408, 2425);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode?
                f_10904_2402_2426(Microsoft.CodeAnalysis.CSharp.NullableWalker
                this_param, Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 2402, 2426);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10904, 2257, 2464);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10904, 2257, 2464);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitDiscardPattern(BoundDiscardPattern node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10904, 2476, 2595);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 2572, 2584);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10904, 2476, 2595);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10904, 2476, 2595);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10904, 2476, 2595);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitTypePattern(BoundTypePattern node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10904, 2607, 2759);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 2697, 2722);

                f_10904_2697_2721(this, f_10904_2703_2720(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 2736, 2748);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10904, 2607, 2759);

                Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                f_10904_2703_2720(Microsoft.CodeAnalysis.CSharp.BoundTypePattern
                this_param)
                {
                    var return_v = this_param.DeclaredType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 2703, 2720);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode?
                f_10904_2697_2721(Microsoft.CodeAnalysis.CSharp.NullableWalker
                this_param, Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 2697, 2721);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10904, 2607, 2759);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10904, 2607, 2759);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitRelationalPattern(BoundRelationalPattern node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10904, 2771, 2928);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 2873, 2891);

                f_10904_2873_2890(this, f_10904_2879_2889(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 2905, 2917);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10904, 2771, 2928);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10904_2879_2889(Microsoft.CodeAnalysis.CSharp.BoundRelationalPattern
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 2879, 2889);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode?
                f_10904_2873_2890(Microsoft.CodeAnalysis.CSharp.NullableWalker
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 2873, 2890);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10904, 2771, 2928);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10904, 2771, 2928);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitNegatedPattern(BoundNegatedPattern node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10904, 2940, 3093);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 3036, 3056);

                f_10904_3036_3055(this, f_10904_3042_3054(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 3070, 3082);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10904, 2940, 3093);

                Microsoft.CodeAnalysis.CSharp.BoundPattern
                f_10904_3042_3054(Microsoft.CodeAnalysis.CSharp.BoundNegatedPattern
                this_param)
                {
                    var return_v = this_param.Negated;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 3042, 3054);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode?
                f_10904_3036_3055(Microsoft.CodeAnalysis.CSharp.NullableWalker
                this_param, Microsoft.CodeAnalysis.CSharp.BoundPattern
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 3036, 3055);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10904, 2940, 3093);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10904, 2940, 3093);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitBinaryPattern(BoundBinaryPattern node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10904, 3105, 3285);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 3199, 3216);

                f_10904_3199_3215(this, f_10904_3205_3214(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 3230, 3248);

                f_10904_3230_3247(this, f_10904_3236_3246(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 3262, 3274);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10904, 3105, 3285);

                Microsoft.CodeAnalysis.CSharp.BoundPattern
                f_10904_3205_3214(Microsoft.CodeAnalysis.CSharp.BoundBinaryPattern
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 3205, 3214);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode?
                f_10904_3199_3215(Microsoft.CodeAnalysis.CSharp.NullableWalker
                this_param, Microsoft.CodeAnalysis.CSharp.BoundPattern
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 3199, 3215);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundPattern
                f_10904_3236_3246(Microsoft.CodeAnalysis.CSharp.BoundBinaryPattern
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 3236, 3246);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode?
                f_10904_3230_3247(Microsoft.CodeAnalysis.CSharp.NullableWalker
                this_param, Microsoft.CodeAnalysis.CSharp.BoundPattern
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 3230, 3247);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10904, 3105, 3285);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10904, 3105, 3285);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitITuplePattern(BoundITuplePattern node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10904, 3297, 3465);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 3391, 3428);

                f_10904_3391_3427(this, f_10904_3410_3426(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 3442, 3454);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10904, 3297, 3465);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSubpattern>
                f_10904_3410_3426(Microsoft.CodeAnalysis.CSharp.BoundITuplePattern
                this_param)
                {
                    var return_v = this_param.Subpatterns;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 3410, 3426);
                    return return_v;
                }


                int
                f_10904_3391_3427(Microsoft.CodeAnalysis.CSharp.NullableWalker
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSubpattern>
                nodes)
                {
                    this_param.VisitAndUnsplitAll<Microsoft.CodeAnalysis.CSharp.BoundSubpattern>(nodes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 3391, 3427);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10904, 3297, 3465);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10904, 3297, 3465);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void LearnFromAnyNullPatterns(
                    int inputSlot,
                    TypeSymbol inputType,
                    BoundPattern pattern)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10904, 3769, 7788);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 3930, 3974) || true) && (inputSlot <= 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10904, 3930, 3974);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 3967, 3974);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10904, 3930, 3974);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 4170, 4204);

                f_10904_4170_4203(this, pattern);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 4220, 7777);

                switch (pattern)
                {

                    case BoundConstantPattern cp:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10904, 4220, 7777);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 4320, 4392);

                        bool
                        isExplicitNullCheck = f_10904_4347_4369(f_10904_4347_4355(cp)) == f_10904_4373_4391()
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 4414, 4774) || true) && (isExplicitNullCheck)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10904, 4414, 4774);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 4661, 4751);

                            f_10904_4661_4750(this, inputSlot, inputType, ref this.State, markDependentSlotsNotNull: false);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10904, 4414, 4774);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10904, 4796, 4802);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10904, 4220, 7777);

                    case BoundDeclarationPattern _:
                    case BoundDiscardPattern _:
                    case BoundITuplePattern _:
                    case BoundRelationalPattern _:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10904, 4220, 7777);
                        DynAbs.Tracing.TraceSender.TraceBreak(10904, 5010, 5016);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10904, 4220, 7777);

                    case BoundTypePattern tp:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10904, 4220, 7777);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 5101, 5292) || true) && (f_10904_5105_5129(tp))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10904, 5101, 5292);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 5179, 5269);

                            f_10904_5179_5268(this, inputSlot, inputType, ref this.State, markDependentSlotsNotNull: false);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10904, 5101, 5292);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10904, 5314, 5320);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10904, 4220, 7777);

                    case BoundRecursivePattern rp:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10904, 4220, 7777);
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 5417, 5620) || true) && (f_10904_5421_5445(rp))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10904, 5417, 5620);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 5503, 5593);

                                f_10904_5503_5592(this, inputSlot, inputType, ref this.State, markDependentSlotsNotNull: false);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10904, 5417, 5620);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 5741, 6400) || true) && (f_10904_5745_5765(rp) is null && (DynAbs.Tracing.TraceSender.Expression_True(10904, 5745, 5805) && f_10904_5777_5805_M(!rp.Deconstruction.IsDefault)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10904, 5741, 6400);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 5863, 5902);

                                var
                                elements = f_10904_5878_5901(inputType)
                                ;
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 5941, 5946);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 5948, 6028);
                                    for (int
        i = 0
        ,
        n = f_10904_5952_6028(rp.Deconstruction.Length, (DynAbs.Tracing.TraceSender.Conditional_F1(10904, 5987, 6005) || ((elements.IsDefault && DynAbs.Tracing.TraceSender.Conditional_F2(10904, 6008, 6009)) || DynAbs.Tracing.TraceSender.Conditional_F3(10904, 6012, 6027))) ? 0 : elements.Length)
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 5932, 6373) || true) && (i < n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 6037, 6040)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10904, 5932, 6373))

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10904, 5932, 6373);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 6106, 6150);

                                        BoundSubpattern
                                        item = f_10904_6129_6146(rp)[i]
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 6184, 6218);

                                        FieldSymbol
                                        element = elements[i]
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 6252, 6342);

                                        f_10904_6252_6341(this, f_10904_6277_6312(this, element, inputSlot), f_10904_6314_6326(element), f_10904_6328_6340(item));
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10904, 1, 442);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(10904, 1, 442);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10904, 5741, 6400);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 6474, 7233) || true) && (f_10904_6478_6502_M(!rp.Properties.IsDefault))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10904, 6474, 7233);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 6569, 6574);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 6576, 6600);
                                    for (int
        i = 0
        ,
        n = rp.Properties.Length
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 6560, 7206) || true) && (i < n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 6609, 6612)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10904, 6560, 7206))

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10904, 6560, 7206);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 6678, 6718);

                                        BoundSubpattern
                                        item = f_10904_6701_6714(rp)[i]
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 6752, 6780);

                                        Symbol
                                        symbol = f_10904_6768_6779(item)
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 6857, 7175) || true) && (symbol is not null && (DynAbs.Tracing.TraceSender.Expression_True(10904, 6861, 6956) && f_10904_6883_6956(f_10904_6883_6904(symbol), inputType, TypeCompareKind.AllIgnoreOptions)))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10904, 6857, 7175);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 7030, 7140);

                                            f_10904_7030_7139(this, f_10904_7055_7089(this, symbol, inputSlot), f_10904_7091_7119(symbol).Type, f_10904_7126_7138(item));
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10904, 6857, 7175);
                                        }
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10904, 1, 647);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(10904, 1, 647);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10904, 6474, 7233);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10904, 7278, 7284);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10904, 4220, 7777);

                    case BoundNegatedPattern p:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10904, 4220, 7777);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 7351, 7409);

                        f_10904_7351_7408(this, inputSlot, inputType, f_10904_7398_7407(p));
                        DynAbs.Tracing.TraceSender.TraceBreak(10904, 7431, 7437);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10904, 4220, 7777);

                    case BoundBinaryPattern p:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10904, 4220, 7777);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 7503, 7558);

                        f_10904_7503_7557(this, inputSlot, inputType, f_10904_7550_7556(p));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 7580, 7636);

                        f_10904_7580_7635(this, inputSlot, inputType, f_10904_7627_7634(p));
                        DynAbs.Tracing.TraceSender.TraceBreak(10904, 7658, 7664);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10904, 4220, 7777);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10904, 4220, 7777);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 7712, 7762);

                        throw f_10904_7718_7761(pattern);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10904, 4220, 7777);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10904, 3769, 7788);

                int
                f_10904_4170_4203(Microsoft.CodeAnalysis.CSharp.NullableWalker
                this_param, Microsoft.CodeAnalysis.CSharp.BoundPattern
                pattern)
                {
                    this_param.VisitPatternForRewriting(pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 4170, 4203);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10904_4347_4355(Microsoft.CodeAnalysis.CSharp.BoundConstantPattern
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 4347, 4355);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10904_4347_4369(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 4347, 4369);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10904_4373_4391()
                {
                    var return_v = ConstantValue.Null;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 4373, 4391);
                    return return_v;
                }


                int
                f_10904_4661_4750(Microsoft.CodeAnalysis.CSharp.NullableWalker
                this_param, int
                slot, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                expressionType, ref Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState
                state, bool
                markDependentSlotsNotNull)
                {
                    this_param.LearnFromNullTest(slot, expressionType, ref state, markDependentSlotsNotNull: markDependentSlotsNotNull);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 4661, 4750);
                    return 0;
                }


                bool
                f_10904_5105_5129(Microsoft.CodeAnalysis.CSharp.BoundTypePattern
                this_param)
                {
                    var return_v = this_param.IsExplicitNotNullTest;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 5105, 5129);
                    return return_v;
                }


                int
                f_10904_5179_5268(Microsoft.CodeAnalysis.CSharp.NullableWalker
                this_param, int
                slot, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                expressionType, ref Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState
                state, bool
                markDependentSlotsNotNull)
                {
                    this_param.LearnFromNullTest(slot, expressionType, ref state, markDependentSlotsNotNull: markDependentSlotsNotNull);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 5179, 5268);
                    return 0;
                }


                bool
                f_10904_5421_5445(Microsoft.CodeAnalysis.CSharp.BoundRecursivePattern
                this_param)
                {
                    var return_v = this_param.IsExplicitNotNullTest;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 5421, 5445);
                    return return_v;
                }


                int
                f_10904_5503_5592(Microsoft.CodeAnalysis.CSharp.NullableWalker
                this_param, int
                slot, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                expressionType, ref Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState
                state, bool
                markDependentSlotsNotNull)
                {
                    this_param.LearnFromNullTest(slot, expressionType, ref state, markDependentSlotsNotNull: markDependentSlotsNotNull);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 5503, 5592);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10904_5745_5765(Microsoft.CodeAnalysis.CSharp.BoundRecursivePattern
                this_param)
                {
                    var return_v = this_param.DeconstructMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 5745, 5765);
                    return return_v;
                }


                bool
                f_10904_5777_5805_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 5777, 5805);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                f_10904_5878_5901(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TupleElements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 5878, 5901);
                    return return_v;
                }


                int
                f_10904_5952_6028(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 5952, 6028);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSubpattern>
                f_10904_6129_6146(Microsoft.CodeAnalysis.CSharp.BoundRecursivePattern
                this_param)
                {
                    var return_v = this_param.Deconstruction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 6129, 6146);
                    return return_v;
                }


                int
                f_10904_6277_6312(Microsoft.CodeAnalysis.CSharp.NullableWalker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                symbol, int
                containingSlot)
                {
                    var return_v = this_param.GetOrCreateSlot((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, containingSlot);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 6277, 6312);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10904_6314_6326(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 6314, 6326);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundPattern
                f_10904_6328_6340(Microsoft.CodeAnalysis.CSharp.BoundSubpattern
                this_param)
                {
                    var return_v = this_param.Pattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 6328, 6340);
                    return return_v;
                }


                int
                f_10904_6252_6341(Microsoft.CodeAnalysis.CSharp.NullableWalker
                this_param, int
                inputSlot, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                inputType, Microsoft.CodeAnalysis.CSharp.BoundPattern
                pattern)
                {
                    this_param.LearnFromAnyNullPatterns(inputSlot, inputType, pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 6252, 6341);
                    return 0;
                }


                bool
                f_10904_6478_6502_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 6478, 6502);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSubpattern>
                f_10904_6701_6714(Microsoft.CodeAnalysis.CSharp.BoundRecursivePattern
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 6701, 6714);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10904_6768_6779(Microsoft.CodeAnalysis.CSharp.BoundSubpattern
                this_param)
                {
                    var return_v = this_param.Symbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 6768, 6779);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10904_6883_6904(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 6883, 6904);
                    return return_v;
                }


                bool
                f_10904_6883_6956(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = this_param.Equals(t2, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 6883, 6956);
                    return return_v;
                }


                int
                f_10904_7055_7089(Microsoft.CodeAnalysis.CSharp.NullableWalker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, int
                containingSlot)
                {
                    var return_v = this_param.GetOrCreateSlot(symbol, containingSlot);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 7055, 7089);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10904_7091_7119(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.GetTypeOrReturnType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 7091, 7119);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundPattern
                f_10904_7126_7138(Microsoft.CodeAnalysis.CSharp.BoundSubpattern
                this_param)
                {
                    var return_v = this_param.Pattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 7126, 7138);
                    return return_v;
                }


                int
                f_10904_7030_7139(Microsoft.CodeAnalysis.CSharp.NullableWalker
                this_param, int
                inputSlot, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                inputType, Microsoft.CodeAnalysis.CSharp.BoundPattern
                pattern)
                {
                    this_param.LearnFromAnyNullPatterns(inputSlot, inputType, pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 7030, 7139);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundPattern
                f_10904_7398_7407(Microsoft.CodeAnalysis.CSharp.BoundNegatedPattern
                this_param)
                {
                    var return_v = this_param.Negated;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 7398, 7407);
                    return return_v;
                }


                int
                f_10904_7351_7408(Microsoft.CodeAnalysis.CSharp.NullableWalker
                this_param, int
                inputSlot, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                inputType, Microsoft.CodeAnalysis.CSharp.BoundPattern
                pattern)
                {
                    this_param.LearnFromAnyNullPatterns(inputSlot, inputType, pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 7351, 7408);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundPattern
                f_10904_7550_7556(Microsoft.CodeAnalysis.CSharp.BoundBinaryPattern
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 7550, 7556);
                    return return_v;
                }


                int
                f_10904_7503_7557(Microsoft.CodeAnalysis.CSharp.NullableWalker
                this_param, int
                inputSlot, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                inputType, Microsoft.CodeAnalysis.CSharp.BoundPattern
                pattern)
                {
                    this_param.LearnFromAnyNullPatterns(inputSlot, inputType, pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 7503, 7557);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundPattern
                f_10904_7627_7634(Microsoft.CodeAnalysis.CSharp.BoundBinaryPattern
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 7627, 7634);
                    return return_v;
                }


                int
                f_10904_7580_7635(Microsoft.CodeAnalysis.CSharp.NullableWalker
                this_param, int
                inputSlot, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                inputType, Microsoft.CodeAnalysis.CSharp.BoundPattern
                pattern)
                {
                    this_param.LearnFromAnyNullPatterns(inputSlot, inputType, pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 7580, 7635);
                    return 0;
                }


                System.Exception
                f_10904_7718_7761(Microsoft.CodeAnalysis.CSharp.BoundPattern
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 7718, 7761);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10904, 3769, 7788);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10904, 3769, 7788);
            }
        }

        protected override (LocalState initialState, LocalState afterSwitchState) VisitSwitchStatementDispatch(BoundSwitchStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10904, 7800, 9891);
                (Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState state, bool believedReachable) s1 = default((Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState state, bool believedReachable));
                (Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState state, bool believedReachable) stateAndReachable = default((Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState state, bool believedReachable));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 8019, 8133);

                int
                slot = (DynAbs.Tracing.TraceSender.Conditional_F1(10904, 8030, 8058) || ((f_10904_8030_8058(f_10904_8030_8045(node)) && DynAbs.Tracing.TraceSender.Conditional_F2(10904, 8061, 8104)) || DynAbs.Tracing.TraceSender.Conditional_F3(10904, 8107, 8132))) ? f_10904_8061_8104(this, f_10904_8088_8103(node)) : f_10904_8107_8132(this, f_10904_8116_8131(node))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 8147, 8555) || true) && (slot > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10904, 8147, 8555);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 8193, 8238);

                    var
                    originalInputType = f_10904_8217_8237(f_10904_8217_8232(node))
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 8256, 8540);
                        foreach (var section in f_10904_8280_8299_I(f_10904_8280_8299(node)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10904, 8256, 8540);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 8341, 8521);
                                foreach (var label in f_10904_8363_8383_I(f_10904_8363_8383(section)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10904, 8341, 8521);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 8433, 8498);

                                    f_10904_8433_8497(this, slot, originalInputType, f_10904_8483_8496(label));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10904, 8341, 8521);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10904, 1, 181);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10904, 1, 181);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10904, 8256, 8540);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10904, 1, 285);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10904, 1, 285);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10904, 8147, 8555);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 8607, 8667);

                var
                expressionState = f_10904_8629_8666(this, f_10904_8650_8665(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 8681, 8726);

                LocalState
                initialState = this.State.Clone()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 8742, 8774);

                f_10904_8742_8773(this, f_10904_8756_8772(node));
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 8788, 9013);
                    foreach (var section in f_10904_8812_8831_I(f_10904_8812_8831(node)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10904, 8788, 9013);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 8968, 8998);

                        f_10904_8968_8997(this, f_10904_8982_8996(section));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10904, 8788, 9013);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10904, 1, 226);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10904, 1, 226);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 9029, 9153);

                var
                labelStateMap = f_10904_9049_9152(this, node.Syntax, f_10904_9083_9099(node), f_10904_9101_9116(node), expressionState, ref initialState)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 9167, 9635);
                    foreach (var section in f_10904_9191_9210_I(f_10904_9191_9210(node)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10904, 9167, 9635);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 9244, 9620);
                            foreach (var label in f_10904_9266_9286_I(f_10904_9266_9286(section)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10904, 9244, 9620);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 9328, 9458);

                                var
                                labelResult = (DynAbs.Tracing.TraceSender.Conditional_F1(10904, 9346, 9396) || ((f_10904_9346_9396(labelStateMap, f_10904_9372_9383(label), out s1) && DynAbs.Tracing.TraceSender.Conditional_F2(10904, 9399, 9401)) || DynAbs.Tracing.TraceSender.Conditional_F3(10904, 9404, 9457))) ? s1 : (state: f_10904_9412_9430(this), believedReachable: false)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 9480, 9508);

                                f_10904_9480_9507(this, labelResult.state);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 9530, 9601);

                                f_10904_9530_9600(f_10904_9530_9545(), f_10904_9550_9599(label, this.State, f_10904_9587_9598(label)));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10904, 9244, 9620);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10904, 1, 377);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10904, 1, 377);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10904, 9167, 9635);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10904, 1, 469);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10904, 1, 469);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 9651, 9791);

                var
                afterSwitchState = (DynAbs.Tracing.TraceSender.Conditional_F1(10904, 9674, 9743) || ((f_10904_9674_9743(labelStateMap, f_10904_9700_9715(node), out stateAndReachable) && DynAbs.Tracing.TraceSender.Conditional_F2(10904, 9746, 9769)) || DynAbs.Tracing.TraceSender.Conditional_F3(10904, 9772, 9790))) ? stateAndReachable.state : f_10904_9772_9790(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 9805, 9826);

                f_10904_9805_9825(labelStateMap);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 9840, 9880);

                return (initialState, afterSwitchState);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10904, 7800, 9891);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10904_8030_8045(Microsoft.CodeAnalysis.CSharp.BoundSwitchStatement
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 8030, 8045);
                    return return_v;
                }


                bool
                f_10904_8030_8058(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.IsSuppressed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 8030, 8058);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10904_8088_8103(Microsoft.CodeAnalysis.CSharp.BoundSwitchStatement
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 8088, 8103);
                    return return_v;
                }


                int
                f_10904_8061_8104(Microsoft.CodeAnalysis.CSharp.NullableWalker
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.GetOrCreatePlaceholderSlot(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 8061, 8104);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10904_8116_8131(Microsoft.CodeAnalysis.CSharp.BoundSwitchStatement
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 8116, 8131);
                    return return_v;
                }


                int
                f_10904_8107_8132(Microsoft.CodeAnalysis.CSharp.NullableWalker
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.MakeSlot(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 8107, 8132);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10904_8217_8232(Microsoft.CodeAnalysis.CSharp.BoundSwitchStatement
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 8217, 8232);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10904_8217_8237(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 8217, 8237);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchSection>
                f_10904_8280_8299(Microsoft.CodeAnalysis.CSharp.BoundSwitchStatement
                this_param)
                {
                    var return_v = this_param.SwitchSections;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 8280, 8299);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel>
                f_10904_8363_8383(Microsoft.CodeAnalysis.CSharp.BoundSwitchSection
                this_param)
                {
                    var return_v = this_param.SwitchLabels;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 8363, 8383);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundPattern
                f_10904_8483_8496(Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel
                this_param)
                {
                    var return_v = this_param.Pattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 8483, 8496);
                    return return_v;
                }


                int
                f_10904_8433_8497(Microsoft.CodeAnalysis.CSharp.NullableWalker
                this_param, int
                inputSlot, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                inputType, Microsoft.CodeAnalysis.CSharp.BoundPattern
                pattern)
                {
                    this_param.LearnFromAnyNullPatterns(inputSlot, inputType, pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 8433, 8497);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel>
                f_10904_8363_8383_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 8363, 8383);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchSection>
                f_10904_8280_8299_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchSection>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 8280, 8299);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10904_8650_8665(Microsoft.CodeAnalysis.CSharp.BoundSwitchStatement
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 8650, 8665);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithState
                f_10904_8629_8666(Microsoft.CodeAnalysis.CSharp.NullableWalker
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.VisitRvalueWithState(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 8629, 8666);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10904_8756_8772(Microsoft.CodeAnalysis.CSharp.BoundSwitchStatement
                this_param)
                {
                    var return_v = this_param.InnerLocals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 8756, 8772);
                    return return_v;
                }


                int
                f_10904_8742_8773(Microsoft.CodeAnalysis.CSharp.NullableWalker
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals)
                {
                    this_param.DeclareLocals(locals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 8742, 8773);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchSection>
                f_10904_8812_8831(Microsoft.CodeAnalysis.CSharp.BoundSwitchStatement
                this_param)
                {
                    var return_v = this_param.SwitchSections;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 8812, 8831);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10904_8982_8996(Microsoft.CodeAnalysis.CSharp.BoundSwitchSection
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 8982, 8996);
                    return return_v;
                }


                int
                f_10904_8968_8997(Microsoft.CodeAnalysis.CSharp.NullableWalker
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals)
                {
                    this_param.DeclareLocals(locals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 8968, 8997);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchSection>
                f_10904_8812_8831_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchSection>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 8812, 8831);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
                f_10904_9083_9099(Microsoft.CodeAnalysis.CSharp.BoundSwitchStatement
                this_param)
                {
                    var return_v = this_param.DecisionDag;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 9083, 9099);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10904_9101_9116(Microsoft.CodeAnalysis.CSharp.BoundSwitchStatement
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 9101, 9116);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol, (Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState state, bool believedReachable)>
                f_10904_9049_9152(Microsoft.CodeAnalysis.CSharp.NullableWalker
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
                decisionDag, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithState
                expressionType, ref Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState
                initialState)
                {
                    var return_v = this_param.LearnFromDecisionDag(node, decisionDag, expression, expressionType, ref initialState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 9049, 9152);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchSection>
                f_10904_9191_9210(Microsoft.CodeAnalysis.CSharp.BoundSwitchStatement
                this_param)
                {
                    var return_v = this_param.SwitchSections;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 9191, 9210);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel>
                f_10904_9266_9286(Microsoft.CodeAnalysis.CSharp.BoundSwitchSection
                this_param)
                {
                    var return_v = this_param.SwitchLabels;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 9266, 9286);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10904_9372_9383(Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 9372, 9383);
                    return return_v;
                }


                bool
                f_10904_9346_9396(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol, (Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState state, bool believedReachable)>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                key, out (Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState state, bool believedReachable)
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 9346, 9396);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState
                f_10904_9412_9430(Microsoft.CodeAnalysis.CSharp.NullableWalker
                this_param)
                {
                    var return_v = this_param.UnreachableState();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 9412, 9430);
                    return return_v;
                }


                int
                f_10904_9480_9507(Microsoft.CodeAnalysis.CSharp.NullableWalker
                this_param, Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState
                newState)
                {
                    this_param.SetState(newState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 9480, 9507);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState, Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalFunctionState>.PendingBranch>
                f_10904_9530_9545()
                {
                    var return_v = PendingBranches;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 9530, 9545);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10904_9587_9598(Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 9587, 9598);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState, Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalFunctionState>.PendingBranch
                f_10904_9550_9599(Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel
                branch, Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState
                state, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState, Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalFunctionState>.PendingBranch((Microsoft.CodeAnalysis.CSharp.BoundNode)branch, state, label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 9550, 9599);
                    return return_v;
                }


                int
                f_10904_9530_9600(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState, Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalFunctionState>.PendingBranch>
                this_param, Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState, Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalFunctionState>.PendingBranch
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 9530, 9600);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel>
                f_10904_9266_9286_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 9266, 9286);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchSection>
                f_10904_9191_9210_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchSection>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 9191, 9210);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                f_10904_9700_9715(Microsoft.CodeAnalysis.CSharp.BoundSwitchStatement
                this_param)
                {
                    var return_v = this_param.BreakLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 9700, 9715);
                    return return_v;
                }


                bool
                f_10904_9674_9743(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol, (Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState state, bool believedReachable)>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                key, out (Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState state, bool believedReachable)
                value)
                {
                    var return_v = this_param.TryGetValue((Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 9674, 9743);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState
                f_10904_9772_9790(Microsoft.CodeAnalysis.CSharp.NullableWalker
                this_param)
                {
                    var return_v = this_param.UnreachableState();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 9772, 9790);
                    return return_v;
                }


                int
                f_10904_9805_9825(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol, (Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState state, bool believedReachable)>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 9805, 9825);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10904, 7800, 9891);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10904, 7800, 9891);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override void VisitSwitchSection(BoundSwitchSection node, bool isLastSection)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10904, 9903, 10379);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 10015, 10045);

                f_10904_10015_10044(this, node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 10059, 10088);

                f_10904_10059_10087(this, f_10904_10068_10086(this));
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 10102, 10327);
                    foreach (var label in f_10904_10124_10141_I(f_10904_10124_10141(node)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10904, 10102, 10327);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 10175, 10206);

                        f_10904_10175_10205(this, label);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 10224, 10264);

                        f_10904_10224_10263(this, f_10904_10249_10262(label));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 10282, 10312);

                        f_10904_10282_10311(this, f_10904_10293_10304(label), node);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10904, 10102, 10327);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10904, 1, 226);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10904, 1, 226);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 10343, 10368);

                f_10904_10343_10367(this, node);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10904, 9903, 10379);

                int
                f_10904_10015_10044(Microsoft.CodeAnalysis.CSharp.NullableWalker
                this_param, Microsoft.CodeAnalysis.CSharp.BoundSwitchSection
                node)
                {
                    this_param.TakeIncrementalSnapshot((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 10015, 10044);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState
                f_10904_10068_10086(Microsoft.CodeAnalysis.CSharp.NullableWalker
                this_param)
                {
                    var return_v = this_param.UnreachableState();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 10068, 10086);
                    return return_v;
                }


                int
                f_10904_10059_10087(Microsoft.CodeAnalysis.CSharp.NullableWalker
                this_param, Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState
                newState)
                {
                    this_param.SetState(newState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 10059, 10087);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel>
                f_10904_10124_10141(Microsoft.CodeAnalysis.CSharp.BoundSwitchSection
                this_param)
                {
                    var return_v = this_param.SwitchLabels;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 10124, 10141);
                    return return_v;
                }


                int
                f_10904_10175_10205(Microsoft.CodeAnalysis.CSharp.NullableWalker
                this_param, Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel
                node)
                {
                    this_param.TakeIncrementalSnapshot((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 10175, 10205);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundPattern
                f_10904_10249_10262(Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel
                this_param)
                {
                    var return_v = this_param.Pattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 10249, 10262);
                    return return_v;
                }


                int
                f_10904_10224_10263(Microsoft.CodeAnalysis.CSharp.NullableWalker
                this_param, Microsoft.CodeAnalysis.CSharp.BoundPattern
                pattern)
                {
                    this_param.VisitPatternForRewriting(pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 10224, 10263);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10904_10293_10304(Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 10293, 10304);
                    return return_v;
                }


                int
                f_10904_10282_10311(Microsoft.CodeAnalysis.CSharp.NullableWalker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label, Microsoft.CodeAnalysis.CSharp.BoundSwitchSection
                node)
                {
                    this_param.VisitLabel(label, (Microsoft.CodeAnalysis.CSharp.BoundStatement)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 10282, 10311);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel>
                f_10904_10124_10141_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 10124, 10141);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10904_10343_10367(Microsoft.CodeAnalysis.CSharp.NullableWalker
                this_param, Microsoft.CodeAnalysis.CSharp.BoundSwitchSection
                node)
                {
                    var return_v = this_param.VisitStatementList((Microsoft.CodeAnalysis.CSharp.BoundStatementList)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 10343, 10367);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10904, 9903, 10379);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10904, 9903, 10379);
            }
        }

        private PooledDictionary<LabelSymbol, (LocalState state, bool believedReachable)>
            LearnFromDecisionDag(
            SyntaxNode node,
            BoundDecisionDag decisionDag,
            BoundExpression expression,
            TypeWithState expressionType,
            ref LocalState initialState)
        {
            // We reuse the slot at the beginning of a switch (or is-pattern expression), pretending that we are
            // not copying the input to evaluate the patterns.  In this way we infer non-nullability of the original
            // variable's parts based on matched pattern parts.  Mutations in `when` clauses can show the inaccuracy
            // of analysis based on this choice.
            var rootTemp = BoundDagTemp.ForOriginalInput(expression);
            int originalInputSlot = MakeSlot(expression);
            if (originalInputSlot <= 0)
            {
                originalInputSlot = makeDagTempSlot(expressionType.ToTypeWithAnnotations(compilation), rootTemp);
                initialState[originalInputSlot] = expressionType.State;
            }

            var tempMap = PooledDictionary<BoundDagTemp, (int slot, TypeSymbol type)>.GetInstance();
            Debug.Assert(originalInputSlot > 0);
            Debug.Assert(isDerivedType(NominalSlotType(originalInputSlot), expressionType.Type));
            tempMap.Add(rootTemp, (originalInputSlot, expressionType.Type));

            var nodeStateMap = PooledDictionary<BoundDecisionDagNode, (LocalState state, bool believedReachable)>.GetInstance();
            nodeStateMap.Add(decisionDag.RootNode, (state: initialState.Clone(), believedReachable: true));

            var labelStateMap = PooledDictionary<LabelSymbol, (LocalState state, bool believedReachable)>.GetInstance();

            foreach (var dagNode in decisionDag.TopologicallySortedNodes)
            {
                bool found = nodeStateMap.TryGetValue(dagNode, out var nodeStateAndBelievedReachable);
                Debug.Assert(found); // the topologically sorted nodes should contain only reachable nodes
                (LocalState nodeState, bool nodeBelievedReachable) = nodeStateAndBelievedReachable;
                SetState(nodeState);

                switch (dagNode)
                {
                    case BoundEvaluationDecisionDagNode p:
                        {
                            var evaluation = p.Evaluation;
                            (int inputSlot, TypeSymbol inputType) = tempMap.TryGetValue(evaluation.Input, out var slotAndType) ? slotAndType : throw ExceptionUtilities.Unreachable;
                            Debug.Assert(inputSlot > 0);
                            var inputState = this.State[inputSlot];

                            switch (evaluation)
                            {
                                case BoundDagDeconstructEvaluation e:
                                    {
                                        // https://github.com/dotnet/roslyn/issues/34232
                                        // We may need to recompute the Deconstruct method for a deconstruction if
                                        // the receiver type has changed (e.g. its nested nullability).
                                        var method = e.DeconstructMethod;
                                        int extensionExtra = method.RequiresInstanceReceiver ? 0 : 1;
                                        for (int i = 0; i < method.ParameterCount - extensionExtra; i++)
                                        {
                                            var parameterType = method.Parameters[i + extensionExtra].TypeWithAnnotations;
                                            var output = new BoundDagTemp(e.Syntax, parameterType.Type, e, i);
                                            int outputSlot = makeDagTempSlot(parameterType, output);
                                            Debug.Assert(outputSlot > 0);
                                            addToTempMap(output, outputSlot, parameterType.Type);
                                        }
                                        break;
                                    }
                                case BoundDagTypeEvaluation e:
                                    {
                                        var output = new BoundDagTemp(e.Syntax, e.Type, e);
                                        HashSet<DiagnosticInfo> discardedDiagnostics = null;
                                        int outputSlot;
                                        switch (_conversions.WithNullability(false).ClassifyConversionFromType(inputType, e.Type, ref discardedDiagnostics).Kind)
                                        {
                                            case ConversionKind.Identity:
                                            case ConversionKind.ImplicitReference:
                                                outputSlot = inputSlot;
                                                break;
                                            case ConversionKind.ExplicitNullable when AreNullableAndUnderlyingTypes(inputType, e.Type, out _):
                                                outputSlot = GetNullableOfTValueSlot(inputType, inputSlot, out _, forceSlotEvenIfEmpty: true);
                                                if (outputSlot < 0)
                                                    goto default;
                                                break;
                                            default:
                                                outputSlot = makeDagTempSlot(TypeWithAnnotations.Create(e.Type, NullableAnnotation.NotAnnotated), output);
                                                break;
                                        }
                                        State[outputSlot] = NullableFlowState.NotNull;
                                        addToTempMap(output, outputSlot, e.Type);
                                        break;
                                    }
                                case BoundDagFieldEvaluation e:
                                    {
                                        Debug.Assert(inputSlot > 0);
                                        var field = (FieldSymbol)AsMemberOfType(inputType, e.Field);
                                        var type = field.TypeWithAnnotations;
                                        var output = new BoundDagTemp(e.Syntax, type.Type, e);
                                        int outputSlot = GetOrCreateSlot(field, inputSlot, forceSlotEvenIfEmpty: true);
                                        if (outputSlot <= 0)
                                        {
                                            outputSlot = makeDagTempSlot(type, output);
                                        }
                                        Debug.Assert(outputSlot > 0);
                                        addToTempMap(output, outputSlot, type.Type);
                                        break;
                                    }
                                case BoundDagPropertyEvaluation e:
                                    {
                                        Debug.Assert(inputSlot > 0);
                                        var property = (PropertySymbol)AsMemberOfType(inputType, e.Property);
                                        var type = property.TypeWithAnnotations;
                                        var output = new BoundDagTemp(e.Syntax, type.Type, e);
                                        int outputSlot = GetOrCreateSlot(property, inputSlot, forceSlotEvenIfEmpty: true);
                                        if (outputSlot <= 0)
                                        {
                                            outputSlot = makeDagTempSlot(type, output);
                                        }
                                        Debug.Assert(outputSlot > 0);
                                        addToTempMap(output, outputSlot, type.Type);
                                        break;
                                    }
                                case BoundDagIndexEvaluation e:
                                    {
                                        var type = TypeWithAnnotations.Create(e.Property.Type, NullableAnnotation.Annotated);
                                        var output = new BoundDagTemp(e.Syntax, type.Type, e);
                                        int outputSlot = makeDagTempSlot(type, output);
                                        Debug.Assert(outputSlot > 0);
                                        addToTempMap(output, outputSlot, type.Type);
                                        break;
                                    }
                                default:
                                    throw ExceptionUtilities.UnexpectedValue(p.Evaluation.Kind);
                            }
                            gotoNode(p.Next, this.State, nodeBelievedReachable);
                            break;
                        }
                    case BoundTestDecisionDagNode p:
                        {
                            var test = p.Test;
                            bool foundTemp = tempMap.TryGetValue(test.Input, out var slotAndType);
                            Debug.Assert(foundTemp);

                            (int inputSlot, TypeSymbol inputType) = slotAndType;
                            var inputState = this.State[inputSlot];
                            Split();
                            switch (test)
                            {
                                case BoundDagTypeTest t:
                                    if (inputSlot > 0)
                                    {
                                        learnFromNonNullTest(inputSlot, ref this.StateWhenTrue);
                                    }
                                    gotoNode(p.WhenTrue, this.StateWhenTrue, nodeBelievedReachable);
                                    gotoNode(p.WhenFalse, this.StateWhenFalse, nodeBelievedReachable);
                                    break;
                                case BoundDagNonNullTest t:
                                    if (inputSlot > 0)
                                    {
                                        MarkDependentSlotsNotNull(inputSlot, inputType, ref this.StateWhenFalse);
                                        if (t.IsExplicitTest)
                                        {
                                            LearnFromNullTest(inputSlot, inputType, ref this.StateWhenFalse, markDependentSlotsNotNull: false);
                                        }
                                        learnFromNonNullTest(inputSlot, ref this.StateWhenTrue);
                                    }
                                    gotoNode(p.WhenTrue, this.StateWhenTrue, nodeBelievedReachable);
                                    gotoNode(p.WhenFalse, this.StateWhenFalse, nodeBelievedReachable & inputState.MayBeNull());
                                    break;
                                case BoundDagExplicitNullTest _:
                                    if (inputSlot > 0)
                                    {
                                        LearnFromNullTest(inputSlot, inputType, ref this.StateWhenTrue, markDependentSlotsNotNull: true);
                                        learnFromNonNullTest(inputSlot, ref this.StateWhenFalse);
                                    }
                                    gotoNode(p.WhenTrue, this.StateWhenTrue, nodeBelievedReachable);
                                    gotoNode(p.WhenFalse, this.StateWhenFalse, nodeBelievedReachable);
                                    break;
                                case BoundDagValueTest t:
                                    Debug.Assert(t.Value != ConstantValue.Null);
                                    if (inputSlot > 0)
                                    {
                                        learnFromNonNullTest(inputSlot, ref this.StateWhenTrue);
                                    }
                                    gotoNode(p.WhenTrue, this.StateWhenTrue, nodeBelievedReachable);
                                    gotoNode(p.WhenFalse, this.StateWhenFalse, nodeBelievedReachable);
                                    break;
                                case BoundDagRelationalTest _:
                                    if (inputSlot > 0)
                                    {
                                        learnFromNonNullTest(inputSlot, ref this.StateWhenTrue);
                                    }
                                    gotoNode(p.WhenTrue, this.StateWhenTrue, nodeBelievedReachable);
                                    gotoNode(p.WhenFalse, this.StateWhenFalse, nodeBelievedReachable);
                                    break;
                                default:
                                    throw ExceptionUtilities.UnexpectedValue(test.Kind);
                            }
                            break;
                        }
                    case BoundLeafDecisionDagNode d:
                        // We have one leaf decision dag node per reachable label
                        labelStateMap.Add(d.Label, (this.State, nodeBelievedReachable));
                        break;
                    case BoundWhenDecisionDagNode w:
                        // bind the pattern variables, inferring their types as well
                        foreach (var binding in w.Bindings)
                        {
                            var variableAccess = binding.VariableAccess;
                            var tempSource = binding.TempContainingValue;
                            var foundTemp = tempMap.TryGetValue(tempSource, out var tempSlotAndType);
                            if (foundTemp) // in erroneous programs, we might not have seen a temp defined.
                            {
                                var (tempSlot, tempType) = tempSlotAndType;
                                var tempState = this.State[tempSlot];
                                if (variableAccess is BoundLocal { LocalSymbol: SourceLocalSymbol local } boundLocal)
                                {
                                    var value = TypeWithState.Create(tempType, tempState);
                                    var inferredType = value.ToTypeWithAnnotations(compilation, asAnnotatedType: boundLocal.DeclarationKind == BoundLocalDeclarationKind.WithInferredType);
                                    if (_variables.TryGetType(local, out var existingType))
                                    {
                                        // merge inferred nullable annotation from different branches of the decision tree
                                        inferredType = TypeWithAnnotations.Create(inferredType.Type, existingType.NullableAnnotation.Join(inferredType.NullableAnnotation));
                                    }
                                    _variables.SetType(local, inferredType);

                                    int localSlot = GetOrCreateSlot(local, forceSlotEvenIfEmpty: true);
                                    if (localSlot > 0)
                                    {
                                        this.State[localSlot] = tempState;
                                    }
                                }
                                else
                                {
                                    // https://github.com/dotnet/roslyn/issues/34144 perform inference for top-level var-declared fields in scripts
                                }
                            }
                        }

                        if (w.WhenExpression != null && w.WhenExpression.ConstantValue != ConstantValue.True)
                        {
                            VisitCondition(w.WhenExpression);
                            Debug.Assert(this.IsConditionalState);
                            gotoNode(w.WhenTrue, this.StateWhenTrue, nodeBelievedReachable);
                            gotoNode(w.WhenFalse, this.StateWhenFalse, nodeBelievedReachable);
                        }
                        else
                        {
                            Debug.Assert(w.WhenFalse is null);
                            gotoNode(w.WhenTrue, this.State, nodeBelievedReachable);
                        }
                        break;
                    default:
                        throw ExceptionUtilities.UnexpectedValue(dagNode.Kind);
                }
            }

            SetUnreachable(); // the decision dag is always complete (no fall-through)
            tempMap.Free();
            nodeStateMap.Free();
            return labelStateMap;

            void learnFromNonNullTest(int inputSlot, ref LocalState state)
            {
                LearnFromNonNullTest(inputSlot, ref state);
                if (inputSlot == originalInputSlot)
                    LearnFromNonNullTest(expression, ref state);
            }

            void addToTempMap(BoundDagTemp output, int slot, TypeSymbol type)
            {
                // We need to track all dag temps, so there should be a slot
                Debug.Assert(slot > 0);
                if (tempMap.TryGetValue(output, out var outputSlotAndType))
                {
                    // The dag temp has already been allocated on another branch of the dag
                    Debug.Assert(outputSlotAndType.slot == slot);
                    Debug.Assert(isDerivedType(outputSlotAndType.type, type));
                }
                else
                {
                    Debug.Assert(NominalSlotType(slot) is var slotType && (slotType.IsErrorType() || isDerivedType(slotType, type)));
                    tempMap.Add(output, (slot, type));
                }
            }

            bool isDerivedType(TypeSymbol derivedType, TypeSymbol baseType)
            {
                HashSet<DiagnosticInfo> discardedDiagnostics = null;
                if (derivedType.IsErrorType() || baseType.IsErrorType())
                    return true;

                return _conversions.WithNullability(false).ClassifyConversionFromType(derivedType, baseType, ref discardedDiagnostics).Kind switch
                {
                    ConversionKind.Identity => true,
                    ConversionKind.ImplicitReference => true,
                    ConversionKind.Boxing => true,
                    _ => false,
                };
            }

            void gotoNode(BoundDecisionDagNode node, LocalState state, bool believedReachable)
            {
                if (nodeStateMap.TryGetValue(node, out var stateAndReachable))
                {
                    Join(ref state, ref stateAndReachable.state);
                    believedReachable |= stateAndReachable.believedReachable;
                }

                nodeStateMap[node] = (state, believedReachable);
            }

            int makeDagTempSlot(TypeWithAnnotations type, BoundDagTemp temp)
            {
                object slotKey = (node, temp);
                return GetOrCreatePlaceholderSlot(slotKey, type);
            }
        }

        public override BoundNode VisitConvertedSwitchExpression(BoundConvertedSwitchExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10904, 30037, 30287);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 30155, 30193);

                bool
                inferType = f_10904_30172_30192_M(!node.WasTargetTyped)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 30207, 30250);

                f_10904_30207_30249(this, node, inferType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 30264, 30276);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10904, 30037, 30287);

                bool
                f_10904_30172_30192_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 30172, 30192);
                    return return_v;
                }


                int
                f_10904_30207_30249(Microsoft.CodeAnalysis.CSharp.NullableWalker
                this_param, Microsoft.CodeAnalysis.CSharp.BoundConvertedSwitchExpression
                node, bool
                inferType)
                {
                    this_param.VisitSwitchExpressionCore((Microsoft.CodeAnalysis.CSharp.BoundSwitchExpression)node, inferType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 30207, 30249);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10904, 30037, 30287);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10904, 30037, 30287);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitUnconvertedSwitchExpression(BoundUnconvertedSwitchExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10904, 30299, 30594);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 30508, 30557);

                f_10904_30508_30556(this, node, inferType: true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 30571, 30583);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10904, 30299, 30594);

                int
                f_10904_30508_30556(Microsoft.CodeAnalysis.CSharp.NullableWalker
                this_param, Microsoft.CodeAnalysis.CSharp.BoundUnconvertedSwitchExpression
                node, bool
                inferType)
                {
                    this_param.VisitSwitchExpressionCore((Microsoft.CodeAnalysis.CSharp.BoundSwitchExpression)node, inferType: inferType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 30508, 30556);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10904, 30299, 30594);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10904, 30299, 30594);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void VisitSwitchExpressionCore(BoundSwitchExpression node, bool inferType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10904, 30606, 36815);
                (Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState state, bool believedReachable) defaultLabelState = default((Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState state, bool believedReachable));
                bool requiresFalseWhenClause = default(bool);
                (Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState state, bool believedReachable) labelState = default((Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState state, bool believedReachable));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 30778, 30892);

                int
                slot = (DynAbs.Tracing.TraceSender.Conditional_F1(10904, 30789, 30817) || ((f_10904_30789_30817(f_10904_30789_30804(node)) && DynAbs.Tracing.TraceSender.Conditional_F2(10904, 30820, 30863)) || DynAbs.Tracing.TraceSender.Conditional_F3(10904, 30866, 30891))) ? f_10904_30820_30863(this, f_10904_30847_30862(node)) : f_10904_30866_30891(this, f_10904_30875_30890(node))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 30906, 31189) || true) && (slot > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10904, 30906, 31189);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 30952, 30997);

                    var
                    originalInputType = f_10904_30976_30996(f_10904_30976_30991(node))
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 31015, 31174);
                        foreach (var arm in f_10904_31035_31050_I(f_10904_31035_31050(node)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10904, 31015, 31174);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 31092, 31155);

                            f_10904_31092_31154(this, slot, originalInputType, f_10904_31142_31153(arm));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10904, 31015, 31174);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10904, 1, 160);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10904, 1, 160);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10904, 30906, 31189);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 31205, 31265);

                var
                expressionState = f_10904_31227_31264(this, f_10904_31248_31263(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 31279, 31401);

                var
                labelStateMap = f_10904_31299_31400(this, node.Syntax, f_10904_31333_31349(node), f_10904_31351_31366(node), expressionState, ref this.State)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 31415, 31449);

                var
                endState = f_10904_31430_31448(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 31465, 32536) || true) && (f_10904_31469_31496_M(!node.ReportedNotExhaustive) && (DynAbs.Tracing.TraceSender.Expression_True(10904, 31469, 31525) && f_10904_31500_31517(node) != null) && (DynAbs.Tracing.TraceSender.Expression_True(10904, 31469, 31617) && f_10904_31546_31617(labelStateMap, f_10904_31572_31589(node), out defaultLabelState)) && (DynAbs.Tracing.TraceSender.Expression_True(10904, 31469, 31656) && defaultLabelState.believedReachable))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10904, 31465, 32536);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 31690, 31724);

                    f_10904_31690_31723(this, defaultLabelState.state);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 31742, 31796);

                    var
                    nodes = f_10904_31754_31795(f_10904_31754_31770(node))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 31814, 31921);

                    var
                    leaf = f_10904_31825_31920(nodes.Where(n => n is BoundLeafDecisionDagNode leaf && leaf.Label == node.DefaultLabel))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 31939, 32147);

                    var
                    samplePattern = f_10904_31959_32146(f_10904_32028_32074(f_10904_32058_32073(node)), nodes, leaf, nullPaths: true, out requiresFalseWhenClause, out _)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 32165, 32327);

                    ErrorCode
                    warningCode = (DynAbs.Tracing.TraceSender.Conditional_F1(10904, 32189, 32212) || ((requiresFalseWhenClause && DynAbs.Tracing.TraceSender.Conditional_F2(10904, 32215, 32273)) || DynAbs.Tracing.TraceSender.Conditional_F3(10904, 32276, 32326))) ? ErrorCode.WRN_SwitchExpressionNotExhaustiveForNullWithWhen : ErrorCode.WRN_SwitchExpressionNotExhaustiveForNull
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 32345, 32521);

                    f_10904_32345_32520(this, warningCode, ((SwitchExpressionSyntax)node.Syntax).SwitchKeyword.GetLocation(), samplePattern);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10904, 31465, 32536);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 32618, 32661);

                int
                numSwitchArms = node.SwitchArms.Length
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 32675, 32745);

                var
                conversions = f_10904_32693_32744(numSwitchArms)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 32759, 32832);

                var
                resultTypes = f_10904_32777_32831(numSwitchArms)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 32846, 32921);

                var
                expressions = f_10904_32864_32920(numSwitchArms)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 32935, 33017);

                var
                placeholderBuilder = f_10904_32960_33016(numSwitchArms)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 33033, 34145);
                    foreach (var arm in f_10904_33053_33068_I(f_10904_33053_33068(node)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10904, 33033, 34145);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 33102, 33235);

                        f_10904_33102_33234(this, (DynAbs.Tracing.TraceSender.Conditional_F1(10904, 33111, 33193) || ((f_10904_33111_33133_M(!f_10904_33112_33123(arm).HasErrors) && (DynAbs.Tracing.TraceSender.Expression_True(10904, 33111, 33193) && f_10904_33137_33193(labelStateMap, f_10904_33163_33172(arm), out labelState)) && DynAbs.Tracing.TraceSender.Conditional_F2(10904, 33196, 33212)) || DynAbs.Tracing.TraceSender.Conditional_F3(10904, 33215, 33233))) ? labelState.state : f_10904_33215_33233(this));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 33363, 33392);

                        f_10904_33363_33391(this, arm);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 33410, 33448);

                        f_10904_33410_33447(this, f_10904_33435_33446(arm));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 33466, 33583);

                        (BoundExpression expression, Conversion conversion) = f_10904_33520_33582(f_10904_33537_33546(arm), includeExplicitConversions: false);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 33601, 33661);

                        f_10904_33601_33660(this, f_10904_33638_33647(arm), expression);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 33679, 33707);

                        f_10904_33679_33706(expressions, expression);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 33725, 33753);

                        f_10904_33725_33752(conversions, conversion);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 33771, 33818);

                        var
                        armType = f_10904_33785_33817(this, expression)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 33836, 33861);

                        f_10904_33836_33860(resultTypes, armType);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 33879, 33914);

                        f_10904_33879_33913(this, ref endState, ref this.State);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 34021, 34130);

                        f_10904_34021_34129(
                                        // Build placeholders for inference in order to preserve annotations.
                                        placeholderBuilder, f_10904_34044_34128(expression, armType.ToTypeWithAnnotations(compilation)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10904, 33033, 34145);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10904, 1, 1113);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10904, 1, 1113);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 34161, 34220);

                var
                placeholders = f_10904_34180_34219(placeholderBuilder)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 34234, 34284);

                HashSet<DiagnosticInfo>
                useSiteDiagnostics = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 34300, 34523);

                TypeSymbol
                inferredType =
                                ((DynAbs.Tracing.TraceSender.Conditional_F1(10904, 34344, 34353) || ((inferType && DynAbs.Tracing.TraceSender.Conditional_F2(10904, 34356, 34438)) || DynAbs.Tracing.TraceSender.Conditional_F3(10904, 34441, 34445))) ? f_10904_34356_34438(placeholders, _conversions, ref useSiteDiagnostics) : null)
                ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?>(10904, 34343, 34522) ?? f_10904_34471_34522_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10904_34471_34480(node), 10904, 34471, 34522).SetUnknownNullabilityForReferenceTypes()))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 34539, 34614);

                var
                inferredTypeWithAnnotations = TypeWithAnnotations.Create(inferredType)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 34761, 35306) || true) && (inferredType is not null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10904, 34761, 35306);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 34832, 34837);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 34823, 35291) || true) && (i < numSwitchArms)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 34858, 34861)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10904, 34823, 35291))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10904, 34823, 35291);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 34903, 34935);

                            var
                            expression = f_10904_34920_34934(expressions, i)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 34957, 35272);

                            resultTypes[i] = f_10904_34974_35271(this, conversionOpt: null, expression, f_10904_35023_35037(conversions, i), inferredTypeWithAnnotations, f_10904_35068_35082(resultTypes, i), checkConversion: true, fromExplicitCast: false, useLegacyWarnings: false, AssignmentKind.Assignment, reportRemainingWarnings: true, reportTopLevelWarnings: false);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10904, 1, 469);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10904, 1, 469);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10904, 34761, 35306);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 35322, 35389);

                var
                inferredState = f_10904_35342_35388(resultTypes)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 35403, 35470);

                var
                resultType = TypeWithState.Create(inferredType, inferredState)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 35486, 36564) || true) && (inferredType is not null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10904, 35486, 36564);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 35548, 35624);

                    inferredTypeWithAnnotations = resultType.ToTypeWithAnnotations(compilation);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 35642, 35829) || true) && (resultType.State == NullableFlowState.MaybeDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10904, 35642, 35829);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 35738, 35810);

                        inferredTypeWithAnnotations = inferredTypeWithAnnotations.AsAnnotated();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10904, 35642, 35829);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 35858, 35863);

                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 35849, 36549) || true) && (i < numSwitchArms)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 35884, 35887)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10904, 35849, 36549))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10904, 35849, 36549);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 35929, 35964);

                            var
                            nodeForSyntax = f_10904_35949_35963(expressions, i)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 35986, 36100);

                            var
                            conversionOpt = f_10904_36006_36030(f_10904_36006_36021(node)[i]) switch
                            {
                                BoundConversion c when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 36058, 36081) || true) && (c != nodeForSyntax) && (DynAbs.Tracing.TraceSender.Expression_True(10904, 36058, 36081) || true)
=> c,
                                _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 36088, 36097) && DynAbs.Tracing.TraceSender.Expression_True(10904, 36088, 36097))
=> null
                            }
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 36172, 36530);

                            _ = f_10904_36176_36529(this, conversionOpt, conversionOperand: nodeForSyntax, f_10904_36241_36255(conversions, i), targetTypeWithNullability: inferredTypeWithAnnotations, operandType: f_10904_36326_36340(resultTypes, i), checkConversion: true, fromExplicitCast: false, useLegacyWarnings: false, AssignmentKind.Assignment, reportRemainingWarnings: false, reportTopLevelWarnings: true);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10904, 1, 701);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10904, 1, 701);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10904, 35486, 36564);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 36580, 36599);

                f_10904_36580_36598(
                            conversions);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 36613, 36632);

                f_10904_36613_36631(resultTypes);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 36646, 36665);

                f_10904_36646_36664(expressions);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 36679, 36700);

                f_10904_36679_36699(labelStateMap);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 36714, 36733);

                f_10904_36714_36732(this, endState);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 36747, 36804);

                f_10904_36747_36803(this, node, resultType, inferredTypeWithAnnotations);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10904, 30606, 36815);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10904_30789_30804(Microsoft.CodeAnalysis.CSharp.BoundSwitchExpression
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 30789, 30804);
                    return return_v;
                }


                bool
                f_10904_30789_30817(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.IsSuppressed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 30789, 30817);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10904_30847_30862(Microsoft.CodeAnalysis.CSharp.BoundSwitchExpression
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 30847, 30862);
                    return return_v;
                }


                int
                f_10904_30820_30863(Microsoft.CodeAnalysis.CSharp.NullableWalker
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.GetOrCreatePlaceholderSlot(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 30820, 30863);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10904_30875_30890(Microsoft.CodeAnalysis.CSharp.BoundSwitchExpression
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 30875, 30890);
                    return return_v;
                }


                int
                f_10904_30866_30891(Microsoft.CodeAnalysis.CSharp.NullableWalker
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.MakeSlot(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 30866, 30891);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10904_30976_30991(Microsoft.CodeAnalysis.CSharp.BoundSwitchExpression
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 30976, 30991);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10904_30976_30996(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 30976, 30996);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm>
                f_10904_31035_31050(Microsoft.CodeAnalysis.CSharp.BoundSwitchExpression
                this_param)
                {
                    var return_v = this_param.SwitchArms;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 31035, 31050);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundPattern
                f_10904_31142_31153(Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm
                this_param)
                {
                    var return_v = this_param.Pattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 31142, 31153);
                    return return_v;
                }


                int
                f_10904_31092_31154(Microsoft.CodeAnalysis.CSharp.NullableWalker
                this_param, int
                inputSlot, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                inputType, Microsoft.CodeAnalysis.CSharp.BoundPattern
                pattern)
                {
                    this_param.LearnFromAnyNullPatterns(inputSlot, inputType, pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 31092, 31154);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm>
                f_10904_31035_31050_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 31035, 31050);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10904_31248_31263(Microsoft.CodeAnalysis.CSharp.BoundSwitchExpression
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 31248, 31263);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithState
                f_10904_31227_31264(Microsoft.CodeAnalysis.CSharp.NullableWalker
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.VisitRvalueWithState(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 31227, 31264);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
                f_10904_31333_31349(Microsoft.CodeAnalysis.CSharp.BoundSwitchExpression
                this_param)
                {
                    var return_v = this_param.DecisionDag;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 31333, 31349);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10904_31351_31366(Microsoft.CodeAnalysis.CSharp.BoundSwitchExpression
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 31351, 31366);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol, (Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState state, bool believedReachable)>
                f_10904_31299_31400(Microsoft.CodeAnalysis.CSharp.NullableWalker
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
                decisionDag, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithState
                expressionType, ref Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState
                initialState)
                {
                    var return_v = this_param.LearnFromDecisionDag(node, decisionDag, expression, expressionType, ref initialState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 31299, 31400);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState
                f_10904_31430_31448(Microsoft.CodeAnalysis.CSharp.NullableWalker
                this_param)
                {
                    var return_v = this_param.UnreachableState();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 31430, 31448);
                    return return_v;
                }


                bool
                f_10904_31469_31496_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 31469, 31496);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol?
                f_10904_31500_31517(Microsoft.CodeAnalysis.CSharp.BoundSwitchExpression
                this_param)
                {
                    var return_v = this_param.DefaultLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 31500, 31517);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10904_31572_31589(Microsoft.CodeAnalysis.CSharp.BoundSwitchExpression
                this_param)
                {
                    var return_v = this_param.DefaultLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 31572, 31589);
                    return return_v;
                }


                bool
                f_10904_31546_31617(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol, (Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState state, bool believedReachable)>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                key, out (Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState state, bool believedReachable)
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 31546, 31617);
                    return return_v;
                }


                int
                f_10904_31690_31723(Microsoft.CodeAnalysis.CSharp.NullableWalker
                this_param, Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState
                newState)
                {
                    this_param.SetState(newState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 31690, 31723);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
                f_10904_31754_31770(Microsoft.CodeAnalysis.CSharp.BoundSwitchExpression
                this_param)
                {
                    var return_v = this_param.DecisionDag;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 31754, 31770);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                f_10904_31754_31795(Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
                this_param)
                {
                    var return_v = this_param.TopologicallySortedNodes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 31754, 31795);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                f_10904_31825_31920(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                source)
                {
                    var return_v = source.First<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 31825, 31920);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10904_32058_32073(Microsoft.CodeAnalysis.CSharp.BoundSwitchExpression
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 32058, 32073);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                f_10904_32028_32074(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = BoundDagTemp.ForOriginalInput(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 32028, 32074);
                    return return_v;
                }


                string
                f_10904_31959_32146(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                rootIdentifier, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                nodes, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                targetNode, bool
                nullPaths, out bool
                requiresFalseWhenClause, out bool
                unnamedEnumValue)
                {
                    var return_v = PatternExplainer.SamplePatternForPathToDagNode(rootIdentifier, nodes, targetNode, nullPaths: nullPaths, out requiresFalseWhenClause, out unnamedEnumValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 31959, 32146);
                    return return_v;
                }


                int
                f_10904_32345_32520(Microsoft.CodeAnalysis.CSharp.NullableWalker
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, Microsoft.CodeAnalysis.Location
                location, params object[]
                arguments)
                {
                    this_param.ReportDiagnostic(errorCode, location, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 32345, 32520);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Conversion>
                f_10904_32693_32744(int
                capacity)
                {
                    var return_v = ArrayBuilder<Conversion>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 32693, 32744);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithState>
                f_10904_32777_32831(int
                capacity)
                {
                    var return_v = ArrayBuilder<TypeWithState>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 32777, 32831);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10904_32864_32920(int
                capacity)
                {
                    var return_v = ArrayBuilder<BoundExpression>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 32864, 32920);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10904_32960_33016(int
                capacity)
                {
                    var return_v = ArrayBuilder<BoundExpression>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 32960, 33016);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm>
                f_10904_33053_33068(Microsoft.CodeAnalysis.CSharp.BoundSwitchExpression
                this_param)
                {
                    var return_v = this_param.SwitchArms;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 33053, 33068);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundPattern
                f_10904_33112_33123(Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm
                this_param)
                {
                    var return_v = this_param.Pattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 33112, 33123);
                    return return_v;
                }


                bool
                f_10904_33111_33133_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 33111, 33133);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10904_33163_33172(Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 33163, 33172);
                    return return_v;
                }


                bool
                f_10904_33137_33193(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol, (Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState state, bool believedReachable)>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                key, out (Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState state, bool believedReachable)
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 33137, 33193);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState
                f_10904_33215_33233(Microsoft.CodeAnalysis.CSharp.NullableWalker
                this_param)
                {
                    var return_v = this_param.UnreachableState();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 33215, 33233);
                    return return_v;
                }


                int
                f_10904_33102_33234(Microsoft.CodeAnalysis.CSharp.NullableWalker
                this_param, Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState
                newState)
                {
                    this_param.SetState(newState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 33102, 33234);
                    return 0;
                }


                int
                f_10904_33363_33391(Microsoft.CodeAnalysis.CSharp.NullableWalker
                this_param, Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm
                node)
                {
                    this_param.TakeIncrementalSnapshot((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 33363, 33391);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundPattern
                f_10904_33435_33446(Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm
                this_param)
                {
                    var return_v = this_param.Pattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 33435, 33446);
                    return return_v;
                }


                int
                f_10904_33410_33447(Microsoft.CodeAnalysis.CSharp.NullableWalker
                this_param, Microsoft.CodeAnalysis.CSharp.BoundPattern
                pattern)
                {
                    this_param.VisitPatternForRewriting(pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 33410, 33447);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10904_33537_33546(Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 33537, 33546);
                    return return_v;
                }


                (Microsoft.CodeAnalysis.CSharp.BoundExpression expression, Microsoft.CodeAnalysis.CSharp.Conversion conversion)
                f_10904_33520_33582(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, bool
                includeExplicitConversions)
                {
                    var return_v = RemoveConversion(expr, includeExplicitConversions: includeExplicitConversions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 33520, 33582);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10904_33638_33647(Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 33638, 33647);
                    return return_v;
                }


                int
                f_10904_33601_33660(Microsoft.CodeAnalysis.CSharp.NullableWalker
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                conversionExpression, Microsoft.CodeAnalysis.CSharp.BoundExpression
                convertedNode)
                {
                    this_param.SnapshotWalkerThroughConversionGroup(conversionExpression, convertedNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 33601, 33660);
                    return 0;
                }


                int
                f_10904_33679_33706(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 33679, 33706);
                    return 0;
                }


                int
                f_10904_33725_33752(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Conversion>
                this_param, Microsoft.CodeAnalysis.CSharp.Conversion
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 33725, 33752);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithState
                f_10904_33785_33817(Microsoft.CodeAnalysis.CSharp.NullableWalker
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.VisitRvalueWithState(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 33785, 33817);
                    return return_v;
                }


                int
                f_10904_33836_33860(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithState>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithState
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 33836, 33860);
                    return 0;
                }


                bool
                f_10904_33879_33913(Microsoft.CodeAnalysis.CSharp.NullableWalker
                this_param, ref Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState
                self, ref Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState
                other)
                {
                    var return_v = this_param.Join(ref self, ref other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 33879, 33913);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10904_34044_34128(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type)
                {
                    var return_v = CreatePlaceholderIfNecessary(expr, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 34044, 34128);
                    return return_v;
                }


                int
                f_10904_34021_34129(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 34021, 34129);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm>
                f_10904_33053_33068_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 33053, 33068);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10904_34180_34219(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 34180, 34219);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10904_34356_34438(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                exprs, Microsoft.CodeAnalysis.CSharp.Conversions
                conversions, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = BestTypeInferrer.InferBestType(exprs, (Microsoft.CodeAnalysis.CSharp.ConversionsBase)conversions, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 34356, 34438);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10904_34471_34480(Microsoft.CodeAnalysis.CSharp.BoundSwitchExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 34471, 34480);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10904_34471_34522_I(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 34471, 34522);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10904_34920_34934(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 34920, 34934);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10904_35023_35037(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Conversion>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 35023, 35037);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithState
                f_10904_35068_35082(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithState>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 35068, 35082);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithState
                f_10904_34974_35271(Microsoft.CodeAnalysis.CSharp.NullableWalker
                this_param, Microsoft.CodeAnalysis.CSharp.BoundConversion?
                conversionOpt, Microsoft.CodeAnalysis.CSharp.BoundExpression
                conversionOperand, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                targetTypeWithNullability, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithState
                operandType, bool
                checkConversion, bool
                fromExplicitCast, bool
                useLegacyWarnings, Microsoft.CodeAnalysis.CSharp.NullableWalker.AssignmentKind
                assignmentKind, bool
                reportRemainingWarnings, bool
                reportTopLevelWarnings)
                {
                    var return_v = this_param.VisitConversion(conversionOpt: conversionOpt, conversionOperand, conversion, targetTypeWithNullability, operandType, checkConversion: checkConversion, fromExplicitCast: fromExplicitCast, useLegacyWarnings: useLegacyWarnings, assignmentKind, reportRemainingWarnings: reportRemainingWarnings, reportTopLevelWarnings: reportTopLevelWarnings);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 34974, 35271);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.NullableFlowState
                f_10904_35342_35388(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithState>
                types)
                {
                    var return_v = BestTypeInferrer.GetNullableState(types);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 35342, 35388);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10904_35949_35963(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 35949, 35963);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm>
                f_10904_36006_36021(Microsoft.CodeAnalysis.CSharp.BoundSwitchExpression
                this_param)
                {
                    var return_v = this_param.SwitchArms;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 36006, 36021);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10904_36006_36030(Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 36006, 36030);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10904_36241_36255(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Conversion>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 36241, 36255);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithState
                f_10904_36326_36340(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithState>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 36326, 36340);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithState
                f_10904_36176_36529(Microsoft.CodeAnalysis.CSharp.NullableWalker
                this_param, Microsoft.CodeAnalysis.CSharp.BoundConversion?
                conversionOpt, Microsoft.CodeAnalysis.CSharp.BoundExpression
                conversionOperand, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                targetTypeWithNullability, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithState
                operandType, bool
                checkConversion, bool
                fromExplicitCast, bool
                useLegacyWarnings, Microsoft.CodeAnalysis.CSharp.NullableWalker.AssignmentKind
                assignmentKind, bool
                reportRemainingWarnings, bool
                reportTopLevelWarnings)
                {
                    var return_v = this_param.VisitConversion(conversionOpt, conversionOperand: conversionOperand, conversion, targetTypeWithNullability: targetTypeWithNullability, operandType: operandType, checkConversion: checkConversion, fromExplicitCast: fromExplicitCast, useLegacyWarnings: useLegacyWarnings, assignmentKind, reportRemainingWarnings: reportRemainingWarnings, reportTopLevelWarnings: reportTopLevelWarnings);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 36176, 36529);
                    return return_v;
                }


                int
                f_10904_36580_36598(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Conversion>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 36580, 36598);
                    return 0;
                }


                int
                f_10904_36613_36631(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithState>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 36613, 36631);
                    return 0;
                }


                int
                f_10904_36646_36664(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 36646, 36664);
                    return 0;
                }


                int
                f_10904_36679_36699(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol, (Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState state, bool believedReachable)>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 36679, 36699);
                    return 0;
                }


                int
                f_10904_36714_36732(Microsoft.CodeAnalysis.CSharp.NullableWalker
                this_param, Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState
                newState)
                {
                    this_param.SetState(newState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 36714, 36732);
                    return 0;
                }


                int
                f_10904_36747_36803(Microsoft.CodeAnalysis.CSharp.NullableWalker
                this_param, Microsoft.CodeAnalysis.CSharp.BoundSwitchExpression
                expression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithState
                resultType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                lvalueType)
                {
                    this_param.SetResult((Microsoft.CodeAnalysis.CSharp.BoundExpression)expression, resultType, lvalueType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 36747, 36803);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10904, 30606, 36815);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10904, 30606, 36815);
            }
        }

        public override BoundNode VisitIsPatternExpression(BoundIsPatternExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10904, 36827, 37785);
                (Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState state, bool believedReachable) s1 = default((Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState state, bool believedReachable));
                (Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState state, bool believedReachable) s2 = default((Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState state, bool believedReachable));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 36933, 36967);

                f_10904_36933_36966(!IsConditionalState);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 36981, 37037);

                f_10904_36981_37036(this, f_10904_37006_37021(node), f_10904_37023_37035(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 37051, 37090);

                f_10904_37051_37089(this, f_10904_37076_37088(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 37104, 37164);

                var
                expressionState = f_10904_37126_37163(this, f_10904_37147_37162(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 37178, 37300);

                var
                labelStateMap = f_10904_37198_37299(this, node.Syntax, f_10904_37232_37248(node), f_10904_37250_37265(node), expressionState, ref this.State)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 37314, 37459);

                var
                trueState = (DynAbs.Tracing.TraceSender.Conditional_F1(10904, 37330, 37426) || ((f_10904_37330_37426(labelStateMap, (DynAbs.Tracing.TraceSender.Conditional_F1(10904, 37356, 37370) || ((f_10904_37356_37370(node) && DynAbs.Tracing.TraceSender.Conditional_F2(10904, 37373, 37392)) || DynAbs.Tracing.TraceSender.Conditional_F3(10904, 37395, 37413))) ? f_10904_37373_37392(node) : f_10904_37395_37413(node), out s1) && DynAbs.Tracing.TraceSender.Conditional_F2(10904, 37429, 37437)) || DynAbs.Tracing.TraceSender.Conditional_F3(10904, 37440, 37458))) ? s1.state : f_10904_37440_37458(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 37473, 37619);

                var
                falseState = (DynAbs.Tracing.TraceSender.Conditional_F1(10904, 37490, 37586) || ((f_10904_37490_37586(labelStateMap, (DynAbs.Tracing.TraceSender.Conditional_F1(10904, 37516, 37530) || ((f_10904_37516_37530(node) && DynAbs.Tracing.TraceSender.Conditional_F2(10904, 37533, 37551)) || DynAbs.Tracing.TraceSender.Conditional_F3(10904, 37554, 37573))) ? f_10904_37533_37551(node) : f_10904_37554_37573(node), out s2) && DynAbs.Tracing.TraceSender.Conditional_F2(10904, 37589, 37597)) || DynAbs.Tracing.TraceSender.Conditional_F3(10904, 37600, 37618))) ? s2.state : f_10904_37600_37618(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 37633, 37654);

                f_10904_37633_37653(labelStateMap);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 37668, 37711);

                f_10904_37668_37710(this, trueState, falseState);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 37725, 37748);

                f_10904_37725_37747(this, node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10904, 37762, 37774);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10904, 36827, 37785);

                int
                f_10904_36933_36966(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 36933, 36966);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10904_37006_37021(Microsoft.CodeAnalysis.CSharp.BoundIsPatternExpression
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 37006, 37021);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundPattern
                f_10904_37023_37035(Microsoft.CodeAnalysis.CSharp.BoundIsPatternExpression
                this_param)
                {
                    var return_v = this_param.Pattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 37023, 37035);
                    return return_v;
                }


                int
                f_10904_36981_37036(Microsoft.CodeAnalysis.CSharp.NullableWalker
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.CSharp.BoundPattern
                pattern)
                {
                    this_param.LearnFromAnyNullPatterns(expression, pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 36981, 37036);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundPattern
                f_10904_37076_37088(Microsoft.CodeAnalysis.CSharp.BoundIsPatternExpression
                this_param)
                {
                    var return_v = this_param.Pattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 37076, 37088);
                    return return_v;
                }


                int
                f_10904_37051_37089(Microsoft.CodeAnalysis.CSharp.NullableWalker
                this_param, Microsoft.CodeAnalysis.CSharp.BoundPattern
                pattern)
                {
                    this_param.VisitPatternForRewriting(pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 37051, 37089);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10904_37147_37162(Microsoft.CodeAnalysis.CSharp.BoundIsPatternExpression
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 37147, 37162);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithState
                f_10904_37126_37163(Microsoft.CodeAnalysis.CSharp.NullableWalker
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.VisitRvalueWithState(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 37126, 37163);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
                f_10904_37232_37248(Microsoft.CodeAnalysis.CSharp.BoundIsPatternExpression
                this_param)
                {
                    var return_v = this_param.DecisionDag;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 37232, 37248);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10904_37250_37265(Microsoft.CodeAnalysis.CSharp.BoundIsPatternExpression
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 37250, 37265);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol, (Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState state, bool believedReachable)>
                f_10904_37198_37299(Microsoft.CodeAnalysis.CSharp.NullableWalker
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
                decisionDag, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithState
                expressionType, ref Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState
                initialState)
                {
                    var return_v = this_param.LearnFromDecisionDag(node, decisionDag, expression, expressionType, ref initialState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 37198, 37299);
                    return return_v;
                }


                bool
                f_10904_37356_37370(Microsoft.CodeAnalysis.CSharp.BoundIsPatternExpression
                this_param)
                {
                    var return_v = this_param.IsNegated;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 37356, 37370);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10904_37373_37392(Microsoft.CodeAnalysis.CSharp.BoundIsPatternExpression
                this_param)
                {
                    var return_v = this_param.WhenFalseLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 37373, 37392);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10904_37395_37413(Microsoft.CodeAnalysis.CSharp.BoundIsPatternExpression
                this_param)
                {
                    var return_v = this_param.WhenTrueLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 37395, 37413);
                    return return_v;
                }


                bool
                f_10904_37330_37426(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol, (Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState state, bool believedReachable)>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                key, out (Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState state, bool believedReachable)
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 37330, 37426);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState
                f_10904_37440_37458(Microsoft.CodeAnalysis.CSharp.NullableWalker
                this_param)
                {
                    var return_v = this_param.UnreachableState();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 37440, 37458);
                    return return_v;
                }


                bool
                f_10904_37516_37530(Microsoft.CodeAnalysis.CSharp.BoundIsPatternExpression
                this_param)
                {
                    var return_v = this_param.IsNegated;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 37516, 37530);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10904_37533_37551(Microsoft.CodeAnalysis.CSharp.BoundIsPatternExpression
                this_param)
                {
                    var return_v = this_param.WhenTrueLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 37533, 37551);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10904_37554_37573(Microsoft.CodeAnalysis.CSharp.BoundIsPatternExpression
                this_param)
                {
                    var return_v = this_param.WhenFalseLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10904, 37554, 37573);
                    return return_v;
                }


                bool
                f_10904_37490_37586(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol, (Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState state, bool believedReachable)>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                key, out (Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState state, bool believedReachable)
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 37490, 37586);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState
                f_10904_37600_37618(Microsoft.CodeAnalysis.CSharp.NullableWalker
                this_param)
                {
                    var return_v = this_param.UnreachableState();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 37600, 37618);
                    return return_v;
                }


                int
                f_10904_37633_37653(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol, (Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState state, bool believedReachable)>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 37633, 37653);
                    return 0;
                }


                int
                f_10904_37668_37710(Microsoft.CodeAnalysis.CSharp.NullableWalker
                this_param, Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState
                whenTrue, Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState
                whenFalse)
                {
                    this_param.SetConditionalState(whenTrue, whenFalse);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 37668, 37710);
                    return 0;
                }


                int
                f_10904_37725_37747(Microsoft.CodeAnalysis.CSharp.NullableWalker
                this_param, Microsoft.CodeAnalysis.CSharp.BoundIsPatternExpression
                node)
                {
                    this_param.SetNotNullResult((Microsoft.CodeAnalysis.CSharp.BoundExpression)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10904, 37725, 37747);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10904, 36827, 37785);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10904, 36827, 37785);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
