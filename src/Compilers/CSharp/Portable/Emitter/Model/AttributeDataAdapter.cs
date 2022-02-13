// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CodeGen;
using Microsoft.CodeAnalysis.CSharp.Emit;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Symbols;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal abstract partial class CSharpAttributeData : Cci.ICustomAttribute
    {
        ImmutableArray<Cci.IMetadataExpression> Cci.ICustomAttribute.GetArguments(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10183, 644, 1321);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10183, 763, 812);

                var
                commonArgs = f_10183_780_811(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10183, 826, 950) || true) && (commonArgs.IsEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10183, 826, 950);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10183, 882, 935);

                    return ImmutableArray<Cci.IMetadataExpression>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10183, 826, 950);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10183, 966, 1032);

                var
                builder = f_10183_980_1031()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10183, 1046, 1260);
                    foreach (var argument in f_10183_1071_1081_I(commonArgs))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10183, 1046, 1260);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10183, 1115, 1170);

                        f_10183_1115_1169(argument.Kind != TypedConstantKind.Error);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10183, 1188, 1245);

                        f_10183_1188_1244(builder, f_10183_1200_1243(this, argument, context));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10183, 1046, 1260);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10183, 1, 215);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10183, 1, 215);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10183, 1274, 1310);

                return f_10183_1281_1309(builder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10183, 644, 1321);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10183_780_811(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.CommonConstructorArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10183, 780, 811);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.IMetadataExpression>
                f_10183_980_1031()
                {
                    var return_v = ArrayBuilder<Cci.IMetadataExpression>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10183, 980, 1031);
                    return return_v;
                }


                int
                f_10183_1115_1169(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10183, 1115, 1169);
                    return 0;
                }


                Microsoft.Cci.IMetadataExpression
                f_10183_1200_1243(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.TypedConstant
                argument, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.CreateMetadataExpression(argument, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10183, 1200, 1243);
                    return return_v;
                }


                int
                f_10183_1188_1244(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.IMetadataExpression>
                this_param, Microsoft.Cci.IMetadataExpression
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10183, 1188, 1244);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10183_1071_1081_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10183, 1071, 1081);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IMetadataExpression>
                f_10183_1281_1309(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.IMetadataExpression>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10183, 1281, 1309);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10183, 644, 1321);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10183, 644, 1321);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        Cci.IMethodReference Cci.ICustomAttribute.Constructor(EmitContext context, bool reportDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10183, 1333, 2329);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10183, 1456, 2076) || true) && (f_10183_1460_1517(f_10183_1460_1485(this)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10183, 1456, 2076);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10183, 1810, 2029) || true) && (reportDiagnostics)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10183, 1810, 2029);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10183, 1873, 2010);

                        f_10183_1873_2009(context.Diagnostics, ErrorCode.ERR_NotAnAttributeClass, f_10183_1932_1963_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(context.SyntaxNodeOpt, 10183, 1932, 1963)?.Location) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.Location?>(10183, 1932, 1987) ?? NoLocation.Singleton), f_10183_1989_2008(this));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10183, 1810, 2029);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10183, 2049, 2061);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10183, 1456, 2076);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10183, 2092, 2159);

                PEModuleBuilder
                moduleBeingBuilt = (PEModuleBuilder)context.Module
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10183, 2173, 2318);

                return (Cci.IMethodReference)f_10183_2202_2317(moduleBeingBuilt, f_10183_2229_2254(this), (CSharpSyntaxNode)context.SyntaxNodeOpt, context.Diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10183, 1333, 2329);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10183_1460_1485(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.AttributeConstructor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10183, 1460, 1485);
                    return return_v;
                }


                bool
                f_10183_1460_1517(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                method)
                {
                    var return_v = method.IsDefaultValueTypeConstructor();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10183, 1460, 1517);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location?
                f_10183_1932_1963_M(Microsoft.CodeAnalysis.Location?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10183, 1932, 1963);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10183_1989_2008(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.AttributeClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10183, 1989, 2008);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10183_1873_2009(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10183, 1873, 2009);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10183_2229_2254(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.AttributeConstructor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10183, 2229, 2254);
                    return return_v;
                }


                Microsoft.Cci.IMethodReference
                f_10183_2202_2317(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                methodSymbol, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.Translate(methodSymbol, (Microsoft.CodeAnalysis.SyntaxNode)syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10183, 2202, 2317);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10183, 1333, 2329);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10183, 1333, 2329);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        ImmutableArray<Cci.IMetadataNamedArgument> Cci.ICustomAttribute.GetNamedArguments(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10183, 2341, 2991);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10183, 2468, 2511);

                var
                commonArgs = f_10183_2485_2510(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10183, 2525, 2652) || true) && (commonArgs.IsEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10183, 2525, 2652);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10183, 2581, 2637);

                    return ImmutableArray<Cci.IMetadataNamedArgument>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10183, 2525, 2652);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10183, 2668, 2737);

                var
                builder = f_10183_2682_2736()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10183, 2751, 2930);
                    foreach (var namedArgument in f_10183_2781_2791_I(commonArgs))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10183, 2751, 2930);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10183, 2825, 2915);

                        f_10183_2825_2914(builder, f_10183_2837_2913(this, namedArgument.Key, namedArgument.Value, context));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10183, 2751, 2930);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10183, 1, 180);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10183, 1, 180);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10183, 2944, 2980);

                return f_10183_2951_2979(builder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10183, 2341, 2991);

                System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
                f_10183_2485_2510(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.CommonNamedArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10183, 2485, 2510);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.IMetadataNamedArgument>
                f_10183_2682_2736()
                {
                    var return_v = ArrayBuilder<Cci.IMetadataNamedArgument>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10183, 2682, 2736);
                    return return_v;
                }


                Microsoft.Cci.IMetadataNamedArgument
                f_10183_2837_2913(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, string
                name, Microsoft.CodeAnalysis.TypedConstant
                argument, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.CreateMetadataNamedArgument(name, argument, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10183, 2837, 2913);
                    return return_v;
                }


                int
                f_10183_2825_2914(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.IMetadataNamedArgument>
                this_param, Microsoft.Cci.IMetadataNamedArgument
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10183, 2825, 2914);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
                f_10183_2781_2791_I(System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10183, 2781, 2791);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IMetadataNamedArgument>
                f_10183_2951_2979(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.IMetadataNamedArgument>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10183, 2951, 2979);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10183, 2341, 2991);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10183, 2341, 2991);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        int Cci.ICustomAttribute.ArgumentCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10183, 3066, 3163);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10183, 3102, 3148);

                    return this.CommonConstructorArguments.Length;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10183, 3066, 3163);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10183, 3003, 3174);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10183, 3003, 3174);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ushort Cci.ICustomAttribute.NamedArgumentCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10183, 3257, 3356);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10183, 3293, 3341);

                    return (ushort)this.CommonNamedArguments.Length;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10183, 3257, 3356);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10183, 3186, 3367);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10183, 3186, 3367);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.ITypeReference Cci.ICustomAttribute.GetType(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10183, 3379, 3709);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10183, 3472, 3539);

                PEModuleBuilder
                moduleBeingBuilt = (PEModuleBuilder)context.Module
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10183, 3553, 3698);

                return f_10183_3560_3697(moduleBeingBuilt, f_10183_3587_3606(this), (CSharpSyntaxNode)context.SyntaxNodeOpt, diagnostics: context.Diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10183, 3379, 3709);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10183_3587_3606(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.AttributeClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10183, 3587, 3606);
                    return return_v;
                }


                Microsoft.Cci.INamedTypeReference
                f_10183_3560_3697(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                namedTypeSymbol, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.Translate(namedTypeSymbol, syntaxNodeOpt: (Microsoft.CodeAnalysis.SyntaxNode)syntaxNodeOpt, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10183, 3560, 3697);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10183, 3379, 3709);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10183, 3379, 3709);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        bool Cci.ICustomAttribute.AllowMultiple
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10183, 3785, 3858);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10183, 3791, 3856);

                    return f_10183_3798_3841(f_10183_3798_3817(this)).AllowMultiple;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10183, 3785, 3858);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                    f_10183_3798_3817(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                    this_param)
                    {
                        var return_v = this_param.AttributeClass;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10183, 3798, 3817);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.AttributeUsageInfo
                    f_10183_3798_3841(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                    this_param)
                    {
                        var return_v = this_param.GetAttributeUsageInfo();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10183, 3798, 3841);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10183, 3721, 3869);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10183, 3721, 3869);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private Cci.IMetadataExpression CreateMetadataExpression(TypedConstant argument, EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10183, 3881, 4580);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10183, 4007, 4143) || true) && (argument.IsNull)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10183, 4007, 4143);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10183, 4060, 4128);

                    return f_10183_4067_4127(argument.TypeInternal, null, context);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10183, 4007, 4143);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10183, 4159, 4569);

                switch (argument.Kind)
                {

                    case TypedConstantKind.Array:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10183, 4159, 4569);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10183, 4265, 4311);

                        return f_10183_4272_4310(this, argument, context);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10183, 4159, 4569);

                    case TypedConstantKind.Type:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10183, 4159, 4569);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10183, 4381, 4418);

                        return f_10183_4388_4417(argument, context);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10183, 4159, 4569);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10183, 4159, 4569);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10183, 4468, 4554);

                        return f_10183_4475_4553(argument.TypeInternal, argument.ValueInternal, context);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10183, 4159, 4569);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10183, 3881, 4580);

                Microsoft.CodeAnalysis.CodeGen.MetadataConstant
                f_10183_4067_4127(Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal?
                type, object
                value, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = CreateMetadataConstant(type, value, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10183, 4067, 4127);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.MetadataCreateArray
                f_10183_4272_4310(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.TypedConstant
                argument, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.CreateMetadataArray(argument, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10183, 4272, 4310);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.MetadataTypeOf
                f_10183_4388_4417(Microsoft.CodeAnalysis.TypedConstant
                argument, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = CreateType(argument, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10183, 4388, 4417);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.MetadataConstant
                f_10183_4475_4553(Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal?
                type, object?
                value, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = CreateMetadataConstant(type, value, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10183, 4475, 4553);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10183, 3881, 4580);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10183, 3881, 4580);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private MetadataCreateArray CreateMetadataArray(TypedConstant argument, EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10183, 4592, 5685);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10183, 4709, 4750);

                f_10183_4709_4749(f_10183_4722_4748_M(!argument.Values.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10183, 4764, 4793);

                var
                values = argument.Values
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10183, 4807, 4907);

                var
                arrayType = f_10183_4823_4906(((PEModuleBuilder)context.Module), argument.TypeInternal)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10183, 4923, 5214) || true) && (values.Length == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10183, 4923, 5214);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10183, 4979, 5199);

                    return f_10183_4986_5198(arrayType, f_10183_5069_5102(arrayType, context), ImmutableArray<Cci.IMetadataExpression>.Empty);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10183, 4923, 5214);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10183, 5230, 5293);

                var
                metadataExprs = new Cci.IMetadataExpression[values.Length]
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10183, 5316, 5321);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10183, 5307, 5458) || true) && (i < values.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10183, 5342, 5345)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10183, 5307, 5458))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10183, 5307, 5458);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10183, 5379, 5443);

                        metadataExprs[i] = f_10183_5398_5442(this, values[i], context);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10183, 1, 152);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10183, 1, 152);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10183, 5474, 5674);

                return f_10183_5481_5673(arrayType, f_10183_5560_5593(arrayType, context), f_10183_5639_5672(metadataExprs));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10183, 4592, 5685);

                bool
                f_10183_4722_4748_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10183, 4722, 4748);
                    return return_v;
                }


                int
                f_10183_4709_4749(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10183, 4709, 4749);
                    return 0;
                }


                Microsoft.Cci.IArrayTypeReference
                f_10183_4823_4906(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal?
                symbol)
                {
                    var return_v = this_param.Translate((Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol?)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10183, 4823, 4906);
                    return return_v;
                }


                Microsoft.Cci.ITypeReference
                f_10183_5069_5102(Microsoft.Cci.IArrayTypeReference
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetElementType(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10183, 5069, 5102);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.MetadataCreateArray
                f_10183_4986_5198(Microsoft.Cci.IArrayTypeReference
                arrayType, Microsoft.Cci.ITypeReference
                elementType, System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IMetadataExpression>
                initializers)
                {
                    var return_v = new Microsoft.CodeAnalysis.CodeGen.MetadataCreateArray(arrayType, elementType, initializers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10183, 4986, 5198);
                    return return_v;
                }


                Microsoft.Cci.IMetadataExpression
                f_10183_5398_5442(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.TypedConstant
                argument, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.CreateMetadataExpression(argument, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10183, 5398, 5442);
                    return return_v;
                }


                Microsoft.Cci.ITypeReference
                f_10183_5560_5593(Microsoft.Cci.IArrayTypeReference
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetElementType(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10183, 5560, 5593);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IMetadataExpression>
                f_10183_5639_5672(Microsoft.Cci.IMetadataExpression[]
                items)
                {
                    var return_v = items.AsImmutableOrNull<Microsoft.Cci.IMetadataExpression>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10183, 5639, 5672);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.MetadataCreateArray
                f_10183_5481_5673(Microsoft.Cci.IArrayTypeReference
                arrayType, Microsoft.Cci.ITypeReference
                elementType, System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IMetadataExpression>
                initializers)
                {
                    var return_v = new Microsoft.CodeAnalysis.CodeGen.MetadataCreateArray(arrayType, elementType, initializers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10183, 5481, 5673);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10183, 4592, 5685);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10183, 4592, 5685);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static MetadataTypeOf CreateType(TypedConstant argument, EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10183, 5697, 6320);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10183, 5807, 5852);

                f_10183_5807_5851(argument.ValueInternal != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10183, 5866, 5921);

                var
                moduleBeingBuilt = (PEModuleBuilder)context.Module
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10183, 5935, 5995);

                var
                syntaxNodeOpt = (CSharpSyntaxNode)context.SyntaxNodeOpt
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10183, 6009, 6047);

                var
                diagnostics = context.Diagnostics
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10183, 6061, 6309);

                return f_10183_6068_6308(f_10183_6087_6177(moduleBeingBuilt, argument.ValueInternal, syntaxNodeOpt, diagnostics), f_10183_6218_6307(moduleBeingBuilt, argument.TypeInternal, syntaxNodeOpt, diagnostics));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10183, 5697, 6320);

                int
                f_10183_5807_5851(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10183, 5807, 5851);
                    return 0;
                }


                Microsoft.Cci.ITypeReference
                f_10183_6087_6177(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, object
                typeSymbol, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.Translate((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)typeSymbol, (Microsoft.CodeAnalysis.SyntaxNode)syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10183, 6087, 6177);
                    return return_v;
                }


                Microsoft.Cci.ITypeReference
                f_10183_6218_6307(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal?
                typeSymbol, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.Translate((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?)typeSymbol, (Microsoft.CodeAnalysis.SyntaxNode)syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10183, 6218, 6307);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.MetadataTypeOf
                f_10183_6068_6308(Microsoft.Cci.ITypeReference
                typeToGet, Microsoft.Cci.ITypeReference
                systemType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CodeGen.MetadataTypeOf(typeToGet, systemType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10183, 6068, 6308);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10183, 5697, 6320);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10183, 5697, 6320);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static MetadataConstant CreateMetadataConstant(ITypeSymbolInternal type, object value, EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10183, 6332, 6718);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10183, 6472, 6539);

                PEModuleBuilder
                moduleBeingBuilt = (PEModuleBuilder)context.Module
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10183, 6553, 6707);

                return f_10183_6560_6706(moduleBeingBuilt, type, value, (CSharpSyntaxNode)context.SyntaxNodeOpt, diagnostics: context.Diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10183, 6332, 6718);

                Microsoft.CodeAnalysis.CodeGen.MetadataConstant
                f_10183_6560_6706(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal
                type, object
                value, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.CreateConstant((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, value, syntaxNodeOpt: (Microsoft.CodeAnalysis.SyntaxNode)syntaxNodeOpt, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10183, 6560, 6706);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10183, 6332, 6718);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10183, 6332, 6718);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Cci.IMetadataNamedArgument CreateMetadataNamedArgument(string name, TypedConstant argument, EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10183, 6730, 7560);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10183, 6875, 6905);

                var
                symbol = f_10183_6888_6904(this, name)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10183, 6919, 6975);

                var
                value = f_10183_6931_6974(this, argument, context)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10183, 6989, 7005);

                TypeSymbol
                type
                = default(TypeSymbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10183, 7019, 7059);

                var
                fieldSymbol = symbol as FieldSymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10183, 7073, 7280) || true) && ((object)fieldSymbol != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10183, 7073, 7280);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10183, 7138, 7162);

                    type = f_10183_7145_7161(fieldSymbol);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10183, 7073, 7280);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10183, 7073, 7280);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10183, 7228, 7265);

                    type = f_10183_7235_7264(((PropertySymbol)symbol));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10183, 7073, 7280);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10183, 7296, 7363);

                PEModuleBuilder
                moduleBeingBuilt = (PEModuleBuilder)context.Module
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10183, 7377, 7549);

                return f_10183_7384_7548(symbol, f_10183_7418_7540(moduleBeingBuilt, type, (CSharpSyntaxNode)context.SyntaxNodeOpt, diagnostics: context.Diagnostics), value);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10183, 6730, 7560);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10183_6888_6904(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, string
                name)
                {
                    var return_v = this_param.LookupName(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10183, 6888, 6904);
                    return return_v;
                }


                Microsoft.Cci.IMetadataExpression
                f_10183_6931_6974(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.TypedConstant
                argument, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.CreateMetadataExpression(argument, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10183, 6931, 6974);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10183_7145_7161(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10183, 7145, 7161);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10183_7235_7264(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10183, 7235, 7264);
                    return return_v;
                }


                Microsoft.Cci.ITypeReference
                f_10183_7418_7540(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeSymbol, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.Translate(typeSymbol, syntaxNodeOpt: (Microsoft.CodeAnalysis.SyntaxNode)syntaxNodeOpt, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10183, 7418, 7540);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.MetadataNamedArgument
                f_10183_7384_7548(Microsoft.CodeAnalysis.CSharp.Symbol
                entity, Microsoft.Cci.ITypeReference
                type, Microsoft.Cci.IMetadataExpression
                value)
                {
                    var return_v = new Microsoft.CodeAnalysis.CodeGen.MetadataNamedArgument((Microsoft.CodeAnalysis.Symbols.ISymbolInternal)entity, type, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10183, 7384, 7548);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10183, 6730, 7560);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10183, 6730, 7560);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Symbol LookupName(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10183, 7572, 8211);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10183, 7635, 7666);

                var
                type = f_10183_7646_7665(this)
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10183, 7680, 8063) || true) && ((object)type != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10183, 7680, 8063);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10183, 7741, 7989);
                            foreach (var member in f_10183_7764_7785_I(f_10183_7764_7785(type, name)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10183, 7741, 7989);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10183, 7827, 7970) || true) && (f_10183_7831_7859(member) == Accessibility.Public)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10183, 7827, 7970);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10183, 7933, 7947);

                                    return member;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10183, 7827, 7970);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10183, 7741, 7989);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10183, 1, 249);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10183, 1, 249);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10183, 8007, 8048);

                        type = f_10183_8014_8047(type);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10183, 7680, 8063);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10183, 7680, 8063);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10183, 7680, 8063);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10183, 8079, 8174);

                f_10183_8079_8173(false, "Name does not match an attribute field or a property.  How can that be?");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10183, 8188, 8200);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10183, 7572, 8211);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10183_7646_7665(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.AttributeClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10183, 7646, 7665);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10183_7764_7785(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10183, 7764, 7785);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_10183_7831_7859(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10183, 7831, 7859);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10183_7764_7785_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10183, 7764, 7785);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10183_8014_8047(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10183, 8014, 8047);
                    return return_v;
                }


                int
                f_10183_8079_8173(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10183, 8079, 8173);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10183, 7572, 8211);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10183, 7572, 8211);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CSharpAttributeData()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(10183, 553, 8218);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 906, 951);
            this._lazyIsSecurityAttribute = ThreeState.Unknown; 
            DynAbs.Tracing.TraceSender.TraceExitConstructor(10183, 553, 8218);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10183, 553, 8218);
        }


        static CSharpAttributeData()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10183, 553, 8218);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10183, 553, 8218);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10183, 553, 8218);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10183, 553, 8218);
    }
}
