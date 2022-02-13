// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Symbols;
using System.Collections.Generic;


namespace Microsoft.CodeAnalysis.CSharp.Emit.NoPia
{
    internal sealed class EmbeddedEvent : EmbeddedTypesManager.CommonEmbeddedEvent
    {
        public EmbeddedEvent(EventSymbolAdapter underlyingEvent, EmbeddedMethod adder, EmbeddedMethod remover) : base(f_10943_690_705_C(underlyingEvent), adder, remover, null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10943, 567, 750);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10943, 567, 750);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10943, 567, 750);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10943, 567, 750);
            }
        }

        protected override IEnumerable<CSharpAttributeData> GetCustomAttributesToEmit(PEModuleBuilder moduleBuilder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10943, 762, 989);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10943, 895, 978);

                return f_10943_902_977(f_10943_902_936(f_10943_902_917()), moduleBuilder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10943, 762, 989);

                Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbolAdapter
                f_10943_902_917()
                {
                    var return_v = UnderlyingEvent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10943, 902, 917);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                f_10943_902_936(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbolAdapter
                this_param)
                {
                    var return_v = this_param.AdaptedEventSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10943, 902, 936);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10943_902_977(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                moduleBuilder)
                {
                    var return_v = this_param.GetCustomAttributesToEmit(moduleBuilder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10943, 902, 977);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10943, 762, 989);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10943, 762, 989);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override bool IsRuntimeSpecial
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10943, 1066, 1181);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10943, 1102, 1166);

                    return f_10943_1109_1165(f_10943_1109_1143(f_10943_1109_1124()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10943, 1066, 1181);

                    Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbolAdapter
                    f_10943_1109_1124()
                    {
                        var return_v = UnderlyingEvent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10943, 1109, 1124);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    f_10943_1109_1143(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbolAdapter
                    this_param)
                    {
                        var return_v = this_param.AdaptedEventSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10943, 1109, 1143);
                        return return_v;
                    }


                    bool
                    f_10943_1109_1165(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    this_param)
                    {
                        var return_v = this_param.HasRuntimeSpecialName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10943, 1109, 1165);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10943, 1001, 1192);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10943, 1001, 1192);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10943, 1266, 1374);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10943, 1302, 1359);

                    return f_10943_1309_1358(f_10943_1309_1343(f_10943_1309_1324()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10943, 1266, 1374);

                    Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbolAdapter
                    f_10943_1309_1324()
                    {
                        var return_v = UnderlyingEvent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10943, 1309, 1324);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    f_10943_1309_1343(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbolAdapter
                    this_param)
                    {
                        var return_v = this_param.AdaptedEventSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10943, 1309, 1343);
                        return return_v;
                    }


                    bool
                    f_10943_1309_1358(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    this_param)
                    {
                        var return_v = this_param.HasSpecialName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10943, 1309, 1358);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10943, 1204, 1385);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10943, 1204, 1385);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override Cci.ITypeReference GetType(PEModuleBuilder moduleBuilder, SyntaxNode syntaxNodeOpt, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10943, 1397, 1662);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10943, 1551, 1651);

                return f_10943_1558_1650(moduleBuilder, f_10943_1582_1621(f_10943_1582_1616(f_10943_1582_1597())), syntaxNodeOpt, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10943, 1397, 1662);

                Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbolAdapter
                f_10943_1582_1597()
                {
                    var return_v = UnderlyingEvent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10943, 1582, 1597);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                f_10943_1582_1616(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbolAdapter
                this_param)
                {
                    var return_v = this_param.AdaptedEventSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10943, 1582, 1616);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10943_1582_1621(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10943, 1582, 1621);
                    return return_v;
                }


                Microsoft.Cci.ITypeReference
                f_10943_1558_1650(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeSymbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.Translate(typeSymbol, syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10943, 1558, 1650);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10943, 1397, 1662);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10943, 1397, 1662);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override EmbeddedType ContainingType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10943, 1745, 1786);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10943, 1751, 1784);

                    return f_10943_1758_1768().ContainingType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10943, 1745, 1786);

                    Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedMethod
                    f_10943_1758_1768()
                    {
                        var return_v = AnAccessor;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10943, 1758, 1768);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10943, 1674, 1797);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10943, 1674, 1797);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10943, 1888, 2015);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10943, 1924, 2000);

                    return f_10943_1931_1999(f_10943_1964_1998(f_10943_1964_1979()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10943, 1888, 2015);

                    Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbolAdapter
                    f_10943_1964_1979()
                    {
                        var return_v = UnderlyingEvent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10943, 1964, 1979);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    f_10943_1964_1998(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbolAdapter
                    this_param)
                    {
                        var return_v = this_param.AdaptedEventSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10943, 1964, 1998);
                        return return_v;
                    }


                    Microsoft.Cci.TypeMemberVisibility
                    f_10943_1931_1999(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    symbol)
                    {
                        var return_v = PEModuleBuilder.MemberVisibility((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10943, 1931, 1999);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10943, 1809, 2026);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10943, 1809, 2026);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10943, 2093, 2199);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10943, 2129, 2184);

                    return f_10943_2136_2183(f_10943_2136_2170(f_10943_2136_2151()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10943, 2093, 2199);

                    Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbolAdapter
                    f_10943_2136_2151()
                    {
                        var return_v = UnderlyingEvent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10943, 2136, 2151);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    f_10943_2136_2170(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbolAdapter
                    this_param)
                    {
                        var return_v = this_param.AdaptedEventSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10943, 2136, 2170);
                        return return_v;
                    }


                    string
                    f_10943_2136_2183(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    this_param)
                    {
                        var return_v = this_param.MetadataName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10943, 2136, 2183);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10943, 2038, 2210);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10943, 2038, 2210);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override void EmbedCorrespondingComEventInterfaceMethodInternal(SyntaxNode syntaxNodeOpt, DiagnosticBag diagnostics, bool isUsedForComAwareEventBinding)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10943, 2222, 5542);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10943, 2869, 2970);

                NamedTypeSymbol
                underlyingContainingType = f_10943_2912_2969(f_10943_2912_2926().UnderlyingNamedType)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10943, 2986, 5531);
                    foreach (var attrData in f_10943_3011_3051_I(f_10943_3011_3051(underlyingContainingType)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10943, 2986, 5531);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10943, 3085, 5516) || true) && (f_10943_3089_3190(attrData, underlyingContainingType, AttributeDescription.ComEventInterfaceAttribute))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10943, 3085, 5516);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10943, 3232, 3256);

                            bool
                            foundMatch = false
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10943, 3278, 3317);

                            NamedTypeSymbol
                            sourceInterface = null
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10943, 3341, 4200) || true) && (attrData.CommonConstructorArguments.Length == 2)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10943, 3341, 4200);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10943, 3442, 3532);

                                sourceInterface = f_10943_3460_3495(attrData)[0].ValueInternal as NamedTypeSymbol;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10943, 3560, 4177) || true) && ((object)sourceInterface != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10943, 3560, 4177);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10943, 3653, 3741);

                                    foundMatch = f_10943_3666_3740(this, sourceInterface, syntaxNodeOpt, diagnostics);
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10943, 3773, 4150);
                                        foreach (NamedTypeSymbol source in f_10943_3808_3857_I(f_10943_3808_3857(sourceInterface)))
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10943, 3773, 4150);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10943, 3923, 4119) || true) && (f_10943_3927_3992(this, source, syntaxNodeOpt, diagnostics))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10943, 3923, 4119);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10943, 4066, 4084);

                                                foundMatch = true;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10943, 3923, 4119);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10943, 3773, 4150);
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10943, 1, 378);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(10943, 1, 378);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10943, 3560, 4177);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10943, 3341, 4200);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10943, 4224, 5467) || true) && (!foundMatch && (DynAbs.Tracing.TraceSender.Expression_True(10943, 4228, 4272) && isUsedForComAwareEventBinding))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10943, 4224, 5467);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10943, 4322, 5444) || true) && ((object)sourceInterface == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10943, 4322, 5444);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10943, 4511, 4666);

                                    f_10943_4511_4665(diagnostics, ErrorCode.ERR_MissingSourceInterface, syntaxNodeOpt, underlyingContainingType, f_10943_4630_4664(f_10943_4630_4645()));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10943, 4322, 5444);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10943, 4322, 5444);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10943, 4780, 4830);

                                    HashSet<DiagnosticInfo>
                                    useSiteDiagnostics = null
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10943, 4860, 4946);

                                    f_10943_4860_4945(sourceInterface, ref useSiteDiagnostics);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10943, 4976, 5083);

                                    f_10943_4976_5082(diagnostics, (DynAbs.Tracing.TraceSender.Conditional_F1(10943, 4992, 5013) || ((syntaxNodeOpt == null && DynAbs.Tracing.TraceSender.Conditional_F2(10943, 5016, 5036)) || DynAbs.Tracing.TraceSender.Conditional_F3(10943, 5039, 5061))) ? NoLocation.Singleton : f_10943_5039_5061(syntaxNodeOpt), useSiteDiagnostics);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10943, 5214, 5417);

                                    f_10943_5214_5416(diagnostics, ErrorCode.ERR_MissingMethodOnSourceInterface, syntaxNodeOpt, sourceInterface, f_10943_5332_5379(f_10943_5332_5366(f_10943_5332_5347())), f_10943_5381_5415(f_10943_5381_5396()));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10943, 4322, 5444);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10943, 4224, 5467);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(10943, 5491, 5497);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10943, 3085, 5516);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10943, 2986, 5531);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10943, 1, 2546);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10943, 1, 2546);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10943, 2222, 5542);

                Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedType
                f_10943_2912_2926()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10943, 2912, 2926);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10943_2912_2969(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                this_param)
                {
                    var return_v = this_param.AdaptedNamedTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10943, 2912, 2969);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10943_3011_3051(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10943, 3011, 3051);
                    return return_v;
                }


                bool
                f_10943_3089_3190(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10943, 3089, 3190);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10943_3460_3495(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.CommonConstructorArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10943, 3460, 3495);
                    return return_v;
                }


                bool
                f_10943_3666_3740(Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedEvent
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                sourceInterface, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.EmbedMatchingInterfaceMethods(sourceInterface, syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10943, 3666, 3740);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10943_3808_3857(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.AllInterfacesNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10943, 3808, 3857);
                    return return_v;
                }


                bool
                f_10943_3927_3992(Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedEvent
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                sourceInterface, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.EmbedMatchingInterfaceMethods(sourceInterface, syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10943, 3927, 3992);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10943_3808_3857_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10943, 3808, 3857);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbolAdapter
                f_10943_4630_4645()
                {
                    var return_v = UnderlyingEvent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10943, 4630, 4645);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                f_10943_4630_4664(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbolAdapter
                this_param)
                {
                    var return_v = this_param.AdaptedEventSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10943, 4630, 4664);
                    return return_v;
                }


                int
                f_10943_4511_4665(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntaxOpt, params object[]
                args)
                {
                    EmbeddedTypesManager.Error(diagnostics, code, syntaxOpt, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10943, 4511, 4665);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10943_4860_4945(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = this_param.AllInterfacesWithDefinitionUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10943, 4860, 4945);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10943_5039_5061(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10943, 5039, 5061);
                    return return_v;
                }


                bool
                f_10943_4976_5082(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add(location, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10943, 4976, 5082);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbolAdapter
                f_10943_5332_5347()
                {
                    var return_v = UnderlyingEvent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10943, 5332, 5347);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                f_10943_5332_5366(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbolAdapter
                this_param)
                {
                    var return_v = this_param.AdaptedEventSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10943, 5332, 5366);
                    return return_v;
                }


                string
                f_10943_5332_5379(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.MetadataName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10943, 5332, 5379);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbolAdapter
                f_10943_5381_5396()
                {
                    var return_v = UnderlyingEvent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10943, 5381, 5396);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                f_10943_5381_5415(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbolAdapter
                this_param)
                {
                    var return_v = this_param.AdaptedEventSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10943, 5381, 5415);
                    return return_v;
                }


                int
                f_10943_5214_5416(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode?
                syntaxOpt, params object[]
                args)
                {
                    EmbeddedTypesManager.Error(diagnostics, code, syntaxOpt, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10943, 5214, 5416);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10943_3011_3051_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10943, 3011, 3051);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10943, 2222, 5542);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10943, 2222, 5542);
            }
        }

        private bool EmbedMatchingInterfaceMethods(NamedTypeSymbol sourceInterface, SyntaxNode syntaxNodeOpt, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10943, 5554, 6160);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10943, 5707, 5731);

                bool
                foundMatch = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10943, 5745, 6117);
                    foreach (Symbol m in f_10943_5766_5841_I(f_10943_5766_5841(sourceInterface, f_10943_5793_5840(f_10943_5793_5827(f_10943_5793_5808())))))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10943, 5745, 6117);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10943, 5875, 6102) || true) && (f_10943_5879_5885(m) == SymbolKind.Method)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10943, 5875, 6102);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10943, 5948, 6043);

                            f_10943_5948_6042(f_10943_5948_5959(), f_10943_5980_6013(((MethodSymbol)m)), syntaxNodeOpt, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10943, 6065, 6083);

                            foundMatch = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10943, 5875, 6102);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10943, 5745, 6117);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10943, 1, 373);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10943, 1, 373);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10943, 6131, 6149);

                return foundMatch;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10943, 5554, 6160);

                Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbolAdapter
                f_10943_5793_5808()
                {
                    var return_v = UnderlyingEvent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10943, 5793, 5808);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                f_10943_5793_5827(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbolAdapter
                this_param)
                {
                    var return_v = this_param.AdaptedEventSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10943, 5793, 5827);
                    return return_v;
                }


                string
                f_10943_5793_5840(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.MetadataName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10943, 5793, 5840);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10943_5766_5841(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10943, 5766, 5841);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10943_5879_5885(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10943, 5879, 5885);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedTypesManager
                f_10943_5948_5959()
                {
                    var return_v = TypeManager;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10943, 5948, 5959);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                f_10943_5980_6013(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.GetCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10943, 5980, 6013);
                    return return_v;
                }


                Microsoft.Cci.IMethodReference
                f_10943_5948_6042(Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedTypesManager
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                methodSymbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.EmbedMethodIfNeedTo(methodSymbol, syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10943, 5948, 6042);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10943_5766_5841_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10943, 5766, 5841);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10943, 5554, 6160);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10943, 5554, 6160);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static EmbeddedEvent()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10943, 472, 6167);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10943, 472, 6167);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10943, 472, 6167);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10943, 472, 6167);

        static Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbolAdapter
        f_10943_690_705_C(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbolAdapter
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10943, 567, 750);
            return return_v;
        }

    }
}
