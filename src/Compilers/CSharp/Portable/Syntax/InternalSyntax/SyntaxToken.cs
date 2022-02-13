// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax
{
    using Microsoft.CodeAnalysis.Syntax.InternalSyntax;
    internal partial class SyntaxToken : CSharpSyntaxNode
    {
        internal SyntaxToken(SyntaxKind kind)
        : base(f_10005_854_858_C(kind))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10005, 796, 1033);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 884, 913);

                FullWidth = f_10005_896_912(f_10005_896_905(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 927, 964);

                this.flags |= NodeFlags.IsNotMissing;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10005, 796, 1033);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10005, 796, 1033);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10005, 796, 1033);
            }
        }

        internal SyntaxToken(SyntaxKind kind, DiagnosticInfo[] diagnostics)
        : base(f_10005_1133_1137_C(kind), diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10005, 1045, 1325);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 1176, 1205);

                FullWidth = f_10005_1188_1204(f_10005_1188_1197(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 1219, 1256);

                this.flags |= NodeFlags.IsNotMissing;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10005, 1045, 1325);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10005, 1045, 1325);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10005, 1045, 1325);
            }
        }

        internal SyntaxToken(SyntaxKind kind, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
        : base(f_10005_1457_1461_C(kind), diagnostics, annotations)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10005, 1337, 1662);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 1513, 1542);

                FullWidth = f_10005_1525_1541(f_10005_1525_1534(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 1556, 1593);

                this.flags |= NodeFlags.IsNotMissing;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10005, 1337, 1662);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10005, 1337, 1662);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10005, 1337, 1662);
            }
        }

        internal SyntaxToken(SyntaxKind kind, int fullWidth)
        : base(f_10005_1747_1751_C(kind), fullWidth)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10005, 1674, 1894);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 1788, 1825);

                this.flags |= NodeFlags.IsNotMissing;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10005, 1674, 1894);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10005, 1674, 1894);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10005, 1674, 1894);
            }
        }

        internal SyntaxToken(SyntaxKind kind, int fullWidth, DiagnosticInfo[] diagnostics)
        : base(f_10005_2009_2013_C(kind), diagnostics, fullWidth)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10005, 1906, 2169);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 2063, 2100);

                this.flags |= NodeFlags.IsNotMissing;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10005, 1906, 2169);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10005, 1906, 2169);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10005, 1906, 2169);
            }
        }

        internal SyntaxToken(SyntaxKind kind, int fullWidth, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
        : base(f_10005_2316_2320_C(kind), diagnostics, annotations, fullWidth)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10005, 2181, 2489);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 2383, 2420);

                this.flags |= NodeFlags.IsNotMissing;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10005, 2181, 2489);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10005, 2181, 2489);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10005, 2181, 2489);
            }
        }

        internal SyntaxToken(ObjectReader reader)
        : base(f_10005_2563_2569_C(reader))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10005, 2501, 2842);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 2595, 2616);

                var
                text = f_10005_2606_2615(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 2630, 2719) || true) && (text != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10005, 2630, 2719);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 2680, 2704);

                    FullWidth = f_10005_2692_2703(text);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10005, 2630, 2719);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 2735, 2772);

                this.flags |= NodeFlags.IsNotMissing;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10005, 2501, 2842);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10005, 2501, 2842);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10005, 2501, 2842);
            }
        }

        internal override bool ShouldReuseInSerialization
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10005, 2904, 3040);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 2907, 3040);
                    return DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.ShouldReuseInSerialization, 10005, 2907, 2938) && (DynAbs.Tracing.TraceSender.Expression_True(10005, 2907, 3040) && f_10005_3004_3013() < Lexer.MaxCachedTokenSize); DynAbs.Tracing.TraceSender.TraceExitMethod(10005, 2904, 3040);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10005, 2904, 3040);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10005, 2904, 3040);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsToken
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10005, 3116, 3123);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 3119, 3123);
                    return true; DynAbs.Tracing.TraceSender.TraceExitMethod(10005, 3116, 3123);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10005, 3116, 3123);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10005, 3116, 3123);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override GreenNode GetSlot(int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10005, 3136, 3255);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 3207, 3244);

                throw f_10005_3213_3243();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10005, 3136, 3255);

                System.Exception
                f_10005_3213_3243()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10005, 3213, 3243);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10005, 3136, 3255);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10005, 3136, 3255);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SyntaxToken Create(SyntaxKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10005, 3267, 3772);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 3343, 3700) || true) && (kind > LastTokenWithWellKnownText)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10005, 3343, 3700);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 3414, 3626) || true) && (!f_10005_3419_3447(kind))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10005, 3414, 3626);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 3489, 3607);

                        throw f_10005_3495_3606(f_10005_3517_3591(f_10005_3531_3584(), kind), nameof(kind));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10005, 3414, 3626);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 3646, 3685);

                    return f_10005_3653_3684(kind, null, null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10005, 3343, 3700);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 3716, 3761);

                return s_tokensWithNoTrivia[(int)kind].Value;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10005, 3267, 3772);

                bool
                f_10005_3419_3447(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.IsAnyToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10005, 3419, 3447);
                    return return_v;
                }


                string
                f_10005_3531_3584()
                {
                    var return_v = CSharpResources.ThisMethodCanOnlyBeUsedToCreateTokens;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10005, 3531, 3584);
                    return return_v;
                }


                string
                f_10005_3517_3591(string
                format, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                arg0)
                {
                    var return_v = string.Format(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10005, 3517, 3591);
                    return return_v;
                }


                System.ArgumentException
                f_10005_3495_3606(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10005, 3495, 3606);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10005_3653_3684(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, Microsoft.CodeAnalysis.GreenNode
                leading, Microsoft.CodeAnalysis.GreenNode
                trailing)
                {
                    var return_v = CreateMissing(kind, leading, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10005, 3653, 3684);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10005, 3267, 3772);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10005, 3267, 3772);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SyntaxToken Create(SyntaxKind kind, GreenNode leading, GreenNode trailing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10005, 3784, 5130);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 3899, 4263) || true) && (kind > LastTokenWithWellKnownText)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10005, 3899, 4263);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 3970, 4182) || true) && (!f_10005_3975_4003(kind))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10005, 3970, 4182);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 4045, 4163);

                        throw f_10005_4051_4162(f_10005_4073_4147(f_10005_4087_4140(), kind), nameof(kind));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10005, 3970, 4182);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 4202, 4248);

                    return f_10005_4209_4247(kind, leading, trailing);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10005, 3899, 4263);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 4279, 4839) || true) && (leading == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10005, 4279, 4839);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 4332, 4824) || true) && (trailing == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10005, 4332, 4824);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 4394, 4439);

                        return s_tokensWithNoTrivia[(int)kind].Value;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10005, 4332, 4824);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10005, 4332, 4824);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 4481, 4824) || true) && (trailing == SyntaxFactory.Space)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10005, 4481, 4824);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 4558, 4614);

                            return s_tokensWithSingleTrailingSpace[(int)kind].Value;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10005, 4481, 4824);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10005, 4481, 4824);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 4656, 4824) || true) && (trailing == SyntaxFactory.CarriageReturnLineFeed)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10005, 4656, 4824);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 4750, 4805);

                                return s_tokensWithSingleTrailingCRLF[(int)kind].Value;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10005, 4656, 4824);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10005, 4481, 4824);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10005, 4332, 4824);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10005, 4279, 4839);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 4855, 5045) || true) && (leading == SyntaxFactory.ElasticZeroSpace && (DynAbs.Tracing.TraceSender.Expression_True(10005, 4859, 4946) && trailing == SyntaxFactory.ElasticZeroSpace))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10005, 4855, 5045);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 4980, 5030);

                    return s_tokensWithElasticTrivia[(int)kind].Value;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10005, 4855, 5045);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 5061, 5119);

                return f_10005_5068_5118(kind, leading, trailing);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10005, 3784, 5130);

                bool
                f_10005_3975_4003(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.IsAnyToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10005, 3975, 4003);
                    return return_v;
                }


                string
                f_10005_4087_4140()
                {
                    var return_v = CSharpResources.ThisMethodCanOnlyBeUsedToCreateTokens;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10005, 4087, 4140);
                    return return_v;
                }


                string
                f_10005_4073_4147(string
                format, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                arg0)
                {
                    var return_v = string.Format(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10005, 4073, 4147);
                    return return_v;
                }


                System.ArgumentException
                f_10005_4051_4162(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10005, 4051, 4162);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10005_4209_4247(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, Microsoft.CodeAnalysis.GreenNode
                leading, Microsoft.CodeAnalysis.GreenNode
                trailing)
                {
                    var return_v = CreateMissing(kind, leading, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10005, 4209, 4247);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithTrivia
                f_10005_5068_5118(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, Microsoft.CodeAnalysis.GreenNode?
                leading, Microsoft.CodeAnalysis.GreenNode
                trailing)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithTrivia(kind, leading, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10005, 5068, 5118);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10005, 3784, 5130);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10005, 3784, 5130);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SyntaxToken CreateMissing(SyntaxKind kind, GreenNode leading, GreenNode trailing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10005, 5142, 5334);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 5264, 5323);

                return f_10005_5271_5322(kind, leading, trailing);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10005, 5142, 5334);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.MissingTokenWithTrivia
                f_10005_5271_5322(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, Microsoft.CodeAnalysis.GreenNode
                leading, Microsoft.CodeAnalysis.GreenNode
                trailing)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.MissingTokenWithTrivia(kind, leading, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10005, 5271, 5322);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10005, 5142, 5334);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10005, 5142, 5334);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal const SyntaxKind
        FirstTokenWithWellKnownText = SyntaxKind.TildeToken
        ;

        internal const SyntaxKind
        LastTokenWithWellKnownText = SyntaxKind.EndOfFileToken
        ;

        private static readonly ArrayElement<SyntaxToken>[] s_tokensWithNoTrivia;

        private static readonly ArrayElement<SyntaxToken>[] s_tokensWithElasticTrivia;

        private static readonly ArrayElement<SyntaxToken>[] s_tokensWithSingleTrailingSpace;

        private static readonly ArrayElement<SyntaxToken>[] s_tokensWithSingleTrailingCRLF;

        static SyntaxToken()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10005, 6245, 7024);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 5372, 5423);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 5460, 5514);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 5661, 5750);
                s_tokensWithNoTrivia = new ArrayElement<SyntaxToken>[(int)LastTokenWithWellKnownText + 1]; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 5813, 5907);
                s_tokensWithElasticTrivia = new ArrayElement<SyntaxToken>[(int)LastTokenWithWellKnownText + 1]; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 5970, 6070);
                s_tokensWithSingleTrailingSpace = new ArrayElement<SyntaxToken>[(int)LastTokenWithWellKnownText + 1]; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 6133, 6232);
                s_tokensWithSingleTrailingCRLF = new ArrayElement<SyntaxToken>[(int)LastTokenWithWellKnownText + 1]; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 6290, 6368);

                f_10005_6290_6367(typeof(SyntaxToken), r => new SyntaxToken(r));
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 6393, 6427);

                    for (var
        kind = FirstTokenWithWellKnownText
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 6384, 7013) || true) && (kind <= LastTokenWithWellKnownText)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 6465, 6471)
        , kind++, DynAbs.Tracing.TraceSender.TraceExitCondition(10005, 6384, 7013))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10005, 6384, 7013);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 6505, 6567);

                        s_tokensWithNoTrivia[(int)kind].Value = f_10005_6545_6566(kind);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 6585, 6726);

                        s_tokensWithElasticTrivia[(int)kind].Value = f_10005_6630_6725(kind, SyntaxFactory.ElasticZeroSpace, SyntaxFactory.ElasticZeroSpace);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 6744, 6854);

                        s_tokensWithSingleTrailingSpace[(int)kind].Value = f_10005_6795_6853(kind, null, SyntaxFactory.Space);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 6872, 6998);

                        s_tokensWithSingleTrailingCRLF[(int)kind].Value = f_10005_6922_6997(kind, null, SyntaxFactory.CarriageReturnLineFeed);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10005, 1, 630);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10005, 1, 630);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10005, 6245, 7024);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10005, 6245, 7024);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10005, 6245, 7024);
            }
        }

        internal static IEnumerable<SyntaxToken> GetWellKnownTokens()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10005, 7036, 8031);

                var listYield = new List<SyntaxToken>();
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 7122, 7328);
                    foreach (var element in f_10005_7146_7166_I(s_tokensWithNoTrivia))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10005, 7122, 7328);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 7200, 7313) || true) && (element.Value != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10005, 7200, 7313);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 7267, 7294);

                            listYield.Add(element.Value);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10005, 7200, 7313);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10005, 7122, 7328);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10005, 1, 207);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10005, 1, 207);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 7344, 7555);
                    foreach (var element in f_10005_7368_7393_I(s_tokensWithElasticTrivia))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10005, 7344, 7555);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 7427, 7540) || true) && (element.Value != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10005, 7427, 7540);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 7494, 7521);

                            listYield.Add(element.Value);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10005, 7427, 7540);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10005, 7344, 7555);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10005, 1, 212);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10005, 1, 212);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 7571, 7788);
                    foreach (var element in f_10005_7595_7626_I(s_tokensWithSingleTrailingSpace))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10005, 7571, 7788);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 7660, 7773) || true) && (element.Value != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10005, 7660, 7773);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 7727, 7754);

                            listYield.Add(element.Value);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10005, 7660, 7773);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10005, 7571, 7788);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10005, 1, 218);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10005, 1, 218);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 7804, 8020);
                    foreach (var element in f_10005_7828_7858_I(s_tokensWithSingleTrailingCRLF))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10005, 7804, 8020);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 7892, 8005) || true) && (element.Value != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10005, 7892, 8005);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 7959, 7986);

                            listYield.Add(element.Value);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10005, 7892, 8005);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10005, 7804, 8020);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10005, 1, 217);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10005, 1, 217);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10005, 7036, 8031);

                return listYield;

                Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>[]
                f_10005_7146_7166_I(Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10005, 7146, 7166);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>[]
                f_10005_7368_7393_I(Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10005, 7368, 7393);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>[]
                f_10005_7595_7626_I(Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10005, 7595, 7626);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>[]
                f_10005_7828_7858_I(Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10005, 7828, 7858);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10005, 7036, 8031);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10005, 7036, 8031);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SyntaxToken Identifier(string text)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10005, 8043, 8164);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 8119, 8153);

                return f_10005_8126_8152(text);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10005, 8043, 8164);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifier
                f_10005_8126_8152(string
                text)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifier(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10005, 8126, 8152);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10005, 8043, 8164);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10005, 8043, 8164);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SyntaxToken Identifier(GreenNode leading, string text, GreenNode trailing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10005, 8176, 8732);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 8291, 8608) || true) && (leading == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10005, 8291, 8608);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 8344, 8593) || true) && (trailing == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10005, 8344, 8593);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 8406, 8430);

                        return f_10005_8413_8429(text);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10005, 8344, 8593);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10005, 8344, 8593);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 8512, 8574);

                        return f_10005_8519_8573(text, trailing);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10005, 8344, 8593);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10005, 8291, 8608);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 8624, 8721);

                return f_10005_8631_8720(SyntaxKind.IdentifierToken, text, text, leading, trailing);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10005, 8176, 8732);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10005_8413_8429(string
                text)
                {
                    var return_v = Identifier(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10005, 8413, 8429);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifierWithTrailingTrivia
                f_10005_8519_8573(string
                text, Microsoft.CodeAnalysis.GreenNode
                trailing)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifierWithTrailingTrivia(text, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10005, 8519, 8573);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifierWithTrivia
                f_10005_8631_8720(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                contextualKind, string
                text, string
                valueText, Microsoft.CodeAnalysis.GreenNode
                leading, Microsoft.CodeAnalysis.GreenNode
                trailing)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifierWithTrivia(contextualKind, text, valueText, leading, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10005, 8631, 8720);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10005, 8176, 8732);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10005, 8176, 8732);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SyntaxToken Identifier(SyntaxKind contextualKind, GreenNode leading, string text, string valueText, GreenNode trailing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10005, 8744, 9182);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 8904, 9065) || true) && (contextualKind == SyntaxKind.IdentifierToken && (DynAbs.Tracing.TraceSender.Expression_True(10005, 8908, 8973) && valueText == text))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10005, 8904, 9065);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 9007, 9050);

                    return f_10005_9014_9049(leading, text, trailing);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10005, 8904, 9065);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 9081, 9171);

                return f_10005_9088_9170(contextualKind, text, valueText, leading, trailing);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10005, 8744, 9182);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10005_9014_9049(Microsoft.CodeAnalysis.GreenNode
                leading, string
                text, Microsoft.CodeAnalysis.GreenNode
                trailing)
                {
                    var return_v = Identifier(leading, text, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10005, 9014, 9049);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifierWithTrivia
                f_10005_9088_9170(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                contextualKind, string
                text, string
                valueText, Microsoft.CodeAnalysis.GreenNode
                leading, Microsoft.CodeAnalysis.GreenNode
                trailing)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifierWithTrivia(contextualKind, text, valueText, leading, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10005, 9088, 9170);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10005, 8744, 9182);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10005, 8744, 9182);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SyntaxToken WithValue<T>(SyntaxKind kind, string text, T value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10005, 9194, 9363);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 9298, 9352);

                return f_10005_9305_9351<T>(kind, text, value);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10005, 9194, 9363);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithValue<T>
                f_10005_9305_9351<T>(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, string
                text, T
                value)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithValue<T>(kind, text, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10005, 9305, 9351);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10005, 9194, 9363);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10005, 9194, 9363);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SyntaxToken WithValue<T>(SyntaxKind kind, GreenNode leading, string text, T value, GreenNode trailing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10005, 9375, 9611);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 9518, 9600);

                return f_10005_9525_9599<T>(kind, text, value, leading, trailing);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10005, 9375, 9611);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithValueAndTrivia<T>
                f_10005_9525_9599<T>(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, string
                text, T
                value, Microsoft.CodeAnalysis.GreenNode
                leading, Microsoft.CodeAnalysis.GreenNode
                trailing)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithValueAndTrivia<T>(kind, text, value, leading, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10005, 9525, 9599);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10005, 9375, 9611);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10005, 9375, 9611);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SyntaxToken StringLiteral(string text)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10005, 9623, 9796);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 9702, 9785);

                return f_10005_9709_9784(SyntaxKind.StringLiteralToken, text, text);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10005, 9623, 9796);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithValue<string>
                f_10005_9709_9784(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, string
                text, string
                value)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithValue<string>(kind, text, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10005, 9709, 9784);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10005, 9623, 9796);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10005, 9623, 9796);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SyntaxToken StringLiteral(CSharpSyntaxNode leading, string text, CSharpSyntaxNode trailing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10005, 9808, 10062);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 9940, 10051);

                return f_10005_9947_10050(SyntaxKind.StringLiteralToken, text, text, leading, trailing);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10005, 9808, 10062);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithValueAndTrivia<string>
                f_10005_9947_10050(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, string
                text, string
                value, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                leading, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                trailing)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithValueAndTrivia<string>(kind, text, value, (Microsoft.CodeAnalysis.GreenNode)leading, (Microsoft.CodeAnalysis.GreenNode)trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10005, 9947, 10050);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10005, 9808, 10062);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10005, 9808, 10062);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual SyntaxKind ContextualKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10005, 10139, 10207);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 10175, 10192);

                    return f_10005_10182_10191(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10005, 10139, 10207);

                    Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    f_10005_10182_10191(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10005, 10182, 10191);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10005, 10074, 10218);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10005, 10074, 10218);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int RawContextualKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10005, 10292, 10375);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 10328, 10360);

                    return (int)f_10005_10340_10359(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10005, 10292, 10375);

                    Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    f_10005_10340_10359(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                    this_param)
                    {
                        var return_v = this_param.ContextualKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10005, 10340, 10359);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10005, 10230, 10386);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10005, 10230, 10386);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual string Text
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10005, 10449, 10495);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 10455, 10493);

                    return f_10005_10462_10492(f_10005_10482_10491(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10005, 10449, 10495);

                    Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    f_10005_10482_10491(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10005, 10482, 10491);
                        return return_v;
                    }


                    string
                    f_10005_10462_10492(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    kind)
                    {
                        var return_v = SyntaxFacts.GetText(kind);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10005, 10462, 10492);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10005, 10398, 10506);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10005, 10398, 10506);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10005, 10894, 10980);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 10952, 10969);

                return f_10005_10959_10968(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10005, 10894, 10980);

                string
                f_10005_10959_10968(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10005, 10959, 10968);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10005, 10894, 10980);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10005, 10894, 10980);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual object Value
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10005, 11044, 11490);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 11080, 11475);

                    switch (f_10005_11088_11097(this))
                    {

                        case SyntaxKind.TrueKeyword:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10005, 11080, 11475);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 11193, 11205);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10005, 11080, 11475);

                        case SyntaxKind.FalseKeyword:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10005, 11080, 11475);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 11282, 11295);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10005, 11080, 11475);

                        case SyntaxKind.NullKeyword:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10005, 11080, 11475);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 11371, 11383);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10005, 11080, 11475);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10005, 11080, 11475);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 11439, 11456);

                            return f_10005_11446_11455(this);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10005, 11080, 11475);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10005, 11044, 11490);

                    Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    f_10005_11088_11097(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10005, 11088, 11097);
                        return return_v;
                    }


                    string
                    f_10005_11446_11455(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                    this_param)
                    {
                        var return_v = this_param.Text;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10005, 11446, 11455);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10005, 10992, 11501);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10005, 10992, 11501);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override object GetValue()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10005, 11513, 11600);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 11571, 11589);

                return f_10005_11578_11588(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10005, 11513, 11600);

                object
                f_10005_11578_11588(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10005, 11578, 11588);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10005, 11513, 11600);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10005, 11513, 11600);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual string ValueText
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10005, 11668, 11693);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 11674, 11691);

                    return f_10005_11681_11690(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10005, 11668, 11693);

                    string
                    f_10005_11681_11690(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                    this_param)
                    {
                        var return_v = this_param.Text;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10005, 11681, 11690);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10005, 11612, 11704);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10005, 11612, 11704);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string GetValueText()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10005, 11716, 11811);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 11778, 11800);

                return f_10005_11785_11799(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10005, 11716, 11811);

                string
                f_10005_11785_11799(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.ValueText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10005, 11785, 11799);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10005, 11716, 11811);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10005, 11716, 11811);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int Width
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10005, 11873, 11905);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 11879, 11903);

                    return f_10005_11886_11902(f_10005_11886_11895(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10005, 11873, 11905);

                    string
                    f_10005_11886_11895(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                    this_param)
                    {
                        var return_v = this_param.Text;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10005, 11886, 11895);
                        return return_v;
                    }


                    int
                    f_10005_11886_11902(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10005, 11886, 11902);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10005, 11823, 11916);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10005, 11823, 11916);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int GetLeadingTriviaWidth()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10005, 11928, 12106);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 11996, 12034);

                var
                leading = f_10005_12010_12033(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 12048, 12095);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10005, 12055, 12070) || ((leading != null && DynAbs.Tracing.TraceSender.Conditional_F2(10005, 12073, 12090)) || DynAbs.Tracing.TraceSender.Conditional_F3(10005, 12093, 12094))) ? f_10005_12073_12090(leading) : 0;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10005, 11928, 12106);

                Microsoft.CodeAnalysis.GreenNode
                f_10005_12010_12033(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.GetLeadingTrivia();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10005, 12010, 12033);
                    return return_v;
                }


                int
                f_10005_12073_12090(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.FullWidth;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10005, 12073, 12090);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10005, 11928, 12106);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10005, 11928, 12106);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetTrailingTriviaWidth()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10005, 12118, 12301);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 12187, 12227);

                var
                trailing = f_10005_12202_12226(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 12241, 12290);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10005, 12248, 12264) || ((trailing != null && DynAbs.Tracing.TraceSender.Conditional_F2(10005, 12267, 12285)) || DynAbs.Tracing.TraceSender.Conditional_F3(10005, 12288, 12289))) ? f_10005_12267_12285(trailing) : 0;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10005, 12118, 12301);

                Microsoft.CodeAnalysis.GreenNode
                f_10005_12202_12226(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.GetTrailingTrivia();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10005, 12202, 12226);
                    return return_v;
                }


                int
                f_10005_12267_12285(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.FullWidth;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10005, 12267, 12285);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10005, 12118, 12301);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10005, 12118, 12301);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal SyntaxList<CSharpSyntaxNode> LeadingTrivia
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10005, 12389, 12462);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 12395, 12460);

                    return f_10005_12402_12459(f_10005_12435_12458(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10005, 12389, 12462);

                    Microsoft.CodeAnalysis.GreenNode
                    f_10005_12435_12458(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                    this_param)
                    {
                        var return_v = this_param.GetLeadingTrivia();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10005, 12435, 12458);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode>
                    f_10005_12402_12459(Microsoft.CodeAnalysis.GreenNode
                    node)
                    {
                        var return_v = new Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode>(node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10005, 12402, 12459);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10005, 12313, 12473);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10005, 12313, 12473);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal SyntaxList<CSharpSyntaxNode> TrailingTrivia
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10005, 12562, 12636);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 12568, 12634);

                    return f_10005_12575_12633(f_10005_12608_12632(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10005, 12562, 12636);

                    Microsoft.CodeAnalysis.GreenNode
                    f_10005_12608_12632(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                    this_param)
                    {
                        var return_v = this_param.GetTrailingTrivia();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10005, 12608, 12632);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode>
                    f_10005_12575_12633(Microsoft.CodeAnalysis.GreenNode
                    node)
                    {
                        var return_v = new Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode>(node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10005, 12575, 12633);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10005, 12485, 12647);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10005, 12485, 12647);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override GreenNode WithLeadingTrivia(GreenNode trivia)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10005, 12659, 12801);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 12752, 12790);

                return f_10005_12759_12789(this, trivia);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10005, 12659, 12801);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10005_12759_12789(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param, Microsoft.CodeAnalysis.GreenNode
                trivia)
                {
                    var return_v = this_param.TokenWithLeadingTrivia(trivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10005, 12759, 12789);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10005, 12659, 12801);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10005, 12659, 12801);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual SyntaxToken TokenWithLeadingTrivia(GreenNode trivia)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10005, 12813, 13020);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 12905, 13009);

                return f_10005_12912_13008(f_10005_12938_12947(this), trivia, null, f_10005_12963_12984(this), f_10005_12986_13007(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10005, 12813, 13020);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10005_12938_12947(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10005, 12938, 12947);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo[]
                f_10005_12963_12984(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.GetDiagnostics();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10005, 12963, 12984);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxAnnotation[]
                f_10005_12986_13007(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.GetAnnotations();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10005, 12986, 13007);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithTrivia
                f_10005_12912_13008(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, Microsoft.CodeAnalysis.GreenNode
                leading, Microsoft.CodeAnalysis.GreenNode
                trailing, Microsoft.CodeAnalysis.DiagnosticInfo[]
                diagnostics, Microsoft.CodeAnalysis.SyntaxAnnotation[]
                annotations)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithTrivia(kind, leading, trailing, diagnostics, annotations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10005, 12912, 13008);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10005, 12813, 13020);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10005, 12813, 13020);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override GreenNode WithTrailingTrivia(GreenNode trivia)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10005, 13032, 13176);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 13126, 13165);

                return f_10005_13133_13164(this, trivia);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10005, 13032, 13176);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10005_13133_13164(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param, Microsoft.CodeAnalysis.GreenNode
                trivia)
                {
                    var return_v = this_param.TokenWithTrailingTrivia(trivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10005, 13133, 13164);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10005, 13032, 13176);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10005, 13032, 13176);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual SyntaxToken TokenWithTrailingTrivia(GreenNode trivia)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10005, 13188, 13396);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 13281, 13385);

                return f_10005_13288_13384(f_10005_13314_13323(this), null, trivia, f_10005_13339_13360(this), f_10005_13362_13383(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10005, 13188, 13396);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10005_13314_13323(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10005, 13314, 13323);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo[]
                f_10005_13339_13360(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.GetDiagnostics();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10005, 13339, 13360);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxAnnotation[]
                f_10005_13362_13383(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.GetAnnotations();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10005, 13362, 13383);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithTrivia
                f_10005_13288_13384(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, Microsoft.CodeAnalysis.GreenNode
                leading, Microsoft.CodeAnalysis.GreenNode
                trailing, Microsoft.CodeAnalysis.DiagnosticInfo[]
                diagnostics, Microsoft.CodeAnalysis.SyntaxAnnotation[]
                annotations)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithTrivia(kind, leading, trailing, diagnostics, annotations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10005, 13288, 13384);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10005, 13188, 13396);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10005, 13188, 13396);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override GreenNode SetDiagnostics(DiagnosticInfo[] diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10005, 13408, 13687);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 13505, 13576);

                f_10005_13505_13575(f_10005_13537_13551(this) == typeof(SyntaxToken));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 13590, 13676);

                return f_10005_13597_13675(f_10005_13613_13622(this), f_10005_13624_13638(this), diagnostics, f_10005_13653_13674(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10005, 13408, 13687);

                System.Type
                f_10005_13537_13551(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10005, 13537, 13551);
                    return return_v;
                }


                int
                f_10005_13505_13575(bool
                condition)
                {
                    System.Diagnostics.Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10005, 13505, 13575);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10005_13613_13622(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10005, 13613, 13622);
                    return return_v;
                }


                int
                f_10005_13624_13638(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.FullWidth;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10005, 13624, 13638);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxAnnotation[]
                f_10005_13653_13674(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.GetAnnotations();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10005, 13653, 13674);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10005_13597_13675(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, int
                fullWidth, Microsoft.CodeAnalysis.DiagnosticInfo[]
                diagnostics, Microsoft.CodeAnalysis.SyntaxAnnotation[]
                annotations)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken(kind, fullWidth, diagnostics, annotations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10005, 13597, 13675);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10005, 13408, 13687);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10005, 13408, 13687);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override GreenNode SetAnnotations(SyntaxAnnotation[] annotations)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10005, 13699, 13980);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 13798, 13869);

                f_10005_13798_13868(f_10005_13830_13844(this) == typeof(SyntaxToken));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 13883, 13969);

                return f_10005_13890_13968(f_10005_13906_13915(this), f_10005_13917_13931(this), f_10005_13933_13954(this), annotations);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10005, 13699, 13980);

                System.Type
                f_10005_13830_13844(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10005, 13830, 13844);
                    return return_v;
                }


                int
                f_10005_13798_13868(bool
                condition)
                {
                    System.Diagnostics.Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10005, 13798, 13868);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10005_13906_13915(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10005, 13906, 13915);
                    return return_v;
                }


                int
                f_10005_13917_13931(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.FullWidth;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10005, 13917, 13931);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo[]
                f_10005_13933_13954(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.GetDiagnostics();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10005, 13933, 13954);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10005_13890_13968(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, int
                fullWidth, Microsoft.CodeAnalysis.DiagnosticInfo[]
                diagnostics, Microsoft.CodeAnalysis.SyntaxAnnotation[]
                annotations)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken(kind, fullWidth, diagnostics, annotations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10005, 13890, 13968);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10005, 13699, 13980);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10005, 13699, 13980);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override DirectiveStack ApplyDirectives(DirectiveStack stack)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10005, 13992, 14350);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 14087, 14310) || true) && (f_10005_14091_14114(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10005, 14087, 14310);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 14148, 14212);

                    stack = f_10005_14156_14211(f_10005_14180_14203(this), stack);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 14230, 14295);

                    stack = f_10005_14238_14294(f_10005_14262_14286(this), stack);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10005, 14087, 14310);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 14326, 14339);

                return stack;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10005, 13992, 14350);

                bool
                f_10005_14091_14114(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.ContainsDirectives;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10005, 14091, 14114);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_10005_14180_14203(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.GetLeadingTrivia();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10005, 14180, 14203);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack
                f_10005_14156_14211(Microsoft.CodeAnalysis.GreenNode
                triviaList, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack
                stack)
                {
                    var return_v = ApplyDirectivesToTrivia(triviaList, stack);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10005, 14156, 14211);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_10005_14262_14286(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.GetTrailingTrivia();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10005, 14262, 14286);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack
                f_10005_14238_14294(Microsoft.CodeAnalysis.GreenNode
                triviaList, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack
                stack)
                {
                    var return_v = ApplyDirectivesToTrivia(triviaList, stack);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10005, 14238, 14294);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10005, 13992, 14350);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10005, 13992, 14350);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static DirectiveStack ApplyDirectivesToTrivia(GreenNode triviaList, DirectiveStack stack)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10005, 14362, 14682);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 14484, 14642) || true) && (triviaList != null && (DynAbs.Tracing.TraceSender.Expression_True(10005, 14488, 14539) && f_10005_14510_14539(triviaList)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10005, 14484, 14642);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 14573, 14627);

                    return f_10005_14580_14626(triviaList, stack);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10005, 14484, 14642);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 14658, 14671);

                return stack;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10005, 14362, 14682);

                bool
                f_10005_14510_14539(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.ContainsDirectives;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10005, 14510, 14539);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack
                f_10005_14580_14626(Microsoft.CodeAnalysis.GreenNode
                listOrNode, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack
                stack)
                {
                    var return_v = ApplyDirectivesToListOrNode(listOrNode, stack);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10005, 14580, 14626);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10005, 14362, 14682);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10005, 14362, 14682);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override TResult Accept<TResult>(CSharpSyntaxVisitor<TResult> visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10005, 14694, 14839);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 14796, 14828);

                return f_10005_14803_14827<TResult>(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10005, 14694, 14839);

                TResult
                f_10005_14803_14827<TResult>(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                token)
                {
                    var return_v = this_param.VisitToken(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10005, 14803, 14827);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10005, 14694, 14839);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10005, 14694, 14839);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override void Accept(CSharpSyntaxVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10005, 14851, 14968);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 14932, 14957);

                f_10005_14932_14956(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10005, 14851, 14968);

                int
                f_10005_14932_14956(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                token)
                {
                    this_param.VisitToken(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10005, 14932, 14956);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10005, 14851, 14968);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10005, 14851, 14968);
            }
        }

        protected override void WriteTokenTo(System.IO.TextWriter writer, bool leading, bool trailing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10005, 14980, 15626);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 15099, 15328) || true) && (leading)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10005, 15099, 15328);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 15144, 15181);

                    var
                    trivia = f_10005_15157_15180(this)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 15199, 15313) || true) && (trivia != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10005, 15199, 15313);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 15259, 15294);

                        f_10005_15259_15293(trivia, writer, true, true);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10005, 15199, 15313);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10005, 15099, 15328);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 15344, 15368);

                f_10005_15344_15367(
                            writer, f_10005_15357_15366(this));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 15384, 15615) || true) && (trailing)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10005, 15384, 15615);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 15430, 15468);

                    var
                    trivia = f_10005_15443_15467(this)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 15486, 15600) || true) && (trivia != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10005, 15486, 15600);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 15546, 15581);

                        f_10005_15546_15580(trivia, writer, true, true);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10005, 15486, 15600);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10005, 15384, 15615);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10005, 14980, 15626);

                Microsoft.CodeAnalysis.GreenNode
                f_10005_15157_15180(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.GetLeadingTrivia();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10005, 15157, 15180);
                    return return_v;
                }


                int
                f_10005_15259_15293(Microsoft.CodeAnalysis.GreenNode
                this_param, System.IO.TextWriter
                writer, bool
                leading, bool
                trailing)
                {
                    this_param.WriteTo(writer, leading, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10005, 15259, 15293);
                    return 0;
                }


                string
                f_10005_15357_15366(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10005, 15357, 15366);
                    return return_v;
                }


                int
                f_10005_15344_15367(System.IO.TextWriter
                this_param, string
                value)
                {
                    this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10005, 15344, 15367);
                    return 0;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_10005_15443_15467(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.GetTrailingTrivia();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10005, 15443, 15467);
                    return return_v;
                }


                int
                f_10005_15546_15580(Microsoft.CodeAnalysis.GreenNode
                this_param, System.IO.TextWriter
                writer, bool
                leading, bool
                trailing)
                {
                    this_param.WriteTo(writer, leading, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10005, 15546, 15580);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10005, 14980, 15626);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10005, 14980, 15626);
            }
        }

        public override bool IsEquivalentTo(GreenNode other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10005, 15638, 16969);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 15715, 15808) || true) && (!DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.IsEquivalentTo(other), 10005, 15720, 15746))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10005, 15715, 15808);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 15780, 15793);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10005, 15715, 15808);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 15824, 15860);

                var
                otherToken = (SyntaxToken)other
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 15876, 15970) || true) && (f_10005_15880_15889(this) != f_10005_15893_15908(otherToken))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10005, 15876, 15970);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 15942, 15955);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10005, 15876, 15970);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 15986, 16028);

                var
                thisLeading = f_10005_16004_16027(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 16042, 16091);

                var
                otherLeading = f_10005_16061_16090(otherToken)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 16105, 16445) || true) && (thisLeading != otherLeading)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10005, 16105, 16445);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 16170, 16291) || true) && (thisLeading == null || (DynAbs.Tracing.TraceSender.Expression_False(10005, 16174, 16217) || otherLeading == null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10005, 16170, 16291);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 16259, 16272);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10005, 16170, 16291);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 16311, 16430) || true) && (!f_10005_16316_16356(thisLeading, otherLeading))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10005, 16311, 16430);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 16398, 16411);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10005, 16311, 16430);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10005, 16105, 16445);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 16461, 16505);

                var
                thisTrailing = f_10005_16480_16504(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 16519, 16570);

                var
                otherTrailing = f_10005_16539_16569(otherToken)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 16584, 16930) || true) && (thisTrailing != otherTrailing)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10005, 16584, 16930);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 16651, 16774) || true) && (thisTrailing == null || (DynAbs.Tracing.TraceSender.Expression_False(10005, 16655, 16700) || otherTrailing == null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10005, 16651, 16774);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 16742, 16755);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10005, 16651, 16774);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 16794, 16915) || true) && (!f_10005_16799_16841(thisTrailing, otherTrailing))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10005, 16794, 16915);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 16883, 16896);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10005, 16794, 16915);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10005, 16584, 16930);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 16946, 16958);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10005, 15638, 16969);

                string
                f_10005_15880_15889(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10005, 15880, 15889);
                    return return_v;
                }


                string
                f_10005_15893_15908(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10005, 15893, 15908);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_10005_16004_16027(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.GetLeadingTrivia();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10005, 16004, 16027);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_10005_16061_16090(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.GetLeadingTrivia();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10005, 16061, 16090);
                    return return_v;
                }


                bool
                f_10005_16316_16356(Microsoft.CodeAnalysis.GreenNode
                this_param, Microsoft.CodeAnalysis.GreenNode
                other)
                {
                    var return_v = this_param.IsEquivalentTo(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10005, 16316, 16356);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_10005_16480_16504(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.GetTrailingTrivia();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10005, 16480, 16504);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_10005_16539_16569(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.GetTrailingTrivia();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10005, 16539, 16569);
                    return return_v;
                }


                bool
                f_10005_16799_16841(Microsoft.CodeAnalysis.GreenNode
                this_param, Microsoft.CodeAnalysis.GreenNode
                other)
                {
                    var return_v = this_param.IsEquivalentTo(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10005, 16799, 16841);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10005, 15638, 16969);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10005, 15638, 16969);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override SyntaxNode CreateRed(SyntaxNode parent, int position)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10005, 16981, 17125);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10005, 17077, 17114);

                throw f_10005_17083_17113();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10005, 16981, 17125);

                System.Exception
                f_10005_17083_17113()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10005, 17083, 17113);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10005, 16981, 17125);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10005, 16981, 17125);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10005, 435, 17132);

        string
        f_10005_896_905(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
        this_param)
        {
            var return_v = this_param.Text;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10005, 896, 905);
            return return_v;
        }


        int
        f_10005_896_912(string
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10005, 896, 912);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.SyntaxKind
        f_10005_854_858_C(Microsoft.CodeAnalysis.CSharp.SyntaxKind
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10005, 796, 1033);
            return return_v;
        }


        string
        f_10005_1188_1197(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
        this_param)
        {
            var return_v = this_param.Text;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10005, 1188, 1197);
            return return_v;
        }


        int
        f_10005_1188_1204(string
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10005, 1188, 1204);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.SyntaxKind
        f_10005_1133_1137_C(Microsoft.CodeAnalysis.CSharp.SyntaxKind
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10005, 1045, 1325);
            return return_v;
        }


        string
        f_10005_1525_1534(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
        this_param)
        {
            var return_v = this_param.Text;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10005, 1525, 1534);
            return return_v;
        }


        int
        f_10005_1525_1541(string
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10005, 1525, 1541);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.SyntaxKind
        f_10005_1457_1461_C(Microsoft.CodeAnalysis.CSharp.SyntaxKind
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10005, 1337, 1662);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.SyntaxKind
        f_10005_1747_1751_C(Microsoft.CodeAnalysis.CSharp.SyntaxKind
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10005, 1674, 1894);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.SyntaxKind
        f_10005_2009_2013_C(Microsoft.CodeAnalysis.CSharp.SyntaxKind
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10005, 1906, 2169);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.SyntaxKind
        f_10005_2316_2320_C(Microsoft.CodeAnalysis.CSharp.SyntaxKind
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10005, 2181, 2489);
            return return_v;
        }


        string
        f_10005_2606_2615(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
        this_param)
        {
            var return_v = this_param.Text;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10005, 2606, 2615);
            return return_v;
        }


        int
        f_10005_2692_2703(string
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10005, 2692, 2703);
            return return_v;
        }


        static Roslyn.Utilities.ObjectReader
        f_10005_2563_2569_C(Roslyn.Utilities.ObjectReader
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10005, 2501, 2842);
            return return_v;
        }


        int
        f_10005_3004_3013()
        {
            var return_v = FullWidth;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10005, 3004, 3013);
            return return_v;
        }


        static int
        f_10005_6290_6367(System.Type
        type, System.Func<Roslyn.Utilities.ObjectReader, Roslyn.Utilities.IObjectWritable>
        typeReader)
        {
            ObjectBinder.RegisterTypeReader(type, typeReader);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10005, 6290, 6367);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
        f_10005_6545_6566(Microsoft.CodeAnalysis.CSharp.SyntaxKind
        kind)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken(kind);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10005, 6545, 6566);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithTrivia
        f_10005_6630_6725(Microsoft.CodeAnalysis.CSharp.SyntaxKind
        kind, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
        leading, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
        trailing)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithTrivia(kind, (Microsoft.CodeAnalysis.GreenNode)leading, (Microsoft.CodeAnalysis.GreenNode)trailing);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10005, 6630, 6725);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithTrivia
        f_10005_6795_6853(Microsoft.CodeAnalysis.CSharp.SyntaxKind
        kind, Microsoft.CodeAnalysis.GreenNode
        leading, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
        trailing)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithTrivia(kind, leading, (Microsoft.CodeAnalysis.GreenNode)trailing);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10005, 6795, 6853);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithTrivia
        f_10005_6922_6997(Microsoft.CodeAnalysis.CSharp.SyntaxKind
        kind, Microsoft.CodeAnalysis.GreenNode
        leading, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
        trailing)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithTrivia(kind, leading, (Microsoft.CodeAnalysis.GreenNode)trailing);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10005, 6922, 6997);
            return return_v;
        }

    }
}
