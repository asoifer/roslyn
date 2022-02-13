// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Emit;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal abstract class SourceTypeParameterSymbolBase : TypeParameterSymbol, IAttributeTargetSymbol
    {
        private readonly ImmutableArray<SyntaxReference> _syntaxRefs;

        private readonly ImmutableArray<Location> _locations;

        private readonly string _name;

        private readonly short _ordinal;

        private SymbolCompletionState _state;

        private CustomAttributesBag<CSharpAttributeData> _lazyCustomAttributesBag;

        private TypeParameterBounds _lazyBounds;

        protected SourceTypeParameterSymbolBase(string name, int ordinal, ImmutableArray<Location> locations, ImmutableArray<SyntaxReference> syntaxRefs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10276, 1230, 1590);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 959, 964);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 998, 1006);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 1115, 1139);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 1178, 1217);
                this._lazyBounds = TypeParameterBounds.Unset; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 1400, 1434);

                f_10276_1400_1433(f_10276_1413_1432_M(!syntaxRefs.IsEmpty));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 1450, 1463);

                _name = name;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 1477, 1503);

                _ordinal = (short)ordinal;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 1517, 1540);

                _locations = locations;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 1554, 1579);

                _syntaxRefs = syntaxRefs;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10276, 1230, 1590);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 1230, 1590);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 1230, 1590);
            }
        }

        public override ImmutableArray<Location> Locations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 1677, 1746);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 1713, 1731);

                    return _locations;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 1677, 1746);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 1602, 1757);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 1602, 1757);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<SyntaxReference> DeclaringSyntaxReferences
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 1867, 1937);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 1903, 1922);

                    return _syntaxRefs;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 1867, 1937);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 1769, 1948);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 1769, 1948);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal ImmutableArray<SyntaxReference> SyntaxReferences
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 2042, 2112);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 2078, 2097);

                    return _syntaxRefs;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 2042, 2112);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 1960, 2123);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 1960, 2123);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int Ordinal
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 2187, 2254);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 2223, 2239);

                    return _ordinal;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 2187, 2254);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 2135, 2265);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 2135, 2265);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override VarianceKind Variance
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 2339, 2415);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 2375, 2400);

                    return VarianceKind.None;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 2339, 2415);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 2277, 2426);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 2277, 2426);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 2490, 2554);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 2526, 2539);

                    return _name;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 2490, 2554);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 2438, 2565);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 2438, 2565);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ImmutableArray<TypeWithAnnotations> GetConstraintTypes(ConsList<TypeParameterSymbol> inProgress)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 2577, 2874);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 2716, 2756);

                var
                bounds = f_10276_2729_2755(this, inProgress)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 2770, 2863);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10276, 2777, 2793) || (((bounds != null) && DynAbs.Tracing.TraceSender.Conditional_F2(10276, 2796, 2818)) || DynAbs.Tracing.TraceSender.Conditional_F3(10276, 2821, 2862))) ? bounds.ConstraintTypes : ImmutableArray<TypeWithAnnotations>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 2577, 2874);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterBounds
                f_10276_2729_2755(Microsoft.CodeAnalysis.CSharp.Symbols.SourceTypeParameterSymbolBase
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                inProgress)
                {
                    var return_v = this_param.GetBounds(inProgress);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 2729, 2755);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 2577, 2874);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 2577, 2874);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<NamedTypeSymbol> GetInterfaces(ConsList<TypeParameterSymbol> inProgress)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 2886, 3165);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 3016, 3056);

                var
                bounds = f_10276_3029_3055(this, inProgress)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 3070, 3154);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10276, 3077, 3093) || (((bounds != null) && DynAbs.Tracing.TraceSender.Conditional_F2(10276, 3096, 3113)) || DynAbs.Tracing.TraceSender.Conditional_F3(10276, 3116, 3153))) ? bounds.Interfaces : ImmutableArray<NamedTypeSymbol>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 2886, 3165);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterBounds
                f_10276_3029_3055(Microsoft.CodeAnalysis.CSharp.Symbols.SourceTypeParameterSymbolBase
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                inProgress)
                {
                    var return_v = this_param.GetBounds(inProgress);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 3029, 3055);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 2886, 3165);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 2886, 3165);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override NamedTypeSymbol GetEffectiveBaseClass(ConsList<TypeParameterSymbol> inProgress)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 3177, 3444);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 3299, 3339);

                var
                bounds = f_10276_3312_3338(this, inProgress)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 3353, 3433);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10276, 3360, 3376) || (((bounds != null) && DynAbs.Tracing.TraceSender.Conditional_F2(10276, 3379, 3404)) || DynAbs.Tracing.TraceSender.Conditional_F3(10276, 3407, 3432))) ? bounds.EffectiveBaseClass : f_10276_3407_3432(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 3177, 3444);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterBounds
                f_10276_3312_3338(Microsoft.CodeAnalysis.CSharp.Symbols.SourceTypeParameterSymbolBase
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                inProgress)
                {
                    var return_v = this_param.GetBounds(inProgress);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 3312, 3338);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10276_3407_3432(Microsoft.CodeAnalysis.CSharp.Symbols.SourceTypeParameterSymbolBase
                this_param)
                {
                    var return_v = this_param.GetDefaultBaseType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 3407, 3432);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 3177, 3444);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 3177, 3444);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override TypeSymbol GetDeducedBaseType(ConsList<TypeParameterSymbol> inProgress)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 3456, 3712);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 3570, 3610);

                var
                bounds = f_10276_3583_3609(this, inProgress)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 3624, 3701);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10276, 3631, 3647) || (((bounds != null) && DynAbs.Tracing.TraceSender.Conditional_F2(10276, 3650, 3672)) || DynAbs.Tracing.TraceSender.Conditional_F3(10276, 3675, 3700))) ? bounds.DeducedBaseType : f_10276_3675_3700(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 3456, 3712);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterBounds
                f_10276_3583_3609(Microsoft.CodeAnalysis.CSharp.Symbols.SourceTypeParameterSymbolBase
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                inProgress)
                {
                    var return_v = this_param.GetBounds(inProgress);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 3583, 3609);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10276_3675_3700(Microsoft.CodeAnalysis.CSharp.Symbols.SourceTypeParameterSymbolBase
                this_param)
                {
                    var return_v = this_param.GetDefaultBaseType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 3675, 3700);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 3456, 3712);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 3456, 3712);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ImmutableArray<SyntaxList<AttributeListSyntax>> MergedAttributeDeclarationSyntaxLists
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 3843, 4931);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 3879, 3969);

                    var
                    mergedAttributesBuilder = f_10276_3909_3968()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 3989, 4216);
                        foreach (var syntaxRef in f_10276_4015_4026_I(_syntaxRefs))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10276, 3989, 4216);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 4068, 4124);

                            var
                            syntax = (TypeParameterSyntax)f_10276_4102_4123(syntaxRef)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 4146, 4197);

                            f_10276_4146_4196(mergedAttributesBuilder, f_10276_4174_4195(syntax));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10276, 3989, 4216);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10276, 1, 228);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10276, 1, 228);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 4236, 4307);

                    var
                    sourceMethod = f_10276_4255_4276(this) as SourceOrdinaryMethodSymbol
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 4325, 4844) || true) && ((object)sourceMethod != null && (DynAbs.Tracing.TraceSender.Expression_True(10276, 4329, 4383) && f_10276_4361_4383(sourceMethod)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10276, 4325, 4844);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 4425, 4489);

                        var
                        implementingPart = f_10276_4448_4488(sourceMethod)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 4511, 4825) || true) && ((object)implementingPart != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10276, 4511, 4825);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 4597, 4690);

                            var
                            typeParameter = (SourceTypeParameterSymbolBase)f_10276_4648_4679(implementingPart)[_ordinal]
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 4716, 4802);

                            f_10276_4716_4801(mergedAttributesBuilder, f_10276_4749_4800(typeParameter));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10276, 4511, 4825);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10276, 4325, 4844);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 4864, 4916);

                    return f_10276_4871_4915(mergedAttributesBuilder);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 3843, 4931);

                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                    f_10276_3909_3968()
                    {
                        var return_v = ArrayBuilder<SyntaxList<AttributeListSyntax>>.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 3909, 3968);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxNode
                    f_10276_4102_4123(Microsoft.CodeAnalysis.SyntaxReference
                    this_param)
                    {
                        var return_v = this_param.GetSyntax();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 4102, 4123);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                    f_10276_4174_4195(Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterSyntax
                    this_param)
                    {
                        var return_v = this_param.AttributeLists;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 4174, 4195);
                        return return_v;
                    }


                    int
                    f_10276_4146_4196(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                    this_param, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 4146, 4196);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
                    f_10276_4015_4026_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 4015, 4026);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10276_4255_4276(Microsoft.CodeAnalysis.CSharp.Symbols.SourceTypeParameterSymbolBase
                    this_param)
                    {
                        var return_v = this_param.ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 4255, 4276);
                        return return_v;
                    }


                    bool
                    f_10276_4361_4383(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsPartial;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 4361, 4383);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                    f_10276_4448_4488(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.SourcePartialImplementation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 4448, 4488);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    f_10276_4648_4679(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeParameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 4648, 4679);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                    f_10276_4749_4800(Microsoft.CodeAnalysis.CSharp.Symbols.SourceTypeParameterSymbolBase
                    this_param)
                    {
                        var return_v = this_param.MergedAttributeDeclarationSyntaxLists;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 4749, 4800);
                        return return_v;
                    }


                    int
                    f_10276_4716_4801(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                    items)
                    {
                        this_param.AddRange(items);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 4716, 4801);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                    f_10276_4871_4915(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                    this_param)
                    {
                        var return_v = this_param.ToImmutableAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 4871, 4915);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 3724, 4942);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 3724, 4942);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        IAttributeTargetSymbol IAttributeTargetSymbol.AttributesOwner
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 5040, 5060);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 5046, 5058);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 5040, 5060);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 4954, 5071);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 4954, 5071);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        AttributeLocation IAttributeTargetSymbol.DefaultAttributeLocation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 5173, 5220);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 5179, 5218);

                    return AttributeLocation.TypeParameter;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 5173, 5220);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 5083, 5231);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 5083, 5231);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        AttributeLocation IAttributeTargetSymbol.AllowedAttributeLocations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 5334, 5381);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 5340, 5379);

                    return AttributeLocation.TypeParameter;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 5334, 5381);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 5243, 5392);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 5243, 5392);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override ImmutableArray<CSharpAttributeData> GetAttributes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 5825, 5977);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 5924, 5966);

                return f_10276_5931_5965(f_10276_5931_5954(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 5825, 5977);

                Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10276_5931_5954(Microsoft.CodeAnalysis.CSharp.Symbols.SourceTypeParameterSymbolBase
                this_param)
                {
                    var return_v = this_param.GetAttributesBag();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 5931, 5954);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10276_5931_5965(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param)
                {
                    var return_v = this_param.Attributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 5931, 5965);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 5825, 5977);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 5825, 5977);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual CustomAttributesBag<CSharpAttributeData> GetAttributesBag()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 6303, 7958);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 6404, 7899) || true) && (_lazyCustomAttributesBag == null || (DynAbs.Tracing.TraceSender.Expression_False(10276, 6408, 6478) || f_10276_6444_6478_M(!_lazyCustomAttributesBag.IsSealed)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10276, 6404, 7899);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 6512, 6546);

                    bool
                    lazyAttributesStored = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 6566, 6637);

                    var
                    sourceMethod = f_10276_6585_6606(this) as SourceOrdinaryMethodSymbol
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 6655, 7728) || true) && ((object)sourceMethod == null || (DynAbs.Tracing.TraceSender.Expression_False(10276, 6659, 6743) || (object)f_10276_6699_6735(sourceMethod) == null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10276, 6655, 7728);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 6785, 7268);

                        lazyAttributesStored = f_10276_6808_7267(this, f_10276_6860_6920(f_10276_6877_6919(this)), ref _lazyCustomAttributesBag, binderOpt:
                        (DynAbs.Tracing.TraceSender.Conditional_F1(10276, 7160, 7201) || ((                        // LAFHIS
                                                                                                                   //(ContainingSymbol as LocalFunctionSymbol)?.SignatureBinder)
                                                (f_10276_7161_7177() is LocalFunctionSymbol) && DynAbs.Tracing.TraceSender.Conditional_F2(10276, 7204, 7259)) || DynAbs.Tracing.TraceSender.Conditional_F3(10276, 7262, 7266))) ? f_10276_7204_7259(((LocalFunctionSymbol)f_10276_7226_7242())) : null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10276, 6655, 7728);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10276, 6655, 7728);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 7350, 7463);

                        var
                        typeParameter = (SourceTypeParameterSymbolBase)f_10276_7401_7452(f_10276_7401_7437(sourceMethod))[_ordinal]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 7485, 7575);

                        CustomAttributesBag<CSharpAttributeData>
                        attributesBag = f_10276_7542_7574(typeParameter)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 7599, 7709);

                        lazyAttributesStored = f_10276_7622_7700(ref _lazyCustomAttributesBag, attributesBag, null) == null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10276, 6655, 7728);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 7748, 7884) || true) && (lazyAttributesStored)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10276, 7748, 7884);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 7814, 7865);

                        _state.NotePartComplete(CompletionPart.Attributes);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10276, 7748, 7884);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10276, 6404, 7899);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 7915, 7947);

                return _lazyCustomAttributesBag;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 6303, 7958);

                bool
                f_10276_6444_6478_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 6444, 6478);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10276_6585_6606(Microsoft.CodeAnalysis.CSharp.Symbols.SourceTypeParameterSymbolBase
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 6585, 6606);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                f_10276_6699_6735(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.SourcePartialDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 6699, 6735);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                f_10276_6877_6919(Microsoft.CodeAnalysis.CSharp.Symbols.SourceTypeParameterSymbolBase
                this_param)
                {
                    var return_v = this_param.MergedAttributeDeclarationSyntaxLists;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 6877, 6919);
                    return return_v;
                }


                Roslyn.Utilities.OneOrMany<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                f_10276_6860_6920(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                many)
                {
                    var return_v = OneOrMany.Create(many);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 6860, 6920);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10276_7161_7177()
                {
                    var return_v = ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 7161, 7177);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10276_7226_7242()
                {
                    var return_v = ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 7226, 7242);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10276_7204_7259(Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                this_param)
                {
                    var return_v = this_param.SignatureBinder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 7204, 7259);
                    return return_v;
                }


                bool
                f_10276_6808_7267(Microsoft.CodeAnalysis.CSharp.Symbols.SourceTypeParameterSymbolBase
                this_param, Roslyn.Utilities.OneOrMany<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                attributesSyntaxLists, ref Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>?
                lazyCustomAttributesBag, Microsoft.CodeAnalysis.CSharp.Binder?
                binderOpt)
                {
                    var return_v = this_param.LoadAndValidateAttributes(attributesSyntaxLists, ref lazyCustomAttributesBag, binderOpt: binderOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 6808, 7267);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                f_10276_7401_7437(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.SourcePartialDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 7401, 7437);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10276_7401_7452(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 7401, 7452);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10276_7542_7574(Microsoft.CodeAnalysis.CSharp.Symbols.SourceTypeParameterSymbolBase
                this_param)
                {
                    var return_v = this_param.GetAttributesBag();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 7542, 7574);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>?
                f_10276_7622_7700(ref Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>?
                location1, Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                value, Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 7622, 7700);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 6303, 7958);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 6303, 7958);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override void EnsureAllConstraintsAreResolved()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 7970, 8197);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 8051, 8186) || true) && (!f_10276_8056_8075(_lazyBounds))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10276, 8051, 8186);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 8109, 8171);

                    f_10276_8109_8170(f_10276_8141_8169(this));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10276, 8051, 8186);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 7970, 8197);

                bool
                f_10276_8056_8075(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterBounds
                boundsOpt)
                {
                    var return_v = boundsOpt.IsSet();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 8056, 8075);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10276_8141_8169(Microsoft.CodeAnalysis.CSharp.Symbols.SourceTypeParameterSymbolBase
                this_param)
                {
                    var return_v = this_param.ContainerTypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 8141, 8169);
                    return return_v;
                }


                int
                f_10276_8109_8170(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                typeParameters)
                {
                    EnsureAllConstraintsAreResolved(typeParameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 8109, 8170);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 7970, 8197);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 7970, 8197);
            }
        }

        protected abstract ImmutableArray<TypeParameterSymbol> ContainerTypeParameters
        {
            get;
        }

        private TypeParameterBounds GetBounds(ConsList<TypeParameterSymbol> inProgress)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 8339, 9457);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 8443, 8493);

                f_10276_8443_8492(!f_10276_8457_8491(inProgress, this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 8507, 8615);

                f_10276_8507_8614(!f_10276_8521_8537(inProgress) || (DynAbs.Tracing.TraceSender.Expression_False(10276, 8520, 8613) || f_10276_8541_8613(f_10276_8557_8589(f_10276_8557_8572(inProgress)), f_10276_8591_8612(this))));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 8631, 9411) || true) && (!f_10276_8636_8655(_lazyBounds))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10276, 8631, 9411);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 8689, 8735);

                    var
                    diagnostics = f_10276_8707_8734()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 8753, 8810);

                    var
                    bounds = f_10276_8766_8809(this, inProgress, diagnostics)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 8830, 9357) || true) && (f_10276_8834_8957(f_10276_8850_8929(ref _lazyBounds, bounds, TypeParameterBounds.Unset), TypeParameterBounds.Unset))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10276, 8830, 9357);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 8999, 9048);

                        f_10276_8999_9047(this, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 9070, 9113);

                        f_10276_9070_9112(this, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 9135, 9185);

                        f_10276_9135_9184(this, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 9207, 9251);

                        f_10276_9207_9250(this, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 9273, 9338);

                        _state.NotePartComplete(CompletionPart.TypeParameterConstraints);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10276, 8830, 9357);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 9377, 9396);

                    f_10276_9377_9395(
                                    diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10276, 8631, 9411);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 9427, 9446);

                return _lazyBounds;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 8339, 9457);

                bool
                f_10276_8457_8491(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                list, Microsoft.CodeAnalysis.CSharp.Symbols.SourceTypeParameterSymbolBase
                element)
                {
                    var return_v = list.ContainsReference<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>((Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol)element);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 8457, 8491);
                    return return_v;
                }


                int
                f_10276_8443_8492(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 8443, 8492);
                    return 0;
                }


                bool
                f_10276_8521_8537(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                this_param)
                {
                    var return_v = this_param.Any();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 8521, 8537);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                f_10276_8557_8572(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                this_param)
                {
                    var return_v = this_param.Head;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 8557, 8572);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10276_8557_8589(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 8557, 8589);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10276_8591_8612(Microsoft.CodeAnalysis.CSharp.Symbols.SourceTypeParameterSymbolBase
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 8591, 8612);
                    return return_v;
                }


                bool
                f_10276_8541_8613(Microsoft.CodeAnalysis.CSharp.Symbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 8541, 8613);
                    return return_v;
                }


                int
                f_10276_8507_8614(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 8507, 8614);
                    return 0;
                }


                bool
                f_10276_8636_8655(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterBounds
                boundsOpt)
                {
                    var return_v = boundsOpt.IsSet();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 8636, 8655);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10276_8707_8734()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 8707, 8734);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterBounds
                f_10276_8766_8809(Microsoft.CodeAnalysis.CSharp.Symbols.SourceTypeParameterSymbolBase
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                inProgress, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.ResolveBounds(inProgress, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 8766, 8809);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterBounds
                f_10276_8850_8929(ref Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterBounds
                location1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterBounds
                value, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterBounds
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 8850, 8929);
                    return return_v;
                }


                bool
                f_10276_8834_8957(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterBounds
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterBounds
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 8834, 8957);
                    return return_v;
                }


                int
                f_10276_8999_9047(Microsoft.CodeAnalysis.CSharp.Symbols.SourceTypeParameterSymbolBase
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.CheckConstraintTypeConstraints(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 8999, 9047);
                    return 0;
                }


                int
                f_10276_9070_9112(Microsoft.CodeAnalysis.CSharp.Symbols.SourceTypeParameterSymbolBase
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.CheckUnmanagedConstraint(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 9070, 9112);
                    return 0;
                }


                int
                f_10276_9135_9184(Microsoft.CodeAnalysis.CSharp.Symbols.SourceTypeParameterSymbolBase
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.EnsureAttributesFromConstraints(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 9135, 9184);
                    return 0;
                }


                int
                f_10276_9207_9250(Microsoft.CodeAnalysis.CSharp.Symbols.SourceTypeParameterSymbolBase
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.AddDeclarationDiagnostics(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 9207, 9250);
                    return 0;
                }


                int
                f_10276_9377_9395(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 9377, 9395);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 8339, 9457);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 8339, 9457);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract TypeParameterBounds ResolveBounds(ConsList<TypeParameterSymbol> inProgress, DiagnosticBag diagnostics);

        private void CheckConstraintTypeConstraints(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 10012, 10879);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 10107, 10170);

                var
                constraintTypes = f_10276_10129_10169(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 10184, 10271) || true) && (constraintTypes.Length == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10276, 10184, 10271);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 10249, 10256);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10276, 10184, 10271);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 10287, 10443);

                var
                args = f_10276_10298_10442(f_10276_10341_10361(), f_10276_10363_10413(f_10276_10383_10412(f_10276_10383_10401())), _locations[0], diagnostics)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 10457, 10868);
                    foreach (var constraintType in f_10276_10488_10503_I(constraintTypes))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10276, 10457, 10868);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 10537, 10587);

                        HashSet<DiagnosticInfo>
                        useSiteDiagnostics = null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 10605, 10671);

                        f_10276_10605_10670(constraintType.Type, ref useSiteDiagnostics);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 10691, 10853) || true) && (!f_10276_10696_10746(diagnostics, args.Location, useSiteDiagnostics))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10276, 10691, 10853);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 10788, 10834);

                            constraintType.Type.CheckAllConstraints(args);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10276, 10691, 10853);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10276, 10457, 10868);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10276, 1, 412);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10276, 1, 412);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 10012, 10879);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10276_10129_10169(Microsoft.CodeAnalysis.CSharp.Symbols.SourceTypeParameterSymbolBase
                this_param)
                {
                    var return_v = this_param.ConstraintTypesNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 10129, 10169);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10276_10341_10361()
                {
                    var return_v = DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 10341, 10361);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10276_10383_10401()
                {
                    var return_v = ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 10383, 10401);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10276_10383_10412(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.CorLibrary;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 10383, 10412);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.TypeConversions
                f_10276_10363_10413(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                corLibrary)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.TypeConversions(corLibrary);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 10363, 10413);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ConstraintsHelper.CheckConstraintsArgs
                f_10276_10298_10442(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                currentCompilation, Microsoft.CodeAnalysis.CSharp.TypeConversions
                conversions, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.ConstraintsHelper.CheckConstraintsArgs(currentCompilation, (Microsoft.CodeAnalysis.CSharp.ConversionsBase)conversions, location, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 10298, 10442);
                    return return_v;
                }


                int
                f_10276_10605_10670(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    type.AddUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 10605, 10670);
                    return 0;
                }


                bool
                f_10276_10696_10746(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add(location, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 10696, 10746);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10276_10488_10503_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 10488, 10503);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 10012, 10879);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 10012, 10879);
            }
        }

        private void CheckUnmanagedConstraint(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 10891, 11222);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 10980, 11211) || true) && (f_10276_10984_11015(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10276, 10980, 11211);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 11049, 11196);

                    f_10276_11049_11195(f_10276_11049_11069(), diagnostics, f_10276_11116_11152(f_10276_11116_11143(this)), f_10276_11154_11194(this));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10276, 10980, 11211);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 10891, 11222);

                bool
                f_10276_10984_11015(Microsoft.CodeAnalysis.CSharp.Symbols.SourceTypeParameterSymbolBase
                this_param)
                {
                    var return_v = this_param.HasUnmanagedTypeConstraint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 10984, 11015);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10276_11049_11069()
                {
                    var return_v = DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 11049, 11069);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10276_11116_11143(Microsoft.CodeAnalysis.CSharp.Symbols.SourceTypeParameterSymbolBase
                symbol)
                {
                    var return_v = symbol.GetNonNullSyntaxNode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 11116, 11143);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10276_11116_11152(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 11116, 11152);
                    return return_v;
                }


                bool
                f_10276_11154_11194(Microsoft.CodeAnalysis.CSharp.Symbols.SourceTypeParameterSymbolBase
                this_param)
                {
                    var return_v = this_param.ModifyCompilationForAttributeEmbedding();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 11154, 11194);
                    return return_v;
                }


                int
                f_10276_11049_11195(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location, bool
                modifyCompilation)
                {
                    this_param.EnsureIsUnmanagedAttributeExists(diagnostics, location, modifyCompilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 11049, 11195);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 10891, 11222);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 10891, 11222);
            }
        }

        private bool ModifyCompilationForAttributeEmbedding()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 11234, 11880);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 11312, 11335);

                bool
                modifyCompilation
                = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 11351, 11828);

                switch (f_10276_11359_11380(this))
                {

                    case SourceOrdinaryMethodSymbol _:
                    case SourceMemberContainerTypeSymbol _:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10276, 11351, 11828);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 11527, 11552);

                        modifyCompilation = true;
                        DynAbs.Tracing.TraceSender.TraceBreak(10276, 11574, 11580);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10276, 11351, 11828);

                    case LocalFunctionSymbol _:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10276, 11351, 11828);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 11647, 11673);

                        modifyCompilation = false;
                        DynAbs.Tracing.TraceSender.TraceBreak(10276, 11695, 11701);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10276, 11351, 11828);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10276, 11351, 11828);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 11749, 11813);

                        throw f_10276_11755_11812(f_10276_11790_11811(this));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10276, 11351, 11828);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 11844, 11869);

                return modifyCompilation;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 11234, 11880);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10276_11359_11380(Microsoft.CodeAnalysis.CSharp.Symbols.SourceTypeParameterSymbolBase
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 11359, 11380);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10276_11790_11811(Microsoft.CodeAnalysis.CSharp.Symbols.SourceTypeParameterSymbolBase
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 11790, 11811);
                    return return_v;
                }


                System.Exception
                f_10276_11755_11812(Microsoft.CodeAnalysis.CSharp.Symbol
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 11755, 11812);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 11234, 11880);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 11234, 11880);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void EnsureAttributesFromConstraints(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 11892, 12548);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 11988, 12238) || true) && (f_10276_11992_12027().Any(t => t.ContainsNativeInteger()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10276, 11988, 12238);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 12097, 12223);

                    f_10276_12097_12222(f_10276_12097_12117(), diagnostics, f_10276_12166_12179(), f_10276_12181_12221(this));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10276, 11988, 12238);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 12252, 12460) || true) && (f_10276_12256_12290(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10276, 12252, 12460);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 12324, 12445);

                    f_10276_12324_12444(f_10276_12324_12344(), diagnostics, f_10276_12388_12401(), f_10276_12403_12443(this));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10276, 12252, 12460);
                }

                Location getLocation()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 12497, 12536);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 12500, 12536);
                        return f_10276_12500_12536(f_10276_12500_12527(this)); DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 12497, 12536);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 12497, 12536);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 12497, 12536);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 11892, 12548);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10276_11992_12027()
                {
                    var return_v = ConstraintTypesNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 11992, 12027);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10276_12097_12117()
                {
                    var return_v = DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 12097, 12117);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10276_12166_12179()
                {
                    var return_v = getLocation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 12166, 12179);
                    return return_v;
                }


                bool
                f_10276_12181_12221(Microsoft.CodeAnalysis.CSharp.Symbols.SourceTypeParameterSymbolBase
                this_param)
                {
                    var return_v = this_param.ModifyCompilationForAttributeEmbedding();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 12181, 12221);
                    return return_v;
                }


                int
                f_10276_12097_12222(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location, bool
                modifyCompilation)
                {
                    this_param.EnsureNativeIntegerAttributeExists(diagnostics, location, modifyCompilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 12097, 12222);
                    return 0;
                }


                bool
                f_10276_12256_12290(Microsoft.CodeAnalysis.CSharp.Symbols.SourceTypeParameterSymbolBase
                this_param)
                {
                    var return_v = this_param.ConstraintsNeedNullableAttribute();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 12256, 12290);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10276_12324_12344()
                {
                    var return_v = DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 12324, 12344);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10276_12388_12401()
                {
                    var return_v = getLocation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 12388, 12401);
                    return return_v;
                }


                bool
                f_10276_12403_12443(Microsoft.CodeAnalysis.CSharp.Symbols.SourceTypeParameterSymbolBase
                this_param)
                {
                    var return_v = this_param.ModifyCompilationForAttributeEmbedding();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 12403, 12443);
                    return return_v;
                }


                int
                f_10276_12324_12444(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location, bool
                modifyCompilation)
                {
                    this_param.EnsureNullableAttributeExists(diagnostics, location, modifyCompilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 12324, 12444);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10276_12500_12527(Microsoft.CodeAnalysis.CSharp.Symbols.SourceTypeParameterSymbolBase
                symbol)
                {
                    var return_v = symbol.GetNonNullSyntaxNode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 12500, 12527);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10276_12500_12536(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 12500, 12536);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 11892, 12548);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 11892, 12548);
            }
        }

        internal bool ConstraintsNeedNullableAttribute()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 12656, 13502);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 12729, 12851) || true) && (!f_10276_12734_12789(f_10276_12734_12754(), this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10276, 12729, 12851);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 12823, 12836);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10276, 12729, 12851);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 12865, 13011) || true) && (f_10276_12869_12900(this) && (DynAbs.Tracing.TraceSender.Expression_True(10276, 12869, 12950) && f_10276_12904_12942(this) != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10276, 12865, 13011);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 12984, 12996);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10276, 12865, 13011);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 13025, 13167) || true) && (this.ConstraintTypesNoUseSiteDiagnostics.Any(c => c.NeedsNullableAttribute()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10276, 13025, 13167);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 13140, 13152);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10276, 13025, 13167);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 13181, 13271) || true) && (f_10276_13185_13210(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10276, 13181, 13271);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 13244, 13256);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10276, 13181, 13271);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 13285, 13491);

                return f_10276_13292_13324_M(!this.HasReferenceTypeConstraint) && (DynAbs.Tracing.TraceSender.Expression_True(10276, 13292, 13373) && f_10276_13345_13373_M(!this.HasValueTypeConstraint)) && (DynAbs.Tracing.TraceSender.Expression_True(10276, 13292, 13442) && this.ConstraintTypesNoUseSiteDiagnostics.IsEmpty) && (DynAbs.Tracing.TraceSender.Expression_True(10276, 13292, 13490) && f_10276_13463_13481(this) == false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 12656, 13502);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10276_12734_12754()
                {
                    var return_v = DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 12734, 12754);
                    return return_v;
                }


                bool
                f_10276_12734_12789(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceTypeParameterSymbolBase
                symbol)
                {
                    var return_v = this_param.ShouldEmitNullableAttributes((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 12734, 12789);
                    return return_v;
                }


                bool
                f_10276_12869_12900(Microsoft.CodeAnalysis.CSharp.Symbols.SourceTypeParameterSymbolBase
                this_param)
                {
                    var return_v = this_param.HasReferenceTypeConstraint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 12869, 12900);
                    return return_v;
                }


                bool?
                f_10276_12904_12942(Microsoft.CodeAnalysis.CSharp.Symbols.SourceTypeParameterSymbolBase
                this_param)
                {
                    var return_v = this_param.ReferenceTypeConstraintIsNullable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 12904, 12942);
                    return return_v;
                }


                bool
                f_10276_13185_13210(Microsoft.CodeAnalysis.CSharp.Symbols.SourceTypeParameterSymbolBase
                this_param)
                {
                    var return_v = this_param.HasNotNullConstraint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 13185, 13210);
                    return return_v;
                }


                bool
                f_10276_13292_13324_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 13292, 13324);
                    return return_v;
                }


                bool
                f_10276_13345_13373_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 13345, 13373);
                    return return_v;
                }


                bool?
                f_10276_13463_13481(Microsoft.CodeAnalysis.CSharp.Symbols.SourceTypeParameterSymbolBase
                this_param)
                {
                    var return_v = this_param.IsNotNullable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 13463, 13481);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 12656, 13502);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 12656, 13502);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private NamedTypeSymbol GetDefaultBaseType()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 13514, 13667);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 13583, 13656);

                return f_10276_13590_13655(f_10276_13590_13613(this), SpecialType.System_Object);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 13514, 13667);

                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10276_13590_13613(Microsoft.CodeAnalysis.CSharp.Symbols.SourceTypeParameterSymbolBase
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 13590, 13613);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10276_13590_13655(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, Microsoft.CodeAnalysis.SpecialType
                type)
                {
                    var return_v = this_param.GetSpecialType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 13590, 13655);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 13514, 13667);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 13514, 13667);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override void ForceComplete(SourceLocation locationOpt, CancellationToken cancellationToken)
        {
            while (true)
            {
                cancellationToken.ThrowIfCancellationRequested();
                var incompletePart = _state.NextIncompletePart;
                switch (incompletePart)
                {
                    case CompletionPart.Attributes:
                        GetAttributes();
                        break;

                    case CompletionPart.TypeParameterConstraints:
                        var constraintTypes = this.ConstraintTypesNoUseSiteDiagnostics;

                        // Nested type parameter references might not be valid in error scenarios.
                        //Debug.Assert(this.ContainingSymbol.IsContainingSymbolOfAllTypeParameters(this.ConstraintTypes));
                        //Debug.Assert(this.ContainingSymbol.IsContainingSymbolOfAllTypeParameters(ImmutableArray<TypeSymbol>.CreateFrom(this.Interfaces)));
                        Debug.Assert(this.ContainingSymbol.IsContainingSymbolOfAllTypeParameters(this.EffectiveBaseClassNoUseSiteDiagnostics));
                        Debug.Assert(this.ContainingSymbol.IsContainingSymbolOfAllTypeParameters(this.DeducedBaseTypeNoUseSiteDiagnostics));
                        break;

                    case CompletionPart.None:
                        return;

                    default:
                        // any other values are completion parts intended for other kinds of symbols
                        _state.NotePartComplete(CompletionPart.All & ~CompletionPart.TypeParameterSymbolAll);
                        break;
                }

                _state.SpinWaitComplete(incompletePart, cancellationToken);
            }
        }

        internal override void AddSynthesizedAttributes(PEModuleBuilder moduleBuilder, ref ArrayBuilder<SynthesizedAttributeData> attributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 15507, 16301);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 15665, 15726);

                // LAFHIS
                //DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.AddSynthesizedAttributes(moduleBuilder, ref attributes), 10276, 15665, 15725);

                base.AddSynthesizedAttributes(moduleBuilder, ref attributes);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 15665, 15725);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 15742, 15918) || true) && (f_10276_15746_15777(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10276, 15742, 15918);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 15811, 15903);

                    f_10276_15811_15902(ref attributes, f_10276_15851_15901(moduleBuilder, this));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10276, 15742, 15918);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 15934, 15973);

                var
                compilation = f_10276_15952_15972()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 15987, 16290) || true) && (f_10276_15991_16037(compilation, this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10276, 15987, 16290);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 16071, 16275);

                    f_10276_16071_16274(ref attributes, f_10276_16154_16273(moduleBuilder, f_10276_16207_16232(this), f_10276_16234_16272(this)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10276, 15987, 16290);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 15507, 16301);

                bool
                f_10276_15746_15777(Microsoft.CodeAnalysis.CSharp.Symbols.SourceTypeParameterSymbolBase
                this_param)
                {
                    var return_v = this_param.HasUnmanagedTypeConstraint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 15746, 15777);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                f_10276_15851_15901(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceTypeParameterSymbolBase
                symbol)
                {
                    var return_v = this_param.SynthesizeIsUnmanagedAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 15851, 15901);
                    return return_v;
                }


                int
                f_10276_15811_15902(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 15811, 15902);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10276_15952_15972()
                {
                    var return_v = DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 15952, 15972);
                    return return_v;
                }


                bool
                f_10276_15991_16037(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceTypeParameterSymbolBase
                symbol)
                {
                    var return_v = this_param.ShouldEmitNullableAttributes((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 15991, 16037);
                    return return_v;
                }


                byte?
                f_10276_16207_16232(Microsoft.CodeAnalysis.CSharp.Symbols.SourceTypeParameterSymbolBase
                this_param)
                {
                    var return_v = this_param.GetNullableContextValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 16207, 16232);
                    return return_v;
                }


                byte
                f_10276_16234_16272(Microsoft.CodeAnalysis.CSharp.Symbols.SourceTypeParameterSymbolBase
                this_param)
                {
                    var return_v = this_param.GetSynthesizedNullableAttributeValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 16234, 16272);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                f_10276_16154_16273(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, byte?
                nullableContextValue, byte
                nullableValue)
                {
                    var return_v = this_param.SynthesizeNullableAttributeIfNecessary(nullableContextValue, nullableValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 16154, 16273);
                    return return_v;
                }


                int
                f_10276_16071_16274(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 16071, 16274);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 15507, 16301);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 15507, 16301);
            }
        }

        internal byte GetSynthesizedNullableAttributeValue()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 16313, 17287);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 16390, 17202) || true) && (f_10276_16394_16425(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10276, 16390, 17202);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 16459, 16784);

                    switch (f_10276_16467_16505(this))
                    {

                        case true:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10276, 16459, 16784);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 16583, 16643);

                            return NullableAnnotationExtensions.AnnotatedAttributeValue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10276, 16459, 16784);

                        case false:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10276, 16459, 16784);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 16702, 16765);

                            return NullableAnnotationExtensions.NotAnnotatedAttributeValue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10276, 16459, 16784);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10276, 16390, 17202);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10276, 16390, 17202);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 16818, 17202) || true) && (f_10276_16822_16847(this))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10276, 16818, 17202);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 16881, 16944);

                        return NullableAnnotationExtensions.NotAnnotatedAttributeValue;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10276, 16818, 17202);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10276, 16818, 17202);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 16978, 17202) || true) && (f_10276_16982_17010_M(!this.HasValueTypeConstraint) && (DynAbs.Tracing.TraceSender.Expression_True(10276, 16982, 17062) && this.ConstraintTypesNoUseSiteDiagnostics.IsEmpty) && (DynAbs.Tracing.TraceSender.Expression_True(10276, 16982, 17093) && f_10276_17066_17084(this) == false))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10276, 16978, 17202);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 17127, 17187);

                            return NullableAnnotationExtensions.AnnotatedAttributeValue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10276, 16978, 17202);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10276, 16818, 17202);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10276, 16390, 17202);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 17216, 17276);

                return NullableAnnotationExtensions.ObliviousAttributeValue;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 16313, 17287);

                bool
                f_10276_16394_16425(Microsoft.CodeAnalysis.CSharp.Symbols.SourceTypeParameterSymbolBase
                this_param)
                {
                    var return_v = this_param.HasReferenceTypeConstraint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 16394, 16425);
                    return return_v;
                }


                bool?
                f_10276_16467_16505(Microsoft.CodeAnalysis.CSharp.Symbols.SourceTypeParameterSymbolBase
                this_param)
                {
                    var return_v = this_param.ReferenceTypeConstraintIsNullable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 16467, 16505);
                    return return_v;
                }


                bool
                f_10276_16822_16847(Microsoft.CodeAnalysis.CSharp.Symbols.SourceTypeParameterSymbolBase
                this_param)
                {
                    var return_v = this_param.HasNotNullConstraint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 16822, 16847);
                    return return_v;
                }


                bool
                f_10276_16982_17010_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 16982, 17010);
                    return return_v;
                }


                bool?
                f_10276_17066_17084(Microsoft.CodeAnalysis.CSharp.Symbols.SourceTypeParameterSymbolBase
                this_param)
                {
                    var return_v = this_param.IsNotNullable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 17066, 17084);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 16313, 17287);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 16313, 17287);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override void DecodeWellKnownAttribute(ref DecodeWellKnownAttributeArguments<AttributeSyntax, CSharpAttributeData, AttributeLocation> arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 17299, 18107);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 17484, 17543);

                f_10276_17484_17542((object)arguments.AttributeSyntaxOpt != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 17559, 17595);

                var
                attribute = arguments.Attribute
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 17609, 17644);

                f_10276_17609_17643(f_10276_17622_17642_M(!attribute.HasErrors));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 17658, 17719);

                f_10276_17658_17718(arguments.SymbolPart == AttributeLocation.None);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 17735, 18035) || true) && (f_10276_17739_17812(attribute, this, AttributeDescription.NullableAttribute))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10276, 17735, 18035);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 17914, 18020);

                    f_10276_17914_18019(                // NullableAttribute should not be set explicitly.
                                    arguments.Diagnostics, ErrorCode.ERR_ExplicitNullableAttribute, f_10276_17981_18018(arguments.AttributeSyntaxOpt));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10276, 17735, 18035);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 18051, 18096);

                // LAFHIS
                //DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.DecodeWellKnownAttribute(ref arguments), 10276, 18051, 18095);
                base.DecodeWellKnownAttribute(ref arguments);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 18051, 18095);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 17299, 18107);

                int
                f_10276_17484_17542(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 17484, 17542);
                    return 0;
                }


                bool
                f_10276_17622_17642_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 17622, 17642);
                    return return_v;
                }


                int
                f_10276_17609_17643(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 17609, 17643);
                    return 0;
                }


                int
                f_10276_17658_17718(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 17658, 17718);
                    return 0;
                }


                bool
                f_10276_17739_17812(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceTypeParameterSymbolBase
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 17739, 17812);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10276_17981_18018(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 17981, 18018);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10276_17914_18019(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 17914, 18019);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 17299, 18107);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 17299, 18107);
            }
        }

        protected bool? CalculateReferenceTypeConstraintIsNullable(TypeParameterConstraintKind constraints)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 18119, 18746);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 18243, 18371) || true) && ((constraints & TypeParameterConstraintKind.ReferenceType) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10276, 18243, 18371);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 18343, 18356);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10276, 18243, 18371);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 18387, 18707);

                switch (constraints & TypeParameterConstraintKind.AllReferenceTypeKinds)
                {

                    case TypeParameterConstraintKind.NullableReferenceType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10276, 18387, 18707);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 18569, 18581);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10276, 18387, 18707);

                    case TypeParameterConstraintKind.NotNullableReferenceType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10276, 18387, 18707);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 18679, 18692);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10276, 18387, 18707);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 18723, 18735);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 18119, 18746);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 18119, 18746);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 18119, 18746);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SourceTypeParameterSymbolBase()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10276, 685, 18753);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10276, 685, 18753);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 685, 18753);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10276, 685, 18753);

        bool
        f_10276_1413_1432_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 1413, 1432);
            return return_v;
        }


        int
        f_10276_1400_1433(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 1400, 1433);
            return 0;
        }

    }
    internal sealed class SourceTypeParameterSymbol : SourceTypeParameterSymbolBase
    {
        private readonly SourceNamedTypeSymbol _owner;

        private readonly VarianceKind _varianceKind;

        public SourceTypeParameterSymbol(SourceNamedTypeSymbol owner, string name, int ordinal, VarianceKind varianceKind, ImmutableArray<Location> locations, ImmutableArray<SyntaxReference> syntaxRefs)
        : base(f_10276_19184_19188_C(name), ordinal, locations, syntaxRefs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10276, 18969, 19315);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 18896, 18902);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 18943, 18956);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 19246, 19261);

                _owner = owner;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 19275, 19304);

                _varianceKind = varianceKind;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10276, 18969, 19315);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 18969, 19315);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 18969, 19315);
            }
        }

        public override TypeParameterKind TypeParameterKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 19403, 19484);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 19439, 19469);

                    return TypeParameterKind.Type;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 19403, 19484);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 19327, 19495);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 19327, 19495);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Symbol ContainingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 19571, 19593);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 19577, 19591);

                    return _owner;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 19571, 19593);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 19507, 19604);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 19507, 19604);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override VarianceKind Variance
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 19678, 19707);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 19684, 19705);

                    return _varianceKind;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 19678, 19707);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 19616, 19718);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 19616, 19718);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool HasConstructorConstraint
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 19800, 19981);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 19836, 19880);

                    var
                    constraints = f_10276_19854_19879(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 19898, 19966);

                    return (constraints & TypeParameterConstraintKind.Constructor) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 19800, 19981);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintKind
                    f_10276_19854_19879(Microsoft.CodeAnalysis.CSharp.Symbols.SourceTypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.GetConstraintKinds();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 19854, 19879);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 19730, 19992);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 19730, 19992);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool HasValueTypeConstraint
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 20072, 20259);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 20108, 20152);

                    var
                    constraints = f_10276_20126_20151(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 20170, 20244);

                    return (constraints & TypeParameterConstraintKind.AllValueTypeKinds) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 20072, 20259);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintKind
                    f_10276_20126_20151(Microsoft.CodeAnalysis.CSharp.Symbols.SourceTypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.GetConstraintKinds();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 20126, 20151);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 20004, 20270);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 20004, 20270);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsValueTypeFromConstraintTypes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 20358, 20612);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 20394, 20432);

                    f_10276_20394_20431(f_10276_20407_20430_M(!HasValueTypeConstraint));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 20450, 20494);

                    var
                    constraints = f_10276_20468_20493(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 20512, 20597);

                    return (constraints & TypeParameterConstraintKind.ValueTypeFromConstraintTypes) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 20358, 20612);

                    bool
                    f_10276_20407_20430_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 20407, 20430);
                        return return_v;
                    }


                    int
                    f_10276_20394_20431(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 20394, 20431);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintKind
                    f_10276_20468_20493(Microsoft.CodeAnalysis.CSharp.Symbols.SourceTypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.GetConstraintKinds();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 20468, 20493);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 20282, 20623);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 20282, 20623);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool HasReferenceTypeConstraint
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 20707, 20890);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 20743, 20787);

                    var
                    constraints = f_10276_20761_20786(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 20805, 20875);

                    return (constraints & TypeParameterConstraintKind.ReferenceType) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 20707, 20890);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintKind
                    f_10276_20761_20786(Microsoft.CodeAnalysis.CSharp.Symbols.SourceTypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.GetConstraintKinds();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 20761, 20786);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 20635, 20901);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 20635, 20901);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsReferenceTypeFromConstraintTypes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 20993, 21195);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 21029, 21073);

                    var
                    constraints = f_10276_21047_21072(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 21091, 21180);

                    return (constraints & TypeParameterConstraintKind.ReferenceTypeFromConstraintTypes) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 20993, 21195);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintKind
                    f_10276_21047_21072(Microsoft.CodeAnalysis.CSharp.Symbols.SourceTypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.GetConstraintKinds();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 21047, 21072);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 20913, 21206);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 20913, 21206);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool? ReferenceTypeConstraintIsNullable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 21300, 21428);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 21336, 21413);

                    return f_10276_21343_21412(this, f_10276_21386_21411(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 21300, 21428);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintKind
                    f_10276_21386_21411(Microsoft.CodeAnalysis.CSharp.Symbols.SourceTypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.GetConstraintKinds();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 21386, 21411);
                        return return_v;
                    }


                    bool?
                    f_10276_21343_21412(Microsoft.CodeAnalysis.CSharp.Symbols.SourceTypeParameterSymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintKind
                    constraints)
                    {
                        var return_v = this_param.CalculateReferenceTypeConstraintIsNullable(constraints);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 21343, 21412);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 21218, 21439);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 21218, 21439);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool HasNotNullConstraint
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 21517, 21694);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 21553, 21597);

                    var
                    constraints = f_10276_21571_21596(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 21615, 21679);

                    return (constraints & TypeParameterConstraintKind.NotNull) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 21517, 21694);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintKind
                    f_10276_21571_21596(Microsoft.CodeAnalysis.CSharp.Symbols.SourceTypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.GetConstraintKinds();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 21571, 21596);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 21451, 21705);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 21451, 21705);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool? IsNotNullable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 21779, 22057);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 21815, 21990) || true) && ((f_10276_21820_21845(this) & TypeParameterConstraintKind.ObliviousNullabilityIfReferenceType) != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10276, 21815, 21990);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 21959, 21971);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10276, 21815, 21990);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 22010, 22042);

                    return f_10276_22017_22041(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 21779, 22057);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintKind
                    f_10276_21820_21845(Microsoft.CodeAnalysis.CSharp.Symbols.SourceTypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.GetConstraintKinds();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 21820, 21845);
                        return return_v;
                    }


                    bool?
                    f_10276_22017_22041(Microsoft.CodeAnalysis.CSharp.Symbols.SourceTypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.CalculateIsNotNullable();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 22017, 22041);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 21717, 22068);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 21717, 22068);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool HasUnmanagedTypeConstraint
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 22152, 22331);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 22188, 22232);

                    var
                    constraints = f_10276_22206_22231(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 22250, 22316);

                    return (constraints & TypeParameterConstraintKind.Unmanaged) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 22152, 22331);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintKind
                    f_10276_22206_22231(Microsoft.CodeAnalysis.CSharp.Symbols.SourceTypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.GetConstraintKinds();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 22206, 22231);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 22080, 22342);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 22080, 22342);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override ImmutableArray<TypeParameterSymbol> ContainerTypeParameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 22457, 22494);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 22463, 22492);

                    return f_10276_22470_22491(_owner);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 22457, 22494);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    f_10276_22470_22491(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeParameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 22470, 22491);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 22354, 22505);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 22354, 22505);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override TypeParameterBounds ResolveBounds(ConsList<TypeParameterSymbol> inProgress, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 22517, 23090);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 22663, 22738);

                var
                constraintTypes = f_10276_22685_22737(_owner, f_10276_22724_22736(this))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 22752, 22900) || true) && (constraintTypes.IsEmpty && (DynAbs.Tracing.TraceSender.Expression_True(10276, 22756, 22839) && f_10276_22783_22803(this) == TypeParameterConstraintKind.None))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10276, 22752, 22900);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 22873, 22885);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10276, 22752, 22900);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 22916, 23079);

                return f_10276_22923_23078(this, f_10276_22942_22976(f_10276_22942_22965(this)), f_10276_22978_23002(inProgress, this), constraintTypes, inherited: false, f_10276_23039_23064(this), diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 22517, 23090);

                int
                f_10276_22724_22736(Microsoft.CodeAnalysis.CSharp.Symbols.SourceTypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.Ordinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 22724, 22736);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10276_22685_22737(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param, int
                ordinal)
                {
                    var return_v = this_param.GetTypeParameterConstraintTypes(ordinal);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 22685, 22737);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintKind
                f_10276_22783_22803(Microsoft.CodeAnalysis.CSharp.Symbols.SourceTypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.GetConstraintKinds();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 22783, 22803);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10276_22942_22965(Microsoft.CodeAnalysis.CSharp.Symbols.SourceTypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 22942, 22965);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10276_22942_22976(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.CorLibrary;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 22942, 22976);
                    return return_v;
                }


                Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10276_22978_23002(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                list, Microsoft.CodeAnalysis.CSharp.Symbols.SourceTypeParameterSymbol
                head)
                {
                    var return_v = list.Prepend<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>((Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol)head);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 22978, 23002);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10276_23039_23064(Microsoft.CodeAnalysis.CSharp.Symbols.SourceTypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 23039, 23064);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterBounds
                f_10276_22923_23078(Microsoft.CodeAnalysis.CSharp.Symbols.SourceTypeParameterSymbol
                typeParameter, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                corLibrary, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                inProgress, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                constraintTypes, bool
                inherited, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                currentCompilation, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = typeParameter.ResolveBounds(corLibrary, inProgress, constraintTypes, inherited: inherited, currentCompilation, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 22923, 23078);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 22517, 23090);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 22517, 23090);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private TypeParameterConstraintKind GetConstraintKinds()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 23102, 23253);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 23183, 23242);

                return f_10276_23190_23241(_owner, f_10276_23228_23240(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 23102, 23253);

                int
                f_10276_23228_23240(Microsoft.CodeAnalysis.CSharp.Symbols.SourceTypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.Ordinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 23228, 23240);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintKind
                f_10276_23190_23241(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param, int
                ordinal)
                {
                    var return_v = this_param.GetTypeParameterConstraintKind(ordinal);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 23190, 23241);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 23102, 23253);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 23102, 23253);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SourceTypeParameterSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10276, 18761, 23260);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10276, 18761, 23260);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 18761, 23260);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10276, 18761, 23260);

        static string
        f_10276_19184_19188_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10276, 18969, 19315);
            return return_v;
        }

    }
    internal sealed class SourceMethodTypeParameterSymbol : SourceTypeParameterSymbolBase
    {
        private readonly SourceMethodSymbol _owner;

        public SourceMethodTypeParameterSymbol(SourceMethodSymbol owner, string name, int ordinal, ImmutableArray<Location> locations, ImmutableArray<SyntaxReference> syntaxRefs)
        : base(f_10276_23616_23620_C(name), ordinal, locations, syntaxRefs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10276, 23425, 23704);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 23406, 23412);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 23678, 23693);

                _owner = owner;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10276, 23425, 23704);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 23425, 23704);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 23425, 23704);
            }
        }

        internal override void AddDeclarationDiagnostics(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 23805, 23853);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 23808, 23853);
                f_10276_23808_23853(_owner, diagnostics); DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 23805, 23853);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 23805, 23853);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 23805, 23853);
            }

            int
            f_10276_23808_23853(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbol
            this_param, Microsoft.CodeAnalysis.DiagnosticBag
            diagnostics)
            {
                this_param.AddDeclarationDiagnostics(diagnostics);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 23808, 23853);
                return 0;
            }

        }

        public override TypeParameterKind TypeParameterKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 23942, 24025);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 23978, 24010);

                    return TypeParameterKind.Method;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 23942, 24025);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 23866, 24036);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 23866, 24036);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Symbol ContainingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 24112, 24134);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 24118, 24132);

                    return _owner;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 24112, 24134);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 24048, 24145);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 24048, 24145);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool HasConstructorConstraint
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 24227, 24408);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 24263, 24307);

                    var
                    constraints = f_10276_24281_24306(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 24325, 24393);

                    return (constraints & TypeParameterConstraintKind.Constructor) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 24227, 24408);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintKind
                    f_10276_24281_24306(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodTypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.GetConstraintKinds();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 24281, 24306);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 24157, 24419);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 24157, 24419);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool HasValueTypeConstraint
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 24499, 24686);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 24535, 24579);

                    var
                    constraints = f_10276_24553_24578(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 24597, 24671);

                    return (constraints & TypeParameterConstraintKind.AllValueTypeKinds) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 24499, 24686);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintKind
                    f_10276_24553_24578(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodTypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.GetConstraintKinds();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 24553, 24578);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 24431, 24697);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 24431, 24697);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsValueTypeFromConstraintTypes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 24785, 25039);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 24821, 24859);

                    f_10276_24821_24858(f_10276_24834_24857_M(!HasValueTypeConstraint));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 24877, 24921);

                    var
                    constraints = f_10276_24895_24920(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 24939, 25024);

                    return (constraints & TypeParameterConstraintKind.ValueTypeFromConstraintTypes) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 24785, 25039);

                    bool
                    f_10276_24834_24857_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 24834, 24857);
                        return return_v;
                    }


                    int
                    f_10276_24821_24858(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 24821, 24858);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintKind
                    f_10276_24895_24920(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodTypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.GetConstraintKinds();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 24895, 24920);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 24709, 25050);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 24709, 25050);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool HasReferenceTypeConstraint
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 25134, 25317);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 25170, 25214);

                    var
                    constraints = f_10276_25188_25213(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 25232, 25302);

                    return (constraints & TypeParameterConstraintKind.ReferenceType) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 25134, 25317);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintKind
                    f_10276_25188_25213(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodTypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.GetConstraintKinds();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 25188, 25213);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 25062, 25328);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 25062, 25328);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsReferenceTypeFromConstraintTypes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 25420, 25622);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 25456, 25500);

                    var
                    constraints = f_10276_25474_25499(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 25518, 25607);

                    return (constraints & TypeParameterConstraintKind.ReferenceTypeFromConstraintTypes) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 25420, 25622);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintKind
                    f_10276_25474_25499(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodTypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.GetConstraintKinds();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 25474, 25499);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 25340, 25633);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 25340, 25633);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool HasNotNullConstraint
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 25711, 25888);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 25747, 25791);

                    var
                    constraints = f_10276_25765_25790(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 25809, 25873);

                    return (constraints & TypeParameterConstraintKind.NotNull) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 25711, 25888);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintKind
                    f_10276_25765_25790(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodTypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.GetConstraintKinds();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 25765, 25790);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 25645, 25899);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 25645, 25899);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool? ReferenceTypeConstraintIsNullable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 25993, 26121);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 26029, 26106);

                    return f_10276_26036_26105(this, f_10276_26079_26104(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 25993, 26121);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintKind
                    f_10276_26079_26104(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodTypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.GetConstraintKinds();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 26079, 26104);
                        return return_v;
                    }


                    bool?
                    f_10276_26036_26105(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodTypeParameterSymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintKind
                    constraints)
                    {
                        var return_v = this_param.CalculateReferenceTypeConstraintIsNullable(constraints);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 26036, 26105);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 25911, 26132);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 25911, 26132);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool? IsNotNullable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 26206, 26484);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 26242, 26417) || true) && ((f_10276_26247_26272(this) & TypeParameterConstraintKind.ObliviousNullabilityIfReferenceType) != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10276, 26242, 26417);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 26386, 26398);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10276, 26242, 26417);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 26437, 26469);

                    return f_10276_26444_26468(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 26206, 26484);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintKind
                    f_10276_26247_26272(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodTypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.GetConstraintKinds();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 26247, 26272);
                        return return_v;
                    }


                    bool?
                    f_10276_26444_26468(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodTypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.CalculateIsNotNullable();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 26444, 26468);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 26144, 26495);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 26144, 26495);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool HasUnmanagedTypeConstraint
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 26579, 26758);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 26615, 26659);

                    var
                    constraints = f_10276_26633_26658(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 26677, 26743);

                    return (constraints & TypeParameterConstraintKind.Unmanaged) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 26579, 26758);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintKind
                    f_10276_26633_26658(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodTypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.GetConstraintKinds();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 26633, 26658);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 26507, 26769);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 26507, 26769);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override ImmutableArray<TypeParameterSymbol> ContainerTypeParameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 26884, 26921);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 26890, 26919);

                    return f_10276_26897_26918(_owner);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 26884, 26921);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    f_10276_26897_26918(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeParameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 26897, 26918);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 26781, 26932);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 26781, 26932);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override TypeParameterBounds ResolveBounds(ConsList<TypeParameterSymbol> inProgress, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 26944, 27626);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 27090, 27149);

                var
                constraints = f_10276_27108_27148(_owner)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 27163, 27272);

                var
                constraintTypes = (DynAbs.Tracing.TraceSender.Conditional_F1(10276, 27185, 27204) || ((constraints.IsEmpty && DynAbs.Tracing.TraceSender.Conditional_F2(10276, 27207, 27248)) || DynAbs.Tracing.TraceSender.Conditional_F3(10276, 27251, 27271))) ? ImmutableArray<TypeWithAnnotations>.Empty : constraints[f_10276_27263_27270()]
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 27288, 27436) || true) && (constraintTypes.IsEmpty && (DynAbs.Tracing.TraceSender.Expression_True(10276, 27292, 27375) && f_10276_27319_27339(this) == TypeParameterConstraintKind.None))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10276, 27288, 27436);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 27409, 27421);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10276, 27288, 27436);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 27452, 27615);

                return f_10276_27459_27614(this, f_10276_27478_27512(f_10276_27478_27501(this)), f_10276_27514_27538(inProgress, this), constraintTypes, inherited: false, f_10276_27575_27600(this), diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 26944, 27626);

                System.Collections.Immutable.ImmutableArray<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>>
                f_10276_27108_27148(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbol
                this_param)
                {
                    var return_v = this_param.GetTypeParameterConstraintTypes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 27108, 27148);
                    return return_v;
                }


                int
                f_10276_27263_27270()
                {
                    var return_v = Ordinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 27263, 27270);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintKind
                f_10276_27319_27339(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodTypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.GetConstraintKinds();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 27319, 27339);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10276_27478_27501(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodTypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 27478, 27501);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10276_27478_27512(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.CorLibrary;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 27478, 27512);
                    return return_v;
                }


                Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10276_27514_27538(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                list, Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodTypeParameterSymbol
                head)
                {
                    var return_v = list.Prepend<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>((Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol)head);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 27514, 27538);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10276_27575_27600(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodTypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 27575, 27600);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterBounds
                f_10276_27459_27614(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodTypeParameterSymbol
                typeParameter, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                corLibrary, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                inProgress, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                constraintTypes, bool
                inherited, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                currentCompilation, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = typeParameter.ResolveBounds(corLibrary, inProgress, constraintTypes, inherited: inherited, currentCompilation, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 27459, 27614);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 26944, 27626);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 26944, 27626);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private TypeParameterConstraintKind GetConstraintKinds()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 27638, 27900);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 27719, 27782);

                var
                constraintKinds = f_10276_27741_27781(_owner)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 27796, 27889);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10276, 27803, 27826) || ((constraintKinds.IsEmpty && DynAbs.Tracing.TraceSender.Conditional_F2(10276, 27829, 27861)) || DynAbs.Tracing.TraceSender.Conditional_F3(10276, 27864, 27888))) ? TypeParameterConstraintKind.None : constraintKinds[f_10276_27880_27887()];
                DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 27638, 27900);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintKind>
                f_10276_27741_27781(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbol
                this_param)
                {
                    var return_v = this_param.GetTypeParameterConstraintKinds();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 27741, 27781);
                    return return_v;
                }


                int
                f_10276_27880_27887()
                {
                    var return_v = Ordinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 27880, 27887);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 27638, 27900);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 27638, 27900);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SourceMethodTypeParameterSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10276, 23268, 27907);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10276, 23268, 27907);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 23268, 27907);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10276, 23268, 27907);

        static string
        f_10276_23616_23620_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10276, 23425, 23704);
            return return_v;
        }

    }
    internal abstract class OverriddenMethodTypeParameterMapBase
    {
        private readonly SourceOrdinaryMethodSymbol _overridingMethod;

        private TypeMap _lazyTypeMap;

        private MethodSymbol _lazyOverriddenMethod;

        protected OverriddenMethodTypeParameterMapBase(SourceOrdinaryMethodSymbol overridingMethod)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10276, 28732, 28896);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 28402, 28419);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 28533, 28545);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 28664, 28719);
                this._lazyOverriddenMethod = ErrorMethodSymbol.UnknownMethod; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 28848, 28885);

                _overridingMethod = overridingMethod;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10276, 28732, 28896);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 28732, 28896);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 28732, 28896);
            }
        }

        public SourceOrdinaryMethodSymbol OverridingMethod
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 28983, 29016);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 28989, 29014);

                    return _overridingMethod;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 28983, 29016);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 28908, 29027);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 28908, 29027);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public TypeParameterSymbol GetOverriddenTypeParameter(int ordinal)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 29039, 29292);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 29130, 29175);

                var
                overriddenMethod = f_10276_29153_29174(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 29189, 29281);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10276, 29196, 29230) || ((((object)overriddenMethod != null) && DynAbs.Tracing.TraceSender.Conditional_F2(10276, 29233, 29273)) || DynAbs.Tracing.TraceSender.Conditional_F3(10276, 29276, 29280))) ? f_10276_29233_29264(overriddenMethod)[ordinal] : null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 29039, 29292);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10276_29153_29174(Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenMethodTypeParameterMapBase
                this_param)
                {
                    var return_v = this_param.OverriddenMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 29153, 29174);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10276_29233_29264(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 29233, 29264);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 29039, 29292);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 29039, 29292);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public TypeMap TypeMap
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 29351, 30176);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 29387, 30121) || true) && (_lazyTypeMap == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10276, 29387, 30121);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 29453, 29498);

                        var
                        overriddenMethod = f_10276_29476_29497(this)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 29520, 30102) || true) && ((object)overriddenMethod != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10276, 29520, 30102);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 29606, 29669);

                            var
                            overriddenTypeParameters = f_10276_29637_29668(overriddenMethod)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 29695, 29759);

                            var
                            overridingTypeParameters = f_10276_29726_29758(_overridingMethod)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 29787, 29868);

                            f_10276_29787_29867(overriddenTypeParameters.Length == overridingTypeParameters.Length);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 29896, 29992);

                            var
                            typeMap = f_10276_29910_29991(overriddenTypeParameters, overridingTypeParameters, allowAlpha: true)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 30018, 30079);

                            f_10276_30018_30078(ref _lazyTypeMap, typeMap, null);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10276, 29520, 30102);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10276, 29387, 30121);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 30141, 30161);

                    return _lazyTypeMap;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 29351, 30176);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10276_29476_29497(Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenMethodTypeParameterMapBase
                    this_param)
                    {
                        var return_v = this_param.OverriddenMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 29476, 29497);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    f_10276_29637_29668(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeParameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 29637, 29668);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    f_10276_29726_29758(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeParameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 29726, 29758);
                        return return_v;
                    }


                    int
                    f_10276_29787_29867(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 29787, 29867);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                    f_10276_29910_29991(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    from, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    to, bool
                    allowAlpha)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap(from, to, allowAlpha: allowAlpha);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 29910, 29991);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap?
                    f_10276_30018_30078(ref Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap?
                    location1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                    value, Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap?
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 30018, 30078);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 29304, 30187);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 29304, 30187);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private MethodSymbol OverriddenMethod
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 30261, 30628);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 30297, 30566) || true) && (f_10276_30301_30372(_lazyOverriddenMethod, ErrorMethodSymbol.UnknownMethod))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10276, 30297, 30566);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 30414, 30547);

                        f_10276_30414_30546(ref _lazyOverriddenMethod, f_10276_30469_30512(this, _overridingMethod), ErrorMethodSymbol.UnknownMethod);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10276, 30297, 30566);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 30584, 30613);

                    return _lazyOverriddenMethod;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 30261, 30628);

                    bool
                    f_10276_30301_30372(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    objA, Microsoft.CodeAnalysis.CSharp.Symbols.ErrorMethodSymbol
                    objB)
                    {
                        var return_v = ReferenceEquals((object)objA, (object)objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 30301, 30372);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10276_30469_30512(Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenMethodTypeParameterMapBase
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                    overridingMethod)
                    {
                        var return_v = this_param.GetOverriddenMethod(overridingMethod);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 30469, 30512);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10276_30414_30546(ref Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    location1, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    value, Microsoft.CodeAnalysis.CSharp.Symbols.ErrorMethodSymbol
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, (Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 30414, 30546);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 30199, 30639);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 30199, 30639);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected abstract MethodSymbol GetOverriddenMethod(SourceOrdinaryMethodSymbol overridingMethod);

        static OverriddenMethodTypeParameterMapBase()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10276, 28210, 30755);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10276, 28210, 30755);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 28210, 30755);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10276, 28210, 30755);
    }
    internal sealed class OverriddenMethodTypeParameterMap : OverriddenMethodTypeParameterMapBase
    {
        public OverriddenMethodTypeParameterMap(SourceOrdinaryMethodSymbol overridingMethod)
        : base(f_10276_30978_30994_C(overridingMethod))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10276, 30873, 31073);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 31020, 31062);

                f_10276_31020_31061(f_10276_31033_31060(overridingMethod));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10276, 30873, 31073);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 30873, 31073);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 30873, 31073);
            }
        }

        protected override MethodSymbol GetOverriddenMethod(SourceOrdinaryMethodSymbol overridingMethod)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 31085, 31548);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 31206, 31245);

                MethodSymbol
                method = overridingMethod
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 31259, 31291);

                f_10276_31259_31290(f_10276_31272_31289(method));
                {
                    try
                    {
                        do

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10276, 31305, 31443);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 31340, 31373);

                            method = f_10276_31349_31372(method);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10276, 31305, 31443);
                        }
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 31305, 31443) || true) && (((object)method != null) && (DynAbs.Tracing.TraceSender.Expression_True(10276, 31396, 31441) && f_10276_31424_31441(method)))
                        );
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10276, 31305, 31443);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10276, 31305, 31443);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 31523, 31537);

                return method;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 31085, 31548);

                bool
                f_10276_31272_31289(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsOverride;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 31272, 31289);
                    return return_v;
                }


                int
                f_10276_31259_31290(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 31259, 31290);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10276_31349_31372(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.OverriddenMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 31349, 31372);
                    return return_v;
                }


                bool
                f_10276_31424_31441(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsOverride;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 31424, 31441);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 31085, 31548);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 31085, 31548);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static OverriddenMethodTypeParameterMap()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10276, 30763, 31555);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10276, 30763, 31555);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 30763, 31555);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10276, 30763, 31555);

        bool
        f_10276_31033_31060(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
        this_param)
        {
            var return_v = this_param.IsOverride;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 31033, 31060);
            return return_v;
        }


        int
        f_10276_31020_31061(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 31020, 31061);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
        f_10276_30978_30994_C(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10276, 30873, 31073);
            return return_v;
        }

    }
    internal sealed class ExplicitInterfaceMethodTypeParameterMap : OverriddenMethodTypeParameterMapBase
    {
        public ExplicitInterfaceMethodTypeParameterMap(SourceOrdinaryMethodSymbol implementationMethod)
        : base(f_10276_31796_31816_C(implementationMethod))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10276, 31680, 31922);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 31842, 31911);

                f_10276_31842_31910(f_10276_31855_31909(implementationMethod));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10276, 31680, 31922);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 31680, 31922);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 31680, 31922);
            }
        }

        protected override MethodSymbol GetOverriddenMethod(SourceOrdinaryMethodSymbol overridingMethod)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 31934, 32389);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 32055, 32135);

                var
                explicitImplementations = f_10276_32085_32134(overridingMethod)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 32149, 32199);

                f_10276_32149_32198(explicitImplementations.Length <= 1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 32298, 32378);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10276, 32305, 32341) || (((explicitImplementations.Length > 0) && DynAbs.Tracing.TraceSender.Conditional_F2(10276, 32344, 32370)) || DynAbs.Tracing.TraceSender.Conditional_F3(10276, 32373, 32377))) ? explicitImplementations[0] : null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 31934, 32389);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10276_32085_32134(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.ExplicitInterfaceImplementations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 32085, 32134);
                    return return_v;
                }


                int
                f_10276_32149_32198(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 32149, 32198);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 31934, 32389);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 31934, 32389);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ExplicitInterfaceMethodTypeParameterMap()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10276, 31563, 32396);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10276, 31563, 32396);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 31563, 32396);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10276, 31563, 32396);

        bool
        f_10276_31855_31909(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
        this_param)
        {
            var return_v = this_param.IsExplicitInterfaceImplementation;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 31855, 31909);
            return return_v;
        }


        int
        f_10276_31842_31910(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 31842, 31910);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
        f_10276_31796_31816_C(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10276, 31680, 31922);
            return return_v;
        }

    }
    internal sealed class SourceOverridingMethodTypeParameterSymbol : SourceTypeParameterSymbolBase
    {
        private readonly OverriddenMethodTypeParameterMapBase _map;

        public SourceOverridingMethodTypeParameterSymbol(OverriddenMethodTypeParameterMapBase map, string name, int ordinal, ImmutableArray<Location> locations, ImmutableArray<SyntaxReference> syntaxRefs)
        : base(f_10276_33116_33120_C(name), ordinal, locations, syntaxRefs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10276, 32899, 33200);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 32882, 32886);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 33178, 33189);

                _map = map;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10276, 32899, 33200);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 32899, 33200);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 32899, 33200);
            }
        }

        public SourceOrdinaryMethodSymbol Owner
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 33276, 33313);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 33282, 33311);

                    return f_10276_33289_33310(_map);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 33276, 33313);

                    Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                    f_10276_33289_33310(Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenMethodTypeParameterMapBase
                    this_param)
                    {
                        var return_v = this_param.OverridingMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 33289, 33310);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 33212, 33324);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 33212, 33324);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override TypeParameterKind TypeParameterKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 33412, 33495);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 33448, 33480);

                    return TypeParameterKind.Method;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 33412, 33495);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 33336, 33506);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 33336, 33506);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Symbol ContainingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 33582, 33608);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 33588, 33606);

                    return f_10276_33595_33605(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 33582, 33608);

                    Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                    f_10276_33595_33605(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOverridingMethodTypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.Owner;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 33595, 33605);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 33518, 33619);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 33518, 33619);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool HasConstructorConstraint
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 33701, 33900);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 33737, 33786);

                    var
                    typeParameter = f_10276_33757_33785(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 33804, 33885);

                    return ((object)typeParameter != null) && (DynAbs.Tracing.TraceSender.Expression_True(10276, 33811, 33884) && f_10276_33846_33884(typeParameter));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 33701, 33900);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    f_10276_33757_33785(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOverridingMethodTypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.OverriddenTypeParameter;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 33757, 33785);
                        return return_v;
                    }


                    bool
                    f_10276_33846_33884(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.HasConstructorConstraint;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 33846, 33884);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 33631, 33911);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 33631, 33911);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool HasValueTypeConstraint
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 33991, 34188);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 34027, 34076);

                    var
                    typeParameter = f_10276_34047_34075(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 34094, 34173);

                    return ((object)typeParameter != null) && (DynAbs.Tracing.TraceSender.Expression_True(10276, 34101, 34172) && f_10276_34136_34172(typeParameter));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 33991, 34188);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    f_10276_34047_34075(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOverridingMethodTypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.OverriddenTypeParameter;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 34047, 34075);
                        return return_v;
                    }


                    bool
                    f_10276_34136_34172(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.HasValueTypeConstraint;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 34136, 34172);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 33923, 34199);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 33923, 34199);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsValueTypeFromConstraintTypes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 34287, 34574);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 34323, 34372);

                    var
                    typeParameter = f_10276_34343_34371(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 34390, 34559);

                    return ((object)typeParameter != null) && (DynAbs.Tracing.TraceSender.Expression_True(10276, 34397, 34558) && (f_10276_34433_34477(typeParameter) || (DynAbs.Tracing.TraceSender.Expression_False(10276, 34433, 34557) || f_10276_34481_34557(f_10276_34521_34556()))));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 34287, 34574);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    f_10276_34343_34371(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOverridingMethodTypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.OverriddenTypeParameter;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 34343, 34371);
                        return return_v;
                    }


                    bool
                    f_10276_34433_34477(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.IsValueTypeFromConstraintTypes;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 34433, 34477);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    f_10276_34521_34556()
                    {
                        var return_v = ConstraintTypesNoUseSiteDiagnostics;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 34521, 34556);
                        return return_v;
                    }


                    bool
                    f_10276_34481_34557(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    constraintTypes)
                    {
                        var return_v = CalculateIsValueTypeFromConstraintTypes(constraintTypes);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 34481, 34557);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 34211, 34585);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 34211, 34585);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool HasReferenceTypeConstraint
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 34669, 34870);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 34705, 34754);

                    var
                    typeParameter = f_10276_34725_34753(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 34772, 34855);

                    return ((object)typeParameter != null) && (DynAbs.Tracing.TraceSender.Expression_True(10276, 34779, 34854) && f_10276_34814_34854(typeParameter));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 34669, 34870);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    f_10276_34725_34753(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOverridingMethodTypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.OverriddenTypeParameter;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 34725, 34753);
                        return return_v;
                    }


                    bool
                    f_10276_34814_34854(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.HasReferenceTypeConstraint;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 34814, 34854);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 34597, 34881);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 34597, 34881);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsReferenceTypeFromConstraintTypes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 34973, 35268);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 35009, 35058);

                    var
                    typeParameter = f_10276_35029_35057(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 35076, 35253);

                    return ((object)typeParameter != null) && (DynAbs.Tracing.TraceSender.Expression_True(10276, 35083, 35252) && (f_10276_35119_35167(typeParameter) || (DynAbs.Tracing.TraceSender.Expression_False(10276, 35119, 35251) || f_10276_35171_35251(f_10276_35215_35250()))));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 34973, 35268);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    f_10276_35029_35057(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOverridingMethodTypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.OverriddenTypeParameter;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 35029, 35057);
                        return return_v;
                    }


                    bool
                    f_10276_35119_35167(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.IsReferenceTypeFromConstraintTypes;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 35119, 35167);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    f_10276_35215_35250()
                    {
                        var return_v = ConstraintTypesNoUseSiteDiagnostics;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 35215, 35250);
                        return return_v;
                    }


                    bool
                    f_10276_35171_35251(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    constraintTypes)
                    {
                        var return_v = CalculateIsReferenceTypeFromConstraintTypes(constraintTypes);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 35171, 35251);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 34893, 35279);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 34893, 35279);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool? ReferenceTypeConstraintIsNullable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 35373, 35604);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 35409, 35474);

                    TypeParameterSymbol
                    typeParameter = f_10276_35445_35473(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 35492, 35589);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10276, 35499, 35530) || ((((object)typeParameter != null) && DynAbs.Tracing.TraceSender.Conditional_F2(10276, 35533, 35580)) || DynAbs.Tracing.TraceSender.Conditional_F3(10276, 35583, 35588))) ? f_10276_35533_35580(typeParameter) : false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 35373, 35604);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    f_10276_35445_35473(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOverridingMethodTypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.OverriddenTypeParameter;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 35445, 35473);
                        return return_v;
                    }


                    bool?
                    f_10276_35533_35580(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.ReferenceTypeConstraintIsNullable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 35533, 35580);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 35291, 35615);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 35291, 35615);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool HasNotNullConstraint
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 35693, 35810);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 35729, 35795);

                    return f_10276_35736_35786_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10276_35736_35764(this), 10276, 35736, 35786)?.HasNotNullConstraint) == true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 35693, 35810);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    f_10276_35736_35764(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOverridingMethodTypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.OverriddenTypeParameter;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 35736, 35764);
                        return return_v;
                    }


                    bool?
                    f_10276_35736_35786_M(bool?
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 35736, 35786);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 35627, 35821);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 35627, 35821);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool? IsNotNullable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 35895, 35997);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 35931, 35982);

                    return f_10276_35938_35981_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10276_35938_35966(this), 10276, 35938, 35981)?.IsNotNullable);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 35895, 35997);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    f_10276_35938_35966(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOverridingMethodTypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.OverriddenTypeParameter;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 35938, 35966);
                        return return_v;
                    }


                    bool?
                    f_10276_35938_35981_M(bool?
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 35938, 35981);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 35833, 36008);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 35833, 36008);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool HasUnmanagedTypeConstraint
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 36092, 36293);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 36128, 36177);

                    var
                    typeParameter = f_10276_36148_36176(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 36195, 36278);

                    return ((object)typeParameter != null) && (DynAbs.Tracing.TraceSender.Expression_True(10276, 36202, 36277) && f_10276_36237_36277(typeParameter));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 36092, 36293);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    f_10276_36148_36176(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOverridingMethodTypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.OverriddenTypeParameter;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 36148, 36176);
                        return return_v;
                    }


                    bool
                    f_10276_36237_36277(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.HasUnmanagedTypeConstraint;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 36237, 36277);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 36020, 36304);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 36020, 36304);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override ImmutableArray<TypeParameterSymbol> ContainerTypeParameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 36419, 36460);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 36425, 36458);

                    return f_10276_36432_36457(f_10276_36432_36442(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 36419, 36460);

                    Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                    f_10276_36432_36442(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOverridingMethodTypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.Owner;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 36432, 36442);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    f_10276_36432_36457(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeParameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 36432, 36457);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 36316, 36471);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 36316, 36471);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override TypeParameterBounds ResolveBounds(ConsList<TypeParameterSymbol> inProgress, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 36483, 37159);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 36629, 36678);

                var
                typeParameter = f_10276_36649_36677(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 36692, 36786) || true) && ((object)typeParameter == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10276, 36692, 36786);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 36759, 36771);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10276, 36692, 36786);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 36800, 36823);

                var
                map = f_10276_36810_36822(_map)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 36837, 36863);

                f_10276_36837_36862(map != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 36879, 36972);

                var
                constraintTypes = f_10276_36901_36971(map, f_10276_36921_36970(typeParameter))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 36986, 37148);

                return f_10276_36993_37147(this, f_10276_37012_37046(f_10276_37012_37035(this)), f_10276_37048_37072(inProgress, this), constraintTypes, inherited: true, f_10276_37108_37133(this), diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 36483, 37159);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                f_10276_36649_36677(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOverridingMethodTypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.OverriddenTypeParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 36649, 36677);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                f_10276_36810_36822(Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenMethodTypeParameterMapBase
                this_param)
                {
                    var return_v = this_param.TypeMap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 36810, 36822);
                    return return_v;
                }


                int
                f_10276_36837_36862(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 36837, 36862);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10276_36921_36970(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.ConstraintTypesNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 36921, 36970);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10276_36901_36971(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                original)
                {
                    var return_v = this_param.SubstituteTypes(original);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 36901, 36971);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10276_37012_37035(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOverridingMethodTypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 37012, 37035);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10276_37012_37046(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.CorLibrary;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 37012, 37046);
                    return return_v;
                }


                Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10276_37048_37072(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                list, Microsoft.CodeAnalysis.CSharp.Symbols.SourceOverridingMethodTypeParameterSymbol
                head)
                {
                    var return_v = list.Prepend<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>((Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol)head);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 37048, 37072);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10276_37108_37133(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOverridingMethodTypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 37108, 37133);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterBounds
                f_10276_36993_37147(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOverridingMethodTypeParameterSymbol
                typeParameter, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                corLibrary, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                inProgress, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                constraintTypes, bool
                inherited, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                currentCompilation, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = typeParameter.ResolveBounds(corLibrary, inProgress, constraintTypes, inherited: inherited, currentCompilation, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 36993, 37147);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 36483, 37159);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 36483, 37159);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private TypeParameterSymbol OverriddenTypeParameter
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10276, 37539, 37643);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10276, 37575, 37628);

                    return f_10276_37582_37627(_map, f_10276_37614_37626(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10276, 37539, 37643);

                    int
                    f_10276_37614_37626(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOverridingMethodTypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.Ordinal;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10276, 37614, 37626);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    f_10276_37582_37627(Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenMethodTypeParameterMapBase
                    this_param, int
                    ordinal)
                    {
                        var return_v = this_param.GetOverriddenTypeParameter(ordinal);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10276, 37582, 37627);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10276, 37463, 37654);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 37463, 37654);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static SourceOverridingMethodTypeParameterSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10276, 32716, 37661);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10276, 32716, 37661);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10276, 32716, 37661);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10276, 32716, 37661);

        static string
        f_10276_33116_33120_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10276, 32899, 33200);
            return return_v;
        }

    }
}
