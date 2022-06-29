// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Reflection;
using System.Reflection.Metadata;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.Emit
{
    internal class ErrorType : Cci.INamespaceTypeReference
    {
        public static readonly ErrorType Singleton;

        private static readonly string s_name;

        Cci.IUnitReference Cci.INamespaceTypeReference.GetUnit(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(292, 988, 1130);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(292, 1088, 1119);

                return ErrorAssembly.Singleton;
                DynAbs.Tracing.TraceSender.TraceExitMethod(292, 988, 1130);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(292, 988, 1130);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(292, 988, 1130);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        string Cci.INamespaceTypeReference.NamespaceName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(292, 1215, 1276);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(292, 1251, 1261);

                    return "";
                    DynAbs.Tracing.TraceSender.TraceExitMethod(292, 1215, 1276);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(292, 1142, 1287);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(292, 1142, 1287);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ushort Cci.INamedTypeReference.GenericParameterCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(292, 1376, 1436);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(292, 1412, 1421);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(292, 1376, 1436);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(292, 1299, 1447);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(292, 1299, 1447);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(292, 1523, 1587);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(292, 1559, 1572);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(292, 1523, 1587);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(292, 1459, 1598);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(292, 1459, 1598);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(292, 1665, 1729);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(292, 1701, 1714);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(292, 1665, 1729);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(292, 1610, 1740);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(292, 1610, 1740);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(292, 1812, 1876);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(292, 1848, 1861);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(292, 1812, 1876);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(292, 1752, 1887);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(292, 1752, 1887);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.ITypeDefinition Cci.ITypeReference.GetResolvedType(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(292, 1899, 2022);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(292, 1999, 2011);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(292, 1899, 2022);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(292, 1899, 2022);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(292, 1899, 2022);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        Cci.PrimitiveTypeCode Cci.ITypeReference.TypeCode
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(292, 2108, 2201);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(292, 2144, 2186);

                    return Cci.PrimitiveTypeCode.NotPrimitive;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(292, 2108, 2201);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(292, 2034, 2212);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(292, 2034, 2212);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(292, 2296, 2384);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(292, 2332, 2369);

                    return default(TypeDefinitionHandle);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(292, 2296, 2384);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(292, 2224, 2395);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(292, 2224, 2395);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(292, 2521, 2584);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(292, 2557, 2569);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(292, 2521, 2584);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(292, 2407, 2595);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(292, 2407, 2595);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.IGenericTypeInstanceReference Cci.ITypeReference.AsGenericTypeInstanceReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(292, 2715, 2778);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(292, 2751, 2763);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(292, 2715, 2778);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(292, 2607, 2789);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(292, 2607, 2789);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.IGenericTypeParameterReference Cci.ITypeReference.AsGenericTypeParameterReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(292, 2911, 2974);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(292, 2947, 2959);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(292, 2911, 2974);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(292, 2801, 2985);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(292, 2801, 2985);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.INamespaceTypeDefinition Cci.ITypeReference.AsNamespaceTypeDefinition(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(292, 2997, 3139);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(292, 3116, 3128);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(292, 2997, 3139);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(292, 2997, 3139);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(292, 2997, 3139);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        Cci.INamespaceTypeReference Cci.ITypeReference.AsNamespaceTypeReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(292, 3247, 3310);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(292, 3283, 3295);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(292, 3247, 3310);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(292, 3151, 3321);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(292, 3151, 3321);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.INestedTypeDefinition Cci.ITypeReference.AsNestedTypeDefinition(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(292, 3333, 3469);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(292, 3446, 3458);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(292, 3333, 3469);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(292, 3333, 3469);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(292, 3333, 3469);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        Cci.INestedTypeReference Cci.ITypeReference.AsNestedTypeReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(292, 3571, 3634);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(292, 3607, 3619);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(292, 3571, 3634);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(292, 3481, 3645);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(292, 3481, 3645);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.ISpecializedNestedTypeReference Cci.ITypeReference.AsSpecializedNestedTypeReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(292, 3769, 3832);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(292, 3805, 3817);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(292, 3769, 3832);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(292, 3657, 3843);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(292, 3657, 3843);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.ITypeDefinition Cci.ITypeReference.AsTypeDefinition(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(292, 3855, 3979);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(292, 3956, 3968);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(292, 3855, 3979);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(292, 3855, 3979);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(292, 3855, 3979);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        IEnumerable<Cci.ICustomAttribute> Cci.IReference.GetAttributes(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(292, 3991, 4180);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(292, 4099, 4169);

                return f_292_4106_4168();
                DynAbs.Tracing.TraceSender.TraceExitMethod(292, 3991, 4180);

                System.Collections.Generic.IEnumerable<Microsoft.Cci.ICustomAttribute>
                f_292_4106_4168()
                {
                    var return_v = SpecializedCollections.EmptyEnumerable<Cci.ICustomAttribute>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(292, 4106, 4168);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(292, 3991, 4180);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(292, 3991, 4180);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        void Cci.IReference.Dispatch(Cci.MetadataVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(292, 4192, 4334);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(292, 4274, 4323);

                f_292_4274_4322(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(292, 4192, 4334);

                int
                f_292_4274_4322(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.CodeAnalysis.Emit.ErrorType
                namespaceTypeReference)
                {
                    this_param.Visit((Microsoft.Cci.INamespaceTypeReference)namespaceTypeReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(292, 4274, 4322);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(292, 4192, 4334);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(292, 4192, 4334);
            }
        }

        Cci.IDefinition Cci.IReference.AsDefinition(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(292, 4346, 4458);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(292, 4435, 4447);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(292, 4346, 4458);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(292, 4346, 4458);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(292, 4346, 4458);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        Symbols.ISymbolInternal Cci.IReference.GetInternalSymbol()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(292, 4529, 4536);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(292, 4532, 4536);
                return null; DynAbs.Tracing.TraceSender.TraceExitMethod(292, 4529, 4536);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(292, 4529, 4536);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(292, 4529, 4536);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        string Cci.INamedEntity.Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(292, 4602, 4667);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(292, 4638, 4652);

                    return s_name;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(292, 4602, 4667);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(292, 4549, 4678);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(292, 4549, 4678);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool Equals(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(292, 4690, 4969);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(292, 4904, 4958);

                throw f_292_4910_4957();
                DynAbs.Tracing.TraceSender.TraceExitMethod(292, 4690, 4969);

                System.Exception
                f_292_4910_4957()
                {
                    var return_v = Roslyn.Utilities.ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(292, 4910, 4957);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(292, 4690, 4969);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(292, 4690, 4969);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(292, 4981, 5254);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(292, 5189, 5243);

                throw f_292_5195_5242();
                DynAbs.Tracing.TraceSender.TraceExitMethod(292, 4981, 5254);

                System.Exception
                f_292_5195_5242()
                {
                    var return_v = Roslyn.Utilities.ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(292, 5195, 5242);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(292, 4981, 5254);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(292, 4981, 5254);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private sealed class ErrorAssembly : Cci.IAssemblyReference
        {
            public static readonly ErrorAssembly Singleton;

            private static readonly AssemblyIdentity s_identity;

            AssemblyIdentity Cci.IAssemblyReference.Identity
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(292, 6196, 6209);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(292, 6199, 6209);
                        return s_identity; DynAbs.Tracing.TraceSender.TraceExitMethod(292, 6196, 6209);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(292, 6196, 6209);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(292, 6196, 6209);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            Version Cci.IAssemblyReference.AssemblyVersionPattern
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(292, 6278, 6285);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(292, 6281, 6285);
                        return null; DynAbs.Tracing.TraceSender.TraceExitMethod(292, 6278, 6285);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(292, 6278, 6285);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(292, 6278, 6285);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            Cci.IAssemblyReference Cci.IModuleReference.GetContainingAssembly(EmitContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(292, 6302, 6448);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(292, 6421, 6433);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(292, 6302, 6448);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(292, 6302, 6448);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(292, 6302, 6448);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            IEnumerable<Cci.ICustomAttribute> Cci.IReference.GetAttributes(EmitContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(292, 6464, 6665);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(292, 6580, 6650);

                    return f_292_6587_6649();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(292, 6464, 6665);

                    System.Collections.Generic.IEnumerable<Microsoft.Cci.ICustomAttribute>
                    f_292_6587_6649()
                    {
                        var return_v = SpecializedCollections.EmptyEnumerable<Cci.ICustomAttribute>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(292, 6587, 6649);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(292, 6464, 6665);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(292, 6464, 6665);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            void Cci.IReference.Dispatch(Cci.MetadataVisitor visitor)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(292, 6681, 6830);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(292, 6771, 6815);

                    f_292_6771_6814(visitor, this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(292, 6681, 6830);

                    int
                    f_292_6771_6814(Microsoft.Cci.MetadataVisitor
                    this_param, Microsoft.CodeAnalysis.Emit.ErrorType.ErrorAssembly
                    assemblyReference)
                    {
                        this_param.Visit((Microsoft.Cci.IAssemblyReference)assemblyReference);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(292, 6771, 6814);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(292, 6681, 6830);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(292, 6681, 6830);
                }
            }

            Cci.IDefinition Cci.IReference.AsDefinition(EmitContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(292, 6846, 6970);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(292, 6943, 6955);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(292, 6846, 6970);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(292, 6846, 6970);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(292, 6846, 6970);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            Symbols.ISymbolInternal Cci.IReference.GetInternalSymbol()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(292, 7045, 7052);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(292, 7048, 7052);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(292, 7045, 7052);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(292, 7045, 7052);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(292, 7045, 7052);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            string Cci.INamedEntity.Name
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(292, 7098, 7116);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(292, 7101, 7116);
                        return f_292_7101_7116(s_identity); DynAbs.Tracing.TraceSender.TraceExitMethod(292, 7098, 7116);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(292, 7098, 7116);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(292, 7098, 7116);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public ErrorAssembly()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(292, 5378, 7128);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(292, 5378, 7128);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(292, 5378, 7128);
            }


            static ErrorAssembly()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(292, 5378, 7128);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(292, 5499, 5530);
                Singleton = f_292_5511_5530(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(292, 5743, 6130);
                s_identity = f_292_5756_6130(name: "Error" + Guid.NewGuid().ToString("B"), version: AssemblyIdentity.NullVersion, cultureName: "", publicKeyOrToken: ImmutableArray<byte>.Empty, hasPublicKey: false, isRetargetable: false, contentType: AssemblyContentType.Default); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(292, 5378, 7128);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(292, 5378, 7128);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(292, 5378, 7128);

            static Microsoft.CodeAnalysis.Emit.ErrorType.ErrorAssembly
            f_292_5511_5530()
            {
                var return_v = new Microsoft.CodeAnalysis.Emit.ErrorType.ErrorAssembly();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(292, 5511, 5530);
                return return_v;
            }


            static Microsoft.CodeAnalysis.AssemblyIdentity
            f_292_5756_6130(string
            name, System.Version
            version, string
            cultureName, System.Collections.Immutable.ImmutableArray<byte>
            publicKeyOrToken, bool
            hasPublicKey, bool
            isRetargetable, System.Reflection.AssemblyContentType
            contentType)
            {
                var return_v = new Microsoft.CodeAnalysis.AssemblyIdentity(name: name, version: version, cultureName: cultureName, publicKeyOrToken: publicKeyOrToken, hasPublicKey: hasPublicKey, isRetargetable: isRetargetable, contentType: contentType);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(292, 5756, 6130);
                return return_v;
            }


            string
            f_292_7101_7116(Microsoft.CodeAnalysis.AssemblyIdentity
            this_param)
            {
                var return_v = this_param.Name;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(292, 7101, 7116);
                return return_v;
            }

        }

        public ErrorType()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(292, 610, 7135);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(292, 610, 7135);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(292, 610, 7135);
        }


        static ErrorType()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(292, 610, 7135);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(292, 714, 741);
            Singleton = f_292_726_741(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(292, 928, 975);
            s_name = "Error" + Guid.NewGuid().ToString("B"); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(292, 610, 7135);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(292, 610, 7135);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(292, 610, 7135);

        static Microsoft.CodeAnalysis.Emit.ErrorType
        f_292_726_741()
        {
            var return_v = new Microsoft.CodeAnalysis.Emit.ErrorType();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(292, 726, 741);
            return return_v;
        }

    }
}
