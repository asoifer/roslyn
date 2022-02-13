// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    public partial class AttributeSyntax
    {
        internal string GetErrorDisplayName()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10739, 672, 848);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10739, 806, 837);

                return f_10739_813_836(f_10739_813_817());
                DynAbs.Tracing.TraceSender.TraceExitMethod(10739, 672, 848);

                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10739_813_817()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10739, 813, 817);
                    return return_v;
                }


                string
                f_10739_813_836(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                this_param)
                {
                    var return_v = this_param.ErrorDisplayName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10739, 813, 836);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10739, 672, 848);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10739, 672, 848);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal AttributeArgumentSyntax? GetNamedArgumentSyntax(string namedArgName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10739, 860, 1437);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10739, 962, 1012);

                f_10739_962_1011(!f_10739_976_1010(namedArgName));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10739, 1028, 1398) || true) && (argumentList != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10739, 1028, 1398);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10739, 1086, 1383);
                        foreach (var argSyntax in f_10739_1112_1134_I(f_10739_1112_1134(argumentList)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10739, 1086, 1383);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10739, 1176, 1364) || true) && (f_10739_1180_1200(argSyntax) != null && (DynAbs.Tracing.TraceSender.Expression_True(10739, 1180, 1274) && f_10739_1212_1237(f_10739_1212_1232(argSyntax)).Identifier.ValueText == namedArgName))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10739, 1176, 1364);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10739, 1324, 1341);

                                return argSyntax;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10739, 1176, 1364);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10739, 1086, 1383);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10739, 1, 298);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10739, 1, 298);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10739, 1028, 1398);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10739, 1414, 1426);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10739, 860, 1437);

                bool
                f_10739_976_1010(string
                value)
                {
                    var return_v = String.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10739, 976, 1010);
                    return return_v;
                }


                int
                f_10739_962_1011(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10739, 962, 1011);
                    return 0;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax>
                f_10739_1112_1134(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentListSyntax
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10739, 1112, 1134);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax?
                f_10739_1180_1200(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax
                this_param)
                {
                    var return_v = this_param.NameEquals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10739, 1180, 1200);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax
                f_10739_1212_1232(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax
                this_param)
                {
                    var return_v = this_param.NameEquals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10739, 1212, 1232);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                f_10739_1212_1237(Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10739, 1212, 1237);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax>
                f_10739_1112_1134_I(Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10739, 1112, 1134);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10739, 860, 1437);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10739, 860, 1437);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static AttributeSyntax()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10739, 307, 1444);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10739, 307, 1444);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10739, 307, 1444);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10739, 307, 1444);
    }
}
