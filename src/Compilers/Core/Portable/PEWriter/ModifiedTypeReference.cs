// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Reflection.Metadata;
using Roslyn.Utilities;
using EmitContext = Microsoft.CodeAnalysis.Emit.EmitContext;

namespace Microsoft.Cci
{
    internal sealed class ModifiedTypeReference : IModifiedTypeReference
    {
        private readonly ITypeReference _modifiedType;

        private readonly ImmutableArray<ICustomModifier> _customModifiers;

        public ModifiedTypeReference(ITypeReference modifiedType, ImmutableArray<ICustomModifier> customModifiers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(504, 682, 1014);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(504, 580, 593);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(504, 813, 854);

                f_504_813_853(modifiedType != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(504, 868, 909);

                f_504_868_908(f_504_881_907_M(!customModifiers.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(504, 925, 954);

                _modifiedType = modifiedType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(504, 968, 1003);

                _customModifiers = customModifiers;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(504, 682, 1014);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(504, 682, 1014);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(504, 682, 1014);
            }
        }

        ImmutableArray<ICustomModifier> IModifiedTypeReference.CustomModifiers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(504, 1121, 1315);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(504, 1276, 1300);

                    return _customModifiers;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(504, 1121, 1315);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(504, 1026, 1326);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(504, 1026, 1326);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ITypeReference IModifiedTypeReference.UnmodifiedType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(504, 1415, 1487);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(504, 1451, 1472);

                    return _modifiedType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(504, 1415, 1487);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(504, 1338, 1498);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(504, 1338, 1498);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool ITypeReference.IsEnum
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(504, 1561, 1606);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(504, 1567, 1604);

                    throw f_504_1573_1603();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(504, 1561, 1606);

                    System.Exception
                    f_504_1573_1603()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(504, 1573, 1603);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(504, 1510, 1617);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(504, 1510, 1617);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool ITypeReference.IsValueType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(504, 1685, 1730);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(504, 1691, 1728);

                    throw f_504_1697_1727();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(504, 1685, 1730);

                    System.Exception
                    f_504_1697_1727()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(504, 1697, 1727);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(504, 1629, 1741);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(504, 1629, 1741);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ITypeDefinition ITypeReference.GetResolvedType(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(504, 1753, 1893);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(504, 1845, 1882);

                throw f_504_1851_1881();
                DynAbs.Tracing.TraceSender.TraceExitMethod(504, 1753, 1893);

                System.Exception
                f_504_1851_1881()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(504, 1851, 1881);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(504, 1753, 1893);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(504, 1753, 1893);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        PrimitiveTypeCode ITypeReference.TypeCode
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(504, 1971, 2017);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(504, 1977, 2015);

                    return PrimitiveTypeCode.NotPrimitive;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(504, 1971, 2017);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(504, 1905, 2028);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(504, 1905, 2028);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        TypeDefinitionHandle ITypeReference.TypeDef
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(504, 2108, 2153);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(504, 2114, 2151);

                    throw f_504_2120_2150();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(504, 2108, 2153);

                    System.Exception
                    f_504_2120_2150()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(504, 2120, 2150);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(504, 2040, 2164);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(504, 2040, 2164);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        IEnumerable<ICustomAttribute> IReference.GetAttributes(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(504, 2176, 2353);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(504, 2276, 2342);

                return f_504_2283_2341();
                DynAbs.Tracing.TraceSender.TraceExitMethod(504, 2176, 2353);

                System.Collections.Generic.IEnumerable<Microsoft.Cci.ICustomAttribute>
                f_504_2283_2341()
                {
                    var return_v = SpecializedCollections.EmptyEnumerable<ICustomAttribute>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(504, 2283, 2341);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(504, 2176, 2353);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(504, 2176, 2353);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        void IReference.Dispatch(MetadataVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(504, 2365, 2494);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(504, 2439, 2483);

                f_504_2439_2482(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(504, 2365, 2494);

                int
                f_504_2439_2482(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.ModifiedTypeReference
                modifiedTypeReference)
                {
                    this_param.Visit((Microsoft.Cci.IModifiedTypeReference)modifiedTypeReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(504, 2439, 2482);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(504, 2365, 2494);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(504, 2365, 2494);
            }
        }

        IGenericMethodParameterReference? ITypeReference.AsGenericMethodParameterReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(504, 2613, 2676);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(504, 2649, 2661);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(504, 2613, 2676);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(504, 2506, 2687);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(504, 2506, 2687);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        IGenericTypeInstanceReference? ITypeReference.AsGenericTypeInstanceReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(504, 2800, 2863);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(504, 2836, 2848);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(504, 2800, 2863);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(504, 2699, 2874);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(504, 2699, 2874);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        IGenericTypeParameterReference? ITypeReference.AsGenericTypeParameterReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(504, 2989, 3052);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(504, 3025, 3037);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(504, 2989, 3052);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(504, 2886, 3063);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(504, 2886, 3063);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        INamespaceTypeDefinition? ITypeReference.AsNamespaceTypeDefinition(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(504, 3075, 3210);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(504, 3187, 3199);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(504, 3075, 3210);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(504, 3075, 3210);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(504, 3075, 3210);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        INamespaceTypeReference? ITypeReference.AsNamespaceTypeReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(504, 3311, 3374);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(504, 3347, 3359);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(504, 3311, 3374);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(504, 3222, 3385);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(504, 3222, 3385);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        INestedTypeDefinition? ITypeReference.AsNestedTypeDefinition(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(504, 3397, 3526);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(504, 3503, 3515);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(504, 3397, 3526);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(504, 3397, 3526);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(504, 3397, 3526);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        INestedTypeReference? ITypeReference.AsNestedTypeReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(504, 3621, 3684);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(504, 3657, 3669);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(504, 3621, 3684);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(504, 3538, 3695);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(504, 3538, 3695);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ISpecializedNestedTypeReference? ITypeReference.AsSpecializedNestedTypeReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(504, 3812, 3875);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(504, 3848, 3860);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(504, 3812, 3875);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(504, 3707, 3886);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(504, 3707, 3886);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ITypeDefinition? ITypeReference.AsTypeDefinition(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(504, 3898, 4015);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(504, 3992, 4004);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(504, 3898, 4015);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(504, 3898, 4015);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(504, 3898, 4015);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        IDefinition? IReference.AsDefinition(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(504, 4027, 4132);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(504, 4109, 4121);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(504, 4027, 4132);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(504, 4027, 4132);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(504, 4027, 4132);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        CodeAnalysis.Symbols.ISymbolInternal? Cci.IReference.GetInternalSymbol()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(504, 4217, 4224);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(504, 4220, 4224);
                return null; DynAbs.Tracing.TraceSender.TraceExitMethod(504, 4217, 4224);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(504, 4217, 4224);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(504, 4217, 4224);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(504, 4237, 4517);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(504, 4452, 4506);

                throw f_504_4458_4505();
                DynAbs.Tracing.TraceSender.TraceExitMethod(504, 4237, 4517);

                System.Exception
                f_504_4458_4505()
                {
                    var return_v = Roslyn.Utilities.ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(504, 4458, 4505);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(504, 4237, 4517);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(504, 4237, 4517);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(504, 4529, 4802);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(504, 4737, 4791);

                throw f_504_4743_4790();
                DynAbs.Tracing.TraceSender.TraceExitMethod(504, 4529, 4802);

                System.Exception
                f_504_4743_4790()
                {
                    var return_v = Roslyn.Utilities.ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(504, 4743, 4790);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(504, 4529, 4802);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(504, 4529, 4802);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ModifiedTypeReference()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(504, 463, 4809);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(504, 463, 4809);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(504, 463, 4809);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(504, 463, 4809);

        static int
        f_504_813_853(bool
        b)
        {
            RoslynDebug.Assert(b);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(504, 813, 853);
            return 0;
        }


        bool
        f_504_881_907_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(504, 881, 907);
            return return_v;
        }


        static int
        f_504_868_908(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(504, 868, 908);
            return 0;
        }

    }
}
