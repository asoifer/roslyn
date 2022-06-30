// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.IO;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    public sealed partial class ModuleMetadata : Metadata
    {
        private bool _isDisposed;

        private readonly PEModule _module;

        private ModuleMetadata(PEReader peReader)
        : base(isImageOwner: f_434_935_953_C(true), id: f_434_959_983())
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(434, 873, 1178);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(434, 803, 814);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(434, 853, 860);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(434, 1009, 1167);

                _module = f_434_1019_1166(this, peReader: peReader, metadataOpt: IntPtr.Zero, metadataSizeOpt: 0, includeEmbeddedInteropTypes: false, ignoreAssemblyRefs: false);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(434, 873, 1178);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(434, 873, 1178);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(434, 873, 1178);
            }
        }

        private ModuleMetadata(IntPtr metadata, int size, bool includeEmbeddedInteropTypes, bool ignoreAssemblyRefs)
        : base(isImageOwner: f_434_1319_1337_C(true), id: f_434_1343_1367())
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(434, 1190, 1593);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(434, 803, 814);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(434, 853, 860);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(434, 1393, 1582);

                _module = f_434_1403_1581(this, peReader: null, metadataOpt: metadata, metadataSizeOpt: size, includeEmbeddedInteropTypes: includeEmbeddedInteropTypes, ignoreAssemblyRefs: ignoreAssemblyRefs);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(434, 1190, 1593);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(434, 1190, 1593);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(434, 1190, 1593);
            }
        }

        private ModuleMetadata(ModuleMetadata metadata)
        : base(isImageOwner: f_434_1700_1719_C(false), id: f_434_1725_1736(metadata))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(434, 1632, 1799);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(434, 803, 814);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(434, 853, 860);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(434, 1762, 1788);

                _module = f_434_1772_1787(metadata);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(434, 1632, 1799);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(434, 1632, 1799);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(434, 1632, 1799);
            }
        }

        public static ModuleMetadata CreateFromMetadata(IntPtr metadata, int size)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(434, 2425, 2955);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(434, 2524, 2650) || true) && (metadata == IntPtr.Zero)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(434, 2524, 2650);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(434, 2585, 2635);

                    throw f_434_2591_2634(nameof(metadata));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(434, 2524, 2650);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(434, 2666, 2823) || true) && (size <= 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(434, 2666, 2823);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(434, 2713, 2808);

                    throw f_434_2719_2807(f_434_2751_2792(), nameof(size));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(434, 2666, 2823);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(434, 2839, 2944);

                return f_434_2846_2943(metadata, size, includeEmbeddedInteropTypes: false, ignoreAssemblyRefs: false);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(434, 2425, 2955);

                System.ArgumentNullException
                f_434_2591_2634(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(434, 2591, 2634);
                    return return_v;
                }


                string
                f_434_2751_2792()
                {
                    var return_v = CodeAnalysisResources.SizeHasToBePositive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(434, 2751, 2792);
                    return return_v;
                }


                System.ArgumentOutOfRangeException
                f_434_2719_2807(string
                paramName, string
                message)
                {
                    var return_v = new System.ArgumentOutOfRangeException(paramName, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(434, 2719, 2807);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ModuleMetadata
                f_434_2846_2943(System.IntPtr
                metadata, int
                size, bool
                includeEmbeddedInteropTypes, bool
                ignoreAssemblyRefs)
                {
                    var return_v = new Microsoft.CodeAnalysis.ModuleMetadata(metadata, size, includeEmbeddedInteropTypes: includeEmbeddedInteropTypes, ignoreAssemblyRefs: ignoreAssemblyRefs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(434, 2846, 2943);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(434, 2425, 2955);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(434, 2425, 2955);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ModuleMetadata CreateFromMetadata(IntPtr metadata, int size, bool includeEmbeddedInteropTypes, bool ignoreAssemblyRefs = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(434, 2967, 3326);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(434, 3135, 3173);

                f_434_3135_3172(metadata != IntPtr.Zero);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(434, 3187, 3210);

                f_434_3187_3209(size > 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(434, 3224, 3315);

                return f_434_3231_3314(metadata, size, includeEmbeddedInteropTypes, ignoreAssemblyRefs);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(434, 2967, 3326);

                int
                f_434_3135_3172(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(434, 3135, 3172);
                    return 0;
                }


                int
                f_434_3187_3209(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(434, 3187, 3209);
                    return 0;
                }


                Microsoft.CodeAnalysis.ModuleMetadata
                f_434_3231_3314(System.IntPtr
                metadata, int
                size, bool
                includeEmbeddedInteropTypes, bool
                ignoreAssemblyRefs)
                {
                    var return_v = new Microsoft.CodeAnalysis.ModuleMetadata(metadata, size, includeEmbeddedInteropTypes, ignoreAssemblyRefs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(434, 3231, 3314);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(434, 2967, 3326);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(434, 2967, 3326);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static unsafe ModuleMetadata CreateFromImage(IntPtr peImage, int size)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(434, 3905, 4393);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(434, 4007, 4131) || true) && (peImage == IntPtr.Zero)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(434, 4007, 4131);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(434, 4067, 4116);

                    throw f_434_4073_4115(nameof(peImage));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(434, 4007, 4131);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(434, 4147, 4304) || true) && (size <= 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(434, 4147, 4304);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(434, 4194, 4289);

                    throw f_434_4200_4288(f_434_4232_4273(), nameof(size));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(434, 4147, 4304);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(434, 4320, 4382);

                return f_434_4327_4381(f_434_4346_4380(peImage, size));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(434, 3905, 4393);

                System.ArgumentNullException
                f_434_4073_4115(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(434, 4073, 4115);
                    return return_v;
                }


                string
                f_434_4232_4273()
                {
                    var return_v = CodeAnalysisResources.SizeHasToBePositive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(434, 4232, 4273);
                    return return_v;
                }


                System.ArgumentOutOfRangeException
                f_434_4200_4288(string
                paramName, string
                message)
                {
                    var return_v = new System.ArgumentOutOfRangeException(paramName, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(434, 4200, 4288);
                    return return_v;
                }


                System.Reflection.PortableExecutable.PEReader
                f_434_4346_4380(System.IntPtr
                peImage, int
                size)
                {
                    var return_v = new System.Reflection.PortableExecutable.PEReader((byte*)peImage, size);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(434, 4346, 4380);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ModuleMetadata
                f_434_4327_4381(System.Reflection.PortableExecutable.PEReader
                peReader)
                {
                    var return_v = new Microsoft.CodeAnalysis.ModuleMetadata(peReader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(434, 4327, 4381);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(434, 3905, 4393);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(434, 3905, 4393);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ModuleMetadata CreateFromImage(IEnumerable<byte> peImage)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(434, 4726, 5026);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(434, 4822, 4939) || true) && (peImage == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(434, 4822, 4939);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(434, 4875, 4924);

                    throw f_434_4881_4923(nameof(peImage));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(434, 4822, 4939);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(434, 4955, 5015);

                return f_434_4962_5014(f_434_4978_5013(peImage));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(434, 4726, 5026);

                System.ArgumentNullException
                f_434_4881_4923(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(434, 4881, 4923);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_434_4978_5013(System.Collections.Generic.IEnumerable<byte>
                items)
                {
                    var return_v = ImmutableArray.CreateRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(434, 4978, 5013);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ModuleMetadata
                f_434_4962_5014(System.Collections.Immutable.ImmutableArray<byte>
                peImage)
                {
                    var return_v = CreateFromImage(peImage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(434, 4962, 5014);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(434, 4726, 5026);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(434, 4726, 5026);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ModuleMetadata CreateFromImage(ImmutableArray<byte> peImage)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(434, 5348, 5642);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(434, 5447, 5566) || true) && (peImage.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(434, 5447, 5566);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(434, 5502, 5551);

                    throw f_434_5508_5550(nameof(peImage));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(434, 5447, 5566);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(434, 5582, 5631);

                return f_434_5589_5630(f_434_5608_5629(peImage));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(434, 5348, 5642);

                System.ArgumentNullException
                f_434_5508_5550(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(434, 5508, 5550);
                    return return_v;
                }


                System.Reflection.PortableExecutable.PEReader
                f_434_5608_5629(System.Collections.Immutable.ImmutableArray<byte>
                peImage)
                {
                    var return_v = new System.Reflection.PortableExecutable.PEReader(peImage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(434, 5608, 5629);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ModuleMetadata
                f_434_5589_5630(System.Reflection.PortableExecutable.PEReader
                peReader)
                {
                    var return_v = new Microsoft.CodeAnalysis.ModuleMetadata(peReader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(434, 5589, 5630);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(434, 5348, 5642);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(434, 5348, 5642);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ModuleMetadata CreateFromStream(Stream peStream, bool leaveOpen = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(434, 6393, 6614);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(434, 6504, 6603);

                return f_434_6511_6602(peStream, (DynAbs.Tracing.TraceSender.Conditional_F1(434, 6538, 6547) || ((leaveOpen && DynAbs.Tracing.TraceSender.Conditional_F2(434, 6550, 6575)) || DynAbs.Tracing.TraceSender.Conditional_F3(434, 6578, 6601))) ? PEStreamOptions.LeaveOpen : PEStreamOptions.Default);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(434, 6393, 6614);

                Microsoft.CodeAnalysis.ModuleMetadata
                f_434_6511_6602(System.IO.Stream
                peStream, System.Reflection.PortableExecutable.PEStreamOptions
                options)
                {
                    var return_v = CreateFromStream(peStream, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(434, 6511, 6602);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(434, 6393, 6614);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(434, 6393, 6614);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ModuleMetadata CreateFromStream(Stream peStream, PEStreamOptions options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(434, 8077, 9019);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(434, 8189, 8308) || true) && (peStream == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(434, 8189, 8308);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(434, 8243, 8293);

                    throw f_434_8249_8292(nameof(peStream));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(434, 8189, 8308);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(434, 8324, 8513) || true) && (f_434_8328_8345_M(!peStream.CanRead) || (DynAbs.Tracing.TraceSender.Expression_False(434, 8328, 8366) || f_434_8349_8366_M(!peStream.CanSeek)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(434, 8324, 8513);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(434, 8400, 8498);

                    throw f_434_8406_8497(f_434_8428_8478(), nameof(peStream));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(434, 8324, 8513);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(434, 8612, 8870) || true) && (f_434_8616_8631(peStream) == 0 && (DynAbs.Tracing.TraceSender.Expression_True(434, 8616, 8692) && (options & PEStreamOptions.PrefetchEntireImage) != 0) && (DynAbs.Tracing.TraceSender.Expression_True(434, 8616, 8745) && (options & PEStreamOptions.PrefetchMetadata) != 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(434, 8612, 8870);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(434, 8831, 8855);

                    f_434_8831_8854(peStream);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(434, 8612, 8870);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(434, 8949, 9008);

                return f_434_8956_9007(f_434_8975_9006(peStream, options));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(434, 8077, 9019);

                System.ArgumentNullException
                f_434_8249_8292(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(434, 8249, 8292);
                    return return_v;
                }


                bool
                f_434_8328_8345_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(434, 8328, 8345);
                    return return_v;
                }


                bool
                f_434_8349_8366_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(434, 8349, 8366);
                    return return_v;
                }


                string
                f_434_8428_8478()
                {
                    var return_v = CodeAnalysisResources.StreamMustSupportReadAndSeek;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(434, 8428, 8478);
                    return return_v;
                }


                System.ArgumentException
                f_434_8406_8497(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(434, 8406, 8497);
                    return return_v;
                }


                long
                f_434_8616_8631(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(434, 8616, 8631);
                    return return_v;
                }


                System.Reflection.PortableExecutable.PEHeaders
                f_434_8831_8854(System.IO.Stream
                peStream)
                {
                    var return_v = new System.Reflection.PortableExecutable.PEHeaders(peStream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(434, 8831, 8854);
                    return return_v;
                }


                System.Reflection.PortableExecutable.PEReader
                f_434_8975_9006(System.IO.Stream
                peStream, System.Reflection.PortableExecutable.PEStreamOptions
                options)
                {
                    var return_v = new System.Reflection.PortableExecutable.PEReader(peStream, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(434, 8975, 9006);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ModuleMetadata
                f_434_8956_9007(System.Reflection.PortableExecutable.PEReader
                peReader)
                {
                    var return_v = new Microsoft.CodeAnalysis.ModuleMetadata(peReader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(434, 8956, 9007);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(434, 8077, 9019);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(434, 8077, 9019);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ModuleMetadata CreateFromFile(string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(434, 10030, 10182);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(434, 10111, 10171);

                return f_434_10118_10170(f_434_10135_10169(path));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(434, 10030, 10182);

                System.IO.Stream
                f_434_10135_10169(string
                path)
                {
                    var return_v = FileUtilities.OpenFileStream(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(434, 10135, 10169);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ModuleMetadata
                f_434_10118_10170(System.IO.Stream
                peStream)
                {
                    var return_v = CreateFromStream(peStream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(434, 10118, 10170);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(434, 10030, 10182);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(434, 10030, 10182);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal new ModuleMetadata Copy()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(434, 10751, 10853);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(434, 10810, 10842);

                return f_434_10817_10841(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(434, 10751, 10853);

                Microsoft.CodeAnalysis.ModuleMetadata
                f_434_10817_10841(Microsoft.CodeAnalysis.ModuleMetadata
                metadata)
                {
                    var return_v = new Microsoft.CodeAnalysis.ModuleMetadata(metadata);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(434, 10817, 10841);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(434, 10751, 10853);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(434, 10751, 10853);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override Metadata CommonCopy()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(434, 10865, 10955);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(434, 10930, 10944);

                return f_434_10937_10943(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(434, 10865, 10955);

                Microsoft.CodeAnalysis.ModuleMetadata
                f_434_10937_10943(Microsoft.CodeAnalysis.ModuleMetadata
                this_param)
                {
                    var return_v = this_param.Copy();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(434, 10937, 10943);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(434, 10865, 10955);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(434, 10865, 10955);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(434, 11078, 11262);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(434, 11133, 11152);

                _isDisposed = true;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(434, 11168, 11251) || true) && (IsImageOwner)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(434, 11168, 11251);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(434, 11218, 11236);

                    f_434_11218_11235(_module);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(434, 11168, 11251);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(434, 11078, 11262);

                int
                f_434_11218_11235(Microsoft.CodeAnalysis.PEModule
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(434, 11218, 11235);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(434, 11078, 11262);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(434, 11078, 11262);
            }
        }

        public bool IsDisposed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(434, 11419, 11468);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(434, 11425, 11466);

                    return _isDisposed || (DynAbs.Tracing.TraceSender.Expression_False(434, 11432, 11465) || f_434_11447_11465(_module));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(434, 11419, 11468);

                    bool
                    f_434_11447_11465(Microsoft.CodeAnalysis.PEModule
                    this_param)
                    {
                        var return_v = this_param.IsDisposed;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(434, 11447, 11465);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(434, 11372, 11479);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(434, 11372, 11479);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal PEModule Module
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(434, 11540, 11759);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(434, 11576, 11709) || true) && (f_434_11580_11590())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(434, 11576, 11709);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(434, 11632, 11690);

                        throw f_434_11638_11689(nameof(ModuleMetadata));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(434, 11576, 11709);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(434, 11729, 11744);

                    return _module;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(434, 11540, 11759);

                    bool
                    f_434_11580_11590()
                    {
                        var return_v = IsDisposed;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(434, 11580, 11590);
                        return return_v;
                    }


                    System.ObjectDisposedException
                    f_434_11638_11689(string
                    objectName)
                    {
                        var return_v = new System.ObjectDisposedException(objectName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(434, 11638, 11689);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(434, 11491, 11770);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(434, 11491, 11770);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(434, 12083, 12110);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(434, 12089, 12108);

                    return f_434_12096_12107(f_434_12096_12102());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(434, 12083, 12110);

                    Microsoft.CodeAnalysis.PEModule
                    f_434_12096_12102()
                    {
                        var return_v = Module;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(434, 12096, 12102);
                        return return_v;
                    }


                    string
                    f_434_12096_12107(Microsoft.CodeAnalysis.PEModule
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(434, 12096, 12107);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(434, 12040, 12121);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(434, 12040, 12121);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public Guid GetModuleVersionId()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(434, 12402, 12512);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(434, 12459, 12501);

                return f_434_12466_12500(f_434_12466_12472());
                DynAbs.Tracing.TraceSender.TraceExitMethod(434, 12402, 12512);

                Microsoft.CodeAnalysis.PEModule
                f_434_12466_12472()
                {
                    var return_v = Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(434, 12466, 12472);
                    return return_v;
                }


                System.Guid
                f_434_12466_12500(Microsoft.CodeAnalysis.PEModule
                this_param)
                {
                    var return_v = this_param.GetModuleVersionIdOrThrow();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(434, 12466, 12500);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(434, 12402, 12512);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(434, 12402, 12512);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override MetadataImageKind Kind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(434, 12710, 12750);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(434, 12716, 12748);

                    return MetadataImageKind.Module;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(434, 12710, 12750);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(434, 12647, 12761);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(434, 12647, 12761);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ImmutableArray<string> GetModuleNames()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(434, 13087, 13215);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(434, 13158, 13204);

                return f_434_13165_13203(f_434_13165_13171());
                DynAbs.Tracing.TraceSender.TraceExitMethod(434, 13087, 13215);

                Microsoft.CodeAnalysis.PEModule
                f_434_13165_13171()
                {
                    var return_v = Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(434, 13165, 13171);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_434_13165_13203(Microsoft.CodeAnalysis.PEModule
                this_param)
                {
                    var return_v = this_param.GetMetadataModuleNamesOrThrow();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(434, 13165, 13203);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(434, 13087, 13215);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(434, 13087, 13215);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public MetadataReader GetMetadataReader()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(434, 13562, 13579);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(434, 13565, 13579);
                return f_434_13565_13579(); DynAbs.Tracing.TraceSender.TraceExitMethod(434, 13562, 13579);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(434, 13562, 13579);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(434, 13562, 13579);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Reflection.Metadata.MetadataReader
            f_434_13565_13579()
            {
                var return_v = MetadataReader;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(434, 13565, 13579);
                return return_v;
            }

        }

        internal MetadataReader MetadataReader
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(434, 13631, 13655);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(434, 13634, 13655);
                    return f_434_13634_13655(f_434_13634_13640()); DynAbs.Tracing.TraceSender.TraceExitMethod(434, 13631, 13655);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(434, 13631, 13655);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(434, 13631, 13655);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public PortableExecutableReference GetReference(DocumentationProvider? documentation = null, string? filePath = null, string? display = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(434, 14218, 14505);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(434, 14384, 14494);

                return f_434_14391_14493(this, MetadataReferenceProperties.Module, documentation, filePath, display);
                DynAbs.Tracing.TraceSender.TraceExitMethod(434, 14218, 14505);

                Microsoft.CodeAnalysis.MetadataImageReference
                f_434_14391_14493(Microsoft.CodeAnalysis.ModuleMetadata
                metadata, Microsoft.CodeAnalysis.MetadataReferenceProperties
                properties, Microsoft.CodeAnalysis.DocumentationProvider?
                documentation, string?
                filePath, string?
                display)
                {
                    var return_v = new Microsoft.CodeAnalysis.MetadataImageReference((Microsoft.CodeAnalysis.Metadata)metadata, properties, documentation, filePath, display);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(434, 14391, 14493);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(434, 14218, 14505);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(434, 14218, 14505);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ModuleMetadata()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(434, 720, 14512);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(434, 720, 14512);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(434, 720, 14512);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(434, 720, 14512);

        static Microsoft.CodeAnalysis.MetadataId
        f_434_959_983()
        {
            var return_v = MetadataId.CreateNewId();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(434, 959, 983);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PEModule
        f_434_1019_1166(Microsoft.CodeAnalysis.ModuleMetadata
        owner, System.Reflection.PortableExecutable.PEReader
        peReader, System.IntPtr
        metadataOpt, int
        metadataSizeOpt, bool
        includeEmbeddedInteropTypes, bool
        ignoreAssemblyRefs)
        {
            var return_v = new Microsoft.CodeAnalysis.PEModule(owner, peReader: peReader, metadataOpt: metadataOpt, metadataSizeOpt: metadataSizeOpt, includeEmbeddedInteropTypes: includeEmbeddedInteropTypes, ignoreAssemblyRefs: ignoreAssemblyRefs);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(434, 1019, 1166);
            return return_v;
        }


        static bool
        f_434_935_953_C(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(434, 873, 1178);
            return return_v;
        }


        static Microsoft.CodeAnalysis.MetadataId
        f_434_1343_1367()
        {
            var return_v = MetadataId.CreateNewId();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(434, 1343, 1367);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PEModule
        f_434_1403_1581(Microsoft.CodeAnalysis.ModuleMetadata
        owner, System.Reflection.PortableExecutable.PEReader
        peReader, System.IntPtr
        metadataOpt, int
        metadataSizeOpt, bool
        includeEmbeddedInteropTypes, bool
        ignoreAssemblyRefs)
        {
            var return_v = new Microsoft.CodeAnalysis.PEModule(owner, peReader: peReader, metadataOpt: metadataOpt, metadataSizeOpt: metadataSizeOpt, includeEmbeddedInteropTypes: includeEmbeddedInteropTypes, ignoreAssemblyRefs: ignoreAssemblyRefs);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(434, 1403, 1581);
            return return_v;
        }


        static bool
        f_434_1319_1337_C(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(434, 1190, 1593);
            return return_v;
        }


        static Microsoft.CodeAnalysis.MetadataId
        f_434_1725_1736(Microsoft.CodeAnalysis.ModuleMetadata
        this_param)
        {
            var return_v = this_param.Id;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(434, 1725, 1736);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PEModule
        f_434_1772_1787(Microsoft.CodeAnalysis.ModuleMetadata
        this_param)
        {
            var return_v = this_param.Module;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(434, 1772, 1787);
            return return_v;
        }


        static bool
        f_434_1700_1719_C(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(434, 1632, 1799);
            return return_v;
        }


        Microsoft.CodeAnalysis.PEModule
        f_434_13634_13640()
        {
            var return_v = Module;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(434, 13634, 13640);
            return return_v;
        }


        System.Reflection.Metadata.MetadataReader
        f_434_13634_13655(Microsoft.CodeAnalysis.PEModule
        this_param)
        {
            var return_v = this_param.MetadataReader;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(434, 13634, 13655);
            return return_v;
        }

    }
}
