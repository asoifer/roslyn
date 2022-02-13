// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class Binder
    {
        internal static void BindAttributeTypes(ImmutableArray<Binder> binders, ImmutableArray<AttributeSyntax> attributesToBind, Symbol ownerSymbol, NamedTypeSymbol[] boundAttributeTypes, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10300, 1391, 2741);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 1623, 1651);

                f_10300_1623_1650(binders.Any());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 1665, 1702);

                f_10300_1665_1701(attributesToBind.Any());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 1716, 1758);

                f_10300_1716_1757((object)ownerSymbol != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 1772, 1828);

                f_10300_1772_1827(binders.Length == attributesToBind.Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 1842, 1890);

                f_10300_1842_1889(boundAttributeTypes != null);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 1915, 1920);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 1906, 2730) || true) && (i < attributesToBind.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 1951, 1954)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 1906, 2730))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 1906, 2730);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 2060, 2715) || true) && (boundAttributeTypes[i] is null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 2060, 2715);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 2136, 2160);

                            var
                            binder = binders[i]
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 2594, 2696);

                            boundAttributeTypes[i] = (NamedTypeSymbol)f_10300_2636_2690(binder, f_10300_2652_2676(attributesToBind[i]), diagnostics).Type;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 2060, 2715);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10300, 1, 825);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10300, 1, 825);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10300, 1391, 2741);

                int
                f_10300_1623_1650(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 1623, 1650);
                    return 0;
                }


                int
                f_10300_1665_1701(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 1665, 1701);
                    return 0;
                }


                int
                f_10300_1716_1757(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 1716, 1757);
                    return 0;
                }


                int
                f_10300_1772_1827(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 1772, 1827);
                    return 0;
                }


                int
                f_10300_1842_1889(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 1842, 1889);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10300_2652_2676(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 2652, 2676);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10300_2636_2690(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindType((Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax)syntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 2636, 2690);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10300, 1391, 2741);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10300, 1391, 2741);
            }
        }

        internal static void GetAttributes(
                    ImmutableArray<Binder> binders,
                    ImmutableArray<AttributeSyntax> attributesToBind,
                    ImmutableArray<NamedTypeSymbol> boundAttributeTypes,
                    CSharpAttributeData?[] attributesBuilder,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10300, 2833, 5199);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 3162, 3190);

                f_10300_3162_3189(binders.Any());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 3204, 3241);

                f_10300_3204_3240(attributesToBind.Any());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 3255, 3295);

                f_10300_3255_3294(boundAttributeTypes.Any());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 3309, 3365);

                f_10300_3309_3364(binders.Length == attributesToBind.Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 3379, 3447);

                f_10300_3379_3446(boundAttributeTypes.Length == attributesToBind.Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 3461, 3507);

                f_10300_3461_3506(attributesBuilder != null);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 3532, 3537);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 3523, 5188) || true) && (i < attributesToBind.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 3568, 3571)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 3523, 5188))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 3523, 5188);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 3605, 3659);

                        AttributeSyntax
                        attributeSyntax = attributesToBind[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 3677, 3737);

                        NamedTypeSymbol
                        boundAttributeType = boundAttributeTypes[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 3755, 3782);

                        Binder
                        binder = binders[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 3802, 3861);

                        var
                        attribute = (SourceAttributeData?)attributesBuilder[i]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 3879, 5173) || true) && (attribute == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 3879, 5173);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 3942, 4035);

                            attributesBuilder[i] = f_10300_3965_4034(binder, attributeSyntax, boundAttributeType, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 3879, 5173);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 3879, 5173);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 4631, 4666);

                            f_10300_4631_4665(f_10300_4644_4664_M(!attribute.HasErrors));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 4688, 4737);

                            f_10300_4688_4736(f_10300_4701_4725(attribute) is object);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 4759, 4810);

                            HashSet<DiagnosticInfo>?
                            useSiteDiagnostics = null
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 4832, 4979);

                            bool
                            isConditionallyOmitted = f_10300_4862_4978(binder, f_10300_4901_4925(attribute), f_10300_4927_4953(attributeSyntax), ref useSiteDiagnostics)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 5001, 5054);

                            f_10300_5001_5053(diagnostics, attributeSyntax, useSiteDiagnostics);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 5076, 5154);

                            attributesBuilder[i] = f_10300_5099_5153(attribute, isConditionallyOmitted);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 3879, 5173);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10300, 1, 1666);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10300, 1, 1666);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10300, 2833, 5199);

                int
                f_10300_3162_3189(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 3162, 3189);
                    return 0;
                }


                int
                f_10300_3204_3240(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 3204, 3240);
                    return 0;
                }


                int
                f_10300_3255_3294(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 3255, 3294);
                    return 0;
                }


                int
                f_10300_3309_3364(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 3309, 3364);
                    return 0;
                }


                int
                f_10300_3379_3446(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 3379, 3446);
                    return 0;
                }


                int
                f_10300_3461_3506(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 3461, 3506);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                f_10300_3965_4034(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                node, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                boundAttributeType, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.GetAttribute(node, boundAttributeType, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 3965, 4034);
                    return return_v;
                }


                bool
                f_10300_4644_4664_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 4644, 4664);
                    return return_v;
                }


                int
                f_10300_4631_4665(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 4631, 4665);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10300_4701_4725(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAttributeData
                this_param)
                {
                    var return_v = this_param.AttributeClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 4701, 4725);
                    return return_v;
                }


                int
                f_10300_4688_4736(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 4688, 4736);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10300_4901_4925(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAttributeData
                this_param)
                {
                    var return_v = this_param.AttributeClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 4901, 4925);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10300_4927_4953(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 4927, 4953);
                    return return_v;
                }


                bool
                f_10300_4862_4978(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                attributeType, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = this_param.IsAttributeConditionallyOmitted(attributeType, syntaxTree, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 4862, 4978);
                    return return_v;
                }


                bool
                f_10300_5001_5053(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                node, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add((Microsoft.CodeAnalysis.SyntaxNode)node, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 5001, 5053);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceAttributeData
                f_10300_5099_5153(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAttributeData
                this_param, bool
                isConditionallyOmitted)
                {
                    var return_v = this_param.WithOmittedCondition(isConditionallyOmitted);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 5099, 5153);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10300, 2833, 5199);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10300, 2833, 5199);
            }
        }

        internal CSharpAttributeData GetAttribute(AttributeSyntax node, NamedTypeSymbol boundAttributeType, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10300, 5274, 5643);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 5425, 5567);

                var
                boundAttribute = f_10300_5446_5566(f_10300_5446_5513(node, f_10300_5477_5506(this), this), node, boundAttributeType, diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 5583, 5632);

                return f_10300_5590_5631(this, boundAttribute, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10300, 5274, 5643);

                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10300_5477_5506(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.ContainingMemberOrLambda;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 5477, 5506);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder
                f_10300_5446_5513(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                root, Microsoft.CodeAnalysis.CSharp.Symbol?
                memberSymbol, Microsoft.CodeAnalysis.CSharp.Binder
                next)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder((Microsoft.CodeAnalysis.SyntaxNode)root, memberSymbol, next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 5446, 5513);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundAttribute
                f_10300_5446_5566(Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                node, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                attributeType, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindAttribute(node, attributeType, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 5446, 5566);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                f_10300_5590_5631(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundAttribute
                boundAttribute, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.GetAttribute(boundAttribute, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 5590, 5631);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10300, 5274, 5643);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10300, 5274, 5643);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal BoundAttribute BindAttribute(AttributeSyntax node, NamedTypeSymbol attributeType, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10300, 5655, 5896);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 5797, 5885);

                return f_10300_5804_5884(f_10300_5804_5832(this, node), node, attributeType, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10300, 5655, 5896);

                Microsoft.CodeAnalysis.CSharp.Binder
                f_10300_5804_5832(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                node)
                {
                    var return_v = this_param.GetRequiredBinder((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 5804, 5832);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundAttribute
                f_10300_5804_5884(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                node, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                attributeType, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindAttributeCore(node, attributeType, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 5804, 5884);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10300, 5655, 5896);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10300, 5655, 5896);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Binder SkipSemanticModelBinder()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10300, 5908, 6157);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 5973, 5994);

                Binder
                result = this
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 6010, 6116) || true) && (f_10300_6017_6045(result))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 6010, 6116);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 6079, 6101);

                        result = result.Next!;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 6010, 6116);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10300, 6010, 6116);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10300, 6010, 6116);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 6132, 6146);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10300, 5908, 6157);

                bool
                f_10300_6017_6045(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.IsSemanticModelBinder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 6017, 6045);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10300, 5908, 6157);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10300, 5908, 6157);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundAttribute BindAttributeCore(AttributeSyntax node, NamedTypeSymbol attributeType, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10300, 6169, 10371);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 6314, 6417);

                f_10300_6314_6416(f_10300_6327_6357(this) == f_10300_6361_6415(f_10300_6361_6389(this, node)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 6902, 6958);

                NamedTypeSymbol
                attributeTypeForBinding = attributeType
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 6972, 7026);

                LookupResultKind
                resultKind = LookupResultKind.Viable
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 7040, 7485) || true) && (f_10300_7044_7081(attributeTypeForBinding))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 7040, 7485);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 7115, 7172);

                    var
                    errorType = (ErrorTypeSymbol)attributeTypeForBinding
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 7190, 7224);

                    resultKind = f_10300_7203_7223(errorType);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 7242, 7470) || true) && (errorType.CandidateSymbols.Length == 1 && (DynAbs.Tracing.TraceSender.Expression_True(10300, 7246, 7336) && f_10300_7288_7314(errorType)[0] is NamedTypeSymbol))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 7242, 7470);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 7378, 7451);

                        attributeTypeForBinding = (NamedTypeSymbol)f_10300_7421_7447(errorType)[0];
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 7242, 7470);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 7040, 7485);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 7591, 7631);

                var
                argumentListOpt = f_10300_7613_7630(node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 7645, 7734);

                Binder
                attributeArgumentBinder = f_10300_7678_7733(this, BinderFlags.AttributeArgument)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 7748, 7897);

                AnalyzedAttributeArguments
                analyzedArguments = f_10300_7795_7896(attributeArgumentBinder, argumentListOpt, attributeTypeForBinding, diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 7913, 7964);

                HashSet<DiagnosticInfo>?
                useSiteDiagnostics = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 7978, 8024);

                ImmutableArray<int>
                argsToParamsOpt = default
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 8038, 8060);

                bool
                expanded = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 8074, 8116);

                MethodSymbol?
                attributeConstructor = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 8222, 9085) || true) && (!f_10300_8227_8264(attributeTypeForBinding))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 8222, 9085);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 8298, 9070);

                    attributeConstructor = f_10300_8321_9069(this, node, attributeTypeForBinding, analyzedArguments.ConstructorArguments, diagnostics, ref resultKind, suppressErrors: f_10300_8787_8814(attributeType), ref argsToParamsOpt, ref expanded, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 8222, 9085);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 9099, 9141);

                f_10300_9099_9140(diagnostics, node, useSiteDiagnostics);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 9157, 9632) || true) && (attributeConstructor is object)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 9157, 9632);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 9225, 9318);

                    f_10300_9225_9317(this, diagnostics, attributeConstructor, node, hasBaseReceiver: false);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 9338, 9617) || true) && (attributeConstructor.Parameters.Any(p => p.RefKind == RefKind.In))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 9338, 9617);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 9449, 9598);

                        f_10300_9449_9597(diagnostics, ErrorCode.ERR_AttributeCtorInParameter, node, f_10300_9514_9596(attributeConstructor, f_10300_9551_9595()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 9338, 9617);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 9157, 9632);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 9648, 9714);

                var
                constructorArguments = analyzedArguments.ConstructorArguments
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 9728, 9840);

                ImmutableArray<BoundExpression>
                boundConstructorArguments = f_10300_9788_9839(constructorArguments.Arguments)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 9854, 9944);

                ImmutableArray<string>
                boundConstructorArgumentNamesOpt = f_10300_9912_9943(constructorArguments)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 9958, 10045);

                ImmutableArray<BoundExpression>
                boundNamedArguments = analyzedArguments.NamedArguments
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 10059, 10087);

                f_10300_10059_10086(constructorArguments);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 10103, 10360);

                return f_10300_10110_10359(node, attributeConstructor, boundConstructorArguments, boundConstructorArgumentNamesOpt, argsToParamsOpt, expanded, boundNamedArguments, resultKind, attributeType, hasErrors: resultKind != LookupResultKind.Viable);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10300, 6169, 10371);

                Microsoft.CodeAnalysis.CSharp.Binder
                f_10300_6327_6357(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.SkipSemanticModelBinder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 6327, 6357);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10300_6361_6389(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                node)
                {
                    var return_v = this_param.GetRequiredBinder((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 6361, 6389);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10300_6361_6415(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.SkipSemanticModelBinder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 6361, 6415);
                    return return_v;
                }


                int
                f_10300_6314_6416(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 6314, 6416);
                    return 0;
                }


                bool
                f_10300_7044_7081(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 7044, 7081);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LookupResultKind
                f_10300_7203_7223(Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                this_param)
                {
                    var return_v = this_param.ResultKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 7203, 7223);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10300_7288_7314(Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                this_param)
                {
                    var return_v = this_param.CandidateSymbols;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 7288, 7314);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10300_7421_7447(Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                this_param)
                {
                    var return_v = this_param.CandidateSymbols;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 7421, 7447);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentListSyntax?
                f_10300_7613_7630(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.ArgumentList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 7613, 7630);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10300_7678_7733(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BinderFlags
                flags)
                {
                    var return_v = this_param.WithAdditionalFlags(flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 7678, 7733);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder.AnalyzedAttributeArguments
                f_10300_7795_7896(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentListSyntax?
                attributeArgumentList, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                attributeType, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindAttributeArguments(attributeArgumentList, attributeType, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 7795, 7896);
                    return return_v;
                }


                bool
                f_10300_8227_8264(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 8227, 8264);
                    return return_v;
                }


                bool
                f_10300_8787_8814(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 8787, 8814);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10300_8321_9069(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                node, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                attributeType, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                boundConstructorArguments, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, ref Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, bool
                suppressErrors, ref System.Collections.Immutable.ImmutableArray<int>
                argsToParamsOpt, ref bool
                expanded, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = this_param.BindAttributeConstructor(node, attributeType, boundConstructorArguments, diagnostics, ref resultKind, suppressErrors: suppressErrors, ref argsToParamsOpt, ref expanded, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 8321, 9069);
                    return return_v;
                }


                bool
                f_10300_9099_9140(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                node, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add((Microsoft.CodeAnalysis.SyntaxNode)node, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 9099, 9140);
                    return return_v;
                }


                int
                f_10300_9225_9317(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                node, bool
                hasBaseReceiver)
                {
                    this_param.ReportDiagnosticsIfObsolete(diagnostics, (Microsoft.CodeAnalysis.CSharp.Symbol)symbol, (Microsoft.CodeAnalysis.SyntaxNode)node, hasBaseReceiver: hasBaseReceiver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 9225, 9317);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolDisplayFormat
                f_10300_9551_9595()
                {
                    var return_v = SymbolDisplayFormat.CSharpErrorMessageFormat;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 9551, 9595);
                    return return_v;
                }


                string
                f_10300_9514_9596(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, Microsoft.CodeAnalysis.SymbolDisplayFormat
                format)
                {
                    var return_v = this_param.ToDisplayString(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 9514, 9596);
                    return return_v;
                }


                int
                f_10300_9449_9597(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 9449, 9597);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10300_9788_9839(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 9788, 9839);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_10300_9912_9943(Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                this_param)
                {
                    var return_v = this_param.GetNames();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 9912, 9943);
                    return return_v;
                }


                int
                f_10300_10059_10086(Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 10059, 10086);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundAttribute
                f_10300_10110_10359(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                constructor, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                constructorArguments, System.Collections.Immutable.ImmutableArray<string>
                constructorArgumentNamesOpt, System.Collections.Immutable.ImmutableArray<int>
                constructorArgumentsToParamsOpt, bool
                constructorExpanded, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                namedArguments, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundAttribute((Microsoft.CodeAnalysis.SyntaxNode)syntax, constructor, constructorArguments, constructorArgumentNamesOpt, constructorArgumentsToParamsOpt, constructorExpanded, namedArguments, resultKind, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, hasErrors: hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 10110, 10359);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10300, 6169, 10371);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10300, 6169, 10371);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private CSharpAttributeData GetAttribute(BoundAttribute boundAttribute, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10300, 10383, 13372);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 10506, 10563);

                var
                attributeType = (NamedTypeSymbol)f_10300_10543_10562(boundAttribute)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 10577, 10631);

                var
                attributeConstructor = f_10300_10604_10630(boundAttribute)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 10647, 10697);

                f_10300_10647_10696((object)attributeType != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 10711, 10778);

                f_10300_10711_10777(f_10300_10724_10752(boundAttribute.Syntax) == SyntaxKind.Attribute);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 10794, 10883);

                f_10300_10794_10882(this, boundAttribute, boundAttribute.Syntax, diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 10899, 10944);

                bool
                hasErrors = f_10300_10916_10943(boundAttribute)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 10960, 11309) || true) && (f_10300_10964_10991(attributeType) || (DynAbs.Tracing.TraceSender.Expression_False(10300, 10964, 11019) || f_10300_10995_11019(attributeType)) || (DynAbs.Tracing.TraceSender.Expression_False(10300, 10964, 11051) || attributeConstructor is null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 10960, 11309);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 11135, 11159);

                    f_10300_11135_11158(hasErrors);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 11177, 11294);

                    return f_10300_11184_11293(f_10300_11208_11244(boundAttribute.Syntax), attributeType, attributeConstructor, hasErrors);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 10960, 11309);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 11419, 11562);

                f_10300_11419_11561(this, f_10300_11454_11485(attributeConstructor), f_10300_11487_11532(((AttributeSyntax)boundAttribute.Syntax)), diagnostics, ref hasErrors);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 11686, 11737);

                var
                visitor = f_10300_11700_11736(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 11751, 11803);

                var
                arguments = f_10300_11767_11802(boundAttribute)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 11817, 11906);

                var
                constructorArgsArray = visitor.VisitArguments(arguments, diagnostics, ref hasErrors)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 11920, 12028);

                var
                namedArguments = visitor.VisitNamedArguments(f_10300_11969_11998(boundAttribute), diagnostics, ref hasErrors)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 12044, 12120);

                f_10300_12044_12119(f_10300_12057_12088_M(!constructorArgsArray.IsDefault), "Property of VisitArguments");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 12136, 12190);

                ImmutableArray<int>
                constructorArgumentsSourceIndices
                = default(ImmutableArray<int>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 12204, 12255);

                ImmutableArray<TypedConstant>
                constructorArguments
                = default(ImmutableArray<TypedConstant>);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 12269, 12849) || true) && (hasErrors || (DynAbs.Tracing.TraceSender.Expression_False(10300, 12273, 12326) || f_10300_12286_12321(attributeConstructor) == 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 12269, 12849);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 12360, 12425);

                    constructorArgumentsSourceIndices = default(ImmutableArray<int>);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 12443, 12487);

                    constructorArguments = constructorArgsArray;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 12269, 12849);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 12269, 12849);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 12553, 12834);

                    constructorArguments = f_10300_12576_12833(this, out constructorArgumentsSourceIndices, attributeConstructor, constructorArgsArray, f_10300_12722_12764(boundAttribute), boundAttribute.Syntax, diagnostics, ref hasErrors);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 12269, 12849);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 12865, 12916);

                HashSet<DiagnosticInfo>?
                useSiteDiagnostics = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 12930, 13058);

                bool
                isConditionallyOmitted = f_10300_12960_13057(this, attributeType, f_10300_13007_13032(boundAttribute), ref useSiteDiagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 13072, 13131);

                f_10300_13072_13130(diagnostics, boundAttribute.Syntax, useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 13147, 13361);

                return f_10300_13154_13360(f_10300_13178_13214(boundAttribute.Syntax), attributeType, attributeConstructor, constructorArguments, constructorArgumentsSourceIndices, namedArguments, hasErrors, isConditionallyOmitted);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10300, 10383, 13372);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10300_10543_10562(Microsoft.CodeAnalysis.CSharp.BoundAttribute
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 10543, 10562);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10300_10604_10630(Microsoft.CodeAnalysis.CSharp.BoundAttribute
                this_param)
                {
                    var return_v = this_param.Constructor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 10604, 10630);
                    return return_v;
                }


                int
                f_10300_10647_10696(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 10647, 10696);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10300_10724_10752(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 10724, 10752);
                    return return_v;
                }


                int
                f_10300_10711_10777(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 10711, 10777);
                    return 0;
                }


                int
                f_10300_10794_10882(Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.CSharp.BoundAttribute
                node, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    NullableWalker.AnalyzeIfNeeded(binder, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, syntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 10794, 10882);
                    return 0;
                }


                bool
                f_10300_10916_10943(Microsoft.CodeAnalysis.CSharp.BoundAttribute
                this_param)
                {
                    var return_v = this_param.HasAnyErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 10916, 10943);
                    return return_v;
                }


                bool
                f_10300_10964_10991(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 10964, 10991);
                    return return_v;
                }


                bool
                f_10300_10995_11019(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsAbstract;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 10995, 11019);
                    return return_v;
                }


                int
                f_10300_11135_11158(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 11135, 11158);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxReference
                f_10300_11208_11244(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.GetReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 11208, 11244);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceAttributeData
                f_10300_11184_11293(Microsoft.CodeAnalysis.SyntaxReference
                applicationNode, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                attributeClass, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                attributeConstructor, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SourceAttributeData(applicationNode, attributeClass, attributeConstructor, hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 11184, 11293);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10300_11454_11485(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 11454, 11485);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10300_11487_11532(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 11487, 11532);
                    return return_v;
                }


                int
                f_10300_11419_11561(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, ref bool
                hasErrors)
                {
                    this_param.ValidateTypeForAttributeParameters(parameters, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, diagnostics, ref hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 11419, 11561);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Binder.AttributeExpressionVisitor
                f_10300_11700_11736(Microsoft.CodeAnalysis.CSharp.Binder
                binder)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Binder.AttributeExpressionVisitor(binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 11700, 11736);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10300_11767_11802(Microsoft.CodeAnalysis.CSharp.BoundAttribute
                this_param)
                {
                    var return_v = this_param.ConstructorArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 11767, 11802);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10300_11969_11998(Microsoft.CodeAnalysis.CSharp.BoundAttribute
                this_param)
                {
                    var return_v = this_param.NamedArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 11969, 11998);
                    return return_v;
                }


                bool
                f_10300_12057_12088_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 12057, 12088);
                    return return_v;
                }


                int
                f_10300_12044_12119(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 12044, 12119);
                    return 0;
                }


                int
                f_10300_12286_12321(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 12286, 12321);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_10300_12722_12764(Microsoft.CodeAnalysis.CSharp.BoundAttribute
                this_param)
                {
                    var return_v = this_param.ConstructorArgumentNamesOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 12722, 12764);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10300_12576_12833(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, out System.Collections.Immutable.ImmutableArray<int>
                constructorArgumentsSourceIndices, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                attributeConstructor, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                constructorArgsArray, System.Collections.Immutable.ImmutableArray<string>
                constructorArgumentNamesOpt, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, ref bool
                hasErrors)
                {
                    var return_v = this_param.GetRewrittenAttributeConstructorArguments(out constructorArgumentsSourceIndices, attributeConstructor, constructorArgsArray, constructorArgumentNamesOpt, (Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax)syntax, diagnostics, ref hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 12576, 12833);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree?
                f_10300_13007_13032(Microsoft.CodeAnalysis.CSharp.BoundAttribute
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 13007, 13032);
                    return return_v;
                }


                bool
                f_10300_12960_13057(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                attributeType, Microsoft.CodeAnalysis.SyntaxTree?
                syntaxTree, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = this_param.IsAttributeConditionallyOmitted(attributeType, syntaxTree, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 12960, 13057);
                    return return_v;
                }


                bool
                f_10300_13072_13130(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.SyntaxNode
                node, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add(node, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 13072, 13130);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxReference
                f_10300_13178_13214(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.GetReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 13178, 13214);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceAttributeData
                f_10300_13154_13360(Microsoft.CodeAnalysis.SyntaxReference
                applicationNode, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                attributeClass, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                attributeConstructor, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                constructorArguments, System.Collections.Immutable.ImmutableArray<int>
                constructorArgumentsSourceIndices, System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
                namedArguments, bool
                hasErrors, bool
                isConditionallyOmitted)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SourceAttributeData(applicationNode, attributeClass, attributeConstructor, constructorArguments, constructorArgumentsSourceIndices, namedArguments, hasErrors, isConditionallyOmitted);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 13154, 13360);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10300, 10383, 13372);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10300, 10383, 13372);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void ValidateTypeForAttributeParameters(ImmutableArray<ParameterSymbol> parameters, CSharpSyntaxNode syntax, DiagnosticBag diagnostics, ref bool hasErrors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10300, 13384, 14042);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 13572, 14031);
                    foreach (var parameter in f_10300_13598_13608_I(parameters))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 13572, 14031);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 13642, 13688);

                        var
                        paramType = f_10300_13658_13687(parameter)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 13706, 13738);

                        f_10300_13706_13737(paramType.HasType);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 13758, 14016) || true) && (!f_10300_13763_13820(paramType.Type, f_10300_13808_13819()))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 13758, 14016);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 13862, 13958);

                            f_10300_13862_13957(diagnostics, ErrorCode.ERR_BadAttributeParamType, syntax, f_10300_13926_13940(parameter), paramType.Type);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 13980, 13997);

                            hasErrors = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 13758, 14016);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 13572, 14031);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10300, 1, 460);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10300, 1, 460);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10300, 13384, 14042);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10300_13658_13687(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 13658, 13687);
                    return return_v;
                }


                int
                f_10300_13706_13737(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 13706, 13737);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10300_13808_13819()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 13808, 13819);
                    return return_v;
                }


                bool
                f_10300_13763_13820(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = type.IsValidAttributeParameterType(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 13763, 13820);
                    return return_v;
                }


                string
                f_10300_13926_13940(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 13926, 13940);
                    return return_v;
                }


                int
                f_10300_13862_13957(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 13862, 13957);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10300_13598_13608_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 13598, 13608);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10300, 13384, 14042);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10300, 13384, 14042);
            }
        }

        protected bool IsAttributeConditionallyOmitted(NamedTypeSymbol attributeType, SyntaxTree? syntaxTree, ref HashSet<DiagnosticInfo>? useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10300, 14054, 15580);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 14520, 14608) || true) && (f_10300_14524_14546())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 14520, 14608);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 14580, 14593);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 14520, 14608);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 14624, 14668);

                f_10300_14624_14667((object)attributeType != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 14682, 14725);

                f_10300_14682_14724(!f_10300_14696_14723(attributeType));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 14741, 15569) || true) && (f_10300_14745_14772(attributeType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 14741, 15569);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 14806, 14895);

                    ImmutableArray<string>
                    conditionalSymbols = f_10300_14850_14894(attributeType)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 14913, 14954);

                    f_10300_14913_14953(conditionalSymbols != null);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 14972, 15111) || true) && (syntaxTree.IsAnyPreprocessorSymbolDefined(conditionalSymbols))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 14972, 15111);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 15079, 15092);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 14972, 15111);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 15131, 15225);

                    var
                    baseType = f_10300_15146_15224(attributeType, ref useSiteDiagnostics)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 15243, 15443) || true) && ((object)baseType != null && (DynAbs.Tracing.TraceSender.Expression_True(10300, 15247, 15297) && f_10300_15275_15297(baseType)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 15243, 15443);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 15339, 15424);

                        return f_10300_15346_15423(this, baseType, syntaxTree, ref useSiteDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 15243, 15443);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 15463, 15475);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 14741, 15569);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 14741, 15569);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 15541, 15554);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 14741, 15569);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10300, 14054, 15580);

                bool
                f_10300_14524_14546()
                {
                    var return_v = IsEarlyAttributeBinder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 14524, 14546);
                    return return_v;
                }


                int
                f_10300_14624_14667(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 14624, 14667);
                    return 0;
                }


                bool
                f_10300_14696_14723(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 14696, 14723);
                    return return_v;
                }


                int
                f_10300_14682_14724(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 14682, 14724);
                    return 0;
                }


                bool
                f_10300_14745_14772(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsConditional;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 14745, 14772);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_10300_14850_14894(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetAppliedConditionalSymbols();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 14850, 14894);
                    return return_v;
                }


                int
                f_10300_14913_14953(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 14913, 14953);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10300_15146_15224(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = this_param.BaseTypeWithDefinitionUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 15146, 15224);
                    return return_v;
                }


                bool
                f_10300_15275_15297(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsConditional;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 15275, 15297);
                    return return_v;
                }


                bool
                f_10300_15346_15423(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                attributeType, Microsoft.CodeAnalysis.SyntaxTree?
                syntaxTree, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.IsAttributeConditionallyOmitted(attributeType, syntaxTree, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 15346, 15423);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10300, 14054, 15580);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10300, 14054, 15580);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private AnalyzedAttributeArguments BindAttributeArguments(
                    AttributeArgumentListSyntax? attributeArgumentList,
                    NamedTypeSymbol attributeType,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10300, 15748, 19090);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 15980, 16044);

                var
                boundConstructorArguments = f_10300_16012_16043()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 16058, 16122);

                var
                boundNamedArguments = ImmutableArray<BoundExpression>.Empty
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 16138, 18977) || true) && (attributeArgumentList != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 16138, 18977);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 16205, 16270);

                    ArrayBuilder<BoundExpression>?
                    boundNamedArgumentsBuilder = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 16288, 16335);

                    HashSet<string>?
                    boundNamedArgumentsSet = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 16501, 16534);

                    bool
                    hadLangVersionError = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 16554, 16581);

                    var
                    shouldHaveName = false
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 16601, 18773);
                        foreach (var argument in f_10300_16626_16657_I(f_10300_16626_16657(attributeArgumentList)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 16601, 18773);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 16699, 18754) || true) && (f_10300_16703_16722(argument) == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 16699, 18754);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 16780, 16971) || true) && (shouldHaveName)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 16780, 16971);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 16856, 16944);

                                    f_10300_16856_16943(diagnostics, ErrorCode.ERR_NamedArgumentExpected, f_10300_16909_16942(f_10300_16909_16928(argument)));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 16780, 16971);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 17048, 17488);

                                f_10300_17048_17487(
                                                        // Constructor argument
                                                        this, boundConstructorArguments, diagnostics, ref hadLangVersionError, argument, f_10300_17294_17385(this, diagnostics, f_10300_17330_17349(argument), RefKind.None, allowArglist: false), f_10300_17416_17434(argument), refKind: RefKind.None);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 16699, 18754);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 16699, 18754);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 17586, 17608);

                                shouldHaveName = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 17776, 17845);

                                string
                                argumentName = f_10300_17798_17822(f_10300_17798_17817(argument)).Identifier.ValueText!
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 17871, 18457) || true) && (boundNamedArgumentsBuilder == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 17871, 18457);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 17967, 18040);

                                    boundNamedArgumentsBuilder = f_10300_17996_18039();
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 18070, 18117);

                                    boundNamedArgumentsSet = f_10300_18095_18116();
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 17871, 18457);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 17871, 18457);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 18175, 18457) || true) && (f_10300_18179_18225(boundNamedArgumentsSet!, argumentName))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 18175, 18457);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 18340, 18430);

                                        f_10300_18340_18429(diagnostics, ErrorCode.ERR_DuplicateNamedAttributeArgument, argument, argumentName);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 18175, 18457);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 17871, 18457);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 18485, 18587);

                                BoundExpression
                                boundNamedArgument = f_10300_18522_18586(this, argument, attributeType, diagnostics)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 18613, 18664);

                                f_10300_18613_18663(boundNamedArgumentsBuilder, boundNamedArgument);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 18690, 18731);

                                f_10300_18690_18730(boundNamedArgumentsSet, argumentName);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 16699, 18754);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 16601, 18773);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10300, 1, 2173);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10300, 1, 2173);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 18793, 18962) || true) && (boundNamedArgumentsBuilder != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 18793, 18962);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 18873, 18943);

                        boundNamedArguments = f_10300_18895_18942(boundNamedArgumentsBuilder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 18793, 18962);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 16138, 18977);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 18993, 19079);

                return f_10300_19000_19078(boundConstructorArguments, boundNamedArguments);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10300, 15748, 19090);

                Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                f_10300_16012_16043()
                {
                    var return_v = AnalyzedArguments.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 16012, 16043);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax>
                f_10300_16626_16657(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentListSyntax
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 16626, 16657);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax?
                f_10300_16703_16722(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax
                this_param)
                {
                    var return_v = this_param.NameEquals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 16703, 16722);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10300_16909_16928(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 16909, 16928);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10300_16909_16942(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.GetLocation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 16909, 16942);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10300_16856_16943(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 16856, 16943);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10300_17330_17349(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 17330, 17349);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10300_17294_17385(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                argumentExpression, Microsoft.CodeAnalysis.RefKind
                refKind, bool
                allowArglist)
                {
                    var return_v = this_param.BindArgumentExpression(diagnostics, argumentExpression, refKind, allowArglist: allowArglist);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 17294, 17385);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameColonSyntax?
                f_10300_17416_17434(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax
                this_param)
                {
                    var return_v = this_param.NameColon;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 17416, 17434);
                    return return_v;
                }


                int
                f_10300_17048_17487(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                result, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, ref bool
                hadLangVersionError, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax
                argumentSyntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                boundArgumentExpression, Microsoft.CodeAnalysis.CSharp.Syntax.NameColonSyntax?
                nameColonSyntax, Microsoft.CodeAnalysis.RefKind
                refKind)
                {
                    this_param.BindArgumentAndName(result, diagnostics, ref hadLangVersionError, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)argumentSyntax, boundArgumentExpression, nameColonSyntax, refKind: refKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 17048, 17487);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax
                f_10300_17798_17817(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax
                this_param)
                {
                    var return_v = this_param.NameEquals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 17798, 17817);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                f_10300_17798_17822(Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 17798, 17822);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10300_17996_18039()
                {
                    var return_v = ArrayBuilder<BoundExpression>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 17996, 18039);
                    return return_v;
                }


                System.Collections.Generic.HashSet<string>
                f_10300_18095_18116()
                {
                    var return_v = new System.Collections.Generic.HashSet<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 18095, 18116);
                    return return_v;
                }


                bool
                f_10300_18179_18225(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 18179, 18225);
                    return return_v;
                }


                int
                f_10300_18340_18429(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 18340, 18429);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10300_18522_18586(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax
                namedArgument, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                attributeType, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindNamedAttributeArgument(namedArgument, attributeType, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 18522, 18586);
                    return return_v;
                }


                int
                f_10300_18613_18663(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 18613, 18663);
                    return 0;
                }


                bool
                f_10300_18690_18730(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 18690, 18730);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax>
                f_10300_16626_16657_I(Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 16626, 16657);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10300_18895_18942(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 18895, 18942);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder.AnalyzedAttributeArguments
                f_10300_19000_19078(Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                constructorArguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                namedArguments)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Binder.AnalyzedAttributeArguments(constructorArguments, namedArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 19000, 19078);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10300, 15748, 19090);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10300, 15748, 19090);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression BindNamedAttributeArgument(AttributeArgumentSyntax namedArgument, NamedTypeSymbol attributeType, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10300, 19102, 22763);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 19274, 19288);

                bool
                wasError
                = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 19302, 19330);

                LookupResultKind
                resultKind
                = default(LookupResultKind);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 19344, 19481);

                Symbol
                namedArgumentNameSymbol = f_10300_19377_19480(this, namedArgument, attributeType, diagnostics, out wasError, out resultKind)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 19497, 19602);

                f_10300_19497_19601(this, diagnostics, namedArgumentNameSymbol, namedArgument, hasBaseReceiver: false);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 19618, 20421) || true) && (f_10300_19622_19650(namedArgumentNameSymbol) == SymbolKind.Property)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 19618, 20421);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 19707, 19768);

                    var
                    propertySymbol = (PropertySymbol)namedArgumentNameSymbol
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 19786, 19846);

                    var
                    setMethod = f_10300_19802_19845(propertySymbol)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 19864, 20406) || true) && (setMethod != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 19864, 20406);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 19927, 20018);

                        f_10300_19927_20017(this, diagnostics, setMethod, namedArgument, hasBaseReceiver: false);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 20042, 20387) || true) && (f_10300_20046_20066(setMethod) && (DynAbs.Tracing.TraceSender.Expression_True(10300, 20046, 20120) && f_10300_20070_20100(setMethod) != f_10300_20104_20120(this)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 20042, 20387);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 20273, 20364);

                            f_10300_20273_20363(namedArgument, MessageID.IDS_FeatureInitOnlySetters, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 20042, 20387);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 19864, 20406);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 19618, 20421);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 20437, 20501);

                f_10300_20437_20500(resultKind == LookupResultKind.Viable || (DynAbs.Tracing.TraceSender.Expression_False(10300, 20450, 20499) || wasError));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 20517, 20546);

                TypeSymbol
                namedArgumentType
                = default(TypeSymbol);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 20560, 20880) || true) && (wasError)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 20560, 20880);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 20606, 20644);

                    namedArgumentType = f_10300_20626_20643(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 20560, 20880);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 20560, 20880);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 20746, 20865);

                    namedArgumentType = f_10300_20766_20864(this, namedArgument, namedArgumentNameSymbol, attributeType, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 20560, 20880);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 21101, 21214);

                BoundExpression
                namedArgumentValue = f_10300_21138_21213(this, f_10300_21153_21177(namedArgument), diagnostics, BindValueKind.RValue)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 21228, 21333);

                namedArgumentValue = f_10300_21249_21332(this, namedArgumentType, namedArgumentValue, diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 21431, 21488);

                var
                fieldSymbol = namedArgumentNameSymbol as FieldSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 21502, 21557);

                f_10300_21502_21556(f_10300_21521_21545(namedArgument) is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 21571, 21635);

                IdentifierNameSyntax
                nameSyntax = f_10300_21605_21634(f_10300_21605_21629(namedArgument))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 21649, 21672);

                BoundExpression
                lvalue
                = default(BoundExpression);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 21686, 22639) || true) && (fieldSymbol is object)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 21686, 22639);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 21745, 21825);

                    var
                    containingAssembly = f_10300_21770_21800(fieldSymbol) as SourceAssemblySymbol
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 21948, 22022);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(containingAssembly, 10300, 21948, 22021)?.NoteFieldAccess(fieldSymbol, read: true, write: true), 10300, 21967, 22021);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 22042, 22161);

                    lvalue = f_10300_22051_22160(nameSyntax, null, fieldSymbol, ConstantValue.NotAvailable, resultKind, f_10300_22143_22159(fieldSymbol));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 21686, 22639);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 21686, 22639);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 22227, 22290);

                    var
                    propertySymbol = namedArgumentNameSymbol as PropertySymbol
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 22308, 22624) || true) && (propertySymbol is object)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 22308, 22624);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 22378, 22476);

                        lvalue = f_10300_22387_22475(nameSyntax, null, propertySymbol, resultKind, namedArgumentType);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 22308, 22624);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 22308, 22624);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 22558, 22605);

                        lvalue = f_10300_22567_22604(this, nameSyntax, resultKind);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 22308, 22624);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 21686, 22639);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 22655, 22752);

                return f_10300_22662_22751(namedArgument, lvalue, namedArgumentValue, namedArgumentType);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10300, 19102, 22763);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10300_19377_19480(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax
                namedArgument, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                attributeType, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out bool
                wasError, out Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind)
                {
                    var return_v = this_param.BindNamedAttributeArgumentName(namedArgument, attributeType, diagnostics, out wasError, out resultKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 19377, 19480);
                    return return_v;
                }


                int
                f_10300_19497_19601(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax
                node, bool
                hasBaseReceiver)
                {
                    this_param.ReportDiagnosticsIfObsolete(diagnostics, symbol, (Microsoft.CodeAnalysis.SyntaxNode)node, hasBaseReceiver: hasBaseReceiver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 19497, 19601);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10300_19622_19650(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 19622, 19650);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10300_19802_19845(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                property)
                {
                    var return_v = property.GetOwnOrInheritedSetMethod();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 19802, 19845);
                    return return_v;
                }


                int
                f_10300_19927_20017(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax
                node, bool
                hasBaseReceiver)
                {
                    this_param.ReportDiagnosticsIfObsolete(diagnostics, (Microsoft.CodeAnalysis.CSharp.Symbol)symbol, (Microsoft.CodeAnalysis.SyntaxNode)node, hasBaseReceiver: hasBaseReceiver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 19927, 20017);
                    return 0;
                }


                bool
                f_10300_20046_20066(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsInitOnly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 20046, 20066);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10300_20070_20100(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 20070, 20100);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10300_20104_20120(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 20104, 20120);
                    return return_v;
                }


                bool
                f_10300_20273_20363(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.MessageID
                feature, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = CheckFeatureAvailability((Microsoft.CodeAnalysis.SyntaxNode)syntax, feature, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 20273, 20363);
                    return return_v;
                }


                int
                f_10300_20437_20500(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 20437, 20500);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10300_20626_20643(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.CreateErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 20626, 20643);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10300_20766_20864(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax
                namedArgument, Microsoft.CodeAnalysis.CSharp.Symbol
                namedArgumentNameSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                attributeType, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindNamedAttributeArgumentType(namedArgument, namedArgumentNameSymbol, attributeType, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 20766, 20864);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10300_21153_21177(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 21153, 21177);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10300_21138_21213(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                valueKind)
                {
                    var return_v = this_param.BindValue(node, diagnostics, valueKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 21138, 21213);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10300_21249_21332(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                targetType, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.GenerateConversionForAssignment(targetType, expression, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 21249, 21332);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax?
                f_10300_21521_21545(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax
                this_param)
                {
                    var return_v = this_param.NameEquals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 21521, 21545);
                    return return_v;
                }


                int
                f_10300_21502_21556(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 21502, 21556);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax
                f_10300_21605_21629(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax
                this_param)
                {
                    var return_v = this_param.NameEquals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 21605, 21629);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                f_10300_21605_21634(Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 21605, 21634);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10300_21770_21800(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 21770, 21800);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10300_22143_22159(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 22143, 22159);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                f_10300_22051_22160(Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                fieldSymbol, Microsoft.CodeAnalysis.ConstantValue
                constantValueOpt, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundFieldAccess((Microsoft.CodeAnalysis.SyntaxNode)syntax, receiver, fieldSymbol, constantValueOpt, resultKind, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 22051, 22160);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
                f_10300_22387_22475(Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                propertySymbol, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess((Microsoft.CodeAnalysis.SyntaxNode)syntax, receiverOpt, propertySymbol, resultKind, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 22387, 22475);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBadExpression
                f_10300_22567_22604(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                lookupResultKind)
                {
                    var return_v = this_param.BadExpression((Microsoft.CodeAnalysis.SyntaxNode)syntax, lookupResultKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 22567, 22604);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                f_10300_22662_22751(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator((Microsoft.CodeAnalysis.SyntaxNode)syntax, left, right, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 22662, 22751);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10300, 19102, 22763);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10300, 19102, 22763);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Symbol BindNamedAttributeArgumentName(AttributeArgumentSyntax namedArgument, NamedTypeSymbol attributeType, DiagnosticBag diagnostics, out bool wasError, out LookupResultKind resultKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10300, 22775, 23703);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 22994, 23049);

                f_10300_22994_23048(f_10300_23013_23037(namedArgument) is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 23063, 23114);

                var
                identifierName = f_10300_23084_23113(f_10300_23084_23108(namedArgument))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 23128, 23175);

                var
                name = identifierName.Identifier.ValueText
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 23189, 23238);

                LookupResult
                result = f_10300_23211_23237()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 23252, 23303);

                HashSet<DiagnosticInfo>?
                useSiteDiagnostics = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 23317, 23404);

                f_10300_23317_23403(this, result, attributeType, name, 0, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 23418, 23470);

                f_10300_23418_23469(diagnostics, identifierName, useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 23484, 23591);

                Symbol
                resultSymbol = f_10300_23506_23590(this, result, name, 0, identifierName, diagnostics, false, out wasError)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 23605, 23630);

                resultKind = f_10300_23618_23629(result);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 23644, 23658);

                f_10300_23644_23657(result);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 23672, 23692);

                return resultSymbol;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10300, 22775, 23703);

                Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax?
                f_10300_23013_23037(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax
                this_param)
                {
                    var return_v = this_param.NameEquals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 23013, 23037);
                    return return_v;
                }


                int
                f_10300_22994_23048(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 22994, 23048);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax
                f_10300_23084_23108(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax
                this_param)
                {
                    var return_v = this_param.NameEquals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 23084, 23108);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                f_10300_23084_23113(Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 23084, 23113);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LookupResult
                f_10300_23211_23237()
                {
                    var return_v = LookupResult.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 23211, 23237);
                    return return_v;
                }


                int
                f_10300_23317_23403(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.LookupResult
                result, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                nsOrType, string
                name, int
                arity, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    this_param.LookupMembersWithFallback(result, (Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol)nsOrType, name, arity, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 23317, 23403);
                    return 0;
                }


                bool
                f_10300_23418_23469(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                node, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add((Microsoft.CodeAnalysis.SyntaxNode)node, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 23418, 23469);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10300_23506_23590(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.LookupResult
                result, string
                simpleName, int
                arity, Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                where, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                suppressUseSiteDiagnostics, out bool
                wasError)
                {
                    var return_v = this_param.ResultSymbol(result, simpleName, arity, (Microsoft.CodeAnalysis.SyntaxNode)where, diagnostics, suppressUseSiteDiagnostics, out wasError);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 23506, 23590);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LookupResultKind
                f_10300_23618_23629(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 23618, 23629);
                    return return_v;
                }


                int
                f_10300_23644_23657(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 23644, 23657);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10300, 22775, 23703);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10300, 22775, 23703);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private TypeSymbol BindNamedAttributeArgumentType(AttributeArgumentSyntax namedArgument, Symbol namedArgumentNameSymbol, NamedTypeSymbol attributeType, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10300, 23715, 27524);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 23918, 24066) || true) && (f_10300_23922_23950(namedArgumentNameSymbol) == SymbolKind.ErrorType)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 23918, 24066);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 24008, 24051);

                    return (TypeSymbol)namedArgumentNameSymbol;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 23918, 24066);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 24469, 24503);

                bool
                invalidNamedArgument = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 24517, 24554);

                TypeSymbol?
                namedArgumentType = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 24568, 24664);

                invalidNamedArgument |= (f_10300_24593_24638(namedArgumentNameSymbol) != Accessibility.Public);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 24678, 24735);

                invalidNamedArgument |= f_10300_24702_24734(namedArgumentNameSymbol);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 24751, 26345) || true) && (!invalidNamedArgument)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 24751, 26345);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 24810, 26330);

                    switch (f_10300_24818_24846(namedArgumentNameSymbol))
                    {

                        case SymbolKind.Field:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 24810, 26330);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 24936, 24991);

                            var
                            fieldSymbol = (FieldSymbol)namedArgumentNameSymbol
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 25017, 25054);

                            namedArgumentType = f_10300_25037_25053(fieldSymbol);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 25080, 25127);

                            invalidNamedArgument |= f_10300_25104_25126(fieldSymbol);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 25153, 25197);

                            invalidNamedArgument |= f_10300_25177_25196(fieldSymbol);
                            DynAbs.Tracing.TraceSender.TraceBreak(10300, 25223, 25229);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 24810, 26330);

                        case SymbolKind.Property:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 24810, 26330);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 25304, 25415);

                            var
                            propertySymbol = f_10300_25325_25414(((PropertySymbol)namedArgumentNameSymbol), f_10300_25394_25413(this))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 25441, 25481);

                            namedArgumentType = f_10300_25461_25480(propertySymbol);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 25507, 25557);

                            invalidNamedArgument |= f_10300_25531_25556(propertySymbol);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 25583, 25624);

                            var
                            getMethod = f_10300_25599_25623(propertySymbol)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 25650, 25691);

                            var
                            setMethod = f_10300_25666_25690(propertySymbol)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 25717, 25819);

                            invalidNamedArgument = invalidNamedArgument || (DynAbs.Tracing.TraceSender.Expression_False(10300, 25740, 25789) || (object)getMethod == null) || (DynAbs.Tracing.TraceSender.Expression_False(10300, 25740, 25818) || (object)setMethod == null);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 25845, 26161) || true) && (!invalidNamedArgument)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 25845, 26161);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 25928, 26134);

                                invalidNamedArgument =
                                f_10300_25984_26016(getMethod!) != Accessibility.Public || (DynAbs.Tracing.TraceSender.Expression_False(10300, 25984, 26133) || f_10300_26077_26109(setMethod!) != Accessibility.Public);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 25845, 26161);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(10300, 26187, 26193);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 24810, 26330);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 24810, 26330);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 26251, 26279);

                            invalidNamedArgument = true;
                            DynAbs.Tracing.TraceSender.TraceBreak(10300, 26305, 26311);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 24810, 26330);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 24751, 26345);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 26361, 26854) || true) && (invalidNamedArgument)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 26361, 26854);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 26419, 26474);

                    f_10300_26419_26473(f_10300_26438_26462(namedArgument) is object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 26492, 26839);

                    return f_10300_26499_26838(attributeType, namedArgumentNameSymbol, LookupResultKind.NotAVariable, f_10300_26661_26837(diagnostics, ErrorCode.ERR_BadNamedAttributeArgument, f_10300_26743_26781(f_10300_26743_26772(f_10300_26743_26767(namedArgument))), f_10300_26808_26836(namedArgumentNameSymbol)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 26361, 26854);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 26870, 26918);

                f_10300_26870_26917(namedArgumentType is object);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 26934, 27472) || true) && (!f_10300_26939_26999(namedArgumentType, f_10300_26987_26998()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 26934, 27472);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 27033, 27088);

                    f_10300_27033_27087(f_10300_27052_27076(namedArgument) is object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 27106, 27457);

                    return f_10300_27113_27456(attributeType, namedArgumentNameSymbol, LookupResultKind.NotAVariable, f_10300_27275_27455(diagnostics, ErrorCode.ERR_BadNamedAttributeArgumentType, f_10300_27361_27399(f_10300_27361_27390(f_10300_27361_27385(namedArgument))), f_10300_27426_27454(namedArgumentNameSymbol)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 26934, 27472);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 27488, 27513);

                return namedArgumentType;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10300, 23715, 27524);

                Microsoft.CodeAnalysis.SymbolKind
                f_10300_23922_23950(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 23922, 23950);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_10300_24593_24638(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 24593, 24638);
                    return return_v;
                }


                bool
                f_10300_24702_24734(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 24702, 24734);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10300_24818_24846(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 24818, 24846);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10300_25037_25053(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 25037, 25053);
                    return return_v;
                }


                bool
                f_10300_25104_25126(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.IsReadOnly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 25104, 25126);
                    return return_v;
                }


                bool
                f_10300_25177_25196(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.IsConst;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 25177, 25196);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10300_25394_25413(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 25394, 25413);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10300_25325_25414(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                accessingTypeOpt)
                {
                    var return_v = this_param.GetLeastOverriddenProperty(accessingTypeOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 25325, 25414);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10300_25461_25480(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 25461, 25480);
                    return return_v;
                }


                bool
                f_10300_25531_25556(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.IsReadOnly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 25531, 25556);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10300_25599_25623(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.GetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 25599, 25623);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10300_25666_25690(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.SetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 25666, 25690);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_10300_25984_26016(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 25984, 26016);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_10300_26077_26109(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 26077, 26109);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax?
                f_10300_26438_26462(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax
                this_param)
                {
                    var return_v = this_param.NameEquals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 26438, 26462);
                    return return_v;
                }


                int
                f_10300_26419_26473(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 26419, 26473);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax
                f_10300_26743_26767(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax
                this_param)
                {
                    var return_v = this_param.NameEquals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 26743, 26767);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                f_10300_26743_26772(Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 26743, 26772);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10300_26743_26781(Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 26743, 26781);
                    return return_v;
                }


                string
                f_10300_26808_26836(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 26808, 26836);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10300_26661_26837(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 26661, 26837);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol
                f_10300_26499_26838(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                containingSymbol, Microsoft.CodeAnalysis.CSharp.Symbol
                guessSymbol, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                errorInfo)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol((Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol)containingSymbol, guessSymbol, resultKind, (Microsoft.CodeAnalysis.DiagnosticInfo)errorInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 26499, 26838);
                    return return_v;
                }


                int
                f_10300_26870_26917(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 26870, 26917);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10300_26987_26998()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 26987, 26998);
                    return return_v;
                }


                bool
                f_10300_26939_26999(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = type.IsValidAttributeParameterType(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 26939, 26999);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax?
                f_10300_27052_27076(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax
                this_param)
                {
                    var return_v = this_param.NameEquals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 27052, 27076);
                    return return_v;
                }


                int
                f_10300_27033_27087(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 27033, 27087);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax
                f_10300_27361_27385(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax
                this_param)
                {
                    var return_v = this_param.NameEquals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 27361, 27385);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                f_10300_27361_27390(Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 27361, 27390);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10300_27361_27399(Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 27361, 27399);
                    return return_v;
                }


                string
                f_10300_27426_27454(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 27426, 27454);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10300_27275_27455(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 27275, 27455);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol
                f_10300_27113_27456(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                containingSymbol, Microsoft.CodeAnalysis.CSharp.Symbol
                guessSymbol, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                errorInfo)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol((Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol)containingSymbol, guessSymbol, resultKind, (Microsoft.CodeAnalysis.DiagnosticInfo)errorInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 27113, 27456);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10300, 23715, 27524);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10300, 23715, 27524);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected MethodSymbol BindAttributeConstructor(
                    AttributeSyntax node,
                    NamedTypeSymbol attributeType,
                    AnalyzedArguments boundConstructorArguments,
                    DiagnosticBag diagnostics,
                    ref LookupResultKind resultKind,
                    bool suppressErrors,
                    ref ImmutableArray<int> argsToParamsOpt,
                    ref bool expanded,
                    ref HashSet<DiagnosticInfo>? useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10300, 27536, 29189);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 28014, 28074);

                MemberResolutionResult<MethodSymbol>
                memberResolutionResult
                = default(MemberResolutionResult<MethodSymbol>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 28088, 28139);

                ImmutableArray<MethodSymbol>
                candidateConstructors
                = default(ImmutableArray<MethodSymbol>);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 28153, 28940) || true) && (!f_10300_28158_28587(this, attributeType, boundConstructorArguments, f_10300_28292_28310(attributeType), f_10300_28329_28342(node), suppressErrors, diagnostics, out memberResolutionResult, out candidateConstructors, allowProtectedConstructorsOfBaseType: true))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 28153, 28940);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 28621, 28925);

                    resultKind = f_10300_28634_28924(resultKind, (DynAbs.Tracing.TraceSender.Conditional_F1(10300, 28683, 28796) || ((memberResolutionResult.IsValid && (DynAbs.Tracing.TraceSender.Expression_True(10300, 28683, 28796) && !f_10300_28718_28796(this, memberResolutionResult.Member, ref useSiteDiagnostics)) && DynAbs.Tracing.TraceSender.Conditional_F2(10300, 28824, 28853)) || DynAbs.Tracing.TraceSender.Conditional_F3(10300, 28881, 28923))) ? LookupResultKind.Inaccessible : LookupResultKind.OverloadResolutionFailure);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 28153, 28940);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 28954, 29018);

                argsToParamsOpt = memberResolutionResult.Result.ArgsToParamsOpt;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 29032, 29127);

                expanded = memberResolutionResult.Result.Kind == MemberResolutionKind.ApplicableInExpandedForm;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 29141, 29178);

                return memberResolutionResult.Member;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10300, 27536, 29189);

                string
                f_10300_28292_28310(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 28292, 28310);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10300_28329_28342(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 28329, 28342);
                    return return_v;
                }


                bool
                f_10300_28158_28587(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                typeContainingConstructors, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                analyzedArguments, string
                errorName, Microsoft.CodeAnalysis.Location
                errorLocation, bool
                suppressResultDiagnostics, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                memberResolutionResult, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                candidateConstructors, bool
                allowProtectedConstructorsOfBaseType)
                {
                    var return_v = this_param.TryPerformConstructorOverloadResolution(typeContainingConstructors, analyzedArguments, errorName, errorLocation, suppressResultDiagnostics, diagnostics, out memberResolutionResult, out candidateConstructors, allowProtectedConstructorsOfBaseType: allowProtectedConstructorsOfBaseType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 28158, 28587);
                    return return_v;
                }


                bool
                f_10300_28718_28796(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                constructor, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = this_param.IsConstructorAccessible(constructor, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 28718, 28796);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LookupResultKind
                f_10300_28634_28924(Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind1, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind2)
                {
                    var return_v = resultKind1.WorseResultKind(resultKind2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 28634, 28924);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10300, 27536, 29189);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10300, 27536, 29189);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<TypedConstant> GetRewrittenAttributeConstructorArguments(
                    out ImmutableArray<int> constructorArgumentsSourceIndices,
                    MethodSymbol attributeConstructor,
                    ImmutableArray<TypedConstant> constructorArgsArray,
                    ImmutableArray<string> constructorArgumentNamesOpt,
                    AttributeSyntax syntax,
                    DiagnosticBag diagnostics,
                    ref bool hasErrors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10300, 29890, 35460);
                bool foundNamed = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 30355, 30412);

                f_10300_30355_30411((object)attributeConstructor != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 30426, 30472);

                f_10300_30426_30471(f_10300_30439_30470_M(!constructorArgsArray.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 30486, 30511);

                f_10300_30486_30510(!hasErrors);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 30527, 30576);

                int
                argumentsCount = constructorArgsArray.Length
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 30739, 30765);

                int
                argsConsumedCount = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 30781, 30849);

                bool
                hasNamedCtorArguments = f_10300_30810_30848_M(!constructorArgumentNamesOpt.IsDefault)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 30863, 30973);

                f_10300_30863_30972(!hasNamedCtorArguments || (DynAbs.Tracing.TraceSender.Expression_False(10300, 30876, 30971) || constructorArgumentNamesOpt.Length == argumentsCount));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 31051, 31079);

                int
                firstNamedArgIndex = -1
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 31095, 31172);

                ImmutableArray<ParameterSymbol>
                parameters = f_10300_31140_31171(attributeConstructor)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 31186, 31225);

                int
                parameterCount = parameters.Length
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 31241, 31300);

                var
                reorderedArguments = new TypedConstant[parameterCount]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 31314, 31342);

                int[]?
                sourceIndices = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 31367, 31372);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 31358, 35248) || true) && (i < parameterCount)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 31394, 31397)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 31358, 35248))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 31358, 35248);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 31431, 31481);

                        f_10300_31431_31480(argsConsumedCount <= argumentsCount);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 31501, 31543);

                        ParameterSymbol
                        parameter = parameters[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 31561, 31593);

                        TypedConstant
                        reorderedArgument
                        = default(TypedConstant);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 31613, 34272) || true) && (f_10300_31617_31635(parameter) && (DynAbs.Tracing.TraceSender.Expression_True(10300, 31617, 31665) && f_10300_31639_31665(f_10300_31639_31653(parameter))) && (DynAbs.Tracing.TraceSender.Expression_True(10300, 31617, 31692) && i + 1 == parameterCount))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 31613, 34272);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 31734, 31937);

                            reorderedArgument = f_10300_31754_31936(parameter, constructorArgsArray, constructorArgumentNamesOpt, argumentsCount, argsConsumedCount, f_10300_31898_31914(this), out foundNamed);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 31959, 32124) || true) && (!foundNamed)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 31959, 32124);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 32024, 32101);

                                sourceIndices = sourceIndices ?? (DynAbs.Tracing.TraceSender.Expression_Null<int[]?>(10300, 32040, 32100) ?? f_10300_32057_32100(i, parameterCount));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 31959, 32124);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 31613, 34272);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 31613, 34272);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 32166, 34272) || true) && (argsConsumedCount < argumentsCount)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 32166, 34272);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 32246, 33996) || true) && (!hasNamedCtorArguments || (DynAbs.Tracing.TraceSender.Expression_False(10300, 32250, 32355) || constructorArgumentNamesOpt[argsConsumedCount] == null))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 32246, 33996);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 32465, 32525);

                                    reorderedArgument = constructorArgsArray[argsConsumedCount];

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 32551, 32698) || true) && (sourceIndices != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 32551, 32698);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 32634, 32671);

                                        sourceIndices[i] = argsConsumedCount;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 32551, 32698);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 32724, 32744);

                                    argsConsumedCount++;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 32246, 33996);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 32246, 33996);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 32983, 33135) || true) && (firstNamedArgIndex == -1)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 32983, 33135);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 33069, 33108);

                                        firstNamedArgIndex = argsConsumedCount;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 32983, 33135);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 33485, 33511);

                                    int
                                    matchingArgumentIndex
                                    = default(int);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 33537, 33801);

                                    reorderedArgument = f_10300_33557_33800(this, out matchingArgumentIndex, constructorArgsArray, constructorArgumentNamesOpt, parameter, firstNamedArgIndex, argumentsCount, ref argsConsumedCount, syntax, diagnostics);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 33829, 33906);

                                    sourceIndices = sourceIndices ?? (DynAbs.Tracing.TraceSender.Expression_Null<int[]?>(10300, 33845, 33905) ?? f_10300_33862_33905(i, parameterCount));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 33932, 33973);

                                    sourceIndices[i] = matchingArgumentIndex;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 32246, 33996);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 32166, 34272);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 32166, 34272);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 34078, 34154);

                                reorderedArgument = f_10300_34098_34153(this, parameter, syntax, diagnostics);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 34176, 34253);

                                sourceIndices = sourceIndices ?? (DynAbs.Tracing.TraceSender.Expression_Null<int[]?>(10300, 34192, 34252) ?? f_10300_34209_34252(i, parameterCount));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 32166, 34272);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 31613, 34272);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 34292, 35171) || true) && (!hasErrors)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 34292, 35171);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 34348, 35152) || true) && (reorderedArgument.Kind == TypedConstantKind.Error)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 34348, 35152);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 34451, 34468);

                                hasErrors = true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 34348, 35152);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 34348, 35152);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 34518, 35152) || true) && (reorderedArgument.Kind == TypedConstantKind.Array && (DynAbs.Tracing.TraceSender.Expression_True(10300, 34522, 34641) && f_10300_34600_34623(f_10300_34600_34614(parameter)) == TypeKind.Array) && (DynAbs.Tracing.TraceSender.Expression_True(10300, 34522, 34773) && !f_10300_34671_34773(((TypeSymbol)reorderedArgument.TypeInternal!), f_10300_34724_34738(parameter), TypeCompareKind.AllIgnoreOptions)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 34518, 35152);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 35017, 35086);

                                    f_10300_35017_35085(                        // NOTE: As in dev11, we don't allow array covariance conversions (presumably, we don't have a way to
                                                                                // represent the conversion in metadata).
                                                            diagnostics, ErrorCode.ERR_BadAttributeArgument, f_10300_35069_35084(syntax));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 35112, 35129);

                                    hasErrors = true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 34518, 35152);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 34348, 35152);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 34292, 35171);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 35191, 35233);

                        reorderedArguments[i] = reorderedArgument;
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10300, 1, 3891);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10300, 1, 3891);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 35264, 35389);

                constructorArgumentsSourceIndices = (DynAbs.Tracing.TraceSender.Conditional_F1(10300, 35300, 35321) || ((sourceIndices != null && DynAbs.Tracing.TraceSender.Conditional_F2(10300, 35324, 35357)) || DynAbs.Tracing.TraceSender.Conditional_F3(10300, 35360, 35388))) ? f_10300_35324_35357(sourceIndices) : default(ImmutableArray<int>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 35403, 35449);

                return f_10300_35410_35448(reorderedArguments);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10300, 29890, 35460);

                int
                f_10300_30355_30411(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 30355, 30411);
                    return 0;
                }


                bool
                f_10300_30439_30470_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 30439, 30470);
                    return return_v;
                }


                int
                f_10300_30426_30471(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 30426, 30471);
                    return 0;
                }


                int
                f_10300_30486_30510(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 30486, 30510);
                    return 0;
                }


                bool
                f_10300_30810_30848_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 30810, 30848);
                    return return_v;
                }


                int
                f_10300_30863_30972(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 30863, 30972);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10300_31140_31171(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 31140, 31171);
                    return return_v;
                }


                int
                f_10300_31431_31480(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 31431, 31480);
                    return 0;
                }


                bool
                f_10300_31617_31635(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.IsParams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 31617, 31635);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10300_31639_31653(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 31639, 31653);
                    return return_v;
                }


                bool
                f_10300_31639_31665(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsSZArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 31639, 31665);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10300_31898_31914(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Conversions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 31898, 31914);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypedConstant
                f_10300_31754_31936(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                parameter, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                constructorArgsArray, System.Collections.Immutable.ImmutableArray<string>
                constructorArgumentNamesOpt, int
                argumentsCount, int
                argsConsumedCount, Microsoft.CodeAnalysis.CSharp.Conversions
                conversions, out bool
                foundNamed)
                {
                    var return_v = GetParamArrayArgument(parameter, constructorArgsArray, constructorArgumentNamesOpt, argumentsCount, argsConsumedCount, conversions, out foundNamed);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 31754, 31936);
                    return return_v;
                }


                int[]
                f_10300_32057_32100(int
                paramIndex, int
                parameterCount)
                {
                    var return_v = CreateSourceIndicesArray(paramIndex, parameterCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 32057, 32100);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypedConstant
                f_10300_33557_33800(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, out int
                matchingArgumentIndex, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                constructorArgsArray, System.Collections.Immutable.ImmutableArray<string>
                constructorArgumentNamesOpt, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                parameter, int
                startIndex, int
                argumentsCount, ref int
                argsConsumedCount, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.GetMatchingNamedOrOptionalConstructorArgument(out matchingArgumentIndex, constructorArgsArray, constructorArgumentNamesOpt, parameter, startIndex, argumentsCount, ref argsConsumedCount, syntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 33557, 33800);
                    return return_v;
                }


                int[]
                f_10300_33862_33905(int
                paramIndex, int
                parameterCount)
                {
                    var return_v = CreateSourceIndicesArray(paramIndex, parameterCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 33862, 33905);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypedConstant
                f_10300_34098_34153(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                parameter, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.GetDefaultValueArgument(parameter, syntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 34098, 34153);
                    return return_v;
                }


                int[]
                f_10300_34209_34252(int
                paramIndex, int
                parameterCount)
                {
                    var return_v = CreateSourceIndicesArray(paramIndex, parameterCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 34209, 34252);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10300_34600_34614(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 34600, 34614);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10300_34600_34623(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 34600, 34623);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10300_34724_34738(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 34724, 34738);
                    return return_v;
                }


                bool
                f_10300_34671_34773(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals(t2, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 34671, 34773);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10300_35069_35084(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 35069, 35084);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10300_35017_35085(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 35017, 35085);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<int>
                f_10300_35324_35357(int[]
                items)
                {
                    var return_v = items.AsImmutableOrNull<int>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 35324, 35357);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10300_35410_35448(Microsoft.CodeAnalysis.TypedConstant[]
                items)
                {
                    var return_v = items.AsImmutableOrNull<Microsoft.CodeAnalysis.TypedConstant>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 35410, 35448);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10300, 29890, 35460);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10300, 29890, 35460);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static int[] CreateSourceIndicesArray(int paramIndex, int parameterCount)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10300, 35472, 36026);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 35578, 35608);

                f_10300_35578_35607(paramIndex >= 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 35622, 35664);

                f_10300_35622_35663(paramIndex < parameterCount);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 35680, 35724);

                var
                sourceIndices = new int[parameterCount]
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 35747, 35752);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 35738, 35843) || true) && (i < paramIndex)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 35770, 35773)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 35738, 35843))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 35738, 35843);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 35807, 35828);

                        sourceIndices[i] = i;
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10300, 1, 106);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10300, 1, 106);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 35868, 35882);

                    for (int
        i = paramIndex
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 35859, 35978) || true) && (i < parameterCount)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 35904, 35907)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 35859, 35978))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 35859, 35978);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 35941, 35963);

                        sourceIndices[i] = -1;
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10300, 1, 120);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10300, 1, 120);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 35994, 36015);

                return sourceIndices;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10300, 35472, 36026);

                int
                f_10300_35578_35607(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 35578, 35607);
                    return 0;
                }


                int
                f_10300_35622_35663(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 35622, 35663);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10300, 35472, 36026);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10300, 35472, 36026);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private TypedConstant GetMatchingNamedOrOptionalConstructorArgument(
                    out int matchingArgumentIndex,
                    ImmutableArray<TypedConstant> constructorArgsArray,
                    ImmutableArray<string> constructorArgumentNamesOpt,
                    ParameterSymbol parameter,
                    int startIndex,
                    int argumentsCount,
                    ref int argsConsumedCount,
                    AttributeSyntax syntax,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10300, 36038, 37201);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 36524, 36650);

                int
                index = f_10300_36536_36649(f_10300_36577_36591(parameter), constructorArgumentNamesOpt, startIndex, argumentsCount)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 36666, 37190) || true) && (index < argumentsCount)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 36666, 37190);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 36778, 36812);

                    f_10300_36778_36811(index >= startIndex);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 36880, 36900);

                    argsConsumedCount++;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 36918, 36948);

                    matchingArgumentIndex = index;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 36966, 37001);

                    return constructorArgsArray[index];
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 36666, 37190);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 36666, 37190);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 37067, 37094);

                    matchingArgumentIndex = -1;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 37112, 37175);

                    return f_10300_37119_37174(this, parameter, syntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 36666, 37190);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10300, 36038, 37201);

                string
                f_10300_36577_36591(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 36577, 36591);
                    return return_v;
                }


                int
                f_10300_36536_36649(string
                parameterName, System.Collections.Immutable.ImmutableArray<string>
                argumentNamesOpt, int
                startIndex, int
                argumentsCount)
                {
                    var return_v = GetMatchingNamedConstructorArgumentIndex(parameterName, argumentNamesOpt, startIndex, argumentsCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 36536, 36649);
                    return return_v;
                }


                int
                f_10300_36778_36811(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 36778, 36811);
                    return 0;
                }


                Microsoft.CodeAnalysis.TypedConstant
                f_10300_37119_37174(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                parameter, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.GetDefaultValueArgument(parameter, syntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 37119, 37174);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10300, 36038, 37201);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10300, 36038, 37201);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static int GetMatchingNamedConstructorArgumentIndex(string parameterName, ImmutableArray<string> argumentNamesOpt, int startIndex, int argumentsCount)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10300, 37213, 38116);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 37396, 37438);

                f_10300_37396_37437(parameterName != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 37452, 37513);

                f_10300_37452_37512(startIndex >= 0 && (DynAbs.Tracing.TraceSender.Expression_True(10300, 37465, 37511) && startIndex < argumentsCount));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 37529, 37654) || true) && (f_10300_37533_37556(parameterName) || (DynAbs.Tracing.TraceSender.Expression_False(10300, 37533, 37583) || !argumentNamesOpt.Any()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 37529, 37654);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 37617, 37639);

                    return argumentsCount;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 37529, 37654);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 37732, 37758);

                int
                argIndex = startIndex
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 37772, 38073) || true) && (argIndex < argumentsCount)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 37772, 38073);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 37838, 37876);

                        var
                        name = argumentNamesOpt[argIndex]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 37896, 38027) || true) && (f_10300_37900_37960(name, parameterName, StringComparison.Ordinal))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 37896, 38027);
                            DynAbs.Tracing.TraceSender.TraceBreak(10300, 38002, 38008);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 37896, 38027);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 38047, 38058);

                        argIndex++;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 37772, 38073);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10300, 37772, 38073);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10300, 37772, 38073);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 38089, 38105);

                return argIndex;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10300, 37213, 38116);

                int
                f_10300_37396_37437(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 37396, 37437);
                    return 0;
                }


                int
                f_10300_37452_37512(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 37452, 37512);
                    return 0;
                }


                bool
                f_10300_37533_37556(string
                source)
                {
                    var return_v = source.IsEmpty();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 37533, 37556);
                    return return_v;
                }


                bool
                f_10300_37900_37960(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 37900, 37960);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10300, 37213, 38116);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10300, 37213, 38116);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private TypedConstant GetDefaultValueArgument(ParameterSymbol parameter, AttributeSyntax syntax, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10300, 38128, 43661);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 38276, 38311);

                var
                parameterType = f_10300_38296_38310(parameter)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 38325, 38454);

                ConstantValue?
                defaultConstantValue = (DynAbs.Tracing.TraceSender.Conditional_F1(10300, 38363, 38383) || ((f_10300_38363_38383(parameter) && DynAbs.Tracing.TraceSender.Conditional_F2(10300, 38386, 38424)) || DynAbs.Tracing.TraceSender.Conditional_F3(10300, 38427, 38453))) ? f_10300_38386_38424(parameter) : ConstantValue.NotAvailable
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 38470, 38493);

                TypedConstantKind
                kind
                = default(TypedConstantKind);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 38507, 38535);

                object?
                defaultValue = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 38551, 43291) || true) && (f_10300_38555_38578_M(!IsEarlyAttributeBinder) && (DynAbs.Tracing.TraceSender.Expression_True(10300, 38555, 38610) && f_10300_38582_38610(parameter)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 38551, 43291);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 38644, 38712);

                    int
                    line = f_10300_38655_38711(f_10300_38655_38672(syntax), f_10300_38694_38710(f_10300_38694_38705(syntax)))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 38730, 38765);

                    kind = TypedConstantKind.Primitive;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 38785, 38836);

                    HashSet<DiagnosticInfo>?
                    useSiteDiagnostics = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 38854, 38952);

                    var
                    conversion = f_10300_38871_38951(f_10300_38871_38882(), parameterType, ref useSiteDiagnostics)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 38970, 39014);

                    f_10300_38970_39013(diagnostics, syntax, useSiteDiagnostics);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 39034, 39813) || true) && (conversion.IsNumeric || (DynAbs.Tracing.TraceSender.Expression_False(10300, 39038, 39093) || conversion.IsConstantExpression))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 39034, 39813);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 39324, 39546);

                        defaultValue = (DynAbs.Tracing.TraceSender.Conditional_F1(10300, 39339, 39395) || (((f_10300_39340_39365(parameterType) == SpecialType.System_Single)
                        && DynAbs.Tracing.TraceSender.Conditional_F2(10300, 39423, 39434)) || DynAbs.Tracing.TraceSender.Conditional_F3(10300, 39462, 39545))) ? (float)line
                        : f_10300_39462_39545(f_10300_39491_39516(parameterType), f_10300_39518_39544(line));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 39034, 39813);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 39034, 39813);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 39683, 39752);

                        parameterType = f_10300_39699_39751(f_10300_39699_39710(), SpecialType.System_Int32);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 39774, 39794);

                        defaultValue = line;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 39034, 39813);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 38551, 43291);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 38551, 43291);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 39847, 43291) || true) && (f_10300_39851_39874_M(!IsEarlyAttributeBinder) && (DynAbs.Tracing.TraceSender.Expression_True(10300, 39851, 39904) && f_10300_39878_39904(parameter)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 39847, 43291);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 39938, 40008);

                        parameterType = f_10300_39954_40007(f_10300_39954_39965(), SpecialType.System_String);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 40026, 40061);

                        kind = TypedConstantKind.Primitive;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 40079, 40190);

                        defaultValue = f_10300_40094_40189(f_10300_40094_40111(syntax), f_10300_40127_40143(f_10300_40127_40138(syntax)), f_10300_40145_40188(f_10300_40145_40164(f_10300_40145_40156())));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 39847, 43291);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 39847, 43291);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 40224, 43291) || true) && (f_10300_40228_40251_M(!IsEarlyAttributeBinder) && (DynAbs.Tracing.TraceSender.Expression_True(10300, 40228, 40283) && f_10300_40255_40283(parameter)) && (DynAbs.Tracing.TraceSender.Expression_True(10300, 40228, 40353) && (object)f_10300_40295_40345(((ContextualAttributeBinder)this)) != null))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 40224, 43291);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 40387, 40457);

                            parameterType = f_10300_40403_40456(f_10300_40403_40414(), SpecialType.System_String);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 40475, 40510);

                            kind = TypedConstantKind.Primitive;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 40528, 40616);

                            defaultValue = f_10300_40543_40615(f_10300_40543_40593(((ContextualAttributeBinder)this)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 40224, 43291);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 40224, 43291);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 40650, 43291) || true) && (defaultConstantValue == ConstantValue.NotAvailable)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 40650, 43291);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 41435, 42311) || true) && (f_10300_41439_41464(parameterType) == SpecialType.System_Object)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 41435, 42311);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 41664, 41766);

                                    f_10300_41664_41765(                    // CS7067: Attribute constructor parameter '{0}' is optional, but no default parameter value was specified.
                                                        diagnostics, ErrorCode.ERR_BadAttributeParamDefaultArgument, f_10300_41728_41748(f_10300_41728_41739(syntax)), f_10300_41750_41764(parameter));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 41788, 41819);

                                    kind = TypedConstantKind.Error;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 41435, 42311);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 41435, 42311);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 41901, 41976);

                                    kind = TypedConstant.GetTypedConstantKind(parameterType, f_10300_41958_41974(this));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 41998, 42044);

                                    f_10300_41998_42043(kind != TypedConstantKind.Error);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 42068, 42123);

                                    defaultConstantValue = f_10300_42091_42122(parameterType);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 42145, 42292) || true) && (defaultConstantValue != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 42145, 42292);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 42227, 42269);

                                        defaultValue = f_10300_42242_42268(defaultConstantValue);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 42145, 42292);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 41435, 42311);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 40650, 43291);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 40650, 43291);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 42345, 43291) || true) && (f_10300_42349_42375(defaultConstantValue))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 42345, 43291);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 42509, 42540);

                                    kind = TypedConstantKind.Error;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 42345, 43291);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 42345, 43291);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 42574, 43291) || true) && (f_10300_42578_42603(parameterType) == SpecialType.System_Object && (DynAbs.Tracing.TraceSender.Expression_True(10300, 42578, 42664) && f_10300_42636_42664_M(!defaultConstantValue.IsNull)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 42574, 43291);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 42854, 42960);

                                        f_10300_42854_42959(                // error CS1763: '{0}' is of type '{1}'. A default parameter value of a reference type other than string can only be initialized with null
                                                        diagnostics, ErrorCode.ERR_NotNullRefDefaultParameter, f_10300_42912_42927(syntax), f_10300_42929_42943(parameter), parameterType);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 42978, 43009);

                                        kind = TypedConstantKind.Error;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 42574, 43291);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 42574, 43291);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 43075, 43150);

                                        kind = TypedConstant.GetTypedConstantKind(parameterType, f_10300_43132_43148(this));
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 43168, 43214);

                                        f_10300_43168_43213(kind != TypedConstantKind.Error);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 43234, 43276);

                                        defaultValue = f_10300_43249_43275(defaultConstantValue);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 42574, 43291);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 42345, 43291);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 40650, 43291);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 40224, 43291);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 39847, 43291);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 38551, 43291);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 43307, 43650) || true) && (kind == TypedConstantKind.Array)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 43307, 43650);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 43376, 43411);

                    f_10300_43376_43410(defaultValue == null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 43429, 43509);

                    return f_10300_43436_43508(parameterType, default(ImmutableArray<TypedConstant>));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 43307, 43650);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 43307, 43650);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 43575, 43635);

                    return f_10300_43582_43634(parameterType, kind, defaultValue);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 43307, 43650);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10300, 38128, 43661);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10300_38296_38310(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 38296, 38310);
                    return return_v;
                }


                bool
                f_10300_38363_38383(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.IsOptional;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 38363, 38383);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10300_38386_38424(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.ExplicitDefaultConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 38386, 38424);
                    return return_v;
                }


                bool
                f_10300_38555_38578_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 38555, 38578);
                    return return_v;
                }


                bool
                f_10300_38582_38610(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.IsCallerLineNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 38582, 38610);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10300_38655_38672(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 38655, 38672);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10300_38694_38705(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 38694, 38705);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_10300_38694_38710(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                this_param)
                {
                    var return_v = this_param.Span;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 38694, 38710);
                    return return_v;
                }


                int
                f_10300_38655_38711(Microsoft.CodeAnalysis.SyntaxTree
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = this_param.GetDisplayLineNumber(span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 38655, 38711);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10300_38871_38882()
                {
                    var return_v = Conversions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 38871, 38882);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10300_38871_38951(Microsoft.CodeAnalysis.CSharp.Conversions
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = this_param.GetCallerLineNumberConversion(destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 38871, 38951);
                    return return_v;
                }


                bool
                f_10300_38970_39013(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                node, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add((Microsoft.CodeAnalysis.SyntaxNode)node, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 38970, 39013);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10300_39340_39365(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 39340, 39365);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10300_39491_39516(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 39491, 39516);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10300_39518_39544(int
                value)
                {
                    var return_v = ConstantValue.Create(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 39518, 39544);
                    return return_v;
                }


                object
                f_10300_39462_39545(Microsoft.CodeAnalysis.SpecialType
                destinationType, Microsoft.CodeAnalysis.ConstantValue
                value)
                {
                    var return_v = Binder.DoUncheckedConversion(destinationType, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 39462, 39545);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10300_39699_39710()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 39699, 39710);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10300_39699_39751(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 39699, 39751);
                    return return_v;
                }


                bool
                f_10300_39851_39874_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 39851, 39874);
                    return return_v;
                }


                bool
                f_10300_39878_39904(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.IsCallerFilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 39878, 39904);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10300_39954_39965()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 39954, 39965);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10300_39954_40007(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 39954, 40007);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10300_40094_40111(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 40094, 40111);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10300_40127_40138(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 40127, 40138);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_10300_40127_40143(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                this_param)
                {
                    var return_v = this_param.Span;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 40127, 40143);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10300_40145_40156()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 40145, 40156);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10300_40145_40164(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 40145, 40164);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceReferenceResolver?
                f_10300_40145_40188(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.SourceReferenceResolver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 40145, 40188);
                    return return_v;
                }


                string
                f_10300_40094_40189(Microsoft.CodeAnalysis.SyntaxTree
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span, Microsoft.CodeAnalysis.SourceReferenceResolver?
                resolver)
                {
                    var return_v = this_param.GetDisplayPath(span, resolver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 40094, 40189);
                    return return_v;
                }


                bool
                f_10300_40228_40251_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 40228, 40251);
                    return return_v;
                }


                bool
                f_10300_40255_40283(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.IsCallerMemberName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 40255, 40283);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10300_40295_40345(Microsoft.CodeAnalysis.CSharp.ContextualAttributeBinder
                this_param)
                {
                    var return_v = this_param.AttributedMember;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 40295, 40345);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10300_40403_40414()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 40403, 40414);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10300_40403_40456(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 40403, 40456);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10300_40543_40593(Microsoft.CodeAnalysis.CSharp.ContextualAttributeBinder
                this_param)
                {
                    var return_v = this_param.AttributedMember;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 40543, 40593);
                    return return_v;
                }


                string
                f_10300_40543_40615(Microsoft.CodeAnalysis.CSharp.Symbol
                member)
                {
                    var return_v = member.GetMemberCallerName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 40543, 40615);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10300_41439_41464(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 41439, 41464);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10300_41728_41739(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 41728, 41739);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10300_41728_41748(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 41728, 41748);
                    return return_v;
                }


                string
                f_10300_41750_41764(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 41750, 41764);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10300_41664_41765(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 41664, 41765);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10300_41958_41974(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 41958, 41974);
                    return return_v;
                }


                int
                f_10300_41998_42043(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 41998, 42043);
                    return 0;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10300_42091_42122(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetDefaultValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 42091, 42122);
                    return return_v;
                }


                object?
                f_10300_42242_42268(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 42242, 42268);
                    return return_v;
                }


                bool
                f_10300_42349_42375(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.IsBad;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 42349, 42375);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10300_42578_42603(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 42578, 42603);
                    return return_v;
                }


                bool
                f_10300_42636_42664_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 42636, 42664);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10300_42912_42927(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 42912, 42927);
                    return return_v;
                }


                string
                f_10300_42929_42943(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 42929, 42943);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10300_42854_42959(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 42854, 42959);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10300_43132_43148(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 43132, 43148);
                    return return_v;
                }


                int
                f_10300_43168_43213(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 43168, 43213);
                    return 0;
                }


                object?
                f_10300_43249_43275(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 43249, 43275);
                    return return_v;
                }


                int
                f_10300_43376_43410(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 43376, 43410);
                    return 0;
                }


                Microsoft.CodeAnalysis.TypedConstant
                f_10300_43436_43508(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                array)
                {
                    var return_v = new Microsoft.CodeAnalysis.TypedConstant((Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal)type, array);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 43436, 43508);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypedConstant
                f_10300_43582_43634(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.TypedConstantKind
                kind, object?
                value)
                {
                    var return_v = new Microsoft.CodeAnalysis.TypedConstant((Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal)type, kind, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 43582, 43634);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10300, 38128, 43661);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10300, 38128, 43661);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static TypedConstant GetParamArrayArgument(ParameterSymbol parameter, ImmutableArray<TypedConstant> constructorArgsArray,
                    ImmutableArray<string> constructorArgumentNamesOpt, int argumentsCount, int argsConsumedCount, Conversions conversions, out bool foundNamed)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10300, 43673, 46016);
                Microsoft.CodeAnalysis.TypedConstant namedValue = default(Microsoft.CodeAnalysis.TypedConstant);
                Microsoft.CodeAnalysis.TypedConstant lastValue = default(Microsoft.CodeAnalysis.TypedConstant);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 43981, 44031);

                f_10300_43981_44030(argsConsumedCount <= argumentsCount);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 44107, 44825) || true) && (f_10300_44111_44149_M(!constructorArgumentNamesOpt.IsDefault))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 44107, 44825);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 44183, 44250);

                    int
                    argIndex = constructorArgumentNamesOpt.IndexOf(f_10300_44234_44248(parameter))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 44268, 44810) || true) && (argIndex >= 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 44268, 44810);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 44327, 44345);

                        foundNamed = true;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 44367, 44560) || true) && (f_10300_44371_44469(parameter, constructorArgsArray, argIndex, conversions, out namedValue))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 44367, 44560);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 44519, 44537);

                            return namedValue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 44367, 44560);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 44695, 44791);

                        return f_10300_44702_44790(f_10300_44720_44734(parameter), f_10300_44736_44789(constructorArgsArray[argIndex]));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 44268, 44810);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 44107, 44825);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 44841, 44901);

                int
                paramArrayArgCount = argumentsCount - argsConsumedCount
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 44915, 44934);

                foundNamed = false;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 44999, 45153) || true) && (paramArrayArgCount == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 44999, 45153);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 45060, 45138);

                    return f_10300_45067_45137(f_10300_45085_45099(parameter), ImmutableArray<TypedConstant>.Empty);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 44999, 45153);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 45258, 45478) || true) && (paramArrayArgCount == 1 && (DynAbs.Tracing.TraceSender.Expression_True(10300, 45262, 45412) && f_10300_45306_45412(parameter, constructorArgsArray, argsConsumedCount, conversions, out lastValue)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 45258, 45478);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 45446, 45463);

                    return lastValue;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 45258, 45478);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 45494, 45540);

                f_10300_45494_45539(f_10300_45507_45538_M(!constructorArgsArray.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 45554, 45617);

                f_10300_45554_45616(argsConsumedCount <= constructorArgsArray.Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 45707, 45758);

                var
                values = new TypedConstant[paramArrayArgCount]
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 45783, 45788);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 45774, 45920) || true) && (i < paramArrayArgCount)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 45814, 45817)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 45774, 45920))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 45774, 45920);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 45851, 45905);

                        values[i] = constructorArgsArray[argsConsumedCount++];
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10300, 1, 147);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10300, 1, 147);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 45936, 46005);

                return f_10300_45943_46004(f_10300_45961_45975(parameter), f_10300_45977_46003(values));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10300, 43673, 46016);

                int
                f_10300_43981_44030(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 43981, 44030);
                    return 0;
                }


                bool
                f_10300_44111_44149_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 44111, 44149);
                    return return_v;
                }


                string
                f_10300_44234_44248(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 44234, 44248);
                    return return_v;
                }


                bool
                f_10300_44371_44469(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                parameter, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                constructorArgsArray, int
                argIndex, Microsoft.CodeAnalysis.CSharp.Conversions
                conversions, out Microsoft.CodeAnalysis.TypedConstant
                result)
                {
                    var return_v = TryGetNormalParamValue(parameter, constructorArgsArray, argIndex, conversions, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 44371, 44469);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10300_44720_44734(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 44720, 44734);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10300_44736_44789(Microsoft.CodeAnalysis.TypedConstant
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 44736, 44789);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypedConstant
                f_10300_44702_44790(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                array)
                {
                    var return_v = new Microsoft.CodeAnalysis.TypedConstant((Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal)type, array);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 44702, 44790);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10300_45085_45099(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 45085, 45099);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypedConstant
                f_10300_45067_45137(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                array)
                {
                    var return_v = new Microsoft.CodeAnalysis.TypedConstant((Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal)type, array);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 45067, 45137);
                    return return_v;
                }


                bool
                f_10300_45306_45412(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                parameter, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                constructorArgsArray, int
                argIndex, Microsoft.CodeAnalysis.CSharp.Conversions
                conversions, out Microsoft.CodeAnalysis.TypedConstant
                result)
                {
                    var return_v = TryGetNormalParamValue(parameter, constructorArgsArray, argIndex, conversions, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 45306, 45412);
                    return return_v;
                }


                bool
                f_10300_45507_45538_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 45507, 45538);
                    return return_v;
                }


                int
                f_10300_45494_45539(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 45494, 45539);
                    return 0;
                }


                int
                f_10300_45554_45616(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 45554, 45616);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10300_45961_45975(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 45961, 45975);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10300_45977_46003(Microsoft.CodeAnalysis.TypedConstant[]
                items)
                {
                    var return_v = items.AsImmutableOrNull<Microsoft.CodeAnalysis.TypedConstant>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 45977, 46003);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypedConstant
                f_10300_45943_46004(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                array)
                {
                    var return_v = new Microsoft.CodeAnalysis.TypedConstant((Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal)type, array);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 45943, 46004);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10300, 43673, 46016);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10300, 43673, 46016);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool TryGetNormalParamValue(ParameterSymbol parameter, ImmutableArray<TypedConstant> constructorArgsArray,
                    int argIndex, Conversions conversions, out TypedConstant result)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10300, 46028, 47318);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 46252, 46308);

                TypedConstant
                argument = constructorArgsArray[argIndex]
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 46322, 46463) || true) && (argument.Kind != TypedConstantKind.Array)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 46322, 46463);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 46400, 46417);

                    result = default;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 46435, 46448);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 46322, 46463);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 46479, 46530);

                HashSet<DiagnosticInfo>?
                useSiteDiagnostics = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 46600, 46646);

                f_10300_46600_46645(argument.TypeInternal is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 46660, 46797);

                Conversion
                conversion = f_10300_46684_46796(conversions, argument.TypeInternal, f_10300_46757_46771(parameter), ref useSiteDiagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 47025, 47247) || true) && (conversion.IsValid && (DynAbs.Tracing.TraceSender.Expression_True(10300, 47029, 47150) && (conversion.Kind == ConversionKind.ImplicitReference || (DynAbs.Tracing.TraceSender.Expression_False(10300, 47052, 47149) || conversion.Kind == ConversionKind.Identity))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 47025, 47247);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 47184, 47202);

                    result = argument;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 47220, 47232);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 47025, 47247);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 47263, 47280);

                result = default;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 47294, 47307);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10300, 46028, 47318);

                int
                f_10300_46600_46645(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 46600, 46645);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10300_46757_46771(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 46757, 46771);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10300_46684_46796(Microsoft.CodeAnalysis.CSharp.Conversions
                this_param, Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyBuiltInConversion((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 46684, 46796);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10300, 46028, 47318);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10300, 46028, 47318);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private struct AttributeExpressionVisitor
        {

            private readonly Binder _binder;

            public AttributeExpressionVisitor(Binder binder)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10300, 47698, 47811);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 47779, 47796);

                    _binder = binder;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10300, 47698, 47811);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10300, 47698, 47811);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10300, 47698, 47811);
                }
            }

            public ImmutableArray<TypedConstant> VisitArguments(ImmutableArray<BoundExpression> arguments, DiagnosticBag diagnostics, ref bool attrHasErrors, bool parentHasErrors = false)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10300, 47827, 48871);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 48035, 48096);

                    var
                    validatedArguments = ImmutableArray<TypedConstant>.Empty
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 48116, 48152);

                    int
                    numArguments = arguments.Length
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 48170, 48810) || true) && (numArguments > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 48170, 48810);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 48232, 48300);

                        var
                        builder = f_10300_48246_48299(numArguments)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 48322, 48719);
                            foreach (var argument in f_10300_48347_48356_I(arguments))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 48322, 48719);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 48506, 48575);

                                bool
                                curArgumentHasErrors = parentHasErrors || (DynAbs.Tracing.TraceSender.Expression_False(10300, 48534, 48574) || f_10300_48553_48574(argument))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 48603, 48696);

                                f_10300_48603_48695(
                                                        builder, VisitExpression(argument, diagnostics, ref attrHasErrors, curArgumentHasErrors));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 48322, 48719);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10300, 1, 398);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10300, 1, 398);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 48741, 48791);

                        validatedArguments = f_10300_48762_48790(builder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 48170, 48810);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 48830, 48856);

                    return validatedArguments;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10300, 47827, 48871);

                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.TypedConstant>
                    f_10300_48246_48299(int
                    capacity)
                    {
                        var return_v = ArrayBuilder<TypedConstant>.GetInstance(capacity);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 48246, 48299);
                        return return_v;
                    }


                    bool
                    f_10300_48553_48574(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.HasAnyErrors;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 48553, 48574);
                        return return_v;
                    }


                    int
                    f_10300_48603_48695(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.TypedConstant>
                    this_param, Microsoft.CodeAnalysis.TypedConstant
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 48603, 48695);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                    f_10300_48347_48356_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 48347, 48356);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                    f_10300_48762_48790(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.TypedConstant>
                    this_param)
                    {
                        var return_v = this_param.ToImmutableAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 48762, 48790);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10300, 47827, 48871);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10300, 47827, 48871);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public ImmutableArray<KeyValuePair<string, TypedConstant>> VisitNamedArguments(ImmutableArray<BoundExpression> arguments, DiagnosticBag diagnostics, ref bool attrHasErrors)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10300, 48887, 49917);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 49092, 49158);

                    ArrayBuilder<KeyValuePair<string, TypedConstant>>?
                    builder = null
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 49176, 49681);
                        foreach (var argument in f_10300_49201_49210_I(arguments))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 49176, 49681);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 49252, 49322);

                            var
                            kv = VisitNamedArgument(argument, diagnostics, ref attrHasErrors)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 49346, 49662) || true) && (kv.HasValue)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 49346, 49662);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 49411, 49589) || true) && (builder == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 49411, 49589);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 49488, 49562);

                                    builder = f_10300_49498_49561();
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 49411, 49589);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 49617, 49639);

                                f_10300_49617_49638(
                                                        builder, kv.Value);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 49346, 49662);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 49176, 49681);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10300, 1, 506);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10300, 1, 506);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 49701, 49846) || true) && (builder == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 49701, 49846);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 49762, 49827);

                        return ImmutableArray<KeyValuePair<string, TypedConstant>>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 49701, 49846);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 49866, 49902);

                    return f_10300_49873_49901(builder);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10300, 48887, 49917);

                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
                    f_10300_49498_49561()
                    {
                        var return_v = ArrayBuilder<KeyValuePair<string, TypedConstant>>.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 49498, 49561);
                        return return_v;
                    }


                    int
                    f_10300_49617_49638(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
                    this_param, System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 49617, 49638);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                    f_10300_49201_49210_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 49201, 49210);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
                    f_10300_49873_49901(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
                    this_param)
                    {
                        var return_v = this_param.ToImmutableAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 49873, 49901);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10300, 48887, 49917);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10300, 48887, 49917);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private KeyValuePair<String, TypedConstant>? VisitNamedArgument(BoundExpression argument, DiagnosticBag diagnostics, ref bool attrHasErrors)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10300, 49933, 51347);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 50106, 50166);

                    KeyValuePair<String, TypedConstant>?
                    visitedArgument = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 50186, 51289);

                    switch (f_10300_50194_50207(argument))
                    {

                        case BoundKind.AssignmentOperator:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 50186, 51289);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 50309, 50360);

                            var
                            assignment = (BoundAssignmentOperator)argument
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 50388, 51236);

                            switch (f_10300_50396_50416(f_10300_50396_50411(assignment)))
                            {

                                case BoundKind.FieldAccess:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 50388, 51236);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 50535, 50578);

                                    var
                                    fa = (BoundFieldAccess)f_10300_50562_50577(assignment)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 50612, 50781);

                                    visitedArgument = f_10300_50630_50780(f_10300_50670_50689(f_10300_50670_50684(fa)), VisitExpression(f_10300_50707_50723(assignment), diagnostics, ref attrHasErrors, f_10300_50757_50778(argument)));
                                    DynAbs.Tracing.TraceSender.TraceBreak(10300, 50815, 50821);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 50388, 51236);

                                case BoundKind.PropertyAccess:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 50388, 51236);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 50917, 50963);

                                    var
                                    pa = (BoundPropertyAccess)f_10300_50947_50962(assignment)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 50997, 51169);

                                    visitedArgument = f_10300_51015_51168(f_10300_51055_51077(f_10300_51055_51072(pa)), VisitExpression(f_10300_51095_51111(assignment), diagnostics, ref attrHasErrors, f_10300_51145_51166(argument)));
                                    DynAbs.Tracing.TraceSender.TraceBreak(10300, 51203, 51209);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 50388, 51236);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(10300, 51264, 51270);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 50186, 51289);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 51309, 51332);

                    return visitedArgument;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10300, 49933, 51347);

                    Microsoft.CodeAnalysis.CSharp.BoundKind
                    f_10300_50194_50207(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 50194, 50207);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10300_50396_50411(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                    this_param)
                    {
                        var return_v = this_param.Left;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 50396, 50411);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundKind
                    f_10300_50396_50416(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 50396, 50416);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10300_50562_50577(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                    this_param)
                    {
                        var return_v = this_param.Left;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 50562, 50577);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f_10300_50670_50684(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                    this_param)
                    {
                        var return_v = this_param.FieldSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 50670, 50684);
                        return return_v;
                    }


                    string
                    f_10300_50670_50689(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 50670, 50689);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10300_50707_50723(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                    this_param)
                    {
                        var return_v = this_param.Right;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 50707, 50723);
                        return return_v;
                    }


                    bool
                    f_10300_50757_50778(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.HasAnyErrors;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 50757, 50778);
                        return return_v;
                    }


                    System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>
                    f_10300_50630_50780(string
                    key, Microsoft.CodeAnalysis.TypedConstant
                    value)
                    {
                        var return_v = new System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 50630, 50780);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10300_50947_50962(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                    this_param)
                    {
                        var return_v = this_param.Left;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 50947, 50962);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    f_10300_51055_51072(Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
                    this_param)
                    {
                        var return_v = this_param.PropertySymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 51055, 51072);
                        return return_v;
                    }


                    string
                    f_10300_51055_51077(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 51055, 51077);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10300_51095_51111(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                    this_param)
                    {
                        var return_v = this_param.Right;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 51095, 51111);
                        return return_v;
                    }


                    bool
                    f_10300_51145_51166(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.HasAnyErrors;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 51145, 51166);
                        return return_v;
                    }


                    System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>
                    f_10300_51015_51168(string
                    key, Microsoft.CodeAnalysis.TypedConstant
                    value)
                    {
                        var return_v = new System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 51015, 51168);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10300, 49933, 51347);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10300, 49933, 51347);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private TypedConstant VisitExpression(BoundExpression node, DiagnosticBag diagnostics, ref bool attrHasErrors, bool curArgumentHasErrors)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10300, 51875, 52453);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 52116, 52156);

                    f_10300_52116_52155(f_10300_52135_52144(node) is object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 52174, 52268);

                    var
                    typedConstantKind = f_10300_52198_52267(f_10300_52198_52207(node), f_10300_52247_52266(_binder))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 52288, 52438);

                    return VisitExpression(node, typedConstantKind, diagnostics, ref attrHasErrors, curArgumentHasErrors || (DynAbs.Tracing.TraceSender.Expression_False(10300, 52368, 52436) || typedConstantKind == TypedConstantKind.Error));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10300, 51875, 52453);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                    f_10300_52135_52144(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 52135, 52144);
                        return return_v;
                    }


                    int
                    f_10300_52116_52155(bool
                    b)
                    {
                        RoslynDebug.Assert(b);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 52116, 52155);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10300_52198_52207(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 52198, 52207);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    f_10300_52247_52266(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param)
                    {
                        var return_v = this_param.Compilation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 52247, 52266);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.TypedConstantKind
                    f_10300_52198_52267(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    compilation)
                    {
                        var return_v = type.GetAttributeParameterTypedConstantKind(compilation);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 52198, 52267);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10300, 51875, 52453);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10300, 51875, 52453);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private TypedConstant VisitExpression(BoundExpression node, TypedConstantKind typedConstantKind, DiagnosticBag diagnostics, ref bool attrHasErrors, bool curArgumentHasErrors)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10300, 52469, 54104);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 52747, 52797);

                    ConstantValue?
                    constantValue = f_10300_52778_52796(node)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 52815, 53300) || true) && (constantValue != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 52815, 53300);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 52882, 53022) || true) && (f_10300_52886_52905(constantValue))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 52882, 53022);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 52955, 52999);

                            typedConstantKind = TypedConstantKind.Error;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 52882, 53022);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 53046, 53117);

                        f_10300_53046_53116(node, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 53141, 53281);

                        return CreateTypedConstant(node, typedConstantKind, diagnostics, ref attrHasErrors, curArgumentHasErrors, simpleValue: f_10300_53260_53279(constantValue));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 52815, 53300);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 53320, 54089);

                    switch (f_10300_53328_53337(node))
                    {

                        case BoundKind.Conversion:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 53320, 54089);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 53431, 53531);

                            return VisitConversion((BoundConversion)node, diagnostics, ref attrHasErrors, curArgumentHasErrors);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 53320, 54089);

                        case BoundKind.TypeOfOperator:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 53320, 54089);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 53609, 53719);

                            return VisitTypeOfExpression((BoundTypeOfOperator)node, diagnostics, ref attrHasErrors, curArgumentHasErrors);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 53320, 54089);

                        case BoundKind.ArrayCreation:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 53320, 54089);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 53796, 53902);

                            return VisitArrayCreation((BoundArrayCreation)node, diagnostics, ref attrHasErrors, curArgumentHasErrors);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 53320, 54089);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 53320, 54089);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 53958, 54070);

                            return CreateTypedConstant(node, TypedConstantKind.Error, diagnostics, ref attrHasErrors, curArgumentHasErrors);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 53320, 54089);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10300, 52469, 54104);

                    Microsoft.CodeAnalysis.ConstantValue?
                    f_10300_52778_52796(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.ConstantValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 52778, 52796);
                        return return_v;
                    }


                    bool
                    f_10300_52886_52905(Microsoft.CodeAnalysis.ConstantValue
                    this_param)
                    {
                        var return_v = this_param.IsBad;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 52886, 52905);
                        return return_v;
                    }


                    int
                    f_10300_53046_53116(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    expression, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics)
                    {
                        ConstantValueUtils.CheckLangVersionForConstantValue(expression, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 53046, 53116);
                        return 0;
                    }


                    object?
                    f_10300_53260_53279(Microsoft.CodeAnalysis.ConstantValue
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 53260, 53279);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundKind
                    f_10300_53328_53337(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 53328, 53337);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10300, 52469, 54104);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10300, 52469, 54104);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private TypedConstant VisitConversion(BoundConversion node, DiagnosticBag diagnostics, ref bool attrHasErrors, bool curArgumentHasErrors)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10300, 54120, 55911);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 54290, 54331);

                    f_10300_54290_54330(f_10300_54303_54321(node) == null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 54997, 55018);

                    var
                    type = f_10300_55008_55017(node)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 55036, 55063);

                    var
                    operand = f_10300_55050_55062(node)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 55081, 55112);

                    var
                    operandType = f_10300_55099_55111(operand)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 55132, 55764) || true) && ((object)type != null && (DynAbs.Tracing.TraceSender.Expression_True(10300, 55136, 55181) && operandType is object))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 55132, 55764);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 55223, 55745) || true) && (f_10300_55227_55243(type) == SpecialType.System_Object || (DynAbs.Tracing.TraceSender.Expression_False(10300, 55227, 55445) || f_10300_55301_55322(operandType) && (DynAbs.Tracing.TraceSender.Expression_True(10300, 55301, 55340) && f_10300_55326_55340(type)) && (DynAbs.Tracing.TraceSender.Expression_True(10300, 55301, 55445) && f_10300_55369_55416(f_10300_55369_55404(((ArrayTypeSymbol)type))) == SpecialType.System_Object)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 55223, 55745);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 55495, 55591);

                            var
                            typedConstantKind = f_10300_55519_55590(operandType, f_10300_55570_55589(_binder))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 55617, 55722);

                            return VisitExpression(operand, typedConstantKind, diagnostics, ref attrHasErrors, curArgumentHasErrors);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 55223, 55745);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 55132, 55764);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 55784, 55896);

                    return CreateTypedConstant(node, TypedConstantKind.Error, diagnostics, ref attrHasErrors, curArgumentHasErrors);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10300, 54120, 55911);

                    Microsoft.CodeAnalysis.ConstantValue?
                    f_10300_54303_54321(Microsoft.CodeAnalysis.CSharp.BoundConversion
                    this_param)
                    {
                        var return_v = this_param.ConstantValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 54303, 54321);
                        return return_v;
                    }


                    int
                    f_10300_54290_54330(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 54290, 54330);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10300_55008_55017(Microsoft.CodeAnalysis.CSharp.BoundConversion
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 55008, 55017);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10300_55050_55062(Microsoft.CodeAnalysis.CSharp.BoundConversion
                    this_param)
                    {
                        var return_v = this_param.Operand;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 55050, 55062);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                    f_10300_55099_55111(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 55099, 55111);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SpecialType
                    f_10300_55227_55243(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param)
                    {
                        var return_v = this_param.SpecialType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 55227, 55243);
                        return return_v;
                    }


                    bool
                    f_10300_55301_55322(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type)
                    {
                        var return_v = type.IsArray();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 55301, 55322);
                        return return_v;
                    }


                    bool
                    f_10300_55326_55340(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type)
                    {
                        var return_v = type.IsArray();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 55326, 55340);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10300_55369_55404(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ElementType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 55369, 55404);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SpecialType
                    f_10300_55369_55416(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param)
                    {
                        var return_v = this_param.SpecialType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 55369, 55416);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    f_10300_55570_55589(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param)
                    {
                        var return_v = this_param.Compilation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 55570, 55589);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.TypedConstantKind
                    f_10300_55519_55590(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    compilation)
                    {
                        var return_v = type.GetAttributeParameterTypedConstantKind(compilation);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 55519, 55590);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10300, 54120, 55911);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10300, 54120, 55911);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private static TypedConstant VisitTypeOfExpression(BoundTypeOfOperator node, DiagnosticBag diagnostics, ref bool attrHasErrors, bool curArgumentHasErrors)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10300, 55927, 57724);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 56114, 56169);

                    var
                    typeOfArgument = (TypeSymbol?)f_10300_56148_56168(f_10300_56148_56163(node))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 56394, 57543) || true) && (typeOfArgument is object)
                    ) // skip this if the argument was an alias symbol

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 56394, 57543);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 56513, 56540);

                        var
                        isValidArgument = true
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 56562, 57054);

                        switch (f_10300_56570_56589(typeOfArgument))
                        {

                            case SymbolKind.TypeParameter:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 56562, 57054);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 56770, 56794);

                                isValidArgument = false;
                                DynAbs.Tracing.TraceSender.TraceBreak(10300, 56824, 56830);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 56562, 57054);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 56562, 57054);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 56896, 56995);

                                isValidArgument = f_10300_56914_56951(typeOfArgument) || (DynAbs.Tracing.TraceSender.Expression_False(10300, 56914, 56994) || !f_10300_56956_56994(typeOfArgument));
                                DynAbs.Tracing.TraceSender.TraceBreak(10300, 57025, 57031);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 56562, 57054);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 57078, 57524) || true) && (!isValidArgument && (DynAbs.Tracing.TraceSender.Expression_True(10300, 57082, 57123) && !curArgumentHasErrors))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 57078, 57524);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 57248, 57400);

                            f_10300_57248_57399(diagnostics, ErrorCode.ERR_AttrArgWithTypeVars, node.Syntax, f_10300_57322_57398(typeOfArgument, f_10300_57353_57397()));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 57426, 57454);

                            curArgumentHasErrors = true;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 57480, 57501);

                            attrHasErrors = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 57078, 57524);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 56394, 57543);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 57563, 57709);

                    return CreateTypedConstant(node, TypedConstantKind.Type, diagnostics, ref attrHasErrors, curArgumentHasErrors, simpleValue: f_10300_57687_57707(f_10300_57687_57702(node)));
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10300, 55927, 57724);

                    Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                    f_10300_56148_56163(Microsoft.CodeAnalysis.CSharp.BoundTypeOfOperator
                    this_param)
                    {
                        var return_v = this_param.SourceType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 56148, 56163);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10300_56148_56168(Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 56148, 56168);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SymbolKind
                    f_10300_56570_56589(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 56570, 56589);
                        return return_v;
                    }


                    bool
                    f_10300_56914_56951(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type)
                    {
                        var return_v = type.IsUnboundGenericType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 56914, 56951);
                        return return_v;
                    }


                    bool
                    f_10300_56956_56994(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type)
                    {
                        var return_v = type.ContainsTypeParameter();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 56956, 56994);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SymbolDisplayFormat
                    f_10300_57353_57397()
                    {
                        var return_v = SymbolDisplayFormat.CSharpErrorMessageFormat;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 57353, 57397);
                        return return_v;
                    }


                    string
                    f_10300_57322_57398(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param, Microsoft.CodeAnalysis.SymbolDisplayFormat
                    format)
                    {
                        var return_v = this_param.ToDisplayString(format);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 57322, 57398);
                        return return_v;
                    }


                    int
                    f_10300_57248_57399(Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                    code, Microsoft.CodeAnalysis.SyntaxNode
                    syntax, params object[]
                    args)
                    {
                        Binder.Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 57248, 57399);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                    f_10300_57687_57702(Microsoft.CodeAnalysis.CSharp.BoundTypeOfOperator
                    this_param)
                    {
                        var return_v = this_param.SourceType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 57687, 57702);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10300_57687_57707(Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 57687, 57707);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10300, 55927, 57724);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10300, 55927, 57724);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private TypedConstant VisitArrayCreation(BoundArrayCreation node, DiagnosticBag diagnostics, ref bool attrHasErrors, bool curArgumentHasErrors)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10300, 57740, 59662);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 57916, 57969);

                    ImmutableArray<BoundExpression>
                    bounds = f_10300_57957_57968(node)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 57987, 58019);

                    int
                    boundsCount = bounds.Length
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 58039, 58231) || true) && (boundsCount > 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 58039, 58231);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 58100, 58212);

                        return CreateTypedConstant(node, TypedConstantKind.Error, diagnostics, ref attrHasErrors, curArgumentHasErrors);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 58039, 58231);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 58251, 58289);

                    var
                    type = (ArrayTypeSymbol)f_10300_58279_58288(node)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 58307, 58396);

                    var
                    typedConstantKind = f_10300_58331_58395(type, f_10300_58375_58394(_binder))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 58416, 58458);

                    ImmutableArray<TypedConstant>
                    initializer
                    = default(ImmutableArray<TypedConstant>);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 58476, 59496) || true) && (f_10300_58480_58499(node) == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 58476, 59496);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 58549, 59278) || true) && (boundsCount == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 58549, 59278);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 58619, 58669);

                            initializer = ImmutableArray<TypedConstant>.Empty;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 58549, 59278);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 58549, 59278);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 58767, 59255) || true) && (f_10300_58771_58797(bounds[0]))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 58767, 59255);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 58855, 58905);

                                initializer = ImmutableArray<TypedConstant>.Empty;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 58767, 59255);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 58767, 59255);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 59086, 59228);

                                initializer = f_10300_59100_59227(CreateTypedConstant(node, TypedConstantKind.Error, diagnostics, ref attrHasErrors, curArgumentHasErrors));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 58767, 59255);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 58549, 59278);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 58476, 59496);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 58476, 59496);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 59360, 59477);

                        initializer = VisitArguments(f_10300_59389_59421(f_10300_59389_59408(node)), diagnostics, ref attrHasErrors, curArgumentHasErrors);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 58476, 59496);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 59516, 59647);

                    return CreateTypedConstant(node, typedConstantKind, diagnostics, ref attrHasErrors, curArgumentHasErrors, arrayValue: initializer);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10300, 57740, 59662);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                    f_10300_57957_57968(Microsoft.CodeAnalysis.CSharp.BoundArrayCreation
                    this_param)
                    {
                        var return_v = this_param.Bounds;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 57957, 57968);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10300_58279_58288(Microsoft.CodeAnalysis.CSharp.BoundArrayCreation
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 58279, 58288);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    f_10300_58375_58394(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param)
                    {
                        var return_v = this_param.Compilation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 58375, 58394);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.TypedConstantKind
                    f_10300_58331_58395(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                    type, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    compilation)
                    {
                        var return_v = type.GetAttributeParameterTypedConstantKind(compilation);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 58331, 58395);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundArrayInitialization?
                    f_10300_58480_58499(Microsoft.CodeAnalysis.CSharp.BoundArrayCreation
                    this_param)
                    {
                        var return_v = this_param.InitializerOpt;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 58480, 58499);
                        return return_v;
                    }


                    bool
                    f_10300_58771_58797(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    node)
                    {
                        var return_v = node.IsDefaultValue();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 58771, 58797);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                    f_10300_59100_59227(Microsoft.CodeAnalysis.TypedConstant
                    item)
                    {
                        var return_v = ImmutableArray.Create(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 59100, 59227);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundArrayInitialization
                    f_10300_59389_59408(Microsoft.CodeAnalysis.CSharp.BoundArrayCreation
                    this_param)
                    {
                        var return_v = this_param.InitializerOpt;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 59389, 59408);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                    f_10300_59389_59421(Microsoft.CodeAnalysis.CSharp.BoundArrayInitialization
                    this_param)
                    {
                        var return_v = this_param.Initializers;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 59389, 59421);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10300, 57740, 59662);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10300, 57740, 59662);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private static TypedConstant CreateTypedConstant(BoundExpression node, TypedConstantKind typedConstantKind, DiagnosticBag diagnostics, ref bool attrHasErrors, bool curArgumentHasErrors,
                            object? simpleValue = null, ImmutableArray<TypedConstant> arrayValue = default(ImmutableArray<TypedConstant>))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10300, 59678, 62208);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 60024, 60045);

                    var
                    type = f_10300_60035_60044(node)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 60063, 60098);

                    f_10300_60063_60097(type is object);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 60118, 61438) || true) && (typedConstantKind != TypedConstantKind.Error && (DynAbs.Tracing.TraceSender.Expression_True(10300, 60122, 60198) && f_10300_60170_60198(type)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 60118, 61438);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 61375, 61419);

                        typedConstantKind = TypedConstantKind.Error;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 60118, 61438);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 61458, 62193) || true) && (typedConstantKind == TypedConstantKind.Error)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 61458, 62193);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 61548, 61768) || true) && (!curArgumentHasErrors)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 61548, 61768);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 61623, 61698);

                            f_10300_61623_61697(diagnostics, ErrorCode.ERR_BadAttributeArgument, node.Syntax);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 61724, 61745);

                            attrHasErrors = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 61548, 61768);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 61792, 61854);

                        return f_10300_61799_61853(type, TypedConstantKind.Error, null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 61458, 62193);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 61458, 62193);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 61896, 62193) || true) && (typedConstantKind == TypedConstantKind.Array)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 61896, 62193);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 61986, 62029);

                            return f_10300_61993_62028(type, arrayValue);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 61896, 62193);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10300, 61896, 62193);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 62111, 62174);

                            return f_10300_62118_62173(type, typedConstantKind, simpleValue);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 61896, 62193);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10300, 61458, 62193);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10300, 59678, 62208);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                    f_10300_60035_60044(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10300, 60035, 60044);
                        return return_v;
                    }


                    int
                    f_10300_60063_60097(bool
                    b)
                    {
                        RoslynDebug.Assert(b);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 60063, 60097);
                        return 0;
                    }


                    bool
                    f_10300_60170_60198(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type)
                    {
                        var return_v = type.ContainsTypeParameter();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 60170, 60198);
                        return return_v;
                    }


                    int
                    f_10300_61623_61697(Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                    code, Microsoft.CodeAnalysis.SyntaxNode
                    syntax)
                    {
                        Binder.Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 61623, 61697);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.TypedConstant
                    f_10300_61799_61853(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type, Microsoft.CodeAnalysis.TypedConstantKind
                    kind, object?
                    value)
                    {
                        var return_v = new Microsoft.CodeAnalysis.TypedConstant((Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal)type, kind, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 61799, 61853);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.TypedConstant
                    f_10300_61993_62028(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                    array)
                    {
                        var return_v = new Microsoft.CodeAnalysis.TypedConstant((Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal)type, array);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 61993, 62028);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.TypedConstant
                    f_10300_62118_62173(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type, Microsoft.CodeAnalysis.TypedConstantKind
                    kind, object?
                    value)
                    {
                        var return_v = new Microsoft.CodeAnalysis.TypedConstant((Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal)type, kind, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10300, 62118, 62173);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10300, 59678, 62208);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10300, 59678, 62208);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            static AttributeExpressionVisitor()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10300, 47584, 62219);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10300, 47584, 62219);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10300, 47584, 62219);
            }
        }

        private struct AnalyzedAttributeArguments
        {

            internal readonly AnalyzedArguments ConstructorArguments;

            internal readonly ImmutableArray<BoundExpression> NamedArguments;

            internal AnalyzedAttributeArguments(AnalyzedArguments constructorArguments, ImmutableArray<BoundExpression> namedArguments)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10300, 62517, 62792);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 62673, 62722);

                    this.ConstructorArguments = constructorArguments;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10300, 62740, 62777);

                    this.NamedArguments = namedArguments;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10300, 62517, 62792);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10300, 62517, 62792);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10300, 62517, 62792);
                }
            }
            static AnalyzedAttributeArguments()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10300, 62299, 62803);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10300, 62299, 62803);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10300, 62299, 62803);
            }
        }
    }
}
