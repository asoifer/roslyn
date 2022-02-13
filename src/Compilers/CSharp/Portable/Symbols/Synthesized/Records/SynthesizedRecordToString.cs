// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class SynthesizedRecordToString : SynthesizedRecordObjectMethod
    {
        private readonly MethodSymbol _printMethod;

        public SynthesizedRecordToString(SourceMemberContainerTypeSymbol containingType, MethodSymbol printMethod, int memberOffset, DiagnosticBag diagnostics)
        : base(f_10733_1377_1391_C(containingType), WellKnownMemberNames.ObjectToString, memberOffset, diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10733, 1205, 1569);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10733, 1182, 1194);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10733, 1481, 1517);

                f_10733_1481_1516(printMethod is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10733, 1531, 1558);

                _printMethod = printMethod;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10733, 1205, 1569);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10733, 1205, 1569);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10733, 1205, 1569);
            }
        }

        protected override (TypeWithAnnotations ReturnType, ImmutableArray<ParameterSymbol> Parameters, bool IsVararg, ImmutableArray<TypeParameterConstraintClause> DeclaredConstraintsForOverrideOrImplementation) MakeParametersAndBindReturnType(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10733, 1581, 2347);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10733, 1869, 1908);

                var
                compilation = f_10733_1887_1907()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10733, 1922, 1956);

                var
                location = f_10733_1937_1955()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10733, 1970, 2336);

                return (ReturnType: TypeWithAnnotations.Create(f_10733_2017_2101(compilation, SpecialType.System_String, location, diagnostics)),
                                    Parameters: ImmutableArray<ParameterSymbol>.Empty,
                                    IsVararg: false,
                                    DeclaredConstraintsForOverrideOrImplementation: ImmutableArray<TypeParameterConstraintClause>.Empty);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10733, 1581, 2347);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10733_1887_1907()
                {
                    var return_v = DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10733, 1887, 1907);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10733_1937_1955()
                {
                    var return_v = ReturnTypeLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10733, 1937, 1955);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10733_2017_2101(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.SpecialType
                typeId, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = Binder.GetSpecialType(compilation, typeId, location, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10733, 2017, 2101);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10733, 1581, 2347);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10733, 1581, 2347);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override int GetParameterCountFromSyntax()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10733, 2412, 2416);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10733, 2415, 2416);
                return 0; DynAbs.Tracing.TraceSender.TraceExitMethod(10733, 2412, 2416);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10733, 2412, 2416);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10733, 2412, 2416);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override void GenerateMethodBody(TypeCompilationState compilationState, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10733, 2429, 4715);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10733, 2561, 2653);

                var
                F = f_10733_2569_2652(this, f_10733_2605_2620(this), compilationState, diagnostics)
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10733, 2705, 2773);

                    CSharpCompilation
                    compilation = f_10733_2737_2772(f_10733_2737_2751())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10733, 2791, 2868);

                    var
                    stringBuilder = f_10733_2811_2867(F, WellKnownType.System_Text_StringBuilder)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10733, 2886, 2977);

                    var
                    stringBuilderCtor = f_10733_2910_2976(F, WellKnownMember.System_Text_StringBuilder__ctor)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10733, 2997, 3056);

                    var
                    builderLocalSymbol = f_10733_3022_3055(F, stringBuilder)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10733, 3074, 3128);

                    BoundLocal
                    builderLocal = f_10733_3100_3127(F, builderLocalSymbol)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10733, 3146, 3201);

                    var
                    block = f_10733_3158_3200()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10733, 3274, 3338);

                    f_10733_3274_3337(                // var builder = new StringBuilder();
                                    block, f_10733_3284_3336(F, builderLocal, f_10733_3311_3335(F, stringBuilderCtor)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10733, 3402, 3468);

                    f_10733_3402_3467(
                                    // builder.Append(<name>);
                                    block, f_10733_3412_3466(F, builderLocal, f_10733_3446_3465(f_10733_3446_3460())));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10733, 3531, 3583);

                    f_10733_3531_3582(
                                    // builder.Append(" { ");
                                    block, f_10733_3541_3581(F, builderLocal, " { "));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10733, 3676, 3778);

                    f_10733_3676_3777(
                                    // if (this.PrintMembers(builder)) builder.Append(" ");
                                    block, f_10733_3686_3776(F, f_10733_3691_3735(F, f_10733_3698_3706(F), _printMethod, builderLocal), f_10733_3737_3775(F, builderLocal, " ")));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10733, 3839, 3889);

                    f_10733_3839_3888(
                                    // builder.Append("}");
                                    block, f_10733_3849_3887(F, builderLocal, "}"));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10733, 3956, 4054);

                    f_10733_3956_4053(
                                    // return builder.ToString();
                                    block, f_10733_3966_4052(F, f_10733_3975_4051(F, builderLocal, f_10733_3996_4050(F, SpecialMember.System_Object__ToString))));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10733, 4074, 4168);

                    f_10733_4074_4167(
                                    F, f_10733_4088_4166(F, f_10733_4096_4137(builderLocalSymbol), f_10733_4139_4165(block)));
                }
                catch (SyntheticBoundNodeFactory.MissingPredefinedMember ex)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(10733, 4197, 4383);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10733, 4290, 4321);

                    f_10733_4290_4320(diagnostics, f_10733_4306_4319(ex));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10733, 4339, 4368);

                    f_10733_4339_4367(F, f_10733_4353_4366(F));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(10733, 4197, 4383);
                }

                static BoundStatement makeAppendString(SyntheticBoundNodeFactory F, BoundLocal builder, string value)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10733, 4399, 4704);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10733, 4533, 4689);

                        return f_10733_4540_4688(F, f_10733_4562_4687(F, receiver: builder, f_10733_4588_4662(F, WellKnownMember.System_Text_StringBuilder__AppendString), f_10733_4664_4686(F, value)));
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10733, 4399, 4704);

                        Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        f_10733_4588_4662(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                        this_param, Microsoft.CodeAnalysis.WellKnownMember
                        wm)
                        {
                            var return_v = this_param.WellKnownMethod(wm);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10733, 4588, 4662);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundLiteral
                        f_10733_4664_4686(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                        this_param, string
                        stringValue)
                        {
                            var return_v = this_param.StringLiteral(stringValue);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10733, 4664, 4686);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundCall
                        f_10733_4562_4687(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                        this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                        receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        method, Microsoft.CodeAnalysis.CSharp.BoundLiteral
                        arg0)
                        {
                            var return_v = this_param.Call(receiver: (Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, method, (Microsoft.CodeAnalysis.CSharp.BoundExpression)arg0);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10733, 4562, 4687);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                        f_10733_4540_4688(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                        this_param, Microsoft.CodeAnalysis.CSharp.BoundCall
                        expr)
                        {
                            var return_v = this_param.ExpressionStatement((Microsoft.CodeAnalysis.CSharp.BoundExpression)expr);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10733, 4540, 4688);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10733, 4399, 4704);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10733, 4399, 4704);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10733, 2429, 4715);

                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10733_2605_2620(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordToString
                this_param)
                {
                    var return_v = this_param.SyntaxNode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10733, 2605, 2620);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                f_10733_2569_2652(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordToString
                topLevelMethod, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                compilationState, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)topLevelMethod, (Microsoft.CodeAnalysis.SyntaxNode)node, compilationState, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10733, 2569, 2652);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10733_2737_2751()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10733, 2737, 2751);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10733_2737_2772(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10733, 2737, 2772);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10733_2811_2867(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.WellKnownType
                wt)
                {
                    var return_v = this_param.WellKnownType(wt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10733, 2811, 2867);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10733_2910_2976(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                wm)
                {
                    var return_v = this_param.WellKnownMethod(wm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10733, 2910, 2976);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10733_3022_3055(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = this_param.SynthesizedLocal((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10733, 3022, 3055);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10733_3100_3127(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10733, 3100, 3127);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10733_3158_3200()
                {
                    var return_v = ArrayBuilder<BoundStatement>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10733, 3158, 3200);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                f_10733_3311_3335(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                ctor, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                args)
                {
                    var return_v = this_param.New(ctor, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10733, 3311, 3335);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10733_3284_3336(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                left, Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                right)
                {
                    var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10733, 3284, 3336);
                    return return_v;
                }


                int
                f_10733_3274_3337(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10733, 3274, 3337);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10733_3446_3460()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10733, 3446, 3460);
                    return return_v;
                }


                string
                f_10733_3446_3465(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10733, 3446, 3465);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10733_3412_3466(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                F, Microsoft.CodeAnalysis.CSharp.BoundLocal
                builder, string
                value)
                {
                    var return_v = makeAppendString(F, builder, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10733, 3412, 3466);
                    return return_v;
                }


                int
                f_10733_3402_3467(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10733, 3402, 3467);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10733_3541_3581(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                F, Microsoft.CodeAnalysis.CSharp.BoundLocal
                builder, string
                value)
                {
                    var return_v = makeAppendString(F, builder, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10733, 3541, 3581);
                    return return_v;
                }


                int
                f_10733_3531_3582(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10733, 3531, 3582);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundThisReference
                f_10733_3698_3706(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.This();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10733, 3698, 3706);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10733_3691_3735(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundThisReference
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.BoundLocal
                arg0)
                {
                    var return_v = this_param.Call((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, method, (Microsoft.CodeAnalysis.CSharp.BoundExpression)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10733, 3691, 3735);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10733_3737_3775(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                F, Microsoft.CodeAnalysis.CSharp.BoundLocal
                builder, string
                value)
                {
                    var return_v = makeAppendString(F, builder, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10733, 3737, 3775);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10733_3686_3776(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundCall
                condition, Microsoft.CodeAnalysis.CSharp.BoundStatement
                thenClause)
                {
                    var return_v = this_param.If((Microsoft.CodeAnalysis.CSharp.BoundExpression)condition, thenClause);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10733, 3686, 3776);
                    return return_v;
                }


                int
                f_10733_3676_3777(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10733, 3676, 3777);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10733_3849_3887(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                F, Microsoft.CodeAnalysis.CSharp.BoundLocal
                builder, string
                value)
                {
                    var return_v = makeAppendString(F, builder, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10733, 3849, 3887);
                    return return_v;
                }


                int
                f_10733_3839_3888(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10733, 3839, 3888);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10733_3996_4050(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SpecialMember
                sm)
                {
                    var return_v = this_param.SpecialMethod(sm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10733, 3996, 4050);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10733_3975_4051(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = this_param.Call((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10733, 3975, 4051);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                f_10733_3966_4052(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundCall
                expression)
                {
                    var return_v = this_param.Return((Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10733, 3966, 4052);
                    return return_v;
                }


                int
                f_10733_3956_4053(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10733, 3956, 4053);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10733_4096_4137(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10733, 4096, 4137);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10733_4139_4165(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10733, 4139, 4165);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10733_4088_4166(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements)
                {
                    var return_v = this_param.Block(locals, statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10733, 4088, 4166);
                    return return_v;
                }


                int
                f_10733_4074_4167(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                body)
                {
                    this_param.CloseMethod((Microsoft.CodeAnalysis.CSharp.BoundStatement)body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10733, 4074, 4167);
                    return 0;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_10733_4306_4319(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory.MissingPredefinedMember
                this_param)
                {
                    var return_v = this_param.Diagnostic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10733, 4306, 4319);
                    return return_v;
                }


                int
                f_10733_4290_4320(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diag)
                {
                    this_param.Add(diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10733, 4290, 4320);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10733_4353_4366(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.ThrowNull();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10733, 4353, 4366);
                    return return_v;
                }


                int
                f_10733_4339_4367(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                body)
                {
                    this_param.CloseMethod(body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10733, 4339, 4367);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10733, 2429, 4715);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10733, 2429, 4715);
            }
        }

        static SynthesizedRecordToString()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10733, 1056, 4722);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10733, 1056, 4722);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10733, 1056, 4722);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10733, 1056, 4722);

        int
        f_10733_1481_1516(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10733, 1481, 1516);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
        f_10733_1377_1391_C(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10733, 1205, 1569);
            return return_v;
        }

    }
}
