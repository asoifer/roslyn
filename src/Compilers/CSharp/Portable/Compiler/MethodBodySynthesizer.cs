// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.RuntimeMembers;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal static class MethodBodySynthesizer
    {
        internal static ImmutableArray<BoundStatement> ConstructScriptConstructorBody(
                    BoundStatement loweredBody,
                    MethodSymbol constructor,
                    SynthesizedSubmissionFields previousSubmissionFields,
                    CSharpCompilation compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10624, 796, 3612);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 1631, 1670);

                SyntaxNode
                syntax = loweredBody.Syntax
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 1725, 1911);

                f_10624_1725_1910((object)f_10624_1746_1801(f_10624_1746_1772(constructor)) == null || (DynAbs.Tracing.TraceSender.Expression_False(10624, 1738, 1909) || f_10624_1813_1880(f_10624_1813_1868(f_10624_1813_1839(constructor))) == SpecialType.System_Object));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 1925, 2015);

                var
                objectType = f_10624_1942_2014(f_10624_1942_1972(constructor), SpecialType.System_Object)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 2031, 2149);

                BoundExpression
                receiver = new BoundThisReference(syntax, f_10624_2089_2115(constructor)) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10624, 2058, 2148) }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 2165, 3126);

                BoundStatement
                baseConstructorCall =
                                new BoundExpressionStatement(syntax,
                                    new BoundCall(syntax,
                                        receiverOpt: receiver,
                                        method: f_10624_2380_2411(objectType)[0],
                                        arguments: ImmutableArray<BoundExpression>.Empty,
                                        argumentNamesOpt: ImmutableArray<string>.Empty,
                                        argumentRefKindsOpt: ImmutableArray<RefKind>.Empty,
                                        isDelegateCall: false,
                                        expanded: false,
                                        invokedAsExtensionMethod: false,
                                        argsToParamsOpt: ImmutableArray<int>.Empty,
                                        defaultArguments: BitVector.Empty,
                                        resultKind: LookupResultKind.Viable,
                                        type: objectType)
                                    { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10624, 2277, 3075) })
                                { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10624, 2219, 3125) }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 3142, 3202);

                var
                statements = f_10624_3159_3201()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 3216, 3252);

                f_10624_3216_3251(statements, baseConstructorCall);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 3268, 3504) || true) && (f_10624_3272_3307(constructor))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10624, 3268, 3504);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 3388, 3489);

                    f_10624_3388_3488(statements, syntax, constructor, previousSubmissionFields, compilation);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10624, 3268, 3504);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 3520, 3548);

                f_10624_3520_3547(
                            statements, loweredBody);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 3562, 3601);

                return f_10624_3569_3600(statements);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10624, 796, 3612);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10624_1746_1772(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10624, 1746, 1772);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10624_1746_1801(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10624, 1746, 1801);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10624_1813_1839(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10624, 1813, 1839);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10624_1813_1868(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10624, 1813, 1868);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10624_1813_1880(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10624, 1813, 1880);
                    return return_v;
                }


                int
                f_10624_1725_1910(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 1725, 1910);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10624_1942_1972(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10624, 1942, 1972);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10624_1942_2014(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, Microsoft.CodeAnalysis.SpecialType
                type)
                {
                    var return_v = this_param.GetSpecialType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 1942, 2014);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10624_2089_2115(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10624, 2089, 2115);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10624_2380_2411(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.InstanceConstructors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10624, 2380, 2411);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10624_3159_3201()
                {
                    var return_v = ArrayBuilder<BoundStatement>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 3159, 3201);
                    return return_v;
                }


                int
                f_10624_3216_3251(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 3216, 3251);
                    return 0;
                }


                bool
                f_10624_3272_3307(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsSubmissionConstructor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10624, 3272, 3307);
                    return return_v;
                }


                int
                f_10624_3388_3488(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                submissionConstructor, Microsoft.CodeAnalysis.CSharp.SynthesizedSubmissionFields
                synthesizedFields, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    MakeSubmissionInitialization(statements, syntax, submissionConstructor, synthesizedFields, compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 3388, 3488);
                    return 0;
                }


                int
                f_10624_3520_3547(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 3520, 3547);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10624_3569_3600(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 3569, 3600);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10624, 796, 3612);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10624, 796, 3612);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void MakeSubmissionInitialization(
                    ArrayBuilder<BoundStatement> statements,
                    SyntaxNode syntax,
                    MethodSymbol submissionConstructor,
                    SynthesizedSubmissionFields synthesizedFields,
                    CSharpCompilation compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10624, 4358, 9297);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 4671, 4727);

                f_10624_4671_4726(f_10624_4684_4720(submissionConstructor) == 1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 4743, 4870);

                var
                submissionArrayReference = new BoundParameter(syntax, f_10624_4801_4833(submissionConstructor)[0]) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10624, 4774, 4869) }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 4886, 4953);

                var
                intType = f_10624_4900_4952(compilation, SpecialType.System_Int32)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 4967, 5038);

                var
                objectType = f_10624_4984_5037(compilation, SpecialType.System_Object)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 5052, 5173);

                var
                thisReference = new BoundThisReference(syntax, f_10624_5103_5139(submissionConstructor)) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10624, 5072, 5172) }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 5189, 5242);

                var
                slotIndex = f_10624_5205_5241(compilation)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 5256, 5285);

                f_10624_5256_5284(slotIndex >= 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 5357, 6020);

                f_10624_5357_6019(
                            // <submission_array>[<slot_index] = this;
                            statements, new BoundExpressionStatement(syntax,
                                new BoundAssignmentOperator(syntax,
                                    new BoundArrayAccess(syntax,
                                        submissionArrayReference,
                f_10624_5588_5726(new BoundLiteral(syntax, f_10624_5652_5683(slotIndex), intType) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10624, 5627, 5725) }),
                                        objectType)
                                    { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10624, 5483, 5817) },
                                    thisReference,
                                    false,
                f_10624_5904_5922(thisReference))
                                { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10624, 5426, 5972) })
                            { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10624, 5372, 6018) });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 6036, 6097);

                var
                hostObjectField = f_10624_6058_6096(synthesizedFields)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 6111, 7499) || true) && ((object)hostObjectField != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10624, 6111, 7499);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 6258, 7484);

                    f_10624_6258_7483(                // <host_object> = (<host_object_type>)<submission_array>[0]
                                    statements, new BoundExpressionStatement(syntax,
                                            new BoundAssignmentOperator(syntax,
                                                new BoundFieldAccess(syntax, thisReference, hostObjectField, ConstantValue.NotAvailable) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10624, 6422, 6542) },
                    f_10624_6573_7319(syntax, f_10624_6642_6951(syntax, submissionArrayReference, f_10624_6771_6901(new BoundLiteral(syntax, f_10624_6835_6858(0), intType) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10624, 6810, 6900) }), objectType), Conversion.ExplicitReference, false, explicitCastInCode: true, conversionGroupOpt: null, ConstantValue.NotAvailable, f_10624_7268_7288(hostObjectField)),
                    f_10624_7350_7370(hostObjectField))
                                            { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10624, 6357, 7428) })
                                    { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10624, 6295, 7482) });
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10624, 6111, 7499);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 7515, 9286);
                    foreach (var field in f_10624_7537_7567_I(f_10624_7537_7567(synthesizedFields)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10624, 7515, 9286);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 7601, 7660);

                        var
                        targetScriptType = (ImplicitNamedTypeSymbol)f_10624_7649_7659(field)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 7678, 7769);

                        var
                        targetSubmissionIndex = f_10624_7706_7768(f_10624_7706_7743(targetScriptType))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 7787, 7828);

                        f_10624_7787_7827(targetSubmissionIndex >= 0);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 7952, 9271);

                        f_10624_7952_9270(
                                        // this.<field> = (<target_script_type>)<submission_array>[<target_submission_index>];
                                        statements, new BoundExpressionStatement(syntax,
                                                new BoundAssignmentOperator(syntax,
                                                    new BoundFieldAccess(syntax, thisReference, field, ConstantValue.NotAvailable) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10624, 8116, 8226) },
                        f_10624_8257_9084(syntax, new BoundArrayAccess(syntax,
                                                            submissionArrayReference,
                        f_10624_8455_8605(new BoundLiteral(syntax, f_10624_8519_8562(targetSubmissionIndex), intType) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10624, 8494, 8604) }),
                                                            objectType)
                        { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10624, 8326, 8720) }, Conversion.ExplicitReference, false, explicitCastInCode: true, conversionGroupOpt: null, ConstantValue.NotAvailable, targetScriptType),
                                                    targetScriptType
                                                )
                                                { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10624, 8051, 9215) })
                                        { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10624, 7989, 9269) });
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10624, 7515, 9286);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10624, 1, 1772);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10624, 1, 1772);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10624, 4358, 9297);

                int
                f_10624_4684_4720(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10624, 4684, 4720);
                    return return_v;
                }


                int
                f_10624_4671_4726(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 4671, 4726);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10624_4801_4833(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10624, 4801, 4833);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10624_4900_4952(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 4900, 4952);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10624_4984_5037(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 4984, 5037);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10624_5103_5139(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10624, 5103, 5139);
                    return return_v;
                }


                int
                f_10624_5205_5241(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.GetSubmissionSlotIndex();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 5205, 5241);
                    return return_v;
                }


                int
                f_10624_5256_5284(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 5256, 5284);
                    return 0;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10624_5652_5683(int
                value)
                {
                    var return_v = ConstantValue.Create(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 5652, 5683);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10624_5588_5726(Microsoft.CodeAnalysis.CSharp.BoundLiteral
                item)
                {
                    var return_v = ImmutableArray.Create<BoundExpression>((Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 5588, 5726);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10624_5904_5922(Microsoft.CodeAnalysis.CSharp.BoundThisReference
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10624, 5904, 5922);
                    return return_v;
                }


                int
                f_10624_5357_6019(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 5357, 6019);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10624_6058_6096(Microsoft.CodeAnalysis.CSharp.SynthesizedSubmissionFields
                this_param)
                {
                    var return_v = this_param.GetHostObjectField();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 6058, 6096);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10624_6835_6858(int
                value)
                {
                    var return_v = ConstantValue.Create(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 6835, 6858);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10624_6771_6901(Microsoft.CodeAnalysis.CSharp.BoundLiteral
                item)
                {
                    var return_v = ImmutableArray.Create<BoundExpression>((Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 6771, 6901);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundArrayAccess
                f_10624_6642_6951(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundParameter
                expression, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                indices, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundArrayAccess(syntax, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expression, indices, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 6642, 6951);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10624_7268_7288(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.Type
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10624, 7268, 7288);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundConversion
                f_10624_6573_7319(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundArrayAccess
                operand, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, bool
                @checked, bool
                explicitCastInCode, Microsoft.CodeAnalysis.CSharp.ConversionGroup?
                conversionGroupOpt, Microsoft.CodeAnalysis.ConstantValue
                constantValueOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = BoundConversion.Synthesized(syntax, (Microsoft.CodeAnalysis.CSharp.BoundExpression)operand, conversion, @checked, explicitCastInCode: explicitCastInCode, conversionGroupOpt: conversionGroupOpt, constantValueOpt, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 6573, 7319);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10624_7350_7370(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10624, 7350, 7370);
                    return return_v;
                }


                int
                f_10624_6258_7483(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 6258, 7483);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                f_10624_7537_7567(Microsoft.CodeAnalysis.CSharp.SynthesizedSubmissionFields
                this_param)
                {
                    var return_v = this_param.FieldSymbols;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10624, 7537, 7567);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10624_7649_7659(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10624, 7649, 7659);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10624_7706_7743(Microsoft.CodeAnalysis.CSharp.Symbols.ImplicitNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10624, 7706, 7743);
                    return return_v;
                }


                int
                f_10624_7706_7768(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.GetSubmissionSlotIndex();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 7706, 7768);
                    return return_v;
                }


                int
                f_10624_7787_7827(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 7787, 7827);
                    return 0;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10624_8519_8562(int
                value)
                {
                    var return_v = ConstantValue.Create(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 8519, 8562);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10624_8455_8605(Microsoft.CodeAnalysis.CSharp.BoundLiteral
                item)
                {
                    var return_v = ImmutableArray.Create<BoundExpression>((Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 8455, 8605);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundConversion
                f_10624_8257_9084(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundArrayAccess
                operand, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, bool
                @checked, bool
                explicitCastInCode, Microsoft.CodeAnalysis.CSharp.ConversionGroup?
                conversionGroupOpt, Microsoft.CodeAnalysis.ConstantValue
                constantValueOpt, Microsoft.CodeAnalysis.CSharp.Symbols.ImplicitNamedTypeSymbol
                type)
                {
                    var return_v = BoundConversion.Synthesized(syntax, (Microsoft.CodeAnalysis.CSharp.BoundExpression)operand, conversion, @checked, explicitCastInCode: explicitCastInCode, conversionGroupOpt: conversionGroupOpt, constantValueOpt, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 8257, 9084);
                    return return_v;
                }


                int
                f_10624_7952_9270(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 7952, 9270);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                f_10624_7537_7567_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 7537, 7567);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10624, 4358, 9297);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10624, 4358, 9297);
            }
        }

        internal static BoundBlock ConstructAutoPropertyAccessorBody(SourceMemberMethodSymbol accessor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10624, 9459, 11238);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 9579, 9688);

                f_10624_9579_9687(f_10624_9592_9611(accessor) == MethodKind.PropertyGet || (DynAbs.Tracing.TraceSender.Expression_False(10624, 9592, 9686) || f_10624_9641_9660(accessor) == MethodKind.PropertySet));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 9704, 9771);

                var
                property = (SourcePropertySymbolBase)f_10624_9745_9770(accessor)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 9785, 9837);

                CSharpSyntaxNode
                syntax = f_10624_9811_9836(property)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 9851, 9888);

                BoundExpression
                thisReference = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 9902, 10127) || true) && (f_10624_9906_9924_M(!accessor.IsStatic))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10624, 9902, 10127);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 9958, 9998);

                    var
                    thisSymbol = f_10624_9975_9997(accessor)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 10016, 10112);

                    thisReference = new BoundThisReference(syntax, f_10624_10063_10078(thisSymbol)) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10624, 10032, 10111) };
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10624, 9902, 10127);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 10143, 10177);

                var
                field = f_10624_10155_10176(property)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 10191, 10320);

                var
                fieldAccess = new BoundFieldAccess(syntax, thisReference, field, ConstantValue.NotAvailable) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10624, 10209, 10319) }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 10334, 10359);

                BoundStatement
                statement
                = default(BoundStatement);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 10375, 11154) || true) && (f_10624_10379_10398(accessor) == MethodKind.PropertyGet)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10624, 10375, 11154);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 10458, 10543);

                    statement = f_10624_10470_10542(f_10624_10495_10514(accessor), RefKind.None, fieldAccess);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10624, 10375, 11154);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10624, 10375, 11154);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 10609, 10669);

                    f_10624_10609_10668(f_10624_10622_10641(accessor) == MethodKind.PropertySet);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 10687, 10726);

                    var
                    parameter = f_10624_10703_10722(accessor)[0]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 10744, 11139);

                    statement = f_10624_10756_11138(f_10624_10807_10826(accessor), new BoundAssignmentOperator(
                                            syntax,
                                            fieldAccess,
                                            new BoundParameter(syntax, parameter) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10624, 10974, 11043) },
                    f_10624_11070_11083(property))
                    { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10624, 10849, 11137) });
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10624, 10375, 11154);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 11170, 11227);

                return f_10624_11177_11226(syntax, statement);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10624, 9459, 11238);

                Microsoft.CodeAnalysis.MethodKind
                f_10624_9592_9611(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10624, 9592, 9611);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10624_9641_9660(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10624, 9641, 9660);
                    return return_v;
                }


                int
                f_10624_9579_9687(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 9579, 9687);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10624_9745_9770(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                this_param)
                {
                    var return_v = this_param.AssociatedSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10624, 9745, 9770);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10624_9811_9836(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                this_param)
                {
                    var return_v = this_param.CSharpSyntaxNode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10624, 9811, 9836);
                    return return_v;
                }


                bool
                f_10624_9906_9924_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10624, 9906, 9924);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10624_9975_9997(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                this_param)
                {
                    var return_v = this_param.ThisParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10624, 9975, 9997);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10624_10063_10078(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10624, 10063, 10078);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedBackingFieldSymbol
                f_10624_10155_10176(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                this_param)
                {
                    var return_v = this_param.BackingField;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10624, 10155, 10176);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10624_10379_10398(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10624, 10379, 10398);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10624_10495_10514(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                this_param)
                {
                    var return_v = this_param.SyntaxNode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10624, 10495, 10514);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                f_10624_10470_10542(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, Microsoft.CodeAnalysis.RefKind
                refKind, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                expressionOpt)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundReturnStatement((Microsoft.CodeAnalysis.SyntaxNode)syntax, refKind, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expressionOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 10470, 10542);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10624_10622_10641(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10624, 10622, 10641);
                    return return_v;
                }


                int
                f_10624_10609_10668(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 10609, 10668);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10624_10703_10722(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10624, 10703, 10722);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10624_10807_10826(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                this_param)
                {
                    var return_v = this_param.SyntaxNode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10624, 10807, 10826);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10624_11070_11083(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10624, 11070, 11083);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10624_10756_11138(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                expression)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement((Microsoft.CodeAnalysis.SyntaxNode)syntax, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 10756, 11138);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10624_11177_11226(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statement)
                {
                    var return_v = BoundBlock.SynthesizedNoLocals((Microsoft.CodeAnalysis.SyntaxNode)syntax, statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 11177, 11226);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10624, 9459, 11238);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10624, 9459, 11238);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static BoundBlock ConstructFieldLikeEventAccessorBody(SourceEventSymbol eventSymbol, bool isAddMethod, CSharpCompilation compilation, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10624, 11355, 11888);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 11549, 11594);

                f_10624_11549_11593(f_10624_11562_11592(eventSymbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 11608, 11877);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10624, 11615, 11648) || ((f_10624_11615_11648(eventSymbol) && DynAbs.Tracing.TraceSender.Conditional_F2(10624, 11668, 11761)) || DynAbs.Tracing.TraceSender.Conditional_F3(10624, 11781, 11876))) ? f_10624_11668_11761(eventSymbol, isAddMethod, compilation, diagnostics) : f_10624_11781_11876(eventSymbol, isAddMethod, compilation, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10624, 11355, 11888);

                bool
                f_10624_11562_11592(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                this_param)
                {
                    var return_v = this_param.HasAssociatedField;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10624, 11562, 11592);
                    return return_v;
                }


                int
                f_10624_11549_11593(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 11549, 11593);
                    return 0;
                }


                bool
                f_10624_11615_11648(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                this_param)
                {
                    var return_v = this_param.IsWindowsRuntimeEvent
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10624, 11615, 11648);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10624_11668_11761(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                eventSymbol, bool
                isAddMethod, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = ConstructFieldLikeEventAccessorBody_WinRT(eventSymbol, isAddMethod, compilation, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 11668, 11761);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10624_11781_11876(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                eventSymbol, bool
                isAddMethod, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = ConstructFieldLikeEventAccessorBody_Regular(eventSymbol, isAddMethod, compilation, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 11781, 11876);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10624, 11355, 11888);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10624, 11355, 11888);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static BoundBlock ConstructFieldLikeEventAccessorBody_WinRT(SourceEventSymbol eventSymbol, bool isAddMethod, CSharpCompilation compilation, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10624, 12369, 16664);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 12569, 12624);

                CSharpSyntaxNode
                syntax = f_10624_12595_12623(eventSymbol)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 12640, 12727);

                MethodSymbol
                accessor = (DynAbs.Tracing.TraceSender.Conditional_F1(10624, 12664, 12675) || ((isAddMethod && DynAbs.Tracing.TraceSender.Conditional_F2(10624, 12678, 12699)) || DynAbs.Tracing.TraceSender.Conditional_F3(10624, 12702, 12726))) ? f_10624_12678_12699(eventSymbol) : f_10624_12702_12726(eventSymbol)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 12741, 12780);

                f_10624_12741_12779((object)accessor != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 12796, 12844);

                FieldSymbol
                field = f_10624_12816_12843(eventSymbol)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 12858, 12894);

                f_10624_12858_12893((object)field != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 12910, 12966);

                NamedTypeSymbol
                fieldType = (NamedTypeSymbol)f_10624_12955_12965(field)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 12980, 13042);

                f_10624_12980_13041(f_10624_12993_13007(fieldType) == "EventRegistrationTokenTable");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 13058, 13379);

                MethodSymbol
                getOrCreateMethod = (MethodSymbol)f_10624_13105_13378(compilation, WellKnownMember.System_Runtime_InteropServices_WindowsRuntime_EventRegistrationTokenTable_T__GetOrCreateEventRegistrationTokenTable, diagnostics, syntax: syntax)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 13395, 13552) || true) && ((object)getOrCreateMethod == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10624, 13395, 13552);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 13466, 13507);

                    f_10624_13466_13506(f_10624_13479_13505(diagnostics));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 13525, 13537);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10624, 13395, 13552);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 13568, 13626);

                getOrCreateMethod = f_10624_13588_13625(getOrCreateMethod, fieldType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 13642, 13952);

                WellKnownMember
                processHandlerMember = (DynAbs.Tracing.TraceSender.Conditional_F1(10624, 13681, 13692) || ((isAddMethod
                && DynAbs.Tracing.TraceSender.Conditional_F2(10624, 13712, 13820)) || DynAbs.Tracing.TraceSender.Conditional_F3(10624, 13840, 13951))) ? WellKnownMember.System_Runtime_InteropServices_WindowsRuntime_EventRegistrationTokenTable_T__AddEventHandler
                : WellKnownMember.System_Runtime_InteropServices_WindowsRuntime_EventRegistrationTokenTable_T__RemoveEventHandler
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 13968, 14181);

                MethodSymbol
                processHandlerMethod = (MethodSymbol)f_10624_14018_14180(compilation, processHandlerMember, diagnostics, syntax: syntax)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 14197, 14357) || true) && ((object)processHandlerMethod == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10624, 14197, 14357);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 14271, 14312);

                    f_10624_14271_14311(f_10624_14284_14310(diagnostics));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 14330, 14342);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10624, 14197, 14357);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 14373, 14437);

                processHandlerMethod = f_10624_14396_14436(processHandlerMethod, fieldType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 14481, 14771);

                BoundFieldAccess
                fieldAccess = new BoundFieldAccess(
                                syntax,
                (DynAbs.Tracing.TraceSender.Conditional_F1(10624, 14576, 14590) || ((f_10624_14576_14590(field) && DynAbs.Tracing.TraceSender.Conditional_F2(10624, 14593, 14597)) || DynAbs.Tracing.TraceSender.Conditional_F3(10624, 14600, 14659))) ? null : f_10624_14600_14659(syntax, f_10624_14631_14658(f_10624_14631_14653(accessor))),
                                field,
                                constantValueOpt: null)
                { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10624, 14512, 14770) }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 14894, 15086);

                BoundCall
                getOrCreateCall = f_10624_14922_15085(syntax, receiverOpt: null, method: getOrCreateMethod, arg0: fieldAccess)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 15124, 15243);

                BoundParameter
                parameterAccess = f_10624_15157_15242(syntax, f_10624_15219_15238(accessor)[0])
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 15404, 15617);

                BoundCall
                processHandlerCall = f_10624_15435_15616(syntax, receiverOpt: getOrCreateCall, method: processHandlerMethod, arg0: parameterAccess)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 15633, 16653) || true) && (isAddMethod)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10624, 15633, 16653);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 15867, 15975);

                    BoundStatement
                    returnStatement = f_10624_15900_15974(syntax, RefKind.None, processHandlerCall)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 15993, 16056);

                    return f_10624_16000_16055(syntax, returnStatement);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10624, 15633, 16653);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10624, 15633, 16653);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 16335, 16423);

                    BoundStatement
                    callStatement = f_10624_16366_16422(syntax, processHandlerCall)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 16441, 16542);

                    BoundStatement
                    returnStatement = f_10624_16474_16541(syntax, RefKind.None, expressionOpt: null)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 16560, 16638);

                    return f_10624_16567_16637(syntax, callStatement, returnStatement);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10624, 15633, 16653);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10624, 12369, 16664);

                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10624_12595_12623(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                this_param)
                {
                    var return_v = this_param.CSharpSyntaxNode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10624, 12595, 12623);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10624_12678_12699(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                this_param)
                {
                    var return_v = this_param.AddMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10624, 12678, 12699);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10624_12702_12726(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                this_param)
                {
                    var return_v = this_param.RemoveMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10624, 12702, 12726);
                    return return_v;
                }


                int
                f_10624_12741_12779(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 12741, 12779);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?
                f_10624_12816_12843(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                this_param)
                {
                    var return_v = this_param.AssociatedField;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10624, 12816, 12843);
                    return return_v;
                }


                int
                f_10624_12858_12893(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 12858, 12893);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10624_12955_12965(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10624, 12955, 12965);
                    return return_v;
                }


                string
                f_10624_12993_13007(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10624, 12993, 13007);
                    return return_v;
                }


                int
                f_10624_12980_13041(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 12980, 13041);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10624_13105_13378(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.WellKnownMember
                member, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax)
                {
                    var return_v = Binder.GetWellKnownTypeMember(compilation, member, diagnostics, syntax: (Microsoft.CodeAnalysis.SyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 13105, 13378);
                    return return_v;
                }


                bool
                f_10624_13479_13505(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.HasAnyErrors();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 13479, 13505);
                    return return_v;
                }


                int
                f_10624_13466_13506(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 13466, 13506);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10624_13588_13625(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                newOwner)
                {
                    var return_v = this_param.AsMember(newOwner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 13588, 13625);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10624_14018_14180(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.WellKnownMember
                member, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax)
                {
                    var return_v = Binder.GetWellKnownTypeMember(compilation, member, diagnostics, syntax: (Microsoft.CodeAnalysis.SyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 14018, 14180);
                    return return_v;
                }


                bool
                f_10624_14284_14310(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.HasAnyErrors();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 14284, 14310);
                    return return_v;
                }


                int
                f_10624_14271_14311(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 14271, 14311);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10624_14396_14436(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                newOwner)
                {
                    var return_v = this_param.AsMember(newOwner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 14396, 14436);
                    return return_v;
                }


                bool
                f_10624_14576_14590(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10624, 14576, 14590);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10624_14631_14653(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ThisParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10624, 14631, 14653);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10624_14631_14658(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10624, 14631, 14658);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundThisReference
                f_10624_14600_14659(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundThisReference((Microsoft.CodeAnalysis.SyntaxNode)syntax, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 14600, 14659);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10624_14922_15085(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                arg0)
                {
                    var return_v = BoundCall.Synthesized((Microsoft.CodeAnalysis.SyntaxNode)syntax, receiverOpt: receiverOpt, method: method, arg0: (Microsoft.CodeAnalysis.CSharp.BoundExpression)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 14922, 15085);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10624_15219_15238(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10624, 15219, 15238);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundParameter
                f_10624_15157_15242(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                parameterSymbol)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundParameter((Microsoft.CodeAnalysis.SyntaxNode)syntax, parameterSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 15157, 15242);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10624_15435_15616(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundCall
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.BoundParameter
                arg0)
                {
                    var return_v = BoundCall.Synthesized((Microsoft.CodeAnalysis.SyntaxNode)syntax, receiverOpt: (Microsoft.CodeAnalysis.CSharp.BoundExpression)receiverOpt, method: method, arg0: (Microsoft.CodeAnalysis.CSharp.BoundExpression)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 15435, 15616);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                f_10624_15900_15974(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, Microsoft.CodeAnalysis.RefKind
                refKind, Microsoft.CodeAnalysis.CSharp.BoundCall
                expression)
                {
                    var return_v = BoundReturnStatement.Synthesized((Microsoft.CodeAnalysis.SyntaxNode)syntax, refKind, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 15900, 15974);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10624_16000_16055(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statement)
                {
                    var return_v = BoundBlock.SynthesizedNoLocals((Microsoft.CodeAnalysis.SyntaxNode)syntax, statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 16000, 16055);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10624_16366_16422(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundCall
                expression)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement((Microsoft.CodeAnalysis.SyntaxNode)syntax, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 16366, 16422);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                f_10624_16474_16541(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, Microsoft.CodeAnalysis.RefKind
                refKind, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                expressionOpt)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundReturnStatement((Microsoft.CodeAnalysis.SyntaxNode)syntax, refKind, expressionOpt: expressionOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 16474, 16541);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10624_16567_16637(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                statements)
                {
                    var return_v = BoundBlock.SynthesizedNoLocals((Microsoft.CodeAnalysis.SyntaxNode)syntax, statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 16567, 16637);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10624, 12369, 16664);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10624, 12369, 16664);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static BoundBlock ConstructFieldLikeEventAccessorBody_Regular(SourceEventSymbol eventSymbol, bool isAddMethod, CSharpCompilation compilation, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10624, 17533, 26183);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 17735, 17790);

                CSharpSyntaxNode
                syntax = f_10624_17761_17789(eventSymbol)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 17806, 17849);

                TypeSymbol
                delegateType = f_10624_17832_17848(eventSymbol)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 17863, 17950);

                MethodSymbol
                accessor = (DynAbs.Tracing.TraceSender.Conditional_F1(10624, 17887, 17898) || ((isAddMethod && DynAbs.Tracing.TraceSender.Conditional_F2(10624, 17901, 17922)) || DynAbs.Tracing.TraceSender.Conditional_F3(10624, 17925, 17949))) ? f_10624_17901_17922(eventSymbol) : f_10624_17925_17949(eventSymbol)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 17964, 18019);

                ParameterSymbol
                thisParameter = f_10624_17996_18018(accessor)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 18035, 18112);

                TypeSymbol
                boolType = f_10624_18057_18111(compilation, SpecialType.System_Boolean)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 18128, 18252);

                SpecialMember
                updateMethodId = (DynAbs.Tracing.TraceSender.Conditional_F1(10624, 18159, 18170) || ((isAddMethod && DynAbs.Tracing.TraceSender.Conditional_F2(10624, 18173, 18211)) || DynAbs.Tracing.TraceSender.Conditional_F3(10624, 18214, 18251))) ? SpecialMember.System_Delegate__Combine : SpecialMember.System_Delegate__Remove
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 18266, 18357);

                MethodSymbol
                updateMethod = (MethodSymbol)f_10624_18308_18356(compilation, updateMethodId)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 18373, 18554);

                BoundStatement
                @return = new BoundReturnStatement(syntax,
                                refKind: RefKind.None,
                                expressionOpt: null)
                { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10624, 18398, 18553) }
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 18570, 19209) || true) && (updateMethod == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10624, 18570, 19209);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 18628, 18709);

                    MemberDescriptor
                    memberDescriptor = f_10624_18664_18708(updateMethodId)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 18727, 19119);

                    f_10624_18727_19118(diagnostics, f_10624_18743_19117(f_10624_18760_19028(ErrorCode.ERR_MissingPredefinedMember, memberDescriptor.DeclaringTypeMetadataName, memberDescriptor.Name), f_10624_19101_19116(syntax)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 19139, 19194);

                    return f_10624_19146_19193(syntax, @return);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10624, 18570, 19209);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 19225, 19292);

                f_10624_19225_19291(updateMethod, diagnostics, syntax);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 19308, 19490);

                BoundThisReference
                fieldReceiver = (DynAbs.Tracing.TraceSender.Conditional_F1(10624, 19343, 19363) || ((f_10624_19343_19363(eventSymbol) && DynAbs.Tracing.TraceSender.Conditional_F2(10624, 19383, 19387)) || DynAbs.Tracing.TraceSender.Conditional_F3(10624, 19407, 19489))) ? null : new BoundThisReference(syntax, f_10624_19438_19456(thisParameter)) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10624, 19407, 19489) }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 19506, 19759);

                BoundFieldAccess
                boundBackingField = new BoundFieldAccess(syntax,
                                receiver: fieldReceiver,
                                fieldSymbol: f_10624_19644_19671(eventSymbol),
                                constantValueOpt: null)
                { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10624, 19543, 19758) }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 19775, 19937);

                BoundParameter
                boundParameter = new BoundParameter(syntax,
                                parameterSymbol: f_10624_19868_19887(accessor)[0])
                { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10624, 19807, 19936) }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 19953, 19984);

                BoundExpression
                delegateUpdate
                = default(BoundExpression);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 20000, 20151);

                MethodSymbol
                compareExchangeMethod = (MethodSymbol)f_10624_20051_20150(compilation, WellKnownMember.System_Threading_Interlocked__CompareExchange_T)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 20167, 21445) || true) && ((object)compareExchangeMethod == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10624, 20167, 21445);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 20308, 20742);

                    delegateUpdate = f_10624_20325_20741(syntax, operand: f_10624_20405_20636(syntax, receiverOpt: null, method: updateMethod, arguments: f_10624_20562_20635(boundBackingField, boundParameter)), conversion: Conversion.ExplicitReference, type: delegateType);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 20838, 21219);

                    BoundStatement
                    eventUpdate = new BoundExpressionStatement(syntax,
                                        expression: new BoundAssignmentOperator(syntax,
                                            left: boundBackingField,
                                            right: delegateUpdate,
                                            type: delegateType)
                                        { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10624, 20937, 21168) })
                    { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10624, 20867, 21218) }
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 21239, 21430);

                    return f_10624_21246_21429(syntax, statements: f_10624_21318_21428(eventUpdate, @return));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10624, 20167, 21445);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 21461, 21566);

                compareExchangeMethod = f_10624_21485_21565(compareExchangeMethod, f_10624_21517_21564(delegateType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 21582, 21658);

                f_10624_21582_21657(compareExchangeMethod, diagnostics, syntax);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 21674, 21740);

                GeneratedLabelSymbol
                loopLabel = f_10624_21707_21739("loop")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 21756, 21779);

                const int
                numTemps = 3
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 21795, 21842);

                LocalSymbol[]
                tmps = new LocalSymbol[numTemps]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 21856, 21906);

                BoundLocal[]
                boundTmps = new BoundLocal[numTemps]
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 21931, 21936);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 21922, 22239) || true) && (i < numTemps)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 21952, 21955)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10624, 21922, 22239))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10624, 21922, 22239);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 21989, 22107);

                        tmps[i] = f_10624_21999_22106(accessor, TypeWithAnnotations.Create(delegateType), SynthesizedLocalKind.LoweringTemp);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 22125, 22224);

                        boundTmps[i] = new BoundLocal(syntax, tmps[i], null, delegateType) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10624, 22140, 22223) };
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10624, 1, 318);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10624, 1, 318);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 22286, 22638);

                BoundStatement
                tmp0Init = new BoundExpressionStatement(syntax,
                                expression: new BoundAssignmentOperator(syntax,
                                    left: boundTmps[0],
                                    right: boundBackingField,
                                    type: delegateType)
                                { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10624, 22378, 22591) })
                { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10624, 22312, 22637) }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 22676, 22815);

                BoundStatement
                loopStart = new BoundLabelStatement(syntax,
                                label: loopLabel)
                { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10624, 22703, 22814) }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 22860, 23209);

                BoundStatement
                tmp1Update = new BoundExpressionStatement(syntax,
                                expression: new BoundAssignmentOperator(syntax,
                                    left: boundTmps[1],
                                    right: boundTmps[0],
                                    type: delegateType)
                                { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10624, 22954, 23162) })
                { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10624, 22888, 23208) }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 23285, 23690);

                delegateUpdate = f_10624_23302_23689(syntax, operand: f_10624_23378_23592(syntax, receiverOpt: null, method: updateMethod, arguments: f_10624_23523_23591(boundTmps[1], boundParameter)), conversion: Conversion.ExplicitReference, type: delegateType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 23774, 24125);

                BoundStatement
                tmp2Update = new BoundExpressionStatement(syntax,
                                expression: new BoundAssignmentOperator(syntax,
                                    left: boundTmps[2],
                                    right: delegateUpdate,
                                    type: delegateType)
                                { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10624, 23868, 24078) })
                { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10624, 23802, 24124) }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 24223, 24486);

                BoundExpression
                compareExchange = f_10624_24257_24485(syntax, receiverOpt: null, method: compareExchangeMethod, arguments: f_10624_24399_24484(boundBackingField, boundTmps[2], boundTmps[1]))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 24592, 24944);

                BoundStatement
                tmp0Update = new BoundExpressionStatement(syntax,
                                expression: new BoundAssignmentOperator(syntax,
                                    left: boundTmps[0],
                                    right: compareExchange,
                                    type: delegateType)
                                { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10624, 24686, 24897) })
                { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10624, 24620, 24943) }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 25047, 25460);

                BoundExpression
                loopExitCondition = new BoundBinaryOperator(syntax,
                                operatorKind: BinaryOperatorKind.ObjectEqual,
                                left: boundTmps[0],
                                right: boundTmps[1],
                                constantValueOpt: null,
                                methodOpt: null,
                                resultKind: LookupResultKind.Viable,
                                type: boolType)
                { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10624, 25083, 25459) }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 25524, 25745);

                BoundStatement
                loopEnd = new BoundConditionalGoto(syntax,
                                condition: loopExitCondition,
                                jumpIfTrue: false,
                                label: loopLabel)
                { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10624, 25549, 25744) }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 25761, 26172);

                return new BoundBlock(syntax,
                                locals: f_10624_25816_25834(tmps),
                                statements: f_10624_25865_26125(tmp0Init, loopStart, tmp1Update, tmp2Update, tmp0Update, loopEnd, @return))
                { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10624, 25768, 26171) };
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10624, 17533, 26183);

                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10624_17761_17789(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                this_param)
                {
                    var return_v = this_param.CSharpSyntaxNode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10624, 17761, 17789);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10624_17832_17848(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10624, 17832, 17848);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10624_17901_17922(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                this_param)
                {
                    var return_v = this_param.AddMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10624, 17901, 17922);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10624_17925_17949(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                this_param)
                {
                    var return_v = this_param.RemoveMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10624, 17925, 17949);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10624_17996_18018(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                this_param)
                {
                    var return_v = this_param.ThisParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10624, 17996, 18018);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10624_18057_18111(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 18057, 18111);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10624_18308_18356(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialMember
                specialMember)
                {
                    var return_v = this_param.GetSpecialTypeMember(specialMember);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 18308, 18356);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RuntimeMembers.MemberDescriptor
                f_10624_18664_18708(Microsoft.CodeAnalysis.SpecialMember
                member)
                {
                    var return_v = SpecialMembers.GetDescriptor(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 18664, 18708);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10624_18760_19028(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 18760, 19028);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10624_19101_19116(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10624, 19101, 19116);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                f_10624_18743_19117(Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnostic((Microsoft.CodeAnalysis.DiagnosticInfo)info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 18743, 19117);
                    return return_v;
                }


                int
                f_10624_18727_19118(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                diag)
                {
                    this_param.Add((Microsoft.CodeAnalysis.Diagnostic)diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 18727, 19118);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10624_19146_19193(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statement)
                {
                    var return_v = BoundBlock.SynthesizedNoLocals((Microsoft.CodeAnalysis.SyntaxNode)syntax, statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 19146, 19193);
                    return return_v;
                }


                bool
                f_10624_19225_19291(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = Binder.ReportUseSiteDiagnostics((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, diagnostics, (Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 19225, 19291);
                    return return_v;
                }


                bool
                f_10624_19343_19363(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10624, 19343, 19363);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10624_19438_19456(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10624, 19438, 19456);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?
                f_10624_19644_19671(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                this_param)
                {
                    var return_v = this_param.AssociatedField;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10624, 19644, 19671);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10624_19868_19887(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10624, 19868, 19887);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10624_20051_20150(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                member)
                {
                    var return_v = this_param.GetWellKnownTypeMember(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 20051, 20150);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10624_20562_20635(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                item1, Microsoft.CodeAnalysis.CSharp.BoundParameter
                item2)
                {
                    var return_v = ImmutableArray.Create<BoundExpression>((Microsoft.CodeAnalysis.CSharp.BoundExpression)item1, (Microsoft.CodeAnalysis.CSharp.BoundExpression)item2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 20562, 20635);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10624_20405_20636(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments)
                {
                    var return_v = BoundCall.Synthesized((Microsoft.CodeAnalysis.SyntaxNode)syntax, receiverOpt: receiverOpt, method: method, arguments: arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 20405, 20636);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundConversion
                f_10624_20325_20741(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundCall
                operand, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = BoundConversion.SynthesizedNonUserDefined((Microsoft.CodeAnalysis.SyntaxNode)syntax, operand: (Microsoft.CodeAnalysis.CSharp.BoundExpression)operand, conversion: conversion, type: type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 20325, 20741);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10624_21318_21428(Microsoft.CodeAnalysis.CSharp.BoundStatement
                item1, Microsoft.CodeAnalysis.CSharp.BoundStatement
                item2)
                {
                    var return_v = ImmutableArray.Create<BoundStatement>(item1, item2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 21318, 21428);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10624_21246_21429(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements)
                {
                    var return_v = BoundBlock.SynthesizedNoLocals((Microsoft.CodeAnalysis.SyntaxNode)syntax, statements: statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 21246, 21429);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                f_10624_21517_21564(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                item)
                {
                    var return_v = ImmutableArray.Create<TypeSymbol>(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 21517, 21564);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10624_21485_21565(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                typeArguments)
                {
                    var return_v = this_param.Construct(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 21485, 21565);
                    return return_v;
                }


                bool
                f_10624_21582_21657(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = Binder.ReportUseSiteDiagnostics((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, diagnostics, (Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 21582, 21657);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                f_10624_21707_21739(string
                name)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 21707, 21739);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal
                f_10624_21999_22106(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                containingMethodOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type, Microsoft.CodeAnalysis.SynthesizedLocalKind
                kind)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal(containingMethodOpt, type, kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 21999, 22106);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10624_23523_23591(Microsoft.CodeAnalysis.CSharp.BoundLocal
                item1, Microsoft.CodeAnalysis.CSharp.BoundParameter
                item2)
                {
                    var return_v = ImmutableArray.Create<BoundExpression>((Microsoft.CodeAnalysis.CSharp.BoundExpression)item1, (Microsoft.CodeAnalysis.CSharp.BoundExpression)item2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 23523, 23591);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10624_23378_23592(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments)
                {
                    var return_v = BoundCall.Synthesized((Microsoft.CodeAnalysis.SyntaxNode)syntax, receiverOpt: receiverOpt, method: method, arguments: arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 23378, 23592);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundConversion
                f_10624_23302_23689(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundCall
                operand, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = BoundConversion.SynthesizedNonUserDefined((Microsoft.CodeAnalysis.SyntaxNode)syntax, operand: (Microsoft.CodeAnalysis.CSharp.BoundExpression)operand, conversion: conversion, type: type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 23302, 23689);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10624_24399_24484(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                item1, Microsoft.CodeAnalysis.CSharp.BoundLocal
                item2, Microsoft.CodeAnalysis.CSharp.BoundLocal
                item3)
                {
                    var return_v = ImmutableArray.Create<BoundExpression>((Microsoft.CodeAnalysis.CSharp.BoundExpression)item1, (Microsoft.CodeAnalysis.CSharp.BoundExpression)item2, (Microsoft.CodeAnalysis.CSharp.BoundExpression)item3);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 24399, 24484);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10624_24257_24485(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments)
                {
                    var return_v = BoundCall.Synthesized((Microsoft.CodeAnalysis.SyntaxNode)syntax, receiverOpt: receiverOpt, method: method, arguments: arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 24257, 24485);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10624_25816_25834(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol[]
                items)
                {
                    var return_v = items.AsImmutable<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 25816, 25834);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10624_25865_26125(params Microsoft.CodeAnalysis.CSharp.BoundStatement[]?
                items)
                {
                    var return_v = ImmutableArray.Create<BoundStatement>(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 25865, 26125);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10624, 17533, 26183);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10624, 17533, 26183);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static BoundBlock ConstructDestructorBody(MethodSymbol method, BoundBlock block)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10624, 26195, 28755);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 26309, 26335);

                var
                syntax = block.Syntax
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 26351, 26408);

                f_10624_26351_26407(f_10624_26364_26381(method) == MethodKind.Destructor);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 26422, 26523);

                f_10624_26422_26522(f_10624_26435_26448(syntax) == SyntaxKind.Block || (DynAbs.Tracing.TraceSender.Expression_False(10624, 26435, 26521) || f_10624_26472_26485(syntax) == SyntaxKind.ArrowExpressionClause));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 26886, 26952);

                MethodSymbol
                baseTypeFinalize = f_10624_26918_26951(method)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 26968, 28715) || true) && ((object)baseTypeFinalize != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10624, 26968, 28715);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 27038, 27497);

                    BoundStatement
                    baseFinalizeCall = new BoundExpressionStatement(
                                        syntax,
                    f_10624_27152_27446(syntax, new BoundBaseReference(
                                                syntax,
                    f_10624_27323_27344(method))
                    { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10624, 27233, 27402) }, baseTypeFinalize))
                    { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10624, 27072, 27496) }
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 27517, 27864) || true) && (f_10624_27521_27534(syntax) == SyntaxKind.Block)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10624, 27517, 27864);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 27649, 27845);

                        baseFinalizeCall = f_10624_27668_27844(syntax, baseFinalizeCall, ((BlockSyntax)syntax).CloseBraceToken.Span);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10624, 27517, 27864);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 27884, 28700);

                    return f_10624_27891_28699(syntax, ImmutableArray<LocalSymbol>.Empty, f_10624_28013_28698(new BoundTryStatement(
                                                syntax,
                                                block,
                                                ImmutableArray<BoundCatchBlock>.Empty,
                                                new BoundBlock(
                                                    syntax,
                                                    ImmutableArray<LocalSymbol>.Empty,
                    f_10624_28428_28521(baseFinalizeCall))
                                                { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10624, 28270, 28613) }
                                            )
                    { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10624, 28077, 28697) }));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10624, 26968, 28715);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 28731, 28744);

                return block;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10624, 26195, 28755);

                Microsoft.CodeAnalysis.MethodKind
                f_10624_26364_26381(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10624, 26364, 26381);
                    return return_v;
                }


                int
                f_10624_26351_26407(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 26351, 26407);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10624_26435_26448(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 26435, 26448);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10624_26472_26485(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 26472, 26485);
                    return return_v;
                }


                int
                f_10624_26422_26522(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 26422, 26522);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10624_26918_26951(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = GetBaseTypeFinalizeMethod(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 26918, 26951);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10624_27323_27344(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10624, 27323, 27344);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10624_27152_27446(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundBaseReference
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = BoundCall.Synthesized(syntax, (Microsoft.CodeAnalysis.CSharp.BoundExpression)receiverOpt, method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 27152, 27446);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10624_27521_27534(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 27521, 27534);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundSequencePointWithSpan
                f_10624_27668_27844(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statementOpt, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSequencePointWithSpan(syntax, statementOpt, span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 27668, 27844);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10624_28428_28521(Microsoft.CodeAnalysis.CSharp.BoundStatement
                item)
                {
                    var return_v = ImmutableArray.Create<BoundStatement>(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 28428, 28521);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10624_28013_28698(Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                item)
                {
                    var return_v = ImmutableArray.Create<BoundStatement>((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 28013, 28698);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10624_27891_28699(Microsoft.CodeAnalysis.SyntaxNode
                syntax, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBlock(syntax, locals, statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 27891, 28699);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10624, 26195, 28755);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10624, 26195, 28755);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static MethodSymbol GetBaseTypeFinalizeMethod(MethodSymbol method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10624, 29275, 30565);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 29374, 29452);

                NamedTypeSymbol
                baseType = f_10624_29401_29451(f_10624_29401_29422(method))
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 29466, 30528) || true) && ((object)baseType != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10624, 29466, 30528);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 29531, 30444);
                            foreach (Symbol member in f_10624_29557_29613_I(f_10624_29557_29613(baseType, WellKnownMemberNames.DestructorName)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10624, 29531, 30444);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 29655, 30425) || true) && (f_10624_29659_29670(member) == SymbolKind.Method)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10624, 29655, 30425);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 29741, 29792);

                                    MethodSymbol
                                    baseTypeMethod = (MethodSymbol)member
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 29818, 29885);

                                    Accessibility
                                    accessibility = f_10624_29848_29884(baseTypeMethod)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 29911, 30402) || true) && ((accessibility == Accessibility.ProtectedOrInternal || (DynAbs.Tracing.TraceSender.Expression_False(10624, 29916, 30010) || accessibility == Accessibility.Protected)) && (DynAbs.Tracing.TraceSender.Expression_True(10624, 29915, 30078) && f_10624_30044_30073(baseTypeMethod) == 0) && (DynAbs.Tracing.TraceSender.Expression_True(10624, 29915, 30136) && f_10624_30111_30131(baseTypeMethod) == 0) && (DynAbs.Tracing.TraceSender.Expression_True(10624, 29915, 30261) && f_10624_30235_30261(baseTypeMethod)))
                                    ) // NOTE: not checking for virtual

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10624, 29911, 30402);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 30353, 30375);

                                        return baseTypeMethod;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10624, 29911, 30402);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10624, 29655, 30425);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10624, 29531, 30444);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10624, 1, 914);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10624, 1, 914);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 30464, 30513);

                        baseType = f_10624_30475_30512(baseType);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10624, 29466, 30528);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10624, 29466, 30528);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10624, 29466, 30528);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10624, 30542, 30554);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10624, 29275, 30565);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10624_29401_29422(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10624, 29401, 29422);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10624_29401_29451(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10624, 29401, 29451);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10624_29557_29613(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 29557, 29613);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10624_29659_29670(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10624, 29659, 29670);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_10624_29848_29884(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10624, 29848, 29884);
                    return return_v;
                }


                int
                f_10624_30044_30073(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10624, 30044, 30073);
                    return return_v;
                }


                int
                f_10624_30111_30131(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10624, 30111, 30131);
                    return return_v;
                }


                bool
                f_10624_30235_30261(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnsVoid;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10624, 30235, 30261);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10624_29557_29613_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10624, 29557, 29613);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10624_30475_30512(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10624, 30475, 30512);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10624, 29275, 30565);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10624, 29275, 30565);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static MethodBodySynthesizer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10624, 736, 30572);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10624, 736, 30572);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10624, 736, 30572);
        }

    }
}
