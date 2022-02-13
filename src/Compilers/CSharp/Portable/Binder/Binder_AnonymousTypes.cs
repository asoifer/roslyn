// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.CodeAnalysis.Collections;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class Binder
    {
        private BoundExpression BindAnonymousObjectCreation(AnonymousObjectCreationExpressionSyntax node, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10299, 750, 6813);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 924, 961);

                var
                initializers = f_10299_943_960(node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 975, 1011);

                int
                fieldCount = initializers.Count
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 1025, 1047);

                bool
                hasError = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 1104, 1173);

                BoundExpression[]
                boundExpressions = new BoundExpression[fieldCount]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 1187, 1252);

                AnonymousTypeField[]
                fields = new AnonymousTypeField[fieldCount]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 1266, 1337);

                CSharpSyntaxNode[]
                fieldSyntaxNodes = new CSharpSyntaxNode[fieldCount]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 1806, 1865);

                var
                uniqueFieldNames = f_10299_1829_1864()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 1890, 1895);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 1881, 4509) || true) && (i < fieldCount)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 1913, 1916)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10299, 1881, 4509))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10299, 1881, 4509);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 1950, 2023);

                        AnonymousObjectMemberDeclaratorSyntax
                        fieldInitializer = initializers[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 2041, 2100);

                        NameEqualsSyntax?
                        nameEquals = f_10299_2072_2099(fieldInitializer)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 2118, 2176);

                        ExpressionSyntax
                        expression = f_10299_2148_2175(fieldInitializer)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 2196, 2241);

                        SyntaxToken
                        nameToken = default(SyntaxToken)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 2259, 2800) || true) && (nameEquals != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10299, 2259, 2800);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 2323, 2362);

                            nameToken = f_10299_2335_2361(f_10299_2335_2350(nameEquals));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10299, 2259, 2800);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10299, 2259, 2800);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 2444, 2701) || true) && (!f_10299_2449_2492(expression))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10299, 2444, 2701);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 2542, 2558);

                                hasError = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 2584, 2678);

                                f_10299_2584_2677(diagnostics, ErrorCode.ERR_InvalidAnonymousTypeMemberDeclarator, f_10299_2652_2676(expression));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10299, 2444, 2701);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 2725, 2781);

                            nameToken = f_10299_2737_2780(expression);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10299, 2259, 2800);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 2820, 2853);

                        hasError |= f_10299_2832_2852(expression);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 2871, 2946);

                        boundExpressions[i] = f_10299_2893_2945(this, expression, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 3015, 3040);

                        string?
                        fieldName = null
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 3058, 3716) || true) && (nameToken.Kind() == SyntaxKind.IdentifierToken)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10299, 3058, 3716);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 3150, 3182);

                            fieldName = nameToken.ValueText;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 3204, 3532) || true) && (!f_10299_3209_3241(uniqueFieldNames, fieldName!))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10299, 3204, 3532);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 3337, 3424);

                                f_10299_3337_3423(diagnostics, ErrorCode.ERR_AnonymousTypeDuplicatePropertyName, fieldInitializer);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 3450, 3466);

                                hasError = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 3492, 3509);

                                fieldName = null;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10299, 3204, 3532);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10299, 3058, 3716);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10299, 3058, 3716);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 3681, 3697);

                            hasError = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10299, 3058, 3716);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 3817, 3932);

                        TypeSymbol
                        fieldType = f_10299_3840_3931(this, boundExpressions[i], fieldInitializer, diagnostics, ref hasError)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 4010, 4138);

                        fieldSyntaxNodes[i] = (DynAbs.Tracing.TraceSender.Conditional_F1(10299, 4032, 4080) || (((nameToken.Kind() == SyntaxKind.IdentifierToken) && DynAbs.Tracing.TraceSender.Conditional_F2(10299, 4083, 4118)) || DynAbs.Tracing.TraceSender.Conditional_F3(10299, 4121, 4137))) ? (CSharpSyntaxNode)nameToken.Parent! : fieldInitializer;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 4156, 4376);

                        fields[i] = f_10299_4168_4375((DynAbs.Tracing.TraceSender.Conditional_F1(10299, 4213, 4230) || ((fieldName == null && DynAbs.Tracing.TraceSender.Conditional_F2(10299, 4233, 4251)) || DynAbs.Tracing.TraceSender.Conditional_F3(10299, 4254, 4263))) ? "$" + f_10299_4239_4251(i) : fieldName, f_10299_4286_4314(fieldSyntaxNodes[i]), TypeWithAnnotations.Create(fieldType));
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10299, 1, 2629);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10299, 1, 2629);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 4525, 4549);

                f_10299_4525_4548(
                            uniqueFieldNames);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 4605, 4674);

                AnonymousTypeManager
                manager = f_10299_4636_4673(f_10299_4636_4652(this))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 4688, 4812);

                AnonymousTypeDescriptor
                descriptor = f_10299_4725_4811(f_10299_4753_4779(fields), node.NewKeyword.GetLocation())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 4826, 4907);

                NamedTypeSymbol
                anonymousType = f_10299_4858_4906(manager, descriptor)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 5076, 5217);

                ArrayBuilder<BoundAnonymousPropertyDeclaration>
                declarators =
                f_10299_5155_5216()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 5240, 5245);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 5231, 6157) || true) && (i < fieldCount)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 5263, 5266)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10299, 5231, 6157))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10299, 5231, 6157);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 5300, 5360);

                        NameEqualsSyntax?
                        explicitName = f_10299_5333_5359(initializers[i])
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 5378, 6142) || true) && (explicitName != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10299, 5378, 6142);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 5444, 5481);

                            AnonymousTypeField
                            field = fields[i]
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 5503, 6123) || true) && (field.Name != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10299, 5503, 6123);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 5669, 6100);
                                    foreach (var symbol in f_10299_5692_5728_I(f_10299_5692_5728(anonymousType, field.Name)))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10299, 5669, 6100);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 5786, 6073) || true) && (f_10299_5790_5801(symbol) == SymbolKind.Property)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10299, 5786, 6073);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 5890, 6002);

                                            f_10299_5890_6001(declarators, f_10299_5906_6000(fieldSyntaxNodes[i], (PropertySymbol)symbol, field.Type));
                                            DynAbs.Tracing.TraceSender.TraceBreak(10299, 6036, 6042);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10299, 5786, 6073);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10299, 5669, 6100);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10299, 1, 432);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(10299, 1, 432);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10299, 5503, 6123);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10299, 5378, 6142);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10299, 1, 927);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10299, 1, 927);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 6251, 6446) || true) && (!f_10299_6256_6286(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10299, 6251, 6446);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 6320, 6397);

                    f_10299_6320_6396(diagnostics, ErrorCode.ERR_AnonymousTypeNotAvailable, f_10299_6380_6395(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 6415, 6431);

                    hasError = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10299, 6251, 6446);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 6507, 6802);

                return f_10299_6514_6801(node, f_10299_6598_6632(anonymousType)[0], f_10299_6654_6690(boundExpressions), f_10299_6709_6741(declarators), anonymousType, hasError);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10299, 750, 6813);

                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousObjectMemberDeclaratorSyntax>
                f_10299_943_960(Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousObjectCreationExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Initializers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10299, 943, 960);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<string>
                f_10299_1829_1864()
                {
                    var return_v = PooledHashSet<string>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10299, 1829, 1864);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax?
                f_10299_2072_2099(Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousObjectMemberDeclaratorSyntax
                this_param)
                {
                    var return_v = this_param.NameEquals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10299, 2072, 2099);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10299_2148_2175(Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousObjectMemberDeclaratorSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10299, 2148, 2175);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                f_10299_2335_2350(Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10299, 2335, 2350);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10299_2335_2361(Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                this_param)
                {
                    var return_v = this_param.Identifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10299, 2335, 2361);
                    return return_v;
                }


                bool
                f_10299_2449_2492(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                expr)
                {
                    var return_v = IsAnonymousTypeMemberExpression(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10299, 2449, 2492);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10299_2652_2676(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.GetLocation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10299, 2652, 2676);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10299_2584_2677(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10299, 2584, 2677);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10299_2737_2780(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                input)
                {
                    var return_v = input.ExtractAnonymousTypeMemberName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10299, 2737, 2780);
                    return return_v;
                }


                bool
                f_10299_2832_2852(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.HasErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10299, 2832, 2852);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10299_2893_2945(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindRValueWithoutTargetType(node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10299, 2893, 2945);
                    return return_v;
                }


                bool
                f_10299_3209_3241(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10299, 3209, 3241);
                    return return_v;
                }


                int
                f_10299_3337_3423(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousObjectMemberDeclaratorSyntax
                syntax)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10299, 3337, 3423);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10299_3840_3931(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousObjectMemberDeclaratorSyntax
                errorSyntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, ref bool
                hasError)
                {
                    var return_v = this_param.GetAnonymousTypeFieldType(expression, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)errorSyntax, diagnostics, ref hasError);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10299, 3840, 3931);
                    return return_v;
                }


                string
                f_10299_4239_4251(int
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10299, 4239, 4251);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10299_4286_4314(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10299, 4286, 4314);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeField
                f_10299_4168_4375(string
                name, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                typeWithAnnotations)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeField(name, location, typeWithAnnotations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10299, 4168, 4375);
                    return return_v;
                }


                int
                f_10299_4525_4548(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<string>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10299, 4525, 4548);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10299_4636_4652(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10299, 4636, 4652);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                f_10299_4636_4673(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.AnonymousTypeManager;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10299, 4636, 4673);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeField>
                f_10299_4753_4779(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeField[]
                items)
                {
                    var return_v = items.AsImmutableOrNull<Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeField>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10299, 4753, 4779);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeDescriptor
                f_10299_4725_4811(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeField>
                fields, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeDescriptor(fields, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10299, 4725, 4811);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10299_4858_4906(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeDescriptor
                typeDescr)
                {
                    var return_v = this_param.ConstructAnonymousTypeSymbol(typeDescr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10299, 4858, 4906);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundAnonymousPropertyDeclaration>
                f_10299_5155_5216()
                {
                    var return_v = ArrayBuilder<BoundAnonymousPropertyDeclaration>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10299, 5155, 5216);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax?
                f_10299_5333_5359(Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousObjectMemberDeclaratorSyntax
                this_param)
                {
                    var return_v = this_param.NameEquals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10299, 5333, 5359);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10299_5692_5728(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10299, 5692, 5728);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10299_5790_5801(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10299, 5790, 5801);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundAnonymousPropertyDeclaration
                f_10299_5906_6000(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbol
                property, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundAnonymousPropertyDeclaration((Microsoft.CodeAnalysis.SyntaxNode)syntax, (Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol)property, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10299, 5906, 6000);
                    return return_v;
                }


                int
                f_10299_5890_6001(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundAnonymousPropertyDeclaration>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundAnonymousPropertyDeclaration
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10299, 5890, 6001);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10299_5692_5728_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10299, 5692, 5728);
                    return return_v;
                }


                bool
                f_10299_6256_6286(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.IsAnonymousTypesAllowed();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10299, 6256, 6286);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10299_6380_6395(Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousObjectCreationExpressionSyntax
                this_param)
                {
                    var return_v = this_param.NewKeyword;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10299, 6380, 6395);
                    return return_v;
                }


                int
                f_10299_6320_6396(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxToken
                token)
                {
                    Error(diagnostics, code, token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10299, 6320, 6396);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10299_6598_6632(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.InstanceConstructors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10299, 6598, 6632);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10299_6654_6690(Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                items)
                {
                    var return_v = items.AsImmutableOrNull<Microsoft.CodeAnalysis.CSharp.BoundExpression>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10299, 6654, 6690);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundAnonymousPropertyDeclaration>
                f_10299_6709_6741(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundAnonymousPropertyDeclaration>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10299, 6709, 6741);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundAnonymousObjectCreationExpression
                f_10299_6514_6801(Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousObjectCreationExpressionSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                constructor, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundAnonymousPropertyDeclaration>
                declarations, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundAnonymousObjectCreationExpression((Microsoft.CodeAnalysis.SyntaxNode)syntax, constructor, arguments, declarations, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10299, 6514, 6801);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10299, 750, 6813);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10299, 750, 6813);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsAnonymousTypeMemberExpression(ExpressionSyntax expr)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10299, 6825, 7800);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 6924, 7789) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10299, 6924, 7789);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 6969, 7774);

                        switch (f_10299_6977_6988(expr))
                        {

                            case SyntaxKind.QualifiedName:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10299, 6969, 7774);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 7086, 7127);

                                expr = f_10299_7093_7126(((QualifiedNameSyntax)expr));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 7153, 7162);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10299, 6969, 7774);

                            case SyntaxKind.ConditionalAccessExpression:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10299, 6969, 7774);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 7254, 7315);

                                expr = f_10299_7261_7314(((ConditionalAccessExpressionSyntax)expr));

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 7341, 7491) || true) && (f_10299_7345_7356(expr) == SyntaxKind.MemberBindingExpression)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10299, 7341, 7491);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 7452, 7464);

                                    return true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10299, 7341, 7491);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 7519, 7528);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10299, 6969, 7774);

                            case SyntaxKind.IdentifierName:
                            case SyntaxKind.SimpleMemberAccessExpression:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10299, 6969, 7774);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 7674, 7686);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10299, 6969, 7774);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10299, 6969, 7774);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 7742, 7755);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10299, 6969, 7774);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10299, 6924, 7789);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10299, 6924, 7789);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10299, 6924, 7789);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10299, 6825, 7800);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10299_6977_6988(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10299, 6977, 6988);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                f_10299_7093_7126(Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedNameSyntax
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10299, 7093, 7126);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10299_7261_7314(Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalAccessExpressionSyntax
                this_param)
                {
                    var return_v = this_param.WhenNotNull;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10299, 7261, 7314);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10299_7345_7356(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10299, 7345, 7356);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10299, 6825, 7800);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10299, 6825, 7800);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool IsAnonymousTypesAllowed()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10299, 8157, 8829);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 8220, 8263);

                var
                member = f_10299_8233_8262(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 8277, 8357) || true) && (member is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10299, 8277, 8357);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 8329, 8342);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10299, 8277, 8357);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 8373, 8789);

                switch (f_10299_8381_8392(member))
                {

                    case SymbolKind.Method:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10299, 8373, 8789);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 8471, 8483);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10299, 8373, 8789);

                    case SymbolKind.Field:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10299, 8373, 8789);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 8547, 8585);

                        return f_10299_8554_8584_M(!((FieldSymbol)member).IsConst);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10299, 8373, 8789);

                    case SymbolKind.NamedType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10299, 8373, 8789);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 8727, 8774);

                        return f_10299_8734_8773(((NamedTypeSymbol)member));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10299, 8373, 8789);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 8805, 8818);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10299, 8157, 8829);

                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10299_8233_8262(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.ContainingMemberOrLambda;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10299, 8233, 8262);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10299_8381_8392(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10299, 8381, 8392);
                    return return_v;
                }


                bool
                f_10299_8554_8584_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10299, 8554, 8584);
                    return return_v;
                }


                bool
                f_10299_8734_8773(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsScriptClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10299, 8734, 8773);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10299, 8157, 8829);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10299, 8157, 8829);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private TypeSymbol GetAnonymousTypeFieldType(BoundExpression expression, CSharpSyntaxNode errorSyntax, DiagnosticBag diagnostics, ref bool hasError)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10299, 9037, 10870);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 9210, 9234);

                object?
                errorArg = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 9248, 9293);

                TypeSymbol?
                expressionType = f_10299_9277_9292(expression)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 9309, 10314) || true) && (f_10299_9313_9337_M(!expression.HasAnyErrors))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10299, 9309, 10314);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 9371, 10299) || true) && (f_10299_9375_9405(expression))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10299, 9371, 10299);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 9447, 9492);

                        f_10299_9447_9491(expressionType is object);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 9514, 10168) || true) && (f_10299_9518_9545(expressionType))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10299, 9514, 10168);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 9595, 9621);

                            errorArg = expressionType;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 9647, 9725);

                            expressionType = f_10299_9664_9724(this, f_10299_9680_9723(SyntaxKind.VoidKeyword));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10299, 9514, 10168);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10299, 9514, 10168);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 9775, 10168) || true) && (f_10299_9779_9804(expressionType))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10299, 9775, 10168);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 9854, 9880);

                                errorArg = expressionType;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10299, 9775, 10168);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10299, 9775, 10168);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 10032, 10168) || true) && (f_10299_10036_10069(expressionType))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10299, 10032, 10168);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 10119, 10145);

                                    errorArg = expressionType;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10299, 10032, 10168);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10299, 9775, 10168);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10299, 9514, 10168);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10299, 9371, 10299);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10299, 9371, 10299);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 10250, 10280);

                        errorArg = f_10299_10261_10279(expression);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10299, 9371, 10299);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10299, 9309, 10314);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 10330, 10447) || true) && (expressionType is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10299, 10330, 10447);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 10390, 10432);

                    expressionType = f_10299_10407_10431(this, "error");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10299, 10330, 10447);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 10463, 10821) || true) && (errorArg != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10299, 10463, 10821);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 10517, 10533);

                    hasError = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 10551, 10646);

                    f_10299_10551_10645(diagnostics, ErrorCode.ERR_AnonymousTypePropertyAssignedBadValue, errorSyntax, errorArg);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10299, 10463, 10821);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10299, 10837, 10859);

                return expressionType;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10299, 9037, 10870);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10299_9277_9292(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10299, 9277, 9292);
                    return return_v;
                }


                bool
                f_10299_9313_9337_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10299, 9313, 9337);
                    return return_v;
                }


                bool
                f_10299_9375_9405(Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = node.HasExpressionType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10299, 9375, 9405);
                    return return_v;
                }


                int
                f_10299_9447_9491(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10299, 9447, 9491);
                    return 0;
                }


                bool
                f_10299_9518_9545(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsVoidType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10299, 9518, 9545);
                    return return_v;
                }


                string
                f_10299_9680_9723(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.GetText(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10299, 9680, 9723);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10299_9664_9724(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, string
                name)
                {
                    var return_v = this_param.CreateErrorType(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10299, 9664, 9724);
                    return return_v;
                }


                bool
                f_10299_9779_9804(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsUnsafe();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10299, 9779, 9804);
                    return return_v;
                }


                bool
                f_10299_10036_10069(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsRestrictedType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10299, 10036, 10069);
                    return return_v;
                }


                object
                f_10299_10261_10279(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Display;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10299, 10261, 10279);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10299_10407_10431(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, string
                name)
                {
                    var return_v = this_param.CreateErrorType(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10299, 10407, 10431);
                    return return_v;
                }


                int
                f_10299_10551_10645(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10299, 10551, 10645);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10299, 9037, 10870);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10299, 9037, 10870);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
