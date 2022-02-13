// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    public partial class DirectiveTriviaSyntax
    {
        public SyntaxToken DirectiveNameToken
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10759, 608, 3409);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 644, 3394);

                    switch (f_10759_652_663(this))
                    {

                        case SyntaxKind.IfDirectiveTrivia:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10759, 644, 3394);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 765, 814);

                            return f_10759_772_813(((IfDirectiveTriviaSyntax)this));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10759, 644, 3394);

                        case SyntaxKind.ElifDirectiveTrivia:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10759, 644, 3394);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 898, 951);

                            return f_10759_905_950(((ElifDirectiveTriviaSyntax)this));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10759, 644, 3394);

                        case SyntaxKind.ElseDirectiveTrivia:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10759, 644, 3394);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 1035, 1088);

                            return f_10759_1042_1087(((ElseDirectiveTriviaSyntax)this));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10759, 644, 3394);

                        case SyntaxKind.EndIfDirectiveTrivia:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10759, 644, 3394);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 1173, 1228);

                            return f_10759_1180_1227(((EndIfDirectiveTriviaSyntax)this));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10759, 644, 3394);

                        case SyntaxKind.RegionDirectiveTrivia:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10759, 644, 3394);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 1314, 1371);

                            return f_10759_1321_1370(((RegionDirectiveTriviaSyntax)this));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10759, 644, 3394);

                        case SyntaxKind.EndRegionDirectiveTrivia:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10759, 644, 3394);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 1460, 1523);

                            return f_10759_1467_1522(((EndRegionDirectiveTriviaSyntax)this));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10759, 644, 3394);

                        case SyntaxKind.ErrorDirectiveTrivia:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10759, 644, 3394);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 1608, 1663);

                            return f_10759_1615_1662(((ErrorDirectiveTriviaSyntax)this));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10759, 644, 3394);

                        case SyntaxKind.WarningDirectiveTrivia:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10759, 644, 3394);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 1750, 1809);

                            return f_10759_1757_1808(((WarningDirectiveTriviaSyntax)this));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10759, 644, 3394);

                        case SyntaxKind.BadDirectiveTrivia:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10759, 644, 3394);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 1892, 1943);

                            return f_10759_1899_1942(((BadDirectiveTriviaSyntax)this));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10759, 644, 3394);

                        case SyntaxKind.DefineDirectiveTrivia:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10759, 644, 3394);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 2029, 2086);

                            return f_10759_2036_2085(((DefineDirectiveTriviaSyntax)this));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10759, 644, 3394);

                        case SyntaxKind.UndefDirectiveTrivia:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10759, 644, 3394);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 2171, 2226);

                            return f_10759_2178_2225(((UndefDirectiveTriviaSyntax)this));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10759, 644, 3394);

                        case SyntaxKind.LineDirectiveTrivia:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10759, 644, 3394);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 2310, 2363);

                            return f_10759_2317_2362(((LineDirectiveTriviaSyntax)this));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10759, 644, 3394);

                        case SyntaxKind.PragmaWarningDirectiveTrivia:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10759, 644, 3394);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 2456, 2520);

                            return f_10759_2463_2519(((PragmaWarningDirectiveTriviaSyntax)this));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10759, 644, 3394);

                        case SyntaxKind.PragmaChecksumDirectiveTrivia:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10759, 644, 3394);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 2614, 2679);

                            return f_10759_2621_2678(((PragmaChecksumDirectiveTriviaSyntax)this));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10759, 644, 3394);

                        case SyntaxKind.ReferenceDirectiveTrivia:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10759, 644, 3394);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 2768, 2831);

                            return f_10759_2775_2830(((ReferenceDirectiveTriviaSyntax)this));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10759, 644, 3394);

                        case SyntaxKind.LoadDirectiveTrivia:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10759, 644, 3394);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 2915, 2968);

                            return f_10759_2922_2967(((LoadDirectiveTriviaSyntax)this));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10759, 644, 3394);

                        case SyntaxKind.ShebangDirectiveTrivia:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10759, 644, 3394);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 3055, 3116);

                            return f_10759_3062_3115(((ShebangDirectiveTriviaSyntax)this));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10759, 644, 3394);

                        case SyntaxKind.NullableDirectiveTrivia:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10759, 644, 3394);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 3204, 3265);

                            return f_10759_3211_3264(((NullableDirectiveTriviaSyntax)this));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10759, 644, 3394);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10759, 644, 3394);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 3321, 3375);

                            throw f_10759_3327_3374(f_10759_3362_3373(this));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10759, 644, 3394);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10759, 608, 3409);

                    Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    f_10759_652_663(Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
                    this_param)
                    {
                        var return_v = this_param.Kind();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10759, 652, 663);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxToken
                    f_10759_772_813(Microsoft.CodeAnalysis.CSharp.Syntax.IfDirectiveTriviaSyntax
                    this_param)
                    {
                        var return_v = this_param.IfKeyword;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10759, 772, 813);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxToken
                    f_10759_905_950(Microsoft.CodeAnalysis.CSharp.Syntax.ElifDirectiveTriviaSyntax
                    this_param)
                    {
                        var return_v = this_param.ElifKeyword;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10759, 905, 950);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxToken
                    f_10759_1042_1087(Microsoft.CodeAnalysis.CSharp.Syntax.ElseDirectiveTriviaSyntax
                    this_param)
                    {
                        var return_v = this_param.ElseKeyword;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10759, 1042, 1087);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxToken
                    f_10759_1180_1227(Microsoft.CodeAnalysis.CSharp.Syntax.EndIfDirectiveTriviaSyntax
                    this_param)
                    {
                        var return_v = this_param.EndIfKeyword;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10759, 1180, 1227);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxToken
                    f_10759_1321_1370(Microsoft.CodeAnalysis.CSharp.Syntax.RegionDirectiveTriviaSyntax
                    this_param)
                    {
                        var return_v = this_param.RegionKeyword;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10759, 1321, 1370);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxToken
                    f_10759_1467_1522(Microsoft.CodeAnalysis.CSharp.Syntax.EndRegionDirectiveTriviaSyntax
                    this_param)
                    {
                        var return_v = this_param.EndRegionKeyword;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10759, 1467, 1522);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxToken
                    f_10759_1615_1662(Microsoft.CodeAnalysis.CSharp.Syntax.ErrorDirectiveTriviaSyntax
                    this_param)
                    {
                        var return_v = this_param.ErrorKeyword;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10759, 1615, 1662);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxToken
                    f_10759_1757_1808(Microsoft.CodeAnalysis.CSharp.Syntax.WarningDirectiveTriviaSyntax
                    this_param)
                    {
                        var return_v = this_param.WarningKeyword;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10759, 1757, 1808);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxToken
                    f_10759_1899_1942(Microsoft.CodeAnalysis.CSharp.Syntax.BadDirectiveTriviaSyntax
                    this_param)
                    {
                        var return_v = this_param.Identifier;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10759, 1899, 1942);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxToken
                    f_10759_2036_2085(Microsoft.CodeAnalysis.CSharp.Syntax.DefineDirectiveTriviaSyntax
                    this_param)
                    {
                        var return_v = this_param.DefineKeyword;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10759, 2036, 2085);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxToken
                    f_10759_2178_2225(Microsoft.CodeAnalysis.CSharp.Syntax.UndefDirectiveTriviaSyntax
                    this_param)
                    {
                        var return_v = this_param.UndefKeyword;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10759, 2178, 2225);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxToken
                    f_10759_2317_2362(Microsoft.CodeAnalysis.CSharp.Syntax.LineDirectiveTriviaSyntax
                    this_param)
                    {
                        var return_v = this_param.LineKeyword;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10759, 2317, 2362);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxToken
                    f_10759_2463_2519(Microsoft.CodeAnalysis.CSharp.Syntax.PragmaWarningDirectiveTriviaSyntax
                    this_param)
                    {
                        var return_v = this_param.PragmaKeyword;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10759, 2463, 2519);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxToken
                    f_10759_2621_2678(Microsoft.CodeAnalysis.CSharp.Syntax.PragmaChecksumDirectiveTriviaSyntax
                    this_param)
                    {
                        var return_v = this_param.PragmaKeyword;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10759, 2621, 2678);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxToken
                    f_10759_2775_2830(Microsoft.CodeAnalysis.CSharp.Syntax.ReferenceDirectiveTriviaSyntax
                    this_param)
                    {
                        var return_v = this_param.ReferenceKeyword;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10759, 2775, 2830);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxToken
                    f_10759_2922_2967(Microsoft.CodeAnalysis.CSharp.Syntax.LoadDirectiveTriviaSyntax
                    this_param)
                    {
                        var return_v = this_param.LoadKeyword;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10759, 2922, 2967);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxToken
                    f_10759_3062_3115(Microsoft.CodeAnalysis.CSharp.Syntax.ShebangDirectiveTriviaSyntax
                    this_param)
                    {
                        var return_v = this_param.ExclamationToken;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10759, 3062, 3115);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxToken
                    f_10759_3211_3264(Microsoft.CodeAnalysis.CSharp.Syntax.NullableDirectiveTriviaSyntax
                    this_param)
                    {
                        var return_v = this_param.NullableKeyword;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10759, 3211, 3264);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    f_10759_3362_3373(Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
                    this_param)
                    {
                        var return_v = this_param.Kind();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10759, 3362, 3373);
                        return return_v;
                    }


                    System.Exception
                    f_10759_3327_3374(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    o)
                    {
                        var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10759, 3327, 3374);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10759, 546, 3420);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10759, 546, 3420);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public DirectiveTriviaSyntax? GetNextDirective(Func<DirectiveTriviaSyntax, bool>? predicate = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10759, 3432, 4502);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 3556, 3605);

                var
                token = (SyntaxToken)this.ParentTrivia.Token
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 3619, 3637);

                bool
                next = false
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 3651, 4463) || true) && (token.Kind() != SyntaxKind.None)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10759, 3651, 4463);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 3723, 4376);
                            foreach (var tr in f_10759_3742_3761_I(token.LeadingTrivia))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10759, 3723, 4376);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 3803, 4357) || true) && (next)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10759, 3803, 4357);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 3861, 4187) || true) && (tr.IsDirective)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10759, 3861, 4187);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 3937, 3987);

                                        var
                                        d = (DirectiveTriviaSyntax)tr.GetStructure()!
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 4017, 4160) || true) && (predicate == null || (DynAbs.Tracing.TraceSender.Expression_False(10759, 4021, 4054) || f_10759_4042_4054(predicate, d)))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10759, 4017, 4160);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 4120, 4129);

                                            return d;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10759, 4017, 4160);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10759, 3861, 4187);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10759, 3803, 4357);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10759, 3803, 4357);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 4237, 4357) || true) && (tr.UnderlyingNode == f_10759_4262_4272(this))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10759, 4237, 4357);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 4322, 4334);

                                        next = true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10759, 4237, 4357);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10759, 3803, 4357);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10759, 3723, 4376);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10759, 1, 654);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10759, 1, 654);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 4396, 4448);

                        token = token.GetNextToken(s_hasDirectivesFunction);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10759, 3651, 4463);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10759, 3651, 4463);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10759, 3651, 4463);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 4479, 4491);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10759, 3432, 4502);

                bool
                f_10759_4042_4054(System.Func<Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax, bool>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10759, 4042, 4054);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_10759_4262_4272(Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
                this_param)
                {
                    var return_v = this_param.Green;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10759, 4262, 4272);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTriviaList
                f_10759_3742_3761_I(Microsoft.CodeAnalysis.SyntaxTriviaList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10759, 3742, 3761);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10759, 3432, 4502);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10759, 3432, 4502);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public DirectiveTriviaSyntax? GetPreviousDirective(Func<DirectiveTriviaSyntax, bool>? predicate = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10759, 4514, 5602);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 4642, 4691);

                var
                token = (SyntaxToken)this.ParentTrivia.Token
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 4705, 4723);

                bool
                next = false
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 4737, 5563) || true) && (token.Kind() != SyntaxKind.None)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10759, 4737, 5563);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 4809, 5472);
                            foreach (var tr in f_10759_4828_4857_I(token.LeadingTrivia.Reverse()))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10759, 4809, 5472);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 4899, 5453) || true) && (next)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10759, 4899, 5453);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 4957, 5283) || true) && (tr.IsDirective)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10759, 4957, 5283);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 5033, 5083);

                                        var
                                        d = (DirectiveTriviaSyntax)tr.GetStructure()!
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 5113, 5256) || true) && (predicate == null || (DynAbs.Tracing.TraceSender.Expression_False(10759, 5117, 5150) || f_10759_5138_5150(predicate, d)))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10759, 5113, 5256);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 5216, 5225);

                                            return d;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10759, 5113, 5256);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10759, 4957, 5283);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10759, 4899, 5453);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10759, 4899, 5453);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 5333, 5453) || true) && (tr.UnderlyingNode == f_10759_5358_5368(this))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10759, 5333, 5453);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 5418, 5430);

                                        next = true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10759, 5333, 5453);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10759, 4899, 5453);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10759, 4809, 5472);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10759, 1, 664);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10759, 1, 664);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 5492, 5548);

                        token = token.GetPreviousToken(s_hasDirectivesFunction);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10759, 4737, 5563);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10759, 4737, 5563);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10759, 4737, 5563);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 5579, 5591);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10759, 4514, 5602);

                bool
                f_10759_5138_5150(System.Func<Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax, bool>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10759, 5138, 5150);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_10759_5358_5368(Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
                this_param)
                {
                    var return_v = this_param.Green;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10759, 5358, 5368);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTriviaList.Reversed
                f_10759_4828_4857_I(Microsoft.CodeAnalysis.SyntaxTriviaList.Reversed
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10759, 4828, 4857);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10759, 4514, 5602);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10759, 4514, 5602);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public List<DirectiveTriviaSyntax> GetRelatedDirectives()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10759, 5614, 5824);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 5696, 5741);

                var
                list = f_10759_5707_5740()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 5755, 5787);

                f_10759_5755_5786(this, list);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 5801, 5813);

                return list;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10759, 5614, 5824);

                System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax>
                f_10759_5707_5740()
                {
                    var return_v = new System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10759, 5707, 5740);
                    return return_v;
                }


                int
                f_10759_5755_5786(Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
                this_param, System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax>
                list)
                {
                    this_param.GetRelatedDirectives(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10759, 5755, 5786);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10759, 5614, 5824);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10759, 5614, 5824);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void GetRelatedDirectives(List<DirectiveTriviaSyntax> list)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10759, 5836, 6408);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 5928, 5941);

                f_10759_5928_5940(list);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 5955, 5998);

                var
                p = f_10759_5963_5997(this)
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 6012, 6143) || true) && (p != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10759, 6012, 6143);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 6062, 6074);

                        f_10759_6062_6073(list, p);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 6092, 6128);

                        p = f_10759_6096_6127(p);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10759, 6012, 6143);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10759, 6012, 6143);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10759, 6012, 6143);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 6159, 6174);

                f_10759_6159_6173(
                            list);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 6188, 6203);

                f_10759_6188_6202(list, this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 6217, 6256);

                var
                n = f_10759_6225_6255(this)
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 6270, 6397) || true) && (n != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10759, 6270, 6397);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 6320, 6332);

                        f_10759_6320_6331(list, n);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 6350, 6382);

                        n = f_10759_6354_6381(n);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10759, 6270, 6397);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10759, 6270, 6397);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10759, 6270, 6397);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10759, 5836, 6408);

                int
                f_10759_5928_5940(System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10759, 5928, 5940);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax?
                f_10759_5963_5997(Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
                this_param)
                {
                    var return_v = this_param.GetPreviousRelatedDirective();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10759, 5963, 5997);
                    return return_v;
                }


                int
                f_10759_6062_6073(System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10759, 6062, 6073);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax?
                f_10759_6096_6127(Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
                this_param)
                {
                    var return_v = this_param.GetPreviousRelatedDirective();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10759, 6096, 6127);
                    return return_v;
                }


                int
                f_10759_6159_6173(System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax>
                this_param)
                {
                    this_param.Reverse();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10759, 6159, 6173);
                    return 0;
                }


                int
                f_10759_6188_6202(System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10759, 6188, 6202);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax?
                f_10759_6225_6255(Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
                this_param)
                {
                    var return_v = this_param.GetNextRelatedDirective();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10759, 6225, 6255);
                    return return_v;
                }


                int
                f_10759_6320_6331(System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10759, 6320, 6331);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax?
                f_10759_6354_6381(Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
                this_param)
                {
                    var return_v = this_param.GetNextRelatedDirective();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10759, 6354, 6381);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10759, 5836, 6408);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10759, 5836, 6408);
            }
        }

        private DirectiveTriviaSyntax? GetNextRelatedDirective()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10759, 6420, 8661);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 6501, 6533);

                DirectiveTriviaSyntax?
                d = this
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 6547, 8622);

                switch (f_10759_6555_6563(d))
                {

                    case SyntaxKind.IfDirectiveTrivia:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10759, 6547, 8622);
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 6653, 7123) || true) && (d != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10759, 6653, 7123);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 6719, 7032);

                                switch (f_10759_6727_6735(d))
                                {

                                    case SyntaxKind.ElifDirectiveTrivia:
                                    case SyntaxKind.ElseDirectiveTrivia:
                                    case SyntaxKind.EndIfDirectiveTrivia:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10759, 6719, 7032);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 6996, 7005);

                                        return d;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10759, 6719, 7032);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 7060, 7100);

                                d = f_10759_7064_7099(d);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10759, 6653, 7123);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10759, 6653, 7123);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10759, 6653, 7123);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10759, 7147, 7153);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10759, 6547, 8622);

                    case SyntaxKind.ElifDirectiveTrivia:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10759, 6547, 8622);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 7229, 7269);

                        d = f_10759_7233_7268(d);
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 7293, 7763) || true) && (d != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10759, 7293, 7763);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 7359, 7672);

                                switch (f_10759_7367_7375(d))
                                {

                                    case SyntaxKind.ElifDirectiveTrivia:
                                    case SyntaxKind.ElseDirectiveTrivia:
                                    case SyntaxKind.EndIfDirectiveTrivia:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10759, 7359, 7672);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 7636, 7645);

                                        return d;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10759, 7359, 7672);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 7700, 7740);

                                d = f_10759_7704_7739(d);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10759, 7293, 7763);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10759, 7293, 7763);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10759, 7293, 7763);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10759, 7787, 7793);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10759, 6547, 8622);

                    case SyntaxKind.ElseDirectiveTrivia:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10759, 6547, 8622);
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 7869, 8167) || true) && (d != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10759, 7869, 8167);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 7935, 8076) || true) && (f_10759_7939_7947(d) == SyntaxKind.EndIfDirectiveTrivia)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10759, 7935, 8076);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 8040, 8049);

                                    return d;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10759, 7935, 8076);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 8104, 8144);

                                d = f_10759_8108_8143(d);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10759, 7869, 8167);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10759, 7869, 8167);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10759, 7869, 8167);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10759, 8191, 8197);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10759, 6547, 8622);

                    case SyntaxKind.RegionDirectiveTrivia:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10759, 6547, 8622);
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 8275, 8577) || true) && (d != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10759, 8275, 8577);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 8341, 8486) || true) && (f_10759_8345_8353(d) == SyntaxKind.EndRegionDirectiveTrivia)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10759, 8341, 8486);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 8450, 8459);

                                    return d;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10759, 8341, 8486);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 8514, 8554);

                                d = f_10759_8518_8553(d);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10759, 8275, 8577);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10759, 8275, 8577);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10759, 8275, 8577);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10759, 8601, 8607);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10759, 6547, 8622);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 8638, 8650);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10759, 6420, 8661);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10759_6555_6563(Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10759, 6555, 6563);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10759_6727_6735(Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10759, 6727, 6735);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax?
                f_10759_7064_7099(Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
                this_param)
                {
                    var return_v = this_param.GetNextPossiblyRelatedDirective();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10759, 7064, 7099);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax?
                f_10759_7233_7268(Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
                this_param)
                {
                    var return_v = this_param.GetNextPossiblyRelatedDirective();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10759, 7233, 7268);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10759_7367_7375(Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10759, 7367, 7375);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax?
                f_10759_7704_7739(Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
                this_param)
                {
                    var return_v = this_param.GetNextPossiblyRelatedDirective();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10759, 7704, 7739);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10759_7939_7947(Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10759, 7939, 7947);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax?
                f_10759_8108_8143(Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
                this_param)
                {
                    var return_v = this_param.GetNextPossiblyRelatedDirective();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10759, 8108, 8143);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10759_8345_8353(Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10759, 8345, 8353);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax?
                f_10759_8518_8553(Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
                this_param)
                {
                    var return_v = this_param.GetNextPossiblyRelatedDirective();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10759, 8518, 8553);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10759, 6420, 8661);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10759, 6420, 8661);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private DirectiveTriviaSyntax? GetNextPossiblyRelatedDirective()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10759, 8673, 9817);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 8762, 8794);

                DirectiveTriviaSyntax?
                d = this
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 8808, 9778) || true) && (d != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10759, 8808, 9778);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 8858, 8883);

                        d = f_10759_8862_8882(d);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 8901, 9734) || true) && (d != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10759, 8901, 9734);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 8998, 9715);

                            switch (f_10759_9006_9014(d))
                            {

                                case SyntaxKind.IfDirectiveTrivia:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10759, 8998, 9715);
                                    try
                                    {
                                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 9128, 9320) || true) && (d != null && (DynAbs.Tracing.TraceSender.Expression_True(10759, 9135, 9191) && f_10759_9148_9156(d) != SyntaxKind.EndIfDirectiveTrivia))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10759, 9128, 9320);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 9257, 9289);

                                            d = f_10759_9261_9288(d);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10759, 9128, 9320);
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10759, 9128, 9320);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(10759, 9128, 9320);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 9352, 9361);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10759, 8998, 9715);

                                case SyntaxKind.RegionDirectiveTrivia:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10759, 8998, 9715);
                                    try
                                    {
                                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 9455, 9651) || true) && (d != null && (DynAbs.Tracing.TraceSender.Expression_True(10759, 9462, 9522) && f_10759_9475_9483(d) != SyntaxKind.EndRegionDirectiveTrivia))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10759, 9455, 9651);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 9588, 9620);

                                            d = f_10759_9592_9619(d);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10759, 9455, 9651);
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10759, 9455, 9651);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(10759, 9455, 9651);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 9683, 9692);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10759, 8998, 9715);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10759, 8901, 9734);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 9754, 9763);

                        return d;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10759, 8808, 9778);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10759, 8808, 9778);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10759, 8808, 9778);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 9794, 9806);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10759, 8673, 9817);

                Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax?
                f_10759_8862_8882(Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
                this_param)
                {
                    var return_v = this_param.GetNextDirective();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10759, 8862, 8882);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10759_9006_9014(Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10759, 9006, 9014);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10759_9148_9156(Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10759, 9148, 9156);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax?
                f_10759_9261_9288(Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
                this_param)
                {
                    var return_v = this_param.GetNextRelatedDirective();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10759, 9261, 9288);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10759_9475_9483(Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10759, 9475, 9483);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax?
                f_10759_9592_9619(Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
                this_param)
                {
                    var return_v = this_param.GetNextRelatedDirective();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10759, 9592, 9619);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10759, 8673, 9817);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10759, 8673, 9817);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private DirectiveTriviaSyntax? GetPreviousRelatedDirective()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10759, 9829, 12128);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 9914, 9946);

                DirectiveTriviaSyntax?
                d = this
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 9960, 12089);

                switch (f_10759_9968_9976(d))
                {

                    case SyntaxKind.EndIfDirectiveTrivia:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10759, 9960, 12089);
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 10069, 10540) || true) && (d != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10759, 10069, 10540);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 10135, 10445);

                                switch (f_10759_10143_10151(d))
                                {

                                    case SyntaxKind.IfDirectiveTrivia:
                                    case SyntaxKind.ElifDirectiveTrivia:
                                    case SyntaxKind.ElseDirectiveTrivia:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10759, 10135, 10445);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 10409, 10418);

                                        return d;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10759, 10135, 10445);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 10473, 10517);

                                d = f_10759_10477_10516(d);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10759, 10069, 10540);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10759, 10069, 10540);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10759, 10069, 10540);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10759, 10564, 10570);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10759, 9960, 12089);

                    case SyntaxKind.ElifDirectiveTrivia:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10759, 9960, 12089);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 10646, 10690);

                        d = f_10759_10650_10689(d);
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 10714, 11119) || true) && (d != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10759, 10714, 11119);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 10780, 11024);

                                switch (f_10759_10788_10796(d))
                                {

                                    case SyntaxKind.IfDirectiveTrivia:
                                    case SyntaxKind.ElifDirectiveTrivia:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10759, 10780, 11024);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 10988, 10997);

                                        return d;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10759, 10780, 11024);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 11052, 11096);

                                d = f_10759_11056_11095(d);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10759, 10714, 11119);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10759, 10714, 11119);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10759, 10714, 11119);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10759, 11143, 11149);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10759, 9960, 12089);

                    case SyntaxKind.ElseDirectiveTrivia:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10759, 9960, 12089);
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 11225, 11630) || true) && (d != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10759, 11225, 11630);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 11291, 11535);

                                switch (f_10759_11299_11307(d))
                                {

                                    case SyntaxKind.IfDirectiveTrivia:
                                    case SyntaxKind.ElifDirectiveTrivia:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10759, 11291, 11535);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 11499, 11508);

                                        return d;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10759, 11291, 11535);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 11563, 11607);

                                d = f_10759_11567_11606(d);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10759, 11225, 11630);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10759, 11225, 11630);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10759, 11225, 11630);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10759, 11654, 11660);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10759, 9960, 12089);

                    case SyntaxKind.EndRegionDirectiveTrivia:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10759, 9960, 12089);
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 11741, 12044) || true) && (d != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10759, 11741, 12044);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 11807, 11949) || true) && (f_10759_11811_11819(d) == SyntaxKind.RegionDirectiveTrivia)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10759, 11807, 11949);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 11913, 11922);

                                    return d;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10759, 11807, 11949);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 11977, 12021);

                                d = f_10759_11981_12020(d);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10759, 11741, 12044);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10759, 11741, 12044);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10759, 11741, 12044);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10759, 12068, 12074);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10759, 9960, 12089);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 12105, 12117);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10759, 9829, 12128);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10759_9968_9976(Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10759, 9968, 9976);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10759_10143_10151(Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10759, 10143, 10151);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax?
                f_10759_10477_10516(Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
                this_param)
                {
                    var return_v = this_param.GetPreviousPossiblyRelatedDirective();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10759, 10477, 10516);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax?
                f_10759_10650_10689(Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
                this_param)
                {
                    var return_v = this_param.GetPreviousPossiblyRelatedDirective();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10759, 10650, 10689);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10759_10788_10796(Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10759, 10788, 10796);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax?
                f_10759_11056_11095(Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
                this_param)
                {
                    var return_v = this_param.GetPreviousPossiblyRelatedDirective();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10759, 11056, 11095);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10759_11299_11307(Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10759, 11299, 11307);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax?
                f_10759_11567_11606(Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
                this_param)
                {
                    var return_v = this_param.GetPreviousPossiblyRelatedDirective();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10759, 11567, 11606);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10759_11811_11819(Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10759, 11811, 11819);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax?
                f_10759_11981_12020(Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
                this_param)
                {
                    var return_v = this_param.GetPreviousPossiblyRelatedDirective();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10759, 11981, 12020);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10759, 9829, 12128);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10759, 9829, 12128);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private DirectiveTriviaSyntax? GetPreviousPossiblyRelatedDirective()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10759, 12140, 13300);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 12233, 12265);

                DirectiveTriviaSyntax?
                d = this
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 12279, 13261) || true) && (d != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10759, 12279, 13261);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 12329, 12358);

                        d = f_10759_12333_12357(d);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 12376, 13217) || true) && (d != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10759, 12376, 13217);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 12473, 13198);

                            switch (f_10759_12481_12489(d))
                            {

                                case SyntaxKind.EndIfDirectiveTrivia:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10759, 12473, 13198);
                                    try
                                    {
                                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 12606, 12799) || true) && (d != null && (DynAbs.Tracing.TraceSender.Expression_True(10759, 12613, 12666) && f_10759_12626_12634(d) != SyntaxKind.IfDirectiveTrivia))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10759, 12606, 12799);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 12732, 12768);

                                            d = f_10759_12736_12767(d);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10759, 12606, 12799);
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10759, 12606, 12799);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(10759, 12606, 12799);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 12831, 12840);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10759, 12473, 13198);

                                case SyntaxKind.EndRegionDirectiveTrivia:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10759, 12473, 13198);
                                    try
                                    {
                                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 12937, 13134) || true) && (d != null && (DynAbs.Tracing.TraceSender.Expression_True(10759, 12944, 13001) && f_10759_12957_12965(d) != SyntaxKind.RegionDirectiveTrivia))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10759, 12937, 13134);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 13067, 13103);

                                            d = f_10759_13071_13102(d);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10759, 12937, 13134);
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10759, 12937, 13134);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(10759, 12937, 13134);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 13166, 13175);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10759, 12473, 13198);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10759, 12376, 13217);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 13237, 13246);

                        return d;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10759, 12279, 13261);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10759, 12279, 13261);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10759, 12279, 13261);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 13277, 13289);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10759, 12140, 13300);

                Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax?
                f_10759_12333_12357(Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
                this_param)
                {
                    var return_v = this_param.GetPreviousDirective();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10759, 12333, 12357);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10759_12481_12489(Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10759, 12481, 12489);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10759_12626_12634(Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10759, 12626, 12634);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax?
                f_10759_12736_12767(Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
                this_param)
                {
                    var return_v = this_param.GetPreviousRelatedDirective();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10759, 12736, 12767);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10759_12957_12965(Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10759, 12957, 12965);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax?
                f_10759_13071_13102(Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
                this_param)
                {
                    var return_v = this_param.GetPreviousRelatedDirective();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10759, 13071, 13102);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10759, 12140, 13300);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10759, 12140, 13300);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static readonly Func<SyntaxToken, bool> s_hasDirectivesFunction;

        static DirectiveTriviaSyntax()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10759, 487, 13419);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10759, 13360, 13411);
            s_hasDirectivesFunction = t => t.ContainsDirectives; DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10759, 487, 13419);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10759, 487, 13419);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10759, 487, 13419);
    }
}
