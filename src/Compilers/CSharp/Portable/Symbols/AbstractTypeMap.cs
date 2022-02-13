// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal abstract class AbstractTypeMap
    {
        internal virtual NamedTypeSymbol SubstituteTypeDeclaration(NamedTypeSymbol previous)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10085, 784, 1263);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 893, 960);

                f_10085_893_959((object)f_10085_914_938(previous) == (object)previous);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 976, 1057);

                NamedTypeSymbol
                newContainingType = f_10085_1012_1056(this, f_10085_1032_1055(previous))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 1071, 1173) || true) && ((object)newContainingType == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10085, 1071, 1173);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 1142, 1158);

                    return previous;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10085, 1071, 1173);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 1189, 1252);

                return f_10085_1196_1251(f_10085_1196_1223(previous), newContainingType);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10085, 784, 1263);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10085_914_938(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ConstructedFrom;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10085, 914, 938);
                    return return_v;
                }


                int
                f_10085_893_959(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 893, 959);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10085_1032_1055(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10085, 1032, 1055);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10085_1012_1056(Microsoft.CodeAnalysis.CSharp.Symbols.AbstractTypeMap
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                previous)
                {
                    var return_v = this_param.SubstituteNamedType(previous);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 1012, 1056);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10085_1196_1223(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10085, 1196, 1223);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10085_1196_1251(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                newOwner)
                {
                    var return_v = this_param.AsMember(newOwner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 1196, 1251);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10085, 784, 1263);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10085, 784, 1263);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal NamedTypeSymbol SubstituteNamedType(NamedTypeSymbol previous)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10085, 1459, 3680);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 1554, 1620) || true) && (f_10085_1558_1589(previous, null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10085, 1554, 1620);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 1608, 1620);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10085, 1554, 1620);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 1636, 1704) || true) && (f_10085_1640_1669(previous))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10085, 1636, 1704);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 1688, 1704);

                    return previous;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10085, 1636, 1704);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 1720, 2172) || true) && (f_10085_1724_1748(previous))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10085, 1720, 2172);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 1782, 1910);

                    ImmutableArray<TypeWithAnnotations>
                    oldFieldTypes = f_10085_1834_1909(previous)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 1928, 2011);

                    ImmutableArray<TypeWithAnnotations>
                    newFieldTypes = f_10085_1980_2010(this, oldFieldTypes)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 2029, 2157);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10085, 2036, 2068) || (((oldFieldTypes == newFieldTypes) && DynAbs.Tracing.TraceSender.Conditional_F2(10085, 2071, 2079)) || DynAbs.Tracing.TraceSender.Conditional_F3(10085, 2082, 2156))) ? previous : f_10085_2082_2156(previous, newFieldTypes);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10085, 1720, 2172);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 2504, 2566);

                NamedTypeSymbol
                oldConstructedFrom = f_10085_2541_2565(previous)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 2580, 2663);

                NamedTypeSymbol
                newConstructedFrom = f_10085_2617_2662(this, oldConstructedFrom)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 2679, 2792);

                ImmutableArray<TypeWithAnnotations>
                oldTypeArguments = f_10085_2734_2791(previous)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 2806, 2878);

                bool
                changed = !f_10085_2822_2877(oldConstructedFrom, newConstructedFrom)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 2892, 2986);

                var
                newTypeArguments = f_10085_2915_2985(oldTypeArguments.Length)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 3011, 3016);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 3002, 3406) || true) && (i < oldTypeArguments.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 3047, 3050)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10085, 3002, 3406))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10085, 3002, 3406);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 3084, 3122);

                        var
                        oldArgument = oldTypeArguments[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 3140, 3191);

                        var
                        newArgument = oldArgument.SubstituteType(this)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 3211, 3337) || true) && (!changed && (DynAbs.Tracing.TraceSender.Expression_True(10085, 3215, 3261) && !oldArgument.IsSameAs(newArgument)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10085, 3211, 3337);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 3303, 3318);

                            changed = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10085, 3211, 3337);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 3357, 3391);

                        f_10085_3357_3390(
                                        newTypeArguments, newArgument);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10085, 1, 405);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10085, 1, 405);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 3422, 3541) || true) && (!changed)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10085, 3422, 3541);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 3468, 3492);

                    f_10085_3468_3491(newTypeArguments);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 3510, 3526);

                    return previous;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10085, 3422, 3541);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 3557, 3669);

                // LAFHIS
                var temp = newConstructedFrom.ConstructIfGeneric(f_10085_3602_3639(newTypeArguments));
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 3564, 3640);

                return f_10085_3564_3668(temp, previous);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10085, 1459, 3680);

                bool
                f_10085_1558_1589(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                objA, object?
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 1558, 1589);
                    return return_v;
                }


                bool
                f_10085_1640_1669(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsUnboundGenericType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10085, 1640, 1669);
                    return return_v;
                }


                bool
                f_10085_1724_1748(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsAnonymousType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10085, 1724, 1748);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10085_1834_1909(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = AnonymousTypeManager.GetAnonymousTypePropertyTypesWithAnnotations(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 1834, 1909);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10085_1980_2010(Microsoft.CodeAnalysis.CSharp.Symbols.AbstractTypeMap
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                original)
                {
                    var return_v = this_param.SubstituteTypes(original);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 1980, 2010);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10085_2082_2156(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                newFieldTypes)
                {
                    var return_v = AnonymousTypeManager.ConstructAnonymousTypeSymbol(type, newFieldTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 2082, 2156);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10085_2541_2565(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ConstructedFrom;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10085, 2541, 2565);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10085_2617_2662(Microsoft.CodeAnalysis.CSharp.Symbols.AbstractTypeMap
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                previous)
                {
                    var return_v = this_param.SubstituteTypeDeclaration(previous);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 2617, 2662);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10085_2734_2791(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeArgumentsWithAnnotationsNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10085, 2734, 2791);
                    return return_v;
                }


                bool
                f_10085_2822_2877(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 2822, 2877);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10085_2915_2985(int
                capacity)
                {
                    var return_v = ArrayBuilder<TypeWithAnnotations>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 2915, 2985);
                    return return_v;
                }


                int
                f_10085_3357_3390(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 3357, 3390);
                    return 0;
                }


                int
                f_10085_3468_3491(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 3468, 3491);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10085_3602_3639(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 3602, 3639);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10085_3564_3668(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                original)
                {
                    var return_v = this_param.WithTupleDataFrom(original);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 3564, 3668);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10085, 1459, 3680);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10085, 1459, 3680);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal TypeWithAnnotations SubstituteType(TypeSymbol previous)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10085, 4077, 5536);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 4166, 4256) || true) && (f_10085_4170_4201(previous, null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10085, 4166, 4256);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 4220, 4256);

                    return default(TypeWithAnnotations);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10085, 4166, 4256);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 4272, 4290);

                TypeSymbol
                result
                = default(TypeSymbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 4306, 5467);

                switch (f_10085_4314_4327(previous))
                {

                    case SymbolKind.NamedType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10085, 4306, 5467);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 4409, 4465);

                        result = f_10085_4418_4464(this, previous);
                        DynAbs.Tracing.TraceSender.TraceBreak(10085, 4487, 4493);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10085, 4306, 5467);

                    case SymbolKind.TypeParameter:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10085, 4306, 5467);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 4563, 4625);

                        return f_10085_4570_4624(this, previous);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10085, 4306, 5467);

                    case SymbolKind.ArrayType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10085, 4306, 5467);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 4691, 4747);

                        result = f_10085_4700_4746(this, previous);
                        DynAbs.Tracing.TraceSender.TraceBreak(10085, 4769, 4775);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10085, 4306, 5467);

                    case SymbolKind.PointerType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10085, 4306, 5467);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 4843, 4903);

                        result = f_10085_4852_4902(this, previous);
                        DynAbs.Tracing.TraceSender.TraceBreak(10085, 4925, 4931);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10085, 4306, 5467);

                    case SymbolKind.FunctionPointerType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10085, 4306, 5467);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 5007, 5083);

                        result = f_10085_5016_5082(this, previous);
                        DynAbs.Tracing.TraceSender.TraceBreak(10085, 5105, 5111);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10085, 4306, 5467);

                    case SymbolKind.DynamicType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10085, 4306, 5467);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 5179, 5212);

                        result = f_10085_5188_5211(this);
                        DynAbs.Tracing.TraceSender.TraceBreak(10085, 5234, 5240);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10085, 4306, 5467);

                    case SymbolKind.ErrorType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10085, 4306, 5467);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 5306, 5358);

                        return f_10085_5313_5357(((ErrorTypeSymbol)previous), this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10085, 4306, 5467);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10085, 4306, 5467);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 5406, 5424);

                        result = previous;
                        DynAbs.Tracing.TraceSender.TraceBreak(10085, 5446, 5452);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10085, 4306, 5467);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 5483, 5525);

                return TypeWithAnnotations.Create(result);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10085, 4077, 5536);

                bool
                f_10085_4170_4201(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                objA, object?
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 4170, 4201);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10085_4314_4327(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10085, 4314, 4327);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10085_4418_4464(Microsoft.CodeAnalysis.CSharp.Symbols.AbstractTypeMap
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                previous)
                {
                    var return_v = this_param.SubstituteNamedType((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)previous);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 4418, 4464);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10085_4570_4624(Microsoft.CodeAnalysis.CSharp.Symbols.AbstractTypeMap
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeParameter)
                {
                    var return_v = this_param.SubstituteTypeParameter((Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol)typeParameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 4570, 4624);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                f_10085_4700_4746(Microsoft.CodeAnalysis.CSharp.Symbols.AbstractTypeMap
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t)
                {
                    var return_v = this_param.SubstituteArrayType((Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol)t);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 4700, 4746);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                f_10085_4852_4902(Microsoft.CodeAnalysis.CSharp.Symbols.AbstractTypeMap
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t)
                {
                    var return_v = this_param.SubstitutePointerType((Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol)t);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 4852, 4902);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                f_10085_5016_5082(Microsoft.CodeAnalysis.CSharp.Symbols.AbstractTypeMap
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f)
                {
                    var return_v = this_param.SubstituteFunctionPointerType((Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol)f);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 5016, 5082);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10085_5188_5211(Microsoft.CodeAnalysis.CSharp.Symbols.AbstractTypeMap
                this_param)
                {
                    var return_v = this_param.SubstituteDynamicType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 5188, 5211);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10085_5313_5357(Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AbstractTypeMap
                typeMap)
                {
                    var return_v = this_param.Substitute(typeMap);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 5313, 5357);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10085, 4077, 5536);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10085, 4077, 5536);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal TypeWithAnnotations SubstituteType(TypeWithAnnotations previous)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10085, 5548, 5694);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 5646, 5683);

                return previous.SubstituteType(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10085, 5548, 5694);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10085, 5548, 5694);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10085, 5548, 5694);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual ImmutableArray<CustomModifier> SubstituteCustomModifiers(ImmutableArray<CustomModifier> customModifiers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10085, 5706, 7640);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 5852, 5960) || true) && (customModifiers.IsDefaultOrEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10085, 5852, 5960);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 5922, 5945);

                    return customModifiers;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10085, 5852, 5960);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 5985, 5990);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 5976, 7590) || true) && (i < customModifiers.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 6020, 6023)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10085, 5976, 7590))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10085, 5976, 7590);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 6057, 6142);

                        NamedTypeSymbol
                        modifier = f_10085_6084_6141(((CSharpCustomModifier)customModifiers[i]))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 6160, 6208);

                        var
                        substituted = f_10085_6178_6207(this, modifier)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 6228, 7575) || true) && (!f_10085_6233_6310(modifier, substituted, TypeCompareKind.ConsiderEverything2))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10085, 6228, 7575);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 6352, 6431);

                            var
                            builder = f_10085_6366_6430(customModifiers.Length)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 6453, 6490);

                            f_10085_6453_6489(builder, customModifiers, i);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 6514, 6659);

                            f_10085_6514_6658(
                                                builder, (DynAbs.Tracing.TraceSender.Conditional_F1(10085, 6526, 6555) || ((f_10085_6526_6555(customModifiers[i]) && DynAbs.Tracing.TraceSender.Conditional_F2(10085, 6558, 6606)) || DynAbs.Tracing.TraceSender.Conditional_F3(10085, 6609, 6657))) ? f_10085_6558_6606(substituted) : f_10085_6609_6657(substituted));
                            try
                            {
                                for (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 6686, 6689)
       , i++; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 6681, 7420) || true) && (i < customModifiers.Length)
       ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 6719, 6722)
       , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10085, 6681, 7420))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10085, 6681, 7420);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 6772, 6841);

                                    modifier = f_10085_6783_6840(((CSharpCustomModifier)customModifiers[i]));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 6867, 6911);

                                    substituted = f_10085_6881_6910(this, modifier);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 6939, 7397) || true) && (!f_10085_6944_7021(modifier, substituted, TypeCompareKind.ConsiderEverything2))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10085, 6939, 7397);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 7079, 7224);

                                        f_10085_7079_7223(builder, (DynAbs.Tracing.TraceSender.Conditional_F1(10085, 7091, 7120) || ((f_10085_7091_7120(customModifiers[i]) && DynAbs.Tracing.TraceSender.Conditional_F2(10085, 7123, 7171)) || DynAbs.Tracing.TraceSender.Conditional_F3(10085, 7174, 7222))) ? f_10085_7123_7171(substituted) : f_10085_7174_7222(substituted));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10085, 6939, 7397);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10085, 6939, 7397);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 7338, 7370);

                                        f_10085_7338_7369(builder, customModifiers[i]);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10085, 6939, 7397);
                                    }
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10085, 1, 740);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10085, 1, 740);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 7444, 7498);

                            f_10085_7444_7497(f_10085_7457_7470(builder) == customModifiers.Length);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 7520, 7556);

                            return f_10085_7527_7555(builder);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10085, 6228, 7575);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10085, 1, 1615);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10085, 1, 1615);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 7606, 7629);

                return customModifiers;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10085, 5706, 7640);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10085_6084_6141(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpCustomModifier
                this_param)
                {
                    var return_v = this_param.ModifierSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10085, 6084, 6141);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10085_6178_6207(Microsoft.CodeAnalysis.CSharp.Symbols.AbstractTypeMap
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                previous)
                {
                    var return_v = this_param.SubstituteNamedType(previous);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 6178, 6207);
                    return return_v;
                }


                bool
                f_10085_6233_6310(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 6233, 6310);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CustomModifier>
                f_10085_6366_6430(int
                capacity)
                {
                    var return_v = ArrayBuilder<CustomModifier>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 6366, 6430);
                    return return_v;
                }


                int
                f_10085_6453_6489(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CustomModifier>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                items, int
                length)
                {
                    this_param.AddRange(items, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 6453, 6489);
                    return 0;
                }


                bool
                f_10085_6526_6555(Microsoft.CodeAnalysis.CustomModifier
                this_param)
                {
                    var return_v = this_param.IsOptional;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10085, 6526, 6555);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CustomModifier
                f_10085_6558_6606(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                modifier)
                {
                    var return_v = CSharpCustomModifier.CreateOptional(modifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 6558, 6606);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CustomModifier
                f_10085_6609_6657(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                modifier)
                {
                    var return_v = CSharpCustomModifier.CreateRequired(modifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 6609, 6657);
                    return return_v;
                }


                int
                f_10085_6514_6658(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CustomModifier>
                this_param, Microsoft.CodeAnalysis.CustomModifier
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 6514, 6658);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10085_6783_6840(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpCustomModifier
                this_param)
                {
                    var return_v = this_param.ModifierSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10085, 6783, 6840);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10085_6881_6910(Microsoft.CodeAnalysis.CSharp.Symbols.AbstractTypeMap
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                previous)
                {
                    var return_v = this_param.SubstituteNamedType(previous);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 6881, 6910);
                    return return_v;
                }


                bool
                f_10085_6944_7021(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 6944, 7021);
                    return return_v;
                }


                bool
                f_10085_7091_7120(Microsoft.CodeAnalysis.CustomModifier
                this_param)
                {
                    var return_v = this_param.IsOptional;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10085, 7091, 7120);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CustomModifier
                f_10085_7123_7171(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                modifier)
                {
                    var return_v = CSharpCustomModifier.CreateOptional(modifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 7123, 7171);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CustomModifier
                f_10085_7174_7222(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                modifier)
                {
                    var return_v = CSharpCustomModifier.CreateRequired(modifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 7174, 7222);
                    return return_v;
                }


                int
                f_10085_7079_7223(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CustomModifier>
                this_param, Microsoft.CodeAnalysis.CustomModifier
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 7079, 7223);
                    return 0;
                }


                int
                f_10085_7338_7369(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CustomModifier>
                this_param, Microsoft.CodeAnalysis.CustomModifier
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 7338, 7369);
                    return 0;
                }


                int
                f_10085_7457_7470(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CustomModifier>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10085, 7457, 7470);
                    return return_v;
                }


                int
                f_10085_7444_7497(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 7444, 7497);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                f_10085_7527_7555(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CustomModifier>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 7527, 7555);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10085, 5706, 7640);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10085, 5706, 7640);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected virtual TypeSymbol SubstituteDynamicType()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10085, 7652, 7774);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 7729, 7763);

                return DynamicTypeSymbol.Instance;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10085, 7652, 7774);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10085, 7652, 7774);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10085, 7652, 7774);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected virtual TypeWithAnnotations SubstituteTypeParameter(TypeParameterSymbol typeParameter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10085, 7786, 7967);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 7907, 7956);

                return TypeWithAnnotations.Create(typeParameter);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10085, 7786, 7967);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10085, 7786, 7967);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10085, 7786, 7967);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ArrayTypeSymbol SubstituteArrayType(ArrayTypeSymbol t)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10085, 7979, 9668);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 8066, 8112);

                var
                oldElement = f_10085_8083_8111(t)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 8126, 8188);

                TypeWithAnnotations
                element = oldElement.SubstituteType(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 8202, 8292) || true) && (element.IsSameAs(oldElement))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10085, 8202, 8292);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 8268, 8277);

                    return t;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10085, 8202, 8292);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 8308, 9445) || true) && (f_10085_8312_8323(t))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10085, 8308, 9445);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 8357, 8437);

                    ImmutableArray<NamedTypeSymbol>
                    interfaces = f_10085_8402_8436(t)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 8455, 8518);

                    f_10085_8455_8517(0 <= interfaces.Length && (DynAbs.Tracing.TraceSender.Expression_True(10085, 8468, 8516) && interfaces.Length <= 2));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 8538, 9256) || true) && (interfaces.Length == 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10085, 8538, 9256);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 8606, 8653);

                        f_10085_8606_8652(interfaces[0] is NamedTypeSymbol);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 8687, 8775);

                        interfaces = f_10085_8700_8774(f_10085_8739_8773(this, interfaces[0]));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10085, 8538, 9256);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10085, 8538, 9256);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 8817, 9256) || true) && (interfaces.Length == 2)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10085, 8817, 9256);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 8885, 8932);

                            f_10085_8885_8931(interfaces[0] is NamedTypeSymbol);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 8966, 9090);

                            interfaces = f_10085_8979_9089(f_10085_9018_9052(this, interfaces[0]), f_10085_9054_9088(this, interfaces[1]));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10085, 8817, 9256);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10085, 8817, 9256);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 9132, 9256) || true) && (interfaces.Length != 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10085, 9132, 9256);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 9200, 9237);

                                throw f_10085_9206_9236();
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10085, 9132, 9256);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10085, 8817, 9256);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10085, 8538, 9256);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 9276, 9430);

                    return f_10085_9283_9429(element, f_10085_9365_9395(t), interfaces);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10085, 8308, 9445);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 9461, 9657);

                return f_10085_9468_9656(element, f_10085_9542_9548(t), f_10085_9567_9574(t), f_10085_9593_9606(t), f_10085_9625_9655(t));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10085, 7979, 9668);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10085_8083_8111(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.ElementTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10085, 8083, 8111);
                    return return_v;
                }


                bool
                f_10085_8312_8323(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsSZArray;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10085, 8312, 8323);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10085_8402_8436(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.InterfacesNoUseSiteDiagnostics();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 8402, 8436);
                    return return_v;
                }


                int
                f_10085_8455_8517(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 8455, 8517);
                    return 0;
                }


                int
                f_10085_8606_8652(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 8606, 8652);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10085_8739_8773(Microsoft.CodeAnalysis.CSharp.Symbols.AbstractTypeMap
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                previous)
                {
                    var return_v = this_param.SubstituteNamedType(previous);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 8739, 8773);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10085_8700_8774(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                item)
                {
                    var return_v = ImmutableArray.Create<NamedTypeSymbol>(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 8700, 8774);
                    return return_v;
                }


                int
                f_10085_8885_8931(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 8885, 8931);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10085_9018_9052(Microsoft.CodeAnalysis.CSharp.Symbols.AbstractTypeMap
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                previous)
                {
                    var return_v = this_param.SubstituteNamedType(previous);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 9018, 9052);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10085_9054_9088(Microsoft.CodeAnalysis.CSharp.Symbols.AbstractTypeMap
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                previous)
                {
                    var return_v = this_param.SubstituteNamedType(previous);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 9054, 9088);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10085_8979_9089(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                item1, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                item2)
                {
                    var return_v = ImmutableArray.Create<NamedTypeSymbol>(item1, item2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 8979, 9089);
                    return return_v;
                }


                System.Exception
                f_10085_9206_9236()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10085, 9206, 9236);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10085_9365_9395(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10085, 9365, 9395);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                f_10085_9283_9429(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                elementTypeWithAnnotations, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                array, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                constructedInterfaces)
                {
                    var return_v = ArrayTypeSymbol.CreateSZArray(elementTypeWithAnnotations, array, constructedInterfaces);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 9283, 9429);
                    return return_v;
                }


                int
                f_10085_9542_9548(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.Rank;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10085, 9542, 9548);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<int>
                f_10085_9567_9574(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.Sizes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10085, 9567, 9574);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<int>
                f_10085_9593_9606(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.LowerBounds;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10085, 9593, 9606);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10085_9625_9655(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10085, 9625, 9655);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                f_10085_9468_9656(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                elementTypeWithAnnotations, int
                rank, System.Collections.Immutable.ImmutableArray<int>
                sizes, System.Collections.Immutable.ImmutableArray<int>
                lowerBounds, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                array)
                {
                    var return_v = ArrayTypeSymbol.CreateMDArray(elementTypeWithAnnotations, rank, sizes, lowerBounds, array);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 9468, 9656);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10085, 7979, 9668);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10085, 7979, 9668);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private PointerTypeSymbol SubstitutePointerType(PointerTypeSymbol t)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10085, 9680, 10086);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 9773, 9827);

                var
                oldPointedAtType = f_10085_9796_9826(t)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 9841, 9899);

                var
                pointedAtType = oldPointedAtType.SubstituteType(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 9913, 10015) || true) && (pointedAtType.IsSameAs(oldPointedAtType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10085, 9913, 10015);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 9991, 10000);

                    return t;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10085, 9913, 10015);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 10031, 10075);

                return f_10085_10038_10074(pointedAtType);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10085, 9680, 10086);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10085_9796_9826(Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.PointedAtTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10085, 9796, 9826);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                f_10085_10038_10074(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                pointedAtType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol(pointedAtType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 10038, 10074);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10085, 9680, 10086);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10085, 9680, 10086);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private FunctionPointerTypeSymbol SubstituteFunctionPointerType(FunctionPointerTypeSymbol f)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10085, 10098, 12204);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 10215, 10302);

                var
                substitutedReturnType = f_10085_10243_10254(f).ReturnTypeWithAnnotations.SubstituteType(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 10316, 10372);

                var
                refCustomModifiers = f_10085_10341_10371(f_10085_10341_10352(f))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 10386, 10468);

                var
                substitutedRefCustomModifiers = f_10085_10422_10467(this, refCustomModifiers)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 10484, 10562);

                var
                parameterTypesWithAnnotations = f_10085_10520_10561(f_10085_10520_10531(f))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 10576, 10683);

                ImmutableArray<TypeWithAnnotations>
                substitutedParamTypes = f_10085_10636_10682(this, parameterTypesWithAnnotations)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 10699, 10782);

                ImmutableArray<ImmutableArray<CustomModifier>>
                substitutedParamModifiers = default
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 10798, 10845);

                var
                paramCount = f_10085_10815_10826(f).Parameters.Length
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 10859, 11705) || true) && (paramCount > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10085, 10859, 11705);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 10911, 10994);

                    var
                    builder = f_10085_10925_10993(paramCount)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 11012, 11039);

                    bool
                    didSubstitute = false
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 11057, 11438);
                        foreach (var param in f_10085_11079_11101_I(f_10085_11079_11101(f_10085_11079_11090(f))))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10085, 11057, 11438);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 11143, 11213);

                            var
                            substituted = f_10085_11161_11212(this, f_10085_11187_11211(param))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 11235, 11260);

                            f_10085_11235_11259(builder, substituted);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 11282, 11419) || true) && (substituted != f_10085_11301_11325(param))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10085, 11282, 11419);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 11375, 11396);

                                didSubstitute = true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10085, 11282, 11419);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10085, 11057, 11438);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10085, 1, 382);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10085, 1, 382);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 11458, 11690) || true) && (didSubstitute)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10085, 11458, 11690);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 11517, 11574);

                        substitutedParamModifiers = f_10085_11545_11573(builder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10085, 11458, 11690);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10085, 11458, 11690);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 11656, 11671);

                        f_10085_11656_11670(builder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10085, 11458, 11690);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10085, 10859, 11705);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 11721, 12168) || true) && (substitutedParamTypes != parameterTypesWithAnnotations
                || (DynAbs.Tracing.TraceSender.Expression_False(10085, 11725, 11836) || f_10085_11800_11836_M(!substitutedParamModifiers.IsDefault)) || (DynAbs.Tracing.TraceSender.Expression_False(10085, 11725, 11927) || !f_10085_11858_11869(f).ReturnTypeWithAnnotations.IsSameAs(substitutedReturnType)) || (DynAbs.Tracing.TraceSender.Expression_False(10085, 11725, 11999) || substitutedRefCustomModifiers != refCustomModifiers))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10085, 11721, 12168);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 12033, 12153);

                    f = f_10085_12037_12152(f, substitutedReturnType, substitutedParamTypes, refCustomModifiers, substitutedParamModifiers);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10085, 11721, 12168);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 12184, 12193);

                return f;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10085, 10098, 12204);

                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10085_10243_10254(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.Signature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10085, 10243, 10254);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10085_10341_10352(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.Signature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10085, 10341, 10352);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                f_10085_10341_10371(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.RefCustomModifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10085, 10341, 10371);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                f_10085_10422_10467(Microsoft.CodeAnalysis.CSharp.Symbols.AbstractTypeMap
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                customModifiers)
                {
                    var return_v = this_param.SubstituteCustomModifiers(customModifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 10422, 10467);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10085_10520_10531(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.Signature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10085, 10520, 10531);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10085_10520_10561(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterTypesWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10085, 10520, 10561);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10085_10636_10682(Microsoft.CodeAnalysis.CSharp.Symbols.AbstractTypeMap
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                original)
                {
                    var return_v = this_param.SubstituteTypes(original);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 10636, 10682);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10085_10815_10826(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.Signature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10085, 10815, 10826);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>>
                f_10085_10925_10993(int
                capacity)
                {
                    var return_v = ArrayBuilder<ImmutableArray<CustomModifier>>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 10925, 10993);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10085_11079_11090(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.Signature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10085, 11079, 11090);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10085_11079_11101(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10085, 11079, 11101);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                f_10085_11187_11211(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefCustomModifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10085, 11187, 11211);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                f_10085_11161_11212(Microsoft.CodeAnalysis.CSharp.Symbols.AbstractTypeMap
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                customModifiers)
                {
                    var return_v = this_param.SubstituteCustomModifiers(customModifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 11161, 11212);
                    return return_v;
                }


                int
                f_10085_11235_11259(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 11235, 11259);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                f_10085_11301_11325(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefCustomModifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10085, 11301, 11325);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10085_11079_11101_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 11079, 11101);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>>
                f_10085_11545_11573(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 11545, 11573);
                    return return_v;
                }


                int
                f_10085_11656_11670(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 11656, 11670);
                    return 0;
                }


                bool
                f_10085_11800_11836_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10085, 11800, 11836);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10085_11858_11869(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.Signature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10085, 11858, 11869);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                f_10085_12037_12152(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                substitutedReturnType, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                substitutedParameterTypes, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                refCustomModifiers, System.Collections.Immutable.ImmutableArray<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>>
                paramRefCustomModifiers)
                {
                    var return_v = this_param.SubstituteTypeSymbol(substitutedReturnType, substitutedParameterTypes, refCustomModifiers, paramRefCustomModifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 12037, 12152);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10085, 10098, 12204);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10085, 10098, 12204);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ImmutableArray<TypeSymbol> SubstituteTypesWithoutModifiers(ImmutableArray<TypeSymbol> original)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10085, 12216, 13286);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 12345, 12432) || true) && (original.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10085, 12345, 12432);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 12401, 12417);

                    return original;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10085, 12345, 12432);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 12448, 12475);

                TypeSymbol[]
                result = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 12500, 12505);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 12491, 13197) || true) && (i < original.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 12528, 12531)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10085, 12491, 13197))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10085, 12491, 13197);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 12565, 12585);

                        var
                        t = original[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 12603, 12644);

                        var
                        substituted = f_10085_12621_12638(this, t).Type
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 12662, 13059) || true) && (!f_10085_12667_12705(substituted, t))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10085, 12662, 13059);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 12747, 13040) || true) && (result == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10085, 12747, 13040);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 12815, 12856);

                                result = new TypeSymbol[original.Length];
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 12891, 12896);
                                    for (int
            j = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 12882, 13017) || true) && (j < i)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 12905, 12908)
            , j++, DynAbs.Tracing.TraceSender.TraceExitCondition(10085, 12882, 13017))

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10085, 12882, 13017);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 12966, 12990);

                                        result[j] = original[j];
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10085, 1, 136);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(10085, 1, 136);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10085, 12747, 13040);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10085, 12662, 13059);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 13079, 13182) || true) && (result != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10085, 13079, 13182);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 13139, 13163);

                            result[i] = substituted;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10085, 13079, 13182);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10085, 1, 707);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10085, 1, 707);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 13213, 13275);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10085, 13220, 13234) || ((result != null && DynAbs.Tracing.TraceSender.Conditional_F2(10085, 13237, 13263)) || DynAbs.Tracing.TraceSender.Conditional_F3(10085, 13266, 13274))) ? f_10085_13237_13263(result) : original;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10085, 12216, 13286);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10085_12621_12638(Microsoft.CodeAnalysis.CSharp.Symbols.AbstractTypeMap
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                previous)
                {
                    var return_v = this_param.SubstituteType(previous);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 12621, 12638);
                    return return_v;
                }


                bool
                f_10085_12667_12705(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                objB)
                {
                    var return_v = Object.ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 12667, 12705);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                f_10085_13237_13263(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol[]
                items)
                {
                    var return_v = items.AsImmutableOrNull<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 13237, 13263);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10085, 12216, 13286);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10085, 12216, 13286);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ImmutableArray<TypeWithAnnotations> SubstituteTypes(ImmutableArray<TypeWithAnnotations> original)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10085, 13298, 13843);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 13429, 13552) || true) && (original.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10085, 13429, 13552);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 13485, 13537);

                    return default(ImmutableArray<TypeWithAnnotations>);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10085, 13429, 13552);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 13568, 13644);

                var
                result = f_10085_13581_13643(original.Length)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 13660, 13781);
                    foreach (TypeWithAnnotations t in f_10085_13694_13702_I(original))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10085, 13660, 13781);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 13736, 13766);

                        f_10085_13736_13765(result, f_10085_13747_13764(this, t));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10085, 13660, 13781);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10085, 1, 122);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10085, 1, 122);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 13797, 13832);

                return f_10085_13804_13831(result);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10085, 13298, 13843);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10085_13581_13643(int
                capacity)
                {
                    var return_v = ArrayBuilder<TypeWithAnnotations>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 13581, 13643);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10085_13747_13764(Microsoft.CodeAnalysis.CSharp.Symbols.AbstractTypeMap
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                previous)
                {
                    var return_v = this_param.SubstituteType(previous);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 13747, 13764);
                    return return_v;
                }


                int
                f_10085_13736_13765(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 13736, 13765);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10085_13694_13702_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 13694, 13702);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10085_13804_13831(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 13804, 13831);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10085, 13298, 13843);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10085, 13298, 13843);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void SubstituteConstraintTypesDistinctWithoutModifiers(
                    TypeParameterSymbol owner,
                    ImmutableArray<TypeWithAnnotations> original,
                    ArrayBuilder<TypeWithAnnotations> result,
                    HashSet<TypeParameterSymbol> ignoreTypesDependentOnTypeParametersOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10085, 14106, 16540);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 14432, 14471);

                DynamicTypeEraser
                dynamicEraser = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 14487, 15982) || true) && (original.Length == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10085, 14487, 15982);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 14545, 14552);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10085, 14487, 15982);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10085, 14487, 15982);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 14586, 15982) || true) && (original.Length == 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10085, 14586, 15982);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 14644, 14667);

                        var
                        type = original[0]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 14685, 14939) || true) && (ignoreTypesDependentOnTypeParametersOpt == null || (DynAbs.Tracing.TraceSender.Expression_False(10085, 14689, 14835) || !f_10085_14762_14835(type.Type, ignoreTypesDependentOnTypeParametersOpt)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10085, 14685, 14939);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 14877, 14920);

                            f_10085_14877_14919(result, f_10085_14888_14918(type));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10085, 14685, 14939);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10085, 14586, 15982);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10085, 14586, 15982);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 15005, 15063);

                        var
                        map = f_10085_15015_15062()
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 15081, 15936);
                            foreach (var type in f_10085_15102_15110_I(original))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10085, 15081, 15936);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 15152, 15917) || true) && (ignoreTypesDependentOnTypeParametersOpt == null || (DynAbs.Tracing.TraceSender.Expression_False(10085, 15156, 15306) || !f_10085_15233_15306(type.Type, ignoreTypesDependentOnTypeParametersOpt)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10085, 15152, 15917);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 15356, 15405);

                                    var
                                    substituted = f_10085_15374_15404(type)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 15433, 15894) || true) && (!f_10085_15438_15490(map, substituted.Type, out var mergeWith))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10085, 15433, 15894);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 15548, 15588);

                                        f_10085_15548_15587(map, substituted.Type, f_10085_15574_15586(result));
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 15618, 15642);

                                        f_10085_15618_15641(result, substituted);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10085, 15433, 15894);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10085, 15433, 15894);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 15756, 15867);

                                        result[mergeWith] = f_10085_15776_15866(f_10085_15835_15852(result, mergeWith), substituted);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10085, 15433, 15894);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10085, 15152, 15917);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10085, 15081, 15936);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10085, 1, 856);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10085, 1, 856);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 15956, 15967);

                        f_10085_15956_15966(
                                        map);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10085, 14586, 15982);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10085, 14487, 15982);
                }

                TypeWithAnnotations substituteConstraintType(TypeWithAnnotations type)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10085, 15998, 16529);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 16101, 16304) || true) && (dynamicEraser == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10085, 16101, 16304);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 16168, 16285);

                            dynamicEraser = f_10085_16184_16284(f_10085_16206_16283(f_10085_16206_16241(f_10085_16206_16230(owner)), SpecialType.System_Object));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10085, 16101, 16304);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 16324, 16379);

                        TypeWithAnnotations
                        substituted = f_10085_16358_16378(this, type)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 16399, 16514);

                        return substituted.WithTypeAndModifiers(f_10085_16439_16483(dynamicEraser, substituted.Type), substituted.CustomModifiers);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10085, 15998, 16529);

                        Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                        f_10085_16206_16230(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                        this_param)
                        {
                            var return_v = this_param.ContainingAssembly;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10085, 16206, 16230);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                        f_10085_16206_16241(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                        this_param)
                        {
                            var return_v = this_param.CorLibrary;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10085, 16206, 16241);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        f_10085_16206_16283(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                        this_param, Microsoft.CodeAnalysis.SpecialType
                        type)
                        {
                            var return_v = this_param.GetSpecialType(type);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 16206, 16283);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.DynamicTypeEraser
                        f_10085_16184_16284(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        objectType)
                        {
                            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.DynamicTypeEraser((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)objectType);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 16184, 16284);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                        f_10085_16358_16378(Microsoft.CodeAnalysis.CSharp.Symbols.AbstractTypeMap
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                        previous)
                        {
                            var return_v = this_param.SubstituteType(previous);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 16358, 16378);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        f_10085_16439_16483(Microsoft.CodeAnalysis.CSharp.Symbols.DynamicTypeEraser
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        type)
                        {
                            var return_v = this_param.EraseDynamic(type);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 16439, 16483);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10085, 15998, 16529);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10085, 15998, 16529);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10085, 14106, 16540);

                bool
                f_10085_14762_14835(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                parameters)
                {
                    var return_v = type.ContainsTypeParameters(parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 14762, 14835);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10085_14888_14918(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type)
                {
                    var return_v = substituteConstraintType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 14888, 14918);
                    return return_v;
                }


                int
                f_10085_14877_14919(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 14877, 14919);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol, int>
                f_10085_15015_15062()
                {
                    var return_v = PooledDictionary<TypeSymbol, int>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 15015, 15062);
                    return return_v;
                }


                bool
                f_10085_15233_15306(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                parameters)
                {
                    var return_v = type.ContainsTypeParameters(parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 15233, 15306);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10085_15374_15404(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type)
                {
                    var return_v = substituteConstraintType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 15374, 15404);
                    return return_v;
                }


                bool
                f_10085_15438_15490(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol, int>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                key, out int
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 15438, 15490);
                    return return_v;
                }


                int
                f_10085_15574_15586(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10085, 15574, 15586);
                    return return_v;
                }


                int
                f_10085_15548_15587(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol, int>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                key, int
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 15548, 15587);
                    return 0;
                }


                int
                f_10085_15618_15641(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 15618, 15641);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10085_15835_15852(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10085, 15835, 15852);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10085_15776_15866(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type2)
                {
                    var return_v = ConstraintsHelper.ConstraintWithMostSignificantNullability(type1, type2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 15776, 15866);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10085_15102_15110_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 15102, 15110);
                    return return_v;
                }


                int
                f_10085_15956_15966(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol, int>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 15956, 15966);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10085, 14106, 16540);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10085, 14106, 16540);
            }
        }

        internal ImmutableArray<TypeParameterSymbol> SubstituteTypeParameters(ImmutableArray<TypeParameterSymbol> original)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10085, 16552, 16821);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 16692, 16810);

                return original.SelectAsArray((tp, m) => (TypeParameterSymbol)m.SubstituteTypeParameter(tp).AsTypeSymbolOnly(), this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10085, 16552, 16821);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10085, 16552, 16821);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10085, 16552, 16821);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ImmutableArray<NamedTypeSymbol> SubstituteNamedTypes(ImmutableArray<NamedTypeSymbol> original)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10085, 16936, 17912);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 17064, 17096);

                NamedTypeSymbol[]
                result = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 17121, 17126);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 17112, 17823) || true) && (i < original.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 17149, 17152)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10085, 17112, 17823))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10085, 17112, 17823);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 17186, 17206);

                        var
                        t = original[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 17224, 17265);

                        var
                        substituted = f_10085_17242_17264(this, t)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 17283, 17685) || true) && (!f_10085_17288_17326(substituted, t))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10085, 17283, 17685);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 17368, 17666) || true) && (result == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10085, 17368, 17666);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 17436, 17482);

                                result = new NamedTypeSymbol[original.Length];
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 17517, 17522);
                                    for (int
            j = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 17508, 17643) || true) && (j < i)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 17531, 17534)
            , j++, DynAbs.Tracing.TraceSender.TraceExitCondition(10085, 17508, 17643))

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10085, 17508, 17643);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 17592, 17616);

                                        result[j] = original[j];
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10085, 1, 136);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(10085, 1, 136);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10085, 17368, 17666);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10085, 17283, 17685);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 17705, 17808) || true) && (result != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10085, 17705, 17808);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 17765, 17789);

                            result[i] = substituted;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10085, 17705, 17808);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10085, 1, 712);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10085, 1, 712);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10085, 17839, 17901);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10085, 17846, 17860) || ((result != null && DynAbs.Tracing.TraceSender.Conditional_F2(10085, 17863, 17889)) || DynAbs.Tracing.TraceSender.Conditional_F3(10085, 17892, 17900))) ? f_10085_17863_17889(result) : original;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10085, 16936, 17912);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10085_17242_17264(Microsoft.CodeAnalysis.CSharp.Symbols.AbstractTypeMap
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                previous)
                {
                    var return_v = this_param.SubstituteNamedType(previous);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 17242, 17264);
                    return return_v;
                }


                bool
                f_10085_17288_17326(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                objB)
                {
                    var return_v = Object.ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 17288, 17326);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10085_17863_17889(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol[]
                items)
                {
                    var return_v = items.AsImmutableOrNull<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10085, 17863, 17889);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10085, 16936, 17912);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10085, 16936, 17912);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public AbstractTypeMap()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(10085, 576, 17919);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(10085, 576, 17919);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10085, 576, 17919);
        }


        static AbstractTypeMap()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10085, 576, 17919);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10085, 576, 17919);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10085, 576, 17919);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10085, 576, 17919);
    }
}
