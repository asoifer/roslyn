// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class InMethodBinder : LocalScopeBinder
    {
        private MultiDictionary<string, ParameterSymbol> _lazyParameterMap;

        private readonly MethodSymbol _methodSymbol;

        private SmallDictionary<string, Symbol> _lazyDefinitionMap;

        private TypeWithAnnotations.Boxed _iteratorElementType;

        public InMethodBinder(MethodSymbol owner, Binder enclosing)
        : base(f_10347_1253_1262_C(enclosing), enclosing.Flags & ~BinderFlags.AllClearedAtExecutableCodeBoundary)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10347, 1173, 1519);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 955, 972);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 1013, 1026);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 1077, 1095);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 1140, 1160);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 1355, 1422);

                f_10347_1355_1421(!f_10347_1369_1420(enclosing.Flags, BinderFlags.InCatchFilter));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 1436, 1472);

                f_10347_1436_1471((object)owner != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 1486, 1508);

                _methodSymbol = owner;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10347, 1173, 1519);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10347, 1173, 1519);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10347, 1173, 1519);
            }
        }

        private static void RecordDefinition<T>(SmallDictionary<string, Symbol> declarationMap, ImmutableArray<T> definitions) where T : Symbol
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10347, 1531, 1913);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 1691, 1902);
                    foreach (Symbol s in f_10347_1712_1723_I<T>(definitions))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10347, 1691, 1902);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 1757, 1887) || true) && (!f_10347_1762_1796<T>(declarationMap, f_10347_1789_1795<T>(s)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10347, 1757, 1887);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 1838, 1868);

                            f_10347_1838_1867<T>(declarationMap, f_10347_1857_1863<T>(s), s);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10347, 1757, 1887);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10347, 1691, 1902);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10347, 1, 212);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10347, 1, 212);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10347, 1531, 1913);

                string
                f_10347_1789_1795<T>(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param) where T : Symbol

                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10347, 1789, 1795);
                    return return_v;
                }


                bool
                f_10347_1762_1796<T>(Microsoft.CodeAnalysis.SmallDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, string
                key) where T : Symbol

                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10347, 1762, 1796);
                    return return_v;
                }


                string
                f_10347_1857_1863<T>(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param) where T : Symbol

                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10347, 1857, 1863);
                    return return_v;
                }


                int
                f_10347_1838_1867<T>(Microsoft.CodeAnalysis.SmallDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, string
                key, Microsoft.CodeAnalysis.CSharp.Symbol
                value) where T : Symbol

                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10347, 1838, 1867);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<T>
                f_10347_1712_1723_I<T>(System.Collections.Immutable.ImmutableArray<T>
                i) where T : Symbol

                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10347, 1712, 1723);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10347, 1531, 1913);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10347, 1531, 1913);
            }
        }

        protected override SourceLocalSymbol LookupLocal(SyntaxToken nameToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10347, 1925, 2044);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 2021, 2033);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10347, 1925, 2044);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10347, 1925, 2044);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10347, 1925, 2044);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override LocalFunctionSymbol LookupLocalFunction(SyntaxToken nameToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10347, 2056, 2185);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 2162, 2174);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10347, 2056, 2185);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10347, 2056, 2185);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10347, 2056, 2185);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override uint LocalScopeDepth
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10347, 2236, 2259);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 2239, 2259);
                    return Binder.TopLevelScope; DynAbs.Tracing.TraceSender.TraceExitMethod(10347, 2236, 2259);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10347, 2236, 2259);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10347, 2236, 2259);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override bool InExecutableBinder
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10347, 2315, 2322);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 2318, 2322);
                    return true; DynAbs.Tracing.TraceSender.TraceExitMethod(10347, 2315, 2322);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10347, 2315, 2322);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10347, 2315, 2322);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override Symbol ContainingMemberOrLambda
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10347, 2409, 2481);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 2445, 2466);

                    return _methodSymbol;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10347, 2409, 2481);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10347, 2335, 2492);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10347, 2335, 2492);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsInMethodBody
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10347, 2566, 2629);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 2602, 2614);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10347, 2566, 2629);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10347, 2504, 2640);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10347, 2504, 2640);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsNestedFunctionBinder
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10347, 2698, 2753);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 2701, 2753);
                    return f_10347_2701_2725(_methodSymbol) == MethodKind.LocalFunction; DynAbs.Tracing.TraceSender.TraceExitMethod(10347, 2698, 2753);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10347, 2698, 2753);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10347, 2698, 2753);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsDirectlyInIterator
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10347, 2834, 2917);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 2870, 2902);

                    return f_10347_2877_2901(_methodSymbol);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10347, 2834, 2917);

                    bool
                    f_10347_2877_2901(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsIterator;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10347, 2877, 2901);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10347, 2766, 2928);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10347, 2766, 2928);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsIndirectlyInIterator
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10347, 3010, 3121);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 3046, 3074);

                    return f_10347_3053_3073();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10347, 3010, 3121);

                    bool
                    f_10347_3053_3073()
                    {
                        var return_v = IsDirectlyInIterator;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10347, 3053, 3073);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10347, 2940, 3132);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10347, 2940, 3132);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override GeneratedLabelSymbol BreakLabel
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10347, 3218, 3281);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 3254, 3266);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10347, 3218, 3281);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10347, 3144, 3292);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10347, 3144, 3292);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override GeneratedLabelSymbol ContinueLabel
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10347, 3381, 3444);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 3417, 3429);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10347, 3381, 3444);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10347, 3304, 3455);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10347, 3304, 3455);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override void ValidateYield(YieldStatementSyntax node, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10347, 3467, 3580);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10347, 3467, 3580);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10347, 3467, 3580);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10347, 3467, 3580);
            }
        }

        internal override TypeWithAnnotations GetIteratorElementType()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10347, 3592, 5294);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 3679, 3719);

                RefKind
                refKind = f_10347_3697_3718(_methodSymbol)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 3733, 3782);

                TypeSymbol
                returnType = f_10347_3757_3781(_methodSymbol)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 3798, 4703) || true) && (f_10347_3802_3828_M(!this.IsDirectlyInIterator))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10347, 3798, 4703);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 4449, 4578);

                    var
                    elementType = f_10347_4467_4577(f_10347_4504_4515(), refKind, returnType, errorLocation: null, diagnostics: null)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 4596, 4688);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10347, 4603, 4625) || ((f_10347_4603_4625_M(!elementType.IsDefault) && DynAbs.Tracing.TraceSender.Conditional_F2(10347, 4628, 4639)) || DynAbs.Tracing.TraceSender.Conditional_F3(10347, 4642, 4687))) ? elementType : TypeWithAnnotations.Create(f_10347_4669_4686(this));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10347, 3798, 4703);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 4719, 5233) || true) && (_iteratorElementType is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10347, 4719, 5233);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 4785, 4930);

                    TypeWithAnnotations
                    elementType = f_10347_4819_4929(f_10347_4856_4867(), refKind, returnType, errorLocation: null, diagnostics: null)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 4948, 5094) || true) && (elementType.IsDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10347, 4948, 5094);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 5015, 5075);

                        elementType = TypeWithAnnotations.Create(f_10347_5056_5073(this));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10347, 4948, 5094);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 5114, 5218);

                    f_10347_5114_5217(ref _iteratorElementType, f_10347_5168_5210(elementType), null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10347, 4719, 5233);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 5249, 5283);

                return _iteratorElementType.Value;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10347, 3592, 5294);

                Microsoft.CodeAnalysis.RefKind
                f_10347_3697_3718(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10347, 3697, 3718);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10347_3757_3781(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10347, 3757, 3781);
                    return return_v;
                }


                bool
                f_10347_3802_3828_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10347, 3802, 3828);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10347_4504_4515()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10347, 4504, 4515);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10347_4467_4577(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.RefKind
                refKind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                returnType, Microsoft.CodeAnalysis.Location
                errorLocation, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = GetIteratorElementTypeFromReturnType(compilation, refKind, returnType, errorLocation: errorLocation, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10347, 4467, 4577);
                    return return_v;
                }


                bool
                f_10347_4603_4625_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10347, 4603, 4625);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10347_4669_4686(Microsoft.CodeAnalysis.CSharp.InMethodBinder
                this_param)
                {
                    var return_v = this_param.CreateErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10347, 4669, 4686);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10347_4856_4867()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10347, 4856, 4867);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10347_4819_4929(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.RefKind
                refKind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                returnType, Microsoft.CodeAnalysis.Location
                errorLocation, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = GetIteratorElementTypeFromReturnType(compilation, refKind, returnType, errorLocation: errorLocation, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10347, 4819, 4929);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10347_5056_5073(Microsoft.CodeAnalysis.CSharp.InMethodBinder
                this_param)
                {
                    var return_v = this_param.CreateErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10347, 5056, 5073);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed
                f_10347_5168_5210(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                value)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10347, 5168, 5210);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed?
                f_10347_5114_5217(ref Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed?
                location1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed
                value, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10347, 5114, 5217);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10347, 3592, 5294);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10347, 3592, 5294);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static TypeWithAnnotations GetIteratorElementTypeFromReturnType(CSharpCompilation compilation,
                    RefKind refKind, TypeSymbol returnType, Location errorLocation, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10347, 5306, 7168);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 5538, 7126) || true) && (refKind == RefKind.None && (DynAbs.Tracing.TraceSender.Expression_True(10347, 5542, 5608) && f_10347_5569_5584(returnType) == SymbolKind.NamedType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10347, 5538, 7126);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 5642, 5704);

                    TypeSymbol
                    originalDefinition = f_10347_5674_5703(returnType)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 5722, 6584);

                    switch (f_10347_5730_5760(originalDefinition))
                    {

                        case SpecialType.System_Collections_IEnumerable:
                        case SpecialType.System_Collections_IEnumerator:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10347, 5722, 6584);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 5946, 6017);

                            var
                            objectType = f_10347_5963_6016(compilation, SpecialType.System_Object)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 6043, 6216) || true) && (diagnostics != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10347, 6043, 6216);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 6124, 6189);

                                f_10347_6124_6188(objectType, diagnostics, errorLocation);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10347, 6043, 6216);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 6242, 6288);

                            return TypeWithAnnotations.Create(objectType);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10347, 5722, 6584);

                        case SpecialType.System_Collections_Generic_IEnumerable_T:
                        case SpecialType.System_Collections_Generic_IEnumerator_T:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10347, 5722, 6584);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 6476, 6565);

                            return f_10347_6483_6561(((NamedTypeSymbol)returnType))[0];
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10347, 5722, 6584);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 6604, 7111) || true) && (f_10347_6608_6772(originalDefinition, f_10347_6646_6735(compilation, WellKnownType.System_Collections_Generic_IAsyncEnumerable_T), TypeCompareKind.ConsiderEverything) || (DynAbs.Tracing.TraceSender.Expression_False(10347, 6608, 6961) || f_10347_6797_6961(originalDefinition, f_10347_6835_6924(compilation, WellKnownType.System_Collections_Generic_IAsyncEnumerator_T), TypeCompareKind.ConsiderEverything)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10347, 6604, 7111);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 7003, 7092);

                        return f_10347_7010_7088(((NamedTypeSymbol)returnType))[0];
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10347, 6604, 7111);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10347, 5538, 7126);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 7142, 7157);

                return default;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10347, 5306, 7168);

                Microsoft.CodeAnalysis.SymbolKind
                f_10347_5569_5584(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10347, 5569, 5584);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10347_5674_5703(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10347, 5674, 5703);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10347_5730_5760(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10347, 5730, 5760);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10347_5963_6016(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10347, 5963, 6016);
                    return return_v;
                }


                bool
                f_10347_6124_6188(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = ReportUseSiteDiagnostics((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, diagnostics, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10347, 6124, 6188);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10347_6483_6561(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeArgumentsWithAnnotationsNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10347, 6483, 6561);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10347_6646_6735(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10347, 6646, 6735);
                    return return_v;
                }


                bool
                f_10347_6608_6772(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10347, 6608, 6772);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10347_6835_6924(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10347, 6835, 6924);
                    return return_v;
                }


                bool
                f_10347_6797_6961(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10347, 6797, 6961);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10347_7010_7088(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeArgumentsWithAnnotationsNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10347, 7010, 7088);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10347, 5306, 7168);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10347, 5306, 7168);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsAsyncStreamInterface(CSharpCompilation compilation, RefKind refKind, TypeSymbol returnType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10347, 7180, 7990);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 7319, 7950) || true) && (refKind == RefKind.None && (DynAbs.Tracing.TraceSender.Expression_True(10347, 7323, 7389) && f_10347_7350_7365(returnType) == SymbolKind.NamedType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10347, 7319, 7950);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 7423, 7485);

                    TypeSymbol
                    originalDefinition = f_10347_7455_7484(returnType)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 7505, 7935) || true) && (f_10347_7509_7673(originalDefinition, f_10347_7547_7636(compilation, WellKnownType.System_Collections_Generic_IAsyncEnumerable_T), TypeCompareKind.ConsiderEverything) || (DynAbs.Tracing.TraceSender.Expression_False(10347, 7509, 7862) || f_10347_7698_7862(originalDefinition, f_10347_7736_7825(compilation, WellKnownType.System_Collections_Generic_IAsyncEnumerator_T), TypeCompareKind.ConsiderEverything)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10347, 7505, 7935);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 7904, 7916);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10347, 7505, 7935);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10347, 7319, 7950);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 7966, 7979);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10347, 7180, 7990);

                Microsoft.CodeAnalysis.SymbolKind
                f_10347_7350_7365(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10347, 7350, 7365);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10347_7455_7484(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10347, 7455, 7484);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10347_7547_7636(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10347, 7547, 7636);
                    return return_v;
                }


                bool
                f_10347_7509_7673(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10347, 7509, 7673);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10347_7736_7825(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10347, 7736, 7825);
                    return return_v;
                }


                bool
                f_10347_7698_7862(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10347, 7698, 7862);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10347, 7180, 7990);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10347, 7180, 7990);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override void LookupSymbolsInSingleBinder(
                    LookupResult result, string name, int arity, ConsList<TypeSymbol> basesBeingResolved, LookupOptions options, Binder originalBinder, bool diagnose, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10347, 8002, 9252);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 8286, 8315);

                f_10347_8286_8314(f_10347_8299_8313(result));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 8331, 8479) || true) && (f_10347_8335_8363(_methodSymbol) == 0 || (DynAbs.Tracing.TraceSender.Expression_False(10347, 8335, 8423) || (options & LookupOptions.NamespaceAliasesOnly) != 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10347, 8331, 8479);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 8457, 8464);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10347, 8331, 8479);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 8495, 8532);

                var
                parameterMap = _lazyParameterMap
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 8546, 9004) || true) && (parameterMap == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10347, 8546, 9004);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 8604, 8646);

                    var
                    parameters = f_10347_8621_8645(_methodSymbol)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 8664, 8777);

                    parameterMap = f_10347_8679_8776(parameters.Length, f_10347_8743_8775());
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 8795, 8936);
                        foreach (var parameter in f_10347_8821_8831_I(parameters))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10347, 8795, 8936);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 8873, 8917);

                            f_10347_8873_8916(parameterMap, f_10347_8890_8904(parameter), parameter);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10347, 8795, 8936);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10347, 1, 142);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10347, 1, 142);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 8956, 8989);

                    _lazyParameterMap = parameterMap;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10347, 8546, 9004);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 9020, 9241);
                    foreach (var parameterSymbol in f_10347_9052_9070_I(f_10347_9052_9070(parameterMap, name)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10347, 9020, 9241);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 9104, 9226);

                        f_10347_9104_9225(result, f_10347_9122_9224(originalBinder, parameterSymbol, arity, options, null, diagnose, ref useSiteDiagnostics));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10347, 9020, 9241);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10347, 1, 222);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10347, 1, 222);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10347, 8002, 9252);

                bool
                f_10347_8299_8313(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    var return_v = this_param.IsClear;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10347, 8299, 8313);
                    return return_v;
                }


                int
                f_10347_8286_8314(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10347, 8286, 8314);
                    return 0;
                }


                int
                f_10347_8335_8363(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10347, 8335, 8363);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10347_8621_8645(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10347, 8621, 8645);
                    return return_v;
                }


                System.Collections.Generic.EqualityComparer<string>
                f_10347_8743_8775()
                {
                    var return_v = EqualityComparer<string>.Default;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10347, 8743, 8775);
                    return return_v;
                }


                Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10347_8679_8776(int
                capacity, System.Collections.Generic.EqualityComparer<string>
                comparer)
                {
                    var return_v = new Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>(capacity, (System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10347, 8679, 8776);
                    return return_v;
                }


                string
                f_10347_8890_8904(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10347, 8890, 8904);
                    return return_v;
                }


                bool
                f_10347_8873_8916(Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                this_param, string
                k, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                v)
                {
                    var return_v = this_param.Add(k, v);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10347, 8873, 8916);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10347_8821_8831_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10347, 8821, 8831);
                    return return_v;
                }


                Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>.ValueSet
                f_10347_9052_9070(Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10347, 9052, 9070);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SingleLookupResult
                f_10347_9122_9224(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                symbol, int
                arity, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                accessThroughType, bool
                diagnose, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.CheckViability((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, arity, options, accessThroughType, diagnose, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10347, 9122, 9224);
                    return return_v;
                }


                int
                f_10347_9104_9225(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param, Microsoft.CodeAnalysis.CSharp.SingleLookupResult
                result)
                {
                    this_param.MergeEqual(result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10347, 9104, 9225);
                    return 0;
                }


                Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>.ValueSet
                f_10347_9052_9070_I(Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>.ValueSet
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10347, 9052, 9070);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10347, 8002, 9252);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10347, 8002, 9252);
            }
        }

        protected override void AddLookupSymbolsInfoInSingleBinder(LookupSymbolsInfo result, LookupOptions options, Binder originalBinder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10347, 9264, 9817);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 9419, 9806) || true) && (f_10347_9423_9451(options))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10347, 9419, 9806);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 9485, 9791);
                        foreach (var parameter in f_10347_9511_9535_I(f_10347_9511_9535(_methodSymbol)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10347, 9485, 9791);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 9577, 9772) || true) && (f_10347_9581_9652(originalBinder, parameter, options, result, null))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10347, 9577, 9772);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 9702, 9749);

                                f_10347_9702_9748(result, parameter, f_10347_9730_9744(parameter), 0);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10347, 9577, 9772);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10347, 9485, 9791);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10347, 1, 307);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10347, 1, 307);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10347, 9419, 9806);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10347, 9264, 9817);

                bool
                f_10347_9423_9451(Microsoft.CodeAnalysis.CSharp.LookupOptions
                options)
                {
                    var return_v = options.CanConsiderMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10347, 9423, 9451);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10347_9511_9535(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10347, 9511, 9535);
                    return return_v;
                }


                bool
                f_10347_9581_9652(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                symbol, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.LookupSymbolsInfo
                info, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                accessThroughType)
                {
                    var return_v = this_param.CanAddLookupSymbolInfo((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, options, info, accessThroughType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10347, 9581, 9652);
                    return return_v;
                }


                string
                f_10347_9730_9744(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10347, 9730, 9744);
                    return return_v;
                }


                int
                f_10347_9702_9748(Microsoft.CodeAnalysis.CSharp.LookupSymbolsInfo
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                symbol, string
                name, int
                arity)
                {
                    this_param.AddSymbol((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, name, arity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10347, 9702, 9748);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10347_9511_9535_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10347, 9511, 9535);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10347, 9264, 9817);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10347, 9264, 9817);
            }
        }

        private static bool ReportConflictWithParameter(Symbol parameter, Symbol newSymbol, string name, Location newLocation, DiagnosticBag diagnostics)
        {
#if DEBUG
            var locations = parameter.Locations;
            Debug.Assert(!locations.IsEmpty || parameter.IsImplicitlyDeclared);
            var oldLocation = locations.FirstOrNone();
            Debug.Assert(oldLocation != newLocation || oldLocation == Location.None || newLocation.SourceTree?.GetRoot().ContainsDiagnostics == true,
                "same nonempty location refers to different symbols?");
#endif 
            SymbolKind parameterKind = parameter.Kind;

            // Quirk of the way we represent lambda parameters.                
            SymbolKind newSymbolKind = (object)newSymbol == null ? SymbolKind.Parameter : newSymbol.Kind;

            if (newSymbolKind == SymbolKind.ErrorType)
            {
                return true;
            }

            if (parameterKind == SymbolKind.Parameter)
            {
                switch (newSymbolKind)
                {
                    case SymbolKind.Parameter:
                    case SymbolKind.Local:
                        // A local or parameter named '{0}' cannot be declared in this scope because that name is used in an enclosing local scope to define a local or parameter
                        diagnostics.Add(ErrorCode.ERR_LocalIllegallyOverrides, newLocation, name);
                        return true;

                    case SymbolKind.Method:
                        if (((MethodSymbol)newSymbol).MethodKind == MethodKind.LocalFunction)
                        {
                            goto case SymbolKind.Parameter;
                        }
                        break;

                    case SymbolKind.TypeParameter:
                        // Type parameter declaration name conflicts are not reported, for backwards compatibility.
                        return false;

                    case SymbolKind.RangeVariable:
                        // The range variable '{0}' conflicts with a previous declaration of '{0}'
                        diagnostics.Add(ErrorCode.ERR_QueryRangeVariableOverrides, newLocation, name);
                        return true;
                }
            }

            if (parameterKind == SymbolKind.TypeParameter)
            {
                switch (newSymbolKind)
                {
                    case SymbolKind.Parameter:
                    case SymbolKind.Local:
                        // CS0412: '{0}': a parameter, local variable, or local function cannot have the same name as a method type parameter
                        diagnostics.Add(ErrorCode.ERR_LocalSameNameAsTypeParam, newLocation, name);
                        return true;

                    case SymbolKind.Method:
                        if (((MethodSymbol)newSymbol).MethodKind == MethodKind.LocalFunction)
                        {
                            goto case SymbolKind.Parameter;
                        }
                        break;

                    case SymbolKind.TypeParameter:
                        // Type parameter declaration name conflicts are detected elsewhere
                        return false;

                    case SymbolKind.RangeVariable:
                        // The range variable '{0}' cannot have the same name as a method type parameter
                        diagnostics.Add(ErrorCode.ERR_QueryRangeVariableSameAsTypeParam, newLocation, name);
                        return true;
                }
            }

            Debug.Assert(false, "what else could be defined in a method?");
            diagnostics.Add(ErrorCode.ERR_InternalError, newLocation);
            return true;
        }

        internal override bool EnsureSingleDefinition(Symbol symbol, string name, Location location, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10347, 13679, 14666);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 13823, 13865);

                var
                parameters = f_10347_13840_13864(_methodSymbol)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 13879, 13929);

                var
                typeParameters = f_10347_13900_13928(_methodSymbol)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 13945, 14055) || true) && (parameters.IsEmpty && (DynAbs.Tracing.TraceSender.Expression_True(10347, 13949, 13993) && typeParameters.IsEmpty))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10347, 13945, 14055);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 14027, 14040);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10347, 13945, 14055);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 14071, 14100);

                var
                map = _lazyDefinitionMap
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 14116, 14377) || true) && (map == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10347, 14116, 14377);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 14165, 14209);

                    map = f_10347_14171_14208();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 14227, 14261);

                    f_10347_14227_14260(map, parameters);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 14279, 14317);

                    f_10347_14279_14316(map, typeParameters);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 14337, 14362);

                    _lazyDefinitionMap = map;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10347, 14116, 14377);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 14393, 14420);

                Symbol
                existingDeclaration
                = default(Symbol);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 14434, 14626) || true) && (f_10347_14438_14484(map, name, out existingDeclaration))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10347, 14434, 14626);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 14518, 14611);

                    return f_10347_14525_14610(existingDeclaration, symbol, name, location, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10347, 14434, 14626);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10347, 14642, 14655);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10347, 13679, 14666);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10347_13840_13864(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10347, 13840, 13864);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10347_13900_13928(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10347, 13900, 13928);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SmallDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10347_14171_14208()
                {
                    var return_v = new Microsoft.CodeAnalysis.SmallDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10347, 14171, 14208);
                    return return_v;
                }


                int
                f_10347_14227_14260(Microsoft.CodeAnalysis.SmallDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbol>
                declarationMap, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                definitions)
                {
                    RecordDefinition(declarationMap, definitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10347, 14227, 14260);
                    return 0;
                }


                int
                f_10347_14279_14316(Microsoft.CodeAnalysis.SmallDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbol>
                declarationMap, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                definitions)
                {
                    RecordDefinition(declarationMap, definitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10347, 14279, 14316);
                    return 0;
                }


                bool
                f_10347_14438_14484(Microsoft.CodeAnalysis.SmallDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, string
                key, out Microsoft.CodeAnalysis.CSharp.Symbol
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10347, 14438, 14484);
                    return return_v;
                }


                bool
                f_10347_14525_14610(Microsoft.CodeAnalysis.CSharp.Symbol
                parameter, Microsoft.CodeAnalysis.CSharp.Symbol
                newSymbol, string
                name, Microsoft.CodeAnalysis.Location
                newLocation, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = ReportConflictWithParameter(parameter, newSymbol, name, newLocation, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10347, 14525, 14610);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10347, 13679, 14666);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10347, 13679, 14666);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static InMethodBinder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10347, 834, 14673);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10347, 834, 14673);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10347, 834, 14673);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10347, 834, 14673);

        bool
        f_10347_1369_1420(Microsoft.CodeAnalysis.CSharp.BinderFlags
        self, Microsoft.CodeAnalysis.CSharp.BinderFlags
        other)
        {
            var return_v = self.Includes(other);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10347, 1369, 1420);
            return return_v;
        }


        int
        f_10347_1355_1421(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10347, 1355, 1421);
            return 0;
        }


        int
        f_10347_1436_1471(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10347, 1436, 1471);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Binder
        f_10347_1253_1262_C(Microsoft.CodeAnalysis.CSharp.Binder
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10347, 1173, 1519);
            return return_v;
        }


        Microsoft.CodeAnalysis.MethodKind
        f_10347_2701_2725(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.MethodKind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10347, 2701, 2725);
            return return_v;
        }

    }
}
