// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Cci = Microsoft.Cci;


namespace Microsoft.CodeAnalysis.CSharp.Emit.NoPia
{
    internal sealed class EmbeddedProperty : EmbeddedTypesManager.CommonEmbeddedProperty
    {
        public EmbeddedProperty(PropertySymbolAdapter underlyingProperty, EmbeddedMethod getter, EmbeddedMethod setter) : base(f_10947_776_794_C(underlyingProperty), getter, setter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10947, 644, 833);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10947, 644, 833);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10947, 644, 833);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10947, 644, 833);
            }
        }

        protected override IEnumerable<CSharpAttributeData> GetCustomAttributesToEmit(PEModuleBuilder moduleBuilder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10947, 845, 1078);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10947, 978, 1067);

                return f_10947_985_1066(f_10947_985_1025(f_10947_985_1003()), moduleBuilder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10947, 845, 1078);

                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbolAdapter
                f_10947_985_1003()
                {
                    var return_v = UnderlyingProperty;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10947, 985, 1003);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10947_985_1025(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbolAdapter
                this_param)
                {
                    var return_v = this_param.AdaptedPropertySymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10947, 985, 1025);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10947_985_1066(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                moduleBuilder)
                {
                    var return_v = this_param.GetCustomAttributesToEmit(moduleBuilder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10947, 985, 1066);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10947, 845, 1078);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10947, 845, 1078);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override ImmutableArray<EmbeddedParameter> GetParameters()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10947, 1090, 1297);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10947, 1183, 1286);

                return f_10947_1190_1285(this, f_10947_1233_1284(f_10947_1233_1273(f_10947_1233_1251())));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10947, 1090, 1297);

                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbolAdapter
                f_10947_1233_1251()
                {
                    var return_v = UnderlyingProperty;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10947, 1233, 1251);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10947_1233_1273(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbolAdapter
                this_param)
                {
                    var return_v = this_param.AdaptedPropertySymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10947, 1233, 1273);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10947_1233_1284(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10947, 1233, 1284);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedParameter>
                f_10947_1190_1285(Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedProperty
                containingPropertyOrMethod, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                underlyingParameters)
                {
                    var return_v = EmbeddedTypesManager.EmbedParameters((Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager<Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder, Microsoft.CodeAnalysis.CSharp.ModuleCompilationState, Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedTypesManager, Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData, Microsoft.CodeAnalysis.CSharp.SymbolAdapter, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter, Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbolAdapter, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbolAdapter, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbolAdapter, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbolAdapter, Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedType, Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedField, Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedMethod, Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedEvent, Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedProperty, Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedParameter, Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedTypeParameter>.CommonEmbeddedMember)containingPropertyOrMethod, underlyingParameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10947, 1190, 1285);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10947, 1090, 1297);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10947, 1090, 1297);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override bool IsRuntimeSpecial
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10947, 1374, 1452);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10947, 1380, 1450);

                    return f_10947_1387_1449(f_10947_1387_1427(f_10947_1387_1405()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10947, 1374, 1452);

                    Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbolAdapter
                    f_10947_1387_1405()
                    {
                        var return_v = UnderlyingProperty;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10947, 1387, 1405);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    f_10947_1387_1427(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbolAdapter
                    this_param)
                    {
                        var return_v = this_param.AdaptedPropertySymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10947, 1387, 1427);
                        return return_v;
                    }


                    bool
                    f_10947_1387_1449(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.HasRuntimeSpecialName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10947, 1387, 1449);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10947, 1309, 1463);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10947, 1309, 1463);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override bool IsSpecialName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10947, 1537, 1651);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10947, 1573, 1636);

                    return f_10947_1580_1635(f_10947_1580_1620(f_10947_1580_1598()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10947, 1537, 1651);

                    Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbolAdapter
                    f_10947_1580_1598()
                    {
                        var return_v = UnderlyingProperty;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10947, 1580, 1598);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    f_10947_1580_1620(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbolAdapter
                    this_param)
                    {
                        var return_v = this_param.AdaptedPropertySymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10947, 1580, 1620);
                        return return_v;
                    }


                    bool
                    f_10947_1580_1635(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.HasSpecialName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10947, 1580, 1635);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10947, 1475, 1662);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10947, 1475, 1662);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override Cci.ISignature UnderlyingPropertySignature
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10947, 1760, 1853);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10947, 1796, 1838);

                    return (Cci.ISignature)f_10947_1819_1837();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10947, 1760, 1853);

                    Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbolAdapter
                    f_10947_1819_1837()
                    {
                        var return_v = UnderlyingProperty;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10947, 1819, 1837);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10947, 1674, 1864);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10947, 1674, 1864);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override EmbeddedType ContainingType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10947, 1947, 1988);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10947, 1953, 1986);

                    return f_10947_1960_1970().ContainingType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10947, 1947, 1988);

                    Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedMethod
                    f_10947_1960_1970()
                    {
                        var return_v = AnAccessor;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10947, 1960, 1970);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10947, 1876, 1999);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10947, 1876, 1999);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override Cci.TypeMemberVisibility Visibility
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10947, 2090, 2223);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10947, 2126, 2208);

                    return f_10947_2133_2207(f_10947_2166_2206(f_10947_2166_2184()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10947, 2090, 2223);

                    Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbolAdapter
                    f_10947_2166_2184()
                    {
                        var return_v = UnderlyingProperty;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10947, 2166, 2184);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    f_10947_2166_2206(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbolAdapter
                    this_param)
                    {
                        var return_v = this_param.AdaptedPropertySymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10947, 2166, 2206);
                        return return_v;
                    }


                    Microsoft.Cci.TypeMemberVisibility
                    f_10947_2133_2207(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    symbol)
                    {
                        var return_v = PEModuleBuilder.MemberVisibility((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10947, 2133, 2207);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10947, 2011, 2234);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10947, 2011, 2234);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10947, 2301, 2413);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10947, 2337, 2398);

                    return f_10947_2344_2397(f_10947_2344_2384(f_10947_2344_2362()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10947, 2301, 2413);

                    Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbolAdapter
                    f_10947_2344_2362()
                    {
                        var return_v = UnderlyingProperty;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10947, 2344, 2362);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    f_10947_2344_2384(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbolAdapter
                    this_param)
                    {
                        var return_v = this_param.AdaptedPropertySymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10947, 2344, 2384);
                        return return_v;
                    }


                    string
                    f_10947_2344_2397(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.MetadataName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10947, 2344, 2397);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10947, 2246, 2424);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10947, 2246, 2424);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static EmbeddedProperty()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10947, 543, 2431);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10947, 543, 2431);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10947, 543, 2431);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10947, 543, 2431);

        static Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbolAdapter
        f_10947_776_794_C(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbolAdapter
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10947, 644, 833);
            return return_v;
        }

    }
}
