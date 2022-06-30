// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Roslyn.Utilities;

namespace Microsoft.Cci
{
    internal sealed class MethodSpecComparer : IEqualityComparer<IGenericMethodInstanceReference>
    {
        private readonly MetadataWriter _metadataWriter;

        internal MethodSpecComparer(MetadataWriter metadataWriter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(502, 512, 639);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(502, 484, 499);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(502, 595, 628);

                _metadataWriter = metadataWriter;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(502, 512, 639);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(502, 512, 639);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(502, 512, 639);
            }
        }

        public bool Equals(IGenericMethodInstanceReference? x, IGenericMethodInstanceReference? y)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(502, 651, 1285);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(502, 766, 837) || true) && (x == y)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(502, 766, 837);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(502, 810, 822);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(502, 766, 837);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(502, 851, 898);

                f_502_851_897(x is object && (DynAbs.Tracing.TraceSender.Expression_True(502, 870, 896) && y is object));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(502, 914, 1274);

                return
                f_502_938_1035(_metadataWriter, f_502_991_1034(x, _metadataWriter.Context)) == f_502_1039_1136(_metadataWriter, f_502_1092_1135(y, _metadataWriter.Context)) && (DynAbs.Tracing.TraceSender.Expression_True(502, 938, 1273) && f_502_1157_1213(_metadataWriter, x) == f_502_1217_1273(_metadataWriter, y));
                DynAbs.Tracing.TraceSender.TraceExitMethod(502, 651, 1285);

                int
                f_502_851_897(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(502, 851, 897);
                    return 0;
                }


                Microsoft.Cci.IMethodReference
                f_502_991_1034(Microsoft.Cci.IGenericMethodInstanceReference
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetGenericMethod(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(502, 991, 1034);
                    return return_v;
                }


                System.Reflection.Metadata.EntityHandle
                f_502_938_1035(Microsoft.Cci.MetadataWriter
                this_param, Microsoft.Cci.IMethodReference
                methodReference)
                {
                    var return_v = this_param.GetMethodDefinitionOrReferenceHandle(methodReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(502, 938, 1035);
                    return return_v;
                }


                Microsoft.Cci.IMethodReference
                f_502_1092_1135(Microsoft.Cci.IGenericMethodInstanceReference
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetGenericMethod(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(502, 1092, 1135);
                    return return_v;
                }


                System.Reflection.Metadata.EntityHandle
                f_502_1039_1136(Microsoft.Cci.MetadataWriter
                this_param, Microsoft.Cci.IMethodReference
                methodReference)
                {
                    var return_v = this_param.GetMethodDefinitionOrReferenceHandle(methodReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(502, 1039, 1136);
                    return return_v;
                }


                System.Reflection.Metadata.BlobHandle
                f_502_1157_1213(Microsoft.Cci.MetadataWriter
                this_param, Microsoft.Cci.IGenericMethodInstanceReference
                methodInstanceReference)
                {
                    var return_v = this_param.GetMethodSpecificationSignatureHandle(methodInstanceReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(502, 1157, 1213);
                    return return_v;
                }


                System.Reflection.Metadata.BlobHandle
                f_502_1217_1273(Microsoft.Cci.MetadataWriter
                this_param, Microsoft.Cci.IGenericMethodInstanceReference
                methodInstanceReference)
                {
                    var return_v = this_param.GetMethodSpecificationSignatureHandle(methodInstanceReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(502, 1217, 1273);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(502, 651, 1285);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(502, 651, 1285);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int GetHashCode(IGenericMethodInstanceReference methodInstanceReference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(502, 1297, 1696);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(502, 1401, 1685);

                return f_502_1408_1684(f_502_1439_1558(_metadataWriter, f_502_1492_1557(methodInstanceReference, _metadataWriter.Context)).GetHashCode(), f_502_1591_1669(_metadataWriter, methodInstanceReference).GetHashCode());
                DynAbs.Tracing.TraceSender.TraceExitMethod(502, 1297, 1696);

                Microsoft.Cci.IMethodReference
                f_502_1492_1557(Microsoft.Cci.IGenericMethodInstanceReference
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetGenericMethod(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(502, 1492, 1557);
                    return return_v;
                }


                System.Reflection.Metadata.EntityHandle
                f_502_1439_1558(Microsoft.Cci.MetadataWriter
                this_param, Microsoft.Cci.IMethodReference
                methodReference)
                {
                    var return_v = this_param.GetMethodDefinitionOrReferenceHandle(methodReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(502, 1439, 1558);
                    return return_v;
                }


                System.Reflection.Metadata.BlobHandle
                f_502_1591_1669(Microsoft.Cci.MetadataWriter
                this_param, Microsoft.Cci.IGenericMethodInstanceReference
                methodInstanceReference)
                {
                    var return_v = this_param.GetMethodSpecificationSignatureHandle(methodInstanceReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(502, 1591, 1669);
                    return return_v;
                }


                int
                f_502_1408_1684(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(502, 1408, 1684);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(502, 1297, 1696);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(502, 1297, 1696);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static MethodSpecComparer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(502, 342, 1703);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(502, 342, 1703);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(502, 342, 1703);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(502, 342, 1703);
    }
}
