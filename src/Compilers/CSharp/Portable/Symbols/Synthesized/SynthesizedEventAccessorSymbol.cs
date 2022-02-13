// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Reflection;
using Microsoft.CodeAnalysis.CSharp.Emit;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class SynthesizedEventAccessorSymbol : SourceEventAccessorSymbol
    {
        private readonly object _methodChecksLockObject;

        internal SynthesizedEventAccessorSymbol(SourceEventSymbol @event, bool isAdder, EventSymbol explicitlyImplementedEventOpt = null, string aliasQualifierOpt = null)
        : base(f_10675_1261_1267_C(@event), null, f_10675_1275_1291(@event), explicitlyImplementedEventOpt, aliasQualifierOpt, isAdder, isIterator: false, isNullableAnalysisEnabled: false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10675, 1078, 1426);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10675, 1027, 1065);
                this._methodChecksLockObject = f_10675_1053_1065(); DynAbs.Tracing.TraceSender.TraceExitConstructor(10675, 1078, 1426);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10675, 1078, 1426);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10675, 1078, 1426);
            }
        }

        public override bool IsImplicitlyDeclared
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10675, 1504, 1524);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10675, 1510, 1522);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10675, 1504, 1524);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10675, 1438, 1535);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10675, 1438, 1535);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool GenerateDebugInfo
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10675, 1612, 1633);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10675, 1618, 1631);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10675, 1612, 1633);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10675, 1547, 1644);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10675, 1547, 1644);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override SourceMemberMethodSymbol BoundAttributesSource
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10675, 1746, 1954);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10675, 1782, 1939);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10675, 1789, 1827) || ((f_10675_1789_1804(this) == MethodKind.EventAdd
                    && DynAbs.Tracing.TraceSender.Conditional_F2(10675, 1851, 1910)) || DynAbs.Tracing.TraceSender.Conditional_F3(10675, 1934, 1938))) ? (SourceMemberMethodSymbol)f_10675_1877_1910(f_10675_1877_1897(this)) : null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10675, 1746, 1954);

                    Microsoft.CodeAnalysis.MethodKind
                    f_10675_1789_1804(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEventAccessorSymbol
                    this_param)
                    {
                        var return_v = this_param.MethodKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10675, 1789, 1804);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                    f_10675_1877_1897(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEventAccessorSymbol
                    this_param)
                    {
                        var return_v = this_param.AssociatedEvent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10675, 1877, 1897);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                    f_10675_1877_1910(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                    this_param)
                    {
                        var return_v = this_param.RemoveMethod
                        ;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10675, 1877, 1910);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10675, 1656, 1965);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10675, 1656, 1965);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10675, 2058, 2220);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10675, 2182, 2205);

                    return f_10675_2189_2204();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10675, 2058, 2220);

                    Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                    f_10675_2189_2204()
                    {
                        var return_v = AssociatedEvent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10675, 2189, 2204);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10675, 1977, 2231);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10675, 1977, 2231);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override OneOrMany<SyntaxList<AttributeListSyntax>> GetAttributeDeclarations()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10675, 2243, 2443);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10675, 2355, 2432);

                return f_10675_2362_2431(f_10675_2379_2430(f_10675_2379_2399(this)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10675, 2243, 2443);

                Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                f_10675_2379_2399(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEventAccessorSymbol
                this_param)
                {
                    var return_v = this_param.AssociatedEvent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10675, 2379, 2399);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                f_10675_2379_2430(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                this_param)
                {
                    var return_v = this_param.AttributeDeclarationSyntaxList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10675, 2379, 2430);
                    return return_v;
                }


                Roslyn.Utilities.OneOrMany<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                f_10675_2362_2431(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                one)
                {
                    var return_v = OneOrMany.Create(one);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10675, 2362, 2431);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10675, 2243, 2443);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10675, 2243, 2443);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override void AddSynthesizedAttributes(PEModuleBuilder moduleBuilder, ref ArrayBuilder<SynthesizedAttributeData> attributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10675, 2455, 2917);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10675, 2613, 2674);

                // LAFHIS
                //DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.AddSynthesizedAttributes(moduleBuilder, ref attributes), 10675, 2613, 2673);
                base.AddSynthesizedAttributes(moduleBuilder, ref attributes);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10675, 2613, 2673);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10675, 2690, 2734);

                var
                compilation = f_10675_2708_2733(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10675, 2748, 2906);

                f_10675_2748_2905(ref attributes, f_10675_2788_2904(compilation, WellKnownMember.System_Runtime_CompilerServices_CompilerGeneratedAttribute__ctor));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10675, 2455, 2917);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10675_2708_2733(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEventAccessorSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10675, 2708, 2733);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                f_10675_2788_2904(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                constructor)
                {
                    var return_v = this_param.TrySynthesizeAttribute(constructor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10675, 2788, 2904);
                    return return_v;
                }


                int
                f_10675_2748_2905(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10675, 2748, 2905);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10675, 2455, 2917);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10675, 2455, 2917);
            }
        }

        protected override object MethodChecksLockObject
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10675, 3002, 3041);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10675, 3008, 3039);

                    return _methodChecksLockObject;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10675, 3002, 3041);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10675, 2929, 3052);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10675, 2929, 3052);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override MethodImplAttributes ImplementationAttributes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10675, 3152, 3748);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10675, 3188, 3248);

                    MethodImplAttributes
                    result = DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.ImplementationAttributes, 10675, 3218, 3247)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10675, 3268, 3699) || true) && (f_10675_3272_3283_M(!IsAbstract) && (DynAbs.Tracing.TraceSender.Expression_True(10675, 3272, 3325) && f_10675_3287_3325_M(!f_10675_3288_3303().IsWindowsRuntimeEvent)) && (DynAbs.Tracing.TraceSender.Expression_True(10675, 3272, 3359) && !f_10675_3330_3359(f_10675_3330_3344())) && (DynAbs.Tracing.TraceSender.Expression_True(10675, 3272, 3508) && (object)f_10675_3392_3500(f_10675_3392_3412(), WellKnownMember.System_Threading_Interlocked__CompareExchange_T) == null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10675, 3268, 3699);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10675, 3636, 3680);

                        result |= MethodImplAttributes.Synchronized;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10675, 3268, 3699);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10675, 3719, 3733);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10675, 3152, 3748);

                    bool
                    f_10675_3272_3283_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10675, 3272, 3283);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                    f_10675_3288_3303()
                    {
                        var return_v = AssociatedEvent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10675, 3288, 3303);
                        return return_v;
                    }


                    bool
                    f_10675_3287_3325_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10675, 3287, 3325);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10675_3330_3344()
                    {
                        var return_v = ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10675, 3330, 3344);
                        return return_v;
                    }


                    bool
                    f_10675_3330_3359(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    type)
                    {
                        var return_v = type.IsStructType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10675, 3330, 3359);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    f_10675_3392_3412()
                    {
                        var return_v = DeclaringCompilation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10675, 3392, 3412);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol?
                    f_10675_3392_3500(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param, Microsoft.CodeAnalysis.WellKnownMember
                    member)
                    {
                        var return_v = this_param.GetWellKnownTypeMember(member);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10675, 3392, 3500);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10675, 3064, 3759);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10675, 3064, 3759);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static SynthesizedEventAccessorSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10675, 808, 3766);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10675, 808, 3766);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10675, 808, 3766);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10675, 808, 3766);

        object
        f_10675_1053_1065()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10675, 1053, 1065);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
        f_10675_1275_1291(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
        this_param)
        {
            var return_v = this_param.Locations;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10675, 1275, 1291);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
        f_10675_1261_1267_C(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10675, 1078, 1426);
            return return_v;
        }

    }
}
