// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Roslyn.Utilities;
using Microsoft.CodeAnalysis.Emit;

namespace Microsoft.Cci
{
    internal abstract class ReferenceIndexer : ReferenceIndexerBase
    {
        protected readonly MetadataWriter metadataWriter;

        private readonly HashSet<IImportScope> _alreadySeenScopes;

        internal ReferenceIndexer(MetadataWriter metadataWriter)
        : base(f_508_739_761_C(metadataWriter.Context))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(508, 662, 835);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(508, 537, 551);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(508, 601, 649);
                this._alreadySeenScopes = f_508_622_649(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(508, 787, 824);

                this.metadataWriter = metadataWriter;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(508, 662, 835);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(508, 662, 835);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(508, 662, 835);
            }
        }

        public override void Visit(CommonPEModuleBuilder module)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(508, 847, 1766);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(508, 1122, 1187);

                f_508_1122_1186(this, f_508_1128_1185(module, Context.IsRefAssembly));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(508, 1201, 1253);

                f_508_1201_1252(this, f_508_1207_1251(module));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(508, 1269, 1314);

                f_508_1269_1313(this, f_508_1275_1312(module, Context));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(508, 1328, 1370);

                f_508_1328_1369(this, f_508_1334_1368(module));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(508, 1384, 1434);

