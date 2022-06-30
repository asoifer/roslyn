// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;

namespace Microsoft.CodeAnalysis
{
    public sealed class MetadataId
    {
        private MetadataId()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(428, 779, 821);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(428, 779, 821);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(428, 779, 821);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(428, 779, 821);
            }
        }

        internal static MetadataId CreateNewId()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(428, 874, 893);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(428, 877, 893);
                return f_428_877_893(); DynAbs.Tracing.TraceSender.TraceExitMethod(428, 874, 893);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(428, 874, 893);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(428, 874, 893);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.MetadataId
            f_428_877_893()
            {
                var return_v = new Microsoft.CodeAnalysis.MetadataId();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(428, 877, 893);
                return return_v;
            }

        }

        static MetadataId()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(428, 732, 901);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(428, 732, 901);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(428, 732, 901);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(428, 732, 901);
    }
    public abstract class Metadata : IDisposable
    {
        internal readonly bool IsImageOwner;

        public MetadataId Id { get; }

        internal Metadata(bool isImageOwner, MetadataId id)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(428, 1432, 1579);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(428, 1095, 1107);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(428, 1391, 1420);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(428, 1508, 1541);

                this.IsImageOwner = isImageOwner;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(428, 1555, 1568);

                this.Id = id;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(428, 1432, 1579);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(428, 1432, 1579);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(428, 1432, 1579);
            }
        }

        public abstract MetadataImageKind Kind { get; }

        public abstract void Dispose();

        protected abstract Metadata CommonCopy();

        public Metadata Copy()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(428, 2076, 2154);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(428, 2123, 2143);

                return f_428_2130_2142(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(428, 2076, 2154);

                Microsoft.CodeAnalysis.Metadata
                f_428_2130_2142(Microsoft.CodeAnalysis.Metadata
                this_param)
                {
                    var return_v = this_param.CommonCopy();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(428, 2130, 2142);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(428, 2076, 2154);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(428, 2076, 2154);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static Metadata()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(428, 1011, 2161);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(428, 1011, 2161);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(428, 1011, 2161);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(428, 1011, 2161);
    }
}
