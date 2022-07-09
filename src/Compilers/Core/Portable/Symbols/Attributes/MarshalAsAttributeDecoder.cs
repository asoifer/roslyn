// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.CodeAnalysis.Symbols;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis
{
    internal static class MarshalAsAttributeDecoder<TWellKnownAttributeData, TAttributeSyntax, TAttributeData, TAttributeLocation>
            where TWellKnownAttributeData : WellKnownAttributeData, IMarshalAsAttributeTarget, new()
            where TAttributeSyntax : SyntaxNode
            where TAttributeData : AttributeData
    {
        internal static void Decode(ref DecodeWellKnownAttributeArguments<TAttributeSyntax, TAttributeData, TAttributeLocation> arguments, AttributeTargets target, CommonMessageProvider messageProvider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(811, 760, 4422);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 979, 1038);

                f_811_979_1037((object)arguments.AttributeSyntaxOpt != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 1054, 1125);

                UnmanagedType
                unmanagedType = f_811_1084_1124(arguments.Attribute)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 1141, 4411);

                switch (unmanagedType)
                {

                    case Cci.Constants.UnmanagedType_CustomMarshaler:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(811, 1141, 4411);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 1267, 1321);

                        f_811_1267_1320(ref arguments, messageProvider);
                        DynAbs.Tracing.TraceSender.TraceBreak(811, 1343, 1349);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(811, 1141, 4411);

                    case UnmanagedType.Interface:
                    case Cci.Constants.UnmanagedType_IDispatch:
                    case UnmanagedType.IUnknown:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(811, 1141, 4411);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 1527, 1602);

                        f_811_1527_1601(ref arguments, unmanagedType, messageProvider);
                        DynAbs.Tracing.TraceSender.TraceBreak(811, 1624, 1630);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(811, 1141, 4411);

                    case UnmanagedType.LPArray:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(811, 1141, 4411);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 1699, 1768);

                        f_811_1699_1767(ref arguments, messageProvider, isFixed: false);
                        DynAbs.Tracing.TraceSender.TraceBreak(811, 1790, 1796);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(811, 1141, 4411);

                    case UnmanagedType.ByValArray:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(811, 1141, 4411);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 1868, 2295) || true) && (target != AttributeTargets.Field)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(811, 1868, 2295);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 1954, 2106);

                            f_811_1954_2105(messageProvider, arguments.Diagnostics, arguments.AttributeSyntaxOpt, 0, "ByValArray", arguments.Attribute);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(811, 1868, 2295);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(811, 1868, 2295);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 2204, 2272);

                            f_811_2204_2271(ref arguments, messageProvider, isFixed: true);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(811, 1868, 2295);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(811, 2319, 2325);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(811, 1141, 4411);

                    case Cci.Constants.UnmanagedType_SafeArray:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(811, 1141, 4411);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 2410, 2467);

                        f_811_2410_2466(ref arguments, messageProvider);
                        DynAbs.Tracing.TraceSender.TraceBreak(811, 2489, 2495);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(811, 1141, 4411);

                    case UnmanagedType.ByValTStr:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(811, 1141, 4411);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 2566, 2983) || true) && (target != AttributeTargets.Field)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(811, 2566, 2983);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 2652, 2803);

                            f_811_2652_2802(messageProvider, arguments.Diagnostics, arguments.AttributeSyntaxOpt, 0, "ByValTStr", arguments.Attribute);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(811, 2566, 2983);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(811, 2566, 2983);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 2901, 2960);

                            f_811_2901_2959(ref arguments, messageProvider);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(811, 2566, 2983);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(811, 3007, 3013);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(811, 1141, 4411);

                    case Cci.Constants.UnmanagedType_VBByRefStr:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(811, 1141, 4411);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 3099, 3633) || true) && (target == AttributeTargets.Field)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(811, 3099, 3633);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 3185, 3336);

                            f_811_3185_3335(messageProvider, arguments.Diagnostics, arguments.AttributeSyntaxOpt, 0, "VBByRefStr", arguments.Attribute);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(811, 3099, 3633);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(811, 3099, 3633);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 3501, 3610);

                            f_811_3501_3609(f_811_3501_3571(                        // named parameters ignored with no error
                                                    arguments.GetOrCreateData<TWellKnownAttributeData>()), unmanagedType);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(811, 3099, 3633);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(811, 3657, 3663);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(811, 1141, 4411);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(811, 1141, 4411);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 3713, 4366) || true) && ((int)unmanagedType < 0 || (DynAbs.Tracing.TraceSender.Expression_False(811, 3717, 3814) || (int)unmanagedType > MarshalPseudoCustomAttributeData.MaxMarshalInteger))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(811, 3713, 4366);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 3945, 4069);

                            f_811_3945_4068(                        // Dev10 reports CS0647: "Error emitting attribute ..."
                                                    messageProvider, arguments.Diagnostics, arguments.AttributeSyntaxOpt, 0, arguments.Attribute);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(811, 3713, 4366);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(811, 3713, 4366);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 4234, 4343);

                            f_811_4234_4342(f_811_4234_4304(                        // named parameters ignored with no error
                                                    arguments.GetOrCreateData<TWellKnownAttributeData>()), unmanagedType);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(811, 3713, 4366);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(811, 4390, 4396);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(811, 1141, 4411);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(811, 760, 4422);

                int
                f_811_979_1037(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(811, 979, 1037);
                    return 0;
                }


                System.Runtime.InteropServices.UnmanagedType
                f_811_1084_1124(TAttributeData
                attribute)
                {
                    var return_v = DecodeMarshalAsType((Microsoft.CodeAnalysis.AttributeData)attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(811, 1084, 1124);
                    return return_v;
                }


                int
                f_811_1267_1320(ref Microsoft.CodeAnalysis.DecodeWellKnownAttributeArguments<TAttributeSyntax, TAttributeData, TAttributeLocation>
                arguments, Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider)
                {
                    DecodeMarshalAsCustom(ref arguments, messageProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(811, 1267, 1320);
                    return 0;
                }


                int
                f_811_1527_1601(ref Microsoft.CodeAnalysis.DecodeWellKnownAttributeArguments<TAttributeSyntax, TAttributeData, TAttributeLocation>
                arguments, System.Runtime.InteropServices.UnmanagedType
                unmanagedType, Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider)
                {
                    DecodeMarshalAsComInterface(ref arguments, unmanagedType, messageProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(811, 1527, 1601);
                    return 0;
                }


                int
                f_811_1699_1767(ref Microsoft.CodeAnalysis.DecodeWellKnownAttributeArguments<TAttributeSyntax, TAttributeData, TAttributeLocation>
                arguments, Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, bool
                isFixed)
                {
                    DecodeMarshalAsArray(ref arguments, messageProvider, isFixed: isFixed);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(811, 1699, 1767);
                    return 0;
                }


                int
                f_811_1954_2105(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, TAttributeSyntax
                attributeSyntax, int
                parameterIndex, string
                unmanagedTypeName, TAttributeData
                attribute)
                {
                    this_param.ReportMarshalUnmanagedTypeOnlyValidForFields(diagnostics, (Microsoft.CodeAnalysis.SyntaxNode)attributeSyntax, parameterIndex, unmanagedTypeName, (Microsoft.CodeAnalysis.AttributeData)attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(811, 1954, 2105);
                    return 0;
                }


                int
                f_811_2204_2271(ref Microsoft.CodeAnalysis.DecodeWellKnownAttributeArguments<TAttributeSyntax, TAttributeData, TAttributeLocation>
                arguments, Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, bool
                isFixed)
                {
                    DecodeMarshalAsArray(ref arguments, messageProvider, isFixed: isFixed);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(811, 2204, 2271);
                    return 0;
                }


                int
                f_811_2410_2466(ref Microsoft.CodeAnalysis.DecodeWellKnownAttributeArguments<TAttributeSyntax, TAttributeData, TAttributeLocation>
                arguments, Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider)
                {
                    DecodeMarshalAsSafeArray(ref arguments, messageProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(811, 2410, 2466);
                    return 0;
                }


                int
                f_811_2652_2802(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, TAttributeSyntax
                attributeSyntax, int
                parameterIndex, string
                unmanagedTypeName, TAttributeData
                attribute)
                {
                    this_param.ReportMarshalUnmanagedTypeOnlyValidForFields(diagnostics, (Microsoft.CodeAnalysis.SyntaxNode)attributeSyntax, parameterIndex, unmanagedTypeName, (Microsoft.CodeAnalysis.AttributeData)attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(811, 2652, 2802);
                    return 0;
                }


                int
                f_811_2901_2959(ref Microsoft.CodeAnalysis.DecodeWellKnownAttributeArguments<TAttributeSyntax, TAttributeData, TAttributeLocation>
                arguments, Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider)
                {
                    DecodeMarshalAsFixedString(ref arguments, messageProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(811, 2901, 2959);
                    return 0;
                }


                int
                f_811_3185_3335(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, TAttributeSyntax
                attributeSyntax, int
                parameterIndex, string
                unmanagedTypeName, TAttributeData
                attribute)
                {
                    this_param.ReportMarshalUnmanagedTypeNotValidForFields(diagnostics, (Microsoft.CodeAnalysis.SyntaxNode)attributeSyntax, parameterIndex, unmanagedTypeName, (Microsoft.CodeAnalysis.AttributeData)attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(811, 3185, 3335);
                    return 0;
                }


                Microsoft.CodeAnalysis.MarshalPseudoCustomAttributeData
                f_811_3501_3571(TWellKnownAttributeData
                this_param)
                {
                    var return_v = this_param.GetOrCreateData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(811, 3501, 3571);
                    return return_v;
                }


                int
                f_811_3501_3609(Microsoft.CodeAnalysis.MarshalPseudoCustomAttributeData
                this_param, System.Runtime.InteropServices.UnmanagedType
                type)
                {
                    this_param.SetMarshalAsSimpleType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(811, 3501, 3609);
                    return 0;
                }


                int
                f_811_3945_4068(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, TAttributeSyntax
                attributeSyntax, int
                parameterIndex, TAttributeData
                attribute)
                {
                    this_param.ReportInvalidAttributeArgument(diagnostics, (Microsoft.CodeAnalysis.SyntaxNode)attributeSyntax, parameterIndex, (Microsoft.CodeAnalysis.AttributeData)attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(811, 3945, 4068);
                    return 0;
                }


                Microsoft.CodeAnalysis.MarshalPseudoCustomAttributeData
                f_811_4234_4304(TWellKnownAttributeData
                this_param)
                {
                    var return_v = this_param.GetOrCreateData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(811, 4234, 4304);
                    return return_v;
                }


                int
                f_811_4234_4342(Microsoft.CodeAnalysis.MarshalPseudoCustomAttributeData
                this_param, System.Runtime.InteropServices.UnmanagedType
                type)
                {
                    this_param.SetMarshalAsSimpleType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(811, 4234, 4342);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(811, 760, 4422);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(811, 760, 4422);
            }
        }

        private static UnmanagedType DecodeMarshalAsType(AttributeData attribute)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(811, 4434, 5054);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 4532, 4560);

                UnmanagedType
                unmanagedType
                = default(UnmanagedType);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 4574, 5006) || true) && (f_811_4578_4639(f_811_4578_4627(f_811_4578_4619(f_811_4578_4608(attribute))[0])) == SpecialType.System_Int16)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(811, 4574, 5006);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 4701, 4817);

                    unmanagedType = (UnmanagedType)f_811_4732_4768(attribute)[0].DecodeValue<short>(SpecialType.System_Int16);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(811, 4574, 5006);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(811, 4574, 5006);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 4883, 4991);

                    unmanagedType = f_811_4899_4935(attribute)[0].DecodeValue<UnmanagedType>(SpecialType.System_Enum);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(811, 4574, 5006);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 5022, 5043);

                return unmanagedType;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(811, 4434, 5054);

                Microsoft.CodeAnalysis.IMethodSymbol?
                f_811_4578_4608(Microsoft.CodeAnalysis.AttributeData
                this_param)
                {
                    var return_v = this_param.AttributeConstructor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(811, 4578, 4608);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IParameterSymbol>
                f_811_4578_4619(Microsoft.CodeAnalysis.IMethodSymbol?
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(811, 4578, 4619);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol
                f_811_4578_4627(Microsoft.CodeAnalysis.IParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(811, 4578, 4627);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_811_4578_4639(Microsoft.CodeAnalysis.ITypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(811, 4578, 4639);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_811_4732_4768(Microsoft.CodeAnalysis.AttributeData
                this_param)
                {
                    var return_v = this_param.CommonConstructorArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(811, 4732, 4768);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_811_4899_4935(Microsoft.CodeAnalysis.AttributeData
                this_param)
                {
                    var return_v = this_param.CommonConstructorArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(811, 4899, 4935);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(811, 4434, 5054);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(811, 4434, 5054);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void DecodeMarshalAsCustom(ref DecodeWellKnownAttributeArguments<TAttributeSyntax, TAttributeData, TAttributeLocation> arguments, CommonMessageProvider messageProvider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(811, 5066, 7877);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 5274, 5333);

                f_811_5274_5332((object)arguments.AttributeSyntaxOpt != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 5349, 5387);

                ITypeSymbolInternal
                typeSymbol = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 5401, 5424);

                string
                typeName = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 5438, 5459);

                string
                cookie = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 5473, 5498);

                bool
                hasTypeName = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 5512, 5539);

                bool
                hasTypeSymbol = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 5553, 5576);

                bool
                hasErrors = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 5592, 5609);

                int
                position = 1
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 5623, 7306);
                    foreach (var namedArg in f_811_5648_5682_I(f_811_5648_5682(arguments.Attribute)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(811, 5623, 7306);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 5716, 7260);

                        switch (namedArg.Key)
                        {

                            case "MarshalType":
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(811, 5716, 7260);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 5823, 5896);

                                typeName = namedArg.Value.DecodeValue<string>(SpecialType.System_String);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 5922, 6261) || true) && (!f_811_5927_5973(typeName))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(811, 5922, 6261);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 6031, 6187);

                                    f_811_6031_6186(messageProvider, arguments.Diagnostics, arguments.AttributeSyntaxOpt, position, f_811_6137_6171(arguments.Attribute), namedArg.Key);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 6217, 6234);

                                    hasErrors = true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(811, 5922, 6261);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 6289, 6308);

                                hasTypeName = true;
                                DynAbs.Tracing.TraceSender.TraceBreak(811, 6365, 6371);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(811, 5716, 7260);

                            case "MarshalTypeRef":
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(811, 5716, 7260);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 6443, 6522);

                                typeSymbol = namedArg.Value.DecodeValue<ITypeSymbolInternal>(SpecialType.None);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 6548, 6569);

                                hasTypeSymbol = true;
                                DynAbs.Tracing.TraceSender.TraceBreak(811, 6629, 6635);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(811, 5716, 7260);

                            case "MarshalCookie":
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(811, 5716, 7260);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 6706, 6777);

                                cookie = namedArg.Value.DecodeValue<string>(SpecialType.System_String);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 6803, 7140) || true) && (!f_811_6808_6852(cookie))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(811, 6803, 7140);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 6910, 7066);

                                    f_811_6910_7065(messageProvider, arguments.Diagnostics, arguments.AttributeSyntaxOpt, position, f_811_7016_7050(arguments.Attribute), namedArg.Key);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 7096, 7113);

                                    hasErrors = true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(811, 6803, 7140);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(811, 7168, 7174);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(811, 5716, 7260);
                                // other parameters ignored with no error
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 7280, 7291);

                        position++;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(811, 5623, 7306);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(811, 1, 1684);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(811, 1, 1684);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 7322, 7644) || true) && (!hasTypeName && (DynAbs.Tracing.TraceSender.Expression_True(811, 7326, 7356) && !hasTypeSymbol))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(811, 7322, 7644);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 7459, 7594);

                    f_811_7459_7593(                // MarshalType or MarshalTypeRef must be specified:
                                    messageProvider, arguments.Diagnostics, arguments.AttributeSyntaxOpt, "MarshalType", "MarshalTypeRef");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 7612, 7629);

                    hasErrors = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(811, 7322, 7644);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 7660, 7866) || true) && (!hasErrors)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(811, 7660, 7866);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 7708, 7851);

                    f_811_7708_7850(f_811_7708_7778(arguments.GetOrCreateData<TWellKnownAttributeData>()), (DynAbs.Tracing.TraceSender.Conditional_F1(811, 7798, 7809) || ((hasTypeName && DynAbs.Tracing.TraceSender.Conditional_F2(811, 7812, 7828)) || DynAbs.Tracing.TraceSender.Conditional_F3(811, 7831, 7841))) ? (object)typeName : typeSymbol, cookie);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(811, 7660, 7866);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(811, 5066, 7877);

                int
                f_811_5274_5332(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(811, 5274, 5332);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
                f_811_5648_5682(TAttributeData
                this_param)
                {
                    var return_v = this_param.NamedArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(811, 5648, 5682);
                    return return_v;
                }


                bool
                f_811_5927_5973(string?
                str)
                {
                    var return_v = MetadataHelpers.IsValidUnicodeString(str);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(811, 5927, 5973);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamedTypeSymbol?
                f_811_6137_6171(TAttributeData
                this_param)
                {
                    var return_v = this_param.AttributeClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(811, 6137, 6171);
                    return return_v;
                }


                int
                f_811_6031_6186(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, TAttributeSyntax
                attributeSyntax, int
                namedArgumentIndex, Microsoft.CodeAnalysis.INamedTypeSymbol?
                attributeClass, string
                parameterName)
                {
                    this_param.ReportInvalidNamedArgument(diagnostics, (Microsoft.CodeAnalysis.SyntaxNode)attributeSyntax, namedArgumentIndex, (Microsoft.CodeAnalysis.ITypeSymbol?)attributeClass, parameterName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(811, 6031, 6186);
                    return 0;
                }


                bool
                f_811_6808_6852(string?
                str)
                {
                    var return_v = MetadataHelpers.IsValidUnicodeString(str);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(811, 6808, 6852);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamedTypeSymbol?
                f_811_7016_7050(TAttributeData
                this_param)
                {
                    var return_v = this_param.AttributeClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(811, 7016, 7050);
                    return return_v;
                }


                int
                f_811_6910_7065(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, TAttributeSyntax
                attributeSyntax, int
                namedArgumentIndex, Microsoft.CodeAnalysis.INamedTypeSymbol?
                attributeClass, string
                parameterName)
                {
                    this_param.ReportInvalidNamedArgument(diagnostics, (Microsoft.CodeAnalysis.SyntaxNode)attributeSyntax, namedArgumentIndex, (Microsoft.CodeAnalysis.ITypeSymbol?)attributeClass, parameterName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(811, 6910, 7065);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
                f_811_5648_5682_I(System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(811, 5648, 5682);
                    return return_v;
                }


                int
                f_811_7459_7593(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, TAttributeSyntax
                attributeSyntax, string
                parameterName1, string
                parameterName2)
                {
                    this_param.ReportAttributeParameterRequired(diagnostics, (Microsoft.CodeAnalysis.SyntaxNode)attributeSyntax, parameterName1, parameterName2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(811, 7459, 7593);
                    return 0;
                }


                Microsoft.CodeAnalysis.MarshalPseudoCustomAttributeData
                f_811_7708_7778(TWellKnownAttributeData
                this_param)
                {
                    var return_v = this_param.GetOrCreateData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(811, 7708, 7778);
                    return return_v;
                }


                int
                f_811_7708_7850(Microsoft.CodeAnalysis.MarshalPseudoCustomAttributeData
                this_param, object?
                typeSymbolOrName, string?
                cookie)
                {
                    this_param.SetMarshalAsCustom(typeSymbolOrName, cookie);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(811, 7708, 7850);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(811, 5066, 7877);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(811, 5066, 7877);
            }
        }

        private static void DecodeMarshalAsComInterface(ref DecodeWellKnownAttributeArguments<TAttributeSyntax, TAttributeData, TAttributeLocation> arguments, UnmanagedType unmanagedType, CommonMessageProvider messageProvider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(811, 7889, 9389);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 8132, 8191);

                f_811_8132_8190((object)arguments.AttributeSyntaxOpt != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 8207, 8234);

                int?
                parameterIndex = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 8248, 8265);

                int
                position = 1
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 8279, 8302);

                bool
                hasErrors = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 8318, 9172);
                    foreach (var namedArg in f_811_8343_8377_I(f_811_8343_8377(arguments.Attribute)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(811, 8318, 9172);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 8411, 9126);

                        switch (namedArg.Key)
                        {

                            case "IidParameterIndex":
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(811, 8411, 9126);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 8524, 8599);

                                parameterIndex = namedArg.Value.DecodeValue<int>(SpecialType.System_Int32);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 8625, 9006) || true) && (parameterIndex < 0 || (DynAbs.Tracing.TraceSender.Expression_False(811, 8629, 8718) || parameterIndex > MarshalPseudoCustomAttributeData.MaxMarshalInteger))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(811, 8625, 9006);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 8776, 8932);

                                    f_811_8776_8931(messageProvider, arguments.Diagnostics, arguments.AttributeSyntaxOpt, position, f_811_8882_8916(arguments.Attribute), namedArg.Key);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 8962, 8979);

                                    hasErrors = true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(811, 8625, 9006);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(811, 9034, 9040);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(811, 8411, 9126);
                                // other parameters ignored with no error
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 9146, 9157);

                        position++;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(811, 8318, 9172);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(811, 1, 855);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(811, 1, 855);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 9188, 9378) || true) && (!hasErrors)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(811, 9188, 9378);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 9236, 9363);

                    f_811_9236_9362(f_811_9236_9306(arguments.GetOrCreateData<TWellKnownAttributeData>()), unmanagedType, parameterIndex);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(811, 9188, 9378);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(811, 7889, 9389);

                int
                f_811_8132_8190(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(811, 8132, 8190);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
                f_811_8343_8377(TAttributeData
                this_param)
                {
                    var return_v = this_param.NamedArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(811, 8343, 8377);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamedTypeSymbol?
                f_811_8882_8916(TAttributeData
                this_param)
                {
                    var return_v = this_param.AttributeClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(811, 8882, 8916);
                    return return_v;
                }


                int
                f_811_8776_8931(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, TAttributeSyntax
                attributeSyntax, int
                namedArgumentIndex, Microsoft.CodeAnalysis.INamedTypeSymbol?
                attributeClass, string
                parameterName)
                {
                    this_param.ReportInvalidNamedArgument(diagnostics, (Microsoft.CodeAnalysis.SyntaxNode)attributeSyntax, namedArgumentIndex, (Microsoft.CodeAnalysis.ITypeSymbol?)attributeClass, parameterName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(811, 8776, 8931);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
                f_811_8343_8377_I(System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(811, 8343, 8377);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MarshalPseudoCustomAttributeData
                f_811_9236_9306(TWellKnownAttributeData
                this_param)
                {
                    var return_v = this_param.GetOrCreateData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(811, 9236, 9306);
                    return return_v;
                }


                int
                f_811_9236_9362(Microsoft.CodeAnalysis.MarshalPseudoCustomAttributeData
                this_param, System.Runtime.InteropServices.UnmanagedType
                unmanagedType, int?
                parameterIndex)
                {
                    this_param.SetMarshalAsComInterface(unmanagedType, parameterIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(811, 9236, 9362);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(811, 7889, 9389);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(811, 7889, 9389);
            }
        }

        private static void DecodeMarshalAsArray(ref DecodeWellKnownAttributeArguments<TAttributeSyntax, TAttributeData, TAttributeLocation> arguments, CommonMessageProvider messageProvider, bool isFixed)
        {
            Debug.Assert((object)arguments.AttributeSyntaxOpt != null);

            UnmanagedType? elementType = null;
            int? elementCount = isFixed ? 1 : (int?)null;
            short? parameterIndex = null;
            bool hasErrors = false;

            int position = 1;
            foreach (var namedArg in arguments.Attribute.NamedArguments)
            {
                switch (namedArg.Key)
                {
                    // array:
                    case "ArraySubType":
                        elementType = namedArg.Value.DecodeValue<UnmanagedType>(SpecialType.System_Enum);

                        // for some reason, Dev10 metadata writer disallows CustomMarshaler type as an element type of non-fixed arrays
                        if (!isFixed && elementType == Cci.Constants.UnmanagedType_CustomMarshaler ||
                            (int)elementType < 0 ||
                            (int)elementType > MarshalPseudoCustomAttributeData.MaxMarshalInteger)
                        {
                            messageProvider.ReportInvalidNamedArgument(arguments.Diagnostics, arguments.AttributeSyntaxOpt, position, arguments.Attribute.AttributeClass, namedArg.Key);
                            hasErrors = true;
                        }

                        break;

                    case "SizeConst":
                        elementCount = namedArg.Value.DecodeValue<int>(SpecialType.System_Int32);
                        if (elementCount < 0 || elementCount > MarshalPseudoCustomAttributeData.MaxMarshalInteger)
                        {
                            messageProvider.ReportInvalidNamedArgument(arguments.Diagnostics, arguments.AttributeSyntaxOpt, position, arguments.Attribute.AttributeClass, namedArg.Key);
                            hasErrors = true;
                        }

                        break;

                    case "SizeParamIndex":
                        if (isFixed)
                        {
                            goto case "SafeArraySubType";
                        }

                        parameterIndex = namedArg.Value.DecodeValue<short>(SpecialType.System_Int16);
                        if (parameterIndex < 0)
                        {
                            messageProvider.ReportInvalidNamedArgument(arguments.Diagnostics, arguments.AttributeSyntaxOpt, position, arguments.Attribute.AttributeClass, namedArg.Key);
                            hasErrors = true;
                        }

                        break;

                    case "SafeArraySubType":
                        messageProvider.ReportParameterNotValidForType(arguments.Diagnostics, arguments.AttributeSyntaxOpt, position);
                        hasErrors = true;
                        break;
                        // other parameters ignored with no error
                }

                position++;
            }

            if (!hasErrors)
            {
                var data = arguments.GetOrCreateData<TWellKnownAttributeData>().GetOrCreateData();
                if (isFixed)
                {
                    data.SetMarshalAsFixedArray(elementType, elementCount);
                }
                else
                {
                    data.SetMarshalAsArray(elementType, elementCount, parameterIndex);
                }
            }
        }

        private static void DecodeMarshalAsSafeArray(ref DecodeWellKnownAttributeArguments<TAttributeSyntax, TAttributeData, TAttributeLocation> arguments, CommonMessageProvider messageProvider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(811, 13063, 16107);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 13274, 13333);

                f_811_13274_13332((object)arguments.AttributeSyntaxOpt != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 13349, 13388);

                Cci.VarEnum?
                elementTypeVariant = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 13402, 13447);

                ITypeSymbolInternal
                elementTypeSymbol = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 13461, 13482);

                int
                symbolIndex = -1
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 13496, 13519);

                bool
                hasErrors = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 13535, 13552);

                int
                position = 1
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 13566, 15033);
                    foreach (var namedArg in f_811_13591_13625_I(f_811_13591_13625(arguments.Attribute)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(811, 13566, 15033);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 13659, 14987);

                        switch (namedArg.Key)
                        {

                            case "SafeArraySubType":
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(811, 13659, 14987);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 13771, 13857);

                                elementTypeVariant = namedArg.Value.DecodeValue<Cci.VarEnum>(SpecialType.System_Enum);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 13883, 14277) || true) && (elementTypeVariant < 0 || (DynAbs.Tracing.TraceSender.Expression_False(811, 13887, 13989) || (int)elementTypeVariant > MarshalPseudoCustomAttributeData.MaxMarshalInteger))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(811, 13883, 14277);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 14047, 14203);

                                    f_811_14047_14202(messageProvider, arguments.Diagnostics, arguments.AttributeSyntaxOpt, position, f_811_14153_14187(arguments.Attribute), namedArg.Key);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 14233, 14250);

                                    hasErrors = true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(811, 13883, 14277);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(811, 14305, 14311);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(811, 13659, 14987);

                            case "SafeArrayUserDefinedSubType":
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(811, 13659, 14987);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 14396, 14482);

                                elementTypeSymbol = namedArg.Value.DecodeValue<ITypeSymbolInternal>(SpecialType.None);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 14508, 14531);

                                symbolIndex = position;
                                DynAbs.Tracing.TraceSender.TraceBreak(811, 14557, 14563);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(811, 13659, 14987);

                            case "ArraySubType":
                            case "SizeConst":
                            case "SizeParamIndex":
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(811, 13659, 14987);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 14716, 14826);

                                f_811_14716_14825(messageProvider, arguments.Diagnostics, arguments.AttributeSyntaxOpt, position);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 14852, 14869);

                                hasErrors = true;
                                DynAbs.Tracing.TraceSender.TraceBreak(811, 14895, 14901);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(811, 13659, 14987);
                                // other parameters ignored with no error
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 15007, 15018);

                        position++;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(811, 13566, 15033);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(811, 1, 1468);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(811, 1, 1468);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 15049, 15885);

                switch (elementTypeVariant)
                {

                    case Cci.VarEnum.VT_DISPATCH:
                    case Cci.VarEnum.VT_UNKNOWN:
                    case Cci.VarEnum.VT_RECORD:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(811, 15049, 15885);
                        DynAbs.Tracing.TraceSender.TraceBreak(811, 15340, 15346);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(811, 15049, 15885);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(811, 15049, 15885);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 15396, 15840) || true) && (elementTypeVariant != null && (DynAbs.Tracing.TraceSender.Expression_True(811, 15400, 15446) && symbolIndex >= 0))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(811, 15396, 15840);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 15496, 15609);

                            f_811_15496_15608(messageProvider, arguments.Diagnostics, arguments.AttributeSyntaxOpt, symbolIndex);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 15635, 15652);

                            hasErrors = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(811, 15396, 15840);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(811, 15396, 15840);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 15792, 15817);

                            elementTypeSymbol = null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(811, 15396, 15840);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(811, 15864, 15870);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(811, 15049, 15885);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 15901, 16096) || true) && (!hasErrors)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(811, 15901, 16096);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 15949, 16081);

                    f_811_15949_16080(f_811_15949_16019(arguments.GetOrCreateData<TWellKnownAttributeData>()), elementTypeVariant, elementTypeSymbol);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(811, 15901, 16096);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(811, 13063, 16107);

                int
                f_811_13274_13332(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(811, 13274, 13332);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
                f_811_13591_13625(TAttributeData
                this_param)
                {
                    var return_v = this_param.NamedArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(811, 13591, 13625);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamedTypeSymbol?
                f_811_14153_14187(TAttributeData
                this_param)
                {
                    var return_v = this_param.AttributeClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(811, 14153, 14187);
                    return return_v;
                }


                int
                f_811_14047_14202(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, TAttributeSyntax
                attributeSyntax, int
                namedArgumentIndex, Microsoft.CodeAnalysis.INamedTypeSymbol?
                attributeClass, string
                parameterName)
                {
                    this_param.ReportInvalidNamedArgument(diagnostics, (Microsoft.CodeAnalysis.SyntaxNode)attributeSyntax, namedArgumentIndex, (Microsoft.CodeAnalysis.ITypeSymbol?)attributeClass, parameterName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(811, 14047, 14202);
                    return 0;
                }


                int
                f_811_14716_14825(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, TAttributeSyntax
                attributeSyntax, int
                namedArgumentIndex)
                {
                    this_param.ReportParameterNotValidForType(diagnostics, (Microsoft.CodeAnalysis.SyntaxNode)attributeSyntax, namedArgumentIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(811, 14716, 14825);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
                f_811_13591_13625_I(System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(811, 13591, 13625);
                    return return_v;
                }


                int
                f_811_15496_15608(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, TAttributeSyntax
                attributeSyntax, int
                namedArgumentIndex)
                {
                    this_param.ReportParameterNotValidForType(diagnostics, (Microsoft.CodeAnalysis.SyntaxNode)attributeSyntax, namedArgumentIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(811, 15496, 15608);
                    return 0;
                }


                Microsoft.CodeAnalysis.MarshalPseudoCustomAttributeData
                f_811_15949_16019(TWellKnownAttributeData
                this_param)
                {
                    var return_v = this_param.GetOrCreateData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(811, 15949, 16019);
                    return return_v;
                }


                int
                f_811_15949_16080(Microsoft.CodeAnalysis.MarshalPseudoCustomAttributeData
                this_param, Microsoft.Cci.VarEnum?
                elementType, Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal?
                elementTypeSymbol)
                {
                    this_param.SetMarshalAsSafeArray(elementType, elementTypeSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(811, 15949, 16080);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(811, 13063, 16107);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(811, 13063, 16107);
            }
        }

        private static void DecodeMarshalAsFixedString(ref DecodeWellKnownAttributeArguments<TAttributeSyntax, TAttributeData, TAttributeLocation> arguments, CommonMessageProvider messageProvider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(811, 16119, 18135);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 16332, 16391);

                f_811_16332_16390((object)arguments.AttributeSyntaxOpt != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 16407, 16429);

                int
                elementCount = -1
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 16443, 16460);

                int
                position = 1
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 16474, 16497);

                bool
                hasErrors = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 16513, 17652);
                    foreach (var namedArg in f_811_16538_16572_I(f_811_16538_16572(arguments.Attribute)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(811, 16513, 17652);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 16606, 17606);

                        switch (namedArg.Key)
                        {

                            case "SizeConst":
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(811, 16606, 17606);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 16711, 16784);

                                elementCount = namedArg.Value.DecodeValue<int>(SpecialType.System_Int32);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 16810, 17187) || true) && (elementCount < 0 || (DynAbs.Tracing.TraceSender.Expression_False(811, 16814, 16899) || elementCount > MarshalPseudoCustomAttributeData.MaxMarshalInteger))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(811, 16810, 17187);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 16957, 17113);

                                    f_811_16957_17112(messageProvider, arguments.Diagnostics, arguments.AttributeSyntaxOpt, position, f_811_17063_17097(arguments.Attribute), namedArg.Key);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 17143, 17160);

                                    hasErrors = true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(811, 16810, 17187);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(811, 17215, 17221);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(811, 16606, 17606);

                            case "ArraySubType":
                            case "SizeParamIndex":
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(811, 16606, 17606);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 17335, 17445);

                                f_811_17335_17444(messageProvider, arguments.Diagnostics, arguments.AttributeSyntaxOpt, position);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 17471, 17488);

                                hasErrors = true;
                                DynAbs.Tracing.TraceSender.TraceBreak(811, 17514, 17520);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(811, 16606, 17606);
                                // other parameters ignored with no error
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 17626, 17637);

                        position++;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(811, 16513, 17652);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(811, 1, 1140);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(811, 1, 1140);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 17668, 17936) || true) && (elementCount < 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(811, 17668, 17936);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 17771, 17886);

                    f_811_17771_17885(                // SizeConst must be specified:
                                    messageProvider, arguments.Diagnostics, arguments.AttributeSyntaxOpt, "SizeConst");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 17904, 17921);

                    hasErrors = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(811, 17668, 17936);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 17952, 18124) || true) && (!hasErrors)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(811, 17952, 18124);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(811, 18000, 18109);

                    f_811_18000_18108(f_811_18000_18070(arguments.GetOrCreateData<TWellKnownAttributeData>()), elementCount);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(811, 17952, 18124);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(811, 16119, 18135);

                int
                f_811_16332_16390(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(811, 16332, 16390);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
                f_811_16538_16572(TAttributeData
                this_param)
                {
                    var return_v = this_param.NamedArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(811, 16538, 16572);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamedTypeSymbol?
                f_811_17063_17097(TAttributeData
                this_param)
                {
                    var return_v = this_param.AttributeClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(811, 17063, 17097);
                    return return_v;
                }


                int
                f_811_16957_17112(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, TAttributeSyntax
                attributeSyntax, int
                namedArgumentIndex, Microsoft.CodeAnalysis.INamedTypeSymbol?
                attributeClass, string
                parameterName)
                {
                    this_param.ReportInvalidNamedArgument(diagnostics, (Microsoft.CodeAnalysis.SyntaxNode)attributeSyntax, namedArgumentIndex, (Microsoft.CodeAnalysis.ITypeSymbol?)attributeClass, parameterName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(811, 16957, 17112);
                    return 0;
                }


                int
                f_811_17335_17444(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, TAttributeSyntax
                attributeSyntax, int
                namedArgumentIndex)
                {
                    this_param.ReportParameterNotValidForType(diagnostics, (Microsoft.CodeAnalysis.SyntaxNode)attributeSyntax, namedArgumentIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(811, 17335, 17444);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
                f_811_16538_16572_I(System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(811, 16538, 16572);
                    return return_v;
                }


                int
                f_811_17771_17885(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, TAttributeSyntax
                attributeSyntax, string
                parameterName)
                {
                    this_param.ReportAttributeParameterRequired(diagnostics, (Microsoft.CodeAnalysis.SyntaxNode)attributeSyntax, parameterName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(811, 17771, 17885);
                    return 0;
                }


                Microsoft.CodeAnalysis.MarshalPseudoCustomAttributeData
                f_811_18000_18070(TWellKnownAttributeData
                this_param)
                {
                    var return_v = this_param.GetOrCreateData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(811, 18000, 18070);
                    return return_v;
                }


                int
                f_811_18000_18108(Microsoft.CodeAnalysis.MarshalPseudoCustomAttributeData
                this_param, int
                elementCount)
                {
                    this_param.SetMarshalAsFixedString(elementCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(811, 18000, 18108);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(811, 16119, 18135);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(811, 16119, 18135);
            }
        }

        static MarshalAsAttributeDecoder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(811, 428, 18142);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(811, 428, 18142);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(811, 428, 18142);
        }
    }
}