                f_508_1384_1433(this, f_508_1390_1432(module, Context));
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(508, 1450, 1609);
                    foreach (var exportedType in f_508_1479_1523_I(f_508_1479_1523(module, Context.Diagnostics)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(508, 1450, 1609);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(508, 1557, 1594);

                        f_508_1557_1593(this, exportedType.Type);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(508, 1450, 1609);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(508, 1, 160);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(508, 1, 160);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(508, 1625, 1661);

                f_508_1625_1660(this, f_508_1631_1659(module, Context));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(508, 1675, 1709);

                f_508_1675_1708(this, f_508_1688_1707(module));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(508, 1723, 1755);

                f_508_1723_1754(this, f_508_1729_1753(module, Context));
                DynAbs.Tracing.TraceSender.TraceExitMethod(508, 847, 1766);

                System.Collections.Generic.IEnumerable<Microsoft.Cci.ICustomAttribute>
                f_508_1128_1185(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param, bool
                isRefAssembly)
                {
                    var return_v = this_param.GetSourceAssemblyAttributes(isRefAssembly);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(508, 1128, 1185);
                    return return_v;
                }


                int
                f_508_1122_1186(Microsoft.Cci.ReferenceIndexer
                this_param, System.Collections.Generic.IEnumerable<Microsoft.Cci.ICustomAttribute>
                customAttributes)
                {
                    this_param.Visit(customAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(508, 1122, 1186);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.SecurityAttribute>
                f_508_1207_1251(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param)
                {
                    var return_v = this_param.GetSourceAssemblySecurityAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(508, 1207, 1251);
                    return return_v;
                }


                int
                f_508_1201_1252(Microsoft.Cci.ReferenceIndexer
                this_param, System.Collections.Generic.IEnumerable<Microsoft.Cci.SecurityAttribute>
                securityAttributes)
                {
                    this_param.Visit(securityAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(508, 1201, 1252);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.IAssemblyReference>
                f_508_1275_1312(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetAssemblyReferences(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(508, 1275, 1312);
                    return return_v;
                }


                int
                f_508_1269_1313(Microsoft.Cci.ReferenceIndexer
                this_param, System.Collections.Generic.IEnumerable<Microsoft.Cci.IAssemblyReference>
                assemblyReferences)
                {
                    this_param.Visit(assemblyReferences);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(508, 1269, 1313);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.ICustomAttribute>
                f_508_1334_1368(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param)
                {
                    var return_v = this_param.GetSourceModuleAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(508, 1334, 1368);
                    return return_v;
                }


                int
                f_508_1328_1369(Microsoft.Cci.ReferenceIndexer
                this_param, System.Collections.Generic.IEnumerable<Microsoft.Cci.ICustomAttribute>
                customAttributes)
                {
                    this_param.Visit(customAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(508, 1328, 1369);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.INamespaceTypeDefinition>
                f_508_1390_1432(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetTopLevelTypeDefinitions(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(508, 1390, 1432);
                    return return_v;
                }


                int
                f_508_1384_1433(Microsoft.Cci.ReferenceIndexer
                this_param, System.Collections.Generic.IEnumerable<Microsoft.Cci.INamespaceTypeDefinition>
                types)
                {
                    this_param.Visit((System.Collections.Generic.IEnumerable<Microsoft.Cci.INamedTypeDefinition>)types);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(508, 1384, 1433);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ExportedType>
                f_508_1479_1523(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.GetExportedTypes(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(508, 1479, 1523);
                    return return_v;
                }


                int
                f_508_1557_1593(Microsoft.Cci.ReferenceIndexer
                this_param, Microsoft.Cci.ITypeReference
                exportedType)
                {
                    this_param.VisitExportedType(exportedType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(508, 1557, 1593);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ExportedType>
                f_508_1479_1523_I(System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ExportedType>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(508, 1479, 1523);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ManagedResource>
                f_508_1631_1659(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetResources(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(508, 1631, 1659);
                    return return_v;
                }


                int
                f_508_1625_1660(Microsoft.Cci.ReferenceIndexer
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ManagedResource>
                resources)
                {
                    this_param.Visit((System.Collections.Generic.IEnumerable<Microsoft.Cci.ManagedResource>)resources);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(508, 1625, 1660);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.UsedNamespaceOrType>
                f_508_1688_1707(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param)
                {
                    var return_v = this_param.GetImports();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(508, 1688, 1707);
                    return return_v;
                }


                int
                f_508_1675_1708(Microsoft.Cci.ReferenceIndexer
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.Cci.UsedNamespaceOrType>
                imports)
                {
                    this_param.VisitImports(imports);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(508, 1675, 1708);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.IFileReference>
                f_508_1729_1753(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetFiles(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(508, 1729, 1753);
                    return return_v;
                }


                int
                f_508_1723_1754(Microsoft.Cci.ReferenceIndexer
                this_param, System.Collections.Generic.IEnumerable<Microsoft.Cci.IFileReference>
                fileReferences)
                {
                    this_param.Visit(fileReferences);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(508, 1723, 1754);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(508, 847, 1766);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(508, 847, 1766);
            }
        }

        private void VisitExportedType(ITypeReference exportedType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(508, 1778, 2832);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(508, 2187, 2269);

                var
                definingUnit = f_508_2206_2268(exportedType, Context)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(508, 2283, 2341);

                var
                definingAssembly = definingUnit as IAssemblyReference
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(508, 2355, 2821) || true) && (definingAssembly != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(508, 2355, 2821);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(508, 2417, 2441);

                    f_508_2417_2440(this, definingAssembly);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(508, 2355, 2821);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(508, 2355, 2821);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(508, 2507, 2590);

                    definingAssembly = f_508_2526_2589(((IModuleReference)definingUnit), Context);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(508, 2608, 2806) || true) && (definingAssembly != null && (DynAbs.Tracing.TraceSender.Expression_True(508, 2612, 2721) && !f_508_2641_2721(definingAssembly, f_508_2675_2720(Context.Module, Context))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(508, 2608, 2806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(508, 2763, 2787);

                        f_508_2763_2786(this, definingAssembly);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(508, 2608, 2806);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(508, 2355, 2821);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(508, 1778, 2832);

                Microsoft.Cci.IUnitReference
                f_508_2206_2268(Microsoft.Cci.ITypeReference
                typeReference, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = MetadataWriter.GetDefiningUnitReference(typeReference, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(508, 2206, 2268);
                    return return_v;
                }


                int
                f_508_2417_2440(Microsoft.Cci.ReferenceIndexer
                this_param, Microsoft.Cci.IAssemblyReference
                assemblyReference)
                {
                    this_param.Visit(assemblyReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(508, 2417, 2440);
                    return 0;
                }


                Microsoft.Cci.IAssemblyReference
                f_508_2526_2589(Microsoft.Cci.IModuleReference
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetContainingAssembly(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(508, 2526, 2589);
                    return return_v;
                }


                Microsoft.Cci.IAssemblyReference
                f_508_2675_2720(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetContainingAssembly(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(508, 2675, 2720);
                    return return_v;
                }


                bool
                f_508_2641_2721(Microsoft.Cci.IAssemblyReference
                objA, Microsoft.Cci.IAssemblyReference
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(508, 2641, 2721);
                    return return_v;
                }


                int
                f_508_2763_2786(Microsoft.Cci.ReferenceIndexer
                this_param, Microsoft.Cci.IAssemblyReference
                assemblyReference)
                {
                    this_param.Visit(assemblyReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(508, 2763, 2786);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(508, 1778, 2832);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(508, 1778, 2832);
            }
        }

        public void VisitMethodBodyReference(IReference reference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(508, 2844, 3977);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(508, 2927, 2975);

                var
                typeReference = reference as ITypeReference
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(508, 2989, 3966) || true) && (typeReference != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(508, 2989, 3966);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(508, 3048, 3084);

                    this.typeReferenceNeedsToken = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(508, 3102, 3128);

                    f_508_3102_3127(this, typeReference);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(508, 3146, 3190);

                    f_508_3146_3189(!this.typeReferenceNeedsToken);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(508, 2989, 3966);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(508, 2989, 3966);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(508, 3256, 3306);

                    var
                    fieldReference = reference as IFieldReference
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(508, 3324, 3951) || true) && (fieldReference != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(508, 3324, 3951);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(508, 3392, 3597) || true) && (f_508_3396_3434(fieldReference))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(508, 3392, 3597);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(508, 3484, 3574);

                            f_508_3484_3573(((IContextualNamedEntity)fieldReference), this.metadataWriter);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(508, 3392, 3597);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(508, 3621, 3648);

                        f_508_3621_3647(
                                            this, fieldReference);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(508, 3324, 3951);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(508, 3324, 3951);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(508, 3730, 3782);

                        var
                        methodReference = reference as IMethodReference
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(508, 3804, 3932) || true) && (methodReference != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(508, 3804, 3932);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(508, 3881, 3909);

                            f_508_3881_3908(this, methodReference);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(508, 3804, 3932);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(508, 3324, 3951);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(508, 2989, 3966);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(508, 2844, 3977);

                int
                f_508_3102_3127(Microsoft.Cci.ReferenceIndexer
                this_param, Microsoft.Cci.ITypeReference
                typeReference)
                {
                    this_param.Visit(typeReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(508, 3102, 3127);
                    return 0;
                }


                int
                f_508_3146_3189(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(508, 3146, 3189);
                    return 0;
                }


                bool
                f_508_3396_3434(Microsoft.Cci.IFieldReference
                this_param)
                {
                    var return_v = this_param.IsContextualNamedEntity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(508, 3396, 3434);
                    return return_v;
                }


                int
                f_508_3484_3573(Microsoft.Cci.IContextualNamedEntity
                this_param, Microsoft.Cci.MetadataWriter
                metadataWriter)
                {
                    this_param.AssociateWithMetadataWriter(metadataWriter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(508, 3484, 3573);
                    return 0;
                }


                int
                f_508_3621_3647(Microsoft.Cci.ReferenceIndexer
                this_param, Microsoft.Cci.IFieldReference
                fieldReference)
                {
                    this_param.Visit(fieldReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(508, 3621, 3647);
                    return 0;
                }


                int
                f_508_3881_3908(Microsoft.Cci.ReferenceIndexer
                this_param, Microsoft.Cci.IMethodReference
                methodReference)
                {
                    this_param.Visit(methodReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(508, 3881, 3908);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(508, 2844, 3977);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(508, 2844, 3977);
            }
        }

        protected override void RecordAssemblyReference(IAssemblyReference assemblyReference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(508, 3989, 4176);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(508, 4099, 4165);

                f_508_4099_4164(this.metadataWriter, assemblyReference);
                DynAbs.Tracing.TraceSender.TraceExitMethod(508, 3989, 4176);

                System.Reflection.Metadata.AssemblyReferenceHandle
                f_508_4099_4164(Microsoft.Cci.MetadataWriter
                this_param, Microsoft.Cci.IAssemblyReference
                assemblyReference)
                {
                    var return_v = this_param.GetAssemblyReferenceHandle(assemblyReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(508, 4099, 4164);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(508, 3989, 4176);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(508, 3989, 4176);
            }
        }

        protected override void ProcessMethodBody(IMethodDefinition method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(508, 4188, 5148);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(508, 4280, 5137) || true) && (f_508_4284_4300(method) && (DynAbs.Tracing.TraceSender.Expression_True(508, 4284, 4332) && !metadataWriter.MetadataOnly))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(508, 4280, 5137);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(508, 4366, 4401);

                    var
                    body = f_508_4377_4400(method, Context)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(508, 4421, 5122) || true) && (body != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(508, 4421, 5122);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(508, 4479, 4496);

                        f_508_4479_4495(this, body);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(508, 4538, 4562);

                            for (IImportScope
        scope = f_508_4546_4562(body)
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(508, 4520, 4950) || true) && (scope != null)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(508, 4579, 4599)
        , scope = f_508_4587_4599(scope), DynAbs.Tracing.TraceSender.TraceExitCondition(508, 4520, 4950))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(508, 4520, 4950);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(508, 4649, 4927) || true) && (f_508_4653_4682(_alreadySeenScopes, scope))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(508, 4649, 4927);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(508, 4740, 4780);

                                    f_508_4740_4779(this, f_508_4753_4778(scope));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(508, 4649, 4927);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(508, 4649, 4927);
                                    DynAbs.Tracing.TraceSender.TraceBreak(508, 4894, 4900);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(508, 4649, 4927);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(508, 1, 431);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(508, 1, 431);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(508, 4421, 5122);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(508, 4421, 5122);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(508, 4992, 5122) || true) && (!metadataWriter.MetadataOnly)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(508, 4992, 5122);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(508, 5066, 5103);

                            throw f_508_5072_5102();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(508, 4992, 5122);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(508, 4421, 5122);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(508, 4280, 5137);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(508, 4188, 5148);

                bool
                f_508_4284_4300(Microsoft.Cci.IMethodDefinition
                methodDef)
                {
                    var return_v = methodDef.HasBody();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(508, 4284, 4300);
                    return return_v;
                }


                Microsoft.Cci.IMethodBody
                f_508_4377_4400(Microsoft.Cci.IMethodDefinition
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetBody(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(508, 4377, 4400);
                    return return_v;
                }


                int
                f_508_4479_4495(Microsoft.Cci.ReferenceIndexer
                this_param, Microsoft.Cci.IMethodBody
                methodBody)
                {
                    this_param.Visit(methodBody);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(508, 4479, 4495);
                    return 0;
                }


                Microsoft.Cci.IImportScope
                f_508_4546_4562(Microsoft.Cci.IMethodBody
                this_param)
                {
                    var return_v = this_param.ImportScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(508, 4546, 4562);
                    return return_v;
                }


                Microsoft.Cci.IImportScope
                f_508_4587_4599(Microsoft.Cci.IImportScope
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(508, 4587, 4599);
                    return return_v;
                }


                bool
                f_508_4653_4682(System.Collections.Generic.HashSet<Microsoft.Cci.IImportScope>
                this_param, Microsoft.Cci.IImportScope
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(508, 4653, 4682);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.UsedNamespaceOrType>
                f_508_4753_4778(Microsoft.Cci.IImportScope
                this_param)
                {
                    var return_v = this_param.GetUsedNamespaces();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(508, 4753, 4778);
                    return return_v;
                }


                int
                f_508_4740_4779(Microsoft.Cci.ReferenceIndexer
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.Cci.UsedNamespaceOrType>
                imports)
                {
                    this_param.VisitImports(imports);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(508, 4740, 4779);
                    return 0;
                }


                System.Exception
                f_508_5072_5102()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(508, 5072, 5102);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(508, 4188, 5148);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(508, 4188, 5148);
            }
        }

        private void VisitImports(ImmutableArray<UsedNamespaceOrType> imports)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(508, 5160, 6306);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(508, 5822, 6295);
                    foreach (var import in f_508_5845_5852_I(imports))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(508, 5822, 6295);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(508, 5886, 6015) || true) && (import.TargetAssemblyOpt != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(508, 5886, 6015);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(508, 5964, 5996);

                            f_508_5964_5995(this, import.TargetAssemblyOpt);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(508, 5886, 6015);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(508, 6035, 6280) || true) && (import.TargetTypeOpt != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(508, 6035, 6280);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(508, 6109, 6145);

                            this.typeReferenceNeedsToken = true;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(508, 6167, 6195);

                            f_508_6167_6194(this, import.TargetTypeOpt);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(508, 6217, 6261);

                            f_508_6217_6260(!this.typeReferenceNeedsToken);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(508, 6035, 6280);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(508, 5822, 6295);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(508, 1, 474);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(508, 1, 474);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(508, 5160, 6306);

                int
                f_508_5964_5995(Microsoft.Cci.ReferenceIndexer
                this_param, Microsoft.Cci.IAssemblyReference
                assemblyReference)
                {
                    this_param.Visit(assemblyReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(508, 5964, 5995);
                    return 0;
                }


                int
                f_508_6167_6194(Microsoft.Cci.ReferenceIndexer
                this_param, Microsoft.Cci.ITypeReference
                typeReference)
                {
                    this_param.Visit(typeReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(508, 6167, 6194);
                    return 0;
                }


                int
                f_508_6217_6260(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(508, 6217, 6260);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.UsedNamespaceOrType>
                f_508_5845_5852_I(System.Collections.Immutable.ImmutableArray<Microsoft.Cci.UsedNamespaceOrType>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(508, 5845, 5852);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(508, 5160, 6306);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(508, 5160, 6306);
            }
        }

        protected override void RecordTypeReference(ITypeReference typeReference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(508, 6318, 6476);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(508, 6416, 6465);

                f_508_6416_6464(this.metadataWriter, typeReference);
                DynAbs.Tracing.TraceSender.TraceExitMethod(508, 6318, 6476);

                System.Reflection.Metadata.EntityHandle
                f_508_6416_6464(Microsoft.Cci.MetadataWriter
                this_param, Microsoft.Cci.ITypeReference
                typeReference)
                {
                    var return_v = this_param.GetTypeHandle(typeReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(508, 6416, 6464);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(508, 6318, 6476);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(508, 6318, 6476);
            }
        }

        protected override void RecordTypeMemberReference(ITypeMemberReference typeMemberReference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(508, 6488, 6681);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(508, 6604, 6670);

                f_508_6604_6669(this.metadataWriter, typeMemberReference);
                DynAbs.Tracing.TraceSender.TraceExitMethod(508, 6488, 6681);

                System.Reflection.Metadata.MemberReferenceHandle
                f_508_6604_6669(Microsoft.Cci.MetadataWriter
                this_param, Microsoft.Cci.ITypeMemberReference
                memberRef)
                {
                    var return_v = this_param.GetMemberReferenceHandle(memberRef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(508, 6604, 6669);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(508, 6488, 6681);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(508, 6488, 6681);
            }
        }

        protected override void RecordFileReference(IFileReference fileReference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(508, 6693, 6859);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(508, 6791, 6848);

                f_508_6791_6847(this.metadataWriter, fileReference);
                DynAbs.Tracing.TraceSender.TraceExitMethod(508, 6693, 6859);

                System.Reflection.Metadata.AssemblyFileHandle
                f_508_6791_6847(Microsoft.Cci.MetadataWriter
                this_param, Microsoft.Cci.IFileReference
                fileReference)
                {
                    var return_v = this_param.GetAssemblyFileHandle(fileReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(508, 6791, 6847);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(508, 6693, 6859);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(508, 6693, 6859);
            }
        }

        protected override void ReserveMethodToken(IMethodReference methodReference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(508, 6871, 7036);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(508, 6972, 7025);

                f_508_6972_7024(this.metadataWriter, methodReference);
                DynAbs.Tracing.TraceSender.TraceExitMethod(508, 6871, 7036);

                System.Reflection.Metadata.EntityHandle
                f_508_6972_7024(Microsoft.Cci.MetadataWriter
                this_param, Microsoft.Cci.IMethodReference
                methodReference)
                {
                    var return_v = this_param.GetMethodHandle(methodReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(508, 6972, 7024);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(508, 6871, 7036);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(508, 6871, 7036);
            }
        }

        protected override void ReserveFieldToken(IFieldReference fieldReference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(508, 7048, 7208);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(508, 7146, 7197);

                f_508_7146_7196(this.metadataWriter, fieldReference);
                DynAbs.Tracing.TraceSender.TraceExitMethod(508, 7048, 7208);

                System.Reflection.Metadata.EntityHandle
                f_508_7146_7196(Microsoft.Cci.MetadataWriter
                this_param, Microsoft.Cci.IFieldReference
                fieldReference)
                {
                    var return_v = this_param.GetFieldHandle(fieldReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(508, 7146, 7196);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(508, 7048, 7208);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(508, 7048, 7208);
            }
        }

        protected override void RecordModuleReference(IModuleReference moduleReference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(508, 7220, 7402);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(508, 7324, 7391);

                f_508_7324_7390(this.metadataWriter, f_508_7369_7389(moduleReference));
                DynAbs.Tracing.TraceSender.TraceExitMethod(508, 7220, 7402);

                string?
                f_508_7369_7389(Microsoft.Cci.IModuleReference
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(508, 7369, 7389);
                    return return_v;
                }


                System.Reflection.Metadata.ModuleReferenceHandle
                f_508_7324_7390(Microsoft.Cci.MetadataWriter
                this_param, string?
                moduleName)
                {
                    var return_v = this_param.GetModuleReferenceHandle(moduleName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(508, 7324, 7390);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(508, 7220, 7402);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(508, 7220, 7402);
            }
        }

        public override void Visit(IPlatformInvokeInformation platformInvokeInformation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(508, 7414, 7613);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(508, 7519, 7602);

                f_508_7519_7601(this.metadataWriter, f_508_7564_7600(platformInvokeInformation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(508, 7414, 7613);

                string?
                f_508_7564_7600(Microsoft.Cci.IPlatformInvokeInformation
                this_param)
                {
                    var return_v = this_param.ModuleName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(508, 7564, 7600);
                    return return_v;
                }


                System.Reflection.Metadata.ModuleReferenceHandle
                f_508_7519_7601(Microsoft.Cci.MetadataWriter
                this_param, string?
                moduleName)
                {
                    var return_v = this_param.GetModuleReferenceHandle(moduleName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(508, 7519, 7601);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(508, 7414, 7613);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(508, 7414, 7613);
            }
        }

        static ReferenceIndexer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(508, 423, 7620);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(508, 423, 7620);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(508, 423, 7620);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(508, 423, 7620);

        System.Collections.Generic.HashSet<Microsoft.Cci.IImportScope>
        f_508_622_649()
        {
            var return_v = new System.Collections.Generic.HashSet<Microsoft.Cci.IImportScope>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(508, 622, 649);
            return return_v;
        }


        static Microsoft.CodeAnalysis.Emit.EmitContext
        f_508_739_761_C(Microsoft.CodeAnalysis.Emit.EmitContext
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(508, 662, 835);
            return return_v;
        }

    }
}
