// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.Cci
{
    internal sealed class TypeSpecComparer : IEqualityComparer<ITypeReference>
    {
        private readonly MetadataWriter _metadataWriter;

        internal TypeSpecComparer(MetadataWriter metadataWriter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(521, 468, 593);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(521, 440, 455);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(521, 549, 582);

                _metadataWriter = metadataWriter;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(521, 468, 593);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(521, 468, 593);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(521, 468, 593);
            }
        }

        public bool Equals(ITypeReference? x, ITypeReference? y)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(521, 605, 812);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(521, 686, 801);

                return x == y || (DynAbs.Tracing.TraceSender.Expression_False(521, 693, 800) || f_521_703_747(_metadataWriter, x).Equals(f_521_755_799(_metadataWriter, y)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(521, 605, 812);

                System.Reflection.Metadata.BlobHandle
                f_521_703_747(Microsoft.Cci.MetadataWriter
                this_param, Microsoft.Cci.ITypeReference?
                typeReference)
                {
                    var return_v = this_param.GetTypeSpecSignatureIndex(typeReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(521, 703, 747);
                    return return_v;
                }


                System.Reflection.Metadata.BlobHandle
                f_521_755_799(Microsoft.Cci.MetadataWriter
                this_param, Microsoft.Cci.ITypeReference?
                typeReference)
                {
                    var return_v = this_param.GetTypeSpecSignatureIndex(typeReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(521, 755, 799);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(521, 605, 812);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(521, 605, 812);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int GetHashCode(ITypeReference typeReference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(521, 824, 990);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(521, 901, 979);

                return f_521_908_964(_metadataWriter, typeReference).GetHashCode();
                DynAbs.Tracing.TraceSender.TraceExitMethod(521, 824, 990);

                System.Reflection.Metadata.BlobHandle
                f_521_908_964(Microsoft.Cci.MetadataWriter
                this_param, Microsoft.Cci.ITypeReference
                typeReference)
                {
                    var return_v = this_param.GetTypeSpecSignatureIndex(typeReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(521, 908, 964);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(521, 824, 990);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(521, 824, 990);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static TypeSpecComparer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(521, 317, 997);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(521, 317, 997);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(521, 317, 997);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(521, 317, 997);
    }
}
