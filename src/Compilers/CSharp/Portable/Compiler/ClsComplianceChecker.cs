// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class ClsComplianceChecker : CSharpSymbolVisitor
    {
        private readonly CSharpCompilation _compilation;

        private readonly SyntaxTree _filterTree;

        private readonly TextSpan? _filterSpanWithinTree;

        private readonly ConcurrentQueue<Diagnostic> _diagnostics;

        private readonly CancellationToken _cancellationToken;

        private readonly ConcurrentDictionary<Symbol, Compliance> _declaredOrInheritedCompliance;

        private readonly ConcurrentStack<Task> _compilerTasks;

        private ClsComplianceChecker(
                    CSharpCompilation compilation,
                    SyntaxTree filterTree,
                    TextSpan? filterSpanWithinTree,
                    ConcurrentQueue<Diagnostic> diagnostics,
                    CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10621, 1493, 2283);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 815, 827);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 866, 877);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 976, 997);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 1176, 1188);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 1323, 1353);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 1466, 1480);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 1776, 1803);

                _compilation = compilation;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 1817, 1842);

                _filterTree = filterTree;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 1856, 1901);

                _filterSpanWithinTree = filterSpanWithinTree;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 1915, 1942);

                _diagnostics = diagnostics;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 1956, 1995);

                _cancellationToken = cancellationToken;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 2011, 2140);

                _declaredOrInheritedCompliance = f_10621_2044_2139(Symbols.SymbolEqualityComparer.ConsiderEverything);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 2156, 2272) || true) && (f_10621_2160_2178())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 2156, 2272);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 2212, 2257);

                    _compilerTasks = f_10621_2229_2256();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 2156, 2272);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10621, 1493, 2283);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10621, 1493, 2283);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10621, 1493, 2283);
            }
        }

        private bool ConcurrentAnalysis
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10621, 2489, 2551);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 2492, 2551);
                    return _filterTree == null && (DynAbs.Tracing.TraceSender.Expression_True(10621, 2492, 2551) && f_10621_2515_2551(f_10621_2515_2535(_compilation))); DynAbs.Tracing.TraceSender.TraceExitMethod(10621, 2489, 2551);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10621, 2489, 2551);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10621, 2489, 2551);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static void CheckCompliance(CSharpCompilation compilation, DiagnosticBag diagnostics, CancellationToken cancellationToken, SyntaxTree filterTree = null, TextSpan? filterSpanWithinTree = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10621, 3297, 3912);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 3520, 3566);

                var
                queue = f_10621_3532_3565()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 3580, 3692);

                var
                checker = f_10621_3594_3691(compilation, filterTree, filterSpanWithinTree, queue, cancellationToken)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 3706, 3742);

                f_10621_3706_3741(checker, f_10621_3720_3740(compilation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 3756, 3781);

                f_10621_3756_3780(checker);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 3797, 3901);
                    foreach (Diagnostic diag in f_10621_3825_3830_I(queue))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 3797, 3901);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 3864, 3886);

                        f_10621_3864_3885(diagnostics, diag);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 3797, 3901);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10621, 1, 105);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10621, 1, 105);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10621, 3297, 3912);

                System.Collections.Concurrent.ConcurrentQueue<Microsoft.CodeAnalysis.Diagnostic>
                f_10621_3532_3565()
                {
                    var return_v = new System.Collections.Concurrent.ConcurrentQueue<Microsoft.CodeAnalysis.Diagnostic>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 3532, 3565);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                f_10621_3594_3691(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.SyntaxTree?
                filterTree, Microsoft.CodeAnalysis.Text.TextSpan?
                filterSpanWithinTree, System.Collections.Concurrent.ConcurrentQueue<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker(compilation, filterTree, filterSpanWithinTree, diagnostics, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 3594, 3691);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10621_3720_3740(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 3720, 3740);
                    return return_v;
                }


                int
                f_10621_3706_3741(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                symbol)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 3706, 3741);
                    return 0;
                }


                int
                f_10621_3756_3780(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param)
                {
                    this_param.WaitForWorkers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 3756, 3780);
                    return 0;
                }


                int
                f_10621_3864_3885(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diag)
                {
                    this_param.Add(diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 3864, 3885);
                    return 0;
                }


                System.Collections.Concurrent.ConcurrentQueue<Microsoft.CodeAnalysis.Diagnostic>
                f_10621_3825_3830_I(System.Collections.Concurrent.ConcurrentQueue<Microsoft.CodeAnalysis.Diagnostic>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 3825, 3830);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10621, 3297, 3912);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10621, 3297, 3912);
            }
        }

        public override void VisitAssembly(AssemblySymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10621, 3924, 8111);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 4006, 4056);

                _cancellationToken.ThrowIfCancellationRequested();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 4072, 4136);

                f_10621_4072_4135(symbol is SourceAssemblySymbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 4152, 4225);

                Compliance
                assemblyCompliance = f_10621_4184_4224(this, symbol)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 4241, 5348) || true) && (assemblyCompliance == Compliance.DeclaredFalse)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 4241, 5348);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 5326, 5333);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 4241, 5348);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 5364, 5422);

                bool
                assemblyComplianceValue = f_10621_5395_5421(assemblyCompliance)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 5447, 5452);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 5438, 7687) || true) && (i < symbol.Modules.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 5481, 5484)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 5438, 7687))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 5438, 7687);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 5518, 5558);

                        ModuleSymbol
                        module = f_10621_5540_5554(symbol)[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 5576, 5603);

                        Location
                        attributeLocation
                        = default(Location);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 5621, 5707);

                        bool?
                        moduleDeclaredCompliance = f_10621_5654_5706(this, module, out attributeLocation)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 5727, 5803);

                        Location
                        warningLocation = (DynAbs.Tracing.TraceSender.Conditional_F1(10621, 5754, 5760) || ((i == 0 && DynAbs.Tracing.TraceSender.Conditional_F2(10621, 5763, 5780)) || DynAbs.Tracing.TraceSender.Conditional_F3(10621, 5783, 5802))) ? attributeLocation : f_10621_5783_5799(module)[0]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 5821, 6034);

                        f_10621_5821_6033(warningLocation != null || (DynAbs.Tracing.TraceSender.Expression_False(10621, 5853, 5914) || f_10621_5880_5914_M(!moduleDeclaredCompliance.HasValue)) || (DynAbs.Tracing.TraceSender.Expression_False(10621, 5853, 5949) || (i == 0 && (DynAbs.Tracing.TraceSender.Expression_True(10621, 5919, 5948) && _filterTree != null))), "Can only be null when the source location is filtered out.");

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 6054, 7672) || true) && (f_10621_6058_6091(moduleDeclaredCompliance))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 6054, 7672);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 6133, 6784) || true) && (warningLocation != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 6133, 6784);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 6210, 6761) || true) && (!f_10621_6215_6245(assemblyCompliance))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 6210, 6761);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 6406, 6474);

                                    f_10621_6406_6473(                            // This is not useful on non-source modules, but dev11 reports it anyway.
                                                                this, ErrorCode.WRN_CLS_NotOnModules, warningLocation);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 6210, 6761);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 6210, 6761);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 6532, 6761) || true) && (assemblyComplianceValue != f_10621_6563_6607(moduleDeclaredCompliance))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 6532, 6761);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 6665, 6734);

                                        f_10621_6665_6733(this, ErrorCode.WRN_CLS_NotOnModules2, warningLocation);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 6532, 6761);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 6210, 6761);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 6133, 6784);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 6054, 7672);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 6054, 7672);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 6826, 7672) || true) && (assemblyComplianceValue && (DynAbs.Tracing.TraceSender.Expression_True(10621, 6830, 6862) && i > 0))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 6826, 7672);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 6904, 6942);

                                bool
                                sawClsCompliantAttribute = false
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 6964, 7022);

                                var
                                peModule = (Symbols.Metadata.PE.PEModuleSymbol)module
                                ;
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 7044, 7455);
                                    foreach (CSharpAttributeData assemblyLevelAttribute in f_10621_7099_7131_I(f_10621_7099_7131(peModule)))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 7044, 7455);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 7181, 7432) || true) && (f_10621_7185_7279(assemblyLevelAttribute, peModule, AttributeDescription.CLSCompliantAttribute))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 7181, 7432);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 7337, 7369);

                                            sawClsCompliantAttribute = true;
                                            DynAbs.Tracing.TraceSender.TraceBreak(10621, 7399, 7405);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 7181, 7432);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 7044, 7455);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10621, 1, 412);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(10621, 1, 412);
                                }
                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 7479, 7653) || true) && (!sawClsCompliantAttribute)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 7479, 7653);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 7558, 7630);

                                    f_10621_7558_7629(this, ErrorCode.WRN_CLS_ModuleMissingCLS, warningLocation);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 7479, 7653);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 6826, 7672);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 6054, 7672);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10621, 1, 2250);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10621, 1, 2250);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 7703, 7822) || true) && (assemblyComplianceValue)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 7703, 7822);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 7764, 7807);

                    f_10621_7764_7806(this, symbol);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 7703, 7822);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 7838, 7884);

                ModuleSymbol
                sourceModule = f_10621_7866_7880(symbol)[0]
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 7898, 8054) || true) && (f_10621_7902_7956(f_10621_7909_7955(this, sourceModule)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 7898, 8054);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 7990, 8039);

                    f_10621_7990_8038(this, sourceModule);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 7898, 8054);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 8070, 8100);

                f_10621_8070_8099(this, f_10621_8076_8098(symbol));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10621, 3924, 8111);

                int
                f_10621_4072_4135(bool
                condition)
                {
                    System.Diagnostics.Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 4072, 4135);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker.Compliance
                f_10621_4184_4224(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                symbol)
                {
                    var return_v = this_param.GetDeclaredOrInheritedCompliance((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 4184, 4224);
                    return return_v;
                }


                bool
                f_10621_5395_5421(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker.Compliance
                compliance)
                {
                    var return_v = IsTrue(compliance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 5395, 5421);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                f_10621_5540_5554(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.Modules;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 5540, 5554);
                    return return_v;
                }


                bool?
                f_10621_5654_5706(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                symbol, out Microsoft.CodeAnalysis.Location
                attributeLocation)
                {
                    var return_v = this_param.GetDeclaredCompliance((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, out attributeLocation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 5654, 5706);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10621_5783_5799(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 5783, 5799);
                    return return_v;
                }


                bool
                f_10621_5880_5914_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 5880, 5914);
                    return return_v;
                }


                int
                f_10621_5821_6033(bool
                condition, string
                message)
                {
                    System.Diagnostics.Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 5821, 6033);
                    return 0;
                }


                bool
                f_10621_6058_6091(bool?
                this_param)
                {
                    var return_v = this_param.HasValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 6058, 6091);
                    return return_v;
                }


                bool
                f_10621_6215_6245(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker.Compliance
                compliance)
                {
                    var return_v = IsDeclared(compliance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 6215, 6245);
                    return return_v;
                }


                int
                f_10621_6406_6473(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    this_param.AddDiagnostic(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 6406, 6473);
                    return 0;
                }


                bool
                f_10621_6563_6607(bool?
                this_param)
                {
                    var return_v = this_param.GetValueOrDefault();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 6563, 6607);
                    return return_v;
                }


                int
                f_10621_6665_6733(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    this_param.AddDiagnostic(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 6665, 6733);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10621_7099_7131(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param)
                {
                    var return_v = this_param.GetAssemblyAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 7099, 7131);
                    return return_v;
                }


                bool
                f_10621_7185_7279(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 7185, 7279);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10621_7099_7131_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 7099, 7131);
                    return return_v;
                }


                int
                f_10621_7558_7629(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location?
                location)
                {
                    this_param.AddDiagnostic(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 7558, 7629);
                    return 0;
                }


                int
                f_10621_7764_7806(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                symbol)
                {
                    this_param.CheckForAttributeWithArrayArgument((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 7764, 7806);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                f_10621_7866_7880(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.Modules;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 7866, 7880);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker.Compliance
                f_10621_7909_7955(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                symbol)
                {
                    var return_v = this_param.GetDeclaredOrInheritedCompliance((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 7909, 7955);
                    return return_v;
                }


                bool
                f_10621_7902_7956(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker.Compliance
                compliance)
                {
                    var return_v = IsTrue(compliance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 7902, 7956);
                    return return_v;
                }


                int
                f_10621_7990_8038(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                symbol)
                {
                    this_param.CheckForAttributeWithArrayArgument((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 7990, 8038);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_10621_8076_8098(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 8076, 8098);
                    return return_v;
                }


                int
                f_10621_8070_8099(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                symbol)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 8070, 8099);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10621, 3924, 8111);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10621, 3924, 8111);
            }
        }

        private void WaitForWorkers()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10621, 8123, 8437);
                System.Threading.Tasks.Task curTask = default(System.Threading.Tasks.Task);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 8177, 8204);

                var
                tasks = _compilerTasks
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 8218, 8291) || true) && (tasks == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 8218, 8291);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 8269, 8276);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 8218, 8291);
                }
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 8307, 8426) || true) && (f_10621_8314_8344(tasks, out curTask))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 8307, 8426);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 8378, 8411);

                        f_10621_8378_8398(curTask).GetResult();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 8307, 8426);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10621, 8307, 8426);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10621, 8307, 8426);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10621, 8123, 8437);

                bool
                f_10621_8314_8344(System.Collections.Concurrent.ConcurrentStack<System.Threading.Tasks.Task>
                this_param, out System.Threading.Tasks.Task
                result)
                {
                    var return_v = this_param.TryPop(out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 8314, 8344);
                    return return_v;
                }


                System.Runtime.CompilerServices.TaskAwaiter
                f_10621_8378_8398(System.Threading.Tasks.Task
                this_param)
                {
                    var return_v = this_param.GetAwaiter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 8378, 8398);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10621, 8123, 8437);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10621, 8123, 8437);
            }
        }

        public override void VisitNamespace(NamespaceSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10621, 8449, 9046);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 8533, 8583);

                _cancellationToken.ThrowIfCancellationRequested();

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 8599, 8630) || true) && (f_10621_8603_8621(this, symbol))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 8599, 8630);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 8623, 8630);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 8599, 8630);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 8646, 8815) || true) && (f_10621_8650_8698(f_10621_8657_8697(this, symbol)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 8646, 8815);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 8732, 8750);

                    f_10621_8732_8749(this, symbol);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 8768, 8800);

                    f_10621_8768_8799(this, symbol);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 8646, 8815);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 8831, 9035) || true) && (f_10621_8835_8853())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 8831, 9035);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 8887, 8924);

                    f_10621_8887_8923(this, symbol);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 8831, 9035);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 8831, 9035);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 8990, 9020);

                    f_10621_8990_9019(this, symbol);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 8831, 9035);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10621, 8449, 9046);

                bool
                f_10621_8603_8621(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                symbol)
                {
                    var return_v = this_param.DoNotVisit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 8603, 8621);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker.Compliance
                f_10621_8657_8697(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                symbol)
                {
                    var return_v = this_param.GetDeclaredOrInheritedCompliance((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 8657, 8697);
                    return return_v;
                }


                bool
                f_10621_8650_8698(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker.Compliance
                compliance)
                {
                    var return_v = IsTrue(compliance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 8650, 8698);
                    return return_v;
                }


                int
                f_10621_8732_8749(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                symbol)
                {
                    this_param.CheckName((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 8732, 8749);
                    return 0;
                }


                int
                f_10621_8768_8799(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                symbol)
                {
                    this_param.CheckMemberDistinctness((Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 8768, 8799);
                    return 0;
                }


                bool
                f_10621_8835_8853()
                {
                    var return_v = ConcurrentAnalysis;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 8835, 8853);
                    return return_v;
                }


                int
                f_10621_8887_8923(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                symbol)
                {
                    this_param.VisitNamespaceMembersAsTasks(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 8887, 8923);
                    return 0;
                }


                int
                f_10621_8990_9019(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                symbol)
                {
                    this_param.VisitNamespaceMembers(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 8990, 9019);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10621, 8449, 9046);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10621, 8449, 9046);
            }
        }

        private void VisitNamespaceMembersAsTasks(NamespaceSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10621, 9058, 9700);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 9148, 9689);
                    foreach (var m in f_10621_9166_9194_I(f_10621_9166_9194(symbol)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 9148, 9689);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 9228, 9674);

                        f_10621_9228_9673(_compilerTasks, f_10621_9248_9672(f_10621_9257_9651(() =>
                        {
                            try
                            {
                                Visit(m);
                            }
                            catch (Exception e) when (FatalError.ReportAndPropagateUnlessCanceled(e))
                            {
                                throw ExceptionUtilities.Unreachable;
                            }
                        }), _cancellationToken));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 9148, 9689);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10621, 1, 542);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10621, 1, 542);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10621, 9058, 9700);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10621_9166_9194(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param)
                {
                    var return_v = this_param.GetMembersUnordered();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 9166, 9194);
                    return return_v;
                }


                System.Action
                f_10621_9257_9651(System.Action
                action)
                {
                    var return_v = UICultureUtilities.WithCurrentUICulture(action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 9257, 9651);
                    return return_v;
                }


                System.Threading.Tasks.Task
                f_10621_9248_9672(System.Action
                action, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = Task.Run(action, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 9248, 9672);
                    return return_v;
                }


                int
                f_10621_9228_9673(System.Collections.Concurrent.ConcurrentStack<System.Threading.Tasks.Task>
                this_param, System.Threading.Tasks.Task
                item)
                {
                    this_param.Push(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 9228, 9673);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10621_9166_9194_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 9166, 9194);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10621, 9058, 9700);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10621, 9058, 9700);
            }
        }

        private void VisitNamespaceMembers(NamespaceSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10621, 9712, 9910);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 9795, 9899);
                    foreach (var m in f_10621_9813_9841_I(f_10621_9813_9841(symbol)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 9795, 9899);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 9875, 9884);

                        f_10621_9875_9883(this, m);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 9795, 9899);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10621, 1, 105);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10621, 1, 105);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10621, 9712, 9910);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10621_9813_9841(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param)
                {
                    var return_v = this_param.GetMembersUnordered();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 9813, 9841);
                    return return_v;
                }


                int
                f_10621_9875_9883(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    this_param.Visit(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 9875, 9883);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10621_9813_9841_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 9813, 9841);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10621, 9712, 9910);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10621, 9712, 9910);
            }
        }

        [PerformanceSensitive("https://github.com/dotnet/roslyn/issues/23582", IsParallelEntry = false)]
        public override void VisitNamedType(NamedTypeSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10621, 9922, 11415);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 10112, 10162);

                _cancellationToken.ThrowIfCancellationRequested();

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 10178, 10209) || true) && (f_10621_10182_10200(this, symbol))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 10178, 10209);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 10202, 10209);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 10178, 10209);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 10225, 10263);

                f_10621_10225_10262(f_10621_10238_10261_M(!symbol.IsImplicitClass));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 10279, 10344);

                Compliance
                compliance = f_10621_10303_10343(this, symbol)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 10360, 11127) || true) && (f_10621_10364_10401(this, symbol, compliance))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 10360, 11127);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 10435, 11112) || true) && (f_10621_10439_10457(compliance))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 10435, 11112);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 10499, 10531);

                        f_10621_10499_10530(this, symbol);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 10553, 10613);

                        f_10621_10553_10612(this, f_10621_10582_10603(symbol), symbol);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 10637, 11093) || true) && (f_10621_10641_10656(symbol) == TypeKind.Delegate)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 10637, 11093);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 10727, 10800);

                            f_10621_10727_10799(this, f_10621_10752_10790(f_10621_10752_10779(symbol)), symbol);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 10637, 11093);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 10637, 11093);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 10850, 11093) || true) && (f_10621_10854_10890(_compilation, symbol) && (DynAbs.Tracing.TraceSender.Expression_True(10621, 10854, 10936) && !f_10621_10895_10936(this, symbol)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 10850, 11093);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 10986, 11070);

                                f_10621_10986_11069(this, ErrorCode.WRN_CLS_BadAttributeType, f_10621_11041_11057(symbol)[0], symbol);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 10850, 11093);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 10637, 11093);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 10435, 11112);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 10360, 11127);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 11300, 11404);
                    foreach (var m in f_10621_11318_11346_I(f_10621_11318_11346(symbol)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 11300, 11404);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 11380, 11389);

                        f_10621_11380_11388(this, m);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 11300, 11404);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10621, 1, 105);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10621, 1, 105);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10621, 9922, 11415);

                bool
                f_10621_10182_10200(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = this_param.DoNotVisit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 10182, 10200);
                    return return_v;
                }


                bool
                f_10621_10238_10261_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 10238, 10261);
                    return return_v;
                }


                int
                f_10621_10225_10262(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 10225, 10262);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker.Compliance
                f_10621_10303_10343(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = this_param.GetDeclaredOrInheritedCompliance((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 10303, 10343);
                    return return_v;
                }


                bool
                f_10621_10364_10401(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol, Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker.Compliance
                compliance)
                {
                    var return_v = this_param.VisitTypeOrMember((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, compliance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 10364, 10401);
                    return return_v;
                }


                bool
                f_10621_10439_10457(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker.Compliance
                compliance)
                {
                    var return_v = IsTrue(compliance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 10439, 10457);
                    return return_v;
                }


                int
                f_10621_10499_10530(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    this_param.CheckBaseTypeCompliance(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 10499, 10530);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10621_10582_10603(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 10582, 10603);
                    return return_v;
                }


                int
                f_10621_10553_10612(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                typeParameters, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                context)
                {
                    this_param.CheckTypeParameterCompliance(typeParameters, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 10553, 10612);
                    return 0;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10621_10641_10656(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 10641, 10656);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10621_10752_10779(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DelegateInvokeMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 10752, 10779);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10621_10752_10790(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 10752, 10790);
                    return return_v;
                }


                int
                f_10621_10727_10799(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                context)
                {
                    this_param.CheckParameterCompliance(parameters, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 10727, 10799);
                    return 0;
                }


                bool
                f_10621_10854_10890(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = this_param.IsAttributeType((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 10854, 10890);
                    return return_v;
                }


                bool
                f_10621_10895_10936(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                attributeType)
                {
                    var return_v = this_param.HasAcceptableAttributeConstructor(attributeType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 10895, 10936);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10621_11041_11057(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 11041, 11057);
                    return return_v;
                }


                int
                f_10621_10986_11069(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    this_param.AddDiagnostic(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 10986, 11069);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10621_11318_11346(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembersUnordered();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 11318, 11346);
                    return return_v;
                }


                int
                f_10621_11380_11388(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    this_param.Visit(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 11380, 11388);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10621_11318_11346_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 11318, 11346);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10621, 9922, 11415);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10621, 9922, 11415);
            }
        }

        private bool HasAcceptableAttributeConstructor(NamedTypeSymbol attributeType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10621, 11427, 12743);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 11529, 12703);
                    foreach (MethodSymbol constructor in f_10621_11566_11600_I(f_10621_11566_11600(attributeType)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 11529, 12703);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 11634, 12688) || true) && (f_10621_11638_11691(f_10621_11645_11690(this, constructor)) && (DynAbs.Tracing.TraceSender.Expression_True(10621, 11638, 11743) && f_10621_11695_11743(constructor)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 11634, 12688);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 11785, 11919);

                            f_10621_11785_11918(f_10621_11817_11857(constructor), "Should be implied by IsAccessibleIfContainerIsAccessible");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 11943, 11985);

                            bool
                            hasUnacceptableParameterType = false
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 12009, 12527);
                                foreach (var paramType in f_10621_12035_12076_I(f_10621_12035_12076(constructor)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 12009, 12527);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 12180, 12504) || true) && (paramType.TypeKind == TypeKind.Array || (DynAbs.Tracing.TraceSender.Expression_False(10621, 12184, 12347) || f_10621_12253_12320(paramType.Type, _compilation) == TypedConstantKind.Error))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 12180, 12504);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 12405, 12441);

                                        hasUnacceptableParameterType = true;
                                        DynAbs.Tracing.TraceSender.TraceBreak(10621, 12471, 12477);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 12180, 12504);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 12009, 12527);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10621, 1, 519);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10621, 1, 519);
                            }
                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 12551, 12669) || true) && (!hasUnacceptableParameterType)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 12551, 12669);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 12634, 12646);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 12551, 12669);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 11634, 12688);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 11529, 12703);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10621, 1, 1175);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10621, 1, 1175);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 12719, 12732);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10621, 11427, 12743);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10621_11566_11600(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.InstanceConstructors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 11566, 11600);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker.Compliance
                f_10621_11645_11690(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol)
                {
                    var return_v = this_param.GetDeclaredOrInheritedCompliance((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 11645, 11690);
                    return return_v;
                }


                bool
                f_10621_11638_11691(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker.Compliance
                compliance)
                {
                    var return_v = IsTrue(compliance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 11638, 11691);
                    return return_v;
                }


                bool
                f_10621_11695_11743(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol)
                {
                    var return_v = IsAccessibleIfContainerIsAccessible((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 11695, 11743);
                    return return_v;
                }


                bool
                f_10621_11817_11857(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol)
                {
                    var return_v = IsAccessibleOutsideAssembly((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 11817, 11857);
                    return return_v;
                }


                int
                f_10621_11785_11918(bool
                condition, string
                message)
                {
                    System.Diagnostics.Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 11785, 11918);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10621_12035_12076(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterTypesWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 12035, 12076);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypedConstantKind
                f_10621_12253_12320(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = type.GetAttributeParameterTypedConstantKind(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 12253, 12320);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10621_12035_12076_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 12035, 12076);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10621_11566_11600_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 11566, 11600);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10621, 11427, 12743);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10621, 11427, 12743);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override void VisitMethod(MethodSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10621, 12755, 13982);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 12833, 12883);

                _cancellationToken.ThrowIfCancellationRequested();

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 12899, 12930) || true) && (f_10621_12903_12921(this, symbol))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 12899, 12930);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 12923, 12930);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 12899, 12930);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 12946, 13011);

                Compliance
                compliance = f_10621_12970_13010(this, symbol)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 13085, 13488) || true) && (f_10621_13089_13108(symbol))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 13085, 13488);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 13142, 13178);

                    f_10621_13142_13177(this, symbol);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 13196, 13246);

                    f_10621_13196_13245(this, f_10621_13227_13244(symbol));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 13264, 13300);

                    f_10621_13264_13299(this, symbol);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 13320, 13446) || true) && (f_10621_13324_13342(compliance))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 13320, 13446);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 13384, 13427);

                        f_10621_13384_13426(this, symbol);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 13320, 13446);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 13466, 13473);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 13085, 13488);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 13504, 13555) || true) && (!f_10621_13509_13546(this, symbol, compliance))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 13504, 13555);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 13548, 13555);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 13504, 13555);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 13571, 13971) || true) && (f_10621_13575_13593(compliance))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 13571, 13971);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 13627, 13694);

                    f_10621_13627_13693(this, f_10621_13652_13669(symbol), f_10621_13671_13692(symbol));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 13712, 13787);

                    f_10621_13712_13786(this, f_10621_13741_13762(symbol), f_10621_13764_13785(symbol));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 13807, 13956) || true) && (f_10621_13811_13826(symbol))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 13807, 13956);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 13868, 13937);

                        f_10621_13868_13936(this, ErrorCode.WRN_CLS_NoVarArgs, f_10621_13916_13932(symbol)[0]);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 13807, 13956);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 13571, 13971);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10621, 12755, 13982);

                bool
                f_10621_12903_12921(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol)
                {
                    var return_v = this_param.DoNotVisit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 12903, 12921);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker.Compliance
                f_10621_12970_13010(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol)
                {
                    var return_v = this_param.GetDeclaredOrInheritedCompliance((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 12970, 13010);
                    return return_v;
                }


                bool
                f_10621_13089_13108(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                methodSymbol)
                {
                    var return_v = methodSymbol.IsAccessor();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 13089, 13108);
                    return return_v;
                }


                int
                f_10621_13142_13177(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol)
                {
                    this_param.CheckForAttributeOnAccessor(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 13142, 13177);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10621_13227_13244(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 13227, 13244);
                    return return_v;
                }


                int
                f_10621_13196_13245(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters)
                {
                    this_param.CheckForMeaninglessOnParameter(parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 13196, 13245);
                    return 0;
                }


                int
                f_10621_13264_13299(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    this_param.CheckForMeaninglessOnReturn(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 13264, 13299);
                    return 0;
                }


                bool
                f_10621_13324_13342(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker.Compliance
                compliance)
                {
                    var return_v = IsTrue(compliance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 13324, 13342);
                    return return_v;
                }


                int
                f_10621_13384_13426(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol)
                {
                    this_param.CheckForAttributeWithArrayArgument((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 13384, 13426);
                    return 0;
                }


                bool
                f_10621_13509_13546(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol, Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker.Compliance
                compliance)
                {
                    var return_v = this_param.VisitTypeOrMember((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, compliance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 13509, 13546);
                    return return_v;
                }


                bool
                f_10621_13575_13593(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker.Compliance
                compliance)
                {
                    var return_v = IsTrue(compliance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 13575, 13593);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10621_13652_13669(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 13652, 13669);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10621_13671_13692(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 13671, 13692);
                    return return_v;
                }


                int
                f_10621_13627_13693(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                context)
                {
                    this_param.CheckParameterCompliance(parameters, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 13627, 13693);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10621_13741_13762(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 13741, 13762);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10621_13764_13785(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 13764, 13785);
                    return return_v;
                }


                int
                f_10621_13712_13786(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                typeParameters, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                context)
                {
                    this_param.CheckTypeParameterCompliance(typeParameters, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 13712, 13786);
                    return 0;
                }


                bool
                f_10621_13811_13826(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsVararg;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 13811, 13826);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10621_13916_13932(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 13916, 13932);
                    return return_v;
                }


                int
                f_10621_13868_13936(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    this_param.AddDiagnostic(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 13868, 13936);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10621, 12755, 13982);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10621, 12755, 13982);
            }
        }

        private void CheckForAttributeOnAccessor(MethodSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10621, 13994, 14835);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 14080, 14824);
                    foreach (CSharpAttributeData attribute in f_10621_14122_14144_I(f_10621_14122_14144(symbol)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 14080, 14824);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 14178, 14809) || true) && (f_10621_14182_14261(attribute, symbol, AttributeDescription.CLSCompliantAttribute))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 14178, 14809);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 14303, 14330);

                            Location
                            attributeLocation
                            = default(Location);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 14352, 14790) || true) && (f_10621_14356_14420(this, attribute, out attributeLocation))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 14352, 14790);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 14470, 14555);

                                AttributeUsageInfo
                                attributeUsage = f_10621_14506_14554(f_10621_14506_14530(attribute))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 14581, 14735);

                                f_10621_14581_14734(this, ErrorCode.ERR_AttributeNotOnAccessor, attributeLocation, f_10621_14657_14686(f_10621_14657_14681(attribute)), attributeUsage.GetValidTargetsErrorArgument());
                                DynAbs.Tracing.TraceSender.TraceBreak(10621, 14761, 14767);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 14352, 14790);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 14178, 14809);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 14080, 14824);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10621, 1, 745);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10621, 1, 745);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10621, 13994, 14835);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10621_14122_14144(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.GetAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 14122, 14144);
                    return return_v;
                }


                bool
                f_10621_14182_14261(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 14182, 14261);
                    return return_v;
                }


                bool
                f_10621_14356_14420(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                attribute, out Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = this_param.TryGetAttributeWarningLocation(attribute, out location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 14356, 14420);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10621_14506_14530(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.AttributeClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 14506, 14530);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AttributeUsageInfo
                f_10621_14506_14554(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                this_param)
                {
                    var return_v = this_param.GetAttributeUsageInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 14506, 14554);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10621_14657_14681(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.AttributeClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 14657, 14681);
                    return return_v;
                }


                string
                f_10621_14657_14686(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 14657, 14686);
                    return return_v;
                }


                int
                f_10621_14581_14734(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    this_param.AddDiagnostic(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 14581, 14734);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10621_14122_14144_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 14122, 14144);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10621, 13994, 14835);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10621, 13994, 14835);
            }
        }

        public override void VisitProperty(PropertySymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10621, 14847, 15731);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 14929, 14979);

                _cancellationToken.ThrowIfCancellationRequested();

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 14995, 15026) || true) && (f_10621_14999_15017(this, symbol))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 14995, 15026);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 15019, 15026);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 14995, 15026);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 15042, 15107);

                Compliance
                compliance = f_10621_15066_15106(this, symbol)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 15123, 15174) || true) && (!f_10621_15128_15165(this, symbol, compliance))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 15123, 15174);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 15167, 15174);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 15123, 15174);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 15582, 15720) || true) && (f_10621_15586_15604(compliance))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 15582, 15720);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 15638, 15705);

                    f_10621_15638_15704(this, f_10621_15663_15680(symbol), f_10621_15682_15703(symbol));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 15582, 15720);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10621, 14847, 15731);

                bool
                f_10621_14999_15017(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                symbol)
                {
                    var return_v = this_param.DoNotVisit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 14999, 15017);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker.Compliance
                f_10621_15066_15106(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                symbol)
                {
                    var return_v = this_param.GetDeclaredOrInheritedCompliance((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 15066, 15106);
                    return return_v;
                }


                bool
                f_10621_15128_15165(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                symbol, Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker.Compliance
                compliance)
                {
                    var return_v = this_param.VisitTypeOrMember((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, compliance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 15128, 15165);
                    return return_v;
                }


                bool
                f_10621_15586_15604(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker.Compliance
                compliance)
                {
                    var return_v = IsTrue(compliance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 15586, 15604);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10621_15663_15680(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 15663, 15680);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10621_15682_15703(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 15682, 15703);
                    return return_v;
                }


                int
                f_10621_15638_15704(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                context)
                {
                    this_param.CheckParameterCompliance(parameters, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 15638, 15704);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10621, 14847, 15731);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10621, 14847, 15731);
            }
        }

        public override void VisitEvent(EventSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10621, 15743, 16684);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 15819, 15869);

                _cancellationToken.ThrowIfCancellationRequested();

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 15885, 15916) || true) && (f_10621_15889_15907(this, symbol))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 15885, 15916);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 15909, 15916);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 15885, 15916);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 15932, 15997);

                Compliance
                compliance = f_10621_15956_15996(this, symbol)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 16622, 16673) || true) && (!f_10621_16627_16664(this, symbol, compliance))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 16622, 16673);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 16666, 16673);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 16622, 16673);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10621, 15743, 16684);

                bool
                f_10621_15889_15907(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                symbol)
                {
                    var return_v = this_param.DoNotVisit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 15889, 15907);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker.Compliance
                f_10621_15956_15996(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                symbol)
                {
                    var return_v = this_param.GetDeclaredOrInheritedCompliance((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 15956, 15996);
                    return return_v;
                }


                bool
                f_10621_16627_16664(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                symbol, Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker.Compliance
                compliance)
                {
                    var return_v = this_param.VisitTypeOrMember((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, compliance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 16627, 16664);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10621, 15743, 16684);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10621, 15743, 16684);
            }
        }

        public override void VisitField(FieldSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10621, 16696, 17278);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 16772, 16822);

                _cancellationToken.ThrowIfCancellationRequested();

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 16838, 16869) || true) && (f_10621_16842_16860(this, symbol))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 16838, 16869);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 16862, 16869);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 16838, 16869);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 16885, 16950);

                Compliance
                compliance = f_10621_16909_16949(this, symbol)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 16966, 17017) || true) && (!f_10621_16971_17008(this, symbol, compliance))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 16966, 17017);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 17010, 17017);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 16966, 17017);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 17033, 17267) || true) && (f_10621_17037_17055(compliance))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 17033, 17267);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 17089, 17252) || true) && (f_10621_17093_17110(symbol))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 17089, 17252);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 17152, 17233);

                        f_10621_17152_17232(this, ErrorCode.WRN_CLS_VolatileField, f_10621_17204_17220(symbol)[0], symbol);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 17089, 17252);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 17033, 17267);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10621, 16696, 17278);

                bool
                f_10621_16842_16860(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                symbol)
                {
                    var return_v = this_param.DoNotVisit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 16842, 16860);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker.Compliance
                f_10621_16909_16949(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                symbol)
                {
                    var return_v = this_param.GetDeclaredOrInheritedCompliance((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 16909, 16949);
                    return return_v;
                }


                bool
                f_10621_16971_17008(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                symbol, Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker.Compliance
                compliance)
                {
                    var return_v = this_param.VisitTypeOrMember((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, compliance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 16971, 17008);
                    return return_v;
                }


                bool
                f_10621_17037_17055(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker.Compliance
                compliance)
                {
                    var return_v = IsTrue(compliance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 17037, 17055);
                    return return_v;
                }


                bool
                f_10621_17093_17110(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.IsVolatile;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 17093, 17110);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10621_17204_17220(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 17204, 17220);
                    return return_v;
                }


                int
                f_10621_17152_17232(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    this_param.AddDiagnostic(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 17152, 17232);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10621, 16696, 17278);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10621, 16696, 17278);
            }
        }

        private bool VisitTypeOrMember(Symbol symbol, Compliance compliance)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10621, 17397, 20578);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 17490, 17526);

                SymbolKind
                symbolKind = f_10621_17514_17525(symbol)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 17542, 17836);

                f_10621_17542_17835(symbolKind == SymbolKind.NamedType || (DynAbs.Tracing.TraceSender.Expression_False(10621, 17592, 17677) || symbolKind == SymbolKind.Field) || (DynAbs.Tracing.TraceSender.Expression_False(10621, 17592, 17731) || symbolKind == SymbolKind.Property) || (DynAbs.Tracing.TraceSender.Expression_False(10621, 17592, 17782) || symbolKind == SymbolKind.Event) || (DynAbs.Tracing.TraceSender.Expression_False(10621, 17592, 17834) || symbolKind == SymbolKind.Method));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 17850, 17904);

                f_10621_17850_17903(!f_10621_17883_17902(symbol));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 17920, 18088) || true) && (!f_10621_17925_17990(this, symbol, compliance))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 17920, 18088);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 18024, 18037);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 17920, 18088);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 18104, 18142);

                bool
                isCompliant = f_10621_18123_18141(compliance)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 18156, 18227);

                bool
                isAccessibleOutsideAssembly = f_10621_18191_18226(symbol)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 18243, 19236) || true) && (isAccessibleOutsideAssembly)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 18243, 19236);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 18308, 18968) || true) && (isCompliant)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 18308, 18968);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 18365, 18383);

                        f_10621_18365_18382(this, symbol);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 18405, 18449);

                        f_10621_18405_18448(this, symbol);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 18471, 18505);

                        f_10621_18471_18504(this, symbol);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 18529, 18690) || true) && (f_10621_18533_18544(symbol) == SymbolKind.NamedType)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 18529, 18690);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 18618, 18667);

                            f_10621_18618_18666(this, (NamedTypeSymbol)symbol);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 18529, 18690);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 18308, 18968);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 18308, 18968);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 18732, 18968) || true) && (f_10621_18736_18795(this, f_10621_18769_18794(symbol)) == Compliance.DeclaredTrue && (DynAbs.Tracing.TraceSender.Expression_True(10621, 18736, 18864) && f_10621_18826_18864(f_10621_18833_18863(this, symbol))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 18732, 18968);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 18906, 18949);

                            f_10621_18906_18948(this, symbol);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 18732, 18968);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 18308, 18968);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 18243, 19236);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 18243, 19236);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 19002, 19236) || true) && (f_10621_19006_19028(compliance))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 19002, 19236);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 19062, 19154);

                        f_10621_19062_19153(this, ErrorCode.WRN_CLS_MeaninglessOnPrivateType, f_10621_19125_19141(symbol)[0], symbol);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 19172, 19185);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 19002, 19236);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 18243, 19236);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 19252, 19409) || true) && (isCompliant)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 19252, 19409);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 19351, 19394);

                    f_10621_19351_19393(this, symbol);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 19252, 19409);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 19503, 20424) || true) && (symbolKind == SymbolKind.NamedType)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 19503, 20424);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 19575, 19622);

                    NamedTypeSymbol
                    type = (NamedTypeSymbol)symbol
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 19640, 19917) || true) && (f_10621_19644_19657(type) == TypeKind.Delegate)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 19640, 19917);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 19720, 19768);

                        MethodSymbol
                        method = f_10621_19742_19767(type)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 19790, 19840);

                        f_10621_19790_19839(this, f_10621_19821_19838(method));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 19862, 19898);

                        f_10621_19862_19897(this, method);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 19640, 19917);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 19503, 20424);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 19503, 20424);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 19951, 20424) || true) && (symbolKind == SymbolKind.Method)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 19951, 20424);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 20020, 20063);

                        MethodSymbol
                        method = (MethodSymbol)symbol
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 20081, 20131);

                        f_10621_20081_20130(this, f_10621_20112_20129(method));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 20149, 20185);

                        f_10621_20149_20184(this, method);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 19951, 20424);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 19951, 20424);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 20219, 20424) || true) && (symbolKind == SymbolKind.Property)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 20219, 20424);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 20290, 20339);

                            PropertySymbol
                            property = (PropertySymbol)symbol
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 20357, 20409);

                            f_10621_20357_20408(this, f_10621_20388_20407(property));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 20219, 20424);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 19951, 20424);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 19503, 20424);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 20532, 20567);

                return isAccessibleOutsideAssembly;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10621, 17397, 20578);

                Microsoft.CodeAnalysis.SymbolKind
                f_10621_17514_17525(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 17514, 17525);
                    return return_v;
                }


                int
                f_10621_17542_17835(bool
                condition)
                {
                    System.Diagnostics.Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 17542, 17835);
                    return 0;
                }


                bool
                f_10621_17883_17902(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.IsAccessor();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 17883, 17902);
                    return return_v;
                }


                int
                f_10621_17850_17903(bool
                condition)
                {
                    System.Diagnostics.Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 17850, 17903);
                    return 0;
                }


                bool
                f_10621_17925_17990(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker.Compliance
                compliance)
                {
                    var return_v = this_param.CheckForDeclarationWithoutAssemblyDeclaration(symbol, compliance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 17925, 17990);
                    return return_v;
                }


                bool
                f_10621_18123_18141(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker.Compliance
                compliance)
                {
                    var return_v = IsTrue(compliance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 18123, 18141);
                    return return_v;
                }


                bool
                f_10621_18191_18226(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = IsAccessibleOutsideAssembly(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 18191, 18226);
                    return return_v;
                }


                int
                f_10621_18365_18382(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    this_param.CheckName(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 18365, 18382);
                    return 0;
                }


                int
                f_10621_18405_18448(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    this_param.CheckForCompliantWithinNonCompliant(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 18405, 18448);
                    return 0;
                }


                int
                f_10621_18471_18504(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    this_param.CheckReturnTypeCompliance(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 18471, 18504);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10621_18533_18544(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 18533, 18544);
                    return return_v;
                }


                int
                f_10621_18618_18666(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    this_param.CheckMemberDistinctness((Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 18618, 18666);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10621_18769_18794(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 18769, 18794);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker.Compliance
                f_10621_18736_18795(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                symbol)
                {
                    var return_v = this_param.GetDeclaredOrInheritedCompliance((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 18736, 18795);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker.Compliance
                f_10621_18833_18863(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = this_param.GetInheritedCompliance(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 18833, 18863);
                    return return_v;
                }


                bool
                f_10621_18826_18864(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker.Compliance
                compliance)
                {
                    var return_v = IsTrue(compliance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 18826, 18864);
                    return return_v;
                }


                int
                f_10621_18906_18948(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    this_param.CheckForNonCompliantAbstractMember(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 18906, 18948);
                    return 0;
                }


                bool
                f_10621_19006_19028(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker.Compliance
                compliance)
                {
                    var return_v = IsDeclared(compliance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 19006, 19028);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10621_19125_19141(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 19125, 19141);
                    return return_v;
                }


                int
                f_10621_19062_19153(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    this_param.AddDiagnostic(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 19062, 19153);
                    return 0;
                }


                int
                f_10621_19351_19393(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    this_param.CheckForAttributeWithArrayArgument(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 19351, 19393);
                    return 0;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10621_19644_19657(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 19644, 19657);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10621_19742_19767(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DelegateInvokeMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 19742, 19767);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10621_19821_19838(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 19821, 19838);
                    return return_v;
                }


                int
                f_10621_19790_19839(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters)
                {
                    this_param.CheckForMeaninglessOnParameter(parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 19790, 19839);
                    return 0;
                }


                int
                f_10621_19862_19897(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    this_param.CheckForMeaninglessOnReturn(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 19862, 19897);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10621_20112_20129(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 20112, 20129);
                    return return_v;
                }


                int
                f_10621_20081_20130(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters)
                {
                    this_param.CheckForMeaninglessOnParameter(parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 20081, 20130);
                    return 0;
                }


                int
                f_10621_20149_20184(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    this_param.CheckForMeaninglessOnReturn(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 20149, 20184);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10621_20388_20407(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 20388, 20407);
                    return return_v;
                }


                int
                f_10621_20357_20408(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters)
                {
                    this_param.CheckForMeaninglessOnParameter(parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 20357, 20408);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10621, 17397, 20578);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10621, 17397, 20578);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void CheckForNonCompliantAbstractMember(Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10621, 20590, 21306);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 20677, 20798);

                f_10621_20677_20797(!f_10621_20710_20758(f_10621_20717_20757(this, symbol)), "Only call on non-compliant symbols");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 20814, 20869);

                NamedTypeSymbol
                containingType = f_10621_20847_20868(symbol)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 20883, 21295) || true) && ((object)containingType != null && (DynAbs.Tracing.TraceSender.Expression_True(10621, 20887, 20947) && f_10621_20921_20947(containingType)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 20883, 21295);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 20981, 21067);

                    f_10621_20981_21066(this, ErrorCode.WRN_CLS_BadInterfaceMember, f_10621_21038_21054(symbol)[0], symbol);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 20883, 21295);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 20883, 21295);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 21101, 21295) || true) && (f_10621_21105_21122(symbol) && (DynAbs.Tracing.TraceSender.Expression_True(10621, 21105, 21161) && f_10621_21126_21137(symbol) != SymbolKind.NamedType))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 21101, 21295);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 21195, 21280);

                        f_10621_21195_21279(this, ErrorCode.WRN_CLS_NoAbstractMembers, f_10621_21251_21267(symbol)[0], symbol);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 21101, 21295);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 20883, 21295);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10621, 20590, 21306);

                Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker.Compliance
                f_10621_20717_20757(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = this_param.GetDeclaredOrInheritedCompliance(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 20717, 20757);
                    return return_v;
                }


                bool
                f_10621_20710_20758(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker.Compliance
                compliance)
                {
                    var return_v = IsTrue(compliance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 20710, 20758);
                    return return_v;
                }


                int
                f_10621_20677_20797(bool
                condition, string
                message)
                {
                    System.Diagnostics.Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 20677, 20797);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10621_20847_20868(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 20847, 20868);
                    return return_v;
                }


                bool
                f_10621_20921_20947(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 20921, 20947);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10621_21038_21054(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 21038, 21054);
                    return return_v;
                }


                int
                f_10621_20981_21066(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    this_param.AddDiagnostic(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 20981, 21066);
                    return 0;
                }


                bool
                f_10621_21105_21122(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.IsAbstract;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 21105, 21122);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10621_21126_21137(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 21126, 21137);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10621_21251_21267(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 21251, 21267);
                    return return_v;
                }


                int
                f_10621_21195_21279(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    this_param.AddDiagnostic(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 21195, 21279);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10621, 20590, 21306);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10621, 20590, 21306);
            }
        }

        private void CheckBaseTypeCompliance(NamedTypeSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10621, 21318, 22835);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 21403, 21519);

                f_10621_21403_21518(f_10621_21435_21483(f_10621_21442_21482(this, symbol)), "Only call on compliant symbols");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 21656, 22824) || true) && (f_10621_21660_21678(symbol))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 21656, 22824);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 21712, 22156);
                        foreach (NamedTypeSymbol interfaceType in f_10621_21754_21793_I(f_10621_21754_21793(symbol)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 21712, 22156);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 21835, 22137) || true) && (!f_10621_21840_21878(this, interfaceType, symbol))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 21835, 22137);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 22019, 22114);

                                f_10621_22019_22113(                        // TODO: it would be nice to report this on the base type clause.
                                                        this, ErrorCode.WRN_CLS_BadInterface, f_10621_22070_22086(symbol)[0], symbol, interfaceType);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 21835, 22137);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 21712, 22156);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10621, 1, 445);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10621, 1, 445);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 21656, 22824);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 21656, 22824);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 22222, 22314);

                    NamedTypeSymbol
                    baseType = f_10621_22249_22274(symbol) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>(10621, 22249, 22313) ?? f_10621_22278_22313(symbol))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 22355, 22492);

                    f_10621_22355_22491((object)baseType != null || (DynAbs.Tracing.TraceSender.Expression_False(10621, 22387, 22462) || f_10621_22415_22433(symbol) == SpecialType.System_Object), "Only object has no base.");

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 22510, 22809) || true) && ((object)baseType != null && (DynAbs.Tracing.TraceSender.Expression_True(10621, 22514, 22576) && !f_10621_22543_22576(this, baseType, symbol)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 22510, 22809);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 22705, 22790);

                        f_10621_22705_22789(                    // TODO: it would be nice to report this on the base type clause.
                                            this, ErrorCode.WRN_CLS_BadBase, f_10621_22751_22767(symbol)[0], symbol, baseType);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 22510, 22809);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 21656, 22824);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10621, 21318, 22835);

                Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker.Compliance
                f_10621_21442_21482(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = this_param.GetDeclaredOrInheritedCompliance((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 21442, 21482);
                    return return_v;
                }


                bool
                f_10621_21435_21483(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker.Compliance
                compliance)
                {
                    var return_v = IsTrue(compliance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 21435, 21483);
                    return return_v;
                }


                int
                f_10621_21403_21518(bool
                condition, string
                message)
                {
                    System.Diagnostics.Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 21403, 21518);
                    return 0;
                }


                bool
                f_10621_21660_21678(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 21660, 21678);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10621_21754_21793(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.InterfacesNoUseSiteDiagnostics();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 21754, 21793);
                    return return_v;
                }


                bool
                f_10621_21840_21878(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                context)
                {
                    var return_v = this_param.IsCompliantType(type, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 21840, 21878);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10621_22070_22086(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 22070, 22086);
                    return return_v;
                }


                int
                f_10621_22019_22113(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    this_param.AddDiagnostic(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 22019, 22113);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10621_21754_21793_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 21754, 21793);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10621_22249_22274(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.EnumUnderlyingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 22249, 22274);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10621_22278_22313(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 22278, 22313);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10621_22415_22433(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 22415, 22433);
                    return return_v;
                }


                int
                f_10621_22355_22491(bool
                condition, string
                message)
                {
                    System.Diagnostics.Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 22355, 22491);
                    return 0;
                }


                bool
                f_10621_22543_22576(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                context)
                {
                    var return_v = this_param.IsCompliantType(type, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 22543, 22576);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10621_22751_22767(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 22751, 22767);
                    return return_v;
                }


                int
                f_10621_22705_22789(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    this_param.AddDiagnostic(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 22705, 22789);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10621, 21318, 22835);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10621, 21318, 22835);
            }
        }

        private void CheckForCompliantWithinNonCompliant(Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10621, 22847, 23506);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 22935, 23051);

                f_10621_22935_23050(f_10621_22967_23015(f_10621_22974_23014(this, symbol)), "Only call on compliant symbols");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 23067, 23122);

                NamedTypeSymbol
                containingType = f_10621_23100_23121(symbol)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 23136, 23235);

                f_10621_23136_23234((object)containingType == null || (DynAbs.Tracing.TraceSender.Expression_False(10621, 23168, 23233) || f_10621_23202_23233_M(!containingType.IsImplicitClass)));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 23249, 23495) || true) && ((object)containingType != null && (DynAbs.Tracing.TraceSender.Expression_True(10621, 23253, 23344) && !f_10621_23288_23344(f_10621_23295_23343(this, containingType))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 23249, 23495);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 23378, 23480);

                    f_10621_23378_23479(this, ErrorCode.WRN_CLS_IllegalTrueInFalse, f_10621_23435_23451(symbol)[0], symbol, containingType);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 23249, 23495);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10621, 22847, 23506);

                Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker.Compliance
                f_10621_22974_23014(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = this_param.GetDeclaredOrInheritedCompliance(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 22974, 23014);
                    return return_v;
                }


                bool
                f_10621_22967_23015(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker.Compliance
                compliance)
                {
                    var return_v = IsTrue(compliance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 22967, 23015);
                    return return_v;
                }


                int
                f_10621_22935_23050(bool
                condition, string
                message)
                {
                    System.Diagnostics.Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 22935, 23050);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10621_23100_23121(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 23100, 23121);
                    return return_v;
                }


                bool
                f_10621_23202_23233_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 23202, 23233);
                    return return_v;
                }


                int
                f_10621_23136_23234(bool
                condition)
                {
                    System.Diagnostics.Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 23136, 23234);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker.Compliance
                f_10621_23295_23343(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = this_param.GetDeclaredOrInheritedCompliance((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 23295, 23343);
                    return return_v;
                }


                bool
                f_10621_23288_23344(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker.Compliance
                compliance)
                {
                    var return_v = IsTrue(compliance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 23288, 23344);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10621_23435_23451(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 23435, 23451);
                    return return_v;
                }


                int
                f_10621_23378_23479(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    this_param.AddDiagnostic(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 23378, 23479);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10621, 22847, 23506);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10621, 22847, 23506);
            }
        }

        private void CheckTypeParameterCompliance(ImmutableArray<TypeParameterSymbol> typeParameters, NamedTypeSymbol context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10621, 23518, 24595);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 23661, 23804);

                f_10621_23661_23803(typeParameters.IsEmpty || (DynAbs.Tracing.TraceSender.Expression_False(10621, 23693, 23768) || f_10621_23719_23768(f_10621_23726_23767(this, context))), "Only call on compliant symbols");
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 23820, 24584);
                    foreach (TypeParameterSymbol typeParameter in f_10621_23866_23880_I(typeParameters))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 23820, 24584);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 23914, 24569);
                            foreach (TypeWithAnnotations constraintType in f_10621_23961_24010_I(f_10621_23961_24010(typeParameter)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 23914, 24569);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 24052, 24550) || true) && (!f_10621_24057_24102(this, constraintType.Type, context))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 24052, 24550);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 24429, 24527);

                                    f_10621_24429_24526(                        // TODO: it would be nice to report this on the constraint clause.
                                                                                // NOTE: we're improving over dev11 by reporting on the type parameter declaration,
                                                                                // rather than on the constraint type declaration.
                                                            this, ErrorCode.WRN_CLS_BadTypeVar, f_10621_24478_24501(typeParameter)[0], constraintType.Type);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 24052, 24550);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 23914, 24569);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10621, 1, 656);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10621, 1, 656);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 23820, 24584);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10621, 1, 765);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10621, 1, 765);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10621, 23518, 24595);

                Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker.Compliance
                f_10621_23726_23767(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = this_param.GetDeclaredOrInheritedCompliance((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 23726, 23767);
                    return return_v;
                }


                bool
                f_10621_23719_23768(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker.Compliance
                compliance)
                {
                    var return_v = IsTrue(compliance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 23719, 23768);
                    return return_v;
                }


                int
                f_10621_23661_23803(bool
                condition, string
                message)
                {
                    System.Diagnostics.Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 23661, 23803);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10621_23961_24010(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.ConstraintTypesNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 23961, 24010);
                    return return_v;
                }


                bool
                f_10621_24057_24102(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                context)
                {
                    var return_v = this_param.IsCompliantType(type, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 24057, 24102);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10621_24478_24501(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 24478, 24501);
                    return return_v;
                }


                int
                f_10621_24429_24526(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    this_param.AddDiagnostic(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 24429, 24526);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10621_23961_24010_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 23961, 24010);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10621_23866_23880_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 23866, 23880);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10621, 23518, 24595);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10621, 23518, 24595);
            }
        }

        private void CheckParameterCompliance(ImmutableArray<ParameterSymbol> parameters, NamedTypeSymbol context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10621, 24607, 25196);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 24738, 24877);

                f_10621_24738_24876(parameters.IsEmpty || (DynAbs.Tracing.TraceSender.Expression_False(10621, 24770, 24841) || f_10621_24792_24841(f_10621_24799_24840(this, context))), "Only call on compliant symbols");
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 24893, 25185);
                    foreach (ParameterSymbol parameter in f_10621_24931_24941_I(parameters))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 24893, 25185);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 24975, 25170) || true) && (!f_10621_24980_25020(this, f_10621_24996_25010(parameter), context))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 24975, 25170);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 25062, 25151);

                            f_10621_25062_25150(this, ErrorCode.WRN_CLS_BadArgType, f_10621_25111_25130(parameter)[0], f_10621_25135_25149(parameter));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 24975, 25170);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 24893, 25185);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10621, 1, 293);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10621, 1, 293);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10621, 24607, 25196);

                Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker.Compliance
                f_10621_24799_24840(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = this_param.GetDeclaredOrInheritedCompliance((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 24799, 24840);
                    return return_v;
                }


                bool
                f_10621_24792_24841(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker.Compliance
                compliance)
                {
                    var return_v = IsTrue(compliance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 24792, 24841);
                    return return_v;
                }


                int
                f_10621_24738_24876(bool
                condition, string
                message)
                {
                    System.Diagnostics.Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 24738, 24876);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10621_24996_25010(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 24996, 25010);
                    return return_v;
                }


                bool
                f_10621_24980_25020(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                context)
                {
                    var return_v = this_param.IsCompliantType(type, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 24980, 25020);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10621_25111_25130(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 25111, 25130);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10621_25135_25149(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 25135, 25149);
                    return return_v;
                }


                int
                f_10621_25062_25150(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    this_param.AddDiagnostic(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 25062, 25150);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10621_24931_24941_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 24931, 24941);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10621, 24607, 25196);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10621, 24607, 25196);
            }
        }

        private void CheckForAttributeWithArrayArgument(Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10621, 25208, 25695);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 25295, 25411);

                f_10621_25295_25410(f_10621_25327_25375(f_10621_25334_25374(this, symbol)), "Only call on compliant symbols");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 25425, 25492);

                f_10621_25425_25491(this, f_10621_25468_25490(symbol));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 25506, 25684) || true) && (f_10621_25510_25521(symbol) == SymbolKind.Method)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 25506, 25684);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 25576, 25669);

                    f_10621_25576_25668(this, f_10621_25619_25667(((MethodSymbol)symbol)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 25506, 25684);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10621, 25208, 25695);

                Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker.Compliance
                f_10621_25334_25374(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = this_param.GetDeclaredOrInheritedCompliance(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 25334, 25374);
                    return return_v;
                }


                bool
                f_10621_25327_25375(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker.Compliance
                compliance)
                {
                    var return_v = IsTrue(compliance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 25327, 25375);
                    return return_v;
                }


                int
                f_10621_25295_25410(bool
                condition, string
                message)
                {
                    System.Diagnostics.Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 25295, 25410);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10621_25468_25490(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.GetAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 25468, 25490);
                    return return_v;
                }


                int
                f_10621_25425_25491(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                attributes)
                {
                    this_param.CheckForAttributeWithArrayArgumentInternal(attributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 25425, 25491);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10621_25510_25521(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 25510, 25521);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10621_25619_25667(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.GetReturnTypeAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 25619, 25667);
                    return return_v;
                }


                int
                f_10621_25576_25668(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                attributes)
                {
                    this_param.CheckForAttributeWithArrayArgumentInternal(attributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 25576, 25668);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10621, 25208, 25695);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10621, 25208, 25695);
            }
        }

        private void CheckForAttributeWithArrayArgumentInternal(ImmutableArray<CSharpAttributeData> attributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10621, 25904, 28806);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 26032, 28795);
                    foreach (CSharpAttributeData attribute in f_10621_26074_26084_I(attributes))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 26032, 28795);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 26118, 26886);
                            foreach (TypedConstant argument in f_10621_26153_26183_I(f_10621_26153_26183(attribute)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 26118, 26886);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 26225, 26867) || true) && (f_10621_26229_26259(argument.TypeInternal) == TypeKind.Array)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 26225, 26867);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 26525, 26550);

                                    Location
                                    warningLocation
                                    = default(Location);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 26576, 26844) || true) && (f_10621_26580_26642(this, attribute, out warningLocation))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 26576, 26844);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 26700, 26780);

                                        f_10621_26700_26779(this, ErrorCode.WRN_CLS_ArrayArgumentToAttribute, warningLocation);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 26810, 26817);

                                        return;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 26576, 26844);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 26225, 26867);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 26118, 26886);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10621, 1, 769);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10621, 1, 769);
                        }
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 26906, 27712);
                            foreach (var pair in f_10621_26927_26951_I(f_10621_26927_26951(attribute)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 26906, 27712);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 26993, 27029);

                                TypedConstant
                                argument = pair.Value
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 27051, 27693) || true) && (f_10621_27055_27085(argument.TypeInternal) == TypeKind.Array)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 27051, 27693);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 27351, 27376);

                                    Location
                                    warningLocation
                                    = default(Location);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 27402, 27670) || true) && (f_10621_27406_27468(this, attribute, out warningLocation))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 27402, 27670);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 27526, 27606);

                                        f_10621_27526_27605(this, ErrorCode.WRN_CLS_ArrayArgumentToAttribute, warningLocation);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 27636, 27643);

                                        return;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 27402, 27670);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 27051, 27693);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 26906, 27712);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10621, 1, 807);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10621, 1, 807);
                        }
                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 27819, 28780) || true) && ((object)f_10621_27831_27861(attribute) != null)
                        ) // Happens in error scenarios.

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 27819, 28780);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 27942, 28761);
                                foreach (var type in f_10621_27963_28023_I(f_10621_27963_28023(f_10621_27963_27993(attribute))))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 27942, 28761);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 28073, 28738) || true) && (type.TypeKind == TypeKind.Array)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 28073, 28738);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 28372, 28397);

                                        Location
                                        warningLocation
                                        = default(Location);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 28427, 28711) || true) && (f_10621_28431_28493(this, attribute, out warningLocation))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 28427, 28711);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 28559, 28639);

                                            f_10621_28559_28638(this, ErrorCode.WRN_CLS_ArrayArgumentToAttribute, warningLocation);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 28673, 28680);

                                            return;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 28427, 28711);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 28073, 28738);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 27942, 28761);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10621, 1, 820);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10621, 1, 820);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 27819, 28780);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 26032, 28795);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10621, 1, 2764);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10621, 1, 2764);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10621, 25904, 28806);

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.TypedConstant>
                f_10621_26153_26183(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.ConstructorArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 26153, 26183);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10621_26229_26259(Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal?
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 26229, 26259);
                    return return_v;
                }


                bool
                f_10621_26580_26642(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                attribute, out Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = this_param.TryGetAttributeWarningLocation(attribute, out location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 26580, 26642);
                    return return_v;
                }


                int
                f_10621_26700_26779(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    this_param.AddDiagnostic(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 26700, 26779);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.TypedConstant>
                f_10621_26153_26183_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.TypedConstant>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 26153, 26183);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
                f_10621_26927_26951(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.NamedArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 26927, 26951);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10621_27055_27085(Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal?
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 27055, 27085);
                    return return_v;
                }


                bool
                f_10621_27406_27468(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                attribute, out Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = this_param.TryGetAttributeWarningLocation(attribute, out location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 27406, 27468);
                    return return_v;
                }


                int
                f_10621_27526_27605(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    this_param.AddDiagnostic(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 27526, 27605);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
                f_10621_26927_26951_I(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 26927, 26951);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10621_27831_27861(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.AttributeConstructor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 27831, 27861);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10621_27963_27993(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.AttributeConstructor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 27963, 27993);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10621_27963_28023(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterTypesWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 27963, 28023);
                    return return_v;
                }


                bool
                f_10621_28431_28493(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                attribute, out Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = this_param.TryGetAttributeWarningLocation(attribute, out location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 28431, 28493);
                    return return_v;
                }


                int
                f_10621_28559_28638(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    this_param.AddDiagnostic(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 28559, 28638);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10621_27963_28023_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 27963, 28023);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10621_26074_26084_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 26074, 26084);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10621, 25904, 28806);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10621, 25904, 28806);
            }
        }

        private bool TryGetAttributeWarningLocation(CSharpAttributeData attribute, out Location location)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10621, 28818, 29563);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 28940, 29005);

                SyntaxReference
                syntaxRef = f_10621_28968_29004(attribute)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 29019, 29493) || true) && (syntaxRef == null && (DynAbs.Tracing.TraceSender.Expression_True(10621, 29023, 29063) && _filterTree == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 29019, 29493);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 29097, 29129);

                    location = NoLocation.Singleton;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 29147, 29159);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 29019, 29493);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 29019, 29493);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 29193, 29493) || true) && (_filterTree == null || (DynAbs.Tracing.TraceSender.Expression_False(10621, 29197, 29278) || (syntaxRef != null && (DynAbs.Tracing.TraceSender.Expression_True(10621, 29221, 29277) && f_10621_29242_29262(syntaxRef) == _filterTree))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 29193, 29493);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 29312, 29389);

                        f_10621_29312_29388(f_10621_29344_29387(f_10621_29344_29364(syntaxRef)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 29407, 29448);

                        location = f_10621_29418_29447(syntaxRef);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 29466, 29478);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 29193, 29493);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 29019, 29493);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 29509, 29525);

                location = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 29539, 29552);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10621, 28818, 29563);

                Microsoft.CodeAnalysis.SyntaxReference?
                f_10621_28968_29004(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.ApplicationSyntaxReference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 28968, 29004);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10621_29242_29262(Microsoft.CodeAnalysis.SyntaxReference
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 29242, 29262);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10621_29344_29364(Microsoft.CodeAnalysis.SyntaxReference?
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 29344, 29364);
                    return return_v;
                }


                bool
                f_10621_29344_29387(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.HasCompilationUnitRoot;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 29344, 29387);
                    return return_v;
                }


                int
                f_10621_29312_29388(bool
                condition)
                {
                    System.Diagnostics.Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 29312, 29388);
                    return 0;
                }


                Microsoft.CodeAnalysis.SourceLocation
                f_10621_29418_29447(Microsoft.CodeAnalysis.SyntaxReference
                syntaxRef)
                {
                    var return_v = new Microsoft.CodeAnalysis.SourceLocation(syntaxRef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 29418, 29447);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10621, 28818, 29563);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10621, 28818, 29563);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void CheckForMeaninglessOnParameter(ImmutableArray<ParameterSymbol> parameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10621, 29575, 30753);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 29687, 29718) || true) && (parameters.IsEmpty)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 29687, 29718);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 29711, 29718);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 29687, 29718);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 29734, 29751);

                int
                startPos = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 29767, 29817);

                Symbol
                container = f_10621_29786_29816(parameters[0])
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 29831, 30337) || true) && (f_10621_29835_29849(container) == SymbolKind.Method)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 29831, 30337);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 29904, 29967);

                    Symbol
                    associated = f_10621_29924_29966(((MethodSymbol)container))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 29985, 30322) || true) && ((object)associated != null && (DynAbs.Tracing.TraceSender.Expression_True(10621, 29989, 30057) && f_10621_30019_30034(associated) == SymbolKind.Property))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 29985, 30322);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 30248, 30303);

                        startPos = f_10621_30259_30302(((PropertySymbol)associated));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 29985, 30322);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 29831, 30337);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 30362, 30374);

                    for (int
        i = startPos
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 30353, 30742) || true) && (i < parameters.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 30399, 30402)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 30353, 30742))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 30353, 30742);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 30436, 30463);

                        Location
                        attributeLocation
                        = default(Location);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 30481, 30727) || true) && (f_10621_30485_30590(this, f_10621_30522_30551(parameters[i]), parameters[i], out attributeLocation))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 30481, 30727);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 30632, 30708);

                            f_10621_30632_30707(this, ErrorCode.WRN_CLS_MeaninglessOnParam, attributeLocation);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 30481, 30727);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10621, 1, 390);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10621, 1, 390);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10621, 29575, 30753);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10621_29786_29816(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 29786, 29816);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10621_29835_29849(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 29835, 29849);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10621_29924_29966(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.AssociatedSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 29924, 29966);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10621_30019_30034(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 30019, 30034);
                    return return_v;
                }


                int
                f_10621_30259_30302(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 30259, 30302);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10621_30522_30551(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.GetAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 30522, 30551);
                    return return_v;
                }


                bool
                f_10621_30485_30590(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                targetSymbol, out Microsoft.CodeAnalysis.Location
                attributeLocation)
                {
                    var return_v = this_param.TryGetClsComplianceAttributeLocation(attributes, (Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, out attributeLocation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 30485, 30590);
                    return return_v;
                }


                int
                f_10621_30632_30707(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    this_param.AddDiagnostic(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 30632, 30707);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10621, 29575, 30753);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10621, 29575, 30753);
            }
        }

        private void CheckForMeaninglessOnReturn(MethodSymbol method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10621, 30765, 31134);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 30851, 30878);

                Location
                attributeLocation
                = default(Location);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 30892, 31123) || true) && (f_10621_30896_30997(this, f_10621_30933_30965(method), method, out attributeLocation))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 30892, 31123);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 31031, 31108);

                    f_10621_31031_31107(this, ErrorCode.WRN_CLS_MeaninglessOnReturn, attributeLocation);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 30892, 31123);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10621, 30765, 31134);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10621_30933_30965(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.GetReturnTypeAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 30933, 30965);
                    return return_v;
                }


                bool
                f_10621_30896_30997(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                targetSymbol, out Microsoft.CodeAnalysis.Location
                attributeLocation)
                {
                    var return_v = this_param.TryGetClsComplianceAttributeLocation(attributes, (Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, out attributeLocation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 30896, 30997);
                    return return_v;
                }


                int
                f_10621_31031_31107(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    this_param.AddDiagnostic(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 31031, 31107);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10621, 30765, 31134);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10621, 30765, 31134);
            }
        }

        private void CheckReturnTypeCompliance(Symbol symbol)
        {
            System.Diagnostics.Debug.Assert(IsTrue(GetDeclaredOrInheritedCompliance(symbol)), "Only call on compliant symbols");

            ErrorCode code;
            TypeSymbol type;
            switch (symbol.Kind)
            {
                case SymbolKind.Field:
                    code = ErrorCode.WRN_CLS_BadFieldPropType;
                    type = ((FieldSymbol)symbol).Type;
                    break;
                case SymbolKind.Property:
                    code = ErrorCode.WRN_CLS_BadFieldPropType;
                    type = ((PropertySymbol)symbol).Type;
                    break;
                case SymbolKind.Event:
                    code = ErrorCode.WRN_CLS_BadFieldPropType;
                    type = ((EventSymbol)symbol).Type;
                    break;
                case SymbolKind.Method:
                    code = ErrorCode.WRN_CLS_BadReturnType;
                    MethodSymbol method = (MethodSymbol)symbol;
                    type = method.ReturnType;

                    if (method.MethodKind == MethodKind.DelegateInvoke)
                    {
                        System.Diagnostics.Debug.Assert(method.ContainingType.TypeKind == TypeKind.Delegate);
                        symbol = method.ContainingType; // Refer to the delegate type in diagnostics.
                    }

                    // Diagnostic not interesting for accessors.
                    System.Diagnostics.Debug.Assert(!method.IsAccessor());

                    break;
                case SymbolKind.NamedType:
                    symbol = ((NamedTypeSymbol)symbol).DelegateInvokeMethod;
                    if ((object)symbol == null)
                    {
                        return;
                    }
                    else
                    {
                        goto case SymbolKind.Method;
                    }
                default:
                    throw ExceptionUtilities.UnexpectedValue(symbol.Kind);
            }

            if (!IsCompliantType(type, symbol.ContainingType))
            {
                this.AddDiagnostic(code, symbol.Locations[0], symbol);
            }
        }

        private bool TryGetClsComplianceAttributeLocation(ImmutableArray<CSharpAttributeData> attributes, Symbol targetSymbol, out Location attributeLocation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10621, 33427, 34070);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 33602, 33991);
                    foreach (CSharpAttributeData data in f_10621_33639_33649_I(attributes))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 33602, 33991);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 33683, 33976) || true) && (f_10621_33687_33767(data, targetSymbol, AttributeDescription.CLSCompliantAttribute))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 33683, 33976);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 33809, 33957) || true) && (f_10621_33813_33872(this, data, out attributeLocation))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 33809, 33957);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 33922, 33934);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 33809, 33957);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 33683, 33976);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 33602, 33991);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10621, 1, 390);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10621, 1, 390);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 34007, 34032);

                attributeLocation = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 34046, 34059);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10621, 33427, 34070);

                bool
                f_10621_33687_33767(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute(targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 33687, 33767);
                    return return_v;
                }


                bool
                f_10621_33813_33872(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                attribute, out Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = this_param.TryGetAttributeWarningLocation(attribute, out location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 33813, 33872);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10621_33639_33649_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 33639, 33649);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10621, 33427, 34070);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10621, 33427, 34070);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool CheckForDeclarationWithoutAssemblyDeclaration(Symbol symbol, Compliance compliance)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10621, 34161, 34870);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 34282, 34833) || true) && (f_10621_34286_34308(compliance))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 34282, 34833);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 34342, 34434);

                    Compliance
                    assemblyCompliance = f_10621_34374_34433(this, f_10621_34407_34432(symbol))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 34454, 34818) || true) && (!f_10621_34459_34489(assemblyCompliance))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 34454, 34818);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 34531, 34688);

                        ErrorCode
                        code = (DynAbs.Tracing.TraceSender.Conditional_F1(10621, 34548, 34566) || ((f_10621_34548_34566(compliance) && DynAbs.Tracing.TraceSender.Conditional_F2(10621, 34594, 34626)) || DynAbs.Tracing.TraceSender.Conditional_F3(10621, 34654, 34687))) ? ErrorCode.WRN_CLS_AssemblyNotCLS
                        : ErrorCode.WRN_CLS_AssemblyNotCLS2
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 34710, 34764);

                        f_10621_34710_34763(this, code, f_10621_34735_34751(symbol)[0], symbol);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 34786, 34799);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 34454, 34818);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 34282, 34833);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 34847, 34859);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10621, 34161, 34870);

                bool
                f_10621_34286_34308(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker.Compliance
                compliance)
                {
                    var return_v = IsDeclared(compliance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 34286, 34308);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10621_34407_34432(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 34407, 34432);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker.Compliance
                f_10621_34374_34433(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                symbol)
                {
                    var return_v = this_param.GetDeclaredOrInheritedCompliance((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 34374, 34433);
                    return return_v;
                }


                bool
                f_10621_34459_34489(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker.Compliance
                compliance)
                {
                    var return_v = IsDeclared(compliance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 34459, 34489);
                    return return_v;
                }


                bool
                f_10621_34548_34566(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker.Compliance
                compliance)
                {
                    var return_v = IsTrue(compliance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 34548, 34566);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10621_34735_34751(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 34735, 34751);
                    return return_v;
                }


                int
                f_10621_34710_34763(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    this_param.AddDiagnostic(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 34710, 34763);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10621, 34161, 34870);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10621, 34161, 34870);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void CheckMemberDistinctness(NamespaceOrTypeSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10621, 34882, 38775);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 34973, 35042);

                f_10621_34973_35041(f_10621_35005_35040(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 35056, 35138);

                f_10621_35056_35137(f_10621_35088_35136(f_10621_35095_35135(this, symbol)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 35154, 35271);

                MultiDictionary<string, Symbol>
                seenByName = f_10621_35199_35270(f_10621_35235_35269())
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 35374, 37854) || true) && (f_10621_35378_35389(symbol) != SymbolKind.Namespace)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 35374, 37854);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 35447, 35494);

                    NamedTypeSymbol
                    type = (NamedTypeSymbol)symbol
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 35904, 36853);
                        foreach (NamedTypeSymbol @interface in f_10621_35943_36005_I(f_10621_35943_36005(f_10621_35943_36000(type))))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 35904, 36853);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 36104, 36159) || true) && (!f_10621_36109_36148(@interface))
                            )
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 36104, 36159);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 36150, 36159);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 36104, 36159);
                            }
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 36183, 36834);
                                foreach (Symbol member in f_10621_36209_36241_I(f_10621_36209_36241(@interface)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 36183, 36834);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 36513, 36811) || true) && (f_10621_36517_36560(member) && (DynAbs.Tracing.TraceSender.Expression_True(10621, 36517, 36690) && (f_10621_36594_36612_M(!member.IsOverride) || (DynAbs.Tracing.TraceSender.Expression_False(10621, 36594, 36689) || !(f_10621_36618_36629(member) == SymbolKind.Method || (DynAbs.Tracing.TraceSender.Expression_False(10621, 36618, 36688) || f_10621_36654_36665(member) == SymbolKind.Property))))))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 36513, 36811);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 36748, 36784);

                                        f_10621_36748_36783(seenByName, f_10621_36763_36774(member), member);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 36513, 36811);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 36183, 36834);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10621, 1, 652);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10621, 1, 652);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 35904, 36853);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10621, 1, 950);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10621, 1, 950);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 36873, 36934);

                    NamedTypeSymbol
                    baseType = f_10621_36900_36933(type)
                    ;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 36952, 37839) || true) && ((object)baseType != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 36952, 37839);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 37025, 37747);
                                foreach (Symbol member in f_10621_37051_37081_I(f_10621_37051_37081(baseType)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 37025, 37747);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 37353, 37724) || true) && (f_10621_37357_37392(member) && (DynAbs.Tracing.TraceSender.Expression_True(10621, 37357, 37473) && f_10621_37425_37473(f_10621_37432_37472(this, member))) && (DynAbs.Tracing.TraceSender.Expression_True(10621, 37357, 37603) && (f_10621_37507_37525_M(!member.IsOverride) || (DynAbs.Tracing.TraceSender.Expression_False(10621, 37507, 37602) || !(f_10621_37531_37542(member) == SymbolKind.Method || (DynAbs.Tracing.TraceSender.Expression_False(10621, 37531, 37601) || f_10621_37567_37578(member) == SymbolKind.Property))))))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 37353, 37724);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 37661, 37697);

                                        f_10621_37661_37696(seenByName, f_10621_37676_37687(member), member);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 37353, 37724);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 37025, 37747);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10621, 1, 723);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10621, 1, 723);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 37771, 37820);

                            baseType = f_10621_37782_37819(baseType);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 36952, 37839);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10621, 36952, 37839);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10621, 36952, 37839);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 35374, 37854);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 37974, 38764);
                    foreach (Symbol member in f_10621_38000_38019_I(f_10621_38000_38019(symbol)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 37974, 38764);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 38107, 38437) || true) && (f_10621_38111_38129(this, member) || (DynAbs.Tracing.TraceSender.Expression_False(10621, 38111, 38198) || !f_10621_38155_38198(member)) || (DynAbs.Tracing.TraceSender.Expression_False(10621, 38111, 38325) || !f_10621_38277_38325(f_10621_38284_38324(this, member))) || (DynAbs.Tracing.TraceSender.Expression_False(10621, 38111, 38367) || f_10621_38350_38367(member)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 38107, 38437);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 38409, 38418);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 38107, 38437);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 38457, 38480);

                        var
                        name = f_10621_38468_38479(member)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 38498, 38537);

                        var
                        sameNameSymbols = f_10621_38520_38536(seenByName, name)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 38555, 38700) || true) && (sameNameSymbols.Count > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 38555, 38700);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 38626, 38681);

                            f_10621_38626_38680(this, member, name, sameNameSymbols);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 38555, 38700);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 38720, 38749);

                        f_10621_38720_38748(
                                        seenByName, name, member);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 37974, 38764);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10621, 1, 791);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10621, 1, 791);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10621, 34882, 38775);

                bool
                f_10621_35005_35040(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                symbol)
                {
                    var return_v = IsAccessibleOutsideAssembly((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 35005, 35040);
                    return return_v;
                }


                int
                f_10621_34973_35041(bool
                condition)
                {
                    System.Diagnostics.Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 34973, 35041);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker.Compliance
                f_10621_35095_35135(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                symbol)
                {
                    var return_v = this_param.GetDeclaredOrInheritedCompliance((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 35095, 35135);
                    return return_v;
                }


                bool
                f_10621_35088_35136(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker.Compliance
                compliance)
                {
                    var return_v = IsTrue(compliance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 35088, 35136);
                    return return_v;
                }


                int
                f_10621_35056_35137(bool
                condition)
                {
                    System.Diagnostics.Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 35056, 35137);
                    return 0;
                }


                System.StringComparer
                f_10621_35235_35269()
                {
                    var return_v = CaseInsensitiveComparison.Comparer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 35235, 35269);
                    return return_v;
                }


                Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10621_35199_35270(System.StringComparer
                comparer)
                {
                    var return_v = new Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbol>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 35199, 35270);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10621_35378_35389(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 35378, 35389);
                    return return_v;
                }


                Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10621_35943_36000(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.InterfacesAndTheirBaseInterfacesNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 35943, 36000);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>.ValueSet>.KeyCollection
                f_10621_35943_36005(Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 35943, 36005);
                    return return_v;
                }


                bool
                f_10621_36109_36148(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = IsAccessibleOutsideAssembly((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 36109, 36148);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10621_36209_36241(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembersUnordered();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 36209, 36241);
                    return return_v;
                }


                bool
                f_10621_36517_36560(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = IsAccessibleIfContainerIsAccessible(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 36517, 36560);
                    return return_v;
                }


                bool
                f_10621_36594_36612_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 36594, 36612);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10621_36618_36629(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 36618, 36629);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10621_36654_36665(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 36654, 36665);
                    return return_v;
                }


                string
                f_10621_36763_36774(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 36763, 36774);
                    return return_v;
                }


                bool
                f_10621_36748_36783(Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, string
                k, Microsoft.CodeAnalysis.CSharp.Symbol
                v)
                {
                    var return_v = this_param.Add(k, v);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 36748, 36783);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10621_36209_36241_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 36209, 36241);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>.ValueSet>.KeyCollection
                f_10621_35943_36005_I(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>.ValueSet>.KeyCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 35943, 36005);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10621_36900_36933(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 36900, 36933);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10621_37051_37081(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembersUnordered();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 37051, 37081);
                    return return_v;
                }


                bool
                f_10621_37357_37392(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = IsAccessibleOutsideAssembly(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 37357, 37392);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker.Compliance
                f_10621_37432_37472(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = this_param.GetDeclaredOrInheritedCompliance(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 37432, 37472);
                    return return_v;
                }


                bool
                f_10621_37425_37473(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker.Compliance
                compliance)
                {
                    var return_v = IsTrue(compliance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 37425, 37473);
                    return return_v;
                }


                bool
                f_10621_37507_37525_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 37507, 37525);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10621_37531_37542(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 37531, 37542);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10621_37567_37578(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 37567, 37578);
                    return return_v;
                }


                string
                f_10621_37676_37687(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 37676, 37687);
                    return return_v;
                }


                bool
                f_10621_37661_37696(Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, string
                k, Microsoft.CodeAnalysis.CSharp.Symbol
                v)
                {
                    var return_v = this_param.Add(k, v);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 37661, 37696);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10621_37051_37081_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 37051, 37081);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10621_37782_37819(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 37782, 37819);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10621_38000_38019(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 38000, 38019);
                    return return_v;
                }


                bool
                f_10621_38111_38129(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = this_param.DoNotVisit(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 38111, 38129);
                    return return_v;
                }


                bool
                f_10621_38155_38198(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = IsAccessibleIfContainerIsAccessible(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 38155, 38198);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker.Compliance
                f_10621_38284_38324(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = this_param.GetDeclaredOrInheritedCompliance(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 38284, 38324);
                    return return_v;
                }


                bool
                f_10621_38277_38325(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker.Compliance
                compliance)
                {
                    var return_v = IsTrue(compliance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 38277, 38325);
                    return return_v;
                }


                bool
                f_10621_38350_38367(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.IsOverride;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 38350, 38367);
                    return return_v;
                }


                string
                f_10621_38468_38479(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 38468, 38479);
                    return return_v;
                }


                Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbol>.ValueSet
                f_10621_38520_38536(Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 38520, 38536);
                    return return_v;
                }


                int
                f_10621_38626_38680(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, string
                symbolName, Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbol>.ValueSet
                sameNameSymbols)
                {
                    this_param.CheckSymbolDistinctness(symbol, symbolName, sameNameSymbols);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 38626, 38680);
                    return 0;
                }


                bool
                f_10621_38720_38748(Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, string
                k, Microsoft.CodeAnalysis.CSharp.Symbol
                v)
                {
                    var return_v = this_param.Add(k, v);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 38720, 38748);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10621_38000_38019_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 38000, 38019);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10621, 34882, 38775);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10621, 34882, 38775);
            }
        }

        private void CheckSymbolDistinctness(Symbol symbol, string symbolName, MultiDictionary<string, Symbol>.ValueSet sameNameSymbols)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10621, 39176, 40995);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 39329, 39369);

                f_10621_39329_39368(sameNameSymbols.Count > 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 39383, 39423);

                f_10621_39383_39422(f_10621_39396_39407(symbol) == symbolName);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 39439, 39536);

                bool
                isMethodOrProperty = f_10621_39465_39476(symbol) == SymbolKind.Method || (DynAbs.Tracing.TraceSender.Expression_False(10621, 39465, 39535) || f_10621_39501_39512(symbol) == SymbolKind.Property)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 39552, 39999);
                    foreach (Symbol other in f_10621_39577_39592_I(sameNameSymbols))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 39552, 39999);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 39626, 39984) || true) && (f_10621_39630_39640(other) != symbolName && (DynAbs.Tracing.TraceSender.Expression_True(10621, 39630, 39708) && !(isMethodOrProperty && (DynAbs.Tracing.TraceSender.Expression_True(10621, 39660, 39707) && f_10621_39682_39692(other) == f_10621_39696_39707(symbol)))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 39626, 39984);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 39851, 39936);

                            f_10621_39851_39935(                    // TODO: Shouldn't we somehow reference the conflicting member?  Dev11 doesn't.
                                                this, ErrorCode.WRN_CLS_BadIdentifierCase, f_10621_39907_39923(symbol)[0], symbol);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 39958, 39965);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 39626, 39984);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 39552, 39999);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10621, 1, 448);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10621, 1, 448);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 40015, 40094) || true) && (!isMethodOrProperty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 40015, 40094);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 40072, 40079);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 40015, 40094);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 40110, 40984);
                    foreach (Symbol other in f_10621_40135_40150_I(sameNameSymbols))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 40110, 40984);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 40273, 40288);

                        ErrorCode
                        code
                        = default(ErrorCode);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 40306, 40969) || true) && (f_10621_40310_40321(symbol) == f_10621_40325_40335(other) && (DynAbs.Tracing.TraceSender.Expression_True(10621, 40310, 40380) && !f_10621_40361_40380(symbol)) && (DynAbs.Tracing.TraceSender.Expression_True(10621, 40310, 40424) && !f_10621_40406_40424(other)) && (DynAbs.Tracing.TraceSender.Expression_True(10621, 40310, 40498) && f_10621_40449_40498(symbol, other, out code)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 40306, 40969);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 40540, 40594);

                            f_10621_40540_40593(this, code, f_10621_40565_40581(symbol)[0], symbol);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 40616, 40623);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 40306, 40969);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 40306, 40969);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 40665, 40969) || true) && (f_10621_40669_40679(other) != symbolName)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 40665, 40969);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 40836, 40921);

                                f_10621_40836_40920(                    // TODO: Shouldn't we somehow reference the conflicting member?  Dev11 doesn't.
                                                    this, ErrorCode.WRN_CLS_BadIdentifierCase, f_10621_40892_40908(symbol)[0], symbol);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 40943, 40950);

                                return;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 40665, 40969);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 40306, 40969);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 40110, 40984);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10621, 1, 875);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10621, 1, 875);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10621, 39176, 40995);

                int
                f_10621_39329_39368(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 39329, 39368);
                    return 0;
                }


                string
                f_10621_39396_39407(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 39396, 39407);
                    return return_v;
                }


                int
                f_10621_39383_39422(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 39383, 39422);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10621_39465_39476(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 39465, 39476);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10621_39501_39512(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 39501, 39512);
                    return return_v;
                }


                string
                f_10621_39630_39640(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 39630, 39640);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10621_39682_39692(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 39682, 39692);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10621_39696_39707(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 39696, 39707);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10621_39907_39923(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 39907, 39923);
                    return return_v;
                }


                int
                f_10621_39851_39935(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    this_param.AddDiagnostic(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 39851, 39935);
                    return 0;
                }


                Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbol>.ValueSet
                f_10621_39577_39592_I(Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbol>.ValueSet
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 39577, 39592);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10621_40310_40321(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 40310, 40321);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10621_40325_40335(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 40325, 40335);
                    return return_v;
                }


                bool
                f_10621_40361_40380(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.IsAccessor();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 40361, 40380);
                    return return_v;
                }


                bool
                f_10621_40406_40424(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.IsAccessor();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 40406, 40424);
                    return return_v;
                }


                bool
                f_10621_40449_40498(Microsoft.CodeAnalysis.CSharp.Symbol
                x, Microsoft.CodeAnalysis.CSharp.Symbol
                y, out Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = TryGetCollisionErrorCode(x, y, out code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 40449, 40498);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10621_40565_40581(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 40565, 40581);
                    return return_v;
                }


                int
                f_10621_40540_40593(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    this_param.AddDiagnostic(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 40540, 40593);
                    return 0;
                }


                string
                f_10621_40669_40679(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 40669, 40679);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10621_40892_40908(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 40892, 40908);
                    return return_v;
                }


                int
                f_10621_40836_40920(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    this_param.AddDiagnostic(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 40836, 40920);
                    return 0;
                }


                Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbol>.ValueSet
                f_10621_40135_40150_I(Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbol>.ValueSet
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 40135, 40150);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10621, 39176, 40995);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10621, 39176, 40995);
            }
        }

        private void CheckName(Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10621, 41007, 43121);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 41069, 41151);

                f_10621_41069_41150(f_10621_41101_41149(f_10621_41108_41148(this, symbol)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 41165, 41234);

                f_10621_41165_41233(f_10621_41197_41232(symbol));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 41250, 41313) || true) && (f_10621_41254_41283_M(!symbol.CanBeReferencedByName) || (DynAbs.Tracing.TraceSender.Expression_False(10621, 41254, 41304) || f_10621_41287_41304(symbol)))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 41250, 41313);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 41306, 41313);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 41250, 41313);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 41329, 41355);

                string
                name = f_10621_41343_41354(symbol)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 42851, 42924);

                f_10621_42851_42923(f_10621_42883_42894(name) == 0 || (DynAbs.Tracing.TraceSender.Expression_False(10621, 42883, 42922) || f_10621_42903_42910(name, 0) != '\uFF3F'));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 42940, 43110) || true) && (f_10621_42944_42955(name) > 0 && (DynAbs.Tracing.TraceSender.Expression_True(10621, 42944, 42982) && f_10621_42963_42970(name, 0) == '\u005F'))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 42940, 43110);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 43016, 43095);

                    f_10621_43016_43094(this, ErrorCode.WRN_CLS_BadIdentifier, f_10621_43068_43084(symbol)[0], name);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 42940, 43110);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10621, 41007, 43121);

                Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker.Compliance
                f_10621_41108_41148(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = this_param.GetDeclaredOrInheritedCompliance(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 41108, 41148);
                    return return_v;
                }


                bool
                f_10621_41101_41149(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker.Compliance
                compliance)
                {
                    var return_v = IsTrue(compliance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 41101, 41149);
                    return return_v;
                }


                int
                f_10621_41069_41150(bool
                condition)
                {
                    System.Diagnostics.Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 41069, 41150);
                    return 0;
                }


                bool
                f_10621_41197_41232(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = IsAccessibleOutsideAssembly(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 41197, 41232);
                    return return_v;
                }


                int
                f_10621_41165_41233(bool
                condition)
                {
                    System.Diagnostics.Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 41165, 41233);
                    return 0;
                }


                bool
                f_10621_41254_41283_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 41254, 41283);
                    return return_v;
                }


                bool
                f_10621_41287_41304(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.IsOverride;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 41287, 41304);
                    return return_v;
                }


                string
                f_10621_41343_41354(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 41343, 41354);
                    return return_v;
                }


                int
                f_10621_42883_42894(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 42883, 42894);
                    return return_v;
                }


                char
                f_10621_42903_42910(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 42903, 42910);
                    return return_v;
                }


                int
                f_10621_42851_42923(bool
                condition)
                {
                    System.Diagnostics.Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 42851, 42923);
                    return 0;
                }


                int
                f_10621_42944_42955(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 42944, 42955);
                    return return_v;
                }


                char
                f_10621_42963_42970(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 42963, 42970);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10621_43068_43084(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 43068, 43084);
                    return return_v;
                }


                int
                f_10621_43016_43094(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    this_param.AddDiagnostic(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 43016, 43094);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10621, 41007, 43121);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10621, 41007, 43121);
            }
        }

        private bool DoNotVisit(Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10621, 43133, 43561);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 43196, 43297) || true) && (f_10621_43200_43211(symbol) == SymbolKind.Namespace)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 43196, 43297);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 43269, 43282);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 43196, 43297);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 43396, 43550);

                return f_10621_43403_43430(symbol) != _compilation || (DynAbs.Tracing.TraceSender.Expression_False(10621, 43403, 43494) || f_10621_43467_43494(symbol)) || (DynAbs.Tracing.TraceSender.Expression_False(10621, 43403, 43549) || f_10621_43515_43549(this, symbol));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10621, 43133, 43561);

                Microsoft.CodeAnalysis.SymbolKind
                f_10621_43200_43211(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 43200, 43211);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10621_43403_43430(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 43403, 43430);
                    return return_v;
                }


                bool
                f_10621_43467_43494(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.IsImplicitlyDeclared;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 43467, 43494);
                    return return_v;
                }


                bool
                f_10621_43515_43549(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = this_param.IsSyntacticallyFilteredOut(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 43515, 43549);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10621, 43133, 43561);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10621, 43133, 43561);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool IsSyntacticallyFilteredOut(Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10621, 43573, 43989);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 43882, 43978);

                return _filterTree != null && (DynAbs.Tracing.TraceSender.Expression_True(10621, 43889, 43977) && !f_10621_43913_43977(symbol, _filterTree, _filterSpanWithinTree));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10621, 43573, 43989);

                bool
                f_10621_43913_43977(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                tree, Microsoft.CodeAnalysis.Text.TextSpan?
                definedWithinSpan)
                {
                    var return_v = this_param.IsDefinedInSourceTree(tree, definedWithinSpan);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 43913, 43977);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10621, 43573, 43989);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10621, 43573, 43989);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool IsCompliantType(TypeSymbol type, NamedTypeSymbol context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10621, 44001, 45439);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 44096, 45428);

                switch (f_10621_44104_44117(type))
                {

                    case TypeKind.Array:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 44096, 45428);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 44193, 44262);

                        return f_10621_44200_44261(this, f_10621_44216_44251(((ArrayTypeSymbol)type)), context);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 44096, 45428);

                    case TypeKind.Dynamic:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 44096, 45428);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 44580, 44592);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 44096, 45428);

                    case TypeKind.Pointer:
                    case TypeKind.FunctionPointer:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 44096, 45428);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 44702, 44715);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 44096, 45428);

                    case TypeKind.Error:
                    case TypeKind.TypeParameter:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 44096, 45428);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 44980, 44992);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 44096, 45428);

                    case TypeKind.Class:
                    case TypeKind.Struct:
                    case TypeKind.Interface:
                    case TypeKind.Delegate:
                    case TypeKind.Enum:
                    case TypeKind.Submission:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 44096, 45428);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 45254, 45309);

                        return f_10621_45261_45308(this, type, context);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 44096, 45428);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 44096, 45428);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 45357, 45413);

                        throw f_10621_45363_45412(f_10621_45398_45411(type));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 44096, 45428);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10621, 44001, 45439);

                Microsoft.CodeAnalysis.TypeKind
                f_10621_44104_44117(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 44104, 44117);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10621_44216_44251(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.ElementType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 44216, 44251);
                    return return_v;
                }


                bool
                f_10621_44200_44261(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                context)
                {
                    var return_v = this_param.IsCompliantType(type, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 44200, 44261);
                    return return_v;
                }


                bool
                f_10621_45261_45308(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                context)
                {
                    var return_v = this_param.IsCompliantType((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)type, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 45261, 45308);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10621_45398_45411(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 45398, 45411);
                    return return_v;
                }


                System.Exception
                f_10621_45363_45412(Microsoft.CodeAnalysis.TypeKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 45363, 45412);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10621, 44001, 45439);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10621, 44001, 45439);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool IsCompliantType(NamedTypeSymbol type, NamedTypeSymbol context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10621, 45451, 47149);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 45784, 46377);

                switch (f_10621_45792_45808(type))
                {

                    case SpecialType.System_TypedReference:
                    case SpecialType.System_UIntPtr:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 45784, 46377);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 46025, 46038);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 45784, 46377);

                    case SpecialType.System_SByte: // sic
                    case SpecialType.System_UInt16:
                    case SpecialType.System_UInt32:
                    case SpecialType.System_UInt64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 45784, 46377);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 46349, 46362);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 45784, 46377);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 46393, 46640) || true) && (f_10621_46397_46410(type) == TypeKind.Error)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 46393, 46640);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 46613, 46625);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 46393, 46640);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 46656, 46788) || true) && (!f_10621_46661_46726(f_10621_46668_46725(this, f_10621_46701_46724(type))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 46656, 46788);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 46760, 46773);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 46656, 46788);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 46804, 47063);
                    foreach (TypeWithAnnotations typeArg in f_10621_46844_46897_I(f_10621_46844_46897(type)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 46804, 47063);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 46931, 47048) || true) && (!f_10621_46936_46974(this, typeArg.Type, context))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 46931, 47048);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 47016, 47029);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 46931, 47048);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 46804, 47063);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10621, 1, 260);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10621, 1, 260);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 47079, 47138);

                return !f_10621_47087_47137(type, context);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10621, 45451, 47149);

                Microsoft.CodeAnalysis.SpecialType
                f_10621_45792_45808(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 45792, 45808);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10621_46397_46410(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 46397, 46410);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10621_46701_46724(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 46701, 46724);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker.Compliance
                f_10621_46668_46725(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = this_param.GetDeclaredOrInheritedCompliance((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 46668, 46725);
                    return return_v;
                }


                bool
                f_10621_46661_46726(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker.Compliance
                compliance)
                {
                    var return_v = IsTrue(compliance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 46661, 46726);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10621_46844_46897(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeArgumentsWithAnnotationsNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 46844, 46897);
                    return return_v;
                }


                bool
                f_10621_46936_46974(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                context)
                {
                    var return_v = this_param.IsCompliantType(type, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 46936, 46974);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10621_46844_46897_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 46844, 46897);
                    return return_v;
                }


                bool
                f_10621_47087_47137(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                context)
                {
                    var return_v = IsInaccessibleBecauseOfConstruction(type, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 47087, 47137);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10621, 45451, 47149);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10621, 45451, 47149);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsInaccessibleBecauseOfConstruction(NamedTypeSymbol type, NamedTypeSymbol context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10621, 47902, 50214);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 48149, 48211);

                bool
                sawProtected = f_10621_48169_48210(f_10621_48169_48195(type))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 48225, 48249);

                bool
                sawGeneric = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 48296, 48364);

                Dictionary<NamedTypeSymbol, NamedTypeSymbol>
                containingTypes = null
                ;
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 48431, 48484);

                    NamedTypeSymbol
                    containingType = f_10621_48464_48483(type)
                    ;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 48502, 49116) || true) && ((object)containingType != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 48502, 49116);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 48581, 48750) || true) && (containingTypes == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 48581, 48750);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 48658, 48727);

                                containingTypes = f_10621_48676_48726();
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 48581, 48750);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 48774, 48857);

                            sawProtected = sawProtected || (DynAbs.Tracing.TraceSender.Expression_False(10621, 48789, 48856) || f_10621_48805_48856(f_10621_48805_48841(containingType)));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 48879, 48931);

                            sawGeneric = sawGeneric || (DynAbs.Tracing.TraceSender.Expression_False(10621, 48892, 48930) || f_10621_48906_48926(containingType) > 0);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 48955, 49026);

                            f_10621_48955_49025(
                                                containingTypes, f_10621_48975_49008(containingType), containingType);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 49050, 49097);

                            containingType = f_10621_49067_49096(containingType);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 48502, 49116);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10621, 48502, 49116);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10621, 48502, 49116);
                    }
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 49147, 49268) || true) && (!sawProtected || (DynAbs.Tracing.TraceSender.Expression_False(10621, 49151, 49179) || !sawGeneric) || (DynAbs.Tracing.TraceSender.Expression_False(10621, 49151, 49206) || containingTypes == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 49147, 49268);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 49240, 49253);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 49147, 49268);
                }
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 49284, 49971) || true) && ((object)context != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 49284, 49971);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 49348, 49390);

                        NamedTypeSymbol
                        contextBaseType = context
                        ;
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 49408, 49903) || true) && ((object)contextBaseType != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 49408, 49903);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 49488, 49519);

                                NamedTypeSymbol
                                containingType
                                = default(NamedTypeSymbol);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 49541, 49797) || true) && (f_10621_49545_49628(containingTypes, f_10621_49573_49607(contextBaseType), out containingType))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 49541, 49797);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 49678, 49774);

                                    return !f_10621_49686_49773(containingType, contextBaseType, TypeCompareKind.ConsiderEverything2);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 49541, 49797);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 49821, 49884);

                                contextBaseType = f_10621_49839_49883(contextBaseType);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 49408, 49903);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10621, 49408, 49903);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10621, 49408, 49903);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 49923, 49956);

                        context = f_10621_49933_49955(context);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 49284, 49971);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10621, 49284, 49971);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10621, 49284, 49971);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 50190, 50203);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10621, 47902, 50214);

                Microsoft.CodeAnalysis.Accessibility
                f_10621_48169_48195(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 48169, 48195);
                    return return_v;
                }


                bool
                f_10621_48169_48210(Microsoft.CodeAnalysis.Accessibility
                accessibility)
                {
                    var return_v = accessibility.HasProtected();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 48169, 48210);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10621_48464_48483(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 48464, 48483);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10621_48676_48726()
                {
                    var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 48676, 48726);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_10621_48805_48841(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 48805, 48841);
                    return return_v;
                }


                bool
                f_10621_48805_48856(Microsoft.CodeAnalysis.Accessibility
                accessibility)
                {
                    var return_v = accessibility.HasProtected();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 48805, 48856);
                    return return_v;
                }


                int
                f_10621_48906_48926(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 48906, 48926);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10621_48975_49008(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 48975, 49008);
                    return return_v;
                }


                int
                f_10621_48955_49025(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                key, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 48955, 49025);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10621_49067_49096(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 49067, 49096);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10621_49573_49607(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 49573, 49607);
                    return return_v;
                }


                bool
                f_10621_49545_49628(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                key, out Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 49545, 49628);
                    return return_v;
                }


                bool
                f_10621_49686_49773(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 49686, 49773);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10621_49839_49883(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 49839, 49883);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10621_49933_49955(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 49933, 49955);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10621, 47902, 50214);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10621, 47902, 50214);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Compliance GetDeclaredOrInheritedCompliance(Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10621, 50226, 52807);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 50317, 50490);

                f_10621_50317_50489(f_10621_50349_50360(symbol) == SymbolKind.NamedType || (DynAbs.Tracing.TraceSender.Expression_False(10621, 50349, 50413) || !((symbol is TypeSymbol))), "Type kinds without declarations are handled elsewhere.");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 50506, 51240) || true) && (f_10621_50510_50521(symbol) == SymbolKind.Namespace)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 50506, 51240);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 50679, 50746);

                    return f_10621_50686_50745(this, f_10621_50719_50744(symbol));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 50506, 51240);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 50506, 51240);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 50780, 51240) || true) && (f_10621_50784_50795(symbol) == SymbolKind.Method)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 50780, 51240);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 50850, 50893);

                        MethodSymbol
                        method = (MethodSymbol)symbol
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 50911, 50955);

                        Symbol
                        associated = f_10621_50931_50954(method)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 50973, 51225) || true) && ((object)associated != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 50973, 51225);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 51154, 51206);

                            return f_10621_51161_51205(this, associated);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 50973, 51225);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 50780, 51240);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 50506, 51240);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 51287, 51333);

                f_10621_51287_51332(f_10621_51300_51311(symbol) != SymbolKind.Alias);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 51347, 51393);

                f_10621_51347_51392(f_10621_51360_51371(symbol) != SymbolKind.Label);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 51407, 51457);

                f_10621_51407_51456(f_10621_51420_51431(symbol) != SymbolKind.Namespace);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 51471, 51521);

                f_10621_51471_51520(f_10621_51484_51495(symbol) != SymbolKind.Parameter);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 51535, 51589);

                f_10621_51535_51588(f_10621_51548_51559(symbol) != SymbolKind.RangeVariable);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 51605, 51627);

                Compliance
                compliance
                = default(Compliance);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 51641, 51778) || true) && (f_10621_51645_51711(_declaredOrInheritedCompliance, symbol, out compliance))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 51641, 51778);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 51745, 51763);

                    return compliance;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 51641, 51778);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 51794, 51819);

                Location
                ignoredLocation
                = default(Location);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 51833, 51911);

                bool?
                declaredCompliance = f_10621_51860_51910(this, symbol, out ignoredLocation)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 51925, 52514) || true) && (f_10621_51929_51956(declaredCompliance))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 51925, 52514);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 51990, 52095);

                    compliance = (DynAbs.Tracing.TraceSender.Conditional_F1(10621, 52003, 52041) || ((f_10621_52003_52041(declaredCompliance) && DynAbs.Tracing.TraceSender.Conditional_F2(10621, 52044, 52067)) || DynAbs.Tracing.TraceSender.Conditional_F3(10621, 52070, 52094))) ? Compliance.DeclaredTrue : Compliance.DeclaredFalse;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 51925, 52514);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 51925, 52514);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 52129, 52514) || true) && (f_10621_52133_52144(symbol) == SymbolKind.Assembly)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 52129, 52514);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 52289, 52326);

                        compliance = Compliance.ImpliedFalse;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 52129, 52514);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 52129, 52514);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 52392, 52499);

                        compliance = (DynAbs.Tracing.TraceSender.Conditional_F1(10621, 52405, 52443) || ((f_10621_52405_52443(f_10621_52412_52442(this, symbol)) && DynAbs.Tracing.TraceSender.Conditional_F2(10621, 52446, 52470)) || DynAbs.Tracing.TraceSender.Conditional_F3(10621, 52473, 52498))) ? Compliance.InheritedTrue : Compliance.InheritedFalse;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 52129, 52514);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 51925, 52514);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 52604, 52796);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10621, 52611, 52686) || (((f_10621_52612_52623(symbol) == SymbolKind.Assembly || (DynAbs.Tracing.TraceSender.Expression_False(10621, 52612, 52685) || f_10621_52650_52661(symbol) == SymbolKind.NamedType))
                && DynAbs.Tracing.TraceSender.Conditional_F2(10621, 52706, 52765)) || DynAbs.Tracing.TraceSender.Conditional_F3(10621, 52785, 52795))) ? f_10621_52706_52765(_declaredOrInheritedCompliance, symbol, compliance) : compliance;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10621, 50226, 52807);

                Microsoft.CodeAnalysis.SymbolKind
                f_10621_50349_50360(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 50349, 50360);
                    return return_v;
                }


                int
                f_10621_50317_50489(bool
                condition, string
                message)
                {
                    System.Diagnostics.Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 50317, 50489);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10621_50510_50521(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 50510, 50521);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10621_50719_50744(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 50719, 50744);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker.Compliance
                f_10621_50686_50745(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                symbol)
                {
                    var return_v = this_param.GetDeclaredOrInheritedCompliance((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 50686, 50745);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10621_50784_50795(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 50784, 50795);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10621_50931_50954(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.AssociatedSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 50931, 50954);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker.Compliance
                f_10621_51161_51205(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = this_param.GetDeclaredOrInheritedCompliance(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 51161, 51205);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10621_51300_51311(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 51300, 51311);
                    return return_v;
                }


                int
                f_10621_51287_51332(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 51287, 51332);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10621_51360_51371(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 51360, 51371);
                    return return_v;
                }


                int
                f_10621_51347_51392(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 51347, 51392);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10621_51420_51431(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 51420, 51431);
                    return return_v;
                }


                int
                f_10621_51407_51456(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 51407, 51456);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10621_51484_51495(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 51484, 51495);
                    return return_v;
                }


                int
                f_10621_51471_51520(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 51471, 51520);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10621_51548_51559(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 51548, 51559);
                    return return_v;
                }


                int
                f_10621_51535_51588(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 51535, 51588);
                    return 0;
                }


                bool
                f_10621_51645_51711(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker.Compliance>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                key, out Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker.Compliance
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 51645, 51711);
                    return return_v;
                }


                bool?
                f_10621_51860_51910(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, out Microsoft.CodeAnalysis.Location
                attributeLocation)
                {
                    var return_v = this_param.GetDeclaredCompliance(symbol, out attributeLocation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 51860, 51910);
                    return return_v;
                }


                bool
                f_10621_51929_51956(bool?
                this_param)
                {
                    var return_v = this_param.HasValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 51929, 51956);
                    return return_v;
                }


                bool
                f_10621_52003_52041(bool?
                this_param)
                {
                    var return_v = this_param.GetValueOrDefault();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 52003, 52041);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10621_52133_52144(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 52133, 52144);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker.Compliance
                f_10621_52412_52442(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = this_param.GetInheritedCompliance(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 52412, 52442);
                    return return_v;
                }


                bool
                f_10621_52405_52443(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker.Compliance
                compliance)
                {
                    var return_v = IsTrue(compliance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 52405, 52443);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10621_52612_52623(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 52612, 52623);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10621_52650_52661(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 52650, 52661);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker.Compliance
                f_10621_52706_52765(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker.Compliance>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                key, Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker.Compliance
                value)
                {
                    var return_v = this_param.GetOrAdd(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 52706, 52765);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10621, 50226, 52807);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10621, 50226, 52807);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Compliance GetInheritedCompliance(Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10621, 52819, 53214);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 52900, 52968);

                f_10621_52900_52967(f_10621_52932_52943(symbol) != SymbolKind.Assembly);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 52984, 53063);

                Symbol
                containing = (Symbol)f_10621_53012_53033(symbol) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbol>(10621, 53004, 53062) ?? f_10621_53037_53062(symbol))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 53077, 53137);

                f_10621_53077_53136((object)containing != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 53151, 53203);

                return f_10621_53158_53202(this, containing);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10621, 52819, 53214);

                Microsoft.CodeAnalysis.SymbolKind
                f_10621_52932_52943(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 52932, 52943);
                    return return_v;
                }


                int
                f_10621_52900_52967(bool
                condition)
                {
                    System.Diagnostics.Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 52900, 52967);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10621_53012_53033(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 53012, 53033);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10621_53037_53062(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 53037, 53062);
                    return return_v;
                }


                int
                f_10621_53077_53136(bool
                condition)
                {
                    System.Diagnostics.Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 53077, 53136);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker.Compliance
                f_10621_53158_53202(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = this_param.GetDeclaredOrInheritedCompliance(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 53158, 53202);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10621, 52819, 53214);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10621, 52819, 53214);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool? GetDeclaredCompliance(Symbol symbol, out Location attributeLocation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10621, 53545, 55499);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 53652, 53677);

                attributeLocation = null;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 53691, 55460);
                    foreach (CSharpAttributeData data in f_10621_53728_53750_I(f_10621_53728_53750(symbol)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 53691, 55460);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 53886, 55445) || true) && (f_10621_53890_53964(data, symbol, AttributeDescription.CLSCompliantAttribute))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 53886, 55445);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 54006, 54059);

                            NamedTypeSymbol
                            attributeClass = f_10621_54039_54058(data)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 54081, 54731) || true) && ((object)attributeClass != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 54081, 54731);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 54165, 54225);

                                DiagnosticInfo
                                info = f_10621_54187_54224(attributeClass)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 54251, 54708) || true) && (info != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 54251, 54708);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 54325, 54415);

                                    Location
                                    location = (DynAbs.Tracing.TraceSender.Conditional_F1(10621, 54345, 54369) || ((symbol.Locations.IsEmpty && DynAbs.Tracing.TraceSender.Conditional_F2(10621, 54372, 54392)) || DynAbs.Tracing.TraceSender.Conditional_F3(10621, 54395, 54414))) ? NoLocation.Singleton : f_10621_54395_54411(symbol)[0]
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 54445, 54500);

                                    f_10621_54445_54499(_diagnostics, f_10621_54466_54498(info, location));

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 54530, 54681) || true) && (f_10621_54534_54547(info) >= DiagnosticSeverity.Error)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 54530, 54681);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 54641, 54650);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 54530, 54681);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 54251, 54708);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 54081, 54731);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 54755, 55426) || true) && (f_10621_54759_54774_M(!data.HasErrors))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 54755, 55426);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 54824, 54998) || true) && (!f_10621_54829_54888(this, data, out attributeLocation))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 54824, 54998);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 54946, 54971);

                                    attributeLocation = null;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 54824, 54998);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 55026, 55095);

                                ImmutableArray<TypedConstant>
                                args = f_10621_55063_55094(data)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 55121, 55222);

                                f_10621_55121_55221(args.Length == 1, "We already checked the signature and HasErrors.");
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 55368, 55403);

                                return (bool)args[0].ValueInternal;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 54755, 55426);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 53886, 55445);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 53691, 55460);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10621, 1, 1770);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10621, 1, 1770);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 55476, 55488);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10621, 53545, 55499);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10621_53728_53750(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.GetAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 53728, 53750);
                    return return_v;
                }


                bool
                f_10621_53890_53964(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute(targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 53890, 53964);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10621_54039_54058(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.AttributeClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 54039, 54058);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10621_54187_54224(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetUseSiteDiagnostic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 54187, 54224);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10621_54395_54411(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 54395, 54411);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                f_10621_54466_54498(Microsoft.CodeAnalysis.DiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnostic(info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 54466, 54498);
                    return return_v;
                }


                int
                f_10621_54445_54499(System.Collections.Concurrent.ConcurrentQueue<Microsoft.CodeAnalysis.Diagnostic>
                this_param, Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                item)
                {
                    this_param.Enqueue((Microsoft.CodeAnalysis.Diagnostic)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 54445, 54499);
                    return 0;
                }


                Microsoft.CodeAnalysis.DiagnosticSeverity
                f_10621_54534_54547(Microsoft.CodeAnalysis.DiagnosticInfo
                this_param)
                {
                    var return_v = this_param.Severity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 54534, 54547);
                    return return_v;
                }


                bool
                f_10621_54759_54774_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 54759, 54774);
                    return return_v;
                }


                bool
                f_10621_54829_54888(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                attribute, out Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = this_param.TryGetAttributeWarningLocation(attribute, out location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 54829, 54888);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10621_55063_55094(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.CommonConstructorArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 55063, 55094);
                    return return_v;
                }


                int
                f_10621_55121_55221(bool
                condition, string
                message)
                {
                    System.Diagnostics.Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 55121, 55221);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10621_53728_53750_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 53728, 53750);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10621, 53545, 55499);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10621, 53545, 55499);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsAccessibleOutsideAssembly(Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10621, 55511, 55912);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 55598, 55875) || true) && ((object)symbol != null && (DynAbs.Tracing.TraceSender.Expression_True(10621, 55605, 55655) && !f_10621_55632_55655(symbol)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 55598, 55875);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 55689, 55811) || true) && (!f_10621_55694_55737(symbol))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 55689, 55811);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 55779, 55792);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 55689, 55811);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 55829, 55860);

                        symbol = f_10621_55838_55859(symbol);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 55598, 55875);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10621, 55598, 55875);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10621, 55598, 55875);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 55889, 55901);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10621, 55511, 55912);

                bool
                f_10621_55632_55655(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = IsImplicitClass(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 55632, 55655);
                    return return_v;
                }


                bool
                f_10621_55694_55737(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = IsAccessibleIfContainerIsAccessible(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 55694, 55737);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10621_55838_55859(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 55838, 55859);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10621, 55511, 55912);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10621, 55511, 55912);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsAccessibleIfContainerIsAccessible(Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10621, 55924, 56759);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 56019, 56748);

                switch (f_10621_56027_56055(symbol))
                {

                    case Accessibility.Public:
                    case Accessibility.Protected:
                    case Accessibility.ProtectedOrInternal:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 56019, 56748);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 56241, 56253);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 56019, 56748);

                    case Accessibility.Private:
                    case Accessibility.ProtectedAndInternal:
                    case Accessibility.Internal:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 56019, 56748);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 56424, 56437);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 56019, 56748);

                    case Accessibility.NotApplicable:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 56019, 56748);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 56510, 56579);

                        f_10621_56510_56578(f_10621_56542_56553(symbol) == SymbolKind.ErrorType);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 56601, 56614);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 56019, 56748);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 56019, 56748);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 56662, 56733);

                        throw f_10621_56668_56732(f_10621_56703_56731(symbol));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 56019, 56748);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10621, 55924, 56759);

                Microsoft.CodeAnalysis.Accessibility
                f_10621_56027_56055(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 56027, 56055);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10621_56542_56553(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 56542, 56553);
                    return return_v;
                }


                int
                f_10621_56510_56578(bool
                condition)
                {
                    System.Diagnostics.Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 56510, 56578);
                    return 0;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_10621_56703_56731(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 56703, 56731);
                    return return_v;
                }


                System.Exception
                f_10621_56668_56732(Microsoft.CodeAnalysis.Accessibility
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 56668, 56732);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10621, 55924, 56759);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10621, 55924, 56759);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void AddDiagnostic(ErrorCode code, Location location)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10621, 56771, 57005);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 56857, 56895);

                var
                info = f_10621_56868_56894(code)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 56909, 56953);

                var
                diag = f_10621_56920_56952(info, location)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 56967, 56994);

                f_10621_56967_56993(_diagnostics, diag);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10621, 56771, 57005);

                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10621_56868_56894(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 56868, 56894);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                f_10621_56920_56952(Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnostic((Microsoft.CodeAnalysis.DiagnosticInfo)info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 56920, 56952);
                    return return_v;
                }


                int
                f_10621_56967_56993(System.Collections.Concurrent.ConcurrentQueue<Microsoft.CodeAnalysis.Diagnostic>
                this_param, Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                item)
                {
                    this_param.Enqueue((Microsoft.CodeAnalysis.Diagnostic)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 56967, 56993);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10621, 56771, 57005);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10621, 56771, 57005);
            }
        }

        private void AddDiagnostic(ErrorCode code, Location location, params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10621, 57017, 57279);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 57125, 57169);

                var
                info = f_10621_57136_57168(code, args)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 57183, 57227);

                var
                diag = f_10621_57194_57226(info, location)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 57241, 57268);

                f_10621_57241_57267(_diagnostics, diag);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10621, 57017, 57279);

                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10621_57136_57168(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 57136, 57168);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                f_10621_57194_57226(Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnostic((Microsoft.CodeAnalysis.DiagnosticInfo)info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 57194, 57226);
                    return return_v;
                }


                int
                f_10621_57241_57267(System.Collections.Concurrent.ConcurrentQueue<Microsoft.CodeAnalysis.Diagnostic>
                this_param, Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                item)
                {
                    this_param.Enqueue((Microsoft.CodeAnalysis.Diagnostic)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 57241, 57267);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10621, 57017, 57279);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10621, 57017, 57279);
            }
        }

        private static bool IsImplicitClass(Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10621, 57291, 57465);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 57366, 57454);

                return f_10621_57373_57384(symbol) == SymbolKind.NamedType && (DynAbs.Tracing.TraceSender.Expression_True(10621, 57373, 57453) && f_10621_57412_57453(((NamedTypeSymbol)symbol)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10621, 57291, 57465);

                Microsoft.CodeAnalysis.SymbolKind
                f_10621_57373_57384(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 57373, 57384);
                    return return_v;
                }


                bool
                f_10621_57412_57453(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsImplicitClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 57412, 57453);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10621, 57291, 57465);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10621, 57291, 57465);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsTrue(Compliance compliance)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10621, 57477, 58020);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 57551, 58009);

                switch (compliance)
                {

                    case Compliance.DeclaredTrue:
                    case Compliance.InheritedTrue:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 57551, 58009);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 57702, 57714);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 57551, 58009);

                    case Compliance.DeclaredFalse:
                    case Compliance.InheritedFalse:
                    case Compliance.ImpliedFalse:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 57551, 58009);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 57880, 57893);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 57551, 58009);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 57551, 58009);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 57941, 57994);

                        throw f_10621_57947_57993(compliance);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 57551, 58009);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10621, 57477, 58020);

                System.Exception
                f_10621_57947_57993(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker.Compliance
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 57947, 57993);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10621, 57477, 58020);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10621, 57477, 58020);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsDeclared(Compliance compliance)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10621, 58032, 58579);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 58110, 58568);

                switch (compliance)
                {

                    case Compliance.DeclaredTrue:
                    case Compliance.DeclaredFalse:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 58110, 58568);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 58261, 58273);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 58110, 58568);

                    case Compliance.InheritedTrue:
                    case Compliance.InheritedFalse:
                    case Compliance.ImpliedFalse:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 58110, 58568);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 58439, 58452);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 58110, 58568);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 58110, 58568);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 58500, 58553);

                        throw f_10621_58506_58552(compliance);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 58110, 58568);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10621, 58032, 58579);

                System.Exception
                f_10621_58506_58552(Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker.Compliance
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 58506, 58552);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10621, 58032, 58579);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10621, 58032, 58579);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private enum Compliance
        {
            DeclaredTrue,
            DeclaredFalse,
            InheritedTrue,
            InheritedFalse,
            ImpliedFalse,
        }

        private static bool TryGetCollisionErrorCode(Symbol x, Symbol y, out ErrorCode code)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10621, 58893, 63234);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 59002, 59053);

                f_10621_59002_59052((object)x != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 59067, 59118);

                f_10621_59067_59117((object)y != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 59132, 59188);

                f_10621_59132_59187((object)x != (object)y);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 59202, 59252);

                f_10621_59202_59251(f_10621_59234_59240(x) == f_10621_59244_59250(y));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 59268, 59290);

                code = ErrorCode.Void;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 59306, 59358);

                ImmutableArray<TypeWithAnnotations>
                xParameterTypes
                = default(ImmutableArray<TypeWithAnnotations>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 59372, 59424);

                ImmutableArray<TypeWithAnnotations>
                yParameterTypes
                = default(ImmutableArray<TypeWithAnnotations>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 59438, 59472);

                ImmutableArray<RefKind>
                xRefKinds
                = default(ImmutableArray<RefKind>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 59486, 59520);

                ImmutableArray<RefKind>
                yRefKinds
                = default(ImmutableArray<RefKind>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 59534, 60524);

                switch (f_10621_59542_59548(x))
                {

                    case SymbolKind.Method:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 59534, 60524);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 59627, 59652);

                        var
                        mX = (MethodSymbol)x
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 59674, 59725);

                        xParameterTypes = f_10621_59692_59724(mX);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 59747, 59780);

                        xRefKinds = f_10621_59759_59779(mX);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 59804, 59829);

                        var
                        mY = (MethodSymbol)y
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 59851, 59902);

                        yParameterTypes = f_10621_59869_59901(mY);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 59924, 59957);

                        yRefKinds = f_10621_59936_59956(mY);
                        DynAbs.Tracing.TraceSender.TraceBreak(10621, 59979, 59985);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 59534, 60524);

                    case SymbolKind.Property:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 59534, 60524);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 60050, 60077);

                        var
                        pX = (PropertySymbol)x
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 60099, 60150);

                        xParameterTypes = f_10621_60117_60149(pX);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 60172, 60205);

                        xRefKinds = f_10621_60184_60204(pX);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 60229, 60256);

                        var
                        pY = (PropertySymbol)y
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 60278, 60329);

                        yParameterTypes = f_10621_60296_60328(pY);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 60351, 60384);

                        yRefKinds = f_10621_60363_60383(pY);
                        DynAbs.Tracing.TraceSender.TraceBreak(10621, 60406, 60412);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 59534, 60524);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 59534, 60524);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 60460, 60509);

                        throw f_10621_60466_60508(f_10621_60501_60507(x));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 59534, 60524);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 60540, 60579);

                int
                numParams = xParameterTypes.Length
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 60595, 60696) || true) && (yParameterTypes.Length != numParams)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 60595, 60696);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 60668, 60681);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 60595, 60696);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 60884, 60955);

                bool
                sawRefKindDifference = xRefKinds.IsDefault != yRefKinds.IsDefault
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 60969, 61005);

                bool
                sawArrayRankDifference = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 61019, 61059);

                bool
                sawArrayOfArraysDifference = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 61084, 61089);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 61075, 62821) || true) && (i < numParams)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 61106, 61109)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 61075, 62821))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 61075, 62821);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 61143, 61186);

                        TypeSymbol
                        xType = xParameterTypes[i].Type
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 61204, 61247);

                        TypeSymbol
                        yType = yParameterTypes[i].Type
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 61267, 61302);

                        TypeKind
                        typeKind = f_10621_61287_61301(xType)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 61320, 61424) || true) && (f_10621_61324_61338(yType) != typeKind)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 61320, 61424);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 61392, 61405);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 61320, 61424);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 61444, 62625) || true) && (typeKind == TypeKind.Array)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 61444, 62625);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 61516, 61568);

                            ArrayTypeSymbol
                            xArrayType = (ArrayTypeSymbol)xType
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 61590, 61642);

                            ArrayTypeSymbol
                            yArrayType = (ArrayTypeSymbol)yType
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 61666, 61752);

                            sawArrayRankDifference = sawArrayRankDifference || (DynAbs.Tracing.TraceSender.Expression_False(10621, 61691, 61751) || f_10621_61717_61732(xArrayType) != f_10621_61736_61751(yArrayType));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 61776, 61906);

                            bool
                            elementTypesDiffer = !f_10621_61803_61905(f_10621_61821_61843(xArrayType), f_10621_61845_61867(yArrayType), TypeCompareKind.ConsiderEverything2)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 62088, 62436) || true) && (f_10621_62092_62119(xArrayType) || (DynAbs.Tracing.TraceSender.Expression_False(10621, 62092, 62150) || f_10621_62123_62150(yArrayType)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 62088, 62436);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 62200, 62278);

                                sawArrayOfArraysDifference = sawArrayOfArraysDifference || (DynAbs.Tracing.TraceSender.Expression_False(10621, 62229, 62277) || elementTypesDiffer);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 62088, 62436);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 62088, 62436);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 62328, 62436) || true) && (elementTypesDiffer)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 62328, 62436);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 62400, 62413);

                                    return false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 62328, 62436);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 62088, 62436);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 61444, 62625);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 61444, 62625);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 62478, 62625) || true) && (!f_10621_62483_62551(xType, yType, TypeCompareKind.ConsiderEverything2))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 62478, 62625);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 62593, 62606);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 62478, 62625);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 61444, 62625);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 62645, 62806) || true) && (f_10621_62649_62669_M(!xRefKinds.IsDefault))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10621, 62645, 62806);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 62711, 62787);

                            sawRefKindDifference = sawRefKindDifference || (DynAbs.Tracing.TraceSender.Expression_False(10621, 62734, 62786) || xRefKinds[i] != yRefKinds[i]);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10621, 62645, 62806);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10621, 1, 1747);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10621, 1, 1747);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 62837, 63177);

                code =
                (DynAbs.Tracing.TraceSender.Conditional_F1(10621, 62861, 62887) || ((sawArrayOfArraysDifference && DynAbs.Tracing.TraceSender.Conditional_F2(10621, 62890, 62923)) || DynAbs.Tracing.TraceSender.Conditional_F3(10621, 62943, 63176))) ? ErrorCode.WRN_CLS_OverloadUnnamed : (DynAbs.Tracing.TraceSender.Conditional_F1(10621, 62943, 62965) || ((sawArrayRankDifference && DynAbs.Tracing.TraceSender.Conditional_F2(10621, 62968, 63000)) || DynAbs.Tracing.TraceSender.Conditional_F3(10621, 63087, 63176))) ? ErrorCode.WRN_CLS_OverloadRefOut : (DynAbs.Tracing.TraceSender.Conditional_F1(10621, 63087, 63107) || ((sawRefKindDifference && DynAbs.Tracing.TraceSender.Conditional_F2(10621, 63110, 63142)) || DynAbs.Tracing.TraceSender.Conditional_F3(10621, 63162, 63176))) ? ErrorCode.WRN_CLS_OverloadRefOut : ErrorCode.Void;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 63193, 63223);

                return code != ErrorCode.Void;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10621, 58893, 63234);

                int
                f_10621_59002_59052(bool
                condition)
                {
                    System.Diagnostics.Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 59002, 59052);
                    return 0;
                }


                int
                f_10621_59067_59117(bool
                condition)
                {
                    System.Diagnostics.Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 59067, 59117);
                    return 0;
                }


                int
                f_10621_59132_59187(bool
                condition)
                {
                    System.Diagnostics.Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 59132, 59187);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10621_59234_59240(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 59234, 59240);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10621_59244_59250(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 59244, 59250);
                    return return_v;
                }


                int
                f_10621_59202_59251(bool
                condition)
                {
                    System.Diagnostics.Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 59202, 59251);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10621_59542_59548(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 59542, 59548);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10621_59692_59724(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterTypesWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 59692, 59724);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10621_59759_59779(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterRefKinds;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 59759, 59779);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10621_59869_59901(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterTypesWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 59869, 59901);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10621_59936_59956(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterRefKinds;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 59936, 59956);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10621_60117_60149(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.ParameterTypesWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 60117, 60149);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10621_60184_60204(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.ParameterRefKinds;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 60184, 60204);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10621_60296_60328(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.ParameterTypesWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 60296, 60328);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10621_60363_60383(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.ParameterRefKinds;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 60363, 60383);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10621_60501_60507(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 60501, 60507);
                    return return_v;
                }


                System.Exception
                f_10621_60466_60508(Microsoft.CodeAnalysis.SymbolKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 60466, 60508);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10621_61287_61301(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 61287, 61301);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10621_61324_61338(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 61324, 61338);
                    return return_v;
                }


                int
                f_10621_61717_61732(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.Rank;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 61717, 61732);
                    return return_v;
                }


                int
                f_10621_61736_61751(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.Rank;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 61736, 61751);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10621_61821_61843(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.ElementType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 61821, 61843);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10621_61845_61867(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.ElementType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 61845, 61867);
                    return return_v;
                }


                bool
                f_10621_61803_61905(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 61803, 61905);
                    return return_v;
                }


                bool
                f_10621_62092_62119(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                arrayType)
                {
                    var return_v = IsArrayOfArrays(arrayType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 62092, 62119);
                    return return_v;
                }


                bool
                f_10621_62123_62150(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                arrayType)
                {
                    var return_v = IsArrayOfArrays(arrayType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 62123, 62150);
                    return return_v;
                }


                bool
                f_10621_62483_62551(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 62483, 62551);
                    return return_v;
                }


                bool
                f_10621_62649_62669_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 62649, 62669);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10621, 58893, 63234);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10621, 58893, 63234);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsArrayOfArrays(ArrayTypeSymbol arrayType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10621, 63246, 63402);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10621, 63333, 63391);

                return f_10621_63340_63366(f_10621_63340_63361(arrayType)) == SymbolKind.ArrayType;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10621, 63246, 63402);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10621_63340_63361(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.ElementType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 63340, 63361);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10621_63340_63366(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 63340, 63366);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10621, 63246, 63402);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10621, 63246, 63402);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ClsComplianceChecker()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10621, 698, 63409);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10621, 698, 63409);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10621, 698, 63409);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10621, 698, 63409);

        System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker.Compliance>
        f_10621_2044_2139(System.Collections.Generic.EqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbol>
        comparer)
        {
            var return_v = new System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.ClsComplianceChecker.Compliance>((System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbol>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 2044, 2139);
            return return_v;
        }


        bool
        f_10621_2160_2178()
        {
            var return_v = ConcurrentAnalysis;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 2160, 2178);
            return return_v;
        }


        System.Collections.Concurrent.ConcurrentStack<System.Threading.Tasks.Task>
        f_10621_2229_2256()
        {
            var return_v = new System.Collections.Concurrent.ConcurrentStack<System.Threading.Tasks.Task>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10621, 2229, 2256);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        f_10621_2515_2535(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param)
        {
            var return_v = this_param.Options;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 2515, 2535);
            return return_v;
        }


        bool
        f_10621_2515_2551(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        this_param)
        {
            var return_v = this_param.ConcurrentBuild;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10621, 2515, 2551);
            return return_v;
        }

    }
}
