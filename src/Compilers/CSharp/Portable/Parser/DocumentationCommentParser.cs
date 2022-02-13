// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Diagnostics;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax
{
    using Microsoft.CodeAnalysis.Syntax.InternalSyntax;
    internal class DocumentationCommentParser : SyntaxParser
    {
        private readonly SyntaxListPool _pool;

        private bool _isDelimited;

        internal DocumentationCommentParser(Lexer lexer, LexerMode modeflags)
        : base(f_10026_1621_1626_C(lexer), LexerMode.XmlDocComment | LexerMode.XmlDocCommentLocationStart | modeflags, null, null, true)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10026, 1531, 1829);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 1454, 1482);
                this._pool = f_10026_1462_1482(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 1506, 1518);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 13872, 13911);
                this._attributesSeen = f_10026_13890_13911(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 1746, 1818);

                _isDelimited = (modeflags & LexerMode.XmlDocCommentStyleDelimited) != 0;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10026, 1531, 1829);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10026, 1531, 1829);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10026, 1531, 1829);
            }
        }

        internal void ReInitialize(LexerMode modeflags)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10026, 1841, 2131);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 1913, 1933);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.ReInitialize(), 10026, 1913, 1932);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 1947, 2034);

                this.Mode = LexerMode.XmlDocComment | LexerMode.XmlDocCommentLocationStart | modeflags;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 2048, 2120);

                _isDelimited = (modeflags & LexerMode.XmlDocCommentStyleDelimited) != 0;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10026, 1841, 2131);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10026, 1841, 2131);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10026, 1841, 2131);
            }
        }

        private LexerMode SetMode(LexerMode mode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10026, 2143, 2379);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 2209, 2229);

                var
                tmp = f_10026_2219_2228(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 2243, 2343);

                this.Mode = mode | (tmp & (LexerMode.MaskXmlDocCommentLocation | LexerMode.MaskXmlDocCommentStyle));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 2357, 2368);

                return tmp;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10026, 2143, 2379);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LexerMode
                f_10026_2219_2228(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.Mode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 2219, 2228);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10026, 2143, 2379);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10026, 2143, 2379);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void ResetMode(LexerMode mode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10026, 2391, 2482);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 2454, 2471);

                this.Mode = mode;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10026, 2391, 2482);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10026, 2391, 2482);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10026, 2391, 2482);
            }
        }

        public DocumentationCommentTriviaSyntax ParseDocumentationComment(out bool isTerminated)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10026, 2494, 4121);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 2607, 2651);

                var
                nodes = f_10026_2619_2650(_pool)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 2701, 2727);

                    f_10026_2701_2726(this, nodes);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 3368, 3527) || true) && (f_10026_3372_3394(f_10026_3372_3389(this)) != SyntaxKind.EndOfDocumentationCommentToken)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 3368, 3527);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 3481, 3508);

                        f_10026_3481_3507(this, nodes);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 3368, 3527);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 3547, 3614);

                    var
                    eoc = f_10026_3557_3613(this, SyntaxKind.EndOfDocumentationCommentToken)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 3634, 3765);

                    isTerminated = !_isDelimited || (DynAbs.Tracing.TraceSender.Expression_False(10026, 3649, 3764) || (eoc.LeadingTrivia.Count > 0 && (DynAbs.Tracing.TraceSender.Expression_True(10026, 3667, 3763) && f_10026_3698_3755(f_10026_3698_3715(eoc)[eoc.LeadingTrivia.Count - 1]) == "*/")));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 3783, 3913);

                    SyntaxKind
                    kind = (DynAbs.Tracing.TraceSender.Conditional_F1(10026, 3801, 3813) || ((_isDelimited && DynAbs.Tracing.TraceSender.Conditional_F2(10026, 3816, 3862)) || DynAbs.Tracing.TraceSender.Conditional_F3(10026, 3865, 3912))) ? SyntaxKind.MultiLineDocumentationCommentTrivia : SyntaxKind.SingleLineDocumentationCommentTrivia
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 3933, 4008);

                    return f_10026_3940_4007(kind, nodes.ToList(), eoc);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(10026, 4037, 4110);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 4077, 4095);

                    f_10026_4077_4094(_pool, nodes);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(10026, 4037, 4110);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10026, 2494, 4121);

                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlNodeSyntax>
                f_10026_2619_2650(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListPool
                this_param)
                {
                    var return_v = this_param.Allocate<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlNodeSyntax>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 2619, 2650);
                    return return_v;
                }


                int
                f_10026_2701_2726(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlNodeSyntax>
                nodes)
                {
                    this_param.ParseXmlNodes(nodes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 2701, 2726);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_3372_3389(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 3372, 3389);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10026_3372_3394(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 3372, 3394);
                    return return_v;
                }


                int
                f_10026_3481_3507(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlNodeSyntax>
                nodes)
                {
                    this_param.ParseRemainder(nodes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 3481, 3507);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_3557_3613(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = this_param.EatToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 3557, 3613);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode>
                f_10026_3698_3715(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.LeadingTrivia;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 3698, 3715);
                    return return_v;
                }


                string
                f_10026_3698_3755(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode?
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 3698, 3755);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentTriviaSyntax
                f_10026_3940_4007(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlNodeSyntax>
                content, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                endOfComment)
                {
                    var return_v = SyntaxFactory.DocumentationCommentTrivia(kind, content, endOfComment);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 3940, 4007);
                    return return_v;
                }


                int
                f_10026_4077_4094(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListPool
                this_param, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlNodeSyntax>
                item)
                {
                    this_param.Free((Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 4077, 4094);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10026, 2494, 4121);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10026, 2494, 4121);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void ParseRemainder(SyntaxListBuilder<XmlNodeSyntax> nodes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10026, 4133, 5337);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 4224, 4294);

                bool
                endTag = f_10026_4238_4260(f_10026_4238_4255(this)) == SyntaxKind.LessThanSlashToken
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 4310, 4369);

                var
                saveMode = f_10026_4325_4368(this, LexerMode.XmlCDataSectionText)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 4385, 4419);

                var
                textTokens = f_10026_4402_4418(_pool)
                ;
                try
                {
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 4469, 4787) || true) && (f_10026_4476_4498(f_10026_4476_4493(this)) != SyntaxKind.EndOfDocumentationCommentToken)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 4469, 4787);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 4585, 4613);

                            var
                            token = f_10026_4597_4612(this)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 4746, 4768);

                            f_10026_4746_4767(
                                                // TODO: It is possible that a non-literal gets in here. ]]>, specifically. Is that ok?
                                                textTokens, token);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 4469, 4787);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10026, 4469, 4787);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10026, 4469, 4787);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 4807, 4873);

                    var
                    allRemainderText = f_10026_4830_4872(f_10026_4852_4871(textTokens))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 4893, 5008);

                    XmlParseErrorCode
                    code = (DynAbs.Tracing.TraceSender.Conditional_F1(10026, 4918, 4924) || ((endTag && DynAbs.Tracing.TraceSender.Conditional_F2(10026, 4927, 4966)) || DynAbs.Tracing.TraceSender.Conditional_F3(10026, 4969, 5007))) ? XmlParseErrorCode.XML_EndTagNotExpected : XmlParseErrorCode.XML_ExpectedEndOfXml
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 5026, 5130);

                    allRemainderText = f_10026_5045_5129(this, allRemainderText, f_10026_5089_5128(0, 1, code));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 5150, 5178);

                    nodes.Add(allRemainderText);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(10026, 5207, 5285);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 5247, 5270);

                    f_10026_5247_5269(_pool, textTokens);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(10026, 5207, 5285);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 5301, 5326);

                f_10026_5301_5325(
                            this, saveMode);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10026, 4133, 5337);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_4238_4255(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 4238, 4255);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10026_4238_4260(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 4238, 4260);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LexerMode
                f_10026_4325_4368(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LexerMode
                mode)
                {
                    var return_v = this_param.SetMode(mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 4325, 4368);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                f_10026_4402_4418(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListPool
                this_param)
                {
                    var return_v = this_param.Allocate();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 4402, 4418);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_4476_4493(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 4476, 4493);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10026_4476_4498(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 4476, 4498);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_4597_4612(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.EatToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 4597, 4612);
                    return return_v;
                }


                int
                f_10026_4746_4767(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.GreenNode)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 4746, 4767);
                    return 0;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.GreenNode>
                f_10026_4852_4871(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                this_param)
                {
                    var return_v = this_param.ToList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 4852, 4871);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlTextSyntax
                f_10026_4830_4872(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.GreenNode>
                textTokens)
                {
                    var return_v = SyntaxFactory.XmlText((Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>)textTokens);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 4830, 4872);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.XmlSyntaxDiagnosticInfo
                f_10026_5089_5128(int
                offset, int
                width, Microsoft.CodeAnalysis.CSharp.XmlParseErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.XmlSyntaxDiagnosticInfo(offset, width, code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 5089, 5128);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlTextSyntax
                f_10026_5045_5129(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlTextSyntax
                node, params Microsoft.CodeAnalysis.DiagnosticInfo[]
                diagnostics)
                {
                    var return_v = this_param.WithAdditionalDiagnostics<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlTextSyntax>(node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 5045, 5129);
                    return return_v;
                }


                int
                f_10026_5247_5269(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListPool
                this_param, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                item)
                {
                    this_param.Free(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 5247, 5269);
                    return 0;
                }


                int
                f_10026_5301_5325(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LexerMode
                mode)
                {
                    this_param.ResetMode(mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 5301, 5325);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10026, 4133, 5337);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10026, 4133, 5337);
            }
        }

        private void ParseXmlNodes(SyntaxListBuilder<XmlNodeSyntax> nodes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10026, 5349, 5680);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 5440, 5669) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 5440, 5669);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 5485, 5516);

                        var
                        node = f_10026_5496_5515(this)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 5534, 5618) || true) && (node == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 5534, 5618);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 5592, 5599);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 5534, 5618);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 5638, 5654);

                        nodes.Add(node);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 5440, 5669);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10026, 5440, 5669);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10026, 5440, 5669);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10026, 5349, 5680);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlNodeSyntax
                f_10026_5496_5515(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.ParseXmlNode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 5496, 5515);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10026, 5349, 5680);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10026, 5349, 5680);
            }
        }

        private XmlNodeSyntax ParseXmlNode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10026, 5692, 6759);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 5753, 6748);

                switch (f_10026_5761_5783(f_10026_5761_5778(this)))
                {

                    case SyntaxKind.XmlTextLiteralToken:
                    case SyntaxKind.XmlTextLiteralNewLineToken:
                    case SyntaxKind.XmlEntityLiteralToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 5753, 6748);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 5992, 6019);

                        return f_10026_5999_6018(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 5753, 6748);

                    case SyntaxKind.LessThanToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 5753, 6748);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 6089, 6119);

                        return f_10026_6096_6118(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 5753, 6748);

                    case SyntaxKind.XmlCommentStartToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 5753, 6748);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 6196, 6226);

                        return f_10026_6203_6225(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 5753, 6748);

                    case SyntaxKind.XmlCDataStartToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 5753, 6748);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 6301, 6336);

                        return f_10026_6308_6335(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 5753, 6748);

                    case SyntaxKind.XmlProcessingInstructionStartToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 5753, 6748);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 6427, 6471);

                        return f_10026_6434_6470(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 5753, 6748);

                    case SyntaxKind.EndOfDocumentationCommentToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 5753, 6748);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 6558, 6570);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 5753, 6748);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 5753, 6748);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 6721, 6733);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 5753, 6748);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10026, 5692, 6759);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_5761_5778(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 5761, 5778);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10026_5761_5783(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 5761, 5783);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlNodeSyntax
                f_10026_5999_6018(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.ParseXmlText();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 5999, 6018);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlNodeSyntax
                f_10026_6096_6118(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.ParseXmlElement();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 6096, 6118);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlCommentSyntax
                f_10026_6203_6225(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.ParseXmlComment();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 6203, 6225);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlCDataSectionSyntax
                f_10026_6308_6335(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.ParseXmlCDataSection();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 6308, 6335);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlProcessingInstructionSyntax
                f_10026_6434_6470(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.ParseXmlProcessingInstruction();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 6434, 6470);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10026, 5692, 6759);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10026, 5692, 6759);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool IsXmlNodeStartOrStop()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10026, 6771, 7448);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 6831, 7437);

                switch (f_10026_6839_6861(f_10026_6839_6856(this)))
                {

                    case SyntaxKind.LessThanToken:
                    case SyntaxKind.LessThanSlashToken:
                    case SyntaxKind.XmlCommentStartToken:
                    case SyntaxKind.XmlCDataStartToken:
                    case SyntaxKind.XmlProcessingInstructionStartToken:
                    case SyntaxKind.GreaterThanToken:
                    case SyntaxKind.SlashGreaterThanToken:
                    case SyntaxKind.EndOfDocumentationCommentToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 6831, 7437);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 7349, 7361);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 6831, 7437);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 6831, 7437);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 7409, 7422);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 6831, 7437);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10026, 6771, 7448);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_6839_6856(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 6839, 6856);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10026_6839_6861(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 6839, 6861);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10026, 6771, 7448);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10026, 6771, 7448);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private XmlNodeSyntax ParseXmlText()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10026, 7460, 8020);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 7521, 7555);

                var
                textTokens = f_10026_7538_7554(_pool)
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 7569, 7876) || true) && (f_10026_7576_7598(f_10026_7576_7593(this)) == SyntaxKind.XmlTextLiteralToken
                    || (DynAbs.Tracing.TraceSender.Expression_False(10026, 7576, 7716) || f_10026_7653_7675(f_10026_7653_7670(this)) == SyntaxKind.XmlTextLiteralNewLineToken
                    ) || (DynAbs.Tracing.TraceSender.Expression_False(10026, 7576, 7795) || f_10026_7737_7759(f_10026_7737_7754(this)) == SyntaxKind.XmlEntityLiteralToken))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 7569, 7876);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 7829, 7861);

                        f_10026_7829_7860(textTokens, f_10026_7844_7859(this));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 7569, 7876);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10026, 7569, 7876);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10026, 7569, 7876);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 7892, 7923);

                var
                list = f_10026_7903_7922(textTokens)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 7937, 7960);

                f_10026_7937_7959(_pool, textTokens);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 7974, 8009);

                return f_10026_7981_8008(list);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10026, 7460, 8020);

                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                f_10026_7538_7554(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListPool
                this_param)
                {
                    var return_v = this_param.Allocate();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 7538, 7554);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_7576_7593(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 7576, 7593);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10026_7576_7598(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 7576, 7598);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_7653_7670(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 7653, 7670);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10026_7653_7675(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 7653, 7675);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_7737_7754(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 7737, 7754);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10026_7737_7759(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 7737, 7759);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_7844_7859(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.EatToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 7844, 7859);
                    return return_v;
                }


                int
                f_10026_7829_7860(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.GreenNode)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 7829, 7860);
                    return 0;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.GreenNode>
                f_10026_7903_7922(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                this_param)
                {
                    var return_v = this_param.ToList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 7903, 7922);
                    return return_v;
                }


                int
                f_10026_7937_7959(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListPool
                this_param, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                item)
                {
                    this_param.Free(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 7937, 7959);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlTextSyntax
                f_10026_7981_8008(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.GreenNode>
                textTokens)
                {
                    var return_v = SyntaxFactory.XmlText((Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>)textTokens);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 7981, 8008);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10026, 7460, 8020);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10026, 7460, 8020);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private XmlNodeSyntax ParseXmlElement()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10026, 8032, 12863);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 8096, 8151);

                var
                lessThan = f_10026_8111_8150(this, SyntaxKind.LessThanToken)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 8179, 8232);

                var
                saveMode = f_10026_8194_8231(this, LexerMode.XmlElementTag)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 8246, 8277);

                var
                name = f_10026_8257_8276(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 8291, 8595) || true) && (f_10026_8295_8328(lessThan) > 0 || (DynAbs.Tracing.TraceSender.Expression_False(10026, 8295, 8368) || f_10026_8336_8364(name) > 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 8291, 8595);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 8503, 8580);

                    name = f_10026_8510_8579(this, name, XmlParseErrorCode.XML_InvalidWhitespace);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 8291, 8595);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 8611, 8660);

                var
                attrs = f_10026_8623_8659(_pool)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 8710, 8751);

                    f_10026_8710_8750(this, ref name, attrs);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 8771, 12750) || true) && (f_10026_8775_8797(f_10026_8775_8792(this)) == SyntaxKind.GreaterThanToken)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 8771, 12750);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 8870, 8958);

                        var
                        startTag = f_10026_8885_8957(lessThan, name, attrs, f_10026_8941_8956(this))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 8980, 9018);

                        f_10026_8980_9017(this, LexerMode.XmlDocComment);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 9040, 9084);

                        var
                        nodes = f_10026_9052_9083(_pool)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 9158, 9184);

                            f_10026_9158_9183(this, nodes);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 9212, 9234);

                            XmlNameSyntax
                            endName
                            = default(XmlNameSyntax);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 9260, 9284);

                            SyntaxToken
                            greaterThan
                            = default(SyntaxToken);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 9348, 9433);

                            var
                            lessThanSlash = f_10026_9368_9432(this, SyntaxKind.LessThanSlashToken, reportError: false)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 9638, 11787) || true) && (f_10026_9642_9665(lessThanSlash))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 9638, 11787);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 9723, 9748);

                                f_10026_9723_9747(this, saveMode);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 9778, 9887);

                                lessThanSlash = f_10026_9794_9886(this, lessThanSlash, XmlParseErrorCode.XML_EndTagExpected, f_10026_9870_9885(name));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 9917, 10030);

                                endName = f_10026_9927_10029(prefix: null, localName: f_10026_9974_10028(SyntaxKind.IdentifierToken));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 10060, 10130);

                                greaterThan = f_10026_10074_10129(SyntaxKind.GreaterThanToken);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 9638, 11787);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 9638, 11787);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 10244, 10282);

                                f_10026_10244_10281(this, LexerMode.XmlElementTag);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 10312, 10342);

                                endName = f_10026_10322_10341(this);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 10372, 10754) || true) && (f_10026_10376_10414(lessThanSlash) > 0 || (DynAbs.Tracing.TraceSender.Expression_False(10026, 10376, 10457) || f_10026_10422_10453(endName) > 0))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 10372, 10754);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 10640, 10723);

                                    endName = f_10026_10650_10722(this, endName, XmlParseErrorCode.XML_InvalidWhitespace);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 10372, 10754);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 10786, 11060) || true) && (f_10026_10790_10808_M(!endName.IsMissing) && (DynAbs.Tracing.TraceSender.Expression_True(10026, 10790, 10844) && !f_10026_10813_10844(name, endName)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 10786, 11060);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 10910, 11029);

                                    endName = f_10026_10920_11028(this, endName, XmlParseErrorCode.XML_ElementTypeMatch, f_10026_10992_11010(endName), f_10026_11012_11027(name));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 10786, 11060);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 11206, 11671) || true) && (f_10026_11210_11232(f_10026_11210_11227(this)) != SyntaxKind.GreaterThanToken)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 11206, 11671);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 11329, 11640);

                                    f_10026_11329_11639(this, ref endName, null, p => p.CurrentToken.Kind != SyntaxKind.GreaterThanToken, p => p.IsXmlNodeStartOrStop(), XmlParseErrorCode.XML_InvalidToken);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 11206, 11671);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 11703, 11760);

                                greaterThan = f_10026_11717_11759(this, SyntaxKind.GreaterThanToken);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 9638, 11787);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 11815, 11896);

                            var
                            endTag = f_10026_11828_11895(lessThanSlash, endName, greaterThan)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 11922, 11947);

                            f_10026_11922_11946(this, saveMode);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 11973, 12039);

                            return f_10026_11980_12038(startTag, nodes.ToList(), endTag);
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinally(10026, 12084, 12181);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 12140, 12158);

                            f_10026_12140_12157(_pool, nodes);
                            DynAbs.Tracing.TraceSender.TraceExitFinally(10026, 12084, 12181);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 8771, 12750);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 8771, 12750);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 12263, 12337);

                        var
                        slashGreater = f_10026_12282_12336(this, SyntaxKind.SlashGreaterThanToken, false)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 12359, 12586) || true) && (f_10026_12363_12385(slashGreater) && (DynAbs.Tracing.TraceSender.Expression_True(10026, 12363, 12404) && f_10026_12389_12404_M(!name.IsMissing)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 12359, 12586);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 12454, 12563);

                            slashGreater = f_10026_12469_12562(this, slashGreater, XmlParseErrorCode.XML_ExpectedEndOfTag, f_10026_12546_12561(name));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 12359, 12586);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 12610, 12635);

                        f_10026_12610_12634(
                                            this, saveMode);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 12657, 12731);

                        return f_10026_12664_12730(lessThan, name, attrs, slashGreater);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 8771, 12750);
                    }
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(10026, 12779, 12852);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 12819, 12837);

                    f_10026_12819_12836(_pool, attrs);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(10026, 12779, 12852);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10026, 8032, 12863);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_8111_8150(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = this_param.EatToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 8111, 8150);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LexerMode
                f_10026_8194_8231(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LexerMode
                mode)
                {
                    var return_v = this_param.SetMode(mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 8194, 8231);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlNameSyntax
                f_10026_8257_8276(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.ParseXmlName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 8257, 8276);
                    return return_v;
                }


                int
                f_10026_8295_8328(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.GetTrailingTriviaWidth();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 8295, 8328);
                    return return_v;
                }


                int
                f_10026_8336_8364(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlNameSyntax
                this_param)
                {
                    var return_v = this_param.GetLeadingTriviaWidth();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 8336, 8364);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlNameSyntax
                f_10026_8510_8579(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlNameSyntax
                node, Microsoft.CodeAnalysis.CSharp.XmlParseErrorCode
                code)
                {
                    var return_v = this_param.WithXmlParseError<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlNameSyntax>(node, code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 8510, 8579);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlAttributeSyntax>
                f_10026_8623_8659(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListPool
                this_param)
                {
                    var return_v = this_param.Allocate<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlAttributeSyntax>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 8623, 8659);
                    return return_v;
                }


                int
                f_10026_8710_8750(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, ref Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlNameSyntax
                elementName, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlAttributeSyntax>
                attrs)
                {
                    this_param.ParseXmlAttributes(ref elementName, attrs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 8710, 8750);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_8775_8792(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 8775, 8792);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10026_8775_8797(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 8775, 8797);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_8941_8956(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.EatToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 8941, 8956);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlElementStartTagSyntax
                f_10026_8885_8957(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                lessThanToken, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlNameSyntax
                name, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlAttributeSyntax>
                attributes, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                greaterThanToken)
                {
                    var return_v = SyntaxFactory.XmlElementStartTag(lessThanToken, name, (Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlAttributeSyntax>)attributes, greaterThanToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 8885, 8957);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LexerMode
                f_10026_8980_9017(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LexerMode
                mode)
                {
                    var return_v = this_param.SetMode(mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 8980, 9017);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlNodeSyntax>
                f_10026_9052_9083(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListPool
                this_param)
                {
                    var return_v = this_param.Allocate<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlNodeSyntax>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 9052, 9083);
                    return return_v;
                }


                int
                f_10026_9158_9183(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlNodeSyntax>
                nodes)
                {
                    this_param.ParseXmlNodes(nodes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 9158, 9183);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_9368_9432(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, bool
                reportError)
                {
                    var return_v = this_param.EatToken(kind, reportError: reportError);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 9368, 9432);
                    return return_v;
                }


                bool
                f_10026_9642_9665(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.IsMissing;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 9642, 9665);
                    return return_v;
                }


                int
                f_10026_9723_9747(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LexerMode
                mode)
                {
                    this_param.ResetMode(mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 9723, 9747);
                    return 0;
                }


                string
                f_10026_9870_9885(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlNameSyntax
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 9870, 9885);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_9794_9886(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                node, Microsoft.CodeAnalysis.CSharp.XmlParseErrorCode
                code, params string[]
                args)
                {
                    var return_v = this_param.WithXmlParseError(node, code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 9794, 9886);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_9974_10028(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFactory.MissingToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 9974, 10028);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlNameSyntax
                f_10026_9927_10029(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlPrefixSyntax?
                prefix, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                localName)
                {
                    var return_v = SyntaxFactory.XmlName(prefix: prefix, localName: localName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 9927, 10029);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_10074_10129(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFactory.MissingToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 10074, 10129);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LexerMode
                f_10026_10244_10281(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LexerMode
                mode)
                {
                    var return_v = this_param.SetMode(mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 10244, 10281);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlNameSyntax
                f_10026_10322_10341(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.ParseXmlName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 10322, 10341);
                    return return_v;
                }


                int
                f_10026_10376_10414(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.GetTrailingTriviaWidth();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 10376, 10414);
                    return return_v;
                }


                int
                f_10026_10422_10453(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlNameSyntax
                this_param)
                {
                    var return_v = this_param.GetLeadingTriviaWidth();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 10422, 10453);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlNameSyntax
                f_10026_10650_10722(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlNameSyntax
                node, Microsoft.CodeAnalysis.CSharp.XmlParseErrorCode
                code)
                {
                    var return_v = this_param.WithXmlParseError<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlNameSyntax>(node, code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 10650, 10722);
                    return return_v;
                }


                bool
                f_10026_10790_10808_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 10790, 10808);
                    return return_v;
                }


                bool
                f_10026_10813_10844(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlNameSyntax
                name, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlNameSyntax
                endName)
                {
                    var return_v = MatchingXmlNames(name, endName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 10813, 10844);
                    return return_v;
                }


                string
                f_10026_10992_11010(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlNameSyntax
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 10992, 11010);
                    return return_v;
                }


                string
                f_10026_11012_11027(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlNameSyntax
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 11012, 11027);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlNameSyntax
                f_10026_10920_11028(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlNameSyntax
                node, Microsoft.CodeAnalysis.CSharp.XmlParseErrorCode
                code, params string[]
                args)
                {
                    var return_v = this_param.WithXmlParseError<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlNameSyntax>(node, code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 10920, 11028);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_11210_11227(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 11210, 11227);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10026_11210_11232(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 11210, 11232);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser.SkipResult
                f_10026_11329_11639(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, ref Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlNameSyntax
                startNode, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                list, System.Func<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser, bool>
                isNotExpectedFunction, System.Func<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser, bool>
                abortFunction, Microsoft.CodeAnalysis.CSharp.XmlParseErrorCode
                error)
                {
                    var return_v = this_param.SkipBadTokens<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlNameSyntax>(ref startNode, list, isNotExpectedFunction, abortFunction, error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 11329, 11639);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_11717_11759(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = this_param.EatToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 11717, 11759);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlElementEndTagSyntax
                f_10026_11828_11895(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                lessThanSlashToken, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlNameSyntax
                name, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                greaterThanToken)
                {
                    var return_v = SyntaxFactory.XmlElementEndTag(lessThanSlashToken, name, greaterThanToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 11828, 11895);
                    return return_v;
                }


                int
                f_10026_11922_11946(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LexerMode
                mode)
                {
                    this_param.ResetMode(mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 11922, 11946);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlElementSyntax
                f_10026_11980_12038(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlElementStartTagSyntax
                startTag, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlNodeSyntax>
                content, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlElementEndTagSyntax
                endTag)
                {
                    var return_v = SyntaxFactory.XmlElement(startTag, content, endTag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 11980, 12038);
                    return return_v;
                }


                int
                f_10026_12140_12157(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListPool
                this_param, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlNodeSyntax>
                item)
                {
                    this_param.Free((Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 12140, 12157);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_12282_12336(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, bool
                reportError)
                {
                    var return_v = this_param.EatToken(kind, reportError);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 12282, 12336);
                    return return_v;
                }


                bool
                f_10026_12363_12385(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.IsMissing;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 12363, 12385);
                    return return_v;
                }


                bool
                f_10026_12389_12404_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 12389, 12404);
                    return return_v;
                }


                string
                f_10026_12546_12561(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlNameSyntax
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 12546, 12561);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_12469_12562(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                node, Microsoft.CodeAnalysis.CSharp.XmlParseErrorCode
                code, params string[]
                args)
                {
                    var return_v = this_param.WithXmlParseError(node, code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 12469, 12562);
                    return return_v;
                }


                int
                f_10026_12610_12634(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LexerMode
                mode)
                {
                    this_param.ResetMode(mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 12610, 12634);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlEmptyElementSyntax
                f_10026_12664_12730(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                lessThanToken, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlNameSyntax
                name, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlAttributeSyntax>
                attributes, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                slashGreaterThanToken)
                {
                    var return_v = SyntaxFactory.XmlEmptyElement(lessThanToken, name, (Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlAttributeSyntax>)attributes, slashGreaterThanToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 12664, 12730);
                    return return_v;
                }


                int
                f_10026_12819_12836(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListPool
                this_param, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlAttributeSyntax>
                item)
                {
                    this_param.Free((Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 12819, 12836);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10026, 8032, 12863);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10026, 8032, 12863);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool MatchingXmlNames(XmlNameSyntax name, XmlNameSyntax endName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10026, 12875, 13776);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 13220, 13300) || true) && (name == endName)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 13220, 13300);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 13273, 13285);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 13220, 13300);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 13521, 13704) || true) && (f_10026_13525_13547_M(!name.HasLeadingTrivia) && (DynAbs.Tracing.TraceSender.Expression_True(10026, 13525, 13594) && f_10026_13568_13594_M(!endName.HasTrailingTrivia)) && (DynAbs.Tracing.TraceSender.Expression_True(10026, 13525, 13643) && f_10026_13615_13643(name, endName)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 13521, 13704);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 13677, 13689);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 13521, 13704);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 13720, 13765);

                return f_10026_13727_13742(name) == f_10026_13746_13764(endName);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10026, 12875, 13776);

                bool
                f_10026_13525_13547_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 13525, 13547);
                    return return_v;
                }


                bool
                f_10026_13568_13594_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 13568, 13594);
                    return return_v;
                }


                bool
                f_10026_13615_13643(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlNameSyntax
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlNameSyntax
                other)
                {
                    var return_v = this_param.IsEquivalentTo((Microsoft.CodeAnalysis.GreenNode)other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 13615, 13643);
                    return return_v;
                }


                string
                f_10026_13727_13742(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlNameSyntax
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 13727, 13742);
                    return return_v;
                }


                string
                f_10026_13746_13764(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlNameSyntax
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 13746, 13764);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10026, 12875, 13776);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10026, 12875, 13776);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private readonly HashSet<string> _attributesSeen;

        private void ParseXmlAttributes(ref XmlNameSyntax elementName, SyntaxListBuilder<XmlAttributeSyntax> attrs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10026, 13924, 15868);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 14056, 14080);

                f_10026_14056_14079(_attributesSeen);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 14094, 15857) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 14094, 15857);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 14139, 15842) || true) && (f_10026_14143_14165(f_10026_14143_14160(this)) == SyntaxKind.IdentifierToken)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 14139, 15842);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 14237, 14284);

                            var
                            attr = f_10026_14248_14283(this, elementName)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 14306, 14345);

                            string
                            attrName = f_10026_14324_14344(f_10026_14324_14333(attr))
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 14367, 14694) || true) && (f_10026_14371_14405(_attributesSeen, attrName))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 14367, 14694);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 14455, 14543);

                                attr = f_10026_14462_14542(this, attr, XmlParseErrorCode.XML_DuplicateAttribute, attrName);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 14367, 14694);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 14367, 14694);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 14641, 14671);

                                f_10026_14641_14670(_attributesSeen, attrName);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 14367, 14694);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 14718, 14734);

                            attrs.Add(attr);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 14139, 15842);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 14139, 15842);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 14816, 15692);

                            var
                            skip = f_10026_14827_15691(this, ref elementName, attrs, p => p.CurrentToken.Kind != SyntaxKind.IdentifierName, p => p.CurrentToken.Kind == SyntaxKind.GreaterThanToken
                                                        || p.CurrentToken.Kind == SyntaxKind.SlashGreaterThanToken
                                                        || p.CurrentToken.Kind == SyntaxKind.LessThanToken
                                                        || p.CurrentToken.Kind == SyntaxKind.LessThanSlashToken
                                                        || p.CurrentToken.Kind == SyntaxKind.EndOfDocumentationCommentToken
                                                        || p.CurrentToken.Kind == SyntaxKind.EndOfFileToken, XmlParseErrorCode.XML_InvalidToken)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 15716, 15823) || true) && (skip == SkipResult.Abort)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 15716, 15823);
                                DynAbs.Tracing.TraceSender.TraceBreak(10026, 15794, 15800);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 15716, 15823);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 14139, 15842);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 14094, 15857);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10026, 14094, 15857);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10026, 14094, 15857);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10026, 13924, 15868);

                int
                f_10026_14056_14079(System.Collections.Generic.HashSet<string>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 14056, 14079);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_14143_14160(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 14143, 14160);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10026_14143_14165(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 14143, 14165);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlAttributeSyntax
                f_10026_14248_14283(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlNameSyntax
                elementName)
                {
                    var return_v = this_param.ParseXmlAttribute(elementName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 14248, 14283);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlNameSyntax
                f_10026_14324_14333(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlAttributeSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 14324, 14333);
                    return return_v;
                }


                string
                f_10026_14324_14344(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlNameSyntax
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 14324, 14344);
                    return return_v;
                }


                bool
                f_10026_14371_14405(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 14371, 14405);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlAttributeSyntax
                f_10026_14462_14542(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlAttributeSyntax
                node, Microsoft.CodeAnalysis.CSharp.XmlParseErrorCode
                code, params string[]
                args)
                {
                    var return_v = this_param.WithXmlParseError<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlAttributeSyntax>(node, code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 14462, 14542);
                    return return_v;
                }


                bool
                f_10026_14641_14670(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 14641, 14670);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser.SkipResult
                f_10026_14827_15691(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, ref Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlNameSyntax
                startNode, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlAttributeSyntax>
                list, System.Func<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser, bool>
                isNotExpectedFunction, System.Func<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser, bool>
                abortFunction, Microsoft.CodeAnalysis.CSharp.XmlParseErrorCode
                error)
                {
                    var return_v = this_param.SkipBadTokens<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlNameSyntax>(ref startNode, (Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder)list, isNotExpectedFunction, abortFunction, error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 14827, 15691);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10026, 13924, 15868);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10026, 13924, 15868);
            }
        }

        private enum SkipResult
        {
            Continue,
            Abort
        }

        private SkipResult SkipBadTokens<T>(
                    ref T startNode,
                    SyntaxListBuilder list,
                    Func<DocumentationCommentParser, bool> isNotExpectedFunction,
                    Func<DocumentationCommentParser, bool> abortFunction,
                    XmlParseErrorCode error
                    ) where T : CSharpSyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10026, 15979, 18305);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 16328, 16384);

                var
                badTokens = default(SyntaxListBuilder<SyntaxToken>)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 16398, 16420);

                bool
                hasError = false
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 16472, 16512);

                    SkipResult
                    result = SkipResult.Continue
                    ;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 16532, 17250) || true) && (f_10026_16539_16566<T>(isNotExpectedFunction, this))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 16532, 17250);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 16608, 16762) || true) && (f_10026_16612_16631<T>(abortFunction, this))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 16608, 16762);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 16681, 16707);

                                result = SkipResult.Abort;
                                DynAbs.Tracing.TraceSender.TraceBreak(10026, 16733, 16739);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 16608, 16762);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 16786, 16921) || true) && (badTokens.IsNull)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 16786, 16921);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 16856, 16898);

                                badTokens = f_10026_16868_16897<T>(_pool);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 16786, 16921);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 16945, 16973);

                            var
                            token = f_10026_16957_16972<T>(this)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 16995, 17186) || true) && (!hasError)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 16995, 17186);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 17058, 17121);

                                token = f_10026_17066_17120<T>(this, token, error, f_10026_17103_17119<T>(token));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 17147, 17163);

                                hasError = true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 16995, 17186);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 17210, 17231);

                            badTokens.Add(token);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 16532, 17250);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10026, 16532, 17250);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10026, 16532, 17250);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 17270, 18106) || true) && (f_10026_17274_17291_M(!badTokens.IsNull) && (DynAbs.Tracing.TraceSender.Expression_True(10026, 17274, 17314) && badTokens.Count > 0))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 17270, 18106);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 17457, 17847) || true) && (list == null || (DynAbs.Tracing.TraceSender.Expression_False(10026, 17461, 17492) || f_10026_17477_17487<T>(list) == 0))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 17457, 17847);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 17542, 17614);

                            startNode = f_10026_17554_17613<T>(this, startNode, badTokens.ToListNode());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 17457, 17847);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 17457, 17847);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 17712, 17824);

                            list[f_10026_17717_17727<T>(list) - 1] = f_10026_17735_17823<T>(this, f_10026_17778_17798<T>(list, f_10026_17783_17793<T>(list) - 1), badTokens.ToListNode());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 17457, 17847);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 17871, 17885);

                        return result;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 17270, 18106);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 17270, 18106);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 18063, 18087);

                        return SkipResult.Abort;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 17270, 18106);
                    }
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(10026, 18135, 18294);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 18175, 18279) || true) && (f_10026_18179_18196_M(!badTokens.IsNull))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 18175, 18279);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 18238, 18260);

                        f_10026_18238_18259<T>(_pool, badTokens);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 18175, 18279);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitFinally(10026, 18135, 18294);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10026, 15979, 18305);

                bool
                f_10026_16539_16566<T>(System.Func<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser, bool>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                arg) where T : CSharpSyntaxNode

                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 16539, 16566);
                    return return_v;
                }


                bool
                f_10026_16612_16631<T>(System.Func<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser, bool>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                arg) where T : CSharpSyntaxNode

                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 16612, 16631);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>
                f_10026_16868_16897<T>(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListPool
                this_param) where T : CSharpSyntaxNode

                {
                    var return_v = this_param.Allocate<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 16868, 16897);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_16957_16972<T>(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param) where T : CSharpSyntaxNode

                {
                    var return_v = this_param.EatToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 16957, 16972);
                    return return_v;
                }


                string
                f_10026_17103_17119<T>(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param) where T : CSharpSyntaxNode

                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 17103, 17119);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_17066_17120<T>(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                node, Microsoft.CodeAnalysis.CSharp.XmlParseErrorCode
                code, params string[]
                args) where T : CSharpSyntaxNode

                {
                    var return_v = this_param.WithXmlParseError(node, code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 17066, 17120);
                    return return_v;
                }


                bool
                f_10026_17274_17291_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 17274, 17291);
                    return return_v;
                }


                int
                f_10026_17477_17487<T>(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                this_param) where T : CSharpSyntaxNode

                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 17477, 17487);
                    return return_v;
                }


                T
                f_10026_17554_17613<T>(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, T
                node, Microsoft.CodeAnalysis.GreenNode?
                skippedSyntax) where T : CSharpSyntaxNode

                {
                    var return_v = this_param.AddTrailingSkippedSyntax<T>(node, skippedSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 17554, 17613);
                    return return_v;
                }


                int
                f_10026_17717_17727<T>(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                this_param) where T : CSharpSyntaxNode

                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 17717, 17727);
                    return return_v;
                }


                int
                f_10026_17783_17793<T>(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                this_param) where T : CSharpSyntaxNode

                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 17783, 17793);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode?
                f_10026_17778_17798<T>(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                this_param, int
                i0) where T : CSharpSyntaxNode

                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 17778, 17798);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode?
                f_10026_17735_17823<T>(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.GreenNode?
                node, Microsoft.CodeAnalysis.GreenNode?
                skippedSyntax) where T : CSharpSyntaxNode

                {
                    var return_v = this_param.AddTrailingSkippedSyntax<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode?>((Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode?)node, skippedSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 17735, 17823);
                    return return_v;
                }


                bool
                f_10026_18179_18196_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 18179, 18196);
                    return return_v;
                }


                int
                f_10026_18238_18259<T>(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListPool
                this_param, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>
                item) where T : CSharpSyntaxNode

                {
                    this_param.Free((Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 18238, 18259);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10026, 15979, 18305);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10026, 15979, 18305);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private XmlAttributeSyntax ParseXmlAttribute(XmlNameSyntax elementName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10026, 18317, 21372);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 18413, 18448);

                var
                attrName = f_10026_18428_18447(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 18462, 18737) || true) && (f_10026_18466_18498(attrName) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 18462, 18737);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 18637, 18722);

                    attrName = f_10026_18648_18721(this, attrName, XmlParseErrorCode.XML_WhitespaceMissing);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 18462, 18737);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 18753, 18811);

                var
                equals = f_10026_18766_18810(this, SyntaxKind.EqualsToken, false)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 18825, 19770) || true) && (f_10026_18829_18845(equals))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 18825, 19770);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 18879, 18965);

                    equals = f_10026_18888_18964(this, equals, XmlParseErrorCode.XML_MissingEqualsAttribute);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 18985, 19755);

                    switch (f_10026_18993_19015(f_10026_18993_19010(this)))
                    {

                        case SyntaxKind.SingleQuoteToken:
                        case SyntaxKind.DoubleQuoteToken:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 18985, 19755);
                            DynAbs.Tracing.TraceSender.TraceBreak(10026, 19253, 19259);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 18985, 19755);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 18985, 19755);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 19386, 19736);

                            return f_10026_19393_19735(attrName, equals, f_10026_19530_19585(SyntaxKind.DoubleQuoteToken), default(SyntaxList<SyntaxToken>), f_10026_19679_19734(SyntaxKind.DoubleQuoteToken));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 18985, 19755);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 18825, 19770);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 19786, 19809);

                SyntaxToken
                startQuote
                = default(SyntaxToken);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 19823, 19844);

                SyntaxToken
                endQuote
                = default(SyntaxToken);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 19858, 19909);

                string
                attrNameText = f_10026_19880_19908(f_10026_19880_19898(attrName))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 19923, 19966);

                bool
                hasNoPrefix = f_10026_19942_19957(attrName) == null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 19980, 21361) || true) && (hasNoPrefix && (DynAbs.Tracing.TraceSender.Expression_True(10026, 19984, 20105) && f_10026_19999_20105(attrNameText, DocumentationCommentXmlNames.CrefAttributeName)) && (DynAbs.Tracing.TraceSender.Expression_True(10026, 19984, 20143) && !f_10026_20127_20143(this)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 19980, 21361);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 20177, 20193);

                    CrefSyntax
                    cref
                    = default(CrefSyntax);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 20211, 20275);

                    f_10026_20211_20274(this, out startQuote, out cref, out endQuote);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 20293, 20377);

                    return f_10026_20300_20376(attrName, equals, startQuote, cref, endQuote);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 19980, 21361);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 19980, 21361);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 20411, 21361) || true) && (hasNoPrefix && (DynAbs.Tracing.TraceSender.Expression_True(10026, 20415, 20536) && f_10026_20430_20536(attrNameText, DocumentationCommentXmlNames.NameAttributeName)) && (DynAbs.Tracing.TraceSender.Expression_True(10026, 20415, 20601) && f_10026_20557_20601(elementName)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 20411, 21361);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 20635, 20667);

                        IdentifierNameSyntax
                        identifier
                        = default(IdentifierNameSyntax);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 20685, 20755);

                        f_10026_20685_20754(this, out startQuote, out identifier, out endQuote);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 20773, 20863);

                        return f_10026_20780_20862(attrName, equals, startQuote, identifier, endQuote);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 20411, 21361);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 20411, 21361);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 20929, 20976);

                        var
                        textTokens = f_10026_20946_20975(_pool)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 21038, 21107);

                            f_10026_21038_21106(this, out startQuote, textTokens, out endQuote);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 21129, 21219);

                            return f_10026_21136_21218(attrName, equals, startQuote, textTokens, endQuote);
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinally(10026, 21256, 21346);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 21304, 21327);

                            f_10026_21304_21326(_pool, textTokens);
                            DynAbs.Tracing.TraceSender.TraceExitFinally(10026, 21256, 21346);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 20411, 21361);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 19980, 21361);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10026, 18317, 21372);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlNameSyntax
                f_10026_18428_18447(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.ParseXmlName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 18428, 18447);
                    return return_v;
                }


                int
                f_10026_18466_18498(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlNameSyntax
                this_param)
                {
                    var return_v = this_param.GetLeadingTriviaWidth();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 18466, 18498);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlNameSyntax
                f_10026_18648_18721(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlNameSyntax
                node, Microsoft.CodeAnalysis.CSharp.XmlParseErrorCode
                code)
                {
                    var return_v = this_param.WithXmlParseError<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlNameSyntax>(node, code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 18648, 18721);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_18766_18810(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, bool
                reportError)
                {
                    var return_v = this_param.EatToken(kind, reportError);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 18766, 18810);
                    return return_v;
                }


                bool
                f_10026_18829_18845(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.IsMissing;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 18829, 18845);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_18888_18964(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                node, Microsoft.CodeAnalysis.CSharp.XmlParseErrorCode
                code, params string[]
                args)
                {
                    var return_v = this_param.WithXmlParseError(node, code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 18888, 18964);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_18993_19010(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 18993, 19010);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10026_18993_19015(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 18993, 19015);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_19530_19585(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFactory.MissingToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 19530, 19585);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_19679_19734(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFactory.MissingToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 19679, 19734);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlTextAttributeSyntax
                f_10026_19393_19735(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlNameSyntax
                name, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                equalsToken, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                startQuoteToken, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>
                textTokens, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                endQuoteToken)
                {
                    var return_v = SyntaxFactory.XmlTextAttribute(name, equalsToken, startQuoteToken, textTokens, endQuoteToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 19393, 19735);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_19880_19898(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlNameSyntax
                this_param)
                {
                    var return_v = this_param.LocalName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 19880, 19898);
                    return return_v;
                }


                string
                f_10026_19880_19908(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.ValueText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 19880, 19908);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlPrefixSyntax?
                f_10026_19942_19957(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlNameSyntax
                this_param)
                {
                    var return_v = this_param.Prefix;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 19942, 19957);
                    return return_v;
                }


                bool
                f_10026_19999_20105(string
                name1, string
                name2)
                {
                    var return_v = DocumentationCommentXmlNames.AttributeEquals(name1, name2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 19999, 20105);
                    return return_v;
                }


                bool
                f_10026_20127_20143(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.IsVerbatimCref();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 20127, 20143);
                    return return_v;
                }


                int
                f_10026_20211_20274(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, out Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                startQuote, out Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CrefSyntax
                cref, out Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                endQuote)
                {
                    this_param.ParseCrefAttribute(out startQuote, out cref, out endQuote);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 20211, 20274);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlCrefAttributeSyntax
                f_10026_20300_20376(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlNameSyntax
                name, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                equalsToken, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                startQuoteToken, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CrefSyntax
                cref, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                endQuoteToken)
                {
                    var return_v = SyntaxFactory.XmlCrefAttribute(name, equalsToken, startQuoteToken, cref, endQuoteToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 20300, 20376);
                    return return_v;
                }


                bool
                f_10026_20430_20536(string
                name1, string
                name2)
                {
                    var return_v = DocumentationCommentXmlNames.AttributeEquals(name1, name2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 20430, 20536);
                    return return_v;
                }


                bool
                f_10026_20557_20601(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlNameSyntax
                elementName)
                {
                    var return_v = XmlElementSupportsNameAttribute(elementName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 20557, 20601);
                    return return_v;
                }


                int
                f_10026_20685_20754(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, out Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                startQuote, out Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.IdentifierNameSyntax
                identifier, out Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                endQuote)
                {
                    this_param.ParseNameAttribute(out startQuote, out identifier, out endQuote);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 20685, 20754);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlNameAttributeSyntax
                f_10026_20780_20862(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlNameSyntax
                name, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                equalsToken, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                startQuoteToken, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.IdentifierNameSyntax
                identifier, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                endQuoteToken)
                {
                    var return_v = SyntaxFactory.XmlNameAttribute(name, equalsToken, startQuoteToken, identifier, endQuoteToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 20780, 20862);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>
                f_10026_20946_20975(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListPool
                this_param)
                {
                    var return_v = this_param.Allocate<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 20946, 20975);
                    return return_v;
                }


                int
                f_10026_21038_21106(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, out Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                startQuote, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>
                textTokens, out Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                endQuote)
                {
                    this_param.ParseXmlAttributeText(out startQuote, textTokens, out endQuote);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 21038, 21106);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlTextAttributeSyntax
                f_10026_21136_21218(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlNameSyntax
                name, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                equalsToken, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                startQuoteToken, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>
                textTokens, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                endQuoteToken)
                {
                    var return_v = SyntaxFactory.XmlTextAttribute(name, equalsToken, startQuoteToken, (Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>)textTokens, endQuoteToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 21136, 21218);
                    return return_v;
                }


                int
                f_10026_21304_21326(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListPool
                this_param, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>
                item)
                {
                    this_param.Free((Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 21304, 21326);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10026, 18317, 21372);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10026, 18317, 21372);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool XmlElementSupportsNameAttribute(XmlNameSyntax elementName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10026, 21384, 22201);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 21487, 21579) || true) && (f_10026_21491_21509(elementName) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 21487, 21579);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 21551, 21564);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 21487, 21579);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 21595, 21646);

                string
                localName = f_10026_21614_21645(f_10026_21614_21635(elementName))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 21660, 22190);

                return
                f_10026_21684_21788(localName, DocumentationCommentXmlNames.ParameterElementName) || (DynAbs.Tracing.TraceSender.Expression_False(10026, 21684, 21922) || f_10026_21809_21922(localName, DocumentationCommentXmlNames.ParameterReferenceElementName)) || (DynAbs.Tracing.TraceSender.Expression_False(10026, 21684, 22051) || f_10026_21943_22051(localName, DocumentationCommentXmlNames.TypeParameterElementName)) || (DynAbs.Tracing.TraceSender.Expression_False(10026, 21684, 22189) || f_10026_22072_22189(localName, DocumentationCommentXmlNames.TypeParameterReferenceElementName));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10026, 21384, 22201);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlPrefixSyntax?
                f_10026_21491_21509(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlNameSyntax
                this_param)
                {
                    var return_v = this_param.Prefix;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 21491, 21509);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_21614_21635(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlNameSyntax
                this_param)
                {
                    var return_v = this_param.LocalName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 21614, 21635);
                    return return_v;
                }


                string
                f_10026_21614_21645(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.ValueText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 21614, 21645);
                    return return_v;
                }


                bool
                f_10026_21684_21788(string
                name1, string
                name2)
                {
                    var return_v = DocumentationCommentXmlNames.ElementEquals(name1, name2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 21684, 21788);
                    return return_v;
                }


                bool
                f_10026_21809_21922(string
                name1, string
                name2)
                {
                    var return_v = DocumentationCommentXmlNames.ElementEquals(name1, name2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 21809, 21922);
                    return return_v;
                }


                bool
                f_10026_21943_22051(string
                name1, string
                name2)
                {
                    var return_v = DocumentationCommentXmlNames.ElementEquals(name1, name2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 21943, 22051);
                    return return_v;
                }


                bool
                f_10026_22072_22189(string
                name1, string
                name2)
                {
                    var return_v = DocumentationCommentXmlNames.ElementEquals(name1, name2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 22072, 22189);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10026, 21384, 22201);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10026, 21384, 22201);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool IsVerbatimCref()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10026, 22213, 23668);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 22466, 22490);

                bool
                isVerbatim = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 22506, 22544);

                var
                resetPoint = f_10026_22523_22543(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 22560, 22742);

                SyntaxToken
                openQuote = f_10026_22584_22741(this, (DynAbs.Tracing.TraceSender.Conditional_F1(10026, 22593, 22646) || ((f_10026_22593_22615(f_10026_22593_22610(this)) == SyntaxKind.SingleQuoteToken
                && DynAbs.Tracing.TraceSender.Conditional_F2(10026, 22666, 22693)) || DynAbs.Tracing.TraceSender.Conditional_F3(10026, 22713, 22740))) ? SyntaxKind.SingleQuoteToken
                : SyntaxKind.DoubleQuoteToken)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 22846, 22883);

                f_10026_22846_22882(
                            // NOTE: Don't need to save mode, since we're already using a reset point.
                            this, LexerMode.XmlCharacter);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 22899, 22939);

                SyntaxToken
                current = f_10026_22921_22938(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 22953, 23537) || true) && ((f_10026_22958_22970(current) == SyntaxKind.XmlTextLiteralToken || (DynAbs.Tracing.TraceSender.Expression_False(10026, 22958, 23056) || f_10026_23008_23020(current) == SyntaxKind.XmlEntityLiteralToken)) && (DynAbs.Tracing.TraceSender.Expression_True(10026, 22957, 23134) && f_10026_23078_23095(current) != f_10026_23099_23134(f_10026_23119_23133(openQuote))) && (DynAbs.Tracing.TraceSender.Expression_True(10026, 22957, 23179) && f_10026_23155_23172(current) != ":"))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 22953, 23537);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 23213, 23224);

                    f_10026_23213_23223(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 23244, 23272);

                    current = f_10026_23254_23271(this);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 23290, 23522) || true) && ((f_10026_23295_23307(current) == SyntaxKind.XmlTextLiteralToken || (DynAbs.Tracing.TraceSender.Expression_False(10026, 23295, 23393) || f_10026_23345_23357(current) == SyntaxKind.XmlEntityLiteralToken)) && (DynAbs.Tracing.TraceSender.Expression_True(10026, 23294, 23443) && f_10026_23419_23436(current) == ":"))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 23290, 23522);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 23485, 23503);

                        isVerbatim = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 23290, 23522);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 22953, 23537);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 23553, 23580);

                f_10026_23553_23579(
                            this, ref resetPoint);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 23594, 23623);

                f_10026_23594_23622(this, ref resetPoint);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 23639, 23657);

                return isVerbatim;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10026, 22213, 23668);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser.ResetPoint
                f_10026_22523_22543(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.GetResetPoint();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 22523, 22543);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_22593_22610(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 22593, 22610);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10026_22593_22615(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 22593, 22615);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_22584_22741(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = this_param.EatToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 22584, 22741);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LexerMode
                f_10026_22846_22882(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LexerMode
                mode)
                {
                    var return_v = this_param.SetMode(mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 22846, 22882);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_22921_22938(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 22921, 22938);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10026_22958_22970(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 22958, 22970);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10026_23008_23020(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 23008, 23020);
                    return return_v;
                }


                string
                f_10026_23078_23095(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.ValueText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 23078, 23095);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10026_23119_23133(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 23119, 23133);
                    return return_v;
                }


                string
                f_10026_23099_23134(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.GetText(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 23099, 23134);
                    return return_v;
                }


                string
                f_10026_23155_23172(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.ValueText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 23155, 23172);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_23213_23223(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.EatToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 23213, 23223);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_23254_23271(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 23254, 23271);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10026_23295_23307(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 23295, 23307);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10026_23345_23357(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 23345, 23357);
                    return return_v;
                }


                string
                f_10026_23419_23436(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.ValueText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 23419, 23436);
                    return return_v;
                }


                int
                f_10026_23553_23579(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, ref Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser.ResetPoint
                point)
                {
                    this_param.Reset(ref point);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 23553, 23579);
                    return 0;
                }


                int
                f_10026_23594_23622(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, ref Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser.ResetPoint
                point)
                {
                    this_param.Release(ref point);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 23594, 23622);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10026, 22213, 23668);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10026, 22213, 23668);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void ParseCrefAttribute(out SyntaxToken startQuote, out CrefSyntax cref, out SyntaxToken endQuote)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10026, 23680, 24303);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 23811, 23854);

                startQuote = f_10026_23824_23853(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 23868, 23907);

                SyntaxKind
                quoteKind = f_10026_23891_23906(startQuote)
                ;

                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 23942, 24110);

                    var
                    saveMode = f_10026_23957_24109(this, (DynAbs.Tracing.TraceSender.Conditional_F1(10026, 23970, 24010) || ((quoteKind == SyntaxKind.SingleQuoteToken
                    && DynAbs.Tracing.TraceSender.Conditional_F2(10026, 24034, 24056)) || DynAbs.Tracing.TraceSender.Conditional_F3(10026, 24080, 24108))) ? LexerMode.XmlCrefQuote
                    : LexerMode.XmlCrefDoubleQuote)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 24130, 24168);

                    cref = f_10026_24137_24167(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 24188, 24213);

                    f_10026_24188_24212(
                                    this, saveMode);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 24244, 24292);

                endQuote = f_10026_24255_24291(this, quoteKind);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10026, 23680, 24303);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_23824_23853(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.ParseXmlAttributeStartQuote();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 23824, 23853);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10026_23891_23906(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 23891, 23906);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LexerMode
                f_10026_23957_24109(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LexerMode
                mode)
                {
                    var return_v = this_param.SetMode(mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 23957, 24109);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CrefSyntax
                f_10026_24137_24167(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.ParseCrefAttributeValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 24137, 24167);
                    return return_v;
                }


                int
                f_10026_24188_24212(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LexerMode
                mode)
                {
                    this_param.ResetMode(mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 24188, 24212);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_24255_24291(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                quoteKind)
                {
                    var return_v = this_param.ParseXmlAttributeEndQuote(quoteKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 24255, 24291);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10026, 23680, 24303);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10026, 23680, 24303);
            }
        }

        private void ParseNameAttribute(out SyntaxToken startQuote, out IdentifierNameSyntax identifier, out SyntaxToken endQuote)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10026, 24315, 24960);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 24462, 24505);

                startQuote = f_10026_24475_24504(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 24519, 24558);

                SyntaxKind
                quoteKind = f_10026_24542_24557(startQuote)
                ;

                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 24593, 24761);

                    var
                    saveMode = f_10026_24608_24760(this, (DynAbs.Tracing.TraceSender.Conditional_F1(10026, 24621, 24661) || ((quoteKind == SyntaxKind.SingleQuoteToken
                    && DynAbs.Tracing.TraceSender.Conditional_F2(10026, 24685, 24707)) || DynAbs.Tracing.TraceSender.Conditional_F3(10026, 24731, 24759))) ? LexerMode.XmlNameQuote
                    : LexerMode.XmlNameDoubleQuote)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 24781, 24825);

                    identifier = f_10026_24794_24824(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 24845, 24870);

                    f_10026_24845_24869(
                                    this, saveMode);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 24901, 24949);

                endQuote = f_10026_24912_24948(this, quoteKind);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10026, 24315, 24960);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_24475_24504(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.ParseXmlAttributeStartQuote();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 24475, 24504);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10026_24542_24557(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 24542, 24557);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LexerMode
                f_10026_24608_24760(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LexerMode
                mode)
                {
                    var return_v = this_param.SetMode(mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 24608, 24760);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.IdentifierNameSyntax
                f_10026_24794_24824(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.ParseNameAttributeValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 24794, 24824);
                    return return_v;
                }


                int
                f_10026_24845_24869(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LexerMode
                mode)
                {
                    this_param.ResetMode(mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 24845, 24869);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_24912_24948(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                quoteKind)
                {
                    var return_v = this_param.ParseXmlAttributeEndQuote(quoteKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 24912, 24948);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10026, 24315, 24960);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10026, 24315, 24960);
            }
        }

        private void ParseXmlAttributeText(out SyntaxToken startQuote, SyntaxListBuilder<SyntaxToken> textTokens, out SyntaxToken endQuote)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10026, 24972, 26931);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 25128, 25171);

                startQuote = f_10026_25141_25170(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 25185, 25224);

                SyntaxKind
                quoteKind = f_10026_25208_25223(startQuote)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 25421, 26920) || true) && (f_10026_25425_25445(startQuote) && (DynAbs.Tracing.TraceSender.Expression_True(10026, 25425, 25474) && f_10026_25449_25469(startQuote) == 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 25421, 26920);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 25508, 25557);

                    endQuote = f_10026_25519_25556(quoteKind);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 25421, 26920);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 25421, 26920);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 25623, 25809);

                    var
                    saveMode = f_10026_25638_25808(this, (DynAbs.Tracing.TraceSender.Conditional_F1(10026, 25651, 25691) || ((quoteKind == SyntaxKind.SingleQuoteToken
                    && DynAbs.Tracing.TraceSender.Conditional_F2(10026, 25715, 25746)) || DynAbs.Tracing.TraceSender.Conditional_F3(10026, 25770, 25807))) ? LexerMode.XmlAttributeTextQuote
                    : LexerMode.XmlAttributeTextDoubleQuote)
                    ;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 25829, 26607) || true) && (f_10026_25836_25858(f_10026_25836_25853(this)) == SyntaxKind.XmlTextLiteralToken
                        || (DynAbs.Tracing.TraceSender.Expression_False(10026, 25836, 25980) || f_10026_25917_25939(f_10026_25917_25934(this)) == SyntaxKind.XmlTextLiteralNewLineToken
                        ) || (DynAbs.Tracing.TraceSender.Expression_False(10026, 25836, 26063) || f_10026_26005_26027(f_10026_26005_26022(this)) == SyntaxKind.XmlEntityLiteralToken
                        ) || (DynAbs.Tracing.TraceSender.Expression_False(10026, 25836, 26138) || f_10026_26088_26110(f_10026_26088_26105(this)) == SyntaxKind.LessThanToken))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 25829, 26607);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 26180, 26208);

                            var
                            token = f_10026_26192_26207(this)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 26230, 26542) || true) && (f_10026_26234_26244(token) == SyntaxKind.LessThanToken)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 26230, 26542);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 26433, 26519);

                                token = f_10026_26441_26518(this, token, XmlParseErrorCode.XML_LessThanInAttributeValue);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 26230, 26542);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 26566, 26588);

                            textTokens.Add(token);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 25829, 26607);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10026, 25829, 26607);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10026, 25829, 26607);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 26627, 26652);

                    f_10026_26627_26651(
                                    this, saveMode);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 26857, 26905);

                    endQuote = f_10026_26868_26904(this, quoteKind);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 25421, 26920);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10026, 24972, 26931);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_25141_25170(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.ParseXmlAttributeStartQuote();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 25141, 25170);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10026_25208_25223(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 25208, 25223);
                    return return_v;
                }


                bool
                f_10026_25425_25445(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.IsMissing;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 25425, 25445);
                    return return_v;
                }


                int
                f_10026_25449_25469(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.FullWidth;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 25449, 25469);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_25519_25556(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFactory.MissingToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 25519, 25556);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LexerMode
                f_10026_25638_25808(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LexerMode
                mode)
                {
                    var return_v = this_param.SetMode(mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 25638, 25808);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_25836_25853(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 25836, 25853);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10026_25836_25858(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 25836, 25858);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_25917_25934(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 25917, 25934);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10026_25917_25939(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 25917, 25939);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_26005_26022(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 26005, 26022);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10026_26005_26027(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 26005, 26027);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_26088_26105(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 26088, 26105);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10026_26088_26110(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 26088, 26110);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_26192_26207(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.EatToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 26192, 26207);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10026_26234_26244(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 26234, 26244);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_26441_26518(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                node, Microsoft.CodeAnalysis.CSharp.XmlParseErrorCode
                code, params string[]
                args)
                {
                    var return_v = this_param.WithXmlParseError(node, code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 26441, 26518);
                    return return_v;
                }


                int
                f_10026_26627_26651(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LexerMode
                mode)
                {
                    this_param.ResetMode(mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 26627, 26651);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_26868_26904(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                quoteKind)
                {
                    var return_v = this_param.ParseXmlAttributeEndQuote(quoteKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 26868, 26904);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10026, 24972, 26931);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10026, 24972, 26931);
            }
        }

        private SyntaxToken ParseXmlAttributeStartQuote()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10026, 26943, 27632);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 27017, 27147) || true) && (f_10026_27021_27063(f_10026_27045_27062(this)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 27017, 27147);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 27097, 27132);

                    return f_10026_27104_27131(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 27017, 27147);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 27163, 27327);

                var
                quoteKind = (DynAbs.Tracing.TraceSender.Conditional_F1(10026, 27179, 27232) || ((f_10026_27179_27201(f_10026_27179_27196(this)) == SyntaxKind.SingleQuoteToken
                && DynAbs.Tracing.TraceSender.Conditional_F2(10026, 27252, 27279)) || DynAbs.Tracing.TraceSender.Conditional_F3(10026, 27299, 27326))) ? SyntaxKind.SingleQuoteToken
                : SyntaxKind.DoubleQuoteToken
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 27343, 27405);

                var
                startQuote = f_10026_27360_27404(this, quoteKind, reportError: false)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 27419, 27589) || true) && (f_10026_27423_27443(startQuote))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 27419, 27589);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 27477, 27574);

                    startQuote = f_10026_27490_27573(this, startQuote, XmlParseErrorCode.XML_StringLiteralNoStartQuote);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 27419, 27589);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 27603, 27621);

                return startQuote;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10026, 26943, 27632);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_27045_27062(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 27045, 27062);
                    return return_v;
                }


                bool
                f_10026_27021_27063(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                token)
                {
                    var return_v = IsNonAsciiQuotationMark(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 27021, 27063);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_27104_27131(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.SkipNonAsciiQuotationMark();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 27104, 27131);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_27179_27196(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 27179, 27196);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10026_27179_27201(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 27179, 27201);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_27360_27404(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, bool
                reportError)
                {
                    var return_v = this_param.EatToken(kind, reportError: reportError);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 27360, 27404);
                    return return_v;
                }


                bool
                f_10026_27423_27443(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.IsMissing;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 27423, 27443);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_27490_27573(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                node, Microsoft.CodeAnalysis.CSharp.XmlParseErrorCode
                code, params string[]
                args)
                {
                    var return_v = this_param.WithXmlParseError(node, code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 27490, 27573);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10026, 26943, 27632);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10026, 26943, 27632);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private SyntaxToken ParseXmlAttributeEndQuote(SyntaxKind quoteKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10026, 27644, 28159);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 27736, 27866) || true) && (f_10026_27740_27782(f_10026_27764_27781(this)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 27736, 27866);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 27816, 27851);

                    return f_10026_27823_27850(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 27736, 27866);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 27882, 27942);

                var
                endQuote = f_10026_27897_27941(this, quoteKind, reportError: false)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 27956, 28118) || true) && (f_10026_27960_27978(endQuote))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 27956, 28118);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 28012, 28103);

                    endQuote = f_10026_28023_28102(this, endQuote, XmlParseErrorCode.XML_StringLiteralNoEndQuote);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 27956, 28118);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 28132, 28148);

                return endQuote;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10026, 27644, 28159);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_27764_27781(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 27764, 27781);
                    return return_v;
                }


                bool
                f_10026_27740_27782(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                token)
                {
                    var return_v = IsNonAsciiQuotationMark(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 27740, 27782);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_27823_27850(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.SkipNonAsciiQuotationMark();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 27823, 27850);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_27897_27941(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, bool
                reportError)
                {
                    var return_v = this_param.EatToken(kind, reportError: reportError);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 27897, 27941);
                    return return_v;
                }


                bool
                f_10026_27960_27978(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.IsMissing;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 27960, 27978);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_28023_28102(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                node, Microsoft.CodeAnalysis.CSharp.XmlParseErrorCode
                code, params string[]
                args)
                {
                    var return_v = this_param.WithXmlParseError(node, code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 28023, 28102);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10026, 27644, 28159);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10026, 27644, 28159);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private SyntaxToken SkipNonAsciiQuotationMark()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10026, 28171, 28517);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 28243, 28311);

                var
                quote = f_10026_28255_28310(SyntaxKind.DoubleQuoteToken)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 28325, 28377);

                quote = f_10026_28333_28376(this, quote, f_10026_28365_28375(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 28391, 28479);

                quote = f_10026_28399_28478(this, quote, XmlParseErrorCode.XML_StringLiteralNonAsciiQuote);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 28493, 28506);

                return quote;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10026, 28171, 28517);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_28255_28310(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFactory.MissingToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 28255, 28310);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_28365_28375(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.EatToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 28365, 28375);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_28333_28376(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                node, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                skippedSyntax)
                {
                    var return_v = this_param.AddTrailingSkippedSyntax<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>(node, (Microsoft.CodeAnalysis.GreenNode)skippedSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 28333, 28376);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_28399_28478(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                node, Microsoft.CodeAnalysis.CSharp.XmlParseErrorCode
                code, params string[]
                args)
                {
                    var return_v = this_param.WithXmlParseError(node, code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 28399, 28478);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10026, 28171, 28517);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10026, 28171, 28517);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsNonAsciiQuotationMark(SyntaxToken token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10026, 28803, 28985);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 28890, 28974);

                return f_10026_28897_28914(f_10026_28897_28907(token)) == 1 && (DynAbs.Tracing.TraceSender.Expression_True(10026, 28897, 28973) && f_10026_28923_28973(f_10026_28959_28972(f_10026_28959_28969(token), 0)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10026, 28803, 28985);

                string
                f_10026_28897_28907(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 28897, 28907);
                    return return_v;
                }


                int
                f_10026_28897_28914(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 28897, 28914);
                    return return_v;
                }


                string
                f_10026_28959_28969(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 28959, 28969);
                    return return_v;
                }


                char
                f_10026_28959_28972(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 28959, 28972);
                    return return_v;
                }


                bool
                f_10026_28923_28973(char
                ch)
                {
                    var return_v = SyntaxFacts.IsNonAsciiQuotationMark(ch);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 28923, 28973);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10026, 28803, 28985);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10026, 28803, 28985);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private XmlNameSyntax ParseXmlName()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10026, 28997, 31030);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 29058, 29109);

                var
                id = f_10026_29067_29108(this, SyntaxKind.IdentifierToken)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 29123, 29153);

                XmlPrefixSyntax
                prefix = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 29167, 30962) || true) && (f_10026_29171_29193(f_10026_29171_29188(this)) == SyntaxKind.ColonToken)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 29167, 30962);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 29252, 29280);

                    var
                    colon = f_10026_29264_29279(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 29300, 29354);

                    int
                    prefixTrailingWidth = f_10026_29326_29353(id)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 29372, 29426);

                    int
                    colonLeadingWidth = f_10026_29396_29425(colon)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 29446, 29922) || true) && (prefixTrailingWidth > 0 || (DynAbs.Tracing.TraceSender.Expression_False(10026, 29450, 29498) || colonLeadingWidth > 0))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 29446, 29922);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 29647, 29681);

                        int
                        offset = -prefixTrailingWidth
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 29703, 29755);

                        int
                        width = prefixTrailingWidth + colonLeadingWidth
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 29777, 29903);

                        colon = f_10026_29785_29902(this, colon, f_10026_29818_29901(offset, width, XmlParseErrorCode.XML_InvalidWhitespace));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 29446, 29922);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 29942, 29986);

                    prefix = f_10026_29951_29985(id, colon);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 30004, 30051);

                    id = f_10026_30009_30050(this, SyntaxKind.IdentifierToken);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 30071, 30127);

                    int
                    colonTrailingWidth = f_10026_30096_30126(colon)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 30145, 30200);

                    int
                    localNameLeadingWidth = f_10026_30173_30199(id)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 30218, 30947) || true) && (colonTrailingWidth > 0 || (DynAbs.Tracing.TraceSender.Expression_False(10026, 30222, 30273) || localNameLeadingWidth > 0))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 30218, 30947);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 30427, 30460);

                        int
                        offset = -colonTrailingWidth
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 30482, 30537);

                        int
                        width = colonTrailingWidth + localNameLeadingWidth
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 30559, 30679);

                        id = f_10026_30564_30678(this, id, f_10026_30594_30677(offset, width, XmlParseErrorCode.XML_InvalidWhitespace));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 30218, 30947);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 29167, 30962);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 30978, 31019);

                return f_10026_30985_31018(prefix, id);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10026, 28997, 31030);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_29067_29108(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = this_param.EatToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 29067, 29108);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_29171_29188(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 29171, 29188);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10026_29171_29193(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 29171, 29193);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_29264_29279(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.EatToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 29264, 29279);
                    return return_v;
                }


                int
                f_10026_29326_29353(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.GetTrailingTriviaWidth();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 29326, 29353);
                    return return_v;
                }


                int
                f_10026_29396_29425(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.GetLeadingTriviaWidth();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 29396, 29425);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.XmlSyntaxDiagnosticInfo
                f_10026_29818_29901(int
                offset, int
                width, Microsoft.CodeAnalysis.CSharp.XmlParseErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.XmlSyntaxDiagnosticInfo(offset, width, code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 29818, 29901);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_29785_29902(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                node, params Microsoft.CodeAnalysis.DiagnosticInfo[]
                diagnostics)
                {
                    var return_v = this_param.WithAdditionalDiagnostics<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>(node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 29785, 29902);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlPrefixSyntax
                f_10026_29951_29985(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                prefix, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                colonToken)
                {
                    var return_v = SyntaxFactory.XmlPrefix(prefix, colonToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 29951, 29985);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_30009_30050(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = this_param.EatToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 30009, 30050);
                    return return_v;
                }


                int
                f_10026_30096_30126(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.GetTrailingTriviaWidth();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 30096, 30126);
                    return return_v;
                }


                int
                f_10026_30173_30199(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.GetLeadingTriviaWidth();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 30173, 30199);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.XmlSyntaxDiagnosticInfo
                f_10026_30594_30677(int
                offset, int
                width, Microsoft.CodeAnalysis.CSharp.XmlParseErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.XmlSyntaxDiagnosticInfo(offset, width, code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 30594, 30677);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_30564_30678(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                node, params Microsoft.CodeAnalysis.DiagnosticInfo[]
                diagnostics)
                {
                    var return_v = this_param.WithAdditionalDiagnostics<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>(node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 30564, 30678);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlNameSyntax
                f_10026_30985_31018(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlPrefixSyntax?
                prefix, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                localName)
                {
                    var return_v = SyntaxFactory.XmlName(prefix, localName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 30985, 31018);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10026, 28997, 31030);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10026, 28997, 31030);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private XmlCommentSyntax ParseXmlComment()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10026, 31042, 32332);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 31109, 31197);

                var
                lessThanExclamationMinusMinusToken = f_10026_31150_31196(this, SyntaxKind.XmlCommentStartToken)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 31211, 31265);

                var
                saveMode = f_10026_31226_31264(this, LexerMode.XmlCommentText)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 31279, 31326);

                var
                textTokens = f_10026_31296_31325(_pool)
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 31340, 31988) || true) && (f_10026_31347_31369(f_10026_31347_31364(this)) == SyntaxKind.XmlTextLiteralToken
                    || (DynAbs.Tracing.TraceSender.Expression_False(10026, 31347, 31487) || f_10026_31424_31446(f_10026_31424_31441(this)) == SyntaxKind.XmlTextLiteralNewLineToken
                    ) || (DynAbs.Tracing.TraceSender.Expression_False(10026, 31347, 31560) || f_10026_31508_31530(f_10026_31508_31525(this)) == SyntaxKind.MinusMinusToken))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 31340, 31988);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 31594, 31622);

                        var
                        token = f_10026_31606_31621(this)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 31640, 31931) || true) && (f_10026_31644_31654(token) == SyntaxKind.MinusMinusToken)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 31640, 31931);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 31834, 31912);

                            token = f_10026_31842_31911(this, token, XmlParseErrorCode.XML_IncorrectComment);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 31640, 31931);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 31951, 31973);

                        textTokens.Add(token);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 31340, 31988);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10026, 31340, 31988);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10026, 31340, 31988);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 32004, 32035);

                var
                list = textTokens.ToList()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 32049, 32072);

                f_10026_32049_32071(_pool, textTokens);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 32088, 32166);

                var
                minusMinusGreaterThanToken = f_10026_32121_32165(this, SyntaxKind.XmlCommentEndToken)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 32180, 32205);

                f_10026_32180_32204(this, saveMode);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 32219, 32321);

                return f_10026_32226_32320(lessThanExclamationMinusMinusToken, list, minusMinusGreaterThanToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10026, 31042, 32332);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_31150_31196(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = this_param.EatToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 31150, 31196);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LexerMode
                f_10026_31226_31264(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LexerMode
                mode)
                {
                    var return_v = this_param.SetMode(mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 31226, 31264);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>
                f_10026_31296_31325(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListPool
                this_param)
                {
                    var return_v = this_param.Allocate<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 31296, 31325);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_31347_31364(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 31347, 31364);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10026_31347_31369(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 31347, 31369);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_31424_31441(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 31424, 31441);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10026_31424_31446(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 31424, 31446);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_31508_31525(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 31508, 31525);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10026_31508_31530(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 31508, 31530);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_31606_31621(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.EatToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 31606, 31621);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10026_31644_31654(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 31644, 31654);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_31842_31911(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                node, Microsoft.CodeAnalysis.CSharp.XmlParseErrorCode
                code, params string[]
                args)
                {
                    var return_v = this_param.WithXmlParseError(node, code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 31842, 31911);
                    return return_v;
                }


                int
                f_10026_32049_32071(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListPool
                this_param, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>
                item)
                {
                    this_param.Free((Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 32049, 32071);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_32121_32165(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = this_param.EatToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 32121, 32165);
                    return return_v;
                }


                int
                f_10026_32180_32204(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LexerMode
                mode)
                {
                    this_param.ResetMode(mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 32180, 32204);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlCommentSyntax
                f_10026_32226_32320(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                lessThanExclamationMinusMinusToken, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>
                textTokens, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                minusMinusGreaterThanToken)
                {
                    var return_v = SyntaxFactory.XmlComment(lessThanExclamationMinusMinusToken, textTokens, minusMinusGreaterThanToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 32226, 32320);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10026, 31042, 32332);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10026, 31042, 32332);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private XmlCDataSectionSyntax ParseXmlCDataSection()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10026, 32344, 33096);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 32421, 32488);

                var
                startCDataToken = f_10026_32443_32487(this, SyntaxKind.XmlCDataStartToken)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 32502, 32561);

                var
                saveMode = f_10026_32517_32560(this, LexerMode.XmlCDataSectionText)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 32575, 32631);

                var
                textTokens = f_10026_32592_32630(10)
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 32645, 32872) || true) && (f_10026_32652_32674(f_10026_32652_32669(this)) == SyntaxKind.XmlTextLiteralToken
                    || (DynAbs.Tracing.TraceSender.Expression_False(10026, 32652, 32791) || f_10026_32728_32750(f_10026_32728_32745(this)) == SyntaxKind.XmlTextLiteralNewLineToken))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 32645, 32872);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 32825, 32857);

                        textTokens.Add(f_10026_32840_32855(this));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 32645, 32872);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10026, 32645, 32872);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10026, 32645, 32872);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 32888, 32951);

                var
                endCDataToken = f_10026_32908_32950(this, SyntaxKind.XmlCDataEndToken)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 32965, 32990);

                f_10026_32965_32989(this, saveMode);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 33004, 33085);

                return f_10026_33011_33084(startCDataToken, textTokens, endCDataToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10026, 32344, 33096);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_32443_32487(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = this_param.EatToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 32443, 32487);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LexerMode
                f_10026_32517_32560(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LexerMode
                mode)
                {
                    var return_v = this_param.SetMode(mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 32517, 32560);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>
                f_10026_32592_32630(int
                size)
                {
                    var return_v = new Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>(size);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 32592, 32630);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_32652_32669(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 32652, 32669);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10026_32652_32674(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 32652, 32674);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_32728_32745(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 32728, 32745);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10026_32728_32750(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 32728, 32750);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_32840_32855(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.EatToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 32840, 32855);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_32908_32950(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = this_param.EatToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 32908, 32950);
                    return return_v;
                }


                int
                f_10026_32965_32989(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LexerMode
                mode)
                {
                    this_param.ResetMode(mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 32965, 32989);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlCDataSectionSyntax
                f_10026_33011_33084(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                startCDataToken, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>
                textTokens, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                endCDataToken)
                {
                    var return_v = SyntaxFactory.XmlCDataSection(startCDataToken, (Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>)textTokens, endCDataToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 33011, 33084);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10026, 32344, 33096);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10026, 32344, 33096);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private XmlProcessingInstructionSyntax ParseXmlProcessingInstruction()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10026, 33108, 34510);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 33203, 33302);

                var
                startProcessingInstructionToken = f_10026_33241_33301(this, SyntaxKind.XmlProcessingInstructionStartToken)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 33316, 33369);

                var
                saveMode = f_10026_33331_33368(this, LexerMode.XmlElementTag)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 33409, 33440);

                var
                name = f_10026_33420_33439(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 33607, 33660);

                f_10026_33607_33659(

                            // NOTE: The XML spec says that name cannot be "xml" (case-insensitive comparison), 
                            // but Dev10 does not enforce this.

                            this, LexerMode.XmlProcessingInstructionText);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 33700, 33756);

                var
                textTokens = f_10026_33717_33755(10)
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 33770, 34207) || true) && (f_10026_33777_33799(f_10026_33777_33794(this)) == SyntaxKind.XmlTextLiteralToken
                    || (DynAbs.Tracing.TraceSender.Expression_False(10026, 33777, 33916) || f_10026_33853_33875(f_10026_33853_33870(this)) == SyntaxKind.XmlTextLiteralNewLineToken))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 33770, 34207);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 33950, 33982);

                        var
                        textToken = f_10026_33966_33981(this)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 34166, 34192);

                        textTokens.Add(textToken);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 33770, 34207);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10026, 33770, 34207);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10026, 33770, 34207);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 34223, 34318);

                var
                endProcessingInstructionToken = f_10026_34259_34317(this, SyntaxKind.XmlProcessingInstructionEndToken)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 34332, 34357);

                f_10026_34332_34356(this, saveMode);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 34371, 34499);

                return f_10026_34378_34498(startProcessingInstructionToken, name, textTokens, endProcessingInstructionToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10026, 33108, 34510);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_33241_33301(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = this_param.EatToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 33241, 33301);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LexerMode
                f_10026_33331_33368(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LexerMode
                mode)
                {
                    var return_v = this_param.SetMode(mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 33331, 33368);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlNameSyntax
                f_10026_33420_33439(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.ParseXmlName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 33420, 33439);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LexerMode
                f_10026_33607_33659(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LexerMode
                mode)
                {
                    var return_v = this_param.SetMode(mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 33607, 33659);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>
                f_10026_33717_33755(int
                size)
                {
                    var return_v = new Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>(size);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 33717, 33755);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_33777_33794(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 33777, 33794);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10026_33777_33799(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 33777, 33799);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_33853_33870(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 33853, 33870);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10026_33853_33875(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 33853, 33875);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_33966_33981(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.EatToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 33966, 33981);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_34259_34317(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = this_param.EatToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 34259, 34317);
                    return return_v;
                }


                int
                f_10026_34332_34356(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LexerMode
                mode)
                {
                    this_param.ResetMode(mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 34332, 34356);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlProcessingInstructionSyntax
                f_10026_34378_34498(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                startProcessingInstructionToken, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlNameSyntax
                name, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>
                textTokens, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                endProcessingInstructionToken)
                {
                    var return_v = SyntaxFactory.XmlProcessingInstruction(startProcessingInstructionToken, name, (Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>)textTokens, endProcessingInstructionToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 34378, 34498);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10026, 33108, 34510);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10026, 33108, 34510);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override SyntaxDiagnosticInfo GetExpectedTokenError(SyntaxKind expected, SyntaxKind actual, int offset, int length)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10026, 34522, 35569);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 34821, 35164) || true) && (f_10026_34825_34831())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 34821, 35164);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 34865, 34957);

                    SyntaxDiagnosticInfo
                    rawInfo = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetExpectedTokenError(expected, actual, offset, length), 10026, 34896, 34956)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 34975, 35115);

                    SyntaxDiagnosticInfo
                    crefInfo = f_10026_35007_35114(rawInfo.Offset, rawInfo.Width, ErrorCode.WRN_ErrorOverride, rawInfo, f_10026_35101_35113(rawInfo))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 35133, 35149);

                    return crefInfo;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 34821, 35164);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 35180, 35558);

                switch (expected)
                {

                    case SyntaxKind.IdentifierToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 35180, 35558);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 35284, 35377);

                        return f_10026_35291_35376(offset, length, XmlParseErrorCode.XML_ExpectedIdentifier);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 35180, 35558);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 35180, 35558);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 35427, 35543);

                        return f_10026_35434_35542(offset, length, XmlParseErrorCode.XML_InvalidToken, f_10026_35514_35541(actual));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 35180, 35558);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10026, 34522, 35569);

                bool
                f_10026_34825_34831()
                {
                    var return_v = InCref;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 34825, 34831);
                    return return_v;
                }


                int
                f_10026_35101_35113(Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
                this_param)
                {
                    var return_v = this_param.Code;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 35101, 35113);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
                f_10026_35007_35114(int
                offset, int
                width, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo(offset, width, code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 35007, 35114);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.XmlSyntaxDiagnosticInfo
                f_10026_35291_35376(int
                offset, int
                width, Microsoft.CodeAnalysis.CSharp.XmlParseErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.XmlSyntaxDiagnosticInfo(offset, width, code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 35291, 35376);
                    return return_v;
                }


                string
                f_10026_35514_35541(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.GetText(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 35514, 35541);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.XmlSyntaxDiagnosticInfo
                f_10026_35434_35542(int
                offset, int
                width, Microsoft.CodeAnalysis.CSharp.XmlParseErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.XmlSyntaxDiagnosticInfo(offset, width, code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 35434, 35542);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10026, 34522, 35569);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10026, 34522, 35569);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override SyntaxDiagnosticInfo GetExpectedTokenError(SyntaxKind expected, SyntaxKind actual)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10026, 35581, 36467);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 35856, 36094) || true) && (f_10026_35860_35866())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 35856, 36094);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 35900, 35918);

                    int
                    offset
                    = default(int),
                    width
                    = default(int);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 35936, 35997);

                    f_10026_35936_35996(this, out offset, out width);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 36017, 36079);

                    return f_10026_36024_36078(this, expected, actual, offset, width);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 35856, 36094);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 36110, 36456);

                switch (expected)
                {

                    case SyntaxKind.IdentifierToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 36110, 36456);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 36214, 36291);

                        return f_10026_36221_36290(XmlParseErrorCode.XML_ExpectedIdentifier);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 36110, 36456);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 36110, 36456);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 36341, 36441);

                        return f_10026_36348_36440(XmlParseErrorCode.XML_InvalidToken, f_10026_36412_36439(actual));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 36110, 36456);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10026, 35581, 36467);

                bool
                f_10026_35860_35866()
                {
                    var return_v = InCref;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 35860, 35866);
                    return return_v;
                }


                int
                f_10026_35936_35996(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, out int
                offset, out int
                width)
                {
                    this_param.GetDiagnosticSpanForMissingToken(out offset, out width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 35936, 35996);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
                f_10026_36024_36078(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                expected, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                actual, int
                offset, int
                length)
                {
                    var return_v = this_param.GetExpectedTokenError(expected, actual, offset, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 36024, 36078);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.XmlSyntaxDiagnosticInfo
                f_10026_36221_36290(Microsoft.CodeAnalysis.CSharp.XmlParseErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.XmlSyntaxDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 36221, 36290);
                    return return_v;
                }


                string
                f_10026_36412_36439(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.GetText(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 36412, 36439);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.XmlSyntaxDiagnosticInfo
                f_10026_36348_36440(Microsoft.CodeAnalysis.CSharp.XmlParseErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.XmlSyntaxDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 36348, 36440);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10026, 35581, 36467);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10026, 35581, 36467);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private TNode WithXmlParseError<TNode>(TNode node, XmlParseErrorCode code) where TNode : CSharpSyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10026, 36479, 36709);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 36609, 36698);

                return f_10026_36616_36697<TNode>(this, node, f_10026_36648_36696<TNode>(0, f_10026_36679_36689<TNode>(node), code));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10026, 36479, 36709);

                int
                f_10026_36679_36689<TNode>(TNode
                this_param) where TNode : CSharpSyntaxNode

                {
                    var return_v = this_param.Width;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 36679, 36689);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.XmlSyntaxDiagnosticInfo
                f_10026_36648_36696<TNode>(int
                offset, int
                width, Microsoft.CodeAnalysis.CSharp.XmlParseErrorCode
                code, params object[]
                args) where TNode : CSharpSyntaxNode

                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.XmlSyntaxDiagnosticInfo(offset, width, code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 36648, 36696);
                    return return_v;
                }


                TNode
                f_10026_36616_36697<TNode>(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, TNode
                node, params Microsoft.CodeAnalysis.DiagnosticInfo[]
                diagnostics) where TNode : CSharpSyntaxNode

                {
                    var return_v = this_param.WithAdditionalDiagnostics<TNode>(node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 36616, 36697);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10026, 36479, 36709);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10026, 36479, 36709);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private TNode WithXmlParseError<TNode>(TNode node, XmlParseErrorCode code, params string[] args) where TNode : CSharpSyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10026, 36721, 36979);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 36873, 36968);

                return f_10026_36880_36967<TNode>(this, node, f_10026_36912_36966<TNode>(0, f_10026_36943_36953<TNode>(node), code, args));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10026, 36721, 36979);

                int
                f_10026_36943_36953<TNode>(TNode
                this_param) where TNode : CSharpSyntaxNode

                {
                    var return_v = this_param.Width;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 36943, 36953);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.XmlSyntaxDiagnosticInfo
                f_10026_36912_36966<TNode>(int
                offset, int
                width, Microsoft.CodeAnalysis.CSharp.XmlParseErrorCode
                code, params string[]
                args) where TNode : CSharpSyntaxNode

                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.XmlSyntaxDiagnosticInfo(offset, width, code, (object[])args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 36912, 36966);
                    return return_v;
                }


                TNode
                f_10026_36880_36967<TNode>(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, TNode
                node, params Microsoft.CodeAnalysis.DiagnosticInfo[]
                diagnostics) where TNode : CSharpSyntaxNode

                {
                    var return_v = this_param.WithAdditionalDiagnostics<TNode>(node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 36880, 36967);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10026, 36721, 36979);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10026, 36721, 36979);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private SyntaxToken WithXmlParseError(SyntaxToken node, XmlParseErrorCode code, params string[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10026, 36991, 37223);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 37117, 37212);

                return f_10026_37124_37211(this, node, f_10026_37156_37210(0, f_10026_37187_37197(node), code, args));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10026, 36991, 37223);

                int
                f_10026_37187_37197(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Width;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 37187, 37197);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.XmlSyntaxDiagnosticInfo
                f_10026_37156_37210(int
                offset, int
                width, Microsoft.CodeAnalysis.CSharp.XmlParseErrorCode
                code, params string[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.XmlSyntaxDiagnosticInfo(offset, width, code, (object[])args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 37156, 37210);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_37124_37211(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                node, params Microsoft.CodeAnalysis.DiagnosticInfo[]
                diagnostics)
                {
                    var return_v = this_param.WithAdditionalDiagnostics<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>(node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 37124, 37211);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10026, 36991, 37223);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10026, 36991, 37223);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override TNode WithAdditionalDiagnostics<TNode>(TNode node, params DiagnosticInfo[] diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10026, 37235, 37699);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 37525, 37688);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10026, 37532, 37587) || ((f_10026_37532_37557<TNode>(f_10026_37532_37539<TNode>()) >= DocumentationMode.Diagnose
                && DynAbs.Tracing.TraceSender.Conditional_F2(10026, 37607, 37663)) || DynAbs.Tracing.TraceSender.Conditional_F3(10026, 37683, 37687))) ? DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.WithAdditionalDiagnostics<TNode>(node, diagnostics), 10026, 37607, 37663) : node;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10026, 37235, 37699);

                Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                f_10026_37532_37539<TNode>()
                {
                    var return_v = Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 37532, 37539);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DocumentationMode
                f_10026_37532_37557<TNode>(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                this_param)
                {
                    var return_v = this_param.DocumentationMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 37532, 37557);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10026, 37235, 37699);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10026, 37235, 37699);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private CrefSyntax ParseCrefAttributeValue()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10026, 40206, 41961);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 40275, 40293);

                CrefSyntax
                result
                = default(CrefSyntax);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 40309, 40401);

                TypeSyntax
                type = f_10026_40327_40400(this, typeArgumentsMustBeIdentifiers: true, checkForMember: true)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 40415, 41260) || true) && (type == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 40415, 41260);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 40465, 40492);

                    result = f_10026_40474_40491(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 40415, 41260);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 40415, 41260);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 40526, 41260) || true) && (f_10026_40530_40550())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 40526, 41260);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 40584, 40622);

                        result = f_10026_40593_40621(type);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 40526, 41260);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 40526, 41260);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 40656, 41260) || true) && (f_10026_40660_40669(type) != SyntaxKind.QualifiedName && (DynAbs.Tracing.TraceSender.Expression_True(10026, 40660, 40752) && f_10026_40701_40723(f_10026_40701_40718(this)) == SyntaxKind.OpenParenToken))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 40656, 41260);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 40859, 40921);

                            CrefParameterListSyntax
                            parameters = f_10026_40896_40920(this)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 40939, 40995);

                            result = f_10026_40948_40994(type, parameters);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 40656, 41260);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 40656, 41260);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 41061, 41109);

                            SyntaxToken
                            dot = f_10026_41079_41108(this, SyntaxKind.DotToken)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 41127, 41171);

                            MemberCrefSyntax
                            member = f_10026_41153_41170(this)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 41189, 41245);

                            result = f_10026_41198_41244(type, dot, member);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 40656, 41260);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 40526, 41260);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 40415, 41260);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 41276, 41352);

                bool
                needOverallError = f_10026_41300_41321_M(!IsEndOfCrefAttribute) || (DynAbs.Tracing.TraceSender.Expression_False(10026, 41300, 41351) || f_10026_41325_41351(result))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 41368, 41750) || true) && (f_10026_41372_41393_M(!IsEndOfCrefAttribute))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 41368, 41750);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 41427, 41473);

                    var
                    badTokens = f_10026_41443_41472(_pool)
                    ;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 41491, 41611) || true) && (f_10026_41498_41519_M(!IsEndOfCrefAttribute))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 41491, 41611);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 41561, 41592);

                            badTokens.Add(f_10026_41575_41590(this));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 41491, 41611);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10026, 41491, 41611);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10026, 41491, 41611);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 41629, 41695);

                    result = f_10026_41638_41694(this, result, badTokens.ToListNode());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 41713, 41735);

                    f_10026_41713_41734(_pool, badTokens);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 41368, 41750);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 41766, 41920) || true) && (needOverallError)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 41766, 41920);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 41820, 41905);

                    result = f_10026_41829_41904(this, result, ErrorCode.WRN_BadXMLRefSyntax, f_10026_41882_41903(result));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 41766, 41920);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 41936, 41950);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10026, 40206, 41961);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.TypeSyntax
                f_10026_40327_40400(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, bool
                typeArgumentsMustBeIdentifiers, bool
                checkForMember)
                {
                    var return_v = this_param.ParseCrefType(typeArgumentsMustBeIdentifiers: typeArgumentsMustBeIdentifiers, checkForMember: checkForMember);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 40327, 40400);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.MemberCrefSyntax
                f_10026_40474_40491(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.ParseMemberCref();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 40474, 40491);
                    return return_v;
                }


                bool
                f_10026_40530_40550()
                {
                    var return_v = IsEndOfCrefAttribute;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 40530, 40550);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.TypeCrefSyntax
                f_10026_40593_40621(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.TypeSyntax
                type)
                {
                    var return_v = SyntaxFactory.TypeCref(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 40593, 40621);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10026_40660_40669(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.TypeSyntax
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 40660, 40669);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_40701_40718(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 40701, 40718);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10026_40701_40723(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 40701, 40723);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CrefParameterListSyntax
                f_10026_40896_40920(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.ParseCrefParameterList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 40896, 40920);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.NameMemberCrefSyntax
                f_10026_40948_40994(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.TypeSyntax
                name, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CrefParameterListSyntax
                parameters)
                {
                    var return_v = SyntaxFactory.NameMemberCref(name, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 40948, 40994);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_41079_41108(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = this_param.EatToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 41079, 41108);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.MemberCrefSyntax
                f_10026_41153_41170(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.ParseMemberCref();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 41153, 41170);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.QualifiedCrefSyntax
                f_10026_41198_41244(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.TypeSyntax
                container, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                dotToken, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.MemberCrefSyntax
                member)
                {
                    var return_v = SyntaxFactory.QualifiedCref(container, dotToken, member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 41198, 41244);
                    return return_v;
                }


                bool
                f_10026_41300_41321_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 41300, 41321);
                    return return_v;
                }


                bool
                f_10026_41325_41351(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CrefSyntax
                this_param)
                {
                    var return_v = this_param.ContainsDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 41325, 41351);
                    return return_v;
                }


                bool
                f_10026_41372_41393_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 41372, 41393);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>
                f_10026_41443_41472(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListPool
                this_param)
                {
                    var return_v = this_param.Allocate<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 41443, 41472);
                    return return_v;
                }


                bool
                f_10026_41498_41519_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 41498, 41519);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_41575_41590(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.EatToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 41575, 41590);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CrefSyntax
                f_10026_41638_41694(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CrefSyntax
                node, Microsoft.CodeAnalysis.GreenNode?
                skippedSyntax)
                {
                    var return_v = this_param.AddTrailingSkippedSyntax<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CrefSyntax>(node, skippedSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 41638, 41694);
                    return return_v;
                }


                int
                f_10026_41713_41734(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListPool
                this_param, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>
                item)
                {
                    this_param.Free((Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 41713, 41734);
                    return 0;
                }


                string
                f_10026_41882_41903(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CrefSyntax
                this_param)
                {
                    var return_v = this_param.ToFullString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 41882, 41903);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CrefSyntax
                f_10026_41829_41904(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CrefSyntax
                node, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = this_param.AddError<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CrefSyntax>(node, code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 41829, 41904);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10026, 40206, 41961);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10026, 40206, 41961);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private MemberCrefSyntax ParseMemberCref()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10026, 42187, 42768);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 42254, 42757);

                switch (f_10026_42262_42279(f_10026_42262_42274()))
                {

                    case SyntaxKind.ThisKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 42254, 42757);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 42363, 42395);

                        return f_10026_42370_42394(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 42254, 42757);

                    case SyntaxKind.OperatorKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 42254, 42757);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 42467, 42500);

                        return f_10026_42474_42499(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 42254, 42757);

                    case SyntaxKind.ExplicitKeyword:
                    case SyntaxKind.ImplicitKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 42254, 42757);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 42622, 42665);

                        return f_10026_42629_42664(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 42254, 42757);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 42254, 42757);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 42713, 42742);

                        return f_10026_42720_42741(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 42254, 42757);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10026, 42187, 42768);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_42262_42274()
                {
                    var return_v = CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 42262, 42274);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10026_42262_42279(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 42262, 42279);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.IndexerMemberCrefSyntax
                f_10026_42370_42394(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.ParseIndexerMemberCref();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 42370, 42394);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.OperatorMemberCrefSyntax
                f_10026_42474_42499(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.ParseOperatorMemberCref();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 42474, 42499);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ConversionOperatorMemberCrefSyntax
                f_10026_42629_42664(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.ParseConversionOperatorMemberCref();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 42629, 42664);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.NameMemberCrefSyntax
                f_10026_42720_42741(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.ParseNameMemberCref();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 42720, 42741);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10026, 42187, 42768);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10026, 42187, 42768);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private NameMemberCrefSyntax ParseNameMemberCref()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10026, 42953, 43261);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 43028, 43104);

                SimpleNameSyntax
                name = f_10026_43052_43103(this, typeArgumentsMustBeIdentifiers: true)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 43118, 43180);

                CrefParameterListSyntax
                parameters = f_10026_43155_43179(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 43196, 43250);

                return f_10026_43203_43249(name, parameters);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10026, 42953, 43261);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SimpleNameSyntax
                f_10026_43052_43103(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, bool
                typeArgumentsMustBeIdentifiers)
                {
                    var return_v = this_param.ParseCrefName(typeArgumentsMustBeIdentifiers: typeArgumentsMustBeIdentifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 43052, 43103);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CrefParameterListSyntax
                f_10026_43155_43179(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.ParseCrefParameterList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 43155, 43179);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.NameMemberCrefSyntax
                f_10026_43203_43249(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SimpleNameSyntax
                name, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CrefParameterListSyntax
                parameters)
                {
                    var return_v = SyntaxFactory.NameMemberCref((Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.TypeSyntax)name, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 43203, 43249);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10026, 42953, 43261);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10026, 42953, 43261);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private IndexerMemberCrefSyntax ParseIndexerMemberCref()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10026, 43384, 43759);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 43465, 43523);

                f_10026_43465_43522(f_10026_43478_43495(f_10026_43478_43490()) == SyntaxKind.ThisKeyword);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 43537, 43574);

                SyntaxToken
                thisKeyword = f_10026_43563_43573(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 43588, 43668);

                CrefBracketedParameterListSyntax
                parameters = f_10026_43634_43667(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 43684, 43748);

                return f_10026_43691_43747(thisKeyword, parameters);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10026, 43384, 43759);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_43478_43490()
                {
                    var return_v = CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 43478, 43490);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10026_43478_43495(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 43478, 43495);
                    return return_v;
                }


                int
                f_10026_43465_43522(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 43465, 43522);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_43563_43573(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.EatToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 43563, 43573);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CrefBracketedParameterListSyntax
                f_10026_43634_43667(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.ParseBracketedCrefParameterList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 43634, 43667);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.IndexerMemberCrefSyntax
                f_10026_43691_43747(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                thisKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CrefBracketedParameterListSyntax
                parameters)
                {
                    var return_v = SyntaxFactory.IndexerMemberCref(thisKeyword, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 43691, 43747);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10026, 43384, 43759);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10026, 43384, 43759);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private OperatorMemberCrefSyntax ParseOperatorMemberCref()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10026, 43889, 48429);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 43972, 44034);

                f_10026_43972_44033(f_10026_43985_44002(f_10026_43985_43997()) == SyntaxKind.OperatorKeyword);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 44048, 44089);

                SyntaxToken
                operatorKeyword = f_10026_44078_44088(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 44105, 44131);

                SyntaxToken
                operatorToken
                = default(SyntaxToken);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 44147, 45292) || true) && (f_10026_44151_44207(f_10026_44189_44206(f_10026_44189_44201())))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 44147, 45292);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 44241, 44268);

                    operatorToken = f_10026_44257_44267(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 44147, 45292);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 44147, 45292);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 44334, 44399);

                    operatorToken = f_10026_44350_44398(SyntaxKind.PlusToken);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 44528, 44539);

                    int
                    offset
                    = default(int);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 44557, 44567);

                    int
                    width
                    = default(int);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 44585, 44641);

                    f_10026_44585_44640(this, out offset, out width);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 44661, 44922) || true) && (f_10026_44665_44727(f_10026_44709_44726(f_10026_44709_44721())) || (DynAbs.Tracing.TraceSender.Expression_False(10026, 44665, 44793) || f_10026_44731_44793(f_10026_44775_44792(f_10026_44775_44787()))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 44661, 44922);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 44835, 44903);

                        operatorToken = f_10026_44851_44902(this, operatorToken, f_10026_44891_44901(this));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 44661, 44922);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 44942, 45048);

                    SyntaxDiagnosticInfo
                    rawInfo = f_10026_44973_45047(offset, width, ErrorCode.ERR_OvlOperatorExpected)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 45066, 45190);

                    SyntaxDiagnosticInfo
                    crefInfo = f_10026_45098_45189(offset, width, ErrorCode.WRN_ErrorOverride, rawInfo, f_10026_45176_45188(rawInfo))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 45210, 45277);

                    operatorToken = f_10026_45226_45276(this, operatorToken, crefInfo);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 44147, 45292);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 45489, 48152) || true) && (f_10026_45493_45511(operatorToken) == SyntaxKind.GreaterThanToken && (DynAbs.Tracing.TraceSender.Expression_True(10026, 45493, 45589) && f_10026_45546_45584(operatorToken) == 0) && (DynAbs.Tracing.TraceSender.Expression_True(10026, 45493, 45634) && f_10026_45593_45629(f_10026_45593_45605()) == 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 45489, 48152);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 45668, 48137) || true) && (f_10026_45672_45689(f_10026_45672_45684()) == SyntaxKind.GreaterThanToken)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 45668, 48137);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 45762, 45799);

                        var
                        operatorToken2 = f_10026_45783_45798(this)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 45821, 46187);

                        operatorToken = f_10026_45837_46186(f_10026_45883_45915(operatorToken), SyntaxKind.GreaterThanGreaterThanToken, f_10026_46007_46025(operatorToken) + f_10026_46028_46047(operatorToken2), f_10026_46074_46097(operatorToken) + f_10026_46100_46124(operatorToken2), f_10026_46151_46185(operatorToken2));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 45668, 48137);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 45668, 48137);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 46229, 48137) || true) && (f_10026_46233_46250(f_10026_46233_46245()) == SyntaxKind.EqualsToken)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 46229, 48137);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 46318, 46355);

                            var
                            operatorToken2 = f_10026_46339_46354(this)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 46377, 46738);

                            operatorToken = f_10026_46393_46737(f_10026_46439_46471(operatorToken), SyntaxKind.GreaterThanEqualsToken, f_10026_46558_46576(operatorToken) + f_10026_46579_46598(operatorToken2), f_10026_46625_46648(operatorToken) + f_10026_46651_46675(operatorToken2), f_10026_46702_46736(operatorToken2));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 46229, 48137);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 46229, 48137);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 46780, 48137) || true) && (f_10026_46784_46801(f_10026_46784_46796()) == SyntaxKind.GreaterThanEqualsToken)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 46780, 48137);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 46880, 46917);

                                var
                                operatorToken2 = f_10026_46901_46916(this)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 46939, 47325);

                                var
                                nonOverloadableOperator = f_10026_46969_47324(f_10026_47015_47047(operatorToken), SyntaxKind.GreaterThanGreaterThanEqualsToken, f_10026_47145_47163(operatorToken) + f_10026_47166_47185(operatorToken2), f_10026_47212_47235(operatorToken) + f_10026_47238_47262(operatorToken2), f_10026_47289_47323(operatorToken2))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 47349, 47414);

                                operatorToken = f_10026_47365_47413(SyntaxKind.PlusToken);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 47510, 47591);

                                operatorToken = f_10026_47526_47590(this, operatorToken, nonOverloadableOperator);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 47670, 47691);

                                const int
                                offset = 0
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 47713, 47755);

                                int
                                width = f_10026_47725_47754(nonOverloadableOperator)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 47777, 47883);

                                SyntaxDiagnosticInfo
                                rawInfo = f_10026_47808_47882(offset, width, ErrorCode.ERR_OvlOperatorExpected)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 47905, 48029);

                                SyntaxDiagnosticInfo
                                crefInfo = f_10026_47937_48028(offset, width, ErrorCode.WRN_ErrorOverride, rawInfo, f_10026_48015_48027(rawInfo))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 48051, 48118);

                                operatorToken = f_10026_48067_48117(this, operatorToken, crefInfo);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 46780, 48137);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 46229, 48137);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 45668, 48137);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 45489, 48152);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 48168, 48240);

                f_10026_48168_48239(f_10026_48181_48238(f_10026_48219_48237(operatorToken)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 48256, 48318);

                CrefParameterListSyntax
                parameters = f_10026_48293_48317(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 48334, 48418);

                return f_10026_48341_48417(operatorKeyword, operatorToken, parameters);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10026, 43889, 48429);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_43985_43997()
                {
                    var return_v = CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 43985, 43997);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10026_43985_44002(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 43985, 44002);
                    return return_v;
                }


                int
                f_10026_43972_44033(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 43972, 44033);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_44078_44088(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.EatToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 44078, 44088);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_44189_44201()
                {
                    var return_v = CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 44189, 44201);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10026_44189_44206(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 44189, 44206);
                    return return_v;
                }


                bool
                f_10026_44151_44207(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.IsAnyOverloadableOperator(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 44151, 44207);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_44257_44267(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.EatToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 44257, 44267);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_44350_44398(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFactory.MissingToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 44350, 44398);
                    return return_v;
                }


                int
                f_10026_44585_44640(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, out int
                offset, out int
                width)
                {
                    this_param.GetDiagnosticSpanForMissingToken(out offset, out width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 44585, 44640);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_44709_44721()
                {
                    var return_v = CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 44709, 44721);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10026_44709_44726(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 44709, 44726);
                    return return_v;
                }


                bool
                f_10026_44665_44727(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                token)
                {
                    var return_v = SyntaxFacts.IsUnaryOperatorDeclarationToken(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 44665, 44727);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_44775_44787()
                {
                    var return_v = CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 44775, 44787);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10026_44775_44792(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 44775, 44792);
                    return return_v;
                }


                bool
                f_10026_44731_44793(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                token)
                {
                    var return_v = SyntaxFacts.IsBinaryExpressionOperatorToken(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 44731, 44793);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_44891_44901(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.EatToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 44891, 44901);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_44851_44902(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                node, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                skippedSyntax)
                {
                    var return_v = this_param.AddTrailingSkippedSyntax<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>(node, (Microsoft.CodeAnalysis.GreenNode)skippedSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 44851, 44902);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
                f_10026_44973_45047(int
                offset, int
                width, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo(offset, width, code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 44973, 45047);
                    return return_v;
                }


                int
                f_10026_45176_45188(Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
                this_param)
                {
                    var return_v = this_param.Code;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 45176, 45188);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
                f_10026_45098_45189(int
                offset, int
                width, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo(offset, width, code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 45098, 45189);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_45226_45276(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                node, params Microsoft.CodeAnalysis.DiagnosticInfo[]
                diagnostics)
                {
                    var return_v = this_param.WithAdditionalDiagnostics<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>(node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 45226, 45276);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10026_45493_45511(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 45493, 45511);
                    return return_v;
                }


                int
                f_10026_45546_45584(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.GetTrailingTriviaWidth();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 45546, 45584);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_45593_45605()
                {
                    var return_v = CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 45593, 45605);
                    return return_v;
                }


                int
                f_10026_45593_45629(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.GetLeadingTriviaWidth();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 45593, 45629);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_45672_45684()
                {
                    var return_v = CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 45672, 45684);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10026_45672_45689(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 45672, 45689);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_45783_45798(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.EatToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 45783, 45798);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_10026_45883_45915(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.GetLeadingTrivia();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 45883, 45915);
                    return return_v;
                }


                string
                f_10026_46007_46025(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 46007, 46025);
                    return return_v;
                }


                string
                f_10026_46028_46047(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 46028, 46047);
                    return return_v;
                }


                string
                f_10026_46074_46097(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.ValueText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 46074, 46097);
                    return return_v;
                }


                string
                f_10026_46100_46124(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.ValueText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 46100, 46124);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_10026_46151_46185(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.GetTrailingTrivia();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 46151, 46185);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_45837_46186(Microsoft.CodeAnalysis.GreenNode
                leading, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, string
                text, string
                valueText, Microsoft.CodeAnalysis.GreenNode
                trailing)
                {
                    var return_v = SyntaxFactory.Token(leading, kind, text, valueText, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 45837, 46186);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_46233_46245()
                {
                    var return_v = CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 46233, 46245);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10026_46233_46250(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 46233, 46250);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_46339_46354(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.EatToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 46339, 46354);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_10026_46439_46471(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.GetLeadingTrivia();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 46439, 46471);
                    return return_v;
                }


                string
                f_10026_46558_46576(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 46558, 46576);
                    return return_v;
                }


                string
                f_10026_46579_46598(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 46579, 46598);
                    return return_v;
                }


                string
                f_10026_46625_46648(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.ValueText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 46625, 46648);
                    return return_v;
                }


                string
                f_10026_46651_46675(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.ValueText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 46651, 46675);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_10026_46702_46736(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.GetTrailingTrivia();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 46702, 46736);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_46393_46737(Microsoft.CodeAnalysis.GreenNode
                leading, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, string
                text, string
                valueText, Microsoft.CodeAnalysis.GreenNode
                trailing)
                {
                    var return_v = SyntaxFactory.Token(leading, kind, text, valueText, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 46393, 46737);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_46784_46796()
                {
                    var return_v = CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 46784, 46796);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10026_46784_46801(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 46784, 46801);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_46901_46916(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.EatToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 46901, 46916);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_10026_47015_47047(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.GetLeadingTrivia();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 47015, 47047);
                    return return_v;
                }


                string
                f_10026_47145_47163(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 47145, 47163);
                    return return_v;
                }


                string
                f_10026_47166_47185(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 47166, 47185);
                    return return_v;
                }


                string
                f_10026_47212_47235(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.ValueText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 47212, 47235);
                    return return_v;
                }


                string
                f_10026_47238_47262(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.ValueText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 47238, 47262);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_10026_47289_47323(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.GetTrailingTrivia();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 47289, 47323);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_46969_47324(Microsoft.CodeAnalysis.GreenNode
                leading, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, string
                text, string
                valueText, Microsoft.CodeAnalysis.GreenNode
                trailing)
                {
                    var return_v = SyntaxFactory.Token(leading, kind, text, valueText, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 46969, 47324);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_47365_47413(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFactory.MissingToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 47365, 47413);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_47526_47590(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                node, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                skippedSyntax)
                {
                    var return_v = this_param.AddTrailingSkippedSyntax<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>(node, (Microsoft.CodeAnalysis.GreenNode)skippedSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 47526, 47590);
                    return return_v;
                }


                int
                f_10026_47725_47754(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Width;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 47725, 47754);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
                f_10026_47808_47882(int
                offset, int
                width, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo(offset, width, code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 47808, 47882);
                    return return_v;
                }


                int
                f_10026_48015_48027(Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
                this_param)
                {
                    var return_v = this_param.Code;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 48015, 48027);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
                f_10026_47937_48028(int
                offset, int
                width, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo(offset, width, code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 47937, 48028);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_48067_48117(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                node, params Microsoft.CodeAnalysis.DiagnosticInfo[]
                diagnostics)
                {
                    var return_v = this_param.WithAdditionalDiagnostics<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>(node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 48067, 48117);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10026_48219_48237(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 48219, 48237);
                    return return_v;
                }


                bool
                f_10026_48181_48238(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.IsAnyOverloadableOperator(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 48181, 48238);
                    return return_v;
                }


                int
                f_10026_48168_48239(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 48168, 48239);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CrefParameterListSyntax
                f_10026_48293_48317(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.ParseCrefParameterList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 48293, 48317);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.OperatorMemberCrefSyntax
                f_10026_48341_48417(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                operatorKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                operatorToken, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CrefParameterListSyntax
                parameters)
                {
                    var return_v = SyntaxFactory.OperatorMemberCref(operatorKeyword, operatorToken, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 48341, 48417);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10026, 43889, 48429);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10026, 43889, 48429);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ConversionOperatorMemberCrefSyntax ParseConversionOperatorMemberCref()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10026, 48560, 49231);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 48663, 48793);

                f_10026_48663_48792(f_10026_48676_48693(f_10026_48676_48688()) == SyntaxKind.ExplicitKeyword || (DynAbs.Tracing.TraceSender.Expression_False(10026, 48676, 48791) || f_10026_48744_48761(f_10026_48744_48756()) == SyntaxKind.ImplicitKeyword));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 48807, 48851);

                SyntaxToken
                implicitOrExplicit = f_10026_48840_48850(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 48867, 48934);

                SyntaxToken
                operatorKeyword = f_10026_48897_48933(this, SyntaxKind.OperatorKeyword)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 48950, 49021);

                TypeSyntax
                type = f_10026_48968_49020(this, typeArgumentsMustBeIdentifiers: false)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 49037, 49099);

                CrefParameterListSyntax
                parameters = f_10026_49074_49098(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 49115, 49220);

                return f_10026_49122_49219(implicitOrExplicit, operatorKeyword, type, parameters);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10026, 48560, 49231);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_48676_48688()
                {
                    var return_v = CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 48676, 48688);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10026_48676_48693(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 48676, 48693);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_48744_48756()
                {
                    var return_v = CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 48744, 48756);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10026_48744_48761(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 48744, 48761);
                    return return_v;
                }


                int
                f_10026_48663_48792(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 48663, 48792);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_48840_48850(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.EatToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 48840, 48850);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_48897_48933(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = this_param.EatToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 48897, 48933);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.TypeSyntax
                f_10026_48968_49020(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, bool
                typeArgumentsMustBeIdentifiers)
                {
                    var return_v = this_param.ParseCrefType(typeArgumentsMustBeIdentifiers: typeArgumentsMustBeIdentifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 48968, 49020);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CrefParameterListSyntax
                f_10026_49074_49098(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.ParseCrefParameterList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 49074, 49098);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ConversionOperatorMemberCrefSyntax
                f_10026_49122_49219(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                implicitOrExplicitKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                operatorKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.TypeSyntax
                type, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CrefParameterListSyntax
                parameters)
                {
                    var return_v = SyntaxFactory.ConversionOperatorMemberCref(implicitOrExplicitKeyword, operatorKeyword, type, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 49122, 49219);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10026, 48560, 49231);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10026, 48560, 49231);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private CrefParameterListSyntax ParseCrefParameterList()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10026, 49341, 49518);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 49422, 49507);

                return (CrefParameterListSyntax)f_10026_49454_49506(this, useSquareBrackets: false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10026, 49341, 49518);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BaseCrefParameterListSyntax
                f_10026_49454_49506(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, bool
                useSquareBrackets)
                {
                    var return_v = this_param.ParseBaseCrefParameterList(useSquareBrackets: useSquareBrackets);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 49454, 49506);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10026, 49341, 49518);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10026, 49341, 49518);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private CrefBracketedParameterListSyntax ParseBracketedCrefParameterList()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10026, 49624, 49827);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 49723, 49816);

                return (CrefBracketedParameterListSyntax)f_10026_49764_49815(this, useSquareBrackets: true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10026, 49624, 49827);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BaseCrefParameterListSyntax
                f_10026_49764_49815(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, bool
                useSquareBrackets)
                {
                    var return_v = this_param.ParseBaseCrefParameterList(useSquareBrackets: useSquareBrackets);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 49764, 49815);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10026, 49624, 49827);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10026, 49624, 49827);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BaseCrefParameterListSyntax ParseBaseCrefParameterList(bool useSquareBrackets)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10026, 49992, 52092);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 50103, 50201);

                SyntaxKind
                openKind = (DynAbs.Tracing.TraceSender.Conditional_F1(10026, 50125, 50142) || ((useSquareBrackets && DynAbs.Tracing.TraceSender.Conditional_F2(10026, 50145, 50172)) || DynAbs.Tracing.TraceSender.Conditional_F3(10026, 50175, 50200))) ? SyntaxKind.OpenBracketToken : SyntaxKind.OpenParenToken
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 50215, 50316);

                SyntaxKind
                closeKind = (DynAbs.Tracing.TraceSender.Conditional_F1(10026, 50238, 50255) || ((useSquareBrackets && DynAbs.Tracing.TraceSender.Conditional_F2(10026, 50258, 50286)) || DynAbs.Tracing.TraceSender.Conditional_F3(10026, 50289, 50315))) ? SyntaxKind.CloseBracketToken : SyntaxKind.CloseParenToken
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 50332, 50426) || true) && (f_10026_50336_50353(f_10026_50336_50348()) != openKind)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 50332, 50426);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 50399, 50411);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 50332, 50426);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 50442, 50480);

                SyntaxToken
                open = f_10026_50461_50479(this, openKind)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 50496, 50554);

                var
                list = f_10026_50507_50553(_pool)
                ;
                try
                {
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 50604, 51497) || true) && (f_10026_50611_50628(f_10026_50611_50623()) == SyntaxKind.CommaToken || (DynAbs.Tracing.TraceSender.Expression_False(10026, 50611, 50682) || f_10026_50657_50682(this)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 50604, 51497);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 50724, 50755);

                            list.Add(f_10026_50733_50753(this));

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 50779, 51478) || true) && (f_10026_50783_50800(f_10026_50783_50795()) != closeKind)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 50779, 51478);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 50863, 50915);

                                SyntaxToken
                                comma = f_10026_50883_50914(this, SyntaxKind.CommaToken)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 50941, 51455) || true) && (f_10026_50945_50961_M(!comma.IsMissing) || (DynAbs.Tracing.TraceSender.Expression_False(10026, 50945, 50990) || f_10026_50965_50990(this)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 50941, 51455);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 51126, 51151);

                                    list.AddSeparator(comma);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 50941, 51455);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 50941, 51455);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 51371, 51428);

                                    f_10026_51371_51427(f_10026_51384_51401(f_10026_51384_51396()) != SyntaxKind.CommaToken);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 50941, 51455);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 50779, 51478);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 50604, 51497);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10026, 50604, 51497);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10026, 50604, 51497);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 51709, 51749);

                    SyntaxToken
                    close = f_10026_51729_51748(this, closeKind)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 51769, 51980);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10026, 51776, 51793) || ((useSquareBrackets
                    && DynAbs.Tracing.TraceSender.Conditional_F2(10026, 51817, 51905)) || DynAbs.Tracing.TraceSender.Conditional_F3(10026, 51929, 51979))) ? (BaseCrefParameterListSyntax)f_10026_51846_51905(open, list, close) : f_10026_51929_51979(open, list, close);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(10026, 52009, 52081);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 52049, 52066);

                    f_10026_52049_52065(_pool, list);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(10026, 52009, 52081);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10026, 49992, 52092);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_50336_50348()
                {
                    var return_v = CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 50336, 50348);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10026_50336_50353(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 50336, 50353);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_50461_50479(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = this_param.EatToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 50461, 50479);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxListBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CrefParameterSyntax>
                f_10026_50507_50553(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListPool
                this_param)
                {
                    var return_v = this_param.AllocateSeparated<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CrefParameterSyntax>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 50507, 50553);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_50611_50623()
                {
                    var return_v = CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 50611, 50623);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10026_50611_50628(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 50611, 50628);
                    return return_v;
                }


                bool
                f_10026_50657_50682(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.IsPossibleCrefParameter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 50657, 50682);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CrefParameterSyntax
                f_10026_50733_50753(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.ParseCrefParameter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 50733, 50753);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_50783_50795()
                {
                    var return_v = CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 50783, 50795);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10026_50783_50800(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 50783, 50800);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_50883_50914(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = this_param.EatToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 50883, 50914);
                    return return_v;
                }


                bool
                f_10026_50945_50961_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 50945, 50961);
                    return return_v;
                }


                bool
                f_10026_50965_50990(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.IsPossibleCrefParameter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 50965, 50990);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_51384_51396()
                {
                    var return_v = CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 51384, 51396);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10026_51384_51401(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 51384, 51401);
                    return return_v;
                }


                int
                f_10026_51371_51427(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 51371, 51427);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_51729_51748(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = this_param.EatToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 51729, 51748);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CrefBracketedParameterListSyntax
                f_10026_51846_51905(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                openBracketToken, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxListBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CrefParameterSyntax>
                parameters, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                closeBracketToken)
                {
                    var return_v = SyntaxFactory.CrefBracketedParameterList(openBracketToken, (Microsoft.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CrefParameterSyntax>)parameters, closeBracketToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 51846, 51905);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CrefParameterListSyntax
                f_10026_51929_51979(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                openParenToken, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxListBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CrefParameterSyntax>
                parameters, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                closeParenToken)
                {
                    var return_v = SyntaxFactory.CrefParameterList(openParenToken, (Microsoft.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CrefParameterSyntax>)parameters, closeParenToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 51929, 51979);
                    return return_v;
                }


                int
                f_10026_52049_52065(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListPool
                this_param, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxListBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CrefParameterSyntax>
                item)
                {
                    this_param.Free<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CrefParameterSyntax>(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 52049, 52065);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10026, 49992, 52092);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10026, 49992, 52092);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool IsPossibleCrefParameter()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10026, 52234, 52714);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 52297, 52338);

                SyntaxKind
                kind = f_10026_52315_52337(f_10026_52315_52332(this))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 52352, 52703);

                switch (kind)
                {

                    case SyntaxKind.RefKeyword:
                    case SyntaxKind.OutKeyword:
                    case SyntaxKind.InKeyword:
                    case SyntaxKind.IdentifierToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 52352, 52703);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 52586, 52598);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 52352, 52703);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 52352, 52703);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 52646, 52688);

                        return f_10026_52653_52687(kind);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 52352, 52703);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10026, 52234, 52714);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_52315_52332(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 52315, 52332);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10026_52315_52337(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 52315, 52337);
                    return return_v;
                }


                bool
                f_10026_52653_52687(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.IsPredefinedType(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 52653, 52687);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10026, 52234, 52714);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10026, 52234, 52714);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private CrefParameterSyntax ParseCrefParameter()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10026, 52956, 53502);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 53029, 53059);

                SyntaxToken
                refKindOpt = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 53073, 53337);

                switch (f_10026_53081_53098(f_10026_53081_53093()))
                {

                    case SyntaxKind.RefKeyword:
                    case SyntaxKind.OutKeyword:
                    case SyntaxKind.InKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 53073, 53337);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 53270, 53294);

                        refKindOpt = f_10026_53283_53293(this);
                        DynAbs.Tracing.TraceSender.TraceBreak(10026, 53316, 53322);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 53073, 53337);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 53353, 53424);

                TypeSyntax
                type = f_10026_53371_53423(this, typeArgumentsMustBeIdentifiers: false)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 53438, 53491);

                return f_10026_53445_53490(refKindOpt, type);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10026, 52956, 53502);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_53081_53093()
                {
                    var return_v = CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 53081, 53093);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10026_53081_53098(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 53081, 53098);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_53283_53293(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.EatToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 53283, 53293);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.TypeSyntax
                f_10026_53371_53423(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, bool
                typeArgumentsMustBeIdentifiers)
                {
                    var return_v = this_param.ParseCrefType(typeArgumentsMustBeIdentifiers: typeArgumentsMustBeIdentifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 53371, 53423);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CrefParameterSyntax
                f_10026_53445_53490(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken?
                refKindKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.TypeSyntax
                type)
                {
                    var return_v = SyntaxFactory.CrefParameter(refKindKeyword, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 53445, 53490);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10026, 52956, 53502);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10026, 52956, 53502);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private SimpleNameSyntax ParseCrefName(bool typeArgumentsMustBeIdentifiers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10026, 53862, 55992);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 53962, 54029);

                SyntaxToken
                identifierToken = f_10026_53992_54028(this, SyntaxKind.IdentifierToken)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 54045, 54196) || true) && (f_10026_54049_54066(f_10026_54049_54061()) != SyntaxKind.LessThanToken)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 54045, 54196);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 54128, 54181);

                    return f_10026_54135_54180(identifierToken);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 54045, 54196);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 54212, 54234);

                var
                open = f_10026_54223_54233(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 54250, 54299);

                var
                list = f_10026_54261_54298(_pool)
                ;
                try
                {
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 54349, 55572) || true) && (true)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 54349, 55572);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 54402, 54472);

                            TypeSyntax
                            typeSyntax = f_10026_54426_54471(this, typeArgumentsMustBeIdentifiers)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 54496, 54869) || true) && (typeArgumentsMustBeIdentifiers && (DynAbs.Tracing.TraceSender.Expression_True(10026, 54500, 54578) && f_10026_54534_54549(typeSyntax) != SyntaxKind.IdentifierName))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 54496, 54869);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 54628, 54846);

                                typeSyntax = f_10026_54641_54845(this, typeSyntax, ErrorCode.WRN_ErrorOverride, f_10026_54725_54790(ErrorCode.ERR_TypeParamMustBeIdentifier), $"{(int)ErrorCode.ERR_TypeParamMustBeIdentifier:d4}");
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 54496, 54869);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 54893, 54914);

                            list.Add(typeSyntax);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 54938, 54974);

                            var
                            currentKind = f_10026_54956_54973(f_10026_54956_54968())
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 54996, 55553) || true) && (currentKind == SyntaxKind.CommaToken || (DynAbs.Tracing.TraceSender.Expression_False(10026, 55000, 55081) || currentKind == SyntaxKind.IdentifierToken) || (DynAbs.Tracing.TraceSender.Expression_False(10026, 55000, 55157) || f_10026_55110_55157(f_10026_55139_55156(f_10026_55139_55151()))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 54996, 55553);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 55375, 55426);

                                list.AddSeparator(f_10026_55393_55424(this, SyntaxKind.CommaToken));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 54996, 55553);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 54996, 55553);
                                DynAbs.Tracing.TraceSender.TraceBreak(10026, 55524, 55530);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 54996, 55553);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 54349, 55572);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10026, 54349, 55572);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10026, 54349, 55572);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 55592, 55650);

                    SyntaxToken
                    close = f_10026_55612_55649(this, SyntaxKind.GreaterThanToken)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 55670, 55759);

                    open = f_10026_55677_55758(this, open, MessageID.IDS_FeatureGenerics, forceWarning: true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 55779, 55880);

                    return f_10026_55786_55879(identifierToken, f_10026_55829_55878(open, list, close));
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(10026, 55909, 55981);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 55949, 55966);

                    f_10026_55949_55965(_pool, list);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(10026, 55909, 55981);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10026, 53862, 55992);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_53992_54028(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = this_param.EatToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 53992, 54028);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_54049_54061()
                {
                    var return_v = CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 54049, 54061);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10026_54049_54066(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 54049, 54066);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.IdentifierNameSyntax
                f_10026_54135_54180(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                identifier)
                {
                    var return_v = SyntaxFactory.IdentifierName(identifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 54135, 54180);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_54223_54233(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.EatToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 54223, 54233);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxListBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.TypeSyntax>
                f_10026_54261_54298(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListPool
                this_param)
                {
                    var return_v = this_param.AllocateSeparated<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.TypeSyntax>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 54261, 54298);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.TypeSyntax
                f_10026_54426_54471(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, bool
                typeArgumentsMustBeIdentifiers)
                {
                    var return_v = this_param.ParseCrefType(typeArgumentsMustBeIdentifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 54426, 54471);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10026_54534_54549(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.TypeSyntax
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 54534, 54549);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
                f_10026_54725_54790(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 54725, 54790);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.TypeSyntax
                f_10026_54641_54845(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.TypeSyntax
                node, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = this_param.AddError<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.TypeSyntax>(node, code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 54641, 54845);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_54956_54968()
                {
                    var return_v = CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 54956, 54968);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10026_54956_54973(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 54956, 54973);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_55139_55151()
                {
                    var return_v = CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 55139, 55151);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10026_55139_55156(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 55139, 55156);
                    return return_v;
                }


                bool
                f_10026_55110_55157(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.IsPredefinedType(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 55110, 55157);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_55393_55424(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = this_param.EatToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 55393, 55424);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_55612_55649(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = this_param.EatToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 55612, 55649);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_55677_55758(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                node, Microsoft.CodeAnalysis.CSharp.MessageID
                feature, bool
                forceWarning)
                {
                    var return_v = this_param.CheckFeatureAvailability<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>(node, feature, forceWarning: forceWarning);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 55677, 55758);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.TypeArgumentListSyntax
                f_10026_55829_55878(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                lessThanToken, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxListBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.TypeSyntax>
                arguments, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                greaterThanToken)
                {
                    var return_v = SyntaxFactory.TypeArgumentList(lessThanToken, (Microsoft.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.TypeSyntax>)arguments, greaterThanToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 55829, 55878);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.GenericNameSyntax
                f_10026_55786_55879(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                identifier, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.TypeArgumentListSyntax
                typeArgumentList)
                {
                    var return_v = SyntaxFactory.GenericName(identifier, typeArgumentList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 55786, 55879);
                    return return_v;
                }


                int
                f_10026_55949_55965(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListPool
                this_param, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxListBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.TypeSyntax>
                item)
                {
                    this_param.Free<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.TypeSyntax>(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 55949, 55965);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10026, 53862, 55992);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10026, 53862, 55992);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private TypeSyntax ParseCrefType(bool typeArgumentsMustBeIdentifiers, bool checkForMember = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10026, 56806, 57186);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 56929, 57028);

                TypeSyntax
                typeWithoutSuffix = f_10026_56960_57027(this, typeArgumentsMustBeIdentifiers, checkForMember)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 57042, 57175);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10026, 57049, 57079) || ((typeArgumentsMustBeIdentifiers
                && DynAbs.Tracing.TraceSender.Conditional_F2(10026, 57099, 57116)) || DynAbs.Tracing.TraceSender.Conditional_F3(10026, 57136, 57174))) ? typeWithoutSuffix
                : f_10026_57136_57174(this, typeWithoutSuffix);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10026, 56806, 57186);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.TypeSyntax
                f_10026_56960_57027(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, bool
                typeArgumentsMustBeIdentifiers, bool
                checkForMember)
                {
                    var return_v = this_param.ParseCrefTypeHelper(typeArgumentsMustBeIdentifiers, checkForMember);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 56960, 57027);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.TypeSyntax
                f_10026_57136_57174(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.TypeSyntax
                type)
                {
                    var return_v = this_param.ParseCrefTypeSuffix(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 57136, 57174);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10026, 56806, 57186);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10026, 56806, 57186);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private TypeSyntax ParseCrefTypeHelper(bool typeArgumentsMustBeIdentifiers, bool checkForMember = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10026, 57924, 60959);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 58053, 58073);

                NameSyntax
                leftName
                = default(NameSyntax);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 58089, 60047) || true) && (f_10026_58093_58140(f_10026_58122_58139(f_10026_58122_58134())))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 58089, 60047);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 58524, 58572);

                    return f_10026_58531_58571(f_10026_58560_58570(this));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 58089, 60047);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 58089, 60047);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 58606, 60047) || true) && (f_10026_58610_58627(f_10026_58610_58622()) == SyntaxKind.IdentifierToken && (DynAbs.Tracing.TraceSender.Expression_True(10026, 58610, 58708) && f_10026_58661_58678(f_10026_58661_58673(this, 1)) == SyntaxKind.ColonColonToken))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 58606, 60047);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 58774, 58805);

                        SyntaxToken
                        alias = f_10026_58794_58804(this)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 58823, 58968) || true) && (f_10026_58827_58847(alias) == SyntaxKind.GlobalKeyword)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 58823, 58968);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 58917, 58949);

                            alias = f_10026_58925_58948(alias);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 58823, 58968);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 58988, 59086);

                        alias = f_10026_58996_59085(this, alias, MessageID.IDS_FeatureGlobalNamespace, forceWarning: true);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 59106, 59142);

                        SyntaxToken
                        colonColon = f_10026_59131_59141(this)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 59160, 59230);

                        SimpleNameSyntax
                        name = f_10026_59184_59229(this, typeArgumentsMustBeIdentifiers)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 59248, 59347);

                        leftName = f_10026_59259_59346(f_10026_59292_59327(alias), colonColon, name);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 58606, 60047);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 58606, 60047);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 59442, 59482);

                        ResetPoint
                        resetPoint = f_10026_59466_59481(this)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 59500, 59557);

                        leftName = f_10026_59511_59556(this, typeArgumentsMustBeIdentifiers);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 59575, 59985) || true) && (checkForMember && (DynAbs.Tracing.TraceSender.Expression_True(10026, 59579, 59661) && (f_10026_59598_59616(leftName) || (DynAbs.Tracing.TraceSender.Expression_False(10026, 59598, 59660) || f_10026_59620_59637(f_10026_59620_59632()) != SyntaxKind.DotToken))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 59575, 59985);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 59852, 59879);

                            f_10026_59852_59878(                    // If this isn't the first part of a dotted name, then we prefer to represent it
                                                                    // as a MemberCrefSyntax.
                                                this, ref resetPoint);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 59901, 59930);

                            f_10026_59901_59929(this, ref resetPoint);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 59954, 59966);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 59575, 59985);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 60003, 60032);

                        f_10026_60003_60031(this, ref resetPoint);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 58606, 60047);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 58089, 60047);
                }
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 60063, 60916) || true) && (f_10026_60070_60087(f_10026_60070_60082()) == SyntaxKind.DotToken)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 60063, 60916);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 60230, 60270);

                        ResetPoint
                        resetPoint = f_10026_60254_60269(this)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 60290, 60319);

                        SyntaxToken
                        dot = f_10026_60308_60318(this)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 60339, 60414);

                        SimpleNameSyntax
                        rightName = f_10026_60368_60413(this, typeArgumentsMustBeIdentifiers)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 60434, 60767) || true) && (checkForMember && (DynAbs.Tracing.TraceSender.Expression_True(10026, 60438, 60521) && (f_10026_60457_60476(rightName) || (DynAbs.Tracing.TraceSender.Expression_False(10026, 60457, 60520) || f_10026_60480_60497(f_10026_60480_60492()) != SyntaxKind.DotToken))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 60434, 60767);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 60563, 60590);

                            f_10026_60563_60589(this, ref resetPoint);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 60679, 60708);

                            f_10026_60679_60707(this, ref resetPoint);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 60732, 60748);

                            return leftName;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 60434, 60767);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 60787, 60816);

                        f_10026_60787_60815(
                                        this, ref resetPoint);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 60836, 60901);

                        leftName = f_10026_60847_60900(leftName, dot, rightName);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 60063, 60916);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10026, 60063, 60916);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10026, 60063, 60916);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 60932, 60948);

                return leftName;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10026, 57924, 60959);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_58122_58134()
                {
                    var return_v = CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 58122, 58134);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10026_58122_58139(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 58122, 58139);
                    return return_v;
                }


                bool
                f_10026_58093_58140(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.IsPredefinedType(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 58093, 58140);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_58560_58570(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.EatToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 58560, 58570);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.PredefinedTypeSyntax
                f_10026_58531_58571(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                keyword)
                {
                    var return_v = SyntaxFactory.PredefinedType(keyword);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 58531, 58571);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_58610_58622()
                {
                    var return_v = CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 58610, 58622);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10026_58610_58627(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 58610, 58627);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_58661_58673(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, int
                n)
                {
                    var return_v = this_param.PeekToken(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 58661, 58673);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10026_58661_58678(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 58661, 58678);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_58794_58804(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.EatToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 58794, 58804);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10026_58827_58847(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.ContextualKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 58827, 58847);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_58925_58948(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                token)
                {
                    var return_v = ConvertToKeyword(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 58925, 58948);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_58996_59085(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                node, Microsoft.CodeAnalysis.CSharp.MessageID
                feature, bool
                forceWarning)
                {
                    var return_v = this_param.CheckFeatureAvailability<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>(node, feature, forceWarning: forceWarning);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 58996, 59085);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_59131_59141(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.EatToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 59131, 59141);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SimpleNameSyntax
                f_10026_59184_59229(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, bool
                typeArgumentsMustBeIdentifiers)
                {
                    var return_v = this_param.ParseCrefName(typeArgumentsMustBeIdentifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 59184, 59229);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.IdentifierNameSyntax
                f_10026_59292_59327(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                identifier)
                {
                    var return_v = SyntaxFactory.IdentifierName(identifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 59292, 59327);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.AliasQualifiedNameSyntax
                f_10026_59259_59346(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.IdentifierNameSyntax
                alias, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                colonColonToken, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SimpleNameSyntax
                name)
                {
                    var return_v = SyntaxFactory.AliasQualifiedName(alias, colonColonToken, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 59259, 59346);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser.ResetPoint
                f_10026_59466_59481(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.GetResetPoint();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 59466, 59481);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SimpleNameSyntax
                f_10026_59511_59556(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, bool
                typeArgumentsMustBeIdentifiers)
                {
                    var return_v = this_param.ParseCrefName(typeArgumentsMustBeIdentifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 59511, 59556);
                    return return_v;
                }


                bool
                f_10026_59598_59616(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.NameSyntax
                this_param)
                {
                    var return_v = this_param.IsMissing;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 59598, 59616);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_59620_59632()
                {
                    var return_v = CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 59620, 59632);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10026_59620_59637(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 59620, 59637);
                    return return_v;
                }


                int
                f_10026_59852_59878(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, ref Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser.ResetPoint
                point)
                {
                    this_param.Reset(ref point);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 59852, 59878);
                    return 0;
                }


                int
                f_10026_59901_59929(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, ref Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser.ResetPoint
                point)
                {
                    this_param.Release(ref point);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 59901, 59929);
                    return 0;
                }


                int
                f_10026_60003_60031(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, ref Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser.ResetPoint
                point)
                {
                    this_param.Release(ref point);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 60003, 60031);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_60070_60082()
                {
                    var return_v = CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 60070, 60082);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10026_60070_60087(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 60070, 60087);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser.ResetPoint
                f_10026_60254_60269(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.GetResetPoint();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 60254, 60269);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_60308_60318(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.EatToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 60308, 60318);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SimpleNameSyntax
                f_10026_60368_60413(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, bool
                typeArgumentsMustBeIdentifiers)
                {
                    var return_v = this_param.ParseCrefName(typeArgumentsMustBeIdentifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 60368, 60413);
                    return return_v;
                }


                bool
                f_10026_60457_60476(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SimpleNameSyntax
                this_param)
                {
                    var return_v = this_param.IsMissing;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 60457, 60476);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_60480_60492()
                {
                    var return_v = CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 60480, 60492);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10026_60480_60497(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 60480, 60497);
                    return return_v;
                }


                int
                f_10026_60563_60589(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, ref Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser.ResetPoint
                point)
                {
                    this_param.Reset(ref point);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 60563, 60589);
                    return 0;
                }


                int
                f_10026_60679_60707(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, ref Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser.ResetPoint
                point)
                {
                    this_param.Release(ref point);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 60679, 60707);
                    return 0;
                }


                int
                f_10026_60787_60815(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, ref Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser.ResetPoint
                point)
                {
                    this_param.Release(ref point);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 60787, 60815);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.QualifiedNameSyntax
                f_10026_60847_60900(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.NameSyntax
                left, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                dotToken, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SimpleNameSyntax
                right)
                {
                    var return_v = SyntaxFactory.QualifiedName(left, dotToken, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 60847, 60900);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10026, 57924, 60959);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10026, 57924, 60959);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private TypeSyntax ParseCrefTypeSuffix(TypeSyntax type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10026, 61172, 64395);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 61252, 61402) || true) && (f_10026_61256_61273(f_10026_61256_61268()) == SyntaxKind.QuestionToken)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 61252, 61402);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 61335, 61387);

                    type = f_10026_61342_61386(type, f_10026_61375_61385(this));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 61252, 61402);
                }
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 61418, 61570) || true) && (f_10026_61425_61442(f_10026_61425_61437()) == SyntaxKind.AsteriskToken)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 61418, 61570);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 61504, 61555);

                        type = f_10026_61511_61554(type, f_10026_61543_61553(this));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 61418, 61570);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10026, 61418, 61570);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10026, 61418, 61570);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 61586, 64358) || true) && (f_10026_61590_61607(f_10026_61590_61602()) == SyntaxKind.OpenBracketToken)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 61586, 64358);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 61672, 61819);

                    var
                    omittedArraySizeExpressionInstance = f_10026_61713_61818(f_10026_61754_61817(SyntaxKind.OmittedArraySizeExpressionToken))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 61837, 61895);

                    var
                    rankList = f_10026_61852_61894(_pool)
                    ;
                    try
                    {
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 61957, 64147) || true) && (f_10026_61964_61981(f_10026_61964_61976()) == SyntaxKind.OpenBracketToken)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 61957, 64147);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 62062, 62092);

                                SyntaxToken
                                open = f_10026_62081_62091(this)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 62118, 62182);

                                var
                                dimensionList = f_10026_62138_62181(_pool)
                                ;
                                try
                                {
                                    try
                                    {
                                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 62268, 63300) || true) && (f_10026_62275_62297(f_10026_62275_62292(this)) != SyntaxKind.CloseBracketToken)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 62268, 63300);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 62395, 63269) || true) && (f_10026_62399_62421(f_10026_62399_62416(this)) == SyntaxKind.CommaToken)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 62395, 63269);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 62623, 62677);

                                                dimensionList.Add(omittedArraySizeExpressionInstance);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 62715, 62759);

                                                dimensionList.AddSeparator(f_10026_62742_62757(this));
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 62395, 63269);
                                            }

                                            else

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 62395, 63269);
                                                DynAbs.Tracing.TraceSender.TraceBreak(10026, 63228, 63234);

                                                break;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 62395, 63269);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 62268, 63300);
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10026, 62268, 63300);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(10026, 62268, 63300);
                                    }
                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 63506, 63691) || true) && ((dimensionList.Count & 1) == 0)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 63506, 63691);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 63606, 63660);

                                        dimensionList.Add(omittedArraySizeExpressionInstance);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 63506, 63691);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 63791, 63847);

                                    var
                                    close = f_10026_63803_63846(this, SyntaxKind.CloseBracketToken)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 63879, 63954);

                                    rankList.Add(f_10026_63892_63952(open, dimensionList, close));
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterFinally(10026, 64007, 64124);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 64071, 64097);

                                    f_10026_64071_64096(_pool, dimensionList);
                                    DynAbs.Tracing.TraceSender.TraceExitFinally(10026, 64007, 64124);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 61957, 64147);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10026, 61957, 64147);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10026, 61957, 64147);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 64171, 64218);

                        type = f_10026_64178_64217(type, rankList);
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(10026, 64255, 64343);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 64303, 64324);

                        f_10026_64303_64323(_pool, rankList);
                        DynAbs.Tracing.TraceSender.TraceExitFinally(10026, 64255, 64343);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 61586, 64358);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 64372, 64384);

                return type;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10026, 61172, 64395);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_61256_61268()
                {
                    var return_v = CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 61256, 61268);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10026_61256_61273(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 61256, 61273);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_61375_61385(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.EatToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 61375, 61385);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.NullableTypeSyntax
                f_10026_61342_61386(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.TypeSyntax
                elementType, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                questionToken)
                {
                    var return_v = SyntaxFactory.NullableType(elementType, questionToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 61342, 61386);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_61425_61437()
                {
                    var return_v = CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 61425, 61437);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10026_61425_61442(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 61425, 61442);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_61543_61553(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.EatToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 61543, 61553);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.PointerTypeSyntax
                f_10026_61511_61554(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.TypeSyntax
                elementType, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                asteriskToken)
                {
                    var return_v = SyntaxFactory.PointerType(elementType, asteriskToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 61511, 61554);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_61590_61602()
                {
                    var return_v = CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 61590, 61602);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10026_61590_61607(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 61590, 61607);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_61754_61817(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFactory.Token(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 61754, 61817);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.OmittedArraySizeExpressionSyntax
                f_10026_61713_61818(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                omittedArraySizeExpressionToken)
                {
                    var return_v = SyntaxFactory.OmittedArraySizeExpression(omittedArraySizeExpressionToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 61713, 61818);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ArrayRankSpecifierSyntax>
                f_10026_61852_61894(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListPool
                this_param)
                {
                    var return_v = this_param.Allocate<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ArrayRankSpecifierSyntax>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 61852, 61894);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_61964_61976()
                {
                    var return_v = CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 61964, 61976);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10026_61964_61981(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 61964, 61981);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_62081_62091(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.EatToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 62081, 62091);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxListBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax>
                f_10026_62138_62181(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListPool
                this_param)
                {
                    var return_v = this_param.AllocateSeparated<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 62138, 62181);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_62275_62292(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 62275, 62292);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10026_62275_62297(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 62275, 62297);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_62399_62416(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 62399, 62416);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10026_62399_62421(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 62399, 62421);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_62742_62757(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.EatToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 62742, 62757);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_63803_63846(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = this_param.EatToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 63803, 63846);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ArrayRankSpecifierSyntax
                f_10026_63892_63952(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                openBracketToken, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxListBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax>
                sizes, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                closeBracketToken)
                {
                    var return_v = SyntaxFactory.ArrayRankSpecifier(openBracketToken, (Microsoft.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax>)sizes, closeBracketToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 63892, 63952);
                    return return_v;
                }


                int
                f_10026_64071_64096(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListPool
                this_param, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxListBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax>
                item)
                {
                    this_param.Free<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax>(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 64071, 64096);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ArrayTypeSyntax
                f_10026_64178_64217(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.TypeSyntax
                elementType, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ArrayRankSpecifierSyntax>
                rankSpecifiers)
                {
                    var return_v = SyntaxFactory.ArrayType(elementType, (Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ArrayRankSpecifierSyntax>)rankSpecifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 64178, 64217);
                    return return_v;
                }


                int
                f_10026_64303_64323(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListPool
                this_param, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ArrayRankSpecifierSyntax>
                item)
                {
                    this_param.Free((Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 64303, 64323);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10026, 61172, 64395);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10026, 61172, 64395);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool IsEndOfCrefAttribute
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10026, 64596, 65622);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 64632, 65607);

                    switch (f_10026_64640_64657(f_10026_64640_64652()))
                    {

                        case SyntaxKind.SingleQuoteToken:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 64632, 65607);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 64758, 64828);

                            return (f_10026_64766_64775(this) & LexerMode.XmlCrefQuote) == LexerMode.XmlCrefQuote;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 64632, 65607);

                        case SyntaxKind.DoubleQuoteToken:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 64632, 65607);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 64909, 64991);

                            return (f_10026_64917_64926(this) & LexerMode.XmlCrefDoubleQuote) == LexerMode.XmlCrefDoubleQuote;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 64632, 65607);

                        case SyntaxKind.EndOfFileToken:
                        case SyntaxKind.EndOfDocumentationCommentToken:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 64632, 65607);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 65139, 65151);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 64632, 65607);

                        case SyntaxKind.BadToken:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 64632, 65607);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 65375, 65519);

                            return f_10026_65382_65399(f_10026_65382_65394()) == f_10026_65403_65448(SyntaxKind.LessThanToken) || (DynAbs.Tracing.TraceSender.Expression_False(10026, 65382, 65518) || f_10026_65481_65518(f_10026_65505_65517()));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 64632, 65607);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 64632, 65607);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 65575, 65588);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 64632, 65607);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10026, 64596, 65622);

                    Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                    f_10026_64640_64652()
                    {
                        var return_v = CurrentToken;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 64640, 64652);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    f_10026_64640_64657(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 64640, 64657);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LexerMode
                    f_10026_64766_64775(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                    this_param)
                    {
                        var return_v = this_param.Mode;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 64766, 64775);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LexerMode
                    f_10026_64917_64926(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                    this_param)
                    {
                        var return_v = this_param.Mode;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 64917, 64926);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                    f_10026_65382_65394()
                    {
                        var return_v = CurrentToken;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 65382, 65394);
                        return return_v;
                    }


                    string
                    f_10026_65382_65399(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                    this_param)
                    {
                        var return_v = this_param.Text;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 65382, 65399);
                        return return_v;
                    }


                    string
                    f_10026_65403_65448(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    kind)
                    {
                        var return_v = SyntaxFacts.GetText(kind);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 65403, 65448);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                    f_10026_65505_65517()
                    {
                        var return_v = CurrentToken;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 65505, 65517);
                        return return_v;
                    }


                    bool
                    f_10026_65481_65518(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                    token)
                    {
                        var return_v = IsNonAsciiQuotationMark(token);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 65481, 65518);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10026, 64538, 65633);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10026, 64538, 65633);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private bool InCref
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10026, 65791, 66169);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 65827, 66154);

                    switch (f_10026_65835_65844(this) & (LexerMode.XmlCrefDoubleQuote | LexerMode.XmlCrefQuote))
                    {

                        case LexerMode.XmlCrefQuote:
                        case LexerMode.XmlCrefDoubleQuote:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 65827, 66154);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 66054, 66066);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 65827, 66154);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 65827, 66154);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 66122, 66135);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 65827, 66154);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10026, 65791, 66169);

                    Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LexerMode
                    f_10026_65835_65844(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                    this_param)
                    {
                        var return_v = this_param.Mode;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 65835, 65844);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10026, 65747, 66180);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10026, 65747, 66180);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private IdentifierNameSyntax ParseNameAttributeValue()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10026, 66260, 67009);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 66421, 66513);

                SyntaxToken
                identifierToken = f_10026_66451_66512(this, SyntaxKind.IdentifierToken, reportError: false)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 66529, 66929) || true) && (f_10026_66533_66554_M(!IsEndOfNameAttribute))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 66529, 66929);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 66588, 66634);

                    var
                    badTokens = f_10026_66604_66633(_pool)
                    ;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 66652, 66772) || true) && (f_10026_66659_66680_M(!IsEndOfNameAttribute))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 66652, 66772);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 66722, 66753);

                            badTokens.Add(f_10026_66736_66751(this));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 66652, 66772);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10026, 66652, 66772);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10026, 66652, 66772);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 66790, 66874);

                    identifierToken = f_10026_66808_66873(this, identifierToken, badTokens.ToListNode());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 66892, 66914);

                    f_10026_66892_66913(_pool, badTokens);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 66529, 66929);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 66945, 66998);

                return f_10026_66952_66997(identifierToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10026, 66260, 67009);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_66451_66512(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, bool
                reportError)
                {
                    var return_v = this_param.EatToken(kind, reportError: reportError);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 66451, 66512);
                    return return_v;
                }


                bool
                f_10026_66533_66554_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 66533, 66554);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>
                f_10026_66604_66633(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListPool
                this_param)
                {
                    var return_v = this_param.Allocate<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 66604, 66633);
                    return return_v;
                }


                bool
                f_10026_66659_66680_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 66659, 66680);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_66736_66751(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    var return_v = this_param.EatToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 66736, 66751);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10026_66808_66873(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                node, Microsoft.CodeAnalysis.GreenNode?
                skippedSyntax)
                {
                    var return_v = this_param.AddTrailingSkippedSyntax<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>(node, skippedSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 66808, 66873);
                    return return_v;
                }


                int
                f_10026_66892_66913(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListPool
                this_param, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>
                item)
                {
                    this_param.Free((Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 66892, 66913);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.IdentifierNameSyntax
                f_10026_66952_66997(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                identifier)
                {
                    var return_v = SyntaxFactory.IdentifierName(identifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 66952, 66997);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10026, 66260, 67009);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10026, 66260, 67009);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool IsEndOfNameAttribute
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10026, 67210, 68236);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 67246, 68221);

                    switch (f_10026_67254_67271(f_10026_67254_67266()))
                    {

                        case SyntaxKind.SingleQuoteToken:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 67246, 68221);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 67372, 67442);

                            return (f_10026_67380_67389(this) & LexerMode.XmlNameQuote) == LexerMode.XmlNameQuote;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 67246, 68221);

                        case SyntaxKind.DoubleQuoteToken:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 67246, 68221);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 67523, 67605);

                            return (f_10026_67531_67540(this) & LexerMode.XmlNameDoubleQuote) == LexerMode.XmlNameDoubleQuote;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 67246, 68221);

                        case SyntaxKind.EndOfFileToken:
                        case SyntaxKind.EndOfDocumentationCommentToken:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 67246, 68221);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 67753, 67765);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 67246, 68221);

                        case SyntaxKind.BadToken:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 67246, 68221);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 67989, 68133);

                            return f_10026_67996_68013(f_10026_67996_68008()) == f_10026_68017_68062(SyntaxKind.LessThanToken) || (DynAbs.Tracing.TraceSender.Expression_False(10026, 67996, 68132) || f_10026_68095_68132(f_10026_68119_68131()));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 67246, 68221);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10026, 67246, 68221);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10026, 68189, 68202);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10026, 67246, 68221);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10026, 67210, 68236);

                    Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                    f_10026_67254_67266()
                    {
                        var return_v = CurrentToken;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 67254, 67266);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    f_10026_67254_67271(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 67254, 67271);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LexerMode
                    f_10026_67380_67389(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                    this_param)
                    {
                        var return_v = this_param.Mode;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 67380, 67389);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LexerMode
                    f_10026_67531_67540(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                    this_param)
                    {
                        var return_v = this_param.Mode;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 67531, 67540);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                    f_10026_67996_68008()
                    {
                        var return_v = CurrentToken;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 67996, 68008);
                        return return_v;
                    }


                    string
                    f_10026_67996_68013(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                    this_param)
                    {
                        var return_v = this_param.Text;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 67996, 68013);
                        return return_v;
                    }


                    string
                    f_10026_68017_68062(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    kind)
                    {
                        var return_v = SyntaxFacts.GetText(kind);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 68017, 68062);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                    f_10026_68119_68131()
                    {
                        var return_v = CurrentToken;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10026, 68119, 68131);
                        return return_v;
                    }


                    bool
                    f_10026_68095_68132(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                    token)
                    {
                        var return_v = IsNonAsciiQuotationMark(token);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 68095, 68132);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10026, 67152, 68247);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10026, 67152, 68247);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static DocumentationCommentParser()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10026, 1349, 68298);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10026, 1349, 68298);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10026, 1349, 68298);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10026, 1349, 68298);

        Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListPool
        f_10026_1462_1482()
        {
            var return_v = new Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListPool();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 1462, 1482);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
        f_10026_1621_1626_C(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10026, 1531, 1829);
            return return_v;
        }


        System.Collections.Generic.HashSet<string>
        f_10026_13890_13911()
        {
            var return_v = new System.Collections.Generic.HashSet<string>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10026, 13890, 13911);
            return return_v;
        }

    }
}
