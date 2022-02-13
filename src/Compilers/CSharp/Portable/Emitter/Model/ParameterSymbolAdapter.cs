// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CodeGen;
using Microsoft.CodeAnalysis.CSharp.Emit;
using Microsoft.CodeAnalysis.Emit;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal partial class
            ParameterSymbolAdapter : SymbolAdapter,
            Cci.IParameterTypeInformation,
            Cci.IParameterDefinition
    {
        ImmutableArray<Cci.ICustomModifier> Cci.IParameterTypeInformation.CustomModifiers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10200, 851, 1012);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10200, 887, 997);

                    return ImmutableArray<Cci.ICustomModifier>.CastUp(f_10200_937_959().TypeWithAnnotations.CustomModifiers);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10200, 851, 1012);

                    Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    f_10200_937_959()
                    {
                        var return_v = AdaptedParameterSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10200, 937, 959);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10200, 745, 1023);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10200, 745, 1023);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool Cci.IParameterTypeInformation.IsByReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10200, 1108, 1213);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10200, 1144, 1198);

                    return f_10200_1151_1181(f_10200_1151_1173()) != RefKind.None;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10200, 1108, 1213);

                    Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    f_10200_1151_1173()
                    {
                        var return_v = AdaptedParameterSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10200, 1151, 1173);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.RefKind
                    f_10200_1151_1181(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.RefKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10200, 1151, 1181);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10200, 1035, 1224);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10200, 1035, 1224);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ImmutableArray<Cci.ICustomModifier> Cci.IParameterTypeInformation.RefCustomModifiers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10200, 1345, 1489);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10200, 1381, 1474);

                    return ImmutableArray<Cci.ICustomModifier>.CastUp(f_10200_1431_1472(f_10200_1431_1453()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10200, 1345, 1489);

                    Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    f_10200_1431_1453()
                    {
                        var return_v = AdaptedParameterSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10200, 1431, 1453);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    f_10200_1431_1472(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.RefCustomModifiers;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10200, 1431, 1472);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10200, 1236, 1500);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10200, 1236, 1500);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.ITypeReference Cci.IParameterTypeInformation.GetType(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10200, 1512, 1905);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10200, 1614, 1894);

                return f_10200_1621_1893(((PEModuleBuilder)context.Module), f_10200_1665_1692(f_10200_1665_1687()), (CSharpSyntaxNode)context.SyntaxNodeOpt, diagnostics: context.Diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10200, 1512, 1905);

                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10200_1665_1687()
                {
                    var return_v = AdaptedParameterSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10200, 1665, 1687);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10200_1665_1692(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10200, 1665, 1692);
                    return return_v;
                }


                Microsoft.Cci.ITypeReference
                f_10200_1621_1893(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeSymbol, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.Translate(typeSymbol, syntaxNodeOpt: (Microsoft.CodeAnalysis.SyntaxNode)syntaxNodeOpt, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10200, 1621, 1893);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10200, 1512, 1905);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10200, 1512, 1905);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        ushort Cci.IParameterListEntry.Index
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10200, 1978, 2075);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10200, 2014, 2060);

                    return (ushort)f_10200_2029_2059(f_10200_2029_2051());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10200, 1978, 2075);

                    Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    f_10200_2029_2051()
                    {
                        var return_v = AdaptedParameterSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10200, 2029, 2051);
                        return return_v;
                    }


                    int
                    f_10200_2029_2059(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.Ordinal;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10200, 2029, 2059);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10200, 1917, 2086);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10200, 1917, 2086);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        MetadataConstant Cci.IParameterDefinition.GetDefaultValue(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10200, 2219, 2420);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10200, 2322, 2349);

                f_10200_2322_2348(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10200, 2363, 2409);

                return f_10200_2370_2408(this, context);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10200, 2219, 2420);

                int
                f_10200_2322_2348(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbolAdapter
                this_param)
                {
                    this_param.CheckDefinitionInvariant();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10200, 2322, 2348);
                    return 0;
                }


                Microsoft.CodeAnalysis.CodeGen.MetadataConstant
                f_10200_2370_2408(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbolAdapter
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetMetadataConstantValue(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10200, 2370, 2408);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10200, 2219, 2420);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10200, 2219, 2420);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal MetadataConstant GetMetadataConstantValue(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10200, 2432, 3583);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10200, 2528, 2641) || true) && (f_10200_2532_2580_M(!f_10200_2533_2555().HasMetadataConstantValue))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10200, 2528, 2641);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10200, 2614, 2626);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10200, 2528, 2641);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10200, 2657, 2734);

                ConstantValue
                constant = f_10200_2682_2733(f_10200_2682_2704())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10200, 2748, 2764);

                TypeSymbol
                type
                = default(TypeSymbol);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10200, 2778, 3268) || true) && (f_10200_2782_2802(constant) != SpecialType.None)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10200, 2778, 3268);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10200, 3024, 3110);

                    type = f_10200_3031_3109(f_10200_3031_3072(f_10200_3031_3053()), f_10200_3088_3108(constant));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10200, 2778, 3268);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10200, 2778, 3268);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10200, 3218, 3253);

                    type = f_10200_3225_3252(f_10200_3225_3247());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10200, 2778, 3268);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10200, 3284, 3572);

                return f_10200_3291_3571(((PEModuleBuilder)context.Module), type, f_10200_3346_3360(constant), (CSharpSyntaxNode)context.SyntaxNodeOpt, diagnostics: context.Diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10200, 2432, 3583);

                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10200_2533_2555()
                {
                    var return_v = AdaptedParameterSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10200, 2533, 2555);
                    return return_v;
                }


                bool
                f_10200_2532_2580_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10200, 2532, 2580);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10200_2682_2704()
                {
                    var return_v = AdaptedParameterSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10200, 2682, 2704);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10200_2682_2733(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.ExplicitDefaultConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10200, 2682, 2733);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10200_2782_2802(Microsoft.CodeAnalysis.ConstantValue?
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10200, 2782, 2802);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10200_3031_3053()
                {
                    var return_v = AdaptedParameterSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10200, 3031, 3053);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10200_3031_3072(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10200, 3031, 3072);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10200_3088_3108(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10200, 3088, 3108);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10200_3031_3109(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, Microsoft.CodeAnalysis.SpecialType
                type)
                {
                    var return_v = this_param.GetSpecialType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10200, 3031, 3109);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10200_3225_3247()
                {
                    var return_v = AdaptedParameterSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10200, 3225, 3247);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10200_3225_3252(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10200, 3225, 3252);
                    return return_v;
                }


                object?
                f_10200_3346_3360(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10200, 3346, 3360);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.MetadataConstant
                f_10200_3291_3571(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, object?
                value, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.CreateConstant(type, value, syntaxNodeOpt: (Microsoft.CodeAnalysis.SyntaxNode)syntaxNodeOpt, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10200, 3291, 3571);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10200, 2432, 3583);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10200, 2432, 3583);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        bool Cci.IParameterDefinition.HasDefaultValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10200, 3665, 3816);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10200, 3701, 3728);

                    f_10200_3701_3727(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10200, 3746, 3801);

                    return f_10200_3753_3800(f_10200_3753_3775());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10200, 3665, 3816);

                    int
                    f_10200_3701_3727(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10200, 3701, 3727);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    f_10200_3753_3775()
                    {
                        var return_v = AdaptedParameterSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10200, 3753, 3775);
                        return return_v;
                    }


                    bool
                    f_10200_3753_3800(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.HasMetadataConstantValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10200, 3753, 3800);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10200, 3595, 3827);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10200, 3595, 3827);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool Cci.IParameterDefinition.IsOptional
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10200, 3904, 4049);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10200, 3940, 3967);

                    f_10200_3940_3966(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10200, 3985, 4034);

                    return f_10200_3992_4033(f_10200_3992_4014());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10200, 3904, 4049);

                    int
                    f_10200_3940_3966(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10200, 3940, 3966);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    f_10200_3992_4014()
                    {
                        var return_v = AdaptedParameterSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10200, 3992, 4014);
                        return return_v;
                    }


                    bool
                    f_10200_3992_4033(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.IsMetadataOptional;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10200, 3992, 4033);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10200, 3839, 4060);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10200, 3839, 4060);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool Cci.IParameterDefinition.IsIn
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10200, 4131, 4270);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10200, 4167, 4194);

                    f_10200_4167_4193(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10200, 4212, 4255);

                    return f_10200_4219_4254(f_10200_4219_4241());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10200, 4131, 4270);

                    int
                    f_10200_4167_4193(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10200, 4167, 4193);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    f_10200_4219_4241()
                    {
                        var return_v = AdaptedParameterSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10200, 4219, 4241);
                        return return_v;
                    }


                    bool
                    f_10200_4219_4254(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.IsMetadataIn;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10200, 4219, 4254);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10200, 4072, 4281);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10200, 4072, 4281);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool Cci.IParameterDefinition.IsMarshalledExplicitly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10200, 4370, 4519);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10200, 4406, 4433);

                    f_10200_4406_4432(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10200, 4451, 4504);

                    return f_10200_4458_4503(f_10200_4458_4480());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10200, 4370, 4519);

                    int
                    f_10200_4406_4432(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10200, 4406, 4432);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    f_10200_4458_4480()
                    {
                        var return_v = AdaptedParameterSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10200, 4458, 4480);
                        return return_v;
                    }


                    bool
                    f_10200_4458_4503(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.IsMarshalledExplicitly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10200, 4458, 4503);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10200, 4293, 4530);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10200, 4293, 4530);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool Cci.IParameterDefinition.IsOut
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10200, 4602, 4742);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10200, 4638, 4665);

                    f_10200_4638_4664(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10200, 4683, 4727);

                    return f_10200_4690_4726(f_10200_4690_4712());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10200, 4602, 4742);

                    int
                    f_10200_4638_4664(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10200, 4638, 4664);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    f_10200_4690_4712()
                    {
                        var return_v = AdaptedParameterSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10200, 4690, 4712);
                        return return_v;
                    }


                    bool
                    f_10200_4690_4726(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.IsMetadataOut;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10200, 4690, 4726);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10200, 4542, 4753);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10200, 4542, 4753);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.IMarshallingInformation Cci.IParameterDefinition.MarshallingInformation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10200, 4865, 5014);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10200, 4901, 4928);

                    f_10200_4901_4927(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10200, 4946, 4999);

                    return f_10200_4953_4998(f_10200_4953_4975());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10200, 4865, 5014);

                    int
                    f_10200_4901_4927(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10200, 4901, 4927);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    f_10200_4953_4975()
                    {
                        var return_v = AdaptedParameterSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10200, 4953, 4975);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.MarshalPseudoCustomAttributeData
                    f_10200_4953_4998(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.MarshallingInformation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10200, 4953, 4998);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10200, 4765, 5025);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10200, 4765, 5025);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ImmutableArray<byte> Cci.IParameterDefinition.MarshallingDescriptor
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10200, 5129, 5277);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10200, 5165, 5192);

                    f_10200_5165_5191(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10200, 5210, 5262);

                    return f_10200_5217_5261(f_10200_5217_5239());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10200, 5129, 5277);

                    int
                    f_10200_5165_5191(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10200, 5165, 5191);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    f_10200_5217_5239()
                    {
                        var return_v = AdaptedParameterSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10200, 5217, 5239);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<byte>
                    f_10200_5217_5261(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.MarshallingDescriptor;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10200, 5217, 5261);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10200, 5037, 5288);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10200, 5037, 5288);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        void Cci.IReference.Dispatch(Cci.MetadataVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10200, 5300, 6078);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10200, 5382, 5419);

                throw f_10200_5388_5418();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10200, 5300, 6078);

                System.Exception
                f_10200_5388_5418()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10200, 5388, 5418);
                    return return_v;
                }

                //At present we have no scenario that needs this method.
                //Should one arise, uncomment implementation and add a test.
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10200, 5300, 6078);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10200, 5300, 6078);
            }
        }

        Cci.IDefinition Cci.IReference.AsDefinition(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10200, 6090, 6554);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10200, 6179, 6223);

                f_10200_6179_6222(f_10200_6192_6221(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10200, 6239, 6306);

                PEModuleBuilder
                moduleBeingBuilt = (PEModuleBuilder)context.Module
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10200, 6322, 6515) || true) && (f_10200_6326_6361(f_10200_6326_6348()) && (DynAbs.Tracing.TraceSender.Expression_True(10200, 6326, 6454) && f_10200_6382_6421(f_10200_6382_6404()) == moduleBeingBuilt.SourceModule))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10200, 6322, 6515);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10200, 6488, 6500);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10200, 6322, 6515);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10200, 6531, 6543);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10200, 6090, 6554);

                bool
                f_10200_6192_6221(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbolAdapter
                this_param)
                {
                    var return_v = this_param.IsDefinitionOrDistinct();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10200, 6192, 6221);
                    return return_v;
                }


                int
                f_10200_6179_6222(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10200, 6179, 6222);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10200_6326_6348()
                {
                    var return_v = AdaptedParameterSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10200, 6326, 6348);
                    return return_v;
                }


                bool
                f_10200_6326_6361(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10200, 6326, 6361);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10200_6382_6404()
                {
                    var return_v = AdaptedParameterSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10200, 6382, 6404);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10200_6382_6421(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.ContainingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10200, 6382, 6421);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10200, 6090, 6554);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10200, 6090, 6554);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        string Cci.INamedEntity.Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10200, 6619, 6670);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10200, 6625, 6668);

                    return f_10200_6632_6667(f_10200_6632_6654());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10200, 6619, 6670);

                    Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    f_10200_6632_6654()
                    {
                        var return_v = AdaptedParameterSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10200, 6632, 6654);
                        return return_v;
                    }


                    string
                    f_10200_6632_6667(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.MetadataName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10200, 6632, 6667);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10200, 6566, 6681);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10200, 6566, 6681);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static ParameterSymbolAdapter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10200, 529, 6688);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10200, 529, 6688);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10200, 529, 6688);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10200, 529, 6688);
    }
    internal partial class ParameterSymbol
    {
        private ParameterSymbolAdapter _lazyAdapter;

        protected sealed override SymbolAdapter GetCciAdapterImpl()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10200, 6878, 6896);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10200, 6881, 6896);
                return f_10200_6881_6896(this); DynAbs.Tracing.TraceSender.TraceExitMethod(10200, 6878, 6896);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10200, 6878, 6896);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10200, 6878, 6896);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbolAdapter
            f_10200_6881_6896(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
            this_param)
            {
                var return_v = this_param.GetCciAdapter();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10200, 6881, 6896);
                return return_v;
            }

        }

        internal new ParameterSymbolAdapter GetCciAdapter()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10200, 6909, 7197);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10200, 6985, 7150) || true) && (_lazyAdapter is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10200, 6985, 7150);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10200, 7043, 7135);

                    return f_10200_7050_7134(ref _lazyAdapter, f_10200_7101_7133(this));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10200, 6985, 7150);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10200, 7166, 7186);

                return _lazyAdapter;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10200, 6909, 7197);

                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbolAdapter
                f_10200_7101_7133(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                underlyingParameterSymbol)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbolAdapter(underlyingParameterSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10200, 7101, 7133);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbolAdapter
                f_10200_7050_7134(ref Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbolAdapter?
                target, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbolAdapter
                value)
                {
                    var return_v = InterlockedOperations.Initialize(ref target, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10200, 7050, 7134);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10200, 6909, 7197);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10200, 6909, 7197);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual bool HasMetadataConstantValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10200, 7465, 8178);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10200, 7501, 7528);

                    f_10200_7501_7527(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10200, 7907, 8163);

                    return f_10200_7914_7947(this) != null && (DynAbs.Tracing.TraceSender.Expression_True(10200, 7914, 8058) && f_10200_7983_8028(f_10200_7983_8016(this)) != SpecialType.System_Decimal) && (DynAbs.Tracing.TraceSender.Expression_True(10200, 7914, 8162) && f_10200_8086_8131(f_10200_8086_8119(this)) != SpecialType.System_DateTime);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10200, 7465, 8178);

                    int
                    f_10200_7501_7527(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10200, 7501, 7527);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.ConstantValue?
                    f_10200_7914_7947(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.ExplicitDefaultConstantValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10200, 7914, 7947);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConstantValue
                    f_10200_7983_8016(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.ExplicitDefaultConstantValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10200, 7983, 8016);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SpecialType
                    f_10200_7983_8028(Microsoft.CodeAnalysis.ConstantValue
                    this_param)
                    {
                        var return_v = this_param.SpecialType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10200, 7983, 8028);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConstantValue
                    f_10200_8086_8119(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.ExplicitDefaultConstantValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10200, 8086, 8119);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SpecialType
                    f_10200_8086_8131(Microsoft.CodeAnalysis.ConstantValue
                    this_param)
                    {
                        var return_v = this_param.SpecialType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10200, 8086, 8131);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10200, 7394, 8189);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10200, 7394, 8189);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual bool IsMarshalledExplicitly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10200, 8270, 8409);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10200, 8306, 8333);

                    f_10200_8306_8332(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10200, 8351, 8394);

                    return f_10200_8358_8385(this) != null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10200, 8270, 8409);

                    int
                    f_10200_8306_8332(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10200, 8306, 8332);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.MarshalPseudoCustomAttributeData
                    f_10200_8358_8385(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.MarshallingInformation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10200, 8358, 8385);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10200, 8201, 8420);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10200, 8201, 8420);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual ImmutableArray<byte> MarshallingDescriptor
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10200, 8516, 8649);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10200, 8552, 8579);

                    f_10200_8552_8578(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10200, 8597, 8634);

                    return default(ImmutableArray<byte>);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10200, 8516, 8649);

                    int
                    f_10200_8552_8578(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10200, 8552, 8578);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10200, 8432, 8660);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10200, 8432, 8660);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static ParameterSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10200, 6696, 8667);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10143, 847, 875);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10200, 6696, 8667);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10200, 6696, 8667);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10200, 6696, 8667);
    }
    internal partial class ParameterSymbolAdapter
    {
        internal ParameterSymbolAdapter(ParameterSymbol underlyingParameterSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10200, 8748, 9132);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10200, 9226, 9282);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10200, 8847, 8898);

                AdaptedParameterSymbol = underlyingParameterSymbol;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10200, 8914, 9121) || true) && (underlyingParameterSymbol is NativeIntegerParameterSymbol)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10200, 8914, 9121);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10200, 9069, 9106);

                    throw f_10200_9075_9105();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10200, 8914, 9121);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10200, 8748, 9132);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10200, 8748, 9132);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10200, 8748, 9132);
            }
        }

        internal sealed override Symbol AdaptedSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10200, 9190, 9215);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10200, 9193, 9215);
                    return f_10200_9193_9215(); DynAbs.Tracing.TraceSender.TraceExitMethod(10200, 9190, 9215);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10200, 9190, 9215);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10200, 9190, 9215);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal ParameterSymbol AdaptedParameterSymbol { get; }

        System.Exception
        f_10200_9075_9105()
        {
            var return_v = ExceptionUtilities.Unreachable;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10200, 9075, 9105);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        f_10200_9193_9215()
        {
            var return_v = AdaptedParameterSymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10200, 9193, 9215);
            return return_v;
        }

    }
}
