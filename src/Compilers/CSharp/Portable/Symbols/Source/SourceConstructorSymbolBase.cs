// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal abstract class SourceConstructorSymbolBase : SourceMemberMethodSymbol
    {
        protected ImmutableArray<ParameterSymbol> _lazyParameters;

        private TypeWithAnnotations _lazyReturnType;

        private bool _lazyIsVararg;

        protected SourceConstructorSymbolBase(
                    SourceMemberContainerTypeSymbol containingType,
                    Location location,
                    CSharpSyntaxNode syntax,
                    bool isIterator)
        : base(f_10242_933_947_C(containingType), f_10242_949_970(syntax), f_10242_972_1003(location), isIterator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10242, 713, 1197);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10242, 687, 700);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10242, 1041, 1186);

                f_10242_1041_1185(f_10242_1072_1120(syntax, SyntaxKind.ConstructorDeclaration) || (DynAbs.Tracing.TraceSender.Expression_False(10242, 1072, 1184) || f_10242_1141_1184(syntax, SyntaxKind.RecordDeclaration)));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10242, 713, 1197);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10242, 713, 1197);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10242, 713, 1197);
            }
        }

        protected sealed override void MethodChecks(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10242, 1209, 3703);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10242, 1304, 1366);

                var
                syntax = (CSharpSyntaxNode)f_10242_1335_1365(syntaxReferenceOpt)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10242, 1380, 1462);

                var
                binderFactory = f_10242_1400_1461(f_10242_1400_1425(this), f_10242_1443_1460(syntax))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10242, 1476, 1531);

                ParameterListSyntax
                parameterList = f_10242_1512_1530(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10242, 1831, 1936);

                var
                bodyBinder = f_10242_1848_1935(f_10242_1848_1900(binderFactory, parameterList, syntax, this), this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10242, 2377, 2501);

                var
                signatureBinder = f_10242_2399_2500(bodyBinder, BinderFlags.SuppressConstraintChecks, this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10242, 2517, 2542);

                SyntaxToken
                arglistToken
                = default(SyntaxToken);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10242, 2556, 2853);

                _lazyParameters = f_10242_2574_2852(signatureBinder, this, parameterList, out arglistToken, allowRefOrOut: f_10242_2712_2725(), allowThis: false, addRefReadOnlyModifier: false, diagnostics: diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10242, 2869, 2936);

                _lazyIsVararg = (arglistToken.Kind() == SyntaxKind.ArgListKeyword);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10242, 2950, 3068);

                _lazyReturnType = TypeWithAnnotations.Create(f_10242_2995_3066(bodyBinder, SpecialType.System_Void, diagnostics, syntax));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10242, 3084, 3117);

                var
                location = f_10242_3099_3113(this)[0]
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10242, 3131, 3323) || true) && (f_10242_3135_3145() == MethodKind.StaticConstructor && (DynAbs.Tracing.TraceSender.Expression_True(10242, 3135, 3210) && (_lazyParameters.Length != 0)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10242, 3131, 3323);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10242, 3244, 3308);

                    f_10242_3244_3307(diagnostics, ErrorCode.ERR_StaticConstParam, location, this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10242, 3131, 3323);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10242, 3339, 3419);

                f_10242_3339_3418(
                            this, _lazyReturnType, _lazyParameters, diagnostics);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10242, 3435, 3692) || true) && (_lazyIsVararg && (DynAbs.Tracing.TraceSender.Expression_True(10242, 3439, 3591) && (f_10242_3457_3472() || (DynAbs.Tracing.TraceSender.Expression_False(10242, 3457, 3504) || f_10242_3476_3504(f_10242_3476_3490())) || (DynAbs.Tracing.TraceSender.Expression_False(10242, 3457, 3590) || _lazyParameters.Length > 0 && (DynAbs.Tracing.TraceSender.Expression_True(10242, 3508, 3590) && f_10242_3538_3590(_lazyParameters[_lazyParameters.Length - 1]))))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10242, 3435, 3692);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10242, 3625, 3677);

                    f_10242_3625_3676(diagnostics, ErrorCode.ERR_BadVarargs, location);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10242, 3435, 3692);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10242, 1209, 3703);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10242_1335_1365(Microsoft.CodeAnalysis.SyntaxReference
                this_param)
                {
                    var return_v = this_param.GetSyntax();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10242, 1335, 1365);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10242_1400_1425(Microsoft.CodeAnalysis.CSharp.Symbols.SourceConstructorSymbolBase
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10242, 1400, 1425);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10242_1443_1460(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10242, 1443, 1460);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinderFactory
                f_10242_1400_1461(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree)
                {
                    var return_v = this_param.GetBinderFactory(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10242, 1400, 1461);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
                f_10242_1512_1530(Microsoft.CodeAnalysis.CSharp.Symbols.SourceConstructorSymbolBase
                this_param)
                {
                    var return_v = this_param.GetParameterList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10242, 1512, 1530);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10242_1848_1900(Microsoft.CodeAnalysis.CSharp.BinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
                node, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                memberDeclarationOpt, Microsoft.CodeAnalysis.CSharp.Symbols.SourceConstructorSymbolBase
                memberOpt)
                {
                    var return_v = this_param.GetBinder((Microsoft.CodeAnalysis.SyntaxNode)node, memberDeclarationOpt, (Microsoft.CodeAnalysis.CSharp.Symbol)memberOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10242, 1848, 1900);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10242_1848_1935(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceConstructorSymbolBase
                containing)
                {
                    var return_v = this_param.WithContainingMemberOrLambda((Microsoft.CodeAnalysis.CSharp.Symbol)containing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10242, 1848, 1935);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10242_2399_2500(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BinderFlags
                flags, Microsoft.CodeAnalysis.CSharp.Symbols.SourceConstructorSymbolBase
                containing)
                {
                    var return_v = this_param.WithAdditionalFlagsAndContainingMemberOrLambda(flags, (Microsoft.CodeAnalysis.CSharp.Symbol)containing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10242, 2399, 2500);
                    return return_v;
                }


                bool
                f_10242_2712_2725()
                {
                    var return_v = AllowRefOrOut;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10242, 2712, 2725);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10242_2574_2852(Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.CSharp.Symbols.SourceConstructorSymbolBase
                owner, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
                syntax, out Microsoft.CodeAnalysis.SyntaxToken
                arglistToken, bool
                allowRefOrOut, bool
                allowThis, bool
                addRefReadOnlyModifier, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = ParameterHelpers.MakeParameters(binder, (Microsoft.CodeAnalysis.CSharp.Symbol)owner, (Microsoft.CodeAnalysis.CSharp.Syntax.BaseParameterListSyntax)syntax, out arglistToken, allowRefOrOut: allowRefOrOut, allowThis: allowThis, addRefReadOnlyModifier: addRefReadOnlyModifier, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10242, 2574, 2852);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10242_2995_3066(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SpecialType
                typeId, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.GetSpecialType(typeId, diagnostics, (Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10242, 2995, 3066);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10242_3099_3113(Microsoft.CodeAnalysis.CSharp.Symbols.SourceConstructorSymbolBase
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10242, 3099, 3113);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10242_3135_3145()
                {
                    var return_v = MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10242, 3135, 3145);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10242_3244_3307(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10242, 3244, 3307);
                    return return_v;
                }


                int
                f_10242_3339_3418(Microsoft.CodeAnalysis.CSharp.Symbols.SourceConstructorSymbolBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                returnType, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.CheckEffectiveAccessibility(returnType, parameters, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10242, 3339, 3418);
                    return 0;
                }


                bool
                f_10242_3457_3472()
                {
                    var return_v = IsGenericMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10242, 3457, 3472);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10242_3476_3490()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10242, 3476, 3490);
                    return return_v;
                }


                bool
                f_10242_3476_3504(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsGenericType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10242, 3476, 3504);
                    return return_v;
                }


                bool
                f_10242_3538_3590(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.IsParams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10242, 3538, 3590);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10242_3625_3676(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10242, 3625, 3676);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10242, 1209, 3703);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10242, 1209, 3703);
            }
        }

        protected abstract ParameterListSyntax GetParameterList();

        protected abstract bool AllowRefOrOut { get; }

        internal sealed override void AfterAddingTypeMembersChecks(ConversionsBase conversions, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10242, 3880, 4734);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10242, 4019, 4079);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.AfterAddingTypeMembersChecks(conversions, diagnostics), 10242, 4019, 4078);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10242, 4095, 4134);

                var
                compilation = f_10242_4113_4133()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10242, 4148, 4260);

                f_10242_4148_4259(compilation, f_10242_4210_4220(), diagnostics, modifyCompilation: true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10242, 4274, 4389);

                f_10242_4274_4388(compilation, f_10242_4339_4349(), diagnostics, modifyCompilation: true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10242, 4403, 4519);

                f_10242_4403_4518(compilation, this, f_10242_4469_4479(), diagnostics, modifyCompilation: true);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10242, 4535, 4723);
                    foreach (var parameter in f_10242_4561_4576_I(f_10242_4561_4576(this)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10242, 4535, 4723);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10242, 4610, 4708);

                        f_10242_4610_4707(f_10242_4610_4624(parameter), compilation, conversions, f_10242_4671_4690(parameter)[0], diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10242, 4535, 4723);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10242, 1, 189);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10242, 1, 189);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10242, 3880, 4734);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10242_4113_4133()
                {
                    var return_v = DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10242, 4113, 4133);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10242_4210_4220()
                {
                    var return_v = Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10242, 4210, 4220);
                    return return_v;
                }


                int
                f_10242_4148_4259(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                modifyCompilation)
                {
                    ParameterHelpers.EnsureIsReadOnlyAttributeExists(compilation, parameters, diagnostics, modifyCompilation: modifyCompilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10242, 4148, 4259);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10242_4339_4349()
                {
                    var return_v = Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10242, 4339, 4349);
                    return return_v;
                }


                int
                f_10242_4274_4388(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                modifyCompilation)
                {
                    ParameterHelpers.EnsureNativeIntegerAttributeExists(compilation, parameters, diagnostics, modifyCompilation: modifyCompilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10242, 4274, 4388);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10242_4469_4479()
                {
                    var return_v = Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10242, 4469, 4479);
                    return return_v;
                }


                int
                f_10242_4403_4518(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Symbols.SourceConstructorSymbolBase
                container, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                modifyCompilation)
                {
                    ParameterHelpers.EnsureNullableAttributeExists(compilation, (Microsoft.CodeAnalysis.CSharp.Symbol)container, parameters, diagnostics, modifyCompilation: modifyCompilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10242, 4403, 4518);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10242_4561_4576(Microsoft.CodeAnalysis.CSharp.Symbols.SourceConstructorSymbolBase
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10242, 4561, 4576);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10242_4610_4624(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10242, 4610, 4624);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10242_4671_4690(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10242, 4671, 4690);
                    return return_v;
                }


                int
                f_10242_4610_4707(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.ConversionsBase
                conversions, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    type.CheckAllConstraints(compilation, conversions, location, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10242, 4610, 4707);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10242_4561_4576_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10242, 4561, 4576);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10242, 3880, 4734);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10242, 3880, 4734);
            }
        }

        public sealed override bool IsVararg
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10242, 4807, 4916);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10242, 4843, 4862);

                    f_10242_4843_4861(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10242, 4880, 4901);

                    return _lazyIsVararg;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10242, 4807, 4916);

                    int
                    f_10242_4843_4861(Microsoft.CodeAnalysis.CSharp.Symbols.SourceConstructorSymbolBase
                    this_param)
                    {
                        this_param.LazyMethodChecks();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10242, 4843, 4861);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10242, 4746, 4927);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10242, 4746, 4927);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10242, 5012, 5096);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10242, 5048, 5081);

                    return DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.IsImplicitlyDeclared, 10242, 5055, 5080);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10242, 5012, 5096);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10242, 4939, 5107);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10242, 4939, 5107);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override int ParameterCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10242, 5187, 5420);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10242, 5223, 5344) || true) && (f_10242_5227_5253_M(!_lazyParameters.IsDefault))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10242, 5223, 5344);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10242, 5295, 5325);

                        return _lazyParameters.Length;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10242, 5223, 5344);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10242, 5364, 5405);

                    return f_10242_5371_5404(f_10242_5371_5389(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10242, 5187, 5420);

                    bool
                    f_10242_5227_5253_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10242, 5227, 5253);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
                    f_10242_5371_5389(Microsoft.CodeAnalysis.CSharp.Symbols.SourceConstructorSymbolBase
                    this_param)
                    {
                        var return_v = this_param.GetParameterList();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10242, 5371, 5389);
                        return return_v;
                    }


                    int
                    f_10242_5371_5404(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
                    this_param)
                    {
                        var return_v = this_param.ParameterCount;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10242, 5371, 5404);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10242, 5119, 5431);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10242, 5119, 5431);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10242, 5533, 5644);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10242, 5569, 5588);

                    f_10242_5569_5587(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10242, 5606, 5629);

                    return _lazyParameters;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10242, 5533, 5644);

                    int
                    f_10242_5569_5587(Microsoft.CodeAnalysis.CSharp.Symbols.SourceConstructorSymbolBase
                    this_param)
                    {
                        this_param.LazyMethodChecks();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10242, 5569, 5587);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10242, 5443, 5655);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10242, 5443, 5655);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override ImmutableArray<TypeParameterSymbol> TypeParameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10242, 5765, 5822);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10242, 5771, 5820);

                    return ImmutableArray<TypeParameterSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10242, 5765, 5822);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10242, 5667, 5833);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10242, 5667, 5833);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override ImmutableArray<ImmutableArray<TypeWithAnnotations>> GetTypeParameterConstraintTypes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10242, 5967, 6027);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10242, 5970, 6027);
                return ImmutableArray<ImmutableArray<TypeWithAnnotations>>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10242, 5967, 6027);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10242, 5967, 6027);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10242, 5967, 6027);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override ImmutableArray<TypeParameterConstraintKind> GetTypeParameterConstraintKinds()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10242, 6154, 6206);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10242, 6157, 6206);
                return ImmutableArray<TypeParameterConstraintKind>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10242, 6154, 6206);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10242, 6154, 6206);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10242, 6154, 6206);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override RefKind RefKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10242, 6275, 6303);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10242, 6281, 6301);

                    return RefKind.None;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10242, 6275, 6303);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10242, 6219, 6314);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10242, 6219, 6314);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override TypeWithAnnotations ReturnTypeWithAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10242, 6419, 6530);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10242, 6455, 6474);

                    f_10242_6455_6473(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10242, 6492, 6515);

                    return _lazyReturnType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10242, 6419, 6530);

                    int
                    f_10242_6455_6473(Microsoft.CodeAnalysis.CSharp.Symbols.SourceConstructorSymbolBase
                    this_param)
                    {
                        this_param.LazyMethodChecks();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10242, 6455, 6473);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10242, 6326, 6541);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10242, 6326, 6541);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10242, 6612, 6733);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10242, 6618, 6731);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10242, 6625, 6638) || ((f_10242_6625_6638(this) && DynAbs.Tracing.TraceSender.Conditional_F2(10242, 6641, 6683)) || DynAbs.Tracing.TraceSender.Conditional_F3(10242, 6686, 6730))) ? WellKnownMemberNames.StaticConstructorName : WellKnownMemberNames.InstanceConstructorName;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10242, 6612, 6733);

                    bool
                    f_10242_6625_6638(Microsoft.CodeAnalysis.CSharp.Symbols.SourceConstructorSymbolBase
                    this_param)
                    {
                        var return_v = this_param.IsStatic;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10242, 6625, 6638);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10242, 6553, 6744);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10242, 6553, 6744);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override OneOrMany<SyntaxList<AttributeListSyntax>> GetReturnTypeAttributeDeclarations()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10242, 6756, 7025);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10242, 6948, 7014);

                return f_10242_6955_7013(default(SyntaxList<AttributeListSyntax>));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10242, 6756, 7025);

                Roslyn.Utilities.OneOrMany<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                f_10242_6955_7013(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                one)
                {
                    var return_v = OneOrMany.Create(one);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10242, 6955, 7013);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10242, 6756, 7025);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10242, 6756, 7025);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected sealed override IAttributeTargetSymbol AttributeOwner
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10242, 7125, 7203);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10242, 7161, 7188);

                    return DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.AttributeOwner, 10242, 7168, 7187);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10242, 7125, 7203);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10242, 7037, 7214);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10242, 7037, 7214);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool GenerateDebugInfo
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10242, 7298, 7318);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10242, 7304, 7316);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10242, 7298, 7318);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10242, 7226, 7329);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10242, 7226, 7329);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override int CalculateLocalSyntaxOffset(int position, SyntaxTree tree)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10242, 7341, 9489);
                int offset = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10242, 7452, 7496);

                f_10242_7452_7495(position >= 0 && (DynAbs.Tracing.TraceSender.Expression_True(10242, 7465, 7494) && tree != null));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10242, 7512, 7526);

                TextSpan
                span
                = default(TextSpan);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10242, 7623, 7689);

                var
                ctorSyntax = (CSharpSyntaxNode)f_10242_7658_7688(syntaxReferenceOpt)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10242, 7703, 8375) || true) && (tree == f_10242_7715_7736(ctorSyntax))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10242, 7703, 8375);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10242, 7770, 7904) || true) && (f_10242_7774_7829(this, position, out offset))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10242, 7770, 7904);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10242, 7871, 7885);

                        return offset;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10242, 7770, 7904);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10242, 8032, 8360) || true) && (position == f_10242_8048_8068(ctorSyntax))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10242, 8032, 8360);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10242, 8331, 8341);

                        return -1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10242, 8032, 8360);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10242, 7703, 8375);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10242, 8436, 8462);

                int
                ctorInitializerLength
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10242, 8476, 8515);

                var
                ctorInitializer = f_10242_8498_8514(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10242, 8529, 8955) || true) && (tree == f_10242_8541_8568_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(ctorInitializer, 10242, 8541, 8568)?.SyntaxTree))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10242, 8529, 8955);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10242, 8602, 8630);

                    span = f_10242_8609_8629(ctorInitializer);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10242, 8648, 8684);

                    ctorInitializerLength = span.Length;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10242, 8704, 8848) || true) && (span.Contains(position))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10242, 8704, 8848);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10242, 8773, 8829);

                        return -ctorInitializerLength + (position - span.Start);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10242, 8704, 8848);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10242, 8529, 8955);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10242, 8529, 8955);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10242, 8914, 8940);

                    ctorInitializerLength = 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10242, 8529, 8955);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10242, 9027, 9044);

                int
                syntaxOffset
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10242, 9058, 9122);

                var
                containingType = (SourceNamedTypeSymbol)f_10242_9102_9121(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10242, 9136, 9343) || true) && (f_10242_9140_9274(containingType, position, tree, f_10242_9219_9232(this), ctorInitializerLength, out syntaxOffset))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10242, 9136, 9343);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10242, 9308, 9328);

                    return syntaxOffset;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10242, 9136, 9343);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10242, 9441, 9478);

                throw f_10242_9447_9477();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10242, 7341, 9489);

                int
                f_10242_7452_7495(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10242, 7452, 7495);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10242_7658_7688(Microsoft.CodeAnalysis.SyntaxReference
                this_param)
                {
                    var return_v = this_param.GetSyntax();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10242, 7658, 7688);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10242_7715_7736(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10242, 7715, 7736);
                    return return_v;
                }


                bool
                f_10242_7774_7829(Microsoft.CodeAnalysis.CSharp.Symbols.SourceConstructorSymbolBase
                this_param, int
                position, out int
                offset)
                {
                    var return_v = this_param.IsWithinExpressionOrBlockBody(position, out offset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10242, 7774, 7829);
                    return return_v;
                }


                int
                f_10242_8048_8068(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.SpanStart;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10242, 8048, 8068);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10242_8498_8514(Microsoft.CodeAnalysis.CSharp.Symbols.SourceConstructorSymbolBase
                this_param)
                {
                    var return_v = this_param.GetInitializer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10242, 8498, 8514);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree?
                f_10242_8541_8568_M(Microsoft.CodeAnalysis.SyntaxTree?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10242, 8541, 8568);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_10242_8609_8629(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Span;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10242, 8609, 8629);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10242_9102_9121(Microsoft.CodeAnalysis.CSharp.Symbols.SourceConstructorSymbolBase
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10242, 9102, 9121);
                    return return_v;
                }


                bool
                f_10242_9219_9232(Microsoft.CodeAnalysis.CSharp.Symbols.SourceConstructorSymbolBase
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10242, 9219, 9232);
                    return return_v;
                }


                bool
                f_10242_9140_9274(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param, int
                position, Microsoft.CodeAnalysis.SyntaxTree
                tree, bool
                isStatic, int
                ctorInitializerLength, out int
                syntaxOffset)
                {
                    var return_v = this_param.TryCalculateSyntaxOffsetOfPositionInInitializer(position, tree, isStatic, ctorInitializerLength, out syntaxOffset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10242, 9140, 9274);
                    return return_v;
                }


                System.Exception
                f_10242_9447_9477()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10242, 9447, 9477);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10242, 7341, 9489);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10242, 7341, 9489);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal abstract override bool IsNullableAnalysisEnabled();

        protected abstract CSharpSyntaxNode GetInitializer();

        protected abstract bool IsWithinExpressionOrBlockBody(int position, out int offset);

        static SourceConstructorSymbolBase()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10242, 457, 9729);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10242, 457, 9729);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10242, 457, 9729);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10242, 457, 9729);

        static Microsoft.CodeAnalysis.SyntaxReference
        f_10242_949_970(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
        this_param)
        {
            var return_v = this_param.GetReference();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10242, 949, 970);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
        f_10242_972_1003(Microsoft.CodeAnalysis.Location
        item)
        {
            var return_v = ImmutableArray.Create(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10242, 972, 1003);
            return return_v;
        }


        bool
        f_10242_1072_1120(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
        node, Microsoft.CodeAnalysis.CSharp.SyntaxKind
        kind)
        {
            var return_v = node.IsKind(kind);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10242, 1072, 1120);
            return return_v;
        }


        bool
        f_10242_1141_1184(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
        node, Microsoft.CodeAnalysis.CSharp.SyntaxKind
        kind)
        {
            var return_v = node.IsKind(kind);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10242, 1141, 1184);
            return return_v;
        }


        int
        f_10242_1041_1185(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10242, 1041, 1185);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10242_933_947_C(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10242, 713, 1197);
            return return_v;
        }

    }
}
