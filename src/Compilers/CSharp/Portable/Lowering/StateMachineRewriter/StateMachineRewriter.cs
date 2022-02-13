// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CodeGen;
using Microsoft.CodeAnalysis.Collections;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal abstract class StateMachineRewriter
    {
        protected readonly BoundStatement body;

        protected readonly MethodSymbol method;

        protected readonly DiagnosticBag diagnostics;

        protected readonly SyntheticBoundNodeFactory F;

        protected readonly SynthesizedContainer stateMachineType;

        protected readonly VariableSlotAllocator slotAllocatorOpt;

        protected readonly SynthesizedLocalOrdinalsDispenser synthesizedLocalOrdinals;

        protected FieldSymbol stateField;

        protected IReadOnlyDictionary<Symbol, CapturedSymbolReplacement> nonReusableLocalProxies;

        protected int nextFreeHoistedLocalSlot;

        protected IOrderedReadOnlySet<Symbol> hoistedVariables;

        protected Dictionary<Symbol, CapturedSymbolReplacement> initialParameters;

        protected FieldSymbol initialThreadIdField;

        protected StateMachineRewriter(
                    BoundStatement body,
                    MethodSymbol method,
                    SynthesizedContainer stateMachineType,
                    VariableSlotAllocator slotAllocatorOpt,
                    TypeCompilationState compilationState,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10542, 1482, 2635);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 686, 690);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 733, 739);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 783, 794);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 850, 851);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 902, 918);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 970, 986);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 1050, 1074);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 1109, 1119);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 1195, 1218);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 1243, 1267);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 1316, 1332);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 1399, 1416);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 1449, 1469);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 1803, 1830);

                f_10542_1803_1829(body != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 1844, 1873);

                f_10542_1844_1872(method != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 1887, 1934);

                f_10542_1887_1933((object)stateMachineType != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 1948, 1987);

                f_10542_1948_1986(compilationState != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 2001, 2035);

                f_10542_2001_2034(diagnostics != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 2051, 2068);

                this.body = body;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 2082, 2103);

                this.method = method;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 2117, 2158);

                this.stateMachineType = stateMachineType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 2172, 2213);

                this.slotAllocatorOpt = slotAllocatorOpt;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 2227, 2299);

                this.synthesizedLocalOrdinals = f_10542_2259_2298();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 2313, 2344);

                this.diagnostics = diagnostics;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 2360, 2451);

                this.F = f_10542_2369_2450(method, body.Syntax, compilationState, diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 2465, 2572);

                f_10542_2465_2571(f_10542_2478_2570(f_10542_2496_2509(F), f_10542_2511_2532(method), TypeCompareKind.ConsiderEverything2));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 2586, 2624);

                f_10542_2586_2623(f_10542_2599_2607(F) == body.Syntax);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10542, 1482, 2635);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10542, 1482, 2635);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10542, 1482, 2635);
            }
        }

        protected abstract bool PreserveInitialParameterValuesAndThreadId { get; }

        protected abstract void GenerateControlFields();

        protected abstract void InitializeStateMachine(ArrayBuilder<BoundStatement> bodyBuilder, NamedTypeSymbol frameType, LocalSymbol stateMachineLocal);

        protected abstract BoundStatement GenerateStateMachineCreation(LocalSymbol stateMachineVariable, NamedTypeSymbol frameType, IReadOnlyDictionary<Symbol, CapturedSymbolReplacement> proxies);

        protected abstract void GenerateMethodImplementations();

        protected BoundStatement Rewrite()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10542, 3977, 5753);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 4036, 4125) || true) && (f_10542_4040_4059(this.body))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10542, 4036, 4125);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 4093, 4110);

                    return this.body;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10542, 4036, 4125);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 4141, 4176);

                f_10542_4141_4175(
                            F, stateMachineType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 4192, 4216);

                f_10542_4192_4215(this);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 4232, 4688) || true) && (f_10542_4236_4277() && (DynAbs.Tracing.TraceSender.Expression_True(10542, 4236, 4297) && f_10542_4281_4297(this)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10542, 4232, 4688);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 4534, 4673);

                    initialThreadIdField = f_10542_4557_4672(F, f_10542_4577_4616(F, SpecialType.System_Int32), f_10542_4618_4671());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10542, 4232, 4688);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 4786, 4952) || true) && (f_10542_4790_4831())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10542, 4786, 4952);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 4865, 4937);

                    initialParameters = f_10542_4885_4936();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10542, 4786, 4952);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 5032, 5135);

                var
                variablesToHoist = f_10542_5055_5134(f_10542_5093_5106(F), method, body, diagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 5151, 5388) || true) && (f_10542_5155_5181(diagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10542, 5151, 5388);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 5284, 5373);

                    return f_10542_5291_5372(f_10542_5313_5321(F), ImmutableArray<BoundNode>.Empty, hasErrors: true);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10542, 5151, 5388);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 5404, 5521);

                f_10542_5404_5520(this, variablesToHoist, out this.nonReusableLocalProxies, out this.nextFreeHoistedLocalSlot);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 5537, 5578);

                this.hoistedVariables = variablesToHoist;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 5594, 5626);

                f_10542_5594_5625(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 5707, 5742);

                return f_10542_5714_5741(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10542, 3977, 5753);

                bool
                f_10542_4040_4059(Microsoft.CodeAnalysis.CSharp.BoundStatement
                this_param)
                {
                    var return_v = this_param.HasErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10542, 4040, 4059);
                    return return_v;
                }


                int
                f_10542_4141_4175(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedContainer
                nestedType)
                {
                    this_param.OpenNestedType((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)nestedType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 4141, 4175);
                    return 0;
                }


                int
                f_10542_4192_4215(Microsoft.CodeAnalysis.CSharp.StateMachineRewriter
                this_param)
                {
                    this_param.GenerateControlFields();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 4192, 4215);
                    return 0;
                }


                bool
                f_10542_4236_4277()
                {
                    var return_v = PreserveInitialParameterValuesAndThreadId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10542, 4236, 4277);
                    return return_v;
                }


                bool
                f_10542_4281_4297(Microsoft.CodeAnalysis.CSharp.StateMachineRewriter
                this_param)
                {
                    var return_v = this_param.CanGetThreadId();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 4281, 4297);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10542_4577_4616(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SpecialType
                st)
                {
                    var return_v = this_param.SpecialType(st);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 4577, 4616);
                    return return_v;
                }


                string
                f_10542_4618_4671()
                {
                    var return_v = GeneratedNames.MakeIteratorCurrentThreadIdFieldName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 4618, 4671);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol
                f_10542_4557_4672(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, string
                name)
                {
                    var return_v = this_param.StateMachineField((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 4557, 4672);
                    return return_v;
                }


                bool
                f_10542_4790_4831()
                {
                    var return_v = PreserveInitialParameterValuesAndThreadId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10542, 4790, 4831);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement>
                f_10542_4885_4936()
                {
                    var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 4885, 4936);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10542_5093_5106(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10542, 5093, 5106);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Collections.OrderedSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10542_5055_5134(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.BoundStatement
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = IteratorAndAsyncCaptureWalker.Analyze(compilation, method, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 5055, 5134);
                    return return_v;
                }


                bool
                f_10542_5155_5181(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.HasAnyErrors();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 5155, 5181);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10542_5313_5321(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10542, 5313, 5321);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBadStatement
                f_10542_5291_5372(Microsoft.CodeAnalysis.SyntaxNode
                syntax, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode>
                childBoundNodes, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBadStatement(syntax, childBoundNodes, hasErrors: hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 5291, 5372);
                    return return_v;
                }


                int
                f_10542_5404_5520(Microsoft.CodeAnalysis.CSharp.StateMachineRewriter
                this_param, Microsoft.CodeAnalysis.Collections.OrderedSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                variablesToHoist, out System.Collections.Generic.IReadOnlyDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement>
                proxies, out int
                nextFreeHoistedLocalSlot)
                {
                    this_param.CreateNonReusableLocalProxies((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbol>)variablesToHoist, out proxies, out nextFreeHoistedLocalSlot);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 5404, 5520);
                    return 0;
                }


                int
                f_10542_5594_5625(Microsoft.CodeAnalysis.CSharp.StateMachineRewriter
                this_param)
                {
                    this_param.GenerateMethodImplementations();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 5594, 5625);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10542_5714_5741(Microsoft.CodeAnalysis.CSharp.StateMachineRewriter
                this_param)
                {
                    var return_v = this_param.GenerateKickoffMethodBody();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 5714, 5741);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10542, 3977, 5753);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10542, 3977, 5753);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void CreateNonReusableLocalProxies(
                    IEnumerable<Symbol> variablesToHoist,
                    out IReadOnlyDictionary<Symbol, CapturedSymbolReplacement> proxies,
                    out int nextFreeHoistedLocalSlot)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10542, 5765, 12551);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 6012, 6085);

                var
                proxiesBuilder = f_10542_6033_6084()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 6101, 6140);

                var
                typeMap = f_10542_6115_6139(stateMachineType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 6154, 6241);

                bool
                isDebugBuild = f_10542_6174_6213(f_10542_6174_6195(f_10542_6174_6187(F))) == OptimizationLevel.Debug
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 6255, 6323);

                bool
                mapToPreviousFields = isDebugBuild && (DynAbs.Tracing.TraceSender.Expression_True(10542, 6282, 6322) && slotAllocatorOpt != null)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 6339, 6439);

                nextFreeHoistedLocalSlot = (DynAbs.Tracing.TraceSender.Conditional_F1(10542, 6366, 6385) || ((mapToPreviousFields && DynAbs.Tracing.TraceSender.Conditional_F2(10542, 6388, 6434)) || DynAbs.Tracing.TraceSender.Conditional_F3(10542, 6437, 6438))) ? f_10542_6388_6434(slotAllocatorOpt) : 0;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 6455, 12499);
                    foreach (var variable in f_10542_6480_6496_I(variablesToHoist))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10542, 6455, 12499);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 6530, 6619);

                        f_10542_6530_6618(f_10542_6543_6556(variable) == SymbolKind.Local || (DynAbs.Tracing.TraceSender.Expression_False(10542, 6543, 6617) || f_10542_6580_6593(variable) == SymbolKind.Parameter));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 6639, 12484) || true) && (f_10542_6643_6656(variable) == SymbolKind.Local)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10542, 6639, 12484);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 6718, 6752);

                            var
                            local = (LocalSymbol)variable
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 6774, 6818);

                            var
                            synthesizedKind = f_10542_6796_6817(local)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 6842, 6980) || true) && (!f_10542_6847_6898(synthesizedKind))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10542, 6842, 6980);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 6948, 6957);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10542, 6842, 6980);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 7055, 7154) || true) && (f_10542_7059_7072(local))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10542, 7055, 7154);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 7122, 7131);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10542, 7055, 7154);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 7178, 7455) || true) && (f_10542_7182_7195(local) != RefKind.None)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10542, 7178, 7455);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 7337, 7397);

                                f_10542_7337_7396(synthesizedKind == SynthesizedLocalKind.Spill);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 7423, 7432);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10542, 7178, 7455);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 7479, 7523);

                            f_10542_7479_7522(f_10542_7492_7505(local) == RefKind.None);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 7545, 7582);

                            StateMachineFieldSymbol
                            field = null
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 7606, 10135) || true) && (f_10542_7610_7650(this, local))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10542, 7606, 10135);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 7757, 7813);

                                var
                                fieldType = f_10542_7773_7807(typeMap, f_10542_7796_7806(local)).Type
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 7841, 7857);

                                LocalDebugId
                                id
                                = default(LocalDebugId);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 7883, 7902);

                                int
                                slotIndex = -1
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 7930, 9681) || true) && (isDebugBuild)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10542, 7930, 9681);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 8381, 8439);

                                    SyntaxNode
                                    declaratorSyntax = f_10542_8411_8438(local)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 8469, 8608);

                                    int
                                    syntaxOffset = f_10542_8488_8607(method, f_10542_8522_8577(declaratorSyntax), f_10542_8579_8606(declaratorSyntax))
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 8638, 8727);

                                    int
                                    ordinal = f_10542_8652_8726(synthesizedLocalOrdinals, synthesizedKind, syntaxOffset)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 8757, 8802);

                                    id = f_10542_8762_8801(syntaxOffset, ordinal);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 8913, 8935);

                                    int
                                    previousSlotIndex
                                    = default(int);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 8965, 9517) || true) && (mapToPreviousFields && (DynAbs.Tracing.TraceSender.Expression_True(10542, 8969, 9390) && f_10542_8992_9390(slotAllocatorOpt, declaratorSyntax, f_10542_9130_9200(f_10542_9130_9148(F), fieldType, declaratorSyntax, diagnostics), synthesizedKind, id, diagnostics, out previousSlotIndex)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10542, 8965, 9517);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 9456, 9486);

                                        slotIndex = previousSlotIndex;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10542, 8965, 9517);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10542, 7930, 9681);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10542, 7930, 9681);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 9631, 9654);

                                    id = LocalDebugId.None;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10542, 7930, 9681);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 9709, 9852) || true) && (slotIndex == -1)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10542, 9709, 9852);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 9786, 9825);

                                    slotIndex = nextFreeHoistedLocalSlot++;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10542, 9709, 9852);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 9880, 9980);

                                string
                                fieldName = f_10542_9899_9979(synthesizedKind, slotIndex, f_10542_9968_9978(local))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 10006, 10112);

                                field = f_10542_10014_10111(F, fieldType, fieldName, f_10542_10056_10099(synthesizedKind, id), slotIndex);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10542, 7606, 10135);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 10159, 10345) || true) && (field != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10542, 10159, 10345);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 10226, 10322);

                                f_10542_10226_10321(proxiesBuilder, local, f_10542_10252_10320(field, isReusable: false));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10542, 10159, 10345);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10542, 6639, 12484);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10542, 6639, 12484);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 10427, 10469);

                            var
                            parameter = (ParameterSymbol)variable
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 10491, 12465) || true) && (f_10542_10495_10511(parameter))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10542, 10491, 12465);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 10561, 10604);

                                var
                                containingType = f_10542_10582_10603(method)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 10630, 10750);

                                var
                                proxyField = f_10542_10647_10749(F, containingType, f_10542_10683_10718(), isPublic: true, isThis: true)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 10776, 10881);

                                f_10542_10776_10880(proxiesBuilder, parameter, f_10542_10806_10879(proxyField, isReusable: false));

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 10909, 11395) || true) && (f_10542_10913_10954())
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10542, 10909, 11395);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 11012, 11227);

                                    var
                                    initialThis = (DynAbs.Tracing.TraceSender.Conditional_F1(10542, 11030, 11059) || ((f_10542_11030_11059(containingType) && DynAbs.Tracing.TraceSender.Conditional_F2(10542, 11095, 11213)) || DynAbs.Tracing.TraceSender.Conditional_F3(10542, 11216, 11226))) ? f_10542_11095_11213(F, containingType, f_10542_11131_11182(), isPublic: true, isThis: true) : proxyField
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 11259, 11368);

                                    f_10542_11259_11367(
                                                                initialParameters, parameter, f_10542_11292_11366(initialThis, isReusable: false));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10542, 10909, 11395);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10542, 10491, 12465);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10542, 10491, 12465);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 11707, 11859);

                                var
                                proxyField = f_10542_11724_11858(F, f_10542_11744_11782(typeMap, f_10542_11767_11781(parameter)).Type, f_10542_11789_11803(parameter), isPublic: f_10542_11815_11857_M(!PreserveInitialParameterValuesAndThreadId))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 11885, 11990);

                                f_10542_11885_11989(proxiesBuilder, parameter, f_10542_11915_11988(proxyField, isReusable: false));

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 12018, 12442) || true) && (f_10542_12022_12063())
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10542, 12018, 12442);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 12121, 12282);

                                    var
                                    field = f_10542_12133_12281(F, f_10542_12153_12191(typeMap, f_10542_12176_12190(parameter)).Type, f_10542_12198_12264(f_10542_12249_12263(parameter)), isPublic: true)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 12312, 12415);

                                    f_10542_12312_12414(initialParameters, parameter, f_10542_12345_12413(field, isReusable: false));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10542, 12018, 12442);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10542, 10491, 12465);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10542, 6639, 12484);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10542, 6455, 12499);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10542, 1, 6045);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10542, 1, 6045);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 12515, 12540);

                proxies = proxiesBuilder;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10542, 5765, 12551);

                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement>
                f_10542_6033_6084()
                {
                    var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 6033, 6084);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                f_10542_6115_6139(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedContainer
                this_param)
                {
                    var return_v = this_param.TypeMap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10542, 6115, 6139);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10542_6174_6187(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10542, 6174, 6187);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10542_6174_6195(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10542, 6174, 6195);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OptimizationLevel
                f_10542_6174_6213(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.OptimizationLevel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10542, 6174, 6213);
                    return return_v;
                }


                int
                f_10542_6388_6434(Microsoft.CodeAnalysis.CodeGen.VariableSlotAllocator?
                this_param)
                {
                    var return_v = this_param.PreviousHoistedLocalSlotCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10542, 6388, 6434);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10542_6543_6556(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10542, 6543, 6556);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10542_6580_6593(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10542, 6580, 6593);
                    return return_v;
                }


                int
                f_10542_6530_6618(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 6530, 6618);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10542_6643_6656(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10542, 6643, 6656);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SynthesizedLocalKind
                f_10542_6796_6817(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.SynthesizedKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10542, 6796, 6817);
                    return return_v;
                }


                bool
                f_10542_6847_6898(Microsoft.CodeAnalysis.SynthesizedLocalKind
                kind)
                {
                    var return_v = kind.MustSurviveStateMachineSuspension();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 6847, 6898);
                    return return_v;
                }


                bool
                f_10542_7059_7072(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.IsConst;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10542, 7059, 7072);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10542_7182_7195(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10542, 7182, 7195);
                    return return_v;
                }


                int
                f_10542_7337_7396(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 7337, 7396);
                    return 0;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10542_7492_7505(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10542, 7492, 7505);
                    return return_v;
                }


                int
                f_10542_7479_7522(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 7479, 7522);
                    return 0;
                }


                bool
                f_10542_7610_7650(Microsoft.CodeAnalysis.CSharp.StateMachineRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.ShouldPreallocateNonReusableProxy(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 7610, 7650);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10542_7796_7806(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10542, 7796, 7806);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10542_7773_7807(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                previous)
                {
                    var return_v = this_param.SubstituteType(previous);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 7773, 7807);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10542_8411_8438(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.GetDeclaratorSyntax();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 8411, 8438);
                    return return_v;
                }


                int
                f_10542_8522_8577(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = LambdaUtilities.GetDeclaratorPosition(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 8522, 8577);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10542_8579_8606(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10542, 8579, 8606);
                    return return_v;
                }


                int
                f_10542_8488_8607(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, int
                localPosition, Microsoft.CodeAnalysis.SyntaxTree
                localTree)
                {
                    var return_v = this_param.CalculateLocalSyntaxOffset(localPosition, localTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 8488, 8607);
                    return return_v;
                }


                int
                f_10542_8652_8726(Microsoft.CodeAnalysis.CodeGen.SynthesizedLocalOrdinalsDispenser
                this_param, Microsoft.CodeAnalysis.SynthesizedLocalKind
                localKind, int
                syntaxOffset)
                {
                    var return_v = this_param.AssignLocalOrdinal(localKind, syntaxOffset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 8652, 8726);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalDebugId
                f_10542_8762_8801(int
                syntaxOffset, int
                ordinal)
                {
                    var return_v = new Microsoft.CodeAnalysis.CodeGen.LocalDebugId(syntaxOffset, ordinal);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 8762, 8801);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder?
                f_10542_9130_9148(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.ModuleBuilderOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10542, 9130, 9148);
                    return return_v;
                }


                Microsoft.Cci.ITypeReference
                f_10542_9130_9200(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder?
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeSymbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.Translate(typeSymbol, syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 9130, 9200);
                    return return_v;
                }


                bool
                f_10542_8992_9390(Microsoft.CodeAnalysis.CodeGen.VariableSlotAllocator?
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                currentDeclarator, Microsoft.Cci.ITypeReference
                currentType, Microsoft.CodeAnalysis.SynthesizedLocalKind
                synthesizedKind, Microsoft.CodeAnalysis.CodeGen.LocalDebugId
                currentId, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out int
                slotIndex)
                {
                    var return_v = this_param.TryGetPreviousHoistedLocalSlotIndex(currentDeclarator, currentType, synthesizedKind, currentId, diagnostics, out slotIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 8992, 9390);
                    return return_v;
                }


                string
                f_10542_9968_9978(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10542, 9968, 9978);
                    return return_v;
                }


                string
                f_10542_9899_9979(Microsoft.CodeAnalysis.SynthesizedLocalKind
                kind, int
                slotIndex, string
                localNameOpt)
                {
                    var return_v = GeneratedNames.MakeHoistedLocalFieldName(kind, slotIndex, localNameOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 9899, 9979);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalSlotDebugInfo
                f_10542_10056_10099(Microsoft.CodeAnalysis.SynthesizedLocalKind
                synthesizedKind, Microsoft.CodeAnalysis.CodeGen.LocalDebugId
                id)
                {
                    var return_v = new Microsoft.CodeAnalysis.CodeGen.LocalSlotDebugInfo(synthesizedKind, id);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 10056, 10099);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol
                f_10542_10014_10111(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, string
                name, Microsoft.CodeAnalysis.CodeGen.LocalSlotDebugInfo
                slotDebugInfo, int
                slotIndex)
                {
                    var return_v = this_param.StateMachineField(type, name, slotDebugInfo, slotIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 10014, 10111);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CapturedToStateMachineFieldReplacement
                f_10542_10252_10320(Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol
                hoistedField, bool
                isReusable)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CapturedToStateMachineFieldReplacement(hoistedField, isReusable: isReusable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 10252, 10320);
                    return return_v;
                }


                int
                f_10542_10226_10321(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                key, Microsoft.CodeAnalysis.CSharp.CapturedToStateMachineFieldReplacement
                value)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)key, (Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 10226, 10321);
                    return 0;
                }


                bool
                f_10542_10495_10511(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.IsThis;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10542, 10495, 10511);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10542_10582_10603(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10542, 10582, 10603);
                    return return_v;
                }


                string
                f_10542_10683_10718()
                {
                    var return_v = GeneratedNames.ThisProxyFieldName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 10683, 10718);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol
                f_10542_10647_10749(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, string
                name, bool
                isPublic, bool
                isThis)
                {
                    var return_v = this_param.StateMachineField((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, name, isPublic: isPublic, isThis: isThis);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 10647, 10749);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CapturedToStateMachineFieldReplacement
                f_10542_10806_10879(Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol
                hoistedField, bool
                isReusable)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CapturedToStateMachineFieldReplacement(hoistedField, isReusable: isReusable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 10806, 10879);
                    return return_v;
                }


                int
                f_10542_10776_10880(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                key, Microsoft.CodeAnalysis.CSharp.CapturedToStateMachineFieldReplacement
                value)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)key, (Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 10776, 10880);
                    return 0;
                }


                bool
                f_10542_10913_10954()
                {
                    var return_v = PreserveInitialParameterValuesAndThreadId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10542, 10913, 10954);
                    return return_v;
                }


                bool
                f_10542_11030_11059(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsStructType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 11030, 11059);
                    return return_v;
                }


                string
                f_10542_11131_11182()
                {
                    var return_v = GeneratedNames.StateMachineThisParameterProxyName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 11131, 11182);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol
                f_10542_11095_11213(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, string
                name, bool
                isPublic, bool
                isThis)
                {
                    var return_v = this_param.StateMachineField((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, name, isPublic: isPublic, isThis: isThis);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 11095, 11213);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CapturedToStateMachineFieldReplacement
                f_10542_11292_11366(Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol
                hoistedField, bool
                isReusable)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CapturedToStateMachineFieldReplacement(hoistedField, isReusable: isReusable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 11292, 11366);
                    return return_v;
                }


                int
                f_10542_11259_11367(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                key, Microsoft.CodeAnalysis.CSharp.CapturedToStateMachineFieldReplacement
                value)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)key, (Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 11259, 11367);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10542_11767_11781(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10542, 11767, 11781);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10542_11744_11782(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                previous)
                {
                    var return_v = this_param.SubstituteType(previous);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 11744, 11782);
                    return return_v;
                }


                string
                f_10542_11789_11803(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10542, 11789, 11803);
                    return return_v;
                }


                bool
                f_10542_11815_11857_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10542, 11815, 11857);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol
                f_10542_11724_11858(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, string
                name, bool
                isPublic)
                {
                    var return_v = this_param.StateMachineField(type, name, isPublic: isPublic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 11724, 11858);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CapturedToStateMachineFieldReplacement
                f_10542_11915_11988(Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol
                hoistedField, bool
                isReusable)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CapturedToStateMachineFieldReplacement(hoistedField, isReusable: isReusable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 11915, 11988);
                    return return_v;
                }


                int
                f_10542_11885_11989(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                key, Microsoft.CodeAnalysis.CSharp.CapturedToStateMachineFieldReplacement
                value)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)key, (Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 11885, 11989);
                    return 0;
                }


                bool
                f_10542_12022_12063()
                {
                    var return_v = PreserveInitialParameterValuesAndThreadId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10542, 12022, 12063);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10542_12176_12190(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10542, 12176, 12190);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10542_12153_12191(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                previous)
                {
                    var return_v = this_param.SubstituteType(previous);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 12153, 12191);
                    return return_v;
                }


                string
                f_10542_12249_12263(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10542, 12249, 12263);
                    return return_v;
                }


                string
                f_10542_12198_12264(string
                parameterName)
                {
                    var return_v = GeneratedNames.StateMachineParameterProxyFieldName(parameterName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 12198, 12264);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol
                f_10542_12133_12281(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, string
                name, bool
                isPublic)
                {
                    var return_v = this_param.StateMachineField(type, name, isPublic: isPublic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 12133, 12281);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CapturedToStateMachineFieldReplacement
                f_10542_12345_12413(Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol
                hoistedField, bool
                isReusable)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CapturedToStateMachineFieldReplacement(hoistedField, isReusable: isReusable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 12345, 12413);
                    return return_v;
                }


                int
                f_10542_12312_12414(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                key, Microsoft.CodeAnalysis.CSharp.CapturedToStateMachineFieldReplacement
                value)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)key, (Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 12312, 12414);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10542_6480_6496_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 6480, 6496);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10542, 5765, 12551);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10542, 5765, 12551);
            }
        }

        private bool ShouldPreallocateNonReusableProxy(LocalSymbol local)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10542, 12563, 13293);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 12653, 12697);

                var
                synthesizedKind = f_10542_12675_12696(local)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 12711, 12775);

                var
                optimizationLevel = f_10542_12735_12774(f_10542_12735_12756(f_10542_12735_12748(F)))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 13041, 13208) || true) && (optimizationLevel == OptimizationLevel.Release && (DynAbs.Tracing.TraceSender.Expression_True(10542, 13045, 13146) && synthesizedKind == SynthesizedLocalKind.UserDefined))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10542, 13041, 13208);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 13180, 13193);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10542, 13041, 13208);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 13224, 13282);

                return !f_10542_13232_13281(synthesizedKind, optimizationLevel);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10542, 12563, 13293);

                Microsoft.CodeAnalysis.SynthesizedLocalKind
                f_10542_12675_12696(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.SynthesizedKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10542, 12675, 12696);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10542_12735_12748(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10542, 12735, 12748);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10542_12735_12756(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10542, 12735, 12756);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OptimizationLevel
                f_10542_12735_12774(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.OptimizationLevel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10542, 12735, 12774);
                    return return_v;
                }


                bool
                f_10542_13232_13281(Microsoft.CodeAnalysis.SynthesizedLocalKind
                kind, Microsoft.CodeAnalysis.OptimizationLevel
                optimizations)
                {
                    var return_v = kind.IsSlotReusable(optimizations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 13232, 13281);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10542, 12563, 13293);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10542, 12563, 13293);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundStatement GenerateKickoffMethodBody()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10542, 13305, 14266);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 13380, 13407);

                F.CurrentFunction = method;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 13421, 13482);

                var
                bodyBuilder = f_10542_13439_13481()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 13498, 13638);

                var
                frameType = (DynAbs.Tracing.TraceSender.Conditional_F1(10542, 13514, 13536) || ((f_10542_13514_13536(method) && DynAbs.Tracing.TraceSender.Conditional_F2(10542, 13539, 13618)) || DynAbs.Tracing.TraceSender.Conditional_F3(10542, 13621, 13637))) ? f_10542_13539_13618(stateMachineType, f_10542_13566_13601(method), unbound: false) : stateMachineType
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 13652, 13723);

                LocalSymbol
                stateMachineVariable = f_10542_13687_13722(F, frameType, null)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 13737, 13806);

                f_10542_13737_13805(this, bodyBuilder, frameType, stateMachineVariable);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 13904, 14006);

                var
                proxies = (DynAbs.Tracing.TraceSender.Conditional_F1(10542, 13918, 13959) || ((f_10542_13918_13959() && DynAbs.Tracing.TraceSender.Conditional_F2(10542, 13962, 13979)) || DynAbs.Tracing.TraceSender.Conditional_F3(10542, 13982, 14005))) ? initialParameters : nonReusableLocalProxies
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 14022, 14110);

                f_10542_14022_14109(
                            bodyBuilder, f_10542_14038_14108(this, stateMachineVariable, frameType, proxies));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 14126, 14255);

                return f_10542_14133_14254(F, f_10542_14159_14202(stateMachineVariable), f_10542_14221_14253(bodyBuilder));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10542, 13305, 14266);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10542_13439_13481()
                {
                    var return_v = ArrayBuilder<BoundStatement>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 13439, 13481);
                    return return_v;
                }


                bool
                f_10542_13514_13536(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsGenericMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10542, 13514, 13536);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10542_13566_13601(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.TypeArgumentsWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10542, 13566, 13601);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10542_13539_13618(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedContainer
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArguments, bool
                unbound)
                {
                    var return_v = this_param.Construct(typeArguments, unbound: unbound);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 13539, 13618);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10542_13687_13722(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.SyntaxNode?
                syntax)
                {
                    var return_v = this_param.SynthesizedLocal((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 13687, 13722);
                    return return_v;
                }


                int
                f_10542_13737_13805(Microsoft.CodeAnalysis.CSharp.StateMachineRewriter
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                bodyBuilder, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                frameType, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                stateMachineLocal)
                {
                    this_param.InitializeStateMachine(bodyBuilder, frameType, stateMachineLocal);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 13737, 13805);
                    return 0;
                }


                bool
                f_10542_13918_13959()
                {
                    var return_v = PreserveInitialParameterValuesAndThreadId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10542, 13918, 13959);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10542_14038_14108(Microsoft.CodeAnalysis.CSharp.StateMachineRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                stateMachineVariable, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                frameType, System.Collections.Generic.IReadOnlyDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement>
                proxies)
                {
                    var return_v = this_param.GenerateStateMachineCreation(stateMachineVariable, frameType, proxies);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 14038, 14108);
                    return return_v;
                }


                int
                f_10542_14022_14109(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 14022, 14109);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10542_14159_14202(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 14159, 14202);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10542_14221_14253(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 14221, 14253);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10542_14133_14254(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements)
                {
                    var return_v = this_param.Block(locals, statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 14133, 14254);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10542, 13305, 14266);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10542, 13305, 14266);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected BoundStatement GenerateParameterStorage(LocalSymbol stateMachineVariable, IReadOnlyDictionary<Symbol, CapturedSymbolReplacement> proxies)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10542, 14278, 15513);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 14450, 14511);

                var
                bodyBuilder = f_10542_14468_14510()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 14574, 14995) || true) && (f_10542_14578_14594_M(!method.IsStatic))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10542, 14574, 14995);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 14628, 14679);

                    f_10542_14628_14678((object)f_10542_14649_14669(method) != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 14699, 14731);

                    CapturedSymbolReplacement
                    proxy
                    = default(CapturedSymbolReplacement);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 14749, 14980) || true) && (f_10542_14753_14805(proxies, f_10542_14773_14793(method), out proxy))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10542, 14749, 14980);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 14847, 14961);

                        f_10542_14847_14960(bodyBuilder, f_10542_14863_14959(F, f_10542_14876_14948(proxy, f_10542_14894_14902(F), frameType1 => F.Local(stateMachineVariable)), f_10542_14950_14958(F)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10542, 14749, 14980);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10542, 14574, 14995);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 15011, 15437);
                    foreach (var parameter in f_10542_15037_15054_I(f_10542_15037_15054(method)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10542, 15011, 15437);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 15088, 15120);

                        CapturedSymbolReplacement
                        proxy
                        = default(CapturedSymbolReplacement);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 15138, 15422) || true) && (f_10542_15142_15183(proxies, parameter, out proxy))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10542, 15138, 15422);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 15225, 15403);

                            f_10542_15225_15402(bodyBuilder, f_10542_15241_15401(F, f_10542_15254_15326(proxy, f_10542_15272_15280(F), frameType1 => F.Local(stateMachineVariable)), f_10542_15378_15400(F, parameter)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10542, 15138, 15422);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10542, 15011, 15437);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10542, 1, 427);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10542, 1, 427);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 15453, 15502);

                return f_10542_15460_15501(F, f_10542_15468_15500(bodyBuilder));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10542, 14278, 15513);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10542_14468_14510()
                {
                    var return_v = ArrayBuilder<BoundStatement>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 14468, 14510);
                    return return_v;
                }


                bool
                f_10542_14578_14594_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10542, 14578, 14594);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10542_14649_14669(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ThisParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10542, 14649, 14669);
                    return return_v;
                }


                int
                f_10542_14628_14678(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 14628, 14678);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10542_14773_14793(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ThisParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10542, 14773, 14793);
                    return return_v;
                }


                bool
                f_10542_14753_14805(System.Collections.Generic.IReadOnlyDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                key, out Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement
                value)
                {
                    var return_v = this_param.TryGetValue((Microsoft.CodeAnalysis.CSharp.Symbol)key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 14753, 14805);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10542_14894_14902(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10542, 14894, 14902);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10542_14876_14948(Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.BoundExpression>
                makeFrame)
                {
                    var return_v = this_param.Replacement(node, makeFrame);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 14876, 14948);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundThisReference
                f_10542_14950_14958(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.This();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 14950, 14958);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10542_14863_14959(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundThisReference
                right)
                {
                    var return_v = this_param.Assignment(left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 14863, 14959);
                    return return_v;
                }


                int
                f_10542_14847_14960(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 14847, 14960);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10542_15037_15054(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10542, 15037, 15054);
                    return return_v;
                }


                bool
                f_10542_15142_15183(System.Collections.Generic.IReadOnlyDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                key, out Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement
                value)
                {
                    var return_v = this_param.TryGetValue((Microsoft.CodeAnalysis.CSharp.Symbol)key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 15142, 15183);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10542_15272_15280(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10542, 15272, 15280);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10542_15254_15326(Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.BoundExpression>
                makeFrame)
                {
                    var return_v = this_param.Replacement(node, makeFrame);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 15254, 15326);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundParameter
                f_10542_15378_15400(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                p)
                {
                    var return_v = this_param.Parameter(p);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 15378, 15400);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10542_15241_15401(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundParameter
                right)
                {
                    var return_v = this_param.Assignment(left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 15241, 15401);
                    return return_v;
                }


                int
                f_10542_15225_15402(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 15225, 15402);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10542_15037_15054_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 15037, 15054);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10542_15468_15500(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 15468, 15500);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10542_15460_15501(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements)
                {
                    var return_v = this_param.Block(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 15460, 15501);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10542, 14278, 15513);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10542, 14278, 15513);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected SynthesizedImplementationMethod OpenMethodImplementation(
                    MethodSymbol methodToImplement,
                    string methodName = null,
                    bool hasMethodBodyDependency = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10542, 15525, 16091);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 15752, 15914);

                var
                result = f_10542_15765_15913(methodName, methodToImplement, (StateMachineTypeSymbol)f_10542_15868_15881(F), null, hasMethodBodyDependency)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 15928, 16011);

                f_10542_15928_16010(f_10542_15928_15946(F), f_10542_15972_15985(F), f_10542_15987_16009(result));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 16025, 16052);

                F.CurrentFunction = result;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 16066, 16080);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10542, 15525, 16091);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10542_15868_15881(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.CurrentType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10542, 15868, 15881);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SynthesizedStateMachineDebuggerHiddenMethod
                f_10542_15765_15913(string?
                name, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                interfaceMethod, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                stateMachineType, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                associatedProperty, bool
                hasMethodBodyDependency)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SynthesizedStateMachineDebuggerHiddenMethod(name, interfaceMethod, (Microsoft.CodeAnalysis.CSharp.StateMachineTypeSymbol?)stateMachineType, associatedProperty, hasMethodBodyDependency);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 15765, 15913);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder?
                f_10542_15928_15946(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.ModuleBuilderOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10542, 15928, 15946);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10542_15972_15985(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.CurrentType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10542, 15972, 15985);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                f_10542_15987_16009(Microsoft.CodeAnalysis.CSharp.SynthesizedStateMachineDebuggerHiddenMethod
                this_param)
                {
                    var return_v = this_param.GetCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 15987, 16009);
                    return return_v;
                }


                int
                f_10542_15928_16010(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder?
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                container, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                method)
                {
                    this_param.AddSynthesizedDefinition(container, (Microsoft.Cci.IMethodDefinition)method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 15928, 16010);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10542, 15525, 16091);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10542, 15525, 16091);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected MethodSymbol OpenPropertyImplementation(MethodSymbol getterToImplement)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10542, 16103, 16632);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 16209, 16314);

                var
                prop = f_10542_16220_16313(getterToImplement, (StateMachineTypeSymbol)f_10542_16299_16312(F))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 16328, 16409);

                f_10542_16328_16408(f_10542_16328_16346(F), f_10542_16372_16385(F), f_10542_16387_16407(prop));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 16425, 16453);

                var
                getter = f_10542_16438_16452(prop)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 16467, 16550);

                f_10542_16467_16549(f_10542_16467_16485(F), f_10542_16511_16524(F), f_10542_16526_16548(getter));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 16566, 16593);

                F.CurrentFunction = getter;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 16607, 16621);

                return getter;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10542, 16103, 16632);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10542_16299_16312(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.CurrentType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10542, 16299, 16312);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedStateMachineProperty
                f_10542_16220_16313(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                interfacePropertyGetter, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                stateMachineType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedStateMachineProperty(interfacePropertyGetter, (Microsoft.CodeAnalysis.CSharp.StateMachineTypeSymbol?)stateMachineType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 16220, 16313);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder?
                f_10542_16328_16346(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.ModuleBuilderOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10542, 16328, 16346);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10542_16372_16385(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.CurrentType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10542, 16372, 16385);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbolAdapter
                f_10542_16387_16407(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedStateMachineProperty
                this_param)
                {
                    var return_v = this_param.GetCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 16387, 16407);
                    return return_v;
                }


                int
                f_10542_16328_16408(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder?
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                container, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbolAdapter
                property)
                {
                    this_param.AddSynthesizedDefinition(container, (Microsoft.Cci.IPropertyDefinition)property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 16328, 16408);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10542_16438_16452(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedStateMachineProperty
                this_param)
                {
                    var return_v = this_param.GetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10542, 16438, 16452);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                f_10542_16467_16485(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.ModuleBuilderOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10542, 16467, 16485);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10542_16511_16524(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.CurrentType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10542, 16511, 16524);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                f_10542_16526_16548(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.GetCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 16526, 16548);
                    return return_v;
                }


                int
                f_10542_16467_16549(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                container, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                method)
                {
                    this_param.AddSynthesizedDefinition(container, (Microsoft.Cci.IMethodDefinition)method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 16467, 16549);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10542, 16103, 16632);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10542, 16103, 16632);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected SynthesizedImplementationMethod OpenMoveNextMethodImplementation(MethodSymbol methodToImplement)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10542, 16644, 17065);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 16775, 16888);

                var
                result = f_10542_16788_16887(methodToImplement, (StateMachineTypeSymbol)f_10542_16873_16886(F))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 16902, 16985);

                f_10542_16902_16984(f_10542_16902_16920(F), f_10542_16946_16959(F), f_10542_16961_16983(result));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 16999, 17026);

                F.CurrentFunction = result;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 17040, 17054);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10542, 16644, 17065);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10542_16873_16886(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.CurrentType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10542, 16873, 16886);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SynthesizedStateMachineMoveNextMethod
                f_10542_16788_16887(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                interfaceMethod, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                stateMachineType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SynthesizedStateMachineMoveNextMethod(interfaceMethod, (Microsoft.CodeAnalysis.CSharp.StateMachineTypeSymbol?)stateMachineType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 16788, 16887);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder?
                f_10542_16902_16920(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.ModuleBuilderOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10542, 16902, 16920);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10542_16946_16959(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.CurrentType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10542, 16946, 16959);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                f_10542_16961_16983(Microsoft.CodeAnalysis.CSharp.SynthesizedStateMachineMoveNextMethod
                this_param)
                {
                    var return_v = this_param.GetCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 16961, 16983);
                    return return_v;
                }


                int
                f_10542_16902_16984(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder?
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                container, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                method)
                {
                    this_param.AddSynthesizedDefinition(container, (Microsoft.Cci.IMethodDefinition)method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 16902, 16984);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10542, 16644, 17065);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10542, 16644, 17065);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected BoundExpression MakeCurrentThreadId()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10542, 17234, 18282);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 17306, 17337);

                f_10542_17306_17336(f_10542_17319_17335(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 17587, 17736);

                var
                currentManagedThreadIdProperty = (PropertySymbol)f_10542_17640_17735(F, WellKnownMember.System_Environment__CurrentManagedThreadId, isOptional: true)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 17750, 18111) || true) && ((object)currentManagedThreadIdProperty != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10542, 17750, 18111);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 17834, 17919);

                    MethodSymbol
                    currentManagedThreadIdMethod = f_10542_17878_17918(currentManagedThreadIdProperty)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 17937, 18096) || true) && ((object)currentManagedThreadIdMethod != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10542, 17937, 18096);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 18027, 18077);

                        return f_10542_18034_18076(F, null, currentManagedThreadIdMethod);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10542, 17937, 18096);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10542, 17750, 18111);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 18127, 18271);

                return f_10542_18134_18270(F, f_10542_18145_18211(F, WellKnownMember.System_Threading_Thread__CurrentThread), WellKnownMember.System_Threading_Thread__ManagedThreadId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10542, 17234, 18282);

                bool
                f_10542_17319_17335(Microsoft.CodeAnalysis.CSharp.StateMachineRewriter
                this_param)
                {
                    var return_v = this_param.CanGetThreadId();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 17319, 17335);
                    return return_v;
                }


                int
                f_10542_17306_17336(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 17306, 17336);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10542_17640_17735(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                wm, bool
                isOptional)
                {
                    var return_v = this_param.WellKnownMember(wm, isOptional: isOptional);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 17640, 17735);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10542_17878_17918(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.GetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10542, 17878, 17918);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10542_18034_18076(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = this_param.Call(receiver, method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 18034, 18076);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10542_18145_18211(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                member)
                {
                    var return_v = this_param.Property(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 18145, 18211);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10542_18134_18270(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiverOpt, Microsoft.CodeAnalysis.WellKnownMember
                member)
                {
                    var return_v = this_param.Property(receiverOpt, member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 18134, 18270);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10542, 17234, 18282);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10542, 17234, 18282);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected SynthesizedImplementationMethod GenerateIteratorGetEnumerator(MethodSymbol getEnumeratorMethod, ref BoundExpression managedThreadId, int initialState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10542, 18450, 23181);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 19422, 19555);

                var
                getEnumerator = f_10542_19442_19554(this, getEnumeratorMethod, hasMethodBodyDependency: false)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 19571, 19632);

                var
                bodyBuilder = f_10542_19589_19631()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 19689, 19753);

                var
                resultVariable = f_10542_19710_19752(F, stateMachineType, null)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 19831, 19961);

                BoundStatement
                makeIterator = f_10542_19861_19960(F, f_10542_19874_19897(F, resultVariable), f_10542_19899_19959(F, f_10542_19905_19933(stateMachineType), f_10542_19935_19958(F, initialState)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 19977, 20034);

                var
                thisInitialized = f_10542_19999_20033(F, "thisInitialized")
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 20050, 21374) || true) && ((object)initialThreadIdField != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10542, 20050, 21374);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 20124, 20164);

                    managedThreadId = f_10542_20142_20163(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 20184, 20246);

                    var
                    thenBuilder = f_10542_20202_20245(4)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 20264, 20313);

                    f_10542_20264_20312(this, thenBuilder, initialState);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 20333, 20459);

                    f_10542_20333_20458(
                                    thenBuilder, f_10542_20410_20457(                    // result = this;
                                        F, f_10542_20423_20446(F, resultVariable), f_10542_20448_20456(F)));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 20479, 20820) || true) && (f_10542_20483_20498(method) || (DynAbs.Tracing.TraceSender.Expression_False(10542, 20483, 20543) || f_10542_20502_20543(f_10542_20502_20527(f_10542_20502_20522(method)))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10542, 20479, 20820);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 20684, 20801);

                        f_10542_20684_20800(                    // if this is a reference type, no need to copy it since it is not assignable
                                            thenBuilder, f_10542_20776_20799(                        // goto thisInitialized;
                                                F, thisInitialized));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10542, 20479, 20820);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 20840, 21359);

                    makeIterator = f_10542_20855_21358(F, condition: f_10542_21003_21231(F, f_10542_21042_21135(F, f_10542_21053_21082(F, f_10542_21061_21069(F), stateField), f_10542_21084_21134(F, StateMachineStates.FinishedStateMachine)), f_10542_21162_21230(F, f_10542_21173_21212(F, f_10542_21181_21189(F), initialThreadIdField), managedThreadId)), thenClause: f_10542_21266_21307(F, f_10542_21274_21306(thenBuilder)), elseClauseOpt: makeIterator);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10542, 20050, 21374);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 21390, 21420);

                f_10542_21390_21419(
                            bodyBuilder, makeIterator);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 21488, 21520);

                var
                copySrc = initialParameters
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 21534, 21573);

                var
                copyDest = nonReusableLocalProxies
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 21587, 22137) || true) && (f_10542_21591_21607_M(!method.IsStatic))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10542, 21587, 22137);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 21682, 21714);

                    CapturedSymbolReplacement
                    proxy
                    = default(CapturedSymbolReplacement);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 21732, 22122) || true) && (f_10542_21736_21789(copyDest, f_10542_21757_21777(method), out proxy))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10542, 21732, 22122);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 21831, 22103);

                        f_10542_21831_22102(bodyBuilder, f_10542_21873_22101(F, f_10542_21916_21988(proxy, f_10542_21934_21942(F), stateMachineType => F.Local(resultVariable)), f_10542_22019_22100(f_10542_22019_22048(copySrc, f_10542_22027_22047(method)), f_10542_22061_22069(F), stateMachineType => F.This())));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10542, 21732, 22122);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10542, 21587, 22137);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 22153, 22195);

                f_10542_22153_22194(
                            bodyBuilder, f_10542_22169_22193(F, thisInitialized));
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 22211, 22958);
                    foreach (var parameter in f_10542_22237_22254_I(f_10542_22237_22254(method)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10542, 22211, 22958);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 22288, 22320);

                        CapturedSymbolReplacement
                        proxy
                        = default(CapturedSymbolReplacement);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 22338, 22943) || true) && (f_10542_22342_22384(copyDest, parameter, out proxy))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10542, 22338, 22943);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 22467, 22574);

                            BoundExpression
                            resultParameter = f_10542_22501_22573(proxy, f_10542_22519_22527(F), stateMachineType => F.Local(resultVariable))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 22640, 22744);

                            BoundExpression
                            parameterProxy = f_10542_22673_22743(f_10542_22673_22691(copySrc, parameter), f_10542_22704_22712(F), stateMachineType => F.This())
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 22766, 22878);

                            BoundStatement
                            copy = f_10542_22788_22877(this, getEnumeratorMethod, parameter, resultParameter, parameterProxy)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 22902, 22924);

                            f_10542_22902_22923(
                                                bodyBuilder, copy);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10542, 22338, 22943);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10542, 22211, 22958);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10542, 1, 748);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10542, 1, 748);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 22974, 23025);

                f_10542_22974_23024(
                            bodyBuilder, f_10542_22990_23023(F, f_10542_22999_23022(F, resultVariable)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 23039, 23135);

                f_10542_23039_23134(F, f_10542_23053_23133(F, f_10542_23061_23098(resultVariable), f_10542_23100_23132(bodyBuilder)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 23149, 23170);

                return getEnumerator;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10542, 18450, 23181);

                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedImplementationMethod
                f_10542_19442_19554(Microsoft.CodeAnalysis.CSharp.StateMachineRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                methodToImplement, bool
                hasMethodBodyDependency)
                {
                    var return_v = this_param.OpenMethodImplementation(methodToImplement, hasMethodBodyDependency: hasMethodBodyDependency);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 19442, 19554);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10542_19589_19631()
                {
                    var return_v = ArrayBuilder<BoundStatement>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 19589, 19631);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10542_19710_19752(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedContainer
                type, Microsoft.CodeAnalysis.SyntaxNode?
                syntax)
                {
                    var return_v = this_param.SynthesizedLocal((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 19710, 19752);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10542_19874_19897(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 19874, 19897);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10542_19905_19933(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedContainer
                this_param)
                {
                    var return_v = this_param.Constructor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10542, 19905, 19933);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLiteral
                f_10542_19935_19958(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, int
                value)
                {
                    var return_v = this_param.Literal(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 19935, 19958);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                f_10542_19899_19959(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                ctor, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                args)
                {
                    var return_v = this_param.New(ctor, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 19899, 19959);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10542_19861_19960(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                left, Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                right)
                {
                    var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 19861, 19960);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                f_10542_19999_20033(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, string
                prefix)
                {
                    var return_v = this_param.GenerateLabel(prefix);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 19999, 20033);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10542_20142_20163(Microsoft.CodeAnalysis.CSharp.StateMachineRewriter
                this_param)
                {
                    var return_v = this_param.MakeCurrentThreadId();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 20142, 20163);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10542_20202_20245(int
                capacity)
                {
                    var return_v = ArrayBuilder<BoundStatement>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 20202, 20245);
                    return return_v;
                }


                int
                f_10542_20264_20312(Microsoft.CodeAnalysis.CSharp.StateMachineRewriter
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                builder, int
                initialState)
                {
                    this_param.GenerateResetInstance(builder, initialState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 20264, 20312);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10542_20423_20446(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 20423, 20446);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundThisReference
                f_10542_20448_20456(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.This();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 20448, 20456);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10542_20410_20457(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                left, Microsoft.CodeAnalysis.CSharp.BoundThisReference
                right)
                {
                    var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 20410, 20457);
                    return return_v;
                }


                int
                f_10542_20333_20458(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 20333, 20458);
                    return 0;
                }


                bool
                f_10542_20483_20498(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10542, 20483, 20498);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10542_20502_20522(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ThisParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10542, 20502, 20522);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10542_20502_20527(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10542, 20502, 20527);
                    return return_v;
                }


                bool
                f_10542_20502_20543(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsReferenceType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10542, 20502, 20543);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                f_10542_20776_20799(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                label)
                {
                    var return_v = this_param.Goto((Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 20776, 20799);
                    return return_v;
                }


                int
                f_10542_20684_20800(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 20684, 20800);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundThisReference
                f_10542_21061_21069(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.This();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 21061, 21069);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                f_10542_21053_21082(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundThisReference
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f)
                {
                    var return_v = this_param.Field((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, f);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 21053, 21082);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLiteral
                f_10542_21084_21134(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, int
                value)
                {
                    var return_v = this_param.Literal(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 21084, 21134);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                f_10542_21042_21135(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                left, Microsoft.CodeAnalysis.CSharp.BoundLiteral
                right)
                {
                    var return_v = this_param.IntEqual((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 21042, 21135);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundThisReference
                f_10542_21181_21189(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.This();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 21181, 21189);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                f_10542_21173_21212(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundThisReference
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f)
                {
                    var return_v = this_param.Field((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, f);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 21173, 21212);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                f_10542_21162_21230(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right)
                {
                    var return_v = this_param.IntEqual((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 21162, 21230);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                f_10542_21003_21231(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                left, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                right)
                {
                    var return_v = this_param.LogicalAnd((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 21003, 21231);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10542_21274_21306(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 21274, 21306);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10542_21266_21307(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements)
                {
                    var return_v = this_param.Block(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 21266, 21307);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10542_20855_21358(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                condition, Microsoft.CodeAnalysis.CSharp.BoundBlock
                thenClause, Microsoft.CodeAnalysis.CSharp.BoundStatement
                elseClauseOpt)
                {
                    var return_v = this_param.If(condition: (Microsoft.CodeAnalysis.CSharp.BoundExpression)condition, thenClause: (Microsoft.CodeAnalysis.CSharp.BoundStatement)thenClause, elseClauseOpt: elseClauseOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 20855, 21358);
                    return return_v;
                }


                int
                f_10542_21390_21419(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 21390, 21419);
                    return 0;
                }


                bool
                f_10542_21591_21607_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10542, 21591, 21607);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10542_21757_21777(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ThisParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10542, 21757, 21777);
                    return return_v;
                }


                bool
                f_10542_21736_21789(System.Collections.Generic.IReadOnlyDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                key, out Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement
                value)
                {
                    var return_v = this_param.TryGetValue((Microsoft.CodeAnalysis.CSharp.Symbol)key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 21736, 21789);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10542_21934_21942(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10542, 21934, 21942);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10542_21916_21988(Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.BoundExpression>
                makeFrame)
                {
                    var return_v = this_param.Replacement(node, makeFrame);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 21916, 21988);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10542_22027_22047(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ThisParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10542, 22027, 22047);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement
                f_10542_22019_22048(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10542, 22019, 22048);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10542_22061_22069(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10542, 22061, 22069);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10542_22019_22100(Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.BoundExpression>
                makeFrame)
                {
                    var return_v = this_param.Replacement(node, makeFrame);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 22019, 22100);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10542_21873_22101(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right)
                {
                    var return_v = this_param.Assignment(left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 21873, 22101);
                    return return_v;
                }


                int
                f_10542_21831_22102(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 21831, 22102);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                f_10542_22169_22193(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                label)
                {
                    var return_v = this_param.Label((Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 22169, 22193);
                    return return_v;
                }


                int
                f_10542_22153_22194(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 22153, 22194);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10542_22237_22254(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10542, 22237, 22254);
                    return return_v;
                }


                bool
                f_10542_22342_22384(System.Collections.Generic.IReadOnlyDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                key, out Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement
                value)
                {
                    var return_v = this_param.TryGetValue((Microsoft.CodeAnalysis.CSharp.Symbol)key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 22342, 22384);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10542_22519_22527(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10542, 22519, 22527);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10542_22501_22573(Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.BoundExpression>
                makeFrame)
                {
                    var return_v = this_param.Replacement(node, makeFrame);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 22501, 22573);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement
                f_10542_22673_22691(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10542, 22673, 22691);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10542_22704_22712(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10542, 22704, 22712);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10542_22673_22743(Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.BoundExpression>
                makeFrame)
                {
                    var return_v = this_param.Replacement(node, makeFrame);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 22673, 22743);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10542_22788_22877(Microsoft.CodeAnalysis.CSharp.StateMachineRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                getEnumeratorMethod, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                parameter, Microsoft.CodeAnalysis.CSharp.BoundExpression
                resultParameter, Microsoft.CodeAnalysis.CSharp.BoundExpression
                parameterProxy)
                {
                    var return_v = this_param.InitializeParameterField(getEnumeratorMethod, parameter, resultParameter, parameterProxy);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 22788, 22877);
                    return return_v;
                }


                int
                f_10542_22902_22923(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 22902, 22923);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10542_22237_22254_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 22237, 22254);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10542_22999_23022(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 22999, 23022);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                f_10542_22990_23023(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                expression)
                {
                    var return_v = this_param.Return((Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 22990, 23023);
                    return return_v;
                }


                int
                f_10542_22974_23024(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 22974, 23024);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10542_23061_23098(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 23061, 23098);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10542_23100_23132(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 23100, 23132);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10542_23053_23133(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements)
                {
                    var return_v = this_param.Block(locals, statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 23053, 23133);
                    return return_v;
                }


                int
                f_10542_23039_23134(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                body)
                {
                    this_param.CloseMethod((Microsoft.CodeAnalysis.CSharp.BoundStatement)body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 23039, 23134);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10542, 18450, 23181);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10542, 18450, 23181);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected virtual void GenerateResetInstance(ArrayBuilder<BoundStatement> builder, int initialState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10542, 23336, 23621);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 23461, 23610);

                f_10542_23461_23609(builder, f_10542_23540_23608(                // this.state = {initialState};
                                F, f_10542_23553_23582(F, f_10542_23561_23569(F), stateField), f_10542_23584_23607(F, initialState)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10542, 23336, 23621);

                Microsoft.CodeAnalysis.CSharp.BoundThisReference
                f_10542_23561_23569(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.This();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 23561, 23569);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                f_10542_23553_23582(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundThisReference
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f)
                {
                    var return_v = this_param.Field((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, f);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 23553, 23582);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLiteral
                f_10542_23584_23607(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, int
                value)
                {
                    var return_v = this_param.Literal(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 23584, 23607);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10542_23540_23608(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                left, Microsoft.CodeAnalysis.CSharp.BoundLiteral
                right)
                {
                    var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 23540, 23608);
                    return return_v;
                }


                int
                f_10542_23461_23609(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 23461, 23609);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10542, 23336, 23621);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10542, 23336, 23621);
            }
        }

        protected virtual BoundStatement InitializeParameterField(MethodSymbol getEnumeratorMethod, ParameterSymbol parameter, BoundExpression resultParameter, BoundExpression parameterProxy)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10542, 23633, 24068);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 23841, 23893);

                f_10542_23841_23892(f_10542_23854_23872_M(!method.IsIterator) || (DynAbs.Tracing.TraceSender.Expression_False(10542, 23854, 23891) || f_10542_23876_23891_M(!method.IsAsync)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 24004, 24057);

                return f_10542_24011_24056(F, resultParameter, parameterProxy);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10542, 23633, 24068);

                bool
                f_10542_23854_23872_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10542, 23854, 23872);
                    return return_v;
                }


                bool
                f_10542_23876_23891_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10542, 23876, 23891);
                    return return_v;
                }


                int
                f_10542_23841_23892(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 23841, 23892);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10542_24011_24056(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right)
                {
                    var return_v = this_param.Assignment(left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 24011, 24056);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10542, 23633, 24068);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10542, 23633, 24068);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected bool CanGetThreadId()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10542, 24238, 24554);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10542, 24294, 24543);

                return (object)f_10542_24309_24402(F, WellKnownMember.System_Threading_Thread__ManagedThreadId, isOptional: true) != null || (DynAbs.Tracing.TraceSender.Expression_False(10542, 24301, 24542) || (object)f_10542_24439_24534(F, WellKnownMember.System_Environment__CurrentManagedThreadId, isOptional: true) != null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10542, 24238, 24554);

                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10542_24309_24402(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                wm, bool
                isOptional)
                {
                    var return_v = this_param.WellKnownMember(wm, isOptional: isOptional);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 24309, 24402);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10542_24439_24534(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                wm, bool
                isOptional)
                {
                    var return_v = this_param.WellKnownMember(wm, isOptional: isOptional);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 24439, 24534);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10542, 24238, 24554);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10542, 24238, 24554);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static StateMachineRewriter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10542, 591, 24561);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10542, 591, 24561);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10542, 591, 24561);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10542, 591, 24561);

        int
        f_10542_1803_1829(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 1803, 1829);
            return 0;
        }


        int
        f_10542_1844_1872(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 1844, 1872);
            return 0;
        }


        int
        f_10542_1887_1933(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 1887, 1933);
            return 0;
        }


        int
        f_10542_1948_1986(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 1948, 1986);
            return 0;
        }


        int
        f_10542_2001_2034(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 2001, 2034);
            return 0;
        }


        Microsoft.CodeAnalysis.CodeGen.SynthesizedLocalOrdinalsDispenser
        f_10542_2259_2298()
        {
            var return_v = new Microsoft.CodeAnalysis.CodeGen.SynthesizedLocalOrdinalsDispenser();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 2259, 2298);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
        f_10542_2369_2450(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        topLevelMethod, Microsoft.CodeAnalysis.SyntaxNode
        node, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
        compilationState, Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory(topLevelMethod, node, compilationState, diagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 2369, 2450);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
        f_10542_2496_2509(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
        this_param)
        {
            var return_v = this_param.CurrentType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10542, 2496, 2509);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10542_2511_2532(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.ContainingType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10542, 2511, 2532);
            return return_v;
        }


        bool
        f_10542_2478_2570(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
        left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        right, Microsoft.CodeAnalysis.TypeCompareKind
        comparison)
        {
            var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?)left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 2478, 2570);
            return return_v;
        }


        int
        f_10542_2465_2571(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 2465, 2571);
            return 0;
        }


        Microsoft.CodeAnalysis.SyntaxNode
        f_10542_2599_2607(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
        this_param)
        {
            var return_v = this_param.Syntax;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10542, 2599, 2607);
            return return_v;
        }


        int
        f_10542_2586_2623(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10542, 2586, 2623);
            return 0;
        }

    }
}
