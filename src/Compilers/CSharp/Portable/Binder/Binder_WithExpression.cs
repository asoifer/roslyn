// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class Binder
    {
        private BoundExpression BindWithExpression(WithExpressionSyntax syntax, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10322, 723, 3065);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10322, 846, 921);

                var
                receiver = f_10322_861_920(this, f_10322_889_906(syntax), diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10322, 935, 968);

                var
                receiverType = f_10322_954_967(receiver)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10322, 984, 1030);

                var
                lookupResult = f_10322_1003_1029()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10322, 1044, 1067);

                bool
                hasErrors = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10322, 1083, 1319) || true) && (receiverType is null || (DynAbs.Tracing.TraceSender.Expression_False(10322, 1087, 1136) || f_10322_1111_1136(receiverType)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10322, 1083, 1319);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10322, 1170, 1253);

                    f_10322_1170_1252(diagnostics, ErrorCode.ERR_InvalidWithReceiverType, f_10322_1225_1251(f_10322_1225_1242(syntax)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10322, 1271, 1304);

                    receiverType = f_10322_1286_1303(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10322, 1083, 1319);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10322, 1335, 1368);

                MethodSymbol?
                cloneMethod = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10322, 1382, 2434) || true) && (!f_10322_1387_1413(receiverType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10322, 1382, 2434);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10322, 1447, 1498);

                    HashSet<DiagnosticInfo>?
                    useSiteDiagnostics = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10322, 1518, 1725);

                    // LAFHIS
                    cloneMethod = f_10322_1532_1724((DynAbs.Tracing.TraceSender.Conditional_F1(10322, 1576, 1625) || ((receiverType is TypeParameterSymbol typeParameter && DynAbs.Tracing.TraceSender.Conditional_F2(10322, 1628, 1684)) || DynAbs.Tracing.TraceSender.Conditional_F3(10322, 1687, 1699))) ? f_10322_1628_1684((TypeParameterSymbol)receiverType, ref useSiteDiagnostics) : receiverType, ref useSiteDiagnostics);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10322, 1743, 2344) || true) && (cloneMethod is null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10322, 1743, 2344);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10322, 1808, 1825);

                        hasErrors = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10322, 1847, 1940);

                        f_10322_1847_1939(diagnostics, ErrorCode.ERR_NoSingleCloneMethod, f_10322_1898_1924(f_10322_1898_1915(syntax)), receiverType);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10322, 1743, 2344);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10322, 1743, 2344);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10322, 1982, 2344) || true) && (f_10322_1986_2020(cloneMethod) is DiagnosticInfo info)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10322, 1982, 2344);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10322, 2116, 2325) || true) && (useSiteDiagnostics == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10322, 2116, 2325);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10322, 2196, 2247);

                                useSiteDiagnostics = f_10322_2217_2246();
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10322, 2273, 2302);

                                f_10322_2273_2301(useSiteDiagnostics, info);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10322, 2116, 2325);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10322, 1982, 2344);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10322, 1743, 2344);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10322, 2364, 2419);

                    f_10322_2364_2418(
                                    diagnostics, f_10322_2380_2397(syntax), useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10322, 1382, 2434);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10322, 2450, 2670);

                var
                initializer = f_10322_2468_2669(this, f_10322_2512_2530(syntax), receiverType, f_10322_2580_2597(syntax), isForNewInstance: true, diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10322, 2840, 3054);

                return f_10322_2847_3053(syntax, receiver, cloneMethod, initializer, receiverType, hasErrors: hasErrors);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10322, 723, 3065);

                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10322_889_906(Microsoft.CodeAnalysis.CSharp.Syntax.WithExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10322, 889, 906);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10322_861_920(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindRValueWithoutTargetType(node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10322, 861, 920);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10322_954_967(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10322, 954, 967);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LookupResult
                f_10322_1003_1029()
                {
                    var return_v = LookupResult.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10322, 1003, 1029);
                    return return_v;
                }


                bool
                f_10322_1111_1136(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsVoidType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10322, 1111, 1136);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10322_1225_1242(Microsoft.CodeAnalysis.CSharp.Syntax.WithExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10322, 1225, 1242);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10322_1225_1251(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10322, 1225, 1251);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10322_1170_1252(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10322, 1170, 1252);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10322_1286_1303(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.CreateErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10322, 1286, 1303);
                    return return_v;
                }


                bool
                f_10322_1387_1413(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10322, 1387, 1413);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10322_1628_1684(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = this_param.EffectiveBaseClass(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10322, 1628, 1684);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10322_1532_1724(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                containingType, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = SynthesizedRecordClone.FindValidCloneMethod(containingType, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10322, 1532, 1724);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10322_1898_1915(Microsoft.CodeAnalysis.CSharp.Syntax.WithExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10322, 1898, 1915);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10322_1898_1924(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10322, 1898, 1924);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10322_1847_1939(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10322, 1847, 1939);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10322_1986_2020(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.GetUseSiteDiagnostic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10322, 1986, 2020);
                    return return_v;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                f_10322_2217_2246()
                {
                    var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10322, 2217, 2246);
                    return return_v;
                }


                bool
                f_10322_2273_2301(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                this_param, Microsoft.CodeAnalysis.DiagnosticInfo
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10322, 2273, 2301);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10322_2380_2397(Microsoft.CodeAnalysis.CSharp.Syntax.WithExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10322, 2380, 2397);
                    return return_v;
                }


                bool
                f_10322_2364_2418(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add((Microsoft.CodeAnalysis.SyntaxNode)node, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10322, 2364, 2418);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InitializerExpressionSyntax
                f_10322_2512_2530(Microsoft.CodeAnalysis.CSharp.Syntax.WithExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Initializer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10322, 2512, 2530);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10322_2580_2597(Microsoft.CodeAnalysis.CSharp.Syntax.WithExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10322, 2580, 2597);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase
                f_10322_2468_2669(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InitializerExpressionSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                typeSyntax, bool
                isForNewInstance, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindInitializerExpression(syntax, type, (Microsoft.CodeAnalysis.SyntaxNode)typeSyntax, isForNewInstance: isForNewInstance, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10322, 2468, 2669);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundWithExpression
                f_10322_2847_3053(Microsoft.CodeAnalysis.CSharp.Syntax.WithExpressionSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                cloneMethod, Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase
                initializerExpression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundWithExpression((Microsoft.CodeAnalysis.SyntaxNode)syntax, receiver, cloneMethod, initializerExpression, type, hasErrors: hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10322, 2847, 3053);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10322, 723, 3065);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10322, 723, 3065);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
