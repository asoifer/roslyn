// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Emit;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class SynthesizedAccessorValueParameterSymbol : SourceComplexParameterSymbol
    {
        public SynthesizedAccessorValueParameterSymbol(SourceMemberMethodSymbol accessor, TypeWithAnnotations paramType, int ordinal)
        : base(f_10664_1076_1084_C(accessor), ordinal, paramType, RefKind.None, ParameterSymbol.ValueParameterName, f_10664_1156_1174(accessor), syntaxRef: null, isParams: false, isExtensionMethodThis: false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10664, 930, 1321);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10664, 930, 1321);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10664, 930, 1321);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10664, 930, 1321);
            }
        }

        internal override FlowAnalysisAnnotations FlowAnalysisAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10664, 1423, 2082);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10664, 1459, 1501);

                    var
                    result = FlowAnalysisAnnotations.None
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10664, 1519, 2035) || true) && (f_10664_1523_1539() is SourcePropertyAccessorSymbol propertyAccessor && (DynAbs.Tracing.TraceSender.Expression_True(10664, 1523, 1662) && f_10664_1592_1625(propertyAccessor) is SourcePropertySymbolBase property))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10664, 1519, 2035);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10664, 1704, 1852) || true) && (f_10664_1708_1732(property))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10664, 1704, 1852);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10664, 1782, 1829);

                            result |= FlowAnalysisAnnotations.DisallowNull;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10664, 1704, 1852);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10664, 1874, 2016) || true) && (f_10664_1878_1899(property))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10664, 1874, 2016);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10664, 1949, 1993);

                            result |= FlowAnalysisAnnotations.AllowNull;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10664, 1874, 2016);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10664, 1519, 2035);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10664, 2053, 2067);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10664, 1423, 2082);

                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10664_1523_1539()
                    {
                        var return_v = ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10664, 1523, 1539);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10664_1592_1625(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol
                    this_param)
                    {
                        var return_v = this_param.AssociatedSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10664, 1592, 1625);
                        return return_v;
                    }


                    bool
                    f_10664_1708_1732(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                    this_param)
                    {
                        var return_v = this_param.HasDisallowNull;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10664, 1708, 1732);
                        return return_v;
                    }


                    bool
                    f_10664_1878_1899(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                    this_param)
                    {
                        var return_v = this_param.HasAllowNull;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10664, 1878, 1899);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10664, 1333, 2093);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10664, 1333, 2093);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ImmutableHashSet<string> NotNullIfParameterNotNull
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10664, 2174, 2207);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10664, 2177, 2207);
                    return ImmutableHashSet<string>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10664, 2174, 2207);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10664, 2174, 2207);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10664, 2174, 2207);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10664, 2310, 2438);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10664, 2346, 2390);

                    return ImmutableArray<CustomModifier>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10664, 2310, 2438);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10664, 2220, 2449);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10664, 2220, 2449);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsImplicitlyDeclared
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10664, 2527, 2547);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10664, 2533, 2545);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10664, 2527, 2547);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10664, 2461, 2558);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10664, 2461, 2558);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override IAttributeTargetSymbol AttributeOwner
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10664, 2651, 2714);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10664, 2657, 2712);

                    return (SourceMemberMethodSymbol)f_10664_2690_2711(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10664, 2651, 2714);

                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10664_2690_2711(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAccessorValueParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10664, 2690, 2711);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10664, 2570, 2725);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10664, 2570, 2725);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override OneOrMany<SyntaxList<AttributeListSyntax>> GetAttributeDeclarations()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10664, 2737, 3087);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10664, 2956, 3019);

                var
                accessor = (SourceMemberMethodSymbol)f_10664_2997_3018(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10664, 3033, 3076);

                return f_10664_3040_3075(accessor);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10664, 2737, 3087);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10664_2997_3018(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAccessorValueParameterSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10664, 2997, 3018);
                    return return_v;
                }


                Roslyn.Utilities.OneOrMany<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                f_10664_3040_3075(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                this_param)
                {
                    var return_v = this_param.GetAttributeDeclarations();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10664, 3040, 3075);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10664, 2737, 3087);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10664, 2737, 3087);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override void AddSynthesizedAttributes(PEModuleBuilder moduleBuilder, ref ArrayBuilder<SynthesizedAttributeData> attributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10664, 3099, 4073);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10664, 3257, 3318);

                // LAFHIS
                //DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.AddSynthesizedAttributes(moduleBuilder, ref attributes), 10664, 3257, 3317);
                base.AddSynthesizedAttributes(moduleBuilder, ref attributes);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10664, 3257, 3317);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10664, 3334, 4062) || true) && (f_10664_3338_3354() is SourcePropertyAccessorSymbol propertyAccessor && (DynAbs.Tracing.TraceSender.Expression_True(10664, 3338, 3477) && f_10664_3407_3440(propertyAccessor) is SourcePropertySymbolBase property))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10664, 3334, 4062);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10664, 3511, 3553);

                    var
                    annotations = f_10664_3529_3552()
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10664, 3571, 3803) || true) && ((annotations & FlowAnalysisAnnotations.DisallowNull) != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10664, 3571, 3803);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10664, 3674, 3784);

                        f_10664_3674_3783(ref attributes, f_10664_3714_3782(f_10664_3743_3781(property)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10664, 3571, 3803);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10664, 3821, 4047) || true) && ((annotations & FlowAnalysisAnnotations.AllowNull) != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10664, 3821, 4047);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10664, 3921, 4028);

                        f_10664_3921_4027(ref attributes, f_10664_3961_4026(f_10664_3990_4025(property)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10664, 3821, 4047);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10664, 3334, 4062);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10664, 3099, 4073);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10664_3338_3354()
                {
                    var return_v = ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10664, 3338, 3354);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10664_3407_3440(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol
                this_param)
                {
                    var return_v = this_param.AssociatedSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10664, 3407, 3440);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FlowAnalysisAnnotations
                f_10664_3529_3552()
                {
                    var return_v = FlowAnalysisAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10664, 3529, 3552);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceAttributeData
                f_10664_3743_3781(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                this_param)
                {
                    var return_v = this_param.DisallowNullAttributeIfExists;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10664, 3743, 3781);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                f_10664_3714_3782(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAttributeData
                original)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData(original);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10664, 3714, 3782);
                    return return_v;
                }


                int
                f_10664_3674_3783(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10664, 3674, 3783);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceAttributeData
                f_10664_3990_4025(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                this_param)
                {
                    var return_v = this_param.AllowNullAttributeIfExists;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10664, 3990, 4025);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                f_10664_3961_4026(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAttributeData
                original)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData(original);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10664, 3961, 4026);
                    return return_v;
                }


                int
                f_10664_3921_4027(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10664, 3921, 4027);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10664, 3099, 4073);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10664, 3099, 4073);
            }
        }

        static SynthesizedAccessorValueParameterSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10664, 821, 4080);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10664, 821, 4080);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10664, 821, 4080);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10664, 821, 4080);

        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
        f_10664_1156_1174(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
        this_param)
        {
            var return_v = this_param.Locations;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10664, 1156, 1174);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbol
        f_10664_1076_1084_C(Microsoft.CodeAnalysis.CSharp.Symbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10664, 930, 1321);
            return return_v;
        }

    }
}
