// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.Emit;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cci = Microsoft.Cci;
using Microsoft.CodeAnalysis.CodeGen;


namespace Microsoft.CodeAnalysis.CSharp.Emit.NoPia
{
    internal sealed class EmbeddedParameter : EmbeddedTypesManager.CommonEmbeddedParameter
    {
        public EmbeddedParameter(
                    EmbeddedTypesManager.CommonEmbeddedMember containingPropertyOrMethod, ParameterSymbolAdapter underlyingParameter) : base(f_10946_938_964_C(containingPropertyOrMethod), underlyingParameter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10946, 765, 1092);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10946, 1011, 1081);

                f_10946_1011_1080(f_10946_1024_1079(f_10946_1024_1066(underlyingParameter)));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10946, 765, 1092);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10946, 765, 1092);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10946, 765, 1092);
            }
        }

        protected override bool HasDefaultValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10946, 1168, 1294);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10946, 1204, 1279);

                    return f_10946_1211_1278(f_10946_1211_1253(UnderlyingParameter));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10946, 1168, 1294);

                    Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    f_10946_1211_1253(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbolAdapter
                    this_param)
                    {
                        var return_v = this_param.AdaptedParameterSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10946, 1211, 1253);
                        return return_v;
                    }


                    bool
                    f_10946_1211_1278(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.HasMetadataConstantValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10946, 1211, 1278);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10946, 1104, 1305);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10946, 1104, 1305);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override IEnumerable<CSharpAttributeData> GetCustomAttributesToEmit(PEModuleBuilder moduleBuilder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10946, 1317, 1552);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10946, 1450, 1541);

                return f_10946_1457_1540(f_10946_1457_1499(UnderlyingParameter), moduleBuilder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10946, 1317, 1552);

                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10946_1457_1499(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbolAdapter
                this_param)
                {
                    var return_v = this_param.AdaptedParameterSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10946, 1457, 1499);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10946_1457_1540(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                moduleBuilder)
                {
                    var return_v = this_param.GetCustomAttributesToEmit(moduleBuilder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10946, 1457, 1540);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10946, 1317, 1552);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10946, 1317, 1552);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override MetadataConstant GetDefaultValue(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10946, 1564, 1733);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10946, 1661, 1722);

                return f_10946_1668_1721(UnderlyingParameter, context);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10946, 1564, 1733);

                Microsoft.CodeAnalysis.CodeGen.MetadataConstant
                f_10946_1668_1721(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbolAdapter
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetMetadataConstantValue(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10946, 1668, 1721);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10946, 1564, 1733);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10946, 1564, 1733);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override bool IsIn
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10946, 1798, 1912);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10946, 1834, 1897);

                    return f_10946_1841_1896(f_10946_1841_1883(UnderlyingParameter));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10946, 1798, 1912);

                    Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    f_10946_1841_1883(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbolAdapter
                    this_param)
                    {
                        var return_v = this_param.AdaptedParameterSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10946, 1841, 1883);
                        return return_v;
                    }


                    bool
                    f_10946_1841_1896(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.IsMetadataIn;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10946, 1841, 1896);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10946, 1745, 1923);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10946, 1745, 1923);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override bool IsOut
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10946, 1989, 2104);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10946, 2025, 2089);

                    return f_10946_2032_2088(f_10946_2032_2074(UnderlyingParameter));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10946, 1989, 2104);

                    Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    f_10946_2032_2074(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbolAdapter
                    this_param)
                    {
                        var return_v = this_param.AdaptedParameterSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10946, 2032, 2074);
                        return return_v;
                    }


                    bool
                    f_10946_2032_2088(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.IsMetadataOut;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10946, 2032, 2088);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10946, 1935, 2115);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10946, 1935, 2115);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override bool IsOptional
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10946, 2186, 2306);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10946, 2222, 2291);

                    return f_10946_2229_2290(f_10946_2229_2271(UnderlyingParameter));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10946, 2186, 2306);

                    Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    f_10946_2229_2271(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbolAdapter
                    this_param)
                    {
                        var return_v = this_param.AdaptedParameterSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10946, 2229, 2271);
                        return return_v;
                    }


                    bool
                    f_10946_2229_2290(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.IsMetadataOptional;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10946, 2229, 2290);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10946, 2127, 2317);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10946, 2127, 2317);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override bool IsMarshalledExplicitly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10946, 2400, 2524);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10946, 2436, 2509);

                    return f_10946_2443_2508(f_10946_2443_2485(UnderlyingParameter));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10946, 2400, 2524);

                    Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    f_10946_2443_2485(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbolAdapter
                    this_param)
                    {
                        var return_v = this_param.AdaptedParameterSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10946, 2443, 2485);
                        return return_v;
                    }


                    bool
                    f_10946_2443_2508(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.IsMarshalledExplicitly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10946, 2443, 2508);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10946, 2329, 2535);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10946, 2329, 2535);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override Cci.IMarshallingInformation MarshallingInformation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10946, 2641, 2765);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10946, 2677, 2750);

                    return f_10946_2684_2749(f_10946_2684_2726(UnderlyingParameter));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10946, 2641, 2765);

                    Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    f_10946_2684_2726(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbolAdapter
                    this_param)
                    {
                        var return_v = this_param.AdaptedParameterSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10946, 2684, 2726);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.MarshalPseudoCustomAttributeData
                    f_10946_2684_2749(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.MarshallingInformation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10946, 2684, 2749);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10946, 2547, 2776);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10946, 2547, 2776);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override ImmutableArray<byte> MarshallingDescriptor
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10946, 2874, 2997);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10946, 2910, 2982);

                    return f_10946_2917_2981(f_10946_2917_2959(UnderlyingParameter));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10946, 2874, 2997);

                    Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    f_10946_2917_2959(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbolAdapter
                    this_param)
                    {
                        var return_v = this_param.AdaptedParameterSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10946, 2917, 2959);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<byte>
                    f_10946_2917_2981(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.MarshallingDescriptor;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10946, 2917, 2981);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10946, 2788, 3008);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10946, 2788, 3008);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10946, 3075, 3146);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10946, 3081, 3144);

                    return f_10946_3088_3143(f_10946_3088_3130(UnderlyingParameter));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10946, 3075, 3146);

                    Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    f_10946_3088_3130(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbolAdapter
                    this_param)
                    {
                        var return_v = this_param.AdaptedParameterSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10946, 3088, 3130);
                        return return_v;
                    }


                    string
                    f_10946_3088_3143(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.MetadataName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10946, 3088, 3143);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10946, 3020, 3157);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10946, 3020, 3157);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override Cci.IParameterTypeInformation UnderlyingParameterTypeInformation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10946, 3277, 3386);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10946, 3313, 3371);

                    return (Cci.IParameterTypeInformation)UnderlyingParameter;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10946, 3277, 3386);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10946, 3169, 3397);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10946, 3169, 3397);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override ushort Index
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10946, 3465, 3582);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10946, 3501, 3567);

                    return (ushort)f_10946_3516_3566(f_10946_3516_3558(UnderlyingParameter));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10946, 3465, 3582);

                    Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    f_10946_3516_3558(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbolAdapter
                    this_param)
                    {
                        var return_v = this_param.AdaptedParameterSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10946, 3516, 3558);
                        return return_v;
                    }


                    int
                    f_10946_3516_3566(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.Ordinal;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10946, 3516, 3566);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10946, 3409, 3593);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10946, 3409, 3593);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static EmbeddedParameter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10946, 662, 3600);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10946, 662, 3600);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10946, 662, 3600);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10946, 662, 3600);

        Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        f_10946_1024_1066(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbolAdapter
        this_param)
        {
            var return_v = this_param.AdaptedParameterSymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10946, 1024, 1066);
            return return_v;
        }


        bool
        f_10946_1024_1079(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        this_param)
        {
            var return_v = this_param.IsDefinition;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10946, 1024, 1079);
            return return_v;
        }


        int
        f_10946_1011_1080(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10946, 1011, 1080);
            return 0;
        }


        static Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager<Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder, Microsoft.CodeAnalysis.CSharp.ModuleCompilationState, Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedTypesManager, Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData, Microsoft.CodeAnalysis.CSharp.SymbolAdapter, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter, Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbolAdapter, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbolAdapter, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbolAdapter, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbolAdapter, Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedType, Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedField, Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedMethod, Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedEvent, Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedProperty, Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedParameter, Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedTypeParameter>.CommonEmbeddedMember
        f_10946_938_964_C(Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager<Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder, Microsoft.CodeAnalysis.CSharp.ModuleCompilationState, Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedTypesManager, Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData, Microsoft.CodeAnalysis.CSharp.SymbolAdapter, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter, Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbolAdapter, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbolAdapter, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbolAdapter, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbolAdapter, Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedType, Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedField, Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedMethod, Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedEvent, Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedProperty, Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedParameter, Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedTypeParameter>.CommonEmbeddedMember
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10946, 765, 1092);
            return return_v;
        }

    }
}
