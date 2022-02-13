// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal class FlowAnalysisPass
    {
        public static BoundBlock Rewrite(
                    MethodSymbol method,
                    BoundBlock block,
                    DiagnosticBag diagnostics,
                    bool hasTrailingExpression,
                    bool originalBodyNested)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10897, 1434, 5122);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10897, 1777, 1844);

                f_10897_1777_1843(!hasTrailingExpression || (DynAbs.Tracing.TraceSender.Expression_False(10897, 1790, 1842) || f_10897_1816_1842(method)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10897, 1858, 1919);

                var
                initialDiagnosticCount = f_10897_1887_1911(diagnostics).Length
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10897, 1941, 1987);

                var
                compilation = f_10897_1959_1986(method)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10897, 2003, 5082) || true) && (f_10897_2007_2025(method) || (DynAbs.Tracing.TraceSender.Expression_False(10897, 2007, 2046) || f_10897_2029_2046(method)) || (DynAbs.Tracing.TraceSender.Expression_False(10897, 2007, 2090) || f_10897_2050_2090(method, compilation)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10897, 2003, 5082);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10897, 2187, 2449) || true) && ((f_10897_2192_2219(method) && (DynAbs.Tracing.TraceSender.Expression_True(10897, 2192, 2250) && f_10897_2223_2250_M(!method.IsScriptInitializer))) || (DynAbs.Tracing.TraceSender.Expression_False(10897, 2191, 2324) || f_10897_2276_2324(compilation, method, block, diagnostics)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10897, 2187, 2449);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10897, 2366, 2430);

                        block = f_10897_2374_2429(block, method, originalBodyNested);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10897, 2187, 2449);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10897, 2003, 5082);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10897, 2003, 5082);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10897, 2483, 5082) || true) && (f_10897_2487_2535(compilation, method, block, diagnostics))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10897, 2483, 5082);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10897, 2826, 2890);

                        f_10897_2826_2889(f_10897_2839_2856(method) != MethodKind.AnonymousFunction);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10897, 3056, 3205);

                        var
                        submissionResultType = (DynAbs.Tracing.TraceSender.Conditional_F1(10897, 3083, 3134) || (((method is SynthesizedInteractiveInitializerMethod) && DynAbs.Tracing.TraceSender.Conditional_F2(10897, 3137, 3197)) || DynAbs.Tracing.TraceSender.Conditional_F3(10897, 3200, 3204))) ? f_10897_3137_3197(((SynthesizedInteractiveInitializerMethod)method)) : null
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10897, 3223, 5067) || true) && (!hasTrailingExpression && (DynAbs.Tracing.TraceSender.Expression_True(10897, 3227, 3291) && ((object)submissionResultType != null)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10897, 3223, 5067);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10897, 3333, 3382);

                            f_10897_3333_3381(!f_10897_3347_3380(submissionResultType));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10897, 3406, 3511);

                            var
                            trailingExpression = f_10897_3431_3510(f_10897_3458_3487(method), submissionResultType)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10897, 3533, 3661);

                            var
                            newStatements = block.Statements.Add(f_10897_3574_3659(trailingExpression.Syntax, RefKind.None, trailingExpression))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10897, 3683, 3802);

                            block = new BoundBlock(block.Syntax, ImmutableArray<LocalSymbol>.Empty, newStatements) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10897, 3691, 3801) };

                            System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                f_10897_4561_4629(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                diags)
                            {
                                var return_v = GetErrorsOnly(diags);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10897, 4561, 4629);
                                return return_v;
                            }
                            System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                           f_10897_4495_4546(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                           diags)
                            {
                                var return_v = GetErrorsOnly((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>)diags);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10897, 4495, 4546);
                                return return_v;
                            }

                            IEnumerable<Diagnostic> GetErrorsOnly(IEnumerable<Diagnostic> diags)
                            {
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10897, 4130, 4189);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10897, 4133, 4189);
                                    return f_10897_4133_4189(diags, d => d.Severity == DiagnosticSeverity.Error); DynAbs.Tracing.TraceSender.TraceExitMethod(10897, 4130, 4189);
                                }
                                catch
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10897, 4130, 4189);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10897, 4130, 4189);
                                }
                                throw new System.Exception("Slicer error: unreachable code");
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10897, 4212, 4270);

                            var
                            flowAnalysisDiagnostics = f_10897_4242_4269()
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10897, 4292, 4368);

                            f_10897_4292_4367(!f_10897_4306_4366(compilation, method, block, flowAnalysisDiagnostics));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10897, 4482, 4632);

                            f_10897_4482_4631(f_10897_4495_4630(f_10897_4495_4546(f_10897_4509_4545(flowAnalysisDiagnostics)), f_10897_4561_4629(f_10897_4575_4628(f_10897_4575_4599(diagnostics), initialDiagnosticCount))));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10897, 4654, 4685);

                            f_10897_4654_4684(flowAnalysisDiagnostics);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10897, 3223, 5067);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10897, 3223, 5067);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10897, 4899, 5067) || true) && (method.Locations.Length == 1)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10897, 4899, 5067);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10897, 4973, 5048);

                                f_10897_4973_5047(diagnostics, ErrorCode.ERR_ReturnExpected, f_10897_5019_5035(method)[0], method);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10897, 4899, 5067);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10897, 3223, 5067);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10897, 2483, 5082);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10897, 2003, 5082);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10897, 5098, 5111);

                return block;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10897, 1434, 5122);

                bool
                f_10897_1816_1842(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsScriptInitializer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10897, 1816, 1842);
                    return return_v;
                }


                int
                f_10897_1777_1843(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10897, 1777, 1843);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_10897_1887_1911(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.ToReadOnly();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10897, 1887, 1911);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10897_1959_1986(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10897, 1959, 1986);
                    return return_v;
                }


                bool
                f_10897_2007_2025(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnsVoid;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10897, 2007, 2025);
                    return return_v;
                }


                bool
                f_10897_2029_2046(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsIterator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10897, 2029, 2046);
                    return return_v;
                }


                bool
                f_10897_2050_2090(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = method.IsAsyncReturningTask(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10897, 2050, 2090);
                    return return_v;
                }


                bool
                f_10897_2192_2219(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsImplicitlyDeclared;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10897, 2192, 2219);
                    return return_v;
                }


                bool
                f_10897_2223_2250_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10897, 2223, 2250);
                    return return_v;
                }


                bool
                f_10897_2276_2324(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.BoundBlock
                block, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = Analyze(compilation, method, block, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10897, 2276, 2324);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10897_2374_2429(Microsoft.CodeAnalysis.CSharp.BoundBlock
                body, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, bool
                originalBodyNested)
                {
                    var return_v = AppendImplicitReturn(body, method, originalBodyNested);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10897, 2374, 2429);
                    return return_v;
                }


                bool
                f_10897_2487_2535(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.BoundBlock
                block, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = Analyze(compilation, method, block, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10897, 2487, 2535);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10897_2839_2856(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10897, 2839, 2856);
                    return return_v;
                }


                int
                f_10897_2826_2889(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10897, 2826, 2889);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10897_3137_3197(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedInteractiveInitializerMethod
                this_param)
                {
                    var return_v = this_param.ResultType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10897, 3137, 3197);
                    return return_v;
                }


                bool
                f_10897_3347_3380(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsVoidType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10897, 3347, 3380);
                    return return_v;
                }


                int
                f_10897_3333_3381(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10897, 3333, 3381);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10897_3458_3487(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol)
                {
                    var return_v = symbol.GetNonNullSyntaxNode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10897, 3458, 3487);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDefaultExpression
                f_10897_3431_3510(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDefaultExpression((Microsoft.CodeAnalysis.SyntaxNode)syntax, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10897, 3431, 3510);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                f_10897_3574_3659(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.RefKind
                refKind, Microsoft.CodeAnalysis.CSharp.BoundDefaultExpression
                expressionOpt)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundReturnStatement(syntax, refKind, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expressionOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10897, 3574, 3659);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                f_10897_4133_4189(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                source, System.Func<Microsoft.CodeAnalysis.Diagnostic, bool>
                predicate)
                {
                    var return_v = source.Where<Microsoft.CodeAnalysis.Diagnostic>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10897, 4133, 4189);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10897_4242_4269()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10897, 4242, 4269);
                    return return_v;
                }


                bool
                f_10897_4306_4366(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.BoundBlock
                block, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = Analyze(compilation, method, block, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10897, 4306, 4366);
                    return return_v;
                }


                int
                f_10897_4292_4367(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10897, 4292, 4367);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_10897_4509_4545(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.ToReadOnly();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10897, 4509, 4545);
                    return return_v;
                }

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_10897_4575_4599(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.ToReadOnly();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10897, 4575, 4599);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                f_10897_4575_4628(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                source, int
                count)
                {
                    var return_v = source.Skip<Microsoft.CodeAnalysis.Diagnostic>(count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10897, 4575, 4628);
                    return return_v;
                }


                bool
                f_10897_4495_4630(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                first, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                second)
                {
                    var return_v = first.SequenceEqual<Microsoft.CodeAnalysis.Diagnostic>(second);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10897, 4495, 4630);
                    return return_v;
                }


                int
                f_10897_4482_4631(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10897, 4482, 4631);
                    return 0;
                }


                int
                f_10897_4654_4684(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10897, 4654, 4684);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10897_5019_5035(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10897, 5019, 5035);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10897_4973_5047(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10897, 4973, 5047);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10897, 1434, 5122);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10897, 1434, 5122);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static BoundBlock AppendImplicitReturn(BoundBlock body, MethodSymbol method, bool originalBodyNested)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10897, 5134, 5883);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10897, 5268, 5872) || true) && (originalBodyNested)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10897, 5268, 5872);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10897, 5324, 5357);

                    var
                    statements = f_10897_5341_5356(body)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10897, 5375, 5401);

                    int
                    n = statements.Length
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10897, 5421, 5479);

                    var
                    builder = f_10897_5435_5478(n)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10897, 5497, 5533);

                    f_10897_5497_5532(builder, statements, n - 1);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10897, 5551, 5624);

                    f_10897_5551_5623(builder, f_10897_5563_5622(statements[n - 1], method));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10897, 5644, 5749);

                    return f_10897_5651_5748(body, f_10897_5663_5674(body), ImmutableArray<LocalFunctionSymbol>.Empty, f_10897_5719_5747(builder));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10897, 5268, 5872);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10897, 5268, 5872);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10897, 5815, 5857);

                    return f_10897_5822_5856(body, method);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10897, 5268, 5872);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10897, 5134, 5883);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10897_5341_5356(Microsoft.CodeAnalysis.CSharp.BoundBlock
                this_param)
                {
                    var return_v = this_param.Statements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10897, 5341, 5356);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10897_5435_5478(int
                capacity)
                {
                    var return_v = ArrayBuilder<BoundStatement>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10897, 5435, 5478);
                    return return_v;
                }


                int
                f_10897_5497_5532(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                items, int
                length)
                {
                    this_param.AddRange(items, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10897, 5497, 5532);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10897_5563_5622(Microsoft.CodeAnalysis.CSharp.BoundStatement
                body, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = AppendImplicitReturn((Microsoft.CodeAnalysis.CSharp.BoundBlock)body, method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10897, 5563, 5622);
                    return return_v;
                }


                int
                f_10897_5551_5623(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10897, 5551, 5623);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10897_5663_5674(Microsoft.CodeAnalysis.CSharp.BoundBlock
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10897, 5663, 5674);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10897_5719_5747(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10897, 5719, 5747);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10897_5651_5748(Microsoft.CodeAnalysis.CSharp.BoundBlock
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
                localFunctions, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements)
                {
                    var return_v = this_param.Update(locals, localFunctions, statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10897, 5651, 5748);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10897_5822_5856(Microsoft.CodeAnalysis.CSharp.BoundBlock
                body, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = AppendImplicitReturn(body, method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10897, 5822, 5856);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10897, 5134, 5883);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10897, 5134, 5883);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static BoundBlock AppendImplicitReturn(BoundBlock body, MethodSymbol method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10897, 6131, 7044);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10897, 6241, 6268);

                f_10897_6241_6267(body != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10897, 6282, 6311);

                f_10897_6282_6310(method != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10897, 6327, 6359);

                SyntaxNode
                syntax = body.Syntax
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10897, 6375, 6702);

                f_10897_6375_6701(f_10897_6388_6413(body) || (DynAbs.Tracing.TraceSender.Expression_False(10897, 6388, 6474) || f_10897_6443_6474(syntax, SyntaxKind.Block)) || (DynAbs.Tracing.TraceSender.Expression_False(10897, 6388, 6551) || f_10897_6504_6551(syntax, SyntaxKind.ArrowExpressionClause)) || (DynAbs.Tracing.TraceSender.Expression_False(10897, 6388, 6629) || f_10897_6581_6629(syntax, SyntaxKind.ConstructorDeclaration)) || (DynAbs.Tracing.TraceSender.Expression_False(10897, 6388, 6700) || f_10897_6659_6700(syntax, SyntaxKind.CompilationUnit)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10897, 6718, 6938);

                BoundStatement
                ret = (DynAbs.Tracing.TraceSender.Conditional_F1(10897, 6739, 6777) || (((f_10897_6740_6757(method) && (DynAbs.Tracing.TraceSender.Expression_True(10897, 6740, 6776) && f_10897_6761_6776_M(!method.IsAsync)))
                && DynAbs.Tracing.TraceSender.Conditional_F2(10897, 6797, 6857)) || DynAbs.Tracing.TraceSender.Conditional_F3(10897, 6877, 6937))) ? (BoundStatement)f_10897_6813_6857(syntax) : f_10897_6877_6937(syntax, RefKind.None, null)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10897, 6954, 7033);

                return f_10897_6961_7032(body, f_10897_6973_6984(body), f_10897_6986_7005(body), body.Statements.Add(ret));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10897, 6131, 7044);

                int
                f_10897_6241_6267(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10897, 6241, 6267);
                    return 0;
                }


                int
                f_10897_6282_6310(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10897, 6282, 6310);
                    return 0;
                }


                bool
                f_10897_6388_6413(Microsoft.CodeAnalysis.CSharp.BoundBlock
                this_param)
                {
                    var return_v = this_param.WasCompilerGenerated;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10897, 6388, 6413);
                    return return_v;
                }


                bool
                f_10897_6443_6474(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = node.IsKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10897, 6443, 6474);
                    return return_v;
                }


                bool
                f_10897_6504_6551(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = node.IsKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10897, 6504, 6551);
                    return return_v;
                }


                bool
                f_10897_6581_6629(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = node.IsKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10897, 6581, 6629);
                    return return_v;
                }


                bool
                f_10897_6659_6700(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = node.IsKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10897, 6659, 6700);
                    return return_v;
                }


                int
                f_10897_6375_6701(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10897, 6375, 6701);
                    return 0;
                }


                bool
                f_10897_6740_6757(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsIterator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10897, 6740, 6757);
                    return return_v;
                }


                bool
                f_10897_6761_6776_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10897, 6761, 6776);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundYieldBreakStatement
                f_10897_6813_6857(Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    var return_v = BoundYieldBreakStatement.Synthesized(syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10897, 6813, 6857);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                f_10897_6877_6937(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.RefKind
                refKind, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = BoundReturnStatement.Synthesized(syntax, refKind, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10897, 6877, 6937);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10897_6973_6984(Microsoft.CodeAnalysis.CSharp.BoundBlock
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10897, 6973, 6984);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
                f_10897_6986_7005(Microsoft.CodeAnalysis.CSharp.BoundBlock
                this_param)
                {
                    var return_v = this_param.LocalFunctions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10897, 6986, 7005);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10897_6961_7032(Microsoft.CodeAnalysis.CSharp.BoundBlock
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
                localFunctions, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements)
                {
                    var return_v = this_param.Update(locals, localFunctions, statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10897, 6961, 7032);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10897, 6131, 7044);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10897, 6131, 7044);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool Analyze(
                    CSharpCompilation compilation,
                    MethodSymbol method,
                    BoundBlock block,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10897, 7056, 7461);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10897, 7258, 7336);

                var
                result = f_10897_7271_7335(compilation, method, block, diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10897, 7350, 7422);

                f_10897_7350_7421(compilation, method, block, diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10897, 7436, 7450);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10897, 7056, 7461);

                bool
                f_10897_7271_7335(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                member, Microsoft.CodeAnalysis.CSharp.BoundBlock
                block, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = ControlFlowPass.Analyze(compilation, (Microsoft.CodeAnalysis.CSharp.Symbol)member, block, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10897, 7271, 7335);
                    return return_v;
                }


                int
                f_10897_7350_7421(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                member, Microsoft.CodeAnalysis.CSharp.BoundBlock
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    DefiniteAssignmentPass.Analyze(compilation, member, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10897, 7350, 7421);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10897, 7056, 7461);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10897, 7056, 7461);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public FlowAnalysisPass()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(10897, 489, 7468);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(10897, 489, 7468);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10897, 489, 7468);
        }


        static FlowAnalysisPass()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10897, 489, 7468);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10897, 489, 7468);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10897, 489, 7468);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10897, 489, 7468);
    }
}
