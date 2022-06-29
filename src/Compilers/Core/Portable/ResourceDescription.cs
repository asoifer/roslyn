// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.IO;
using Roslyn.Utilities;
using Microsoft.CodeAnalysis.Emit;
using System.Reflection;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Security.Cryptography;

namespace Microsoft.CodeAnalysis
{
    public sealed class ResourceDescription : Cci.IFileReference
    {
        internal readonly string ResourceName;

        internal readonly string? FileName;

        internal readonly bool IsPublic;

        internal readonly Func<Stream> DataProvider;

        private readonly CryptographicHashProvider _hashes;

        public ResourceDescription(string resourceName, Func<Stream> dataProvider, bool isPublic)
        : this(f_28_1647_1659_C(resourceName), fileName: null, dataProvider, isPublic, isEmbedded: true, checkArgs: true)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(28, 1537, 1757);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(28, 1537, 1757);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28, 1537, 1757);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28, 1537, 1757);
            }
        }

        public ResourceDescription(string resourceName, string? fileName, Func<Stream> dataProvider, bool isPublic)
        : this(f_28_2606_2618_C(resourceName), fileName, dataProvider, isPublic, isEmbedded: false, checkArgs: true)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(28, 2478, 2711);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(28, 2478, 2711);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28, 2478, 2711);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28, 2478, 2711);
            }
        }

        internal ResourceDescription(string resourceName, string? fileName, Func<Stream> dataProvider, bool isPublic, bool isEmbedded, bool checkArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(28, 2723, 4233);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28, 709, 721);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28, 758, 766);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28, 820, 828);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28, 870, 882);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28, 936, 943);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(28, 2890, 3973) || true) && (checkArgs)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(28, 2890, 3973);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(28, 2937, 3076) || true) && (dataProvider == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(28, 2937, 3076);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(28, 3003, 3057);

                        throw f_28_3009_3056(nameof(dataProvider));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(28, 2937, 3076);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(28, 3096, 3235) || true) && (resourceName == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(28, 3096, 3235);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(28, 3162, 3216);

                        throw f_28_3168_3215(nameof(resourceName));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(28, 3096, 3235);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(28, 3255, 3476) || true) && (!f_28_3260_3315(resourceName))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(28, 3255, 3476);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(28, 3357, 3457);

                        throw f_28_3363_3456(f_28_3385_3433(), nameof(resourceName));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(28, 3255, 3476);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(28, 3496, 3958) || true) && (!isEmbedded)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(28, 3496, 3958);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(28, 3553, 3696) || true) && (fileName == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(28, 3553, 3696);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(28, 3623, 3673);

                            throw f_28_3629_3672(nameof(fileName));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(28, 3553, 3696);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(28, 3720, 3939) || true) && (!f_28_3725_3774(fileName))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(28, 3720, 3939);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(28, 3824, 3916);

                            throw f_28_3830_3915(f_28_3852_3896(), nameof(fileName));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(28, 3720, 3939);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(28, 3496, 3958);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(28, 2890, 3973);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28, 3989, 4022);

                this.ResourceName = resourceName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28, 4036, 4069);

                this.DataProvider = dataProvider;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28, 4083, 4128);

                this.FileName = (DynAbs.Tracing.TraceSender.Conditional_F1(28, 4099, 4109) || ((isEmbedded && DynAbs.Tracing.TraceSender.Conditional_F2(28, 4112, 4116)) || DynAbs.Tracing.TraceSender.Conditional_F3(28, 4119, 4127))) ? null : fileName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28, 4142, 4167);

                this.IsPublic = isPublic;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28, 4181, 4222);

                _hashes = f_28_4191_4221(this);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(28, 2723, 4233);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28, 2723, 4233);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28, 2723, 4233);
            }
        }
        private sealed class ResourceHashProvider : CryptographicHashProvider
        {
            private readonly ResourceDescription _resource;

            public ResourceHashProvider(ResourceDescription resource)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(28, 4402, 4583);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(28, 4376, 4385);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(28, 4492, 4529);

                    f_28_4492_4528(resource != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(28, 4547, 4568);

                    _resource = resource;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(28, 4402, 4583);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28, 4402, 4583);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28, 4402, 4583);
                }
            }

            internal override ImmutableArray<byte> ComputeHash(HashAlgorithm algorithm)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(28, 4599, 5353);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(28, 4751, 5169);
                        using (var
                        stream = f_28_4771_4795(_resource)
                        )
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(28, 4845, 5053) || true) && (stream == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(28, 4845, 5053);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28, 4921, 5026);

                                throw f_28_4927_5025(f_28_4957_5024());
                                DynAbs.Tracing.TraceSender.TraceExitCondition(28, 4845, 5053);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(28, 5081, 5146);

                            return f_28_5088_5145(f_28_5115_5144(algorithm, stream));
                            DynAbs.Tracing.TraceSender.TraceExitUsing(28, 4751, 5169);
                        }
                    }
                    catch (Exception ex)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(28, 5206, 5338);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(28, 5267, 5319);

                        throw f_28_5273_5318(_resource.FileName, ex);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(28, 5206, 5338);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(28, 4599, 5353);

                    System.IO.Stream
                    f_28_4771_4795(Microsoft.CodeAnalysis.ResourceDescription
                    this_param)
                    {
                        var return_v = this_param.DataProvider();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(28, 4771, 4795);
                        return return_v;
                    }


                    string
                    f_28_4957_5024()
                    {
                        var return_v = CodeAnalysisResources.ResourceDataProviderShouldReturnNonNullStream;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(28, 4957, 5024);
                        return return_v;
                    }


                    System.InvalidOperationException
                    f_28_4927_5025(string
                    message)
                    {
                        var return_v = new System.InvalidOperationException(message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(28, 4927, 5025);
                        return return_v;
                    }


                    byte[]
                    f_28_5115_5144(System.Security.Cryptography.HashAlgorithm
                    this_param, System.IO.Stream
                    inputStream)
                    {
                        var return_v = this_param.ComputeHash(inputStream);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(28, 5115, 5144);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<byte>
                    f_28_5088_5145(byte[]
                    items)
                    {
                        var return_v = ImmutableArray.CreateRange((System.Collections.Generic.IEnumerable<byte>)items);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(28, 5088, 5145);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ResourceException
                    f_28_5273_5318(string?
                    name, System.Exception
                    inner)
                    {
                        var return_v = new Microsoft.CodeAnalysis.ResourceException(name, inner);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(28, 5273, 5318);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28, 4599, 5353);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28, 4599, 5353);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static ResourceHashProvider()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(28, 4245, 5364);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(28, 4245, 5364);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28, 4245, 5364);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(28, 4245, 5364);

            static int
            f_28_4492_4528(bool
            b)
            {
                RoslynDebug.Assert(b);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(28, 4492, 4528);
                return 0;
            }

        }

        internal bool IsEmbedded
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(28, 5425, 5457);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(28, 5431, 5455);

                    return FileName == null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(28, 5425, 5457);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28, 5376, 5468);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28, 5376, 5468);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal Cci.ManagedResource ToManagedResource(CommonPEModuleBuilder moduleBeingBuilt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28, 5480, 5728);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28, 5591, 5717);

                return f_28_5598_5716(ResourceName, IsPublic, (DynAbs.Tracing.TraceSender.Conditional_F1(28, 5646, 5656) || ((f_28_5646_5656() && DynAbs.Tracing.TraceSender.Conditional_F2(28, 5659, 5671)) || DynAbs.Tracing.TraceSender.Conditional_F3(28, 5674, 5678))) ? DataProvider : null, (DynAbs.Tracing.TraceSender.Conditional_F1(28, 5680, 5690) || ((f_28_5680_5690() && DynAbs.Tracing.TraceSender.Conditional_F2(28, 5693, 5697)) || DynAbs.Tracing.TraceSender.Conditional_F3(28, 5700, 5704))) ? null : this, offset: 0);
                DynAbs.Tracing.TraceSender.TraceExitMethod(28, 5480, 5728);

                bool
                f_28_5646_5656()
                {
                    var return_v = IsEmbedded;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(28, 5646, 5656);
                    return return_v;
                }


                bool
                f_28_5680_5690()
                {
                    var return_v = IsEmbedded;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(28, 5680, 5690);
                    return return_v;
                }


                Microsoft.Cci.ManagedResource
                f_28_5598_5716(string
                name, bool
                isPublic, System.Func<System.IO.Stream>?
                streamProvider, Microsoft.CodeAnalysis.ResourceDescription?
                fileReference, int
                offset)
                {
                    var return_v = new Microsoft.Cci.ManagedResource(name, isPublic, streamProvider, (Microsoft.Cci.IFileReference?)fileReference, offset: (uint)offset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28, 5598, 5716);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28, 5480, 5728);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28, 5480, 5728);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        ImmutableArray<byte> Cci.IFileReference.GetHashValue(AssemblyHashAlgorithm algorithmId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28, 5740, 5899);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28, 5852, 5888);

                return f_28_5859_5887(_hashes, algorithmId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(28, 5740, 5899);

                System.Collections.Immutable.ImmutableArray<byte>
                f_28_5859_5887(Microsoft.CodeAnalysis.CryptographicHashProvider
                this_param, System.Reflection.AssemblyHashAlgorithm
                algorithmId)
                {
                    var return_v = this_param.GetHash(algorithmId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28, 5859, 5887);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28, 5740, 5899);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28, 5740, 5899);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        string? Cci.IFileReference.FileName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(28, 5971, 5995);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(28, 5977, 5993);

                    return FileName;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(28, 5971, 5995);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28, 5911, 6006);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28, 5911, 6006);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool Cci.IFileReference.HasMetadata
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(28, 6078, 6099);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(28, 6084, 6097);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(28, 6078, 6099);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28, 6018, 6110);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28, 6018, 6110);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static ResourceDescription()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(28, 607, 6117);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(28, 607, 6117);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28, 607, 6117);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(28, 607, 6117);

        static string
        f_28_1647_1659_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(28, 1537, 1757);
            return return_v;
        }


        static string
        f_28_2606_2618_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(28, 2478, 2711);
            return return_v;
        }


        static System.ArgumentNullException
        f_28_3009_3056(string
        paramName)
        {
            var return_v = new System.ArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(28, 3009, 3056);
            return return_v;
        }


        static System.ArgumentNullException
        f_28_3168_3215(string
        paramName)
        {
            var return_v = new System.ArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(28, 3168, 3215);
            return return_v;
        }


        static bool
        f_28_3260_3315(string
        str)
        {
            var return_v = MetadataHelpers.IsValidMetadataIdentifier(str);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(28, 3260, 3315);
            return return_v;
        }


        static string
        f_28_3385_3433()
        {
            var return_v = CodeAnalysisResources.EmptyOrInvalidResourceName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(28, 3385, 3433);
            return return_v;
        }


        static System.ArgumentException
        f_28_3363_3456(string
        message, string
        paramName)
        {
            var return_v = new System.ArgumentException(message, paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(28, 3363, 3456);
            return return_v;
        }


        static System.ArgumentNullException
        f_28_3629_3672(string
        paramName)
        {
            var return_v = new System.ArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(28, 3629, 3672);
            return return_v;
        }


        static bool
        f_28_3725_3774(string
        name)
        {
            var return_v = MetadataHelpers.IsValidMetadataFileName(name);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(28, 3725, 3774);
            return return_v;
        }


        static string
        f_28_3852_3896()
        {
            var return_v = CodeAnalysisResources.EmptyOrInvalidFileName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(28, 3852, 3896);
            return return_v;
        }


        static System.ArgumentException
        f_28_3830_3915(string
        message, string
        paramName)
        {
            var return_v = new System.ArgumentException(message, paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(28, 3830, 3915);
            return return_v;
        }


        static Microsoft.CodeAnalysis.ResourceDescription.ResourceHashProvider
        f_28_4191_4221(Microsoft.CodeAnalysis.ResourceDescription
        resource)
        {
            var return_v = new Microsoft.CodeAnalysis.ResourceDescription.ResourceHashProvider(resource);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(28, 4191, 4221);
            return return_v;
        }

    }
}
