// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Diagnostics;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class SourceFieldLikeEventSymbol : SourceEventSymbol
    {
        private readonly string _name;

        private readonly TypeWithAnnotations _type;

        private readonly SynthesizedEventAccessorSymbol _addMethod;

        private readonly SynthesizedEventAccessorSymbol _removeMethod;

        internal SourceFieldLikeEventSymbol(SourceMemberContainerTypeSymbol containingType, Binder binder, SyntaxTokenList modifiers, VariableDeclaratorSyntax declaratorSyntax, DiagnosticBag diagnostics)
        : base(f_10251_1377_1391_C(containingType), declaratorSyntax, modifiers, isFieldLike: true, interfaceSpecifierSyntaxOpt: null, nameTokenSyntax: f_10251_1513_1540(declaratorSyntax), diagnostics: diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10251, 1161, 6169);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10251, 949, 954);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10251, 1066, 1076);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10251, 1135, 1148);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10251, 6463, 6525);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10251, 1592, 1640);

                f_10251_1592_1639(f_10251_1605_1628(declaratorSyntax) is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10251, 1656, 1702);

                _name = declaratorSyntax.Identifier.ValueText;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10251, 1718, 1774);

                var
                declaratorDiagnostics = f_10251_1746_1773()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10251, 1788, 1863);

                var
                declarationSyntax = (VariableDeclarationSyntax)f_10251_1839_1862(declaratorSyntax)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10251, 1877, 1954);

                _type = f_10251_1885_1953(this, binder, f_10251_1907_1929(declarationSyntax), declaratorDiagnostics);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10251, 3286, 3594) || true) && (f_10251_3290_3305(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10251, 3286, 3594);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10251, 3339, 3391);

                    EventSymbol?
                    overriddenEvent = f_10251_3370_3390(this)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10251, 3409, 3579) || true) && ((object?)overriddenEvent != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10251, 3409, 3579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10251, 3487, 3560);

                        f_10251_3487_3559(overriddenEvent, ref _type, f_10251_3540_3558());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10251, 3409, 3579);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10251, 3286, 3594);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10251, 3610, 3669);

                bool
                hasInitializer = f_10251_3632_3660(declaratorSyntax) != null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10251, 3683, 3739);

                bool
                inInterfaceType = f_10251_3706_3738(containingType)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10251, 3755, 4366) || true) && (hasInitializer)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10251, 3755, 4366);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10251, 3807, 4351) || true) && (inInterfaceType && (DynAbs.Tracing.TraceSender.Expression_True(10251, 3811, 3844) && f_10251_3830_3844_M(!this.IsStatic)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10251, 3807, 4351);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10251, 3886, 3968);

                        f_10251_3886_3967(diagnostics, ErrorCode.ERR_InterfaceEventInitializer, f_10251_3943_3957(this)[0], this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10251, 3807, 4351);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10251, 3807, 4351);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10251, 4010, 4351) || true) && (f_10251_4014_4029(this))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10251, 4010, 4351);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10251, 4071, 4152);

                            f_10251_4071_4151(diagnostics, ErrorCode.ERR_AbstractEventInitializer, f_10251_4127_4141(this)[0], this);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10251, 4010, 4351);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10251, 4010, 4351);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10251, 4194, 4351) || true) && (f_10251_4198_4211(this))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10251, 4194, 4351);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10251, 4253, 4332);

                                f_10251_4253_4331(diagnostics, ErrorCode.ERR_ExternEventInitializer, f_10251_4307_4321(this)[0], this);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10251, 4194, 4351);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10251, 4010, 4351);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10251, 3807, 4351);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10251, 3755, 4366);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10251, 4548, 4833) || true) && (hasInitializer || (DynAbs.Tracing.TraceSender.Expression_False(10251, 4552, 4605) || !(f_10251_4572_4585(this) || (DynAbs.Tracing.TraceSender.Expression_False(10251, 4572, 4604) || f_10251_4589_4604(this)))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10251, 4548, 4833);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10251, 4639, 4700);

                    AssociatedEventField = f_10251_4662_4699(this, declaratorSyntax);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10251, 4548, 4833);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10251, 4849, 5016) || true) && (f_10251_4853_4862_M(!IsStatic) && (DynAbs.Tracing.TraceSender.Expression_True(10251, 4853, 4891) && f_10251_4866_4891(f_10251_4866_4880())))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10251, 4849, 5016);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10251, 4925, 5001);

                    f_10251_4925_5000(diagnostics, ErrorCode.ERR_FieldlikeEventsInRoStruct, f_10251_4982_4996(this)[0]);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10251, 4849, 5016);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10251, 5032, 5623) || true) && (inInterfaceType)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10251, 5032, 5623);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10251, 5085, 5608) || true) && (f_10251_5089_5102(this) || (DynAbs.Tracing.TraceSender.Expression_False(10251, 5089, 5119) || f_10251_5106_5119(this)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10251, 5085, 5608);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10251, 5161, 5405) || true) && (f_10251_5165_5230_M(!f_10251_5166_5184().RuntimeSupportsDefaultInterfaceImplementation))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10251, 5161, 5405);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10251, 5280, 5382);

                            f_10251_5280_5381(diagnostics, ErrorCode.ERR_RuntimeDoesNotSupportDefaultInterfaceImplementation, f_10251_5363_5377(this)[0]);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10251, 5161, 5405);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10251, 5085, 5608);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10251, 5085, 5608);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10251, 5447, 5608) || true) && (f_10251_5451_5467_M(!this.IsAbstract))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10251, 5447, 5608);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10251, 5509, 5589);

                            f_10251_5509_5588(diagnostics, ErrorCode.ERR_EventNeedsBothAccessors, f_10251_5564_5578(this)[0], this);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10251, 5447, 5608);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10251, 5085, 5608);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10251, 5032, 5623);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10251, 5701, 5770);

                _addMethod = f_10251_5714_5769(this, isAdder: true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10251, 5784, 5857);

                _removeMethod = f_10251_5800_5856(this, isAdder: false);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10251, 5873, 6113) || true) && (f_10251_5877_5904(declarationSyntax)[0] == declaratorSyntax)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10251, 5873, 6113);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10251, 6054, 6098);

                    f_10251_6054_6097(                // Don't report these diagnostics for every declarator in this declaration.
                                    diagnostics, declaratorDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10251, 5873, 6113);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10251, 6129, 6158);

                f_10251_6129_6157(
                            declaratorDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10251, 1161, 6169);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10251, 1161, 6169);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10251, 1161, 6169);
            }
        }

        internal override FieldSymbol? AssociatedField
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10251, 6427, 6450);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10251, 6430, 6450);
                    return f_10251_6430_6450(); DynAbs.Tracing.TraceSender.TraceExitMethod(10251, 6427, 6450);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10251, 6427, 6450);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10251, 6427, 6450);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal SourceEventFieldSymbol? AssociatedEventField { get; }

        public override string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10251, 6589, 6610);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10251, 6595, 6608);

                    return _name;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10251, 6589, 6610);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10251, 6537, 6621);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10251, 6537, 6621);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override TypeWithAnnotations TypeWithAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10251, 6713, 6734);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10251, 6719, 6732);

                    return _type;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10251, 6713, 6734);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10251, 6633, 6745);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10251, 6633, 6745);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override MethodSymbol AddMethod
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10251, 6820, 6846);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10251, 6826, 6844);

                    return _addMethod;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10251, 6820, 6846);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10251, 6757, 6857);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10251, 6757, 6857);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override MethodSymbol RemoveMethod
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10251, 6935, 6964);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10251, 6941, 6962);

                    return _removeMethod;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10251, 6935, 6964);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10251, 6869, 6975);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10251, 6869, 6975);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10251, 7068, 7089);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10251, 7074, 7087);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10251, 7068, 7089);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10251, 6987, 7100);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10251, 6987, 7100);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10251, 7199, 7469);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10251, 7235, 7454);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10251, 7242, 7279) || (((object?)f_10251_7251_7271() != null && DynAbs.Tracing.TraceSender.Conditional_F2(10251, 7303, 7379)) || DynAbs.Tracing.TraceSender.Conditional_F3(10251, 7403, 7453))) ? AttributeLocation.Event | AttributeLocation.Method | AttributeLocation.Field : AttributeLocation.Event | AttributeLocation.Method;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10251, 7199, 7469);

                    Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventFieldSymbol?
                    f_10251_7251_7271()
                    {
                        var return_v = AssociatedEventField;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10251, 7251, 7271);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10251, 7112, 7480);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10251, 7112, 7480);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10251, 7593, 7642);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10251, 7599, 7640);

                    return ImmutableArray<EventSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10251, 7593, 7642);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10251, 7492, 7653);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10251, 7492, 7653);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private SourceEventFieldSymbol MakeAssociatedField(VariableDeclaratorSyntax declaratorSyntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10251, 7665, 8077);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10251, 7783, 7848);

                DiagnosticBag
                discardedDiagnostics = f_10251_7820_7847()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10251, 7862, 7947);

                var
                field = f_10251_7874_7946(this, declaratorSyntax, discardedDiagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10251, 7961, 7989);

                f_10251_7961_7988(discardedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10251, 8005, 8039);

                f_10251_8005_8038(f_10251_8018_8028(field) == _name);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10251, 8053, 8066);

                return field;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10251, 7665, 8077);

                Microsoft.CodeAnalysis.DiagnosticBag
                f_10251_7820_7847()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10251, 7820, 7847);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventFieldSymbol
                f_10251_7874_7946(Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldLikeEventSymbol
                associatedEvent, Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
                declaratorSyntax, Microsoft.CodeAnalysis.DiagnosticBag
                discardedDiagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventFieldSymbol((Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol)associatedEvent, declaratorSyntax, discardedDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10251, 7874, 7946);
                    return return_v;
                }


                int
                f_10251_7961_7988(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10251, 7961, 7988);
                    return 0;
                }


                string
                f_10251_8018_8028(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventFieldSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10251, 8018, 8028);
                    return return_v;
                }


                int
                f_10251_8005_8038(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10251, 8005, 8038);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10251, 7665, 8077);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10251, 7665, 8077);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override void ForceComplete(SourceLocation? locationOpt, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10251, 8089, 8451);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10251, 8216, 8373) || true) && ((object?)f_10251_8229_8249(this) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10251, 8216, 8373);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10251, 8291, 8358);

                    f_10251_8291_8357(f_10251_8291_8311(this), locationOpt, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10251, 8216, 8373);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10251, 8389, 8440);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.ForceComplete(locationOpt, cancellationToken), 10251, 8389, 8439);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10251, 8089, 8451);

                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?
                f_10251_8229_8249(Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldLikeEventSymbol
                this_param)
                {
                    var return_v = this_param.AssociatedField;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10251, 8229, 8249);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10251_8291_8311(Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldLikeEventSymbol
                this_param)
                {
                    var return_v = this_param.AssociatedField;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10251, 8291, 8311);
                    return return_v;
                }


                int
                f_10251_8291_8357(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param, Microsoft.CodeAnalysis.SourceLocation?
                locationOpt, System.Threading.CancellationToken
                cancellationToken)
                {
                    this_param.ForceComplete(locationOpt, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10251, 8291, 8357);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10251, 8089, 8451);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10251, 8089, 8451);
            }
        }

        static SourceFieldLikeEventSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10251, 840, 8458);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10251, 840, 8458);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10251, 840, 8458);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10251, 840, 8458);

        static Microsoft.CodeAnalysis.SyntaxToken
        f_10251_1513_1540(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
        this_param)
        {
            var return_v = this_param.Identifier;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10251, 1513, 1540);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
        f_10251_1605_1628(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
        this_param)
        {
            var return_v = this_param.Parent;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10251, 1605, 1628);
            return return_v;
        }


        int
        f_10251_1592_1639(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10251, 1592, 1639);
            return 0;
        }


        Microsoft.CodeAnalysis.DiagnosticBag
        f_10251_1746_1773()
        {
            var return_v = DiagnosticBag.GetInstance();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10251, 1746, 1773);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
        f_10251_1839_1862(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
        this_param)
        {
            var return_v = this_param.Parent;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10251, 1839, 1862);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
        f_10251_1907_1929(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
        this_param)
        {
            var return_v = this_param.Type;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10251, 1907, 1929);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
        f_10251_1885_1953(Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldLikeEventSymbol
        this_param, Microsoft.CodeAnalysis.CSharp.Binder
        binder, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
        typeSyntax, Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics)
        {
            var return_v = this_param.BindEventType(binder, typeSyntax, diagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10251, 1885, 1953);
            return return_v;
        }


        bool
        f_10251_3290_3305(Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldLikeEventSymbol
        this_param)
        {
            var return_v = this_param.IsOverride;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10251, 3290, 3305);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol?
        f_10251_3370_3390(Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldLikeEventSymbol
        this_param)
        {
            var return_v = this_param.OverriddenEvent;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10251, 3370, 3390);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        f_10251_3540_3558()
        {
            var return_v = ContainingAssembly;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10251, 3540, 3558);
            return return_v;
        }


        int
        f_10251_3487_3559(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
        eventWithCustomModifiers, ref Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
        type, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        containingAssembly)
        {
            CopyEventCustomModifiers(eventWithCustomModifiers, ref type, containingAssembly);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10251, 3487, 3559);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax?
        f_10251_3632_3660(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
        this_param)
        {
            var return_v = this_param.Initializer;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10251, 3632, 3660);
            return return_v;
        }


        bool
        f_10251_3706_3738(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
        type)
        {
            var return_v = type.IsInterfaceType();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10251, 3706, 3738);
            return return_v;
        }


        bool
        f_10251_3830_3844_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10251, 3830, 3844);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
        f_10251_3943_3957(Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldLikeEventSymbol
        this_param)
        {
            var return_v = this_param.Locations;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10251, 3943, 3957);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
        f_10251_3886_3967(Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, Microsoft.CodeAnalysis.Location
        location, params object[]
        args)
        {
            var return_v = diagnostics.Add(code, location, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10251, 3886, 3967);
            return return_v;
        }


        bool
        f_10251_4014_4029(Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldLikeEventSymbol
        this_param)
        {
            var return_v = this_param.IsAbstract;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10251, 4014, 4029);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
        f_10251_4127_4141(Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldLikeEventSymbol
        this_param)
        {
            var return_v = this_param.Locations;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10251, 4127, 4141);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
        f_10251_4071_4151(Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, Microsoft.CodeAnalysis.Location
        location, params object[]
        args)
        {
            var return_v = diagnostics.Add(code, location, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10251, 4071, 4151);
            return return_v;
        }


        bool
        f_10251_4198_4211(Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldLikeEventSymbol
        this_param)
        {
            var return_v = this_param.IsExtern;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10251, 4198, 4211);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
        f_10251_4307_4321(Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldLikeEventSymbol
        this_param)
        {
            var return_v = this_param.Locations;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10251, 4307, 4321);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
        f_10251_4253_4331(Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, Microsoft.CodeAnalysis.Location
        location, params object[]
        args)
        {
            var return_v = diagnostics.Add(code, location, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10251, 4253, 4331);
            return return_v;
        }


        bool
        f_10251_4572_4585(Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldLikeEventSymbol
        this_param)
        {
            var return_v = this_param.IsExtern;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10251, 4572, 4585);
            return return_v;
        }


        bool
        f_10251_4589_4604(Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldLikeEventSymbol
        this_param)
        {
            var return_v = this_param.IsAbstract;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10251, 4589, 4604);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventFieldSymbol
        f_10251_4662_4699(Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldLikeEventSymbol
        this_param, Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
        declaratorSyntax)
        {
            var return_v = this_param.MakeAssociatedField(declaratorSyntax);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10251, 4662, 4699);
            return return_v;
        }


        bool
        f_10251_4853_4862_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10251, 4853, 4862);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10251_4866_4880()
        {
            var return_v = ContainingType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10251, 4866, 4880);
            return return_v;
        }


        bool
        f_10251_4866_4891(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param)
        {
            var return_v = this_param.IsReadOnly;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10251, 4866, 4891);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
        f_10251_4982_4996(Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldLikeEventSymbol
        this_param)
        {
            var return_v = this_param.Locations;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10251, 4982, 4996);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
        f_10251_4925_5000(Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, Microsoft.CodeAnalysis.Location
        location)
        {
            var return_v = diagnostics.Add(code, location);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10251, 4925, 5000);
            return return_v;
        }


        bool
        f_10251_5089_5102(Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldLikeEventSymbol
        this_param)
        {
            var return_v = this_param.IsExtern;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10251, 5089, 5102);
            return return_v;
        }


        bool
        f_10251_5106_5119(Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldLikeEventSymbol
        this_param)
        {
            var return_v = this_param.IsStatic;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10251, 5106, 5119);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        f_10251_5166_5184()
        {
            var return_v = ContainingAssembly;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10251, 5166, 5184);
            return return_v;
        }


        bool
        f_10251_5165_5230_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10251, 5165, 5230);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
        f_10251_5363_5377(Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldLikeEventSymbol
        this_param)
        {
            var return_v = this_param.Locations;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10251, 5363, 5377);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
        f_10251_5280_5381(Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, Microsoft.CodeAnalysis.Location
        location)
        {
            var return_v = diagnostics.Add(code, location);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10251, 5280, 5381);
            return return_v;
        }


        bool
        f_10251_5451_5467_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10251, 5451, 5467);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
        f_10251_5564_5578(Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldLikeEventSymbol
        this_param)
        {
            var return_v = this_param.Locations;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10251, 5564, 5578);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
        f_10251_5509_5588(Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, Microsoft.CodeAnalysis.Location
        location, params object[]
        args)
        {
            var return_v = diagnostics.Add(code, location, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10251, 5509, 5588);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEventAccessorSymbol
        f_10251_5714_5769(Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldLikeEventSymbol
        @event, bool
        isAdder)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEventAccessorSymbol((Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol)@event, isAdder: isAdder);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10251, 5714, 5769);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEventAccessorSymbol
        f_10251_5800_5856(Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldLikeEventSymbol
        @event, bool
        isAdder)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEventAccessorSymbol((Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol)@event, isAdder: isAdder);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10251, 5800, 5856);
            return return_v;
        }


        Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax>
        f_10251_5877_5904(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
        this_param)
        {
            var return_v = this_param.Variables;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10251, 5877, 5904);
            return return_v;
        }


        int
        f_10251_6054_6097(Microsoft.CodeAnalysis.DiagnosticBag
        this_param, Microsoft.CodeAnalysis.DiagnosticBag
        bag)
        {
            this_param.AddRange(bag);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10251, 6054, 6097);
            return 0;
        }


        int
        f_10251_6129_6157(Microsoft.CodeAnalysis.DiagnosticBag
        this_param)
        {
            this_param.Free();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10251, 6129, 6157);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
        f_10251_1377_1391_C(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10251, 1161, 6169);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventFieldSymbol?
        f_10251_6430_6450()
        {
            var return_v = AssociatedEventField;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10251, 6430, 6450);
            return return_v;
        }

    }
}
