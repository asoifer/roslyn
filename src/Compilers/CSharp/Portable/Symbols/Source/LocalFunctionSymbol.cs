// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Diagnostics;
using System.Threading;
using Microsoft.Cci;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class LocalFunctionSymbol : SourceMethodSymbolWithAttributes
    {
        private readonly Binder _binder;

        private readonly Symbol _containingSymbol;

        private readonly DeclarationModifiers _declarationModifiers;

        private readonly ImmutableArray<SourceMethodTypeParameterSymbol> _typeParameters;

        private readonly RefKind _refKind;

        private ImmutableArray<ParameterSymbol> _lazyParameters;

        private bool _lazyIsVarArg;

        private ImmutableArray<ImmutableArray<TypeWithAnnotations>> _lazyTypeParameterConstraintTypes;

        private ImmutableArray<TypeParameterConstraintKind> _lazyTypeParameterConstraintKinds;

        private TypeWithAnnotations.Boxed? _lazyReturnType;

        private TypeWithAnnotations.Boxed? _lazyIteratorElementType;

        private readonly DiagnosticBag _declarationDiagnostics;

        public LocalFunctionSymbol(
                    Binder binder,
                    Symbol containingSymbol,
                    LocalFunctionStatementSyntax syntax)
        : base(f_10233_1871_1892_C(f_10233_1871_1892(syntax)))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10233, 1707, 3984);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 609, 616);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 651, 668);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 717, 738);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 865, 873);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 965, 978);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 1310, 1325);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 1371, 1395);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 1671, 1694);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 4182, 4218);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 1918, 1955);

                _containingSymbol = containingSymbol;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 1971, 2017);

                _declarationDiagnostics = f_10233_1997_2016();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 2033, 2200);

                _declarationModifiers =
                                DeclarationModifiers.Private |
                                syntax.Modifiers.ToDeclarationModifiers(diagnostics: _declarationDiagnostics);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 2216, 2374) || true) && (f_10233_2220_2263(f_10233_2251_2262(syntax)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10233, 2216, 2374);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 2297, 2359);

                    _lazyIteratorElementType = TypeWithAnnotations.Boxed.Sentinel;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10233, 2216, 2374);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 2390, 2463);

                f_10233_2390_2462(
                            this, _declarationModifiers, _declarationDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 2479, 2500);

                ScopeBinder = binder;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 2516, 2578);

                binder = f_10233_2525_2577(binder, f_10233_2560_2576(syntax));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 2594, 3052) || true) && (f_10233_2598_2622(syntax) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10233, 2594, 3052);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 2664, 2722);

                    binder = f_10233_2673_2721(this, binder);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 2740, 2802);

                    _typeParameters = f_10233_2758_2801(this, _declarationDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10233, 2594, 3052);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10233, 2594, 3052);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 2868, 2940);

                    _typeParameters = ImmutableArray<SourceMethodTypeParameterSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 2958, 3037);

                    f_10233_2958_3036(f_10233_2986_3010(syntax), _declarationDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10233, 2594, 3052);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 3068, 3211) || true) && (f_10233_3072_3089())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10233, 3068, 3211);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 3123, 3196);

                    f_10233_3123_3195(_declarationDiagnostics, ErrorCode.ERR_BadExtensionAgg, f_10233_3182_3191()[0]);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10233, 3068, 3211);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 3227, 3403);
                    foreach (var param in f_10233_3249_3280_I(f_10233_3249_3280(f_10233_3249_3269(syntax))))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10233, 3227, 3403);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 3314, 3388);

                        f_10233_3314_3387(this, f_10233_3341_3361(param), _declarationDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10233, 3227, 3403);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10233, 1, 177);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10233, 1, 177);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 3419, 3940) || true) && (f_10233_3423_3447(f_10233_3423_3440(syntax)) == SyntaxKind.RefType)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10233, 3419, 3940);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 3503, 3553);

                    var
                    returnType = (RefTypeSyntax)f_10233_3535_3552(syntax)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 3571, 3835) || true) && (returnType.ReadOnlyKeyword.Kind() == SyntaxKind.ReadOnlyKeyword)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10233, 3571, 3835);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 3680, 3711);

                        _refKind = RefKind.RefReadOnly;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10233, 3571, 3835);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10233, 3571, 3835);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 3793, 3816);

                        _refKind = RefKind.Ref;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10233, 3571, 3835);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10233, 3419, 3940);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10233, 3419, 3940);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 3901, 3925);

                    _refKind = RefKind.None;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10233, 3419, 3940);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 3956, 3973);

                _binder = binder;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10233, 1707, 3984);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10233, 1707, 3984);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10233, 1707, 3984);
            }
        }

        internal Binder ScopeBinder { get; }

        public Binder ParameterBinder
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10233, 4260, 4270);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 4263, 4270);
                    return _binder; DynAbs.Tracing.TraceSender.TraceExitMethod(10233, 4260, 4270);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10233, 4260, 4270);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10233, 4260, 4270);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal LocalFunctionStatementSyntax Syntax
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10233, 4328, 4391);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 4331, 4391);
                    return (LocalFunctionStatementSyntax)f_10233_4361_4391(syntaxReferenceOpt); DynAbs.Tracing.TraceSender.TraceExitMethod(10233, 4328, 4391);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10233, 4328, 4391);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10233, 4328, 4391);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal void GetDeclarationDiagnostics(DiagnosticBag addTo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10233, 4404, 5578);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 4536, 4684);
                    foreach (var typeParam in f_10233_4562_4577_I(_typeParameters))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10233, 4536, 4684);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 4611, 4669);

                        f_10233_4611_4668(typeParam, null, default(CancellationToken));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10233, 4536, 4684);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10233, 1, 149);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10233, 1, 149);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 4732, 4752);

                f_10233_4732_4751(this);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 4768, 4974);
                    foreach (var p in f_10233_4786_4801_I(_lazyParameters))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10233, 4768, 4974);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 4909, 4959);

                        f_10233_4909_4958(                // Force complete parameters to retrieve all diagnostics
                                        p, null, default(CancellationToken));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10233, 4768, 4974);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10233, 1, 207);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10233, 1, 207);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 4990, 5010);

                f_10233_4990_5009(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 5026, 5042);

                f_10233_5026_5041(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 5056, 5082);

                f_10233_5056_5081(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 5098, 5141);

                f_10233_5098_5140(this, _declarationDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 5157, 5197);

                f_10233_5157_5196(
                            addTo, _declarationDiagnostics);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 5213, 5567) || true) && (f_10233_5217_5238() && (DynAbs.Tracing.TraceSender.Expression_True(10233, 5217, 5258) && f_10233_5242_5258_M(!IsGenericMethod)) && (DynAbs.Tracing.TraceSender.Expression_True(10233, 5217, 5339) && f_10233_5279_5295() is SynthesizedSimpleProgramEntryPointSymbol) && (DynAbs.Tracing.TraceSender.Expression_True(10233, 5217, 5442) && f_10233_5360_5430(f_10233_5360_5380(), this, f_10233_5410_5429()).IsCandidate))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10233, 5213, 5567);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 5476, 5552);

                    f_10233_5476_5551(addTo, ErrorCode.WRN_MainIgnored, f_10233_5513_5519().Identifier.GetLocation(), this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10233, 5213, 5567);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10233, 4404, 5578);

                int
                f_10233_4611_4668(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodTypeParameterSymbol
                this_param, Microsoft.CodeAnalysis.SourceLocation
                locationOpt, System.Threading.CancellationToken
                cancellationToken)
                {
                    this_param.ForceComplete(locationOpt, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 4611, 4668);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodTypeParameterSymbol>
                f_10233_4562_4577_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodTypeParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 4562, 4577);
                    return return_v;
                }


                int
                f_10233_4732_4751(Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                this_param)
                {
                    this_param.ComputeParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 4732, 4751);
                    return 0;
                }


                int
                f_10233_4909_4958(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param, Microsoft.CodeAnalysis.SourceLocation
                locationOpt, System.Threading.CancellationToken
                cancellationToken)
                {
                    this_param.ForceComplete(locationOpt, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 4909, 4958);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10233_4786_4801_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 4786, 4801);
                    return return_v;
                }


                int
                f_10233_4990_5009(Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                this_param)
                {
                    this_param.ComputeReturnType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 4990, 5009);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10233_5026_5041(Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                this_param)
                {
                    var return_v = this_param.GetAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 5026, 5041);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10233_5056_5081(Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                this_param)
                {
                    var return_v = this_param.GetReturnTypeAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 5056, 5081);
                    return return_v;
                }


                int
                f_10233_5098_5140(Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.AsyncMethodChecks(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 5098, 5140);
                    return 0;
                }


                int
                f_10233_5157_5196(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                bag)
                {
                    this_param.AddRange(bag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 5157, 5196);
                    return 0;
                }


                bool
                f_10233_5217_5238()
                {
                    var return_v = IsEntryPointCandidate;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10233, 5217, 5238);
                    return return_v;
                }


                bool
                f_10233_5242_5258_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10233, 5242, 5258);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10233_5279_5295()
                {
                    var return_v = ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10233, 5279, 5295);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10233_5360_5380()
                {
                    var return_v = DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10233, 5360, 5380);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10233_5410_5429()
                {
                    var return_v = new Microsoft.CodeAnalysis.DiagnosticBag();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 5410, 5429);
                    return return_v;
                }


                (bool IsCandidate, bool IsTaskLike)
                f_10233_5360_5430(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                method, Microsoft.CodeAnalysis.DiagnosticBag
                bag)
                {
                    var return_v = this_param.HasEntryPointSignature((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)method, bag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 5360, 5430);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax
                f_10233_5513_5519()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10233, 5513, 5519);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10233_5476_5551(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 5476, 5551);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10233, 4404, 5578);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10233, 4404, 5578);
            }
        }

        internal override void AddDeclarationDiagnostics(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10233, 5679, 5727);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 5682, 5727);
                f_10233_5682_5727(_declarationDiagnostics, diagnostics); DynAbs.Tracing.TraceSender.TraceExitMethod(10233, 5679, 5727);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10233, 5679, 5727);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10233, 5679, 5727);
            }

            int
            f_10233_5682_5727(Microsoft.CodeAnalysis.DiagnosticBag
            this_param, Microsoft.CodeAnalysis.DiagnosticBag
            bag)
            {
                this_param.AddRange(bag);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 5682, 5727);
                return 0;
            }

        }

        public override bool RequiresInstanceReceiver
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10233, 5786, 5794);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 5789, 5794);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10233, 5786, 5794);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10233, 5786, 5794);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10233, 5786, 5794);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsVararg
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10233, 5861, 5971);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 5897, 5917);

                    f_10233_5897_5916(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 5935, 5956);

                    return _lazyIsVarArg;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10233, 5861, 5971);

                    int
                    f_10233_5897_5916(Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                    this_param)
                    {
                        this_param.ComputeParameters();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 5897, 5916);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10233, 5807, 5982);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10233, 5807, 5982);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<ParameterSymbol> Parameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10233, 6077, 6189);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 6113, 6133);

                    f_10233_6113_6132(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 6151, 6174);

                    return _lazyParameters;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10233, 6077, 6189);

                    int
                    f_10233_6113_6132(Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                    this_param)
                    {
                        this_param.ComputeParameters();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 6113, 6132);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10233, 5994, 6200);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10233, 5994, 6200);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private void ComputeParameters()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10233, 6212, 8052);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 6269, 6352) || true) && (_lazyParameters != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10233, 6269, 6352);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 6330, 6337);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10233, 6269, 6352);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 6368, 6393);

                SyntaxToken
                arglistToken
                = default(SyntaxToken);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 6407, 6453);

                var
                diagnostics = f_10233_6425_6452()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 6469, 6824);

                var
                parameters = f_10233_6486_6823(_binder, this, f_10233_6585_6610(f_10233_6585_6596(this)), arglistToken: out arglistToken, allowRefOrOut: true, allowThis: true, addRefReadOnlyModifier: false, diagnostics: diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 6840, 6879);

                var
                compilation = f_10233_6858_6878()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 6893, 7006);

                f_10233_6893_7005(compilation, parameters, diagnostics, modifyCompilation: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 7020, 7136);

                f_10233_7020_7135(compilation, parameters, diagnostics, modifyCompilation: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 7150, 7267);

                f_10233_7150_7266(compilation, this, parameters, diagnostics, modifyCompilation: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 7435, 7499);

                var
                isVararg = arglistToken.Kind() == SyntaxKind.ArgListKeyword
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 7513, 7648) || true) && (isVararg)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10233, 7513, 7648);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 7559, 7633);

                    f_10233_7559_7632(diagnostics, ErrorCode.ERR_IllegalVarArgs, arglistToken.GetLocation());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10233, 7513, 7648);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 7670, 7693);

                lock (_declarationDiagnostics)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 7727, 7863) || true) && (_lazyParameters != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10233, 7727, 7863);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 7796, 7815);

                        f_10233_7796_7814(diagnostics);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 7837, 7844);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10233, 7727, 7863);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 7883, 7936);

                    f_10233_7883_7935(
                                    _declarationDiagnostics, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 7954, 7979);

                    _lazyIsVarArg = isVararg;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 7997, 8026);

                    _lazyParameters = parameters;
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10233, 6212, 8052);

                Microsoft.CodeAnalysis.DiagnosticBag
                f_10233_6425_6452()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 6425, 6452);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax
                f_10233_6585_6596(Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10233, 6585, 6596);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
                f_10233_6585_6610(Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax
                this_param)
                {
                    var return_v = this_param.ParameterList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10233, 6585, 6610);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10233_6486_6823(Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                owner, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
                syntax, out Microsoft.CodeAnalysis.SyntaxToken
                arglistToken, bool
                allowRefOrOut, bool
                allowThis, bool
                addRefReadOnlyModifier, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = ParameterHelpers.MakeParameters(binder, (Microsoft.CodeAnalysis.CSharp.Symbol)owner, (Microsoft.CodeAnalysis.CSharp.Syntax.BaseParameterListSyntax)syntax, out arglistToken, allowRefOrOut: allowRefOrOut, allowThis: allowThis, addRefReadOnlyModifier: addRefReadOnlyModifier, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 6486, 6823);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10233_6858_6878()
                {
                    var return_v = DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10233, 6858, 6878);
                    return return_v;
                }


                int
                f_10233_6893_7005(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                modifyCompilation)
                {
                    ParameterHelpers.EnsureIsReadOnlyAttributeExists(compilation, parameters, diagnostics, modifyCompilation: modifyCompilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 6893, 7005);
                    return 0;
                }


                int
                f_10233_7020_7135(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                modifyCompilation)
                {
                    ParameterHelpers.EnsureNativeIntegerAttributeExists(compilation, parameters, diagnostics, modifyCompilation: modifyCompilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 7020, 7135);
                    return 0;
                }


                int
                f_10233_7150_7266(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                container, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                modifyCompilation)
                {
                    ParameterHelpers.EnsureNullableAttributeExists(compilation, (Microsoft.CodeAnalysis.CSharp.Symbol)container, parameters, diagnostics, modifyCompilation: modifyCompilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 7150, 7266);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10233_7559_7632(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 7559, 7632);
                    return return_v;
                }


                int
                f_10233_7796_7814(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 7796, 7814);
                    return 0;
                }


                int
                f_10233_7883_7935(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                bag)
                {
                    this_param.AddRangeAndFree(bag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 7883, 7935);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10233, 6212, 8052);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10233, 6212, 8052);
            }
        }

        public override TypeWithAnnotations ReturnTypeWithAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10233, 8150, 8269);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 8186, 8206);

                    f_10233_8186_8205(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 8224, 8254);

                    return _lazyReturnType!.Value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10233, 8150, 8269);

                    int
                    f_10233_8186_8205(Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                    this_param)
                    {
                        this_param.ComputeReturnType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 8186, 8205);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10233, 8064, 8280);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10233, 8064, 8280);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override RefKind RefKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10233, 8324, 8335);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 8327, 8335);
                    return _refKind; DynAbs.Tracing.TraceSender.TraceExitMethod(10233, 8324, 8335);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10233, 8324, 8335);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10233, 8324, 8335);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal void ComputeReturnType()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10233, 8348, 10910);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 8406, 8491) || true) && (_lazyReturnType is object)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10233, 8406, 8491);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 8469, 8476);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10233, 8406, 8491);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 8507, 8553);

                var
                diagnostics = f_10233_8525_8552()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 8567, 8615);

                TypeSyntax
                returnTypeSyntax = f_10233_8597_8614(f_10233_8597_8603())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 8629, 8720);

                TypeWithAnnotations
                returnType = f_10233_8662_8719(_binder, f_10233_8679_8705(returnTypeSyntax), diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 8736, 8775);

                var
                compilation = f_10233_8754_8774()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 8971, 9955) || true) && (compilation is object)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10233, 8971, 9955);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 9030, 9071);

                    var
                    location = f_10233_9045_9070(returnTypeSyntax)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 9089, 9278) || true) && (_refKind == RefKind.RefReadOnly)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10233, 9089, 9278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 9166, 9259);

                        f_10233_9166_9258(compilation, diagnostics, location, modifyCompilation: false);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10233, 9089, 9278);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 9298, 9498) || true) && (f_10233_9302_9341(returnType.Type))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10233, 9298, 9498);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 9383, 9479);

                        f_10233_9383_9478(compilation, diagnostics, location, modifyCompilation: false);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10233, 9298, 9498);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 9518, 9940) || true) && (f_10233_9522_9568(compilation, this) && (DynAbs.Tracing.TraceSender.Expression_True(10233, 9522, 9628) && returnType.NeedsNullableAttribute()))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10233, 9518, 9940);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 9670, 9761);

                        f_10233_9670_9760(compilation, diagnostics, location, modifyCompilation: false);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10233, 9518, 9940);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10233, 8971, 9955);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 10029, 10331) || true) && (returnType.IsRestrictedType(ignoreSpanLikeTypes: true))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10233, 10029, 10331);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 10216, 10316);

                    f_10233_10216_10315(                // The return type of a method, delegate, or function pointer cannot be '{0}'
                                    diagnostics, ErrorCode.ERR_MethodReturnCantBeRefAny, f_10233_10272_10297(returnTypeSyntax), returnType.Type);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10233, 10029, 10331);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 10347, 10478);

                f_10233_10347_10477(_refKind == RefKind.None
                || (DynAbs.Tracing.TraceSender.Expression_False(10233, 10360, 10429) || !returnType.IsVoidType()) || (DynAbs.Tracing.TraceSender.Expression_False(10233, 10360, 10476) || f_10233_10450_10476(returnTypeSyntax)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 10500, 10523);

                lock (_declarationDiagnostics)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 10557, 10695) || true) && (_lazyReturnType is object)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10233, 10557, 10695);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 10628, 10647);

                        f_10233_10628_10646(diagnostics);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 10669, 10676);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10233, 10557, 10695);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 10715, 10768);

                    f_10233_10715_10767(
                                    _declarationDiagnostics, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 10786, 10884);

                    f_10233_10786_10883(ref _lazyReturnType, f_10233_10835_10876(returnType), null);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10233, 8348, 10910);

                Microsoft.CodeAnalysis.DiagnosticBag
                f_10233_8525_8552()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 8525, 8552);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax
                f_10233_8597_8603()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10233, 8597, 8603);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10233_8597_8614(Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10233, 8597, 8614);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10233_8679_8705(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                syntax)
                {
                    var return_v = syntax.SkipRef();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 8679, 8705);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10233_8662_8719(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindType((Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax)syntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 8662, 8719);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10233_8754_8774()
                {
                    var return_v = DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10233, 8754, 8774);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10233_9045_9070(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10233, 9045, 9070);
                    return return_v;
                }


                int
                f_10233_9166_9258(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location, bool
                modifyCompilation)
                {
                    this_param.EnsureIsReadOnlyAttributeExists(diagnostics, location, modifyCompilation: modifyCompilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 9166, 9258);
                    return 0;
                }


                bool
                f_10233_9302_9341(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.ContainsNativeInteger();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 9302, 9341);
                    return return_v;
                }


                int
                f_10233_9383_9478(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location, bool
                modifyCompilation)
                {
                    this_param.EnsureNativeIntegerAttributeExists(diagnostics, location, modifyCompilation: modifyCompilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 9383, 9478);
                    return 0;
                }


                bool
                f_10233_9522_9568(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                symbol)
                {
                    var return_v = this_param.ShouldEmitNullableAttributes((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 9522, 9568);
                    return return_v;
                }


                int
                f_10233_9670_9760(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location, bool
                modifyCompilation)
                {
                    this_param.EnsureNullableAttributeExists(diagnostics, location, modifyCompilation: modifyCompilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 9670, 9760);
                    return 0;
                }


                Microsoft.CodeAnalysis.Location
                f_10233_10272_10297(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10233, 10272, 10297);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10233_10216_10315(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 10216, 10315);
                    return return_v;
                }


                bool
                f_10233_10450_10476(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                this_param)
                {
                    var return_v = this_param.HasErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10233, 10450, 10476);
                    return return_v;
                }


                int
                f_10233_10347_10477(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 10347, 10477);
                    return 0;
                }


                int
                f_10233_10628_10646(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 10628, 10646);
                    return 0;
                }


                int
                f_10233_10715_10767(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                bag)
                {
                    this_param.AddRangeAndFree(bag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 10715, 10767);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed
                f_10233_10835_10876(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                value)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 10835, 10876);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed?
                f_10233_10786_10883(ref Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed?
                location1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed
                value, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 10786, 10883);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10233, 8348, 10910);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10233, 8348, 10910);
            }
        }

        public override bool ReturnsVoid
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10233, 10955, 10981);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 10958, 10981);
                    return f_10233_10958_10981(f_10233_10958_10968()); DynAbs.Tracing.TraceSender.TraceExitMethod(10233, 10955, 10981);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10233, 10955, 10981);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10233, 10955, 10981);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int Arity
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10233, 11020, 11044);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 11023, 11044);
                    return f_10233_11023_11037().Length; DynAbs.Tracing.TraceSender.TraceExitMethod(10233, 11020, 11044);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10233, 11020, 11044);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10233, 11020, 11044);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<TypeWithAnnotations> TypeArgumentsWithAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10233, 11138, 11175);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 11141, 11175);
                    return f_10233_11141_11175(this); DynAbs.Tracing.TraceSender.TraceExitMethod(10233, 11138, 11175);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10233, 11138, 11175);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10233, 11138, 11175);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<TypeParameterSymbol> TypeParameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10233, 11268, 11347);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 11271, 11347);
                    return _typeParameters.Cast<SourceMethodTypeParameterSymbol, TypeParameterSymbol>(); DynAbs.Tracing.TraceSender.TraceExitMethod(10233, 11268, 11347);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10233, 11268, 11347);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10233, 11268, 11347);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsExtensionMethod
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10233, 11423, 11804);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 11560, 11626);

                    var
                    firstParam = f_10233_11577_11597(f_10233_11577_11583()).Parameters.FirstOrDefault()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 11644, 11789);

                    return firstParam != null && (DynAbs.Tracing.TraceSender.Expression_True(10233, 11651, 11715) && f_10233_11694_11715_M(!firstParam.IsArgList)) && (DynAbs.Tracing.TraceSender.Expression_True(10233, 11651, 11788) && firstParam.Modifiers.Any(SyntaxKind.ThisKeyword));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10233, 11423, 11804);

                    Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax
                    f_10233_11577_11583()
                    {
                        var return_v = Syntax;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10233, 11577, 11583);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
                    f_10233_11577_11597(Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax
                    this_param)
                    {
                        var return_v = this_param.ParameterList;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10233, 11577, 11597);
                        return return_v;
                    }


                    bool
                    f_10233_11694_11715_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10233, 11694, 11715);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10233, 11360, 11815);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10233, 11360, 11815);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override TypeWithAnnotations IteratorElementTypeWithAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10233, 11924, 12025);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 11960, 12010);

                    return DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_lazyIteratorElementType, 10233, 11967, 11998)?.Value ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations?>(10233, 11967, 12009) ?? default);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10233, 11924, 12025);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10233, 11827, 12475);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10233, 11827, 12475);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10233, 12039, 12464);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 12075, 12299);

                    f_10233_12075_12298(_lazyIteratorElementType == TypeWithAnnotations.Boxed.Sentinel || (DynAbs.Tracing.TraceSender.Expression_False(10233, 12088, 12297) || (_lazyIteratorElementType is object && (DynAbs.Tracing.TraceSender.Expression_True(10233, 12155, 12296) && f_10233_12193_12296(_lazyIteratorElementType.Value.Type, value.Type, TypeCompareKind.ConsiderEverything2)))));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 12317, 12449);

                    f_10233_12317_12448(ref _lazyIteratorElementType, f_10233_12375_12411(value), TypeWithAnnotations.Boxed.Sentinel);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10233, 12039, 12464);

                    bool
                    f_10233_12193_12296(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    right, Microsoft.CodeAnalysis.TypeCompareKind
                    comparison)
                    {
                        var return_v = TypeSymbol.Equals(left, right, comparison);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 12193, 12296);
                        return return_v;
                    }


                    int
                    f_10233_12075_12298(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 12075, 12298);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed
                    f_10233_12375_12411(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    value)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 12375, 12411);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed
                    f_10233_12317_12448(ref Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed
                    location1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed
                    value, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 12317, 12448);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10233, 11827, 12475);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10233, 11827, 12475);
                }
            }
        }

        internal override bool IsIterator
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10233, 12521, 12558);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 12524, 12558);
                    return _lazyIteratorElementType is object; DynAbs.Tracing.TraceSender.TraceExitMethod(10233, 12521, 12558);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10233, 12521, 12558);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10233, 12521, 12558);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override MethodKind MethodKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10233, 12609, 12636);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 12612, 12636);
                    return MethodKind.LocalFunction; DynAbs.Tracing.TraceSender.TraceExitMethod(10233, 12609, 12636);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10233, 12609, 12636);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10233, 12609, 12636);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override Symbol ContainingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10233, 12696, 12716);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 12699, 12716);
                    return _containingSymbol; DynAbs.Tracing.TraceSender.TraceExitMethod(10233, 12696, 12716);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10233, 12696, 12716);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10233, 12696, 12716);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10233, 12757, 12793);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 12760, 12793);
                    return f_10233_12760_12766().Identifier.ValueText ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(10233, 12760, 12793) ?? ""); DynAbs.Tracing.TraceSender.TraceExitMethod(10233, 12757, 12793);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10233, 12757, 12793);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10233, 12757, 12793);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public SyntaxToken NameToken
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10233, 12835, 12855);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 12838, 12855);
                    return f_10233_12838_12855(f_10233_12838_12844()); DynAbs.Tracing.TraceSender.TraceExitMethod(10233, 12835, 12855);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10233, 12835, 12855);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10233, 12835, 12855);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public Binder SignatureBinder
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10233, 12898, 12908);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 12901, 12908);
                    return _binder; DynAbs.Tracing.TraceSender.TraceExitMethod(10233, 12898, 12908);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10233, 12898, 12908);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10233, 12898, 12908);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<MethodSymbol> ExplicitInterfaceImplementations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10233, 12999, 13036);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 13002, 13036);
                    return ImmutableArray<MethodSymbol>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10233, 12999, 13036);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10233, 12999, 13036);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10233, 12999, 13036);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<Location> Locations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10233, 13100, 13157);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 13103, 13157);
                    return f_10233_13103_13157(f_10233_13125_13131().Identifier.GetLocation()); DynAbs.Tracing.TraceSender.TraceExitMethod(10233, 13100, 13157);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10233, 13100, 13157);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10233, 13100, 13157);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool GenerateDebugInfo
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10233, 13211, 13218);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 13214, 13218);
                    return true; DynAbs.Tracing.TraceSender.TraceExitMethod(10233, 13211, 13218);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10233, 13211, 13218);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10233, 13211, 13218);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<CustomModifier> RefCustomModifiers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10233, 13297, 13336);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 13300, 13336);
                    return ImmutableArray<CustomModifier>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10233, 13297, 13336);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10233, 13297, 13336);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10233, 13297, 13336);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override CallingConvention CallingConvention
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10233, 13403, 13431);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 13406, 13431);
                    return CallingConvention.Default; DynAbs.Tracing.TraceSender.TraceExitMethod(10233, 13403, 13431);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10233, 13403, 13431);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10233, 13403, 13431);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override OneOrMany<SyntaxList<AttributeListSyntax>> GetAttributeDeclarations()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10233, 13444, 13614);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 13556, 13603);

                return f_10233_13563_13602(f_10233_13580_13601(f_10233_13580_13586()));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10233, 13444, 13614);

                Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax
                f_10233_13580_13586()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10233, 13580, 13586);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                f_10233_13580_13601(Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax
                this_param)
                {
                    var return_v = this_param.AttributeLists;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10233, 13580, 13601);
                    return return_v;
                }


                Roslyn.Utilities.OneOrMany<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                f_10233_13563_13602(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                one)
                {
                    var return_v = OneOrMany.Create(one);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 13563, 13602);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10233, 13444, 13614);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10233, 13444, 13614);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override void NoteAttributesComplete(bool forReturnType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10233, 13626, 13696);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10233, 13626, 13696);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10233, 13626, 13696);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10233, 13626, 13696);
            }
        }

        public override Symbol? AssociatedSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10233, 13749, 13756);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 13752, 13756);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10233, 13749, 13756);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10233, 13749, 13756);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10233, 13749, 13756);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Accessibility DeclaredAccessibility
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10233, 13821, 13883);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 13824, 13883);
                    return f_10233_13824_13883(_declarationModifiers); DynAbs.Tracing.TraceSender.TraceExitMethod(10233, 13821, 13883);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10233, 13821, 13883);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10233, 13821, 13883);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsAsync
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10233, 13925, 13985);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 13928, 13985);
                    return (_declarationModifiers & DeclarationModifiers.Async) != 0; DynAbs.Tracing.TraceSender.TraceExitMethod(10233, 13925, 13985);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10233, 13925, 13985);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10233, 13925, 13985);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsStatic
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10233, 14028, 14089);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 14031, 14089);
                    return (_declarationModifiers & DeclarationModifiers.Static) != 0; DynAbs.Tracing.TraceSender.TraceExitMethod(10233, 14028, 14089);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10233, 14028, 14089);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10233, 14028, 14089);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsVirtual
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10233, 14133, 14195);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 14136, 14195);
                    return (_declarationModifiers & DeclarationModifiers.Virtual) != 0; DynAbs.Tracing.TraceSender.TraceExitMethod(10233, 14133, 14195);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10233, 14133, 14195);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10233, 14133, 14195);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsOverride
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10233, 14240, 14303);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 14243, 14303);
                    return (_declarationModifiers & DeclarationModifiers.Override) != 0; DynAbs.Tracing.TraceSender.TraceExitMethod(10233, 14240, 14303);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10233, 14240, 14303);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10233, 14240, 14303);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsAbstract
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10233, 14348, 14411);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 14351, 14411);
                    return (_declarationModifiers & DeclarationModifiers.Abstract) != 0; DynAbs.Tracing.TraceSender.TraceExitMethod(10233, 14348, 14411);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10233, 14348, 14411);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10233, 14348, 14411);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsSealed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10233, 14454, 14515);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 14457, 14515);
                    return (_declarationModifiers & DeclarationModifiers.Sealed) != 0; DynAbs.Tracing.TraceSender.TraceExitMethod(10233, 14454, 14515);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10233, 14454, 14515);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10233, 14454, 14515);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsExtern
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10233, 14558, 14619);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 14561, 14619);
                    return (_declarationModifiers & DeclarationModifiers.Extern) != 0; DynAbs.Tracing.TraceSender.TraceExitMethod(10233, 14558, 14619);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10233, 14558, 14619);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10233, 14558, 14619);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsUnsafe
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10233, 14653, 14714);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 14656, 14714);
                    return (_declarationModifiers & DeclarationModifiers.Unsafe) != 0; DynAbs.Tracing.TraceSender.TraceExitMethod(10233, 14653, 14714);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10233, 14653, 14714);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10233, 14653, 14714);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool IsExpressionBodied
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10233, 14760, 14813);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 14763, 14813);
                    return f_10233_14763_14769() is { Body: null, ExpressionBody: object _ }; DynAbs.Tracing.TraceSender.TraceExitMethod(10233, 14760, 14813);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10233, 14760, 14813);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10233, 14760, 14813);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsDeclaredReadOnly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10233, 14868, 14876);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 14871, 14876);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10233, 14868, 14876);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10233, 14868, 14876);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10233, 14868, 14876);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsInitOnly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10233, 14923, 14931);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 14926, 14931);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10233, 14923, 14931);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10233, 14923, 14931);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10233, 14923, 14931);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsMetadataNewSlot(bool ignoreInterfaceImplementationChanges = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10233, 15036, 15044);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 15039, 15044);
                return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10233, 15036, 15044);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10233, 15036, 15044);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10233, 15036, 15044);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool IsMetadataVirtual(bool ignoreInterfaceImplementationChanges = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10233, 15149, 15157);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 15152, 15157);
                return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10233, 15149, 15157);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10233, 15149, 15157);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10233, 15149, 15157);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override int CalculateLocalSyntaxOffset(int localPosition, SyntaxTree localTree)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10233, 15170, 15332);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 15284, 15321);

                throw f_10233_15290_15320();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10233, 15170, 15332);

                System.Exception
                f_10233_15290_15320()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10233, 15290, 15320);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10233, 15170, 15332);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10233, 15170, 15332);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool TryGetThisParameter(out ParameterSymbol? thisParameter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10233, 15344, 15569);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 15511, 15532);

                thisParameter = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 15546, 15558);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10233, 15344, 15569);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10233, 15344, 15569);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10233, 15344, 15569);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void ReportAttributesDisallowed(SyntaxList<AttributeListSyntax> attributes, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10233, 15581, 16127);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 15716, 15878);

                var
                diagnosticInfo = f_10233_15737_15877(MessageID.IDS_FeatureLocalFunctionAttributes, f_10233_15839_15876(f_10233_15839_15868(syntaxReferenceOpt)))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 15892, 16116) || true) && (diagnosticInfo is object)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10233, 15892, 16116);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 15954, 16101);
                        foreach (var attrList in f_10233_15979_15989_I(attributes))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10233, 15954, 16101);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 16031, 16082);

                            f_10233_16031_16081(diagnostics, diagnosticInfo, f_10233_16063_16080(attrList));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10233, 15954, 16101);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10233, 1, 148);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10233, 1, 148);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10233, 15892, 16116);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10233, 15581, 16127);

                Microsoft.CodeAnalysis.SyntaxTree
                f_10233_15839_15868(Microsoft.CodeAnalysis.SyntaxReference
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10233, 15839, 15868);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ParseOptions
                f_10233_15839_15876(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10233, 15839, 15876);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo?
                f_10233_15737_15877(Microsoft.CodeAnalysis.CSharp.MessageID
                feature, Microsoft.CodeAnalysis.ParseOptions
                options)
                {
                    var return_v = feature.GetFeatureAvailabilityDiagnosticInfo((Microsoft.CodeAnalysis.CSharp.CSharpParseOptions)options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 15737, 15877);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10233_16063_16080(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10233, 16063, 16080);
                    return return_v;
                }


                int
                f_10233_16031_16081(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    diagnostics.Add((Microsoft.CodeAnalysis.DiagnosticInfo)info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 16031, 16081);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                f_10233_15979_15989_I(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 15979, 15989);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10233, 15581, 16127);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10233, 15581, 16127);
            }
        }

        private ImmutableArray<SourceMethodTypeParameterSymbol> MakeTypeParameters(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10233, 16139, 18956);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 16265, 16338);

                var
                result = f_10233_16278_16337()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 16352, 16421);

                var
                typeParameters = f_10233_16373_16409_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10233_16373_16397(f_10233_16373_16379()), 10233, 16373, 16409)?.Parameters) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterSyntax>?>(10233, 16373, 16420) ?? default)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 16444, 16455);
                    for (int
        ordinal = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 16435, 18894) || true) && (ordinal < typeParameters.Count)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 16489, 16498)
        , ordinal++, DynAbs.Tracing.TraceSender.TraceExitCondition(10233, 16435, 18894))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10233, 16435, 18894);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 16532, 16572);

                        var
                        parameter = typeParameters[ordinal]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 16590, 16800) || true) && (parameter.VarianceKeyword.Kind() != SyntaxKind.None)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10233, 16590, 16800);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 16687, 16781);

                            f_10233_16687_16780(diagnostics, ErrorCode.ERR_IllegalVarianceSyntax, parameter.VarianceKeyword.GetLocation());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10233, 16590, 16800);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 16820, 16886);

                        f_10233_16820_16885(this, f_10233_16847_16871(parameter), diagnostics);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 16906, 16944);

                        var
                        identifier = f_10233_16923_16943(parameter)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 16962, 17002);

                        var
                        location = identifier.GetLocation()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 17020, 17058);

                        var
                        name = identifier.ValueText ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(10233, 17031, 17057) ?? "")
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 17078, 17366);
                            foreach (var @param in f_10233_17101_17107_I(result))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10233, 17078, 17366);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 17149, 17347) || true) && (name == f_10233_17161_17172(@param))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10233, 17149, 17347);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 17222, 17292);

                                    f_10233_17222_17291(diagnostics, ErrorCode.ERR_DuplicateTypeParameter, location, name);
                                    DynAbs.Tracing.TraceSender.TraceBreak(10233, 17318, 17324);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10233, 17149, 17347);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10233, 17078, 17366);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10233, 1, 289);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10233, 1, 289);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 17386, 17507);

                        f_10233_17386_17506(identifier.Text, f_10233_17457_17482(this), diagnostics, location);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 17527, 17595);

                        var
                        tpEnclosing = f_10233_17545_17594(f_10233_17545_17561(), name)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 17613, 18528) || true) && ((object?)tpEnclosing != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10233, 17613, 18528);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 17687, 17707);

                            ErrorCode
                            typeError
                            = default(ErrorCode);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 17729, 18414) || true) && (f_10233_17733_17766(f_10233_17733_17761(tpEnclosing)) == SymbolKind.Method)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10233, 17729, 18414);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 17950, 18020);

                                typeError = ErrorCode.WRN_TypeParameterSameAsOuterMethodTypeParameter;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10233, 17729, 18414);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10233, 17729, 18414);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 18118, 18190);

                                f_10233_18118_18189(f_10233_18131_18164(f_10233_18131_18159(tpEnclosing)) == SymbolKind.NamedType);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 18327, 18391);

                                typeError = ErrorCode.WRN_TypeParameterSameAsOuterTypeParameter;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10233, 17729, 18414);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 18436, 18509);

                            f_10233_18436_18508(diagnostics, typeError, location, name, f_10233_18479_18507(tpEnclosing));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10233, 17613, 18528);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 18548, 18833);

                        var
                        typeParameter = f_10233_18568_18832(this, name, ordinal, f_10233_18726_18757(location), f_10233_18784_18831(f_10233_18806_18830(parameter)))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 18853, 18879);

                        f_10233_18853_18878(
                                        result, typeParameter);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10233, 1, 2460);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10233, 1, 2460);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 18910, 18945);

                return f_10233_18917_18944(result);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10233, 16139, 18956);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodTypeParameterSymbol>
                f_10233_16278_16337()
                {
                    var return_v = ArrayBuilder<SourceMethodTypeParameterSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 16278, 16337);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax
                f_10233_16373_16379()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10233, 16373, 16379);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax?
                f_10233_16373_16397(Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax
                this_param)
                {
                    var return_v = this_param.TypeParameterList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10233, 16373, 16397);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterSyntax>?
                f_10233_16373_16409_M(Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterSyntax>?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10233, 16373, 16409);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10233_16687_16780(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 16687, 16780);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                f_10233_16847_16871(Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterSyntax
                this_param)
                {
                    var return_v = this_param.AttributeLists;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10233, 16847, 16871);
                    return return_v;
                }


                int
                f_10233_16820_16885(Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                this_param, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                attributes, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.ReportAttributesDisallowed(attributes, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 16820, 16885);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10233_16923_16943(Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterSyntax
                this_param)
                {
                    var return_v = this_param.Identifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10233, 16923, 16943);
                    return return_v;
                }


                string
                f_10233_17161_17172(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodTypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10233, 17161, 17172);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10233_17222_17291(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 17222, 17291);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodTypeParameterSymbol>
                f_10233_17101_17107_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodTypeParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 17101, 17107);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10233_17457_17482(Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10233, 17457, 17482);
                    return return_v;
                }


                int
                f_10233_17386_17506(string
                name, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location)
                {
                    SourceMemberContainerTypeSymbol.ReportTypeNamedRecord(name, compilation, diagnostics, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 17386, 17506);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10233_17545_17561()
                {
                    var return_v = ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10233, 17545, 17561);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol?
                f_10233_17545_17594(Microsoft.CodeAnalysis.CSharp.Symbol
                methodOrType, string
                name)
                {
                    var return_v = methodOrType.FindEnclosingTypeParameter(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 17545, 17594);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10233_17733_17761(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10233, 17733, 17761);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10233_17733_17766(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10233, 17733, 17766);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10233_18131_18159(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10233, 18131, 18159);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10233_18131_18164(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10233, 18131, 18164);
                    return return_v;
                }


                int
                f_10233_18118_18189(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 18118, 18189);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10233_18479_18507(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10233, 18479, 18507);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10233_18436_18508(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 18436, 18508);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10233_18726_18757(Microsoft.CodeAnalysis.Location
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 18726, 18757);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxReference
                f_10233_18806_18830(Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterSyntax
                this_param)
                {
                    var return_v = this_param.GetReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 18806, 18830);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
                f_10233_18784_18831(Microsoft.CodeAnalysis.SyntaxReference
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 18784, 18831);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodTypeParameterSymbol
                f_10233_18568_18832(Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                owner, string
                name, int
                ordinal, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                locations, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
                syntaxRefs)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodTypeParameterSymbol((Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbol)owner, name, ordinal, locations, syntaxRefs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 18568, 18832);
                    return return_v;
                }


                int
                f_10233_18853_18878(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodTypeParameterSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodTypeParameterSymbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 18853, 18878);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodTypeParameterSymbol>
                f_10233_18917_18944(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodTypeParameterSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 18917, 18944);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10233, 16139, 18956);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10233, 16139, 18956);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<ImmutableArray<TypeWithAnnotations>> GetTypeParameterConstraintTypes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10233, 18968, 20051);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 19094, 19983) || true) && (_lazyTypeParameterConstraintTypes.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10233, 19094, 19983);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 19175, 19209);

                    f_10233_19175_19208(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 19229, 19249);

                    var
                    syntax = f_10233_19242_19248()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 19267, 19313);

                    var
                    diagnostics = f_10233_19285_19312()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 19331, 19583);

                    var
                    constraints = f_10233_19349_19582(this, _binder, f_10233_19439_19453(), f_10233_19476_19500(syntax), f_10233_19523_19547(syntax), diagnostics)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 19607, 19630);
                    lock (_declarationDiagnostics)
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 19672, 19912) || true) && (_lazyTypeParameterConstraintTypes.IsDefault)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10233, 19672, 19912);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 19769, 19815);

                            f_10233_19769_19814(_declarationDiagnostics, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 19841, 19889);

                            _lazyTypeParameterConstraintTypes = constraints;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10233, 19672, 19912);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 19949, 19968);

                    f_10233_19949_19967(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10233, 19094, 19983);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 19999, 20040);

                return _lazyTypeParameterConstraintTypes;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10233, 18968, 20051);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintKind>
                f_10233_19175_19208(Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                this_param)
                {
                    var return_v = this_param.GetTypeParameterConstraintKinds();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 19175, 19208);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax
                f_10233_19242_19248()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10233, 19242, 19248);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10233_19285_19312()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 19285, 19312);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10233_19439_19453()
                {
                    var return_v = TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10233, 19439, 19453);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax?
                f_10233_19476_19500(Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax
                this_param)
                {
                    var return_v = this_param.TypeParameterList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10233, 19476, 19500);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax>
                f_10233_19523_19547(Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax
                this_param)
                {
                    var return_v = this_param.ConstraintClauses;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10233, 19523, 19547);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>>
                f_10233_19349_19582(Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                containingSymbol, Microsoft.CodeAnalysis.CSharp.Binder
                binder, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                typeParameters, Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax?
                typeParameterList, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax>
                constraintClauses, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = containingSymbol.MakeTypeParameterConstraintTypes(binder, typeParameters, typeParameterList, constraintClauses, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 19349, 19582);
                    return return_v;
                }


                int
                f_10233_19769_19814(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                bag)
                {
                    this_param.AddRange(bag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 19769, 19814);
                    return 0;
                }


                int
                f_10233_19949_19967(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 19949, 19967);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10233, 18968, 20051);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10233, 18968, 20051);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<TypeParameterConstraintKind> GetTypeParameterConstraintKinds()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10233, 20063, 20716);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 20181, 20648) || true) && (_lazyTypeParameterConstraintKinds.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10233, 20181, 20648);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 20262, 20282);

                    var
                    syntax = f_10233_20275_20281()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 20300, 20518);

                    var
                    constraints = f_10233_20318_20517(this, _binder, f_10233_20408_20422(), f_10233_20445_20469(syntax), f_10233_20492_20516(syntax))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 20538, 20633);

                    f_10233_20538_20632(ref _lazyTypeParameterConstraintKinds, constraints);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10233, 20181, 20648);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 20664, 20705);

                return _lazyTypeParameterConstraintKinds;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10233, 20063, 20716);

                Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax
                f_10233_20275_20281()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10233, 20275, 20281);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10233_20408_20422()
                {
                    var return_v = TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10233, 20408, 20422);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax?
                f_10233_20445_20469(Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax
                this_param)
                {
                    var return_v = this_param.TypeParameterList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10233, 20445, 20469);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax>
                f_10233_20492_20516(Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax
                this_param)
                {
                    var return_v = this_param.ConstraintClauses;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10233, 20492, 20516);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintKind>
                f_10233_20318_20517(Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                containingSymbol, Microsoft.CodeAnalysis.CSharp.Binder
                binder, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                typeParameters, Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax?
                typeParameterList, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax>
                constraintClauses)
                {
                    var return_v = containingSymbol.MakeTypeParameterConstraintKinds(binder, typeParameters, typeParameterList, constraintClauses);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 20318, 20517);
                    return return_v;
                }


                bool
                f_10233_20538_20632(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintKind>
                location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintKind>
                value)
                {
                    var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 20538, 20632);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10233, 20063, 20716);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10233, 20063, 20716);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool IsNullableAnalysisEnabled()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10233, 20779, 20818);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 20782, 20818);
                throw f_10233_20788_20818(); DynAbs.Tracing.TraceSender.TraceExitMethod(10233, 20779, 20818);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10233, 20779, 20818);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10233, 20779, 20818);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Exception
            f_10233_20788_20818()
            {
                var return_v = ExceptionUtilities.Unreachable;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10233, 20788, 20818);
                return return_v;
            }

        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10233, 20831, 21004);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 20965, 20993);

                return f_10233_20972_20992(f_10233_20972_20978());
                DynAbs.Tracing.TraceSender.TraceExitMethod(10233, 20831, 21004);

                Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax
                f_10233_20972_20978()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10233, 20972, 20978);
                    return return_v;
                }


                int
                f_10233_20972_20992(Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 20972, 20992);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10233, 20831, 21004);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10233, 20831, 21004);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override bool Equals(Symbol symbol, TypeCompareKind compareKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10233, 21016, 21289);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 21119, 21159) || true) && ((object)this == symbol)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10233, 21119, 21159);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 21147, 21159);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10233, 21119, 21159);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 21175, 21225);

                var
                localFunction = symbol as LocalFunctionSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10233, 21239, 21278);

                return f_10233_21246_21267_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(localFunction, 10233, 21246, 21267)?.Syntax) == f_10233_21271_21277();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10233, 21016, 21289);

                Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax?
                f_10233_21246_21267_M(Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10233, 21246, 21267);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax
                f_10233_21271_21277()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10233, 21271, 21277);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10233, 21016, 21289);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10233, 21016, 21289);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static LocalFunctionSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10233, 492, 21296);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10233, 492, 21296);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10233, 492, 21296);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10233, 492, 21296);

        static Microsoft.CodeAnalysis.SyntaxReference
        f_10233_1871_1892(Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax
        this_param)
        {
            var return_v = this_param.GetReference();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 1871, 1892);
            return return_v;
        }


        Microsoft.CodeAnalysis.DiagnosticBag
        f_10233_1997_2016()
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticBag();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 1997, 2016);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
        f_10233_2251_2262(Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax
        this_param)
        {
            var return_v = this_param.Body;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10233, 2251, 2262);
            return return_v;
        }


        bool
        f_10233_2220_2263(Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
        node)
        {
            var return_v = SyntaxFacts.HasYieldOperations((Microsoft.CodeAnalysis.SyntaxNode?)node);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 2220, 2263);
            return return_v;
        }


        int
        f_10233_2390_2462(Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
        symbol, Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
        modifiers, Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics)
        {
            symbol.CheckUnsafeModifier(modifiers, diagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 2390, 2462);
            return 0;
        }


        Microsoft.CodeAnalysis.SyntaxTokenList
        f_10233_2560_2576(Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax
        this_param)
        {
            var return_v = this_param.Modifiers;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10233, 2560, 2576);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Binder
        f_10233_2525_2577(Microsoft.CodeAnalysis.CSharp.Binder
        this_param, Microsoft.CodeAnalysis.SyntaxTokenList
        modifiers)
        {
            var return_v = this_param.WithUnsafeRegionIfNecessary(modifiers);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 2525, 2577);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax?
        f_10233_2598_2622(Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax
        this_param)
        {
            var return_v = this_param.TypeParameterList;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10233, 2598, 2622);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.WithMethodTypeParametersBinder
        f_10233_2673_2721(Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
        methodSymbol, Microsoft.CodeAnalysis.CSharp.Binder
        next)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.WithMethodTypeParametersBinder((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)methodSymbol, next);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 2673, 2721);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodTypeParameterSymbol>
        f_10233_2758_2801(Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
        this_param, Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics)
        {
            var return_v = this_param.MakeTypeParameters(diagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 2758, 2801);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax>
        f_10233_2986_3010(Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax
        this_param)
        {
            var return_v = this_param.ConstraintClauses;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10233, 2986, 3010);
            return return_v;
        }


        int
        f_10233_2958_3036(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax>
        constraintClauses, Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics)
        {
            ReportErrorIfHasConstraints(constraintClauses, diagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 2958, 3036);
            return 0;
        }


        bool
        f_10233_3072_3089()
        {
            var return_v = IsExtensionMethod;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10233, 3072, 3089);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
        f_10233_3182_3191()
        {
            var return_v = Locations;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10233, 3182, 3191);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
        f_10233_3123_3195(Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, Microsoft.CodeAnalysis.Location
        location)
        {
            var return_v = diagnostics.Add(code, location);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 3123, 3195);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
        f_10233_3249_3269(Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax
        this_param)
        {
            var return_v = this_param.ParameterList;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10233, 3249, 3269);
            return return_v;
        }


        Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax>
        f_10233_3249_3280(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
        this_param)
        {
            var return_v = this_param.Parameters;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10233, 3249, 3280);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
        f_10233_3341_3361(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
        this_param)
        {
            var return_v = this_param.AttributeLists;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10233, 3341, 3361);
            return return_v;
        }


        int
        f_10233_3314_3387(Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
        this_param, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
        attributes, Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics)
        {
            this_param.ReportAttributesDisallowed(attributes, diagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 3314, 3387);
            return 0;
        }


        Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax>
        f_10233_3249_3280_I(Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 3249, 3280);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
        f_10233_3423_3440(Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax
        this_param)
        {
            var return_v = this_param.ReturnType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10233, 3423, 3440);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.SyntaxKind
        f_10233_3423_3447(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
        this_param)
        {
            var return_v = this_param.Kind();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 3423, 3447);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
        f_10233_3535_3552(Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax
        this_param)
        {
            var return_v = this_param.ReturnType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10233, 3535, 3552);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxReference
        f_10233_1871_1892_C(Microsoft.CodeAnalysis.SyntaxReference
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10233, 1707, 3984);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxNode
        f_10233_4361_4391(Microsoft.CodeAnalysis.SyntaxReference
        this_param)
        {
            var return_v = this_param.GetSyntax();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 4361, 4391);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        f_10233_10958_10968()
        {
            var return_v = ReturnType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10233, 10958, 10968);
            return return_v;
        }


        bool
        f_10233_10958_10981(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        type)
        {
            var return_v = type.IsVoidType();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 10958, 10981);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
        f_10233_11023_11037()
        {
            var return_v = TypeParameters;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10233, 11023, 11037);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
        f_10233_11141_11175(Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
        this_param)
        {
            var return_v = this_param.GetTypeParametersAsTypeArguments();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 11141, 11175);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax
        f_10233_12760_12766()
        {
            var return_v = Syntax;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10233, 12760, 12766);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax
        f_10233_12838_12844()
        {
            var return_v = Syntax;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10233, 12838, 12844);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxToken
        f_10233_12838_12855(Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax
        this_param)
        {
            var return_v = this_param.Identifier;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10233, 12838, 12855);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax
        f_10233_13125_13131()
        {
            var return_v = Syntax;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10233, 13125, 13131);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
        f_10233_13103_13157(Microsoft.CodeAnalysis.Location
        item)
        {
            var return_v = ImmutableArray.Create(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 13103, 13157);
            return return_v;
        }


        Microsoft.CodeAnalysis.Accessibility
        f_10233_13824_13883(Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
        modifiers)
        {
            var return_v = ModifierUtils.EffectiveAccessibility(modifiers);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10233, 13824, 13883);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax
        f_10233_14763_14769()
        {
            var return_v = Syntax;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10233, 14763, 14769);
            return return_v;
        }

    }
}
