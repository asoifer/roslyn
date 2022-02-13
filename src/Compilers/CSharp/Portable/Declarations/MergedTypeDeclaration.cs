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
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    [DebuggerDisplay("{GetDebuggerDisplay(), nq}")]
    internal sealed class MergedTypeDeclaration : MergedNamespaceOrTypeDeclaration
    {
        private readonly ImmutableArray<SingleTypeDeclaration> _declarations;

        private ImmutableArray<MergedTypeDeclaration> _lazyChildren;

        private ICollection<string> _lazyMemberNames;

        internal MergedTypeDeclaration(ImmutableArray<SingleTypeDeclaration> declarations)
        : base(f_10395_1137_1157_C(f_10395_1137_1157(declarations[0])))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10395, 1034, 1223);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10395, 1005, 1021);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10395, 1183, 1212);

                _declarations = declarations;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10395, 1034, 1223);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10395, 1034, 1223);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10395, 1034, 1223);
            }
        }

        public ImmutableArray<SingleTypeDeclaration> Declarations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10395, 1317, 1389);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10395, 1353, 1374);

                    return _declarations;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10395, 1317, 1389);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10395, 1235, 1400);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10395, 1235, 1400);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ImmutableArray<SyntaxReference> SyntaxReferences
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10395, 1492, 1602);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10395, 1528, 1587);

                    return _declarations.SelectAsArray(r => r.SyntaxReference);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10395, 1492, 1602);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10395, 1412, 1613);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10395, 1412, 1613);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ImmutableArray<SyntaxList<AttributeListSyntax>> GetAttributeDeclarations()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10395, 1625, 3289);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10395, 1731, 1824);

                var
                attributeSyntaxListBuilder = f_10395_1764_1823()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10395, 1840, 3207);
                    foreach (var decl in f_10395_1861_1874_I(_declarations))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10395, 1840, 3207);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10395, 1908, 2004) || true) && (f_10395_1912_1934_M(!decl.HasAnyAttributes))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10395, 1908, 2004);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10395, 1976, 1985);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10395, 1908, 2004);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10395, 2024, 2061);

                        var
                        syntaxRef = f_10395_2040_2060(decl)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10395, 2079, 2116);

                        var
                        typeDecl = f_10395_2094_2115(syntaxRef)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10395, 2134, 2187);

                        SyntaxList<AttributeListSyntax>
                        attributesSyntaxList
                        = default(SyntaxList<AttributeListSyntax>);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10395, 2205, 3119);

                        switch (f_10395_2213_2228(typeDecl))
                        {

                            case SyntaxKind.ClassDeclaration:
                            case SyntaxKind.StructDeclaration:
                            case SyntaxKind.InterfaceDeclaration:
                            case SyntaxKind.RecordDeclaration:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10395, 2205, 3119);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10395, 2500, 2572);

                                attributesSyntaxList = f_10395_2523_2571(((TypeDeclarationSyntax)typeDecl));
                                DynAbs.Tracing.TraceSender.TraceBreak(10395, 2598, 2604);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10395, 2205, 3119);

                            case SyntaxKind.DelegateDeclaration:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10395, 2205, 3119);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10395, 2690, 2766);

                                attributesSyntaxList = f_10395_2713_2765(((DelegateDeclarationSyntax)typeDecl));
                                DynAbs.Tracing.TraceSender.TraceBreak(10395, 2792, 2798);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10395, 2205, 3119);

                            case SyntaxKind.EnumDeclaration:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10395, 2205, 3119);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10395, 2880, 2952);

                                attributesSyntaxList = f_10395_2903_2951(((EnumDeclarationSyntax)typeDecl));
                                DynAbs.Tracing.TraceSender.TraceBreak(10395, 2978, 2984);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10395, 2205, 3119);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10395, 2205, 3119);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10395, 3042, 3100);

                                throw f_10395_3048_3099(f_10395_3083_3098(typeDecl));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10395, 2205, 3119);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10395, 3139, 3192);

                        f_10395_3139_3191(
                                        attributeSyntaxListBuilder, attributesSyntaxList);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10395, 1840, 3207);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10395, 1, 1368);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10395, 1, 1368);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10395, 3223, 3278);

                return f_10395_3230_3277(attributeSyntaxListBuilder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10395, 1625, 3289);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                f_10395_1764_1823()
                {
                    var return_v = ArrayBuilder<SyntaxList<AttributeListSyntax>>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10395, 1764, 1823);
                    return return_v;
                }


                bool
                f_10395_1912_1934_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10395, 1912, 1934);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxReference
                f_10395_2040_2060(Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration
                this_param)
                {
                    var return_v = this_param.SyntaxReference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10395, 2040, 2060);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10395_2094_2115(Microsoft.CodeAnalysis.SyntaxReference
                this_param)
                {
                    var return_v = this_param.GetSyntax();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10395, 2094, 2115);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10395_2213_2228(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10395, 2213, 2228);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                f_10395_2523_2571(Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.AttributeLists;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10395, 2523, 2571);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                f_10395_2713_2765(Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.AttributeLists;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10395, 2713, 2765);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                f_10395_2903_2951(Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.AttributeLists;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10395, 2903, 2951);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10395_3083_3098(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10395, 3083, 3098);
                    return return_v;
                }


                System.Exception
                f_10395_3048_3099(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10395, 3048, 3099);
                    return return_v;
                }


                int
                f_10395_3139_3191(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                this_param, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10395, 3139, 3191);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                f_10395_1861_1874_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10395, 1861, 1874);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                f_10395_3230_3277(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10395, 3230, 3277);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10395, 1625, 3289);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10395, 1625, 3289);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override DeclarationKind Kind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10395, 3362, 3446);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10395, 3398, 3431);

                    return f_10395_3405_3430(f_10395_3405_3422(this)[0]);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10395, 3362, 3446);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                    f_10395_3405_3422(Microsoft.CodeAnalysis.CSharp.MergedTypeDeclaration
                    this_param)
                    {
                        var return_v = this_param.Declarations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10395, 3405, 3422);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.DeclarationKind
                    f_10395_3405_3430(Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10395, 3405, 3430);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10395, 3301, 3457);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10395, 3301, 3457);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public int Arity
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10395, 3510, 3595);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10395, 3546, 3580);

                    return f_10395_3553_3579(f_10395_3553_3570(this)[0]);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10395, 3510, 3595);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                    f_10395_3553_3570(Microsoft.CodeAnalysis.CSharp.MergedTypeDeclaration
                    this_param)
                    {
                        var return_v = this_param.Declarations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10395, 3553, 3570);
                        return return_v;
                    }


                    int
                    f_10395_3553_3579(Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration
                    this_param)
                    {
                        var return_v = this_param.Arity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10395, 3553, 3579);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10395, 3469, 3606);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10395, 3469, 3606);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool ContainsExtensionMethods
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10395, 3679, 3943);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10395, 3715, 3895);
                        foreach (var decl in f_10395_3736_3753_I(f_10395_3736_3753(this)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10395, 3715, 3895);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10395, 3795, 3876) || true) && (f_10395_3799_3837(decl))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10395, 3795, 3876);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10395, 3864, 3876);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10395, 3795, 3876);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10395, 3715, 3895);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10395, 1, 181);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10395, 1, 181);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10395, 3915, 3928);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10395, 3679, 3943);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                    f_10395_3736_3753(Microsoft.CodeAnalysis.CSharp.MergedTypeDeclaration
                    this_param)
                    {
                        var return_v = this_param.Declarations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10395, 3736, 3753);
                        return return_v;
                    }


                    bool
                    f_10395_3799_3837(Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration
                    this_param)
                    {
                        var return_v = this_param.AnyMemberHasExtensionMethodSyntax;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10395, 3799, 3837);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                    f_10395_3736_3753_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10395, 3736, 3753);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10395, 3618, 3954);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10395, 3618, 3954);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool AnyMemberHasAttributes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10395, 4025, 4278);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10395, 4061, 4230);
                        foreach (var decl in f_10395_4082_4099_I(f_10395_4082_4099(this)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10395, 4061, 4230);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10395, 4141, 4211) || true) && (f_10395_4145_4172(decl))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10395, 4141, 4211);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10395, 4199, 4211);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10395, 4141, 4211);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10395, 4061, 4230);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10395, 1, 170);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10395, 1, 170);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10395, 4250, 4263);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10395, 4025, 4278);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                    f_10395_4082_4099(Microsoft.CodeAnalysis.CSharp.MergedTypeDeclaration
                    this_param)
                    {
                        var return_v = this_param.Declarations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10395, 4082, 4099);
                        return return_v;
                    }


                    bool
                    f_10395_4145_4172(Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration
                    this_param)
                    {
                        var return_v = this_param.AnyMemberHasAttributes;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10395, 4145, 4172);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                    f_10395_4082_4099_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10395, 4082, 4099);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10395, 3966, 4289);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10395, 3966, 4289);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public LexicalSortKey GetLexicalSortKey(CSharpCompilation compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10395, 4301, 4735);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10395, 4396, 4483);

                LexicalSortKey
                sortKey = f_10395_4421_4482(f_10395_4440_4468(f_10395_4440_4452()[0]), compilation)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10395, 4506, 4511);
                    for (var
        i = 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10395, 4497, 4693) || true) && (i < f_10395_4517_4529().Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10395, 4538, 4541)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10395, 4497, 4693))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10395, 4497, 4693);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10395, 4575, 4678);

                        sortKey = LexicalSortKey.First(sortKey, f_10395_4615_4676(f_10395_4634_4662(f_10395_4634_4646()[i]), compilation));
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10395, 1, 197);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10395, 1, 197);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10395, 4709, 4724);

                return sortKey;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10395, 4301, 4735);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                f_10395_4440_4452()
                {
                    var return_v = Declarations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10395, 4440, 4452);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceLocation
                f_10395_4440_4468(Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration
                this_param)
                {
                    var return_v = this_param.NameLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10395, 4440, 4468);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LexicalSortKey
                f_10395_4421_4482(Microsoft.CodeAnalysis.SourceLocation
                location, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.LexicalSortKey((Microsoft.CodeAnalysis.Location)location, compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10395, 4421, 4482);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                f_10395_4517_4529()
                {
                    var return_v = Declarations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10395, 4517, 4529);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                f_10395_4634_4646()
                {
                    var return_v = Declarations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10395, 4634, 4646);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceLocation
                f_10395_4634_4662(Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration
                this_param)
                {
                    var return_v = this_param.NameLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10395, 4634, 4662);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LexicalSortKey
                f_10395_4615_4676(Microsoft.CodeAnalysis.SourceLocation
                location, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.LexicalSortKey((Microsoft.CodeAnalysis.Location)location, compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10395, 4615, 4676);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10395, 4301, 4735);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10395, 4301, 4735);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ImmutableArray<SourceLocation> NameLocations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10395, 4823, 5475);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10395, 4859, 5460) || true) && (f_10395_4863_4875().Length == 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10395, 4859, 5460);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10395, 4929, 4988);

                        return f_10395_4936_4987(f_10395_4958_4986(f_10395_4958_4970()[0]));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10395, 4859, 5460);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10395, 4859, 5460);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10395, 5070, 5127);

                        var
                        builder = f_10395_5084_5126()
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10395, 5149, 5383);
                            foreach (var decl in f_10395_5170_5182_I(f_10395_5170_5182()))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10395, 5149, 5383);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10395, 5232, 5271);

                                SourceLocation
                                loc = f_10395_5253_5270(decl)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10395, 5297, 5360) || true) && (loc != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10395, 5297, 5360);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10395, 5343, 5360);

                                    f_10395_5343_5359(builder, loc);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10395, 5297, 5360);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10395, 5149, 5383);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10395, 1, 235);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10395, 1, 235);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10395, 5405, 5441);

                        return f_10395_5412_5440(builder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10395, 4859, 5460);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10395, 4823, 5475);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                    f_10395_4863_4875()
                    {
                        var return_v = Declarations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10395, 4863, 4875);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                    f_10395_4958_4970()
                    {
                        var return_v = Declarations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10395, 4958, 4970);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SourceLocation
                    f_10395_4958_4986(Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration
                    this_param)
                    {
                        var return_v = this_param.NameLocation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10395, 4958, 4986);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SourceLocation>
                    f_10395_4936_4987(Microsoft.CodeAnalysis.SourceLocation
                    item)
                    {
                        var return_v = ImmutableArray.Create(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10395, 4936, 4987);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SourceLocation>
                    f_10395_5084_5126()
                    {
                        var return_v = ArrayBuilder<SourceLocation>.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10395, 5084, 5126);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                    f_10395_5170_5182()
                    {
                        var return_v = Declarations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10395, 5170, 5182);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SourceLocation
                    f_10395_5253_5270(Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration
                    this_param)
                    {
                        var return_v = this_param.NameLocation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10395, 5253, 5270);
                        return return_v;
                    }


                    int
                    f_10395_5343_5359(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SourceLocation>
                    this_param, Microsoft.CodeAnalysis.SourceLocation
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10395, 5343, 5359);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                    f_10395_5170_5182_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10395, 5170, 5182);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SourceLocation>
                    f_10395_5412_5440(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SourceLocation>
                    this_param)
                    {
                        var return_v = this_param.ToImmutableAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10395, 5412, 5440);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10395, 4747, 5486);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10395, 4747, 5486);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ImmutableArray<MergedTypeDeclaration> MakeChildren()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10395, 5498, 6724);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10395, 5583, 5638);

                ArrayBuilder<SingleTypeDeclaration>
                nestedTypes = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10395, 5654, 6216);
                    foreach (var decl in f_10395_5675_5692_I(f_10395_5675_5692(this)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10395, 5654, 6216);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10395, 5726, 6201);
                            foreach (var child in f_10395_5748_5761_I(f_10395_5748_5761(decl)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10395, 5726, 6201);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10395, 5803, 5847);

                                var
                                asType = child as SingleTypeDeclaration
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10395, 5869, 6182) || true) && (asType != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10395, 5869, 6182);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10395, 5937, 6109) || true) && (nestedTypes == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10395, 5937, 6109);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10395, 6018, 6082);

                                        nestedTypes = f_10395_6032_6081();
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10395, 5937, 6109);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10395, 6135, 6159);

                                    f_10395_6135_6158(nestedTypes, asType);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10395, 5869, 6182);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10395, 5726, 6201);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10395, 1, 476);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10395, 1, 476);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10395, 5654, 6216);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10395, 1, 563);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10395, 1, 563);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10395, 6232, 6297);

                var
                children = f_10395_6247_6296()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10395, 6313, 6660) || true) && (nestedTypes != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10395, 6313, 6660);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10395, 6370, 6431);

                    var
                    typesGrouped = f_10395_6389_6430(nestedTypes, t => t.Identity)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10395, 6449, 6468);

                    f_10395_6449_6467(nestedTypes);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10395, 6488, 6645);
                        foreach (var typeGroup in f_10395_6514_6533_I(f_10395_6514_6533(typesGrouped)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10395, 6488, 6645);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10395, 6575, 6626);

                            f_10395_6575_6625(children, f_10395_6588_6624(typeGroup));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10395, 6488, 6645);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10395, 1, 158);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10395, 1, 158);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10395, 6313, 6660);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10395, 6676, 6713);

                return f_10395_6683_6712(children);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10395, 5498, 6724);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                f_10395_5675_5692(Microsoft.CodeAnalysis.CSharp.MergedTypeDeclaration
                this_param)
                {
                    var return_v = this_param.Declarations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10395, 5675, 5692);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                f_10395_5748_5761(Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10395, 5748, 5761);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                f_10395_6032_6081()
                {
                    var return_v = ArrayBuilder<SingleTypeDeclaration>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10395, 6032, 6081);
                    return return_v;
                }


                int
                f_10395_6135_6158(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                this_param, Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10395, 6135, 6158);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                f_10395_5748_5761_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10395, 5748, 5761);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                f_10395_5675_5692_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10395, 5675, 5692);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MergedTypeDeclaration>
                f_10395_6247_6296()
                {
                    var return_v = ArrayBuilder<MergedTypeDeclaration>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10395, 6247, 6296);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration.TypeDeclarationIdentity, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>>
                f_10395_6389_6430(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                this_param, System.Func<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration, Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration.TypeDeclarationIdentity>
                keySelector)
                {
                    var return_v = this_param.ToDictionary<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration.TypeDeclarationIdentity>(keySelector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10395, 6389, 6430);
                    return return_v;
                }


                int
                f_10395_6449_6467(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10395, 6449, 6467);
                    return 0;
                }


                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration.TypeDeclarationIdentity, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>>.ValueCollection
                f_10395_6514_6533(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration.TypeDeclarationIdentity, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10395, 6514, 6533);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MergedTypeDeclaration
                f_10395_6588_6624(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                declarations)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.MergedTypeDeclaration(declarations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10395, 6588, 6624);
                    return return_v;
                }


                int
                f_10395_6575_6625(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MergedTypeDeclaration>
                this_param, Microsoft.CodeAnalysis.CSharp.MergedTypeDeclaration
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10395, 6575, 6625);
                    return 0;
                }


                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration.TypeDeclarationIdentity, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>>.ValueCollection
                f_10395_6514_6533_I(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration.TypeDeclarationIdentity, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>>.ValueCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10395, 6514, 6533);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.MergedTypeDeclaration>
                f_10395_6683_6712(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MergedTypeDeclaration>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10395, 6683, 6712);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10395, 5498, 6724);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10395, 5498, 6724);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public new ImmutableArray<MergedTypeDeclaration> Children
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10395, 6818, 7076);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10395, 6854, 7020) || true) && (_lazyChildren.IsDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10395, 6854, 7020);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10395, 6923, 7001);

                        f_10395_6923_7000(ref _lazyChildren, f_10395_6985_6999(this));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10395, 6854, 7020);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10395, 7040, 7061);

                    return _lazyChildren;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10395, 6818, 7076);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.MergedTypeDeclaration>
                    f_10395_6985_6999(Microsoft.CodeAnalysis.CSharp.MergedTypeDeclaration
                    this_param)
                    {
                        var return_v = this_param.MakeChildren();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10395, 6985, 6999);
                        return return_v;
                    }


                    bool
                    f_10395_6923_7000(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.MergedTypeDeclaration>
                    location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.MergedTypeDeclaration>
                    value)
                    {
                        var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10395, 6923, 7000);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10395, 6736, 7087);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10395, 6736, 7087);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override ImmutableArray<Declaration> GetDeclarationChildren()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10395, 7099, 7257);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10395, 7195, 7246);

                return f_10395_7202_7245(f_10395_7231_7244(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10395, 7099, 7257);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.MergedTypeDeclaration>
                f_10395_7231_7244(Microsoft.CodeAnalysis.CSharp.MergedTypeDeclaration
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10395, 7231, 7244);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Declaration>
                f_10395_7202_7245(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.MergedTypeDeclaration>
                from)
                {
                    var return_v = StaticCast<Declaration>.From(from);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10395, 7202, 7245);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10395, 7099, 7257);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10395, 7099, 7257);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ICollection<string> MemberNames
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10395, 7332, 7683);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10395, 7368, 7624) || true) && (_lazyMemberNames == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10395, 7368, 7624);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10395, 7438, 7520);

                        var
                        names = f_10395_7450_7519(f_10395_7481_7498(this), d => d.MemberNames)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10395, 7542, 7605);

                        f_10395_7542_7604(ref _lazyMemberNames, names, null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10395, 7368, 7624);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10395, 7644, 7668);

                    return _lazyMemberNames;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10395, 7332, 7683);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                    f_10395_7481_7498(Microsoft.CodeAnalysis.CSharp.MergedTypeDeclaration
                    this_param)
                    {
                        var return_v = this_param.Declarations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10395, 7481, 7498);
                        return return_v;
                    }


                    System.Collections.Generic.ICollection<string>
                    f_10395_7450_7519(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                    collections, System.Func<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration, System.Collections.Generic.ICollection<string>>
                    selector)
                    {
                        var return_v = UnionCollection<string>.Create(collections, selector);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10395, 7450, 7519);
                        return return_v;
                    }


                    System.Collections.Generic.ICollection<string>?
                    f_10395_7542_7604(ref System.Collections.Generic.ICollection<string>?
                    location1, System.Collections.Generic.ICollection<string>
                    value, System.Collections.Generic.ICollection<string>?
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10395, 7542, 7604);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10395, 7269, 7694);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10395, 7269, 7694);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal string GetDebuggerDisplay()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10395, 7706, 7827);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10395, 7767, 7816);

                return $"{nameof(MergedTypeDeclaration)} {f_10395_7809_7813()}";
                DynAbs.Tracing.TraceSender.TraceExitMethod(10395, 7706, 7827);

                string
                f_10395_7809_7813()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10395, 7809, 7813);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10395, 7706, 7827);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10395, 7706, 7827);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static MergedTypeDeclaration()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10395, 680, 7834);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10395, 680, 7834);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10395, 680, 7834);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10395, 680, 7834);

        static string
        f_10395_1137_1157(Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration
        this_param)
        {
            var return_v = this_param.Name;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10395, 1137, 1157);
            return return_v;
        }


        static string
        f_10395_1137_1157_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10395, 1034, 1223);
            return return_v;
        }

    }
}
