// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection.Metadata;
using Microsoft.CodeAnalysis;
using Roslyn.Utilities;

namespace Microsoft.Cci
{
    internal sealed class ManagedResource
    {
        private readonly Func<Stream>? _streamProvider;

        private readonly IFileReference? _fileReference;

        private readonly uint _offset;

        private readonly string _name;

        private readonly bool _isPublic;

        internal ManagedResource(string name, bool isPublic, Func<Stream>? streamProvider, IFileReference? fileReference, uint offset)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(495, 1006, 1422);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(495, 542, 557);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(495, 601, 615);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(495, 648, 655);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(495, 690, 695);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(495, 728, 737);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(495, 1157, 1224);

                f_495_1157_1223(streamProvider == null ^ fileReference == null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(495, 1240, 1273);

                _streamProvider = streamProvider;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(495, 1287, 1300);

                _name = name;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(495, 1314, 1345);

                _fileReference = fileReference;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(495, 1359, 1376);

                _offset = offset;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(495, 1390, 1411);

                _isPublic = isPublic;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(495, 1006, 1422);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(495, 1006, 1422);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(495, 1006, 1422);
            }
        }

        public void WriteData(BlobBuilder resourceWriter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(495, 1434, 2837);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(495, 1508, 2826) || true) && (_fileReference == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(495, 1508, 2826);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(495, 1711, 2657);
                        using (Stream
                        stream = f_495_1734_1751(this)
                        )
#nullable enable
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(495, 1819, 2029) || true) && (stream == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(495, 1819, 2029);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(495, 1895, 2002);

                                throw f_495_1901_2001(f_495_1931_2000());
                                DynAbs.Tracing.TraceSender.TraceExitCondition(495, 1819, 2029);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(495, 2057, 2108);

                            var
                            count = (int)(f_495_2075_2088(stream) - f_495_2091_2106(stream))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(495, 2134, 2167);

                            f_495_2134_2166(resourceWriter, count);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(495, 2195, 2258);

                            int
                            bytesWritten = f_495_2214_2257(resourceWriter, stream, count)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(495, 2284, 2584) || true) && (bytesWritten != count)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(495, 2284, 2584);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(495, 2367, 2557);

                                throw f_495_2373_2556(f_495_2436_2555(f_495_2450_2478(), f_495_2480_2533(), bytesWritten, count));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(495, 2284, 2584);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(495, 2610, 2634);

                            f_495_2610_2633(resourceWriter, 8);
                            DynAbs.Tracing.TraceSender.TraceExitUsing(495, 1711, 2657);
                        }
                    }
                    catch (Exception e)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(495, 2694, 2811);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(495, 2754, 2792);

                        throw f_495_2760_2791(_name, e);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(495, 2694, 2811);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(495, 1508, 2826);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(495, 1434, 2837);

                System.IO.Stream
                f_495_1734_1751(Microsoft.Cci.ManagedResource
                this_param)
                {
                    var return_v = this_param._streamProvider();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(495, 1734, 1751);
                    return return_v;
                }


                string
                f_495_1931_2000()
                {
                    var return_v = CodeAnalysisResources.ResourceStreamProviderShouldReturnNonNullStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(495, 1931, 2000);
                    return return_v;
                }


                System.InvalidOperationException
                f_495_1901_2001(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(495, 1901, 2001);
                    return return_v;
                }


                long
                f_495_2075_2088(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(495, 2075, 2088);
                    return return_v;
                }


                long
                f_495_2091_2106(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(495, 2091, 2106);
                    return return_v;
                }


                int
                f_495_2134_2166(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteInt32(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(495, 2134, 2166);
                    return 0;
                }


                int
                f_495_2214_2257(System.Reflection.Metadata.BlobBuilder
                this_param, System.IO.Stream
                source, int
                byteCount)
                {
                    var return_v = this_param.TryWriteBytes(source, byteCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(495, 2214, 2257);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_495_2450_2478()
                {
                    var return_v = CultureInfo.CurrentUICulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(495, 2450, 2478);
                    return return_v;
                }


                string
                f_495_2480_2533()
                {
                    var return_v = CodeAnalysisResources.ResourceStreamEndedUnexpectedly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(495, 2480, 2533);
                    return return_v;
                }


                string
                f_495_2436_2555(System.Globalization.CultureInfo
                provider, string
                format, int
                arg0, int
                arg1)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(495, 2436, 2555);
                    return return_v;
                }


                System.IO.EndOfStreamException
                f_495_2373_2556(string
                message)
                {
                    var return_v = new System.IO.EndOfStreamException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(495, 2373, 2556);
                    return return_v;
                }


                int
                f_495_2610_2633(System.Reflection.Metadata.BlobBuilder
                this_param, int
                alignment)
                {
                    this_param.Align(alignment);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(495, 2610, 2633);
                    return 0;
                }


                Microsoft.CodeAnalysis.ResourceException
                f_495_2760_2791(string
                name, System.Exception
                inner)
                {
                    var return_v = new Microsoft.CodeAnalysis.ResourceException(name, inner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(495, 2760, 2791);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(495, 1434, 2837);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(495, 1434, 2837);
            }
        }

        public IFileReference? ExternalFile
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(495, 2909, 2982);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(495, 2945, 2967);

                    return _fileReference;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(495, 2909, 2982);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(495, 2849, 2993);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(495, 2849, 2993);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public uint Offset
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(495, 3048, 3114);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(495, 3084, 3099);

                    return _offset;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(495, 3048, 3114);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(495, 3005, 3125);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(495, 3005, 3125);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public IEnumerable<ICustomAttribute> Attributes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(495, 3209, 3283);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(495, 3215, 3281);

                    return f_495_3222_3280();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(495, 3209, 3283);

                    System.Collections.Generic.IEnumerable<Microsoft.Cci.ICustomAttribute>
                    f_495_3222_3280()
                    {
                        var return_v = SpecializedCollections.EmptyEnumerable<ICustomAttribute>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(495, 3222, 3280);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(495, 3137, 3294);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(495, 3137, 3294);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(495, 3351, 3376);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(495, 3357, 3374);

                    return _isPublic;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(495, 3351, 3376);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(495, 3306, 3387);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(495, 3306, 3387);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(495, 3442, 3463);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(495, 3448, 3461);

                    return _name;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(495, 3442, 3463);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(495, 3399, 3474);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(495, 3399, 3474);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static ManagedResource()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(495, 457, 3481);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(495, 457, 3481);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(495, 457, 3481);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(495, 457, 3481);

        static int
        f_495_1157_1223(bool
        b)
        {
            RoslynDebug.Assert(b);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(495, 1157, 1223);
            return 0;
        }

    }
}
