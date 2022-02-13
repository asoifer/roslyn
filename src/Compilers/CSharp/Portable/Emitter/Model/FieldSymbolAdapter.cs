// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CodeGen;
using Microsoft.CodeAnalysis.CSharp.Emit;
using Microsoft.CodeAnalysis.Emit;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal partial class
            FieldSymbolAdapter : SymbolAdapter,
            Cci.IFieldReference,
            Cci.IFieldDefinition,
            Cci.ITypeMemberReference,
            Cci.ITypeDefinitionMember,
            Cci.ISpecializedFieldReference
    {
        Cci.ITypeReference Cci.IFieldReference.GetType(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10187, 800, 1889);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10187, 892, 959);

                PEModuleBuilder
                moduleBeingBuilt = (PEModuleBuilder)context.Module
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10187, 975, 1061);

                TypeWithAnnotations
                fieldTypeWithAnnotations = f_10187_1022_1060(f_10187_1022_1040())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10187, 1075, 1138);

                var
                customModifiers = fieldTypeWithAnnotations.CustomModifiers
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10187, 1152, 1203);

                var
                isFixed = f_10187_1166_1202(f_10187_1166_1184())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10187, 1217, 1335);

                var
                implType = (DynAbs.Tracing.TraceSender.Conditional_F1(10187, 1232, 1239) || ((isFixed && DynAbs.Tracing.TraceSender.Conditional_F2(10187, 1242, 1302)) || DynAbs.Tracing.TraceSender.Conditional_F3(10187, 1305, 1334))) ? f_10187_1242_1302(f_10187_1242_1260(), moduleBeingBuilt) : fieldTypeWithAnnotations.Type
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10187, 1349, 1589);

                var
                type = f_10187_1360_1588(moduleBeingBuilt, implType, (CSharpSyntaxNode)context.SyntaxNodeOpt, diagnostics: context.Diagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10187, 1605, 1878) || true) && (isFixed || (DynAbs.Tracing.TraceSender.Expression_False(10187, 1609, 1647) || customModifiers.Length == 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10187, 1605, 1878);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10187, 1681, 1693);

                    return type;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10187, 1605, 1878);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10187, 1605, 1878);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10187, 1759, 1863);

                    return f_10187_1766_1862(type, ImmutableArray<Cci.ICustomModifier>.CastUp(customModifiers));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10187, 1605, 1878);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10187, 800, 1889);

                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10187_1022_1040()
                {
                    var return_v = AdaptedFieldSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10187, 1022, 1040);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10187_1022_1060(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10187, 1022, 1060);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10187_1166_1184()
                {
                    var return_v = AdaptedFieldSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10187, 1166, 1184);
                    return return_v;
                }


                bool
                f_10187_1166_1202(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.IsFixedSizeBuffer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10187, 1166, 1202);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10187_1242_1260()
                {
                    var return_v = AdaptedFieldSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10187, 1242, 1260);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10187_1242_1302(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                emitModule)
                {
                    var return_v = this_param.FixedImplementationType(emitModule);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10187, 1242, 1302);
                    return return_v;
                }


                Microsoft.Cci.ITypeReference
                f_10187_1360_1588(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeSymbol, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.Translate(typeSymbol, syntaxNodeOpt: (Microsoft.CodeAnalysis.SyntaxNode)syntaxNodeOpt, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10187, 1360, 1588);
                    return return_v;
                }


                Microsoft.Cci.ModifiedTypeReference
                f_10187_1766_1862(Microsoft.Cci.ITypeReference
                modifiedType, System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ICustomModifier>
                customModifiers)
                {
                    var return_v = new Microsoft.Cci.ModifiedTypeReference(modifiedType, customModifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10187, 1766, 1862);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10187, 800, 1889);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10187, 800, 1889);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        Cci.IFieldDefinition Cci.IFieldReference.GetResolvedField(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10187, 1901, 2073);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10187, 2004, 2062);

                return f_10187_2011_2061(this, context.Module);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10187, 1901, 2073);

                Microsoft.Cci.IFieldDefinition
                f_10187_2011_2061(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                this_param, Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                moduleBeingBuilt)
                {
                    var return_v = this_param.ResolvedFieldImpl((Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder)moduleBeingBuilt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10187, 2011, 2061);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10187, 1901, 2073);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10187, 1901, 2073);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Cci.IFieldDefinition ResolvedFieldImpl(PEModuleBuilder moduleBeingBuilt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10187, 2085, 2474);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10187, 2190, 2234);

                f_10187_2190_2233(f_10187_2203_2232(this));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10187, 2250, 2435) || true) && (f_10187_2254_2285(f_10187_2254_2272()) && (DynAbs.Tracing.TraceSender.Expression_True(10187, 2254, 2374) && f_10187_2306_2341(f_10187_2306_2324()) == moduleBeingBuilt.SourceModule))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10187, 2250, 2435);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10187, 2408, 2420);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10187, 2250, 2435);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10187, 2451, 2463);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10187, 2085, 2474);

                bool
                f_10187_2203_2232(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                this_param)
                {
                    var return_v = this_param.IsDefinitionOrDistinct();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10187, 2203, 2232);
                    return return_v;
                }


                int
                f_10187_2190_2233(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10187, 2190, 2233);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10187_2254_2272()
                {
                    var return_v = AdaptedFieldSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10187, 2254, 2272);
                    return return_v;
                }


                bool
                f_10187_2254_2285(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10187, 2254, 2285);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10187_2306_2324()
                {
                    var return_v = AdaptedFieldSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10187, 2306, 2324);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10187_2306_2341(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.ContainingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10187, 2306, 2341);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10187, 2085, 2474);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10187, 2085, 2474);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        Cci.ISpecializedFieldReference Cci.IFieldReference.AsSpecializedFieldReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10187, 2589, 2845);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10187, 2625, 2669);

                    f_10187_2625_2668(f_10187_2638_2667(this));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10187, 2689, 2798) || true) && (f_10187_2693_2725_M(!f_10187_2694_2712().IsDefinition))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10187, 2689, 2798);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10187, 2767, 2779);

                        return this;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10187, 2689, 2798);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10187, 2818, 2830);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10187, 2589, 2845);

                    bool
                    f_10187_2638_2667(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                    this_param)
                    {
                        var return_v = this_param.IsDefinitionOrDistinct();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10187, 2638, 2667);
                        return return_v;
                    }


                    int
                    f_10187_2625_2668(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10187, 2625, 2668);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f_10187_2694_2712()
                    {
                        var return_v = AdaptedFieldSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10187, 2694, 2712);
                        return return_v;
                    }


                    bool
                    f_10187_2693_2725_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10187, 2693, 2725);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10187, 2486, 2856);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10187, 2486, 2856);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.ITypeReference Cci.ITypeMemberReference.GetContainingType(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10187, 2868, 3479);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10187, 2975, 3042);

                PEModuleBuilder
                moduleBeingBuilt = (PEModuleBuilder)context.Module
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10187, 3058, 3102);

                f_10187_3058_3101(f_10187_3071_3100(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10187, 3118, 3468);

                return f_10187_3125_3467(moduleBeingBuilt, f_10187_3152_3185(f_10187_3152_3170()), (CSharpSyntaxNode)context.SyntaxNodeOpt, diagnostics: context.Diagnostics, needDeclaration: f_10187_3435_3466(f_10187_3435_3453()));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10187, 2868, 3479);

                bool
                f_10187_3071_3100(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                this_param)
                {
                    var return_v = this_param.IsDefinitionOrDistinct();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10187, 3071, 3100);
                    return return_v;
                }


                int
                f_10187_3058_3101(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10187, 3058, 3101);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10187_3152_3170()
                {
                    var return_v = AdaptedFieldSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10187, 3152, 3170);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10187_3152_3185(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10187, 3152, 3185);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10187_3435_3453()
                {
                    var return_v = AdaptedFieldSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10187, 3435, 3453);
                    return return_v;
                }


                bool
                f_10187_3435_3466(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10187, 3435, 3466);
                    return return_v;
                }


                Microsoft.Cci.INamedTypeReference
                f_10187_3125_3467(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                namedTypeSymbol, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                needDeclaration)
                {
                    var return_v = this_param.Translate(namedTypeSymbol, syntaxNodeOpt: (Microsoft.CodeAnalysis.SyntaxNode)syntaxNodeOpt, diagnostics: diagnostics, needDeclaration: needDeclaration);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10187, 3125, 3467);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10187, 2868, 3479);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10187, 2868, 3479);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        void Cci.IReference.Dispatch(Cci.MetadataVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10187, 3491, 4095);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10187, 3573, 3617);

                f_10187_3573_3616(f_10187_3586_3615(this));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10187, 3633, 4084) || true) && (f_10187_3637_3669_M(!f_10187_3638_3656().IsDefinition))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10187, 3633, 4084);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10187, 3703, 3755);

                    f_10187_3703_3754(visitor, this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10187, 3633, 4084);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10187, 3633, 4084);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10187, 3789, 4084) || true) && (f_10187_3793_3828(f_10187_3793_3811()) == ((PEModuleBuilder)visitor.Context.Module).SourceModule)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10187, 3789, 4084);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10187, 3920, 3962);

                        f_10187_3920_3961(visitor, this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10187, 3789, 4084);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10187, 3789, 4084);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10187, 4028, 4069);

                        f_10187_4028_4068(visitor, this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10187, 3789, 4084);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10187, 3633, 4084);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10187, 3491, 4095);

                bool
                f_10187_3586_3615(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                this_param)
                {
                    var return_v = this_param.IsDefinitionOrDistinct();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10187, 3586, 3615);
                    return return_v;
                }


                int
                f_10187_3573_3616(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10187, 3573, 3616);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10187_3638_3656()
                {
                    var return_v = AdaptedFieldSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10187, 3638, 3656);
                    return return_v;
                }


                bool
                f_10187_3637_3669_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10187, 3637, 3669);
                    return return_v;
                }


                int
                f_10187_3703_3754(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.ISpecializedFieldReference
                fieldReference)
                {
                    this_param.Visit((Microsoft.Cci.IFieldReference)fieldReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10187, 3703, 3754);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10187_3793_3811()
                {
                    var return_v = AdaptedFieldSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10187, 3793, 3811);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10187_3793_3828(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.ContainingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10187, 3793, 3828);
                    return return_v;
                }


                int
                f_10187_3920_3961(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                fieldDefinition)
                {
                    this_param.Visit((Microsoft.Cci.IFieldDefinition)fieldDefinition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10187, 3920, 3961);
                    return 0;
                }


                int
                f_10187_4028_4068(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                fieldReference)
                {
                    this_param.Visit((Microsoft.Cci.IFieldReference)fieldReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10187, 4028, 4068);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10187, 3491, 4095);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10187, 3491, 4095);
            }
        }

        Cci.IDefinition Cci.IReference.AsDefinition(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10187, 4107, 4333);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10187, 4196, 4263);

                PEModuleBuilder
                moduleBeingBuilt = (PEModuleBuilder)context.Module
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10187, 4279, 4322);

                return f_10187_4286_4321(this, moduleBeingBuilt);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10187, 4107, 4333);

                Microsoft.Cci.IFieldDefinition
                f_10187_4286_4321(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                this_param, Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                moduleBeingBuilt)
                {
                    var return_v = this_param.ResolvedFieldImpl(moduleBeingBuilt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10187, 4286, 4321);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10187, 4107, 4333);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10187, 4107, 4333);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        string Cci.INamedEntity.Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10187, 4398, 4488);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10187, 4434, 4473);

                    return f_10187_4441_4472(f_10187_4441_4459());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10187, 4398, 4488);

                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f_10187_4441_4459()
                    {
                        var return_v = AdaptedFieldSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10187, 4441, 4459);
                        return return_v;
                    }


                    string
                    f_10187_4441_4472(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.MetadataName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10187, 4441, 4472);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10187, 4345, 4499);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10187, 4345, 4499);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool Cci.IFieldReference.IsContextualNamedEntity
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10187, 4584, 4648);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10187, 4620, 4633);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10187, 4584, 4648);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10187, 4511, 4659);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10187, 4511, 4659);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        MetadataConstant Cci.IFieldDefinition.GetCompileTimeValue(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10187, 4671, 4869);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10187, 4774, 4801);

                f_10187_4774_4800(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10187, 4817, 4858);

                return f_10187_4824_4857(this, context);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10187, 4671, 4869);

                int
                f_10187_4774_4800(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                this_param)
                {
                    this_param.CheckDefinitionInvariant();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10187, 4774, 4800);
                    return 0;
                }


                Microsoft.CodeAnalysis.CodeGen.MetadataConstant
                f_10187_4824_4857(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetMetadataConstantValue(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10187, 4824, 4857);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10187, 4671, 4869);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10187, 4671, 4869);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal MetadataConstant GetMetadataConstantValue(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10187, 4881, 6127);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10187, 5169, 6088) || true) && (f_10187_5173_5210(f_10187_5173_5191()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10187, 5169, 6088);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10187, 5740, 6073);

                    return f_10187_5747_6072(((PEModuleBuilder)context.Module), f_10187_5796_5819(f_10187_5796_5814()), f_10187_5821_5853(f_10187_5821_5839()), (CSharpSyntaxNode)context.SyntaxNodeOpt, diagnostics: context.Diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10187, 5169, 6088);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10187, 6104, 6116);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10187, 4881, 6127);

                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10187_5173_5191()
                {
                    var return_v = AdaptedFieldSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10187, 5173, 5191);
                    return return_v;
                }


                bool
                f_10187_5173_5210(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.IsMetadataConstant;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10187, 5173, 5210);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10187_5796_5814()
                {
                    var return_v = AdaptedFieldSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10187, 5796, 5814);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10187_5796_5819(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10187, 5796, 5819);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10187_5821_5839()
                {
                    var return_v = AdaptedFieldSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10187, 5821, 5839);
                    return return_v;
                }


                object
                f_10187_5821_5853(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10187, 5821, 5853);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.MetadataConstant
                f_10187_5747_6072(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, object
                value, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.CreateConstant(type, value, syntaxNodeOpt: (Microsoft.CodeAnalysis.SyntaxNode)syntaxNodeOpt, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10187, 5747, 6072);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10187, 4881, 6127);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10187, 4881, 6127);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        ImmutableArray<byte> Cci.IFieldDefinition.MappedData
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10187, 6216, 6349);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10187, 6252, 6279);

                    f_10187_6252_6278(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10187, 6297, 6334);

                    return default(ImmutableArray<byte>);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10187, 6216, 6349);

                    int
                    f_10187_6252_6278(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10187, 6252, 6278);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10187, 6139, 6360);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10187, 6139, 6360);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool Cci.IFieldDefinition.IsCompileTimeConstant
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10187, 6444, 6785);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10187, 6480, 6507);

                    f_10187_6480_6506(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10187, 6725, 6770);

                    return f_10187_6732_6769(f_10187_6732_6750());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10187, 6444, 6785);

                    int
                    f_10187_6480_6506(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10187, 6480, 6506);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f_10187_6732_6750()
                    {
                        var return_v = AdaptedFieldSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10187, 6732, 6750);
                        return return_v;
                    }


                    bool
                    f_10187_6732_6769(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.IsMetadataConstant;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10187, 6732, 6769);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10187, 6372, 6796);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10187, 6372, 6796);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool Cci.IFieldDefinition.IsNotSerialized
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10187, 6874, 7012);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10187, 6910, 6937);

                    f_10187_6910_6936(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10187, 6955, 6997);

                    return f_10187_6962_6996(f_10187_6962_6980());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10187, 6874, 7012);

                    int
                    f_10187_6910_6936(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10187, 6910, 6936);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f_10187_6962_6980()
                    {
                        var return_v = AdaptedFieldSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10187, 6962, 6980);
                        return return_v;
                    }


                    bool
                    f_10187_6962_6996(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.IsNotSerialized;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10187, 6962, 6996);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10187, 6808, 7023);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10187, 6808, 7023);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool Cci.IFieldDefinition.IsReadOnly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10187, 7096, 7303);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10187, 7132, 7159);

                    f_10187_7132_7158(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10187, 7177, 7288);

                    return f_10187_7184_7213(f_10187_7184_7202()) || (DynAbs.Tracing.TraceSender.Expression_False(10187, 7184, 7287) || (f_10187_7218_7244(f_10187_7218_7236()) && (DynAbs.Tracing.TraceSender.Expression_True(10187, 7218, 7286) && f_10187_7248_7286_M(!f_10187_7249_7267().IsMetadataConstant))));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10187, 7096, 7303);

                    int
                    f_10187_7132_7158(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10187, 7132, 7158);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f_10187_7184_7202()
                    {
                        var return_v = AdaptedFieldSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10187, 7184, 7202);
                        return return_v;
                    }


                    bool
                    f_10187_7184_7213(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.IsReadOnly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10187, 7184, 7213);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f_10187_7218_7236()
                    {
                        var return_v = AdaptedFieldSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10187, 7218, 7236);
                        return return_v;
                    }


                    bool
                    f_10187_7218_7244(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.IsConst;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10187, 7218, 7244);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f_10187_7249_7267()
                    {
                        var return_v = AdaptedFieldSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10187, 7249, 7267);
                        return return_v;
                    }


                    bool
                    f_10187_7248_7286_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10187, 7248, 7286);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10187, 7035, 7314);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10187, 7035, 7314);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool Cci.IFieldDefinition.IsRuntimeSpecial
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10187, 7393, 7537);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10187, 7429, 7456);

                    f_10187_7429_7455(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10187, 7474, 7522);

                    return f_10187_7481_7521(f_10187_7481_7499());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10187, 7393, 7537);

                    int
                    f_10187_7429_7455(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10187, 7429, 7455);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f_10187_7481_7499()
                    {
                        var return_v = AdaptedFieldSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10187, 7481, 7499);
                        return return_v;
                    }


                    bool
                    f_10187_7481_7521(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.HasRuntimeSpecialName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10187, 7481, 7521);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10187, 7326, 7548);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10187, 7326, 7548);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool Cci.IFieldDefinition.IsSpecialName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10187, 7624, 7761);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10187, 7660, 7687);

                    f_10187_7660_7686(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10187, 7705, 7746);

                    return f_10187_7712_7745(f_10187_7712_7730());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10187, 7624, 7761);

                    int
                    f_10187_7660_7686(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10187, 7660, 7686);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f_10187_7712_7730()
                    {
                        var return_v = AdaptedFieldSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10187, 7712, 7730);
                        return return_v;
                    }


                    bool
                    f_10187_7712_7745(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.HasSpecialName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10187, 7712, 7745);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10187, 7560, 7772);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10187, 7560, 7772);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool Cci.IFieldDefinition.IsStatic
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10187, 7843, 7974);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10187, 7879, 7906);

                    f_10187_7879_7905(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10187, 7924, 7959);

                    return f_10187_7931_7958(f_10187_7931_7949());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10187, 7843, 7974);

                    int
                    f_10187_7879_7905(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10187, 7879, 7905);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f_10187_7931_7949()
                    {
                        var return_v = AdaptedFieldSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10187, 7931, 7949);
                        return return_v;
                    }


                    bool
                    f_10187_7931_7958(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.IsStatic;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10187, 7931, 7958);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10187, 7784, 7985);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10187, 7784, 7985);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool Cci.IFieldDefinition.IsMarshalledExplicitly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10187, 8070, 8215);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10187, 8106, 8133);

                    f_10187_8106_8132(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10187, 8151, 8200);

                    return f_10187_8158_8199(f_10187_8158_8176());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10187, 8070, 8215);

                    int
                    f_10187_8106_8132(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10187, 8106, 8132);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f_10187_8158_8176()
                    {
                        var return_v = AdaptedFieldSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10187, 8158, 8176);
                        return return_v;
                    }


                    bool
                    f_10187_8158_8199(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.IsMarshalledExplicitly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10187, 8158, 8199);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10187, 7997, 8226);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10187, 7997, 8226);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.IMarshallingInformation Cci.IFieldDefinition.MarshallingInformation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10187, 8334, 8479);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10187, 8370, 8397);

                    f_10187_8370_8396(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10187, 8415, 8464);

                    return f_10187_8422_8463(f_10187_8422_8440());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10187, 8334, 8479);

                    int
                    f_10187_8370_8396(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10187, 8370, 8396);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f_10187_8422_8440()
                    {
                        var return_v = AdaptedFieldSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10187, 8422, 8440);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.MarshalPseudoCustomAttributeData
                    f_10187_8422_8463(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.MarshallingInformation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10187, 8422, 8463);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10187, 8238, 8490);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10187, 8238, 8490);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ImmutableArray<byte> Cci.IFieldDefinition.MarshallingDescriptor
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10187, 8590, 8734);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10187, 8626, 8653);

                    f_10187_8626_8652(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10187, 8671, 8719);

                    return f_10187_8678_8718(f_10187_8678_8696());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10187, 8590, 8734);

                    int
                    f_10187_8626_8652(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10187, 8626, 8652);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f_10187_8678_8696()
                    {
                        var return_v = AdaptedFieldSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10187, 8678, 8696);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<byte>
                    f_10187_8678_8718(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.MarshallingDescriptor;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10187, 8678, 8718);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10187, 8502, 8745);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10187, 8502, 8745);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        int Cci.IFieldDefinition.Offset
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10187, 8813, 8957);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10187, 8849, 8876);

                    f_10187_8849_8875(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10187, 8894, 8942);

                    return f_10187_8901_8936(f_10187_8901_8919()) ?? (DynAbs.Tracing.TraceSender.Expression_Null<int?>(10187, 8901, 8941) ?? 0);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10187, 8813, 8957);

                    int
                    f_10187_8849_8875(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10187, 8849, 8875);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f_10187_8901_8919()
                    {
                        var return_v = AdaptedFieldSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10187, 8901, 8919);
                        return return_v;
                    }


                    int?
                    f_10187_8901_8936(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeLayoutOffset;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10187, 8901, 8936);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10187, 8757, 8968);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10187, 8757, 8968);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10187, 9075, 9228);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10187, 9111, 9138);

                    f_10187_9111_9137(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10187, 9156, 9213);

                    return f_10187_9163_9212(f_10187_9163_9196(f_10187_9163_9181()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10187, 9075, 9228);

                    int
                    f_10187_9111_9137(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10187, 9111, 9137);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f_10187_9163_9181()
                    {
                        var return_v = AdaptedFieldSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10187, 9163, 9181);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10187_9163_9196(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10187, 9163, 9196);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                    f_10187_9163_9212(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.GetCciAdapter();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10187, 9163, 9212);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10187, 8980, 9239);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10187, 8980, 9239);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10187, 9337, 9493);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10187, 9373, 9400);

                    f_10187_9373_9399(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10187, 9418, 9478);

                    return f_10187_9425_9477(f_10187_9458_9476());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10187, 9337, 9493);

                    int
                    f_10187_9373_9399(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10187, 9373, 9399);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f_10187_9458_9476()
                    {
                        var return_v = AdaptedFieldSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10187, 9458, 9476);
                        return return_v;
                    }


                    Microsoft.Cci.TypeMemberVisibility
                    f_10187_9425_9477(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    symbol)
                    {
                        var return_v = PEModuleBuilder.MemberVisibility((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10187, 9425, 9477);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10187, 9251, 9504);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10187, 9251, 9504);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.IFieldReference Cci.ISpecializedFieldReference.UnspecializedVersion
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10187, 9612, 9789);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10187, 9648, 9695);

                    f_10187_9648_9694(f_10187_9661_9693_M(!f_10187_9662_9680().IsDefinition));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10187, 9713, 9774);

                    return f_10187_9720_9773(f_10187_9720_9757(f_10187_9720_9738()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10187, 9612, 9789);

                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f_10187_9662_9680()
                    {
                        var return_v = AdaptedFieldSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10187, 9662, 9680);
                        return return_v;
                    }


                    bool
                    f_10187_9661_9693_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10187, 9661, 9693);
                        return return_v;
                    }


                    int
                    f_10187_9648_9694(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10187, 9648, 9694);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f_10187_9720_9738()
                    {
                        var return_v = AdaptedFieldSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10187, 9720, 9738);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f_10187_9720_9757(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10187, 9720, 9757);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                    f_10187_9720_9773(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.GetCciAdapter();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10187, 9720, 9773);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10187, 9516, 9800);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10187, 9516, 9800);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static FieldSymbolAdapter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10187, 494, 9807);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10187, 494, 9807);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10187, 494, 9807);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10187, 494, 9807);
    }
    internal partial class FieldSymbol
    {
        private FieldSymbolAdapter _lazyAdapter;

        protected sealed override SymbolAdapter GetCciAdapterImpl()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10187, 9989, 10007);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10187, 9992, 10007);
                return f_10187_9992_10007(this); DynAbs.Tracing.TraceSender.TraceExitMethod(10187, 9989, 10007);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10187, 9989, 10007);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10187, 9989, 10007);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
            f_10187_9992_10007(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
            this_param)
            {
                var return_v = this_param.GetCciAdapter();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10187, 9992, 10007);
                return return_v;
            }

        }

        internal new FieldSymbolAdapter GetCciAdapter()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10187, 10020, 10300);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10187, 10092, 10253) || true) && (_lazyAdapter is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10187, 10092, 10253);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10187, 10150, 10238);

                    return f_10187_10157_10237(ref _lazyAdapter, f_10187_10208_10236(this));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10187, 10092, 10253);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10187, 10269, 10289);

                return _lazyAdapter;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10187, 10020, 10300);

                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                f_10187_10208_10236(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                underlyingFieldSymbol)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter(underlyingFieldSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10187, 10208, 10236);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                f_10187_10157_10237(ref Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter?
                target, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                value)
                {
                    var return_v = InterlockedOperations.Initialize(ref target, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10187, 10157, 10237);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10187, 10020, 10300);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10187, 10020, 10300);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual bool IsMarshalledExplicitly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10187, 10555, 10694);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10187, 10591, 10618);

                    f_10187_10591_10617(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10187, 10636, 10679);

                    return f_10187_10643_10670(this) != null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10187, 10555, 10694);

                    int
                    f_10187_10591_10617(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10187, 10591, 10617);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.MarshalPseudoCustomAttributeData
                    f_10187_10643_10670(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.MarshallingInformation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10187, 10643, 10670);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10187, 10486, 10705);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10187, 10486, 10705);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10187, 10801, 10934);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10187, 10837, 10864);

                    f_10187_10837_10863(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10187, 10882, 10919);

                    return default(ImmutableArray<byte>);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10187, 10801, 10934);

                    int
                    f_10187_10837_10863(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10187, 10837, 10863);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10187, 10717, 10945);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10187, 10717, 10945);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static FieldSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10187, 9815, 10952);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10187, 9815, 10952);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10187, 9815, 10952);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10187, 9815, 10952);
    }
    internal partial class FieldSymbolAdapter
    {
        internal FieldSymbolAdapter(FieldSymbol underlyingFieldSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10187, 11029, 11170);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10187, 11260, 11308);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10187, 11116, 11159);

                AdaptedFieldSymbol = underlyingFieldSymbol;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10187, 11029, 11170);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10187, 11029, 11170);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10187, 11029, 11170);
            }
        }

        internal sealed override Symbol AdaptedSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10187, 11228, 11249);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10187, 11231, 11249);
                    return f_10187_11231_11249(); DynAbs.Tracing.TraceSender.TraceExitMethod(10187, 11228, 11249);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10187, 11228, 11249);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10187, 11228, 11249);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal FieldSymbol AdaptedFieldSymbol { get; }

        Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
        f_10187_11231_11249()
        {
            var return_v = AdaptedFieldSymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10187, 11231, 11249);
            return return_v;
        }

    }
}
