// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal class SourceComplexParameterSymbol : SourceParameterSymbol, IAttributeTargetSymbol
    {
        [Flags]
        private enum ParameterSyntaxKind : byte
        {
            Regular = 0,
            ParamsParameter = 1,
            ExtensionThisParameter = 2,
            DefaultParameter = 4,
        }

        private readonly SyntaxReference _syntaxRef;

        private readonly ParameterSyntaxKind _parameterSyntaxKind;

        private CustomAttributesBag<CSharpAttributeData> _lazyCustomAttributesBag;

        private ThreeState _lazyHasOptionalAttribute;

        protected ConstantValue _lazyDefaultSyntaxValue;

        internal SourceComplexParameterSymbol(
                    Symbol owner,
                    int ordinal,
                    TypeWithAnnotations parameterType,
                    RefKind refKind,
                    string name,
                    ImmutableArray<Location> locations,
                    SyntaxReference syntaxRef,
                    bool isParams,
                    bool isExtensionMethodThis)
        : base(f_10240_1666_1671_C(owner), parameterType, ordinal, refKind, name, locations)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10240, 1292, 2658);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 1002, 1012);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 1060, 1080);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 1142, 1166);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 1196, 1221);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 1256, 1279);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 1747, 1837);

                f_10240_1747_1836((syntaxRef == null) || (DynAbs.Tracing.TraceSender.Expression_False(10240, 1760, 1835) || (f_10240_1784_1834(f_10240_1784_1805(syntaxRef), SyntaxKind.Parameter))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 1851, 1890);

                f_10240_1851_1889(!(owner is LambdaSymbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 1961, 2008);

                _lazyHasOptionalAttribute = ThreeState.Unknown;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 2022, 2045);

                _syntaxRef = syntaxRef;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 2061, 2182) || true) && (isParams)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 2061, 2182);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 2107, 2167);

                    _parameterSyntaxKind |= ParameterSyntaxKind.ParamsParameter;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 2061, 2182);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 2198, 2339) || true) && (isExtensionMethodThis)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 2198, 2339);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 2257, 2324);

                    _parameterSyntaxKind |= ParameterSyntaxKind.ExtensionThisParameter;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 2198, 2339);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 2355, 2399);

                var
                parameterSyntax = f_10240_2377_2398(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 2413, 2585) || true) && (parameterSyntax != null && (DynAbs.Tracing.TraceSender.Expression_True(10240, 2417, 2475) && f_10240_2444_2467(parameterSyntax) != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 2413, 2585);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 2509, 2570);

                    _parameterSyntaxKind |= ParameterSyntaxKind.DefaultParameter;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 2413, 2585);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 2601, 2647);

                _lazyDefaultSyntaxValue = f_10240_2627_2646();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10240, 1292, 2658);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10240, 1292, 2658);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10240, 1292, 2658);
            }
        }

        private Binder ParameterBinderOpt
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10240, 2723, 2832);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 2726, 2832);
                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10240, 2726, 2767) || (((f_10240_2727_2743() is LocalFunctionSymbol) && DynAbs.Tracing.TraceSender.Conditional_F2(10240, 2770, 2825)) || DynAbs.Tracing.TraceSender.Conditional_F3(10240, 2828, 2832))) ? f_10240_2770_2825(((LocalFunctionSymbol)f_10240_2792_2808())) : null; DynAbs.Tracing.TraceSender.TraceExitMethod(10240, 2723, 2832);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10240, 2723, 2832);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10240, 2723, 2832);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override SyntaxReference SyntaxReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10240, 2895, 2908);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 2898, 2908);
                    return _syntaxRef; DynAbs.Tracing.TraceSender.TraceExitMethod(10240, 2895, 2908);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10240, 2895, 2908);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10240, 2895, 2908);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal ParameterSyntax CSharpSyntaxNode
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10240, 2963, 3006);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 2966, 3006);
                    return (ParameterSyntax)f_10240_2983_3006_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_syntaxRef, 10240, 2983, 3006)?.GetSyntax()); DynAbs.Tracing.TraceSender.TraceExitMethod(10240, 2963, 3006);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10240, 2963, 3006);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10240, 2963, 3006);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool IsDiscard
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10240, 3057, 3065);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 3060, 3065);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10240, 3057, 3065);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10240, 3057, 3065);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10240, 3057, 3065);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ConstantValue ExplicitDefaultConstantValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10240, 3163, 4015);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 3944, 4000);

                    return f_10240_3951_3969() ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.ConstantValue>(10240, 3951, 3999) ?? f_10240_3973_3999());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10240, 3163, 4015);

                    Microsoft.CodeAnalysis.ConstantValue
                    f_10240_3951_3969()
                    {
                        var return_v = DefaultSyntaxValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 3951, 3969);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConstantValue
                    f_10240_3973_3999()
                    {
                        var return_v = DefaultValueFromAttributes;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 3973, 3999);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10240, 3078, 4026);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10240, 3078, 4026);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ConstantValue DefaultValueFromAttributes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10240, 4121, 4407);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 4157, 4241);

                    ParameterEarlyWellKnownAttributeData
                    data = f_10240_4201_4240(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 4259, 4392);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10240, 4266, 4333) || (((data != null && (DynAbs.Tracing.TraceSender.Expression_True(10240, 4267, 4332) && f_10240_4283_4309(data) != f_10240_4313_4332())) && DynAbs.Tracing.TraceSender.Conditional_F2(10240, 4336, 4362)) || DynAbs.Tracing.TraceSender.Conditional_F3(10240, 4365, 4391))) ? f_10240_4336_4362(data) : ConstantValue.NotAvailable;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10240, 4121, 4407);

                    Microsoft.CodeAnalysis.CSharp.Symbols.ParameterEarlyWellKnownAttributeData
                    f_10240_4201_4240(Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.GetEarlyDecodedWellKnownAttributeData();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 4201, 4240);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConstantValue
                    f_10240_4283_4309(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterEarlyWellKnownAttributeData
                    this_param)
                    {
                        var return_v = this_param.DefaultParameterValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 4283, 4309);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConstantValue
                    f_10240_4313_4332()
                    {
                        var return_v = ConstantValue.Unset;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 4313, 4332);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConstantValue
                    f_10240_4336_4362(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterEarlyWellKnownAttributeData
                    this_param)
                    {
                        var return_v = this_param.DefaultParameterValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 4336, 4362);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10240, 4038, 4418);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10240, 4038, 4418);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsIDispatchConstant
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10240, 4486, 4562);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 4489, 4562);
                    return f_10240_4489_4554_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10240_4489_4523(this), 10240, 4489, 4554)?.HasIDispatchConstantAttribute) == true; DynAbs.Tracing.TraceSender.TraceExitMethod(10240, 4486, 4562);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10240, 4486, 4562);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10240, 4486, 4562);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsIUnknownConstant
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10240, 4630, 4705);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 4633, 4705);
                    return f_10240_4633_4697_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10240_4633_4667(this), 10240, 4633, 4697)?.HasIUnknownConstantAttribute) == true; DynAbs.Tracing.TraceSender.TraceExitMethod(10240, 4630, 4705);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10240, 4630, 4705);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10240, 4630, 4705);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private bool HasCallerLineNumberAttribute
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10240, 4773, 4853);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 4776, 4853);
                    return f_10240_4776_4845_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10240_4776_4815(this), 10240, 4776, 4845)?.HasCallerLineNumberAttribute) == true; DynAbs.Tracing.TraceSender.TraceExitMethod(10240, 4773, 4853);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10240, 4773, 4853);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10240, 4773, 4853);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private bool HasCallerFilePathAttribute
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10240, 4919, 4997);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 4922, 4997);
                    return f_10240_4922_4989_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10240_4922_4961(this), 10240, 4922, 4989)?.HasCallerFilePathAttribute) == true; DynAbs.Tracing.TraceSender.TraceExitMethod(10240, 4919, 4997);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10240, 4919, 4997);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10240, 4919, 4997);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private bool HasCallerMemberNameAttribute
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10240, 5065, 5145);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 5068, 5145);
                    return f_10240_5068_5137_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10240_5068_5107(this), 10240, 5068, 5137)?.HasCallerMemberNameAttribute) == true; DynAbs.Tracing.TraceSender.TraceExitMethod(10240, 5065, 5145);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10240, 5065, 5145);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10240, 5065, 5145);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsCallerLineNumber
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10240, 5200, 5231);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 5203, 5231);
                    return f_10240_5203_5231(); DynAbs.Tracing.TraceSender.TraceExitMethod(10240, 5200, 5231);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10240, 5200, 5231);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10240, 5200, 5231);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsCallerFilePath
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10240, 5284, 5346);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 5287, 5346);
                    return f_10240_5287_5316_M(!HasCallerLineNumberAttribute) && (DynAbs.Tracing.TraceSender.Expression_True(10240, 5287, 5346) && f_10240_5320_5346()); DynAbs.Tracing.TraceSender.TraceExitMethod(10240, 5284, 5346);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10240, 5284, 5346);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10240, 5284, 5346);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsCallerMemberName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10240, 5401, 5598);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 5404, 5598);
                    return f_10240_5404_5433_M(!HasCallerLineNumberAttribute) && (DynAbs.Tracing.TraceSender.Expression_True(10240, 5404, 5515) && f_10240_5488_5515_M(!HasCallerFilePathAttribute)) && (DynAbs.Tracing.TraceSender.Expression_True(10240, 5404, 5598) && f_10240_5570_5598()); DynAbs.Tracing.TraceSender.TraceExitMethod(10240, 5401, 5598);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10240, 5401, 5598);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10240, 5401, 5598);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override FlowAnalysisAnnotations FlowAnalysisAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10240, 5701, 5824);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 5737, 5809);

                    return f_10240_5744_5808(f_10240_5773_5807(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10240, 5701, 5824);

                    Microsoft.CodeAnalysis.CSharp.Symbols.ParameterWellKnownAttributeData
                    f_10240_5773_5807(Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.GetDecodedWellKnownAttributeData();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 5773, 5807);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.FlowAnalysisAnnotations
                    f_10240_5744_5808(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterWellKnownAttributeData
                    attributeData)
                    {
                        var return_v = DecodeFlowAnalysisAttributes(attributeData);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 5744, 5808);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10240, 5611, 5835);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10240, 5611, 5835);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static FlowAnalysisAnnotations DecodeFlowAnalysisAttributes(ParameterWellKnownAttributeData attributeData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10240, 5847, 7560);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 5986, 6096) || true) && (attributeData == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 5986, 6096);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 6045, 6081);

                    return FlowAnalysisAnnotations.None;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 5986, 6096);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 6110, 6177);

                FlowAnalysisAnnotations
                annotations = FlowAnalysisAnnotations.None
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 6191, 6281) || true) && (f_10240_6195_6230(attributeData))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 6191, 6281);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 6232, 6281);

                    annotations |= FlowAnalysisAnnotations.AllowNull;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 6191, 6281);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 6295, 6391) || true) && (f_10240_6299_6337(attributeData))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 6295, 6391);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 6339, 6391);

                    annotations |= FlowAnalysisAnnotations.DisallowNull;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 6295, 6391);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 6407, 6835) || true) && (f_10240_6411_6446(attributeData))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 6407, 6835);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 6480, 6529);

                    annotations |= FlowAnalysisAnnotations.MaybeNull;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 6407, 6835);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 6407, 6835);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 6595, 6820) || true) && (f_10240_6599_6635(attributeData) is bool when)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 6595, 6820);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 6690, 6801);

                        annotations |= ((DynAbs.Tracing.TraceSender.Conditional_F1(10240, 6706, 6710) || ((when && DynAbs.Tracing.TraceSender.Conditional_F2(10240, 6713, 6754)) || DynAbs.Tracing.TraceSender.Conditional_F3(10240, 6757, 6799))) ? FlowAnalysisAnnotations.MaybeNullWhenTrue : FlowAnalysisAnnotations.MaybeNullWhenFalse);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 6595, 6820);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 6407, 6835);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 6851, 7269) || true) && (f_10240_6855_6888(attributeData))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 6851, 7269);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 6922, 6969);

                    annotations |= FlowAnalysisAnnotations.NotNull;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 6851, 7269);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 6851, 7269);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 7035, 7254) || true) && (f_10240_7039_7073(attributeData) is bool when)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 7035, 7254);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 7128, 7235);

                        annotations |= ((DynAbs.Tracing.TraceSender.Conditional_F1(10240, 7144, 7148) || ((when && DynAbs.Tracing.TraceSender.Conditional_F2(10240, 7151, 7190)) || DynAbs.Tracing.TraceSender.Conditional_F3(10240, 7193, 7233))) ? FlowAnalysisAnnotations.NotNullWhenTrue : FlowAnalysisAnnotations.NotNullWhenFalse);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 7035, 7254);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 6851, 7269);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 7285, 7514) || true) && (f_10240_7289_7327(attributeData) is bool condition)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 7285, 7514);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 7379, 7499);

                    annotations |= ((DynAbs.Tracing.TraceSender.Conditional_F1(10240, 7395, 7404) || ((condition && DynAbs.Tracing.TraceSender.Conditional_F2(10240, 7407, 7450)) || DynAbs.Tracing.TraceSender.Conditional_F3(10240, 7453, 7497))) ? FlowAnalysisAnnotations.DoesNotReturnIfTrue : FlowAnalysisAnnotations.DoesNotReturnIfFalse);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 7285, 7514);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 7530, 7549);

                return annotations;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10240, 5847, 7560);

                bool
                f_10240_6195_6230(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterWellKnownAttributeData
                this_param)
                {
                    var return_v = this_param.HasAllowNullAttribute;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 6195, 6230);
                    return return_v;
                }


                bool
                f_10240_6299_6337(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterWellKnownAttributeData
                this_param)
                {
                    var return_v = this_param.HasDisallowNullAttribute;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 6299, 6337);
                    return return_v;
                }


                bool
                f_10240_6411_6446(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterWellKnownAttributeData
                this_param)
                {
                    var return_v = this_param.HasMaybeNullAttribute;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 6411, 6446);
                    return return_v;
                }


                bool?
                f_10240_6599_6635(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterWellKnownAttributeData
                this_param)
                {
                    var return_v = this_param.MaybeNullWhenAttribute;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 6599, 6635);
                    return return_v;
                }


                bool
                f_10240_6855_6888(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterWellKnownAttributeData
                this_param)
                {
                    var return_v = this_param.HasNotNullAttribute;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 6855, 6888);
                    return return_v;
                }


                bool?
                f_10240_7039_7073(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterWellKnownAttributeData
                this_param)
                {
                    var return_v = this_param.NotNullWhenAttribute;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 7039, 7073);
                    return return_v;
                }


                bool?
                f_10240_7289_7327(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterWellKnownAttributeData
                this_param)
                {
                    var return_v = this_param.DoesNotReturnIfAttribute;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 7289, 7327);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10240, 5847, 7560);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10240, 5847, 7560);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableHashSet<string> NotNullIfParameterNotNull
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10240, 7654, 7752);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 7657, 7752);
                    return f_10240_7657_7718_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10240_7657_7691(this), 10240, 7657, 7718)?.NotNullIfParameterNotNull) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Immutable.ImmutableHashSet<string>?>(10240, 7657, 7752) ?? ImmutableHashSet<string>.Empty); DynAbs.Tracing.TraceSender.TraceExitMethod(10240, 7654, 7752);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10240, 7654, 7752);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10240, 7654, 7752);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool HasEnumeratorCancellationAttribute
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10240, 7838, 8055);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 7874, 7957);

                    ParameterWellKnownAttributeData
                    attributeData = f_10240_7922_7956(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 7975, 8040);

                    return f_10240_7982_8031_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(attributeData, 10240, 7982, 8031)?.HasEnumeratorCancellationAttribute) == true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10240, 7838, 8055);

                    Microsoft.CodeAnalysis.CSharp.Symbols.ParameterWellKnownAttributeData
                    f_10240_7922_7956(Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.GetDecodedWellKnownAttributeData();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 7922, 7956);
                        return return_v;
                    }


                    bool?
                    f_10240_7982_8031_M(bool?
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 7982, 8031);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10240, 7765, 8066);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10240, 7765, 8066);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static SyntaxNode? GetDefaultValueSyntaxForIsNullableAnalysisEnabled(ParameterSyntax? parameterSyntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10240, 8210, 8393);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 8296, 8393);
                return (DynAbs.Tracing.TraceSender.Conditional_F1(10240, 8296, 8354) || ((            // LAFHIS
                                                                                                      //parameterSyntax?.Default?.Value
                            parameterSyntax != null && (DynAbs.Tracing.TraceSender.Expression_True(10240, 8296, 8354) && f_10240_8323_8346(parameterSyntax) != null) && DynAbs.Tracing.TraceSender.Conditional_F2(10240, 8357, 8386)) || DynAbs.Tracing.TraceSender.Conditional_F3(10240, 8389, 8393))) ? f_10240_8357_8386(f_10240_8357_8380(parameterSyntax)) : null; DynAbs.Tracing.TraceSender.TraceExitMethod(10240, 8210, 8393);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10240, 8210, 8393);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10240, 8210, 8393);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax?
            f_10240_8323_8346(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
            this_param)
            {
                var return_v = this_param.Default;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 8323, 8346);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax
            f_10240_8357_8380(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
            this_param)
            {
                var return_v = this_param.Default;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 8357, 8380);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
            f_10240_8357_8386(Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 8357, 8386);
                return return_v;
            }

        }

        private ConstantValue DefaultSyntaxValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10240, 8471, 10366);
                    Microsoft.CodeAnalysis.CSharp.Binder? binder = default(Microsoft.CodeAnalysis.CSharp.Binder?);
                    Microsoft.CodeAnalysis.CSharp.BoundParameterEqualsValue? parameterEqualsValue = default(Microsoft.CodeAnalysis.CSharp.BoundParameterEqualsValue?);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 8507, 10193) || true) && (state.NotePartComplete(CompletionPart.StartDefaultSyntaxValue))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 8507, 10193);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 8615, 8661);

                        var
                        diagnostics = f_10240_8633_8660()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 8683, 8939);

                        var
                        previousValue = f_10240_8703_8938(ref _lazyDefaultSyntaxValue, f_10240_8811_8891(this, diagnostics, out binder, out parameterEqualsValue), f_10240_8918_8937())
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 8961, 9012);

                        f_10240_8961_9011(previousValue == f_10240_8991_9010());
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 9036, 9125);

                        var
                        completedOnThisThread = state.NotePartComplete(CompletionPart.EndDefaultSyntaxValue)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 9147, 9183);

                        f_10240_9147_9182(completedOnThisThread);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 9207, 9892) || true) && (parameterEqualsValue is not null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 9207, 9892);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 9293, 9606) || true) && (binder is not null && (DynAbs.Tracing.TraceSender.Expression_True(10240, 9297, 9434) && f_10240_9348_9415(f_10240_9398_9414()) is { } valueSyntax))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 9293, 9606);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 9492, 9579);

                                f_10240_9492_9578(binder, parameterEqualsValue, valueSyntax, diagnostics);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 9293, 9606);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 9632, 9869) || true) && (f_10240_9636_9666_M(!_lazyDefaultSyntaxValue.IsBad))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 9632, 9869);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 9724, 9842);

                                f_10240_9724_9841(this, _lazyDefaultSyntaxValue, f_10240_9794_9820(parameterEqualsValue).Syntax, diagnostics);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 9632, 9869);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 9207, 9892);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 9916, 9955);

                        f_10240_9916_9954(this, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 9977, 9996);

                        f_10240_9977_9995(diagnostics);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 10020, 10116);

                        completedOnThisThread = state.NotePartComplete(CompletionPart.EndDefaultSyntaxValueDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 10138, 10174);

                        f_10240_10138_10173(completedOnThisThread);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 8507, 10193);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 10213, 10302);

                    state.SpinWaitComplete(CompletionPart.EndDefaultSyntaxValue, default(CancellationToken));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 10320, 10351);

                    return _lazyDefaultSyntaxValue;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10240, 8471, 10366);

                    Microsoft.CodeAnalysis.DiagnosticBag
                    f_10240_8633_8660()
                    {
                        var return_v = DiagnosticBag.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 8633, 8660);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConstantValue
                    f_10240_8811_8891(Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                    this_param, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics, out Microsoft.CodeAnalysis.CSharp.Binder?
                    binder, out Microsoft.CodeAnalysis.CSharp.BoundParameterEqualsValue?
                    parameterEqualsValue)
                    {
                        var return_v = this_param.MakeDefaultExpression(diagnostics, out binder, out parameterEqualsValue);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 8811, 8891);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConstantValue
                    f_10240_8918_8937()
                    {
                        var return_v = ConstantValue.Unset;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 8918, 8937);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConstantValue
                    f_10240_8703_8938(ref Microsoft.CodeAnalysis.ConstantValue
                    location1, Microsoft.CodeAnalysis.ConstantValue
                    value, Microsoft.CodeAnalysis.ConstantValue
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 8703, 8938);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConstantValue
                    f_10240_8991_9010()
                    {
                        var return_v = ConstantValue.Unset;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 8991, 9010);
                        return return_v;
                    }


                    int
                    f_10240_8961_9011(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 8961, 9011);
                        return 0;
                    }


                    int
                    f_10240_9147_9182(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 9147, 9182);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                    f_10240_9398_9414()
                    {
                        var return_v = CSharpSyntaxNode;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 9398, 9414);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxNode?
                    f_10240_9348_9415(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                    parameterSyntax)
                    {
                        var return_v = GetDefaultValueSyntaxForIsNullableAnalysisEnabled(parameterSyntax);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 9348, 9415);
                        return return_v;
                    }


                    int
                    f_10240_9492_9578(Microsoft.CodeAnalysis.CSharp.Binder
                    binder, Microsoft.CodeAnalysis.CSharp.BoundParameterEqualsValue
                    node, Microsoft.CodeAnalysis.SyntaxNode
                    syntax, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics)
                    {
                        NullableWalker.AnalyzeIfNeeded(binder, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, syntax, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 9492, 9578);
                        return 0;
                    }


                    bool
                    f_10240_9636_9666_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 9636, 9666);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10240_9794_9820(Microsoft.CodeAnalysis.CSharp.BoundParameterEqualsValue
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 9794, 9820);
                        return return_v;
                    }


                    int
                    f_10240_9724_9841(Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                    this_param, Microsoft.CodeAnalysis.ConstantValue
                    value, Microsoft.CodeAnalysis.SyntaxNode
                    syntax, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics)
                    {
                        this_param.VerifyParamDefaultValueMatchesAttributeIfAny(value, syntax, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 9724, 9841);
                        return 0;
                    }


                    int
                    f_10240_9916_9954(Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                    this_param, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics)
                    {
                        this_param.AddDeclarationDiagnostics(diagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 9916, 9954);
                        return 0;
                    }


                    int
                    f_10240_9977_9995(Microsoft.CodeAnalysis.DiagnosticBag
                    this_param)
                    {
                        this_param.Free();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 9977, 9995);
                        return 0;
                    }


                    int
                    f_10240_10138_10173(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 10138, 10173);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10240, 8406, 10377);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10240, 8406, 10377);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private Binder GetBinder(SyntaxNode syntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10240, 10389, 11169);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 10457, 10489);

                var
                binder = f_10240_10470_10488()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 10813, 11069) || true) && (binder == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 10813, 11069);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 10865, 10909);

                    var
                    compilation = f_10240_10883_10908(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 10927, 10995);

                    var
                    binderFactory = f_10240_10947_10994(compilation, f_10240_10976_10993(syntax))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 11013, 11054);

                    binder = f_10240_11022_11053(binderFactory, syntax);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 10813, 11069);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 11083, 11130);

                f_10240_11083_11129(f_10240_11096_11120(binder, syntax) == null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 11144, 11158);

                return binder;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10240, 10389, 11169);

                Microsoft.CodeAnalysis.CSharp.Binder
                f_10240_10470_10488()
                {
                    var return_v = ParameterBinderOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 10470, 10488);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10240_10883_10908(Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 10883, 10908);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10240_10976_10993(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 10976, 10993);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinderFactory
                f_10240_10947_10994(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree)
                {
                    var return_v = this_param.GetBinderFactory(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 10947, 10994);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10240_11022_11053(Microsoft.CodeAnalysis.CSharp.BinderFactory
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = this_param.GetBinder(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 11022, 11053);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10240_11096_11120(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = this_param.GetBinder(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 11096, 11120);
                    return return_v;
                }


                int
                f_10240_11083_11129(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 11083, 11129);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10240, 10389, 11169);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10240, 10389, 11169);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void NullableAnalyzeParameterDefaultValueFromAttributes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10240, 11181, 13603);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 11271, 11315);

                var
                parameterSyntax = f_10240_11293_11314(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 11329, 11723) || true) && (parameterSyntax == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 11329, 11723);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 11701, 11708);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 11329, 11723);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 12065, 12118);

                var
                attributes = parameterSyntax.AttributeLists.Node
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 12132, 12277) || true) && (attributes is null || (DynAbs.Tracing.TraceSender.Expression_False(10240, 12136, 12221) || !f_10240_12159_12221(f_10240_12188_12208(), attributes)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 12132, 12277);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 12255, 12262);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 12132, 12277);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 12293, 12339);

                var
                defaultValue = f_10240_12312_12338()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 12353, 12455) || true) && (defaultValue == null || (DynAbs.Tracing.TraceSender.Expression_False(10240, 12357, 12399) || f_10240_12381_12399(defaultValue)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 12353, 12455);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 12433, 12440);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 12353, 12455);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 12471, 12511);

                var
                binder = f_10240_12484_12510(this, parameterSyntax)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 12916, 13339);

                var
                parameterEqualsValue = f_10240_12943_13338(parameterSyntax, this, ImmutableArray<LocalSymbol>.Empty, f_10240_13284_13337(parameterSyntax, defaultValue, f_10240_13332_13336()))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 13355, 13401);

                var
                diagnostics = f_10240_13373_13400()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 13415, 13506);

                f_10240_13415_13505(binder, parameterEqualsValue, parameterSyntax, diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 13520, 13559);

                f_10240_13520_13558(this, diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 13573, 13592);

                f_10240_13573_13591(diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10240, 11181, 13603);

                Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                f_10240_11293_11314(Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                this_param)
                {
                    var return_v = this_param.CSharpSyntaxNode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 11293, 11314);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10240_12188_12208()
                {
                    var return_v = DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 12188, 12208);
                    return return_v;
                }


                bool
                f_10240_12159_12221(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    var return_v = NullableWalker.NeedsAnalysis(compilation, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 12159, 12221);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10240_12312_12338()
                {
                    var return_v = DefaultValueFromAttributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 12312, 12338);
                    return return_v;
                }


                bool
                f_10240_12381_12399(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.IsBad;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 12381, 12399);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10240_12484_12510(Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                syntax)
                {
                    var return_v = this_param.GetBinder((Microsoft.CodeAnalysis.SyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 12484, 12510);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10240_13332_13336()
                {
                    var return_v = Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 13332, 13336);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLiteral
                f_10240_13284_13337(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                syntax, Microsoft.CodeAnalysis.ConstantValue
                constantValueOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundLiteral((Microsoft.CodeAnalysis.SyntaxNode)syntax, constantValueOpt, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 13284, 13337);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundParameterEqualsValue
                f_10240_12943_13338(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                parameter, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, Microsoft.CodeAnalysis.CSharp.BoundLiteral
                value)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundParameterEqualsValue((Microsoft.CodeAnalysis.SyntaxNode)syntax, (Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol)parameter, locals, (Microsoft.CodeAnalysis.CSharp.BoundExpression)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 12943, 13338);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10240_13373_13400()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 13373, 13400);
                    return return_v;
                }


                int
                f_10240_13415_13505(Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.CSharp.BoundParameterEqualsValue
                node, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    NullableWalker.AnalyzeIfNeeded(binder, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, (Microsoft.CodeAnalysis.SyntaxNode)syntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 13415, 13505);
                    return 0;
                }


                int
                f_10240_13520_13558(Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.AddDeclarationDiagnostics(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 13520, 13558);
                    return 0;
                }


                int
                f_10240_13573_13591(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 13573, 13591);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10240, 11181, 13603);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10240, 11181, 13603);
            }
        }

        private ConstantValue MakeDefaultExpression(DiagnosticBag diagnostics, out Binder? binder, out BoundParameterEqualsValue? parameterEqualsValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10240, 13815, 16437);
                Microsoft.CodeAnalysis.CSharp.BoundExpression valueBeforeConversion = default(Microsoft.CodeAnalysis.CSharp.BoundExpression);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 13983, 13997);

                binder = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 14011, 14039);

                parameterEqualsValue = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 14055, 14099);

                var
                parameterSyntax = f_10240_14077_14098(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 14113, 14223) || true) && (parameterSyntax == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 14113, 14223);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 14174, 14208);

                    return ConstantValue.NotAvailable;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 14113, 14223);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 14239, 14283);

                var
                defaultSyntax = f_10240_14259_14282(parameterSyntax)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 14297, 14405) || true) && (defaultSyntax == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 14297, 14405);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 14356, 14390);

                    return ConstantValue.NotAvailable;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 14297, 14405);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 14421, 14455);

                binder = f_10240_14430_14454(this, defaultSyntax);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 14469, 14560);

                Binder
                binderForDefault = f_10240_14495_14559(binder, this, defaultSyntax)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 14574, 14629);

                f_10240_14574_14628(f_10240_14587_14627(binderForDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 14643, 14719);

                f_10240_14643_14718(f_10240_14656_14697(binderForDefault) == f_10240_14701_14717());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 14735, 14866);

                parameterEqualsValue = f_10240_14758_14865(binderForDefault, defaultSyntax, this, diagnostics, out valueBeforeConversion);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 14880, 14989) || true) && (f_10240_14884_14915(valueBeforeConversion))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 14880, 14989);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 14949, 14974);

                    return f_10240_14956_14973();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 14880, 14989);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 15005, 15070);

                BoundExpression
                convertedExpression = f_10240_15043_15069(parameterEqualsValue)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 15084, 15253);

                bool
                hasErrors = f_10240_15101_15252(binder, f_10240_15155_15171(), parameterSyntax, this, valueBeforeConversion, convertedExpression, diagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 15267, 15354) || true) && (hasErrors)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 15267, 15354);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 15314, 15339);

                    return f_10240_15321_15338();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 15267, 15354);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 15704, 16253) || true) && (f_10240_15708_15741(convertedExpression) == null && (DynAbs.Tracing.TraceSender.Expression_True(10240, 15708, 15801) && f_10240_15753_15777(convertedExpression) == BoundKind.Conversion) && (DynAbs.Tracing.TraceSender.Expression_True(10240, 15708, 15908) && f_10240_15822_15875(((BoundConversion)convertedExpression)) != ConversionKind.DefaultLiteral))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 15704, 16253);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 15942, 16238) || true) && (f_10240_15946_15981(parameterType.Type))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 15942, 16238);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 16023, 16219);

                        convertedExpression = f_10240_16045_16218(binder, f_10240_16084_16130(parameterType.Type), valueBeforeConversion, diagnostics, isDefaultParameter: true);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 15942, 16238);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 15704, 16253);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 16331, 16399);

                var
                value = f_10240_16343_16376(convertedExpression) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.ConstantValue?>(10240, 16343, 16398) ?? f_10240_16380_16398())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 16413, 16426);

                return value;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10240, 13815, 16437);

                Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                f_10240_14077_14098(Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                this_param)
                {
                    var return_v = this_param.CSharpSyntaxNode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 14077, 14098);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax?
                f_10240_14259_14282(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                this_param)
                {
                    var return_v = this_param.Default;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 14259, 14282);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10240_14430_14454(Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax
                syntax)
                {
                    var return_v = this_param.GetBinder((Microsoft.CodeAnalysis.SyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 14430, 14454);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10240_14495_14559(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                parameter, Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax
                defaultValueSyntax)
                {
                    var return_v = this_param.CreateBinderForParameterDefaultValue((Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol)parameter, defaultValueSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 14495, 14559);
                    return return_v;
                }


                bool
                f_10240_14587_14627(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.InParameterDefaultValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 14587, 14627);
                    return return_v;
                }


                int
                f_10240_14574_14628(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 14574, 14628);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10240_14656_14697(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.ContainingMemberOrLambda;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 14656, 14697);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10240_14701_14717()
                {
                    var return_v = ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 14701, 14717);
                    return return_v;
                }


                int
                f_10240_14643_14718(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 14643, 14718);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundParameterEqualsValue
                f_10240_14758_14865(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax
                defaultValueSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                parameter, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out Microsoft.CodeAnalysis.CSharp.BoundExpression
                valueBeforeConversion)
                {
                    var return_v = this_param.BindParameterDefaultValue(defaultValueSyntax, (Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol)parameter, diagnostics, out valueBeforeConversion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 14758, 14865);
                    return return_v;
                }


                bool
                f_10240_14884_14915(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.HasErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 14884, 14915);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10240_14956_14973()
                {
                    var return_v = ConstantValue.Bad;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 14956, 14973);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10240_15043_15069(Microsoft.CodeAnalysis.CSharp.BoundParameterEqualsValue
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 15043, 15069);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10240_15155_15171()
                {
                    var return_v = ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 15155, 15171);
                    return return_v;
                }


                bool
                f_10240_15101_15252(Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.CSharp.Symbol
                owner, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                parameterSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                parameter, Microsoft.CodeAnalysis.CSharp.BoundExpression
                defaultExpression, Microsoft.CodeAnalysis.CSharp.BoundExpression
                convertedExpression, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = ParameterHelpers.ReportDefaultParameterErrors(binder, owner, parameterSyntax, (Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbol)parameter, defaultExpression, convertedExpression, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 15101, 15252);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10240_15321_15338()
                {
                    var return_v = ConstantValue.Bad;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 15321, 15338);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10240_15708_15741(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 15708, 15741);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10240_15753_15777(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 15753, 15777);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ConversionKind
                f_10240_15822_15875(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.ConversionKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 15822, 15875);
                    return return_v;
                }


                bool
                f_10240_15946_15981(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 15946, 15981);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10240_16084_16130(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetNullableUnderlyingType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 16084, 16130);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10240_16045_16218(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                targetType, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                isDefaultParameter)
                {
                    var return_v = this_param.GenerateConversionForAssignment(targetType, expression, diagnostics, isDefaultParameter: isDefaultParameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 16045, 16218);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10240_16343_16376(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 16343, 16376);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10240_16380_16398()
                {
                    var return_v = ConstantValue.Null;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 16380, 16398);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10240, 13815, 16437);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10240, 13815, 16437);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string MetadataName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10240, 16530, 17173);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 16667, 16738);

                    var
                    sourceMethod = f_10240_16686_16707(this) as SourceOrdinaryMethodSymbol
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 16756, 16874) || true) && ((object)sourceMethod == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 16756, 16874);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 16830, 16855);

                        return DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.MetadataName, 10240, 16837, 16854);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 16756, 16874);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 16894, 16948);

                    var
                    definition = f_10240_16911_16947(sourceMethod)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 16966, 17082) || true) && ((object)definition == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 16966, 17082);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 17038, 17063);

                        return DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.MetadataName, 10240, 17045, 17062);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 16966, 17082);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 17102, 17158);

                    return f_10240_17109_17157(f_10240_17109_17130(definition)[f_10240_17131_17143(this)]);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10240, 16530, 17173);

                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10240_16686_16707(Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 16686, 16707);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                    f_10240_16911_16947(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.SourcePartialDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 16911, 16947);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    f_10240_17109_17130(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.Parameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 17109, 17130);
                        return return_v;
                    }


                    int
                    f_10240_17131_17143(Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.Ordinal;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 17131, 17143);
                        return return_v;
                    }


                    string
                    f_10240_17109_17157(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.MetadataName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 17109, 17157);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10240, 16470, 17184);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10240, 16470, 17184);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected virtual IAttributeTargetSymbol AttributeOwner
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10240, 17252, 17259);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 17255, 17259);
                    return this; DynAbs.Tracing.TraceSender.TraceExitMethod(10240, 17252, 17259);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10240, 17252, 17259);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10240, 17252, 17259);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10240, 17334, 17351);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 17337, 17351);
                    return f_10240_17337_17351(); DynAbs.Tracing.TraceSender.TraceExitMethod(10240, 17334, 17351);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10240, 17334, 17351);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10240, 17334, 17351);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10240, 17430, 17460);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 17433, 17460);
                    return AttributeLocation.Parameter; DynAbs.Tracing.TraceSender.TraceExitMethod(10240, 17430, 17460);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10240, 17430, 17460);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10240, 17430, 17460);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10240, 17564, 17911);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 17600, 17841) || true) && (f_10240_17604_17690(this))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 17600, 17841);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 17732, 17822);

                        return AttributeLocation.Parameter | AttributeLocation.Property | AttributeLocation.Field;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 17600, 17841);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 17861, 17896);

                    return AttributeLocation.Parameter;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10240, 17564, 17911);

                    bool
                    f_10240_17604_17690(Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                    parameter)
                    {
                        var return_v = SynthesizedRecordPropertySymbol.HaveCorrespondingSynthesizedRecordPropertySymbol((Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbol)parameter);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 17604, 17690);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10240, 17473, 17922);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10240, 17473, 17922);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private SourceParameterSymbol BoundAttributesSource
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10240, 18403, 18915);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 18439, 18510);

                    var
                    sourceMethod = f_10240_18458_18479(this) as SourceOrdinaryMethodSymbol
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 18528, 18633) || true) && ((object)sourceMethod == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 18528, 18633);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 18602, 18614);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 18528, 18633);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 18653, 18705);

                    var
                    impl = f_10240_18664_18704(sourceMethod)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 18723, 18820) || true) && ((object)impl == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 18723, 18820);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 18789, 18801);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 18723, 18820);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 18840, 18900);

                    return (SourceParameterSymbol)f_10240_18870_18885(impl)[f_10240_18886_18898(this)];
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10240, 18403, 18915);

                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10240_18458_18479(Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 18458, 18479);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                    f_10240_18664_18704(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.SourcePartialImplementation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 18664, 18704);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    f_10240_18870_18885(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.Parameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 18870, 18885);
                        return return_v;
                    }


                    int
                    f_10240_18886_18898(Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.Ordinal;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 18886, 18898);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10240, 18327, 18926);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10240, 18327, 18926);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override SyntaxList<AttributeListSyntax> AttributeDeclarationList
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10240, 19044, 19239);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 19080, 19115);

                    var
                    syntax = f_10240_19093_19114(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 19133, 19224);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10240, 19140, 19156) || (((syntax != null) && DynAbs.Tracing.TraceSender.Conditional_F2(10240, 19159, 19180)) || DynAbs.Tracing.TraceSender.Conditional_F3(10240, 19183, 19223))) ? f_10240_19159_19180(syntax) : default(SyntaxList<AttributeListSyntax>);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10240, 19044, 19239);

                    Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                    f_10240_19093_19114(Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.CSharpSyntaxNode;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 19093, 19114);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                    f_10240_19159_19180(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                    this_param)
                    {
                        var return_v = this_param.AttributeLists;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 19159, 19180);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10240, 18938, 19250);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10240, 18938, 19250);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual OneOrMany<SyntaxList<AttributeListSyntax>> GetAttributeDeclarations()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10240, 19416, 21142);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 19861, 19931);

                SyntaxList<AttributeListSyntax>
                attributes = f_10240_19906_19930()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 19947, 20018);

                var
                sourceMethod = f_10240_19966_19987(this) as SourceOrdinaryMethodSymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 20032, 20149) || true) && ((object)sourceMethod == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 20032, 20149);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 20098, 20134);

                    return f_10240_20105_20133(attributes);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 20032, 20149);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 20165, 20213);

                SyntaxList<AttributeListSyntax>
                otherAttributes
                = default(SyntaxList<AttributeListSyntax>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 20307, 20378);

                SourceOrdinaryMethodSymbol
                otherPart = f_10240_20346_20377(sourceMethod)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 20392, 20698) || true) && ((object)otherPart != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 20392, 20698);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 20455, 20558);

                    otherAttributes = f_10240_20473_20557(((SourceParameterSymbol)f_10240_20497_20517(otherPart)[f_10240_20518_20530(this)]));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 20392, 20698);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 20392, 20698);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 20624, 20683);

                    otherAttributes = default(SyntaxList<AttributeListSyntax>);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 20392, 20698);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 20714, 21039) || true) && (attributes.Equals(default(SyntaxList<AttributeListSyntax>)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 20714, 21039);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 20811, 20852);

                    return f_10240_20818_20851(otherAttributes);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 20714, 21039);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 20714, 21039);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 20886, 21039) || true) && (otherAttributes.Equals(default(SyntaxList<AttributeListSyntax>)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 20886, 21039);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 20988, 21024);

                        return f_10240_20995_21023(attributes);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 20886, 21039);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 20714, 21039);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 21055, 21131);

                return f_10240_21062_21130(f_10240_21079_21129(attributes, otherAttributes));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10240, 19416, 21142);

                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                f_10240_19906_19930()
                {
                    var return_v = AttributeDeclarationList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 19906, 19930);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10240_19966_19987(Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 19966, 19987);
                    return return_v;
                }


                Roslyn.Utilities.OneOrMany<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                f_10240_20105_20133(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                one)
                {
                    var return_v = OneOrMany.Create(one);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 20105, 20133);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                f_10240_20346_20377(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.OtherPartOfPartial;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 20346, 20377);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10240_20497_20517(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 20497, 20517);
                    return return_v;
                }


                int
                f_10240_20518_20530(Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                this_param)
                {
                    var return_v = this_param.Ordinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 20518, 20530);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                f_10240_20473_20557(Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbol
                this_param)
                {
                    var return_v = this_param.AttributeDeclarationList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 20473, 20557);
                    return return_v;
                }


                Roslyn.Utilities.OneOrMany<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                f_10240_20818_20851(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                one)
                {
                    var return_v = OneOrMany.Create(one);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 20818, 20851);
                    return return_v;
                }


                Roslyn.Utilities.OneOrMany<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                f_10240_20995_21023(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                one)
                {
                    var return_v = OneOrMany.Create(one);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 20995, 21023);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                f_10240_21079_21129(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                item1, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                item2)
                {
                    var return_v = ImmutableArray.Create(item1, item2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 21079, 21129);
                    return return_v;
                }


                Roslyn.Utilities.OneOrMany<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                f_10240_21062_21130(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                many)
                {
                    var return_v = OneOrMany.Create(many);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 21062, 21130);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10240, 19416, 21142);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10240, 19416, 21142);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ParameterWellKnownAttributeData GetDecodedWellKnownAttributeData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10240, 21431, 21873);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 21531, 21576);

                var
                attributesBag = _lazyCustomAttributesBag
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 21590, 21762) || true) && (attributesBag == null || (DynAbs.Tracing.TraceSender.Expression_False(10240, 21594, 21673) || f_10240_21619_21673_M(!attributesBag.IsDecodedWellKnownAttributeDataComputed)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 21590, 21762);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 21707, 21747);

                    attributesBag = f_10240_21723_21746(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 21590, 21762);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 21778, 21862);

                return (ParameterWellKnownAttributeData)f_10240_21818_21861(attributesBag);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10240, 21431, 21873);

                bool
                f_10240_21619_21673_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 21619, 21673);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10240_21723_21746(Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                this_param)
                {
                    var return_v = this_param.GetAttributesBag();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 21723, 21746);
                    return return_v;
                }


                Microsoft.CodeAnalysis.WellKnownAttributeData
                f_10240_21818_21861(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param)
                {
                    var return_v = this_param.DecodedWellKnownAttributeData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 21818, 21861);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10240, 21431, 21873);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10240, 21431, 21873);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ParameterEarlyWellKnownAttributeData GetEarlyDecodedWellKnownAttributeData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10240, 22182, 22649);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 22292, 22337);

                var
                attributesBag = _lazyCustomAttributesBag
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 22351, 22528) || true) && (attributesBag == null || (DynAbs.Tracing.TraceSender.Expression_False(10240, 22355, 22439) || f_10240_22380_22439_M(!attributesBag.IsEarlyDecodedWellKnownAttributeDataComputed)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 22351, 22528);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 22473, 22513);

                    attributesBag = f_10240_22489_22512(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 22351, 22528);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 22544, 22638);

                return (ParameterEarlyWellKnownAttributeData)f_10240_22589_22637(attributesBag);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10240, 22182, 22649);

                bool
                f_10240_22380_22439_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 22380, 22439);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10240_22489_22512(Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                this_param)
                {
                    var return_v = this_param.GetAttributesBag();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 22489, 22512);
                    return return_v;
                }


                Microsoft.CodeAnalysis.EarlyWellKnownAttributeData
                f_10240_22589_22637(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param)
                {
                    var return_v = this_param.EarlyDecodedWellKnownAttributeData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 22589, 22637);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10240, 22182, 22649);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10240, 22182, 22649);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override CustomAttributesBag<CSharpAttributeData> GetAttributesBag()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10240, 22975, 24297);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 23084, 24238) || true) && (_lazyCustomAttributesBag == null || (DynAbs.Tracing.TraceSender.Expression_False(10240, 23088, 23158) || f_10240_23124_23158_M(!_lazyCustomAttributesBag.IsSealed)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 23084, 24238);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 23192, 23252);

                    SourceParameterSymbol
                    copyFrom = f_10240_23225_23251(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 23320, 23367);

                    f_10240_23320_23366(!f_10240_23334_23365(copyFrom, this));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 23387, 23415);

                    bool
                    bagCreatedOnThisThread
                    = default(bool);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 23433, 23991) || true) && ((object)copyFrom != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 23433, 23991);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 23503, 23551);

                        var
                        attributesBag = f_10240_23523_23550(copyFrom)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 23573, 23685);

                        bagCreatedOnThisThread = f_10240_23598_23676(ref _lazyCustomAttributesBag, attributesBag, null) == null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 23433, 23991);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 23433, 23991);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 23767, 23821);

                        var
                        attributeSyntax = f_10240_23789_23820(this)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 23843, 23972);

                        bagCreatedOnThisThread = f_10240_23868_23971(this, attributeSyntax, ref _lazyCustomAttributesBag, binderOpt: f_10240_23952_23970());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 23433, 23991);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 24011, 24223) || true) && (bagCreatedOnThisThread)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 24011, 24223);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 24079, 24132);

                        f_10240_24079_24131(this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 24154, 24204);

                        state.NotePartComplete(CompletionPart.Attributes);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 24011, 24223);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 23084, 24238);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 24254, 24286);

                return _lazyCustomAttributesBag;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10240, 22975, 24297);

                bool
                f_10240_23124_23158_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 23124, 23158);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbol
                f_10240_23225_23251(Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                this_param)
                {
                    var return_v = this_param.BoundAttributesSource;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 23225, 23251);
                    return return_v;
                }


                bool
                f_10240_23334_23365(Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 23334, 23365);
                    return return_v;
                }


                int
                f_10240_23320_23366(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 23320, 23366);
                    return 0;
                }


                Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10240_23523_23550(Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbol
                this_param)
                {
                    var return_v = this_param.GetAttributesBag();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 23523, 23550);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>?
                f_10240_23598_23676(ref Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>?
                location1, Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                value, Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 23598, 23676);
                    return return_v;
                }


                Roslyn.Utilities.OneOrMany<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                f_10240_23789_23820(Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                this_param)
                {
                    var return_v = this_param.GetAttributeDeclarations();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 23789, 23820);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10240_23952_23970()
                {
                    var return_v = ParameterBinderOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 23952, 23970);
                    return return_v;
                }


                bool
                f_10240_23868_23971(Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                this_param, Roslyn.Utilities.OneOrMany<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                attributesSyntaxLists, ref Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>?
                lazyCustomAttributesBag, Microsoft.CodeAnalysis.CSharp.Binder
                binderOpt)
                {
                    var return_v = this_param.LoadAndValidateAttributes(attributesSyntaxLists, ref lazyCustomAttributesBag, binderOpt: binderOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 23868, 23971);
                    return return_v;
                }


                int
                f_10240_24079_24131(Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                this_param)
                {
                    this_param.NullableAnalyzeParameterDefaultValueFromAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 24079, 24131);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10240, 22975, 24297);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10240, 22975, 24297);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override void EarlyDecodeWellKnownAttributeType(NamedTypeSymbol attributeType, AttributeSyntax attributeSyntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10240, 24309, 24980);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 24454, 24497);

                f_10240_24454_24496(!f_10240_24468_24495(attributeType));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 24758, 24969) || true) && (f_10240_24762_24876(attributeType, attributeSyntax, AttributeDescription.OptionalAttribute))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 24758, 24969);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 24910, 24954);

                    _lazyHasOptionalAttribute = ThreeState.True;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 24758, 24969);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10240, 24309, 24980);

                bool
                f_10240_24468_24495(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 24468, 24495);
                    return return_v;
                }


                int
                f_10240_24454_24496(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 24454, 24496);
                    return 0;
                }


                bool
                f_10240_24762_24876(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                attributeType, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                attributeSyntax, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = CSharpAttributeData.IsTargetEarlyAttribute(attributeType, attributeSyntax, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 24762, 24876);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10240, 24309, 24980);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10240, 24309, 24980);
            }
        }

        internal override void PostEarlyDecodeWellKnownAttributeTypes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10240, 24992, 25298);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 25080, 25225) || true) && (_lazyHasOptionalAttribute == ThreeState.Unknown)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 25080, 25225);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 25165, 25210);

                    _lazyHasOptionalAttribute = ThreeState.False;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 25080, 25225);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 25241, 25287);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.PostEarlyDecodeWellKnownAttributeTypes(), 10240, 25241, 25286);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10240, 24992, 25298);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10240, 24992, 25298);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10240, 24992, 25298);
            }
        }

        internal override CSharpAttributeData EarlyDecodeWellKnownAttribute(ref EarlyDecodeWellKnownAttributeArguments<EarlyWellKnownAttributeBinder, NamedTypeSymbol, AttributeSyntax, AttributeLocation> arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10240, 25310, 27694);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 25540, 27610) || true) && (f_10240_25544_25691(arguments.AttributeType, arguments.AttributeSyntax, AttributeDescription.DefaultParameterValueAttribute))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 25540, 27610);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 25725, 25845);

                    return f_10240_25732_25844(this, AttributeDescription.DefaultParameterValueAttribute, ref arguments);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 25540, 27610);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 25540, 27610);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 25879, 27610) || true) && (f_10240_25883_26024(arguments.AttributeType, arguments.AttributeSyntax, AttributeDescription.DecimalConstantAttribute))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 25879, 27610);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 26058, 26172);

                        return f_10240_26065_26171(this, AttributeDescription.DecimalConstantAttribute, ref arguments);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 25879, 27610);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 25879, 27610);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 26206, 27610) || true) && (f_10240_26210_26352(arguments.AttributeType, arguments.AttributeSyntax, AttributeDescription.DateTimeConstantAttribute))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 26206, 27610);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 26386, 26501);

                            return f_10240_26393_26500(this, AttributeDescription.DateTimeConstantAttribute, ref arguments);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 26206, 27610);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 26206, 27610);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 26535, 27610) || true) && (!f_10240_26540_26592(this, arguments.AttributeSyntax))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 26535, 27610);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 26626, 27595) || true) && (f_10240_26630_26772(arguments.AttributeType, arguments.AttributeSyntax, AttributeDescription.CallerLineNumberAttribute))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 26626, 27595);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 26814, 26916);

                                    arguments.GetOrCreateData<ParameterEarlyWellKnownAttributeData>().HasCallerLineNumberAttribute = true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 26626, 27595);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 26626, 27595);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 26958, 27595) || true) && (f_10240_26962_27102(arguments.AttributeType, arguments.AttributeSyntax, AttributeDescription.CallerFilePathAttribute))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 26958, 27595);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 27144, 27244);

                                        arguments.GetOrCreateData<ParameterEarlyWellKnownAttributeData>().HasCallerFilePathAttribute = true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 26958, 27595);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 26958, 27595);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 27286, 27595) || true) && (f_10240_27290_27432(arguments.AttributeType, arguments.AttributeSyntax, AttributeDescription.CallerMemberNameAttribute))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 27286, 27595);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 27474, 27576);

                                            arguments.GetOrCreateData<ParameterEarlyWellKnownAttributeData>().HasCallerMemberNameAttribute = true;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 27286, 27595);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 26958, 27595);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 26626, 27595);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 26535, 27610);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 26206, 27610);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 25879, 27610);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 25540, 27610);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 27626, 27683);

                //return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.EarlyDecodeWellKnownAttribute(ref arguments), 10240, 27633, 27682);

                var temp = base.EarlyDecodeWellKnownAttribute(ref arguments);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 27633, 27682);
                return temp;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10240, 25310, 27694);

                bool
                f_10240_25544_25691(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                attributeType, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                attributeSyntax, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = CSharpAttributeData.IsTargetEarlyAttribute(attributeType, attributeSyntax, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 25544, 25691);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                f_10240_25732_25844(Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                this_param, Microsoft.CodeAnalysis.AttributeDescription
                description, ref Microsoft.CodeAnalysis.EarlyDecodeWellKnownAttributeArguments<Microsoft.CodeAnalysis.CSharp.EarlyWellKnownAttributeBinder, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation>
                arguments)
                {
                    var return_v = this_param.EarlyDecodeAttributeForDefaultParameterValue(description, ref arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 25732, 25844);
                    return return_v;
                }


                bool
                f_10240_25883_26024(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                attributeType, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                attributeSyntax, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = CSharpAttributeData.IsTargetEarlyAttribute(attributeType, attributeSyntax, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 25883, 26024);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                f_10240_26065_26171(Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                this_param, Microsoft.CodeAnalysis.AttributeDescription
                description, ref Microsoft.CodeAnalysis.EarlyDecodeWellKnownAttributeArguments<Microsoft.CodeAnalysis.CSharp.EarlyWellKnownAttributeBinder, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation>
                arguments)
                {
                    var return_v = this_param.EarlyDecodeAttributeForDefaultParameterValue(description, ref arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 26065, 26171);
                    return return_v;
                }


                bool
                f_10240_26210_26352(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                attributeType, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                attributeSyntax, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = CSharpAttributeData.IsTargetEarlyAttribute(attributeType, attributeSyntax, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 26210, 26352);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                f_10240_26393_26500(Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                this_param, Microsoft.CodeAnalysis.AttributeDescription
                description, ref Microsoft.CodeAnalysis.EarlyDecodeWellKnownAttributeArguments<Microsoft.CodeAnalysis.CSharp.EarlyWellKnownAttributeBinder, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation>
                arguments)
                {
                    var return_v = this_param.EarlyDecodeAttributeForDefaultParameterValue(description, ref arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 26393, 26500);
                    return return_v;
                }


                bool
                f_10240_26540_26592(Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                node)
                {
                    var return_v = this_param.IsOnPartialImplementation(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 26540, 26592);
                    return return_v;
                }


                bool
                f_10240_26630_26772(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                attributeType, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                attributeSyntax, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = CSharpAttributeData.IsTargetEarlyAttribute(attributeType, attributeSyntax, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 26630, 26772);
                    return return_v;
                }


                bool
                f_10240_26962_27102(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                attributeType, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                attributeSyntax, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = CSharpAttributeData.IsTargetEarlyAttribute(attributeType, attributeSyntax, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 26962, 27102);
                    return return_v;
                }


                bool
                f_10240_27290_27432(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                attributeType, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                attributeSyntax, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = CSharpAttributeData.IsTargetEarlyAttribute(attributeType, attributeSyntax, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 27290, 27432);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10240, 25310, 27694);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10240, 25310, 27694);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private CSharpAttributeData EarlyDecodeAttributeForDefaultParameterValue(AttributeDescription description, ref EarlyDecodeWellKnownAttributeArguments<EarlyWellKnownAttributeBinder, NamedTypeSymbol, AttributeSyntax, AttributeLocation> arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10240, 27706, 29129);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 27975, 28234);

                f_10240_27975_28233(f_10240_27988_28059(ref description, AttributeDescription.DefaultParameterValueAttribute) || (DynAbs.Tracing.TraceSender.Expression_False(10240, 27988, 28145) || f_10240_28080_28145(ref description, AttributeDescription.DecimalConstantAttribute)) || (DynAbs.Tracing.TraceSender.Expression_False(10240, 27988, 28232) || f_10240_28166_28232(ref description, AttributeDescription.DateTimeConstantAttribute)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 28250, 28273);

                bool
                hasAnyDiagnostics
                = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 28287, 28408);

                var
                attribute = f_10240_28303_28407(arguments.Binder, arguments.AttributeSyntax, arguments.AttributeType, out hasAnyDiagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 28422, 28442);

                ConstantValue
                value
                = default(ConstantValue);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 28456, 28798) || true) && (f_10240_28460_28479(attribute))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 28456, 28798);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 28513, 28539);

                    value = f_10240_28521_28538();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 28557, 28582);

                    hasAnyDiagnostics = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 28456, 28798);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 28456, 28798);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 28648, 28783);

                    value = f_10240_28656_28782(this, description, attribute, arguments.AttributeSyntax, diagnose: false, diagnosticsOpt: null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 28456, 28798);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 28814, 28896);

                var
                paramData = arguments.GetOrCreateData<ParameterEarlyWellKnownAttributeData>()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 28910, 29057) || true) && (f_10240_28914_28945(paramData) == f_10240_28949_28968())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 28910, 29057);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 29002, 29042);

                    paramData.DefaultParameterValue = value;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 28910, 29057);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 29073, 29118);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10240, 29080, 29098) || ((!hasAnyDiagnostics && DynAbs.Tracing.TraceSender.Conditional_F2(10240, 29101, 29110)) || DynAbs.Tracing.TraceSender.Conditional_F3(10240, 29113, 29117))) ? attribute : null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10240, 27706, 29129);

                bool
                f_10240_27988_28059(ref Microsoft.CodeAnalysis.AttributeDescription
                this_param, Microsoft.CodeAnalysis.AttributeDescription
                obj)
                {
                    var return_v = this_param.Equals((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 27988, 28059);
                    return return_v;
                }


                bool
                f_10240_28080_28145(ref Microsoft.CodeAnalysis.AttributeDescription
                this_param, Microsoft.CodeAnalysis.AttributeDescription
                obj)
                {
                    var return_v = this_param.Equals((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 28080, 28145);
                    return return_v;
                }


                bool
                f_10240_28166_28232(ref Microsoft.CodeAnalysis.AttributeDescription
                this_param, Microsoft.CodeAnalysis.AttributeDescription
                obj)
                {
                    var return_v = this_param.Equals((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 28166, 28232);
                    return return_v;
                }


                int
                f_10240_27975_28233(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 27975, 28233);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                f_10240_28303_28407(Microsoft.CodeAnalysis.CSharp.EarlyWellKnownAttributeBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                node, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                boundAttributeType, out bool
                generatedDiagnostics)
                {
                    var return_v = this_param.GetAttribute(node, boundAttributeType, out generatedDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 28303, 28407);
                    return return_v;
                }


                bool
                f_10240_28460_28479(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.HasErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 28460, 28479);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10240_28521_28538()
                {
                    var return_v = ConstantValue.Bad;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 28521, 28538);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10240_28656_28782(Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                this_param, Microsoft.CodeAnalysis.AttributeDescription
                description, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                attribute, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                node, bool
                diagnose, Microsoft.CodeAnalysis.DiagnosticBag
                diagnosticsOpt)
                {
                    var return_v = this_param.DecodeDefaultParameterValueAttribute(description, attribute, node, diagnose: diagnose, diagnosticsOpt: diagnosticsOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 28656, 28782);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10240_28914_28945(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterEarlyWellKnownAttributeData
                this_param)
                {
                    var return_v = this_param.DefaultParameterValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 28914, 28945);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10240_28949_28968()
                {
                    var return_v = ConstantValue.Unset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 28949, 28968);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10240, 27706, 29129);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10240, 27706, 29129);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override void DecodeWellKnownAttribute(ref DecodeWellKnownAttributeArguments<AttributeSyntax, CSharpAttributeData, AttributeLocation> arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10240, 29141, 36709);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 29319, 29378);

                f_10240_29319_29377((object)arguments.AttributeSyntaxOpt != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 29394, 29430);

                var
                attribute = arguments.Attribute
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 29444, 29479);

                f_10240_29444_29478(f_10240_29457_29477_M(!attribute.HasErrors));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 29493, 29554);

                f_10240_29493_29553(arguments.SymbolPart == AttributeLocation.None);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 29570, 36698) || true) && (f_10240_29574_29660(attribute, this, AttributeDescription.DefaultParameterValueAttribute))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 29570, 36698);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 29796, 29901);

                    f_10240_29796_29900(this, AttributeDescription.DefaultParameterValueAttribute, ref arguments);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 29570, 36698);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 29570, 36698);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 29935, 36698) || true) && (f_10240_29939_30019(attribute, this, AttributeDescription.DecimalConstantAttribute))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 29935, 36698);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 30155, 30254);

                        f_10240_30155_30253(this, AttributeDescription.DecimalConstantAttribute, ref arguments);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 29935, 36698);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 29935, 36698);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 30288, 36698) || true) && (f_10240_30292_30373(attribute, this, AttributeDescription.DateTimeConstantAttribute))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 30288, 36698);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 30509, 30609);

                            f_10240_30509_30608(this, AttributeDescription.DateTimeConstantAttribute, ref arguments);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 30288, 36698);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 30288, 36698);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 30643, 36698) || true) && (f_10240_30647_30720(attribute, this, AttributeDescription.OptionalAttribute))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 30643, 36698);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 30754, 30813);

                                f_10240_30754_30812(_lazyHasOptionalAttribute == ThreeState.True);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 30833, 31182) || true) && (f_10240_30837_30861())
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 30833, 31182);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 31047, 31163);

                                    f_10240_31047_31162(                    // error CS1745: Cannot specify default parameter value in conjunction with DefaultParameterAttribute or OptionalAttribute
                                                        arguments.Diagnostics, ErrorCode.ERR_DefaultValueUsedWithAttributes, f_10240_31119_31161(f_10240_31119_31152(arguments.AttributeSyntaxOpt)));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 30833, 31182);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 30643, 36698);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 30643, 36698);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 31216, 36698) || true) && (f_10240_31220_31295(attribute, this, AttributeDescription.ParamArrayAttribute))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 31216, 36698);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 31438, 31542);

                                    f_10240_31438_31541(                // error CS0674: Do not use 'System.ParamArrayAttribute'. Use the 'params' keyword instead.
                                                    arguments.Diagnostics, ErrorCode.ERR_ExplicitParamArray, f_10240_31498_31540(f_10240_31498_31531(arguments.AttributeSyntaxOpt)));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 31216, 36698);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 31216, 36698);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 31576, 36698) || true) && (f_10240_31580_31647(attribute, this, AttributeDescription.InAttribute))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 31576, 36698);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 31681, 31764);

                                        arguments.GetOrCreateData<ParameterWellKnownAttributeData>().HasInAttribute = true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 31576, 36698);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 31576, 36698);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 31798, 36698) || true) && (f_10240_31802_31870(attribute, this, AttributeDescription.OutAttribute))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 31798, 36698);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 31904, 31988);

                                            arguments.GetOrCreateData<ParameterWellKnownAttributeData>().HasOutAttribute = true;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 31798, 36698);
                                        }

                                        else
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 31798, 36698);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 32022, 36698) || true) && (f_10240_32026_32100(attribute, this, AttributeDescription.MarshalAsAttribute))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 32022, 36698);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 32134, 32326);

                                                f_10240_32134_32325(ref arguments, AttributeTargets.Parameter, MessageProvider.Instance);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 32022, 36698);
                                            }

                                            else
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 32022, 36698);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 32360, 36698) || true) && (f_10240_32364_32446(attribute, this, AttributeDescription.IDispatchConstantAttribute))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 32360, 36698);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 32480, 32578);

                                                    arguments.GetOrCreateData<ParameterWellKnownAttributeData>().HasIDispatchConstantAttribute = true;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 32360, 36698);
                                                }

                                                else
                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 32360, 36698);

                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 32612, 36698) || true) && (f_10240_32616_32697(attribute, this, AttributeDescription.IUnknownConstantAttribute))
                                                    )

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 32612, 36698);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 32731, 32828);

                                                        arguments.GetOrCreateData<ParameterWellKnownAttributeData>().HasIUnknownConstantAttribute = true;
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 32612, 36698);
                                                    }

                                                    else
                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 32612, 36698);

                                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 32862, 36698) || true) && (f_10240_32866_32947(attribute, this, AttributeDescription.CallerLineNumberAttribute))
                                                        )

                                                        {
                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 32862, 36698);
                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 32981, 33068);

                                                            f_10240_32981_33067(this, arguments.AttributeSyntaxOpt, arguments.Diagnostics);
                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 32862, 36698);
                                                        }

                                                        else
                                                        {
                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 32862, 36698);

                                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 33102, 36698) || true) && (f_10240_33106_33185(attribute, this, AttributeDescription.CallerFilePathAttribute))
                                                            )

                                                            {
                                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 33102, 36698);
                                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 33219, 33304);

                                                                f_10240_33219_33303(this, arguments.AttributeSyntaxOpt, arguments.Diagnostics);
                                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 33102, 36698);
                                                            }

                                                            else
                                                            {
                                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 33102, 36698);

                                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 33338, 36698) || true) && (f_10240_33342_33423(attribute, this, AttributeDescription.CallerMemberNameAttribute))
                                                                )

                                                                {
                                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 33338, 36698);
                                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 33457, 33544);

                                                                    f_10240_33457_33543(this, arguments.AttributeSyntaxOpt, arguments.Diagnostics);
                                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 33338, 36698);
                                                                }

                                                                else
                                                                {
                                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 33338, 36698);

                                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 33578, 36698) || true) && (f_10240_33582_33943(this, arguments, ReservedAttributes.DynamicAttribute | ReservedAttributes.IsReadOnlyAttribute | ReservedAttributes.IsUnmanagedAttribute | ReservedAttributes.IsByRefLikeAttribute | ReservedAttributes.TupleElementNamesAttribute | ReservedAttributes.NullableAttribute | ReservedAttributes.NativeIntegerAttribute))
                                                                    )

                                                                    {
                                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 33578, 36698);
                                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 33578, 36698);
                                                                    }

                                                                    else
                                                                    {
                                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 33578, 36698);

                                                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 33993, 36698) || true) && (f_10240_33997_34071(attribute, this, AttributeDescription.AllowNullAttribute))
                                                                        )

                                                                        {
                                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 33993, 36698);
                                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 34105, 34195);

                                                                            arguments.GetOrCreateData<ParameterWellKnownAttributeData>().HasAllowNullAttribute = true;
                                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 33993, 36698);
                                                                        }

                                                                        else
                                                                        {
                                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 33993, 36698);

                                                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 34229, 36698) || true) && (f_10240_34233_34310(attribute, this, AttributeDescription.DisallowNullAttribute))
                                                                            )

                                                                            {
                                                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 34229, 36698);
                                                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 34344, 34437);

                                                                                arguments.GetOrCreateData<ParameterWellKnownAttributeData>().HasDisallowNullAttribute = true;
                                                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 34229, 36698);
                                                                            }

                                                                            else
                                                                            {
                                                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 34229, 36698);

                                                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 34471, 36698) || true) && (f_10240_34475_34549(attribute, this, AttributeDescription.MaybeNullAttribute))
                                                                                )

                                                                                {
                                                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 34471, 36698);
                                                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 34583, 34673);

                                                                                    arguments.GetOrCreateData<ParameterWellKnownAttributeData>().HasMaybeNullAttribute = true;
                                                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 34471, 36698);
                                                                                }

                                                                                else
                                                                                {
                                                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 34471, 36698);

                                                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 34707, 36698) || true) && (f_10240_34711_34789(attribute, this, AttributeDescription.MaybeNullWhenAttribute))
                                                                                    )

                                                                                    {
                                                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 34707, 36698);
                                                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 34823, 35047);

                                                                                        arguments.GetOrCreateData<ParameterWellKnownAttributeData>().MaybeNullWhenAttribute = f_10240_34909_35046(AttributeDescription.MaybeNullWhenAttribute, attribute, arguments.Diagnostics);
                                                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 34707, 36698);
                                                                                    }

                                                                                    else
                                                                                    {
                                                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 34707, 36698);

                                                                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 35081, 36698) || true) && (f_10240_35085_35157(attribute, this, AttributeDescription.NotNullAttribute))
                                                                                        )

                                                                                        {
                                                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 35081, 36698);
                                                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 35191, 35279);

                                                                                            arguments.GetOrCreateData<ParameterWellKnownAttributeData>().HasNotNullAttribute = true;
                                                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 35081, 36698);
                                                                                        }

                                                                                        else
                                                                                        {
                                                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 35081, 36698);

                                                                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 35313, 36698) || true) && (f_10240_35317_35393(attribute, this, AttributeDescription.NotNullWhenAttribute))
                                                                                            )

                                                                                            {
                                                                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 35313, 36698);
                                                                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 35427, 35647);

                                                                                                arguments.GetOrCreateData<ParameterWellKnownAttributeData>().NotNullWhenAttribute = f_10240_35511_35646(AttributeDescription.NotNullWhenAttribute, attribute, arguments.Diagnostics);
                                                                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 35313, 36698);
                                                                                            }

                                                                                            else
                                                                                            {
                                                                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 35313, 36698);

                                                                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 35681, 36698) || true) && (f_10240_35685_35765(attribute, this, AttributeDescription.DoesNotReturnIfAttribute))
                                                                                                )

                                                                                                {
                                                                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 35681, 36698);
                                                                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 35799, 36027);

                                                                                                    arguments.GetOrCreateData<ParameterWellKnownAttributeData>().DoesNotReturnIfAttribute = f_10240_35887_36026(AttributeDescription.DoesNotReturnIfAttribute, attribute, arguments.Diagnostics);
                                                                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 35681, 36698);
                                                                                                }

                                                                                                else
                                                                                                {
                                                                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 35681, 36698);

                                                                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 36061, 36698) || true) && (f_10240_36065_36146(attribute, this, AttributeDescription.NotNullIfNotNullAttribute))
                                                                                                    )

                                                                                                    {
                                                                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 36061, 36698);
                                                                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 36180, 36315);

                                                                                                        f_10240_36180_36314(arguments.GetOrCreateData<ParameterWellKnownAttributeData>(), f_10240_36270_36313(attribute));
                                                                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 36061, 36698);
                                                                                                    }

                                                                                                    else
                                                                                                    {
                                                                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 36061, 36698);

                                                                                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 36349, 36698) || true) && (f_10240_36353_36440(attribute, this, AttributeDescription.EnumeratorCancellationAttribute))
                                                                                                        )

                                                                                                        {
                                                                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 36349, 36698);
                                                                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 36474, 36577);

                                                                                                            arguments.GetOrCreateData<ParameterWellKnownAttributeData>().HasEnumeratorCancellationAttribute = true;
                                                                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 36595, 36683);

                                                                                                            f_10240_36595_36682(this, arguments.AttributeSyntaxOpt, arguments.Diagnostics);
                                                                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 36349, 36698);
                                                                                                        }
                                                                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 36061, 36698);
                                                                                                    }
                                                                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 35681, 36698);
                                                                                                }
                                                                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 35313, 36698);
                                                                                            }
                                                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 35081, 36698);
                                                                                        }
                                                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 34707, 36698);
                                                                                    }
                                                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 34471, 36698);
                                                                                }
                                                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 34229, 36698);
                                                                            }
                                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 33993, 36698);
                                                                        }
                                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 33578, 36698);
                                                                    }
                                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 33338, 36698);
                                                                }
                                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 33102, 36698);
                                                            }
                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 32862, 36698);
                                                        }
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 32612, 36698);
                                                    }
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 32360, 36698);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 32022, 36698);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 31798, 36698);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 31576, 36698);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 31216, 36698);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 30643, 36698);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 30288, 36698);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 29935, 36698);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 29570, 36698);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10240, 29141, 36709);

                int
                f_10240_29319_29377(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 29319, 29377);
                    return 0;
                }


                bool
                f_10240_29457_29477_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 29457, 29477);
                    return return_v;
                }


                int
                f_10240_29444_29478(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 29444, 29478);
                    return 0;
                }


                int
                f_10240_29493_29553(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 29493, 29553);
                    return 0;
                }


                bool
                f_10240_29574_29660(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 29574, 29660);
                    return return_v;
                }


                int
                f_10240_29796_29900(Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                this_param, Microsoft.CodeAnalysis.AttributeDescription
                description, ref Microsoft.CodeAnalysis.DecodeWellKnownAttributeArguments<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData, Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation>
                arguments)
                {
                    this_param.DecodeDefaultParameterValueAttribute(description, ref arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 29796, 29900);
                    return 0;
                }


                bool
                f_10240_29939_30019(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 29939, 30019);
                    return return_v;
                }


                int
                f_10240_30155_30253(Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                this_param, Microsoft.CodeAnalysis.AttributeDescription
                description, ref Microsoft.CodeAnalysis.DecodeWellKnownAttributeArguments<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData, Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation>
                arguments)
                {
                    this_param.DecodeDefaultParameterValueAttribute(description, ref arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 30155, 30253);
                    return 0;
                }


                bool
                f_10240_30292_30373(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 30292, 30373);
                    return return_v;
                }


                int
                f_10240_30509_30608(Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                this_param, Microsoft.CodeAnalysis.AttributeDescription
                description, ref Microsoft.CodeAnalysis.DecodeWellKnownAttributeArguments<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData, Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation>
                arguments)
                {
                    this_param.DecodeDefaultParameterValueAttribute(description, ref arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 30509, 30608);
                    return 0;
                }


                bool
                f_10240_30647_30720(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 30647, 30720);
                    return return_v;
                }


                int
                f_10240_30754_30812(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 30754, 30812);
                    return 0;
                }


                bool
                f_10240_30837_30861()
                {
                    var return_v = HasDefaultArgumentSyntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 30837, 30861);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10240_31119_31152(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 31119, 31152);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10240_31119_31161(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 31119, 31161);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10240_31047_31162(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 31047, 31162);
                    return return_v;
                }


                bool
                f_10240_31220_31295(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 31220, 31295);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10240_31498_31531(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 31498, 31531);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10240_31498_31540(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 31498, 31540);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10240_31438_31541(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 31438, 31541);
                    return return_v;
                }


                bool
                f_10240_31580_31647(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 31580, 31647);
                    return return_v;
                }


                bool
                f_10240_31802_31870(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 31802, 31870);
                    return return_v;
                }


                bool
                f_10240_32026_32100(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 32026, 32100);
                    return return_v;
                }


                int
                f_10240_32134_32325(ref Microsoft.CodeAnalysis.DecodeWellKnownAttributeArguments<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData, Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation>
                arguments, System.AttributeTargets
                target, Microsoft.CodeAnalysis.CSharp.MessageProvider
                messageProvider)
                {
                    MarshalAsAttributeDecoder<ParameterWellKnownAttributeData, AttributeSyntax, CSharpAttributeData, AttributeLocation>.Decode(ref arguments, target, (Microsoft.CodeAnalysis.CommonMessageProvider)messageProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 32134, 32325);
                    return 0;
                }


                bool
                f_10240_32364_32446(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 32364, 32446);
                    return return_v;
                }


                bool
                f_10240_32616_32697(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 32616, 32697);
                    return return_v;
                }


                bool
                f_10240_32866_32947(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 32866, 32947);
                    return return_v;
                }


                int
                f_10240_32981_33067(Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.ValidateCallerLineNumberAttribute(node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 32981, 33067);
                    return 0;
                }


                bool
                f_10240_33106_33185(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 33106, 33185);
                    return return_v;
                }


                int
                f_10240_33219_33303(Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.ValidateCallerFilePathAttribute(node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 33219, 33303);
                    return 0;
                }


                bool
                f_10240_33342_33423(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 33342, 33423);
                    return return_v;
                }


                int
                f_10240_33457_33543(Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.ValidateCallerMemberNameAttribute(node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 33457, 33543);
                    return 0;
                }


                bool
                f_10240_33582_33943(Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                this_param, Microsoft.CodeAnalysis.DecodeWellKnownAttributeArguments<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData, Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation>
                arguments, Microsoft.CodeAnalysis.CSharp.Symbol.ReservedAttributes
                reserved)
                {
                    var return_v = this_param.ReportExplicitUseOfReservedAttributes(arguments, reserved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 33582, 33943);
                    return return_v;
                }


                bool
                f_10240_33997_34071(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 33997, 34071);
                    return return_v;
                }


                bool
                f_10240_34233_34310(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 34233, 34310);
                    return return_v;
                }


                bool
                f_10240_34475_34549(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 34475, 34549);
                    return return_v;
                }


                bool
                f_10240_34711_34789(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 34711, 34789);
                    return return_v;
                }


                bool?
                f_10240_34909_35046(Microsoft.CodeAnalysis.AttributeDescription
                description, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                attribute, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = DecodeMaybeNullWhenOrNotNullWhenOrDoesNotReturnIfAttribute(description, attribute, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 34909, 35046);
                    return return_v;
                }


                bool
                f_10240_35085_35157(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 35085, 35157);
                    return return_v;
                }


                bool
                f_10240_35317_35393(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 35317, 35393);
                    return return_v;
                }


                bool?
                f_10240_35511_35646(Microsoft.CodeAnalysis.AttributeDescription
                description, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                attribute, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = DecodeMaybeNullWhenOrNotNullWhenOrDoesNotReturnIfAttribute(description, attribute, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 35511, 35646);
                    return return_v;
                }


                bool
                f_10240_35685_35765(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 35685, 35765);
                    return return_v;
                }


                bool?
                f_10240_35887_36026(Microsoft.CodeAnalysis.AttributeDescription
                description, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                attribute, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = DecodeMaybeNullWhenOrNotNullWhenOrDoesNotReturnIfAttribute(description, attribute, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 35887, 36026);
                    return return_v;
                }


                bool
                f_10240_36065_36146(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 36065, 36146);
                    return return_v;
                }


                string?
                f_10240_36270_36313(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                attribute)
                {
                    var return_v = attribute.DecodeNotNullIfNotNullAttribute();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 36270, 36313);
                    return return_v;
                }


                int
                f_10240_36180_36314(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterWellKnownAttributeData
                this_param, string?
                parameterName)
                {
                    this_param.AddNotNullIfParameterNotNull(parameterName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 36180, 36314);
                    return 0;
                }


                bool
                f_10240_36353_36440(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 36353, 36440);
                    return return_v;
                }


                int
                f_10240_36595_36682(Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.ValidateCancellationTokenAttribute(node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 36595, 36682);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10240, 29141, 36709);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10240, 29141, 36709);
            }
        }

        private static bool? DecodeMaybeNullWhenOrNotNullWhenOrDoesNotReturnIfAttribute(AttributeDescription description, CSharpAttributeData attribute, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10240, 36721, 37155);
                bool value = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 36917, 36970);

                var
                arguments = f_10240_36933_36969(attribute)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 36984, 37144);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10240, 36991, 37087) || ((arguments.Length == 1 && (DynAbs.Tracing.TraceSender.Expression_True(10240, 36991, 37087) && arguments[0].TryDecodeValue(SpecialType.System_Boolean, out value
                )) && DynAbs.Tracing.TraceSender.Conditional_F2(10240, 37107, 37119)) || DynAbs.Tracing.TraceSender.Conditional_F3(10240, 37139, 37143))) ? (bool?)value : null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10240, 36721, 37155);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10240_36933_36969(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.CommonConstructorArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 36933, 36969);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10240, 36721, 37155);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10240, 36721, 37155);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void DecodeDefaultParameterValueAttribute(AttributeDescription description, ref DecodeWellKnownAttributeArguments<AttributeSyntax, CSharpAttributeData, AttributeLocation> arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10240, 37167, 37925);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 37381, 37417);

                var
                attribute = arguments.Attribute
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 37431, 37473);

                var
                syntax = arguments.AttributeSyntaxOpt
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 37487, 37527);

                var
                diagnostics = arguments.Diagnostics
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 37543, 37572);

                f_10240_37543_37571(syntax != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 37586, 37620);

                f_10240_37586_37619(diagnostics != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 37636, 37762);

                var
                value = f_10240_37648_37761(this, description, attribute, syntax, diagnose: true, diagnosticsOpt: diagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 37776, 37914) || true) && (f_10240_37780_37792_M(!value.IsBad))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 37776, 37914);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 37826, 37899);

                    f_10240_37826_37898(this, value, syntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 37776, 37914);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10240, 37167, 37925);

                int
                f_10240_37543_37571(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 37543, 37571);
                    return 0;
                }


                int
                f_10240_37586_37619(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 37586, 37619);
                    return 0;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10240_37648_37761(Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                this_param, Microsoft.CodeAnalysis.AttributeDescription
                description, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                attribute, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                node, bool
                diagnose, Microsoft.CodeAnalysis.DiagnosticBag
                diagnosticsOpt)
                {
                    var return_v = this_param.DecodeDefaultParameterValueAttribute(description, attribute, node, diagnose: diagnose, diagnosticsOpt: diagnosticsOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 37648, 37761);
                    return return_v;
                }


                bool
                f_10240_37780_37792_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 37780, 37792);
                    return return_v;
                }


                int
                f_10240_37826_37898(Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                this_param, Microsoft.CodeAnalysis.ConstantValue
                value, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.VerifyParamDefaultValueMatchesAttributeIfAny(value, (Microsoft.CodeAnalysis.SyntaxNode)syntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 37826, 37898);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10240, 37167, 37925);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10240, 37167, 37925);
            }
        }

        private void VerifyParamDefaultValueMatchesAttributeIfAny(ConstantValue value, SyntaxNode syntax, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10240, 38248, 38913);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 38397, 38448);

                var
                data = f_10240_38408_38447(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 38462, 38902) || true) && (data != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 38462, 38902);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 38512, 38555);

                    var
                    attrValue = f_10240_38528_38554(data)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 38573, 38887) || true) && ((attrValue != f_10240_38591_38610()) && (DynAbs.Tracing.TraceSender.Expression_True(10240, 38577, 38656) && (value != attrValue)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 38573, 38887);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 38782, 38868);

                        f_10240_38782_38867(                    // CS8017: The parameter has multiple distinct default values.
                                            diagnostics, ErrorCode.ERR_ParamDefaultValueDiffersFromAttribute, f_10240_38851_38866(syntax));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 38573, 38887);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 38462, 38902);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10240, 38248, 38913);

                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterEarlyWellKnownAttributeData
                f_10240_38408_38447(Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                this_param)
                {
                    var return_v = this_param.GetEarlyDecodedWellKnownAttributeData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 38408, 38447);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10240_38528_38554(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterEarlyWellKnownAttributeData
                this_param)
                {
                    var return_v = this_param.DefaultParameterValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 38528, 38554);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10240_38591_38610()
                {
                    var return_v = ConstantValue.Unset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 38591, 38610);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10240_38851_38866(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 38851, 38866);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10240_38782_38867(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 38782, 38867);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10240, 38248, 38913);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10240, 38248, 38913);
            }
        }

        private ConstantValue DecodeDefaultParameterValueAttribute(AttributeDescription description, CSharpAttributeData attribute, AttributeSyntax node, bool diagnose, DiagnosticBag diagnosticsOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10240, 38925, 39808);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 39140, 39175);

                f_10240_39140_39174(f_10240_39153_39173_M(!attribute.HasErrors));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 39191, 39797) || true) && (f_10240_39195_39266(ref description, AttributeDescription.DefaultParameterValueAttribute))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 39191, 39797);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 39300, 39387);

                    return f_10240_39307_39386(this, attribute, node, diagnose, diagnosticsOpt);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 39191, 39797);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 39191, 39797);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 39421, 39797) || true) && (f_10240_39425_39490(ref description, AttributeDescription.DecimalConstantAttribute))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 39421, 39797);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 39524, 39570);

                        return f_10240_39531_39569(attribute);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 39421, 39797);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 39421, 39797);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 39636, 39717);

                        f_10240_39636_39716(f_10240_39649_39715(ref description, AttributeDescription.DateTimeConstantAttribute));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 39735, 39782);

                        return f_10240_39742_39781(attribute);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 39421, 39797);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 39191, 39797);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10240, 38925, 39808);

                bool
                f_10240_39153_39173_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 39153, 39173);
                    return return_v;
                }


                int
                f_10240_39140_39174(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 39140, 39174);
                    return 0;
                }


                bool
                f_10240_39195_39266(ref Microsoft.CodeAnalysis.AttributeDescription
                this_param, Microsoft.CodeAnalysis.AttributeDescription
                obj)
                {
                    var return_v = this_param.Equals((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 39195, 39266);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10240_39307_39386(Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                attribute, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                node, bool
                diagnose, Microsoft.CodeAnalysis.DiagnosticBag
                diagnosticsOpt)
                {
                    var return_v = this_param.DecodeDefaultParameterValueAttribute(attribute, node, diagnose, diagnosticsOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 39307, 39386);
                    return return_v;
                }


                bool
                f_10240_39425_39490(ref Microsoft.CodeAnalysis.AttributeDescription
                this_param, Microsoft.CodeAnalysis.AttributeDescription
                obj)
                {
                    var return_v = this_param.Equals((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 39425, 39490);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10240_39531_39569(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.DecodeDecimalConstantValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 39531, 39569);
                    return return_v;
                }


                bool
                f_10240_39649_39715(ref Microsoft.CodeAnalysis.AttributeDescription
                this_param, Microsoft.CodeAnalysis.AttributeDescription
                obj)
                {
                    var return_v = this_param.Equals((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 39649, 39715);
                    return return_v;
                }


                int
                f_10240_39636_39716(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 39636, 39716);
                    return 0;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10240_39742_39781(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.DecodeDateTimeConstantValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 39742, 39781);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10240, 38925, 39808);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10240, 38925, 39808);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ConstantValue DecodeDefaultParameterValueAttribute(CSharpAttributeData attribute, AttributeSyntax node, bool diagnose, DiagnosticBag diagnosticsOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10240, 39820, 44155);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 40001, 40051);

                f_10240_40001_40050(!diagnose || (DynAbs.Tracing.TraceSender.Expression_False(10240, 40014, 40049) || diagnosticsOpt != null));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 40067, 40485) || true) && (f_10240_40071_40095())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 40067, 40485);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 40269, 40427) || true) && (diagnose)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 40269, 40427);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 40323, 40408);

                        f_10240_40323_40407(diagnosticsOpt, ErrorCode.ERR_DefaultValueUsedWithAttributes, f_10240_40388_40406(f_10240_40388_40397(node)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 40269, 40427);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 40445, 40470);

                    return f_10240_40452_40469();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 40067, 40485);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 41336, 41399);

                f_10240_41336_41398(attribute.CommonConstructorArguments.Length == 1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 41501, 41551);

                var
                arg = f_10240_41511_41547(attribute)[0]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 41567, 41762);

                SpecialType
                specialType = (DynAbs.Tracing.TraceSender.Conditional_F1(10240, 41593, 41627) || ((arg.Kind == TypedConstantKind.Enum && DynAbs.Tracing.TraceSender.Conditional_F2(10240, 41647, 41713)) || DynAbs.Tracing.TraceSender.Conditional_F3(10240, 41733, 41761))) ? f_10240_41647_41713(f_10240_41647_41701(((NamedTypeSymbol)arg.TypeInternal))) : f_10240_41733_41761(arg.TypeInternal)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 41778, 41822);

                var
                compilation = f_10240_41796_41821(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 41836, 41913);

                var
                constantValueDiscriminator = f_10240_41869_41912(specialType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 41927, 41977);

                HashSet<DiagnosticInfo>
                useSiteDiagnostics = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 41991, 43917) || true) && (constantValueDiscriminator == ConstantValueTypeDiscriminator.Bad)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 41991, 43917);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 42093, 43281) || true) && (arg.Kind != TypedConstantKind.Array && (DynAbs.Tracing.TraceSender.Expression_True(10240, 42097, 42161) && arg.ValueInternal == null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 42093, 43281);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 42203, 42832) || true) && (f_10240_42207_42232(f_10240_42207_42216(this)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 42203, 42832);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 42282, 42347);

                            constantValueDiscriminator = ConstantValueTypeDiscriminator.Null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 42203, 42832);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 42203, 42832);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 42581, 42758) || true) && (diagnose)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 42581, 42758);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 42651, 42731);

                                f_10240_42651_42730(diagnosticsOpt, ErrorCode.ERR_DefaultValueTypeMustMatch, f_10240_42711_42729(f_10240_42711_42720(node)));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 42581, 42758);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 42784, 42809);

                            return f_10240_42791_42808();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 42203, 42832);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 42093, 43281);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 42093, 43281);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 43033, 43215) || true) && (diagnose)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 43033, 43215);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 43095, 43192);

                            f_10240_43095_43191(diagnosticsOpt, ErrorCode.ERR_DefaultValueBadValueType, f_10240_43154_43172(f_10240_43154_43163(node)), arg.TypeInternal);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 43033, 43215);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 43237, 43262);

                        return f_10240_43244_43261();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 42093, 43281);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 41991, 43917);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 41991, 43917);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 43315, 43917) || true) && (!f_10240_43320_43463(f_10240_43320_43435(f_10240_43320_43343(compilation), arg.TypeInternal, f_10240_43401_43410(this), ref useSiteDiagnostics).Kind))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 43315, 43917);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 43625, 43859) || true) && (diagnose)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 43625, 43859);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 43679, 43759);

                            f_10240_43679_43758(diagnosticsOpt, ErrorCode.ERR_DefaultValueTypeMustMatch, f_10240_43739_43757(f_10240_43739_43748(node)));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 43781, 43840);

                            f_10240_43781_43839(diagnosticsOpt, f_10240_43800_43818(f_10240_43800_43809(node)), useSiteDiagnostics);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 43625, 43859);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 43877, 43902);

                        return f_10240_43884_43901();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 43315, 43917);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 41991, 43917);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 43933, 44053) || true) && (diagnose)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 43933, 44053);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 43979, 44038);

                    f_10240_43979_44037(diagnosticsOpt, f_10240_43998_44016(f_10240_43998_44007(node)), useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 43933, 44053);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 44069, 44144);

                return f_10240_44076_44143(arg.ValueInternal, constantValueDiscriminator);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10240, 39820, 44155);

                int
                f_10240_40001_40050(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 40001, 40050);
                    return 0;
                }


                bool
                f_10240_40071_40095()
                {
                    var return_v = HasDefaultArgumentSyntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 40071, 40095);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10240_40388_40397(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 40388, 40397);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10240_40388_40406(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 40388, 40406);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10240_40323_40407(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 40323, 40407);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10240_40452_40469()
                {
                    var return_v = ConstantValue.Bad;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 40452, 40469);
                    return return_v;
                }


                int
                f_10240_41336_41398(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 41336, 41398);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10240_41511_41547(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.CommonConstructorArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 41511, 41547);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10240_41647_41701(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                this_param)
                {
                    var return_v = this_param.EnumUnderlyingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 41647, 41701);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10240_41647_41713(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 41647, 41713);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10240_41733_41761(Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal?
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 41733, 41761);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10240_41796_41821(Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 41796, 41821);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
                f_10240_41869_41912(Microsoft.CodeAnalysis.SpecialType
                st)
                {
                    var return_v = ConstantValue.GetDiscriminator(st);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 41869, 41912);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10240_42207_42216(Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 42207, 42216);
                    return return_v;
                }


                bool
                f_10240_42207_42232(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsReferenceType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 42207, 42232);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10240_42711_42720(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 42711, 42720);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10240_42711_42729(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 42711, 42729);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10240_42651_42730(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 42651, 42730);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10240_42791_42808()
                {
                    var return_v = ConstantValue.Bad;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 42791, 42808);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10240_43154_43163(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 43154, 43163);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10240_43154_43172(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 43154, 43172);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10240_43095_43191(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 43095, 43191);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10240_43244_43261()
                {
                    var return_v = ConstantValue.Bad;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 43244, 43261);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10240_43320_43343(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Conversions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 43320, 43343);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10240_43401_43410(Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 43401, 43410);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10240_43320_43435(Microsoft.CodeAnalysis.CSharp.Conversions
                this_param, Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyConversionFromType((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 43320, 43435);
                    return return_v;
                }


                bool
                f_10240_43320_43463(Microsoft.CodeAnalysis.CSharp.ConversionKind
                conversionKind)
                {
                    var return_v = conversionKind.IsImplicitConversion();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 43320, 43463);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10240_43739_43748(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 43739, 43748);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10240_43739_43757(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 43739, 43757);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10240_43679_43758(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 43679, 43758);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10240_43800_43809(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 43800, 43809);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10240_43800_43818(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 43800, 43818);
                    return return_v;
                }


                bool
                f_10240_43781_43839(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add(location, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 43781, 43839);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10240_43884_43901()
                {
                    var return_v = ConstantValue.Bad;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 43884, 43901);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10240_43998_44007(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 43998, 44007);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10240_43998_44016(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 43998, 44016);
                    return return_v;
                }


                bool
                f_10240_43979_44037(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add(location, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 43979, 44037);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10240_44076_44143(object?
                value, Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
                discriminator)
                {
                    var return_v = ConstantValue.Create(value, discriminator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 44076, 44143);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10240, 39820, 44155);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10240, 39820, 44155);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool IsValidCallerInfoContext(AttributeSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10240, 44227, 44491);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 44230, 44491);
                return !f_10240_44231_44283(f_10240_44231_44247()) && (DynAbs.Tracing.TraceSender.Expression_True(10240, 44230, 44386) && !f_10240_44357_44386(f_10240_44357_44373())) && (DynAbs.Tracing.TraceSender.Expression_True(10240, 44230, 44491) && !f_10240_44460_44491(this, node)); DynAbs.Tracing.TraceSender.TraceExitMethod(10240, 44227, 44491);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10240, 44227, 44491);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10240, 44227, 44491);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Symbol
            f_10240_44231_44247()
            {
                var return_v = ContainingSymbol;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 44231, 44247);
                return return_v;
            }


            bool
            f_10240_44231_44283(Microsoft.CodeAnalysis.CSharp.Symbol
            member)
            {
                var return_v = member.IsExplicitInterfaceImplementation();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 44231, 44283);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Symbol
            f_10240_44357_44373()
            {
                var return_v = ContainingSymbol;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 44357, 44373);
                return return_v;
            }


            bool
            f_10240_44357_44386(Microsoft.CodeAnalysis.CSharp.Symbol
            symbol)
            {
                var return_v = symbol.IsOperator();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 44357, 44386);
                return return_v;
            }


            bool
            f_10240_44460_44491(Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
            this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
            node)
            {
                var return_v = this_param.IsOnPartialImplementation(node);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 44460, 44491);
                return return_v;
            }

        }

        private bool IsOnPartialImplementation(AttributeSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10240, 44953, 45898);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 45038, 45084);

                var
                method = f_10240_45051_45067() as MethodSymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 45098, 45139) || true) && ((object)method == null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 45098, 45139);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 45126, 45139);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 45098, 45139);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 45153, 45241);

                var
                impl = (DynAbs.Tracing.TraceSender.Conditional_F1(10240, 45164, 45196) || ((f_10240_45164_45196(method) && DynAbs.Tracing.TraceSender.Conditional_F2(10240, 45199, 45205)) || DynAbs.Tracing.TraceSender.Conditional_F3(10240, 45208, 45240))) ? method : f_10240_45208_45240(method)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 45255, 45294) || true) && ((object)impl == null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 45255, 45294);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 45281, 45294);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 45255, 45294);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 45308, 45511);

                var
                paramList =
                f_10240_45341_45487(f_10240_45341_45442(f_10240_45341_45393(node))) as ParameterListSyntax
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 45548, 45584) || true) && (paramList == null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 45548, 45584);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 45571, 45584);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 45548, 45584);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 45598, 45657);

                var
                methDecl = f_10240_45613_45629(paramList) as MethodDeclarationSyntax
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 45671, 45706) || true) && (methDecl == null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 45671, 45706);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 45693, 45706);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 45671, 45706);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 45720, 45860);
                    foreach (var r in f_10240_45738_45768_I(f_10240_45738_45768(impl)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 45720, 45860);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 45802, 45845) || true) && (f_10240_45806_45819(r) == methDecl)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 45802, 45845);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 45833, 45845);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 45802, 45845);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 45720, 45860);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10240, 1, 141);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10240, 1, 141);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 45874, 45887);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10240, 44953, 45898);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10240_45051_45067()
                {
                    var return_v = ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 45051, 45067);
                    return return_v;
                }


                bool
                f_10240_45164_45196(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                member)
                {
                    var return_v = member.IsPartialImplementation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 45164, 45196);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10240_45208_45240(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.PartialImplementationPart;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 45208, 45240);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10240_45341_45393(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Parent  // AttributeListSyntax
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 45341, 45393);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10240_45341_45442(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                this_param)
                {
                    var return_v = this_param.Parent  // ParameterSyntax
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 45341, 45442);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10240_45341_45487(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 45341, 45487);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10240_45613_45629(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 45613, 45629);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
                f_10240_45738_45768(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringSyntaxReferences;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 45738, 45768);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10240_45806_45819(Microsoft.CodeAnalysis.SyntaxReference
                this_param)
                {
                    var return_v = this_param.GetSyntax();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 45806, 45819);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
                f_10240_45738_45768_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 45738, 45768);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10240, 44953, 45898);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10240, 44953, 45898);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void ValidateCallerLineNumberAttribute(AttributeSyntax node, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10240, 45910, 47723);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 46030, 46088);

                CSharpCompilation
                compilation = f_10240_46062_46087(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 46102, 46152);

                HashSet<DiagnosticInfo>
                useSiteDiagnostics = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 46168, 47640) || true) && (!f_10240_46173_46203(this, node))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 46168, 47640);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 46463, 46596);

                    f_10240_46463_46595(                // CS4024: The CallerLineNumberAttribute applied to parameter '{0}' will have no effect because it applies to a
                                                        //         member that is used in contexts that do not allow optional arguments
                                    diagnostics, ErrorCode.WRN_CallerLineNumberParamForUnconsumedLocation, f_10240_46537_46555(f_10240_46537_46546(node)), f_10240_46557_46573().Identifier.ValueText);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 46168, 47640);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 46168, 47640);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 46630, 47640) || true) && (!f_10240_46635_46738(f_10240_46635_46658(compilation), f_10240_46689_46708().Type, ref useSiteDiagnostics))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 46630, 47640);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 46916, 46990);

                        TypeSymbol
                        intType = f_10240_46937_46989(compilation, SpecialType.System_Int32)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 47008, 47131);

                        f_10240_47008_47130(diagnostics, ErrorCode.ERR_NoConversionForCallerLineNumberParam, f_10240_47076_47094(f_10240_47076_47085(node)), intType, f_10240_47105_47124().Type);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 46630, 47640);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 46630, 47640);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 47165, 47640) || true) && (f_10240_47169_47193_M(!HasExplicitDefaultValue) && (DynAbs.Tracing.TraceSender.Expression_True(10240, 47169, 47240) && !f_10240_47198_47240(f_10240_47198_47214())))
                        ) // attribute applied to parameter without default

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 47165, 47640);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 47530, 47625);

                            f_10240_47530_47624(                // Unconsumed location checks happen first, so we require a default value.

                                            // CS4020: The CallerLineNumberAttribute may only be applied to parameters with default values
                                            diagnostics, ErrorCode.ERR_BadCallerLineNumberParamWithoutDefaultValue, f_10240_47605_47623(f_10240_47605_47614(node)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 47165, 47640);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 46630, 47640);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 46168, 47640);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 47656, 47712);

                f_10240_47656_47711(
                            diagnostics, f_10240_47672_47690(f_10240_47672_47681(node)), useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10240, 45910, 47723);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10240_46062_46087(Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 46062, 46087);
                    return return_v;
                }


                bool
                f_10240_46173_46203(Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                node)
                {
                    var return_v = this_param.IsValidCallerInfoContext(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 46173, 46203);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10240_46537_46546(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 46537, 46546);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10240_46537_46555(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 46537, 46555);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                f_10240_46557_46573()
                {
                    var return_v = CSharpSyntaxNode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 46557, 46573);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10240_46463_46595(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 46463, 46595);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10240_46635_46658(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Conversions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 46635, 46658);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10240_46689_46708()
                {
                    var return_v = TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 46689, 46708);
                    return return_v;
                }


                bool
                f_10240_46635_46738(Microsoft.CodeAnalysis.CSharp.Conversions
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = this_param.HasCallerLineNumberConversion(destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 46635, 46738);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10240_46937_46989(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 46937, 46989);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10240_47076_47085(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 47076, 47085);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10240_47076_47094(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 47076, 47094);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10240_47105_47124()
                {
                    var return_v = TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 47105, 47124);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10240_47008_47130(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 47008, 47130);
                    return return_v;
                }


                bool
                f_10240_47169_47193_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 47169, 47193);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10240_47198_47214()
                {
                    var return_v = ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 47198, 47214);
                    return return_v;
                }


                bool
                f_10240_47198_47240(Microsoft.CodeAnalysis.CSharp.Symbol
                member)
                {
                    var return_v = member.IsPartialImplementation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 47198, 47240);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10240_47605_47614(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 47605, 47614);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10240_47605_47623(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 47605, 47623);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10240_47530_47624(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 47530, 47624);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10240_47672_47681(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 47672, 47681);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10240_47672_47690(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 47672, 47690);
                    return return_v;
                }


                bool
                f_10240_47656_47711(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add(location, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 47656, 47711);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10240, 45910, 47723);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10240, 45910, 47723);
            }
        }

        private void ValidateCallerFilePathAttribute(AttributeSyntax node, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10240, 47735, 49930);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 47853, 47911);

                CSharpCompilation
                compilation = f_10240_47885_47910(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 47925, 47975);

                HashSet<DiagnosticInfo>
                useSiteDiagnostics = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 47991, 49847) || true) && (!f_10240_47996_48026(this, node))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 47991, 49847);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 48284, 48415);

                    f_10240_48284_48414(                // CS4025: The CallerFilePathAttribute applied to parameter '{0}' will have no effect because it applies to a
                                                        //         member that is used in contexts that do not allow optional arguments
                                    diagnostics, ErrorCode.WRN_CallerFilePathParamForUnconsumedLocation, f_10240_48356_48374(f_10240_48356_48365(node)), f_10240_48376_48392().Identifier.ValueText);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 47991, 49847);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 47991, 49847);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 48449, 49847) || true) && (!f_10240_48454_48557(f_10240_48454_48477(compilation), f_10240_48508_48527().Type, ref useSiteDiagnostics))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 48449, 49847);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 48733, 48811);

                        TypeSymbol
                        stringType = f_10240_48757_48810(compilation, SpecialType.System_String)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 48829, 48953);

                        f_10240_48829_48952(diagnostics, ErrorCode.ERR_NoConversionForCallerFilePathParam, f_10240_48895_48913(f_10240_48895_48904(node)), stringType, f_10240_48927_48946().Type);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 48449, 49847);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 48449, 49847);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 48987, 49847) || true) && (f_10240_48991_49015_M(!HasExplicitDefaultValue) && (DynAbs.Tracing.TraceSender.Expression_True(10240, 48991, 49062) && !f_10240_49020_49062(f_10240_49020_49036())))
                        ) // attribute applied to parameter without default

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 48987, 49847);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 49350, 49443);

                            f_10240_49350_49442(                // Unconsumed location checks happen first, so we require a default value.

                                            // CS4021: The CallerFilePathAttribute may only be applied to parameters with default values
                                            diagnostics, ErrorCode.ERR_BadCallerFilePathParamWithoutDefaultValue, f_10240_49423_49441(f_10240_49423_49432(node)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 48987, 49847);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 48987, 49847);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 49477, 49847) || true) && (f_10240_49481_49509())
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 49477, 49847);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 49698, 49832);

                                f_10240_49698_49831(                // CS7082: The CallerFilePathAttribute applied to parameter '{0}' will have no effect. It is overridden by the CallerLineNumberAttribute.
                                                diagnostics, ErrorCode.WRN_CallerLineNumberPreferredOverCallerFilePath, f_10240_49773_49791(f_10240_49773_49782(node)), f_10240_49793_49809().Identifier.ValueText);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 49477, 49847);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 48987, 49847);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 48449, 49847);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 47991, 49847);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 49863, 49919);

                f_10240_49863_49918(
                            diagnostics, f_10240_49879_49897(f_10240_49879_49888(node)), useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10240, 47735, 49930);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10240_47885_47910(Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 47885, 47910);
                    return return_v;
                }


                bool
                f_10240_47996_48026(Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                node)
                {
                    var return_v = this_param.IsValidCallerInfoContext(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 47996, 48026);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10240_48356_48365(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 48356, 48365);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10240_48356_48374(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 48356, 48374);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                f_10240_48376_48392()
                {
                    var return_v = CSharpSyntaxNode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 48376, 48392);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10240_48284_48414(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 48284, 48414);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10240_48454_48477(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Conversions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 48454, 48477);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10240_48508_48527()
                {
                    var return_v = TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 48508, 48527);
                    return return_v;
                }


                bool
                f_10240_48454_48557(Microsoft.CodeAnalysis.CSharp.Conversions
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = this_param.HasCallerInfoStringConversion(destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 48454, 48557);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10240_48757_48810(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 48757, 48810);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10240_48895_48904(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 48895, 48904);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10240_48895_48913(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 48895, 48913);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10240_48927_48946()
                {
                    var return_v = TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 48927, 48946);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10240_48829_48952(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 48829, 48952);
                    return return_v;
                }


                bool
                f_10240_48991_49015_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 48991, 49015);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10240_49020_49036()
                {
                    var return_v = ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 49020, 49036);
                    return return_v;
                }


                bool
                f_10240_49020_49062(Microsoft.CodeAnalysis.CSharp.Symbol
                member)
                {
                    var return_v = member.IsPartialImplementation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 49020, 49062);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10240_49423_49432(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 49423, 49432);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10240_49423_49441(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 49423, 49441);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10240_49350_49442(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 49350, 49442);
                    return return_v;
                }


                bool
                f_10240_49481_49509()
                {
                    var return_v = HasCallerLineNumberAttribute;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 49481, 49509);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10240_49773_49782(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 49773, 49782);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10240_49773_49791(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 49773, 49791);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                f_10240_49793_49809()
                {
                    var return_v = CSharpSyntaxNode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 49793, 49809);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10240_49698_49831(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 49698, 49831);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10240_49879_49888(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 49879, 49888);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10240_49879_49897(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 49879, 49897);
                    return return_v;
                }


                bool
                f_10240_49863_49918(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add(location, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 49863, 49918);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10240, 47735, 49930);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10240, 47735, 49930);
            }
        }

        private void ValidateCallerMemberNameAttribute(AttributeSyntax node, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10240, 49942, 52542);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 50062, 50120);

                CSharpCompilation
                compilation = f_10240_50094_50119(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 50134, 50184);

                HashSet<DiagnosticInfo>
                useSiteDiagnostics = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 50200, 52459) || true) && (!f_10240_50205_50235(this, node))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 50200, 52459);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 50495, 50628);

                    f_10240_50495_50627(                // CS4026: The CallerMemberNameAttribute applied to parameter '{0}' will have no effect because it applies to a
                                                        //         member that is used in contexts that do not allow optional arguments
                                    diagnostics, ErrorCode.WRN_CallerMemberNameParamForUnconsumedLocation, f_10240_50569_50587(f_10240_50569_50578(node)), f_10240_50589_50605().Identifier.ValueText);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 50200, 52459);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 50200, 52459);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 50662, 52459) || true) && (!f_10240_50667_50770(f_10240_50667_50690(compilation), f_10240_50721_50740().Type, ref useSiteDiagnostics))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 50662, 52459);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 50948, 51026);

                        TypeSymbol
                        stringType = f_10240_50972_51025(compilation, SpecialType.System_String)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 51044, 51170);

                        f_10240_51044_51169(diagnostics, ErrorCode.ERR_NoConversionForCallerMemberNameParam, f_10240_51112_51130(f_10240_51112_51121(node)), stringType, f_10240_51144_51163().Type);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 50662, 52459);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 50662, 52459);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 51204, 52459) || true) && (f_10240_51208_51232_M(!HasExplicitDefaultValue) && (DynAbs.Tracing.TraceSender.Expression_True(10240, 51208, 51279) && !f_10240_51237_51279(f_10240_51237_51253())))
                        ) // attribute applied to parameter without default

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 51204, 52459);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 51569, 51664);

                            f_10240_51569_51663(                // Unconsumed location checks happen first, so we require a default value.

                                            // CS4022: The CallerMemberNameAttribute may only be applied to parameters with default values
                                            diagnostics, ErrorCode.ERR_BadCallerMemberNameParamWithoutDefaultValue, f_10240_51644_51662(f_10240_51644_51653(node)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 51204, 52459);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 51204, 52459);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 51698, 52459) || true) && (f_10240_51702_51730())
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 51698, 52459);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 51921, 52057);

                                f_10240_51921_52056(                // CS7081: The CallerMemberNameAttribute applied to parameter '{0}' will have no effect. It is overridden by the CallerLineNumberAttribute.
                                                diagnostics, ErrorCode.WRN_CallerLineNumberPreferredOverCallerMemberName, f_10240_51998_52016(f_10240_51998_52007(node)), f_10240_52018_52034().Identifier.ValueText);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 51698, 52459);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 51698, 52459);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 52091, 52459) || true) && (f_10240_52095_52121())
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 52091, 52459);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 52310, 52444);

                                    f_10240_52310_52443(                // CS7080: The CallerMemberNameAttribute applied to parameter '{0}' will have no effect. It is overridden by the CallerFilePathAttribute.
                                                    diagnostics, ErrorCode.WRN_CallerFilePathPreferredOverCallerMemberName, f_10240_52385_52403(f_10240_52385_52394(node)), f_10240_52405_52421().Identifier.ValueText);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 52091, 52459);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 51698, 52459);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 51204, 52459);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 50662, 52459);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 50200, 52459);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 52475, 52531);

                f_10240_52475_52530(
                            diagnostics, f_10240_52491_52509(f_10240_52491_52500(node)), useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10240, 49942, 52542);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10240_50094_50119(Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 50094, 50119);
                    return return_v;
                }


                bool
                f_10240_50205_50235(Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                node)
                {
                    var return_v = this_param.IsValidCallerInfoContext(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 50205, 50235);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10240_50569_50578(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 50569, 50578);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10240_50569_50587(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 50569, 50587);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                f_10240_50589_50605()
                {
                    var return_v = CSharpSyntaxNode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 50589, 50605);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10240_50495_50627(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 50495, 50627);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10240_50667_50690(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Conversions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 50667, 50690);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10240_50721_50740()
                {
                    var return_v = TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 50721, 50740);
                    return return_v;
                }


                bool
                f_10240_50667_50770(Microsoft.CodeAnalysis.CSharp.Conversions
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = this_param.HasCallerInfoStringConversion(destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 50667, 50770);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10240_50972_51025(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 50972, 51025);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10240_51112_51121(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 51112, 51121);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10240_51112_51130(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 51112, 51130);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10240_51144_51163()
                {
                    var return_v = TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 51144, 51163);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10240_51044_51169(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 51044, 51169);
                    return return_v;
                }


                bool
                f_10240_51208_51232_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 51208, 51232);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10240_51237_51253()
                {
                    var return_v = ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 51237, 51253);
                    return return_v;
                }


                bool
                f_10240_51237_51279(Microsoft.CodeAnalysis.CSharp.Symbol
                member)
                {
                    var return_v = member.IsPartialImplementation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 51237, 51279);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10240_51644_51653(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 51644, 51653);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10240_51644_51662(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 51644, 51662);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10240_51569_51663(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 51569, 51663);
                    return return_v;
                }


                bool
                f_10240_51702_51730()
                {
                    var return_v = HasCallerLineNumberAttribute;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 51702, 51730);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10240_51998_52007(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 51998, 52007);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10240_51998_52016(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 51998, 52016);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                f_10240_52018_52034()
                {
                    var return_v = CSharpSyntaxNode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 52018, 52034);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10240_51921_52056(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 51921, 52056);
                    return return_v;
                }


                bool
                f_10240_52095_52121()
                {
                    var return_v = HasCallerFilePathAttribute;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 52095, 52121);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10240_52385_52394(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 52385, 52394);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10240_52385_52403(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 52385, 52403);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                f_10240_52405_52421()
                {
                    var return_v = CSharpSyntaxNode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 52405, 52421);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10240_52310_52443(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 52310, 52443);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10240_52491_52500(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 52491, 52500);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10240_52491_52509(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 52491, 52509);
                    return return_v;
                }


                bool
                f_10240_52475_52530(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add(location, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 52475, 52530);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10240, 49942, 52542);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10240, 49942, 52542);
            }
        }

        private void ValidateCancellationTokenAttribute(AttributeSyntax node, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10240, 52554, 53661);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 52675, 52881) || true) && (f_10240_52679_52695())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 52675, 52881);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 52729, 52866);

                    f_10240_52729_52865(diagnostics, ErrorCode.WRN_UnconsumedEnumeratorCancellationAttributeUsage, f_10240_52807_52825(f_10240_52807_52816(node)), f_10240_52827_52843().Identifier.ValueText);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 52675, 52881);
                }

                bool needsReporting()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10240, 52897, 53650);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 52951, 53603) || true) && (!f_10240_52956_53061(f_10240_52956_52960(), f_10240_52968_53060(f_10240_52968_52993(this), WellKnownType.System_Threading_CancellationToken)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 52951, 53603);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 53103, 53115);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 52951, 53603);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 52951, 53603);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 53157, 53603) || true) && (f_10240_53161_53182(this) is MethodSymbol method && (DynAbs.Tracing.TraceSender.Expression_True(10240, 53161, 53244) && f_10240_53230_53244(method)) && (DynAbs.Tracing.TraceSender.Expression_True(10240, 53161, 53417) && f_10240_53269_53417(f_10240_53269_53305(f_10240_53269_53286(method)), f_10240_53313_53416(f_10240_53313_53338(this), WellKnownType.System_Collections_Generic_IAsyncEnumerable_T))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 53157, 53603);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 53571, 53584);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 53157, 53603);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 52951, 53603);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 53623, 53635);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10240, 52897, 53650);

                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        f_10240_52956_52960()
                        {
                            var return_v = Type;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 52956, 52960);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        f_10240_52968_52993(Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                        this_param)
                        {
                            var return_v = this_param.DeclaringCompilation;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 52968, 52993);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        f_10240_52968_53060(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        this_param, Microsoft.CodeAnalysis.WellKnownType
                        type)
                        {
                            var return_v = this_param.GetWellKnownType(type);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 52968, 53060);
                            return return_v;
                        }


                        bool
                        f_10240_52956_53061(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        obj)
                        {
                            var return_v = this_param.Equals((object)obj);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 52956, 53061);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbol
                        f_10240_53161_53182(Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                        this_param)
                        {
                            var return_v = this_param.ContainingSymbol;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 53161, 53182);
                            return return_v;
                        }


                        bool
                        f_10240_53230_53244(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        this_param)
                        {
                            var return_v = this_param.IsAsync;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 53230, 53244);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        f_10240_53269_53286(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        this_param)
                        {
                            var return_v = this_param.ReturnType;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 53269, 53286);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        f_10240_53269_53305(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        this_param)
                        {
                            var return_v = this_param.OriginalDefinition;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 53269, 53305);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        f_10240_53313_53338(Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                        this_param)
                        {
                            var return_v = this_param.DeclaringCompilation;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 53313, 53338);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        f_10240_53313_53416(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        this_param, Microsoft.CodeAnalysis.WellKnownType
                        type)
                        {
                            var return_v = this_param.GetWellKnownType(type);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 53313, 53416);
                            return return_v;
                        }


                        bool
                        f_10240_53269_53417(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        obj)
                        {
                            var return_v = this_param.Equals((object)obj);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 53269, 53417);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10240, 52897, 53650);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10240, 52897, 53650);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10240, 52554, 53661);

                bool
                f_10240_52679_52695()
                {
                    var return_v = needsReporting();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 52679, 52695);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10240_52807_52816(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 52807, 52816);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10240_52807_52825(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 52807, 52825);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                f_10240_52827_52843()
                {
                    var return_v = CSharpSyntaxNode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 52827, 52843);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10240_52729_52865(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 52729, 52865);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10240, 52554, 53661);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10240, 52554, 53661);
            }
        }

        internal override void PostDecodeWellKnownAttributes(ImmutableArray<CSharpAttributeData> boundAttributes, ImmutableArray<AttributeSyntax> allAttributeSyntaxNodes, DiagnosticBag diagnostics, AttributeLocation symbolPart, WellKnownAttributeData decodedData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10240, 53673, 55876);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 53953, 53994);

                f_10240_53953_53993(f_10240_53966_53992_M(!boundAttributes.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 54008, 54057);

                f_10240_54008_54056(f_10240_54021_54055_M(!allAttributeSyntaxNodes.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 54071, 54142);

                f_10240_54071_54141(boundAttributes.Length == allAttributeSyntaxNodes.Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 54156, 54203);

                f_10240_54156_54202(_lazyCustomAttributesBag != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 54217, 54296);

                f_10240_54217_54295(f_10240_54230_54294(_lazyCustomAttributesBag));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 54310, 54361);

                f_10240_54310_54360(symbolPart == AttributeLocation.None);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 54377, 54433);

                var
                data = (ParameterWellKnownAttributeData)decodedData
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 54447, 55734) || true) && (data != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 54447, 55734);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 54497, 55719);

                    switch (f_10240_54505_54512())
                    {

                        case RefKind.Ref:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 54497, 55719);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 54597, 54938) || true) && (f_10240_54601_54621(data) && (DynAbs.Tracing.TraceSender.Expression_True(10240, 54601, 54645) && f_10240_54625_54645_M(!data.HasInAttribute)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 54597, 54938);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 54843, 54911);

                                f_10240_54843_54910(                            // error CS0662: Cannot specify the Out attribute on a ref parameter without also specifying the In attribute.
                                                            diagnostics, ErrorCode.ERR_OutAttrOnRefParam, f_10240_54892_54906(this)[0]);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 54597, 54938);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(10240, 54964, 54970);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 54497, 55719);

                        case RefKind.Out:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 54497, 55719);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 55035, 55303) || true) && (f_10240_55039_55058(data))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 55035, 55303);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 55209, 55276);

                                f_10240_55209_55275(                            // error CS0036: An out parameter cannot have the In attribute.
                                                            diagnostics, ErrorCode.ERR_InAttrOnOutParam, f_10240_55257_55271(this)[0]);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 55035, 55303);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(10240, 55329, 55335);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 54497, 55719);

                        case RefKind.In:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 54497, 55719);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 55399, 55668) || true) && (f_10240_55403_55423(data))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 55399, 55668);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 55574, 55641);

                                f_10240_55574_55640(                            // error CS8355: An in parameter cannot have the Out attribute.
                                                            diagnostics, ErrorCode.ERR_OutAttrOnInParam, f_10240_55622_55636(this)[0]);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 55399, 55668);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(10240, 55694, 55700);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 54497, 55719);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 54447, 55734);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 55750, 55865);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.PostDecodeWellKnownAttributes(boundAttributes, allAttributeSyntaxNodes, diagnostics, symbolPart, decodedData), 10240, 55750, 55864);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10240, 53673, 55876);

                bool
                f_10240_53966_53992_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 53966, 53992);
                    return return_v;
                }


                int
                f_10240_53953_53993(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 53953, 53993);
                    return 0;
                }


                bool
                f_10240_54021_54055_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 54021, 54055);
                    return return_v;
                }


                int
                f_10240_54008_54056(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 54008, 54056);
                    return 0;
                }


                int
                f_10240_54071_54141(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 54071, 54141);
                    return 0;
                }


                int
                f_10240_54156_54202(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 54156, 54202);
                    return 0;
                }


                bool
                f_10240_54230_54294(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param)
                {
                    var return_v = this_param.IsDecodedWellKnownAttributeDataComputed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 54230, 54294);
                    return return_v;
                }


                int
                f_10240_54217_54295(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 54217, 54295);
                    return 0;
                }


                int
                f_10240_54310_54360(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 54310, 54360);
                    return 0;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10240_54505_54512()
                {
                    var return_v = RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 54505, 54512);
                    return return_v;
                }


                bool
                f_10240_54601_54621(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterWellKnownAttributeData
                this_param)
                {
                    var return_v = this_param.HasOutAttribute;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 54601, 54621);
                    return return_v;
                }


                bool
                f_10240_54625_54645_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 54625, 54645);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10240_54892_54906(Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 54892, 54906);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10240_54843_54910(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 54843, 54910);
                    return return_v;
                }


                bool
                f_10240_55039_55058(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterWellKnownAttributeData
                this_param)
                {
                    var return_v = this_param.HasInAttribute;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 55039, 55058);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10240_55257_55271(Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 55257, 55271);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10240_55209_55275(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 55209, 55275);
                    return return_v;
                }


                bool
                f_10240_55403_55423(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterWellKnownAttributeData
                this_param)
                {
                    var return_v = this_param.HasOutAttribute;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 55403, 55423);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10240_55622_55636(Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 55622, 55636);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10240_55574_55640(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 55574, 55640);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10240, 53673, 55876);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10240, 53673, 55876);
            }
        }

        internal override bool HasDefaultArgumentSyntax
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10240, 56071, 56196);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 56107, 56181);

                    return (_parameterSyntaxKind & ParameterSyntaxKind.DefaultParameter) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10240, 56071, 56196);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10240, 55999, 56207);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10240, 55999, 56207);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool HasOptionalAttribute
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10240, 56453, 57843);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 56489, 57696) || true) && (_lazyHasOptionalAttribute == ThreeState.Unknown)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 56489, 57696);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 56582, 56642);

                        SourceParameterSymbol
                        copyFrom = f_10240_56615_56641(this)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 56718, 56765);

                        f_10240_56718_56764(!f_10240_56732_56763(copyFrom, this));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 56789, 57677) || true) && ((object)copyFrom != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 56789, 57677);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 57053, 57126);

                            _lazyHasOptionalAttribute = f_10240_57081_57125(f_10240_57081_57110(copyFrom));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 56789, 57677);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 56789, 57677);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 57442, 57475);

                            var
                            attributes = f_10240_57459_57474(this)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 57503, 57654) || true) && (!attributes.Any())
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10240, 57503, 57654);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 57582, 57627);

                                _lazyHasOptionalAttribute = ThreeState.False;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 57503, 57654);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 56789, 57677);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10240, 56489, 57696);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 57716, 57767);

                    f_10240_57716_57766(f_10240_57729_57765(_lazyHasOptionalAttribute));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 57787, 57828);

                    return f_10240_57794_57827(_lazyHasOptionalAttribute);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10240, 56453, 57843);

                    Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbol
                    f_10240_56615_56641(Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.BoundAttributesSource;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 56615, 56641);
                        return return_v;
                    }


                    bool
                    f_10240_56732_56763(Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbol
                    objA, Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                    objB)
                    {
                        var return_v = ReferenceEquals((object)objA, (object)objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 56732, 56763);
                        return return_v;
                    }


                    int
                    f_10240_56718_56764(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 56718, 56764);
                        return 0;
                    }


                    bool
                    f_10240_57081_57110(Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.HasOptionalAttribute;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 57081, 57110);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ThreeState
                    f_10240_57081_57125(bool
                    value)
                    {
                        var return_v = value.ToThreeState();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 57081, 57125);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                    f_10240_57459_57474(Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.GetAttributes();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 57459, 57474);
                        return return_v;
                    }


                    bool
                    f_10240_57729_57765(Microsoft.CodeAnalysis.ThreeState
                    value)
                    {
                        var return_v = value.HasValue();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 57729, 57765);
                        return return_v;
                    }


                    int
                    f_10240_57716_57766(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 57716, 57766);
                        return 0;
                    }


                    bool
                    f_10240_57794_57827(Microsoft.CodeAnalysis.ThreeState
                    value)
                    {
                        var return_v = value.Value();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 57794, 57827);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10240, 56378, 57854);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10240, 56378, 57854);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsMetadataOptional
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10240, 57932, 58399);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 58328, 58384);

                    return f_10240_58335_58359() || (DynAbs.Tracing.TraceSender.Expression_False(10240, 58335, 58383) || f_10240_58363_58383());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10240, 57932, 58399);

                    bool
                    f_10240_58335_58359()
                    {
                        var return_v = HasDefaultArgumentSyntax;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 58335, 58359);
                        return return_v;
                    }


                    bool
                    f_10240_58363_58383()
                    {
                        var return_v = HasOptionalAttribute;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 58363, 58383);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10240, 57866, 58410);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10240, 57866, 58410);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool IsMetadataIn
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10240, 58478, 58560);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 58481, 58560);
                    return DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.IsMetadataIn, 10240, 58481, 58498) || (DynAbs.Tracing.TraceSender.Expression_False(10240, 58481, 58560) || f_10240_58502_58552_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10240_58502_58536(this), 10240, 58502, 58552)?.HasInAttribute) == true); DynAbs.Tracing.TraceSender.TraceExitMethod(10240, 58478, 58560);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10240, 58478, 58560);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10240, 58478, 58560);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool IsMetadataOut
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10240, 58630, 58714);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 58633, 58714);
                    return DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.IsMetadataOut, 10240, 58633, 58651) || (DynAbs.Tracing.TraceSender.Expression_False(10240, 58633, 58714) || f_10240_58655_58706_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10240_58655_58689(this), 10240, 58655, 58706)?.HasOutAttribute) == true); DynAbs.Tracing.TraceSender.TraceExitMethod(10240, 58630, 58714);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10240, 58630, 58714);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10240, 58630, 58714);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override MarshalPseudoCustomAttributeData MarshallingInformation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10240, 58821, 58882);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 58824, 58882);
                    return f_10240_58824_58882_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10240_58824_58858(this), 10240, 58824, 58882)?.MarshallingInformation); DynAbs.Tracing.TraceSender.TraceExitMethod(10240, 58821, 58882);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10240, 58821, 58882);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10240, 58821, 58882);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsParams
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10240, 58925, 58993);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 58928, 58993);
                    return (_parameterSyntaxKind & ParameterSyntaxKind.ParamsParameter) != 0; DynAbs.Tracing.TraceSender.TraceExitMethod(10240, 58925, 58993);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10240, 58925, 58993);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10240, 58925, 58993);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsExtensionMethodThis
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10240, 59051, 59126);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 59054, 59126);
                    return (_parameterSyntaxKind & ParameterSyntaxKind.ExtensionThisParameter) != 0; DynAbs.Tracing.TraceSender.TraceExitMethod(10240, 59051, 59126);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10240, 59051, 59126);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10240, 59051, 59126);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10240, 59205, 59244);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 59208, 59244);
                    return ImmutableArray<CustomModifier>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10240, 59205, 59244);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10240, 59205, 59244);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10240, 59205, 59244);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override void ForceComplete(SourceLocation locationOpt, CancellationToken cancellationToken)
        {
            _ = this.GetAttributes();
            _ = this.ExplicitDefaultConstantValue;
            state.SpinWaitComplete(CompletionPart.ComplexParameterSymbolAll, cancellationToken);
        }

        static SourceComplexParameterSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10240, 635, 59576);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10240, 635, 59576);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10240, 635, 59576);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10240, 635, 59576);

        Microsoft.CodeAnalysis.SyntaxNode
        f_10240_1784_1805(Microsoft.CodeAnalysis.SyntaxReference
        this_param)
        {
            var return_v = this_param.GetSyntax();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 1784, 1805);
            return return_v;
        }


        bool
        f_10240_1784_1834(Microsoft.CodeAnalysis.SyntaxNode
        node, Microsoft.CodeAnalysis.CSharp.SyntaxKind
        kind)
        {
            var return_v = node.IsKind(kind);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 1784, 1834);
            return return_v;
        }


        int
        f_10240_1747_1836(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 1747, 1836);
            return 0;
        }


        int
        f_10240_1851_1889(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 1851, 1889);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
        f_10240_2377_2398(Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
        this_param)
        {
            var return_v = this_param.CSharpSyntaxNode;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 2377, 2398);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax?
        f_10240_2444_2467(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
        this_param)
        {
            var return_v = this_param.Default;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 2444, 2467);
            return return_v;
        }


        Microsoft.CodeAnalysis.ConstantValue
        f_10240_2627_2646()
        {
            var return_v = ConstantValue.Unset;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 2627, 2646);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbol
        f_10240_1666_1671_C(Microsoft.CodeAnalysis.CSharp.Symbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10240, 1292, 2658);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbol
        f_10240_2727_2743()
        {
            var return_v = ContainingSymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 2727, 2743);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbol
        f_10240_2792_2808()
        {
            var return_v = ContainingSymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 2792, 2808);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Binder
        f_10240_2770_2825(Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
        this_param)
        {
            var return_v = this_param.ParameterBinder;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 2770, 2825);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxNode?
        f_10240_2983_3006_I(Microsoft.CodeAnalysis.SyntaxNode?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 2983, 3006);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.ParameterWellKnownAttributeData?
        f_10240_4489_4523(Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
        this_param)
        {
            var return_v = this_param?.GetDecodedWellKnownAttributeData();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 4489, 4523);
            return return_v;
        }


        bool?
        f_10240_4489_4554_M(bool?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 4489, 4554);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.ParameterWellKnownAttributeData?
        f_10240_4633_4667(Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
        this_param)
        {
            var return_v = this_param?.GetDecodedWellKnownAttributeData();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 4633, 4667);
            return return_v;
        }


        bool?
        f_10240_4633_4697_M(bool?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 4633, 4697);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.ParameterEarlyWellKnownAttributeData?
        f_10240_4776_4815(Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
        this_param)
        {
            var return_v = this_param?.GetEarlyDecodedWellKnownAttributeData();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 4776, 4815);
            return return_v;
        }


        bool?
        f_10240_4776_4845_M(bool?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 4776, 4845);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.ParameterEarlyWellKnownAttributeData?
        f_10240_4922_4961(Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
        this_param)
        {
            var return_v = this_param?.GetEarlyDecodedWellKnownAttributeData();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 4922, 4961);
            return return_v;
        }


        bool?
        f_10240_4922_4989_M(bool?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 4922, 4989);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.ParameterEarlyWellKnownAttributeData?
        f_10240_5068_5107(Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
        this_param)
        {
            var return_v = this_param?.GetEarlyDecodedWellKnownAttributeData();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 5068, 5107);
            return return_v;
        }


        bool?
        f_10240_5068_5137_M(bool?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 5068, 5137);
            return return_v;
        }


        bool
        f_10240_5203_5231()
        {
            var return_v = HasCallerLineNumberAttribute;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 5203, 5231);
            return return_v;
        }


        bool
        f_10240_5287_5316_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 5287, 5316);
            return return_v;
        }


        bool
        f_10240_5320_5346()
        {
            var return_v = HasCallerFilePathAttribute;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 5320, 5346);
            return return_v;
        }


        bool
        f_10240_5404_5433_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 5404, 5433);
            return return_v;
        }


        bool
        f_10240_5488_5515_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 5488, 5515);
            return return_v;
        }


        bool
        f_10240_5570_5598()
        {
            var return_v = HasCallerMemberNameAttribute;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 5570, 5598);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.ParameterWellKnownAttributeData?
        f_10240_7657_7691(Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
        this_param)
        {
            var return_v = this_param?.GetDecodedWellKnownAttributeData();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 7657, 7691);
            return return_v;
        }


        System.Collections.Immutable.ImmutableHashSet<string>?
        f_10240_7657_7718_M(System.Collections.Immutable.ImmutableHashSet<string>?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 7657, 7718);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.IAttributeTargetSymbol
        f_10240_17337_17351()
        {
            var return_v = AttributeOwner;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 17337, 17351);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.ParameterWellKnownAttributeData?
        f_10240_58502_58536(Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
        this_param)
        {
            var return_v = this_param?.GetDecodedWellKnownAttributeData();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 58502, 58536);
            return return_v;
        }


        bool?
        f_10240_58502_58552_M(bool?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 58502, 58552);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.ParameterWellKnownAttributeData?
        f_10240_58655_58689(Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
        this_param)
        {
            var return_v = this_param?.GetDecodedWellKnownAttributeData();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 58655, 58689);
            return return_v;
        }


        bool?
        f_10240_58655_58706_M(bool?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 58655, 58706);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.ParameterWellKnownAttributeData?
        f_10240_58824_58858(Microsoft.CodeAnalysis.CSharp.Symbols.SourceComplexParameterSymbol
        this_param)
        {
            var return_v = this_param?.GetDecodedWellKnownAttributeData();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 58824, 58858);
            return return_v;
        }


        Microsoft.CodeAnalysis.MarshalPseudoCustomAttributeData?
        f_10240_58824_58882_M(Microsoft.CodeAnalysis.MarshalPseudoCustomAttributeData?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 58824, 58882);
            return return_v;
        }

    }
    internal sealed class SourceComplexParameterSymbolWithCustomModifiersPrecedingByRef : SourceComplexParameterSymbol
    {
        private readonly ImmutableArray<CustomModifier> _refCustomModifiers;

        internal SourceComplexParameterSymbolWithCustomModifiersPrecedingByRef(
                    Symbol owner,
                    int ordinal,
                    TypeWithAnnotations parameterType,
                    RefKind refKind,
                    ImmutableArray<CustomModifier> refCustomModifiers,
                    string name,
                    ImmutableArray<Location> locations,
                    SyntaxReference syntaxRef,
                    bool isParams,
                    bool isExtensionMethodThis)
        : base(f_10240_60266_60271_C(owner), ordinal, parameterType, refKind, name, locations, syntaxRef, isParams, isExtensionMethodThis)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10240, 59795, 60586);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 60391, 60433);

                f_10240_60391_60432(f_10240_60404_60431_M(!refCustomModifiers.IsEmpty));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 60449, 60490);

                _refCustomModifiers = refCustomModifiers;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 60506, 60575);

                f_10240_60506_60574(refKind != RefKind.None || (DynAbs.Tracing.TraceSender.Expression_False(10240, 60519, 60573) || _refCustomModifiers.IsEmpty));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10240, 59795, 60586);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10240, 59795, 60586);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10240, 59795, 60586);
            }
        }

        public override ImmutableArray<CustomModifier> RefCustomModifiers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10240, 60664, 60686);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10240, 60667, 60686);
                    return _refCustomModifiers; DynAbs.Tracing.TraceSender.TraceExitMethod(10240, 60664, 60686);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10240, 60664, 60686);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10240, 60664, 60686);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static SourceComplexParameterSymbolWithCustomModifiersPrecedingByRef()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10240, 59584, 60694);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10240, 59584, 60694);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10240, 59584, 60694);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10240, 59584, 60694);

        bool
        f_10240_60404_60431_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10240, 60404, 60431);
            return return_v;
        }


        int
        f_10240_60391_60432(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 60391, 60432);
            return 0;
        }


        int
        f_10240_60506_60574(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10240, 60506, 60574);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbol
        f_10240_60266_60271_C(Microsoft.CodeAnalysis.CSharp.Symbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10240, 59795, 60586);
            return return_v;
        }

    }
}
