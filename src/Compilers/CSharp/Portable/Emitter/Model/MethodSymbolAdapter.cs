// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Emit;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal partial class
            MethodSymbolAdapter : SymbolAdapter,
            Cci.ITypeMemberReference,
            Cci.IMethodReference,
            Cci.IGenericMethodInstanceReference,
            Cci.ISpecializedMethodReference,
            Cci.ITypeDefinitionMember,
            Cci.IMethodDefinition
    {
        Cci.IGenericMethodInstanceReference Cci.IMethodReference.AsGenericMethodInstanceReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10194, 1041, 1358);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 1077, 1121);

                    f_10194_1077_1120(f_10194_1090_1119(this));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 1141, 1311) || true) && (f_10194_1145_1178_M(!f_10194_1146_1165().IsDefinition) && (DynAbs.Tracing.TraceSender.Expression_True(10194, 1145, 1238) && f_10194_1203_1238(f_10194_1203_1222())))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10194, 1141, 1311);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 1280, 1292);

                        return this;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10194, 1141, 1311);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 1331, 1343);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10194, 1041, 1358);

                    bool
                    f_10194_1090_1119(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                    this_param)
                    {
                        var return_v = this_param.IsDefinitionOrDistinct();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 1090, 1119);
                        return return_v;
                    }


                    int
                    f_10194_1077_1120(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 1077, 1120);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10194_1146_1165()
                    {
                        var return_v = AdaptedMethodSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 1146, 1165);
                        return return_v;
                    }


                    bool
                    f_10194_1145_1178_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 1145, 1178);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10194_1203_1222()
                    {
                        var return_v = AdaptedMethodSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 1203, 1222);
                        return return_v;
                    }


                    bool
                    f_10194_1203_1238(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsGenericMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 1203, 1238);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10194, 927, 1369);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10194, 927, 1369);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.ISpecializedMethodReference Cci.IMethodReference.AsSpecializedMethodReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10194, 1487, 2061);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 1523, 1567);

                    f_10194_1523_1566(f_10194_1536_1565(this));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 1587, 2014) || true) && (f_10194_1591_1624_M(!f_10194_1592_1611().IsDefinition) && (DynAbs.Tracing.TraceSender.Expression_True(10194, 1591, 1756) && (f_10194_1650_1686_M(!f_10194_1651_1670().IsGenericMethod) || (DynAbs.Tracing.TraceSender.Expression_False(10194, 1650, 1755) || f_10194_1690_1755(f_10194_1720_1754(f_10194_1720_1739()))))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10194, 1587, 2014);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 1798, 1961);

                        f_10194_1798_1960((object)f_10194_1819_1853(f_10194_1819_1838()) != null && (DynAbs.Tracing.TraceSender.Expression_True(10194, 1811, 1959) && f_10194_1894_1959(f_10194_1924_1958(f_10194_1924_1943()))));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 1983, 1995);

                        return this;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10194, 1587, 2014);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 2034, 2046);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10194, 1487, 2061);

                    bool
                    f_10194_1536_1565(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                    this_param)
                    {
                        var return_v = this_param.IsDefinitionOrDistinct();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 1536, 1565);
                        return return_v;
                    }


                    int
                    f_10194_1523_1566(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 1523, 1566);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10194_1592_1611()
                    {
                        var return_v = AdaptedMethodSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 1592, 1611);
                        return return_v;
                    }


                    bool
                    f_10194_1591_1624_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 1591, 1624);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10194_1651_1670()
                    {
                        var return_v = AdaptedMethodSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 1651, 1670);
                        return return_v;
                    }


                    bool
                    f_10194_1650_1686_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 1650, 1686);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10194_1720_1739()
                    {
                        var return_v = AdaptedMethodSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 1720, 1739);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10194_1720_1754(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 1720, 1754);
                        return return_v;
                    }


                    bool
                    f_10194_1690_1755(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    toCheck)
                    {
                        var return_v = PEModuleBuilder.IsGenericType(toCheck);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 1690, 1755);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10194_1819_1838()
                    {
                        var return_v = AdaptedMethodSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 1819, 1838);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10194_1819_1853(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 1819, 1853);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10194_1924_1943()
                    {
                        var return_v = AdaptedMethodSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 1924, 1943);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10194_1924_1958(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 1924, 1958);
                        return return_v;
                    }


                    bool
                    f_10194_1894_1959(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    toCheck)
                    {
                        var return_v = PEModuleBuilder.IsGenericType(toCheck);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 1894, 1959);
                        return return_v;
                    }


                    int
                    f_10194_1798_1960(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 1798, 1960);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10194, 1381, 2072);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10194, 1381, 2072);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.IDefinition Cci.IReference.AsDefinition(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10194, 2084, 2219);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 2173, 2208);

                return f_10194_2180_2207(this, context);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10194, 2084, 2219);

                Microsoft.Cci.IMethodDefinition
                f_10194_2180_2207(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.ResolvedMethodImpl(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 2180, 2207);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10194, 2084, 2219);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10194, 2084, 2219);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        Cci.ITypeReference Cci.ITypeMemberReference.GetContainingType(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10194, 2231, 3083);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 2338, 2382);

                f_10194_2338_2381(f_10194_2351_2380(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 2398, 2481);

                var
                synthesizedGlobalMethod = f_10194_2428_2447() as SynthesizedGlobalMethodSymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 2495, 2661) || true) && ((object)synthesizedGlobalMethod != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10194, 2495, 2661);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 2572, 2646);

                    return f_10194_2579_2645(synthesizedGlobalMethod);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10194, 2495, 2661);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 2677, 2745);

                NamedTypeSymbol
                containingType = f_10194_2710_2744(f_10194_2710_2729())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 2759, 2814);

                var
                moduleBeingBuilt = (PEModuleBuilder)context.Module
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 2830, 3072);

                return f_10194_2837_3071(moduleBeingBuilt, containingType, (CSharpSyntaxNode)context.SyntaxNodeOpt, diagnostics: context.Diagnostics, needDeclaration: f_10194_3038_3070(f_10194_3038_3057()));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10194, 2231, 3083);

                bool
                f_10194_2351_2380(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                this_param)
                {
                    var return_v = this_param.IsDefinitionOrDistinct();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 2351, 2380);
                    return return_v;
                }


                int
                f_10194_2338_2381(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 2338, 2381);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10194_2428_2447()
                {
                    var return_v = AdaptedMethodSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 2428, 2447);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.PrivateImplementationDetails
                f_10194_2579_2645(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedGlobalMethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingPrivateImplementationDetailsType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 2579, 2645);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10194_2710_2729()
                {
                    var return_v = AdaptedMethodSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 2710, 2729);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10194_2710_2744(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 2710, 2744);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10194_3038_3057()
                {
                    var return_v = AdaptedMethodSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 3038, 3057);
                    return return_v;
                }


                bool
                f_10194_3038_3070(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 3038, 3070);
                    return return_v;
                }


                Microsoft.Cci.INamedTypeReference
                f_10194_2837_3071(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                namedTypeSymbol, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                needDeclaration)
                {
                    var return_v = this_param.Translate(namedTypeSymbol, syntaxNodeOpt: (Microsoft.CodeAnalysis.SyntaxNode)syntaxNodeOpt, diagnostics: diagnostics, needDeclaration: needDeclaration);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 2837, 3071);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10194, 2231, 3083);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10194, 2231, 3083);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        void Cci.IReference.Dispatch(Cci.MetadataVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10194, 3095, 4402);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 3177, 3221);

                f_10194_3177_3220(f_10194_3190_3219(this));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 3237, 4391) || true) && (f_10194_3241_3274_M(!f_10194_3242_3261().IsDefinition))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10194, 3237, 4391);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 3308, 3808) || true) && (f_10194_3312_3347(f_10194_3312_3331()))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10194, 3308, 3808);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 3389, 3473);

                        f_10194_3389_3472(f_10194_3402_3463(((Cci.IMethodReference)this)) != null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 3495, 3552);

                        f_10194_3495_3551(visitor, this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10194, 3308, 3808);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10194, 3308, 3808);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 3634, 3714);

                        f_10194_3634_3713(f_10194_3647_3704(((Cci.IMethodReference)this)) != null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 3736, 3789);

                        f_10194_3736_3788(visitor, this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10194, 3308, 3808);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10194, 3237, 4391);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10194, 3237, 4391);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 3874, 3949);

                    PEModuleBuilder
                    moduleBeingBuilt = (PEModuleBuilder)visitor.Context.Module
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 3967, 4376) || true) && (f_10194_3971_4007(f_10194_3971_3990()) == moduleBeingBuilt.SourceModule)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10194, 3967, 4376);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 4082, 4168);

                        f_10194_4082_4167(f_10194_4095_4158(((Cci.IMethodReference)this), visitor.Context) != null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 4190, 4233);

                        f_10194_4190_4232(visitor, this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10194, 3967, 4376);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10194, 3967, 4376);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 4315, 4357);

                        f_10194_4315_4356(visitor, this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10194, 3967, 4376);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10194, 3237, 4391);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10194, 3095, 4402);

                bool
                f_10194_3190_3219(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                this_param)
                {
                    var return_v = this_param.IsDefinitionOrDistinct();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 3190, 3219);
                    return return_v;
                }


                int
                f_10194_3177_3220(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 3177, 3220);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10194_3242_3261()
                {
                    var return_v = AdaptedMethodSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 3242, 3261);
                    return return_v;
                }


                bool
                f_10194_3241_3274_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 3241, 3274);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10194_3312_3331()
                {
                    var return_v = AdaptedMethodSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 3312, 3331);
                    return return_v;
                }


                bool
                f_10194_3312_3347(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsGenericMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 3312, 3347);
                    return return_v;
                }


                Microsoft.Cci.IGenericMethodInstanceReference?
                f_10194_3402_3463(Microsoft.Cci.IMethodReference
                this_param)
                {
                    var return_v = this_param.AsGenericMethodInstanceReference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 3402, 3463);
                    return return_v;
                }


                int
                f_10194_3389_3472(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 3389, 3472);
                    return 0;
                }


                int
                f_10194_3495_3551(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                genericMethodInstanceReference)
                {
                    this_param.Visit((Microsoft.Cci.IGenericMethodInstanceReference)genericMethodInstanceReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 3495, 3551);
                    return 0;
                }


                Microsoft.Cci.ISpecializedMethodReference?
                f_10194_3647_3704(Microsoft.Cci.IMethodReference
                this_param)
                {
                    var return_v = this_param.AsSpecializedMethodReference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 3647, 3704);
                    return return_v;
                }


                int
                f_10194_3634_3713(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 3634, 3713);
                    return 0;
                }


                int
                f_10194_3736_3788(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.ISpecializedMethodReference
                methodReference)
                {
                    this_param.Visit((Microsoft.Cci.IMethodReference)methodReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 3736, 3788);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10194_3971_3990()
                {
                    var return_v = AdaptedMethodSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 3971, 3990);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10194_3971_4007(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 3971, 4007);
                    return return_v;
                }


                Microsoft.Cci.IMethodDefinition?
                f_10194_4095_4158(Microsoft.Cci.IMethodReference
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetResolvedMethod(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 4095, 4158);
                    return return_v;
                }


                int
                f_10194_4082_4167(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 4082, 4167);
                    return 0;
                }


                int
                f_10194_4190_4232(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                method)
                {
                    this_param.Visit((Microsoft.Cci.IMethodDefinition)method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 4190, 4232);
                    return 0;
                }


                int
                f_10194_4315_4356(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                methodReference)
                {
                    this_param.Visit((Microsoft.Cci.IMethodReference)methodReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 4315, 4356);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10194, 3095, 4402);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10194, 3095, 4402);
            }
        }

        string Cci.INamedEntity.Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10194, 4467, 4515);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 4473, 4513);

                    return f_10194_4480_4512(f_10194_4480_4499());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10194, 4467, 4515);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10194_4480_4499()
                    {
                        var return_v = AdaptedMethodSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 4480, 4499);
                        return return_v;
                    }


                    string
                    f_10194_4480_4512(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.MetadataName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 4480, 4512);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10194, 4414, 4526);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10194, 4414, 4526);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool Cci.IMethodReference.AcceptsExtraArguments
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10194, 4610, 4697);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 4646, 4682);

                    return f_10194_4653_4681(f_10194_4653_4672());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10194, 4610, 4697);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10194_4653_4672()
                    {
                        var return_v = AdaptedMethodSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 4653, 4672);
                        return return_v;
                    }


                    bool
                    f_10194_4653_4681(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsVararg;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 4653, 4681);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10194, 4538, 4708);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10194, 4538, 4708);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ushort Cci.IMethodReference.GenericParameterCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10194, 4794, 4886);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 4830, 4871);

                    return (ushort)f_10194_4845_4870(f_10194_4845_4864());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10194, 4794, 4886);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10194_4845_4864()
                    {
                        var return_v = AdaptedMethodSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 4845, 4864);
                        return return_v;
                    }


                    int
                    f_10194_4845_4870(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.Arity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 4845, 4870);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10194, 4720, 4897);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10194, 4720, 4897);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool Cci.IMethodReference.IsGeneric
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10194, 4969, 5063);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 5005, 5048);

                    return f_10194_5012_5047(f_10194_5012_5031());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10194, 4969, 5063);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10194_5012_5031()
                    {
                        var return_v = AdaptedMethodSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 5012, 5031);
                        return return_v;
                    }


                    bool
                    f_10194_5012_5047(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsGenericMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 5012, 5047);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10194, 4909, 5074);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10194, 4909, 5074);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ushort Cci.ISignature.ParameterCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10194, 5147, 5248);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 5183, 5233);

                    return (ushort)f_10194_5198_5232(f_10194_5198_5217());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10194, 5147, 5248);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10194_5198_5217()
                    {
                        var return_v = AdaptedMethodSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 5198, 5217);
                        return return_v;
                    }


                    int
                    f_10194_5198_5232(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ParameterCount;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 5198, 5232);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10194, 5086, 5259);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10194, 5086, 5259);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.IMethodDefinition Cci.IMethodReference.GetResolvedMethod(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10194, 5271, 5423);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 5377, 5412);

                return f_10194_5384_5411(this, context);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10194, 5271, 5423);

                Microsoft.Cci.IMethodDefinition
                f_10194_5384_5411(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.ResolvedMethodImpl(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 5384, 5411);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10194, 5271, 5423);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10194, 5271, 5423);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Cci.IMethodDefinition ResolvedMethodImpl(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10194, 5435, 6092);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 5529, 5573);

                f_10194_5529_5572(f_10194_5542_5571(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 5587, 5654);

                PEModuleBuilder
                moduleBeingBuilt = (PEModuleBuilder)context.Module
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 5670, 6053) || true) && (f_10194_5674_5706(f_10194_5674_5693()) && (DynAbs.Tracing.TraceSender.Expression_True(10194, 5674, 5830) && f_10194_5761_5797(f_10194_5761_5780()) == moduleBeingBuilt.SourceModule))
                ) // must be declared in the module we are building

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10194, 5670, 6053);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 5914, 5986);

                    f_10194_5914_5985((object)f_10194_5935_5976(f_10194_5935_5954()) == null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 6026, 6038);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10194, 5670, 6053);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 6069, 6081);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10194, 5435, 6092);

                bool
                f_10194_5542_5571(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                this_param)
                {
                    var return_v = this_param.IsDefinitionOrDistinct();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 5542, 5571);
                    return return_v;
                }


                int
                f_10194_5529_5572(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 5529, 5572);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10194_5674_5693()
                {
                    var return_v = AdaptedMethodSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 5674, 5693);
                    return return_v;
                }


                bool
                f_10194_5674_5706(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 5674, 5706);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10194_5761_5780()
                {
                    var return_v = AdaptedMethodSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 5761, 5780);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10194_5761_5797(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 5761, 5797);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10194_5935_5954()
                {
                    var return_v = AdaptedMethodSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 5935, 5954);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10194_5935_5976(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.PartialDefinitionPart;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 5935, 5976);
                    return return_v;
                }


                int
                f_10194_5914_5985(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 5914, 5985);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10194, 5435, 6092);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10194, 5435, 6092);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        ImmutableArray<Cci.IParameterTypeInformation> Cci.IMethodReference.ExtraParameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10194, 6211, 6321);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 6247, 6306);

                    return ImmutableArray<Cci.IParameterTypeInformation>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10194, 6211, 6321);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10194, 6104, 6332);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10194, 6104, 6332);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.CallingConvention Cci.ISignature.CallingConvention
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10194, 6423, 6519);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 6459, 6504);

                    return f_10194_6466_6503(f_10194_6466_6485());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10194, 6423, 6519);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10194_6466_6485()
                    {
                        var return_v = AdaptedMethodSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 6466, 6485);
                        return return_v;
                    }


                    Microsoft.Cci.CallingConvention
                    f_10194_6466_6503(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.CallingConvention;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 6466, 6503);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10194, 6344, 6530);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10194, 6344, 6530);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ImmutableArray<Cci.IParameterTypeInformation> Cci.ISignature.GetParameters(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10194, 6542, 7196);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 6662, 6706);

                f_10194_6662_6705(f_10194_6675_6704(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 6722, 6789);

                PEModuleBuilder
                moduleBeingBuilt = (PEModuleBuilder)context.Module
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 6803, 7185) || true) && (f_10194_6807_6839(f_10194_6807_6826()) && (DynAbs.Tracing.TraceSender.Expression_True(10194, 6807, 6912) && f_10194_6843_6879(f_10194_6843_6862()) == moduleBeingBuilt.SourceModule))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10194, 6803, 7185);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 6946, 7038);

                    return f_10194_6953_7037(f_10194_7000_7036(this));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10194, 6803, 7185);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10194, 6803, 7185);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 7104, 7170);

                    return f_10194_7111_7169(moduleBeingBuilt, f_10194_7138_7168(f_10194_7138_7157()));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10194, 6803, 7185);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10194, 6542, 7196);

                bool
                f_10194_6675_6704(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                this_param)
                {
                    var return_v = this_param.IsDefinitionOrDistinct();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 6675, 6704);
                    return return_v;
                }


                int
                f_10194_6662_6705(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 6662, 6705);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10194_6807_6826()
                {
                    var return_v = AdaptedMethodSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 6807, 6826);
                    return return_v;
                }


                bool
                f_10194_6807_6839(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 6807, 6839);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10194_6843_6862()
                {
                    var return_v = AdaptedMethodSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 6843, 6862);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10194_6843_6879(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 6843, 6879);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IParameterDefinition>
                f_10194_7000_7036(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                this_param)
                {
                    var return_v = this_param.EnumerateDefinitionParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 7000, 7036);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IParameterTypeInformation>
                f_10194_6953_7037(System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IParameterDefinition>
                from)
                {
                    var return_v = StaticCast<Cci.IParameterTypeInformation>.From(from);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 6953, 7037);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10194_7138_7157()
                {
                    var return_v = AdaptedMethodSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 7138, 7157);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10194_7138_7168(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 7138, 7168);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IParameterTypeInformation>
                f_10194_7111_7169(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                @params)
                {
                    var return_v = this_param.Translate(@params);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 7111, 7169);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10194, 6542, 7196);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10194, 6542, 7196);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<Cci.IParameterDefinition> EnumerateDefinitionParameters()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10194, 7208, 7650);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 7313, 7383);

                f_10194_7313_7382(f_10194_7326_7345().Parameters.All(p => p.IsDefinition));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 7410, 7529);

                return f_10194_7417_7436().Parameters.SelectAsArray<ParameterSymbol, Cci.IParameterDefinition>(p => p.GetCciAdapter());
                DynAbs.Tracing.TraceSender.TraceExitMethod(10194, 7208, 7650);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10194_7326_7345()
                {
                    var return_v = AdaptedMethodSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 7326, 7345);
                    return return_v;
                }


                int
                f_10194_7313_7382(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 7313, 7382);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10194_7417_7436()
                {
                    var return_v = AdaptedMethodSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 7417, 7436);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10194, 7208, 7650);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10194, 7208, 7650);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        ImmutableArray<Cci.ICustomModifier> Cci.ISignature.ReturnValueCustomModifiers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10194, 7764, 7928);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 7800, 7913);

                    return ImmutableArray<Cci.ICustomModifier>.CastUp(f_10194_7850_7869().ReturnTypeWithAnnotations.CustomModifiers);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10194, 7764, 7928);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10194_7850_7869()
                    {
                        var return_v = AdaptedMethodSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 7850, 7869);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10194, 7662, 7939);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10194, 7662, 7939);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ImmutableArray<Cci.ICustomModifier> Cci.ISignature.RefCustomModifiers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10194, 8045, 8186);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 8081, 8171);

                    return ImmutableArray<Cci.ICustomModifier>.CastUp(f_10194_8131_8169(f_10194_8131_8150()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10194, 8045, 8186);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10194_8131_8150()
                    {
                        var return_v = AdaptedMethodSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 8131, 8150);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    f_10194_8131_8169(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.RefCustomModifiers;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 8131, 8169);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10194, 7951, 8197);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10194, 7951, 8197);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool Cci.ISignature.ReturnValueIsByRef
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10194, 8272, 8379);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 8308, 8364);

                    return f_10194_8315_8363(f_10194_8315_8342(f_10194_8315_8334()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10194, 8272, 8379);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10194_8315_8334()
                    {
                        var return_v = AdaptedMethodSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 8315, 8334);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.RefKind
                    f_10194_8315_8342(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.RefKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 8315, 8342);
                        return return_v;
                    }


                    bool
                    f_10194_8315_8363(Microsoft.CodeAnalysis.RefKind
                    refKind)
                    {
                        var return_v = refKind.IsManagedReference();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 8315, 8363);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10194, 8209, 8390);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10194, 8209, 8390);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.ITypeReference Cci.ISignature.GetType(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10194, 8402, 8707);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 8489, 8696);

                return f_10194_8496_8695(((PEModuleBuilder)context.Module), f_10194_8540_8570(f_10194_8540_8559()), (CSharpSyntaxNode)context.SyntaxNodeOpt, diagnostics: context.Diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10194, 8402, 8707);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10194_8540_8559()
                {
                    var return_v = AdaptedMethodSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 8540, 8559);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10194_8540_8570(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 8540, 8570);
                    return return_v;
                }


                Microsoft.Cci.ITypeReference
                f_10194_8496_8695(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeSymbol, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.Translate(typeSymbol, syntaxNodeOpt: (Microsoft.CodeAnalysis.SyntaxNode)syntaxNodeOpt, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 8496, 8695);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10194, 8402, 8707);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10194, 8402, 8707);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        IEnumerable<Cci.ITypeReference> Cci.IGenericMethodInstanceReference.GetGenericArguments(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10194, 8719, 9477);

                var listYield = new List<Cci.ITypeReference>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 8852, 8919);

                PEModuleBuilder
                moduleBeingBuilt = (PEModuleBuilder)context.Module
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 8935, 9019);

                f_10194_8935_9018(f_10194_8948_9009(((Cci.IMethodReference)this)) != null);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 9035, 9466);
                    foreach (var arg in f_10194_9055_9103_I(f_10194_9055_9103(f_10194_9055_9074())))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10194, 9035, 9466);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 9137, 9179);

                        f_10194_9137_9178(arg.CustomModifiers.IsEmpty);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 9197, 9451);

                        listYield.Add(f_10194_9210_9450(moduleBeingBuilt, arg.Type, (CSharpSyntaxNode)context.SyntaxNodeOpt, diagnostics: context.Diagnostics));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10194, 9035, 9466);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10194, 1, 432);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10194, 1, 432);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10194, 8719, 9477);

                return listYield;

                Microsoft.Cci.IGenericMethodInstanceReference?
                f_10194_8948_9009(Microsoft.Cci.IMethodReference
                this_param)
                {
                    var return_v = this_param.AsGenericMethodInstanceReference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 8948, 9009);
                    return return_v;
                }


                int
                f_10194_8935_9018(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 8935, 9018);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10194_9055_9074()
                {
                    var return_v = AdaptedMethodSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 9055, 9074);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10194_9055_9103(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.TypeArgumentsWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 9055, 9103);
                    return return_v;
                }


                int
                f_10194_9137_9178(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 9137, 9178);
                    return 0;
                }


                Microsoft.Cci.ITypeReference
                f_10194_9210_9450(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeSymbol, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.Translate(typeSymbol, syntaxNodeOpt: (Microsoft.CodeAnalysis.SyntaxNode)syntaxNodeOpt, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 9210, 9450);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10194_9055_9103_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 9055, 9103);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10194, 8719, 9477);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10194, 8719, 9477);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        Cci.IMethodReference Cci.IGenericMethodInstanceReference.GetGenericMethod(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10194, 9489, 10401);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 9608, 9692);

                f_10194_9608_9691(f_10194_9621_9682(((Cci.IMethodReference)this)) != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 9708, 9771);

                NamedTypeSymbol
                container = f_10194_9736_9770(f_10194_9736_9755())
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 9787, 10242) || true) && (!f_10194_9792_9832(container))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10194, 9787, 10242);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 9924, 10227);

                    return f_10194_9931_10226(((PEModuleBuilder)context.Module), f_10194_10011_10049(f_10194_10011_10030()), (CSharpSyntaxNode)context.SyntaxNodeOpt, diagnostics: context.Diagnostics, needDeclaration: true);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10194, 9787, 10242);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 10258, 10322);

                MethodSymbol
                methodSymbol = f_10194_10286_10321(f_10194_10286_10305())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 10338, 10390);

                return f_10194_10345_10389(methodSymbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10194, 9489, 10401);

                Microsoft.Cci.IGenericMethodInstanceReference?
                f_10194_9621_9682(Microsoft.Cci.IMethodReference
                this_param)
                {
                    var return_v = this_param.AsGenericMethodInstanceReference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 9621, 9682);
                    return return_v;
                }


                int
                f_10194_9608_9691(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 9608, 9691);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10194_9736_9755()
                {
                    var return_v = AdaptedMethodSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 9736, 9755);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10194_9736_9770(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 9736, 9770);
                    return return_v;
                }


                bool
                f_10194_9792_9832(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                toCheck)
                {
                    var return_v = PEModuleBuilder.IsGenericType(toCheck);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 9792, 9832);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10194_10011_10030()
                {
                    var return_v = AdaptedMethodSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 10011, 10030);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10194_10011_10049(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 10011, 10049);
                    return return_v;
                }


                Microsoft.Cci.IMethodReference
                f_10194_9931_10226(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                methodSymbol, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                needDeclaration)
                {
                    var return_v = this_param.Translate(methodSymbol, syntaxNodeOpt: (Microsoft.CodeAnalysis.SyntaxNode)syntaxNodeOpt, diagnostics: diagnostics, needDeclaration: needDeclaration);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 9931, 10226);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10194_10286_10305()
                {
                    var return_v = AdaptedMethodSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 10286, 10305);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10194_10286_10321(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ConstructedFrom;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 10286, 10321);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Emit.SpecializedMethodReference
                f_10194_10345_10389(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                underlyingMethod)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Emit.SpecializedMethodReference(underlyingMethod);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 10345, 10389);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10194, 9489, 10401);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10194, 9489, 10401);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        Cci.IMethodReference Cci.ISpecializedMethodReference.UnspecializedVersion
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10194, 10511, 10738);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 10547, 10627);

                    f_10194_10547_10626(f_10194_10560_10617(((Cci.IMethodReference)this)) != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 10645, 10723);

                    return f_10194_10652_10722(((MethodSymbol)f_10194_10667_10705(f_10194_10667_10686())));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10194, 10511, 10738);

                    Microsoft.Cci.ISpecializedMethodReference?
                    f_10194_10560_10617(Microsoft.Cci.IMethodReference
                    this_param)
                    {
                        var return_v = this_param.AsSpecializedMethodReference;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 10560, 10617);
                        return return_v;
                    }


                    int
                    f_10194_10547_10626(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 10547, 10626);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10194_10667_10686()
                    {
                        var return_v = AdaptedMethodSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 10667, 10686);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10194_10667_10705(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 10667, 10705);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                    f_10194_10652_10722(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.GetCciAdapter();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 10652, 10722);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10194, 10413, 10749);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10194, 10413, 10749);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.ITypeDefinition Cci.ITypeDefinitionMember.ContainingTypeDefinition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10194, 10856, 11311);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 10892, 10919);

                    f_10194_10892_10918(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 10939, 11022);

                    var
                    synthesizedGlobalMethod = f_10194_10969_10988() as SynthesizedGlobalMethodSymbol
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 11040, 11218) || true) && ((object)synthesizedGlobalMethod != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10194, 11040, 11218);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 11125, 11199);

                        return f_10194_11132_11198(synthesizedGlobalMethod);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10194, 11040, 11218);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 11238, 11296);

                    return f_10194_11245_11295(f_10194_11245_11279(f_10194_11245_11264()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10194, 10856, 11311);

                    int
                    f_10194_10892_10918(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 10892, 10918);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10194_10969_10988()
                    {
                        var return_v = AdaptedMethodSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 10969, 10988);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CodeGen.PrivateImplementationDetails
                    f_10194_11132_11198(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedGlobalMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingPrivateImplementationDetailsType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 11132, 11198);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10194_11245_11264()
                    {
                        var return_v = AdaptedMethodSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 11245, 11264);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10194_11245_11279(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 11245, 11279);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                    f_10194_11245_11295(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.GetCciAdapter();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 11245, 11295);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10194, 10761, 11322);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10194, 10761, 11322);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10194, 11420, 11577);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 11456, 11483);

                    f_10194_11456_11482(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 11501, 11562);

                    return f_10194_11508_11561(f_10194_11541_11560());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10194, 11420, 11577);

                    int
                    f_10194_11456_11482(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 11456, 11482);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10194_11541_11560()
                    {
                        var return_v = AdaptedMethodSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 11541, 11560);
                        return return_v;
                    }


                    Microsoft.Cci.TypeMemberVisibility
                    f_10194_11508_11561(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    symbol)
                    {
                        var return_v = PEModuleBuilder.MemberVisibility((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 11508, 11561);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10194, 11334, 11588);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10194, 11334, 11588);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.IMethodBody Cci.IMethodDefinition.GetBody(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10194, 11600, 11819);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 11691, 11718);

                f_10194_11691_11717(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 11732, 11808);

                return f_10194_11739_11807(((PEModuleBuilder)context.Module), f_10194_11787_11806());
                DynAbs.Tracing.TraceSender.TraceExitMethod(10194, 11600, 11819);

                int
                f_10194_11691_11717(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                this_param)
                {
                    this_param.CheckDefinitionInvariant();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 11691, 11717);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10194_11787_11806()
                {
                    var return_v = AdaptedMethodSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 11787, 11806);
                    return return_v;
                }


                Microsoft.Cci.IMethodBody
                f_10194_11739_11807(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                methodSymbol)
                {
                    var return_v = this_param.GetMethodBody((Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal)methodSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 11739, 11807);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10194, 11600, 11819);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10194, 11600, 11819);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        IEnumerable<Cci.IGenericMethodParameter> Cci.IMethodDefinition.GenericParameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10194, 11936, 12244);

                    var listYield = new List<Cci.IGenericMethodParameter>();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 11972, 11999);

                    f_10194_11972_11998(this);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 12019, 12229);
                        foreach (var @param in f_10194_12042_12076_I(f_10194_12042_12076(f_10194_12042_12061())))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10194, 12019, 12229);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 12118, 12152);

                            f_10194_12118_12151(f_10194_12131_12150(@param));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 12174, 12210);

                            listYield.Add(f_10194_12187_12209(@param));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10194, 12019, 12229);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10194, 1, 211);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10194, 1, 211);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10194, 11936, 12244);

                    return listYield;

                    int
                    f_10194_11972_11998(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 11972, 11998);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10194_12042_12061()
                    {
                        var return_v = AdaptedMethodSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 12042, 12061);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    f_10194_12042_12076(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeParameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 12042, 12076);
                        return return_v;
                    }


                    bool
                    f_10194_12131_12150(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.IsDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 12131, 12150);
                        return return_v;
                    }


                    int
                    f_10194_12118_12151(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 12118, 12151);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbolAdapter
                    f_10194_12187_12209(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.GetCciAdapter();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 12187, 12209);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    f_10194_12042_12076_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 12042, 12076);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10194, 11831, 12255);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10194, 11831, 12255);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool Cci.IMethodDefinition.HasDeclarativeSecurity
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10194, 12341, 12487);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 12377, 12404);

                    f_10194_12377_12403(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 12422, 12472);

                    return f_10194_12429_12471(f_10194_12429_12448());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10194, 12341, 12487);

                    int
                    f_10194_12377_12403(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 12377, 12403);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10194_12429_12448()
                    {
                        var return_v = AdaptedMethodSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 12429, 12448);
                        return return_v;
                    }


                    bool
                    f_10194_12429_12471(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.HasDeclarativeSecurity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 12429, 12471);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10194, 12267, 12498);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10194, 12267, 12498);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        IEnumerable<Cci.SecurityAttribute> Cci.IMethodDefinition.SecurityAttributes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10194, 12610, 12833);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 12646, 12673);

                    f_10194_12646_12672(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 12691, 12748);

                    f_10194_12691_12747(f_10194_12704_12746(f_10194_12704_12723()));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 12766, 12818);

                    return f_10194_12773_12817(f_10194_12773_12792());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10194, 12610, 12833);

                    int
                    f_10194_12646_12672(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 12646, 12672);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10194_12704_12723()
                    {
                        var return_v = AdaptedMethodSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 12704, 12723);
                        return return_v;
                    }


                    bool
                    f_10194_12704_12746(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.HasDeclarativeSecurity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 12704, 12746);
                        return return_v;
                    }


                    int
                    f_10194_12691_12747(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 12691, 12747);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10194_12773_12792()
                    {
                        var return_v = AdaptedMethodSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 12773, 12792);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<Microsoft.Cci.SecurityAttribute>
                    f_10194_12773_12817(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.GetSecurityInformation();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 12773, 12817);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10194, 12510, 12844);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10194, 12510, 12844);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool Cci.IMethodDefinition.IsAbstract
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10194, 12918, 13052);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 12954, 12981);

                    f_10194_12954_12980(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 12999, 13037);

                    return f_10194_13006_13036(f_10194_13006_13025());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10194, 12918, 13052);

                    int
                    f_10194_12954_12980(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 12954, 12980);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10194_13006_13025()
                    {
                        var return_v = AdaptedMethodSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 13006, 13025);
                        return return_v;
                    }


                    bool
                    f_10194_13006_13036(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsAbstract;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 13006, 13036);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10194, 12856, 13063);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10194, 12856, 13063);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool Cci.IMethodDefinition.IsAccessCheckedOnOverride
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10194, 13152, 13303);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 13188, 13215);

                    f_10194_13188_13214(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 13235, 13288);

                    return f_10194_13242_13287(f_10194_13242_13261());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10194, 13152, 13303);

                    int
                    f_10194_13188_13214(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 13188, 13214);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10194_13242_13261()
                    {
                        var return_v = AdaptedMethodSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 13242, 13261);
                        return return_v;
                    }


                    bool
                    f_10194_13242_13287(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsAccessCheckedOnOverride;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 13242, 13287);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10194, 13075, 13314);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10194, 13075, 13314);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool Cci.IMethodDefinition.IsConstructor
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10194, 13391, 13551);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 13427, 13454);

                    f_10194_13427_13453(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 13472, 13536);

                    return f_10194_13479_13509(f_10194_13479_13498()) == MethodKind.Constructor;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10194, 13391, 13551);

                    int
                    f_10194_13427_13453(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 13427, 13453);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10194_13479_13498()
                    {
                        var return_v = AdaptedMethodSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 13479, 13498);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.MethodKind
                    f_10194_13479_13509(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.MethodKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 13479, 13509);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10194, 13326, 13562);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10194, 13326, 13562);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool Cci.IMethodDefinition.IsExternal
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10194, 13636, 13772);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 13672, 13699);

                    f_10194_13672_13698(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 13719, 13757);

                    return f_10194_13726_13756(f_10194_13726_13745());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10194, 13636, 13772);

                    int
                    f_10194_13672_13698(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 13672, 13698);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10194_13726_13745()
                    {
                        var return_v = AdaptedMethodSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 13726, 13745);
                        return return_v;
                    }


                    bool
                    f_10194_13726_13756(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsExternal;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 13726, 13756);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10194, 13574, 13783);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10194, 13574, 13783);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool Cci.IMethodDefinition.IsHiddenBySignature
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10194, 13866, 14013);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 13902, 13929);

                    f_10194_13902_13928(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 13947, 13998);

                    return f_10194_13954_13997_M(!f_10194_13955_13974().HidesBaseMethodsByName);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10194, 13866, 14013);

                    int
                    f_10194_13902_13928(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 13902, 13928);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10194_13955_13974()
                    {
                        var return_v = AdaptedMethodSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 13955, 13974);
                        return return_v;
                    }


                    bool
                    f_10194_13954_13997_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 13954, 13997);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10194, 13795, 14024);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10194, 13795, 14024);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool Cci.IMethodDefinition.IsNewSlot
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10194, 14097, 14240);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 14133, 14160);

                    f_10194_14133_14159(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 14178, 14225);

                    return f_10194_14185_14224(f_10194_14185_14204());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10194, 14097, 14240);

                    int
                    f_10194_14133_14159(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 14133, 14159);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10194_14185_14204()
                    {
                        var return_v = AdaptedMethodSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 14185, 14204);
                        return return_v;
                    }


                    bool
                    f_10194_14185_14224(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsMetadataNewSlot();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 14185, 14224);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10194, 14036, 14251);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10194, 14036, 14251);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool Cci.IMethodDefinition.IsPlatformInvoke
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10194, 14331, 14481);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 14367, 14394);

                    f_10194_14367_14393(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 14412, 14466);

                    return f_10194_14419_14457(f_10194_14419_14438()) != null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10194, 14331, 14481);

                    int
                    f_10194_14367_14393(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 14367, 14393);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10194_14419_14438()
                    {
                        var return_v = AdaptedMethodSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 14419, 14438);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.DllImportData?
                    f_10194_14419_14457(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.GetDllImportData();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 14419, 14457);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10194, 14263, 14492);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10194, 14263, 14492);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.IPlatformInvokeInformation Cci.IMethodDefinition.PlatformInvokeData
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10194, 14600, 14742);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 14636, 14663);

                    f_10194_14636_14662(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 14681, 14727);

                    return f_10194_14688_14726(f_10194_14688_14707());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10194, 14600, 14742);

                    int
                    f_10194_14636_14662(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 14636, 14662);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10194_14688_14707()
                    {
                        var return_v = AdaptedMethodSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 14688, 14707);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.DllImportData?
                    f_10194_14688_14726(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.GetDllImportData();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 14688, 14726);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10194, 14504, 14753);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10194, 14504, 14753);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        System.Reflection.MethodImplAttributes Cci.IMethodDefinition.GetImplementationAttributes(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10194, 14765, 15003);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 14899, 14926);

                f_10194_14899_14925(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 14940, 14992);

                return f_10194_14947_14991(f_10194_14947_14966());
                DynAbs.Tracing.TraceSender.TraceExitMethod(10194, 14765, 15003);

                int
                f_10194_14899_14925(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                this_param)
                {
                    this_param.CheckDefinitionInvariant();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 14899, 14925);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10194_14947_14966()
                {
                    var return_v = AdaptedMethodSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 14947, 14966);
                    return return_v;
                }


                System.Reflection.MethodImplAttributes
                f_10194_14947_14991(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ImplementationAttributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 14947, 14991);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10194, 14765, 15003);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10194, 14765, 15003);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        bool Cci.IMethodDefinition.IsRuntimeSpecial
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10194, 15083, 15228);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 15119, 15146);

                    f_10194_15119_15145(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 15164, 15213);

                    return f_10194_15171_15212(f_10194_15171_15190());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10194, 15083, 15228);

                    int
                    f_10194_15119_15145(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 15119, 15145);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10194_15171_15190()
                    {
                        var return_v = AdaptedMethodSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 15171, 15190);
                        return return_v;
                    }


                    bool
                    f_10194_15171_15212(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.HasRuntimeSpecialName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 15171, 15212);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10194, 15015, 15239);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10194, 15015, 15239);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool Cci.IMethodDefinition.IsSealed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10194, 15311, 15450);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 15347, 15374);

                    f_10194_15347_15373(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 15392, 15435);

                    return f_10194_15399_15434(f_10194_15399_15418());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10194, 15311, 15450);

                    int
                    f_10194_15347_15373(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 15347, 15373);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10194_15399_15418()
                    {
                        var return_v = AdaptedMethodSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 15399, 15418);
                        return return_v;
                    }


                    bool
                    f_10194_15399_15434(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsMetadataFinal;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 15399, 15434);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10194, 15251, 15461);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10194, 15251, 15461);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool Cci.IMethodDefinition.IsSpecialName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10194, 15538, 15676);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 15574, 15601);

                    f_10194_15574_15600(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 15619, 15661);

                    return f_10194_15626_15660(f_10194_15626_15645());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10194, 15538, 15676);

                    int
                    f_10194_15574_15600(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 15574, 15600);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10194_15626_15645()
                    {
                        var return_v = AdaptedMethodSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 15626, 15645);
                        return return_v;
                    }


                    bool
                    f_10194_15626_15660(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.HasSpecialName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 15626, 15660);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10194, 15473, 15687);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10194, 15473, 15687);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool Cci.IMethodDefinition.IsStatic
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10194, 15759, 15891);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 15795, 15822);

                    f_10194_15795_15821(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 15840, 15876);

                    return f_10194_15847_15875(f_10194_15847_15866());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10194, 15759, 15891);

                    int
                    f_10194_15795_15821(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 15795, 15821);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10194_15847_15866()
                    {
                        var return_v = AdaptedMethodSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 15847, 15866);
                        return return_v;
                    }


                    bool
                    f_10194_15847_15875(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsStatic;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 15847, 15875);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10194, 15699, 15902);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10194, 15699, 15902);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool Cci.IMethodDefinition.IsVirtual
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10194, 15975, 16118);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 16011, 16038);

                    f_10194_16011_16037(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 16056, 16103);

                    return f_10194_16063_16102(f_10194_16063_16082());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10194, 15975, 16118);

                    int
                    f_10194_16011_16037(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 16011, 16037);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10194_16063_16082()
                    {
                        var return_v = AdaptedMethodSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 16063, 16082);
                        return return_v;
                    }


                    bool
                    f_10194_16063_16102(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsMetadataVirtual();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 16063, 16102);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10194, 15914, 16129);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10194, 15914, 16129);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ImmutableArray<Cci.IParameterDefinition> Cci.IMethodDefinition.Parameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10194, 16239, 16374);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 16275, 16302);

                    f_10194_16275_16301(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 16320, 16359);

                    return f_10194_16327_16358(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10194, 16239, 16374);

                    int
                    f_10194_16275_16301(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 16275, 16301);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IParameterDefinition>
                    f_10194_16327_16358(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                    this_param)
                    {
                        var return_v = this_param.EnumerateDefinitionParameters();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 16327, 16358);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10194, 16141, 16385);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10194, 16141, 16385);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool Cci.IMethodDefinition.RequiresSecurityObject
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10194, 16471, 16619);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 16507, 16534);

                    f_10194_16507_16533(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 16554, 16604);

                    return f_10194_16561_16603(f_10194_16561_16580());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10194, 16471, 16619);

                    int
                    f_10194_16507_16533(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 16507, 16533);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10194_16561_16580()
                    {
                        var return_v = AdaptedMethodSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 16561, 16580);
                        return return_v;
                    }


                    bool
                    f_10194_16561_16603(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.RequiresSecurityObject;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 16561, 16603);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10194, 16397, 16630);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10194, 16397, 16630);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        IEnumerable<Cci.ICustomAttribute> Cci.IMethodDefinition.GetReturnValueAttributes(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10194, 16642, 17467);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 16768, 16795);

                f_10194_16768_16794(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 16811, 16907);

                ImmutableArray<CSharpAttributeData>
                userDefined = f_10194_16861_16906(f_10194_16861_16880())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 16921, 16979);

                ArrayBuilder<SynthesizedAttributeData>
                synthesized = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 16993, 17098);

                f_10194_16993_17097(f_10194_16993_17012(), context.Module, ref synthesized);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 17311, 17456);

                return f_10194_17318_17455(f_10194_17318_17337(), userDefined, synthesized, isReturnType: true, emittingAssemblyAttributesInNetModule: false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10194, 16642, 17467);

                int
                f_10194_16768_16794(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                this_param)
                {
                    this_param.CheckDefinitionInvariant();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 16768, 16794);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10194_16861_16880()
                {
                    var return_v = AdaptedMethodSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 16861, 16880);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10194_16861_16906(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.GetReturnTypeAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 16861, 16906);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10194_16993_17012()
                {
                    var return_v = AdaptedMethodSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 16993, 17012);
                    return return_v;
                }


                int
                f_10194_16993_17097(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                moduleBuilder, ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>?
                attributes)
                {
                    this_param.AddSynthesizedReturnTypeAttributes((Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder)moduleBuilder, ref attributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 16993, 17097);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10194_17318_17337()
                {
                    var return_v = AdaptedMethodSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 17318, 17337);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10194_17318_17455(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                userDefined, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                synthesized, bool
                isReturnType, bool
                emittingAssemblyAttributesInNetModule)
                {
                    var return_v = this_param.GetCustomAttributesToEmit(userDefined, synthesized, isReturnType: isReturnType, emittingAssemblyAttributesInNetModule: emittingAssemblyAttributesInNetModule);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 17318, 17455);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10194, 16642, 17467);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10194, 16642, 17467);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        bool Cci.IMethodDefinition.ReturnValueIsMarshalledExplicitly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10194, 17564, 17721);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 17600, 17627);

                    f_10194_17600_17626(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 17645, 17706);

                    return f_10194_17652_17705(f_10194_17652_17671());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10194, 17564, 17721);

                    int
                    f_10194_17600_17626(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 17600, 17626);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10194_17652_17671()
                    {
                        var return_v = AdaptedMethodSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 17652, 17671);
                        return return_v;
                    }


                    bool
                    f_10194_17652_17705(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ReturnValueIsMarshalledExplicitly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 17652, 17705);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10194, 17479, 17732);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10194, 17479, 17732);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.IMarshallingInformation Cci.IMethodDefinition.ReturnValueMarshallingInformation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10194, 17852, 18009);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 17888, 17915);

                    f_10194_17888_17914(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 17933, 17994);

                    return f_10194_17940_17993(f_10194_17940_17959());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10194, 17852, 18009);

                    int
                    f_10194_17888_17914(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 17888, 17914);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10194_17940_17959()
                    {
                        var return_v = AdaptedMethodSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 17940, 17959);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.MarshalPseudoCustomAttributeData
                    f_10194_17940_17993(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ReturnValueMarshallingInformation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 17940, 17993);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10194, 17744, 18020);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10194, 17744, 18020);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ImmutableArray<byte> Cci.IMethodDefinition.ReturnValueMarshallingDescriptor
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10194, 18132, 18288);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 18168, 18195);

                    f_10194_18168_18194(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 18213, 18273);

                    return f_10194_18220_18272(f_10194_18220_18239());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10194, 18132, 18288);

                    int
                    f_10194_18168_18194(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 18168, 18194);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10194_18220_18239()
                    {
                        var return_v = AdaptedMethodSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 18220, 18239);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<byte>
                    f_10194_18220_18272(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ReturnValueMarshallingDescriptor;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 18220, 18272);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10194, 18032, 18299);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10194, 18032, 18299);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.INamespace Cci.IMethodDefinition.ContainingNamespace
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10194, 18392, 18506);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 18428, 18491);

                    return f_10194_18435_18490(f_10194_18435_18474(f_10194_18435_18454()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10194, 18392, 18506);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10194_18435_18454()
                    {
                        var return_v = AdaptedMethodSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 18435, 18454);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    f_10194_18435_18474(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingNamespace;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 18435, 18474);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbolAdapter
                    f_10194_18435_18490(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    this_param)
                    {
                        var return_v = this_param.GetCciAdapter();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 18435, 18490);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10194, 18311, 18517);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10194, 18311, 18517);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static MethodSymbolAdapter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10194, 570, 18524);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10194, 570, 18524);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10194, 570, 18524);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10194, 570, 18524);
    }
    internal partial class MethodSymbol
    {
        private MethodSymbolAdapter _lazyAdapter;

        protected sealed override SymbolAdapter GetCciAdapterImpl()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10194, 18708, 18726);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 18711, 18726);
                return f_10194_18711_18726(this); DynAbs.Tracing.TraceSender.TraceExitMethod(10194, 18708, 18726);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10194, 18708, 18726);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10194, 18708, 18726);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
            f_10194_18711_18726(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
            this_param)
            {
                var return_v = this_param.GetCciAdapter();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 18711, 18726);
                return return_v;
            }

        }

        internal new MethodSymbolAdapter GetCciAdapter()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10194, 18739, 19010);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 18812, 18963) || true) && (_lazyAdapter is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10194, 18812, 18963);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 18870, 18948);

                    return f_10194_18877_18947(ref _lazyAdapter, f_10194_18928_18946(this));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10194, 18812, 18963);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 18979, 18999);

                return _lazyAdapter;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10194, 18739, 19010);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                f_10194_18928_18946(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.CreateCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 18928, 18946);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                f_10194_18877_18947(ref Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter?
                target, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                value)
                {
                    var return_v = InterlockedOperations.Initialize(ref target, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 18877, 18947);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10194, 18739, 19010);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10194, 18739, 19010);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected virtual MethodSymbolAdapter CreateCciAdapter()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10194, 19022, 19151);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 19103, 19140);

                return f_10194_19110_19139(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10194, 19022, 19151);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                f_10194_19110_19139(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                underlyingMethodSymbol)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter(underlyingMethodSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 19110, 19139);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10194, 19022, 19151);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10194, 19022, 19151);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual bool IsAccessCheckedOnOverride
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10194, 19411, 20148);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 19447, 19474);

                    f_10194_19447_19473(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 19785, 19842);

                    Accessibility
                    accessibility = f_10194_19815_19841(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 19860, 20133);

                    return (accessibility == Accessibility.Private || (DynAbs.Tracing.TraceSender.Expression_False(10194, 19868, 19986) || accessibility == Accessibility.ProtectedAndInternal) || (DynAbs.Tracing.TraceSender.Expression_False(10194, 19868, 20054) || accessibility == Accessibility.Internal))
                    && (DynAbs.Tracing.TraceSender.Expression_True(10194, 19867, 20107) && f_10194_20083_20107(this)) && (DynAbs.Tracing.TraceSender.Expression_True(10194, 19867, 20132) && f_10194_20111_20132_M(!this.IsMetadataFinal));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10194, 19411, 20148);

                    int
                    f_10194_19447_19473(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 19447, 19473);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.Accessibility
                    f_10194_19815_19841(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.DeclaredAccessibility;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 19815, 19841);
                        return return_v;
                    }


                    bool
                    f_10194_20083_20107(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsMetadataVirtual();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 20083, 20107);
                        return return_v;
                    }


                    bool
                    f_10194_20111_20132_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 20111, 20132);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10194, 19339, 20159);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10194, 19339, 20159);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual bool IsExternal
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10194, 20228, 20851);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 20264, 20291);

                    f_10194_20264_20290(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 20733, 20836);

                    return f_10194_20740_20753(this) || (DynAbs.Tracing.TraceSender.Expression_False(10194, 20740, 20835) || (object)f_10194_20765_20779() != null && (DynAbs.Tracing.TraceSender.Expression_True(10194, 20757, 20835) && f_10194_20791_20814(f_10194_20791_20805()) == TypeKind.Delegate));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10194, 20228, 20851);

                    int
                    f_10194_20264_20290(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 20264, 20290);
                        return 0;
                    }


                    bool
                    f_10194_20740_20753(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsExtern;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 20740, 20753);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10194_20765_20779()
                    {
                        var return_v = ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 20765, 20779);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10194_20791_20805()
                    {
                        var return_v = ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 20791, 20805);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.TypeKind
                    f_10194_20791_20814(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 20791, 20814);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10194, 20171, 20862);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10194, 20171, 20862);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal abstract bool IsMetadataNewSlot(bool ignoreInterfaceImplementationChanges = false);

        internal virtual bool HasRuntimeSpecialName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10194, 21769, 21986);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 21805, 21832);

                    f_10194_21805_21831(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 21850, 21971);

                    return f_10194_21857_21872(this) == MethodKind.Constructor
                    || (DynAbs.Tracing.TraceSender.Expression_False(10194, 21857, 21970) || f_10194_21923_21938(this) == MethodKind.StaticConstructor);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10194, 21769, 21986);

                    int
                    f_10194_21805_21831(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 21805, 21831);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.MethodKind
                    f_10194_21857_21872(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.MethodKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 21857, 21872);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.MethodKind
                    f_10194_21923_21938(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.MethodKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 21923, 21938);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10194, 21701, 21997);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10194, 21701, 21997);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual bool IsMetadataFinal
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10194, 22071, 22456);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 22169, 22224);

                    f_10194_22169_22223(f_10194_22182_22197(this) != MethodKind.Destructor);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 22244, 22441);

                    return f_10194_22251_22264(this) || (DynAbs.Tracing.TraceSender.Expression_False(10194, 22251, 22440) || (f_10194_22290_22314(this) && (DynAbs.Tracing.TraceSender.Expression_True(10194, 22290, 22439) && !(f_10194_22342_22356(this) || (DynAbs.Tracing.TraceSender.Expression_False(10194, 22342, 22375) || f_10194_22360_22375(this)) || (DynAbs.Tracing.TraceSender.Expression_False(10194, 22342, 22394) || f_10194_22379_22394(this)) || (DynAbs.Tracing.TraceSender.Expression_False(10194, 22342, 22438) || f_10194_22398_22413(this) == MethodKind.Destructor)))));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10194, 22071, 22456);

                    Microsoft.CodeAnalysis.MethodKind
                    f_10194_22182_22197(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.MethodKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 22182, 22197);
                        return return_v;
                    }


                    int
                    f_10194_22169_22223(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 22169, 22223);
                        return 0;
                    }


                    bool
                    f_10194_22251_22264(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsSealed;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 22251, 22264);
                        return return_v;
                    }


                    bool
                    f_10194_22290_22314(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsMetadataVirtual();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 22290, 22314);
                        return return_v;
                    }


                    bool
                    f_10194_22342_22356(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsVirtual;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 22342, 22356);
                        return return_v;
                    }


                    bool
                    f_10194_22360_22375(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsOverride;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 22360, 22375);
                        return return_v;
                    }


                    bool
                    f_10194_22379_22394(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsAbstract;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 22379, 22394);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.MethodKind
                    f_10194_22398_22413(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.MethodKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 22398, 22413);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10194, 22009, 22467);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10194, 22009, 22467);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal abstract bool IsMetadataVirtual(bool ignoreInterfaceImplementationChanges = false);

        internal virtual bool ReturnValueIsMarshalledExplicitly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10194, 23386, 23536);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 23422, 23449);

                    f_10194_23422_23448(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 23467, 23521);

                    return f_10194_23474_23512(this) != null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10194, 23386, 23536);

                    int
                    f_10194_23422_23448(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 23422, 23448);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.MarshalPseudoCustomAttributeData
                    f_10194_23474_23512(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ReturnValueMarshallingInformation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 23474, 23512);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10194, 23306, 23547);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10194, 23306, 23547);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual ImmutableArray<byte> ReturnValueMarshallingDescriptor
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10194, 23654, 23787);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 23690, 23717);

                    f_10194_23690_23716(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 23735, 23772);

                    return default(ImmutableArray<byte>);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10194, 23654, 23787);

                    int
                    f_10194_23690_23716(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10194, 23690, 23716);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10194, 23559, 23798);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10194, 23559, 23798);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static MethodSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10194, 18532, 23805);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 908, 919);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10194, 18532, 23805);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10194, 18532, 23805);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10194, 18532, 23805);
    }
    internal partial class MethodSymbolAdapter
    {
        internal MethodSymbolAdapter(MethodSymbol underlyingMethodSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10194, 23883, 24246);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 24337, 24387);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 23973, 24018);

                AdaptedMethodSymbol = underlyingMethodSymbol;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 24034, 24235) || true) && (underlyingMethodSymbol is NativeIntegerMethodSymbol)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10194, 24034, 24235);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 24183, 24220);

                    throw f_10194_24189_24219();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10194, 24034, 24235);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10194, 23883, 24246);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10194, 23883, 24246);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10194, 23883, 24246);
            }
        }

        internal sealed override Symbol AdaptedSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10194, 24304, 24326);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 24307, 24326);
                    return f_10194_24307_24326(); DynAbs.Tracing.TraceSender.TraceExitMethod(10194, 24304, 24326);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10194, 24304, 24326);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10194, 24304, 24326);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal MethodSymbol AdaptedMethodSymbol { get; }

        System.Exception
        f_10194_24189_24219()
        {
            var return_v = ExceptionUtilities.Unreachable;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 24189, 24219);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        f_10194_24307_24326()
        {
            var return_v = AdaptedMethodSymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10194, 24307, 24326);
            return return_v;
        }

    }
}
