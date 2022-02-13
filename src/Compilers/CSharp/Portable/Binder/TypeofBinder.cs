// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis.CSharp.Symbols;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class TypeofBinder : Binder
    {
        private readonly Dictionary<GenericNameSyntax, bool> _allowedMap;

        private readonly bool _isTypeExpressionOpen;

        internal TypeofBinder(ExpressionSyntax typeExpression, Binder next)
        : base(f_10373_1334_1338_C(next), next.Flags | BinderFlags.UnsafeRegion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10373, 1152, 1496);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10373, 1074, 1085);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10373, 1118, 1139);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10373, 1403, 1485);

                f_10373_1403_1484(typeExpression, out _allowedMap, out _isTypeExpressionOpen);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10373, 1152, 1496);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10373, 1152, 1496);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10373, 1152, 1496);
            }
        }

        internal bool IsTypeExpressionOpen
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10373, 1543, 1567);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10373, 1546, 1567);
                    return _isTypeExpressionOpen; DynAbs.Tracing.TraceSender.TraceExitMethod(10373, 1543, 1567);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10373, 1543, 1567);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10373, 1543, 1567);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override bool IsUnboundTypeAllowed(GenericNameSyntax syntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10373, 1580, 1799);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10373, 1675, 1688);

                bool
                allowed
                = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10373, 1702, 1788);

                return _allowedMap != null && (DynAbs.Tracing.TraceSender.Expression_True(10373, 1709, 1776) && f_10373_1732_1776(_allowedMap, syntax, out allowed)) && (DynAbs.Tracing.TraceSender.Expression_True(10373, 1709, 1787) && allowed);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10373, 1580, 1799);

                bool
                f_10373_1732_1776(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Syntax.GenericNameSyntax, bool>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.GenericNameSyntax
                key, out bool
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10373, 1732, 1776);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10373, 1580, 1799);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10373, 1580, 1799);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private class OpenTypeVisitor : CSharpSyntaxVisitor
        {
            private Dictionary<GenericNameSyntax, bool> _allowedMap;

            private bool _seenConstructed;

            private bool _seenGeneric;

            public static void Visit(ExpressionSyntax typeSyntax, out Dictionary<GenericNameSyntax, bool> allowedMap, out bool isUnboundGenericType)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10373, 2869, 3287);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10373, 3038, 3086);

                    OpenTypeVisitor
                    visitor = f_10373_3064_3085()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10373, 3104, 3130);

                    f_10373_3104_3129(visitor, typeSyntax);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10373, 3148, 3181);

                    allowedMap = visitor._allowedMap;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10373, 3199, 3272);

                    isUnboundGenericType = visitor._seenGeneric && (DynAbs.Tracing.TraceSender.Expression_True(10373, 3222, 3271) && !visitor._seenConstructed);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10373, 2869, 3287);

                    Microsoft.CodeAnalysis.CSharp.TypeofBinder.OpenTypeVisitor
                    f_10373_3064_3085()
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.TypeofBinder.OpenTypeVisitor();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10373, 3064, 3085);
                        return return_v;
                    }


                    int
                    f_10373_3104_3129(Microsoft.CodeAnalysis.CSharp.TypeofBinder.OpenTypeVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                    node)
                    {
                        this_param.Visit((Microsoft.CodeAnalysis.SyntaxNode)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10373, 3104, 3129);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10373, 2869, 3287);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10373, 2869, 3287);
                }
            }

            public override void VisitGenericName(GenericNameSyntax node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10373, 3303, 4104);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10373, 3397, 3417);

                    _seenGeneric = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10373, 3437, 3517);

                    SeparatedSyntaxList<TypeSyntax>
                    typeArguments = f_10373_3485_3516(f_10373_3485_3506(node))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10373, 3535, 4089) || true) && (f_10373_3539_3564(node))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10373, 3535, 4089);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10373, 3606, 3758) || true) && (_allowedMap == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10373, 3606, 3758);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10373, 3679, 3735);

                            _allowedMap = f_10373_3693_3734();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10373, 3606, 3758);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10373, 3780, 3818);

                        _allowedMap[node] = !_seenConstructed;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10373, 3535, 4089);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10373, 3535, 4089);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10373, 3900, 3924);

                        _seenConstructed = true;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10373, 3946, 4070);
                            foreach (TypeSyntax arg in f_10373_3973_3986_I(typeArguments))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10373, 3946, 4070);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10373, 4036, 4047);

                                f_10373_4036_4046(this, arg);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10373, 3946, 4070);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10373, 1, 125);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10373, 1, 125);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10373, 3535, 4089);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10373, 3303, 4104);

                    Microsoft.CodeAnalysis.CSharp.Syntax.TypeArgumentListSyntax
                    f_10373_3485_3506(Microsoft.CodeAnalysis.CSharp.Syntax.GenericNameSyntax
                    this_param)
                    {
                        var return_v = this_param.TypeArgumentList;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10373, 3485, 3506);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax>
                    f_10373_3485_3516(Microsoft.CodeAnalysis.CSharp.Syntax.TypeArgumentListSyntax
                    this_param)
                    {
                        var return_v = this_param.Arguments;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10373, 3485, 3516);
                        return return_v;
                    }


                    bool
                    f_10373_3539_3564(Microsoft.CodeAnalysis.CSharp.Syntax.GenericNameSyntax
                    this_param)
                    {
                        var return_v = this_param.IsUnboundGenericName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10373, 3539, 3564);
                        return return_v;
                    }


                    System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Syntax.GenericNameSyntax, bool>
                    f_10373_3693_3734()
                    {
                        var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Syntax.GenericNameSyntax, bool>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10373, 3693, 3734);
                        return return_v;
                    }


                    int
                    f_10373_4036_4046(Microsoft.CodeAnalysis.CSharp.TypeofBinder.OpenTypeVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                    node)
                    {
                        this_param.Visit((Microsoft.CodeAnalysis.SyntaxNode)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10373, 4036, 4046);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax>
                    f_10373_3973_3986_I(Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10373, 3973, 3986);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10373, 3303, 4104);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10373, 3303, 4104);
                }
            }

            public override void VisitQualifiedName(QualifiedNameSyntax node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10373, 4120, 4808);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10373, 4218, 4269);

                    bool
                    seenConstructedBeforeRight = _seenConstructed
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10373, 4380, 4398);

                    f_10373_4380_4397(this, f_10373_4386_4396(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10373, 4418, 4468);

                    bool
                    seenConstructedBeforeLeft = _seenConstructed
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10373, 4488, 4505);

                    f_10373_4488_4504(this, f_10373_4494_4503(node));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10373, 4633, 4793) || true) && (!seenConstructedBeforeRight && (DynAbs.Tracing.TraceSender.Expression_True(10373, 4637, 4694) && !seenConstructedBeforeLeft) && (DynAbs.Tracing.TraceSender.Expression_True(10373, 4637, 4714) && _seenConstructed))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10373, 4633, 4793);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10373, 4756, 4774);

                        f_10373_4756_4773(this, f_10373_4762_4772(node));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10373, 4633, 4793);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10373, 4120, 4808);

                    Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                    f_10373_4386_4396(Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedNameSyntax
                    this_param)
                    {
                        var return_v = this_param.Right;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10373, 4386, 4396);
                        return return_v;
                    }


                    int
                    f_10373_4380_4397(Microsoft.CodeAnalysis.CSharp.TypeofBinder.OpenTypeVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                    node)
                    {
                        this_param.Visit((Microsoft.CodeAnalysis.SyntaxNode)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10373, 4380, 4397);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                    f_10373_4494_4503(Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedNameSyntax
                    this_param)
                    {
                        var return_v = this_param.Left;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10373, 4494, 4503);
                        return return_v;
                    }


                    int
                    f_10373_4488_4504(Microsoft.CodeAnalysis.CSharp.TypeofBinder.OpenTypeVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                    node)
                    {
                        this_param.Visit((Microsoft.CodeAnalysis.SyntaxNode)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10373, 4488, 4504);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                    f_10373_4762_4772(Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedNameSyntax
                    this_param)
                    {
                        var return_v = this_param.Right;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10373, 4762, 4772);
                        return return_v;
                    }


                    int
                    f_10373_4756_4773(Microsoft.CodeAnalysis.CSharp.TypeofBinder.OpenTypeVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                    node)
                    {
                        this_param.Visit((Microsoft.CodeAnalysis.SyntaxNode)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10373, 4756, 4773);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10373, 4120, 4808);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10373, 4120, 4808);
                }
            }

            public override void VisitAliasQualifiedName(AliasQualifiedNameSyntax node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10373, 4824, 4964);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10373, 4932, 4949);

                    f_10373_4932_4948(this, f_10373_4938_4947(node));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10373, 4824, 4964);

                    Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                    f_10373_4938_4947(Microsoft.CodeAnalysis.CSharp.Syntax.AliasQualifiedNameSyntax
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10373, 4938, 4947);
                        return return_v;
                    }


                    int
                    f_10373_4932_4948(Microsoft.CodeAnalysis.CSharp.TypeofBinder.OpenTypeVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                    node)
                    {
                        this_param.Visit((Microsoft.CodeAnalysis.SyntaxNode)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10373, 4932, 4948);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10373, 4824, 4964);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10373, 4824, 4964);
                }
            }

            public override void VisitArrayType(ArrayTypeSyntax node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10373, 4980, 5151);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10373, 5070, 5094);

                    _seenConstructed = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10373, 5112, 5136);

                    f_10373_5112_5135(this, f_10373_5118_5134(node));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10373, 4980, 5151);

                    Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                    f_10373_5118_5134(Microsoft.CodeAnalysis.CSharp.Syntax.ArrayTypeSyntax
                    this_param)
                    {
                        var return_v = this_param.ElementType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10373, 5118, 5134);
                        return return_v;
                    }


                    int
                    f_10373_5112_5135(Microsoft.CodeAnalysis.CSharp.TypeofBinder.OpenTypeVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                    node)
                    {
                        this_param.Visit((Microsoft.CodeAnalysis.SyntaxNode)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10373, 5112, 5135);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10373, 4980, 5151);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10373, 4980, 5151);
                }
            }

            public override void VisitPointerType(PointerTypeSyntax node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10373, 5167, 5342);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10373, 5261, 5285);

                    _seenConstructed = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10373, 5303, 5327);

                    f_10373_5303_5326(this, f_10373_5309_5325(node));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10373, 5167, 5342);

                    Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                    f_10373_5309_5325(Microsoft.CodeAnalysis.CSharp.Syntax.PointerTypeSyntax
                    this_param)
                    {
                        var return_v = this_param.ElementType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10373, 5309, 5325);
                        return return_v;
                    }


                    int
                    f_10373_5303_5326(Microsoft.CodeAnalysis.CSharp.TypeofBinder.OpenTypeVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                    node)
                    {
                        this_param.Visit((Microsoft.CodeAnalysis.SyntaxNode)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10373, 5303, 5326);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10373, 5167, 5342);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10373, 5167, 5342);
                }
            }

            public override void VisitNullableType(NullableTypeSyntax node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10373, 5358, 5535);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10373, 5454, 5478);

                    _seenConstructed = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10373, 5496, 5520);

                    f_10373_5496_5519(this, f_10373_5502_5518(node));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10373, 5358, 5535);

                    Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                    f_10373_5502_5518(Microsoft.CodeAnalysis.CSharp.Syntax.NullableTypeSyntax
                    this_param)
                    {
                        var return_v = this_param.ElementType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10373, 5502, 5518);
                        return return_v;
                    }


                    int
                    f_10373_5496_5519(Microsoft.CodeAnalysis.CSharp.TypeofBinder.OpenTypeVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                    node)
                    {
                        this_param.Visit((Microsoft.CodeAnalysis.SyntaxNode)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10373, 5496, 5519);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10373, 5358, 5535);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10373, 5358, 5535);
                }
            }

            public OpenTypeVisitor()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10373, 2203, 5546);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10373, 2323, 2334);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10373, 2362, 2378);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10373, 2406, 2418);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10373, 2203, 5546);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10373, 2203, 5546);
            }


            static OpenTypeVisitor()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10373, 2203, 5546);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10373, 2203, 5546);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10373, 2203, 5546);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10373, 2203, 5546);
        }

        static TypeofBinder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10373, 961, 5553);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10373, 961, 5553);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10373, 961, 5553);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10373, 961, 5553);

        int
        f_10373_1403_1484(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
        typeSyntax, out System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Syntax.GenericNameSyntax, bool>
        allowedMap, out bool
        isUnboundGenericType)
        {
            OpenTypeVisitor.Visit(typeSyntax, out allowedMap, out isUnboundGenericType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10373, 1403, 1484);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Binder
        f_10373_1334_1338_C(Microsoft.CodeAnalysis.CSharp.Binder
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10373, 1152, 1496);
            return return_v;
        }

    }
}
