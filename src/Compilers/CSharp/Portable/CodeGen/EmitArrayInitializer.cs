// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Microsoft.CodeAnalysis.CSharp.CodeGen
{
    internal partial class CodeGenerator
    {
        private enum ArrayInitializerStyle
        {
            // Initialize every element
            Element,

            // Initialize all elements at once from a metadata blob
            Block,

            // Mixed case where there are some initializers that are constants and
            // there is enough of them so that it makes sense to use block initialization
            // followed by individual initialization of non-constant elements
            Mixed,
        }

        private void EmitArrayInitializers(ArrayTypeSymbol arrayType, BoundArrayInitialization inits)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10962, 1594, 2433);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 1712, 1747);

                var
                initExprs = f_10962_1728_1746(inits)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 1761, 1848);

                var
                initializationStyle = f_10962_1787_1847(this, f_10962_1814_1835(arrayType), initExprs)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 1864, 2422) || true) && (initializationStyle == ArrayInitializerStyle.Element)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10962, 1864, 2422);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 1954, 2011);

                    f_10962_1954_2010(this, arrayType, initExprs, true);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10962, 1864, 2422);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10962, 1864, 2422);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 2077, 2132);

                    ImmutableArray<byte>
                    data = f_10962_2105_2131(this, initExprs)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 2150, 2219);

                    f_10962_2150_2218(_builder, data, inits.Syntax, _diagnostics);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 2239, 2407) || true) && (initializationStyle == ArrayInitializerStyle.Mixed)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10962, 2239, 2407);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 2335, 2388);

                        f_10962_2335_2387(this, arrayType, initExprs, false);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10962, 2239, 2407);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10962, 1864, 2422);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10962, 1594, 2433);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10962_1728_1746(Microsoft.CodeAnalysis.CSharp.BoundArrayInitialization
                this_param)
                {
                    var return_v = this_param.Initializers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10962, 1728, 1746);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10962_1814_1835(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.ElementType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10962, 1814, 1835);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator.ArrayInitializerStyle
                f_10962_1787_1847(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                elementType, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                inits)
                {
                    var return_v = this_param.ShouldEmitBlockInitializer(elementType, inits);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10962, 1787, 1847);
                    return return_v;
                }


                int
                f_10962_1954_2010(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                arrayType, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                inits, bool
                includeConstants)
                {
                    this_param.EmitElementInitializers(arrayType, inits, includeConstants);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10962, 1954, 2010);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_10962_2105_2131(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                initializers)
                {
                    var return_v = this_param.GetRawData(initializers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10962, 2105, 2131);
                    return return_v;
                }


                int
                f_10962_2150_2218(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Collections.Immutable.ImmutableArray<byte>
                data, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.EmitArrayBlockInitializer(data, syntaxNode, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10962, 2150, 2218);
                    return 0;
                }


                int
                f_10962_2335_2387(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                arrayType, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                inits, bool
                includeConstants)
                {
                    this_param.EmitElementInitializers(arrayType, inits, includeConstants);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10962, 2335, 2387);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10962, 1594, 2433);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10962, 1594, 2433);
            }
        }

        private void EmitElementInitializers(ArrayTypeSymbol arrayType,
                                                    ImmutableArray<BoundExpression> inits,
                                                    bool includeConstants)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10962, 2445, 2994);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 2685, 2983) || true) && (!f_10962_2690_2726(inits))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10962, 2685, 2983);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 2760, 2826);

                    f_10962_2760_2825(this, arrayType, inits, includeConstants);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10962, 2685, 2983);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10962, 2685, 2983);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 2892, 2968);

                    f_10962_2892_2967(this, arrayType, inits, includeConstants);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10962, 2685, 2983);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10962, 2445, 2994);

                bool
                f_10962_2690_2726(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                inits)
                {
                    var return_v = IsMultidimensionalInitializer(inits);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10962, 2690, 2726);
                    return return_v;
                }


                int
                f_10962_2760_2825(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                arrayType, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                inits, bool
                includeConstants)
                {
                    this_param.EmitVectorElementInitializers(arrayType, inits, includeConstants);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10962, 2760, 2825);
                    return 0;
                }


                int
                f_10962_2892_2967(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                arrayType, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                inits, bool
                includeConstants)
                {
                    this_param.EmitMultidimensionalElementInitializers(arrayType, inits, includeConstants);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10962, 2892, 2967);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10962, 2445, 2994);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10962, 2445, 2994);
            }
        }

        private void EmitVectorElementInitializers(ArrayTypeSymbol arrayType,
                            ImmutableArray<BoundExpression> inits,
                            bool includeConstants)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10962, 3006, 3654);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 3213, 3218);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 3204, 3643) || true) && (i < inits.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 3238, 3241)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10962, 3204, 3643))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10962, 3204, 3643);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 3275, 3295);

                        var
                        init = inits[i]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 3313, 3628) || true) && (f_10962_3317_3365(includeConstants, init))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10962, 3313, 3628);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 3407, 3441);

                            f_10962_3407_3440(_builder, ILOpCode.Dup);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 3463, 3491);

                            f_10962_3463_3490(_builder, i);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 3513, 3540);

                            f_10962_3513_3539(this, init, true);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 3562, 3609);

                            f_10962_3562_3608(this, arrayType, init.Syntax);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10962, 3313, 3628);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10962, 1, 440);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10962, 1, 440);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10962, 3006, 3654);

                bool
                f_10962_3317_3365(bool
                includeConstants, Microsoft.CodeAnalysis.CSharp.BoundExpression
                init)
                {
                    var return_v = ShouldEmitInitExpression(includeConstants, init);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10962, 3317, 3365);
                    return return_v;
                }


                int
                f_10962_3407_3440(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10962, 3407, 3440);
                    return 0;
                }


                int
                f_10962_3463_3490(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, int
                value)
                {
                    this_param.EmitIntConstant(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10962, 3463, 3490);
                    return 0;
                }


                int
                f_10962_3513_3539(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitExpression(expression, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10962, 3513, 3539);
                    return 0;
                }


                int
                f_10962_3562_3608(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                arrayType, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitVectorElementStore(arrayType, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10962, 3562, 3608);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10962, 3006, 3654);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10962, 3006, 3654);
            }
        }

        private static bool ShouldEmitInitExpression(bool includeConstants, BoundExpression init)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10962, 3944, 4226);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 4058, 4145) || true) && (f_10962_4062_4083(init))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10962, 4058, 4145);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 4117, 4130);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10962, 4058, 4145);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 4161, 4215);

                return includeConstants || (DynAbs.Tracing.TraceSender.Expression_False(10962, 4168, 4214) || f_10962_4188_4206(init) == null);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10962, 3944, 4226);

                bool
                f_10962_4062_4083(Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = node.IsDefaultValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10962, 4062, 4083);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10962_4188_4206(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10962, 4188, 4206);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10962, 3944, 4226);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10962, 3944, 4226);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private struct IndexDesc
        {

            public IndexDesc(int index, ImmutableArray<BoundExpression> initializers)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10962, 4807, 4998);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 4913, 4932);

                    this.Index = index;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 4950, 4983);

                    this.Initializers = initializers;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10962, 4807, 4998);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10962, 4807, 4998);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10962, 4807, 4998);
                }
            }

            public readonly int Index;

            public readonly ImmutableArray<BoundExpression> Initializers;
            static IndexDesc()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10962, 4758, 5126);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10962, 4758, 5126);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10962, 4758, 5126);
            }
        }

        private void EmitMultidimensionalElementInitializers(ArrayTypeSymbol arrayType,
                                                                    ImmutableArray<BoundExpression> inits,
                                                                    bool includeConstants)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10962, 5138, 6133);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 5685, 5729);

                var
                indices = f_10962_5699_5728()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 5826, 5831);

                    // emit initializers for all values of the leftmost index.
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 5817, 6077) || true) && (i < inits.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 5851, 5854)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10962, 5817, 6077))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10962, 5817, 6077);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 5888, 5970);

                        indices.Push(f_10962_5901_5968(i, f_10962_5918_5967(((BoundArrayInitialization)inits[i]))));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 5988, 6062);

                        f_10962_5988_6061(this, arrayType, indices, includeConstants);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10962, 1, 261);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10962, 1, 261);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 6093, 6122);

                f_10962_6093_6121(!f_10962_6107_6120(indices));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10962, 5138, 6133);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator.IndexDesc>
                f_10962_5699_5728()
                {
                    var return_v = new Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator.IndexDesc>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10962, 5699, 5728);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10962_5918_5967(Microsoft.CodeAnalysis.CSharp.BoundArrayInitialization
                this_param)
                {
                    var return_v = this_param.Initializers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10962, 5918, 5967);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator.IndexDesc
                f_10962_5901_5968(int
                index, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                initializers)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator.IndexDesc(index, initializers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10962, 5901, 5968);
                    return return_v;
                }


                int
                f_10962_5988_6061(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                arrayType, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator.IndexDesc>
                indices, bool
                includeConstants)
                {
                    this_param.EmitAllElementInitializersRecursive(arrayType, indices, includeConstants);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10962, 5988, 6061);
                    return 0;
                }


                bool
                f_10962_6107_6120(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator.IndexDesc>
                this_param)
                {
                    var return_v = this_param.Any();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10962, 6107, 6120);
                    return return_v;
                }


                int
                f_10962_6093_6121(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10962, 6093, 6121);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10962, 5138, 6133);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10962, 5138, 6133);
            }
        }

        private void EmitAllElementInitializersRecursive(ArrayTypeSymbol arrayType,
                                                                 ArrayBuilder<IndexDesc> indices,
                                                                 bool includeConstants)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10962, 6778, 8676);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 7050, 7075);

                var
                top = f_10962_7060_7074(indices)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 7089, 7118);

                var
                inits = top.Initializers
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 7134, 8635) || true) && (f_10962_7138_7174(inits))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10962, 7134, 8635);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 7300, 7305);
                        // emit initializers for the less significant indices recursively
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 7291, 7567) || true) && (i < inits.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 7325, 7328)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10962, 7291, 7567))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10962, 7291, 7567);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 7370, 7452);

                            indices.Push(f_10962_7383_7450(i, f_10962_7400_7449(((BoundArrayInitialization)inits[i]))));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 7474, 7548);

                            f_10962_7474_7547(this, arrayType, indices, includeConstants);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10962, 1, 277);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10962, 1, 277);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10962, 7134, 8635);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10962, 7134, 8635);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 7672, 7677);
                        // leaf case
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 7663, 8620) || true) && (i < inits.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 7697, 7700)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10962, 7663, 8620))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10962, 7663, 8620);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 7742, 7762);

                            var
                            init = inits[i]
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 7784, 8601) || true) && (f_10962_7788_7836(includeConstants, init))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10962, 7784, 8601);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 7929, 7963);

                                f_10962_7929_7962(                        // emit array ref
                                                        _builder, ILOpCode.Dup);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 7991, 8041);

                                f_10962_7991_8040(f_10962_8004_8017(indices) == f_10962_8021_8035(arrayType) - 1);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 8145, 8293);
                                    foreach (var row in f_10962_8165_8172_I(indices))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10962, 8145, 8293);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 8230, 8266);

                                        f_10962_8230_8265(_builder, row.Index);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10962, 8145, 8293);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10962, 1, 149);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(10962, 1, 149);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 8369, 8397);

                                f_10962_8369_8396(
                                                        // emit the leaf index
                                                        _builder, i);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 8425, 8449);

                                var
                                initExpr = inits[i]
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 8475, 8506);

                                f_10962_8475_8505(this, initExpr, true);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 8532, 8578);

                                f_10962_8532_8577(this, arrayType, init.Syntax);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10962, 7784, 8601);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10962, 1, 958);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10962, 1, 958);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10962, 7134, 8635);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 8651, 8665);

                f_10962_8651_8664(
                            indices);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10962, 6778, 8676);

                Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator.IndexDesc
                f_10962_7060_7074(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator.IndexDesc>
                builder)
                {
                    var return_v = builder.Peek<Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator.IndexDesc>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10962, 7060, 7074);
                    return return_v;
                }


                bool
                f_10962_7138_7174(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                inits)
                {
                    var return_v = IsMultidimensionalInitializer(inits);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10962, 7138, 7174);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10962_7400_7449(Microsoft.CodeAnalysis.CSharp.BoundArrayInitialization
                this_param)
                {
                    var return_v = this_param.Initializers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10962, 7400, 7449);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator.IndexDesc
                f_10962_7383_7450(int
                index, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                initializers)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator.IndexDesc(index, initializers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10962, 7383, 7450);
                    return return_v;
                }


                int
                f_10962_7474_7547(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                arrayType, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator.IndexDesc>
                indices, bool
                includeConstants)
                {
                    this_param.EmitAllElementInitializersRecursive(arrayType, indices, includeConstants);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10962, 7474, 7547);
                    return 0;
                }


                bool
                f_10962_7788_7836(bool
                includeConstants, Microsoft.CodeAnalysis.CSharp.BoundExpression
                init)
                {
                    var return_v = ShouldEmitInitExpression(includeConstants, init);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10962, 7788, 7836);
                    return return_v;
                }


                int
                f_10962_7929_7962(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10962, 7929, 7962);
                    return 0;
                }


                int
                f_10962_8004_8017(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator.IndexDesc>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10962, 8004, 8017);
                    return return_v;
                }


                int
                f_10962_8021_8035(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.Rank;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10962, 8021, 8035);
                    return return_v;
                }


                int
                f_10962_7991_8040(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10962, 7991, 8040);
                    return 0;
                }


                int
                f_10962_8230_8265(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, int
                value)
                {
                    this_param.EmitIntConstant(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10962, 8230, 8265);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator.IndexDesc>
                f_10962_8165_8172_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator.IndexDesc>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10962, 8165, 8172);
                    return return_v;
                }


                int
                f_10962_8369_8396(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, int
                value)
                {
                    this_param.EmitIntConstant(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10962, 8369, 8396);
                    return 0;
                }


                int
                f_10962_8475_8505(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitExpression(expression, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10962, 8475, 8505);
                    return 0;
                }


                int
                f_10962_8532_8577(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                arrayType, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitArrayElementStore(arrayType, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10962, 8532, 8577);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator.IndexDesc
                f_10962_8651_8664(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator.IndexDesc>
                builder)
                {
                    var return_v = builder.Pop<Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator.IndexDesc>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10962, 8651, 8664);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10962, 6778, 8676);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10962, 6778, 8676);
            }
        }

        private static ConstantValue AsConstOrDefault(BoundExpression init)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10962, 8688, 9104);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 8780, 8836);

                ConstantValue
                initConstantValueOpt = f_10962_8817_8835(init)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 8852, 8961) || true) && (initConstantValueOpt != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10962, 8852, 8961);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 8918, 8946);

                    return initConstantValueOpt;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10962, 8852, 8961);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 8977, 9032);

                TypeSymbol
                type = f_10962_8995_9031(f_10962_8995_9004(init))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 9046, 9093);

                return f_10962_9053_9092(f_10962_9075_9091(type));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10962, 8688, 9104);

                Microsoft.CodeAnalysis.ConstantValue?
                f_10962_8817_8835(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10962, 8817, 8835);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10962_8995_9004(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10962, 8995, 9004);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10962_8995_9031(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = type.EnumUnderlyingTypeOrSelf();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10962, 8995, 9031);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10962_9075_9091(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10962, 9075, 9091);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10962_9053_9092(Microsoft.CodeAnalysis.SpecialType
                st)
                {
                    var return_v = ConstantValue.Default(st);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10962, 9053, 9092);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10962, 8688, 9104);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10962, 8688, 9104);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ArrayInitializerStyle ShouldEmitBlockInitializer(TypeSymbol elementType, ImmutableArray<BoundExpression> inits)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10962, 9116, 10636);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 9260, 9383) || true) && (f_10962_9264_9297_M(!_module.SupportsPrivateImplClass))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10962, 9260, 9383);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 9331, 9368);

                    return ArrayInitializerStyle.Element;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10962, 9260, 9383);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 9399, 9704) || true) && (f_10962_9403_9427(elementType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10962, 9399, 9704);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 9461, 9618) || true) && (f_10962_9465_9520_M(!_module.Compilation.EnableEnumArrayBlockInitialization))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10962, 9461, 9618);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 9562, 9599);

                        return ArrayInitializerStyle.Element;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10962, 9461, 9618);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 9636, 9689);

                    elementType = f_10962_9650_9688(elementType);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10962, 9399, 9704);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 9720, 10572) || true) && (f_10962_9724_9761(f_10962_9724_9747(elementType)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10962, 9720, 10572);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 9795, 9933) || true) && (f_10962_9799_9827(_module) == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10962, 9795, 9933);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 9877, 9914);

                        return ArrayInitializerStyle.Element;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10962, 9795, 9933);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 9953, 9971);

                    int
                    initCount = 0
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 9989, 10008);

                    int
                    constCount = 0
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 10026, 10090);

                    f_10962_10026_10089(this, inits, ref initCount, ref constCount);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 10110, 10557) || true) && (initCount > 2)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10962, 10110, 10557);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 10169, 10304) || true) && (initCount == constCount)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10962, 10169, 10304);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 10246, 10281);

                            return ArrayInitializerStyle.Block;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10962, 10169, 10304);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 10328, 10376);

                        int
                        thresholdCnt = f_10962_10347_10375(3, (initCount / 3))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 10400, 10538) || true) && (constCount >= thresholdCnt)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10962, 10400, 10538);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 10480, 10515);

                            return ArrayInitializerStyle.Mixed;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10962, 10400, 10538);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10962, 10110, 10557);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10962, 9720, 10572);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 10588, 10625);

                return ArrayInitializerStyle.Element;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10962, 9116, 10636);

                bool
                f_10962_9264_9297_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10962, 9264, 9297);
                    return return_v;
                }


                bool
                f_10962_9403_9427(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsEnumType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10962, 9403, 9427);
                    return return_v;
                }


                bool
                f_10962_9465_9520_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10962, 9465, 9520);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10962_9650_9688(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.EnumUnderlyingTypeOrSelf();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10962, 9650, 9688);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10962_9724_9747(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10962, 9724, 9747);
                    return return_v;
                }


                bool
                f_10962_9724_9761(Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = specialType.IsBlittable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10962, 9724, 9761);
                    return return_v;
                }


                Microsoft.Cci.IMethodReference
                f_10962_9799_9827(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param)
                {
                    var return_v = this_param.GetInitArrayHelper();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10962, 9799, 9827);
                    return return_v;
                }


                int
                f_10962_10026_10089(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                inits, ref int
                initCount, ref int
                constInits)
                {
                    this_param.InitializerCountRecursive(inits, ref initCount, ref constInits);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10962, 10026, 10089);
                    return 0;
                }


                int
                f_10962_10347_10375(int
                val1, int
                val2)
                {
                    var return_v = Math.Max(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10962, 10347, 10375);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10962, 9116, 10636);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10962, 9116, 10636);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void InitializerCountRecursive(ImmutableArray<BoundExpression> inits, ref int initCount, ref int constInits)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10962, 10784, 11838);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 10925, 11002) || true) && (inits.Length == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10962, 10925, 11002);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 10980, 10987);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10962, 10925, 11002);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 11018, 11827);
                    foreach (var init in f_10962_11039_11044_I(inits))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10962, 11018, 11827);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 11078, 11129);

                        var
                        asArrayInit = init as BoundArrayInitialization
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 11149, 11812) || true) && (asArrayInit != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10962, 11149, 11812);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 11214, 11297);

                            f_10962_11214_11296(this, f_10962_11240_11264(asArrayInit), ref initCount, ref constInits);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10962, 11149, 11812);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10962, 11149, 11812);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 11522, 11793) || true) && (!f_10962_11527_11548(init))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10962, 11522, 11793);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 11598, 11613);

                                initCount += 1;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 11639, 11770) || true) && (f_10962_11643_11661(init) != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10962, 11639, 11770);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 11727, 11743);

                                    constInits += 1;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10962, 11639, 11770);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10962, 11522, 11793);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10962, 11149, 11812);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10962, 11018, 11827);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10962, 1, 810);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10962, 1, 810);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10962, 10784, 11838);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10962_11240_11264(Microsoft.CodeAnalysis.CSharp.BoundArrayInitialization
                this_param)
                {
                    var return_v = this_param.Initializers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10962, 11240, 11264);
                    return return_v;
                }


                int
                f_10962_11214_11296(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                inits, ref int
                initCount, ref int
                constInits)
                {
                    this_param.InitializerCountRecursive(inits, ref initCount, ref constInits);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10962, 11214, 11296);
                    return 0;
                }


                bool
                f_10962_11527_11548(Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = node.IsDefaultValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10962, 11527, 11548);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10962_11643_11661(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10962, 11643, 11661);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10962_11039_11044_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10962, 11039, 11044);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10962, 10784, 11838);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10962, 10784, 11838);
            }
        }

        private ImmutableArray<byte> GetRawData(ImmutableArray<BoundExpression> initializers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10962, 12053, 12534);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 12358, 12412);

                var
                writer = f_10962_12371_12411(initializers.Length * 4)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 12428, 12474);

                f_10962_12428_12473(this, writer, initializers);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 12490, 12523);

                return f_10962_12497_12522(writer);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10962, 12053, 12534);

                System.Reflection.Metadata.BlobBuilder
                f_10962_12371_12411(int
                capacity)
                {
                    var return_v = new System.Reflection.Metadata.BlobBuilder(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10962, 12371, 12411);
                    return return_v;
                }


                int
                f_10962_12428_12473(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, System.Reflection.Metadata.BlobBuilder
                bw, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                inits)
                {
                    this_param.SerializeArrayRecursive(bw, inits);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10962, 12428, 12473);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_10962_12497_12522(System.Reflection.Metadata.BlobBuilder
                this_param)
                {
                    var return_v = this_param.ToImmutableArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10962, 12497, 12522);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10962, 12053, 12534);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10962, 12053, 12534);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void SerializeArrayRecursive(BlobBuilder bw, ImmutableArray<BoundExpression> inits)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10962, 12546, 13246);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 12662, 13235) || true) && (inits.Length != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10962, 12662, 13235);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 12717, 13220) || true) && (f_10962_12721_12734(inits[0]) == BoundKind.ArrayInitialization)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10962, 12717, 13220);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 12809, 12983);
                            foreach (var init in f_10962_12830_12835_I(inits))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10962, 12809, 12983);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 12885, 12960);

                                f_10962_12885_12959(this, bw, f_10962_12913_12958(((BoundArrayInitialization)init)));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10962, 12809, 12983);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10962, 1, 175);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10962, 1, 175);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10962, 12717, 13220);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10962, 12717, 13220);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 13065, 13201);
                            foreach (var init in f_10962_13086_13091_I(inits))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10962, 13065, 13201);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 13141, 13178);

                                f_10962_13141_13177(f_10962_13141_13163(init), bw);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10962, 13065, 13201);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10962, 1, 137);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10962, 1, 137);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10962, 12717, 13220);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10962, 12662, 13235);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10962, 12546, 13246);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10962_12721_12734(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10962, 12721, 12734);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10962_12913_12958(Microsoft.CodeAnalysis.CSharp.BoundArrayInitialization
                this_param)
                {
                    var return_v = this_param.Initializers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10962, 12913, 12958);
                    return return_v;
                }


                int
                f_10962_12885_12959(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, System.Reflection.Metadata.BlobBuilder
                bw, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                inits)
                {
                    this_param.SerializeArrayRecursive(bw, inits);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10962, 12885, 12959);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10962_12830_12835_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10962, 12830, 12835);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10962_13141_13163(Microsoft.CodeAnalysis.CSharp.BoundExpression
                init)
                {
                    var return_v = AsConstOrDefault(init);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10962, 13141, 13163);
                    return return_v;
                }


                int
                f_10962_13141_13177(Microsoft.CodeAnalysis.ConstantValue
                this_param, System.Reflection.Metadata.BlobBuilder
                writer)
                {
                    this_param.Serialize(writer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10962, 13141, 13177);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10962_13086_13091_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10962, 13086, 13091);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10962, 12546, 13246);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10962, 12546, 13246);
            }
        }

        private static bool IsMultidimensionalInitializer(ImmutableArray<BoundExpression> inits)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10962, 13403, 13847);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 13516, 13745);

                f_10962_13516_13744(inits.All((init) => init.Kind != BoundKind.ArrayInitialization) || (DynAbs.Tracing.TraceSender.Expression_False(10962, 13529, 13685) || inits.All((init) => init.Kind == BoundKind.ArrayInitialization)), "all or none should be nested");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 13761, 13836);

                return inits.Length != 0 && (DynAbs.Tracing.TraceSender.Expression_True(10962, 13768, 13835) && f_10962_13789_13802(inits[0]) == BoundKind.ArrayInitialization);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10962, 13403, 13847);

                int
                f_10962_13516_13744(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10962, 13516, 13744);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10962_13789_13802(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10962, 13789, 13802);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10962, 13403, 13847);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10962, 13403, 13847);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool TryEmitReadonlySpanAsBlobWrapper(NamedTypeSymbol spanType, BoundExpression wrappedExpression, bool used, bool inPlace)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10962, 13859, 16978);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 14015, 14051);

                ImmutableArray<byte>
                data = default
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 14065, 14087);

                int
                elementCount = -1
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 14101, 14131);

                TypeSymbol
                elementType = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 14147, 14246) || true) && (f_10962_14151_14184_M(!_module.SupportsPrivateImplClass))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10962, 14147, 14246);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 14218, 14231);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10962, 14147, 14246);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 14262, 14382);

                var
                ctor = ((MethodSymbol)f_10962_14288_14380(this._module.Compilation, WellKnownMember.System_ReadOnlySpan_T__ctor))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 14396, 14474) || true) && (ctor == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10962, 14396, 14474);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 14446, 14459);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10962, 14396, 14474);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 14490, 15406) || true) && (wrappedExpression is BoundArrayCreation ac)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10962, 14490, 15406);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 14570, 14611);

                    var
                    arrayType = (ArrayTypeSymbol)f_10962_14603_14610(ac)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 14629, 14692);

                    elementType = f_10962_14643_14691(f_10962_14643_14664(arrayType));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 15181, 15301) || true) && (f_10962_15185_15222(f_10962_15185_15208(elementType)) != 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10962, 15181, 15301);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 15269, 15282);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10962, 15181, 15301);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 15321, 15391);

                    elementCount = f_10962_15336_15390(this, f_10962_15362_15379(ac), out data);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10962, 14490, 15406);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 15422, 15504) || true) && (elementCount < 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10962, 15422, 15504);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 15476, 15489);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10962, 15422, 15504);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 15520, 15660) || true) && (!inPlace && (DynAbs.Tracing.TraceSender.Expression_True(10962, 15524, 15541) && !used))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10962, 15520, 15660);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 15633, 15645);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10962, 15520, 15660);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 15676, 16939) || true) && (elementCount == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10962, 15676, 16939);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 15731, 16056) || true) && (inPlace)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10962, 15731, 16056);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 15784, 15822);

                        f_10962_15784_15821(_builder, ILOpCode.Initobj);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 15844, 15896);

                        f_10962_15844_15895(this, spanType, wrappedExpression.Syntax);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10962, 15731, 16056);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10962, 15731, 16056);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 15978, 16037);

                        f_10962_15978_16036(this, spanType, used, wrappedExpression.Syntax);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10962, 15731, 16056);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10962, 15676, 16939);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10962, 15676, 16939);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 16122, 16225) || true) && (f_10962_16126_16151(this))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10962, 16122, 16225);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 16193, 16206);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10962, 16122, 16225);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 16245, 16323);

                    f_10962_16245_16322(
                                    _builder, data, wrappedExpression.Syntax, _diagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 16341, 16380);

                    f_10962_16341_16379(_builder, elementCount);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 16400, 16819) || true) && (inPlace)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10962, 16400, 16819);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 16532, 16588);

                        f_10962_16532_16587(                    // consumes target ref, data ptr and size, pushes nothing
                                            _builder, ILOpCode.Call, stackAdjustment: -3);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10962, 16400, 16819);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10962, 16400, 16819);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 16742, 16800);

                        f_10962_16742_16799(                    // consumes data ptr and size, pushes the instance
                                            _builder, ILOpCode.Newobj, stackAdjustment: -1);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10962, 16400, 16819);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 16839, 16924);

                    f_10962_16839_16923(this, f_10962_16855_16878(ctor, spanType), wrappedExpression.Syntax, optArgList: null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10962, 15676, 16939);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 16955, 16967);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10962, 13859, 16978);

                bool
                f_10962_14151_14184_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10962, 14151, 14184);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10962_14288_14380(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                member)
                {
                    var return_v = this_param.GetWellKnownTypeMember(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10962, 14288, 14380);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10962_14603_14610(Microsoft.CodeAnalysis.CSharp.BoundArrayCreation
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10962, 14603, 14610);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10962_14643_14664(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.ElementType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10962, 14643, 14664);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10962_14643_14691(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.EnumUnderlyingTypeOrSelf();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10962, 14643, 14691);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10962_15185_15208(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10962, 15185, 15208);
                    return return_v;
                }


                int
                f_10962_15185_15222(Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = specialType.SizeInBytes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10962, 15185, 15222);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundArrayInitialization?
                f_10962_15362_15379(Microsoft.CodeAnalysis.CSharp.BoundArrayCreation
                this_param)
                {
                    var return_v = this_param.InitializerOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10962, 15362, 15379);
                    return return_v;
                }


                int
                f_10962_15336_15390(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundArrayInitialization?
                initializer, out System.Collections.Immutable.ImmutableArray<byte>
                data)
                {
                    var return_v = this_param.TryGetRawDataForArrayInit(initializer, out data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10962, 15336, 15390);
                    return return_v;
                }


                int
                f_10962_15784_15821(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10962, 15784, 15821);
                    return 0;
                }


                int
                f_10962_15844_15895(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitSymbolToken((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)symbol, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10962, 15844, 15895);
                    return 0;
                }


                int
                f_10962_15978_16036(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, bool
                used, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitDefaultValue((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, used, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10962, 15978, 16036);
                    return 0;
                }


                bool
                f_10962_16126_16151(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param)
                {
                    var return_v = this_param.IsPeVerifyCompatEnabled();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10962, 16126, 16151);
                    return return_v;
                }


                int
                f_10962_16245_16322(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Collections.Immutable.ImmutableArray<byte>
                data, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.EmitArrayBlockFieldRef(data, syntaxNode, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10962, 16245, 16322);
                    return 0;
                }


                int
                f_10962_16341_16379(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, int
                value)
                {
                    this_param.EmitIntConstant(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10962, 16341, 16379);
                    return 0;
                }


                int
                f_10962_16532_16587(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code, int
                stackAdjustment)
                {
                    this_param.EmitOpCode(code, stackAdjustment: stackAdjustment);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10962, 16532, 16587);
                    return 0;
                }


                int
                f_10962_16742_16799(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code, int
                stackAdjustment)
                {
                    this_param.EmitOpCode(code, stackAdjustment: stackAdjustment);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10962, 16742, 16799);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10962_16855_16878(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                newOwner)
                {
                    var return_v = this_param.AsMember(newOwner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10962, 16855, 16878);
                    return return_v;
                }


                int
                f_10962_16839_16923(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode, Microsoft.CodeAnalysis.CSharp.BoundArgListOperator
                optArgList)
                {
                    this_param.EmitSymbolToken(method, syntaxNode, optArgList: optArgList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10962, 16839, 16923);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10962, 13859, 16978);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10962, 13859, 16978);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private int TryGetRawDataForArrayInit(BoundArrayInitialization initializer, out ImmutableArray<byte> data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10962, 17216, 18160);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 17347, 17362);

                data = default;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 17378, 17460) || true) && (initializer == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10962, 17378, 17460);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 17435, 17445);

                    return -1;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10962, 17378, 17460);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 17476, 17520);

                var
                initializers = f_10962_17495_17519(initializer)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 17534, 17649) || true) && (initializers.Any(init => init.ConstantValue == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10962, 17534, 17649);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 17624, 17634);

                    return -1;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10962, 17534, 17649);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 17665, 17704);

                var
                elementCount = initializers.Length
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 17718, 17849) || true) && (elementCount == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10962, 17718, 17849);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 17773, 17807);

                    data = ImmutableArray<byte>.Empty;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 17825, 17834);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10962, 17718, 17849);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 17865, 17919);

                var
                writer = f_10962_17878_17918(initializers.Length * 4)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 17935, 18066);
                    foreach (var init in f_10962_17956_17980_I(f_10962_17956_17980(initializer)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10962, 17935, 18066);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 18014, 18051);

                        f_10962_18014_18050(f_10962_18014_18032(init), writer);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10962, 17935, 18066);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10962, 1, 132);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10962, 1, 132);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 18082, 18115);

                data = f_10962_18089_18114(writer);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10962, 18129, 18149);

                return elementCount;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10962, 17216, 18160);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10962_17495_17519(Microsoft.CodeAnalysis.CSharp.BoundArrayInitialization
                this_param)
                {
                    var return_v = this_param.Initializers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10962, 17495, 17519);
                    return return_v;
                }


                System.Reflection.Metadata.BlobBuilder
                f_10962_17878_17918(int
                capacity)
                {
                    var return_v = new System.Reflection.Metadata.BlobBuilder(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10962, 17878, 17918);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10962_17956_17980(Microsoft.CodeAnalysis.CSharp.BoundArrayInitialization
                this_param)
                {
                    var return_v = this_param.Initializers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10962, 17956, 17980);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10962_18014_18032(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10962, 18014, 18032);
                    return return_v;
                }


                int
                f_10962_18014_18050(Microsoft.CodeAnalysis.ConstantValue?
                this_param, System.Reflection.Metadata.BlobBuilder
                writer)
                {
                    this_param.Serialize(writer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10962, 18014, 18050);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10962_17956_17980_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10962, 17956, 17980);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_10962_18089_18114(System.Reflection.Metadata.BlobBuilder
                this_param)
                {
                    var return_v = this_param.ToImmutableArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10962, 18089, 18114);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10962, 17216, 18160);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10962, 17216, 18160);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
