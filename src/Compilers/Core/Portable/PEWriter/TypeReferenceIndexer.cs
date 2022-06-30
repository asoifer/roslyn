// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.Emit;
using EmitContext = Microsoft.CodeAnalysis.Emit.EmitContext;

namespace Microsoft.Cci
{
    internal sealed class TypeReferenceIndexer : ReferenceIndexerBase
    {
        internal TypeReferenceIndexer(EmitContext context)
        : base(f_519_748_755_C(context))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(519, 677, 778);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(519, 677, 778);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(519, 677, 778);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(519, 677, 778);
            }
        }

        public override void Visit(CommonPEModuleBuilder module)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(519, 790, 1287);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(519, 1074, 1144);

                f_519_1074_1143(            //EDMAURER visit these assembly-level attributes even when producing a module.
                                            //They'll be attached off the "AssemblyAttributesGoHere" typeRef if a module is being produced.

                            this, f_519_1085_1142(module, Context.IsRefAssembly));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(519, 1158, 1215);

                f_519_1158_1214(this, f_519_1169_1213(module));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(519, 1229, 1276);

                f_519_1229_1275(this, f_519_1240_1274(module));
                DynAbs.Tracing.TraceSender.TraceExitMethod(519, 790, 1287);

                System.Collections.Generic.IEnumerable<Microsoft.Cci.ICustomAttribute>
                f_519_1085_1142(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param, bool
                isRefAssembly)
                {
                    var return_v = this_param.GetSourceAssemblyAttributes(isRefAssembly);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(519, 1085, 1142);
                    return return_v;
                }


                int
                f_519_1074_1143(Microsoft.Cci.TypeReferenceIndexer
                this_param, System.Collections.Generic.IEnumerable<Microsoft.Cci.ICustomAttribute>
                customAttributes)
                {
                    this_param.Visit(customAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(519, 1074, 1143);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.SecurityAttribute>
                f_519_1169_1213(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param)
                {
                    var return_v = this_param.GetSourceAssemblySecurityAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(519, 1169, 1213);
                    return return_v;
                }


                int
                f_519_1158_1214(Microsoft.Cci.TypeReferenceIndexer
                this_param, System.Collections.Generic.IEnumerable<Microsoft.Cci.SecurityAttribute>
                securityAttributes)
                {
                    this_param.Visit(securityAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(519, 1158, 1214);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.ICustomAttribute>
                f_519_1240_1274(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param)
                {
                    var return_v = this_param.GetSourceModuleAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(519, 1240, 1274);
                    return return_v;
                }


                int
                f_519_1229_1275(Microsoft.Cci.TypeReferenceIndexer
                this_param, System.Collections.Generic.IEnumerable<Microsoft.Cci.ICustomAttribute>
                customAttributes)
                {
                    this_param.Visit(customAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(519, 1229, 1275);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(519, 790, 1287);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(519, 790, 1287);
            }
        }

        protected override void RecordAssemblyReference(IAssemblyReference assemblyReference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(519, 1299, 1406);
                DynAbs.Tracing.TraceSender.TraceExitMethod(519, 1299, 1406);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(519, 1299, 1406);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(519, 1299, 1406);
            }
        }

        protected override void RecordFileReference(IFileReference fileReference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(519, 1418, 1513);
                DynAbs.Tracing.TraceSender.TraceExitMethod(519, 1418, 1513);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(519, 1418, 1513);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(519, 1418, 1513);
            }
        }

        protected override void RecordModuleReference(IModuleReference moduleReference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(519, 1525, 1626);
                DynAbs.Tracing.TraceSender.TraceExitMethod(519, 1525, 1626);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(519, 1525, 1626);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(519, 1525, 1626);
            }
        }

        public override void Visit(IPlatformInvokeInformation platformInvokeInformation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(519, 1638, 1740);
                DynAbs.Tracing.TraceSender.TraceExitMethod(519, 1638, 1740);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(519, 1638, 1740);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(519, 1638, 1740);
            }
        }

        protected override void ProcessMethodBody(IMethodDefinition method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(519, 1752, 1841);
                DynAbs.Tracing.TraceSender.TraceExitMethod(519, 1752, 1841);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(519, 1752, 1841);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(519, 1752, 1841);
            }
        }

        protected override void RecordTypeReference(ITypeReference typeReference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(519, 1853, 1948);
                DynAbs.Tracing.TraceSender.TraceExitMethod(519, 1853, 1948);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(519, 1853, 1948);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(519, 1853, 1948);
            }
        }

        protected override void ReserveFieldToken(IFieldReference fieldReference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(519, 1960, 2055);
                DynAbs.Tracing.TraceSender.TraceExitMethod(519, 1960, 2055);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(519, 1960, 2055);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(519, 1960, 2055);
            }
        }

        protected override void ReserveMethodToken(IMethodReference methodReference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(519, 2067, 2165);
                DynAbs.Tracing.TraceSender.TraceExitMethod(519, 2067, 2165);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(519, 2067, 2165);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(519, 2067, 2165);
            }
        }

        protected override void RecordTypeMemberReference(ITypeMemberReference typeMemberReference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(519, 2177, 2290);
                DynAbs.Tracing.TraceSender.TraceExitMethod(519, 2177, 2290);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(519, 2177, 2290);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(519, 2177, 2290);
            }
        }

        static TypeReferenceIndexer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(519, 595, 2297);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(519, 595, 2297);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(519, 595, 2297);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(519, 595, 2297);

        static Microsoft.CodeAnalysis.Emit.EmitContext
        f_519_748_755_C(Microsoft.CodeAnalysis.Emit.EmitContext
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(519, 677, 778);
            return return_v;
        }

    }
}
