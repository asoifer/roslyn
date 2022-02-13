// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Diagnostics;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Emit;
using Microsoft.CodeAnalysis.CSharp.Symbols;

using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class SynthesizedMetadataCompiler : CSharpSymbolVisitor
    {
        private readonly PEModuleBuilder _moduleBeingBuilt;

        private readonly CancellationToken _cancellationToken;

        private SynthesizedMetadataCompiler(PEModuleBuilder moduleBeingBuilt, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10628, 1141, 1426);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10628, 1047, 1064);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10628, 1272, 1311);

                f_10628_1272_1310(moduleBeingBuilt != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10628, 1325, 1362);

                _moduleBeingBuilt = moduleBeingBuilt;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10628, 1376, 1415);

                _cancellationToken = cancellationToken;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10628, 1141, 1426);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10628, 1141, 1426);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10628, 1141, 1426);
            }
        }

        public static void ProcessSynthesizedMembers(
                    CSharpCompilation compilation,
                    PEModuleBuilder moduleBeingBuilt,
                    CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10628, 1748, 2180);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10628, 1959, 1998);

                f_10628_1959_1997(moduleBeingBuilt != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10628, 2014, 2098);

                var
                compiler = f_10628_2029_2097(moduleBeingBuilt, cancellationToken)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10628, 2112, 2169);

                f_10628_2112_2168(compiler, f_10628_2127_2167(f_10628_2127_2151(compilation)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10628, 1748, 2180);

                int
                f_10628_1959_1997(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10628, 1959, 1997);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.SynthesizedMetadataCompiler
                f_10628_2029_2097(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                moduleBeingBuilt, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SynthesizedMetadataCompiler(moduleBeingBuilt, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10628, 2029, 2097);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10628_2127_2151(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.SourceModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10628, 2127, 2151);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_10628_2127_2167(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10628, 2127, 2167);
                    return return_v;
                }


                int
                f_10628_2112_2168(Microsoft.CodeAnalysis.CSharp.SynthesizedMetadataCompiler
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                symbol)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10628, 2112, 2168);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10628, 1748, 2180);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10628, 1748, 2180);
            }
        }

        public override void VisitNamespace(NamespaceSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10628, 2192, 2454);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10628, 2276, 2326);

                _cancellationToken.ThrowIfCancellationRequested();
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10628, 2342, 2443);
                    foreach (var s in f_10628_2360_2379_I(f_10628_2360_2379(symbol)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10628, 2342, 2443);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10628, 2413, 2428);

                        f_10628_2413_2427(s, this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10628, 2342, 2443);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10628, 1, 102);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10628, 1, 102);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10628, 2192, 2454);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10628_2360_2379(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param)
                {
                    var return_v = this_param.GetMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10628, 2360, 2379);
                    return return_v;
                }


                int
                f_10628_2413_2427(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param, Microsoft.CodeAnalysis.CSharp.SynthesizedMetadataCompiler
                visitor)
                {
                    this_param.Accept((Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10628, 2413, 2427);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10628_2360_2379_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10628, 2360, 2379);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10628, 2192, 2454);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10628, 2192, 2454);
            }
        }

        public override void VisitNamedType(NamedTypeSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10628, 2466, 3953);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10628, 2550, 2600);

                _cancellationToken.ThrowIfCancellationRequested();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10628, 2616, 2681);

                var
                sourceTypeSymbol = symbol as SourceMemberContainerTypeSymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10628, 2695, 3601) || true) && ((object)sourceTypeSymbol != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10628, 2695, 3601);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10628, 2765, 3586) || true) && (_moduleBeingBuilt != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10628, 2765, 3586);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10628, 3288, 3567);
                            foreach (var synthesizedExplicitImpl in f_10628_3328_3402_I(f_10628_3328_3402(sourceTypeSymbol, _cancellationToken)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10628, 3288, 3567);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10628, 3452, 3544);

                                f_10628_3452_3543(_moduleBeingBuilt, symbol, f_10628_3503_3542(synthesizedExplicitImpl));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10628, 3288, 3567);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10628, 1, 280);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10628, 1, 280);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10628, 2765, 3586);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10628, 2695, 3601);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10628, 3617, 3942);
                    foreach (Symbol member in f_10628_3643_3662_I(f_10628_3643_3662(symbol)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10628, 3617, 3942);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10628, 3696, 3927);

                        switch (f_10628_3704_3715(member))
                        {

                            case SymbolKind.Property:
                            case SymbolKind.NamedType:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10628, 3696, 3927);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10628, 3856, 3876);

                                f_10628_3856_3875(member, this);
                                DynAbs.Tracing.TraceSender.TraceBreak(10628, 3902, 3908);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10628, 3696, 3927);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10628, 3617, 3942);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10628, 1, 326);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10628, 1, 326);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10628, 2466, 3953);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedExplicitImplementationForwardingMethod>
                f_10628_3328_3402(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetSynthesizedExplicitImplementations(cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10628, 3328, 3402);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                f_10628_3503_3542(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedExplicitImplementationForwardingMethod
                this_param)
                {
                    var return_v = this_param.GetCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10628, 3503, 3542);
                    return return_v;
                }


                int
                f_10628_3452_3543(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                container, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                method)
                {
                    this_param.AddSynthesizedDefinition(container, (Microsoft.Cci.IMethodDefinition)method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10628, 3452, 3543);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedExplicitImplementationForwardingMethod>
                f_10628_3328_3402_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedExplicitImplementationForwardingMethod>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10628, 3328, 3402);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10628_3643_3662(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10628, 3643, 3662);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10628_3704_3715(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10628, 3704, 3715);
                    return return_v;
                }


                int
                f_10628_3856_3875(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param, Microsoft.CodeAnalysis.CSharp.SynthesizedMetadataCompiler
                visitor)
                {
                    this_param.Accept((Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10628, 3856, 3875);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10628_3643_3662_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10628, 3643, 3662);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10628, 2466, 3953);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10628, 2466, 3953);
            }
        }

        public override void VisitProperty(PropertySymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10628, 3965, 4537);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10628, 4047, 4103);

                var
                sourceProperty = symbol as SourcePropertySymbolBase
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10628, 4117, 4526) || true) && ((object)sourceProperty != null && (DynAbs.Tracing.TraceSender.Expression_True(10628, 4121, 4178) && f_10628_4155_4178(sourceProperty)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10628, 4117, 4526);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10628, 4212, 4282);

                    var
                    synthesizedAccessor = f_10628_4238_4281(sourceProperty)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10628, 4300, 4511) || true) && ((object)synthesizedAccessor != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10628, 4300, 4511);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10628, 4381, 4492);

                        f_10628_4381_4491(_moduleBeingBuilt, f_10628_4424_4453(sourceProperty), f_10628_4455_4490(synthesizedAccessor));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10628, 4300, 4511);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10628, 4117, 4526);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10628, 3965, 4537);

                bool
                f_10628_4155_4178(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                this_param)
                {
                    var return_v = this_param.IsSealed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10628, 4155, 4178);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedSealedPropertyAccessor
                f_10628_4238_4281(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                this_param)
                {
                    var return_v = this_param.SynthesizedSealedAccessorOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10628, 4238, 4281);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10628_4424_4453(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10628, 4424, 4453);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                f_10628_4455_4490(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedSealedPropertyAccessor
                this_param)
                {
                    var return_v = this_param.GetCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10628, 4455, 4490);
                    return return_v;
                }


                int
                f_10628_4381_4491(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                container, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                method)
                {
                    this_param.AddSynthesizedDefinition(container, (Microsoft.Cci.IMethodDefinition)method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10628, 4381, 4491);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10628, 3965, 4537);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10628, 3965, 4537);
            }
        }

        public override void VisitMethod(MethodSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10628, 4560, 4686);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10628, 4638, 4675);

                throw f_10628_4644_4674();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10628, 4560, 4686);

                System.Exception
                f_10628_4644_4674()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10628, 4644, 4674);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10628, 4560, 4686);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10628, 4560, 4686);
            }
        }

        static SynthesizedMetadataCompiler()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10628, 926, 4701);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10628, 926, 4701);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10628, 926, 4701);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10628, 926, 4701);

        int
        f_10628_1272_1310(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10628, 1272, 1310);
            return 0;
        }

    }
}
