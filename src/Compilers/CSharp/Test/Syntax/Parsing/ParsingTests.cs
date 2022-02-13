// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp.Test.Utilities;
using Microsoft.CodeAnalysis.Test.Utilities;
using Roslyn.Test.Utilities;
using Xunit;
using Xunit.Abstractions;

namespace Microsoft.CodeAnalysis.CSharp.UnitTests
{
    public abstract class ParsingTests : CSharpTestBase
    {
        private CSharpSyntaxNode? _node;

        private IEnumerator<SyntaxNodeOrToken>? _treeEnumerator;

        private readonly ITestOutputHelper _output;

        public ParsingTests(ITestOutputHelper output)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(26001, 796, 899);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 659, 664);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 715, 730);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 776, 783);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 866, 888);

                this._output = output;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(26001, 796, 899);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(26001, 796, 899);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(26001, 796, 899);
            }
        }

        public override void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(26001, 911, 1033);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 966, 981);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Dispose(), 26001, 966, 980);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 995, 1022);

                f_26001_995_1021(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(26001, 911, 1033);

                int
                f_26001_995_1021(Microsoft.CodeAnalysis.CSharp.UnitTests.ParsingTests
                this_param)
                {
                    this_param.VerifyEnumeratorConsumed();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 995, 1021);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(26001, 911, 1033);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(26001, 911, 1033);
            }
        }

        private void VerifyEnumeratorConsumed()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(26001, 1045, 1456);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 1109, 1445) || true) && (_treeEnumerator != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(26001, 1109, 1445);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 1170, 1211);

                    var
                    hasNext = f_26001_1184_1210(_treeEnumerator)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 1229, 1430) || true) && (hasNext)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(26001, 1229, 1430);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 1282, 1299);

                        f_26001_1282_1298(this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 1321, 1411);

                        f_26001_1321_1410(hasNext, "Test contains unconsumed syntax left over from UsingNode()");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(26001, 1229, 1430);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(26001, 1109, 1445);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(26001, 1045, 1456);

                bool
                f_26001_1184_1210(System.Collections.Generic.IEnumerator<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 1184, 1210);
                    return return_v;
                }


                bool
                f_26001_1282_1298(Microsoft.CodeAnalysis.CSharp.UnitTests.ParsingTests
                this_param)
                {
                    var return_v = this_param.DumpAndCleanup();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 1282, 1298);
                    return return_v;
                }


                bool
                f_26001_1321_1410(bool
                condition, string
                userMessage)
                {
                    var return_v = CustomAssert.False(condition, userMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 1321, 1410);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(26001, 1045, 1456);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(26001, 1045, 1456);
            }
        }

        private bool DumpAndCleanup()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(26001, 1468, 1712);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 1522, 1545);

                _treeEnumerator = null;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 1617, 1674);
                    foreach (var _ in f_26001_1635_1669_I(f_26001_1635_1669(this, _node!, dump: true)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(26001, 1617, 1674);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(26001, 1617, 1674);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(26001, 1, 58);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(26001, 1, 58);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 1688, 1701);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(26001, 1468, 1712);

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                f_26001_1635_1669(Microsoft.CodeAnalysis.CSharp.UnitTests.ParsingTests
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node, bool
                dump)
                {
                    var return_v = this_param.EnumerateNodes(node, dump: dump);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 1635, 1669);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                f_26001_1635_1669_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 1635, 1669);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(26001, 1468, 1712);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(26001, 1468, 1712);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static void ParseAndValidate(string text, params DiagnosticDescription[] expectedErrors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(26001, 1724, 2013);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 1844, 1891);

                var
                parsedTree = f_26001_1861_1890(text)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 1905, 1952);

                var
                actualErrors = f_26001_1924_1951(parsedTree)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 1966, 2002);

                f_26001_1966_2001(actualErrors, expectedErrors);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(26001, 1724, 2013);

                Microsoft.CodeAnalysis.SyntaxTree
                f_26001_1861_1890(string
                text)
                {
                    var return_v = ParseWithRoundTripCheck(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 1861, 1890);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                f_26001_1924_1951(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.GetDiagnostics();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 1924, 1951);
                    return return_v;
                }


                int
                f_26001_1966_2001(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                actual, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    actual.Verify(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 1966, 2001);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(26001, 1724, 2013);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(26001, 1724, 2013);
            }
        }

        public static void ParseAndValidate(string text, CSharpParseOptions options, params DiagnosticDescription[] expectedErrors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(26001, 2025, 2360);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 2173, 2238);

                var
                parsedTree = f_26001_2190_2237(text, options: options)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 2252, 2299);

                var
                actualErrors = f_26001_2271_2298(parsedTree)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 2313, 2349);

                f_26001_2313_2348(actualErrors, expectedErrors);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(26001, 2025, 2360);

                Microsoft.CodeAnalysis.SyntaxTree
                f_26001_2190_2237(string
                text, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                options)
                {
                    var return_v = ParseWithRoundTripCheck(text, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 2190, 2237);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                f_26001_2271_2298(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.GetDiagnostics();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 2271, 2298);
                    return return_v;
                }


                int
                f_26001_2313_2348(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                actual, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    actual.Verify(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 2313, 2348);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(26001, 2025, 2360);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(26001, 2025, 2360);
            }
        }

        public static void ParseAndValidateFirst(string text, DiagnosticDescription expectedFirstError)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(26001, 2372, 2673);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 2492, 2539);

                var
                parsedTree = f_26001_2509_2538(text)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 2553, 2600);

                var
                actualErrors = f_26001_2572_2599(parsedTree)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 2614, 2662);

                f_26001_2614_2661(f_26001_2614_2634(actualErrors, 1), expectedFirstError);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(26001, 2372, 2673);

                Microsoft.CodeAnalysis.SyntaxTree
                f_26001_2509_2538(string
                text)
                {
                    var return_v = ParseWithRoundTripCheck(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 2509, 2538);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                f_26001_2572_2599(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.GetDiagnostics();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 2572, 2599);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                f_26001_2614_2634(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                source, int
                count)
                {
                    var return_v = source.Take<Microsoft.CodeAnalysis.Diagnostic>(count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 2614, 2634);
                    return return_v;
                }


                int
                f_26001_2614_2661(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                actual, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    actual.Verify(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 2614, 2661);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(26001, 2372, 2673);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(26001, 2372, 2673);
            }
        }

        protected virtual SyntaxTree ParseTree(string text, CSharpParseOptions? options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(26001, 2766, 2813);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 2769, 2813);
                return f_26001_2769_2813(text, options); DynAbs.Tracing.TraceSender.TraceExitMethod(26001, 2766, 2813);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(26001, 2766, 2813);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(26001, 2766, 2813);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.SyntaxTree
            f_26001_2769_2813(string
            text, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?
            options)
            {
                var return_v = SyntaxFactory.ParseSyntaxTree(text, (Microsoft.CodeAnalysis.ParseOptions?)options);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 2769, 2813);
                return return_v;
            }

        }

        public CompilationUnitSyntax ParseFile(string text, CSharpParseOptions? parseOptions = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(26001, 2919, 2998);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 2935, 2998);
                return f_26001_2935_2998(text, options: parseOptions); DynAbs.Tracing.TraceSender.TraceExitMethod(26001, 2919, 2998);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(26001, 2919, 2998);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(26001, 2919, 2998);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
            f_26001_2935_2998(string
            text, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?
            options)
            {
                var return_v = SyntaxFactory.ParseCompilationUnit(text, options: options);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 2935, 2998);
                return return_v;
            }

        }

        internal CompilationUnitSyntax ParseFileExperimental(string text, MessageID feature)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(26001, 3096, 3188);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 3112, 3188);
                return f_26001_3112_3188(this, text, parseOptions: f_26001_3142_3187(TestOptions.Regular, feature)); DynAbs.Tracing.TraceSender.TraceExitMethod(26001, 3096, 3188);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(26001, 3096, 3188);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(26001, 3096, 3188);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
            f_26001_3142_3187(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
            options, params Microsoft.CodeAnalysis.CSharp.MessageID[]
            features)
            {
                var return_v = options.WithExperimental(features);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 3142, 3187);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
            f_26001_3112_3188(Microsoft.CodeAnalysis.CSharp.UnitTests.ParsingTests
            this_param, string
            text, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
            parseOptions)
            {
                var return_v = this_param.ParseFile(text, parseOptions: parseOptions);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 3112, 3188);
                return return_v;
            }

        }

        protected virtual CSharpSyntaxNode ParseNode(string text, CSharpParseOptions? options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(26001, 3288, 3353);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 3304, 3353);
                return f_26001_3304_3328(this, text, options).GetCompilationUnitRoot(); DynAbs.Tracing.TraceSender.TraceExitMethod(26001, 3288, 3353);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(26001, 3288, 3353);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(26001, 3288, 3353);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.SyntaxTree
            f_26001_3304_3328(Microsoft.CodeAnalysis.CSharp.UnitTests.ParsingTests
            this_param, string
            text, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?
            options)
            {
                var return_v = this_param.ParseTree(text, options);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 3304, 3328);
                return return_v;
            }

        }

        internal void UsingStatement(string text, params DiagnosticDescription[] expectedErrors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(26001, 3366, 3542);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 3479, 3531);

                f_26001_3479_3530(this, text, options: null, expectedErrors);
                DynAbs.Tracing.TraceSender.TraceExitMethod(26001, 3366, 3542);

                int
                f_26001_3479_3530(Microsoft.CodeAnalysis.CSharp.UnitTests.ParsingTests
                this_param, string
                text, Microsoft.CodeAnalysis.ParseOptions?
                options, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expectedErrors)
                {
                    this_param.UsingStatement(text, options: options, expectedErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 3479, 3530);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(26001, 3366, 3542);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(26001, 3366, 3542);
            }
        }

        internal void UsingStatement(string text, ParseOptions? options, params DiagnosticDescription[] expectedErrors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(26001, 3554, 4008);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 3690, 3754);

                var
                node = f_26001_3701_3753(text, options: options)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 3816, 3862);

                f_26001_3816_3861(text, f_26001_3841_3860(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 3876, 3917);

                var
                actualErrors = f_26001_3895_3916(node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 3931, 3967);

                f_26001_3931_3966(actualErrors, expectedErrors);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 3981, 3997);

                f_26001_3981_3996(this, node);
                DynAbs.Tracing.TraceSender.TraceExitMethod(26001, 3554, 4008);

                Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                f_26001_3701_3753(string
                text, Microsoft.CodeAnalysis.ParseOptions?
                options)
                {
                    var return_v = SyntaxFactory.ParseStatement(text, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 3701, 3753);
                    return return_v;
                }


                string
                f_26001_3841_3860(Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                this_param)
                {
                    var return_v = this_param.ToFullString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 3841, 3860);
                    return return_v;
                }


                bool
                f_26001_3816_3861(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 3816, 3861);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                f_26001_3895_3916(Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                this_param)
                {
                    var return_v = this_param.GetDiagnostics();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 3895, 3916);
                    return return_v;
                }


                int
                f_26001_3931_3966(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                actual, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    actual.Verify(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 3931, 3966);
                    return 0;
                }


                int
                f_26001_3981_3996(Microsoft.CodeAnalysis.CSharp.UnitTests.ParsingTests
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                root)
                {
                    this_param.UsingNode((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)root);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 3981, 3996);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(26001, 3554, 4008);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(26001, 3554, 4008);
            }
        }

        internal void UsingDeclaration(string text, ParseOptions options, params DiagnosticDescription[] expectedErrors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(26001, 4020, 4266);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 4157, 4255);

                f_26001_4157_4254(this, text, offset: 0, options, consumeFullText: true, expectedErrors: expectedErrors);
                DynAbs.Tracing.TraceSender.TraceExitMethod(26001, 4020, 4266);

                int
                f_26001_4157_4254(Microsoft.CodeAnalysis.CSharp.UnitTests.ParsingTests
                this_param, string
                text, int
                offset, Microsoft.CodeAnalysis.ParseOptions
                options, bool
                consumeFullText, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expectedErrors)
                {
                    this_param.UsingDeclaration(text, offset: offset, options, consumeFullText: consumeFullText, expectedErrors: expectedErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 4157, 4254);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(26001, 4020, 4266);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(26001, 4020, 4266);
            }
        }

        internal void UsingDeclaration(string text, int offset = 0, ParseOptions? options = null, bool consumeFullText = true, params DiagnosticDescription[] expectedErrors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(26001, 4278, 4927);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 4468, 4556);

                var
                node = f_26001_4479_4555(text, offset, options, consumeFullText)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 4570, 4599);

                f_26001_4570_4598(node is object);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 4613, 4779) || true) && (consumeFullText)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(26001, 4613, 4779);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 4718, 4764);

                    f_26001_4718_4763(text, f_26001_4743_4762(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(26001, 4613, 4779);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 4795, 4836);

                var
                actualErrors = f_26001_4814_4835(node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 4850, 4886);

                f_26001_4850_4885(actualErrors, expectedErrors);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 4900, 4916);

                f_26001_4900_4915(this, node);
                DynAbs.Tracing.TraceSender.TraceExitMethod(26001, 4278, 4927);

                Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax?
                f_26001_4479_4555(string
                text, int
                offset, Microsoft.CodeAnalysis.ParseOptions?
                options, bool
                consumeFullText)
                {
                    var return_v = SyntaxFactory.ParseMemberDeclaration(text, offset, options, consumeFullText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 4479, 4555);
                    return return_v;
                }


                int
                f_26001_4570_4598(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 4570, 4598);
                    return 0;
                }


                string
                f_26001_4743_4762(Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ToFullString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 4743, 4762);
                    return return_v;
                }


                bool
                f_26001_4718_4763(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 4718, 4763);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                f_26001_4814_4835(Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.GetDiagnostics();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 4814, 4835);
                    return return_v;
                }


                int
                f_26001_4850_4885(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                actual, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    actual.Verify(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 4850, 4885);
                    return 0;
                }


                int
                f_26001_4900_4915(Microsoft.CodeAnalysis.CSharp.UnitTests.ParsingTests
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax
                root)
                {
                    this_param.UsingNode((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)root);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 4900, 4915);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(26001, 4278, 4927);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(26001, 4278, 4927);
            }
        }

        internal void UsingExpression(string text, ParseOptions? options, params DiagnosticDescription[] expectedErrors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(26001, 4939, 5174);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 5076, 5163);

                f_26001_5076_5162(this, text, f_26001_5092_5145(text, options: options), expectedErrors);
                DynAbs.Tracing.TraceSender.TraceExitMethod(26001, 4939, 5174);

                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_26001_5092_5145(string
                text, Microsoft.CodeAnalysis.ParseOptions?
                options)
                {
                    var return_v = SyntaxFactory.ParseExpression(text, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 5092, 5145);
                    return return_v;
                }


                int
                f_26001_5076_5162(Microsoft.CodeAnalysis.CSharp.UnitTests.ParsingTests
                this_param, string
                text, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expectedErrors)
                {
                    this_param.UsingNode(text, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node, expectedErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 5076, 5162);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(26001, 4939, 5174);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(26001, 4939, 5174);
            }
        }

        protected void UsingNode(string text, CSharpSyntaxNode node, DiagnosticDescription[] expectedErrors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(26001, 5186, 5551);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 5359, 5405);

                f_26001_5359_5404(text, f_26001_5384_5403(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 5419, 5460);

                var
                actualErrors = f_26001_5438_5459(node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 5474, 5510);

                f_26001_5474_5509(actualErrors, expectedErrors);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 5524, 5540);

                f_26001_5524_5539(this, node);
                DynAbs.Tracing.TraceSender.TraceExitMethod(26001, 5186, 5551);

                string
                f_26001_5384_5403(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.ToFullString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 5384, 5403);
                    return return_v;
                }


                bool
                f_26001_5359_5404(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 5359, 5404);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                f_26001_5438_5459(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.GetDiagnostics();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 5438, 5459);
                    return return_v;
                }


                int
                f_26001_5474_5509(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                actual, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    actual.Verify(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 5474, 5509);
                    return 0;
                }


                int
                f_26001_5524_5539(Microsoft.CodeAnalysis.CSharp.UnitTests.ParsingTests
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                root)
                {
                    this_param.UsingNode(root);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 5524, 5539);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(26001, 5186, 5551);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(26001, 5186, 5551);
            }
        }

        internal void UsingExpression(string text, params DiagnosticDescription[] expectedErrors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(26001, 5563, 5741);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 5677, 5730);

                f_26001_5677_5729(this, text, options: null, expectedErrors);
                DynAbs.Tracing.TraceSender.TraceExitMethod(26001, 5563, 5741);

                int
                f_26001_5677_5729(Microsoft.CodeAnalysis.CSharp.UnitTests.ParsingTests
                this_param, string
                text, Microsoft.CodeAnalysis.ParseOptions?
                options, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expectedErrors)
                {
                    this_param.UsingExpression(text, options: options, expectedErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 5677, 5729);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(26001, 5563, 5741);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(26001, 5563, 5741);
            }
        }

        protected SyntaxTree UsingTree(string text, CSharpParseOptions? options = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(26001, 5884, 6271);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 5988, 6015);

                f_26001_5988_6014(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 6029, 6065);

                var
                tree = f_26001_6040_6064(this, text, options)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 6079, 6117);

                _node = tree.GetCompilationUnitRoot();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 6131, 6178);

                var
                nodes = f_26001_6143_6177(this, _node, dump: false)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 6192, 6232);

                _treeEnumerator = f_26001_6210_6231(nodes);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 6248, 6260);

                return tree;
                DynAbs.Tracing.TraceSender.TraceExitMethod(26001, 5884, 6271);

                int
                f_26001_5988_6014(Microsoft.CodeAnalysis.CSharp.UnitTests.ParsingTests
                this_param)
                {
                    this_param.VerifyEnumeratorConsumed();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 5988, 6014);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_26001_6040_6064(Microsoft.CodeAnalysis.CSharp.UnitTests.ParsingTests
                this_param, string
                text, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?
                options)
                {
                    var return_v = this_param.ParseTree(text, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 6040, 6064);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                f_26001_6143_6177(Microsoft.CodeAnalysis.CSharp.UnitTests.ParsingTests
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node, bool
                dump)
                {
                    var return_v = this_param.EnumerateNodes(node, dump: dump);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 6143, 6177);
                    return return_v;
                }


                System.Collections.Generic.IEnumerator<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                f_26001_6210_6231(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 6210, 6231);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(26001, 5884, 6271);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(26001, 5884, 6271);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected CSharpSyntaxNode UsingNode(string text)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(26001, 6414, 6597);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 6488, 6530);

                var
                root = f_26001_6499_6529(this, text, options: null)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 6544, 6560);

                f_26001_6544_6559(this, root);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 6574, 6586);

                return root;
                DynAbs.Tracing.TraceSender.TraceExitMethod(26001, 6414, 6597);

                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_26001_6499_6529(Microsoft.CodeAnalysis.CSharp.UnitTests.ParsingTests
                this_param, string
                text, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?
                options)
                {
                    var return_v = this_param.ParseNode(text, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 6499, 6529);
                    return return_v;
                }


                int
                f_26001_6544_6559(Microsoft.CodeAnalysis.CSharp.UnitTests.ParsingTests
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                root)
                {
                    this_param.UsingNode(root);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 6544, 6559);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(26001, 6414, 6597);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(26001, 6414, 6597);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected CSharpSyntaxNode UsingNode(string text, CSharpParseOptions options, params DiagnosticDescription[] expectedErrors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(26001, 6609, 6883);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 6758, 6794);

                var
                node = f_26001_6769_6793(this, text, options)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 6808, 6846);

                f_26001_6808_6845(this, text, node, expectedErrors);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 6860, 6872);

                return node;
                DynAbs.Tracing.TraceSender.TraceExitMethod(26001, 6609, 6883);

                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_26001_6769_6793(Microsoft.CodeAnalysis.CSharp.UnitTests.ParsingTests
                this_param, string
                text, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                options)
                {
                    var return_v = this_param.ParseNode(text, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 6769, 6793);
                    return return_v;
                }


                int
                f_26001_6808_6845(Microsoft.CodeAnalysis.CSharp.UnitTests.ParsingTests
                this_param, string
                text, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expectedErrors)
                {
                    this_param.UsingNode(text, node, expectedErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 6808, 6845);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(26001, 6609, 6883);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(26001, 6609, 6883);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected void UsingNode(CSharpSyntaxNode root)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(26001, 7021, 7272);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 7093, 7120);

                f_26001_7093_7119(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 7134, 7147);

                _node = root;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 7161, 7207);

                var
                nodes = f_26001_7173_7206(this, root, dump: false)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 7221, 7261);

                _treeEnumerator = f_26001_7239_7260(nodes);
                DynAbs.Tracing.TraceSender.TraceExitMethod(26001, 7021, 7272);

                int
                f_26001_7093_7119(Microsoft.CodeAnalysis.CSharp.UnitTests.ParsingTests
                this_param)
                {
                    this_param.VerifyEnumeratorConsumed();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 7093, 7119);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                f_26001_7173_7206(Microsoft.CodeAnalysis.CSharp.UnitTests.ParsingTests
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node, bool
                dump)
                {
                    var return_v = this_param.EnumerateNodes(node, dump: dump);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 7173, 7206);
                    return return_v;
                }


                System.Collections.Generic.IEnumerator<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                f_26001_7239_7260(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 7239, 7260);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(26001, 7021, 7272);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(26001, 7021, 7272);
            }
        }

        [DebuggerHidden]
        protected SyntaxNodeOrToken N(SyntaxKind kind, string? value = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(26001, 7421, 8104);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 7576, 7623);

                    f_26001_7576_7622(f_26001_7594_7621(_treeEnumerator!));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 7641, 7698);

                    f_26001_7641_7697(kind, _treeEnumerator.Current.Kind());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 7716, 7770);

                    f_26001_7716_7769(_treeEnumerator.Current.IsMissing);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 7790, 7930) || true) && (value != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(26001, 7790, 7930);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 7849, 7911);

                        f_26001_7849_7910(_treeEnumerator.Current.ToString(), value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(26001, 7790, 7930);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 7950, 7981);

                    return f_26001_7957_7980(_treeEnumerator);
                }
                catch when (f_26001_8022_8038(this))
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(26001, 8010, 8093);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 8072, 8078);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(26001, 8010, 8093);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(26001, 7421, 8104);

                bool
                f_26001_7594_7621(System.Collections.Generic.IEnumerator<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 7594, 7621);
                    return return_v;
                }


                bool
                f_26001_7576_7622(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 7576, 7622);
                    return return_v;
                }


                bool
                f_26001_7641_7697(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                expected, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 7641, 7697);
                    return return_v;
                }


                bool
                f_26001_7716_7769(bool
                condition)
                {
                    var return_v = CustomAssert.False(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 7716, 7769);
                    return return_v;
                }


                bool
                f_26001_7849_7910(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 7849, 7910);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNodeOrToken
                f_26001_7957_7980(System.Collections.Generic.IEnumerator<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(26001, 7957, 7980);
                    return return_v;
                }


                bool
                f_26001_8022_8038(Microsoft.CodeAnalysis.CSharp.UnitTests.ParsingTests
                this_param)
                {
                    var return_v = this_param.DumpAndCleanup();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 8022, 8038);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(26001, 7421, 8104);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(26001, 7421, 8104);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [DebuggerHidden]
        protected SyntaxNodeOrToken M(SyntaxKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(26001, 8281, 8801);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 8414, 8461);

                    f_26001_8414_8460(f_26001_8432_8459(_treeEnumerator!));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 8479, 8531);

                    SyntaxNodeOrToken
                    current = f_26001_8507_8530(_treeEnumerator)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 8549, 8590);

                    f_26001_8549_8589(kind, current.Kind());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 8608, 8645);

                    f_26001_8608_8644(current.IsMissing);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 8663, 8678);

                    return current;
                }
                catch when (f_26001_8719_8735(this))
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(26001, 8707, 8790);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 8769, 8775);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(26001, 8707, 8790);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(26001, 8281, 8801);

                bool
                f_26001_8432_8459(System.Collections.Generic.IEnumerator<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 8432, 8459);
                    return return_v;
                }


                bool
                f_26001_8414_8460(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 8414, 8460);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNodeOrToken
                f_26001_8507_8530(System.Collections.Generic.IEnumerator<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(26001, 8507, 8530);
                    return return_v;
                }


                bool
                f_26001_8549_8589(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                expected, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 8549, 8589);
                    return return_v;
                }


                bool
                f_26001_8608_8644(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 8608, 8644);
                    return return_v;
                }


                bool
                f_26001_8719_8735(Microsoft.CodeAnalysis.CSharp.UnitTests.ParsingTests
                this_param)
                {
                    var return_v = this_param.DumpAndCleanup();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 8719, 8735);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(26001, 8281, 8801);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(26001, 8281, 8801);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [DebuggerHidden]
        protected void EOF()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(26001, 8931, 9260);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 9002, 9249) || true) && (f_26001_9006_9033(_treeEnumerator!))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(26001, 9002, 9249);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 9067, 9107);

                    var
                    tk = _treeEnumerator.Current.Kind()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 9125, 9142);

                    f_26001_9125_9141(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 9160, 9234);

                    f_26001_9160_9233(true, "Found unexpected node or token of kind: " + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (tk).ToString(), 26001, 9230, 9232));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(26001, 9002, 9249);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(26001, 8931, 9260);

                bool
                f_26001_9006_9033(System.Collections.Generic.IEnumerator<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 9006, 9033);
                    return return_v;
                }


                bool
                f_26001_9125_9141(Microsoft.CodeAnalysis.CSharp.UnitTests.ParsingTests
                this_param)
                {
                    var return_v = this_param.DumpAndCleanup();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 9125, 9141);
                    return return_v;
                }


                bool
                f_26001_9160_9233(bool
                condition, string
                userMessage)
                {
                    var return_v = CustomAssert.False(condition, userMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 9160, 9233);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(26001, 8931, 9260);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(26001, 8931, 9260);
            }
        }

        private IEnumerable<SyntaxNodeOrToken> EnumerateNodes(CSharpSyntaxNode node, bool dump)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(26001, 9272, 10412);

                var listYield = new List<SyntaxNodeOrToken>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 9384, 9402);

                f_26001_9384_9401(this, node, dump);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 9416, 9434);

                listYield.Add(node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 9450, 9504);

                var
                stack = f_26001_9462_9503(24)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 9518, 9573);

                f_26001_9518_9572(stack, f_26001_9529_9555(node).GetEnumerator());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 9587, 9598);

                f_26001_9587_9597(this, dump);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 9614, 10374) || true) && (f_26001_9621_9632(stack) > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(26001, 9614, 10374);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 9670, 9691);

                        var
                        en = f_26001_9679_9690(stack)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 9709, 9880) || true) && (!en.MoveNext())
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(26001, 9709, 9880);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 9818, 9830);

                            f_26001_9818_9829(this, dump);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 9852, 9861);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(26001, 9709, 9880);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 9900, 9925);

                        var
                        current = en.Current
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 9943, 9958);

                        f_26001_9943_9957(stack, en);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 10022, 10043);

                        f_26001_10022_10042(this, current, dump);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 10061, 10082);

                        listYield.Add(current);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 10102, 10359) || true) && (current.IsNode)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(26001, 10102, 10359);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 10218, 10276);

                            f_26001_10218_10275(                    // not token, so consider children
                                                stack, current.ChildNodesAndTokens().GetEnumerator());
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 10298, 10309);

                            f_26001_10298_10308(this, dump);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 10331, 10340);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(26001, 10102, 10359);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(26001, 9614, 10374);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(26001, 9614, 10374);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(26001, 9614, 10374);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 10390, 10401);

                f_26001_10390_10400(this, dump);
                DynAbs.Tracing.TraceSender.TraceExitMethod(26001, 9272, 10412);

                return listYield;

                int
                f_26001_9384_9401(Microsoft.CodeAnalysis.CSharp.UnitTests.ParsingTests
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, bool
                dump)
                {
                    this_param.Print((Microsoft.CodeAnalysis.SyntaxNodeOrToken)node, dump);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 9384, 9401);
                    return 0;
                }


                System.Collections.Generic.Stack<Microsoft.CodeAnalysis.ChildSyntaxList.Enumerator>
                f_26001_9462_9503(int
                capacity)
                {
                    var return_v = new System.Collections.Generic.Stack<Microsoft.CodeAnalysis.ChildSyntaxList.Enumerator>(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 9462, 9503);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ChildSyntaxList
                f_26001_9529_9555(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.ChildNodesAndTokens();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 9529, 9555);
                    return return_v;
                }


                int
                f_26001_9518_9572(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.ChildSyntaxList.Enumerator>
                this_param, Microsoft.CodeAnalysis.ChildSyntaxList.Enumerator
                item)
                {
                    this_param.Push(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 9518, 9572);
                    return 0;
                }


                int
                f_26001_9587_9597(Microsoft.CodeAnalysis.CSharp.UnitTests.ParsingTests
                this_param, bool
                dump)
                {
                    this_param.Open(dump);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 9587, 9597);
                    return 0;
                }


                int
                f_26001_9621_9632(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.ChildSyntaxList.Enumerator>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(26001, 9621, 9632);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ChildSyntaxList.Enumerator
                f_26001_9679_9690(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.ChildSyntaxList.Enumerator>
                this_param)
                {
                    var return_v = this_param.Pop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 9679, 9690);
                    return return_v;
                }


                int
                f_26001_9818_9829(Microsoft.CodeAnalysis.CSharp.UnitTests.ParsingTests
                this_param, bool
                dump)
                {
                    this_param.Close(dump);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 9818, 9829);
                    return 0;
                }


                int
                f_26001_9943_9957(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.ChildSyntaxList.Enumerator>
                this_param, Microsoft.CodeAnalysis.ChildSyntaxList.Enumerator
                item)
                {
                    this_param.Push(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 9943, 9957);
                    return 0;
                }


                int
                f_26001_10022_10042(Microsoft.CodeAnalysis.CSharp.UnitTests.ParsingTests
                this_param, Microsoft.CodeAnalysis.SyntaxNodeOrToken
                node, bool
                dump)
                {
                    this_param.Print(node, dump);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 10022, 10042);
                    return 0;
                }


                int
                f_26001_10218_10275(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.ChildSyntaxList.Enumerator>
                this_param, Microsoft.CodeAnalysis.ChildSyntaxList.Enumerator
                item)
                {
                    this_param.Push(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 10218, 10275);
                    return 0;
                }


                int
                f_26001_10298_10308(Microsoft.CodeAnalysis.CSharp.UnitTests.ParsingTests
                this_param, bool
                dump)
                {
                    this_param.Open(dump);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 10298, 10308);
                    return 0;
                }


                int
                f_26001_10390_10400(Microsoft.CodeAnalysis.CSharp.UnitTests.ParsingTests
                this_param, bool
                dump)
                {
                    this_param.Done(dump);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 10390, 10400);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(26001, 9272, 10412);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(26001, 9272, 10412);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void Print(SyntaxNodeOrToken node, bool dump)
        {
            if (dump)
            {
                switch (node.Kind())
                {
                    case SyntaxKind.IdentifierToken:
                    case SyntaxKind.NumericLiteralToken:
                        if (node.IsMissing)
                        {
                            goto default;
                        }
                        _output.WriteLine(@"N(SyntaxKind.{0}, ""{1}"");", node.Kind(), node.ToString());
                        break;
                    default:
                        _output.WriteLine("{0}(SyntaxKind.{1});", node.IsMissing ? "M" : "N", node.Kind());
                        break;
                }
            }
        }

        private void Open(bool dump)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(26001, 11203, 11347);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 11256, 11336) || true) && (dump)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(26001, 11256, 11336);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 11298, 11321);

                    f_26001_11298_11320(_output, "{");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(26001, 11256, 11336);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(26001, 11203, 11347);

                int
                f_26001_11298_11320(Xunit.Abstractions.ITestOutputHelper
                this_param, string
                message)
                {
                    this_param.WriteLine(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 11298, 11320);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(26001, 11203, 11347);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(26001, 11203, 11347);
            }
        }

        private void Close(bool dump)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(26001, 11359, 11504);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 11413, 11493) || true) && (dump)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(26001, 11413, 11493);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 11455, 11478);

                    f_26001_11455_11477(_output, "}");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(26001, 11413, 11493);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(26001, 11359, 11504);

                int
                f_26001_11455_11477(Xunit.Abstractions.ITestOutputHelper
                this_param, string
                message)
                {
                    this_param.WriteLine(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 11455, 11477);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(26001, 11359, 11504);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(26001, 11359, 11504);
            }
        }

        private void Done(bool dump)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(26001, 11516, 11665);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 11569, 11654) || true) && (dump)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(26001, 11569, 11654);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(26001, 11611, 11639);

                    f_26001_11611_11638(_output, "EOF();");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(26001, 11569, 11654);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(26001, 11516, 11665);

                int
                f_26001_11611_11638(Xunit.Abstractions.ITestOutputHelper
                this_param, string
                message)
                {
                    this_param.WriteLine(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(26001, 11611, 11638);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(26001, 11516, 11665);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(26001, 11516, 11665);
            }
        }

        static ParsingTests()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(26001, 565, 11672);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(26001, 565, 11672);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(26001, 565, 11672);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(26001, 565, 11672);
    }
}
