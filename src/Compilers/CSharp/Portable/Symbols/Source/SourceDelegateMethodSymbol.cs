// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal abstract class SourceDelegateMethodSymbol : SourceMemberMethodSymbol
    {
        private ImmutableArray<ParameterSymbol> _parameters;

        private readonly TypeWithAnnotations _returnType;

        protected SourceDelegateMethodSymbol(
                    SourceMemberContainerTypeSymbol delegateType,
                    TypeWithAnnotations returnType,
                    DelegateDeclarationSyntax syntax,
                    MethodKind methodKind,
                    DeclarationModifiers declarationModifiers)
        : base(f_10245_1019_1031_C(delegateType), f_10245_1033_1054(syntax), location: syntax.Identifier.GetLocation(), isIterator: false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10245, 718, 1327);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 1142, 1167);

                _returnType = returnType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 1181, 1316);

                f_10245_1181_1315(this, methodKind, declarationModifiers, _returnType.IsVoidType(), isExtensionMethod: false, isNullableAnalysisEnabled: false);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10245, 718, 1327);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10245, 718, 1327);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10245, 718, 1327);
            }
        }

        protected void InitializeParameters(ImmutableArray<ParameterSymbol> parameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10245, 1339, 1529);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 1443, 1479);

                f_10245_1443_1478(_parameters.IsDefault);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 1493, 1518);

                _parameters = parameters;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10245, 1339, 1529);

                int
                f_10245_1443_1478(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 1443, 1478);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10245, 1339, 1529);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10245, 1339, 1529);
            }
        }

        internal static void AddDelegateMembers(
                    SourceMemberContainerTypeSymbol delegateType,
                    ArrayBuilder<Symbol> symbols,
                    DelegateDeclarationSyntax syntax,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10245, 1541, 5713);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 1795, 1847);

                var
                compilation = f_10245_1813_1846(delegateType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 1861, 1922);

                Binder
                binder = f_10245_1877_1921(delegateType, f_10245_1900_1920(syntax))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 1936, 1952);

                RefKind
                refKind
                = default(RefKind);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 1966, 2035);

                TypeSyntax
                returnTypeSyntax = f_10245_1996_2034(f_10245_1996_2013(syntax), out refKind)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 2049, 2113);

                var
                returnType = f_10245_2066_2112(binder, returnTypeSyntax, diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 2205, 2316);

                var
                voidType = TypeWithAnnotations.Create(f_10245_2247_2314(binder, SpecialType.System_Void, diagnostics, syntax))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 2496, 2611);

                var
                objectType = TypeWithAnnotations.Create(f_10245_2540_2609(binder, SpecialType.System_Object, diagnostics, syntax))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 2625, 2740);

                var
                intPtrType = TypeWithAnnotations.Create(f_10245_2669_2738(binder, SpecialType.System_IntPtr, diagnostics, syntax))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 2756, 3058) || true) && (returnType.IsRestrictedType(ignoreSpanLikeTypes: true))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10245, 2756, 3058);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 2943, 3043);

                    f_10245_2943_3042(                // The return type of a method, delegate, or function pointer cannot be '{0}'
                                    diagnostics, ErrorCode.ERR_MethodReturnCantBeRefAny, f_10245_2999_3024(returnTypeSyntax), returnType.Type);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10245, 2756, 3058);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 3219, 3313);

                var
                invoke = f_10245_3232_3312(delegateType, refKind, returnType, syntax, binder, diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 3327, 3375);

                f_10245_3327_3374(invoke, diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 3389, 3409);

                f_10245_3389_3408(symbols, invoke);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 3503, 3588);

                f_10245_3503_3587(
                            // (2) a constructor with argument types (object, System.IntPtr)
                            symbols, f_10245_3515_3586(delegateType, voidType, objectType, intPtrType, syntax));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 3604, 4563) || true) && (f_10245_3608_3683(f_10245_3608_3674(f_10245_3608_3626(binder), SpecialType.System_IAsyncResult)) != TypeKind.Error && (DynAbs.Tracing.TraceSender.Expression_True(10245, 3608, 3816) && f_10245_3722_3798(f_10245_3722_3789(f_10245_3722_3740(binder), SpecialType.System_AsyncCallback)) != TypeKind.Error) && (DynAbs.Tracing.TraceSender.Expression_True(10245, 3608, 3951) &&                // WinRT delegates don't have Begin/EndInvoke methods
                                !f_10245_3909_3951(delegateType)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10245, 3604, 4563);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 3985, 4112);

                    var
                    iAsyncResultType = TypeWithAnnotations.Create(f_10245_4035_4110(binder, SpecialType.System_IAsyncResult, diagnostics, syntax))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 4130, 4259);

                    var
                    asyncCallbackType = TypeWithAnnotations.Create(f_10245_4181_4257(binder, SpecialType.System_AsyncCallback, diagnostics, syntax))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 4315, 4415);

                    f_10245_4315_4414(
                                    // (3) BeginInvoke
                                    symbols, f_10245_4327_4413(invoke, iAsyncResultType, objectType, asyncCallbackType, syntax));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 4481, 4548);

                    f_10245_4481_4547(
                                    // and (4) EndInvoke methods
                                    symbols, f_10245_4493_4546(invoke, iAsyncResultType, syntax));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10245, 3604, 4563);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 4579, 4698) || true) && (f_10245_4583_4617(delegateType) <= Accessibility.Private)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10245, 4579, 4698);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 4676, 4683);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10245, 4579, 4698);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 4714, 4764);

                HashSet<DiagnosticInfo>
                useSiteDiagnostics = null
                ;

                // LAFHIS
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 4780, 5141);
                var temp = !delegateType.IsNoMoreVisibleThan(f_10245_4818_4850(invoke), ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 4785, 4875);
                if (temp)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10245, 4780, 5141);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 5014, 5126);

                    f_10245_5014_5125(                // Inconsistent accessibility: return type '{1}' is less accessible than delegate '{0}'
                                    diagnostics, ErrorCode.ERR_BadVisDelegateReturn, f_10245_5066_5088(delegateType)[0], delegateType, f_10245_5107_5124(invoke));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10245, 4780, 5141);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 5157, 5623);
                    foreach (var parameter in f_10245_5183_5200_I(f_10245_5183_5200(invoke)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10245, 5157, 5623);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 5234, 5608) || true) && (!parameter.TypeWithAnnotations.IsAtLeastAsVisibleAs(delegateType, ref useSiteDiagnostics))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10245, 5234, 5608);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 5481, 5589);

                            f_10245_5481_5588(                    // Inconsistent accessibility: parameter type '{1}' is less accessible than delegate '{0}'
                                                diagnostics, ErrorCode.ERR_BadVisDelegateParam, f_10245_5532_5554(delegateType)[0], delegateType, f_10245_5573_5587(parameter));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10245, 5234, 5608);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10245, 5157, 5623);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10245, 1, 467);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10245, 1, 467);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 5639, 5702);

                f_10245_5639_5701(
                            diagnostics, f_10245_5655_5677(delegateType)[0], useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10245, 1541, 5713);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10245_1813_1846(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10245, 1813, 1846);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
                f_10245_1900_1920(Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ParameterList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10245, 1900, 1920);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10245_1877_1921(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
                syntaxNode)
                {
                    var return_v = this_param.GetBinder((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 1877, 1921);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10245_1996_2013(Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10245, 1996, 2013);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10245_1996_2034(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                syntax, out Microsoft.CodeAnalysis.RefKind
                refKind)
                {
                    var return_v = syntax.SkipRef(out refKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 1996, 2034);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10245_2066_2112(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindType((Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax)syntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 2066, 2112);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10245_2247_2314(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SpecialType
                typeId, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax
                node)
                {
                    var return_v = this_param.GetSpecialType(typeId, diagnostics, (Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 2247, 2314);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10245_2540_2609(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SpecialType
                typeId, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax
                node)
                {
                    var return_v = this_param.GetSpecialType(typeId, diagnostics, (Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 2540, 2609);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10245_2669_2738(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SpecialType
                typeId, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax
                node)
                {
                    var return_v = this_param.GetSpecialType(typeId, diagnostics, (Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 2669, 2738);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10245_2999_3024(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10245, 2999, 3024);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10245_2943_3042(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 2943, 3042);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceDelegateMethodSymbol.InvokeMethod
                f_10245_3232_3312(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                delegateType, Microsoft.CodeAnalysis.RefKind
                refKind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                returnType, Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SourceDelegateMethodSymbol.InvokeMethod(delegateType, refKind, returnType, syntax, binder, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 3232, 3312);
                    return return_v;
                }


                int
                f_10245_3327_3374(Microsoft.CodeAnalysis.CSharp.Symbols.SourceDelegateMethodSymbol.InvokeMethod
                method, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    method.CheckDelegateVarianceSafety(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 3327, 3374);
                    return 0;
                }


                int
                f_10245_3389_3408(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceDelegateMethodSymbol.InvokeMethod
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 3389, 3408);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceDelegateMethodSymbol.Constructor
                f_10245_3515_3586(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                delegateType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                voidType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                objectType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                intPtrType, Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax
                syntax)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SourceDelegateMethodSymbol.Constructor(delegateType, voidType, objectType, intPtrType, syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 3515, 3586);
                    return return_v;
                }


                int
                f_10245_3503_3587(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceDelegateMethodSymbol.Constructor
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 3503, 3587);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10245_3608_3626(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10245, 3608, 3626);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10245_3608_3674(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 3608, 3674);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10245_3608_3683(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10245, 3608, 3683);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10245_3722_3740(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10245, 3722, 3740);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10245_3722_3789(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 3722, 3789);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10245_3722_3798(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10245, 3722, 3798);
                    return return_v;
                }


                bool
                f_10245_3909_3951(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                symbol)
                {
                    var return_v = symbol.IsCompilationOutputWinMdObj();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 3909, 3951);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10245_4035_4110(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SpecialType
                typeId, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax
                node)
                {
                    var return_v = this_param.GetSpecialType(typeId, diagnostics, (Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 4035, 4110);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10245_4181_4257(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SpecialType
                typeId, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax
                node)
                {
                    var return_v = this_param.GetSpecialType(typeId, diagnostics, (Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 4181, 4257);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceDelegateMethodSymbol.BeginInvokeMethod
                f_10245_4327_4413(Microsoft.CodeAnalysis.CSharp.Symbols.SourceDelegateMethodSymbol.InvokeMethod
                invoke, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                iAsyncResultType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                objectType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                asyncCallbackType, Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax
                syntax)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SourceDelegateMethodSymbol.BeginInvokeMethod(invoke, iAsyncResultType, objectType, asyncCallbackType, syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 4327, 4413);
                    return return_v;
                }


                int
                f_10245_4315_4414(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceDelegateMethodSymbol.BeginInvokeMethod
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 4315, 4414);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceDelegateMethodSymbol.EndInvokeMethod
                f_10245_4493_4546(Microsoft.CodeAnalysis.CSharp.Symbols.SourceDelegateMethodSymbol.InvokeMethod
                invoke, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                iAsyncResultType, Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax
                syntax)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SourceDelegateMethodSymbol.EndInvokeMethod(invoke, iAsyncResultType, syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 4493, 4546);
                    return return_v;
                }


                int
                f_10245_4481_4547(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceDelegateMethodSymbol.EndInvokeMethod
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 4481, 4547);
                    return 0;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_10245_4583_4617(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10245, 4583, 4617);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10245_4818_4850(Microsoft.CodeAnalysis.CSharp.Symbols.SourceDelegateMethodSymbol.InvokeMethod
                this_param)
                {
                    var return_v = this_param.ReturnTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10245, 4818, 4850);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10245_5066_5088(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10245, 5066, 5088);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10245_5107_5124(Microsoft.CodeAnalysis.CSharp.Symbols.SourceDelegateMethodSymbol.InvokeMethod
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10245, 5107, 5124);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10245_5014_5125(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 5014, 5125);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10245_5183_5200(Microsoft.CodeAnalysis.CSharp.Symbols.SourceDelegateMethodSymbol.InvokeMethod
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10245, 5183, 5200);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10245_5532_5554(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10245, 5532, 5554);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10245_5573_5587(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10245, 5573, 5587);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10245_5481_5588(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 5481, 5588);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10245_5183_5200_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 5183, 5200);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10245_5655_5677(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10245, 5655, 5677);
                    return return_v;
                }


                bool
                f_10245_5639_5701(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add(location, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 5639, 5701);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10245, 1541, 5713);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10245, 1541, 5713);
            }
        }

        protected override void MethodChecks(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10245, 5725, 5898);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10245, 5725, 5898);
                // TODO: move more functionality into here, making these symbols more lazy
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10245, 5725, 5898);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10245, 5725, 5898);
            }
        }

        public sealed override bool IsVararg
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10245, 5971, 6035);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 6007, 6020);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10245, 5971, 6035);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10245, 5910, 6046);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10245, 5910, 6046);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override ImmutableArray<ParameterSymbol> Parameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10245, 6148, 6218);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 6184, 6203);

                    return _parameters;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10245, 6148, 6218);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10245, 6058, 6229);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10245, 6058, 6229);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10245, 6332, 6432);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 6368, 6417);

                    return ImmutableArray<TypeParameterSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10245, 6332, 6432);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10245, 6241, 6443);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10245, 6241, 6443);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<ImmutableArray<TypeWithAnnotations>> GetTypeParameterConstraintTypes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10245, 6570, 6630);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 6573, 6630);
                return ImmutableArray<ImmutableArray<TypeWithAnnotations>>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10245, 6570, 6630);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10245, 6570, 6630);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10245, 6570, 6630);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<TypeParameterConstraintKind> GetTypeParameterConstraintKinds()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10245, 6750, 6802);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 6753, 6802);
                return ImmutableArray<TypeParameterConstraintKind>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10245, 6750, 6802);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10245, 6750, 6802);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10245, 6750, 6802);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override TypeWithAnnotations ReturnTypeWithAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10245, 6908, 6978);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 6944, 6963);

                    return _returnType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10245, 6908, 6978);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10245, 6815, 6989);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10245, 6815, 6989);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool IsImplicitlyDeclared
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10245, 7074, 7137);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 7110, 7122);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10245, 7074, 7137);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10245, 7001, 7148);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10245, 7001, 7148);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsExpressionBodied
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10245, 7226, 7247);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 7232, 7245);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10245, 7226, 7247);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10245, 7160, 7258);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10245, 7160, 7258);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10245, 7335, 7356);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 7341, 7354);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10245, 7335, 7356);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10245, 7270, 7367);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10245, 7270, 7367);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected sealed override IAttributeTargetSymbol AttributeOwner
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10245, 7467, 7565);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 7503, 7550);

                    return (SourceNamedTypeSymbol)f_10245_7533_7549();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10245, 7467, 7565);

                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10245_7533_7549()
                    {
                        var return_v = ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10245, 7533, 7549);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10245, 7379, 7576);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10245, 7379, 7576);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override System.Reflection.MethodImplAttributes ImplementationAttributes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10245, 7701, 7763);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 7707, 7761);

                    return System.Reflection.MethodImplAttributes.Runtime;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10245, 7701, 7763);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10245, 7588, 7774);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10245, 7588, 7774);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override OneOrMany<SyntaxList<AttributeListSyntax>> GetAttributeDeclarations()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10245, 7786, 8175);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 8070, 8164);

                return f_10245_8077_8163(f_10245_8094_8162(((SourceNamedTypeSymbol)f_10245_8118_8134())));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10245, 7786, 8175);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10245_8118_8134()
                {
                    var return_v = ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10245, 8118, 8134);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                f_10245_8094_8162(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetAttributeDeclarations();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 8094, 8162);
                    return return_v;
                }


                Roslyn.Utilities.OneOrMany<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                f_10245_8077_8163(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                many)
                {
                    var return_v = OneOrMany.Create(many);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 8077, 8163);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10245, 7786, 8175);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10245, 7786, 8175);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override System.AttributeTargets GetAttributeTarget()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10245, 8187, 8332);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 8281, 8321);

                return System.AttributeTargets.Delegate;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10245, 8187, 8332);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10245, 8187, 8332);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10245, 8187, 8332);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private sealed class Constructor : SourceDelegateMethodSymbol
        {
            internal Constructor(
                            SourceMemberContainerTypeSymbol delegateType,
                            TypeWithAnnotations voidType,
                            TypeWithAnnotations objectType,
                            TypeWithAnnotations intPtrType,
                            DelegateDeclarationSyntax syntax)
            : base(f_10245_8735_8747_C(delegateType), voidType, syntax, MethodKind.Constructor, DeclarationModifiers.Public)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10245, 8430, 9131);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 8852, 9116);

                    f_10245_8852_9115(this, f_10245_8873_9114(f_10245_8934_9012(this, objectType, 0, RefKind.None, "object"), f_10245_9035_9113(this, intPtrType, 1, RefKind.None, "method")));
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10245, 8430, 9131);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10245, 8430, 9131);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10245, 8430, 9131);
                }
            }

            public override string Name
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10245, 9207, 9267);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 9213, 9265);

                        return WellKnownMemberNames.InstanceConstructorName;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10245, 9207, 9267);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10245, 9147, 9282);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10245, 9147, 9282);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10245, 9362, 9390);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 9368, 9388);

                        return RefKind.None;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10245, 9362, 9390);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10245, 9298, 9405);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10245, 9298, 9405);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override OneOrMany<SyntaxList<AttributeListSyntax>> GetReturnTypeAttributeDeclarations()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10245, 9421, 9699);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 9618, 9684);

                    return f_10245_9625_9683(default(SyntaxList<AttributeListSyntax>));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10245, 9421, 9699);

                    Roslyn.Utilities.OneOrMany<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                    f_10245_9625_9683(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                    one)
                    {
                        var return_v = OneOrMany.Create(one);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 9625, 9683);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10245, 9421, 9699);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10245, 9421, 9699);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override LexicalSortKey GetLexicalSortKey()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10245, 9715, 10446);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 10339, 10431);

                    return f_10245_10346_10430(f_10245_10365_10402(this.syntaxReferenceOpt), f_10245_10404_10429(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10245, 9715, 10446);

                    Microsoft.CodeAnalysis.Location
                    f_10245_10365_10402(Microsoft.CodeAnalysis.SyntaxReference
                    this_param)
                    {
                        var return_v = this_param.GetLocation();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 10365, 10402);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    f_10245_10404_10429(Microsoft.CodeAnalysis.CSharp.Symbols.SourceDelegateMethodSymbol.Constructor
                    this_param)
                    {
                        var return_v = this_param.DeclaringCompilation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10245, 10404, 10429);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.LexicalSortKey
                    f_10245_10346_10430(Microsoft.CodeAnalysis.Location
                    location, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    compilation)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.LexicalSortKey(location, compilation);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 10346, 10430);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10245, 9715, 10446);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10245, 9715, 10446);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static Constructor()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10245, 8344, 10457);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10245, 8344, 10457);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10245, 8344, 10457);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10245, 8344, 10457);

            Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
            f_10245_8934_9012(Microsoft.CodeAnalysis.CSharp.Symbols.SourceDelegateMethodSymbol.Constructor
            container, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
            type, int
            ordinal, Microsoft.CodeAnalysis.RefKind
            refKind, string
            name)
            {
                var return_v = SynthesizedParameterSymbol.Create((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)container, type, ordinal, refKind, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 8934, 9012);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
            f_10245_9035_9113(Microsoft.CodeAnalysis.CSharp.Symbols.SourceDelegateMethodSymbol.Constructor
            container, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
            type, int
            ordinal, Microsoft.CodeAnalysis.RefKind
            refKind, string
            name)
            {
                var return_v = SynthesizedParameterSymbol.Create((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)container, type, ordinal, refKind, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 9035, 9113);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
            f_10245_8873_9114(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
            item1, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
            item2)
            {
                var return_v = ImmutableArray.Create<ParameterSymbol>(item1, item2);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 8873, 9114);
                return return_v;
            }


            int
            f_10245_8852_9115(Microsoft.CodeAnalysis.CSharp.Symbols.SourceDelegateMethodSymbol.Constructor
            this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
            parameters)
            {
                this_param.InitializeParameters(parameters);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 8852, 9115);
                return 0;
            }


            static Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
            f_10245_8735_8747_C(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10245, 8430, 9131);
                return return_v;
            }

        }
        private sealed class InvokeMethod : SourceDelegateMethodSymbol
        {
            private readonly RefKind _refKind;

            private readonly ImmutableArray<CustomModifier> _refCustomModifiers;

            internal InvokeMethod(
                            SourceMemberContainerTypeSymbol delegateType,
                            RefKind refKind,
                            TypeWithAnnotations returnType,
                            DelegateDeclarationSyntax syntax,
                            Binder binder,
                            DiagnosticBag diagnostics)
            : base(f_10245_11008_11020_C(delegateType), returnType, syntax, MethodKind.DelegateInvoke, DeclarationModifiers.Virtual | DeclarationModifiers.Public)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10245, 10688, 12537);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 10581, 10589);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 11161, 11185);

                    this._refKind = refKind;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 11205, 11230);

                    SyntaxToken
                    arglistToken
                    = default(SyntaxToken);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 11248, 11552);

                    var
                    parameters = f_10245_11265_11551(binder, this, f_10245_11333_11353(syntax), out arglistToken, allowRefOrOut: true, allowThis: false, addRefReadOnlyModifier: true, diagnostics: diagnostics)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 11572, 11962) || true) && (arglistToken.Kind() == SyntaxKind.ArgListKeyword)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10245, 11572, 11962);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 11863, 11943);

                        f_10245_11863_11942(                    // This is a parse-time error in the native compiler; it is a semantic analysis error in Roslyn.

                                            // error CS1669: __arglist is not valid in this context
                                            diagnostics, ErrorCode.ERR_IllegalVarArgs, f_10245_11909_11941(arglistToken));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10245, 11572, 11962);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 11982, 12469) || true) && (_refKind == RefKind.RefReadOnly)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10245, 11982, 12469);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 12059, 12192);

                        var
                        modifierType = f_10245_12078_12191(binder, WellKnownType.System_Runtime_InteropServices_InAttribute, diagnostics, f_10245_12173_12190(syntax))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 12214, 12309);

                        _refCustomModifiers = f_10245_12236_12308(f_10245_12258_12307(modifierType));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10245, 11982, 12469);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10245, 11982, 12469);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 12391, 12450);

                        _refCustomModifiers = ImmutableArray<CustomModifier>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10245, 11982, 12469);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 12489, 12522);

                    f_10245_12489_12521(this, parameters);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10245, 10688, 12537);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10245, 10688, 12537);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10245, 10688, 12537);
                }
            }

            public override string Name
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10245, 12613, 12668);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 12619, 12666);

                        return WellKnownMemberNames.DelegateInvokeName;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10245, 12613, 12668);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10245, 12553, 12683);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10245, 12553, 12683);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10245, 12763, 12787);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 12769, 12785);

                        return _refKind;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10245, 12763, 12787);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10245, 12699, 12802);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10245, 12699, 12802);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override LexicalSortKey GetLexicalSortKey()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10245, 12818, 13549);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 13442, 13534);

                    return f_10245_13449_13533(f_10245_13468_13505(this.syntaxReferenceOpt), f_10245_13507_13532(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10245, 12818, 13549);

                    Microsoft.CodeAnalysis.Location
                    f_10245_13468_13505(Microsoft.CodeAnalysis.SyntaxReference
                    this_param)
                    {
                        var return_v = this_param.GetLocation();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 13468, 13505);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    f_10245_13507_13532(Microsoft.CodeAnalysis.CSharp.Symbols.SourceDelegateMethodSymbol.InvokeMethod
                    this_param)
                    {
                        var return_v = this_param.DeclaringCompilation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10245, 13507, 13532);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.LexicalSortKey
                    f_10245_13449_13533(Microsoft.CodeAnalysis.Location
                    location, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    compilation)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.LexicalSortKey(location, compilation);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 13449, 13533);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10245, 12818, 13549);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10245, 12818, 13549);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override void AfterAddingTypeMembersChecks(ConversionsBase conversions, DiagnosticBag diagnostics)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10245, 13565, 15156);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 13705, 13767);

                    var
                    syntax = (DelegateDeclarationSyntax)f_10245_13745_13766(f_10245_13745_13754())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 13785, 13832);

                    var
                    location = f_10245_13800_13831(f_10245_13800_13817(syntax))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 13850, 13889);

                    var
                    compilation = f_10245_13868_13888()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 13909, 13940);

                    f_10245_13909_13939(location != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 13960, 14020);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.AfterAddingTypeMembersChecks(conversions, diagnostics), 10245, 13960, 14019);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 14040, 14228) || true) && (_refKind == RefKind.RefReadOnly)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10245, 14040, 14228);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 14117, 14209);

                        f_10245_14117_14208(compilation, diagnostics, location, modifyCompilation: true);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10245, 14040, 14228);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 14248, 14360);

                    f_10245_14248_14359(compilation, f_10245_14310_14320(), diagnostics, modifyCompilation: true);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 14380, 14574) || true) && (f_10245_14384_14418(f_10245_14384_14394()))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10245, 14380, 14574);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 14460, 14555);

                        f_10245_14460_14554(compilation, diagnostics, location, modifyCompilation: true);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10245, 14380, 14574);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 14594, 14709);

                    f_10245_14594_14708(compilation, f_10245_14659_14669(), diagnostics, modifyCompilation: true);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 14729, 15005) || true) && (f_10245_14733_14779(compilation, this) && (DynAbs.Tracing.TraceSender.Expression_True(10245, 14733, 14854) && f_10245_14804_14829().NeedsNullableAttribute()))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10245, 14729, 15005);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 14896, 14986);

                        f_10245_14896_14985(compilation, diagnostics, location, modifyCompilation: true);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10245, 14729, 15005);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 15025, 15141);

                    f_10245_15025_15140(compilation, this, f_10245_15091_15101(), diagnostics, modifyCompilation: true);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10245, 13565, 15156);

                    Microsoft.CodeAnalysis.SyntaxReference
                    f_10245_13745_13754()
                    {
                        var return_v = SyntaxRef;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10245, 13745, 13754);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxNode
                    f_10245_13745_13766(Microsoft.CodeAnalysis.SyntaxReference
                    this_param)
                    {
                        var return_v = this_param.GetSyntax();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 13745, 13766);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                    f_10245_13800_13817(Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.ReturnType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10245, 13800, 13817);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Location
                    f_10245_13800_13831(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                    this_param)
                    {
                        var return_v = this_param.GetLocation();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 13800, 13831);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    f_10245_13868_13888()
                    {
                        var return_v = DeclaringCompilation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10245, 13868, 13888);
                        return return_v;
                    }


                    int
                    f_10245_13909_13939(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 13909, 13939);
                        return 0;
                    }


                    int
                    f_10245_14117_14208(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics, Microsoft.CodeAnalysis.Location
                    location, bool
                    modifyCompilation)
                    {
                        this_param.EnsureIsReadOnlyAttributeExists(diagnostics, location, modifyCompilation: modifyCompilation);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 14117, 14208);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    f_10245_14310_14320()
                    {
                        var return_v = Parameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10245, 14310, 14320);
                        return return_v;
                    }


                    int
                    f_10245_14248_14359(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    compilation, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    parameters, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics, bool
                    modifyCompilation)
                    {
                        ParameterHelpers.EnsureIsReadOnlyAttributeExists(compilation, parameters, diagnostics, modifyCompilation: modifyCompilation);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 14248, 14359);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10245_14384_14394()
                    {
                        var return_v = ReturnType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10245, 14384, 14394);
                        return return_v;
                    }


                    bool
                    f_10245_14384_14418(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type)
                    {
                        var return_v = type.ContainsNativeInteger();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 14384, 14418);
                        return return_v;
                    }


                    int
                    f_10245_14460_14554(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics, Microsoft.CodeAnalysis.Location
                    location, bool
                    modifyCompilation)
                    {
                        this_param.EnsureNativeIntegerAttributeExists(diagnostics, location, modifyCompilation: modifyCompilation);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 14460, 14554);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    f_10245_14659_14669()
                    {
                        var return_v = Parameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10245, 14659, 14669);
                        return return_v;
                    }


                    int
                    f_10245_14594_14708(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    compilation, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    parameters, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics, bool
                    modifyCompilation)
                    {
                        ParameterHelpers.EnsureNativeIntegerAttributeExists(compilation, parameters, diagnostics, modifyCompilation: modifyCompilation);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 14594, 14708);
                        return 0;
                    }


                    bool
                    f_10245_14733_14779(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceDelegateMethodSymbol.InvokeMethod
                    symbol)
                    {
                        var return_v = this_param.ShouldEmitNullableAttributes((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 14733, 14779);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    f_10245_14804_14829()
                    {
                        var return_v = ReturnTypeWithAnnotations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10245, 14804, 14829);
                        return return_v;
                    }


                    int
                    f_10245_14896_14985(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics, Microsoft.CodeAnalysis.Location
                    location, bool
                    modifyCompilation)
                    {
                        this_param.EnsureNullableAttributeExists(diagnostics, location, modifyCompilation: modifyCompilation);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 14896, 14985);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    f_10245_15091_15101()
                    {
                        var return_v = Parameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10245, 15091, 15101);
                        return return_v;
                    }


                    int
                    f_10245_15025_15140(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    compilation, Microsoft.CodeAnalysis.CSharp.Symbols.SourceDelegateMethodSymbol.InvokeMethod
                    container, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    parameters, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics, bool
                    modifyCompilation)
                    {
                        ParameterHelpers.EnsureNullableAttributeExists(compilation, (Microsoft.CodeAnalysis.CSharp.Symbol)container, parameters, diagnostics, modifyCompilation: modifyCompilation);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 15025, 15140);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10245, 13565, 15156);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10245, 13565, 15156);
                }
            }

            public override ImmutableArray<CustomModifier> RefCustomModifiers
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10245, 15238, 15260);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 15241, 15260);
                        return _refCustomModifiers; DynAbs.Tracing.TraceSender.TraceExitMethod(10245, 15238, 15260);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10245, 15238, 15260);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10245, 15238, 15260);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static InvokeMethod()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10245, 10469, 15272);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10245, 10469, 15272);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10245, 10469, 15272);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10245, 10469, 15272);

            Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
            f_10245_11333_11353(Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax
            this_param)
            {
                var return_v = this_param.ParameterList;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10245, 11333, 11353);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
            f_10245_11265_11551(Microsoft.CodeAnalysis.CSharp.Binder
            binder, Microsoft.CodeAnalysis.CSharp.Symbols.SourceDelegateMethodSymbol.InvokeMethod
            owner, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
            syntax, out Microsoft.CodeAnalysis.SyntaxToken
            arglistToken, bool
            allowRefOrOut, bool
            allowThis, bool
            addRefReadOnlyModifier, Microsoft.CodeAnalysis.DiagnosticBag
            diagnostics)
            {
                var return_v = ParameterHelpers.MakeParameters(binder, (Microsoft.CodeAnalysis.CSharp.Symbol)owner, (Microsoft.CodeAnalysis.CSharp.Syntax.BaseParameterListSyntax)syntax, out arglistToken, allowRefOrOut: allowRefOrOut, allowThis: allowThis, addRefReadOnlyModifier: addRefReadOnlyModifier, diagnostics: diagnostics);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 11265, 11551);
                return return_v;
            }


            Microsoft.CodeAnalysis.SourceLocation
            f_10245_11909_11941(Microsoft.CodeAnalysis.SyntaxToken
            token)
            {
                var return_v = new Microsoft.CodeAnalysis.SourceLocation(token);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 11909, 11941);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
            f_10245_11863_11942(Microsoft.CodeAnalysis.DiagnosticBag
            diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
            code, Microsoft.CodeAnalysis.SourceLocation
            location)
            {
                var return_v = diagnostics.Add(code, (Microsoft.CodeAnalysis.Location)location);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 11863, 11942);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
            f_10245_12173_12190(Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax
            this_param)
            {
                var return_v = this_param.ReturnType;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10245, 12173, 12190);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            f_10245_12078_12191(Microsoft.CodeAnalysis.CSharp.Binder
            this_param, Microsoft.CodeAnalysis.WellKnownType
            type, Microsoft.CodeAnalysis.DiagnosticBag
            diagnostics, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
            node)
            {
                var return_v = this_param.GetWellKnownType(type, diagnostics, (Microsoft.CodeAnalysis.SyntaxNode)node);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 12078, 12191);
                return return_v;
            }


            Microsoft.CodeAnalysis.CustomModifier
            f_10245_12258_12307(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            modifier)
            {
                var return_v = CSharpCustomModifier.CreateRequired(modifier);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 12258, 12307);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
            f_10245_12236_12308(Microsoft.CodeAnalysis.CustomModifier
            item)
            {
                var return_v = ImmutableArray.Create(item);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 12236, 12308);
                return return_v;
            }


            int
            f_10245_12489_12521(Microsoft.CodeAnalysis.CSharp.Symbols.SourceDelegateMethodSymbol.InvokeMethod
            this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
            parameters)
            {
                this_param.InitializeParameters(parameters);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 12489, 12521);
                return 0;
            }


            static Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
            f_10245_11008_11020_C(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10245, 10688, 12537);
                return return_v;
            }

        }
        private sealed class BeginInvokeMethod : SourceDelegateMethodSymbol
        {
            internal BeginInvokeMethod(
                            InvokeMethod invoke,
                            TypeWithAnnotations iAsyncResultType,
                            TypeWithAnnotations objectType,
                            TypeWithAnnotations asyncCallbackType,
                            DelegateDeclarationSyntax syntax)
            : base(f_10245_15677_15721_C((SourceNamedTypeSymbol)f_10245_15700_15721(invoke)), iAsyncResultType, syntax, MethodKind.Ordinary, DeclarationModifiers.Virtual | DeclarationModifiers.Public)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10245, 15376, 16723);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 15862, 15923);

                    var
                    parameters = f_10245_15879_15922()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 15941, 16246);
                        foreach (SourceParameterSymbol p in f_10245_15977_15994_I(f_10245_15977_15994(invoke)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10245, 15941, 16246);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 16036, 16172);

                            var
                            synthesizedParam = f_10245_16059_16171(originalParam: p, newOwner: this, newOrdinal: f_10245_16137_16146(p), suppressOptional: true)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 16194, 16227);

                            f_10245_16194_16226(parameters, synthesizedParam);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10245, 15941, 16246);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10245, 1, 306);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10245, 1, 306);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 16266, 16305);

                    int
                    paramCount = f_10245_16283_16304(invoke)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 16323, 16472);

                    f_10245_16323_16471(parameters, f_10245_16338_16470(this, asyncCallbackType, paramCount, RefKind.None, f_10245_16423_16469(parameters, "callback")));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 16490, 16634);

                    f_10245_16490_16633(parameters, f_10245_16505_16632(this, objectType, paramCount + 1, RefKind.None, f_10245_16587_16631(parameters, "object")));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 16654, 16708);

                    f_10245_16654_16707(this, f_10245_16675_16706(parameters));
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10245, 15376, 16723);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10245, 15376, 16723);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10245, 15376, 16723);
                }
            }

            public override string Name
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10245, 16799, 16859);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 16805, 16857);

                        return WellKnownMemberNames.DelegateBeginInvokeName;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10245, 16799, 16859);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10245, 16739, 16874);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10245, 16739, 16874);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10245, 16954, 16982);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 16960, 16980);

                        return RefKind.None;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10245, 16954, 16982);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10245, 16890, 16997);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10245, 16890, 16997);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override OneOrMany<SyntaxList<AttributeListSyntax>> GetReturnTypeAttributeDeclarations()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10245, 17013, 17465);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 17384, 17450);

                    return f_10245_17391_17449(default(SyntaxList<AttributeListSyntax>));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10245, 17013, 17465);

                    Roslyn.Utilities.OneOrMany<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                    f_10245_17391_17449(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                    one)
                    {
                        var return_v = OneOrMany.Create(one);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 17391, 17449);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10245, 17013, 17465);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10245, 17013, 17465);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static BeginInvokeMethod()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10245, 15284, 17476);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10245, 15284, 17476);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10245, 15284, 17476);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10245, 15284, 17476);

            static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            f_10245_15700_15721(Microsoft.CodeAnalysis.CSharp.Symbols.SourceDelegateMethodSymbol.InvokeMethod
            this_param)
            {
                var return_v = this_param.ContainingType;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10245, 15700, 15721);
                return return_v;
            }


            Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
            f_10245_15879_15922()
            {
                var return_v = ArrayBuilder<ParameterSymbol>.GetInstance();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 15879, 15922);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
            f_10245_15977_15994(Microsoft.CodeAnalysis.CSharp.Symbols.SourceDelegateMethodSymbol.InvokeMethod
            this_param)
            {
                var return_v = this_param.Parameters;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10245, 15977, 15994);
                return return_v;
            }


            int
            f_10245_16137_16146(Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbol
            this_param)
            {
                var return_v = this_param.Ordinal;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10245, 16137, 16146);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.SourceClonedParameterSymbol
            f_10245_16059_16171(Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbol
            originalParam, Microsoft.CodeAnalysis.CSharp.Symbols.SourceDelegateMethodSymbol.BeginInvokeMethod
            newOwner, int
            newOrdinal, bool
            suppressOptional)
            {
                var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SourceClonedParameterSymbol(originalParam: originalParam, newOwner: (Microsoft.CodeAnalysis.CSharp.Symbol)newOwner, newOrdinal: newOrdinal, suppressOptional: suppressOptional);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 16059, 16171);
                return return_v;
            }


            int
            f_10245_16194_16226(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
            this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceClonedParameterSymbol
            item)
            {
                this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol)item);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 16194, 16226);
                return 0;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
            f_10245_15977_15994_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 15977, 15994);
                return return_v;
            }


            int
            f_10245_16283_16304(Microsoft.CodeAnalysis.CSharp.Symbols.SourceDelegateMethodSymbol.InvokeMethod
            this_param)
            {
                var return_v = this_param.ParameterCount;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10245, 16283, 16304);
                return return_v;
            }


            string
            f_10245_16423_16469(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
            currentParameters, string
            name)
            {
                var return_v = GetUniqueParameterName(currentParameters, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 16423, 16469);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
            f_10245_16338_16470(Microsoft.CodeAnalysis.CSharp.Symbols.SourceDelegateMethodSymbol.BeginInvokeMethod
            container, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
            type, int
            ordinal, Microsoft.CodeAnalysis.RefKind
            refKind, string
            name)
            {
                var return_v = SynthesizedParameterSymbol.Create((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)container, type, ordinal, refKind, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 16338, 16470);
                return return_v;
            }


            int
            f_10245_16323_16471(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
            this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
            item)
            {
                this_param.Add(item);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 16323, 16471);
                return 0;
            }


            string
            f_10245_16587_16631(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
            currentParameters, string
            name)
            {
                var return_v = GetUniqueParameterName(currentParameters, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 16587, 16631);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
            f_10245_16505_16632(Microsoft.CodeAnalysis.CSharp.Symbols.SourceDelegateMethodSymbol.BeginInvokeMethod
            container, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
            type, int
            ordinal, Microsoft.CodeAnalysis.RefKind
            refKind, string
            name)
            {
                var return_v = SynthesizedParameterSymbol.Create((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)container, type, ordinal, refKind, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 16505, 16632);
                return return_v;
            }


            int
            f_10245_16490_16633(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
            this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
            item)
            {
                this_param.Add(item);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 16490, 16633);
                return 0;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
            f_10245_16675_16706(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
            this_param)
            {
                var return_v = this_param.ToImmutableAndFree();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 16675, 16706);
                return return_v;
            }


            int
            f_10245_16654_16707(Microsoft.CodeAnalysis.CSharp.Symbols.SourceDelegateMethodSymbol.BeginInvokeMethod
            this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
            parameters)
            {
                this_param.InitializeParameters(parameters);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 16654, 16707);
                return 0;
            }


            static Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
            f_10245_15677_15721_C(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10245, 15376, 16723);
                return return_v;
            }

        }
        private sealed class EndInvokeMethod : SourceDelegateMethodSymbol
        {
            private readonly InvokeMethod _invoke;

            internal EndInvokeMethod(
                            InvokeMethod invoke,
                            TypeWithAnnotations iAsyncResultType,
                            DelegateDeclarationSyntax syntax)
            : base(f_10245_17826_17870_C((SourceNamedTypeSymbol)f_10245_17849_17870(invoke)), f_10245_17872_17904(invoke), syntax, MethodKind.Ordinary, DeclarationModifiers.Virtual | DeclarationModifiers.Public)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10245, 17632, 18842);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 17608, 17615);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 18027, 18044);

                    _invoke = invoke;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 18064, 18125);

                    var
                    parameters = f_10245_18081_18124()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 18143, 18159);

                    int
                    ordinal = 0
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 18179, 18590);
                        foreach (SourceParameterSymbol p in f_10245_18215_18232_I(f_10245_18215_18232(invoke)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10245, 18179, 18590);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 18274, 18571) || true) && (f_10245_18278_18287(p) != RefKind.None)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10245, 18274, 18571);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 18353, 18489);

                                var
                                synthesizedParam = f_10245_18376_18488(originalParam: p, newOwner: this, newOrdinal: ordinal++, suppressOptional: true)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 18515, 18548);

                                f_10245_18515_18547(parameters, synthesizedParam);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10245, 18274, 18571);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10245, 18179, 18590);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10245, 1, 412);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10245, 1, 412);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 18610, 18755);

                    f_10245_18610_18754(
                                    parameters, f_10245_18625_18753(this, iAsyncResultType, ordinal++, RefKind.None, f_10245_18708_18752(parameters, "result")));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 18773, 18827);

                    f_10245_18773_18826(this, f_10245_18794_18825(parameters));
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10245, 17632, 18842);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10245, 17632, 18842);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10245, 17632, 18842);
                }
            }

            protected override SourceMemberMethodSymbol BoundAttributesSource
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10245, 18924, 18934);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 18927, 18934);
                        return _invoke; DynAbs.Tracing.TraceSender.TraceExitMethod(10245, 18924, 18934);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10245, 18924, 18934);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10245, 18924, 18934);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10245, 18979, 19024);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 18982, 19024);
                        return WellKnownMemberNames.DelegateEndInvokeName; DynAbs.Tracing.TraceSender.TraceExitMethod(10245, 18979, 19024);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10245, 18979, 19024);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10245, 18979, 19024);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10245, 19073, 19091);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 19076, 19091);
                        return f_10245_19076_19091(_invoke); DynAbs.Tracing.TraceSender.TraceExitMethod(10245, 19073, 19091);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10245, 19073, 19091);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10245, 19073, 19091);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10245, 19174, 19203);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 19177, 19203);
                        return f_10245_19177_19203(_invoke); DynAbs.Tracing.TraceSender.TraceExitMethod(10245, 19174, 19203);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10245, 19174, 19203);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10245, 19174, 19203);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static EndInvokeMethod()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10245, 17488, 19215);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10245, 17488, 19215);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10245, 17488, 19215);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10245, 17488, 19215);

            static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            f_10245_17849_17870(Microsoft.CodeAnalysis.CSharp.Symbols.SourceDelegateMethodSymbol.InvokeMethod
            this_param)
            {
                var return_v = this_param.ContainingType;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10245, 17849, 17870);
                return return_v;
            }


            static Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
            f_10245_17872_17904(Microsoft.CodeAnalysis.CSharp.Symbols.SourceDelegateMethodSymbol.InvokeMethod
            this_param)
            {
                var return_v = this_param.ReturnTypeWithAnnotations;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10245, 17872, 17904);
                return return_v;
            }


            Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
            f_10245_18081_18124()
            {
                var return_v = ArrayBuilder<ParameterSymbol>.GetInstance();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 18081, 18124);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
            f_10245_18215_18232(Microsoft.CodeAnalysis.CSharp.Symbols.SourceDelegateMethodSymbol.InvokeMethod
            this_param)
            {
                var return_v = this_param.Parameters;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10245, 18215, 18232);
                return return_v;
            }


            Microsoft.CodeAnalysis.RefKind
            f_10245_18278_18287(Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbol
            this_param)
            {
                var return_v = this_param.RefKind;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10245, 18278, 18287);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.SourceClonedParameterSymbol
            f_10245_18376_18488(Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbol
            originalParam, Microsoft.CodeAnalysis.CSharp.Symbols.SourceDelegateMethodSymbol.EndInvokeMethod
            newOwner, int
            newOrdinal, bool
            suppressOptional)
            {
                var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SourceClonedParameterSymbol(originalParam: originalParam, newOwner: (Microsoft.CodeAnalysis.CSharp.Symbol)newOwner, newOrdinal: newOrdinal, suppressOptional: suppressOptional);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 18376, 18488);
                return return_v;
            }


            int
            f_10245_18515_18547(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
            this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceClonedParameterSymbol
            item)
            {
                this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol)item);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 18515, 18547);
                return 0;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
            f_10245_18215_18232_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 18215, 18232);
                return return_v;
            }


            string
            f_10245_18708_18752(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
            currentParameters, string
            name)
            {
                var return_v = GetUniqueParameterName(currentParameters, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 18708, 18752);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
            f_10245_18625_18753(Microsoft.CodeAnalysis.CSharp.Symbols.SourceDelegateMethodSymbol.EndInvokeMethod
            container, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
            type, int
            ordinal, Microsoft.CodeAnalysis.RefKind
            refKind, string
            name)
            {
                var return_v = SynthesizedParameterSymbol.Create((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)container, type, ordinal, refKind, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 18625, 18753);
                return return_v;
            }


            int
            f_10245_18610_18754(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
            this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
            item)
            {
                this_param.Add(item);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 18610, 18754);
                return 0;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
            f_10245_18794_18825(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
            this_param)
            {
                var return_v = this_param.ToImmutableAndFree();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 18794, 18825);
                return return_v;
            }


            int
            f_10245_18773_18826(Microsoft.CodeAnalysis.CSharp.Symbols.SourceDelegateMethodSymbol.EndInvokeMethod
            this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
            parameters)
            {
                this_param.InitializeParameters(parameters);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 18773, 18826);
                return 0;
            }


            static Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
            f_10245_17826_17870_C(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10245, 17632, 18842);
                return return_v;
            }


            Microsoft.CodeAnalysis.RefKind
            f_10245_19076_19091(Microsoft.CodeAnalysis.CSharp.Symbols.SourceDelegateMethodSymbol.InvokeMethod
            this_param)
            {
                var return_v = this_param.RefKind;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10245, 19076, 19091);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
            f_10245_19177_19203(Microsoft.CodeAnalysis.CSharp.Symbols.SourceDelegateMethodSymbol.InvokeMethod
            this_param)
            {
                var return_v = this_param.RefCustomModifiers;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10245, 19177, 19203);
                return return_v;
            }

        }

        private static string GetUniqueParameterName(ArrayBuilder<ParameterSymbol> currentParameters, string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10245, 19227, 19506);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 19358, 19467) || true) && (!f_10245_19366_19399(currentParameters, name))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10245, 19358, 19467);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 19433, 19452);

                        name = "__" + name;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10245, 19358, 19467);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10245, 19358, 19467);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10245, 19358, 19467);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 19483, 19495);

                return name;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10245, 19227, 19506);

                bool
                f_10245_19366_19399(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                currentParameters, string
                name)
                {
                    var return_v = IsUnique(currentParameters, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 19366, 19399);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10245, 19227, 19506);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10245, 19227, 19506);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsUnique(ArrayBuilder<ParameterSymbol> currentParameters, string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10245, 19518, 19874);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 19633, 19835);
                    foreach (var p in f_10245_19651_19668_I(currentParameters))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10245, 19633, 19835);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 19702, 19820) || true) && (f_10245_19706_19741(f_10245_19728_19734(p), name) == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10245, 19702, 19820);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 19788, 19801);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10245, 19702, 19820);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10245, 19633, 19835);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10245, 1, 203);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10245, 1, 203);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10245, 19851, 19863);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10245, 19518, 19874);

                string
                f_10245_19728_19734(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10245, 19728, 19734);
                    return return_v;
                }


                int
                f_10245_19706_19741(string
                strA, string
                strB)
                {
                    var return_v = string.CompareOrdinal(strA, strB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 19706, 19741);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10245_19651_19668_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 19651, 19668);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10245, 19518, 19874);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10245, 19518, 19874);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SourceDelegateMethodSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10245, 501, 19881);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10245, 501, 19881);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10245, 501, 19881);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10245, 501, 19881);

        static Microsoft.CodeAnalysis.SyntaxReference
        f_10245_1033_1054(Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax
        this_param)
        {
            var return_v = this_param.GetReference();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 1033, 1054);
            return return_v;
        }


        int
        f_10245_1181_1315(Microsoft.CodeAnalysis.CSharp.Symbols.SourceDelegateMethodSymbol
        this_param, Microsoft.CodeAnalysis.MethodKind
        methodKind, Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
        declarationModifiers, bool
        returnsVoid, bool
        isExtensionMethod, bool
        isNullableAnalysisEnabled)
        {
            this_param.MakeFlags(methodKind, declarationModifiers, returnsVoid, isExtensionMethod: isExtensionMethod, isNullableAnalysisEnabled: isNullableAnalysisEnabled);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10245, 1181, 1315);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10245_1019_1031_C(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10245, 718, 1327);
            return return_v;
        }

    }
}
