// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    public abstract partial class NameSyntax
    {
        public int Arity
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10785, 490, 639);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10785, 526, 624);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10785, 533, 558) || ((this is GenericNameSyntax && DynAbs.Tracing.TraceSender.Conditional_F2(10785, 561, 619)) || DynAbs.Tracing.TraceSender.Conditional_F3(10785, 622, 623))) ? f_10785_561_603(((GenericNameSyntax)this)).Arguments.Count : 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10785, 490, 639);

                    Microsoft.CodeAnalysis.CSharp.Syntax.TypeArgumentListSyntax
                    f_10785_561_603(Microsoft.CodeAnalysis.CSharp.Syntax.GenericNameSyntax
                    this_param)
                    {
                        var return_v = this_param.TypeArgumentList;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10785, 561, 603);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10785, 449, 650);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10785, 449, 650);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal abstract SimpleNameSyntax GetUnqualifiedName();

        internal abstract string ErrorDisplayName();

        internal string? GetAliasQualifierOpt()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10785, 2112, 2677);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10785, 2176, 2199);

                NameSyntax
                name = this
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10785, 2213, 2666) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10785, 2213, 2666);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10785, 2258, 2619);

                        switch (f_10785_2266_2277(name))
                        {

                            case SyntaxKind.QualifiedName:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10785, 2258, 2619);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10785, 2375, 2415);

                                name = f_10785_2382_2414(((QualifiedNameSyntax)name));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10785, 2441, 2450);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10785, 2258, 2619);

                            case SyntaxKind.AliasQualifiedName:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10785, 2258, 2619);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10785, 2533, 2600);

                                return f_10785_2540_2578(((AliasQualifiedNameSyntax)name)).Identifier.ValueText;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10785, 2258, 2619);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10785, 2639, 2651);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10785, 2213, 2666);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10785, 2213, 2666);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10785, 2213, 2666);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10785, 2112, 2677);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10785_2266_2277(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10785, 2266, 2277);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10785_2382_2414(Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedNameSyntax
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10785, 2382, 2414);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                f_10785_2540_2578(Microsoft.CodeAnalysis.CSharp.Syntax.AliasQualifiedNameSyntax
                this_param)
                {
                    var return_v = this_param.Alias;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10785, 2540, 2578);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10785, 2112, 2677);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10785, 2112, 2677);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static NameSyntax()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10785, 392, 2684);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10785, 392, 2684);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10785, 392, 2684);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10785, 392, 2684);
    }
}
