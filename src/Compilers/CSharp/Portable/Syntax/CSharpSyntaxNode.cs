// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    public abstract partial class CSharpSyntaxNode : SyntaxNode, IFormattable
    {
        internal CSharpSyntaxNode(GreenNode green, SyntaxNode? parent, int position)
        : base(f_10002_1163_1168_C(green), parent, position)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10002, 1066, 1209);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10002, 1066, 1209);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10002, 1066, 1209);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10002, 1066, 1209);
            }
        }

        internal CSharpSyntaxNode(GreenNode green, int position, SyntaxTree syntaxTree)
        : base(f_10002_1512_1517_C(green), position, syntaxTree)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10002, 1412, 1562);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10002, 1412, 1562);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10002, 1412, 1562);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10002, 1412, 1562);
            }
        }

        internal new SyntaxTree SyntaxTree
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10002, 2116, 2303);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 2152, 2209);

                    var
                    result = this._syntaxTree ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.SyntaxTree?>(10002, 2165, 2208) ?? f_10002_2185_2208(this))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 2227, 2256);

                    f_10002_2227_2255(result != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 2274, 2288);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10002, 2116, 2303);

                    Microsoft.CodeAnalysis.SyntaxTree
                    f_10002_2185_2208(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    node)
                    {
                        var return_v = ComputeSyntaxTree(node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10002, 2185, 2208);
                        return return_v;
                    }


                    int
                    f_10002_2227_2255(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10002, 2227, 2255);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10002, 2057, 2314);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10002, 2057, 2314);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static SyntaxTree ComputeSyntaxTree(CSharpSyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10002, 2326, 4178);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 2417, 2462);

                ArrayBuilder<CSharpSyntaxNode>?
                nodes = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 2476, 2500);

                SyntaxTree?
                tree = null
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 2584, 3470) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10002, 2584, 3470);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 2629, 2653);

                        tree = node._syntaxTree;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 2671, 2754) || true) && (tree != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10002, 2671, 2754);
                            DynAbs.Tracing.TraceSender.TraceBreak(10002, 2729, 2735);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10002, 2671, 2754);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 2774, 2799);

                        var
                        parent = f_10002_2787_2798(node)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 2817, 3134) || true) && (parent == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10002, 2817, 3134);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 2942, 3041);

                            f_10002_2942_3040(ref node._syntaxTree, f_10002_2992_3033(node), null);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 3063, 3087);

                            tree = node._syntaxTree;
                            DynAbs.Tracing.TraceSender.TraceBreak(10002, 3109, 3115);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10002, 2817, 3134);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 3154, 3180);

                        tree = parent._syntaxTree;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 3198, 3327) || true) && (tree != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10002, 3198, 3327);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 3256, 3280);

                            node._syntaxTree = tree;
                            DynAbs.Tracing.TraceSender.TraceBreak(10002, 3302, 3308);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10002, 3198, 3327);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 3347, 3423);

                        f_10002_3347_3422(
                                        (nodes ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode>?>(10002, 3348, 3411) ?? (nodes = f_10002_3366_3410()))), node);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 3441, 3455);

                        node = parent;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10002, 2584, 3470);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10002, 2584, 3470);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10002, 2584, 3470);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 3551, 4139) || true) && (nodes != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10002, 3551, 4139);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 3602, 3629);

                    f_10002_3602_3628(tree != null);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 3649, 4091);
                        foreach (var n in f_10002_3667_3672_I(nodes))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10002, 3649, 4091);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 3714, 3747);

                            var
                            existingTree = n._syntaxTree
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 3769, 4029) || true) && (existingTree != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10002, 3769, 4029);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 3843, 3929);

                                f_10002_3843_3928(existingTree == tree, "how could this node belong to a different tree?");
                                DynAbs.Tracing.TraceSender.TraceBreak(10002, 4000, 4006);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10002, 3769, 4029);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 4051, 4072);

                            n._syntaxTree = tree;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10002, 3649, 4091);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10002, 1, 443);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10002, 1, 443);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 4111, 4124);

                    f_10002_4111_4123(
                                    nodes);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10002, 3551, 4139);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 4155, 4167);

                return tree;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10002, 2326, 4178);

                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10002_2787_2798(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10002, 2787, 2798);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10002_2992_3033(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                root)
                {
                    var return_v = CSharpSyntaxTree.CreateWithoutClone(root);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10002, 2992, 3033);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree?
                f_10002_2942_3040(ref Microsoft.CodeAnalysis.SyntaxTree?
                location1, Microsoft.CodeAnalysis.SyntaxTree
                value, Microsoft.CodeAnalysis.SyntaxTree?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10002, 2942, 3040);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode>
                f_10002_3366_3410()
                {
                    var return_v = ArrayBuilder<CSharpSyntaxNode>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10002, 3366, 3410);
                    return return_v;
                }


                int
                f_10002_3347_3422(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode>
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10002, 3347, 3422);
                    return 0;
                }


                int
                f_10002_3602_3628(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10002, 3602, 3628);
                    return 0;
                }


                int
                f_10002_3843_3928(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10002, 3843, 3928);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode>
                f_10002_3667_3672_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10002, 3667, 3672);
                    return return_v;
                }


                int
                f_10002_4111_4123(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10002, 4111, 4123);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10002, 2326, 4178);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10002, 2326, 4178);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public abstract TResult? Accept<TResult>(CSharpSyntaxVisitor<TResult> visitor);

        public abstract void Accept(CSharpSyntaxVisitor visitor);

        internal new CSharpSyntaxNode? Parent
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10002, 4533, 4622);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 4569, 4607);

                    return (CSharpSyntaxNode?)DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.Parent, 10002, 4595, 4606);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10002, 4533, 4622);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10002, 4471, 4633);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10002, 4471, 4633);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal new CSharpSyntaxNode? ParentOrStructuredTriviaParent
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10002, 4731, 4844);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 4767, 4829);

                    return (CSharpSyntaxNode?)DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.ParentOrStructuredTriviaParent, 10002, 4793, 4828);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10002, 4731, 4844);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10002, 4645, 4855);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10002, 4645, 4855);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal Syntax.InternalSyntax.CSharpSyntaxNode CsGreen
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10002, 4994, 5060);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 5000, 5058);

                    return (Syntax.InternalSyntax.CSharpSyntaxNode)f_10002_5047_5057(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10002, 4994, 5060);

                    Microsoft.CodeAnalysis.GreenNode
                    f_10002_5047_5057(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    this_param)
                    {
                        var return_v = this_param.Green;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10002, 5047, 5057);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10002, 4914, 5071);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10002, 4914, 5071);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public SyntaxKind Kind()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10002, 5193, 5291);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 5242, 5280);

                return (SyntaxKind)f_10002_5261_5279(f_10002_5261_5271(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10002, 5193, 5291);

                Microsoft.CodeAnalysis.GreenNode
                f_10002_5261_5271(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Green;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10002, 5261, 5271);
                    return return_v;
                }


                int
                f_10002_5261_5279(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.RawKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10002, 5261, 5279);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10002, 5193, 5291);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10002, 5193, 5291);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string Language
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10002, 5466, 5502);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 5472, 5500);

                    return LanguageNames.CSharp;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10002, 5466, 5502);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10002, 5410, 5513);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10002, 5410, 5513);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public new SyntaxTriviaList GetLeadingTrivia()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10002, 5654, 5842);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 5725, 5785);

                var
                firstToken = f_10002_5742_5784(this, includeZeroWidth: true)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 5799, 5831);

                return firstToken.LeadingTrivia;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10002, 5654, 5842);

                Microsoft.CodeAnalysis.SyntaxToken
                f_10002_5742_5784(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param, bool
                includeZeroWidth)
                {
                    var return_v = this_param.GetFirstToken(includeZeroWidth: includeZeroWidth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10002, 5742, 5784);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10002, 5654, 5842);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10002, 5654, 5842);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public new SyntaxTriviaList GetTrailingTrivia()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10002, 5982, 6169);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 6054, 6112);

                var
                lastToken = f_10002_6070_6111(this, includeZeroWidth: true)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 6126, 6158);

                return lastToken.TrailingTrivia;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10002, 5982, 6169);

                Microsoft.CodeAnalysis.SyntaxToken
                f_10002_6070_6111(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param, bool
                includeZeroWidth)
                {
                    var return_v = this_param.GetLastToken(includeZeroWidth: includeZeroWidth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10002, 6070, 6111);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10002, 5982, 6169);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10002, 5982, 6169);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxNode DeserializeFrom(Stream stream, CancellationToken cancellationToken = default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10002, 6322, 7152);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 6449, 6564) || true) && (stream == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10002, 6449, 6564);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 6501, 6549);

                    throw f_10002_6507_6548(nameof(stream));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10002, 6449, 6564);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 6580, 6733) || true) && (f_10002_6584_6599_M(!stream.CanRead))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10002, 6580, 6733);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 6633, 6718);

                    throw f_10002_6639_6717(f_10002_6669_6716());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10002, 6580, 6733);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 6749, 6838);

                using var
                reader = f_10002_6768_6837(stream, leaveOpen: true, cancellationToken)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 6854, 7017) || true) && (reader == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10002, 6854, 7017);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 6906, 7002);

                    throw f_10002_6912_7001(f_10002_6934_6984(), nameof(stream));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10002, 6854, 7017);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 7033, 7103);

                var
                root = (Syntax.InternalSyntax.CSharpSyntaxNode)f_10002_7084_7102(reader)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 7117, 7141);

                return f_10002_7124_7140(root);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10002, 6322, 7152);

                System.ArgumentNullException
                f_10002_6507_6548(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10002, 6507, 6548);
                    return return_v;
                }


                bool
                f_10002_6584_6599_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10002, 6584, 6599);
                    return return_v;
                }


                string
                f_10002_6669_6716()
                {
                    var return_v = CodeAnalysisResources.TheStreamCannotBeReadFrom;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10002, 6669, 6716);
                    return return_v;
                }


                System.InvalidOperationException
                f_10002_6639_6717(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10002, 6639, 6717);
                    return return_v;
                }


                Roslyn.Utilities.ObjectReader
                f_10002_6768_6837(System.IO.Stream
                stream, bool
                leaveOpen, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = ObjectReader.TryGetReader(stream, leaveOpen: leaveOpen, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10002, 6768, 6837);
                    return return_v;
                }


                string
                f_10002_6934_6984()
                {
                    var return_v = CodeAnalysisResources.Stream_contains_invalid_data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10002, 6934, 6984);
                    return return_v;
                }


                System.ArgumentException
                f_10002_6912_7001(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10002, 6912, 7001);
                    return return_v;
                }


                object
                f_10002_7084_7102(Roslyn.Utilities.ObjectReader
                this_param)
                {
                    var return_v = this_param.ReadValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10002, 7084, 7102);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10002_7124_7140(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.CreateRed();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10002, 7124, 7140);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10002, 6322, 7152);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10002, 6322, 7152);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public new Location GetLocation()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10002, 7291, 7392);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 7349, 7381);

                return f_10002_7356_7380(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10002, 7291, 7392);

                Microsoft.CodeAnalysis.SourceLocation
                f_10002_7356_7380(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = new Microsoft.CodeAnalysis.SourceLocation((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10002, 7356, 7380);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10002, 7291, 7392);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10002, 7291, 7392);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal new SyntaxReference GetReference()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10002, 7657, 7778);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 7725, 7767);

                return f_10002_7732_7766(f_10002_7732_7747(this), this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10002, 7657, 7778);

                Microsoft.CodeAnalysis.SyntaxTree
                f_10002_7732_7747(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10002, 7732, 7747);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxReference
                f_10002_7732_7766(Microsoft.CodeAnalysis.SyntaxTree
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.GetReference((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10002, 7732, 7766);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10002, 7657, 7778);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10002, 7657, 7778);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public new IEnumerable<Diagnostic> GetDiagnostics()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10002, 8068, 8199);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 8144, 8188);

                return f_10002_8151_8187(f_10002_8151_8166(this), this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10002, 8068, 8199);

                Microsoft.CodeAnalysis.SyntaxTree
                f_10002_8151_8166(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10002, 8151, 8166);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                f_10002_8151_8187(Microsoft.CodeAnalysis.SyntaxTree
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.GetDiagnostics((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10002, 8151, 8187);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10002, 8068, 8199);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10002, 8068, 8199);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal IList<DirectiveTriviaSyntax> GetDirectives(Func<DirectiveTriviaSyntax, bool>? filter = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10002, 8241, 8456);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 8367, 8445);

                return ((SyntaxNodeOrToken)this).GetDirectives<DirectiveTriviaSyntax>(filter);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10002, 8241, 8456);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10002, 8241, 8456);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10002, 8241, 8456);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public DirectiveTriviaSyntax? GetFirstDirective(Func<DirectiveTriviaSyntax, bool>? predicate = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10002, 8586, 9917);
                Microsoft.CodeAnalysis.SyntaxNode? node = default(Microsoft.CodeAnalysis.SyntaxNode?);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 8711, 9878);
                    foreach (var child in f_10002_8733_8759_I(f_10002_8733_8759(this)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10002, 8711, 9878);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 8793, 9863) || true) && (child.ContainsDirectives)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10002, 8793, 9863);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 8863, 9844) || true) && (child.AsNode(out node
                            ))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10002, 8863, 9844);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 8943, 8985);

                                var
                                d = f_10002_8951_8984(node, predicate)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 9011, 9118) || true) && (d != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10002, 9011, 9118);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 9082, 9091);

                                    return d;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10002, 9011, 9118);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10002, 8863, 9844);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10002, 8863, 9844);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 9216, 9244);

                                var
                                token = child.AsToken()
                                ;
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 9344, 9821);
                                    foreach (var tr in f_10002_9363_9382_I(token.LeadingTrivia))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10002, 9344, 9821);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 9440, 9794) || true) && (tr.IsDirective)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10002, 9440, 9794);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 9524, 9574);

                                            var
                                            d = (DirectiveTriviaSyntax)tr.GetStructure()!
                                            ;

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 9608, 9763) || true) && (predicate == null || (DynAbs.Tracing.TraceSender.Expression_False(10002, 9612, 9645) || f_10002_9633_9645(predicate, d)))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10002, 9608, 9763);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 9719, 9728);

                                                return d;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10002, 9608, 9763);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10002, 9440, 9794);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10002, 9344, 9821);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10002, 1, 478);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(10002, 1, 478);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10002, 8863, 9844);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10002, 8793, 9863);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10002, 8711, 9878);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10002, 1, 1168);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10002, 1, 1168);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 9894, 9906);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10002, 8586, 9917);

                Microsoft.CodeAnalysis.ChildSyntaxList
                f_10002_8733_8759(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.ChildNodesAndTokens();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10002, 8733, 8759);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax?
                f_10002_8951_8984(Microsoft.CodeAnalysis.SyntaxNode
                node, System.Func<Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax, bool>?
                predicate)
                {
                    var return_v = node.GetFirstDirective(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10002, 8951, 8984);
                    return return_v;
                }


                bool
                f_10002_9633_9645(System.Func<Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax, bool>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10002, 9633, 9645);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTriviaList
                f_10002_9363_9382_I(Microsoft.CodeAnalysis.SyntaxTriviaList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10002, 9363, 9382);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ChildSyntaxList
                f_10002_8733_8759_I(Microsoft.CodeAnalysis.ChildSyntaxList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10002, 8733, 8759);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10002, 8586, 9917);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10002, 8586, 9917);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public DirectiveTriviaSyntax? GetLastDirective(Func<DirectiveTriviaSyntax, bool>? predicate = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10002, 10046, 11395);
                Microsoft.CodeAnalysis.SyntaxNode? node = default(Microsoft.CodeAnalysis.SyntaxNode?);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 10170, 11356);
                    foreach (var child in f_10002_10192_10228_I(f_10002_10192_10218(this).Reverse()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10002, 10170, 11356);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 10262, 11341) || true) && (child.ContainsDirectives)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10002, 10262, 11341);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 10332, 11322) || true) && (child.AsNode(out node
                            ))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10002, 10332, 11322);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 10412, 10453);

                                var
                                d = f_10002_10420_10452(node, predicate)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 10479, 10586) || true) && (d != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10002, 10479, 10586);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 10550, 10559);

                                    return d;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10002, 10479, 10586);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10002, 10332, 11322);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10002, 10332, 11322);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 10684, 10712);

                                var
                                token = child.AsToken()
                                ;
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 10812, 11299);
                                    foreach (var tr in f_10002_10831_10860_I(token.LeadingTrivia.Reverse()))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10002, 10812, 11299);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 10918, 11272) || true) && (tr.IsDirective)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10002, 10918, 11272);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 11002, 11052);

                                            var
                                            d = (DirectiveTriviaSyntax)tr.GetStructure()!
                                            ;

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 11086, 11241) || true) && (predicate == null || (DynAbs.Tracing.TraceSender.Expression_False(10002, 11090, 11123) || f_10002_11111_11123(predicate, d)))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10002, 11086, 11241);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 11197, 11206);

                                                return d;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10002, 11086, 11241);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10002, 10918, 11272);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10002, 10812, 11299);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10002, 1, 488);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(10002, 1, 488);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10002, 10332, 11322);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10002, 10262, 11341);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10002, 10170, 11356);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10002, 1, 1187);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10002, 1, 1187);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 11372, 11384);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10002, 10046, 11395);

                Microsoft.CodeAnalysis.ChildSyntaxList
                f_10002_10192_10218(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.ChildNodesAndTokens();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10002, 10192, 10218);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax?
                f_10002_10420_10452(Microsoft.CodeAnalysis.SyntaxNode
                node, System.Func<Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax, bool>?
                predicate)
                {
                    var return_v = node.GetLastDirective(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10002, 10420, 10452);
                    return return_v;
                }


                bool
                f_10002_11111_11123(System.Func<Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax, bool>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10002, 11111, 11123);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTriviaList.Reversed
                f_10002_10831_10860_I(Microsoft.CodeAnalysis.SyntaxTriviaList.Reversed
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10002, 10831, 10860);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ChildSyntaxList.Reversed
                f_10002_10192_10228_I(Microsoft.CodeAnalysis.ChildSyntaxList.Reversed
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10002, 10192, 10228);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10002, 10046, 11395);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10002, 10046, 11395);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public new SyntaxToken GetFirstToken(bool includeZeroWidth = false, bool includeSkipped = false, bool includeDirectives = false, bool includeDocumentationComments = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10002, 12104, 12420);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 12300, 12409);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetFirstToken(includeZeroWidth, includeSkipped, includeDirectives, includeDocumentationComments), 10002, 12307, 12408);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10002, 12104, 12420);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10002, 12104, 12420);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10002, 12104, 12420);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal SyntaxToken GetFirstToken(Func<SyntaxToken, bool>? predicate, Func<SyntaxTrivia, bool>? stepInto = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10002, 12896, 13118);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 13034, 13107);

                return f_10002_13041_13106(SyntaxNavigator.Instance, this, predicate, stepInto);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10002, 12896, 13118);

                Microsoft.CodeAnalysis.SyntaxToken
                f_10002_13041_13106(Microsoft.CodeAnalysis.SyntaxNavigator
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                current, System.Func<Microsoft.CodeAnalysis.SyntaxToken, bool>?
                predicate, System.Func<Microsoft.CodeAnalysis.SyntaxTrivia, bool>?
                stepInto)
                {
                    var return_v = this_param.GetFirstToken((Microsoft.CodeAnalysis.SyntaxNode)current, predicate, stepInto);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10002, 13041, 13106);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10002, 12896, 13118);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10002, 12896, 13118);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public new SyntaxToken GetLastToken(bool includeZeroWidth = false, bool includeSkipped = false, bool includeDirectives = false, bool includeDocumentationComments = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10002, 13787, 14101);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 13982, 14090);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetLastToken(includeZeroWidth, includeSkipped, includeDirectives, includeDocumentationComments), 10002, 13989, 14089);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10002, 13787, 14101);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10002, 13787, 14101);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10002, 13787, 14101);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public new SyntaxToken FindToken(int position, bool findInsideTrivia = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10002, 14583, 14746);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 14685, 14735);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.FindToken(position, findInsideTrivia), 10002, 14692, 14734);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10002, 14583, 14746);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10002, 14583, 14746);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10002, 14583, 14746);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal SyntaxToken FindTokenIncludingCrefAndNameAttributes(int position)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10002, 15228, 16689);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 15327, 15406);

                SyntaxToken
                nonTriviaToken = f_10002_15356_15405(this, position, findInsideTrivia: false)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 15422, 15495);

                SyntaxTrivia
                trivia = f_10002_15444_15494(position, nonTriviaToken)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 15511, 15642) || true) && (!f_10002_15516_15571(trivia.Kind()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10002, 15511, 15642);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 15605, 15627);

                    return nonTriviaToken;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10002, 15511, 15642);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 15658, 15692);

                f_10002_15658_15691(trivia.HasStructure);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 15706, 15803);

                SyntaxToken
                triviaToken = f_10002_15732_15802(((CSharpSyntaxNode)trivia.GetStructure()!), position)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 16039, 16102);

                CSharpSyntaxNode?
                curr = (CSharpSyntaxNode?)triviaToken.Parent
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 16116, 16640) || true) && (curr != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10002, 16116, 16640);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 16272, 16586) || true) && (f_10002_16276_16287(curr) == SyntaxKind.XmlCrefAttribute || (DynAbs.Tracing.TraceSender.Expression_False(10002, 16276, 16364) || f_10002_16322_16333(curr) == SyntaxKind.XmlNameAttribute))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10002, 16272, 16586);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 16406, 16567);

                            return (DynAbs.Tracing.TraceSender.Conditional_F1(10002, 16413, 16485) || ((f_10002_16413_16485(position, curr) && DynAbs.Tracing.TraceSender.Conditional_F2(10002, 16513, 16524)) || DynAbs.Tracing.TraceSender.Conditional_F3(10002, 16552, 16566))) ? triviaToken
                            : nonTriviaToken;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10002, 16272, 16586);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 16606, 16625);

                        curr = f_10002_16613_16624(curr);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10002, 16116, 16640);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10002, 16116, 16640);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10002, 16116, 16640);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 16656, 16678);

                return nonTriviaToken;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10002, 15228, 16689);

                Microsoft.CodeAnalysis.SyntaxToken
                f_10002_15356_15405(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param, int
                position, bool
                findInsideTrivia)
                {
                    var return_v = this_param.FindToken(position, findInsideTrivia: findInsideTrivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10002, 15356, 15405);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTrivia
                f_10002_15444_15494(int
                position, Microsoft.CodeAnalysis.SyntaxToken
                token)
                {
                    var return_v = GetTriviaFromSyntaxToken(position, token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10002, 15444, 15494);
                    return return_v;
                }


                bool
                f_10002_15516_15571(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.IsDocumentationCommentTrivia(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10002, 15516, 15571);
                    return return_v;
                }


                int
                f_10002_15658_15691(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10002, 15658, 15691);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10002_15732_15802(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param, int
                position)
                {
                    var return_v = this_param.FindTokenInternal(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10002, 15732, 15802);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10002_16276_16287(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10002, 16276, 16287);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10002_16322_16333(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10002, 16322, 16333);
                    return return_v;
                }


                bool
                f_10002_16413_16485(int
                position, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                attribute)
                {
                    var return_v = LookupPosition.IsInXmlAttributeValue(position, (Microsoft.CodeAnalysis.CSharp.Syntax.XmlAttributeSyntax)attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10002, 16413, 16485);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10002_16613_16624(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10002, 16613, 16624);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10002, 15228, 16689);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10002, 15228, 16689);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public new SyntaxTrivia FindTrivia(int position, Func<SyntaxTrivia, bool> stepInto)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10002, 17279, 17441);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 17387, 17430);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.FindTrivia(position, stepInto), 10002, 17394, 17429);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10002, 17279, 17441);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10002, 17279, 17441);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10002, 17279, 17441);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public new SyntaxTrivia FindTrivia(int position, bool findInsideTrivia = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10002, 17824, 17990);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 17928, 17979);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.FindTrivia(position, findInsideTrivia), 10002, 17935, 17978);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10002, 17824, 17990);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10002, 17824, 17990);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10002, 17824, 17990);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override bool EquivalentToCore(SyntaxNode other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10002, 18259, 18390);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 18342, 18379);

                throw f_10002_18348_18378();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10002, 18259, 18390);

                System.Exception
                f_10002_18348_18378()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10002, 18348, 18378);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10002, 18259, 18390);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10002, 18259, 18390);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override SyntaxTree SyntaxTreeCore
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10002, 18471, 18545);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 18507, 18530);

                    return f_10002_18514_18529(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10002, 18471, 18545);

                    Microsoft.CodeAnalysis.SyntaxTree
                    f_10002_18514_18529(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    this_param)
                    {
                        var return_v = this_param.SyntaxTree;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10002, 18514, 18529);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10002, 18402, 18556);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10002, 18402, 18556);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected internal override SyntaxNode ReplaceCore<TNode>(
                    IEnumerable<TNode>? nodes = null,
                    Func<TNode, TNode, SyntaxNode>? computeReplacementNode = null,
                    IEnumerable<SyntaxToken>? tokens = null,
                    Func<SyntaxToken, SyntaxToken, SyntaxToken>? computeReplacementToken = null,
                    IEnumerable<SyntaxTrivia>? trivia = null,
                    Func<SyntaxTrivia, SyntaxTrivia, SyntaxTrivia>? computeReplacementTrivia = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10002, 18568, 19260);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 19067, 19249);

                return f_10002_19074_19248(f_10002_19074_19200(this, nodes, computeReplacementNode, tokens, computeReplacementToken, trivia, computeReplacementTrivia), f_10002_19232_19247(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10002, 18568, 19260);

                SyntaxNode
                f_10002_19074_19200(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                root, System.Collections.Generic.IEnumerable<TNode>?
                nodes, Func<TNode, TNode, SyntaxNode>?
                computeReplacementNode, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxToken>?
                tokens, System.Func<Microsoft.CodeAnalysis.SyntaxToken, Microsoft.CodeAnalysis.SyntaxToken, Microsoft.CodeAnalysis.SyntaxToken>?
                computeReplacementToken, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTrivia>?
                trivia, System.Func<Microsoft.CodeAnalysis.SyntaxTrivia, Microsoft.CodeAnalysis.SyntaxTrivia, Microsoft.CodeAnalysis.SyntaxTrivia>?
                computeReplacementTrivia)
                {
                    var return_v = SyntaxReplacer.Replace(root, nodes, computeReplacementNode, tokens, computeReplacementToken, trivia, computeReplacementTrivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10002, 19074, 19200);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10002_19232_19247(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10002, 19232, 19247);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_10002_19074_19248(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.SyntaxTree
                oldTree)
                {
                    var return_v = node.AsRootOfNewTreeWithOptionsFrom(oldTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10002, 19074, 19248);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10002, 18568, 19260);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10002, 18568, 19260);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected internal override SyntaxNode ReplaceNodeInListCore(SyntaxNode originalNode, IEnumerable<SyntaxNode> replacementNodes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10002, 19272, 19561);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 19424, 19550);

                return f_10002_19431_19549(f_10002_19431_19501(this, originalNode, replacementNodes), f_10002_19533_19548(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10002, 19272, 19561);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10002_19431_19501(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                root, Microsoft.CodeAnalysis.SyntaxNode
                originalNode, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                newNodes)
                {
                    var return_v = SyntaxReplacer.ReplaceNodeInList((Microsoft.CodeAnalysis.SyntaxNode)root, originalNode, newNodes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10002, 19431, 19501);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10002_19533_19548(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10002, 19533, 19548);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_10002_19431_19549(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.SyntaxTree
                oldTree)
                {
                    var return_v = node.AsRootOfNewTreeWithOptionsFrom(oldTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10002, 19431, 19549);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10002, 19272, 19561);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10002, 19272, 19561);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected internal override SyntaxNode InsertNodesInListCore(SyntaxNode nodeInList, IEnumerable<SyntaxNode> nodesToInsert, bool insertBefore)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10002, 19573, 19884);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 19739, 19873);

                return f_10002_19746_19872(f_10002_19746_19824(this, nodeInList, nodesToInsert, insertBefore), f_10002_19856_19871(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10002, 19573, 19884);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10002_19746_19824(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                root, Microsoft.CodeAnalysis.SyntaxNode
                nodeInList, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                nodesToInsert, bool
                insertBefore)
                {
                    var return_v = SyntaxReplacer.InsertNodeInList((Microsoft.CodeAnalysis.SyntaxNode)root, nodeInList, nodesToInsert, insertBefore);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10002, 19746, 19824);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10002_19856_19871(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10002, 19856, 19871);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_10002_19746_19872(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.SyntaxTree
                oldTree)
                {
                    var return_v = node.AsRootOfNewTreeWithOptionsFrom(oldTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10002, 19746, 19872);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10002, 19573, 19884);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10002, 19573, 19884);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected internal override SyntaxNode ReplaceTokenInListCore(SyntaxToken originalToken, IEnumerable<SyntaxToken> newTokens)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10002, 19896, 20177);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 20045, 20166);

                return f_10002_20052_20165(f_10002_20052_20117(this, originalToken, newTokens), f_10002_20149_20164(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10002, 19896, 20177);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10002_20052_20117(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                root, Microsoft.CodeAnalysis.SyntaxToken
                tokenInList, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxToken>
                newTokens)
                {
                    var return_v = SyntaxReplacer.ReplaceTokenInList((Microsoft.CodeAnalysis.SyntaxNode)root, tokenInList, newTokens);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10002, 20052, 20117);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10002_20149_20164(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10002, 20149, 20164);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_10002_20052_20165(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.SyntaxTree
                oldTree)
                {
                    var return_v = node.AsRootOfNewTreeWithOptionsFrom(oldTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10002, 20052, 20165);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10002, 19896, 20177);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10002, 19896, 20177);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected internal override SyntaxNode InsertTokensInListCore(SyntaxToken originalToken, IEnumerable<SyntaxToken> newTokens, bool insertBefore)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10002, 20189, 20502);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 20357, 20491);

                return f_10002_20364_20490(f_10002_20364_20442(this, originalToken, newTokens, insertBefore), f_10002_20474_20489(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10002, 20189, 20502);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10002_20364_20442(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                root, Microsoft.CodeAnalysis.SyntaxToken
                tokenInList, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxToken>
                newTokens, bool
                insertBefore)
                {
                    var return_v = SyntaxReplacer.InsertTokenInList((Microsoft.CodeAnalysis.SyntaxNode)root, tokenInList, newTokens, insertBefore);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10002, 20364, 20442);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10002_20474_20489(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10002, 20474, 20489);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_10002_20364_20490(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.SyntaxTree
                oldTree)
                {
                    var return_v = node.AsRootOfNewTreeWithOptionsFrom(oldTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10002, 20364, 20490);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10002, 20189, 20502);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10002, 20189, 20502);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected internal override SyntaxNode ReplaceTriviaInListCore(SyntaxTrivia originalTrivia, IEnumerable<SyntaxTrivia> newTrivia)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10002, 20514, 20801);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 20667, 20790);

                return f_10002_20674_20789(f_10002_20674_20741(this, originalTrivia, newTrivia), f_10002_20773_20788(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10002, 20514, 20801);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10002_20674_20741(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                root, Microsoft.CodeAnalysis.SyntaxTrivia
                triviaInList, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTrivia>
                newTrivia)
                {
                    var return_v = SyntaxReplacer.ReplaceTriviaInList((Microsoft.CodeAnalysis.SyntaxNode)root, triviaInList, newTrivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10002, 20674, 20741);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10002_20773_20788(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10002, 20773, 20788);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_10002_20674_20789(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.SyntaxTree
                oldTree)
                {
                    var return_v = node.AsRootOfNewTreeWithOptionsFrom(oldTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10002, 20674, 20789);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10002, 20514, 20801);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10002, 20514, 20801);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected internal override SyntaxNode InsertTriviaInListCore(SyntaxTrivia originalTrivia, IEnumerable<SyntaxTrivia> newTrivia, bool insertBefore)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10002, 20813, 21131);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 20984, 21120);

                return f_10002_20991_21119(f_10002_20991_21071(this, originalTrivia, newTrivia, insertBefore), f_10002_21103_21118(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10002, 20813, 21131);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10002_20991_21071(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                root, Microsoft.CodeAnalysis.SyntaxTrivia
                triviaInList, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTrivia>
                newTrivia, bool
                insertBefore)
                {
                    var return_v = SyntaxReplacer.InsertTriviaInList((Microsoft.CodeAnalysis.SyntaxNode)root, triviaInList, newTrivia, insertBefore);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10002, 20991, 21071);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10002_21103_21118(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10002, 21103, 21118);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_10002_20991_21119(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.SyntaxTree
                oldTree)
                {
                    var return_v = node.AsRootOfNewTreeWithOptionsFrom(oldTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10002, 20991, 21119);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10002, 20813, 21131);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10002, 20813, 21131);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected internal override SyntaxNode? RemoveNodesCore(IEnumerable<SyntaxNode> nodes, SyntaxRemoveOptions options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10002, 21143, 21426);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 21283, 21415);

                return f_10002_21290_21414(f_10002_21290_21366(this, f_10002_21326_21356(nodes), options), f_10002_21398_21413(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10002, 21143, 21426);

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode>
                f_10002_21326_21356(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                source)
                {
                    var return_v = source.Cast<Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10002, 21326, 21356);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10002_21290_21366(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                root, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode>
                nodes, Microsoft.CodeAnalysis.SyntaxRemoveOptions
                options)
                {
                    var return_v = SyntaxNodeRemover.RemoveNodes(root, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>)nodes, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10002, 21290, 21366);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10002_21398_21413(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10002, 21398, 21413);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_10002_21290_21414(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                node, Microsoft.CodeAnalysis.SyntaxTree
                oldTree)
                {
                    var return_v = node.AsRootOfNewTreeWithOptionsFrom(oldTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10002, 21290, 21414);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10002, 21143, 21426);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10002, 21143, 21426);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected internal override SyntaxNode NormalizeWhitespaceCore(string indentation, string eol, bool elasticTrivia)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10002, 21438, 21709);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 21577, 21698);

                return f_10002_21584_21697(f_10002_21584_21649(this, indentation, eol, elasticTrivia), f_10002_21681_21696(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10002, 21438, 21709);

                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10002_21584_21649(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node, string
                indentWhitespace, string
                eolWhitespace, bool
                useElasticTrivia)
                {
                    var return_v = SyntaxNormalizer.Normalize(node, indentWhitespace, eolWhitespace, useElasticTrivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10002, 21584, 21649);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10002_21681_21696(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10002, 21681, 21696);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_10002_21584_21697(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node, Microsoft.CodeAnalysis.SyntaxTree
                oldTree)
                {
                    var return_v = node.AsRootOfNewTreeWithOptionsFrom(oldTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10002, 21584, 21697);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10002, 21438, 21709);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10002, 21438, 21709);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override bool IsEquivalentToCore(SyntaxNode node, bool topLevel = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10002, 21721, 21914);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 21828, 21903);

                return f_10002_21835_21902(this, (CSharpSyntaxNode)node, topLevel);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10002, 21721, 21914);

                bool
                f_10002_21835_21902(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                oldNode, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                newNode, bool
                topLevel)
                {
                    var return_v = SyntaxFactory.AreEquivalent((Microsoft.CodeAnalysis.SyntaxNode)oldNode, (Microsoft.CodeAnalysis.SyntaxNode)newNode, topLevel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10002, 21835, 21902);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10002, 21721, 21914);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10002, 21721, 21914);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool ShouldCreateWeakList()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10002, 21926, 22312);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 21996, 22272) || true) && (f_10002_22000_22011(this) == SyntaxKind.Block)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10002, 21996, 22272);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 22065, 22090);

                    var
                    parent = f_10002_22078_22089(this)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 22108, 22257) || true) && (parent is MemberDeclarationSyntax || (DynAbs.Tracing.TraceSender.Expression_False(10002, 22112, 22184) || parent is AccessorDeclarationSyntax))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10002, 22108, 22257);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 22226, 22238);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10002, 22108, 22257);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10002, 21996, 22272);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 22288, 22301);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10002, 21926, 22312);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10002_22000_22011(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10002, 22000, 22011);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10002_22078_22089(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10002, 22078, 22089);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10002, 21926, 22312);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10002, 21926, 22312);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        string IFormattable.ToString(string? format, IFormatProvider? formatProvider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10002, 22346, 22477);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10002, 22448, 22466);

                return f_10002_22455_22465(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10002, 22346, 22477);

                string
                f_10002_22455_22465(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10002, 22455, 22465);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10002, 22346, 22477);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10002, 22346, 22477);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CSharpSyntaxNode()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10002, 976, 22484);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10002, 976, 22484);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10002, 976, 22484);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10002, 976, 22484);

        static Microsoft.CodeAnalysis.GreenNode
        f_10002_1163_1168_C(Microsoft.CodeAnalysis.GreenNode
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10002, 1066, 1209);
            return return_v;
        }


        static Microsoft.CodeAnalysis.GreenNode
        f_10002_1512_1517_C(Microsoft.CodeAnalysis.GreenNode
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10002, 1412, 1562);
            return return_v;
        }

    }
}
