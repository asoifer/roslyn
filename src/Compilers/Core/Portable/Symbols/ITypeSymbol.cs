// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.CodeAnalysis
{
    /// <summary>
    /// Represents a type.
    /// </summary>
    /// <remarks>
    /// This interface is reserved for implementation by its associated APIs. We reserve the right to
    /// change it in the future.
    /// </remarks>
    public interface ITypeSymbol : INamespaceOrTypeSymbol
    {

        TypeKind TypeKind { get; }

        INamedTypeSymbol? BaseType { get; }

        ImmutableArray<INamedTypeSymbol> Interfaces { get; }

        ImmutableArray<INamedTypeSymbol> AllInterfaces { get; }

        bool IsReferenceType { get; }

        bool IsValueType { get; }

        bool IsAnonymousType { get; }

        bool IsTupleType { get; }

        bool IsNativeIntegerType { get; }

        new ITypeSymbol OriginalDefinition { get; }

        SpecialType SpecialType { get; }

        ISymbol? FindImplementationForInterfaceMember(ISymbol interfaceMember);

        bool IsRefLikeType { get; }

        bool IsUnmanagedType { get; }

        bool IsReadOnly { get; }

        bool IsRecord { get; }

        string ToDisplayString(NullableFlowState topLevelNullability, SymbolDisplayFormat? format = null);

        ImmutableArray<SymbolDisplayPart> ToDisplayParts(NullableFlowState topLevelNullability, SymbolDisplayFormat? format = null);

        string ToMinimalDisplayString(
                    SemanticModel semanticModel,
                    NullableFlowState topLevelNullability,
                    int position,
                    SymbolDisplayFormat? format = null);

        ImmutableArray<SymbolDisplayPart> ToMinimalDisplayParts(
                    SemanticModel semanticModel,
                    NullableFlowState topLevelNullability,
                    int position,
                    SymbolDisplayFormat? format = null);

        NullableAnnotation NullableAnnotation { get; }

        ITypeSymbol WithNullableAnnotation(NullableAnnotation nullableAnnotation);
    }
    internal static class ITypeSymbolHelpers
    {
        internal static bool IsNullableType([NotNullWhen(returnValue: true)] ITypeSymbol? typeOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(630, 10020, 10267);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(630, 10158, 10256);

                return typeOpt != null && (DynAbs.Tracing.TraceSender.Expression_True(630, 10165, 10255) && f_630_10184_10222(f_630_10184_10210(typeOpt)) == SpecialType.System_Nullable_T);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(630, 10020, 10267);

                Microsoft.CodeAnalysis.ITypeSymbol
                f_630_10184_10210(Microsoft.CodeAnalysis.ITypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(630, 10184, 10210);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_630_10184_10222(Microsoft.CodeAnalysis.ITypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(630, 10184, 10222);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(630, 10020, 10267);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(630, 10020, 10267);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsNullableOfBoolean([NotNullWhen(returnValue: true)] ITypeSymbol? type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(630, 10279, 10485);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(630, 10396, 10474);

                return f_630_10403_10423(type) && (DynAbs.Tracing.TraceSender.Expression_True(630, 10403, 10473) && f_630_10427_10473(f_630_10441_10472(type)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(630, 10279, 10485);

                bool
                f_630_10403_10423(Microsoft.CodeAnalysis.ITypeSymbol?
                typeOpt)
                {
                    var return_v = IsNullableType(typeOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(630, 10403, 10423);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol
                f_630_10441_10472(Microsoft.CodeAnalysis.ITypeSymbol
                type)
                {
                    var return_v = GetNullableUnderlyingType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(630, 10441, 10472);
                    return return_v;
                }


                bool
                f_630_10427_10473(Microsoft.CodeAnalysis.ITypeSymbol
                type)
                {
                    var return_v = IsBooleanType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(630, 10427, 10473);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(630, 10279, 10485);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(630, 10279, 10485);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ITypeSymbol GetNullableUnderlyingType(ITypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(630, 10497, 10702);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(630, 10593, 10628);

                f_630_10593_10627(f_630_10606_10626(type));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(630, 10642, 10691);

                return f_630_10649_10687(((INamedTypeSymbol)type))[0];
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(630, 10497, 10702);

                bool
                f_630_10606_10626(Microsoft.CodeAnalysis.ITypeSymbol
                typeOpt)
                {
                    var return_v = IsNullableType(typeOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(630, 10606, 10626);
                    return return_v;
                }


                int
                f_630_10593_10627(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(630, 10593, 10627);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ITypeSymbol>
                f_630_10649_10687(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(630, 10649, 10687);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(630, 10497, 10702);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(630, 10497, 10702);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsBooleanType([NotNullWhen(returnValue: true)] ITypeSymbol? type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(630, 10714, 10891);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(630, 10825, 10880);

                return f_630_10832_10849_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(type, 630, 10832, 10849)?.SpecialType) == SpecialType.System_Boolean;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(630, 10714, 10891);

                Microsoft.CodeAnalysis.SpecialType?
                f_630_10832_10849_M(Microsoft.CodeAnalysis.SpecialType?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(630, 10832, 10849);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(630, 10714, 10891);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(630, 10714, 10891);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsObjectType([NotNullWhen(returnValue: true)] ITypeSymbol? type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(630, 10903, 11078);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(630, 11013, 11067);

                return f_630_11020_11037_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(type, 630, 11020, 11037)?.SpecialType) == SpecialType.System_Object;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(630, 10903, 11078);

                Microsoft.CodeAnalysis.SpecialType?
                f_630_11020_11037_M(Microsoft.CodeAnalysis.SpecialType?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(630, 11020, 11037);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(630, 10903, 11078);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(630, 10903, 11078);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsSignedIntegralType([NotNullWhen(returnValue: true)] ITypeSymbol? type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(630, 11090, 11313);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(630, 11231, 11302);

                return type != null && (DynAbs.Tracing.TraceSender.Expression_True(630, 11238, 11301) && f_630_11254_11293(f_630_11254_11270(type)) == true);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(630, 11090, 11313);

                Microsoft.CodeAnalysis.SpecialType
                f_630_11254_11270(Microsoft.CodeAnalysis.ITypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(630, 11254, 11270);
                    return return_v;
                }


                bool
                f_630_11254_11293(Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = specialType.IsSignedIntegralType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(630, 11254, 11293);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(630, 11090, 11313);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(630, 11090, 11313);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsUnsignedIntegralType([NotNullWhen(returnValue: true)] ITypeSymbol? type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(630, 11325, 11552);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(630, 11468, 11541);

                return type != null && (DynAbs.Tracing.TraceSender.Expression_True(630, 11475, 11540) && f_630_11491_11532(f_630_11491_11507(type)) == true);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(630, 11325, 11552);

                Microsoft.CodeAnalysis.SpecialType
                f_630_11491_11507(Microsoft.CodeAnalysis.ITypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(630, 11491, 11507);
                    return return_v;
                }


                bool
                f_630_11491_11532(Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = specialType.IsUnsignedIntegralType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(630, 11491, 11532);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(630, 11325, 11552);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(630, 11325, 11552);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsNumericType([NotNullWhen(returnValue: true)] ITypeSymbol? type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(630, 11564, 11773);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(630, 11698, 11762);

                return type != null && (DynAbs.Tracing.TraceSender.Expression_True(630, 11705, 11761) && f_630_11721_11753(f_630_11721_11737(type)) == true);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(630, 11564, 11773);

                Microsoft.CodeAnalysis.SpecialType
                f_630_11721_11737(Microsoft.CodeAnalysis.ITypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(630, 11721, 11737);
                    return return_v;
                }


                bool
                f_630_11721_11753(Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = specialType.IsNumericType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(630, 11721, 11753);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(630, 11564, 11773);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(630, 11564, 11773);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ITypeSymbol? GetEnumUnderlyingType(ITypeSymbol? type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(630, 11785, 12000);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(630, 11902, 11989);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(630, 11909, 11935) || (((type is INamedTypeSymbol) && DynAbs.Tracing.TraceSender.Conditional_F2(630, 11938, 11981)) || DynAbs.Tracing.TraceSender.Conditional_F3(630, 11984, 11988))) ? f_630_11938_11981(((INamedTypeSymbol)type)) : null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(630, 11785, 12000);

                Microsoft.CodeAnalysis.INamedTypeSymbol?
                f_630_11938_11981(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.EnumUnderlyingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(630, 11938, 11981);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(630, 11785, 12000);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(630, 11785, 12000);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [return: NotNullIfNotNull(parameterName: "type")]
        internal static ITypeSymbol? GetEnumUnderlyingTypeOrSelf(ITypeSymbol? type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(630, 12012, 12225);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(630, 12171, 12214);

                return f_630_12178_12205(type) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.ITypeSymbol?>(630, 12178, 12213) ?? type);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(630, 12012, 12225);

                Microsoft.CodeAnalysis.ITypeSymbol?
                f_630_12178_12205(Microsoft.CodeAnalysis.ITypeSymbol?
                type)
                {
                    var return_v = GetEnumUnderlyingType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(630, 12178, 12205);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(630, 12012, 12225);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(630, 12012, 12225);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsDynamicType([NotNullWhen(returnValue: true)] ITypeSymbol? type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(630, 12237, 12403);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(630, 12348, 12392);

                return f_630_12355_12365_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(type, 630, 12355, 12365)?.Kind) == SymbolKind.DynamicType;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(630, 12237, 12403);

                Microsoft.CodeAnalysis.SymbolKind?
                f_630_12355_12365_M(Microsoft.CodeAnalysis.SymbolKind?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(630, 12355, 12365);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(630, 12237, 12403);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(630, 12237, 12403);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ITypeSymbolHelpers()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(630, 9963, 12410);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(630, 9963, 12410);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(630, 9963, 12410);
        }

    }
}
