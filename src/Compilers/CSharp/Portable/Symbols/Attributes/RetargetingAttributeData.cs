// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Collections.Immutable;

namespace Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting
{
    internal sealed class RetargetingAttributeData : SourceAttributeData
    {
        internal RetargetingAttributeData(
                    SyntaxReference applicationNode,
                    NamedTypeSymbol attributeClass,
                    MethodSymbol attributeConstructor,
                    ImmutableArray<TypedConstant> constructorArguments,
                    ImmutableArray<int> constructorArgumentsSourceIndices,
                    ImmutableArray<KeyValuePair<string, TypedConstant>> namedArguments,
                    bool hasErrors,
                    bool isConditionallyOmitted)
        : base(f_10404_1004_1019_C(applicationNode), attributeClass, attributeConstructor, constructorArguments, constructorArgumentsSourceIndices, namedArguments, hasErrors, isConditionallyOmitted)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10404, 525, 1188);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10404, 525, 1188);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10404, 525, 1188);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10404, 525, 1188);
            }
        }

        internal override TypeSymbol GetSystemType(Symbol targetSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10404, 1471, 2280);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10404, 1559, 1704);

                var
                retargetingAssembly = (RetargetingAssemblySymbol)((DynAbs.Tracing.TraceSender.Conditional_F1(10404, 1613, 1653) || ((f_10404_1613_1630(targetSymbol) == SymbolKind.Assembly && DynAbs.Tracing.TraceSender.Conditional_F2(10404, 1656, 1668)) || DynAbs.Tracing.TraceSender.Conditional_F3(10404, 1671, 1702))) ? targetSymbol : f_10404_1671_1702(targetSymbol))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10404, 1718, 1804);

                var
                underlyingAssembly = (SourceAssemblySymbol)f_10404_1765_1803(retargetingAssembly)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10404, 1899, 2007);

                TypeSymbol
                systemType = f_10404_1923_2006(f_10404_1923_1962(underlyingAssembly), WellKnownType.System_Type)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10404, 2057, 2137);

                var
                retargetingModule = (RetargetingModuleSymbol)f_10404_2106_2133(retargetingAssembly)[0]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10404, 2151, 2269);

                return f_10404_2158_2268(retargetingModule.RetargetingTranslator, systemType, RetargetOptions.RetargetPrimitiveTypesByTypeCode);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10404, 1471, 2280);

                Microsoft.CodeAnalysis.SymbolKind
                f_10404_1613_1630(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10404, 1613, 1630);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10404_1671_1702(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10404, 1671, 1702);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10404_1765_1803(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingAssemblySymbol
                this_param)
                {
                    var return_v = this_param.UnderlyingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10404, 1765, 1803);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10404_1923_1962(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10404, 1923, 1962);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10404_1923_2006(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10404, 1923, 2006);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                f_10404_2106_2133(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingAssemblySymbol
                this_param)
                {
                    var return_v = this_param.Modules;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10404, 2106, 2133);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10404_2158_2268(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                symbol, Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetOptions
                options)
                {
                    var return_v = this_param.Retarget(symbol, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10404, 2158, 2268);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10404, 1471, 2280);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10404, 1471, 2280);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static RetargetingAttributeData()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10404, 440, 2287);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10404, 440, 2287);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10404, 440, 2287);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10404, 440, 2287);

        static Microsoft.CodeAnalysis.SyntaxReference
        f_10404_1004_1019_C(Microsoft.CodeAnalysis.SyntaxReference
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10404, 525, 1188);
            return return_v;
        }

    }
}
