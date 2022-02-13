// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection.Metadata;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.Emit;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Emit
{
    internal abstract class NamedTypeReference : Cci.INamedTypeReference
    {
        protected readonly NamedTypeSymbol UnderlyingNamedType;

        public NamedTypeReference(NamedTypeSymbol underlyingNamedType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10197, 640, 851);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10197, 608, 627);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10197, 727, 777);

                f_10197_727_776((object)underlyingNamedType != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10197, 793, 840);

                this.UnderlyingNamedType = underlyingNamedType;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10197, 640, 851);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10197, 640, 851);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10197, 640, 851);
            }
        }

        ushort Cci.INamedTypeReference.GenericParameterCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10197, 940, 1032);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10197, 976, 1017);

                    return (ushort)f_10197_991_1016(UnderlyingNamedType);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10197, 940, 1032);

                    int
                    f_10197_991_1016(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Arity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10197, 991, 1016);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10197, 863, 1043);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10197, 863, 1043);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool Cci.INamedTypeReference.MangleName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10197, 1119, 1208);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10197, 1155, 1193);

                    return f_10197_1162_1192(UnderlyingNamedType);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10197, 1119, 1208);

                    bool
                    f_10197_1162_1192(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.MangleName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10197, 1162, 1192);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10197, 1055, 1219);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10197, 1055, 1219);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        string Cci.INamedEntity.Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10197, 1284, 1375);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10197, 1320, 1360);

                    return f_10197_1327_1359(UnderlyingNamedType);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10197, 1284, 1375);

                    string
                    f_10197_1327_1359(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.MetadataName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10197, 1327, 1359);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10197, 1231, 1386);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10197, 1231, 1386);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool Cci.ITypeReference.IsEnum
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10197, 1453, 1544);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10197, 1489, 1529);

                    return f_10197_1496_1528(UnderlyingNamedType);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10197, 1453, 1544);

                    bool
                    f_10197_1496_1528(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    type)
                    {
                        var return_v = type.IsEnumType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10197, 1496, 1528);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10197, 1398, 1555);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10197, 1398, 1555);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool Cci.ITypeReference.IsValueType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10197, 1627, 1717);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10197, 1663, 1702);

                    return f_10197_1670_1701(UnderlyingNamedType);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10197, 1627, 1717);

                    bool
                    f_10197_1670_1701(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsValueType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10197, 1670, 1701);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10197, 1567, 1728);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10197, 1567, 1728);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.ITypeDefinition Cci.ITypeReference.GetResolvedType(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10197, 1740, 1863);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10197, 1840, 1852);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10197, 1740, 1863);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10197, 1740, 1863);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10197, 1740, 1863);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        Cci.PrimitiveTypeCode Cci.ITypeReference.TypeCode
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10197, 1949, 2042);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10197, 1985, 2027);

                    return Cci.PrimitiveTypeCode.NotPrimitive;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10197, 1949, 2042);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10197, 1875, 2053);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10197, 1875, 2053);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        TypeDefinitionHandle Cci.ITypeReference.TypeDef
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10197, 2137, 2225);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10197, 2173, 2210);

                    return default(TypeDefinitionHandle);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10197, 2137, 2225);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10197, 2065, 2236);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10197, 2065, 2236);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.IGenericMethodParameterReference Cci.ITypeReference.AsGenericMethodParameterReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10197, 2362, 2425);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10197, 2398, 2410);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10197, 2362, 2425);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10197, 2248, 2436);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10197, 2248, 2436);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public abstract Cci.IGenericTypeInstanceReference AsGenericTypeInstanceReference
        {
            get;
        }

        Cci.IGenericTypeParameterReference Cci.ITypeReference.AsGenericTypeParameterReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10197, 2690, 2753);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10197, 2726, 2738);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10197, 2690, 2753);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10197, 2580, 2764);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10197, 2580, 2764);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.INamespaceTypeDefinition Cci.ITypeReference.AsNamespaceTypeDefinition(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10197, 2776, 2918);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10197, 2895, 2907);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10197, 2776, 2918);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10197, 2776, 2918);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10197, 2776, 2918);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public abstract Cci.INamespaceTypeReference AsNamespaceTypeReference
        {
            get;
        }

        Cci.INestedTypeDefinition Cci.ITypeReference.AsNestedTypeDefinition(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10197, 3050, 3186);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10197, 3163, 3175);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10197, 3050, 3186);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10197, 3050, 3186);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10197, 3050, 3186);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public abstract Cci.INestedTypeReference AsNestedTypeReference
        {
            get;
        }

        public abstract Cci.ISpecializedNestedTypeReference AsSpecializedNestedTypeReference
        {
            get;
        }

        Cci.ITypeDefinition Cci.ITypeReference.AsTypeDefinition(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10197, 3448, 3572);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10197, 3549, 3561);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10197, 3448, 3572);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10197, 3448, 3572);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10197, 3448, 3572);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10197, 3584, 3739);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10197, 3642, 3728);

                return f_10197_3649_3727(UnderlyingNamedType, SymbolDisplayFormat.ILVisualizationFormat);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10197, 3584, 3739);

                string
                f_10197_3649_3727(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.SymbolDisplayFormat
                format)
                {
                    var return_v = this_param.ToDisplayString(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10197, 3649, 3727);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10197, 3584, 3739);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10197, 3584, 3739);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        IEnumerable<Cci.ICustomAttribute> Cci.IReference.GetAttributes(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10197, 3751, 3940);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10197, 3859, 3929);

                return f_10197_3866_3928();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10197, 3751, 3940);

                System.Collections.Generic.IEnumerable<Microsoft.Cci.ICustomAttribute>
                f_10197_3866_3928()
                {
                    var return_v = SpecializedCollections.EmptyEnumerable<Cci.ICustomAttribute>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10197, 3866, 3928);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10197, 3751, 3940);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10197, 3751, 3940);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public abstract void Dispatch(Cci.MetadataVisitor visitor);

        Cci.IDefinition Cci.IReference.AsDefinition(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10197, 4023, 4135);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10197, 4112, 4124);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10197, 4023, 4135);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10197, 4023, 4135);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10197, 4023, 4135);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        CodeAnalysis.Symbols.ISymbolInternal Cci.IReference.GetInternalSymbol()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10197, 4219, 4241);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10197, 4222, 4241);
                return UnderlyingNamedType; DynAbs.Tracing.TraceSender.TraceExitMethod(10197, 4219, 4241);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10197, 4219, 4241);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10197, 4219, 4241);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override bool Equals(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10197, 4254, 4533);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10197, 4468, 4522);

                throw f_10197_4474_4521();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10197, 4254, 4533);

                System.Exception
                f_10197_4474_4521()
                {
                    var return_v = Roslyn.Utilities.ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10197, 4474, 4521);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10197, 4254, 4533);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10197, 4254, 4533);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10197, 4545, 4818);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10197, 4753, 4807);

                throw f_10197_4759_4806();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10197, 4545, 4818);

                System.Exception
                f_10197_4759_4806()
                {
                    var return_v = Roslyn.Utilities.ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10197, 4759, 4806);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10197, 4545, 4818);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10197, 4545, 4818);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static NamedTypeReference()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10197, 488, 4825);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10197, 488, 4825);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10197, 488, 4825);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10197, 488, 4825);

        int
        f_10197_727_776(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10197, 727, 776);
            return 0;
        }

    }
}
