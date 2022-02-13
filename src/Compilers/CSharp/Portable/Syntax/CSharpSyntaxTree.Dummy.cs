// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Immutable;
using System.Text;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    public partial class CSharpSyntaxTree
    {
        internal sealed class DummySyntaxTree : CSharpSyntaxTree
        {
            private readonly CompilationUnitSyntax _node;

            public DummySyntaxTree()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10082, 657, 808);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10082, 635, 640);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10082, 714, 793);

                    _node = f_10082_722_792(this, f_10082_743_791(string.Empty));
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10082, 657, 808);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10082, 657, 808);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10082, 657, 808);
                }
            }

            public override string ToString()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10082, 824, 925);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10082, 890, 910);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10082, 824, 925);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10082, 824, 925);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10082, 824, 925);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override SourceText GetText(CancellationToken cancellationToken)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10082, 941, 1112);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10082, 1045, 1097);

                    return f_10082_1052_1096(string.Empty, f_10082_1082_1095());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10082, 941, 1112);

                    System.Text.Encoding
                    f_10082_1082_1095()
                    {
                        var return_v = Encoding.UTF8;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10082, 1082, 1095);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Text.SourceText
                    f_10082_1052_1096(string
                    text, System.Text.Encoding
                    encoding)
                    {
                        var return_v = SourceText.From(text, encoding);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10082, 1052, 1096);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10082, 941, 1112);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10082, 941, 1112);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override bool TryGetText(out SourceText text)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10082, 1128, 1310);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10082, 1213, 1265);

                    text = f_10082_1220_1264(string.Empty, f_10082_1250_1263());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10082, 1283, 1295);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10082, 1128, 1310);

                    System.Text.Encoding
                    f_10082_1250_1263()
                    {
                        var return_v = Encoding.UTF8;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10082, 1250, 1263);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Text.SourceText
                    f_10082_1220_1264(string
                    text, System.Text.Encoding
                    encoding)
                    {
                        var return_v = SourceText.From(text, encoding);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10082, 1220, 1264);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10082, 1128, 1310);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10082, 1128, 1310);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override Encoding Encoding
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10082, 1392, 1421);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10082, 1398, 1419);

                        return f_10082_1405_1418();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10082, 1392, 1421);

                        System.Text.Encoding
                        f_10082_1405_1418()
                        {
                            var return_v = Encoding.UTF8;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10082, 1405, 1418);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10082, 1326, 1436);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10082, 1326, 1436);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override int Length
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10082, 1511, 1528);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10082, 1517, 1526);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10082, 1511, 1528);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10082, 1452, 1543);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10082, 1452, 1543);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override CSharpParseOptions Options
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10082, 1634, 1676);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10082, 1640, 1674);

                        return f_10082_1647_1673();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10082, 1634, 1676);

                        Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                        f_10082_1647_1673()
                        {
                            var return_v = CSharpParseOptions.Default;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10082, 1647, 1673);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10082, 1559, 1691);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10082, 1559, 1691);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            [Obsolete("Obsolete due to performance problems, use CompilationOptions.SyntaxTreeOptionsProvider instead", error: false)]
            public override ImmutableDictionary<string, ReportDiagnostic> DiagnosticOptions
            {
                [Obsolete("Obsolete due to performance problems, use CompilationOptions.SyntaxTreeOptionsProvider instead", error: false)]
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10082, 1940, 1979);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10082, 1943, 1979);
                        throw f_10082_1949_1979(); DynAbs.Tracing.TraceSender.TraceExitMethod(10082, 1940, 1979);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10082, 1940, 1979);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10082, 1940, 1979);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override string FilePath
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10082, 2060, 2088);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10082, 2066, 2086);

                        return string.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10082, 2060, 2088);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10082, 1996, 2103);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10082, 1996, 2103);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override SyntaxReference GetReference(SyntaxNode node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10082, 2119, 2267);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10082, 2213, 2252);

                    return f_10082_2220_2251(node);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10082, 2119, 2267);

                    Microsoft.CodeAnalysis.CSharp.SimpleSyntaxReference
                    f_10082_2220_2251(Microsoft.CodeAnalysis.SyntaxNode
                    node)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.SimpleSyntaxReference(node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10082, 2220, 2251);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10082, 2119, 2267);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10082, 2119, 2267);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override CSharpSyntaxNode GetRoot(CancellationToken cancellationToken)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10082, 2283, 2421);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10082, 2393, 2406);

                    return _node;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10082, 2283, 2421);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10082, 2283, 2421);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10082, 2283, 2421);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override bool TryGetRoot(out CSharpSyntaxNode root)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10082, 2437, 2586);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10082, 2528, 2541);

                    root = _node;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10082, 2559, 2571);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10082, 2437, 2586);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10082, 2437, 2586);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10082, 2437, 2586);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override bool HasCompilationUnitRoot
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10082, 2678, 2698);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10082, 2684, 2696);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10082, 2678, 2698);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10082, 2602, 2713);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10082, 2602, 2713);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override FileLinePositionSpan GetLineSpan(TextSpan span, CancellationToken cancellationToken = default(CancellationToken))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10082, 2729, 2943);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10082, 2891, 2928);

                    return default(FileLinePositionSpan);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10082, 2729, 2943);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10082, 2729, 2943);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10082, 2729, 2943);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override SyntaxTree WithRootAndOptions(SyntaxNode root, ParseOptions options)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10082, 2959, 3179);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10082, 3076, 3164);

                    return f_10082_3083_3163(root, options: options, path: f_10082_3138_3146(), encoding: null);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10082, 2959, 3179);

                    string
                    f_10082_3138_3146()
                    {
                        var return_v = FilePath;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10082, 3138, 3146);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxTree
                    f_10082_3083_3163(Microsoft.CodeAnalysis.SyntaxNode
                    root, Microsoft.CodeAnalysis.ParseOptions
                    options, string
                    path, System.Text.Encoding?
                    encoding)
                    {
                        var return_v = SyntaxFactory.SyntaxTree(root, options: options, path: path, encoding: encoding);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10082, 3083, 3163);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10082, 2959, 3179);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10082, 2959, 3179);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override SyntaxTree WithFilePath(string path)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10082, 3195, 3385);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10082, 3280, 3370);

                    return f_10082_3287_3369(_node, options: f_10082_3328_3340(this), path: path, encoding: null);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10082, 3195, 3385);

                    Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                    f_10082_3328_3340(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree.DummySyntaxTree
                    this_param)
                    {
                        var return_v = this_param.Options;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10082, 3328, 3340);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxTree
                    f_10082_3287_3369(Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
                    root, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                    options, string
                    path, System.Text.Encoding?
                    encoding)
                    {
                        var return_v = SyntaxFactory.SyntaxTree((Microsoft.CodeAnalysis.SyntaxNode)root, options: (Microsoft.CodeAnalysis.ParseOptions)options, path: path, encoding: encoding);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10082, 3287, 3369);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10082, 3195, 3385);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10082, 3195, 3385);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static DummySyntaxTree()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10082, 515, 3396);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10082, 515, 3396);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10082, 515, 3396);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10082, 515, 3396);

            Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
            f_10082_743_791(string
            text)
            {
                var return_v = SyntaxFactory.ParseCompilationUnit(text);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10082, 743, 791);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
            f_10082_722_792(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree.DummySyntaxTree
            this_param, Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
            node)
            {
                var return_v = this_param.CloneNodeAsRoot<Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax>(node);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10082, 722, 792);
                return return_v;
            }


            System.Exception
            f_10082_1949_1979()
            {
                var return_v = ExceptionUtilities.Unreachable;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10082, 1949, 1979);
                return return_v;
            }

        }
    }
}
