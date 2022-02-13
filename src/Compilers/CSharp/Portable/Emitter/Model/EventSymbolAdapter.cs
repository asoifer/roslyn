// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.Cci;
using Microsoft.CodeAnalysis.CSharp.Emit;
using Microsoft.CodeAnalysis.Emit;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal partial class
            EventSymbolAdapter : SymbolAdapter,
            Cci.IEventDefinition
    {
        IEnumerable<Cci.IMethodReference> Cci.IEventDefinition.GetAccessors(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10185, 662, 1350);

                var listYield = new List<IMethodReference>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10185, 775, 802);

                f_10185_775_801(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10185, 818, 880);

                var
                addMethod = f_10185_834_879_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10185_834_862(f_10185_834_852()), 10185, 834, 879)?.GetCciAdapter())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10185, 894, 941);

                f_10185_894_940((object?)addMethod != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10185, 955, 1063) || true) && (addMethod.ShouldInclude(context))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10185, 955, 1063);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10185, 1025, 1048);

                    listYield.Add(addMethod);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10185, 955, 1063);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10185, 1079, 1147);

                var
                removeMethod = f_10185_1098_1146_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10185_1098_1129(f_10185_1098_1116()), 10185, 1098, 1146)?.GetCciAdapter())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10185, 1161, 1211);

                f_10185_1161_1210((object?)removeMethod != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10185, 1225, 1339) || true) && (removeMethod.ShouldInclude(context))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10185, 1225, 1339);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10185, 1298, 1324);

                    listYield.Add(removeMethod);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10185, 1225, 1339);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10185, 662, 1350);

                return listYield;

                int
                f_10185_775_801(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbolAdapter
                this_param)
                {
                    this_param.CheckDefinitionInvariant();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10185, 775, 801);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                f_10185_834_852()
                {
                    var return_v = AdaptedEventSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10185, 834, 852);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10185_834_862(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.AddMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10185, 834, 862);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter?
                f_10185_834_879_I(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10185, 834, 879);
                    return return_v;
                }


                int
                f_10185_894_940(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10185, 894, 940);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                f_10185_1098_1116()
                {
                    var return_v = AdaptedEventSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10185, 1098, 1116);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10185_1098_1129(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.RemoveMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10185, 1098, 1129);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter?
                f_10185_1098_1146_I(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10185, 1098, 1146);
                    return return_v;
                }


                int
                f_10185_1161_1210(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10185, 1161, 1210);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10185, 662, 1350);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10185, 662, 1350);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        Cci.IMethodReference Cci.IEventDefinition.Adder
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10185, 1434, 1692);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10185, 1470, 1497);

                    f_10185_1470_1496(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10185, 1515, 1577);

                    var
                    addMethod = f_10185_1531_1576_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10185_1531_1559(f_10185_1531_1549()), 10185, 1531, 1576)?.GetCciAdapter())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10185, 1595, 1642);

                    f_10185_1595_1641((object?)addMethod != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10185, 1660, 1677);

                    return addMethod;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10185, 1434, 1692);

                    int
                    f_10185_1470_1496(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10185, 1470, 1496);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    f_10185_1531_1549()
                    {
                        var return_v = AdaptedEventSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10185, 1531, 1549);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                    f_10185_1531_1559(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    this_param)
                    {
                        var return_v = this_param.AddMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10185, 1531, 1559);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter?
                    f_10185_1531_1576_I(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter?
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10185, 1531, 1576);
                        return return_v;
                    }


                    int
                    f_10185_1595_1641(bool
                    b)
                    {
                        RoslynDebug.Assert(b);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10185, 1595, 1641);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10185, 1362, 1703);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10185, 1362, 1703);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.IMethodReference Cci.IEventDefinition.Remover
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10185, 1789, 2059);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10185, 1825, 1852);

                    f_10185_1825_1851(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10185, 1870, 1938);

                    var
                    removeMethod = f_10185_1889_1937_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10185_1889_1920(f_10185_1889_1907()), 10185, 1889, 1937)?.GetCciAdapter())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10185, 1956, 2006);

                    f_10185_1956_2005((object?)removeMethod != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10185, 2024, 2044);

                    return removeMethod;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10185, 1789, 2059);

                    int
                    f_10185_1825_1851(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10185, 1825, 1851);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    f_10185_1889_1907()
                    {
                        var return_v = AdaptedEventSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10185, 1889, 1907);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                    f_10185_1889_1920(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    this_param)
                    {
                        var return_v = this_param.RemoveMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10185, 1889, 1920);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter?
                    f_10185_1889_1937_I(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter?
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10185, 1889, 1937);
                        return return_v;
                    }


                    int
                    f_10185_1956_2005(bool
                    b)
                    {
                        RoslynDebug.Assert(b);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10185, 1956, 2005);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10185, 1715, 2070);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10185, 1715, 2070);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool Cci.IEventDefinition.IsRuntimeSpecial
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10185, 2149, 2293);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10185, 2185, 2212);

                    f_10185_2185_2211(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10185, 2230, 2278);

                    return f_10185_2237_2277(f_10185_2237_2255());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10185, 2149, 2293);

                    int
                    f_10185_2185_2211(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10185, 2185, 2211);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    f_10185_2237_2255()
                    {
                        var return_v = AdaptedEventSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10185, 2237, 2255);
                        return return_v;
                    }


                    bool
                    f_10185_2237_2277(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    this_param)
                    {
                        var return_v = this_param.HasRuntimeSpecialName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10185, 2237, 2277);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10185, 2082, 2304);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10185, 2082, 2304);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool Cci.IEventDefinition.IsSpecialName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10185, 2380, 2517);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10185, 2416, 2443);

                    f_10185_2416_2442(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10185, 2461, 2502);

                    return f_10185_2468_2501(f_10185_2468_2486());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10185, 2380, 2517);

                    int
                    f_10185_2416_2442(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10185, 2416, 2442);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    f_10185_2468_2486()
                    {
                        var return_v = AdaptedEventSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10185, 2468, 2486);
                        return return_v;
                    }


                    bool
                    f_10185_2468_2501(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    this_param)
                    {
                        var return_v = this_param.HasSpecialName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10185, 2468, 2501);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10185, 2316, 2528);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10185, 2316, 2528);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.IMethodReference? Cci.IEventDefinition.Caller
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10185, 2614, 2764);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10185, 2650, 2677);

                    f_10185_2650_2676(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10185, 2695, 2707);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10185, 2614, 2764);

                    int
                    f_10185_2650_2676(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10185, 2650, 2676);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10185, 2540, 2775);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10185, 2540, 2775);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.ITypeReference Cci.IEventDefinition.GetType(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10185, 2787, 3057);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10185, 2880, 3046);

                return f_10185_2887_3045(((PEModuleBuilder)context.Module), f_10185_2931_2954(f_10185_2931_2949()), (CSharpSyntaxNode)context.SyntaxNodeOpt, diagnostics: context.Diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10185, 2787, 3057);

                Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                f_10185_2931_2949()
                {
                    var return_v = AdaptedEventSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10185, 2931, 2949);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10185_2931_2954(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10185, 2931, 2954);
                    return return_v;
                }


                Microsoft.Cci.ITypeReference
                f_10185_2887_3045(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeSymbol, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.Translate(typeSymbol, syntaxNodeOpt: (Microsoft.CodeAnalysis.SyntaxNode)syntaxNodeOpt, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10185, 2887, 3045);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10185, 2787, 3057);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10185, 2787, 3057);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        Cci.ITypeDefinition Cci.ITypeDefinitionMember.ContainingTypeDefinition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10185, 3235, 3388);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10185, 3271, 3298);

                    f_10185_3271_3297(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10185, 3316, 3373);

                    return f_10185_3323_3372(f_10185_3323_3356(f_10185_3323_3341()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10185, 3235, 3388);

                    int
                    f_10185_3271_3297(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10185, 3271, 3297);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    f_10185_3323_3341()
                    {
                        var return_v = AdaptedEventSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10185, 3323, 3341);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10185_3323_3356(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10185, 3323, 3356);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                    f_10185_3323_3372(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.GetCciAdapter();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10185, 3323, 3372);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10185, 3140, 3399);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10185, 3140, 3399);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.TypeMemberVisibility Cci.ITypeDefinitionMember.Visibility
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10185, 3497, 3653);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10185, 3533, 3560);

                    f_10185_3533_3559(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10185, 3578, 3638);

                    return f_10185_3585_3637(f_10185_3618_3636());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10185, 3497, 3653);

                    int
                    f_10185_3533_3559(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10185, 3533, 3559);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    f_10185_3618_3636()
                    {
                        var return_v = AdaptedEventSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10185, 3618, 3636);
                        return return_v;
                    }


                    Microsoft.Cci.TypeMemberVisibility
                    f_10185_3585_3637(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    symbol)
                    {
                        var return_v = PEModuleBuilder.MemberVisibility((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10185, 3585, 3637);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10185, 3411, 3664);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10185, 3411, 3664);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.ITypeReference Cci.ITypeMemberReference.GetContainingType(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10185, 3746, 3962);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10185, 3853, 3880);

                f_10185_3853_3879(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10185, 3894, 3951);

                return f_10185_3901_3950(f_10185_3901_3934(f_10185_3901_3919()));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10185, 3746, 3962);

                int
                f_10185_3853_3879(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbolAdapter
                this_param)
                {
                    this_param.CheckDefinitionInvariant();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10185, 3853, 3879);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                f_10185_3901_3919()
                {
                    var return_v = AdaptedEventSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10185, 3901, 3919);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10185_3901_3934(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10185, 3901, 3934);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                f_10185_3901_3950(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10185, 3901, 3950);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10185, 3746, 3962);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10185, 3746, 3962);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        void Cci.IReference.Dispatch(Cci.MetadataVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10185, 4034, 4210);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10185, 4116, 4143);

                f_10185_4116_4142(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10185, 4157, 4199);

                f_10185_4157_4198(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10185, 4034, 4210);

                int
                f_10185_4116_4142(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbolAdapter
                this_param)
                {
                    this_param.CheckDefinitionInvariant();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10185, 4116, 4142);
                    return 0;
                }


                int
                f_10185_4157_4198(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbolAdapter
                eventDefinition)
                {
                    this_param.Visit((Microsoft.Cci.IEventDefinition)eventDefinition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10185, 4157, 4198);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10185, 4034, 4210);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10185, 4034, 4210);
            }
        }

        Cci.IDefinition Cci.IReference.AsDefinition(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10185, 4222, 4375);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10185, 4311, 4338);

                f_10185_4311_4337(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10185, 4352, 4364);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10185, 4222, 4375);

                int
                f_10185_4311_4337(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbolAdapter
                this_param)
                {
                    this_param.CheckDefinitionInvariant();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10185, 4311, 4337);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10185, 4222, 4375);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10185, 4222, 4375);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        string Cci.INamedEntity.Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10185, 4502, 4637);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10185, 4538, 4565);

                    f_10185_4538_4564(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10185, 4583, 4622);

                    return f_10185_4590_4621(f_10185_4590_4608());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10185, 4502, 4637);

                    int
                    f_10185_4538_4564(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10185, 4538, 4564);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    f_10185_4590_4608()
                    {
                        var return_v = AdaptedEventSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10185, 4590, 4608);
                        return return_v;
                    }


                    string
                    f_10185_4590_4621(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    this_param)
                    {
                        var return_v = this_param.MetadataName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10185, 4590, 4621);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10185, 4449, 4648);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10185, 4449, 4648);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static EventSymbolAdapter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10185, 454, 4677);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10185, 454, 4677);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10185, 454, 4677);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10185, 454, 4677);
    }
    internal partial class EventSymbol
    {
        private EventSymbolAdapter? _lazyAdapter;

        protected sealed override SymbolAdapter GetCciAdapterImpl()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10185, 4860, 4878);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10185, 4863, 4878);
                return f_10185_4863_4878(this); DynAbs.Tracing.TraceSender.TraceExitMethod(10185, 4860, 4878);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10185, 4860, 4878);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10185, 4860, 4878);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbolAdapter
            f_10185_4863_4878(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
            this_param)
            {
                var return_v = this_param.GetCciAdapter();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10185, 4863, 4878);
                return return_v;
            }

        }

        internal new EventSymbolAdapter GetCciAdapter()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10185, 4891, 5171);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10185, 4963, 5124) || true) && (_lazyAdapter is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10185, 4963, 5124);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10185, 5021, 5109);

                    return f_10185_5028_5108(ref _lazyAdapter, f_10185_5079_5107(this));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10185, 4963, 5124);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10185, 5140, 5160);

                return _lazyAdapter;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10185, 4891, 5171);

                Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbolAdapter
                f_10185_5079_5107(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                underlyingEventSymbol)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbolAdapter(underlyingEventSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10185, 5079, 5107);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbolAdapter
                f_10185_5028_5108(ref Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbolAdapter?
                target, Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbolAdapter
                value)
                {
                    var return_v = InterlockedOperations.Initialize(ref target, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10185, 5028, 5108);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10185, 4891, 5171);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10185, 4891, 5171);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual bool HasRuntimeSpecialName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10185, 5424, 5533);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10185, 5460, 5487);

                    f_10185_5460_5486(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10185, 5505, 5518);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10185, 5424, 5533);

                    int
                    f_10185_5460_5486(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10185, 5460, 5486);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10185, 5356, 5544);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10185, 5356, 5544);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static EventSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10185, 4685, 5551);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10185, 4685, 5551);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10185, 4685, 5551);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10185, 4685, 5551);
    }
    internal partial class EventSymbolAdapter
    {
        internal EventSymbolAdapter(EventSymbol underlyingEventSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10185, 5628, 5769);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10185, 5859, 5907);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10185, 5715, 5758);

                AdaptedEventSymbol = underlyingEventSymbol;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10185, 5628, 5769);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10185, 5628, 5769);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10185, 5628, 5769);
            }
        }

        internal sealed override Symbol AdaptedSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10185, 5827, 5848);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10185, 5830, 5848);
                    return f_10185_5830_5848(); DynAbs.Tracing.TraceSender.TraceExitMethod(10185, 5827, 5848);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10185, 5827, 5848);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10185, 5827, 5848);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal EventSymbol AdaptedEventSymbol { get; }

        Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
        f_10185_5830_5848()
        {
            var return_v = AdaptedEventSymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10185, 5830, 5848);
            return return_v;
        }

    }
}
