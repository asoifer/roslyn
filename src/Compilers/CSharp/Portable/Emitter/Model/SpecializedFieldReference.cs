// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.Emit;

namespace Microsoft.CodeAnalysis.CSharp.Emit
{
    internal sealed class SpecializedFieldReference : TypeMemberReference, Cci.ISpecializedFieldReference
    {
        private readonly FieldSymbol _underlyingField;

        public SpecializedFieldReference(FieldSymbol underlyingField)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10208, 791, 985);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10208, 762, 778);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10208, 877, 923);

                f_10208_877_922((object)underlyingField != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10208, 939, 974);

                _underlyingField = underlyingField;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10208, 791, 985);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10208, 791, 985);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10208, 791, 985);
            }
        }

        protected override Symbol UnderlyingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10208, 1064, 1139);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10208, 1100, 1124);

                    return _underlyingField;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10208, 1064, 1139);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10208, 997, 1150);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10208, 997, 1150);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override void Dispatch(Cci.MetadataVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10208, 1162, 1308);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10208, 1245, 1297);

                f_10208_1245_1296(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10208, 1162, 1308);

                int
                f_10208_1245_1296(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.ISpecializedFieldReference
                fieldReference)
                {
                    this_param.Visit((Microsoft.Cci.IFieldReference)fieldReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10208, 1245, 1296);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10208, 1162, 1308);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10208, 1162, 1308);
            }
        }

        Cci.IFieldReference Cci.ISpecializedFieldReference.UnspecializedVersion
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10208, 1416, 1607);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10208, 1452, 1515);

                    f_10208_1452_1514(f_10208_1465_1513(f_10208_1465_1500(_underlyingField)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10208, 1533, 1592);

                    return f_10208_1540_1591(f_10208_1540_1575(_underlyingField));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10208, 1416, 1607);

                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f_10208_1465_1500(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10208, 1465, 1500);
                        return return_v;
                    }


                    bool
                    f_10208_1465_1513(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.IsDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10208, 1465, 1513);
                        return return_v;
                    }


                    int
                    f_10208_1452_1514(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10208, 1452, 1514);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f_10208_1540_1575(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10208, 1540, 1575);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                    f_10208_1540_1591(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.GetCciAdapter();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10208, 1540, 1591);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10208, 1320, 1618);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10208, 1320, 1618);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.ISpecializedFieldReference Cci.IFieldReference.AsSpecializedFieldReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10208, 1733, 1796);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10208, 1769, 1781);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10208, 1733, 1796);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10208, 1630, 1807);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10208, 1630, 1807);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.ITypeReference Cci.IFieldReference.GetType(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10208, 1819, 2500);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10208, 1911, 1978);

                TypeWithAnnotations
                oldType = f_10208_1941_1977(_underlyingField)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10208, 1992, 2038);

                var
                customModifiers = oldType.CustomModifiers
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10208, 2052, 2211);

                var
                type = f_10208_2063_2210(((PEModuleBuilder)context.Module), oldType.Type, (CSharpSyntaxNode)context.SyntaxNodeOpt, diagnostics: context.Diagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10208, 2227, 2489) || true) && (customModifiers.Length == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10208, 2227, 2489);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10208, 2292, 2304);

                    return type;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10208, 2227, 2489);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10208, 2227, 2489);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10208, 2370, 2474);

                    return f_10208_2377_2473(type, ImmutableArray<Cci.ICustomModifier>.CastUp(customModifiers));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10208, 2227, 2489);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10208, 1819, 2500);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10208_1941_1977(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10208, 1941, 1977);
                    return return_v;
                }


                Microsoft.Cci.ITypeReference
                f_10208_2063_2210(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeSymbol, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.Translate(typeSymbol, syntaxNodeOpt: (Microsoft.CodeAnalysis.SyntaxNode)syntaxNodeOpt, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10208, 2063, 2210);
                    return return_v;
                }


                Microsoft.Cci.ModifiedTypeReference
                f_10208_2377_2473(Microsoft.Cci.ITypeReference
                modifiedType, System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ICustomModifier>
                customModifiers)
                {
                    var return_v = new Microsoft.Cci.ModifiedTypeReference(modifiedType, customModifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10208, 2377, 2473);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10208, 1819, 2500);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10208, 1819, 2500);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        Cci.IFieldDefinition Cci.IFieldReference.GetResolvedField(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10208, 2512, 2638);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10208, 2615, 2627);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10208, 2512, 2638);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10208, 2512, 2638);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10208, 2512, 2638);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        bool Cci.IFieldReference.IsContextualNamedEntity
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10208, 2723, 2787);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10208, 2759, 2772);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10208, 2723, 2787);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10208, 2650, 2798);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10208, 2650, 2798);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static SpecializedFieldReference()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10208, 615, 2805);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10208, 615, 2805);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10208, 615, 2805);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10208, 615, 2805);

        int
        f_10208_877_922(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10208, 877, 922);
            return 0;
        }

    }
}
