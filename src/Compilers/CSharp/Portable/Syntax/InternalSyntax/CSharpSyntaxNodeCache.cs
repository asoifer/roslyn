// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.Syntax.InternalSyntax;

namespace Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax
{
    internal static class CSharpSyntaxNodeCache
    {
        internal static GreenNode TryGetNode(int kind, GreenNode child1, SyntaxFactoryContext context, out int hash)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10008, 414, 639);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10008, 547, 628);

                return f_10008_554_627(kind, child1, f_10008_595_616(context), out hash);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10008, 414, 639);

                Microsoft.CodeAnalysis.GreenNode.NodeFlags
                f_10008_595_616(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxFactoryContext
                context)
                {
                    var return_v = GetNodeFlags(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10008, 595, 616);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode?
                f_10008_554_627(int
                kind, Microsoft.CodeAnalysis.GreenNode
                child1, Microsoft.CodeAnalysis.GreenNode.NodeFlags
                flags, out int
                hash)
                {
                    var return_v = SyntaxNodeCache.TryGetNode(kind, child1, flags, out hash);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10008, 554, 627);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10008, 414, 639);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10008, 414, 639);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static GreenNode TryGetNode(int kind, GreenNode child1, GreenNode child2, SyntaxFactoryContext context, out int hash)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10008, 651, 902);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10008, 802, 891);

                return f_10008_809_890(kind, child1, child2, f_10008_858_879(context), out hash);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10008, 651, 902);

                Microsoft.CodeAnalysis.GreenNode.NodeFlags
                f_10008_858_879(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxFactoryContext
                context)
                {
                    var return_v = GetNodeFlags(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10008, 858, 879);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode?
                f_10008_809_890(int
                kind, Microsoft.CodeAnalysis.GreenNode
                child1, Microsoft.CodeAnalysis.GreenNode
                child2, Microsoft.CodeAnalysis.GreenNode.NodeFlags
                flags, out int
                hash)
                {
                    var return_v = SyntaxNodeCache.TryGetNode(kind, child1, child2, flags, out hash);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10008, 809, 890);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10008, 651, 902);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10008, 651, 902);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static GreenNode TryGetNode(int kind, GreenNode child1, GreenNode child2, GreenNode child3, SyntaxFactoryContext context, out int hash)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10008, 914, 1191);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10008, 1083, 1180);

                return f_10008_1090_1179(kind, child1, child2, child3, f_10008_1147_1168(context), out hash);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10008, 914, 1191);

                Microsoft.CodeAnalysis.GreenNode.NodeFlags
                f_10008_1147_1168(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxFactoryContext
                context)
                {
                    var return_v = GetNodeFlags(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10008, 1147, 1168);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode?
                f_10008_1090_1179(int
                kind, Microsoft.CodeAnalysis.GreenNode
                child1, Microsoft.CodeAnalysis.GreenNode
                child2, Microsoft.CodeAnalysis.GreenNode
                child3, Microsoft.CodeAnalysis.GreenNode.NodeFlags
                flags, out int
                hash)
                {
                    var return_v = SyntaxNodeCache.TryGetNode(kind, child1, child2, child3, flags, out hash);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10008, 1090, 1179);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10008, 914, 1191);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10008, 914, 1191);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static GreenNode.NodeFlags GetNodeFlags(SyntaxFactoryContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10008, 1203, 1673);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10008, 1305, 1355);

                var
                flags = f_10008_1317_1354()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10008, 1371, 1494) || true) && (context.IsInAsync)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10008, 1371, 1494);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10008, 1426, 1479);

                    flags |= GreenNode.NodeFlags.FactoryContextIsInAsync;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10008, 1371, 1494);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10008, 1510, 1633) || true) && (f_10008_1514_1531(context))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10008, 1510, 1633);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10008, 1565, 1618);

                    flags |= GreenNode.NodeFlags.FactoryContextIsInQuery;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10008, 1510, 1633);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10008, 1649, 1662);

                return flags;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10008, 1203, 1673);

                Microsoft.CodeAnalysis.GreenNode.NodeFlags
                f_10008_1317_1354()
                {
                    var return_v = SyntaxNodeCache.GetDefaultNodeFlags();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10008, 1317, 1354);
                    return return_v;
                }


                bool
                f_10008_1514_1531(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxFactoryContext
                this_param)
                {
                    var return_v = this_param.IsInQuery;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10008, 1514, 1531);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10008, 1203, 1673);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10008, 1203, 1673);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CSharpSyntaxNodeCache()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10008, 354, 1680);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10008, 354, 1680);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10008, 354, 1680);
        }

    }
}
