// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using Roslyn.Utilities;
using EmitContext = Microsoft.CodeAnalysis.Emit.EmitContext;

namespace Microsoft.Cci
{
    internal class RootModuleType : INamespaceTypeDefinition
    {
        private IReadOnlyList<IMethodDefinition>? _methods;

        public void SetStaticConstructorBody(ImmutableArray<byte> il)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(512, 714, 1001);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(512, 800, 831);

                f_512_800_830(_methods is null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(512, 847, 990);

                _methods = f_512_858_989(f_512_921_988(containingTypeDefinition: this, il));
                DynAbs.Tracing.TraceSender.TraceExitMethod(512, 714, 1001);

                int
                f_512_800_830(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(512, 800, 830);
                    return 0;
                }


                Microsoft.Cci.RootModuleStaticConstructor
                f_512_921_988(Microsoft.Cci.RootModuleType
                containingTypeDefinition, System.Collections.Immutable.ImmutableArray<byte>
                il)
                {
                    var return_v = new Microsoft.Cci.RootModuleStaticConstructor(containingTypeDefinition: (Microsoft.Cci.ITypeDefinition)containingTypeDefinition, il);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(512, 921, 988);
                    return return_v;
                }


                System.Collections.Generic.IReadOnlyList<Microsoft.Cci.RootModuleStaticConstructor>
                f_512_858_989(Microsoft.Cci.RootModuleStaticConstructor
                value)
                {
                    var return_v = SpecializedCollections.SingletonReadOnlyList(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(512, 858, 989);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(512, 714, 1001);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(512, 714, 1001);
            }
        }

        public IEnumerable<IMethodDefinition> GetMethods(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(512, 1013, 1200);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(512, 1107, 1189);

                // LAFHIS
                if (_methods == null)
                    DynAbs.Tracing.TraceSender.TraceEnterExpression(512, 1107, 1189);

                return _methods ??= f_512_1127_1188();
                DynAbs.Tracing.TraceSender.TraceExitMethod(512, 1013, 1200);

                System.Collections.Generic.IReadOnlyList<Microsoft.Cci.IMethodDefinition>
                f_512_1127_1188()
                {
                    var return_v = SpecializedCollections.EmptyReadOnlyList<IMethodDefinition>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(512, 1127, 1188);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(512, 1013, 1200);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(512, 1013, 1200);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public TypeDefinitionHandle TypeDef
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(512, 1272, 1317);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(512, 1278, 1315);

                    return default(TypeDefinitionHandle);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(512, 1272, 1317);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(512, 1212, 1328);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(512, 1212, 1328);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ITypeDefinition ResolvedType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(512, 1400, 1420);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(512, 1406, 1418);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(512, 1400, 1420);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(512, 1340, 1431);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(512, 1340, 1431);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public IEnumerable<ICustomAttribute> GetAttributes(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(512, 1443, 1616);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(512, 1539, 1605);

                return f_512_1546_1604();
                DynAbs.Tracing.TraceSender.TraceExitMethod(512, 1443, 1616);

                System.Collections.Generic.IEnumerable<Microsoft.Cci.ICustomAttribute>
                f_512_1546_1604()
                {
                    var return_v = SpecializedCollections.EmptyEnumerable<ICustomAttribute>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(512, 1546, 1604);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(512, 1443, 1616);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(512, 1443, 1616);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool MangleName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(512, 1675, 1696);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(512, 1681, 1694);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(512, 1675, 1696);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(512, 1628, 1707);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(512, 1628, 1707);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(512, 1762, 1788);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(512, 1768, 1786);

                    return "<Module>";
                    DynAbs.Tracing.TraceSender.TraceExitMethod(512, 1762, 1788);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(512, 1719, 1799);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(512, 1719, 1799);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ushort Alignment
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(512, 1859, 1876);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(512, 1865, 1874);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(512, 1859, 1876);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(512, 1811, 1887);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(512, 1811, 1887);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ITypeReference? GetBaseClass(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(512, 1899, 2003);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(512, 1980, 1992);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(512, 1899, 2003);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(512, 1899, 2003);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(512, 1899, 2003);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IEnumerable<IEventDefinition> GetEvents(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(512, 2015, 2184);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(512, 2107, 2173);

                return f_512_2114_2172();
                DynAbs.Tracing.TraceSender.TraceExitMethod(512, 2015, 2184);

                System.Collections.Generic.IEnumerable<Microsoft.Cci.IEventDefinition>
                f_512_2114_2172()
                {
                    var return_v = SpecializedCollections.EmptyEnumerable<IEventDefinition>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(512, 2114, 2172);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(512, 2015, 2184);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(512, 2015, 2184);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IEnumerable<MethodImplementation> GetExplicitImplementationOverrides(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(512, 2196, 2398);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(512, 2317, 2387);

                return f_512_2324_2386();
                DynAbs.Tracing.TraceSender.TraceExitMethod(512, 2196, 2398);

                System.Collections.Generic.IEnumerable<Microsoft.Cci.MethodImplementation>
                f_512_2324_2386()
                {
                    var return_v = SpecializedCollections.EmptyEnumerable<MethodImplementation>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(512, 2324, 2386);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(512, 2196, 2398);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(512, 2196, 2398);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IEnumerable<IFieldDefinition> GetFields(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(512, 2410, 2579);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(512, 2502, 2568);

                return f_512_2509_2567();
                DynAbs.Tracing.TraceSender.TraceExitMethod(512, 2410, 2579);

                System.Collections.Generic.IEnumerable<Microsoft.Cci.IFieldDefinition>
                f_512_2509_2567()
                {
                    var return_v = SpecializedCollections.EmptyEnumerable<IFieldDefinition>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(512, 2509, 2567);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(512, 2410, 2579);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(512, 2410, 2579);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool HasDeclarativeSecurity
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(512, 2650, 2671);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(512, 2656, 2669);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(512, 2650, 2671);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(512, 2591, 2682);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(512, 2591, 2682);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public IEnumerable<Cci.TypeReferenceWithAttributes> Interfaces(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(512, 2694, 2894);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(512, 2802, 2883);

                return f_512_2809_2882();
                DynAbs.Tracing.TraceSender.TraceExitMethod(512, 2694, 2894);

                System.Collections.Generic.IEnumerable<Microsoft.Cci.TypeReferenceWithAttributes>
                f_512_2809_2882()
                {
                    var return_v = SpecializedCollections.EmptyEnumerable<Cci.TypeReferenceWithAttributes>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(512, 2809, 2882);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(512, 2694, 2894);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(512, 2694, 2894);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool IsAbstract
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(512, 2953, 2974);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(512, 2959, 2972);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(512, 2953, 2974);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(512, 2906, 2985);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(512, 2906, 2985);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsBeforeFieldInit
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(512, 3051, 3072);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(512, 3057, 3070);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(512, 3051, 3072);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(512, 2997, 3083);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(512, 2997, 3083);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsComObject
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(512, 3143, 3164);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(512, 3149, 3162);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(512, 3143, 3164);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(512, 3095, 3175);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(512, 3095, 3175);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsGeneric
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(512, 3233, 3254);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(512, 3239, 3252);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(512, 3233, 3254);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(512, 3187, 3265);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(512, 3187, 3265);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsInterface
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(512, 3325, 3346);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(512, 3331, 3344);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(512, 3325, 3346);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(512, 3277, 3357);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(512, 3277, 3357);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsDelegate
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(512, 3416, 3437);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(512, 3422, 3435);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(512, 3416, 3437);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(512, 3369, 3448);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(512, 3369, 3448);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsRuntimeSpecial
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(512, 3513, 3534);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(512, 3519, 3532);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(512, 3513, 3534);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(512, 3460, 3545);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(512, 3460, 3545);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsSerializable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(512, 3608, 3629);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(512, 3614, 3627);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(512, 3608, 3629);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(512, 3557, 3640);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(512, 3557, 3640);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsSpecialName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(512, 3702, 3723);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(512, 3708, 3721);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(512, 3702, 3723);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(512, 3652, 3734);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(512, 3652, 3734);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsWindowsRuntimeImport
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(512, 3805, 3826);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(512, 3811, 3824);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(512, 3805, 3826);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(512, 3746, 3837);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(512, 3746, 3837);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsSealed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(512, 3894, 3915);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(512, 3900, 3913);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(512, 3894, 3915);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(512, 3849, 3926);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(512, 3849, 3926);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public LayoutKind Layout
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(512, 3987, 4018);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(512, 3993, 4016);

                    return LayoutKind.Auto;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(512, 3987, 4018);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(512, 3938, 4029);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(512, 3938, 4029);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public IEnumerable<INestedTypeDefinition> GetNestedTypes(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(512, 4041, 4225);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(512, 4143, 4214);

                return f_512_4150_4213();
                DynAbs.Tracing.TraceSender.TraceExitMethod(512, 4041, 4225);

                System.Collections.Generic.IEnumerable<Microsoft.Cci.INestedTypeDefinition>
                f_512_4150_4213()
                {
                    var return_v = SpecializedCollections.EmptyEnumerable<INestedTypeDefinition>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(512, 4150, 4213);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(512, 4041, 4225);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(512, 4041, 4225);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IEnumerable<IPropertyDefinition> GetProperties(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(512, 4237, 4416);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(512, 4336, 4405);

                return f_512_4343_4404();
                DynAbs.Tracing.TraceSender.TraceExitMethod(512, 4237, 4416);

                System.Collections.Generic.IEnumerable<Microsoft.Cci.IPropertyDefinition>
                f_512_4343_4404()
                {
                    var return_v = SpecializedCollections.EmptyEnumerable<IPropertyDefinition>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(512, 4343, 4404);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(512, 4237, 4416);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(512, 4237, 4416);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public uint SizeOf
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(512, 4471, 4488);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(512, 4477, 4486);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(512, 4471, 4488);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(512, 4428, 4499);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(512, 4428, 4499);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public CharSet StringFormat
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(512, 4563, 4591);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(512, 4569, 4589);

                    return CharSet.Ansi;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(512, 4563, 4591);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(512, 4511, 4602);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(512, 4511, 4602);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsPublic
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(512, 4659, 4680);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(512, 4665, 4678);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(512, 4659, 4680);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(512, 4614, 4691);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(512, 4614, 4691);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsNested
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(512, 4748, 4769);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(512, 4754, 4767);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(512, 4748, 4769);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(512, 4703, 4780);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(512, 4703, 4780);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        IEnumerable<IGenericTypeParameter> ITypeDefinition.GenericParameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(512, 4885, 4930);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(512, 4891, 4928);

                    throw f_512_4897_4927();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(512, 4885, 4930);

                    System.Exception
                    f_512_4897_4927()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(512, 4897, 4927);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(512, 4792, 4941);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(512, 4792, 4941);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ushort ITypeDefinition.GenericParameterCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(512, 5022, 5082);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(512, 5058, 5067);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(512, 5022, 5082);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(512, 4953, 5093);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(512, 4953, 5093);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        IEnumerable<SecurityAttribute> ITypeDefinition.SecurityAttributes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(512, 5195, 5240);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(512, 5201, 5238);

                    throw f_512_5207_5237();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(512, 5195, 5240);

                    System.Exception
                    f_512_5207_5237()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(512, 5207, 5237);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(512, 5105, 5251);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(512, 5105, 5251);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        void IReference.Dispatch(MetadataVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(512, 5263, 5385);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(512, 5337, 5374);

                throw f_512_5343_5373();
                DynAbs.Tracing.TraceSender.TraceExitMethod(512, 5263, 5385);

                System.Exception
                f_512_5343_5373()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(512, 5343, 5373);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(512, 5263, 5385);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(512, 5263, 5385);
            }
        }

        bool ITypeReference.IsEnum
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(512, 5448, 5493);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(512, 5454, 5491);

                    throw f_512_5460_5490();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(512, 5448, 5493);

                    System.Exception
                    f_512_5460_5490()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(512, 5460, 5490);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(512, 5397, 5504);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(512, 5397, 5504);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(512, 5572, 5617);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(512, 5578, 5615);

                    throw f_512_5584_5614();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(512, 5572, 5617);

                    System.Exception
                    f_512_5584_5614()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(512, 5584, 5614);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(512, 5516, 5628);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(512, 5516, 5628);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ITypeDefinition ITypeReference.GetResolvedType(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(512, 5640, 5755);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(512, 5732, 5744);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(512, 5640, 5755);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(512, 5640, 5755);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(512, 5640, 5755);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        PrimitiveTypeCode ITypeReference.TypeCode
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(512, 5833, 5878);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(512, 5839, 5876);

                    throw f_512_5845_5875();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(512, 5833, 5878);

                    System.Exception
                    f_512_5845_5875()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(512, 5845, 5875);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(512, 5767, 5889);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(512, 5767, 5889);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ushort INamedTypeReference.GenericParameterCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(512, 5974, 6019);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(512, 5980, 6017);

                    throw f_512_5986_6016();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(512, 5974, 6019);

                    System.Exception
                    f_512_5986_6016()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(512, 5986, 6016);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(512, 5901, 6030);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(512, 5901, 6030);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        IUnitReference INamespaceTypeReference.GetUnit(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(512, 6042, 6182);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(512, 6134, 6171);

                throw f_512_6140_6170();
                DynAbs.Tracing.TraceSender.TraceExitMethod(512, 6042, 6182);

                System.Exception
                f_512_6140_6170()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(512, 6140, 6170);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(512, 6042, 6182);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(512, 6042, 6182);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        string INamespaceTypeReference.NamespaceName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(512, 6263, 6334);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(512, 6299, 6319);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(512, 6263, 6334);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(512, 6194, 6345);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(512, 6194, 6345);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        IGenericMethodParameterReference? ITypeReference.AsGenericMethodParameterReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(512, 6464, 6527);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(512, 6500, 6512);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(512, 6464, 6527);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(512, 6357, 6538);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(512, 6357, 6538);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(512, 6651, 6714);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(512, 6687, 6699);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(512, 6651, 6714);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(512, 6550, 6725);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(512, 6550, 6725);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(512, 6840, 6903);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(512, 6876, 6888);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(512, 6840, 6903);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(512, 6737, 6914);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(512, 6737, 6914);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        INamespaceTypeDefinition ITypeReference.AsNamespaceTypeDefinition(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(512, 6926, 7060);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(512, 7037, 7049);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(512, 6926, 7060);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(512, 6926, 7060);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(512, 6926, 7060);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        INamespaceTypeReference ITypeReference.AsNamespaceTypeReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(512, 7160, 7223);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(512, 7196, 7208);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(512, 7160, 7223);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(512, 7072, 7234);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(512, 7072, 7234);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        INestedTypeDefinition? ITypeReference.AsNestedTypeDefinition(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(512, 7246, 7375);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(512, 7352, 7364);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(512, 7246, 7375);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(512, 7246, 7375);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(512, 7246, 7375);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        INestedTypeReference? ITypeReference.AsNestedTypeReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(512, 7470, 7533);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(512, 7506, 7518);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(512, 7470, 7533);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(512, 7387, 7544);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(512, 7387, 7544);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(512, 7661, 7724);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(512, 7697, 7709);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(512, 7661, 7724);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(512, 7556, 7735);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(512, 7556, 7735);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ITypeDefinition ITypeReference.AsTypeDefinition(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(512, 7747, 7863);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(512, 7840, 7852);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(512, 7747, 7863);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(512, 7747, 7863);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(512, 7747, 7863);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        IDefinition IReference.AsDefinition(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(512, 7875, 7979);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(512, 7956, 7968);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(512, 7875, 7979);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(512, 7875, 7979);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(512, 7875, 7979);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        CodeAnalysis.Symbols.ISymbolInternal? Cci.IReference.GetInternalSymbol()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(512, 8064, 8071);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(512, 8067, 8071);
                return null; DynAbs.Tracing.TraceSender.TraceExitMethod(512, 8064, 8071);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(512, 8064, 8071);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(512, 8064, 8071);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(512, 8084, 8364);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(512, 8299, 8353);

                throw f_512_8305_8352();
                DynAbs.Tracing.TraceSender.TraceExitMethod(512, 8084, 8364);

                System.Exception
                f_512_8305_8352()
                {
                    var return_v = Roslyn.Utilities.ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(512, 8305, 8352);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(512, 8084, 8364);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(512, 8084, 8364);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(512, 8376, 8649);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(512, 8584, 8638);

                throw f_512_8590_8637();
                DynAbs.Tracing.TraceSender.TraceExitMethod(512, 8376, 8649);

                System.Exception
                f_512_8590_8637()
                {
                    var return_v = Roslyn.Utilities.ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(512, 8590, 8637);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(512, 8376, 8649);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(512, 8376, 8649);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public RootModuleType()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(512, 578, 8656);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(512, 693, 701);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(512, 578, 8656);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(512, 578, 8656);
        }


        static RootModuleType()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(512, 578, 8656);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(512, 578, 8656);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(512, 578, 8656);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(512, 578, 8656);
    }
}
