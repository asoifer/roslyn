// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.Collections;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Symbols;
using Roslyn.Utilities;
using System;
using System.Collections.Immutable;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace Microsoft.CodeAnalysis.CodeGen
{
    internal class PermissionSetAttributeWithFileReference : Cci.ICustomAttribute
    {
        private readonly Cci.ICustomAttribute _sourceAttribute;

        private readonly string _resolvedPermissionSetFilePath;

        internal const string
        FilePropertyName = "File"
        ;

        internal const string
        HexPropertyName = "Hex"
        ;

        public PermissionSetAttributeWithFileReference(Cci.ICustomAttribute sourceAttribute, string resolvedPermissionSetFilePath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(77, 1890, 2234);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(77, 1682, 1698);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(77, 1733, 1763);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(77, 2037, 2095);

                f_77_2037_2094(resolvedPermissionSetFilePath != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(77, 2111, 2146);

                _sourceAttribute = sourceAttribute;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(77, 2160, 2223);

                _resolvedPermissionSetFilePath = resolvedPermissionSetFilePath;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(77, 1890, 2234);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(77, 1890, 2234);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(77, 1890, 2234);
            }
        }

        public ImmutableArray<Cci.IMetadataExpression> GetArguments(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(77, 2371, 2533);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(77, 2476, 2522);

                return f_77_2483_2521(_sourceAttribute, context);
                DynAbs.Tracing.TraceSender.TraceExitMethod(77, 2371, 2533);

                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IMetadataExpression>
                f_77_2483_2521(Microsoft.Cci.ICustomAttribute
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetArguments(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(77, 2483, 2521);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(77, 2371, 2533);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(77, 2371, 2533);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Cci.IMethodReference Constructor(EmitContext context, bool reportDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(77, 2854, 2913);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(77, 2857, 2913);
                return f_77_2857_2913(_sourceAttribute, context, reportDiagnostics); DynAbs.Tracing.TraceSender.TraceExitMethod(77, 2854, 2913);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(77, 2854, 2913);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(77, 2854, 2913);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.Cci.IMethodReference
            f_77_2857_2913(Microsoft.Cci.ICustomAttribute
            this_param, Microsoft.CodeAnalysis.Emit.EmitContext
            context, bool
            reportDiagnostics)
            {
                var return_v = this_param.Constructor(context, reportDiagnostics);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(77, 2857, 2913);
                return return_v;
            }

        }

        public ImmutableArray<Cci.IMetadataNamedArgument> GetNamedArguments(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(77, 3079, 5771);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(77, 3223, 3326);

                Cci.ITypeReference
                stringType = f_77_3255_3325(context.Module, Cci.PlatformType.SystemString, context)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(77, 3405, 3465);

                var
                namedArgs = f_77_3421_3464(_sourceAttribute, context)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(77, 3479, 3515);

                f_77_3479_3514(namedArgs.Length == 1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(77, 3601, 3633);

                var
                fileArg = namedArgs.First()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(77, 3647, 3702);

                f_77_3647_3701(f_77_3660_3680(fileArg) == FilePropertyName);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(77, 3716, 3805);

                f_77_3716_3804(f_77_3729_3803(context.Module, f_77_3759_3771(fileArg), Cci.PlatformType.SystemString));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(77, 3885, 3941);

                f_77_3885_3940(f_77_3898_3919(fileArg) is MetadataConstant);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(77, 3955, 4027);

                var
                fileName = (string?)f_77_3979_4026(((MetadataConstant)f_77_3998_4019(fileArg)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(77, 4041, 4087);

                f_77_4041_4086(!f_77_4055_4085(fileName));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(77, 4209, 4295);

                ISymbol
                iSymbol = f_77_4227_4294(f_77_4227_4280(f_77_4227_4260(_sourceAttribute, context))!)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(77, 4309, 4522);

                f_77_4309_4521(f_77_4322_4377(((INamedTypeSymbol)iSymbol), HexPropertyName).Any(member => member.Kind == SymbolKind.Property && ((IPropertySymbol)member).Type.SpecialType == SpecialType.System_String));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(77, 4546, 4568);

                string
                hexFileContent
                = default(string);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(77, 4764, 4841);

                var
                resolver = f_77_4779_4840(f_77_4779_4819(f_77_4779_4811(context.Module)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(77, 4967, 5004);

                f_77_4967_5003(resolver != null);

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(77, 5056, 5327);
                    using (Stream
                    stream = f_77_5079_5135(resolver, _resolvedPermissionSetFilePath)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(77, 5270, 5308);

                        hexFileContent = f_77_5287_5307(stream);
                        DynAbs.Tracing.TraceSender.TraceExitUsing(77, 5056, 5327);
                    }
                }
                catch (IOException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(77, 5356, 5509);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(77, 5410, 5494);

                    throw f_77_5416_5493(f_77_5451_5460(e), _resolvedPermissionSetFilePath);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(77, 5356, 5509);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(77, 5603, 5760);

                return f_77_5610_5759(f_77_5660_5758(stringType, f_77_5709_5757(stringType, hexFileContent)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(77, 3079, 5771);

                Microsoft.Cci.ITypeReference
                f_77_3255_3325(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param, Microsoft.Cci.PlatformType
                platformType, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetPlatformType(platformType, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(77, 3255, 3325);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IMetadataNamedArgument>
                f_77_3421_3464(Microsoft.Cci.ICustomAttribute
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetNamedArguments(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(77, 3421, 3464);
                    return return_v;
                }


                int
                f_77_3479_3514(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(77, 3479, 3514);
                    return 0;
                }


                string
                f_77_3660_3680(Microsoft.Cci.IMetadataNamedArgument
                this_param)
                {
                    var return_v = this_param.ArgumentName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(77, 3660, 3680);
                    return return_v;
                }


                int
                f_77_3647_3701(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(77, 3647, 3701);
                    return 0;
                }


                Microsoft.Cci.ITypeReference
                f_77_3759_3771(Microsoft.Cci.IMetadataNamedArgument
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(77, 3759, 3771);
                    return return_v;
                }


                bool
                f_77_3729_3803(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param, Microsoft.Cci.ITypeReference
                typeRef, Microsoft.Cci.PlatformType
                platformType)
                {
                    var return_v = this_param.IsPlatformType(typeRef, platformType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(77, 3729, 3803);
                    return return_v;
                }


                int
                f_77_3716_3804(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(77, 3716, 3804);
                    return 0;
                }


                Microsoft.Cci.IMetadataExpression
                f_77_3898_3919(Microsoft.Cci.IMetadataNamedArgument
                this_param)
                {
                    var return_v = this_param.ArgumentValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(77, 3898, 3919);
                    return return_v;
                }


                int
                f_77_3885_3940(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(77, 3885, 3940);
                    return 0;
                }


                Microsoft.Cci.IMetadataExpression
                f_77_3998_4019(Microsoft.Cci.IMetadataNamedArgument
                this_param)
                {
                    var return_v = this_param.ArgumentValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(77, 3998, 4019);
                    return return_v;
                }


                object?
                f_77_3979_4026(Microsoft.CodeAnalysis.CodeGen.MetadataConstant
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(77, 3979, 4026);
                    return return_v;
                }


                bool
                f_77_4055_4085(string?
                value)
                {
                    var return_v = String.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(77, 4055, 4085);
                    return return_v;
                }


                int
                f_77_4041_4086(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(77, 4041, 4086);
                    return 0;
                }


                Microsoft.Cci.ITypeReference
                f_77_4227_4260(Microsoft.Cci.ICustomAttribute
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetType(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(77, 4227, 4260);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Symbols.ISymbolInternal?
                f_77_4227_4280(Microsoft.Cci.ITypeReference
                this_param)
                {
                    var return_v = this_param.GetInternalSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(77, 4227, 4280);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ISymbol
                f_77_4227_4294(Microsoft.CodeAnalysis.Symbols.ISymbolInternal
                this_param)
                {
                    var return_v = this_param.GetISymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(77, 4227, 4294);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_77_4322_4377(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(77, 4322, 4377);
                    return return_v;
                }


                int
                f_77_4309_4521(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(77, 4309, 4521);
                    return 0;
                }


                Microsoft.CodeAnalysis.Compilation
                f_77_4779_4811(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param)
                {
                    var return_v = this_param.CommonCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(77, 4779, 4811);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CompilationOptions
                f_77_4779_4819(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(77, 4779, 4819);
                    return return_v;
                }


                Microsoft.CodeAnalysis.XmlReferenceResolver?
                f_77_4779_4840(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.XmlReferenceResolver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(77, 4779, 4840);
                    return return_v;
                }


                int
                f_77_4967_5003(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(77, 4967, 5003);
                    return 0;
                }


                System.IO.Stream
                f_77_5079_5135(Microsoft.CodeAnalysis.XmlReferenceResolver
                this_param, string
                fullPath)
                {
                    var return_v = this_param.OpenReadChecked(fullPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(77, 5079, 5135);
                    return return_v;
                }


                string
                f_77_5287_5307(System.IO.Stream
                stream)
                {
                    var return_v = ConvertToHex(stream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(77, 5287, 5307);
                    return return_v;
                }


                string
                f_77_5451_5460(System.IO.IOException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(77, 5451, 5460);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.PermissionSetFileReadException
                f_77_5416_5493(string
                message, string
                file)
                {
                    var return_v = new Microsoft.CodeAnalysis.CodeGen.PermissionSetFileReadException(message, file);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(77, 5416, 5493);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.MetadataConstant
                f_77_5709_5757(Microsoft.Cci.ITypeReference
                type, string
                value)
                {
                    var return_v = new Microsoft.CodeAnalysis.CodeGen.MetadataConstant(type, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(77, 5709, 5757);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.PermissionSetAttributeWithFileReference.HexPropertyMetadataNamedArgument
                f_77_5660_5758(Microsoft.Cci.ITypeReference
                type, Microsoft.CodeAnalysis.CodeGen.MetadataConstant
                value)
                {
                    var return_v = new Microsoft.CodeAnalysis.CodeGen.PermissionSetAttributeWithFileReference.HexPropertyMetadataNamedArgument(type, (Microsoft.Cci.IMetadataExpression)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(77, 5660, 5758);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IMetadataNamedArgument>
                f_77_5610_5759(Microsoft.CodeAnalysis.CodeGen.PermissionSetAttributeWithFileReference.HexPropertyMetadataNamedArgument
                item)
                {
                    var return_v = ImmutableArray.Create<Cci.IMetadataNamedArgument>((Microsoft.Cci.IMetadataNamedArgument)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(77, 5610, 5759);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(77, 3079, 5771);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(77, 3079, 5771);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string ConvertToHex(Stream stream)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(77, 5826, 6388);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(77, 5901, 5936);

                f_77_5901_5935(stream != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(77, 5952, 6009);

                var
                pooledStrBuilder = f_77_5975_6008()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(77, 6023, 6078);

                StringBuilder
                stringBuilder = pooledStrBuilder.Builder
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(77, 6094, 6100);

                int
                b
                = default(int);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(77, 6114, 6319) || true) && ((b = f_77_6126_6143(stream)) >= 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(77, 6114, 6319);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(77, 6183, 6238);

                        f_77_6183_6237(stringBuilder, f_77_6204_6236((b >> 4) & 0xf));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(77, 6256, 6304);

                        f_77_6256_6303(stringBuilder, f_77_6277_6302(b & 0xf));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(77, 6114, 6319);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(77, 6114, 6319);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(77, 6114, 6319);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(77, 6335, 6377);

                return f_77_6342_6376(pooledStrBuilder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(77, 5826, 6388);

                int
                f_77_5901_5935(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(77, 5901, 5935);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                f_77_5975_6008()
                {
                    var return_v = PooledStringBuilder.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(77, 5975, 6008);
                    return return_v;
                }


                int
                f_77_6126_6143(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.ReadByte();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(77, 6126, 6143);
                    return return_v;
                }


                char
                f_77_6204_6236(int
                b)
                {
                    var return_v = ConvertHexToChar(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(77, 6204, 6236);
                    return return_v;
                }


                System.Text.StringBuilder
                f_77_6183_6237(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(77, 6183, 6237);
                    return return_v;
                }


                char
                f_77_6277_6302(int
                b)
                {
                    var return_v = ConvertHexToChar(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(77, 6277, 6302);
                    return return_v;
                }


                System.Text.StringBuilder
                f_77_6256_6303(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(77, 6256, 6303);
                    return return_v;
                }


                string
                f_77_6342_6376(Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                this_param)
                {
                    var return_v = this_param.ToStringAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(77, 6342, 6376);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(77, 5826, 6388);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(77, 5826, 6388);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static char ConvertHexToChar(int b)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(77, 6400, 6563);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(77, 6468, 6491);

                f_77_6468_6490(b < 0x10);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(77, 6505, 6552);

                return (char)((DynAbs.Tracing.TraceSender.Conditional_F1(77, 6519, 6525) || ((b < 10 && DynAbs.Tracing.TraceSender.Conditional_F2(77, 6528, 6535)) || DynAbs.Tracing.TraceSender.Conditional_F3(77, 6538, 6550))) ? '0' + b : 'a' + b - 10);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(77, 6400, 6563);

                int
                f_77_6468_6490(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(77, 6468, 6490);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(77, 6400, 6563);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(77, 6400, 6563);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int ArgumentCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(77, 6696, 6729);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(77, 6699, 6729);
                    return f_77_6699_6729(_sourceAttribute); DynAbs.Tracing.TraceSender.TraceExitMethod(77, 6696, 6729);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(77, 6696, 6729);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(77, 6696, 6729);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ushort NamedArgumentCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(77, 6890, 7023);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(77, 6926, 6981);

                    f_77_6926_6980(f_77_6939_6974(_sourceAttribute) == 1);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(77, 6999, 7008);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(77, 6890, 7023);

                    ushort
                    f_77_6939_6974(Microsoft.Cci.ICustomAttribute
                    this_param)
                    {
                        var return_v = this_param.NamedArgumentCount;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(77, 6939, 6974);
                        return return_v;
                    }


                    int
                    f_77_6926_6980(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(77, 6926, 6980);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(77, 6833, 7034);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(77, 6833, 7034);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public Cci.ITypeReference GetType(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(77, 7232, 7268);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(77, 7235, 7268);
                return f_77_7235_7268(_sourceAttribute, context); DynAbs.Tracing.TraceSender.TraceExitMethod(77, 7232, 7268);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(77, 7232, 7268);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(77, 7232, 7268);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.Cci.ITypeReference
            f_77_7235_7268(Microsoft.Cci.ICustomAttribute
            this_param, Microsoft.CodeAnalysis.Emit.EmitContext
            context)
            {
                var return_v = this_param.GetType(context);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(77, 7235, 7268);
                return return_v;
            }

        }

        public bool AllowMultiple
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(77, 7307, 7340);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(77, 7310, 7340);
                    return f_77_7310_7340(_sourceAttribute); DynAbs.Tracing.TraceSender.TraceExitMethod(77, 7307, 7340);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(77, 7307, 7340);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(77, 7307, 7340);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private struct HexPropertyMetadataNamedArgument : Cci.IMetadataNamedArgument
        {

            private readonly Cci.ITypeReference _type;

            private readonly Cci.IMetadataExpression _value;

            public HexPropertyMetadataNamedArgument(Cci.ITypeReference type, Cci.IMetadataExpression value)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(77, 7574, 7763);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(77, 7702, 7715);

                    _type = type;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(77, 7733, 7748);

                    _value = value;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(77, 7574, 7763);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(77, 7574, 7763);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(77, 7574, 7763);
                }
            }

            public string ArgumentName
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(77, 7808, 7839);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(77, 7814, 7837);

                        return HexPropertyName;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(77, 7808, 7839);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(77, 7779, 7841);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(77, 7779, 7841);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public Cci.IMetadataExpression ArgumentValue
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(77, 7902, 7924);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(77, 7908, 7922);

                        return _value;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(77, 7902, 7924);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(77, 7855, 7926);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(77, 7855, 7926);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public bool IsField
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(77, 7962, 7983);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(77, 7968, 7981);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(77, 7962, 7983);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(77, 7940, 7985);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(77, 7940, 7985);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            Cci.ITypeReference Cci.IMetadataExpression.Type
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(77, 8051, 8072);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(77, 8057, 8070);

                        return _type;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(77, 8051, 8072);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(77, 8001, 8074);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(77, 8001, 8074);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            void Cci.IMetadataExpression.Dispatch(Cci.MetadataVisitor visitor)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(77, 8090, 8224);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(77, 8189, 8209);

                    f_77_8189_8208(visitor, this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(77, 8090, 8224);

                    int
                    f_77_8189_8208(Microsoft.Cci.MetadataVisitor
                    this_param, Microsoft.CodeAnalysis.CodeGen.PermissionSetAttributeWithFileReference.HexPropertyMetadataNamedArgument
                    namedArgument)
                    {
                        this_param.Visit((Microsoft.Cci.IMetadataNamedArgument)namedArgument);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(77, 8189, 8208);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(77, 8090, 8224);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(77, 8090, 8224);
                }
            }
            static HexPropertyMetadataNamedArgument()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(77, 7353, 8235);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(77, 7353, 8235);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(77, 7353, 8235);
            }
        }

        static PermissionSetAttributeWithFileReference()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(77, 1550, 8242);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(77, 1796, 1821);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(77, 1854, 1877);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(77, 1550, 8242);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(77, 1550, 8242);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(77, 1550, 8242);

        static int
        f_77_2037_2094(bool
        b)
        {
            RoslynDebug.Assert(b);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(77, 2037, 2094);
            return 0;
        }


        int
        f_77_6699_6729(Microsoft.Cci.ICustomAttribute
        this_param)
        {
            var return_v = this_param.ArgumentCount;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(77, 6699, 6729);
            return return_v;
        }


        bool
        f_77_7310_7340(Microsoft.Cci.ICustomAttribute
        this_param)
        {
            var return_v = this_param.AllowMultiple;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(77, 7310, 7340);
            return return_v;
        }

    }
    internal class PermissionSetFileReadException : Exception
    {
        private readonly string _file;

        public PermissionSetFileReadException(string message, string file)
        : base(f_77_8635_8642_C(message))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(77, 8548, 8692);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(77, 8530, 8535);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(77, 8668, 8681);

                _file = file;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(77, 8548, 8692);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(77, 8548, 8692);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(77, 8548, 8692);
            }
        }

        public string FileName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(77, 8727, 8735);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(77, 8730, 8735);
                    return _file; DynAbs.Tracing.TraceSender.TraceExitMethod(77, 8727, 8735);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(77, 8727, 8735);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(77, 8727, 8735);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public string PropertyName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(77, 8775, 8834);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(77, 8778, 8834);
                    return PermissionSetAttributeWithFileReference.FilePropertyName; DynAbs.Tracing.TraceSender.TraceExitMethod(77, 8775, 8834);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(77, 8775, 8834);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(77, 8775, 8834);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static PermissionSetFileReadException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(77, 8432, 8842);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(77, 8432, 8842);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(77, 8432, 8842);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(77, 8432, 8842);

        static string
        f_77_8635_8642_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(77, 8548, 8692);
            return return_v;
        }

    }
}
