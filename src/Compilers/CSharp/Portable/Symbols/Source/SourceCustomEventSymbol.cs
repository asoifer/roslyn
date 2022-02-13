// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class SourceCustomEventSymbol : SourceEventSymbol
    {
        private readonly TypeWithAnnotations _type;

        private readonly string _name;

        private readonly SourceEventAccessorSymbol? _addMethod;

        private readonly SourceEventAccessorSymbol? _removeMethod;

        private readonly TypeSymbol _explicitInterfaceType;

        private readonly ImmutableArray<EventSymbol> _explicitInterfaceImplementations;

        internal SourceCustomEventSymbol(SourceMemberContainerTypeSymbol containingType, Binder binder, EventDeclarationSyntax syntax, DiagnosticBag diagnostics) : base(f_10244_1236_1250_C(containingType), syntax, f_10244_1260_1276(syntax), isFieldLike: false, interfaceSpecifierSyntaxOpt: f_10244_1345_1378(syntax), nameTokenSyntax: f_10244_1415_1432(syntax), diagnostics: diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10244, 1062, 9407);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10244, 761, 766);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10244, 821, 831);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10244, 886, 899);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10244, 938, 960);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10244, 1484, 1573);

                ExplicitInterfaceSpecifierSyntax?
                interfaceSpecifier = f_10244_1539_1572(syntax)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10244, 1587, 1629);

                SyntaxToken
                nameToken = f_10244_1611_1628(syntax)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10244, 1643, 1711);

                bool
                isExplicitInterfaceImplementation = interfaceSpecifier != null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10244, 1727, 1753);

                string?
                aliasQualifierOpt
                = default(string?);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10244, 1767, 1945);

                _name = f_10244_1775_1944(binder, interfaceSpecifier, nameToken.ValueText, diagnostics, out _explicitInterfaceType, out aliasQualifierOpt);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10244, 1961, 2017);

                _type = f_10244_1969_2016(this, binder, f_10244_1991_2002(syntax), diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10244, 2033, 2180);

                var
                explicitlyImplementedEvent = f_10244_2066_2179(this, _explicitInterfaceType, nameToken.ValueText, interfaceSpecifier, diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10244, 2194, 2284);

                f_10244_2194_2283(this, explicitlyImplementedEvent, diagnostics);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10244, 3500, 4483) || true) && (!isExplicitInterfaceImplementation)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10244, 3500, 4483);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10244, 3934, 4270) || true) && (f_10244_3938_3953(this))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10244, 3934, 4270);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10244, 3995, 4047);

                        EventSymbol?
                        overriddenEvent = f_10244_4026_4046(this)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10244, 4069, 4251) || true) && ((object?)overriddenEvent != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10244, 4069, 4251);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10244, 4155, 4228);

                            f_10244_4155_4227(overriddenEvent, ref _type, f_10244_4208_4226());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10244, 4069, 4251);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10244, 3934, 4270);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10244, 3500, 4483);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10244, 3500, 4483);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10244, 4304, 4483) || true) && ((object)explicitlyImplementedEvent != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10244, 4304, 4483);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10244, 4384, 4468);

                        f_10244_4384_4467(explicitlyImplementedEvent, ref _type, f_10244_4448_4466());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10244, 4304, 4483);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10244, 3500, 4483);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10244, 4499, 4543);

                AccessorDeclarationSyntax?
                addSyntax = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10244, 4557, 4604);

                AccessorDeclarationSyntax?
                removeSyntax = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10244, 4620, 7944) || true) && (f_10244_4624_4643(syntax) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10244, 4620, 7944);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10244, 4685, 7106);
                        foreach (AccessorDeclarationSyntax accessor in f_10244_4732_4761_I(f_10244_4732_4761(f_10244_4732_4751(syntax))))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10244, 4685, 7106);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10244, 4803, 4826);

                            bool
                            checkBody = false
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10244, 4850, 6747);

                            switch (f_10244_4858_4873(accessor))
                            {

                                case SyntaxKind.AddAccessorDeclaration:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10244, 4850, 6747);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10244, 4992, 5393) || true) && (addSyntax == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10244, 4992, 5393);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10244, 5079, 5100);

                                        addSyntax = accessor;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10244, 5134, 5151);

                                        checkBody = true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10244, 4992, 5393);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10244, 4992, 5393);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10244, 5281, 5362);

                                        f_10244_5281_5361(diagnostics, ErrorCode.ERR_DuplicateAccessor, accessor.Keyword.GetLocation());
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10244, 4992, 5393);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceBreak(10244, 5423, 5429);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10244, 4850, 6747);

                                case SyntaxKind.RemoveAccessorDeclaration:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10244, 4850, 6747);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10244, 5527, 5934) || true) && (removeSyntax == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10244, 5527, 5934);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10244, 5617, 5641);

                                        removeSyntax = accessor;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10244, 5675, 5692);

                                        checkBody = true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10244, 5527, 5934);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10244, 5527, 5934);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10244, 5822, 5903);

                                        f_10244_5822_5902(diagnostics, ErrorCode.ERR_DuplicateAccessor, accessor.Keyword.GetLocation());
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10244, 5527, 5934);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceBreak(10244, 5964, 5970);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10244, 4850, 6747);

                                case SyntaxKind.GetAccessorDeclaration:
                                case SyntaxKind.SetAccessorDeclaration:
                                case SyntaxKind.InitAccessorDeclaration:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10244, 4850, 6747);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10244, 6196, 6279);

                                    f_10244_6196_6278(diagnostics, ErrorCode.ERR_AddOrRemoveExpected, accessor.Keyword.GetLocation());
                                    DynAbs.Tracing.TraceSender.TraceBreak(10244, 6309, 6315);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10244, 4850, 6747);

                                case SyntaxKind.UnknownAccessorDeclaration:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10244, 4850, 6747);
                                    DynAbs.Tracing.TraceSender.TraceBreak(10244, 6594, 6600);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10244, 4850, 6747);

                                default:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10244, 4850, 6747);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10244, 6666, 6724);

                                    throw f_10244_6672_6723(f_10244_6707_6722(accessor));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10244, 4850, 6747);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10244, 6771, 7087) || true) && (checkBody && (DynAbs.Tracing.TraceSender.Expression_True(10244, 6775, 6799) && f_10244_6788_6799_M(!IsAbstract)) && (DynAbs.Tracing.TraceSender.Expression_True(10244, 6775, 6824) && f_10244_6803_6816(accessor) == null) && (DynAbs.Tracing.TraceSender.Expression_True(10244, 6775, 6859) && f_10244_6828_6851(accessor) == null) && (DynAbs.Tracing.TraceSender.Expression_True(10244, 6775, 6922) && accessor.SemicolonToken.Kind() == SyntaxKind.SemicolonToken))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10244, 6771, 7087);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10244, 6972, 7064);

                                f_10244_6972_7063(diagnostics, ErrorCode.ERR_AddRemoveMustHaveBody, accessor.SemicolonToken.GetLocation());
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10244, 6771, 7087);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10244, 4685, 7106);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10244, 1, 2422);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10244, 1, 2422);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10244, 7126, 7736) || true) && (f_10244_7130_7140())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10244, 7126, 7736);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10244, 7182, 7417) || true) && (f_10244_7186_7231_M(!f_10244_7187_7206(syntax).OpenBraceToken.IsMissing))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10244, 7182, 7417);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10244, 7281, 7394);

                            f_10244_7281_7393(diagnostics, ErrorCode.ERR_AbstractEventHasAccessors, f_10244_7338_7357(syntax).OpenBraceToken.GetLocation(), this);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10244, 7182, 7417);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10244, 7126, 7736);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10244, 7126, 7736);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10244, 7459, 7736) || true) && ((addSyntax == null || (DynAbs.Tracing.TraceSender.Expression_False(10244, 7464, 7505) || removeSyntax == null)) && (DynAbs.Tracing.TraceSender.Expression_True(10244, 7463, 7595) && (f_10244_7511_7556_M(!f_10244_7512_7531(syntax).OpenBraceToken.IsMissing) || (DynAbs.Tracing.TraceSender.Expression_False(10244, 7511, 7594) || !isExplicitInterfaceImplementation))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10244, 7459, 7736);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10244, 7637, 7717);

                            f_10244_7637_7716(diagnostics, ErrorCode.ERR_EventNeedsBothAccessors, f_10244_7692_7706(this)[0], this);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10244, 7459, 7736);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10244, 7126, 7736);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10244, 4620, 7944);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10244, 4620, 7944);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10244, 7770, 7944) || true) && (isExplicitInterfaceImplementation && (DynAbs.Tracing.TraceSender.Expression_True(10244, 7774, 7822) && f_10244_7811_7822_M(!IsAbstract)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10244, 7770, 7944);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10244, 7856, 7929);

                        f_10244_7856_7928(diagnostics, ErrorCode.ERR_ExplicitEventFieldImpl, f_10244_7910_7924(this)[0]);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10244, 7770, 7944);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10244, 4620, 7944);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10244, 7960, 9140) || true) && (isExplicitInterfaceImplementation && (DynAbs.Tracing.TraceSender.Expression_True(10244, 7964, 8011) && f_10244_8001_8011()) && (DynAbs.Tracing.TraceSender.Expression_True(10244, 7964, 8042) && f_10244_8015_8034(syntax) == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10244, 7960, 9140);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10244, 8076, 8117);

                    f_10244_8076_8116(f_10244_8089_8115(containingType));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10244, 8137, 8255);

                    f_10244_8137_8254(syntax, MessageID.IDS_DefaultInterfaceImplementation, diagnostics, f_10244_8236_8250(this)[0]);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10244, 8275, 8507) || true) && (f_10244_8279_8344_M(!f_10244_8280_8298().RuntimeSupportsDefaultInterfaceImplementation))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10244, 8275, 8507);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10244, 8386, 8488);

                        f_10244_8386_8487(diagnostics, ErrorCode.ERR_RuntimeDoesNotSupportDefaultInterfaceImplementation, f_10244_8469_8483(this)[0]);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10244, 8275, 8507);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10244, 8527, 8643);

                    _addMethod = f_10244_8540_8642(this, isAdder: true, explicitlyImplementedEvent, aliasQualifierOpt);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10244, 8661, 8781);

                    _removeMethod = f_10244_8677_8780(this, isAdder: false, explicitlyImplementedEvent, aliasQualifierOpt);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10244, 7960, 9140);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10244, 7960, 9140);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10244, 8847, 8974);

                    _addMethod = f_10244_8860_8973(this, f_10244_8881_8901(), addSyntax, explicitlyImplementedEvent, aliasQualifierOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10244, 8992, 9125);

                    _removeMethod = f_10244_9008_9124(this, f_10244_9029_9049(), removeSyntax, explicitlyImplementedEvent, aliasQualifierOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10244, 7960, 9140);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10244, 9156, 9396);

                _explicitInterfaceImplementations =
                (DynAbs.Tracing.TraceSender.Conditional_F1(10244, 9209, 9252) || (((object?)explicitlyImplementedEvent == null && DynAbs.Tracing.TraceSender.Conditional_F2(10244, 9276, 9309)) || DynAbs.Tracing.TraceSender.Conditional_F3(10244, 9333, 9395))) ? ImmutableArray<EventSymbol>.Empty : f_10244_9333_9395(explicitlyImplementedEvent);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10244, 1062, 9407);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10244, 1062, 9407);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10244, 1062, 9407);
            }
        }

        public override TypeWithAnnotations TypeWithAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10244, 9499, 9520);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10244, 9505, 9518);

                    return _type;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10244, 9499, 9520);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10244, 9419, 9531);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10244, 9419, 9531);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10244, 9595, 9616);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10244, 9601, 9614);

                    return _name;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10244, 9595, 9616);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10244, 9543, 9627);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10244, 9543, 9627);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override MethodSymbol? AddMethod
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10244, 9703, 9729);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10244, 9709, 9727);

                    return _addMethod;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10244, 9703, 9729);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10244, 9639, 9740);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10244, 9639, 9740);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override MethodSymbol? RemoveMethod
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10244, 9819, 9848);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10244, 9825, 9846);

                    return _removeMethod;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10244, 9819, 9848);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10244, 9752, 9859);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10244, 9752, 9859);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override AttributeLocation AllowedAttributeLocations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10244, 9958, 9997);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10244, 9964, 9995);

                    return AttributeLocation.Event;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10244, 9958, 9997);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10244, 9871, 10008);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10244, 9871, 10008);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ExplicitInterfaceSpecifierSyntax? ExplicitInterfaceSpecifier
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10244, 10113, 10203);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10244, 10119, 10201);

                    return f_10244_10126_10200(((EventDeclarationSyntax)f_10244_10151_10172(this)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10244, 10113, 10203);

                    Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    f_10244_10151_10172(Microsoft.CodeAnalysis.CSharp.Symbols.SourceCustomEventSymbol
                    this_param)
                    {
                        var return_v = this_param.CSharpSyntaxNode;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10244, 10151, 10172);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax?
                    f_10244_10126_10200(Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.ExplicitInterfaceSpecifier;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10244, 10126, 10200);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10244, 10020, 10214);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10244, 10020, 10214);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsExplicitInterfaceImplementation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10244, 10307, 10362);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10244, 10313, 10360);

                    return f_10244_10320_10351(this) != null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10244, 10307, 10362);

                    Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax?
                    f_10244_10320_10351(Microsoft.CodeAnalysis.CSharp.Symbols.SourceCustomEventSymbol
                    this_param)
                    {
                        var return_v = this_param.ExplicitInterfaceSpecifier;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10244, 10320, 10351);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10244, 10226, 10373);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10244, 10226, 10373);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<EventSymbol> ExplicitInterfaceImplementations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10244, 10486, 10535);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10244, 10492, 10533);

                    return _explicitInterfaceImplementations;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10244, 10486, 10535);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10244, 10385, 10546);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10244, 10385, 10546);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override void AfterAddingTypeMembersChecks(ConversionsBase conversions, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10244, 10558, 11620);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10244, 10690, 10750);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.AfterAddingTypeMembersChecks(conversions, diagnostics), 10244, 10690, 10749);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10244, 10766, 11157) || true) && ((object)_explicitInterfaceType != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10244, 10766, 11157);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10244, 10842, 10907);

                    var
                    explicitInterfaceSpecifier = f_10244_10875_10906(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10244, 10925, 10980);

                    f_10244_10925_10979(explicitInterfaceSpecifier != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10244, 10998, 11142);

                    f_10244_10998_11141(_explicitInterfaceType, f_10244_11041_11061(), conversions, f_10244_11076_11127(f_10244_11095_11126(explicitInterfaceSpecifier)), diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10244, 10766, 11157);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10244, 11173, 11609) || true) && (f_10244_11177_11219_M(!_explicitInterfaceImplementations.IsEmpty))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10244, 11173, 11609);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10244, 11346, 11424);

                    EventSymbol
                    explicitlyImplementedEvent = _explicitInterfaceImplementations[0]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10244, 11442, 11594);

                    f_10244_11442_11593(f_10244_11508_11527(this), this, explicitlyImplementedEvent, isExplicit: true, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10244, 11173, 11609);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10244, 10558, 11620);

                Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax?
                f_10244_10875_10906(Microsoft.CodeAnalysis.CSharp.Symbols.SourceCustomEventSymbol
                this_param)
                {
                    var return_v = this_param.ExplicitInterfaceSpecifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10244, 10875, 10906);
                    return return_v;
                }


                int
                f_10244_10925_10979(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10244, 10925, 10979);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10244_11041_11061()
                {
                    var return_v = DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10244, 11041, 11061);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10244_11095_11126(Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10244, 11095, 11126);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceLocation
                f_10244_11076_11127(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                node)
                {
                    var return_v = new Microsoft.CodeAnalysis.SourceLocation((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10244, 11076, 11127);
                    return return_v;
                }


                int
                f_10244_10998_11141(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.ConversionsBase
                conversions, Microsoft.CodeAnalysis.SourceLocation
                location, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    type.CheckAllConstraints(compilation, conversions, (Microsoft.CodeAnalysis.Location)location, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10244, 10998, 11141);
                    return 0;
                }


                bool
                f_10244_11177_11219_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10244, 11177, 11219);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10244_11508_11527(Microsoft.CodeAnalysis.CSharp.Symbols.SourceCustomEventSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10244, 11508, 11527);
                    return return_v;
                }


                int
                f_10244_11442_11593(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                implementingType, Microsoft.CodeAnalysis.CSharp.Symbols.SourceCustomEventSymbol
                implementingMember, Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                interfaceMember, bool
                isExplicit, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    TypeSymbol.CheckNullableReferenceTypeMismatchOnImplementingMember((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)implementingType, (Microsoft.CodeAnalysis.CSharp.Symbol)implementingMember, (Microsoft.CodeAnalysis.CSharp.Symbol)interfaceMember, isExplicit: isExplicit, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10244, 11442, 11593);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10244, 10558, 11620);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10244, 10558, 11620);
            }
        }

        [return: NotNullIfNotNull(parameterName: "syntaxOpt")]
        private SourceCustomEventAccessorSymbol? CreateAccessorSymbol(CSharpCompilation compilation, AccessorDeclarationSyntax? syntaxOpt,
                    EventSymbol? explicitlyImplementedEventOpt, string? aliasQualifierOpt, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10244, 11632, 12273);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10244, 11962, 12044) || true) && (syntaxOpt == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10244, 11962, 12044);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10244, 12017, 12029);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10244, 11962, 12044);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10244, 12060, 12262);

                return f_10244_12067_12261(this, syntaxOpt, explicitlyImplementedEventOpt, aliasQualifierOpt, isNullableAnalysisEnabled: f_10244_12197_12247(compilation, syntaxOpt), diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10244, 11632, 12273);

                bool
                f_10244_12197_12247(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
                syntax)
                {
                    var return_v = this_param.IsNullableAnalysisEnabledIn((Microsoft.CodeAnalysis.SyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10244, 12197, 12247);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceCustomEventAccessorSymbol
                f_10244_12067_12261(Microsoft.CodeAnalysis.CSharp.Symbols.SourceCustomEventSymbol
                @event, Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol?
                explicitlyImplementedEventOpt, string?
                aliasQualifierOpt, bool
                isNullableAnalysisEnabled, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SourceCustomEventAccessorSymbol((Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol)@event, syntax, explicitlyImplementedEventOpt, aliasQualifierOpt, isNullableAnalysisEnabled: isNullableAnalysisEnabled, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10244, 12067, 12261);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10244, 11632, 12273);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10244, 11632, 12273);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SourceCustomEventSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10244, 602, 12280);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10244, 602, 12280);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10244, 602, 12280);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10244, 602, 12280);

        static Microsoft.CodeAnalysis.SyntaxTokenList
        f_10244_1260_1276(Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax
        this_param)
        {
            var return_v = this_param.Modifiers;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10244, 1260, 1276);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax?
        f_10244_1345_1378(Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax
        this_param)
        {
            var return_v = this_param.ExplicitInterfaceSpecifier;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10244, 1345, 1378);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxToken
        f_10244_1415_1432(Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax
        this_param)
        {
            var return_v = this_param.Identifier;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10244, 1415, 1432);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax?
        f_10244_1539_1572(Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax
        this_param)
        {
            var return_v = this_param.ExplicitInterfaceSpecifier;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10244, 1539, 1572);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxToken
        f_10244_1611_1628(Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax
        this_param)
        {
            var return_v = this_param.Identifier;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10244, 1611, 1628);
            return return_v;
        }


        string
        f_10244_1775_1944(Microsoft.CodeAnalysis.CSharp.Binder
        binder, Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax?
        explicitInterfaceSpecifierOpt, string
        name, Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics, out Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        explicitInterfaceTypeOpt, out string?
        aliasQualifierOpt)
        {
            var return_v = ExplicitInterfaceHelpers.GetMemberNameAndInterfaceSymbol(binder, explicitInterfaceSpecifierOpt, name, diagnostics, out explicitInterfaceTypeOpt, out aliasQualifierOpt);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10244, 1775, 1944);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
        f_10244_1991_2002(Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax
        this_param)
        {
            var return_v = this_param.Type;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10244, 1991, 2002);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
        f_10244_1969_2016(Microsoft.CodeAnalysis.CSharp.Symbols.SourceCustomEventSymbol
        this_param, Microsoft.CodeAnalysis.CSharp.Binder
        binder, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
        typeSyntax, Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics)
        {
            var return_v = this_param.BindEventType(binder, typeSyntax, diagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10244, 1969, 2016);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
        f_10244_2066_2179(Microsoft.CodeAnalysis.CSharp.Symbols.SourceCustomEventSymbol
        implementingEvent, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        explicitInterfaceType, string
        interfaceEventName, Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax?
        explicitInterfaceSpecifierSyntax, Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics)
        {
            var return_v = implementingEvent.FindExplicitlyImplementedEvent(explicitInterfaceType, interfaceEventName, explicitInterfaceSpecifierSyntax, diagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10244, 2066, 2179);
            return return_v;
        }


        int
        f_10244_2194_2283(Microsoft.CodeAnalysis.CSharp.Symbols.SourceCustomEventSymbol
        implementingMember, Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
        implementedMember, Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics)
        {
            implementingMember.FindExplicitlyImplementedMemberVerification((Microsoft.CodeAnalysis.CSharp.Symbol)implementedMember, diagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10244, 2194, 2283);
            return 0;
        }


        bool
        f_10244_3938_3953(Microsoft.CodeAnalysis.CSharp.Symbols.SourceCustomEventSymbol
        this_param)
        {
            var return_v = this_param.IsOverride;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10244, 3938, 3953);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol?
        f_10244_4026_4046(Microsoft.CodeAnalysis.CSharp.Symbols.SourceCustomEventSymbol
        this_param)
        {
            var return_v = this_param.OverriddenEvent;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10244, 4026, 4046);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        f_10244_4208_4226()
        {
            var return_v = ContainingAssembly;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10244, 4208, 4226);
            return return_v;
        }


        int
        f_10244_4155_4227(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
        eventWithCustomModifiers, ref Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
        type, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        containingAssembly)
        {
            CopyEventCustomModifiers(eventWithCustomModifiers, ref type, containingAssembly);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10244, 4155, 4227);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        f_10244_4448_4466()
        {
            var return_v = ContainingAssembly;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10244, 4448, 4466);
            return return_v;
        }


        int
        f_10244_4384_4467(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
        eventWithCustomModifiers, ref Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
        type, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        containingAssembly)
        {
            CopyEventCustomModifiers(eventWithCustomModifiers, ref type, containingAssembly);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10244, 4384, 4467);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.AccessorListSyntax?
        f_10244_4624_4643(Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax
        this_param)
        {
            var return_v = this_param.AccessorList;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10244, 4624, 4643);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.AccessorListSyntax
        f_10244_4732_4751(Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax
        this_param)
        {
            var return_v = this_param.AccessorList;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10244, 4732, 4751);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax>
        f_10244_4732_4761(Microsoft.CodeAnalysis.CSharp.Syntax.AccessorListSyntax
        this_param)
        {
            var return_v = this_param.Accessors;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10244, 4732, 4761);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.SyntaxKind
        f_10244_4858_4873(Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
        this_param)
        {
            var return_v = this_param.Kind();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10244, 4858, 4873);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
        f_10244_5281_5361(Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, Microsoft.CodeAnalysis.Location
        location)
        {
            var return_v = diagnostics.Add(code, location);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10244, 5281, 5361);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
        f_10244_5822_5902(Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, Microsoft.CodeAnalysis.Location
        location)
        {
            var return_v = diagnostics.Add(code, location);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10244, 5822, 5902);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
        f_10244_6196_6278(Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, Microsoft.CodeAnalysis.Location
        location)
        {
            var return_v = diagnostics.Add(code, location);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10244, 6196, 6278);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.SyntaxKind
        f_10244_6707_6722(Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
        this_param)
        {
            var return_v = this_param.Kind();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10244, 6707, 6722);
            return return_v;
        }


        System.Exception
        f_10244_6672_6723(Microsoft.CodeAnalysis.CSharp.SyntaxKind
        o)
        {
            var return_v = ExceptionUtilities.UnexpectedValue((object)o);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10244, 6672, 6723);
            return return_v;
        }


        bool
        f_10244_6788_6799_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10244, 6788, 6799);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
        f_10244_6803_6816(Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
        this_param)
        {
            var return_v = this_param.Body;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10244, 6803, 6816);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
        f_10244_6828_6851(Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
        this_param)
        {
            var return_v = this_param.ExpressionBody;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10244, 6828, 6851);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
        f_10244_6972_7063(Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, Microsoft.CodeAnalysis.Location
        location)
        {
            var return_v = diagnostics.Add(code, location);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10244, 6972, 7063);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax>
        f_10244_4732_4761_I(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10244, 4732, 4761);
            return return_v;
        }


        bool
        f_10244_7130_7140()
        {
            var return_v = IsAbstract;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10244, 7130, 7140);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.AccessorListSyntax
        f_10244_7187_7206(Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax
        this_param)
        {
            var return_v = this_param.AccessorList;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10244, 7187, 7206);
            return return_v;
        }


        bool
        f_10244_7186_7231_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10244, 7186, 7231);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.AccessorListSyntax
        f_10244_7338_7357(Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax
        this_param)
        {
            var return_v = this_param.AccessorList;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10244, 7338, 7357);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
        f_10244_7281_7393(Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, Microsoft.CodeAnalysis.Location
        location, params object[]
        args)
        {
            var return_v = diagnostics.Add(code, location, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10244, 7281, 7393);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.AccessorListSyntax
        f_10244_7512_7531(Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax
        this_param)
        {
            var return_v = this_param.AccessorList;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10244, 7512, 7531);
            return return_v;
        }


        bool
        f_10244_7511_7556_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10244, 7511, 7556);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
        f_10244_7692_7706(Microsoft.CodeAnalysis.CSharp.Symbols.SourceCustomEventSymbol
        this_param)
        {
            var return_v = this_param.Locations;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10244, 7692, 7706);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
        f_10244_7637_7716(Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, Microsoft.CodeAnalysis.Location
        location, params object[]
        args)
        {
            var return_v = diagnostics.Add(code, location, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10244, 7637, 7716);
            return return_v;
        }


        bool
        f_10244_7811_7822_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10244, 7811, 7822);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
        f_10244_7910_7924(Microsoft.CodeAnalysis.CSharp.Symbols.SourceCustomEventSymbol
        this_param)
        {
            var return_v = this_param.Locations;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10244, 7910, 7924);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
        f_10244_7856_7928(Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, Microsoft.CodeAnalysis.Location
        location)
        {
            var return_v = diagnostics.Add(code, location);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10244, 7856, 7928);
            return return_v;
        }


        bool
        f_10244_8001_8011()
        {
            var return_v = IsAbstract;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10244, 8001, 8011);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.AccessorListSyntax?
        f_10244_8015_8034(Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax
        this_param)
        {
            var return_v = this_param.AccessorList;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10244, 8015, 8034);
            return return_v;
        }


        bool
        f_10244_8089_8115(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
        this_param)
        {
            var return_v = this_param.IsInterface;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10244, 8089, 8115);
            return return_v;
        }


        int
        f_10244_8076_8116(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10244, 8076, 8116);
            return 0;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
        f_10244_8236_8250(Microsoft.CodeAnalysis.CSharp.Symbols.SourceCustomEventSymbol
        this_param)
        {
            var return_v = this_param.Locations;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10244, 8236, 8250);
            return return_v;
        }


        bool
        f_10244_8137_8254(Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax
        syntax, Microsoft.CodeAnalysis.CSharp.MessageID
        feature, Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics, Microsoft.CodeAnalysis.Location
        location)
        {
            var return_v = Binder.CheckFeatureAvailability((Microsoft.CodeAnalysis.SyntaxNode)syntax, feature, diagnostics, location);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10244, 8137, 8254);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        f_10244_8280_8298()
        {
            var return_v = ContainingAssembly;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10244, 8280, 8298);
            return return_v;
        }


        bool
        f_10244_8279_8344_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10244, 8279, 8344);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
        f_10244_8469_8483(Microsoft.CodeAnalysis.CSharp.Symbols.SourceCustomEventSymbol
        this_param)
        {
            var return_v = this_param.Locations;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10244, 8469, 8483);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
        f_10244_8386_8487(Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, Microsoft.CodeAnalysis.Location
        location)
        {
            var return_v = diagnostics.Add(code, location);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10244, 8386, 8487);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEventAccessorSymbol
        f_10244_8540_8642(Microsoft.CodeAnalysis.CSharp.Symbols.SourceCustomEventSymbol
        @event, bool
        isAdder, Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol?
        explicitlyImplementedEventOpt, string
        aliasQualifierOpt)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEventAccessorSymbol((Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol)@event, isAdder: isAdder, explicitlyImplementedEventOpt, aliasQualifierOpt);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10244, 8540, 8642);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEventAccessorSymbol
        f_10244_8677_8780(Microsoft.CodeAnalysis.CSharp.Symbols.SourceCustomEventSymbol
        @event, bool
        isAdder, Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol?
        explicitlyImplementedEventOpt, string
        aliasQualifierOpt)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEventAccessorSymbol((Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol)@event, isAdder: isAdder, explicitlyImplementedEventOpt, aliasQualifierOpt);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10244, 8677, 8780);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_10244_8881_8901()
        {
            var return_v = DeclaringCompilation;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10244, 8881, 8901);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.SourceCustomEventAccessorSymbol?
        f_10244_8860_8973(Microsoft.CodeAnalysis.CSharp.Symbols.SourceCustomEventSymbol
        this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax?
        syntaxOpt, Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol?
        explicitlyImplementedEventOpt, string
        aliasQualifierOpt, Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics)
        {
            var return_v = this_param.CreateAccessorSymbol(compilation, syntaxOpt, explicitlyImplementedEventOpt, aliasQualifierOpt, diagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10244, 8860, 8973);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_10244_9029_9049()
        {
            var return_v = DeclaringCompilation;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10244, 9029, 9049);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.SourceCustomEventAccessorSymbol?
        f_10244_9008_9124(Microsoft.CodeAnalysis.CSharp.Symbols.SourceCustomEventSymbol
        this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax?
        syntaxOpt, Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol?
        explicitlyImplementedEventOpt, string
        aliasQualifierOpt, Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics)
        {
            var return_v = this_param.CreateAccessorSymbol(compilation, syntaxOpt, explicitlyImplementedEventOpt, aliasQualifierOpt, diagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10244, 9008, 9124);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol>
        f_10244_9333_9395(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
        item)
        {
            var return_v = ImmutableArray.Create<EventSymbol>(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10244, 9333, 9395);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
        f_10244_1236_1250_C(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10244, 1062, 9407);
            return return_v;
        }

    }
}
