// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Symbols;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    internal sealed class PEModule : IDisposable
    {
        private readonly ModuleMetadata _owner;

        private readonly PEReader _peReaderOpt;

        private readonly IntPtr _metadataPointerOpt;

        private readonly int _metadataSizeOpt;

        private MetadataReader _lazyMetadataReader;

        private ImmutableArray<AssemblyIdentity> _lazyAssemblyReferences;

        private Dictionary<string, (int FirstIndex, int SecondIndex)> _lazyForwardedTypesToAssemblyIndexMap;

        private readonly Lazy<IdentifierCollection> _lazyTypeNameCollection;

        private readonly Lazy<IdentifierCollection> _lazyNamespaceNameCollection;

        private string _lazyName;

        private bool _isDisposed;

        private ThreeState _lazyContainsNoPiaLocalTypes;

        private int[] _lazyNoPiaLocalTypeCheckBitMap;

        private ConcurrentDictionary<TypeDefinitionHandle, AttributeInfo> _lazyTypeDefToTypeIdentifierMap;

        private readonly CryptographicHashProvider _hashesOpt;

        private delegate bool AttributeValueExtractor<T>(out T value, ref BlobReader sigReader);

        private static readonly AttributeValueExtractor<string> s_attributeStringValueExtractor;

        private static readonly AttributeValueExtractor<StringAndInt> s_attributeStringAndIntValueExtractor;

        private static readonly AttributeValueExtractor<bool> s_attributeBooleanValueExtractor;

        private static readonly AttributeValueExtractor<byte> s_attributeByteValueExtractor;

        private static readonly AttributeValueExtractor<short> s_attributeShortValueExtractor;

        private static readonly AttributeValueExtractor<int> s_attributeIntValueExtractor;

        private static readonly AttributeValueExtractor<long> s_attributeLongValueExtractor;

        private static readonly AttributeValueExtractor<decimal> s_decimalValueInDecimalConstantAttributeExtractor;

        private static readonly AttributeValueExtractor<ImmutableArray<bool>> s_attributeBoolArrayValueExtractor;

        private static readonly AttributeValueExtractor<ImmutableArray<byte>> s_attributeByteArrayValueExtractor;

        private static readonly AttributeValueExtractor<ImmutableArray<string>> s_attributeStringArrayValueExtractor;

        private static readonly AttributeValueExtractor<ObsoleteAttributeData> s_attributeDeprecatedDataExtractor;

        private static readonly AttributeValueExtractor<BoolAndStringArrayData> s_attributeBoolAndStringArrayValueExtractor;

        private static readonly AttributeValueExtractor<BoolAndStringData> s_attributeBoolAndStringValueExtractor;

        internal struct BoolAndStringArrayData
        {

            public BoolAndStringArrayData(bool sense, ImmutableArray<string> strings)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(415, 5700, 5871);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 5806, 5820);

                    Sense = sense;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 5838, 5856);

                    Strings = strings;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(415, 5700, 5871);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 5700, 5871);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 5700, 5871);
                }
            }

            public readonly bool Sense;

            public readonly ImmutableArray<string> Strings;
            static BoolAndStringArrayData()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(415, 5637, 5986);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(415, 5637, 5986);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 5637, 5986);
            }
        }

        internal struct BoolAndStringData
        {

            public BoolAndStringData(bool sense, string @string)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(415, 6056, 6205);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 6141, 6155);

                    Sense = sense;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 6173, 6190);

                    String = @string;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(415, 6056, 6205);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 6056, 6205);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 6056, 6205);
                }
            }

            public readonly bool Sense;

            public readonly string String;
            static BoolAndStringData()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(415, 5998, 6303);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(415, 5998, 6303);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 5998, 6303);
            }
        }

        internal PEModule(ModuleMetadata owner, PEReader peReader, IntPtr metadataOpt, int metadataSizeOpt, bool includeEmbeddedInteropTypes, bool ignoreAssemblyRefs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(415, 6523, 7638);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 1298, 1304);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 1429, 1441);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 1527, 1543);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 1579, 1598);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 2095, 2132);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 2189, 2212);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 2267, 2295);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 2323, 2332);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 2356, 2367);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 2515, 2543);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 2887, 2917);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 3194, 3225);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 3501, 3511);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 6740, 6828);

                f_415_6740_6827((peReader == null) ^ (metadataOpt == IntPtr.Zero && (DynAbs.Tracing.TraceSender.Expression_True(415, 6775, 6825) && metadataSizeOpt == 0)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 6842, 6906);

                f_415_6842_6905(metadataOpt == IntPtr.Zero || (DynAbs.Tracing.TraceSender.Expression_False(415, 6855, 6904) || metadataSizeOpt > 0));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 6922, 6937);

                _owner = owner;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 6951, 6975);

                _peReaderOpt = peReader;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 6989, 7023);

                _metadataPointerOpt = metadataOpt;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 7037, 7072);

                _metadataSizeOpt = metadataSizeOpt;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 7086, 7170);

                _lazyTypeNameCollection = f_415_7112_7169(ComputeTypeNameCollection);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 7184, 7278);

                _lazyNamespaceNameCollection = f_415_7215_7277(ComputeNamespaceNameCollection);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 7292, 7362);

                _hashesOpt = (DynAbs.Tracing.TraceSender.Conditional_F1(415, 7305, 7323) || (((peReader != null) && DynAbs.Tracing.TraceSender.Conditional_F2(415, 7326, 7354)) || DynAbs.Tracing.TraceSender.Conditional_F3(415, 7357, 7361))) ? f_415_7326_7354(peReader) : null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 7376, 7475);

                _lazyContainsNoPiaLocalTypes = (DynAbs.Tracing.TraceSender.Conditional_F1(415, 7407, 7434) || ((includeEmbeddedInteropTypes && DynAbs.Tracing.TraceSender.Conditional_F2(415, 7437, 7453)) || DynAbs.Tracing.TraceSender.Conditional_F3(415, 7456, 7474))) ? ThreeState.False : ThreeState.Unknown;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 7491, 7627) || true) && (ignoreAssemblyRefs)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 7491, 7627);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 7547, 7612);

                    _lazyAssemblyReferences = ImmutableArray<AssemblyIdentity>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(415, 7491, 7627);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(415, 6523, 7638);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 6523, 7638);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 6523, 7638);
            }
        }
        private sealed class PEHashProvider : CryptographicHashProvider
        {
            private readonly PEReader _peReader;

            public PEHashProvider(PEReader peReader)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(415, 7790, 7948);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 7764, 7773);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 7863, 7894);

                    f_415_7863_7893(peReader != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 7912, 7933);

                    _peReader = peReader;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(415, 7790, 7948);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 7790, 7948);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 7790, 7948);
                }
            }

            internal override unsafe ImmutableArray<byte> ComputeHash(HashAlgorithm algorithm)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 7964, 8447);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 8079, 8128);

                    PEMemoryBlock
                    block = f_415_8101_8127(_peReader)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 8146, 8158);

                    byte[]
                    hash
                    = default(byte[]);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 8178, 8377);
                    using (var
                    stream = f_415_8198_8279(_peReader, block.Pointer, block.Length)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 8321, 8358);

                        hash = f_415_8328_8357(algorithm, stream);
                        DynAbs.Tracing.TraceSender.TraceExitUsing(415, 8178, 8377);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 8397, 8432);

                    return f_415_8404_8431(hash);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(415, 7964, 8447);

                    System.Reflection.PortableExecutable.PEMemoryBlock
                    f_415_8101_8127(System.Reflection.PortableExecutable.PEReader
                    this_param)
                    {
                        var return_v = this_param.GetEntireImage();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 8101, 8127);
                        return return_v;
                    }


                    unsafe Microsoft.CodeAnalysis.ReadOnlyUnmanagedMemoryStream
                    f_415_8198_8279(System.Reflection.PortableExecutable.PEReader
                    memoryOwner, byte*
                    data, int
                    length)
                    {
                        var return_v = new Microsoft.CodeAnalysis.ReadOnlyUnmanagedMemoryStream((object)memoryOwner, (System.IntPtr)data, length);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 8198, 8279);
                        return return_v;
                    }


                    byte[]
                    f_415_8328_8357(System.Security.Cryptography.HashAlgorithm
                    this_param, Microsoft.CodeAnalysis.ReadOnlyUnmanagedMemoryStream
                    inputStream)
                    {
                        var return_v = this_param.ComputeHash((System.IO.Stream)inputStream);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 8328, 8357);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<byte>
                    f_415_8404_8431(params byte[]
                    items)
                    {
                        var return_v = ImmutableArray.Create(items);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 8404, 8431);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 7964, 8447);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 7964, 8447);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static PEHashProvider()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(415, 7650, 8458);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(415, 7650, 8458);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 7650, 8458);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(415, 7650, 8458);

            static int
            f_415_7863_7893(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 7863, 7893);
                return 0;
            }

        }

        internal bool IsDisposed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 8519, 8589);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 8555, 8574);

                    return _isDisposed;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(415, 8519, 8589);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 8470, 8600);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 8470, 8600);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 8612, 8728);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 8658, 8677);

                _isDisposed = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 8693, 8717);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_peReaderOpt, 415, 8693, 8716)?.Dispose(), 415, 8706, 8716);
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 8612, 8728);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 8612, 8728);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 8612, 8728);
            }
        }

        internal PEReader PEReaderOpt
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 8818, 8889);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 8854, 8874);

                    return _peReaderOpt;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(415, 8818, 8889);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 8764, 8900);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 8764, 8900);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal MetadataReader MetadataReader
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 8975, 9594);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 9011, 9130) || true) && (_lazyMetadataReader == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 9011, 9130);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 9084, 9111);

                        f_415_9084_9110(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 9011, 9130);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 9150, 9532) || true) && (_isDisposed)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 9150, 9532);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 9489, 9513);

                        f_415_9489_9512();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 9150, 9532);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 9552, 9579);

                    return _lazyMetadataReader;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(415, 8975, 9594);

                    int
                    f_415_9084_9110(Microsoft.CodeAnalysis.PEModule
                    this_param)
                    {
                        this_param.InitializeMetadataReader();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 9084, 9110);
                        return 0;
                    }


                    int
                    f_415_9489_9512()
                    {
                        ThrowMetadataDisposed();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 9489, 9512);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 8912, 9605);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 8912, 9605);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private unsafe void InitializeMetadataReader()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 9617, 10942);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 9688, 9713);

                MetadataReader
                newReader
                = default(MetadataReader);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 9815, 10845) || true) && (_metadataPointerOpt != IntPtr.Zero)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 9815, 10845);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 9887, 10047);

                    newReader = f_415_9899_10046(_metadataPointerOpt, _metadataSizeOpt, MetadataReaderOptions.ApplyWindowsRuntimeProjections, StringTableDecoder.Instance);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(415, 9815, 10845);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 9815, 10845);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 10113, 10148);

                    f_415_10113_10147(_peReaderOpt != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 10254, 10271);

                    bool
                    hasMetadata
                    = default(bool);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 10333, 10372);

                        hasMetadata = f_415_10347_10371(_peReaderOpt);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(415, 10409, 10494);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 10455, 10475);

                        hasMetadata = false;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(415, 10409, 10494);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 10514, 10684) || true) && (!hasMetadata)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 10514, 10684);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 10572, 10665);

                        throw f_415_10578_10664(f_415_10606_10663());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 10514, 10684);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 10704, 10830);

                    newReader = f_415_10716_10829(_peReaderOpt, MetadataReaderOptions.ApplyWindowsRuntimeProjections, StringTableDecoder.Instance);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(415, 9815, 10845);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 10861, 10931);

                f_415_10861_10930(ref _lazyMetadataReader, newReader, null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 9617, 10942);

                System.Reflection.Metadata.MetadataReader
                f_415_9899_10046(System.IntPtr
                metadata, int
                length, System.Reflection.Metadata.MetadataReaderOptions
                options, Microsoft.CodeAnalysis.PEModule.StringTableDecoder
                utf8Decoder)
                {
                    var return_v = new System.Reflection.Metadata.MetadataReader((byte*)metadata, length, options, (System.Reflection.Metadata.MetadataStringDecoder)utf8Decoder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 9899, 10046);
                    return return_v;
                }


                int
                f_415_10113_10147(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 10113, 10147);
                    return 0;
                }


                bool
                f_415_10347_10371(System.Reflection.PortableExecutable.PEReader
                this_param)
                {
                    var return_v = this_param.HasMetadata;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 10347, 10371);
                    return return_v;
                }


                string
                f_415_10606_10663()
                {
                    var return_v = CodeAnalysisResources.PEImageDoesntContainManagedMetadata;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 10606, 10663);
                    return return_v;
                }


                System.BadImageFormatException
                f_415_10578_10664(string
                message)
                {
                    var return_v = new System.BadImageFormatException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 10578, 10664);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_415_10716_10829(System.Reflection.PortableExecutable.PEReader
                peReader, System.Reflection.Metadata.MetadataReaderOptions
                options, Microsoft.CodeAnalysis.PEModule.StringTableDecoder
                utf8Decoder)
                {
                    var return_v = peReader.GetMetadataReader(options, (System.Reflection.Metadata.MetadataStringDecoder)utf8Decoder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 10716, 10829);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_415_10861_10930(ref System.Reflection.Metadata.MetadataReader
                location1, System.Reflection.Metadata.MetadataReader
                value, System.Reflection.Metadata.MetadataReader
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 10861, 10930);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 9617, 10942);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 9617, 10942);
            }
        }

        private static void ThrowMetadataDisposed()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(415, 10954, 11091);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 11022, 11080);

                throw f_415_11028_11079(nameof(ModuleMetadata));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(415, 10954, 11091);

                System.ObjectDisposedException
                f_415_11028_11079(string
                objectName)
                {
                    var return_v = new System.ObjectDisposedException(objectName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 11028, 11079);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 10954, 11091);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 10954, 11091);
            }
        }

        internal bool IsManifestModule
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 11213, 11297);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 11249, 11282);

                    return f_415_11256_11281(f_415_11256_11270());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(415, 11213, 11297);

                    System.Reflection.Metadata.MetadataReader
                    f_415_11256_11270()
                    {
                        var return_v = MetadataReader;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 11256, 11270);
                        return return_v;
                    }


                    bool
                    f_415_11256_11281(System.Reflection.Metadata.MetadataReader
                    this_param)
                    {
                        var return_v = this_param.IsAssembly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 11256, 11281);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 11158, 11308);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 11158, 11308);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool IsLinkedModule
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 11373, 11458);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 11409, 11443);

                    return f_415_11416_11442_M(!f_415_11417_11431().IsAssembly);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(415, 11373, 11458);

                    System.Reflection.Metadata.MetadataReader
                    f_415_11417_11431()
                    {
                        var return_v = MetadataReader;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 11417, 11431);
                        return return_v;
                    }


                    bool
                    f_415_11416_11442_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 11416, 11442);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 11320, 11469);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 11320, 11469);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool IsCOFFOnly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 11530, 11799);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 11625, 11723) || true) && (_peReaderOpt == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 11625, 11723);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 11691, 11704);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 11625, 11723);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 11743, 11784);

                    return f_415_11750_11783(f_415_11750_11772(_peReaderOpt));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(415, 11530, 11799);

                    System.Reflection.PortableExecutable.PEHeaders
                    f_415_11750_11772(System.Reflection.PortableExecutable.PEReader
                    this_param)
                    {
                        var return_v = this_param.PEHeaders;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 11750, 11772);
                        return return_v;
                    }


                    bool
                    f_415_11750_11783(System.Reflection.PortableExecutable.PEHeaders
                    this_param)
                    {
                        var return_v = this_param.IsCoffOnly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 11750, 11783);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 11481, 11810);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 11481, 11810);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal Machine Machine
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 11967, 12255);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 12066, 12171) || true) && (_peReaderOpt == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 12066, 12171);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 12132, 12152);

                        return Machine.I386;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 12066, 12171);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 12191, 12240);

                    return f_415_12198_12239(f_415_12198_12231(f_415_12198_12220(_peReaderOpt)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(415, 11967, 12255);

                    System.Reflection.PortableExecutable.PEHeaders
                    f_415_12198_12220(System.Reflection.PortableExecutable.PEReader
                    this_param)
                    {
                        var return_v = this_param.PEHeaders;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 12198, 12220);
                        return return_v;
                    }


                    System.Reflection.PortableExecutable.CoffHeader
                    f_415_12198_12231(System.Reflection.PortableExecutable.PEHeaders
                    this_param)
                    {
                        var return_v = this_param.CoffHeader;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 12198, 12231);
                        return return_v;
                    }


                    System.Reflection.PortableExecutable.Machine
                    f_415_12198_12239(System.Reflection.PortableExecutable.CoffHeader
                    this_param)
                    {
                        var return_v = this_param.Machine;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 12198, 12239);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 11918, 12266);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 11918, 12266);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool Bit32Required
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 12545, 12855);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 12644, 12742) || true) && (_peReaderOpt == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 12644, 12742);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 12710, 12723);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 12644, 12742);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 12762, 12840);

                    return (f_415_12770_12808(f_415_12770_12802(f_415_12770_12792(_peReaderOpt))) & CorFlags.Requires32Bit) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(415, 12545, 12855);

                    System.Reflection.PortableExecutable.PEHeaders
                    f_415_12770_12792(System.Reflection.PortableExecutable.PEReader
                    this_param)
                    {
                        var return_v = this_param.PEHeaders;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 12770, 12792);
                        return return_v;
                    }


                    System.Reflection.PortableExecutable.CorHeader?
                    f_415_12770_12802(System.Reflection.PortableExecutable.PEHeaders
                    this_param)
                    {
                        var return_v = this_param.CorHeader;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 12770, 12802);
                        return return_v;
                    }


                    System.Reflection.PortableExecutable.CorFlags
                    f_415_12770_12808(System.Reflection.PortableExecutable.CorHeader?
                    this_param)
                    {
                        var return_v = this_param.Flags;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 12770, 12808);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 12493, 12866);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 12493, 12866);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal ImmutableArray<byte> GetHash(AssemblyHashAlgorithm algorithmId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 12878, 13072);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 12975, 13008);

                f_415_12975_13007(_hashesOpt != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 13022, 13061);

                return f_415_13029_13060(_hashesOpt, algorithmId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 12878, 13072);

                int
                f_415_12975_13007(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 12975, 13007);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_415_13029_13060(Microsoft.CodeAnalysis.CryptographicHashProvider
                this_param, System.Reflection.AssemblyHashAlgorithm
                algorithmId)
                {
                    var return_v = this_param.GetHash(algorithmId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 13029, 13060);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 12878, 13072);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 12878, 13072);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 13188, 13438);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 13224, 13386) || true) && (_lazyName == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 13224, 13386);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 13287, 13367);

                        _lazyName = f_415_13299_13366(f_415_13299_13313(), f_415_13324_13360(f_415_13324_13338()).Name);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 13224, 13386);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 13406, 13423);

                    return _lazyName;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(415, 13188, 13438);

                    System.Reflection.Metadata.MetadataReader
                    f_415_13299_13313()
                    {
                        var return_v = MetadataReader;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 13299, 13313);
                        return return_v;
                    }


                    System.Reflection.Metadata.MetadataReader
                    f_415_13324_13338()
                    {
                        var return_v = MetadataReader;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 13324, 13338);
                        return return_v;
                    }


                    System.Reflection.Metadata.ModuleDefinition
                    f_415_13324_13360(System.Reflection.Metadata.MetadataReader
                    this_param)
                    {
                        var return_v = this_param.GetModuleDefinition();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 13324, 13360);
                        return return_v;
                    }


                    string
                    f_415_13299_13366(System.Reflection.Metadata.MetadataReader
                    this_param, System.Reflection.Metadata.StringHandle
                    handle)
                    {
                        var return_v = this_param.GetString(handle);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 13299, 13366);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 13143, 13449);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 13143, 13449);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal Guid GetModuleVersionIdOrThrow()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 13563, 13690);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 13629, 13679);

                return f_415_13636_13678(f_415_13636_13650());
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 13563, 13690);

                System.Reflection.Metadata.MetadataReader
                f_415_13636_13650()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 13636, 13650);
                    return return_v;
                }


                System.Guid
                f_415_13636_13678(System.Reflection.Metadata.MetadataReader
                reader)
                {
                    var return_v = reader.GetModuleVersionIdOrThrow();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 13636, 13678);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 13563, 13690);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 13563, 13690);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ImmutableArray<string> GetMetadataModuleNamesOrThrow()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 13974, 15012);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 14062, 14111);

                var
                builder = f_415_14076_14110()
                ;
                try
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 14161, 14853);
                        foreach (var fileHandle in f_415_14188_14216_I(f_415_14188_14216(f_415_14188_14202())))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 14161, 14853);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 14258, 14312);

                            var
                            file = f_415_14269_14311(f_415_14269_14283(), fileHandle)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 14334, 14442) || true) && (f_415_14338_14360_M(!file.ContainsMetadata))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 14334, 14442);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 14410, 14419);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(415, 14334, 14442);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 14466, 14522);

                            string
                            moduleName = f_415_14486_14521(f_415_14486_14500(), file.Name)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 14544, 14786) || true) && (!f_415_14549_14600(moduleName))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 14544, 14786);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 14650, 14763);

                                throw f_415_14656_14762(f_415_14684_14761(f_415_14698_14737(), f_415_14739_14748(this), moduleName));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(415, 14544, 14786);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 14810, 14834);

                            f_415_14810_14833(
                                                builder, moduleName);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(415, 14161, 14853);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(415, 1, 693);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(415, 1, 693);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 14873, 14902);

                    return f_415_14880_14901(builder);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(415, 14931, 15001);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 14971, 14986);

                    f_415_14971_14985(builder);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(415, 14931, 15001);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 13974, 15012);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                f_415_14076_14110()
                {
                    var return_v = ArrayBuilder<string>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 14076, 14110);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_415_14188_14202()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 14188, 14202);
                    return return_v;
                }


                System.Reflection.Metadata.AssemblyFileHandleCollection
                f_415_14188_14216(System.Reflection.Metadata.MetadataReader
                this_param)
                {
                    var return_v = this_param.AssemblyFiles;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 14188, 14216);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_415_14269_14283()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 14269, 14283);
                    return return_v;
                }


                System.Reflection.Metadata.AssemblyFile
                f_415_14269_14311(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.AssemblyFileHandle
                handle)
                {
                    var return_v = this_param.GetAssemblyFile(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 14269, 14311);
                    return return_v;
                }


                bool
                f_415_14338_14360_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 14338, 14360);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_415_14486_14500()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 14486, 14500);
                    return return_v;
                }


                string
                f_415_14486_14521(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.StringHandle
                handle)
                {
                    var return_v = this_param.GetString(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 14486, 14521);
                    return return_v;
                }


                bool
                f_415_14549_14600(string
                name)
                {
                    var return_v = MetadataHelpers.IsValidMetadataFileName(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 14549, 14600);
                    return return_v;
                }


                string
                f_415_14698_14737()
                {
                    var return_v = CodeAnalysisResources.InvalidModuleName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 14698, 14737);
                    return return_v;
                }


                string
                f_415_14739_14748(Microsoft.CodeAnalysis.PEModule
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 14739, 14748);
                    return return_v;
                }


                string
                f_415_14684_14761(string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = string.Format(format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 14684, 14761);
                    return return_v;
                }


                System.BadImageFormatException
                f_415_14656_14762(string
                message)
                {
                    var return_v = new System.BadImageFormatException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 14656, 14762);
                    return return_v;
                }


                int
                f_415_14810_14833(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 14810, 14833);
                    return 0;
                }


                System.Reflection.Metadata.AssemblyFileHandleCollection
                f_415_14188_14216_I(System.Reflection.Metadata.AssemblyFileHandleCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 14188, 14216);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_415_14880_14901(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 14880, 14901);
                    return return_v;
                }


                int
                f_415_14971_14985(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 14971, 14985);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 13974, 15012);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 13974, 15012);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal IEnumerable<string> GetReferencedManagedModulesOrThrow()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 15223, 15943);

                var listYield = new List<String>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 15313, 15376);

                HashSet<EntityHandle>
                nameTokens = f_415_15348_15375()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 15390, 15763);
                    foreach (var handle in f_415_15413_15442_I(f_415_15413_15442(f_415_15413_15427())))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 15390, 15763);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 15476, 15540);

                        TypeReference
                        typeRef = f_415_15500_15539(f_415_15500_15514(), handle)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 15558, 15603);

                        EntityHandle
                        scope = typeRef.ResolutionScope
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 15621, 15748) || true) && (scope.Kind == HandleKind.ModuleReference)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 15621, 15748);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 15707, 15729);

                            f_415_15707_15728(nameTokens, scope);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(415, 15621, 15748);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 15390, 15763);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(415, 1, 374);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(415, 1, 374);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 15779, 15932);
                    foreach (var token in f_415_15801_15811_I(nameTokens))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 15779, 15932);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 15845, 15917);

                        listYield.Add(f_415_15858_15916(this, token));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 15779, 15932);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(415, 1, 154);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(415, 1, 154);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 15223, 15943);

                return listYield;

                System.Collections.Generic.HashSet<System.Reflection.Metadata.EntityHandle>
                f_415_15348_15375()
                {
                    var return_v = new System.Collections.Generic.HashSet<System.Reflection.Metadata.EntityHandle>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 15348, 15375);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_415_15413_15427()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 15413, 15427);
                    return return_v;
                }


                System.Reflection.Metadata.TypeReferenceHandleCollection
                f_415_15413_15442(System.Reflection.Metadata.MetadataReader
                this_param)
                {
                    var return_v = this_param.TypeReferences;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 15413, 15442);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_415_15500_15514()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 15500, 15514);
                    return return_v;
                }


                System.Reflection.Metadata.TypeReference
                f_415_15500_15539(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.TypeReferenceHandle
                handle)
                {
                    var return_v = this_param.GetTypeReference(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 15500, 15539);
                    return return_v;
                }


                bool
                f_415_15707_15728(System.Collections.Generic.HashSet<System.Reflection.Metadata.EntityHandle>
                this_param, System.Reflection.Metadata.EntityHandle
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 15707, 15728);
                    return return_v;
                }


                System.Reflection.Metadata.TypeReferenceHandleCollection
                f_415_15413_15442_I(System.Reflection.Metadata.TypeReferenceHandleCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 15413, 15442);
                    return return_v;
                }


                string
                f_415_15858_15916(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.EntityHandle
                moduleRef)
                {
                    var return_v = this_param.GetModuleRefNameOrThrow((System.Reflection.Metadata.ModuleReferenceHandle)moduleRef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 15858, 15916);
                    return return_v;
                }


                System.Collections.Generic.HashSet<System.Reflection.Metadata.EntityHandle>
                f_415_15801_15811_I(System.Collections.Generic.HashSet<System.Reflection.Metadata.EntityHandle>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 15801, 15811);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 15223, 15943);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 15223, 15943);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ImmutableArray<EmbeddedResource> GetEmbeddedResourcesOrThrow()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 15955, 16792);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 16051, 16193) || true) && (f_415_16055_16069().ManifestResources.Count == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 16051, 16193);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 16132, 16178);

                    return ImmutableArray<EmbeddedResource>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(415, 16051, 16193);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 16209, 16272);

                var
                builder = f_415_16223_16271()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 16286, 16736);
                    foreach (var handle in f_415_16309_16341_I(f_415_16309_16341(f_415_16309_16323())))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 16286, 16736);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 16375, 16433);

                        var
                        resource = f_415_16390_16432(f_415_16390_16404(), handle)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 16451, 16721) || true) && (resource.Implementation.IsNil)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 16451, 16721);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 16526, 16588);

                            string
                            resourceName = f_415_16548_16587(f_415_16548_16562(), resource.Name)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 16610, 16702);

                            f_415_16610_16701(builder, f_415_16622_16700((uint)resource.Offset, resource.Attributes, resourceName));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(415, 16451, 16721);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 16286, 16736);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(415, 1, 451);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(415, 1, 451);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 16752, 16781);

                return f_415_16759_16780(builder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 15955, 16792);

                System.Reflection.Metadata.MetadataReader
                f_415_16055_16069()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 16055, 16069);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.EmbeddedResource>.Builder
                f_415_16223_16271()
                {
                    var return_v = ImmutableArray.CreateBuilder<EmbeddedResource>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 16223, 16271);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_415_16309_16323()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 16309, 16323);
                    return return_v;
                }


                System.Reflection.Metadata.ManifestResourceHandleCollection
                f_415_16309_16341(System.Reflection.Metadata.MetadataReader
                this_param)
                {
                    var return_v = this_param.ManifestResources;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 16309, 16341);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_415_16390_16404()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 16390, 16404);
                    return return_v;
                }


                System.Reflection.Metadata.ManifestResource
                f_415_16390_16432(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.ManifestResourceHandle
                handle)
                {
                    var return_v = this_param.GetManifestResource(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 16390, 16432);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_415_16548_16562()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 16548, 16562);
                    return return_v;
                }


                string
                f_415_16548_16587(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.StringHandle
                handle)
                {
                    var return_v = this_param.GetString(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 16548, 16587);
                    return return_v;
                }


                Microsoft.CodeAnalysis.EmbeddedResource
                f_415_16622_16700(long
                offset, System.Reflection.ManifestResourceAttributes
                attributes, string
                name)
                {
                    var return_v = new Microsoft.CodeAnalysis.EmbeddedResource((uint)offset, attributes, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 16622, 16700);
                    return return_v;
                }


                int
                f_415_16610_16701(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.EmbeddedResource>.Builder
                this_param, Microsoft.CodeAnalysis.EmbeddedResource
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 16610, 16701);
                    return 0;
                }


                System.Reflection.Metadata.ManifestResourceHandleCollection
                f_415_16309_16341_I(System.Reflection.Metadata.ManifestResourceHandleCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 16309, 16341);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.EmbeddedResource>
                f_415_16759_16780(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.EmbeddedResource>.Builder
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 16759, 16780);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 15955, 16792);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 15955, 16792);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public string GetModuleRefNameOrThrow(ModuleReferenceHandle moduleRef)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 16906, 17095);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 17001, 17084);

                return f_415_17008_17083(f_415_17008_17022(), f_415_17033_17077(f_415_17033_17047(), moduleRef).Name);
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 16906, 17095);

                System.Reflection.Metadata.MetadataReader
                f_415_17008_17022()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 17008, 17022);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_415_17033_17047()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 17033, 17047);
                    return return_v;
                }


                System.Reflection.Metadata.ModuleReference
                f_415_17033_17077(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.ModuleReferenceHandle
                handle)
                {
                    var return_v = this_param.GetModuleReference(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 17033, 17077);
                    return return_v;
                }


                string
                f_415_17008_17083(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.StringHandle
                handle)
                {
                    var return_v = this_param.GetString(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 17008, 17083);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 16906, 17095);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 16906, 17095);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ImmutableArray<AssemblyIdentity> ReferencedAssemblies
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 17362, 17639);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 17398, 17573) || true) && (_lazyAssemblyReferences == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 17398, 17573);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 17475, 17554);

                        _lazyAssemblyReferences = f_415_17501_17553(f_415_17501_17520(this));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 17398, 17573);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 17593, 17624);

                    return _lazyAssemblyReferences;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(415, 17362, 17639);

                    System.Reflection.Metadata.MetadataReader
                    f_415_17501_17520(Microsoft.CodeAnalysis.PEModule
                    this_param)
                    {
                        var return_v = this_param.MetadataReader;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 17501, 17520);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AssemblyIdentity>
                    f_415_17501_17553(System.Reflection.Metadata.MetadataReader
                    reader)
                    {
                        var return_v = reader.GetReferencedAssembliesOrThrow();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 17501, 17553);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 17277, 17650);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 17277, 17650);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal string MetadataVersion
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 17777, 17823);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 17783, 17821);

                    return f_415_17790_17820(f_415_17790_17804());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(415, 17777, 17823);

                    System.Reflection.Metadata.MetadataReader
                    f_415_17790_17804()
                    {
                        var return_v = MetadataReader;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 17790, 17804);
                        return return_v;
                    }


                    string
                    f_415_17790_17820(System.Reflection.Metadata.MetadataReader
                    this_param)
                    {
                        var return_v = this_param.MetadataVersion;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 17790, 17820);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 17721, 17834);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 17721, 17834);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal BlobReader GetMemoryReaderOrThrow(BlobHandle blob)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 17995, 18132);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 18079, 18121);

                return f_415_18086_18120(f_415_18086_18100(), blob);
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 17995, 18132);

                System.Reflection.Metadata.MetadataReader
                f_415_18086_18100()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 18086, 18100);
                    return return_v;
                }


                System.Reflection.Metadata.BlobReader
                f_415_18086_18120(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.BlobHandle
                handle)
                {
                    var return_v = this_param.GetBlobReader(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 18086, 18120);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 17995, 18132);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 17995, 18132);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string GetFullNameOrThrow(StringHandle namespaceHandle, StringHandle nameHandle)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 18246, 18626);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 18360, 18421);

                var
                attributeTypeName = f_415_18384_18420(f_415_18384_18398(), nameHandle)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 18435, 18510);

                var
                attributeTypeNamespaceName = f_415_18468_18509(f_415_18468_18482(), namespaceHandle)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 18526, 18615);

                return f_415_18533_18614(attributeTypeNamespaceName, attributeTypeName);
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 18246, 18626);

                System.Reflection.Metadata.MetadataReader
                f_415_18384_18398()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 18384, 18398);
                    return return_v;
                }


                string
                f_415_18384_18420(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.StringHandle
                handle)
                {
                    var return_v = this_param.GetString(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 18384, 18420);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_415_18468_18482()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 18468, 18482);
                    return return_v;
                }


                string
                f_415_18468_18509(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.StringHandle
                handle)
                {
                    var return_v = this_param.GetString(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 18468, 18509);
                    return return_v;
                }


                string
                f_415_18533_18614(string
                qualifier, string
                name)
                {
                    var return_v = MetadataHelpers.BuildQualifiedName(qualifier, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 18533, 18614);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 18246, 18626);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 18246, 18626);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal AssemblyIdentity ReadAssemblyIdentityOrThrow()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 18801, 18944);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 18881, 18933);

                return f_415_18888_18932(f_415_18888_18902());
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 18801, 18944);

                System.Reflection.Metadata.MetadataReader
                f_415_18888_18902()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 18888, 18902);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_415_18888_18932(System.Reflection.Metadata.MetadataReader
                reader)
                {
                    var return_v = reader.ReadAssemblyIdentityOrThrow();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 18888, 18932);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 18801, 18944);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 18801, 18944);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public TypeDefinitionHandle GetContainingTypeOrThrow(TypeDefinitionHandle typeDef)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 19115, 19301);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 19222, 19290);

                return f_415_19229_19270(f_415_19229_19243(), typeDef).GetDeclaringType();
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 19115, 19301);

                System.Reflection.Metadata.MetadataReader
                f_415_19229_19243()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 19229, 19243);
                    return return_v;
                }


                System.Reflection.Metadata.TypeDefinition
                f_415_19229_19270(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                handle)
                {
                    var return_v = this_param.GetTypeDefinition(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 19229, 19270);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 19115, 19301);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 19115, 19301);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public string GetTypeDefNameOrThrow(TypeDefinitionHandle typeDef)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 19415, 21270);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 19505, 19579);

                TypeDefinition
                typeDefinition = f_415_19537_19578(f_415_19537_19551(), typeDef)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 19593, 19653);

                string
                name = f_415_19607_19652(f_415_19607_19621(), typeDefinition.Name)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 19667, 19749);

                f_415_19667_19748(f_415_19680_19691(name) == 0 || (DynAbs.Tracing.TraceSender.Expression_False(415, 19680, 19747) || f_415_19700_19747(name)));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 20702, 21231) || true) && (f_415_20706_20737(this, typeDef))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 20702, 21231);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 20771, 20845);

                    string
                    namespaceName = f_415_20794_20844(f_415_20794_20808(), typeDefinition.Namespace)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 20863, 21216) || true) && (f_415_20867_20887(namespaceName) > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 20863, 21216);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 21163, 21197);

                        name = namespaceName + "." + name;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 20863, 21216);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(415, 20702, 21231);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 21247, 21259);

                return name;
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 19415, 21270);

                System.Reflection.Metadata.MetadataReader
                f_415_19537_19551()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 19537, 19551);
                    return return_v;
                }


                System.Reflection.Metadata.TypeDefinition
                f_415_19537_19578(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                handle)
                {
                    var return_v = this_param.GetTypeDefinition(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 19537, 19578);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_415_19607_19621()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 19607, 19621);
                    return return_v;
                }


                string
                f_415_19607_19652(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.StringHandle
                handle)
                {
                    var return_v = this_param.GetString(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 19607, 19652);
                    return return_v;
                }


                int
                f_415_19680_19691(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 19680, 19691);
                    return return_v;
                }


                bool
                f_415_19700_19747(string
                str)
                {
                    var return_v = MetadataHelpers.IsValidMetadataIdentifier(str);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 19700, 19747);
                    return return_v;
                }


                int
                f_415_19667_19748(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 19667, 19748);
                    return 0;
                }


                bool
                f_415_20706_20737(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                typeDef)
                {
                    var return_v = this_param.IsNestedTypeDefOrThrow(typeDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 20706, 20737);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_415_20794_20808()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 20794, 20808);
                    return return_v;
                }


                string
                f_415_20794_20844(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.StringHandle
                handle)
                {
                    var return_v = this_param.GetString(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 20794, 20844);
                    return return_v;
                }


                int
                f_415_20867_20887(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 20867, 20887);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 19415, 21270);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 19415, 21270);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public string GetTypeDefNamespaceOrThrow(TypeDefinitionHandle typeDef)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 21384, 21575);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 21479, 21564);

                return f_415_21486_21563(f_415_21486_21500(), f_415_21511_21552(f_415_21511_21525(), typeDef).Namespace);
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 21384, 21575);

                System.Reflection.Metadata.MetadataReader
                f_415_21486_21500()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 21486, 21500);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_415_21511_21525()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 21511, 21525);
                    return return_v;
                }


                System.Reflection.Metadata.TypeDefinition
                f_415_21511_21552(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                handle)
                {
                    var return_v = this_param.GetTypeDefinition(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 21511, 21552);
                    return return_v;
                }


                string
                f_415_21486_21563(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.StringHandle
                handle)
                {
                    var return_v = this_param.GetString(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 21486, 21563);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 21384, 21575);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 21384, 21575);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public EntityHandle GetTypeDefExtendsOrThrow(TypeDefinitionHandle typeDef)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 21689, 21857);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 21788, 21846);

                return f_415_21795_21836(f_415_21795_21809(), typeDef).BaseType;
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 21689, 21857);

                System.Reflection.Metadata.MetadataReader
                f_415_21795_21809()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 21795, 21809);
                    return return_v;
                }


                System.Reflection.Metadata.TypeDefinition
                f_415_21795_21836(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                handle)
                {
                    var return_v = this_param.GetTypeDefinition(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 21795, 21836);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 21689, 21857);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 21689, 21857);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public TypeAttributes GetTypeDefFlagsOrThrow(TypeDefinitionHandle typeDef)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 21971, 22141);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 22070, 22130);

                return f_415_22077_22118(f_415_22077_22091(), typeDef).Attributes;
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 21971, 22141);

                System.Reflection.Metadata.MetadataReader
                f_415_22077_22091()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 22077, 22091);
                    return return_v;
                }


                System.Reflection.Metadata.TypeDefinition
                f_415_22077_22118(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                handle)
                {
                    var return_v = this_param.GetTypeDefinition(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 22077, 22118);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 21971, 22141);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 21971, 22141);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public GenericParameterHandleCollection GetTypeDefGenericParamsOrThrow(TypeDefinitionHandle typeDef)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 22255, 22463);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 22380, 22452);

                return f_415_22387_22428(f_415_22387_22401(), typeDef).GetGenericParameters();
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 22255, 22463);

                System.Reflection.Metadata.MetadataReader
                f_415_22387_22401()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 22387, 22401);
                    return return_v;
                }


                System.Reflection.Metadata.TypeDefinition
                f_415_22387_22428(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                handle)
                {
                    var return_v = this_param.GetTypeDefinition(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 22387, 22428);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 22255, 22463);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 22255, 22463);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool HasGenericParametersOrThrow(TypeDefinitionHandle typeDef)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 22577, 22764);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 22671, 22753);

                return f_415_22678_22719(f_415_22678_22692(), typeDef).GetGenericParameters().Count > 0;
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 22577, 22764);

                System.Reflection.Metadata.MetadataReader
                f_415_22678_22692()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 22678, 22692);
                    return return_v;
                }


                System.Reflection.Metadata.TypeDefinition
                f_415_22678_22719(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                handle)
                {
                    var return_v = this_param.GetTypeDefinition(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 22678, 22719);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 22577, 22764);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 22577, 22764);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void GetTypeDefPropsOrThrow(
                    TypeDefinitionHandle typeDef,
                    out string name,
                    out string @namespace,
                    out TypeAttributes flags,
                    out EntityHandle extends)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 22878, 23396);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 23125, 23188);

                TypeDefinition
                row = f_415_23146_23187(f_415_23146_23160(), typeDef)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 23202, 23244);

                name = f_415_23209_23243(f_415_23209_23223(), row.Name);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 23258, 23311);

                @namespace = f_415_23271_23310(f_415_23271_23285(), row.Namespace);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 23325, 23348);

                flags = row.Attributes;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 23362, 23385);

                extends = row.BaseType;
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 22878, 23396);

                System.Reflection.Metadata.MetadataReader
                f_415_23146_23160()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 23146, 23160);
                    return return_v;
                }


                System.Reflection.Metadata.TypeDefinition
                f_415_23146_23187(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                handle)
                {
                    var return_v = this_param.GetTypeDefinition(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 23146, 23187);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_415_23209_23223()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 23209, 23223);
                    return return_v;
                }


                string
                f_415_23209_23243(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.StringHandle
                handle)
                {
                    var return_v = this_param.GetString(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 23209, 23243);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_415_23271_23285()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 23271, 23285);
                    return return_v;
                }


                string
                f_415_23271_23310(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.StringHandle
                handle)
                {
                    var return_v = this_param.GetString(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 23271, 23310);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 22878, 23396);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 22878, 23396);
            }
        }

        internal bool IsNestedTypeDefOrThrow(TypeDefinitionHandle typeDef)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 23510, 23667);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 23601, 23656);

                return f_415_23608_23655(f_415_23631_23645(), typeDef);
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 23510, 23667);

                System.Reflection.Metadata.MetadataReader
                f_415_23631_23645()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 23631, 23645);
                    return return_v;
                }


                bool
                f_415_23608_23655(System.Reflection.Metadata.MetadataReader
                metadataReader, System.Reflection.Metadata.TypeDefinitionHandle
                typeDef)
                {
                    var return_v = IsNestedTypeDefOrThrow(metadataReader, typeDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 23608, 23655);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 23510, 23667);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 23510, 23667);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsNestedTypeDefOrThrow(MetadataReader metadataReader, TypeDefinitionHandle typeDef)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(415, 23781, 23990);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 23909, 23979);

                return f_415_23916_23978(f_415_23925_23966(metadataReader, typeDef).Attributes);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(415, 23781, 23990);

                System.Reflection.Metadata.TypeDefinition
                f_415_23925_23966(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                handle)
                {
                    var return_v = this_param.GetTypeDefinition(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 23925, 23966);
                    return return_v;
                }


                bool
                f_415_23916_23978(System.Reflection.TypeAttributes
                flags)
                {
                    var return_v = IsNested(flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 23916, 23978);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 23781, 23990);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 23781, 23990);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool IsInterfaceOrThrow(TypeDefinitionHandle typeDef)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 24104, 24276);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 24191, 24265);

                return f_415_24198_24264(f_415_24198_24239(f_415_24198_24212(), typeDef).Attributes);
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 24104, 24276);

                System.Reflection.Metadata.MetadataReader
                f_415_24198_24212()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 24198, 24212);
                    return return_v;
                }


                System.Reflection.Metadata.TypeDefinition
                f_415_24198_24239(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                handle)
                {
                    var return_v = this_param.GetTypeDefinition(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 24198, 24239);
                    return return_v;
                }


                bool
                f_415_24198_24264(System.Reflection.TypeAttributes
                flags)
                {
                    var return_v = flags.IsInterface();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 24198, 24264);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 24104, 24276);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 24104, 24276);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private struct TypeDefToNamespace
        {

            internal readonly TypeDefinitionHandle TypeDef;

            internal readonly NamespaceDefinitionHandle NamespaceHandle;

            internal TypeDefToNamespace(TypeDefinitionHandle typeDef, NamespaceDefinitionHandle namespaceHandle)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(415, 24483, 24701);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 24616, 24634);

                    TypeDef = typeDef;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 24652, 24686);

                    NamespaceHandle = namespaceHandle;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(415, 24483, 24701);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 24483, 24701);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 24483, 24701);
                }
            }
            static TypeDefToNamespace()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(415, 24288, 24712);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(415, 24288, 24712);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 24288, 24712);
            }
        }

        private IEnumerable<TypeDefToNamespace> GetTypeDefsOrThrow(bool topLevelOnly)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 24826, 25318);

                var listYield = new List<TypeDefToNamespace>();
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 24928, 25307);
                    foreach (var typeDef in f_415_24952_24982_I(f_415_24952_24982(f_415_24952_24966())))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 24928, 25307);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 25016, 25068);

                        var
                        row = f_415_25026_25067(f_415_25026_25040(), typeDef)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 25088, 25202) || true) && (topLevelOnly && (DynAbs.Tracing.TraceSender.Expression_True(415, 25092, 25132) && f_415_25108_25132(row.Attributes)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 25088, 25202);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 25174, 25183);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(415, 25088, 25202);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 25222, 25292);

                        listYield.Add(f_415_25235_25291(typeDef, row.NamespaceDefinition));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 24928, 25307);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(415, 1, 380);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(415, 1, 380);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 24826, 25318);

                return listYield;

                System.Reflection.Metadata.MetadataReader
                f_415_24952_24966()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 24952, 24966);
                    return return_v;
                }


                System.Reflection.Metadata.TypeDefinitionHandleCollection
                f_415_24952_24982(System.Reflection.Metadata.MetadataReader
                this_param)
                {
                    var return_v = this_param.TypeDefinitions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 24952, 24982);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_415_25026_25040()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 25026, 25040);
                    return return_v;
                }


                System.Reflection.Metadata.TypeDefinition
                f_415_25026_25067(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                handle)
                {
                    var return_v = this_param.GetTypeDefinition(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 25026, 25067);
                    return return_v;
                }


                bool
                f_415_25108_25132(System.Reflection.TypeAttributes
                flags)
                {
                    var return_v = IsNested(flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 25108, 25132);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PEModule.TypeDefToNamespace
                f_415_25235_25291(System.Reflection.Metadata.TypeDefinitionHandle
                typeDef, System.Reflection.Metadata.NamespaceDefinitionHandle
                namespaceHandle)
                {
                    var return_v = new Microsoft.CodeAnalysis.PEModule.TypeDefToNamespace(typeDef, namespaceHandle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 25235, 25291);
                    return return_v;
                }


                System.Reflection.Metadata.TypeDefinitionHandleCollection
                f_415_24952_24982_I(System.Reflection.Metadata.TypeDefinitionHandleCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 24952, 24982);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 24826, 25318);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 24826, 25318);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal IEnumerable<IGrouping<string, TypeDefinitionHandle>> GroupTypesByNamespaceOrThrow(StringComparer nameComparer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 26388, 27742);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 27033, 27162);

                Dictionary<string, ArrayBuilder<TypeDefinitionHandle>>
                namespaces = f_415_27101_27161()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 27178, 27219);

                f_415_27178_27218(this, namespaces);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 27233, 27283);

                f_415_27233_27282(this, namespaces);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 27299, 27388);

                var
                result = f_415_27312_27387(f_415_27370_27386(namespaces))
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 27404, 27627);
                    foreach (var pair in f_415_27425_27435_I(namespaces))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 27404, 27627);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 27469, 27612);

                        f_415_27469_27611(result, f_415_27480_27610(pair.Key, pair.Value ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.TypeDefinitionHandle>?>(415, 27533, 27609) ?? f_415_27547_27609())));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 27404, 27627);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(415, 1, 224);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(415, 1, 224);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 27643, 27703);

                f_415_27643_27702(
                            result, f_415_27655_27701(nameComparer));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 27717, 27731);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 26388, 27742);

                System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.TypeDefinitionHandle>>
                f_415_27101_27161()
                {
                    var return_v = new System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.TypeDefinitionHandle>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 27101, 27161);
                    return return_v;
                }


                int
                f_415_27178_27218(Microsoft.CodeAnalysis.PEModule
                this_param, System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.TypeDefinitionHandle>>
                namespaces)
                {
                    this_param.GetTypeNamespaceNamesOrThrow(namespaces);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 27178, 27218);
                    return 0;
                }


                int
                f_415_27233_27282(Microsoft.CodeAnalysis.PEModule
                this_param, System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.TypeDefinitionHandle>>
                namespaces)
                {
                    this_param.GetForwardedTypeNamespaceNamesOrThrow(namespaces);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 27233, 27282);
                    return 0;
                }


                int
                f_415_27370_27386(System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.TypeDefinitionHandle>>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 27370, 27386);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Linq.IGrouping<string, System.Reflection.Metadata.TypeDefinitionHandle>>
                f_415_27312_27387(int
                size)
                {
                    var return_v = new Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Linq.IGrouping<string, System.Reflection.Metadata.TypeDefinitionHandle>>(size);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 27312, 27387);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Reflection.Metadata.TypeDefinitionHandle>
                f_415_27547_27609()
                {
                    var return_v = SpecializedCollections.EmptyEnumerable<TypeDefinitionHandle>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 27547, 27609);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Grouping<string, System.Reflection.Metadata.TypeDefinitionHandle>
                f_415_27480_27610(string
                key, System.Collections.Generic.IEnumerable<System.Reflection.Metadata.TypeDefinitionHandle>
                elements)
                {
                    var return_v = new Microsoft.CodeAnalysis.Grouping<string, System.Reflection.Metadata.TypeDefinitionHandle>(key, elements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 27480, 27610);
                    return return_v;
                }


                int
                f_415_27469_27611(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Linq.IGrouping<string, System.Reflection.Metadata.TypeDefinitionHandle>>
                this_param, Microsoft.CodeAnalysis.Grouping<string, System.Reflection.Metadata.TypeDefinitionHandle>
                item)
                {
                    this_param.Add((System.Linq.IGrouping<string, System.Reflection.Metadata.TypeDefinitionHandle>)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 27469, 27611);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.TypeDefinitionHandle>>
                f_415_27425_27435_I(System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.TypeDefinitionHandle>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 27425, 27435);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PEModule.TypesByNamespaceSortComparer
                f_415_27655_27701(System.StringComparer
                nameComparer)
                {
                    var return_v = new Microsoft.CodeAnalysis.PEModule.TypesByNamespaceSortComparer(nameComparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 27655, 27701);
                    return return_v;
                }


                int
                f_415_27643_27702(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Linq.IGrouping<string, System.Reflection.Metadata.TypeDefinitionHandle>>
                this_param, Microsoft.CodeAnalysis.PEModule.TypesByNamespaceSortComparer
                comparer)
                {
                    this_param.Sort((System.Collections.Generic.IComparer<System.Linq.IGrouping<string, System.Reflection.Metadata.TypeDefinitionHandle>>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 27643, 27702);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 26388, 27742);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 26388, 27742);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        internal class TypesByNamespaceSortComparer : IComparer<IGrouping<string, TypeDefinitionHandle>>
        {
            private readonly StringComparer _nameComparer;

            public TypesByNamespaceSortComparer(StringComparer nameComparer)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(415, 27937, 28078);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 27907, 27920);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 28034, 28063);

                    _nameComparer = nameComparer;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(415, 27937, 28078);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 27937, 28078);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 27937, 28078);
                }
            }

            public int Compare(IGrouping<string, TypeDefinitionHandle> left, IGrouping<string, TypeDefinitionHandle> right)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 28094, 29315);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 28238, 28325) || true) && (left == right)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 28238, 28325);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 28297, 28306);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 28238, 28325);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 28345, 28401);

                    int
                    result = f_415_28358_28400(_nameComparer, f_415_28380_28388(left), f_415_28390_28399(right))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 28421, 29222) || true) && (result == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 28421, 29222);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 28478, 28512);

                        var
                        fLeft = f_415_28490_28511(left)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 28534, 28570);

                        var
                        fRight = f_415_28547_28569(right)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 28594, 28881) || true) && (fLeft.IsNil ^ fRight.IsNil)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 28594, 28881);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 28674, 28705);

                            result = (DynAbs.Tracing.TraceSender.Conditional_F1(415, 28683, 28694) || ((fLeft.IsNil && DynAbs.Tracing.TraceSender.Conditional_F2(415, 28697, 28699)) || DynAbs.Tracing.TraceSender.Conditional_F3(415, 28702, 28704))) ? +1 : -1;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(415, 28594, 28881);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 28594, 28881);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 28803, 28858);

                            result = f_415_28812_28857(f_415_28812_28834(), fLeft, fRight);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(415, 28594, 28881);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 28905, 29203) || true) && (result == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 28905, 29203);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 29054, 29102);

                            f_415_29054_29101(f_415_29067_29081(left) && (DynAbs.Tracing.TraceSender.Expression_True(415, 29067, 29100) && f_415_29085_29100(right)));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 29128, 29180);

                            result = f_415_29137_29179(f_415_29159_29167(left), f_415_29169_29178(right));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(415, 28905, 29203);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 28421, 29222);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 29242, 29268);

                    f_415_29242_29267(result != 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 29286, 29300);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(415, 28094, 29315);

                    string
                    f_415_28380_28388(System.Linq.IGrouping<string, System.Reflection.Metadata.TypeDefinitionHandle>
                    this_param)
                    {
                        var return_v = this_param.Key;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 28380, 28388);
                        return return_v;
                    }


                    string
                    f_415_28390_28399(System.Linq.IGrouping<string, System.Reflection.Metadata.TypeDefinitionHandle>
                    this_param)
                    {
                        var return_v = this_param.Key;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 28390, 28399);
                        return return_v;
                    }


                    int
                    f_415_28358_28400(System.StringComparer
                    this_param, string
                    x, string
                    y)
                    {
                        var return_v = this_param.Compare(x, y);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 28358, 28400);
                        return return_v;
                    }


                    System.Reflection.Metadata.TypeDefinitionHandle
                    f_415_28490_28511(System.Linq.IGrouping<string, System.Reflection.Metadata.TypeDefinitionHandle>
                    source)
                    {
                        var return_v = source.FirstOrDefault<System.Reflection.Metadata.TypeDefinitionHandle>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 28490, 28511);
                        return return_v;
                    }


                    System.Reflection.Metadata.TypeDefinitionHandle
                    f_415_28547_28569(System.Linq.IGrouping<string, System.Reflection.Metadata.TypeDefinitionHandle>
                    source)
                    {
                        var return_v = source.FirstOrDefault<System.Reflection.Metadata.TypeDefinitionHandle>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 28547, 28569);
                        return return_v;
                    }


                    System.Reflection.Metadata.HandleComparer
                    f_415_28812_28834()
                    {
                        var return_v = HandleComparer.Default;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 28812, 28834);
                        return return_v;
                    }


                    int
                    f_415_28812_28857(System.Reflection.Metadata.HandleComparer
                    this_param, System.Reflection.Metadata.TypeDefinitionHandle
                    x, System.Reflection.Metadata.TypeDefinitionHandle
                    y)
                    {
                        var return_v = this_param.Compare((System.Reflection.Metadata.EntityHandle)x, (System.Reflection.Metadata.EntityHandle)y);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 28812, 28857);
                        return return_v;
                    }


                    bool
                    f_415_29067_29081(System.Linq.IGrouping<string, System.Reflection.Metadata.TypeDefinitionHandle>
                    source)
                    {
                        var return_v = source.IsEmpty<System.Reflection.Metadata.TypeDefinitionHandle>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 29067, 29081);
                        return return_v;
                    }


                    bool
                    f_415_29085_29100(System.Linq.IGrouping<string, System.Reflection.Metadata.TypeDefinitionHandle>
                    source)
                    {
                        var return_v = source.IsEmpty<System.Reflection.Metadata.TypeDefinitionHandle>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 29085, 29100);
                        return return_v;
                    }


                    int
                    f_415_29054_29101(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 29054, 29101);
                        return 0;
                    }


                    string
                    f_415_29159_29167(System.Linq.IGrouping<string, System.Reflection.Metadata.TypeDefinitionHandle>
                    this_param)
                    {
                        var return_v = this_param.Key;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 29159, 29167);
                        return return_v;
                    }


                    string
                    f_415_29169_29178(System.Linq.IGrouping<string, System.Reflection.Metadata.TypeDefinitionHandle>
                    this_param)
                    {
                        var return_v = this_param.Key;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 29169, 29178);
                        return return_v;
                    }


                    int
                    f_415_29137_29179(string
                    strA, string
                    strB)
                    {
                        var return_v = string.CompareOrdinal(strA, strB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 29137, 29179);
                        return return_v;
                    }


                    int
                    f_415_29242_29267(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 29242, 29267);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 28094, 29315);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 28094, 29315);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static TypesByNamespaceSortComparer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(415, 27754, 29326);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(415, 27754, 29326);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 27754, 29326);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(415, 27754, 29326);
        }

        private void GetTypeNamespaceNamesOrThrow(Dictionary<string, ArrayBuilder<TypeDefinitionHandle>> namespaces)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 29628, 31163);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 29868, 30012);

                var
                namespaceHandles = f_415_29891_30011(NamespaceHandleEqualityComparer.Singleton)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 30026, 30654);
                    foreach (TypeDefToNamespace pair in f_415_30062_30100_I(f_415_30062_30100(this, topLevelOnly: true)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 30026, 30654);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 30134, 30192);

                        NamespaceDefinitionHandle
                        nsHandle = pair.NamespaceHandle
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 30210, 30254);

                        TypeDefinitionHandle
                        typeDef = pair.TypeDef
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 30274, 30317);

                        ArrayBuilder<TypeDefinitionHandle>
                        builder
                        = default(ArrayBuilder<TypeDefinitionHandle>);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 30337, 30639) || true) && (f_415_30341_30392(namespaceHandles, nsHandle, out builder))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 30337, 30639);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 30434, 30455);

                            f_415_30434_30454(builder, typeDef);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(415, 30337, 30639);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 30337, 30639);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 30537, 30620);

                            f_415_30537_30619(namespaceHandles, nsHandle, new ArrayBuilder<TypeDefinitionHandle> { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => typeDef, 415, 30568, 30618) });
                            DynAbs.Tracing.TraceSender.TraceExitCondition(415, 30337, 30639);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 30026, 30654);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(415, 1, 629);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(415, 1, 629);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 30670, 31152);
                    foreach (var kvp in f_415_30690_30706_I(namespaceHandles))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 30670, 31152);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 30740, 30794);

                        string
                        @namespace = f_415_30760_30793(f_415_30760_30774(), kvp.Key)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 30814, 30857);

                        ArrayBuilder<TypeDefinitionHandle>
                        builder
                        = default(ArrayBuilder<TypeDefinitionHandle>);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 30877, 31137) || true) && (f_415_30881_30928(namespaces, @namespace, out builder))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 30877, 31137);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 30970, 30998);

                            f_415_30970_30997(builder, kvp.Value);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(415, 30877, 31137);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 30877, 31137);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 31080, 31118);

                            f_415_31080_31117(namespaces, @namespace, kvp.Value);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(415, 30877, 31137);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 30670, 31152);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(415, 1, 483);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(415, 1, 483);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 29628, 31163);

                System.Collections.Generic.Dictionary<System.Reflection.Metadata.NamespaceDefinitionHandle, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.TypeDefinitionHandle>>
                f_415_29891_30011(Microsoft.CodeAnalysis.PEModule.NamespaceHandleEqualityComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.Dictionary<System.Reflection.Metadata.NamespaceDefinitionHandle, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.TypeDefinitionHandle>>((System.Collections.Generic.IEqualityComparer<System.Reflection.Metadata.NamespaceDefinitionHandle>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 29891, 30011);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.PEModule.TypeDefToNamespace>
                f_415_30062_30100(Microsoft.CodeAnalysis.PEModule
                this_param, bool
                topLevelOnly)
                {
                    var return_v = this_param.GetTypeDefsOrThrow(topLevelOnly: topLevelOnly);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 30062, 30100);
                    return return_v;
                }


                bool
                f_415_30341_30392(System.Collections.Generic.Dictionary<System.Reflection.Metadata.NamespaceDefinitionHandle, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.TypeDefinitionHandle>>
                this_param, System.Reflection.Metadata.NamespaceDefinitionHandle
                key, out Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.TypeDefinitionHandle>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 30341, 30392);
                    return return_v;
                }


                int
                f_415_30434_30454(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.TypeDefinitionHandle>
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 30434, 30454);
                    return 0;
                }


                int
                f_415_30537_30619(System.Collections.Generic.Dictionary<System.Reflection.Metadata.NamespaceDefinitionHandle, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.TypeDefinitionHandle>>
                this_param, System.Reflection.Metadata.NamespaceDefinitionHandle
                key, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.TypeDefinitionHandle>
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 30537, 30619);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.PEModule.TypeDefToNamespace>
                f_415_30062_30100_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.PEModule.TypeDefToNamespace>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 30062, 30100);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_415_30760_30774()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 30760, 30774);
                    return return_v;
                }


                string
                f_415_30760_30793(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.NamespaceDefinitionHandle
                handle)
                {
                    var return_v = this_param.GetString(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 30760, 30793);
                    return return_v;
                }


                bool
                f_415_30881_30928(System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.TypeDefinitionHandle>>
                this_param, string
                key, out Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.TypeDefinitionHandle>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 30881, 30928);
                    return return_v;
                }


                int
                f_415_30970_30997(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.TypeDefinitionHandle>
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.TypeDefinitionHandle>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 30970, 30997);
                    return 0;
                }


                int
                f_415_31080_31117(System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.TypeDefinitionHandle>>
                this_param, string
                key, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.TypeDefinitionHandle>
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 31080, 31117);
                    return 0;
                }


                System.Collections.Generic.Dictionary<System.Reflection.Metadata.NamespaceDefinitionHandle, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.TypeDefinitionHandle>>
                f_415_30690_30706_I(System.Collections.Generic.Dictionary<System.Reflection.Metadata.NamespaceDefinitionHandle, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.TypeDefinitionHandle>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 30690, 30706);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 29628, 31163);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 29628, 31163);
            }
        }
        private class NamespaceHandleEqualityComparer : IEqualityComparer<NamespaceDefinitionHandle>
        {
            public static readonly NamespaceHandleEqualityComparer Singleton;

            private NamespaceHandleEqualityComparer()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(415, 31413, 31484);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(415, 31413, 31484);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 31413, 31484);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 31413, 31484);
                }
            }

            public bool Equals(NamespaceDefinitionHandle x, NamespaceDefinitionHandle y)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 31500, 31638);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 31609, 31623);

                    return x == y;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(415, 31500, 31638);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 31500, 31638);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 31500, 31638);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public int GetHashCode(NamespaceDefinitionHandle obj)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 31654, 31780);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 31740, 31765);

                    return obj.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(415, 31654, 31780);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 31654, 31780);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 31654, 31780);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static NamespaceHandleEqualityComparer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(415, 31175, 31791);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 31347, 31396);
                Singleton = f_415_31359_31396(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(415, 31175, 31791);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 31175, 31791);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(415, 31175, 31791);

            static Microsoft.CodeAnalysis.PEModule.NamespaceHandleEqualityComparer
            f_415_31359_31396()
            {
                var return_v = new Microsoft.CodeAnalysis.PEModule.NamespaceHandleEqualityComparer();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 31359, 31396);
                return return_v;
            }

        }

        private void GetForwardedTypeNamespaceNamesOrThrow(Dictionary<string, ArrayBuilder<TypeDefinitionHandle>> namespaces)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 33235, 33836);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 33377, 33410);

                f_415_33377_33409(this);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 33426, 33825);
                    foreach (var typeName in f_415_33451_33493_I(f_415_33451_33493(_lazyForwardedTypesToAssemblyIndexMap)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 33426, 33825);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 33527, 33565);

                        int
                        index = f_415_33539_33564(typeName, '.')
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 33583, 33653);

                        string
                        namespaceName = (DynAbs.Tracing.TraceSender.Conditional_F1(415, 33606, 33616) || ((index >= 0 && DynAbs.Tracing.TraceSender.Conditional_F2(415, 33619, 33647)) || DynAbs.Tracing.TraceSender.Conditional_F3(415, 33650, 33652))) ? f_415_33619_33647(typeName, 0, index) : ""
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 33671, 33810) || true) && (!f_415_33676_33713(namespaces, namespaceName))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 33671, 33810);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 33755, 33791);

                            f_415_33755_33790(namespaces, namespaceName, null);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(415, 33671, 33810);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 33426, 33825);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(415, 1, 400);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(415, 1, 400);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 33235, 33836);

                int
                f_415_33377_33409(Microsoft.CodeAnalysis.PEModule
                this_param)
                {
                    this_param.EnsureForwardTypeToAssemblyMap();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 33377, 33409);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, (int FirstIndex, int SecondIndex)>.KeyCollection
                f_415_33451_33493(System.Collections.Generic.Dictionary<string, (int FirstIndex, int SecondIndex)>
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 33451, 33493);
                    return return_v;
                }


                int
                f_415_33539_33564(string
                this_param, char
                value)
                {
                    var return_v = this_param.LastIndexOf(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 33539, 33564);
                    return return_v;
                }


                string
                f_415_33619_33647(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 33619, 33647);
                    return return_v;
                }


                bool
                f_415_33676_33713(System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.TypeDefinitionHandle>>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 33676, 33713);
                    return return_v;
                }


                int
                f_415_33755_33790(System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.TypeDefinitionHandle>>
                this_param, string
                key, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.TypeDefinitionHandle>
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 33755, 33790);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, (int FirstIndex, int SecondIndex)>.KeyCollection
                f_415_33451_33493_I(System.Collections.Generic.Dictionary<string, (int FirstIndex, int SecondIndex)>.KeyCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 33451, 33493);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 33235, 33836);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 33235, 33836);
            }
        }

        private IdentifierCollection ComputeTypeNameCollection()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 33848, 34572);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 33965, 34023);

                    var
                    allTypeDefs = f_415_33983_34022(this, topLevelOnly: false)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 34041, 34356);

                    var
                    typeNames =
                                        DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => from typeDef in allTypeDefs
                                                                                                let metadataName = GetTypeDefNameOrThrow(typeDef.TypeDef)
                                                                                                let backtickIndex = metadataName.IndexOf('`')
                                                                                                select backtickIndex < 0 ? metadataName : metadataName.Substring(0, backtickIndex), 415, 34078, 34355)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 34376, 34419);

                    return f_415_34383_34418(typeNames);
                }
                catch (BadImageFormatException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(415, 34448, 34561);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 34512, 34546);

                    return f_415_34519_34545();
                    DynAbs.Tracing.TraceSender.TraceExitCatch(415, 34448, 34561);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 33848, 34572);

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.PEModule.TypeDefToNamespace>
                f_415_33983_34022(Microsoft.CodeAnalysis.PEModule
                this_param, bool
                topLevelOnly)
                {
                    var return_v = this_param.GetTypeDefsOrThrow(topLevelOnly: topLevelOnly);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 33983, 34022);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IdentifierCollection
                f_415_34383_34418(System.Collections.Generic.IEnumerable<string>
                identifiers)
                {
                    var return_v = new Microsoft.CodeAnalysis.IdentifierCollection(identifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 34383, 34418);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IdentifierCollection
                f_415_34519_34545()
                {
                    var return_v = new Microsoft.CodeAnalysis.IdentifierCollection();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 34519, 34545);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 33848, 34572);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 33848, 34572);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private IdentifierCollection ComputeNamespaceNameCollection()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 34584, 35440);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 34706, 34762);

                    var
                    allTypeIds = f_415_34723_34761(this, topLevelOnly: true)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 34780, 34974);

                    var
                    fullNamespaceNames =
                                        DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => from id in allTypeIds
                                                                                                where !id.NamespaceHandle.IsNil
                                                                                                select MetadataReader.GetString(id.NamespaceHandle), 415, 34826, 34973)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 34994, 35219);

                    var
                    namespaceNames =
                                        DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => from fullName in fullNamespaceNames.Distinct()
                                                                                                from name in fullName.Split(new[] { '.' }, StringSplitOptions.RemoveEmptyEntries)
                                                                                                select name, 415, 35036, 35218)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 35239, 35287);

                    return f_415_35246_35286(namespaceNames);
                }
                catch (BadImageFormatException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(415, 35316, 35429);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 35380, 35414);

                    return f_415_35387_35413();
                    DynAbs.Tracing.TraceSender.TraceExitCatch(415, 35316, 35429);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 34584, 35440);

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.PEModule.TypeDefToNamespace>
                f_415_34723_34761(Microsoft.CodeAnalysis.PEModule
                this_param, bool
                topLevelOnly)
                {
                    var return_v = this_param.GetTypeDefsOrThrow(topLevelOnly: topLevelOnly);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 34723, 34761);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IdentifierCollection
                f_415_35246_35286(System.Collections.Generic.IEnumerable<string>
                identifiers)
                {
                    var return_v = new Microsoft.CodeAnalysis.IdentifierCollection(identifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 35246, 35286);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IdentifierCollection
                f_415_35387_35413()
                {
                    var return_v = new Microsoft.CodeAnalysis.IdentifierCollection();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 35387, 35413);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 34584, 35440);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 34584, 35440);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ImmutableArray<TypeDefinitionHandle> GetNestedTypeDefsOrThrow(TypeDefinitionHandle container)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 35554, 35760);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 35681, 35749);

                return f_415_35688_35731(f_415_35688_35702(), container).GetNestedTypes();
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 35554, 35760);

                System.Reflection.Metadata.MetadataReader
                f_415_35688_35702()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 35688, 35702);
                    return return_v;
                }


                System.Reflection.Metadata.TypeDefinition
                f_415_35688_35731(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                handle)
                {
                    var return_v = this_param.GetTypeDefinition(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 35688, 35731);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 35554, 35760);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 35554, 35760);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal MethodImplementationHandleCollection GetMethodImplementationsOrThrow(TypeDefinitionHandle typeDef)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 35874, 36093);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 36006, 36082);

                return f_415_36013_36054(f_415_36013_36027(), typeDef).GetMethodImplementations();
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 35874, 36093);

                System.Reflection.Metadata.MetadataReader
                f_415_36013_36027()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 36013, 36027);
                    return return_v;
                }


                System.Reflection.Metadata.TypeDefinition
                f_415_36013_36054(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                handle)
                {
                    var return_v = this_param.GetTypeDefinition(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 36013, 36054);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 35874, 36093);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 35874, 36093);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal InterfaceImplementationHandleCollection GetInterfaceImplementationsOrThrow(TypeDefinitionHandle typeDef)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 36329, 36557);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 36467, 36546);

                return f_415_36474_36515(f_415_36474_36488(), typeDef).GetInterfaceImplementations();
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 36329, 36557);

                System.Reflection.Metadata.MetadataReader
                f_415_36474_36488()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 36474, 36488);
                    return return_v;
                }


                System.Reflection.Metadata.TypeDefinition
                f_415_36474_36515(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                handle)
                {
                    var return_v = this_param.GetTypeDefinition(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 36474, 36515);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 36329, 36557);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 36329, 36557);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal MethodDefinitionHandleCollection GetMethodsOfTypeOrThrow(TypeDefinitionHandle typeDef)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 36671, 36864);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 36791, 36853);

                return f_415_36798_36839(f_415_36798_36812(), typeDef).GetMethods();
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 36671, 36864);

                System.Reflection.Metadata.MetadataReader
                f_415_36798_36812()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 36798, 36812);
                    return return_v;
                }


                System.Reflection.Metadata.TypeDefinition
                f_415_36798_36839(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                handle)
                {
                    var return_v = this_param.GetTypeDefinition(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 36798, 36839);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 36671, 36864);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 36671, 36864);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal PropertyDefinitionHandleCollection GetPropertiesOfTypeOrThrow(TypeDefinitionHandle typeDef)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 36978, 37179);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 37103, 37168);

                return f_415_37110_37151(f_415_37110_37124(), typeDef).GetProperties();
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 36978, 37179);

                System.Reflection.Metadata.MetadataReader
                f_415_37110_37124()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 37110, 37124);
                    return return_v;
                }


                System.Reflection.Metadata.TypeDefinition
                f_415_37110_37151(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                handle)
                {
                    var return_v = this_param.GetTypeDefinition(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 37110, 37151);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 36978, 37179);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 36978, 37179);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal EventDefinitionHandleCollection GetEventsOfTypeOrThrow(TypeDefinitionHandle typeDef)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 37293, 37483);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 37411, 37472);

                return f_415_37418_37459(f_415_37418_37432(), typeDef).GetEvents();
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 37293, 37483);

                System.Reflection.Metadata.MetadataReader
                f_415_37418_37432()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 37418, 37432);
                    return return_v;
                }


                System.Reflection.Metadata.TypeDefinition
                f_415_37418_37459(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                handle)
                {
                    var return_v = this_param.GetTypeDefinition(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 37418, 37459);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 37293, 37483);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 37293, 37483);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal FieldDefinitionHandleCollection GetFieldsOfTypeOrThrow(TypeDefinitionHandle typeDef)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 37597, 37787);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 37715, 37776);

                return f_415_37722_37763(f_415_37722_37736(), typeDef).GetFields();
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 37597, 37787);

                System.Reflection.Metadata.MetadataReader
                f_415_37722_37736()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 37722, 37736);
                    return return_v;
                }


                System.Reflection.Metadata.TypeDefinition
                f_415_37722_37763(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                handle)
                {
                    var return_v = this_param.GetTypeDefinition(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 37722, 37763);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 37597, 37787);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 37597, 37787);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal EntityHandle GetBaseTypeOfTypeOrThrow(TypeDefinitionHandle typeDef)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 37901, 38071);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 38002, 38060);

                return f_415_38009_38050(f_415_38009_38023(), typeDef).BaseType;
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 37901, 38071);

                System.Reflection.Metadata.MetadataReader
                f_415_38009_38023()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 38009, 38023);
                    return return_v;
                }


                System.Reflection.Metadata.TypeDefinition
                f_415_38009_38050(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                handle)
                {
                    var return_v = this_param.GetTypeDefinition(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 38009, 38050);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 37901, 38071);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 37901, 38071);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal TypeLayout GetTypeLayout(TypeDefinitionHandle typeDef)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 38083, 39875);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 38446, 38498);

                    var
                    def = f_415_38456_38497(f_415_38456_38470(), typeDef)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 38518, 38534);

                    LayoutKind
                    kind
                    = default(LayoutKind);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 38552, 39179);

                    switch (def.Attributes & TypeAttributes.LayoutMask)
                    {

                        case TypeAttributes.SequentialLayout:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 38552, 39179);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 38707, 38736);

                            kind = LayoutKind.Sequential;
                            DynAbs.Tracing.TraceSender.TraceBreak(415, 38762, 38768);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(415, 38552, 39179);

                        case TypeAttributes.ExplicitLayout:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 38552, 39179);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 38853, 38880);

                            kind = LayoutKind.Explicit;
                            DynAbs.Tracing.TraceSender.TraceBreak(415, 38906, 38912);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(415, 38552, 39179);

                        case TypeAttributes.AutoLayout:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 38552, 39179);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 38993, 39020);

                            return default(TypeLayout);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(415, 38552, 39179);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 38552, 39179);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 39133, 39160);

                            return default(TypeLayout);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(415, 38552, 39179);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 39199, 39228);

                    var
                    layout = def.GetLayout()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 39246, 39269);

                    int
                    size = layout.Size
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 39287, 39324);

                    int
                    packingSize = layout.PackingSize
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 39344, 39503) || true) && (packingSize > byte.MaxValue)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 39344, 39503);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 39468, 39484);

                        packingSize = 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 39344, 39503);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 39523, 39656) || true) && (size < 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 39523, 39656);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 39628, 39637);

                        size = 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 39523, 39656);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 39676, 39729);

                    return f_415_39683_39728(kind, size, (byte)packingSize);
                }
                catch (BadImageFormatException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(415, 39758, 39864);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 39822, 39849);

                    return default(TypeLayout);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(415, 39758, 39864);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 38083, 39875);

                System.Reflection.Metadata.MetadataReader
                f_415_38456_38470()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 38456, 38470);
                    return return_v;
                }


                System.Reflection.Metadata.TypeDefinition
                f_415_38456_38497(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                handle)
                {
                    var return_v = this_param.GetTypeDefinition(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 38456, 38497);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeLayout
                f_415_39683_39728(System.Runtime.InteropServices.LayoutKind
                kind, int
                size, int
                alignment)
                {
                    var return_v = new Microsoft.CodeAnalysis.TypeLayout(kind, size, (byte)alignment);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 39683, 39728);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 38083, 39875);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 38083, 39875);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool IsNoPiaLocalType(TypeDefinitionHandle typeDef)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 39887, 40077);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 39972, 40000);

                AttributeInfo
                attributeInfo
                = default(AttributeInfo);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 40014, 40066);

                return f_415_40021_40065(this, typeDef, out attributeInfo);
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 39887, 40077);

                bool
                f_415_40021_40065(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                typeDef, out Microsoft.CodeAnalysis.PEModule.AttributeInfo
                attributeInfo)
                {
                    var return_v = this_param.IsNoPiaLocalType(typeDef, out attributeInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 40021, 40065);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 39887, 40077);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 39887, 40077);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool HasParamsAttribute(EntityHandle token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 40089, 40262);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 40166, 40251);

                return f_415_40173_40241(this, token, AttributeDescription.ParamArrayAttribute).HasValue;
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 40089, 40262);

                Microsoft.CodeAnalysis.PEModule.AttributeInfo
                f_415_40173_40241(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.EntityHandle
                hasAttribute, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.FindTargetAttribute(hasAttribute, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 40173, 40241);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 40089, 40262);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 40089, 40262);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool HasIsReadOnlyAttribute(EntityHandle token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 40274, 40451);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 40355, 40440);

                return f_415_40362_40430(this, token, AttributeDescription.IsReadOnlyAttribute).HasValue;
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 40274, 40451);

                Microsoft.CodeAnalysis.PEModule.AttributeInfo
                f_415_40362_40430(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.EntityHandle
                hasAttribute, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.FindTargetAttribute(hasAttribute, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 40362, 40430);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 40274, 40451);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 40274, 40451);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool HasDoesNotReturnAttribute(EntityHandle token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 40463, 40646);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 40547, 40635);

                return f_415_40554_40625(this, token, AttributeDescription.DoesNotReturnAttribute).HasValue;
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 40463, 40646);

                Microsoft.CodeAnalysis.PEModule.AttributeInfo
                f_415_40554_40625(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.EntityHandle
                hasAttribute, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.FindTargetAttribute(hasAttribute, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 40554, 40625);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 40463, 40646);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 40463, 40646);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool HasIsUnmanagedAttribute(EntityHandle token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 40658, 40837);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 40740, 40826);

                return f_415_40747_40816(this, token, AttributeDescription.IsUnmanagedAttribute).HasValue;
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 40658, 40837);

                Microsoft.CodeAnalysis.PEModule.AttributeInfo
                f_415_40747_40816(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.EntityHandle
                hasAttribute, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.FindTargetAttribute(hasAttribute, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 40747, 40816);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 40658, 40837);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 40658, 40837);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool HasExtensionAttribute(EntityHandle token, bool ignoreCase)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 40849, 41124);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 40946, 41113);

                return f_415_40953_41103(this, token, (DynAbs.Tracing.TraceSender.Conditional_F1(415, 40980, 40990) || ((ignoreCase && DynAbs.Tracing.TraceSender.Conditional_F2(415, 40993, 41047)) || DynAbs.Tracing.TraceSender.Conditional_F3(415, 41050, 41102))) ? AttributeDescription.CaseInsensitiveExtensionAttribute : AttributeDescription.CaseSensitiveExtensionAttribute).HasValue;
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 40849, 41124);

                Microsoft.CodeAnalysis.PEModule.AttributeInfo
                f_415_40953_41103(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.EntityHandle
                hasAttribute, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.FindTargetAttribute(hasAttribute, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 40953, 41103);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 40849, 41124);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 40849, 41124);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool HasVisualBasicEmbeddedAttribute(EntityHandle token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 41136, 41331);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 41226, 41320);

                return f_415_41233_41310(this, token, AttributeDescription.VisualBasicEmbeddedAttribute).HasValue;
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 41136, 41331);

                Microsoft.CodeAnalysis.PEModule.AttributeInfo
                f_415_41233_41310(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.EntityHandle
                hasAttribute, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.FindTargetAttribute(hasAttribute, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 41233, 41310);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 41136, 41331);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 41136, 41331);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool HasCodeAnalysisEmbeddedAttribute(EntityHandle token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 41343, 41540);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 41434, 41529);

                return f_415_41441_41519(this, token, AttributeDescription.CodeAnalysisEmbeddedAttribute).HasValue;
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 41343, 41540);

                Microsoft.CodeAnalysis.PEModule.AttributeInfo
                f_415_41441_41519(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.EntityHandle
                hasAttribute, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.FindTargetAttribute(hasAttribute, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 41441, 41519);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 41343, 41540);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 41343, 41540);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool HasDefaultMemberAttribute(EntityHandle token, out string memberName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 41552, 41770);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 41659, 41759);

                return f_415_41666_41758(this, token, AttributeDescription.DefaultMemberAttribute, out memberName);
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 41552, 41770);

                bool
                f_415_41666_41758(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.EntityHandle
                token, Microsoft.CodeAnalysis.AttributeDescription
                description, out string
                value)
                {
                    var return_v = this_param.HasStringValuedAttribute(token, description, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 41666, 41758);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 41552, 41770);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 41552, 41770);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool HasGuidAttribute(EntityHandle token, out string guidValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 41782, 41980);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 41879, 41969);

                return f_415_41886_41968(this, token, AttributeDescription.GuidAttribute, out guidValue);
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 41782, 41980);

                bool
                f_415_41886_41968(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.EntityHandle
                token, Microsoft.CodeAnalysis.AttributeDescription
                description, out string
                value)
                {
                    var return_v = this_param.HasStringValuedAttribute(token, description, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 41886, 41968);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 41782, 41980);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 41782, 41980);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool HasFixedBufferAttribute(EntityHandle token, out string elementTypeName, out int bufferSize)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 41992, 42258);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 42122, 42247);

                return f_415_42129_42246(this, token, AttributeDescription.FixedBufferAttribute, out elementTypeName, out bufferSize);
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 41992, 42258);

                bool
                f_415_42129_42246(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.EntityHandle
                token, Microsoft.CodeAnalysis.AttributeDescription
                description, out string
                stringValue, out int
                intValue)
                {
                    var return_v = this_param.HasStringAndIntValuedAttribute(token, description, out stringValue, out intValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 42129, 42246);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 41992, 42258);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 41992, 42258);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool HasAccessedThroughPropertyAttribute(EntityHandle token, out string propertyName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 42270, 42512);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 42389, 42501);

                return f_415_42396_42500(this, token, AttributeDescription.AccessedThroughPropertyAttribute, out propertyName);
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 42270, 42512);

                bool
                f_415_42396_42500(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.EntityHandle
                token, Microsoft.CodeAnalysis.AttributeDescription
                description, out string
                value)
                {
                    var return_v = this_param.HasStringValuedAttribute(token, description, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 42396, 42500);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 42270, 42512);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 42270, 42512);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool HasRequiredAttributeAttribute(EntityHandle token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 42524, 42715);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 42612, 42704);

                return f_415_42619_42694(this, token, AttributeDescription.RequiredAttributeAttribute).HasValue;
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 42524, 42715);

                Microsoft.CodeAnalysis.PEModule.AttributeInfo
                f_415_42619_42694(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.EntityHandle
                hasAttribute, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.FindTargetAttribute(hasAttribute, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 42619, 42694);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 42524, 42715);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 42524, 42715);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool HasAttribute(EntityHandle token, AttributeDescription description)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 42727, 42899);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 42832, 42888);

                return f_415_42839_42878(this, token, description).HasValue;
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 42727, 42899);

                Microsoft.CodeAnalysis.PEModule.AttributeInfo
                f_415_42839_42878(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.EntityHandle
                hasAttribute, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.FindTargetAttribute(hasAttribute, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 42839, 42878);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 42727, 42899);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 42727, 42899);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal CustomAttributeHandle GetAttributeHandle(EntityHandle token, AttributeDescription description)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 42911, 43104);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 43039, 43093);

                return f_415_43046_43085(this, token, description).Handle;
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 42911, 43104);

                Microsoft.CodeAnalysis.PEModule.AttributeInfo
                f_415_43046_43085(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.EntityHandle
                hasAttribute, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.FindTargetAttribute(hasAttribute, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 43046, 43085);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 42911, 43104);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 42911, 43104);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static readonly ImmutableArray<bool> s_simpleTransformFlags;

        internal bool HasDynamicAttribute(EntityHandle token, out ImmutableArray<bool> transformFlags)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 43226, 43938);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 43345, 43432);

                AttributeInfo
                info = f_415_43366_43431(this, token, AttributeDescription.DynamicAttribute)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 43446, 43531);

                f_415_43446_43530(f_415_43459_43473_M(!info.HasValue) || (DynAbs.Tracing.TraceSender.Expression_False(415, 43459, 43501) || info.SignatureIndex == 0) || (DynAbs.Tracing.TraceSender.Expression_False(415, 43459, 43529) || info.SignatureIndex == 1));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 43547, 43670) || true) && (f_415_43551_43565_M(!info.HasValue))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 43547, 43670);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 43599, 43624);

                    transformFlags = default;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 43642, 43655);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(415, 43547, 43670);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 43686, 43833) || true) && (info.SignatureIndex == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 43686, 43833);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 43748, 43788);

                    transformFlags = s_simpleTransformFlags;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 43806, 43818);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(415, 43686, 43833);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 43849, 43927);

                return f_415_43856_43926(this, info.Handle, out transformFlags);
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 43226, 43938);

                Microsoft.CodeAnalysis.PEModule.AttributeInfo
                f_415_43366_43431(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.EntityHandle
                hasAttribute, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.FindTargetAttribute(hasAttribute, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 43366, 43431);
                    return return_v;
                }


                bool
                f_415_43459_43473_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 43459, 43473);
                    return return_v;
                }


                int
                f_415_43446_43530(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 43446, 43530);
                    return 0;
                }


                bool
                f_415_43551_43565_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 43551, 43565);
                    return return_v;
                }


                bool
                f_415_43856_43926(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.CustomAttributeHandle
                handle, out System.Collections.Immutable.ImmutableArray<bool>
                value)
                {
                    var return_v = this_param.TryExtractBoolArrayValueFromAttribute(handle, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 43856, 43926);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 43226, 43938);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 43226, 43938);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool HasNativeIntegerAttribute(EntityHandle token, out ImmutableArray<bool> transformFlags)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 43950, 44674);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 44075, 44168);

                AttributeInfo
                info = f_415_44096_44167(this, token, AttributeDescription.NativeIntegerAttribute)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 44182, 44267);

                f_415_44182_44266(f_415_44195_44209_M(!info.HasValue) || (DynAbs.Tracing.TraceSender.Expression_False(415, 44195, 44237) || info.SignatureIndex == 0) || (DynAbs.Tracing.TraceSender.Expression_False(415, 44195, 44265) || info.SignatureIndex == 1));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 44283, 44406) || true) && (f_415_44287_44301_M(!info.HasValue))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 44283, 44406);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 44335, 44360);

                    transformFlags = default;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 44378, 44391);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(415, 44283, 44406);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 44422, 44569) || true) && (info.SignatureIndex == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 44422, 44569);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 44484, 44524);

                    transformFlags = s_simpleTransformFlags;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 44542, 44554);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(415, 44422, 44569);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 44585, 44663);

                return f_415_44592_44662(this, info.Handle, out transformFlags);
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 43950, 44674);

                Microsoft.CodeAnalysis.PEModule.AttributeInfo
                f_415_44096_44167(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.EntityHandle
                hasAttribute, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.FindTargetAttribute(hasAttribute, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 44096, 44167);
                    return return_v;
                }


                bool
                f_415_44195_44209_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 44195, 44209);
                    return return_v;
                }


                int
                f_415_44182_44266(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 44182, 44266);
                    return 0;
                }


                bool
                f_415_44287_44301_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 44287, 44301);
                    return return_v;
                }


                bool
                f_415_44592_44662(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.CustomAttributeHandle
                handle, out System.Collections.Immutable.ImmutableArray<bool>
                value)
                {
                    var return_v = this_param.TryExtractBoolArrayValueFromAttribute(handle, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 44592, 44662);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 43950, 44674);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 43950, 44674);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool HasTupleElementNamesAttribute(EntityHandle token, out ImmutableArray<string> tupleElementNames)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 44686, 45282);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 44820, 44907);

                var
                info = f_415_44831_44906(this, token, AttributeDescription.TupleElementNamesAttribute)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 44921, 45006);

                f_415_44921_45005(f_415_44934_44948_M(!info.HasValue) || (DynAbs.Tracing.TraceSender.Expression_False(415, 44934, 44976) || info.SignatureIndex == 0) || (DynAbs.Tracing.TraceSender.Expression_False(415, 44934, 45004) || info.SignatureIndex == 1));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 45022, 45172) || true) && (f_415_45026_45040_M(!info.HasValue))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 45022, 45172);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 45074, 45126);

                    tupleElementNames = default(ImmutableArray<string>);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 45144, 45157);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(415, 45022, 45172);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 45188, 45271);

                return f_415_45195_45270(this, info.Handle, out tupleElementNames);
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 44686, 45282);

                Microsoft.CodeAnalysis.PEModule.AttributeInfo
                f_415_44831_44906(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.EntityHandle
                hasAttribute, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.FindTargetAttribute(hasAttribute, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 44831, 44906);
                    return return_v;
                }


                bool
                f_415_44934_44948_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 44934, 44948);
                    return return_v;
                }


                int
                f_415_44921_45005(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 44921, 45005);
                    return 0;
                }


                bool
                f_415_45026_45040_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 45026, 45040);
                    return return_v;
                }


                bool
                f_415_45195_45270(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.CustomAttributeHandle
                handle, out System.Collections.Immutable.ImmutableArray<string>
                value)
                {
                    var return_v = this_param.TryExtractStringArrayValueFromAttribute(handle, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 45195, 45270);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 44686, 45282);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 44686, 45282);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool HasIsByRefLikeAttribute(EntityHandle token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 45294, 45473);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 45376, 45462);

                return f_415_45383_45452(this, token, AttributeDescription.IsByRefLikeAttribute).HasValue;
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 45294, 45473);

                Microsoft.CodeAnalysis.PEModule.AttributeInfo
                f_415_45383_45452(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.EntityHandle
                hasAttribute, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.FindTargetAttribute(hasAttribute, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 45383, 45452);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 45294, 45473);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 45294, 45473);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal const string
        ByRefLikeMarker = "Types with embedded references are not supported in this version of your compiler."
        ;

        internal ObsoleteAttributeData TryGetDeprecatedOrExperimentalOrObsoleteAttribute(
                    EntityHandle token,
                    IAttributeNamedArgumentDecoder decoder,
                    bool ignoreByRefLikeMarker)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 45622, 46970);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 45855, 45874);

                AttributeInfo
                info
                = default(AttributeInfo);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 45890, 45966);

                info = f_415_45897_45965(this, token, AttributeDescription.DeprecatedAttribute);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 45980, 46097) || true) && (info.HasValue)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 45980, 46097);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 46031, 46082);

                    return f_415_46038_46081(this, info);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(415, 45980, 46097);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 46113, 46187);

                info = f_415_46120_46186(this, token, AttributeDescription.ObsoleteAttribute);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 46201, 46587) || true) && (info.HasValue)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 46201, 46587);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 46252, 46340);

                    ObsoleteAttributeData
                    obsoleteData = f_415_46289_46339(this, info, decoder)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 46358, 46534);

                    switch (DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(obsoleteData, 415, 46366, 46387)?.Message)
                    {

                        case ByRefLikeMarker when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 46450, 46476) || true) && (ignoreByRefLikeMarker) && (DynAbs.Tracing.TraceSender.Expression_True(415, 46450, 46476) || true)
                    :
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 46358, 46534);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 46503, 46515);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(415, 46358, 46534);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 46552, 46572);

                    return obsoleteData;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(415, 46201, 46587);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 46720, 46798);

                info = f_415_46727_46797(this, token, AttributeDescription.ExperimentalAttribute);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 46812, 46931) || true) && (info.HasValue)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 46812, 46931);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 46863, 46916);

                    return f_415_46870_46915(this, info);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(415, 46812, 46931);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 46947, 46959);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 45622, 46970);

                Microsoft.CodeAnalysis.PEModule.AttributeInfo
                f_415_45897_45965(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.EntityHandle
                hasAttribute, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.FindTargetAttribute(hasAttribute, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 45897, 45965);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ObsoleteAttributeData
                f_415_46038_46081(Microsoft.CodeAnalysis.PEModule
                this_param, Microsoft.CodeAnalysis.PEModule.AttributeInfo
                attributeInfo)
                {
                    var return_v = this_param.TryExtractDeprecatedDataFromAttribute(attributeInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 46038, 46081);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PEModule.AttributeInfo
                f_415_46120_46186(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.EntityHandle
                hasAttribute, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.FindTargetAttribute(hasAttribute, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 46120, 46186);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ObsoleteAttributeData?
                f_415_46289_46339(Microsoft.CodeAnalysis.PEModule
                this_param, Microsoft.CodeAnalysis.PEModule.AttributeInfo
                attributeInfo, Microsoft.CodeAnalysis.IAttributeNamedArgumentDecoder
                decoder)
                {
                    var return_v = this_param.TryExtractObsoleteDataFromAttribute(attributeInfo, decoder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 46289, 46339);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PEModule.AttributeInfo
                f_415_46727_46797(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.EntityHandle
                hasAttribute, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.FindTargetAttribute(hasAttribute, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 46727, 46797);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ObsoleteAttributeData
                f_415_46870_46915(Microsoft.CodeAnalysis.PEModule
                this_param, Microsoft.CodeAnalysis.PEModule.AttributeInfo
                attributeInfo)
                {
                    var return_v = this_param.TryExtractExperimentalDataFromAttribute(attributeInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 46870, 46915);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 45622, 46970);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 45622, 46970);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal UnmanagedCallersOnlyAttributeData? TryGetUnmanagedCallersOnlyAttribute(
                    EntityHandle token,
                    IAttributeNamedArgumentDecoder attributeArgumentDecoder,
                    Func<string, TypedConstant, bool, (bool IsCallConvs, ImmutableHashSet<INamedTypeSymbolInternal>? CallConvs)> unmanagedCallersOnlyDecoder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 47000, 49330);
                System.Reflection.Metadata.BlobReader sigReader = default(System.Reflection.Metadata.BlobReader);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 47670, 47770);

                AttributeInfo
                info = f_415_47691_47769(this, token, AttributeDescription.UnmanagedCallersOnlyAttribute)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 47784, 47956) || true) && (f_415_47788_47802_M(!info.HasValue) || (DynAbs.Tracing.TraceSender.Expression_False(415, 47788, 47830) || info.SignatureIndex != 0) || (DynAbs.Tracing.TraceSender.Expression_False(415, 47788, 47895) || !f_415_47835_47895(this, info.Handle, out sigReader)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 47784, 47956);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 47929, 47941);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(415, 47784, 47956);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 47972, 48052);

                var
                unmanagedConventionTypes = ImmutableHashSet<INamedTypeSymbolInternal>.Empty
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 48068, 49229) || true) && (sigReader.RemainingBytes > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 48068, 49229);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 48178, 48216);

                        var
                        numNamed = sigReader.ReadUInt16()
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 48247, 48252);
                            for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 48238, 49051) || true) && (i < numNamed)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 48268, 48271)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(415, 48238, 49051))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 48238, 49051);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 48321, 48464);

                                var ((name, value), isProperty, typeCode, elementTypeCode) = f_415_48382_48463(attributeArgumentDecoder, ref sigReader);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 48490, 48678) || true) && (typeCode != SerializationTypeCode.SZArray || (DynAbs.Tracing.TraceSender.Expression_False(415, 48494, 48584) || elementTypeCode != SerializationTypeCode.Type))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 48490, 48678);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 48642, 48651);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(415, 48490, 48678);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 48706, 48787);

                                var
                                namedArgumentDecoded = f_415_48733_48786(unmanagedCallersOnlyDecoder, name, value, !isProperty)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 48813, 49028) || true) && (namedArgumentDecoded.IsCallConvs)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 48813, 49028);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 48907, 48965);

                                    unmanagedConventionTypes = namedArgumentDecoded.CallConvs;
                                    DynAbs.Tracing.TraceSender.TraceBreak(415, 48995, 49001);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(415, 48813, 49028);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(415, 1, 814);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(415, 1, 814);
                        }
                    }
                    catch (Exception ex) when (ex is BadImageFormatException or UnsupportedSignatureContent)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(415, 49088, 49214);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(415, 49088, 49214);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(415, 48068, 49229);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 49245, 49319);

                return f_415_49252_49318(unmanagedConventionTypes);
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 47000, 49330);

                Microsoft.CodeAnalysis.PEModule.AttributeInfo
                f_415_47691_47769(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.EntityHandle
                hasAttribute, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.FindTargetAttribute(hasAttribute, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 47691, 47769);
                    return return_v;
                }


                bool
                f_415_47788_47802_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 47788, 47802);
                    return return_v;
                }


                bool
                f_415_47835_47895(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.CustomAttributeHandle
                handle, out System.Reflection.Metadata.BlobReader
                blobReader)
                {
                    var return_v = this_param.TryGetAttributeReader(handle, out blobReader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 47835, 47895);
                    return return_v;
                }


                (System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant> nameValuePair, bool isProperty, System.Reflection.Metadata.SerializationTypeCode typeCode, System.Reflection.Metadata.SerializationTypeCode elementTypeCode)
                f_415_48382_48463(Microsoft.CodeAnalysis.IAttributeNamedArgumentDecoder
                this_param, ref System.Reflection.Metadata.BlobReader
                argReader)
                {
                    var return_v = this_param.DecodeCustomAttributeNamedArgumentOrThrow(ref argReader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 48382, 48463);
                    return return_v;
                }


                (bool IsCallConvs, System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Symbols.INamedTypeSymbolInternal>? CallConvs)
                f_415_48733_48786(System.Func<string, Microsoft.CodeAnalysis.TypedConstant, bool, (bool IsCallConvs, System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Symbols.INamedTypeSymbolInternal>? CallConvs)>
                this_param, string
                arg1, Microsoft.CodeAnalysis.TypedConstant
                arg2, bool
                arg3)
                {
                    var return_v = this_param.Invoke(arg1, arg2, arg3);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 48733, 48786);
                    return return_v;
                }


                Microsoft.CodeAnalysis.UnmanagedCallersOnlyAttributeData
                f_415_49252_49318(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Symbols.INamedTypeSymbolInternal>?
                callingConventionTypes)
                {
                    var return_v = UnmanagedCallersOnlyAttributeData.Create(callingConventionTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 49252, 49318);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 47000, 49330);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 47000, 49330);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool HasMaybeNullWhenOrNotNullWhenOrDoesNotReturnIfAttribute(EntityHandle token, AttributeDescription description, out bool when)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 49361, 50208);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 49524, 49597);

                f_415_49524_49596(description.Namespace == "System.Diagnostics.CodeAnalysis");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 49611, 49766);

                f_415_49611_49765(description.Name == "MaybeNullWhenAttribute" || (DynAbs.Tracing.TraceSender.Expression_False(415, 49624, 49714) || description.Name == "NotNullWhenAttribute") || (DynAbs.Tracing.TraceSender.Expression_False(415, 49624, 49764) || description.Name == "DoesNotReturnIfAttribute"));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 49782, 49843);

                AttributeInfo
                info = f_415_49803_49842(this, token, description)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 49857, 50143) || true) && (info.HasValue && (DynAbs.Tracing.TraceSender.Expression_True(415, 49861, 50001) &&                // MaybeNullWhen(bool), NotNullWhen(bool), DoesNotReturnIf(bool)
                                info.SignatureIndex == 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 49857, 50143);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 50035, 50128);

                    return f_415_50042_50127(this, info.Handle, out when, s_attributeBooleanValueExtractor);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(415, 49857, 50143);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 50157, 50170);

                when = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 50184, 50197);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 49361, 50208);

                int
                f_415_49524_49596(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 49524, 49596);
                    return 0;
                }


                int
                f_415_49611_49765(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 49611, 49765);
                    return 0;
                }


                Microsoft.CodeAnalysis.PEModule.AttributeInfo
                f_415_49803_49842(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.EntityHandle
                hasAttribute, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.FindTargetAttribute(hasAttribute, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 49803, 49842);
                    return return_v;
                }


                bool
                f_415_50042_50127(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.CustomAttributeHandle
                handle, out bool
                value, Microsoft.CodeAnalysis.PEModule.AttributeValueExtractor<bool>
                valueExtractor)
                {
                    var return_v = this_param.TryExtractValueFromAttribute<bool>(handle, out value, valueExtractor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 50042, 50127);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 49361, 50208);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 49361, 50208);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal CustomAttributeHandle GetAttributeUsageAttributeHandle(EntityHandle token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 50220, 50519);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 50328, 50422);

                AttributeInfo
                info = f_415_50349_50421(this, token, AttributeDescription.AttributeUsageAttribute)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 50436, 50475);

                f_415_50436_50474(info.SignatureIndex == 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 50489, 50508);

                return info.Handle;
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 50220, 50519);

                Microsoft.CodeAnalysis.PEModule.AttributeInfo
                f_415_50349_50421(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.EntityHandle
                hasAttribute, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.FindTargetAttribute(hasAttribute, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 50349, 50421);
                    return return_v;
                }


                int
                f_415_50436_50474(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 50436, 50474);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 50220, 50519);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 50220, 50519);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool HasInterfaceTypeAttribute(EntityHandle token, out ComInterfaceType interfaceType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 50531, 50997);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 50651, 50744);

                AttributeInfo
                info = f_415_50672_50743(this, token, AttributeDescription.InterfaceTypeAttribute)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 50758, 50901) || true) && (info.HasValue && (DynAbs.Tracing.TraceSender.Expression_True(415, 50762, 50840) && f_415_50779_50840(this, info, out interfaceType)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 50758, 50901);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 50874, 50886);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(415, 50758, 50901);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 50917, 50959);

                interfaceType = default(ComInterfaceType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 50973, 50986);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 50531, 50997);

                Microsoft.CodeAnalysis.PEModule.AttributeInfo
                f_415_50672_50743(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.EntityHandle
                hasAttribute, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.FindTargetAttribute(hasAttribute, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 50672, 50743);
                    return return_v;
                }


                bool
                f_415_50779_50840(Microsoft.CodeAnalysis.PEModule
                this_param, Microsoft.CodeAnalysis.PEModule.AttributeInfo
                attributeInfo, out System.Runtime.InteropServices.ComInterfaceType
                interfaceType)
                {
                    var return_v = this_param.TryExtractInterfaceTypeFromAttribute(attributeInfo, out interfaceType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 50779, 50840);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 50531, 50997);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 50531, 50997);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool HasTypeLibTypeAttribute(EntityHandle token, out Cci.TypeLibTypeFlags flags)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 51009, 51453);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 51123, 51214);

                AttributeInfo
                info = f_415_51144_51213(this, token, AttributeDescription.TypeLibTypeAttribute)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 51228, 51361) || true) && (info.HasValue && (DynAbs.Tracing.TraceSender.Expression_True(415, 51232, 51300) && f_415_51249_51300(this, info, out flags)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 51228, 51361);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 51334, 51346);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(415, 51228, 51361);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 51377, 51415);

                flags = default(Cci.TypeLibTypeFlags);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 51429, 51442);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 51009, 51453);

                Microsoft.CodeAnalysis.PEModule.AttributeInfo
                f_415_51144_51213(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.EntityHandle
                hasAttribute, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.FindTargetAttribute(hasAttribute, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 51144, 51213);
                    return return_v;
                }


                bool
                f_415_51249_51300(Microsoft.CodeAnalysis.PEModule
                this_param, Microsoft.CodeAnalysis.PEModule.AttributeInfo
                info, out Microsoft.Cci.TypeLibTypeFlags
                flags)
                {
                    var return_v = this_param.TryExtractTypeLibTypeFromAttribute(info, out flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 51249, 51300);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 51009, 51453);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 51009, 51453);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool HasDateTimeConstantAttribute(EntityHandle token, out ConstantValue defaultValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 51465, 52348);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 51584, 51595);

                long
                value
                = default(long);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 51609, 51709);

                AttributeInfo
                info = f_415_51630_51708(this, token, AttributeDescription.DateTimeConstantAttribute)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 51723, 52274) || true) && (info.HasValue && (DynAbs.Tracing.TraceSender.Expression_True(415, 51727, 51800) && f_415_51744_51800(this, info.Handle, out value)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 51723, 52274);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 51924, 52227) || true) && (value < DateTime.MinValue.Ticks || (DynAbs.Tracing.TraceSender.Expression_False(415, 51928, 51994) || value > DateTime.MaxValue.Ticks))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 51924, 52227);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 52036, 52069);

                        defaultValue = f_415_52051_52068();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 51924, 52227);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 51924, 52227);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 52151, 52208);

                        defaultValue = f_415_52166_52207(f_415_52187_52206(value));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 51924, 52227);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 52247, 52259);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(415, 51723, 52274);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 52290, 52310);

                defaultValue = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 52324, 52337);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 51465, 52348);

                Microsoft.CodeAnalysis.PEModule.AttributeInfo
                f_415_51630_51708(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.EntityHandle
                hasAttribute, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.FindLastTargetAttribute(hasAttribute, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 51630, 51708);
                    return return_v;
                }


                bool
                f_415_51744_51800(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.CustomAttributeHandle
                handle, out long
                value)
                {
                    var return_v = this_param.TryExtractLongValueFromAttribute(handle, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 51744, 51800);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_415_52051_52068()
                {
                    var return_v = ConstantValue.Bad;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 52051, 52068);
                    return return_v;
                }


                System.DateTime
                f_415_52187_52206(long
                ticks)
                {
                    var return_v = new System.DateTime(ticks);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 52187, 52206);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_415_52166_52207(System.DateTime
                value)
                {
                    var return_v = ConstantValue.Create(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 52166, 52207);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 51465, 52348);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 51465, 52348);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool HasDecimalConstantAttribute(EntityHandle token, out ConstantValue defaultValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 52360, 52910);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 52478, 52492);

                decimal
                value
                = default(decimal);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 52506, 52605);

                AttributeInfo
                info = f_415_52527_52604(this, token, AttributeDescription.DecimalConstantAttribute)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 52619, 52836) || true) && (info.HasValue && (DynAbs.Tracing.TraceSender.Expression_True(415, 52623, 52714) && f_415_52640_52714(this, info.Handle, out value)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 52619, 52836);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 52748, 52791);

                    defaultValue = f_415_52763_52790(value);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 52809, 52821);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(415, 52619, 52836);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 52852, 52872);

                defaultValue = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 52886, 52899);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 52360, 52910);

                Microsoft.CodeAnalysis.PEModule.AttributeInfo
                f_415_52527_52604(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.EntityHandle
                hasAttribute, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.FindLastTargetAttribute(hasAttribute, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 52527, 52604);
                    return return_v;
                }


                bool
                f_415_52640_52714(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.CustomAttributeHandle
                handle, out decimal
                value)
                {
                    var return_v = this_param.TryExtractDecimalValueFromDecimalConstantAttribute(handle, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 52640, 52714);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_415_52763_52790(decimal
                value)
                {
                    var return_v = ConstantValue.Create(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 52763, 52790);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 52360, 52910);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 52360, 52910);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool HasNullablePublicOnlyAttribute(EntityHandle token, out bool includesInternals)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 52922, 53568);
                bool value = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 53039, 53137);

                AttributeInfo
                info = f_415_53060_53136(this, token, AttributeDescription.NullablePublicOnlyAttribute)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 53151, 53490) || true) && (info.HasValue)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 53151, 53490);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 53202, 53241);

                    f_415_53202_53240(info.SignatureIndex == 0);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 53259, 53475) || true) && (f_415_53263_53354(this, info.Handle, out value, s_attributeBooleanValueExtractor))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 53259, 53475);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 53396, 53422);

                        includesInternals = value;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 53444, 53456);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 53259, 53475);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(415, 53151, 53490);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 53504, 53530);

                includesInternals = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 53544, 53557);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 52922, 53568);

                Microsoft.CodeAnalysis.PEModule.AttributeInfo
                f_415_53060_53136(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.EntityHandle
                hasAttribute, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.FindTargetAttribute(hasAttribute, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 53060, 53136);
                    return return_v;
                }


                int
                f_415_53202_53240(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 53202, 53240);
                    return 0;
                }


                bool
                f_415_53263_53354(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.CustomAttributeHandle
                handle, out bool
                value, Microsoft.CodeAnalysis.PEModule.AttributeValueExtractor<bool>
                valueExtractor)
                {
                    var return_v = this_param.TryExtractValueFromAttribute<bool>(handle, out value, valueExtractor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 53263, 53354);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 52922, 53568);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 52922, 53568);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ImmutableArray<string> GetInternalsVisibleToAttributeValues(EntityHandle token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 53580, 53985);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 53693, 53803);

                List<AttributeInfo>
                attrInfos = f_415_53725_53802(this, token, AttributeDescription.InternalsVisibleToAttribute)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 53817, 53892);

                ArrayBuilder<string>
                result = f_415_53847_53891(this, attrInfos)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 53906, 53974);

                return f_415_53913_53941_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(result, 415, 53913, 53941)?.ToImmutableAndFree()) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Immutable.ImmutableArray<string>?>(415, 53913, 53973) ?? ImmutableArray<string>.Empty);
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 53580, 53985);

                System.Collections.Generic.List<Microsoft.CodeAnalysis.PEModule.AttributeInfo>
                f_415_53725_53802(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.EntityHandle
                hasAttribute, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.FindTargetAttributes(hasAttribute, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 53725, 53802);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                f_415_53847_53891(Microsoft.CodeAnalysis.PEModule
                this_param, System.Collections.Generic.List<Microsoft.CodeAnalysis.PEModule.AttributeInfo>
                attrInfos)
                {
                    var return_v = this_param.ExtractStringValuesFromAttributes(attrInfos);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 53847, 53891);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>?
                f_415_53913_53941_I(System.Collections.Immutable.ImmutableArray<string>?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 53913, 53941);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 53580, 53985);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 53580, 53985);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ImmutableArray<string> GetConditionalAttributeValues(EntityHandle token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 53997, 54388);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 54103, 54206);

                List<AttributeInfo>
                attrInfos = f_415_54135_54205(this, token, AttributeDescription.ConditionalAttribute)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 54220, 54295);

                ArrayBuilder<string>
                result = f_415_54250_54294(this, attrInfos)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 54309, 54377);

                return f_415_54316_54344_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(result, 415, 54316, 54344)?.ToImmutableAndFree()) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Immutable.ImmutableArray<string>?>(415, 54316, 54376) ?? ImmutableArray<string>.Empty);
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 53997, 54388);

                System.Collections.Generic.List<Microsoft.CodeAnalysis.PEModule.AttributeInfo>
                f_415_54135_54205(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.EntityHandle
                hasAttribute, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.FindTargetAttributes(hasAttribute, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 54135, 54205);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                f_415_54250_54294(Microsoft.CodeAnalysis.PEModule
                this_param, System.Collections.Generic.List<Microsoft.CodeAnalysis.PEModule.AttributeInfo>
                attrInfos)
                {
                    var return_v = this_param.ExtractStringValuesFromAttributes(attrInfos);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 54250, 54294);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>?
                f_415_54316_54344_I(System.Collections.Immutable.ImmutableArray<string>?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 54316, 54344);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 53997, 54388);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 53997, 54388);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ImmutableArray<string> GetMemberNotNullAttributeValues(EntityHandle token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 54544, 55900);
                string extracted = default(string);
                System.Collections.Immutable.ImmutableArray<string> extracted2 = default(System.Collections.Immutable.ImmutableArray<string>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 54652, 54757);

                List<AttributeInfo>
                attrInfos = f_415_54684_54756(this, token, AttributeDescription.MemberNotNullAttribute)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 54771, 54901) || true) && (attrInfos is null || (DynAbs.Tracing.TraceSender.Expression_False(415, 54775, 54816) || f_415_54796_54811(attrInfos) == 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 54771, 54901);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 54850, 54886);

                    return ImmutableArray<string>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(415, 54771, 54901);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 54917, 54980);

                var
                result = f_415_54930_54979(f_415_54963_54978(attrInfos))
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 54996, 55838);
                    foreach (var ai in f_415_55015_55024_I(attrInfos))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 54996, 55838);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 55058, 55823) || true) && (ai.SignatureIndex == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 55058, 55823);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 55126, 55400) || true) && (f_415_55130_55197(this, ai.Handle, out extracted))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 55126, 55400);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 55247, 55377) || true) && (extracted is object)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 55247, 55377);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 55328, 55350);

                                    f_415_55328_55349(result, extracted);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(415, 55247, 55377);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(415, 55126, 55400);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(415, 55058, 55823);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 55058, 55823);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 55442, 55823) || true) && (f_415_55446_55535(this, ai.Handle, out extracted2))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 55442, 55823);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 55577, 55804);
                                    foreach (var value in f_415_55599_55609_I(extracted2))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 55577, 55804);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 55659, 55781) || true) && (value is object)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 55659, 55781);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 55736, 55754);

                                            f_415_55736_55753(result, value);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(415, 55659, 55781);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 55577, 55804);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(415, 1, 228);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(415, 1, 228);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(415, 55442, 55823);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(415, 55058, 55823);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 54996, 55838);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(415, 1, 843);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(415, 1, 843);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 55854, 55889);

                return f_415_55861_55888(result);
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 54544, 55900);

                System.Collections.Generic.List<Microsoft.CodeAnalysis.PEModule.AttributeInfo>
                f_415_54684_54756(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.EntityHandle
                hasAttribute, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.FindTargetAttributes(hasAttribute, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 54684, 54756);
                    return return_v;
                }


                int
                f_415_54796_54811(System.Collections.Generic.List<Microsoft.CodeAnalysis.PEModule.AttributeInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 54796, 54811);
                    return return_v;
                }


                int
                f_415_54963_54978(System.Collections.Generic.List<Microsoft.CodeAnalysis.PEModule.AttributeInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 54963, 54978);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                f_415_54930_54979(int
                capacity)
                {
                    var return_v = ArrayBuilder<string>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 54930, 54979);
                    return return_v;
                }


                bool
                f_415_55130_55197(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.CustomAttributeHandle
                handle, out string
                value)
                {
                    var return_v = this_param.TryExtractStringValueFromAttribute(handle, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 55130, 55197);
                    return return_v;
                }


                int
                f_415_55328_55349(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 55328, 55349);
                    return 0;
                }


                bool
                f_415_55446_55535(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.CustomAttributeHandle
                handle, out System.Collections.Immutable.ImmutableArray<string>
                value)
                {
                    var return_v = this_param.TryExtractStringArrayValueFromAttribute(handle, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 55446, 55535);
                    return return_v;
                }


                int
                f_415_55736_55753(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 55736, 55753);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_415_55599_55609_I(System.Collections.Immutable.ImmutableArray<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 55599, 55609);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.CodeAnalysis.PEModule.AttributeInfo>
                f_415_55015_55024_I(System.Collections.Generic.List<Microsoft.CodeAnalysis.PEModule.AttributeInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 55015, 55024);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_415_55861_55888(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 55861, 55888);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 54544, 55900);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 54544, 55900);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal (ImmutableArray<string> whenTrue, ImmutableArray<string> whenFalse) GetMemberNotNullWhenAttributeValues(EntityHandle token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 56060, 57893);
                Microsoft.CodeAnalysis.PEModule.BoolAndStringData extracted = default(Microsoft.CodeAnalysis.PEModule.BoolAndStringData);
                Microsoft.CodeAnalysis.PEModule.BoolAndStringArrayData extracted2 = default(Microsoft.CodeAnalysis.PEModule.BoolAndStringArrayData);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 56217, 56326);

                List<AttributeInfo>
                attrInfos = f_415_56249_56325(this, token, AttributeDescription.MemberNotNullWhenAttribute)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 56340, 56502) || true) && (attrInfos is null || (DynAbs.Tracing.TraceSender.Expression_False(415, 56344, 56385) || f_415_56365_56380(attrInfos) == 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 56340, 56502);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 56419, 56487);

                    return (ImmutableArray<string>.Empty, ImmutableArray<string>.Empty);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(415, 56340, 56502);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 56518, 56583);

                var
                whenTrue = f_415_56533_56582(f_415_56566_56581(attrInfos))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 56597, 56663);

                var
                whenFalse = f_415_56613_56662(f_415_56646_56661(attrInfos))
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 56679, 57795);
                    foreach (var ai in f_415_56698_56707_I(attrInfos))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 56679, 57795);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 56741, 57780) || true) && (ai.SignatureIndex == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 56741, 57780);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 56809, 57232) || true) && (f_415_56813_56925(this, ai.Handle, out extracted, s_attributeBoolAndStringValueExtractor))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 56809, 57232);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 56975, 57209) || true) && (extracted.String is object)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 56975, 57209);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 57063, 57119);

                                    var
                                    whenResult = (DynAbs.Tracing.TraceSender.Conditional_F1(415, 57080, 57095) || ((extracted.Sense && DynAbs.Tracing.TraceSender.Conditional_F2(415, 57098, 57106)) || DynAbs.Tracing.TraceSender.Conditional_F3(415, 57109, 57118))) ? whenTrue : whenFalse
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 57149, 57182);

                                    f_415_57149_57181(whenResult, extracted.String);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(415, 56975, 57209);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(415, 56809, 57232);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(415, 56741, 57780);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 56741, 57780);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 57274, 57780) || true) && (f_415_57278_57401(this, ai.Handle, out extracted2, s_attributeBoolAndStringArrayValueExtractor))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 57274, 57780);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 57443, 57500);

                                var
                                whenResult = (DynAbs.Tracing.TraceSender.Conditional_F1(415, 57460, 57476) || ((extracted2.Sense && DynAbs.Tracing.TraceSender.Conditional_F2(415, 57479, 57487)) || DynAbs.Tracing.TraceSender.Conditional_F3(415, 57490, 57499))) ? whenTrue : whenFalse
                                ;
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 57522, 57761);
                                    foreach (var value in f_415_57544_57562_I(extracted2.Strings))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 57522, 57761);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 57612, 57738) || true) && (value is object)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 57612, 57738);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 57689, 57711);

                                            f_415_57689_57710(whenResult, value);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(415, 57612, 57738);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 57522, 57761);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(415, 1, 240);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(415, 1, 240);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(415, 57274, 57780);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(415, 56741, 57780);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 56679, 57795);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(415, 1, 1117);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(415, 1, 1117);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 57811, 57882);

                return (f_415_57819_57848(whenTrue), f_415_57850_57880(whenFalse));
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 56060, 57893);

                System.Collections.Generic.List<Microsoft.CodeAnalysis.PEModule.AttributeInfo>
                f_415_56249_56325(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.EntityHandle
                hasAttribute, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.FindTargetAttributes(hasAttribute, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 56249, 56325);
                    return return_v;
                }


                int
                f_415_56365_56380(System.Collections.Generic.List<Microsoft.CodeAnalysis.PEModule.AttributeInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 56365, 56380);
                    return return_v;
                }


                int
                f_415_56566_56581(System.Collections.Generic.List<Microsoft.CodeAnalysis.PEModule.AttributeInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 56566, 56581);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                f_415_56533_56582(int
                capacity)
                {
                    var return_v = ArrayBuilder<string>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 56533, 56582);
                    return return_v;
                }


                int
                f_415_56646_56661(System.Collections.Generic.List<Microsoft.CodeAnalysis.PEModule.AttributeInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 56646, 56661);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                f_415_56613_56662(int
                capacity)
                {
                    var return_v = ArrayBuilder<string>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 56613, 56662);
                    return return_v;
                }


                bool
                f_415_56813_56925(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.CustomAttributeHandle
                handle, out Microsoft.CodeAnalysis.PEModule.BoolAndStringData
                value, Microsoft.CodeAnalysis.PEModule.AttributeValueExtractor<Microsoft.CodeAnalysis.PEModule.BoolAndStringData>
                valueExtractor)
                {
                    var return_v = this_param.TryExtractValueFromAttribute<Microsoft.CodeAnalysis.PEModule.BoolAndStringData>(handle, out value, valueExtractor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 56813, 56925);
                    return return_v;
                }


                int
                f_415_57149_57181(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 57149, 57181);
                    return 0;
                }


                bool
                f_415_57278_57401(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.CustomAttributeHandle
                handle, out Microsoft.CodeAnalysis.PEModule.BoolAndStringArrayData
                value, Microsoft.CodeAnalysis.PEModule.AttributeValueExtractor<Microsoft.CodeAnalysis.PEModule.BoolAndStringArrayData>
                valueExtractor)
                {
                    var return_v = this_param.TryExtractValueFromAttribute<Microsoft.CodeAnalysis.PEModule.BoolAndStringArrayData>(handle, out value, valueExtractor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 57278, 57401);
                    return return_v;
                }


                int
                f_415_57689_57710(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 57689, 57710);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_415_57544_57562_I(System.Collections.Immutable.ImmutableArray<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 57544, 57562);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.CodeAnalysis.PEModule.AttributeInfo>
                f_415_56698_56707_I(System.Collections.Generic.List<Microsoft.CodeAnalysis.PEModule.AttributeInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 56698, 56707);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_415_57819_57848(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 57819, 57848);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_415_57850_57880(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 57850, 57880);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 56060, 57893);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 56060, 57893);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ArrayBuilder<string> ExtractStringValuesFromAttributes(List<AttributeInfo> attrInfos)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 57996, 58624);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 58114, 58196) || true) && (attrInfos == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 58114, 58196);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 58169, 58181);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(415, 58114, 58196);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 58212, 58275);

                var
                result = f_415_58225_58274(f_415_58258_58273(attrInfos))
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 58291, 58583);
                    foreach (var ai in f_415_58310_58319_I(attrInfos))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 58291, 58583);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 58353, 58373);

                        string
                        extractedStr
                        = default(string);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 58391, 58568) || true) && (f_415_58395_58458(this, ai.Handle, out extractedStr) && (DynAbs.Tracing.TraceSender.Expression_True(415, 58395, 58482) && extractedStr != null))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 58391, 58568);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 58524, 58549);

                            f_415_58524_58548(result, extractedStr);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(415, 58391, 58568);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 58291, 58583);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(415, 1, 293);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(415, 1, 293);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 58599, 58613);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 57996, 58624);

                int
                f_415_58258_58273(System.Collections.Generic.List<Microsoft.CodeAnalysis.PEModule.AttributeInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 58258, 58273);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                f_415_58225_58274(int
                capacity)
                {
                    var return_v = ArrayBuilder<string>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 58225, 58274);
                    return return_v;
                }


                bool
                f_415_58395_58458(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.CustomAttributeHandle
                handle, out string
                value)
                {
                    var return_v = this_param.TryExtractStringValueFromAttribute(handle, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 58395, 58458);
                    return return_v;
                }


                int
                f_415_58524_58548(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 58524, 58548);
                    return 0;
                }


                System.Collections.Generic.List<Microsoft.CodeAnalysis.PEModule.AttributeInfo>
                f_415_58310_58319_I(System.Collections.Generic.List<Microsoft.CodeAnalysis.PEModule.AttributeInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 58310, 58319);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 57996, 58624);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 57996, 58624);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ObsoleteAttributeData? TryExtractObsoleteDataFromAttribute(AttributeInfo attributeInfo, IAttributeNamedArgumentDecoder decoder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 58654, 60321);
                System.Reflection.Metadata.BlobReader sig = default(System.Reflection.Metadata.BlobReader);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 58814, 58851);

                f_415_58814_58850(attributeInfo.HasValue);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 58865, 58987) || true) && (!f_415_58870_58926(this, attributeInfo.Handle, out sig))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 58865, 58987);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 58960, 58972);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(415, 58865, 58987);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 59003, 59026);

                string?
                message = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 59040, 59061);

                bool
                isError = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 59075, 60051);

                switch (attributeInfo.SignatureIndex)
                {

                    case 0:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 59075, 60051);
                        DynAbs.Tracing.TraceSender.TraceBreak(415, 59218, 59224);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 59075, 60051);

                    case 1:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 59075, 60051);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 59321, 59479) || true) && (sig.RemainingBytes > 0 && (DynAbs.Tracing.TraceSender.Expression_True(415, 59325, 59400) && f_415_59351_59400(out message, ref sig)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 59321, 59479);
                            DynAbs.Tracing.TraceSender.TraceBreak(415, 59450, 59456);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(415, 59321, 59479);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 59503, 59515);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 59075, 60051);

                    case 2:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 59075, 60051);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 59618, 59881) || true) && (sig.RemainingBytes > 0 && (DynAbs.Tracing.TraceSender.Expression_True(415, 59622, 59697) && f_415_59648_59697(out message, ref sig)) && (DynAbs.Tracing.TraceSender.Expression_True(415, 59622, 59748) && sig.RemainingBytes > 0) && (DynAbs.Tracing.TraceSender.Expression_True(415, 59622, 59802) && f_415_59752_59802(out isError, ref sig)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 59618, 59881);
                            DynAbs.Tracing.TraceSender.TraceBreak(415, 59852, 59858);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(415, 59618, 59881);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 59905, 59917);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 59075, 60051);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 59075, 60051);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 59965, 60036);

                        throw f_415_59971_60035(attributeInfo.SignatureIndex);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 59075, 60051);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 60067, 60188);

                (string? diagnosticId, string? urlFormat) = (DynAbs.Tracing.TraceSender.Conditional_F1(415, 60111, 60133) || ((sig.RemainingBytes > 0 && DynAbs.Tracing.TraceSender.Conditional_F2(415, 60136, 60177)) || DynAbs.Tracing.TraceSender.Conditional_F3(415, 60180, 60187))) ? f_415_60136_60177(ref sig, decoder) : default;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 60202, 60310);

                return f_415_60209_60309(ObsoleteAttributeKind.Obsolete, message, isError, diagnosticId, urlFormat);
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 58654, 60321);

                int
                f_415_58814_58850(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 58814, 58850);
                    return 0;
                }


                bool
                f_415_58870_58926(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.CustomAttributeHandle
                handle, out System.Reflection.Metadata.BlobReader
                blobReader)
                {
                    var return_v = this_param.TryGetAttributeReader(handle, out blobReader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 58870, 58926);
                    return return_v;
                }


                bool
                f_415_59351_59400(out string?
                value, ref System.Reflection.Metadata.BlobReader
                sig)
                {
                    var return_v = CrackStringInAttributeValue(out value, ref sig);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 59351, 59400);
                    return return_v;
                }


                bool
                f_415_59648_59697(out string?
                value, ref System.Reflection.Metadata.BlobReader
                sig)
                {
                    var return_v = CrackStringInAttributeValue(out value, ref sig);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 59648, 59697);
                    return return_v;
                }


                bool
                f_415_59752_59802(out bool
                value, ref System.Reflection.Metadata.BlobReader
                sig)
                {
                    var return_v = CrackBooleanInAttributeValue(out value, ref sig);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 59752, 59802);
                    return return_v;
                }


                System.Exception
                f_415_59971_60035(byte
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 59971, 60035);
                    return return_v;
                }


                (string? diagnosticId, string? urlFormat)
                f_415_60136_60177(ref System.Reflection.Metadata.BlobReader
                sig, Microsoft.CodeAnalysis.IAttributeNamedArgumentDecoder
                decoder)
                {
                    var return_v = CrackObsoleteProperties(ref sig, decoder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 60136, 60177);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ObsoleteAttributeData
                f_415_60209_60309(Microsoft.CodeAnalysis.ObsoleteAttributeKind
                kind, string?
                message, bool
                isError, string?
                diagnosticId, string?
                urlFormat)
                {
                    var return_v = new Microsoft.CodeAnalysis.ObsoleteAttributeData(kind, message, isError, diagnosticId, urlFormat);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 60209, 60309);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 58654, 60321);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 58654, 60321);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool TryGetAttributeReader(CustomAttributeHandle handle, out BlobReader blobReader)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 60333, 61176);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 60449, 60477);

                f_415_60449_60476(f_415_60462_60475_M(!handle.IsNil));
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 60527, 60582);

                    var
                    valueBlob = f_415_60543_60581(this, handle)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 60600, 61024) || true) && (f_415_60604_60620_M(!valueBlob.IsNil))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 60600, 61024);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 60662, 60715);

                        blobReader = f_415_60675_60714(f_415_60675_60689(), valueBlob);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 60737, 61005) || true) && (blobReader.Length >= 4)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 60737, 61005);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 60854, 60982) || true) && (blobReader.ReadInt16() == 1)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 60854, 60982);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 60943, 60955);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(415, 60854, 60982);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(415, 60737, 61005);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 60600, 61024);
                    }
                }
                catch (BadImageFormatException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(415, 61053, 61101);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(415, 61053, 61101);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 61117, 61138);

                blobReader = default;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 61152, 61165);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 60333, 61176);

                bool
                f_415_60462_60475_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 60462, 60475);
                    return return_v;
                }


                int
                f_415_60449_60476(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 60449, 60476);
                    return 0;
                }


                System.Reflection.Metadata.BlobHandle
                f_415_60543_60581(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.CustomAttributeHandle
                handle)
                {
                    var return_v = this_param.GetCustomAttributeValueOrThrow(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 60543, 60581);
                    return return_v;
                }


                bool
                f_415_60604_60620_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 60604, 60620);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_415_60675_60689()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 60675, 60689);
                    return return_v;
                }


                System.Reflection.Metadata.BlobReader
                f_415_60675_60714(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.BlobHandle
                handle)
                {
                    var return_v = this_param.GetBlobReader(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 60675, 60714);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 60333, 61176);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 60333, 61176);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ObsoleteAttributeData TryExtractDeprecatedDataFromAttribute(AttributeInfo attributeInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 61207, 62142);
                Microsoft.CodeAnalysis.ObsoleteAttributeData obsoleteData = default(Microsoft.CodeAnalysis.ObsoleteAttributeData);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 61328, 61365);

                f_415_61328_61364(attributeInfo.HasValue);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 61381, 62131);

                switch (attributeInfo.SignatureIndex)
                {

                    case 0: // DeprecatedAttribute(String, DeprecationType, UInt32) 
                    case 1: // DeprecatedAttribute(String, DeprecationType, UInt32, Platform) 
                    case 2: // DeprecatedAttribute(String, DeprecationType, UInt32, Type) 
                    case 3: // DeprecatedAttribute(String, DeprecationType, UInt32, String) 
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 61381, 62131);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 61807, 61995);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(415, 61814, 61922) || ((f_415_61814_61922(this, attributeInfo.Handle, out obsoleteData, s_attributeDeprecatedDataExtractor) && DynAbs.Tracing.TraceSender.Conditional_F2(415, 61950, 61962)) || DynAbs.Tracing.TraceSender.Conditional_F3(415, 61990, 61994))) ? obsoleteData : null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 61381, 62131);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 61381, 62131);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 62045, 62116);

                        throw f_415_62051_62115(attributeInfo.SignatureIndex);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 61381, 62131);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 61207, 62142);

                int
                f_415_61328_61364(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 61328, 61364);
                    return 0;
                }


                bool
                f_415_61814_61922(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.CustomAttributeHandle
                handle, out Microsoft.CodeAnalysis.ObsoleteAttributeData
                value, Microsoft.CodeAnalysis.PEModule.AttributeValueExtractor<Microsoft.CodeAnalysis.ObsoleteAttributeData>
                valueExtractor)
                {
                    var return_v = this_param.TryExtractValueFromAttribute<Microsoft.CodeAnalysis.ObsoleteAttributeData>(handle, out value, valueExtractor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 61814, 61922);
                    return return_v;
                }


                System.Exception
                f_415_62051_62115(byte
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 62051, 62115);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 61207, 62142);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 61207, 62142);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ObsoleteAttributeData TryExtractExperimentalDataFromAttribute(AttributeInfo attributeInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 62154, 62646);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 62277, 62314);

                f_415_62277_62313(attributeInfo.HasValue);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 62330, 62635);

                switch (attributeInfo.SignatureIndex)
                {

                    case 0: // ExperimentalAttribute() 
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 62330, 62635);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 62457, 62499);

                        return ObsoleteAttributeData.Experimental;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 62330, 62635);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 62330, 62635);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 62549, 62620);

                        throw f_415_62555_62619(attributeInfo.SignatureIndex);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 62330, 62635);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 62154, 62646);

                int
                f_415_62277_62313(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 62277, 62313);
                    return 0;
                }


                System.Exception
                f_415_62555_62619(byte
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 62555, 62619);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 62154, 62646);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 62154, 62646);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool TryExtractInterfaceTypeFromAttribute(AttributeInfo attributeInfo, out ComInterfaceType interfaceType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 62658, 64115);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 62797, 62834);

                f_415_62797_62833(attributeInfo.HasValue);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 62850, 64019);

                switch (attributeInfo.SignatureIndex)
                {

                    case 0:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 62850, 64019);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 63003, 63020);

                        short
                        shortValue
                        = default(short);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 63042, 63364) || true) && (f_415_63046_63144(this, attributeInfo.Handle, out shortValue, s_attributeShortValueExtractor) && (DynAbs.Tracing.TraceSender.Expression_True(415, 63046, 63208) && f_415_63173_63208(shortValue)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 63042, 63364);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 63258, 63303);

                            interfaceType = (ComInterfaceType)shortValue;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 63329, 63341);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(415, 63042, 63364);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(415, 63386, 63392);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 62850, 64019);

                    case 1:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 62850, 64019);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 63506, 63519);

                        int
                        intValue
                        = default(int);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 63541, 63855) || true) && (f_415_63545_63639(this, attributeInfo.Handle, out intValue, s_attributeIntValueExtractor) && (DynAbs.Tracing.TraceSender.Expression_True(415, 63545, 63701) && f_415_63668_63701(intValue)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 63541, 63855);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 63751, 63794);

                            interfaceType = (ComInterfaceType)intValue;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 63820, 63832);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(415, 63541, 63855);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(415, 63877, 63883);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 62850, 64019);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 62850, 64019);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 63933, 64004);

                        throw f_415_63939_64003(attributeInfo.SignatureIndex);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 62850, 64019);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 64035, 64077);

                interfaceType = default(ComInterfaceType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 64091, 64104);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 62658, 64115);

                int
                f_415_62797_62833(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 62797, 62833);
                    return 0;
                }


                bool
                f_415_63046_63144(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.CustomAttributeHandle
                handle, out short
                value, Microsoft.CodeAnalysis.PEModule.AttributeValueExtractor<short>
                valueExtractor)
                {
                    var return_v = this_param.TryExtractValueFromAttribute<short>(handle, out value, valueExtractor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 63046, 63144);
                    return return_v;
                }


                bool
                f_415_63173_63208(short
                comInterfaceType)
                {
                    var return_v = IsValidComInterfaceType((int)comInterfaceType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 63173, 63208);
                    return return_v;
                }


                bool
                f_415_63545_63639(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.CustomAttributeHandle
                handle, out int
                value, Microsoft.CodeAnalysis.PEModule.AttributeValueExtractor<int>
                valueExtractor)
                {
                    var return_v = this_param.TryExtractValueFromAttribute<int>(handle, out value, valueExtractor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 63545, 63639);
                    return return_v;
                }


                bool
                f_415_63668_63701(int
                comInterfaceType)
                {
                    var return_v = IsValidComInterfaceType(comInterfaceType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 63668, 63701);
                    return return_v;
                }


                System.Exception
                f_415_63939_64003(byte
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 63939, 64003);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 62658, 64115);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 62658, 64115);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsValidComInterfaceType(int comInterfaceType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(415, 64127, 64669);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 64217, 64658);

                switch (comInterfaceType)
                {

                    case (int)Cci.Constants.ComInterfaceType_InterfaceIsDual:
                    case (int)Cci.Constants.ComInterfaceType_InterfaceIsIDispatch:
                    case (int)ComInterfaceType.InterfaceIsIInspectable:
                    case (int)ComInterfaceType.InterfaceIsIUnknown:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 64217, 64658);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 64568, 64580);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 64217, 64658);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 64217, 64658);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 64630, 64643);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 64217, 64658);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(415, 64127, 64669);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 64127, 64669);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 64127, 64669);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool TryExtractTypeLibTypeFromAttribute(AttributeInfo info, out Cci.TypeLibTypeFlags flags)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 64681, 65936);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 64805, 64833);

                f_415_64805_64832(info.HasValue);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 64849, 65844);

                switch (info.SignatureIndex)
                {

                    case 0:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 64849, 65844);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 64991, 65008);

                        short
                        shortValue
                        = default(short);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 65030, 65275) || true) && (f_415_65034_65123(this, info.Handle, out shortValue, s_attributeShortValueExtractor))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 65030, 65275);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 65173, 65214);

                            flags = (Cci.TypeLibTypeFlags)shortValue;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 65240, 65252);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(415, 65030, 65275);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(415, 65297, 65303);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 64849, 65844);

                    case 1:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 64849, 65844);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 65415, 65428);

                        int
                        intValue
                        = default(int);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 65450, 65689) || true) && (f_415_65454_65539(this, info.Handle, out intValue, s_attributeIntValueExtractor))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 65450, 65689);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 65589, 65628);

                            flags = (Cci.TypeLibTypeFlags)intValue;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 65654, 65666);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(415, 65450, 65689);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(415, 65711, 65717);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 64849, 65844);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 64849, 65844);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 65767, 65829);

                        throw f_415_65773_65828(info.SignatureIndex);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 64849, 65844);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 65860, 65898);

                flags = default(Cci.TypeLibTypeFlags);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 65912, 65925);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 64681, 65936);

                int
                f_415_64805_64832(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 64805, 64832);
                    return 0;
                }


                bool
                f_415_65034_65123(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.CustomAttributeHandle
                handle, out short
                value, Microsoft.CodeAnalysis.PEModule.AttributeValueExtractor<short>
                valueExtractor)
                {
                    var return_v = this_param.TryExtractValueFromAttribute<short>(handle, out value, valueExtractor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 65034, 65123);
                    return return_v;
                }


                bool
                f_415_65454_65539(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.CustomAttributeHandle
                handle, out int
                value, Microsoft.CodeAnalysis.PEModule.AttributeValueExtractor<int>
                valueExtractor)
                {
                    var return_v = this_param.TryExtractValueFromAttribute<int>(handle, out value, valueExtractor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 65454, 65539);
                    return return_v;
                }


                System.Exception
                f_415_65773_65828(byte
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 65773, 65828);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 64681, 65936);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 64681, 65936);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool TryExtractStringValueFromAttribute(CustomAttributeHandle handle, out string value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 65948, 66168);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 66069, 66157);

                return f_415_66076_66156(this, handle, out value, s_attributeStringValueExtractor);
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 65948, 66168);

                bool
                f_415_66076_66156(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.CustomAttributeHandle
                handle, out string
                value, Microsoft.CodeAnalysis.PEModule.AttributeValueExtractor<string>
                valueExtractor)
                {
                    var return_v = this_param.TryExtractValueFromAttribute<string>(handle, out value, valueExtractor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 66076, 66156);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 65948, 66168);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 65948, 66168);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool TryExtractLongValueFromAttribute(CustomAttributeHandle handle, out long value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 66180, 66394);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 66297, 66383);

                return f_415_66304_66382(this, handle, out value, s_attributeLongValueExtractor);
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 66180, 66394);

                bool
                f_415_66304_66382(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.CustomAttributeHandle
                handle, out long
                value, Microsoft.CodeAnalysis.PEModule.AttributeValueExtractor<long>
                valueExtractor)
                {
                    var return_v = this_param.TryExtractValueFromAttribute<long>(handle, out value, valueExtractor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 66304, 66382);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 66180, 66394);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 66180, 66394);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool TryExtractDecimalValueFromDecimalConstantAttribute(CustomAttributeHandle handle, out decimal value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 66453, 66707);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 66590, 66696);

                return f_415_66597_66695(this, handle, out value, s_decimalValueInDecimalConstantAttributeExtractor);
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 66453, 66707);

                bool
                f_415_66597_66695(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.CustomAttributeHandle
                handle, out decimal
                value, Microsoft.CodeAnalysis.PEModule.AttributeValueExtractor<decimal>
                valueExtractor)
                {
                    var return_v = this_param.TryExtractValueFromAttribute<decimal>(handle, out value, valueExtractor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 66597, 66695);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 66453, 66707);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 66453, 66707);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private struct StringAndInt
        {

            public string StringValue;

            public int IntValue;
            static StringAndInt()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(415, 66719, 66842);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(415, 66719, 66842);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 66719, 66842);
            }
        }

        private bool TryExtractStringAndIntValueFromAttribute(CustomAttributeHandle handle, out string stringValue, out int intValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 66854, 67258);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 67004, 67022);

                StringAndInt
                data
                = default(StringAndInt);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 67036, 67135);

                var
                result = f_415_67049_67134(this, handle, out data, s_attributeStringAndIntValueExtractor)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 67149, 67180);

                stringValue = data.StringValue;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 67194, 67219);

                intValue = data.IntValue;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 67233, 67247);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 66854, 67258);

                bool
                f_415_67049_67134(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.CustomAttributeHandle
                handle, out Microsoft.CodeAnalysis.PEModule.StringAndInt
                value, Microsoft.CodeAnalysis.PEModule.AttributeValueExtractor<Microsoft.CodeAnalysis.PEModule.StringAndInt>
                valueExtractor)
                {
                    var return_v = this_param.TryExtractValueFromAttribute<Microsoft.CodeAnalysis.PEModule.StringAndInt>(handle, out value, valueExtractor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 67049, 67134);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 66854, 67258);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 66854, 67258);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool TryExtractBoolArrayValueFromAttribute(CustomAttributeHandle handle, out ImmutableArray<bool> value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 67270, 67509);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 67407, 67498);

                return f_415_67414_67497(this, handle, out value, s_attributeBoolArrayValueExtractor);
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 67270, 67509);

                bool
                f_415_67414_67497(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.CustomAttributeHandle
                handle, out System.Collections.Immutable.ImmutableArray<bool>
                value, Microsoft.CodeAnalysis.PEModule.AttributeValueExtractor<System.Collections.Immutable.ImmutableArray<bool>>
                valueExtractor)
                {
                    var return_v = this_param.TryExtractValueFromAttribute<System.Collections.Immutable.ImmutableArray<bool>>(handle, out value, valueExtractor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 67414, 67497);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 67270, 67509);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 67270, 67509);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool TryExtractByteArrayValueFromAttribute(CustomAttributeHandle handle, out ImmutableArray<byte> value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 67521, 67760);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 67658, 67749);

                return f_415_67665_67748(this, handle, out value, s_attributeByteArrayValueExtractor);
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 67521, 67760);

                bool
                f_415_67665_67748(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.CustomAttributeHandle
                handle, out System.Collections.Immutable.ImmutableArray<byte>
                value, Microsoft.CodeAnalysis.PEModule.AttributeValueExtractor<System.Collections.Immutable.ImmutableArray<byte>>
                valueExtractor)
                {
                    var return_v = this_param.TryExtractValueFromAttribute<System.Collections.Immutable.ImmutableArray<byte>>(handle, out value, valueExtractor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 67665, 67748);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 67521, 67760);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 67521, 67760);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool TryExtractStringArrayValueFromAttribute(CustomAttributeHandle handle, out ImmutableArray<string> value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 67772, 68017);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 67913, 68006);

                return f_415_67920_68005(this, handle, out value, s_attributeStringArrayValueExtractor);
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 67772, 68017);

                bool
                f_415_67920_68005(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.CustomAttributeHandle
                handle, out System.Collections.Immutable.ImmutableArray<string>
                value, Microsoft.CodeAnalysis.PEModule.AttributeValueExtractor<System.Collections.Immutable.ImmutableArray<string>>
                valueExtractor)
                {
                    var return_v = this_param.TryExtractValueFromAttribute<System.Collections.Immutable.ImmutableArray<string>>(handle, out value, valueExtractor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 67920, 68005);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 67772, 68017);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 67772, 68017);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool TryExtractValueFromAttribute<T>(CustomAttributeHandle handle, out T value, AttributeValueExtractor<T> valueExtractor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 68029, 69073);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 68184, 68212);

                f_415_68184_68211(f_415_68197_68210_M(!handle.IsNil));

                // extract the value
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 68298, 68360);

                    BlobHandle
                    valueBlob = f_415_68321_68359(this, handle)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 68380, 68923) || true) && (f_415_68384_68400_M(!valueBlob.IsNil))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 68380, 68923);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 68503, 68563);

                        BlobReader
                        reader = f_415_68523_68562(f_415_68523_68537(), valueBlob)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 68587, 68904) || true) && (reader.Length > 4)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 68587, 68904);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 68699, 68881) || true) && (reader.ReadByte() == 1 && (DynAbs.Tracing.TraceSender.Expression_True(415, 68703, 68751) && reader.ReadByte() == 0))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 68699, 68881);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 68809, 68854);

                                return f_415_68816_68853(valueExtractor, out value, ref reader);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(415, 68699, 68881);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(415, 68587, 68904);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 68380, 68923);
                    }
                }
                catch (BadImageFormatException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(415, 68952, 69000);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(415, 68952, 69000);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 69016, 69035);

                value = default(T);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 69049, 69062);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 68029, 69073);

                bool
                f_415_68197_68210_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 68197, 68210);
                    return return_v;
                }


                int
                f_415_68184_68211(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 68184, 68211);
                    return 0;
                }


                System.Reflection.Metadata.BlobHandle
                f_415_68321_68359(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.CustomAttributeHandle
                handle)
                {
                    var return_v = this_param.GetCustomAttributeValueOrThrow(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 68321, 68359);
                    return return_v;
                }


                bool
                f_415_68384_68400_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 68384, 68400);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_415_68523_68537()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 68523, 68537);
                    return return_v;
                }


                System.Reflection.Metadata.BlobReader
                f_415_68523_68562(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.BlobHandle
                handle)
                {
                    var return_v = this_param.GetBlobReader(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 68523, 68562);
                    return return_v;
                }


                bool
                f_415_68816_68853(Microsoft.CodeAnalysis.PEModule.AttributeValueExtractor<T>
                this_param, out T
                value, ref System.Reflection.Metadata.BlobReader
                sigReader)
                {
                    var return_v = this_param.Invoke(out value, ref sigReader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 68816, 68853);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 68029, 69073);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 68029, 69073);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool HasStringValuedAttribute(EntityHandle token, AttributeDescription description, out string value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 69085, 69494);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 69220, 69281);

                AttributeInfo
                info = f_415_69241_69280(this, token, description)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 69295, 69427) || true) && (info.HasValue)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 69295, 69427);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 69346, 69412);

                    return f_415_69353_69411(this, info.Handle, out value);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(415, 69295, 69427);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 69443, 69456);

                value = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 69470, 69483);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 69085, 69494);

                Microsoft.CodeAnalysis.PEModule.AttributeInfo
                f_415_69241_69280(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.EntityHandle
                hasAttribute, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.FindTargetAttribute(hasAttribute, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 69241, 69280);
                    return return_v;
                }


                bool
                f_415_69353_69411(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.CustomAttributeHandle
                handle, out string
                value)
                {
                    var return_v = this_param.TryExtractStringValueFromAttribute(handle, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 69353, 69411);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 69085, 69494);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 69085, 69494);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool HasStringAndIntValuedAttribute(EntityHandle token, AttributeDescription description, out string stringValue, out int intValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 69506, 70003);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 69670, 69731);

                AttributeInfo
                info = f_415_69691_69730(this, token, description)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 69745, 69903) || true) && (info.HasValue)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 69745, 69903);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 69796, 69888);

                    return f_415_69803_69887(this, info.Handle, out stringValue, out intValue);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(415, 69745, 69903);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 69919, 69938);

                stringValue = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 69952, 69965);

                intValue = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 69979, 69992);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 69506, 70003);

                Microsoft.CodeAnalysis.PEModule.AttributeInfo
                f_415_69691_69730(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.EntityHandle
                hasAttribute, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.FindTargetAttribute(hasAttribute, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 69691, 69730);
                    return return_v;
                }


                bool
                f_415_69803_69887(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.CustomAttributeHandle
                handle, out string
                stringValue, out int
                intValue)
                {
                    var return_v = this_param.TryExtractStringAndIntValueFromAttribute(handle, out stringValue, out intValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 69803, 69887);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 69506, 70003);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 69506, 70003);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool IsNoPiaLocalType(
                    TypeDefinitionHandle typeDef,
                    out string interfaceGuid,
                    out string scope,
                    out string identifier)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 70015, 71960);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 70220, 70253);

                AttributeInfo
                typeIdentifierInfo
                = default(AttributeInfo);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 70269, 70493) || true) && (!f_415_70274_70323(this, typeDef, out typeIdentifierInfo))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 70269, 70493);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 70357, 70378);

                    interfaceGuid = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 70396, 70409);

                    scope = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 70427, 70445);

                    identifier = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 70465, 70478);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(415, 70269, 70493);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 70509, 70530);

                interfaceGuid = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 70544, 70557);

                scope = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 70571, 70589);

                identifier = null;

                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 70641, 70796) || true) && (f_415_70645_70690(f_415_70645_70676(this, typeDef)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 70641, 70796);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 70732, 70777);

                        f_415_70732_70776(this, typeDef, out interfaceGuid);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 70641, 70796);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 70816, 71796) || true) && (typeIdentifierInfo.SignatureIndex == 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 70816, 71796);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 70942, 71023);

                        BlobHandle
                        valueBlob = f_415_70965_71022(this, typeIdentifierInfo.Handle)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 71047, 71777) || true) && (f_415_71051_71067_M(!valueBlob.IsNil))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 71047, 71777);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 71117, 71177);

                            BlobReader
                            reader = f_415_71137_71176(f_415_71137_71151(), valueBlob)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 71205, 71754) || true) && (reader.Length > 4)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 71205, 71754);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 71329, 71727) || true) && (reader.ReadInt16() == 1)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 71329, 71727);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 71422, 71696) || true) && (!f_415_71427_71477(out scope, ref reader) || (DynAbs.Tracing.TraceSender.Expression_False(415, 71426, 71574) || !f_415_71519_71574(out identifier, ref reader)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 71422, 71696);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 71648, 71661);

                                        return false;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 71422, 71696);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(415, 71329, 71727);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(415, 71205, 71754);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(415, 71047, 71777);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 70816, 71796);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 71816, 71828);

                    return true;
                }
                catch (BadImageFormatException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(415, 71857, 71949);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 71921, 71934);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(415, 71857, 71949);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 70015, 71960);

                bool
                f_415_70274_70323(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                typeDef, out Microsoft.CodeAnalysis.PEModule.AttributeInfo
                attributeInfo)
                {
                    var return_v = this_param.IsNoPiaLocalType(typeDef, out attributeInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 70274, 70323);
                    return return_v;
                }


                System.Reflection.TypeAttributes
                f_415_70645_70676(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                typeDef)
                {
                    var return_v = this_param.GetTypeDefFlagsOrThrow(typeDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 70645, 70676);
                    return return_v;
                }


                bool
                f_415_70645_70690(System.Reflection.TypeAttributes
                flags)
                {
                    var return_v = flags.IsInterface();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 70645, 70690);
                    return return_v;
                }


                bool
                f_415_70732_70776(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                token, out string
                guidValue)
                {
                    var return_v = this_param.HasGuidAttribute((System.Reflection.Metadata.EntityHandle)token, out guidValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 70732, 70776);
                    return return_v;
                }


                System.Reflection.Metadata.BlobHandle
                f_415_70965_71022(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.CustomAttributeHandle
                handle)
                {
                    var return_v = this_param.GetCustomAttributeValueOrThrow(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 70965, 71022);
                    return return_v;
                }


                bool
                f_415_71051_71067_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 71051, 71067);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_415_71137_71151()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 71137, 71151);
                    return return_v;
                }


                System.Reflection.Metadata.BlobReader
                f_415_71137_71176(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.BlobHandle
                handle)
                {
                    var return_v = this_param.GetBlobReader(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 71137, 71176);
                    return return_v;
                }


                bool
                f_415_71427_71477(out string
                value, ref System.Reflection.Metadata.BlobReader
                sig)
                {
                    var return_v = CrackStringInAttributeValue(out value, ref sig);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 71427, 71477);
                    return return_v;
                }


                bool
                f_415_71519_71574(out string
                value, ref System.Reflection.Metadata.BlobReader
                sig)
                {
                    var return_v = CrackStringInAttributeValue(out value, ref sig);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 71519, 71574);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 70015, 71960);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 70015, 71960);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static (string? diagnosticId, string? urlFormat) CrackObsoleteProperties(ref BlobReader sig, IAttributeNamedArgumentDecoder decoder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(415, 72447, 74139);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 72612, 72640);

                string?
                diagnosticId = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 72654, 72679);

                string?
                urlFormat = null
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 73035, 73067);

                    var
                    numNamed = sig.ReadUInt16()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 73094, 73099);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 73085, 73962) || true) && (i < numNamed && (DynAbs.Tracing.TraceSender.Expression_True(415, 73101, 73160) && (diagnosticId is null || (DynAbs.Tracing.TraceSender.Expression_False(415, 73118, 73159) || urlFormat is null))))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 73162, 73165)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(415, 73085, 73962))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 73085, 73962);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 73207, 73335);

                            var ((name, value), isProperty, typeCode, /* elementTypeCode */ _) = f_415_73276_73334(decoder, ref sig);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 73357, 73943) || true) && (typeCode == SerializationTypeCode.String && (DynAbs.Tracing.TraceSender.Expression_True(415, 73361, 73415) && isProperty) && (DynAbs.Tracing.TraceSender.Expression_True(415, 73361, 73460) && value.ValueInternal is string stringValue))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 73357, 73943);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 73510, 73920) || true) && (diagnosticId is null && (DynAbs.Tracing.TraceSender.Expression_True(415, 73514, 73592) && name == ObsoleteAttributeData.DiagnosticIdPropertyName))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 73510, 73920);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 73650, 73677);

                                    diagnosticId = stringValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(415, 73510, 73920);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 73510, 73920);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 73735, 73920) || true) && (urlFormat is null && (DynAbs.Tracing.TraceSender.Expression_True(415, 73739, 73811) && name == ObsoleteAttributeData.UrlFormatPropertyName))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 73735, 73920);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 73869, 73893);

                                        urlFormat = stringValue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 73735, 73920);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(415, 73510, 73920);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(415, 73357, 73943);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(415, 1, 878);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(415, 1, 878);
                    }
                }
                catch (BadImageFormatException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(415, 73991, 74026);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(415, 73991, 74026);
                }
                catch (UnsupportedSignatureContent)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(415, 74040, 74079);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(415, 74040, 74079);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 74095, 74128);

                return (diagnosticId, urlFormat);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(415, 72447, 74139);

                (System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant> nameValuePair, bool isProperty, System.Reflection.Metadata.SerializationTypeCode typeCode, System.Reflection.Metadata.SerializationTypeCode elementTypeCode)
                f_415_73276_73334(Microsoft.CodeAnalysis.IAttributeNamedArgumentDecoder
                this_param, ref System.Reflection.Metadata.BlobReader
                argReader)
                {
                    var return_v = this_param.DecodeCustomAttributeNamedArgumentOrThrow(ref argReader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 73276, 73334);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 72447, 74139);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 72447, 74139);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool CrackDeprecatedAttributeData(out ObsoleteAttributeData value, ref BlobReader sig)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(415, 74170, 74673);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 74296, 74314);

                StringAndInt
                args
                = default(StringAndInt);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 74328, 74606) || true) && (f_415_74332_74384(out args, ref sig))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 74328, 74606);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 74418, 74561);

                    value = f_415_74426_74560(ObsoleteAttributeKind.Deprecated, args.StringValue, args.IntValue == 1, diagnosticId: null, urlFormat: null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 74579, 74591);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(415, 74328, 74606);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 74622, 74635);

                value = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 74649, 74662);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(415, 74170, 74673);

                bool
                f_415_74332_74384(out Microsoft.CodeAnalysis.PEModule.StringAndInt
                value, ref System.Reflection.Metadata.BlobReader
                sig)
                {
                    var return_v = CrackStringAndIntInAttributeValue(out value, ref sig);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 74332, 74384);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ObsoleteAttributeData
                f_415_74426_74560(Microsoft.CodeAnalysis.ObsoleteAttributeKind
                kind, string
                message, bool
                isError, string?
                diagnosticId, string?
                urlFormat)
                {
                    var return_v = new Microsoft.CodeAnalysis.ObsoleteAttributeData(kind, message, isError, diagnosticId: diagnosticId, urlFormat: urlFormat);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 74426, 74560);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 74170, 74673);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 74170, 74673);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool CrackStringAndIntInAttributeValue(out StringAndInt value, ref BlobReader sig)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(415, 74685, 75020);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 74807, 74837);

                value = default(StringAndInt);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 74851, 75009);

                return
                f_415_74875_74934(out value.StringValue, ref sig) && (DynAbs.Tracing.TraceSender.Expression_True(415, 74875, 75008) && f_415_74955_75008(out value.IntValue, ref sig));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(415, 74685, 75020);

                bool
                f_415_74875_74934(out string
                value, ref System.Reflection.Metadata.BlobReader
                sig)
                {
                    var return_v = CrackStringInAttributeValue(out value, ref sig);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 74875, 74934);
                    return return_v;
                }


                bool
                f_415_74955_75008(out int
                value, ref System.Reflection.Metadata.BlobReader
                sig)
                {
                    var return_v = CrackIntInAttributeValue(out value, ref sig);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 74955, 75008);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 74685, 75020);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 74685, 75020);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool CrackStringInAttributeValue(out string value, ref BlobReader sig)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(415, 75032, 75995);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 75179, 75190);

                    int
                    strLen
                    = default(int);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 75208, 75646) || true) && (sig.TryReadCompressedInteger(out strLen) && (DynAbs.Tracing.TraceSender.Expression_True(415, 75212, 75284) && sig.RemainingBytes >= strLen))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 75208, 75646);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 75326, 75355);

                        value = sig.ReadUTF8(strLen);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 75563, 75591);

                        value = f_415_75571_75590(value, '\0');
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 75615, 75627);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 75208, 75646);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 75666, 75679);

                    value = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 75775, 75832);

                    return sig.RemainingBytes >= 1 && (DynAbs.Tracing.TraceSender.Expression_True(415, 75782, 75831) && sig.ReadByte() == 0xFF);
                }
                catch (BadImageFormatException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(415, 75861, 75984);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 75925, 75938);

                    value = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 75956, 75969);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(415, 75861, 75984);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(415, 75032, 75995);

                string
                f_415_75571_75590(string
                this_param, char
                trimChar)
                {
                    var return_v = this_param.TrimEnd(trimChar);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 75571, 75590);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 75032, 75995);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 75032, 75995);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool CrackStringArrayInAttributeValue(out ImmutableArray<string> value, ref BlobReader sig)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(415, 76007, 76814);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 76139, 76720) || true) && (sig.RemainingBytes >= 4)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 76139, 76720);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 76200, 76233);

                    uint
                    arrayLen = sig.ReadUInt32()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 76251, 76290);

                    var
                    stringArray = new string[arrayLen]
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 76317, 76322);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 76308, 76615) || true) && (i < arrayLen)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 76338, 76341)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(415, 76308, 76615))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 76308, 76615);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 76383, 76596) || true) && (!f_415_76388_76444(out stringArray[i], ref sig))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 76383, 76596);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 76494, 76534);

                                value = f_415_76502_76533(stringArray);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 76560, 76573);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(415, 76383, 76596);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(415, 1, 308);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(415, 1, 308);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 76635, 76675);

                    value = f_415_76643_76674(stringArray);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 76693, 76705);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(415, 76139, 76720);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 76736, 76776);

                value = default(ImmutableArray<string>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 76790, 76803);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(415, 76007, 76814);

                bool
                f_415_76388_76444(out string
                value, ref System.Reflection.Metadata.BlobReader
                sig)
                {
                    var return_v = CrackStringInAttributeValue(out value, ref sig);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 76388, 76444);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_415_76502_76533(string[]
                items)
                {
                    var return_v = items.AsImmutableOrNull<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 76502, 76533);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_415_76643_76674(string[]
                items)
                {
                    var return_v = items.AsImmutableOrNull<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 76643, 76674);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 76007, 76814);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 76007, 76814);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool CrackBoolAndStringArrayInAttributeValue(out BoolAndStringArrayData value, ref BlobReader sig)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(415, 76826, 77320);
                bool sense = default(bool);
                System.Collections.Immutable.ImmutableArray<string> strings = default(System.Collections.Immutable.ImmutableArray<string>);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 76965, 77250) || true) && (f_415_76969_77022(out sense, ref sig) && (DynAbs.Tracing.TraceSender.Expression_True(415, 76969, 77120) && f_415_77043_77120(out strings, ref sig)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 76965, 77250);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 77154, 77205);

                    value = f_415_77162_77204(sense, strings);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 77223, 77235);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(415, 76965, 77250);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 77266, 77282);

                value = default;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 77296, 77309);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(415, 76826, 77320);

                bool
                f_415_76969_77022(out bool
                value, ref System.Reflection.Metadata.BlobReader
                sig)
                {
                    var return_v = CrackBooleanInAttributeValue(out value, ref sig);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 76969, 77022);
                    return return_v;
                }


                bool
                f_415_77043_77120(out System.Collections.Immutable.ImmutableArray<string>
                value, ref System.Reflection.Metadata.BlobReader
                sig)
                {
                    var return_v = CrackStringArrayInAttributeValue(out value, ref sig);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 77043, 77120);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PEModule.BoolAndStringArrayData
                f_415_77162_77204(bool
                sense, System.Collections.Immutable.ImmutableArray<string>
                strings)
                {
                    var return_v = new Microsoft.CodeAnalysis.PEModule.BoolAndStringArrayData(sense, strings);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 77162, 77204);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 76826, 77320);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 76826, 77320);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool CrackBoolAndStringInAttributeValue(out BoolAndStringData value, ref BlobReader sig)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(415, 77332, 77790);
                bool sense = default(bool);
                string @string = default(string);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 77461, 77720) || true) && (f_415_77465_77518(out sense, ref sig) && (DynAbs.Tracing.TraceSender.Expression_True(415, 77465, 77595) && f_415_77539_77595(out @string, ref sig)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 77461, 77720);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 77629, 77675);

                    value = f_415_77637_77674(sense, @string);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 77693, 77705);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(415, 77461, 77720);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 77736, 77752);

                value = default;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 77766, 77779);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(415, 77332, 77790);

                bool
                f_415_77465_77518(out bool
                value, ref System.Reflection.Metadata.BlobReader
                sig)
                {
                    var return_v = CrackBooleanInAttributeValue(out value, ref sig);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 77465, 77518);
                    return return_v;
                }


                bool
                f_415_77539_77595(out string
                value, ref System.Reflection.Metadata.BlobReader
                sig)
                {
                    var return_v = CrackStringInAttributeValue(out value, ref sig);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 77539, 77595);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PEModule.BoolAndStringData
                f_415_77637_77674(bool
                sense, string
                @string)
                {
                    var return_v = new Microsoft.CodeAnalysis.PEModule.BoolAndStringData(sense, @string);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 77637, 77674);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 77332, 77790);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 77332, 77790);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool CrackBooleanInAttributeValue(out bool value, ref BlobReader sig)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(415, 77802, 78112);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 77912, 78044) || true) && (sig.RemainingBytes >= 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 77912, 78044);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 77973, 77999);

                    value = sig.ReadBoolean();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 78017, 78029);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(415, 77912, 78044);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 78060, 78074);

                value = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 78088, 78101);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(415, 77802, 78112);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 77802, 78112);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 77802, 78112);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool CrackByteInAttributeValue(out byte value, ref BlobReader sig)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(415, 78124, 78427);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 78231, 78360) || true) && (sig.RemainingBytes >= 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 78231, 78360);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 78292, 78315);

                    value = sig.ReadByte();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 78333, 78345);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(415, 78231, 78360);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 78376, 78389);

                value = 0xff;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 78403, 78416);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(415, 78124, 78427);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 78124, 78427);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 78124, 78427);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool CrackShortInAttributeValue(out short value, ref BlobReader sig)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(415, 78439, 78743);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 78548, 78678) || true) && (sig.RemainingBytes >= 2)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 78548, 78678);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 78609, 78633);

                    value = sig.ReadInt16();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 78651, 78663);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(415, 78548, 78678);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 78694, 78705);

                value = -1;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 78719, 78732);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(415, 78439, 78743);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 78439, 78743);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 78439, 78743);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool CrackIntInAttributeValue(out int value, ref BlobReader sig)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(415, 78755, 79055);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 78860, 78990) || true) && (sig.RemainingBytes >= 4)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 78860, 78990);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 78921, 78945);

                    value = sig.ReadInt32();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 78963, 78975);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(415, 78860, 78990);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 79006, 79017);

                value = -1;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 79031, 79044);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(415, 78755, 79055);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 78755, 79055);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 78755, 79055);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool CrackLongInAttributeValue(out long value, ref BlobReader sig)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(415, 79067, 79369);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 79174, 79304) || true) && (sig.RemainingBytes >= 8)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 79174, 79304);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 79235, 79259);

                    value = sig.ReadInt64();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 79277, 79289);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(415, 79174, 79304);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 79320, 79331);

                value = -1;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 79345, 79358);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(415, 79067, 79369);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 79067, 79369);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 79067, 79369);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool CrackDecimalInDecimalConstantAttribute(out decimal value, ref BlobReader sig)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(415, 79428, 80170);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 79550, 79561);

                byte
                scale
                = default(byte);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 79575, 79585);

                byte
                sign
                = default(byte);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 79599, 79608);

                int
                high
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 79622, 79630);

                int
                mid
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 79644, 79652);

                int
                low
                = default(int);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 79668, 80105) || true) && (f_415_79672_79717(out scale, ref sig) && (DynAbs.Tracing.TraceSender.Expression_True(415, 79672, 79782) && f_415_79738_79782(out sign, ref sig)) && (DynAbs.Tracing.TraceSender.Expression_True(415, 79672, 79846) && f_415_79803_79846(out high, ref sig)) && (DynAbs.Tracing.TraceSender.Expression_True(415, 79672, 79909) && f_415_79867_79909(out mid, ref sig)) && (DynAbs.Tracing.TraceSender.Expression_True(415, 79672, 79972) && f_415_79930_79972(out low, ref sig)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 79668, 80105);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 80006, 80060);

                    value = f_415_80014_80059(low, mid, high, sign != 0, scale);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 80078, 80090);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(415, 79668, 80105);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 80121, 80132);

                value = -1;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 80146, 80159);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(415, 79428, 80170);

                bool
                f_415_79672_79717(out byte
                value, ref System.Reflection.Metadata.BlobReader
                sig)
                {
                    var return_v = CrackByteInAttributeValue(out value, ref sig);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 79672, 79717);
                    return return_v;
                }


                bool
                f_415_79738_79782(out byte
                value, ref System.Reflection.Metadata.BlobReader
                sig)
                {
                    var return_v = CrackByteInAttributeValue(out value, ref sig);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 79738, 79782);
                    return return_v;
                }


                bool
                f_415_79803_79846(out int
                value, ref System.Reflection.Metadata.BlobReader
                sig)
                {
                    var return_v = CrackIntInAttributeValue(out value, ref sig);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 79803, 79846);
                    return return_v;
                }


                bool
                f_415_79867_79909(out int
                value, ref System.Reflection.Metadata.BlobReader
                sig)
                {
                    var return_v = CrackIntInAttributeValue(out value, ref sig);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 79867, 79909);
                    return return_v;
                }


                bool
                f_415_79930_79972(out int
                value, ref System.Reflection.Metadata.BlobReader
                sig)
                {
                    var return_v = CrackIntInAttributeValue(out value, ref sig);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 79930, 79972);
                    return return_v;
                }


                decimal
                f_415_80014_80059(int
                lo, int
                mid, int
                hi, bool
                isNegative, byte
                scale)
                {
                    var return_v = new decimal(lo, mid, hi, isNegative, scale);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 80014, 80059);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 79428, 80170);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 79428, 80170);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool CrackBoolArrayInAttributeValue(out ImmutableArray<bool> value, ref BlobReader sig)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(415, 80182, 80967);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 80310, 80875) || true) && (sig.RemainingBytes >= 4)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 80310, 80875);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 80371, 80404);

                    uint
                    arrayLen = sig.ReadUInt32()
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 80422, 80860) || true) && (sig.RemainingBytes >= arrayLen)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 80422, 80860);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 80498, 80567);

                        var
                        boolArrayBuilder = f_415_80521_80566(arrayLen)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 80598, 80603);
                            for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 80589, 80737) || true) && (i < arrayLen)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 80619, 80622)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(415, 80589, 80737))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 80589, 80737);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 80672, 80714);

                                f_415_80672_80713(boolArrayBuilder, sig.ReadByte() == 1);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(415, 1, 149);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(415, 1, 149);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 80761, 80807);

                        value = f_415_80769_80806(boolArrayBuilder);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 80829, 80841);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 80422, 80860);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(415, 80310, 80875);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 80891, 80929);

                value = default(ImmutableArray<bool>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 80943, 80956);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(415, 80182, 80967);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<bool>
                f_415_80521_80566(uint
                capacity)
                {
                    var return_v = ArrayBuilder<bool>.GetInstance((int)capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 80521, 80566);
                    return return_v;
                }


                int
                f_415_80672_80713(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<bool>
                this_param, bool
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 80672, 80713);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<bool>
                f_415_80769_80806(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<bool>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 80769, 80806);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 80182, 80967);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 80182, 80967);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool CrackByteArrayInAttributeValue(out ImmutableArray<byte> value, ref BlobReader sig)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(415, 80979, 81759);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 81107, 81667) || true) && (sig.RemainingBytes >= 4)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 81107, 81667);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 81168, 81201);

                    uint
                    arrayLen = sig.ReadUInt32()
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 81219, 81652) || true) && (sig.RemainingBytes >= arrayLen)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 81219, 81652);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 81295, 81364);

                        var
                        byteArrayBuilder = f_415_81318_81363(arrayLen)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 81395, 81400);
                            for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 81386, 81529) || true) && (i < arrayLen)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 81416, 81419)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(415, 81386, 81529))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 81386, 81529);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 81469, 81506);

                                f_415_81469_81505(byteArrayBuilder, sig.ReadByte());
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(415, 1, 144);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(415, 1, 144);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 81553, 81599);

                        value = f_415_81561_81598(byteArrayBuilder);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 81621, 81633);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 81219, 81652);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(415, 81107, 81667);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 81683, 81721);

                value = default(ImmutableArray<byte>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 81735, 81748);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(415, 80979, 81759);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<byte>
                f_415_81318_81363(uint
                capacity)
                {
                    var return_v = ArrayBuilder<byte>.GetInstance((int)capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 81318, 81363);
                    return return_v;
                }


                int
                f_415_81469_81505(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<byte>
                this_param, byte
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 81469, 81505);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_415_81561_81598(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<byte>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 81561, 81598);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 80979, 81759);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 80979, 81759);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal struct AttributeInfo
        {

            public readonly CustomAttributeHandle Handle;

            public readonly byte SignatureIndex;

            public AttributeInfo(CustomAttributeHandle handle, int signatureIndex)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(415, 81936, 82223);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 82039, 82108);

                    f_415_82039_82107(signatureIndex >= 0 && (DynAbs.Tracing.TraceSender.Expression_True(415, 82052, 82106) && signatureIndex <= byte.MaxValue));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 82126, 82147);

                    this.Handle = handle;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 82165, 82208);

                    this.SignatureIndex = (byte)signatureIndex;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(415, 81936, 82223);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 81936, 82223);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 81936, 82223);
                }
            }

            public bool HasValue
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 82292, 82321);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 82298, 82319);

                        return f_415_82305_82318_M(!Handle.IsNil);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(415, 82292, 82321);

                        bool
                        f_415_82305_82318_M(bool
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 82305, 82318);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 82239, 82336);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 82239, 82336);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }
            static AttributeInfo()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(415, 81771, 82347);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(415, 81771, 82347);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 81771, 82347);
            }

            static int
            f_415_82039_82107(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 82039, 82107);
                return 0;
            }

        }

        internal List<AttributeInfo> FindTargetAttributes(EntityHandle hasAttribute, AttributeDescription description)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 82359, 83316);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 82494, 82528);

                List<AttributeInfo>
                result = null
                ;

                try
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 82580, 83198);
                        foreach (var attributeHandle in f_415_82612_82660_I(f_415_82612_82660(f_415_82612_82626(), hasAttribute)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 82580, 83198);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 82702, 82786);

                            int
                            signatureIndex = f_415_82723_82785(this, attributeHandle, description)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 82808, 83179) || true) && (signatureIndex != -1)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 82808, 83179);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 82882, 83020) || true) && (result == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 82882, 83020);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 82958, 82993);

                                    result = f_415_82967_82992();
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(415, 82882, 83020);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 83093, 83156);

                                f_415_83093_83155(
                                                        // We found a match
                                                        result, f_415_83104_83154(attributeHandle, signatureIndex));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(415, 82808, 83179);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(415, 82580, 83198);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(415, 1, 619);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(415, 1, 619);
                    }
                }
                catch (BadImageFormatException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(415, 83227, 83275);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(415, 83227, 83275);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 83291, 83305);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 82359, 83316);

                System.Reflection.Metadata.MetadataReader
                f_415_82612_82626()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 82612, 82626);
                    return return_v;
                }


                System.Reflection.Metadata.CustomAttributeHandleCollection
                f_415_82612_82660(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.EntityHandle
                handle)
                {
                    var return_v = this_param.GetCustomAttributes(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 82612, 82660);
                    return return_v;
                }


                int
                f_415_82723_82785(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.CustomAttributeHandle
                customAttribute, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.GetTargetAttributeSignatureIndex(customAttribute, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 82723, 82785);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.CodeAnalysis.PEModule.AttributeInfo>
                f_415_82967_82992()
                {
                    var return_v = new System.Collections.Generic.List<Microsoft.CodeAnalysis.PEModule.AttributeInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 82967, 82992);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PEModule.AttributeInfo
                f_415_83104_83154(System.Reflection.Metadata.CustomAttributeHandle
                handle, int
                signatureIndex)
                {
                    var return_v = new Microsoft.CodeAnalysis.PEModule.AttributeInfo(handle, signatureIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 83104, 83154);
                    return return_v;
                }


                int
                f_415_83093_83155(System.Collections.Generic.List<Microsoft.CodeAnalysis.PEModule.AttributeInfo>
                this_param, Microsoft.CodeAnalysis.PEModule.AttributeInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 83093, 83155);
                    return 0;
                }


                System.Reflection.Metadata.CustomAttributeHandleCollection
                f_415_82612_82660_I(System.Reflection.Metadata.CustomAttributeHandleCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 82612, 82660);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 82359, 83316);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 82359, 83316);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal AttributeInfo FindTargetAttribute(EntityHandle hasAttribute, AttributeDescription description)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 83328, 83537);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 83456, 83526);

                return f_415_83463_83525(f_415_83483_83497(), hasAttribute, description);
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 83328, 83537);

                System.Reflection.Metadata.MetadataReader
                f_415_83483_83497()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 83483, 83497);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PEModule.AttributeInfo
                f_415_83463_83525(System.Reflection.Metadata.MetadataReader
                metadataReader, System.Reflection.Metadata.EntityHandle
                hasAttribute, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = FindTargetAttribute(metadataReader, hasAttribute, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 83463, 83525);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 83328, 83537);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 83328, 83537);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static AttributeInfo FindTargetAttribute(MetadataReader metadataReader, EntityHandle hasAttribute, AttributeDescription description)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(415, 83549, 84348);
                try
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 83751, 84214);
                        foreach (var attributeHandle in f_415_83783_83831_I(f_415_83783_83831(metadataReader, hasAttribute)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 83751, 84214);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 83873, 83973);

                            int
                            signatureIndex = f_415_83894_83972(metadataReader, attributeHandle, description)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 83995, 84195) || true) && (signatureIndex != -1)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 83995, 84195);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 84114, 84172);

                                return f_415_84121_84171(attributeHandle, signatureIndex);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(415, 83995, 84195);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(415, 83751, 84214);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(415, 1, 464);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(415, 1, 464);
                    }
                }
                catch (BadImageFormatException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(415, 84243, 84291);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(415, 84243, 84291);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 84307, 84337);

                return default(AttributeInfo);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(415, 83549, 84348);

                System.Reflection.Metadata.CustomAttributeHandleCollection
                f_415_83783_83831(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.EntityHandle
                handle)
                {
                    var return_v = this_param.GetCustomAttributes(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 83783, 83831);
                    return return_v;
                }


                int
                f_415_83894_83972(System.Reflection.Metadata.MetadataReader
                metadataReader, System.Reflection.Metadata.CustomAttributeHandle
                customAttribute, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = GetTargetAttributeSignatureIndex(metadataReader, customAttribute, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 83894, 83972);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PEModule.AttributeInfo
                f_415_84121_84171(System.Reflection.Metadata.CustomAttributeHandle
                handle, int
                signatureIndex)
                {
                    var return_v = new Microsoft.CodeAnalysis.PEModule.AttributeInfo(handle, signatureIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 84121, 84171);
                    return return_v;
                }


                System.Reflection.Metadata.CustomAttributeHandleCollection
                f_415_83783_83831_I(System.Reflection.Metadata.CustomAttributeHandleCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 83783, 83831);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 83549, 84348);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 83549, 84348);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal AttributeInfo FindLastTargetAttribute(EntityHandle hasAttribute, AttributeDescription description)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 84360, 85213);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 84528, 84576);

                    AttributeInfo
                    attrInfo = default(AttributeInfo)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 84594, 85045);
                        foreach (var attributeHandle in f_415_84626_84674_I(f_415_84626_84674(f_415_84626_84640(), hasAttribute)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 84594, 85045);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 84716, 84800);

                            int
                            signatureIndex = f_415_84737_84799(this, attributeHandle, description)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 84822, 85026) || true) && (signatureIndex != -1)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 84822, 85026);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 84941, 85003);

                                attrInfo = f_415_84952_85002(attributeHandle, signatureIndex);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(415, 84822, 85026);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(415, 84594, 85045);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(415, 1, 452);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(415, 1, 452);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 85063, 85079);

                    return attrInfo;
                }
                catch (BadImageFormatException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(415, 85108, 85156);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(415, 85108, 85156);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 85172, 85202);

                return default(AttributeInfo);
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 84360, 85213);

                System.Reflection.Metadata.MetadataReader
                f_415_84626_84640()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 84626, 84640);
                    return return_v;
                }


                System.Reflection.Metadata.CustomAttributeHandleCollection
                f_415_84626_84674(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.EntityHandle
                handle)
                {
                    var return_v = this_param.GetCustomAttributes(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 84626, 84674);
                    return return_v;
                }


                int
                f_415_84737_84799(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.CustomAttributeHandle
                customAttribute, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.GetTargetAttributeSignatureIndex(customAttribute, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 84737, 84799);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PEModule.AttributeInfo
                f_415_84952_85002(System.Reflection.Metadata.CustomAttributeHandle
                handle, int
                signatureIndex)
                {
                    var return_v = new Microsoft.CodeAnalysis.PEModule.AttributeInfo(handle, signatureIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 84952, 85002);
                    return return_v;
                }


                System.Reflection.Metadata.CustomAttributeHandleCollection
                f_415_84626_84674_I(System.Reflection.Metadata.CustomAttributeHandleCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 84626, 84674);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 84360, 85213);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 84360, 85213);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal int GetParamArrayCountOrThrow(EntityHandle hasAttribute)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 85327, 85803);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 85417, 85431);

                int
                count = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 85445, 85765);
                    foreach (var attributeHandle in f_415_85477_85525_I(f_415_85477_85525(f_415_85477_85491(), hasAttribute)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 85445, 85765);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 85559, 85750) || true) && (f_415_85563_85675(this, attributeHandle, AttributeDescription.ParamArrayAttribute) != -1)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 85559, 85750);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 85723, 85731);

                            count++;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(415, 85559, 85750);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 85445, 85765);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(415, 1, 321);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(415, 1, 321);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 85779, 85792);

                return count;
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 85327, 85803);

                System.Reflection.Metadata.MetadataReader
                f_415_85477_85491()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 85477, 85491);
                    return return_v;
                }


                System.Reflection.Metadata.CustomAttributeHandleCollection
                f_415_85477_85525(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.EntityHandle
                handle)
                {
                    var return_v = this_param.GetCustomAttributes(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 85477, 85525);
                    return return_v;
                }


                int
                f_415_85563_85675(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.CustomAttributeHandle
                customAttribute, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.GetTargetAttributeSignatureIndex(customAttribute, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 85563, 85675);
                    return return_v;
                }


                System.Reflection.Metadata.CustomAttributeHandleCollection
                f_415_85477_85525_I(System.Reflection.Metadata.CustomAttributeHandleCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 85477, 85525);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 85327, 85803);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 85327, 85803);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool IsNoPiaLocalType(TypeDefinitionHandle typeDef, out AttributeInfo attributeInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 85815, 87560);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 85932, 86103) || true) && (_lazyContainsNoPiaLocalTypes == ThreeState.False)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 85932, 86103);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 86018, 86057);

                    attributeInfo = default(AttributeInfo);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 86075, 86088);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(415, 85932, 86103);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 86119, 86654) || true) && (_lazyNoPiaLocalTypeCheckBitMap != null && (DynAbs.Tracing.TraceSender.Expression_True(415, 86123, 86221) && _lazyTypeDefToTypeIdentifierMap != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 86119, 86654);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 86255, 86302);

                    int
                    rid = f_415_86265_86279().GetRowNumber(typeDef)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 86320, 86342);

                    f_415_86320_86341(rid > 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 86362, 86382);

                    int
                    item = rid / 32
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 86400, 86426);

                    int
                    bit = 1 << (rid % 32)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 86446, 86639) || true) && ((_lazyNoPiaLocalTypeCheckBitMap[item] & bit) != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 86446, 86639);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 86541, 86620);

                        return f_415_86548_86619(_lazyTypeDefToTypeIdentifierMap, typeDef, out attributeInfo);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 86446, 86639);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(415, 86119, 86654);
                }

                try
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 86706, 87341);
                        foreach (var attributeHandle in f_415_86738_86781_I(f_415_86738_86781(f_415_86738_86752(), typeDef)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 86706, 87341);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 86823, 86887);

                            int
                            signatureIndex = f_415_86844_86886(this, attributeHandle)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 86909, 87322) || true) && (signatureIndex != -1)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 86909, 87322);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 87028, 87075);

                                _lazyContainsNoPiaLocalTypes = ThreeState.True;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 87103, 87168);

                                f_415_87103_87167(this, typeDef, attributeHandle, signatureIndex);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 87194, 87261);

                                attributeInfo = f_415_87210_87260(attributeHandle, signatureIndex);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 87287, 87299);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(415, 86909, 87322);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(415, 86706, 87341);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(415, 1, 636);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(415, 1, 636);
                    }
                }
                catch (BadImageFormatException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(415, 87370, 87418);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(415, 87370, 87418);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 87434, 87469);

                f_415_87434_87468(this, typeDef);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 87483, 87522);

                attributeInfo = default(AttributeInfo);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 87536, 87549);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 85815, 87560);

                System.Reflection.Metadata.MetadataReader
                f_415_86265_86279()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 86265, 86279);
                    return return_v;
                }


                int
                f_415_86320_86341(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 86320, 86341);
                    return 0;
                }


                bool
                f_415_86548_86619(System.Collections.Concurrent.ConcurrentDictionary<System.Reflection.Metadata.TypeDefinitionHandle, Microsoft.CodeAnalysis.PEModule.AttributeInfo>
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                key, out Microsoft.CodeAnalysis.PEModule.AttributeInfo
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 86548, 86619);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_415_86738_86752()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 86738, 86752);
                    return return_v;
                }


                System.Reflection.Metadata.CustomAttributeHandleCollection
                f_415_86738_86781(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                handle)
                {
                    var return_v = this_param.GetCustomAttributes((System.Reflection.Metadata.EntityHandle)handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 86738, 86781);
                    return return_v;
                }


                int
                f_415_86844_86886(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.CustomAttributeHandle
                customAttribute)
                {
                    var return_v = this_param.IsTypeIdentifierAttribute(customAttribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 86844, 86886);
                    return return_v;
                }


                int
                f_415_87103_87167(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                typeDef, System.Reflection.Metadata.CustomAttributeHandle
                customAttribute, int
                signatureIndex)
                {
                    this_param.RegisterNoPiaLocalType(typeDef, customAttribute, signatureIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 87103, 87167);
                    return 0;
                }


                Microsoft.CodeAnalysis.PEModule.AttributeInfo
                f_415_87210_87260(System.Reflection.Metadata.CustomAttributeHandle
                handle, int
                signatureIndex)
                {
                    var return_v = new Microsoft.CodeAnalysis.PEModule.AttributeInfo(handle, signatureIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 87210, 87260);
                    return return_v;
                }


                System.Reflection.Metadata.CustomAttributeHandleCollection
                f_415_86738_86781_I(System.Reflection.Metadata.CustomAttributeHandleCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 86738, 86781);
                    return return_v;
                }


                int
                f_415_87434_87468(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                typeDef)
                {
                    this_param.RecordNoPiaLocalTypeCheck(typeDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 87434, 87468);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 85815, 87560);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 85815, 87560);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void RegisterNoPiaLocalType(TypeDefinitionHandle typeDef, CustomAttributeHandle customAttribute, int signatureIndex)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 87572, 88491);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 87721, 88005) || true) && (_lazyNoPiaLocalTypeCheckBitMap == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 87721, 88005);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 87797, 87990);

                    f_415_87797_87989(ref _lazyNoPiaLocalTypeCheckBitMap, new int[(f_415_87913_87927().TypeDefinitions.Count + 32) / 32], null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(415, 87721, 88005);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 88021, 88313) || true) && (_lazyTypeDefToTypeIdentifierMap == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 88021, 88313);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 88098, 88298);

                    f_415_88098_88297(ref _lazyTypeDefToTypeIdentifierMap, f_415_88206_88269(), null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(415, 88021, 88313);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 88329, 88429);

                f_415_88329_88428(
                            _lazyTypeDefToTypeIdentifierMap, typeDef, f_415_88377_88427(customAttribute, signatureIndex));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 88445, 88480);

                f_415_88445_88479(this, typeDef);
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 87572, 88491);

                System.Reflection.Metadata.MetadataReader
                f_415_87913_87927()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 87913, 87927);
                    return return_v;
                }


                int[]?
                f_415_87797_87989(ref int[]?
                location1, int[]
                value, int[]?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 87797, 87989);
                    return return_v;
                }


                System.Collections.Concurrent.ConcurrentDictionary<System.Reflection.Metadata.TypeDefinitionHandle, Microsoft.CodeAnalysis.PEModule.AttributeInfo>
                f_415_88206_88269()
                {
                    var return_v = new System.Collections.Concurrent.ConcurrentDictionary<System.Reflection.Metadata.TypeDefinitionHandle, Microsoft.CodeAnalysis.PEModule.AttributeInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 88206, 88269);
                    return return_v;
                }


                System.Collections.Concurrent.ConcurrentDictionary<System.Reflection.Metadata.TypeDefinitionHandle, Microsoft.CodeAnalysis.PEModule.AttributeInfo>?
                f_415_88098_88297(ref System.Collections.Concurrent.ConcurrentDictionary<System.Reflection.Metadata.TypeDefinitionHandle, Microsoft.CodeAnalysis.PEModule.AttributeInfo>?
                location1, System.Collections.Concurrent.ConcurrentDictionary<System.Reflection.Metadata.TypeDefinitionHandle, Microsoft.CodeAnalysis.PEModule.AttributeInfo>
                value, System.Collections.Concurrent.ConcurrentDictionary<System.Reflection.Metadata.TypeDefinitionHandle, Microsoft.CodeAnalysis.PEModule.AttributeInfo>?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 88098, 88297);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PEModule.AttributeInfo
                f_415_88377_88427(System.Reflection.Metadata.CustomAttributeHandle
                handle, int
                signatureIndex)
                {
                    var return_v = new Microsoft.CodeAnalysis.PEModule.AttributeInfo(handle, signatureIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 88377, 88427);
                    return return_v;
                }


                bool
                f_415_88329_88428(System.Collections.Concurrent.ConcurrentDictionary<System.Reflection.Metadata.TypeDefinitionHandle, Microsoft.CodeAnalysis.PEModule.AttributeInfo>
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                key, Microsoft.CodeAnalysis.PEModule.AttributeInfo
                value)
                {
                    var return_v = this_param.TryAdd(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 88329, 88428);
                    return return_v;
                }


                int
                f_415_88445_88479(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                typeDef)
                {
                    this_param.RecordNoPiaLocalTypeCheck(typeDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 88445, 88479);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 87572, 88491);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 87572, 88491);
            }
        }

        private void RecordNoPiaLocalTypeCheck(TypeDefinitionHandle typeDef)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 88503, 89225);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 88596, 88694) || true) && (_lazyNoPiaLocalTypeCheckBitMap == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 88596, 88694);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 88672, 88679);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(415, 88596, 88694);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 88710, 88757);

                int
                rid = f_415_88720_88756(typeDef)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 88771, 88793);

                f_415_88771_88792(rid > 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 88807, 88827);

                int
                item = rid / 32
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 88841, 88867);

                int
                bit = 1 << (rid % 32)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 88881, 88894);

                int
                oldValue
                = default(int);
                {
                    try
                    {
                        do

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 88910, 89214);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 88945, 88993);

                            oldValue = _lazyNoPiaLocalTypeCheckBitMap[item];
                            DynAbs.Tracing.TraceSender.TraceExitCondition(415, 88910, 89214);
                        }
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 88910, 89214) || true) && (f_415_89029_89200(ref _lazyNoPiaLocalTypeCheckBitMap[item], oldValue | bit, oldValue) != oldValue)
                        );
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(415, 88910, 89214);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(415, 88910, 89214);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 88503, 89225);

                int
                f_415_88720_88756(System.Reflection.Metadata.TypeDefinitionHandle
                handle)
                {
                    var return_v = MetadataTokens.GetRowNumber((System.Reflection.Metadata.EntityHandle)handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 88720, 88756);
                    return return_v;
                }


                int
                f_415_88771_88792(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 88771, 88792);
                    return 0;
                }


                int
                f_415_89029_89200(ref int
                location1, int
                value, int
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 89029, 89200);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 88503, 89225);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 88503, 89225);
            }
        }

        private int IsTypeIdentifierAttribute(CustomAttributeHandle customAttribute)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 89596, 90271);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 89697, 89715);

                const int
                No = -1
                ;

                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 89767, 90019) || true) && (f_415_89771_89821(f_415_89771_89785(), customAttribute).Parent.Kind != HandleKind.TypeDefinition)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 89767, 90019);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 89990, 90000);

                        return No;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 89767, 90019);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 90039, 90142);

                    return f_415_90046_90141(this, customAttribute, AttributeDescription.TypeIdentifierAttribute);
                }
                catch (BadImageFormatException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(415, 90171, 90260);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 90235, 90245);

                    return No;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(415, 90171, 90260);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 89596, 90271);

                System.Reflection.Metadata.MetadataReader
                f_415_89771_89785()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 89771, 89785);
                    return return_v;
                }


                System.Reflection.Metadata.CustomAttribute
                f_415_89771_89821(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.CustomAttributeHandle
                handle)
                {
                    var return_v = this_param.GetCustomAttribute(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 89771, 89821);
                    return return_v;
                }


                int
                f_415_90046_90141(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.CustomAttributeHandle
                customAttribute, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.GetTargetAttributeSignatureIndex(customAttribute, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 90046, 90141);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 89596, 90271);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 89596, 90271);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool IsTargetAttribute(
                    CustomAttributeHandle customAttribute,
                    string namespaceName,
                    string typeName,
                    out EntityHandle ctor,
                    bool ignoreCase = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 90942, 91306);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 91190, 91295);

                return f_415_91197_91294(f_415_91215_91229(), customAttribute, namespaceName, typeName, out ctor, ignoreCase);
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 90942, 91306);

                System.Reflection.Metadata.MetadataReader
                f_415_91215_91229()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 91215, 91229);
                    return return_v;
                }


                bool
                f_415_91197_91294(System.Reflection.Metadata.MetadataReader
                metadataReader, System.Reflection.Metadata.CustomAttributeHandle
                customAttribute, string
                namespaceName, string
                typeName, out System.Reflection.Metadata.EntityHandle
                ctor, bool
                ignoreCase)
                {
                    var return_v = IsTargetAttribute(metadataReader, customAttribute, namespaceName, typeName, out ctor, ignoreCase);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 91197, 91294);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 90942, 91306);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 90942, 91306);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsTargetAttribute(
                    MetadataReader metadataReader,
                    CustomAttributeHandle customAttribute,
                    string namespaceName,
                    string typeName,
                    out EntityHandle ctor,
                    bool ignoreCase)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(415, 92048, 93236);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 92338, 92374);

                f_415_92338_92373(namespaceName != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 92388, 92419);

                f_415_92388_92418(typeName != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 92435, 92457);

                EntityHandle
                ctorType
                = default(EntityHandle);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 92471, 92502);

                StringHandle
                ctorTypeNamespace
                = default(StringHandle);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 92516, 92542);

                StringHandle
                ctorTypeName
                = default(StringHandle);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 92558, 92703) || true) && (!f_415_92563_92641(metadataReader, customAttribute, out ctorType, out ctor))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 92558, 92703);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 92675, 92688);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(415, 92558, 92703);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 92719, 92881) || true) && (!f_415_92724_92819(metadataReader, ctorType, out ctorTypeNamespace, out ctorTypeName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 92719, 92881);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 92853, 92866);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(415, 92719, 92881);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 92933, 93104);

                    return f_415_92940_93004(metadataReader, ctorTypeName, typeName, ignoreCase) && (DynAbs.Tracing.TraceSender.Expression_True(415, 92940, 93103) && f_415_93029_93103(metadataReader, ctorTypeNamespace, namespaceName, ignoreCase));
                }
                catch (BadImageFormatException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(415, 93133, 93225);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 93197, 93210);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(415, 93133, 93225);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(415, 92048, 93236);

                int
                f_415_92338_92373(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 92338, 92373);
                    return 0;
                }


                int
                f_415_92388_92418(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 92388, 92418);
                    return 0;
                }


                bool
                f_415_92563_92641(System.Reflection.Metadata.MetadataReader
                metadataReader, System.Reflection.Metadata.CustomAttributeHandle
                customAttribute, out System.Reflection.Metadata.EntityHandle
                ctorType, out System.Reflection.Metadata.EntityHandle
                attributeCtor)
                {
                    var return_v = GetTypeAndConstructor(metadataReader, customAttribute, out ctorType, out attributeCtor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 92563, 92641);
                    return return_v;
                }


                bool
                f_415_92724_92819(System.Reflection.Metadata.MetadataReader
                metadataReader, System.Reflection.Metadata.EntityHandle
                typeDefOrRef, out System.Reflection.Metadata.StringHandle
                namespaceHandle, out System.Reflection.Metadata.StringHandle
                nameHandle)
                {
                    var return_v = GetAttributeNamespaceAndName(metadataReader, typeDefOrRef, out namespaceHandle, out nameHandle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 92724, 92819);
                    return return_v;
                }


                bool
                f_415_92940_93004(System.Reflection.Metadata.MetadataReader
                metadataReader, System.Reflection.Metadata.StringHandle
                nameHandle, string
                name, bool
                ignoreCase)
                {
                    var return_v = StringEquals(metadataReader, nameHandle, name, ignoreCase);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 92940, 93004);
                    return return_v;
                }


                bool
                f_415_93029_93103(System.Reflection.Metadata.MetadataReader
                metadataReader, System.Reflection.Metadata.StringHandle
                nameHandle, string
                name, bool
                ignoreCase)
                {
                    var return_v = StringEquals(metadataReader, nameHandle, name, ignoreCase);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 93029, 93103);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 92048, 93236);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 92048, 93236);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal AssemblyReferenceHandle GetAssemblyRef(string assemblyName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 93534, 94384);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 93627, 93662);

                f_415_93627_93661(assemblyName != null);

                try
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 93765, 94214);
                        foreach (var assemblyRef in f_415_93793_93826_I(f_415_93793_93826(f_415_93793_93807())))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 93765, 94214);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 93940, 94195) || true) && (f_415_93944_93958().StringComparer.Equals(f_415_93981_94029(f_415_93981_93995(), assemblyRef).Name, assemblyName))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 93940, 94195);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 94153, 94172);

                                return assemblyRef;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(415, 93940, 94195);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(415, 93765, 94214);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(415, 1, 450);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(415, 1, 450);
                    }
                }
                catch (BadImageFormatException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(415, 94243, 94291);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(415, 94243, 94291);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 94333, 94373);

                return default(AssemblyReferenceHandle);
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 93534, 94384);

                int
                f_415_93627_93661(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 93627, 93661);
                    return 0;
                }


                System.Reflection.Metadata.MetadataReader
                f_415_93793_93807()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 93793, 93807);
                    return return_v;
                }


                System.Reflection.Metadata.AssemblyReferenceHandleCollection
                f_415_93793_93826(System.Reflection.Metadata.MetadataReader
                this_param)
                {
                    var return_v = this_param.AssemblyReferences;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 93793, 93826);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_415_93944_93958()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 93944, 93958);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_415_93981_93995()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 93981, 93995);
                    return return_v;
                }


                System.Reflection.Metadata.AssemblyReference
                f_415_93981_94029(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.AssemblyReferenceHandle
                handle)
                {
                    var return_v = this_param.GetAssemblyReference(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 93981, 94029);
                    return return_v;
                }


                System.Reflection.Metadata.AssemblyReferenceHandleCollection
                f_415_93793_93826_I(System.Reflection.Metadata.AssemblyReferenceHandleCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 93793, 93826);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 93534, 94384);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 93534, 94384);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal EntityHandle GetTypeRef(
                    EntityHandle resolutionScope,
                    string namespaceName,
                    string typeName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 94869, 96273);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 95035, 95072);

                f_415_95035_95071(f_415_95048_95070_M(!resolutionScope.IsNil));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 95086, 95122);

                f_415_95086_95121(namespaceName != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 95136, 95167);

                f_415_95136_95166(typeName != null);

                try
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 95266, 96107);
                        foreach (var handle in f_415_95289_95318_I(f_415_95289_95318(f_415_95289_95303())))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 95266, 96107);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 95360, 95414);

                            var
                            typeRef = f_415_95374_95413(f_415_95374_95388(), handle)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 95502, 95630) || true) && (typeRef.ResolutionScope != resolutionScope)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 95502, 95630);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 95598, 95607);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(415, 95502, 95630);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 95706, 95853) || true) && (!f_415_95711_95725().StringComparer.Equals(typeRef.Name, typeName))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 95706, 95853);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 95821, 95830);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(415, 95706, 95853);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 95877, 96088) || true) && (f_415_95881_95895().StringComparer.Equals(typeRef.Namespace, namespaceName))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 95877, 96088);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 96051, 96065);

                                return handle;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(415, 95877, 96088);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(415, 95266, 96107);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(415, 1, 842);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(415, 1, 842);
                    }
                }
                catch (BadImageFormatException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(415, 96136, 96184);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(415, 96136, 96184);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 96226, 96262);

                return default(TypeReferenceHandle);
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 94869, 96273);

                bool
                f_415_95048_95070_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 95048, 95070);
                    return return_v;
                }


                int
                f_415_95035_95071(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 95035, 95071);
                    return 0;
                }


                int
                f_415_95086_95121(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 95086, 95121);
                    return 0;
                }


                int
                f_415_95136_95166(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 95136, 95166);
                    return 0;
                }


                System.Reflection.Metadata.MetadataReader
                f_415_95289_95303()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 95289, 95303);
                    return return_v;
                }


                System.Reflection.Metadata.TypeReferenceHandleCollection
                f_415_95289_95318(System.Reflection.Metadata.MetadataReader
                this_param)
                {
                    var return_v = this_param.TypeReferences;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 95289, 95318);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_415_95374_95388()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 95374, 95388);
                    return return_v;
                }


                System.Reflection.Metadata.TypeReference
                f_415_95374_95413(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.TypeReferenceHandle
                handle)
                {
                    var return_v = this_param.GetTypeReference(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 95374, 95413);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_415_95711_95725()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 95711, 95725);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_415_95881_95895()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 95881, 95895);
                    return return_v;
                }


                System.Reflection.Metadata.TypeReferenceHandleCollection
                f_415_95289_95318_I(System.Reflection.Metadata.TypeReferenceHandleCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 95289, 95318);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 94869, 96273);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 94869, 96273);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void GetTypeRefPropsOrThrow(
                    TypeReferenceHandle handle,
                    out string name,
                    out string @namespace,
                    out EntityHandle resolutionScope)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 96387, 96939);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 96601, 96665);

                TypeReference
                typeRef = f_415_96625_96664(f_415_96625_96639(), handle)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 96679, 96721);

                resolutionScope = typeRef.ResolutionScope;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 96735, 96781);

                name = f_415_96742_96780(f_415_96742_96756(), typeRef.Name);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 96795, 96857);

                f_415_96795_96856(f_415_96808_96855(name));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 96871, 96928);

                @namespace = f_415_96884_96927(f_415_96884_96898(), typeRef.Namespace);
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 96387, 96939);

                System.Reflection.Metadata.MetadataReader
                f_415_96625_96639()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 96625, 96639);
                    return return_v;
                }


                System.Reflection.Metadata.TypeReference
                f_415_96625_96664(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.TypeReferenceHandle
                handle)
                {
                    var return_v = this_param.GetTypeReference(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 96625, 96664);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_415_96742_96756()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 96742, 96756);
                    return return_v;
                }


                string
                f_415_96742_96780(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.StringHandle
                handle)
                {
                    var return_v = this_param.GetString(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 96742, 96780);
                    return return_v;
                }


                bool
                f_415_96808_96855(string
                str)
                {
                    var return_v = MetadataHelpers.IsValidMetadataIdentifier(str);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 96808, 96855);
                    return return_v;
                }


                int
                f_415_96795_96856(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 96795, 96856);
                    return 0;
                }


                System.Reflection.Metadata.MetadataReader
                f_415_96884_96898()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 96884, 96898);
                    return return_v;
                }


                string
                f_415_96884_96927(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.StringHandle
                handle)
                {
                    var return_v = this_param.GetString(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 96884, 96927);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 96387, 96939);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 96387, 96939);
            }
        }

        internal int GetTargetAttributeSignatureIndex(CustomAttributeHandle customAttribute, AttributeDescription description)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 97445, 97685);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 97588, 97674);

                return f_415_97595_97673(f_415_97628_97642(), customAttribute, description);
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 97445, 97685);

                System.Reflection.Metadata.MetadataReader
                f_415_97628_97642()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 97628, 97642);
                    return return_v;
                }


                int
                f_415_97595_97673(System.Reflection.Metadata.MetadataReader
                metadataReader, System.Reflection.Metadata.CustomAttributeHandle
                customAttribute, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = GetTargetAttributeSignatureIndex(metadataReader, customAttribute, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 97595, 97673);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 97445, 97685);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 97445, 97685);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static int GetTargetAttributeSignatureIndex(MetadataReader metadataReader, CustomAttributeHandle customAttribute, AttributeDescription description)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(415, 98290, 104062);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 98470, 98488);

                const int
                No = -1
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 98502, 98520);

                EntityHandle
                ctor
                = default(EntityHandle);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 98620, 98816) || true) && (!f_415_98625_98757(metadataReader, customAttribute, description.Namespace, description.Name, out ctor, description.MatchIgnoringCase))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 98620, 98816);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 98791, 98801);

                    return No;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(415, 98620, 98816);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 98905, 99000);

                    BlobReader
                    sig = f_415_98922_98999(metadataReader, f_415_98951_98998(metadataReader, ctor))
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 99029, 99034);

                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 99020, 103948) || true) && (i < f_415_99040_99069(description.Signatures))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 99071, 99074)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(415, 99020, 103948))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 99020, 103948);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 99116, 99164);

                            var
                            targetSignature = description.Signatures[i]
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 99186, 99228);

                            f_415_99186_99227(f_415_99199_99221(targetSignature) >= 3);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 99250, 99262);

                            sig.Reset();

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 99339, 103929) || true) && (sig.RemainingBytes >= 3 && (DynAbs.Tracing.TraceSender.Expression_True(415, 99343, 99431) && sig.ReadByte() == targetSignature[0]) && (DynAbs.Tracing.TraceSender.Expression_True(415, 99343, 99496) && sig.ReadByte() == targetSignature[1]) && (DynAbs.Tracing.TraceSender.Expression_True(415, 99343, 99561) && sig.ReadByte() == targetSignature[2]))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 99339, 103929);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 99611, 99621);

                                int
                                j = 3
                                ;
                                try
                                {
                                    for (; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 99647, 103677) || true) && (j < f_415_99658_99680(targetSignature))
       ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 99682, 99685)
       , j++, DynAbs.Tracing.TraceSender.TraceExitCondition(415, 99647, 103677))

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 99647, 103677);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 99743, 99940) || true) && (sig.RemainingBytes == 0)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 99743, 99940);
                                            DynAbs.Tracing.TraceSender.TraceBreak(415, 99903, 99909);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(415, 99743, 99940);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 99972, 100022);

                                        SignatureTypeCode
                                        b = sig.ReadSignatureTypeCode()
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 100052, 103584) || true) && ((SignatureTypeCode)targetSignature[j] == b)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 100052, 103584);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 100164, 103553);

                                            switch (b)
                                            {

                                                case SignatureTypeCode.TypeHandle:
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 100164, 103553);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 100323, 100365);

                                                    EntityHandle
                                                    token = sig.ReadTypeHandle()
                                                    ;
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 100407, 100441);

                                                    HandleKind
                                                    tokenType = token.Kind
                                                    ;
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 100483, 100501);

                                                    StringHandle
                                                    name
                                                    = default(StringHandle);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 100543, 100559);

                                                    StringHandle
                                                    ns
                                                    = default(StringHandle);

                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 100603, 102555) || true) && (tokenType == HandleKind.TypeDefinition)
                                                    )

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 100603, 102555);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 100735, 100797);

                                                        TypeDefinitionHandle
                                                        typeHandle = (TypeDefinitionHandle)token
                                                        ;

                                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 100845, 101198) || true) && (f_415_100849_100899(metadataReader, typeHandle))
                                                        )

                                                        {
                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 100845, 101198);
                                                            DynAbs.Tracing.TraceSender.TraceBreak(415, 101117, 101123);

                                                            break;
                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(415, 100845, 101198);
                                                        }
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 101246, 101316);

                                                        TypeDefinition
                                                        typeDef = f_415_101271_101315(metadataReader, typeHandle)
                                                        ;
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 101362, 101382);

                                                        name = typeDef.Name;
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 101428, 101451);

                                                        ns = typeDef.Namespace;
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 100603, 102555);
                                                    }

                                                    else
                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 100603, 102555);

                                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 101541, 102555) || true) && (tokenType == HandleKind.TypeReference)
                                                        )

                                                        {
                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 101541, 102555);
                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 101672, 101756);

                                                            TypeReference
                                                            typeRef = f_415_101696_101755(metadataReader, token)
                                                            ;

                                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 101804, 102163) || true) && (typeRef.ResolutionScope.Kind == HandleKind.TypeReference)
                                                            )

                                                            {
                                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 101804, 102163);
                                                                DynAbs.Tracing.TraceSender.TraceBreak(415, 102082, 102088);

                                                                break;
                                                                DynAbs.Tracing.TraceSender.TraceExitCondition(415, 101804, 102163);
                                                            }
                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 102211, 102231);

                                                            name = typeRef.Name;
                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 102277, 102300);

                                                            ns = typeRef.Namespace;
                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(415, 101541, 102555);
                                                        }

                                                        else

                                                        {
                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 101541, 102555);
                                                            DynAbs.Tracing.TraceSender.TraceBreak(415, 102478, 102484);

                                                            break;
                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(415, 101541, 102555);
                                                        }
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 100603, 102555);
                                                    }
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 102599, 102717);

                                                    AttributeDescription.TypeHandleTargetInfo
                                                    targetInfo = AttributeDescription.TypeHandleTargets[targetSignature[j + 1]]
                                                    ;

                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 102761, 103149) || true) && (f_415_102765_102838(metadataReader, ns, targetInfo.Namespace, ignoreCase: false) && (DynAbs.Tracing.TraceSender.Expression_True(415, 102765, 102957) && f_415_102887_102957(metadataReader, name, targetInfo.Name, ignoreCase: false)))
                                                    )

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 102761, 103149);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 103047, 103051);

                                                        j++;
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 103097, 103106);

                                                        continue;
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 102761, 103149);
                                                    }
                                                    DynAbs.Tracing.TraceSender.TraceBreak(415, 103193, 103199);

                                                    break;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(415, 100164, 103553);

                                                case SignatureTypeCode.SZArray:
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 100164, 103553);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 103410, 103419);

                                                    continue;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(415, 100164, 103553);

                                                default:
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 100164, 103553);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 103509, 103518);

                                                    continue;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(415, 100164, 103553);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(415, 100052, 103584);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceBreak(415, 103616, 103622);

                                        break;
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(415, 1, 4031);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(415, 1, 4031);
                                }
                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 103705, 103906) || true) && (sig.RemainingBytes == 0 && (DynAbs.Tracing.TraceSender.Expression_True(415, 103709, 103763) && j == f_415_103741_103763(targetSignature)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 103705, 103906);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 103870, 103879);

                                    return i;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(415, 103705, 103906);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(415, 99339, 103929);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(415, 1, 4929);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(415, 1, 4929);
                    }
                }
                catch (BadImageFormatException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(415, 103977, 104025);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(415, 103977, 104025);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 104041, 104051);

                return No;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(415, 98290, 104062);

                bool
                f_415_98625_98757(System.Reflection.Metadata.MetadataReader
                metadataReader, System.Reflection.Metadata.CustomAttributeHandle
                customAttribute, string
                namespaceName, string
                typeName, out System.Reflection.Metadata.EntityHandle
                ctor, bool
                ignoreCase)
                {
                    var return_v = IsTargetAttribute(metadataReader, customAttribute, namespaceName, typeName, out ctor, ignoreCase);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 98625, 98757);
                    return return_v;
                }


                System.Reflection.Metadata.BlobHandle
                f_415_98951_98998(System.Reflection.Metadata.MetadataReader
                metadataReader, System.Reflection.Metadata.EntityHandle
                methodDefOrRef)
                {
                    var return_v = GetMethodSignatureOrThrow(metadataReader, methodDefOrRef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 98951, 98998);
                    return return_v;
                }


                System.Reflection.Metadata.BlobReader
                f_415_98922_98999(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.BlobHandle
                handle)
                {
                    var return_v = this_param.GetBlobReader(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 98922, 98999);
                    return return_v;
                }


                int
                f_415_99040_99069(byte[][]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 99040, 99069);
                    return return_v;
                }


                int
                f_415_99199_99221(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 99199, 99221);
                    return return_v;
                }


                int
                f_415_99186_99227(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 99186, 99227);
                    return 0;
                }


                int
                f_415_99658_99680(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 99658, 99680);
                    return return_v;
                }


                bool
                f_415_100849_100899(System.Reflection.Metadata.MetadataReader
                metadataReader, System.Reflection.Metadata.TypeDefinitionHandle
                typeDef)
                {
                    var return_v = IsNestedTypeDefOrThrow(metadataReader, typeDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 100849, 100899);
                    return return_v;
                }


                System.Reflection.Metadata.TypeDefinition
                f_415_101271_101315(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                handle)
                {
                    var return_v = this_param.GetTypeDefinition(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 101271, 101315);
                    return return_v;
                }


                System.Reflection.Metadata.TypeReference
                f_415_101696_101755(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.EntityHandle
                handle)
                {
                    var return_v = this_param.GetTypeReference((System.Reflection.Metadata.TypeReferenceHandle)handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 101696, 101755);
                    return return_v;
                }


                bool
                f_415_102765_102838(System.Reflection.Metadata.MetadataReader
                metadataReader, System.Reflection.Metadata.StringHandle
                nameHandle, string
                name, bool
                ignoreCase)
                {
                    var return_v = StringEquals(metadataReader, nameHandle, name, ignoreCase: ignoreCase);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 102765, 102838);
                    return return_v;
                }


                bool
                f_415_102887_102957(System.Reflection.Metadata.MetadataReader
                metadataReader, System.Reflection.Metadata.StringHandle
                nameHandle, string
                name, bool
                ignoreCase)
                {
                    var return_v = StringEquals(metadataReader, nameHandle, name, ignoreCase: ignoreCase);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 102887, 102957);
                    return return_v;
                }


                int
                f_415_103741_103763(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 103741, 103763);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 98290, 104062);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 98290, 104062);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool GetTypeAndConstructor(
                    CustomAttributeHandle customAttribute,
                    out EntityHandle ctorType,
                    out EntityHandle attributeCtor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 104375, 104679);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 104573, 104668);

                return f_415_104580_104667(f_415_104602_104616(), customAttribute, out ctorType, out attributeCtor);
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 104375, 104679);

                System.Reflection.Metadata.MetadataReader
                f_415_104602_104616()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 104602, 104616);
                    return return_v;
                }


                bool
                f_415_104580_104667(System.Reflection.Metadata.MetadataReader
                metadataReader, System.Reflection.Metadata.CustomAttributeHandle
                customAttribute, out System.Reflection.Metadata.EntityHandle
                ctorType, out System.Reflection.Metadata.EntityHandle
                attributeCtor)
                {
                    var return_v = GetTypeAndConstructor(metadataReader, customAttribute, out ctorType, out attributeCtor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 104580, 104667);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 104375, 104679);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 104375, 104679);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool GetTypeAndConstructor(
                    MetadataReader metadataReader,
                    CustomAttributeHandle customAttribute,
                    out EntityHandle ctorType,
                    out EntityHandle attributeCtor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(415, 104992, 107020);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 105276, 105309);

                    ctorType = default(EntityHandle);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 105329, 105408);

                    attributeCtor = f_415_105345_105395(metadataReader, customAttribute).Constructor;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 105428, 106749) || true) && (attributeCtor.Kind == HandleKind.MemberReference)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 105428, 106749);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 105522, 105622);

                        MemberReference
                        memberRef = f_415_105550_105621(metadataReader, attributeCtor)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 105646, 105685);

                        StringHandle
                        ctorName = memberRef.Name
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 105709, 105939) || true) && (!metadataReader.StringComparer.Equals(ctorName, WellKnownMemberNames.InstanceConstructorName))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 105709, 105939);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 105903, 105916);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(415, 105709, 105939);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 105963, 105991);

                        ctorType = memberRef.Parent;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 105428, 106749);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 105428, 106749);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 106033, 106749) || true) && (attributeCtor.Kind == HandleKind.MethodDefinition)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 106033, 106749);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 106128, 106218);

                            var
                            methodDef = f_415_106144_106217(metadataReader, attributeCtor)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 106242, 106478) || true) && (!metadataReader.StringComparer.Equals(methodDef.Name, WellKnownMemberNames.InstanceConstructorName))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 106242, 106478);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 106442, 106455);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(415, 106242, 106478);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 106502, 106542);

                            ctorType = methodDef.GetDeclaringType();
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 106564, 106594);

                            f_415_106564_106593(f_415_106577_106592_M(!ctorType.IsNil));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(415, 106033, 106749);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 106033, 106749);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 106717, 106730);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(415, 106033, 106749);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 105428, 106749);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 106769, 106781);

                    return true;
                }
                catch (BadImageFormatException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(415, 106810, 107009);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 106874, 106907);

                    ctorType = default(EntityHandle);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 106925, 106963);

                    attributeCtor = default(EntityHandle);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 106981, 106994);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(415, 106810, 107009);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(415, 104992, 107020);

                System.Reflection.Metadata.CustomAttribute
                f_415_105345_105395(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.CustomAttributeHandle
                handle)
                {
                    var return_v = this_param.GetCustomAttribute(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 105345, 105395);
                    return return_v;
                }


                System.Reflection.Metadata.MemberReference
                f_415_105550_105621(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.EntityHandle
                handle)
                {
                    var return_v = this_param.GetMemberReference((System.Reflection.Metadata.MemberReferenceHandle)handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 105550, 105621);
                    return return_v;
                }


                System.Reflection.Metadata.MethodDefinition
                f_415_106144_106217(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.EntityHandle
                handle)
                {
                    var return_v = this_param.GetMethodDefinition((System.Reflection.Metadata.MethodDefinitionHandle)handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 106144, 106217);
                    return return_v;
                }


                bool
                f_415_106577_106592_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 106577, 106592);
                    return return_v;
                }


                int
                f_415_106564_106593(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 106564, 106593);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 104992, 107020);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 104992, 107020);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool GetAttributeNamespaceAndName(EntityHandle typeDefOrRef, out StringHandle namespaceHandle, out StringHandle nameHandle)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 107388, 107659);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 107545, 107648);

                return f_415_107552_107647(f_415_107581_107595(), typeDefOrRef, out namespaceHandle, out nameHandle);
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 107388, 107659);

                System.Reflection.Metadata.MetadataReader
                f_415_107581_107595()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 107581, 107595);
                    return return_v;
                }


                bool
                f_415_107552_107647(System.Reflection.Metadata.MetadataReader
                metadataReader, System.Reflection.Metadata.EntityHandle
                typeDefOrRef, out System.Reflection.Metadata.StringHandle
                namespaceHandle, out System.Reflection.Metadata.StringHandle
                nameHandle)
                {
                    var return_v = GetAttributeNamespaceAndName(metadataReader, typeDefOrRef, out namespaceHandle, out nameHandle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 107552, 107647);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 107388, 107659);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 107388, 107659);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool GetAttributeNamespaceAndName(MetadataReader metadataReader, EntityHandle typeDefOrRef, out StringHandle namespaceHandle, out StringHandle nameHandle)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(415, 108027, 109825);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 108221, 108256);

                nameHandle = default(StringHandle);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 108270, 108310);

                namespaceHandle = default(StringHandle);

                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 108362, 109661) || true) && (typeDefOrRef.Kind == HandleKind.TypeReference)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 108362, 109661);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 108453, 108547);

                        TypeReference
                        typeRefRow = f_415_108480_108546(metadataReader, typeDefOrRef)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 108569, 108625);

                        HandleKind
                        handleType = typeRefRow.ResolutionScope.Kind
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 108649, 108879) || true) && (handleType == HandleKind.TypeReference || (DynAbs.Tracing.TraceSender.Expression_False(415, 108653, 108734) || handleType == HandleKind.TypeDefinition))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 108649, 108879);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 108843, 108856);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(415, 108649, 108879);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 108903, 108932);

                        nameHandle = typeRefRow.Name;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 108954, 108993);

                        namespaceHandle = typeRefRow.Namespace;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 108362, 109661);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 108362, 109661);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 109035, 109661) || true) && (typeDefOrRef.Kind == HandleKind.TypeDefinition)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 109035, 109661);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 109127, 109206);

                            var
                            def = f_415_109137_109205(metadataReader, typeDefOrRef)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 109230, 109402) || true) && (f_415_109234_109258(def.Attributes))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 109230, 109402);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 109366, 109379);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(415, 109230, 109402);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 109426, 109448);

                            nameHandle = def.Name;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 109470, 109502);

                            namespaceHandle = def.Namespace;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(415, 109035, 109661);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 109035, 109661);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 109629, 109642);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(415, 109035, 109661);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 108362, 109661);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 109681, 109693);

                    return true;
                }
                catch (BadImageFormatException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(415, 109722, 109814);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 109786, 109799);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(415, 109722, 109814);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(415, 108027, 109825);

                System.Reflection.Metadata.TypeReference
                f_415_108480_108546(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.EntityHandle
                handle)
                {
                    var return_v = this_param.GetTypeReference((System.Reflection.Metadata.TypeReferenceHandle)handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 108480, 108546);
                    return return_v;
                }


                System.Reflection.Metadata.TypeDefinition
                f_415_109137_109205(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.EntityHandle
                handle)
                {
                    var return_v = this_param.GetTypeDefinition((System.Reflection.Metadata.TypeDefinitionHandle)handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 109137, 109205);
                    return return_v;
                }


                bool
                f_415_109234_109258(System.Reflection.TypeAttributes
                flags)
                {
                    var return_v = IsNested(flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 109234, 109258);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 108027, 109825);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 108027, 109825);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void PretendThereArentNoPiaLocalTypes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 109926, 110134);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 109999, 110061);

                f_415_109999_110060(_lazyContainsNoPiaLocalTypes != ThreeState.True);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 110075, 110123);

                _lazyContainsNoPiaLocalTypes = ThreeState.False;
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 109926, 110134);

                int
                f_415_109999_110060(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 109999, 110060);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 109926, 110134);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 109926, 110134);
            }
        }

        internal bool ContainsNoPiaLocalTypes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 110146, 111376);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 110210, 111294) || true) && (_lazyContainsNoPiaLocalTypes == ThreeState.Unknown)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 110210, 111294);
                    try
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 110342, 111122);
                            foreach (var attributeHandle in f_415_110374_110405_I(f_415_110374_110405(f_415_110374_110388())))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 110342, 111122);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 110455, 110519);

                                int
                                signatureIndex = f_415_110476_110518(this, attributeHandle)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 110545, 111099) || true) && (signatureIndex != -1)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 110545, 111099);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 110676, 110723);

                                    _lazyContainsNoPiaLocalTypes = ThreeState.True;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 110841, 110934);

                                    var
                                    parent = (TypeDefinitionHandle)f_415_110876_110926(f_415_110876_110890(), attributeHandle).Parent
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 110966, 111030);

                                    f_415_110966_111029(this, parent, attributeHandle, signatureIndex);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 111060, 111072);

                                    return true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(415, 110545, 111099);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(415, 110342, 111122);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(415, 1, 781);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(415, 1, 781);
                        }
                    }
                    catch (BadImageFormatException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(415, 111159, 111211);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(415, 111159, 111211);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 111231, 111279);

                    _lazyContainsNoPiaLocalTypes = ThreeState.False;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(415, 110210, 111294);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 111310, 111365);

                return _lazyContainsNoPiaLocalTypes == ThreeState.True;
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 110146, 111376);

                System.Reflection.Metadata.MetadataReader
                f_415_110374_110388()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 110374, 110388);
                    return return_v;
                }


                System.Reflection.Metadata.CustomAttributeHandleCollection
                f_415_110374_110405(System.Reflection.Metadata.MetadataReader
                this_param)
                {
                    var return_v = this_param.CustomAttributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 110374, 110405);
                    return return_v;
                }


                int
                f_415_110476_110518(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.CustomAttributeHandle
                customAttribute)
                {
                    var return_v = this_param.IsTypeIdentifierAttribute(customAttribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 110476, 110518);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_415_110876_110890()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 110876, 110890);
                    return return_v;
                }


                System.Reflection.Metadata.CustomAttribute
                f_415_110876_110926(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.CustomAttributeHandle
                handle)
                {
                    var return_v = this_param.GetCustomAttribute(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 110876, 110926);
                    return return_v;
                }


                int
                f_415_110966_111029(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                typeDef, System.Reflection.Metadata.CustomAttributeHandle
                customAttribute, int
                signatureIndex)
                {
                    this_param.RegisterNoPiaLocalType(typeDef, customAttribute, signatureIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 110966, 111029);
                    return 0;
                }


                System.Reflection.Metadata.CustomAttributeHandleCollection
                f_415_110374_110405_I(System.Reflection.Metadata.CustomAttributeHandleCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 110374, 110405);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 110146, 111376);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 110146, 111376);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool HasNullableContextAttribute(EntityHandle token, out byte value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 111388, 111898);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 111490, 111585);

                AttributeInfo
                info = f_415_111511_111584(this, token, AttributeDescription.NullableContextAttribute)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 111599, 111656);

                f_415_111599_111655(f_415_111612_111626_M(!info.HasValue) || (DynAbs.Tracing.TraceSender.Expression_False(415, 111612, 111654) || info.SignatureIndex == 0));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 111672, 111780) || true) && (f_415_111676_111690_M(!info.HasValue))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 111672, 111780);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 111724, 111734);

                    value = 0;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 111752, 111765);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(415, 111672, 111780);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 111796, 111887);

                return f_415_111803_111886(this, info.Handle, out value, s_attributeByteValueExtractor);
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 111388, 111898);

                Microsoft.CodeAnalysis.PEModule.AttributeInfo
                f_415_111511_111584(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.EntityHandle
                hasAttribute, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.FindTargetAttribute(hasAttribute, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 111511, 111584);
                    return return_v;
                }


                bool
                f_415_111612_111626_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 111612, 111626);
                    return return_v;
                }


                int
                f_415_111599_111655(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 111599, 111655);
                    return 0;
                }


                bool
                f_415_111676_111690_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 111676, 111690);
                    return return_v;
                }


                bool
                f_415_111803_111886(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.CustomAttributeHandle
                handle, out byte
                value, Microsoft.CodeAnalysis.PEModule.AttributeValueExtractor<byte>
                valueExtractor)
                {
                    var return_v = this_param.TryExtractValueFromAttribute<byte>(handle, out value, valueExtractor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 111803, 111886);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 111388, 111898);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 111388, 111898);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool HasNullableAttribute(EntityHandle token, out byte defaultTransform, out ImmutableArray<byte> nullableTransforms)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 111910, 112750);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 112061, 112149);

                AttributeInfo
                info = f_415_112082_112148(this, token, AttributeDescription.NullableAttribute)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 112163, 112248);

                f_415_112163_112247(f_415_112176_112190_M(!info.HasValue) || (DynAbs.Tracing.TraceSender.Expression_False(415, 112176, 112218) || info.SignatureIndex == 0) || (DynAbs.Tracing.TraceSender.Expression_False(415, 112176, 112246) || info.SignatureIndex == 1));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 112264, 112285);

                defaultTransform = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 112299, 112350);

                nullableTransforms = default(ImmutableArray<byte>);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 112366, 112446) || true) && (f_415_112370_112384_M(!info.HasValue))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 112366, 112446);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 112418, 112431);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(415, 112366, 112446);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 112462, 112641) || true) && (info.SignatureIndex == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 112462, 112641);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 112524, 112626);

                    return f_415_112531_112625(this, info.Handle, out defaultTransform, s_attributeByteValueExtractor);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(415, 112462, 112641);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 112657, 112739);

                return f_415_112664_112738(this, info.Handle, out nullableTransforms);
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 111910, 112750);

                Microsoft.CodeAnalysis.PEModule.AttributeInfo
                f_415_112082_112148(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.EntityHandle
                hasAttribute, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.FindTargetAttribute(hasAttribute, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 112082, 112148);
                    return return_v;
                }


                bool
                f_415_112176_112190_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 112176, 112190);
                    return return_v;
                }


                int
                f_415_112163_112247(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 112163, 112247);
                    return 0;
                }


                bool
                f_415_112370_112384_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 112370, 112384);
                    return return_v;
                }


                bool
                f_415_112531_112625(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.CustomAttributeHandle
                handle, out byte
                value, Microsoft.CodeAnalysis.PEModule.AttributeValueExtractor<byte>
                valueExtractor)
                {
                    var return_v = this_param.TryExtractValueFromAttribute<byte>(handle, out value, valueExtractor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 112531, 112625);
                    return return_v;
                }


                bool
                f_415_112664_112738(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.CustomAttributeHandle
                handle, out System.Collections.Immutable.ImmutableArray<byte>
                value)
                {
                    var return_v = this_param.TryExtractByteArrayValueFromAttribute(handle, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 112664, 112738);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 111910, 112750);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 111910, 112750);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal BlobReader GetTypeSpecificationSignatureReaderOrThrow(TypeSpecificationHandle typeSpec)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 112922, 113310);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 113104, 113183);

                BlobHandle
                signature = f_415_113127_113172(f_415_113127_113141(), typeSpec).Signature
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 113252, 113299);

                return f_415_113259_113298(f_415_113259_113273(), signature);
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 112922, 113310);

                System.Reflection.Metadata.MetadataReader
                f_415_113127_113141()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 113127, 113141);
                    return return_v;
                }


                System.Reflection.Metadata.TypeSpecification
                f_415_113127_113172(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.TypeSpecificationHandle
                handle)
                {
                    var return_v = this_param.GetTypeSpecification(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 113127, 113172);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_415_113259_113273()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 113259, 113273);
                    return return_v;
                }


                System.Reflection.Metadata.BlobReader
                f_415_113259_113298(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.BlobHandle
                handle)
                {
                    var return_v = this_param.GetBlobReader(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 113259, 113298);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 112922, 113310);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 112922, 113310);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void GetMethodSpecificationOrThrow(MethodSpecificationHandle handle, out EntityHandle method, out BlobHandle instantiation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 113484, 113807);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 113641, 113704);

                var
                methodSpec = f_415_113658_113703(f_415_113658_113672(), handle)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 113718, 113745);

                method = methodSpec.Method;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 113759, 113796);

                instantiation = methodSpec.Signature;
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 113484, 113807);

                System.Reflection.Metadata.MetadataReader
                f_415_113658_113672()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 113658, 113672);
                    return return_v;
                }


                System.Reflection.Metadata.MethodSpecification
                f_415_113658_113703(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.MethodSpecificationHandle
                handle)
                {
                    var return_v = this_param.GetMethodSpecification(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 113658, 113703);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 113484, 113807);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 113484, 113807);
            }
        }

        internal void GetGenericParamPropsOrThrow(
                    GenericParameterHandle handle,
                    out string name,
                    out GenericParameterAttributes flags)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 113983, 114345);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 114175, 114241);

                GenericParameter
                row = f_415_114198_114240(f_415_114198_114212(), handle)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 114255, 114297);

                name = f_415_114262_114296(f_415_114262_114276(), row.Name);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 114311, 114334);

                flags = row.Attributes;
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 113983, 114345);

                System.Reflection.Metadata.MetadataReader
                f_415_114198_114212()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 114198, 114212);
                    return return_v;
                }


                System.Reflection.Metadata.GenericParameter
                f_415_114198_114240(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.GenericParameterHandle
                handle)
                {
                    var return_v = this_param.GetGenericParameter(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 114198, 114240);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_415_114262_114276()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 114262, 114276);
                    return return_v;
                }


                string
                f_415_114262_114296(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.StringHandle
                handle)
                {
                    var return_v = this_param.GetString(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 114262, 114296);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 113983, 114345);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 113983, 114345);
            }
        }

        internal string GetMethodDefNameOrThrow(MethodDefinitionHandle methodDef)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 114518, 114711);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 114616, 114700);

                return f_415_114623_114699(f_415_114623_114637(), f_415_114648_114693(f_415_114648_114662(), methodDef).Name);
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 114518, 114711);

                System.Reflection.Metadata.MetadataReader
                f_415_114623_114637()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 114623, 114637);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_415_114648_114662()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 114648, 114662);
                    return return_v;
                }


                System.Reflection.Metadata.MethodDefinition
                f_415_114648_114693(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.MethodDefinitionHandle
                handle)
                {
                    var return_v = this_param.GetMethodDefinition(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 114648, 114693);
                    return return_v;
                }


                string
                f_415_114623_114699(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.StringHandle
                handle)
                {
                    var return_v = this_param.GetString(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 114623, 114699);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 114518, 114711);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 114518, 114711);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal BlobHandle GetMethodSignatureOrThrow(MethodDefinitionHandle methodDef)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 114825, 115000);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 114929, 114989);

                return f_415_114936_114988(f_415_114962_114976(), methodDef);
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 114825, 115000);

                System.Reflection.Metadata.MetadataReader
                f_415_114962_114976()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 114962, 114976);
                    return return_v;
                }


                System.Reflection.Metadata.BlobHandle
                f_415_114936_114988(System.Reflection.Metadata.MetadataReader
                metadataReader, System.Reflection.Metadata.MethodDefinitionHandle
                methodDef)
                {
                    var return_v = GetMethodSignatureOrThrow(metadataReader, methodDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 114936, 114988);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 114825, 115000);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 114825, 115000);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static BlobHandle GetMethodSignatureOrThrow(MetadataReader metadataReader, MethodDefinitionHandle methodDef)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(415, 115114, 115329);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 115255, 115318);

                return f_415_115262_115307(metadataReader, methodDef).Signature;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(415, 115114, 115329);

                System.Reflection.Metadata.MethodDefinition
                f_415_115262_115307(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.MethodDefinitionHandle
                handle)
                {
                    var return_v = this_param.GetMethodDefinition(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 115262, 115307);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 115114, 115329);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 115114, 115329);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal BlobHandle GetMethodSignatureOrThrow(EntityHandle methodDefOrRef)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 115443, 115618);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 115542, 115607);

                return f_415_115549_115606(f_415_115575_115589(), methodDefOrRef);
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 115443, 115618);

                System.Reflection.Metadata.MetadataReader
                f_415_115575_115589()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 115575, 115589);
                    return return_v;
                }


                System.Reflection.Metadata.BlobHandle
                f_415_115549_115606(System.Reflection.Metadata.MetadataReader
                metadataReader, System.Reflection.Metadata.EntityHandle
                methodDefOrRef)
                {
                    var return_v = GetMethodSignatureOrThrow(metadataReader, methodDefOrRef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 115549, 115606);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 115443, 115618);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 115443, 115618);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static BlobHandle GetMethodSignatureOrThrow(MetadataReader metadataReader, EntityHandle methodDefOrRef)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(415, 115732, 116367);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 115868, 116356);

                switch (methodDefOrRef.Kind)
                {

                    case HandleKind.MethodDefinition:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 115868, 116356);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 115984, 116073);

                        return f_415_115991_116072(metadataReader, methodDefOrRef);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 115868, 116356);

                    case HandleKind.MemberReference:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 115868, 116356);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 116147, 116229);

                        return f_415_116154_116228(metadataReader, methodDefOrRef);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 115868, 116356);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 115868, 116356);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 116279, 116341);

                        throw f_415_116285_116340(methodDefOrRef.Kind);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 115868, 116356);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(415, 115732, 116367);

                System.Reflection.Metadata.BlobHandle
                f_415_115991_116072(System.Reflection.Metadata.MetadataReader
                metadataReader, System.Reflection.Metadata.EntityHandle
                methodDef)
                {
                    var return_v = GetMethodSignatureOrThrow(metadataReader, (System.Reflection.Metadata.MethodDefinitionHandle)methodDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 115991, 116072);
                    return return_v;
                }


                System.Reflection.Metadata.BlobHandle
                f_415_116154_116228(System.Reflection.Metadata.MetadataReader
                metadataReader, System.Reflection.Metadata.EntityHandle
                memberRef)
                {
                    var return_v = GetSignatureOrThrow(metadataReader, (System.Reflection.Metadata.MemberReferenceHandle)memberRef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 116154, 116228);
                    return return_v;
                }


                System.Exception
                f_415_116285_116340(System.Reflection.Metadata.HandleKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 116285, 116340);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 115732, 116367);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 115732, 116367);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public MethodAttributes GetMethodDefFlagsOrThrow(MethodDefinitionHandle methodDef)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 116481, 116663);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 116588, 116652);

                return f_415_116595_116640(f_415_116595_116609(), methodDef).Attributes;
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 116481, 116663);

                System.Reflection.Metadata.MetadataReader
                f_415_116595_116609()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 116595, 116609);
                    return return_v;
                }


                System.Reflection.Metadata.MethodDefinition
                f_415_116595_116640(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.MethodDefinitionHandle
                handle)
                {
                    var return_v = this_param.GetMethodDefinition(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 116595, 116640);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 116481, 116663);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 116481, 116663);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal TypeDefinitionHandle FindContainingTypeOrThrow(MethodDefinitionHandle methodDef)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 116777, 116974);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 116891, 116963);

                return f_415_116898_116943(f_415_116898_116912(), methodDef).GetDeclaringType();
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 116777, 116974);

                System.Reflection.Metadata.MetadataReader
                f_415_116898_116912()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 116898, 116912);
                    return return_v;
                }


                System.Reflection.Metadata.MethodDefinition
                f_415_116898_116943(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.MethodDefinitionHandle
                handle)
                {
                    var return_v = this_param.GetMethodDefinition(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 116898, 116943);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 116777, 116974);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 116777, 116974);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal TypeDefinitionHandle FindContainingTypeOrThrow(FieldDefinitionHandle fieldDef)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 117088, 117281);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 117200, 117270);

                return f_415_117207_117250(f_415_117207_117221(), fieldDef).GetDeclaringType();
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 117088, 117281);

                System.Reflection.Metadata.MetadataReader
                f_415_117207_117221()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 117207, 117221);
                    return return_v;
                }


                System.Reflection.Metadata.FieldDefinition
                f_415_117207_117250(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.FieldDefinitionHandle
                handle)
                {
                    var return_v = this_param.GetFieldDefinition(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 117207, 117250);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 117088, 117281);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 117088, 117281);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal EntityHandle GetContainingTypeOrThrow(MemberReferenceHandle memberRef)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 117395, 117569);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 117499, 117558);

                return f_415_117506_117550(f_415_117506_117520(), memberRef).Parent;
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 117395, 117569);

                System.Reflection.Metadata.MetadataReader
                f_415_117506_117520()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 117506, 117520);
                    return return_v;
                }


                System.Reflection.Metadata.MemberReference
                f_415_117506_117550(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.MemberReferenceHandle
                handle)
                {
                    var return_v = this_param.GetMemberReference(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 117506, 117550);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 117395, 117569);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 117395, 117569);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void GetMethodDefPropsOrThrow(
                    MethodDefinitionHandle methodDef,
                    out string name,
                    out MethodImplAttributes implFlags,
                    out MethodAttributes flags,
                    out int rva)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 117683, 118270);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 117938, 118013);

                MethodDefinition
                methodRow = f_415_117967_118012(f_415_117967_117981(), methodDef)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 118027, 118075);

                name = f_415_118034_118074(f_415_118034_118048(), methodRow.Name);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 118089, 118126);

                implFlags = methodRow.ImplAttributes;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 118140, 118169);

                flags = methodRow.Attributes;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 118183, 118222);

                rva = methodRow.RelativeVirtualAddress;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 118236, 118259);

                f_415_118236_118258(rva >= 0);
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 117683, 118270);

                System.Reflection.Metadata.MetadataReader
                f_415_117967_117981()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 117967, 117981);
                    return return_v;
                }


                System.Reflection.Metadata.MethodDefinition
                f_415_117967_118012(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.MethodDefinitionHandle
                handle)
                {
                    var return_v = this_param.GetMethodDefinition(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 117967, 118012);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_415_118034_118048()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 118034, 118048);
                    return return_v;
                }


                string
                f_415_118034_118074(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.StringHandle
                handle)
                {
                    var return_v = this_param.GetString(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 118034, 118074);
                    return return_v;
                }


                int
                f_415_118236_118258(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 118236, 118258);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 117683, 118270);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 117683, 118270);
            }
        }

        internal void GetMethodImplPropsOrThrow(
                    MethodImplementationHandle methodImpl,
                    out EntityHandle body,
                    out EntityHandle declaration)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 118384, 118741);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 118580, 118642);

                var
                impl = f_415_118591_118641(f_415_118591_118605(), methodImpl)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 118656, 118679);

                body = impl.MethodBody;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 118693, 118730);

                declaration = impl.MethodDeclaration;
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 118384, 118741);

                System.Reflection.Metadata.MetadataReader
                f_415_118591_118605()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 118591, 118605);
                    return return_v;
                }


                System.Reflection.Metadata.MethodImplementation
                f_415_118591_118641(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.MethodImplementationHandle
                handle)
                {
                    var return_v = this_param.GetMethodImplementation(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 118591, 118641);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 118384, 118741);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 118384, 118741);
            }
        }

        internal GenericParameterHandleCollection GetGenericParametersForMethodOrThrow(MethodDefinitionHandle methodDef)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 118855, 119079);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 118992, 119068);

                return f_415_118999_119044(f_415_118999_119013(), methodDef).GetGenericParameters();
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 118855, 119079);

                System.Reflection.Metadata.MetadataReader
                f_415_118999_119013()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 118999, 119013);
                    return return_v;
                }


                System.Reflection.Metadata.MethodDefinition
                f_415_118999_119044(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.MethodDefinitionHandle
                handle)
                {
                    var return_v = this_param.GetMethodDefinition(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 118999, 119044);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 118855, 119079);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 118855, 119079);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ParameterHandleCollection GetParametersOfMethodOrThrow(MethodDefinitionHandle methodDef)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 119193, 119395);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 119315, 119384);

                return f_415_119322_119367(f_415_119322_119336(), methodDef).GetParameters();
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 119193, 119395);

                System.Reflection.Metadata.MetadataReader
                f_415_119322_119336()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 119322, 119336);
                    return return_v;
                }


                System.Reflection.Metadata.MethodDefinition
                f_415_119322_119367(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.MethodDefinitionHandle
                handle)
                {
                    var return_v = this_param.GetMethodDefinition(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 119322, 119367);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 119193, 119395);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 119193, 119395);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal DllImportData GetDllImportData(MethodDefinitionHandle methodDef)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 119407, 120272);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 119541, 119618);

                    var
                    methodImport = f_415_119560_119605(f_415_119560_119574(), methodDef).GetImport()
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 119636, 119793) || true) && (methodImport.Module.IsNil)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 119636, 119793);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 119762, 119774);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 119636, 119793);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 119813, 119878);

                    string
                    moduleName = f_415_119833_119877(this, methodImport.Module)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 119896, 119964);

                    string
                    entryPointName = f_415_119920_119963(f_415_119920_119934(), methodImport.Name)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 119982, 120061);

                    MethodImportAttributes
                    flags = (MethodImportAttributes)methodImport.Attributes
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 120081, 120141);

                    return f_415_120088_120140(moduleName, entryPointName, flags);
                }
                catch (BadImageFormatException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(415, 120170, 120261);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 120234, 120246);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(415, 120170, 120261);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 119407, 120272);

                System.Reflection.Metadata.MetadataReader
                f_415_119560_119574()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 119560, 119574);
                    return return_v;
                }


                System.Reflection.Metadata.MethodDefinition
                f_415_119560_119605(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.MethodDefinitionHandle
                handle)
                {
                    var return_v = this_param.GetMethodDefinition(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 119560, 119605);
                    return return_v;
                }


                string
                f_415_119833_119877(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.ModuleReferenceHandle
                moduleRef)
                {
                    var return_v = this_param.GetModuleRefNameOrThrow(moduleRef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 119833, 119877);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_415_119920_119934()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 119920, 119934);
                    return return_v;
                }


                string
                f_415_119920_119963(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.StringHandle
                handle)
                {
                    var return_v = this_param.GetString(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 119920, 119963);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DllImportData
                f_415_120088_120140(string
                moduleName, string
                entryPointName, System.Reflection.MethodImportAttributes
                flags)
                {
                    var return_v = new Microsoft.CodeAnalysis.DllImportData(moduleName, entryPointName, flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 120088, 120140);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 119407, 120272);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 119407, 120272);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public string GetMemberRefNameOrThrow(MemberReferenceHandle memberRef)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 120445, 120609);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 120540, 120598);

                return f_415_120547_120597(f_415_120571_120585(), memberRef);
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 120445, 120609);

                System.Reflection.Metadata.MetadataReader
                f_415_120571_120585()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 120571, 120585);
                    return return_v;
                }


                string
                f_415_120547_120597(System.Reflection.Metadata.MetadataReader
                metadataReader, System.Reflection.Metadata.MemberReferenceHandle
                memberRef)
                {
                    var return_v = GetMemberRefNameOrThrow(metadataReader, memberRef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 120547, 120597);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 120445, 120609);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 120445, 120609);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string GetMemberRefNameOrThrow(MetadataReader metadataReader, MemberReferenceHandle memberRef)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(415, 120723, 120951);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 120857, 120940);

                return f_415_120864_120939(metadataReader, f_415_120889_120933(metadataReader, memberRef).Name);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(415, 120723, 120951);

                System.Reflection.Metadata.MemberReference
                f_415_120889_120933(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.MemberReferenceHandle
                handle)
                {
                    var return_v = this_param.GetMemberReference(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 120889, 120933);
                    return return_v;
                }


                string
                f_415_120864_120939(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.StringHandle
                handle)
                {
                    var return_v = this_param.GetString(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 120864, 120939);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 120723, 120951);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 120723, 120951);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal BlobHandle GetSignatureOrThrow(MemberReferenceHandle memberRef)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 121065, 121227);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 121162, 121216);

                return f_415_121169_121215(f_415_121189_121203(), memberRef);
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 121065, 121227);

                System.Reflection.Metadata.MetadataReader
                f_415_121189_121203()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 121189, 121203);
                    return return_v;
                }


                System.Reflection.Metadata.BlobHandle
                f_415_121169_121215(System.Reflection.Metadata.MetadataReader
                metadataReader, System.Reflection.Metadata.MemberReferenceHandle
                memberRef)
                {
                    var return_v = GetSignatureOrThrow(metadataReader, memberRef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 121169, 121215);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 121065, 121227);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 121065, 121227);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static BlobHandle GetSignatureOrThrow(MetadataReader metadataReader, MemberReferenceHandle memberRef)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(415, 121341, 121548);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 121475, 121537);

                return f_415_121482_121526(metadataReader, memberRef).Signature;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(415, 121341, 121548);

                System.Reflection.Metadata.MemberReference
                f_415_121482_121526(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.MemberReferenceHandle
                handle)
                {
                    var return_v = this_param.GetMemberReference(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 121482, 121526);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 121341, 121548);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 121341, 121548);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void GetMemberRefPropsOrThrow(
                    MemberReferenceHandle memberRef,
                    out EntityHandle @class,
                    out string name,
                    out byte[] signature)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 121662, 122110);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 121873, 121940);

                MemberReference
                row = f_415_121895_121939(f_415_121895_121909(), memberRef)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 121954, 121974);

                @class = row.Parent;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 121988, 122030);

                name = f_415_121995_122029(f_415_121995_122009(), row.Name);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 122044, 122099);

                signature = f_415_122056_122098(f_415_122056_122070(), row.Signature);
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 121662, 122110);

                System.Reflection.Metadata.MetadataReader
                f_415_121895_121909()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 121895, 121909);
                    return return_v;
                }


                System.Reflection.Metadata.MemberReference
                f_415_121895_121939(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.MemberReferenceHandle
                handle)
                {
                    var return_v = this_param.GetMemberReference(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 121895, 121939);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_415_121995_122009()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 121995, 122009);
                    return return_v;
                }


                string
                f_415_121995_122029(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.StringHandle
                handle)
                {
                    var return_v = this_param.GetString(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 121995, 122029);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_415_122056_122070()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 122056, 122070);
                    return return_v;
                }


                byte[]
                f_415_122056_122098(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.BlobHandle
                handle)
                {
                    var return_v = this_param.GetBlobBytes(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 122056, 122098);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 121662, 122110);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 121662, 122110);
            }
        }

        internal void GetParamPropsOrThrow(
                    ParameterHandle parameterDef,
                    out string name,
                    out ParameterAttributes flags)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 122300, 122657);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 122477, 122541);

                Parameter
                parameter = f_415_122499_122540(f_415_122499_122513(), parameterDef)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 122555, 122603);

                name = f_415_122562_122602(f_415_122562_122576(), parameter.Name);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 122617, 122646);

                flags = parameter.Attributes;
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 122300, 122657);

                System.Reflection.Metadata.MetadataReader
                f_415_122499_122513()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 122499, 122513);
                    return return_v;
                }


                System.Reflection.Metadata.Parameter
                f_415_122499_122540(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.ParameterHandle
                handle)
                {
                    var return_v = this_param.GetParameter(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 122499, 122540);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_415_122562_122576()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 122562, 122576);
                    return return_v;
                }


                string
                f_415_122562_122602(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.StringHandle
                handle)
                {
                    var return_v = this_param.GetString(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 122562, 122602);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 122300, 122657);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 122300, 122657);
            }
        }

        internal string GetParamNameOrThrow(ParameterHandle parameterDef)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 122771, 122998);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 122861, 122925);

                Parameter
                parameter = f_415_122883_122924(f_415_122883_122897(), parameterDef)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 122939, 122987);

                return f_415_122946_122986(f_415_122946_122960(), parameter.Name);
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 122771, 122998);

                System.Reflection.Metadata.MetadataReader
                f_415_122883_122897()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 122883, 122897);
                    return return_v;
                }


                System.Reflection.Metadata.Parameter
                f_415_122883_122924(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.ParameterHandle
                handle)
                {
                    var return_v = this_param.GetParameter(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 122883, 122924);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_415_122946_122960()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 122946, 122960);
                    return return_v;
                }


                string
                f_415_122946_122986(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.StringHandle
                handle)
                {
                    var return_v = this_param.GetString(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 122946, 122986);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 122771, 122998);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 122771, 122998);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal int GetParameterSequenceNumberOrThrow(ParameterHandle param)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 123112, 123274);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 123206, 123263);

                return f_415_123213_123247(f_415_123213_123227(), param).SequenceNumber;
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 123112, 123274);

                System.Reflection.Metadata.MetadataReader
                f_415_123213_123227()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 123213, 123227);
                    return return_v;
                }


                System.Reflection.Metadata.Parameter
                f_415_123213_123247(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.ParameterHandle
                handle)
                {
                    var return_v = this_param.GetParameter(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 123213, 123247);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 123112, 123274);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 123112, 123274);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string GetPropertyDefNameOrThrow(PropertyDefinitionHandle propertyDef)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 123449, 123652);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 123553, 123641);

                return f_415_123560_123640(f_415_123560_123574(), f_415_123585_123634(f_415_123585_123599(), propertyDef).Name);
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 123449, 123652);

                System.Reflection.Metadata.MetadataReader
                f_415_123560_123574()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 123560, 123574);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_415_123585_123599()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 123585, 123599);
                    return return_v;
                }


                System.Reflection.Metadata.PropertyDefinition
                f_415_123585_123634(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.PropertyDefinitionHandle
                handle)
                {
                    var return_v = this_param.GetPropertyDefinition(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 123585, 123634);
                    return return_v;
                }


                string
                f_415_123560_123640(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.StringHandle
                handle)
                {
                    var return_v = this_param.GetString(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 123560, 123640);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 123449, 123652);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 123449, 123652);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal BlobHandle GetPropertySignatureOrThrow(PropertyDefinitionHandle propertyDef)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 123766, 123954);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 123876, 123943);

                return f_415_123883_123932(f_415_123883_123897(), propertyDef).Signature;
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 123766, 123954);

                System.Reflection.Metadata.MetadataReader
                f_415_123883_123897()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 123883, 123897);
                    return return_v;
                }


                System.Reflection.Metadata.PropertyDefinition
                f_415_123883_123932(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.PropertyDefinitionHandle
                handle)
                {
                    var return_v = this_param.GetPropertyDefinition(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 123883, 123932);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 123766, 123954);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 123766, 123954);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void GetPropertyDefPropsOrThrow(
                    PropertyDefinitionHandle propertyDef,
                    out string name,
                    out PropertyAttributes flags)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 124068, 124452);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 124258, 124338);

                PropertyDefinition
                property = f_415_124288_124337(f_415_124288_124302(), propertyDef)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 124352, 124399);

                name = f_415_124359_124398(f_415_124359_124373(), property.Name);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 124413, 124441);

                flags = property.Attributes;
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 124068, 124452);

                System.Reflection.Metadata.MetadataReader
                f_415_124288_124302()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 124288, 124302);
                    return return_v;
                }


                System.Reflection.Metadata.PropertyDefinition
                f_415_124288_124337(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.PropertyDefinitionHandle
                handle)
                {
                    var return_v = this_param.GetPropertyDefinition(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 124288, 124337);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_415_124359_124373()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 124359, 124373);
                    return return_v;
                }


                string
                f_415_124359_124398(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.StringHandle
                handle)
                {
                    var return_v = this_param.GetString(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 124359, 124398);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 124068, 124452);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 124068, 124452);
            }
        }

        internal string GetEventDefNameOrThrow(EventDefinitionHandle eventDef)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 124624, 124812);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 124719, 124801);

                return f_415_124726_124800(f_415_124726_124740(), f_415_124751_124794(f_415_124751_124765(), eventDef).Name);
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 124624, 124812);

                System.Reflection.Metadata.MetadataReader
                f_415_124726_124740()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 124726, 124740);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_415_124751_124765()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 124751, 124765);
                    return return_v;
                }


                System.Reflection.Metadata.EventDefinition
                f_415_124751_124794(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.EventDefinitionHandle
                handle)
                {
                    var return_v = this_param.GetEventDefinition(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 124751, 124794);
                    return return_v;
                }


                string
                f_415_124726_124800(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.StringHandle
                handle)
                {
                    var return_v = this_param.GetString(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 124726, 124800);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 124624, 124812);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 124624, 124812);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void GetEventDefPropsOrThrow(
                    EventDefinitionHandle eventDef,
                    out string name,
                    out EventAttributes flags,
                    out EntityHandle type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 124926, 125360);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 125140, 125211);

                EventDefinition
                eventRow = f_415_125167_125210(f_415_125167_125181(), eventDef)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 125225, 125272);

                name = f_415_125232_125271(f_415_125232_125246(), eventRow.Name);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 125286, 125314);

                flags = eventRow.Attributes;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 125328, 125349);

                type = eventRow.Type;
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 124926, 125360);

                System.Reflection.Metadata.MetadataReader
                f_415_125167_125181()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 125167, 125181);
                    return return_v;
                }


                System.Reflection.Metadata.EventDefinition
                f_415_125167_125210(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.EventDefinitionHandle
                handle)
                {
                    var return_v = this_param.GetEventDefinition(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 125167, 125210);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_415_125232_125246()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 125232, 125246);
                    return return_v;
                }


                string
                f_415_125232_125271(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.StringHandle
                handle)
                {
                    var return_v = this_param.GetString(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 125232, 125271);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 124926, 125360);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 124926, 125360);
            }
        }

        public string GetFieldDefNameOrThrow(FieldDefinitionHandle fieldDef)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 125532, 125718);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 125625, 125707);

                return f_415_125632_125706(f_415_125632_125646(), f_415_125657_125700(f_415_125657_125671(), fieldDef).Name);
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 125532, 125718);

                System.Reflection.Metadata.MetadataReader
                f_415_125632_125646()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 125632, 125646);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_415_125657_125671()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 125657, 125671);
                    return return_v;
                }


                System.Reflection.Metadata.FieldDefinition
                f_415_125657_125700(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.FieldDefinitionHandle
                handle)
                {
                    var return_v = this_param.GetFieldDefinition(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 125657, 125700);
                    return return_v;
                }


                string
                f_415_125632_125706(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.StringHandle
                handle)
                {
                    var return_v = this_param.GetString(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 125632, 125706);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 125532, 125718);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 125532, 125718);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal BlobHandle GetFieldSignatureOrThrow(FieldDefinitionHandle fieldDef)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 125832, 126005);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 125933, 125994);

                return f_415_125940_125983(f_415_125940_125954(), fieldDef).Signature;
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 125832, 126005);

                System.Reflection.Metadata.MetadataReader
                f_415_125940_125954()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 125940, 125954);
                    return return_v;
                }


                System.Reflection.Metadata.FieldDefinition
                f_415_125940_125983(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.FieldDefinitionHandle
                handle)
                {
                    var return_v = this_param.GetFieldDefinition(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 125940, 125983);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 125832, 126005);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 125832, 126005);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public FieldAttributes GetFieldDefFlagsOrThrow(FieldDefinitionHandle fieldDef)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 126119, 126295);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 126222, 126284);

                return f_415_126229_126272(f_415_126229_126243(), fieldDef).Attributes;
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 126119, 126295);

                System.Reflection.Metadata.MetadataReader
                f_415_126229_126243()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 126229, 126243);
                    return return_v;
                }


                System.Reflection.Metadata.FieldDefinition
                f_415_126229_126272(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.FieldDefinitionHandle
                handle)
                {
                    var return_v = this_param.GetFieldDefinition(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 126229, 126272);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 126119, 126295);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 126119, 126295);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void GetFieldDefPropsOrThrow(
                    FieldDefinitionHandle fieldDef,
                    out string name,
                    out FieldAttributes flags)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 126409, 126772);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 126585, 126656);

                FieldDefinition
                fieldRow = f_415_126612_126655(f_415_126612_126626(), fieldDef)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 126672, 126719);

                name = f_415_126679_126718(f_415_126679_126693(), fieldRow.Name);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 126733, 126761);

                flags = fieldRow.Attributes;
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 126409, 126772);

                System.Reflection.Metadata.MetadataReader
                f_415_126612_126626()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 126612, 126626);
                    return return_v;
                }


                System.Reflection.Metadata.FieldDefinition
                f_415_126612_126655(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.FieldDefinitionHandle
                handle)
                {
                    var return_v = this_param.GetFieldDefinition(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 126612, 126655);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_415_126679_126693()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 126679, 126693);
                    return return_v;
                }


                string
                f_415_126679_126718(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.StringHandle
                handle)
                {
                    var return_v = this_param.GetString(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 126679, 126718);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 126409, 126772);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 126409, 126772);
            }
        }

        internal ConstantValue GetParamDefaultValue(ParameterHandle param)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 126784, 127374);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 126875, 126902);

                f_415_126875_126901(f_415_126888_126900_M(!param.IsNil));

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 126954, 127028);

                    var
                    constantHandle = f_415_126975_127009(f_415_126975_126989(), param).GetDefaultValue()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 127140, 127230);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(415, 127147, 127167) || ((constantHandle.IsNil && DynAbs.Tracing.TraceSender.Conditional_F2(415, 127170, 127187)) || DynAbs.Tracing.TraceSender.Conditional_F3(415, 127190, 127229))) ? f_415_127170_127187() : f_415_127190_127229(this, constantHandle);
                }
                catch (BadImageFormatException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(415, 127259, 127363);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 127323, 127348);

                    return f_415_127330_127347();
                    DynAbs.Tracing.TraceSender.TraceExitCatch(415, 127259, 127363);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 126784, 127374);

                bool
                f_415_126888_126900_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 126888, 126900);
                    return return_v;
                }


                int
                f_415_126875_126901(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 126875, 126901);
                    return 0;
                }


                System.Reflection.Metadata.MetadataReader
                f_415_126975_126989()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 126975, 126989);
                    return return_v;
                }


                System.Reflection.Metadata.Parameter
                f_415_126975_127009(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.ParameterHandle
                handle)
                {
                    var return_v = this_param.GetParameter(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 126975, 127009);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_415_127170_127187()
                {
                    var return_v = ConstantValue.Bad;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 127170, 127187);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_415_127190_127229(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.ConstantHandle
                handle)
                {
                    var return_v = this_param.GetConstantValueOrThrow(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 127190, 127229);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_415_127330_127347()
                {
                    var return_v = ConstantValue.Bad;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 127330, 127347);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 126784, 127374);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 126784, 127374);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ConstantValue GetConstantFieldValue(FieldDefinitionHandle fieldDef)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 127386, 127998);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 127487, 127517);

                f_415_127487_127516(f_415_127500_127515_M(!fieldDef.IsNil));

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 127569, 127652);

                    var
                    constantHandle = f_415_127590_127633(f_415_127590_127604(), fieldDef).GetDefaultValue()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 127764, 127854);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(415, 127771, 127791) || ((constantHandle.IsNil && DynAbs.Tracing.TraceSender.Conditional_F2(415, 127794, 127811)) || DynAbs.Tracing.TraceSender.Conditional_F3(415, 127814, 127853))) ? f_415_127794_127811() : f_415_127814_127853(this, constantHandle);
                }
                catch (BadImageFormatException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(415, 127883, 127987);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 127947, 127972);

                    return f_415_127954_127971();
                    DynAbs.Tracing.TraceSender.TraceExitCatch(415, 127883, 127987);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 127386, 127998);

                bool
                f_415_127500_127515_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 127500, 127515);
                    return return_v;
                }


                int
                f_415_127487_127516(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 127487, 127516);
                    return 0;
                }


                System.Reflection.Metadata.MetadataReader
                f_415_127590_127604()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 127590, 127604);
                    return return_v;
                }


                System.Reflection.Metadata.FieldDefinition
                f_415_127590_127633(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.FieldDefinitionHandle
                handle)
                {
                    var return_v = this_param.GetFieldDefinition(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 127590, 127633);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_415_127794_127811()
                {
                    var return_v = ConstantValue.Bad;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 127794, 127811);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_415_127814_127853(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.ConstantHandle
                handle)
                {
                    var return_v = this_param.GetConstantValueOrThrow(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 127814, 127853);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_415_127954_127971()
                {
                    var return_v = ConstantValue.Bad;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 127954, 127971);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 127386, 127998);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 127386, 127998);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CustomAttributeHandleCollection GetCustomAttributesOrThrow(EntityHandle handle)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 128171, 128343);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 128282, 128332);

                return f_415_128289_128331(f_415_128289_128303(), handle);
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 128171, 128343);

                System.Reflection.Metadata.MetadataReader
                f_415_128289_128303()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 128289, 128303);
                    return return_v;
                }


                System.Reflection.Metadata.CustomAttributeHandleCollection
                f_415_128289_128331(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.EntityHandle
                handle)
                {
                    var return_v = this_param.GetCustomAttributes(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 128289, 128331);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 128171, 128343);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 128171, 128343);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BlobHandle GetCustomAttributeValueOrThrow(CustomAttributeHandle handle)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 128457, 128626);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 128560, 128615);

                return f_415_128567_128608(f_415_128567_128581(), handle).Value;
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 128457, 128626);

                System.Reflection.Metadata.MetadataReader
                f_415_128567_128581()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 128567, 128581);
                    return return_v;
                }


                System.Reflection.Metadata.CustomAttribute
                f_415_128567_128608(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.CustomAttributeHandle
                handle)
                {
                    var return_v = this_param.GetCustomAttribute(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 128567, 128608);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 128457, 128626);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 128457, 128626);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BlobHandle GetMarshallingDescriptorHandleOrThrow(EntityHandle fieldOrParameterToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 128762, 129194);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 128879, 129183);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(415, 128886, 128942) || ((fieldOrParameterToken.Kind == HandleKind.FieldDefinition && DynAbs.Tracing.TraceSender.Conditional_F2(415, 128962, 129068)) || DynAbs.Tracing.TraceSender.Conditional_F3(415, 129088, 129182))) ? f_415_128962_129041(f_415_128962_128976(), fieldOrParameterToken).GetMarshallingDescriptor() : f_415_129088_129155(f_415_129088_129102(), fieldOrParameterToken).GetMarshallingDescriptor();
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 128762, 129194);

                System.Reflection.Metadata.MetadataReader
                f_415_128962_128976()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 128962, 128976);
                    return return_v;
                }


                System.Reflection.Metadata.FieldDefinition
                f_415_128962_129041(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.EntityHandle
                handle)
                {
                    var return_v = this_param.GetFieldDefinition((System.Reflection.Metadata.FieldDefinitionHandle)handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 128962, 129041);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_415_129088_129102()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 129088, 129102);
                    return return_v;
                }


                System.Reflection.Metadata.Parameter
                f_415_129088_129155(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.EntityHandle
                handle)
                {
                    var return_v = this_param.GetParameter((System.Reflection.Metadata.ParameterHandle)handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 129088, 129155);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 128762, 129194);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 128762, 129194);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal UnmanagedType GetMarshallingType(EntityHandle fieldOrParameterToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 129206, 129955);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 129344, 129416);

                    var
                    blob = f_415_129355_129415(this, fieldOrParameterToken)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 129436, 129572) || true) && (blob.IsNil)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 129436, 129572);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 129544, 129553);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 129436, 129572);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 129592, 129655);

                    byte
                    firstByte = f_415_129609_129643(f_415_129609_129623(), blob).ReadByte()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 129771, 129827);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(415, 129778, 129795) || ((firstByte <= 0x50 && DynAbs.Tracing.TraceSender.Conditional_F2(415, 129798, 129822)) || DynAbs.Tracing.TraceSender.Conditional_F3(415, 129825, 129826))) ? (UnmanagedType)firstByte : 0;
                }
                catch (BadImageFormatException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(415, 129856, 129944);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 129920, 129929);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(415, 129856, 129944);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 129206, 129955);

                System.Reflection.Metadata.BlobHandle
                f_415_129355_129415(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.EntityHandle
                fieldOrParameterToken)
                {
                    var return_v = this_param.GetMarshallingDescriptorHandleOrThrow(fieldOrParameterToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 129355, 129415);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_415_129609_129623()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 129609, 129623);
                    return return_v;
                }


                System.Reflection.Metadata.BlobReader
                f_415_129609_129643(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.BlobHandle
                handle)
                {
                    var return_v = this_param.GetBlobReader(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 129609, 129643);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 129206, 129955);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 129206, 129955);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ImmutableArray<byte> GetMarshallingDescriptor(EntityHandle fieldOrParameterToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 129967, 130603);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 130118, 130190);

                    var
                    blob = f_415_130129_130189(this, fieldOrParameterToken)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 130208, 130369) || true) && (blob.IsNil)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 130208, 130369);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 130316, 130350);

                        return ImmutableArray<byte>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 130208, 130369);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 130389, 130450);

                    return f_415_130396_130449(f_415_130396_130429(f_415_130396_130410(), blob));
                }
                catch (BadImageFormatException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(415, 130479, 130592);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 130543, 130577);

                    return ImmutableArray<byte>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(415, 130479, 130592);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 129967, 130603);

                System.Reflection.Metadata.BlobHandle
                f_415_130129_130189(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.EntityHandle
                fieldOrParameterToken)
                {
                    var return_v = this_param.GetMarshallingDescriptorHandleOrThrow(fieldOrParameterToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 130129, 130189);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_415_130396_130410()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 130396, 130410);
                    return return_v;
                }


                byte[]
                f_415_130396_130429(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.BlobHandle
                handle)
                {
                    var return_v = this_param.GetBlobBytes(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 130396, 130429);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_415_130396_130449(byte[]
                items)
                {
                    var return_v = items.AsImmutableOrNull<byte>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 130396, 130449);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 129967, 130603);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 129967, 130603);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal int? GetFieldOffset(FieldDefinitionHandle fieldDef)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 130615, 131077);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 130736, 130805);

                    int
                    offset = f_415_130749_130792(f_415_130749_130763(), fieldDef).GetOffset()
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 130823, 130912) || true) && (offset == -1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 130823, 130912);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 130881, 130893);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 130823, 130912);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 130932, 130946);

                    return offset;
                }
                catch (BadImageFormatException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(415, 130975, 131066);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 131039, 131051);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(415, 130975, 131066);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 130615, 131077);

                System.Reflection.Metadata.MetadataReader
                f_415_130749_130763()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 130749, 130763);
                    return return_v;
                }


                System.Reflection.Metadata.FieldDefinition
                f_415_130749_130792(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.FieldDefinitionHandle
                handle)
                {
                    var return_v = this_param.GetFieldDefinition(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 130749, 130792);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 130615, 131077);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 130615, 131077);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ConstantValue GetConstantValueOrThrow(ConstantHandle handle)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 131191, 133621);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 131284, 131337);

                var
                constantRow = f_415_131302_131336(f_415_131302_131316(), handle)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 131351, 131419);

                BlobReader
                reader = f_415_131371_131418(f_415_131371_131385(), constantRow.Value)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 131433, 133569);

                switch (constantRow.TypeCode)
                {

                    case ConstantTypeCode.Boolean:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 131433, 133569);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 131547, 131597);

                        return f_415_131554_131596(reader.ReadBoolean());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 131433, 133569);

                    case ConstantTypeCode.Char:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 131433, 133569);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 131666, 131713);

                        return f_415_131673_131712(reader.ReadChar());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 131433, 133569);

                    case ConstantTypeCode.SByte:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 131433, 133569);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 131783, 131831);

                        return f_415_131790_131830(reader.ReadSByte());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 131433, 133569);

                    case ConstantTypeCode.Int16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 131433, 133569);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 131901, 131949);

                        return f_415_131908_131948(reader.ReadInt16());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 131433, 133569);

                    case ConstantTypeCode.Int32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 131433, 133569);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 132019, 132067);

                        return f_415_132026_132066(reader.ReadInt32());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 131433, 133569);

                    case ConstantTypeCode.Int64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 131433, 133569);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 132137, 132185);

                        return f_415_132144_132184(reader.ReadInt64());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 131433, 133569);

                    case ConstantTypeCode.Byte:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 131433, 133569);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 132254, 132301);

                        return f_415_132261_132300(reader.ReadByte());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 131433, 133569);

                    case ConstantTypeCode.UInt16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 131433, 133569);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 132372, 132421);

                        return f_415_132379_132420(reader.ReadUInt16());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 131433, 133569);

                    case ConstantTypeCode.UInt32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 131433, 133569);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 132492, 132541);

                        return f_415_132499_132540(reader.ReadUInt32());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 131433, 133569);

                    case ConstantTypeCode.UInt64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 131433, 133569);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 132612, 132661);

                        return f_415_132619_132660(reader.ReadUInt64());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 131433, 133569);

                    case ConstantTypeCode.Single:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 131433, 133569);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 132732, 132781);

                        return f_415_132739_132780(reader.ReadSingle());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 131433, 133569);

                    case ConstantTypeCode.Double:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 131433, 133569);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 132852, 132901);

                        return f_415_132859_132900(reader.ReadDouble());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 131433, 133569);

                    case ConstantTypeCode.String:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 131433, 133569);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 132972, 133033);

                        return f_415_132979_133032(reader.ReadUTF16(reader.Length));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 131433, 133569);

                    case ConstantTypeCode.NullReference:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 131433, 133569);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 133397, 133524) || true) && (reader.ReadUInt32() == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 133397, 133524);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 133475, 133501);

                            return f_415_133482_133500();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(415, 133397, 133524);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(415, 133548, 133554);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 131433, 133569);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 133585, 133610);

                return f_415_133592_133609();
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 131191, 133621);

                System.Reflection.Metadata.MetadataReader
                f_415_131302_131316()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 131302, 131316);
                    return return_v;
                }


                System.Reflection.Metadata.Constant
                f_415_131302_131336(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.ConstantHandle
                handle)
                {
                    var return_v = this_param.GetConstant(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 131302, 131336);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_415_131371_131385()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 131371, 131385);
                    return return_v;
                }


                System.Reflection.Metadata.BlobReader
                f_415_131371_131418(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.BlobHandle
                handle)
                {
                    var return_v = this_param.GetBlobReader(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 131371, 131418);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_415_131554_131596(bool
                value)
                {
                    var return_v = ConstantValue.Create(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 131554, 131596);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_415_131673_131712(char
                value)
                {
                    var return_v = ConstantValue.Create(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 131673, 131712);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_415_131790_131830(sbyte
                value)
                {
                    var return_v = ConstantValue.Create(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 131790, 131830);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_415_131908_131948(short
                value)
                {
                    var return_v = ConstantValue.Create(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 131908, 131948);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_415_132026_132066(int
                value)
                {
                    var return_v = ConstantValue.Create(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 132026, 132066);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_415_132144_132184(long
                value)
                {
                    var return_v = ConstantValue.Create(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 132144, 132184);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_415_132261_132300(byte
                value)
                {
                    var return_v = ConstantValue.Create(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 132261, 132300);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_415_132379_132420(ushort
                value)
                {
                    var return_v = ConstantValue.Create(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 132379, 132420);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_415_132499_132540(uint
                value)
                {
                    var return_v = ConstantValue.Create(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 132499, 132540);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_415_132619_132660(ulong
                value)
                {
                    var return_v = ConstantValue.Create(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 132619, 132660);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_415_132739_132780(float
                value)
                {
                    var return_v = ConstantValue.Create(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 132739, 132780);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_415_132859_132900(double
                value)
                {
                    var return_v = ConstantValue.Create(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 132859, 132900);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_415_132979_133032(string
                value)
                {
                    var return_v = ConstantValue.Create(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 132979, 133032);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_415_133482_133500()
                {
                    var return_v = ConstantValue.Null;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 133482, 133500);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_415_133592_133609()
                {
                    var return_v = ConstantValue.Bad;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 133592, 133609);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 131191, 133621);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 131191, 133621);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal (int FirstIndex, int SecondIndex) GetAssemblyRefsForForwardedType(string fullName, bool ignoreCase, out string matchedName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 133633, 135008);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 133790, 133823);

                f_415_133790_133822(this);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 133839, 134907) || true) && (ignoreCase)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 133839, 134907);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 134213, 134545);
                        foreach (var pair in f_415_134234_134271_I(_lazyForwardedTypesToAssemblyIndexMap))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 134213, 134545);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 134313, 134526) || true) && (f_415_134317_134386(pair.Key, fullName, StringComparison.OrdinalIgnoreCase))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 134313, 134526);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 134436, 134459);

                                matchedName = pair.Key;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 134485, 134503);

                                return pair.Value;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(415, 134313, 134526);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(415, 134213, 134545);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(415, 1, 333);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(415, 1, 333);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(415, 133839, 134907);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 133839, 134907);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 134611, 134661);

                    (int FirstIndex, int SecondIndex)
                    assemblyIndices
                    = default((int FirstIndex, int SecondIndex));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 134679, 134892) || true) && (f_415_134683_134763(_lazyForwardedTypesToAssemblyIndexMap, fullName, out assemblyIndices))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 134679, 134892);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 134805, 134828);

                        matchedName = fullName;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 134850, 134873);

                        return assemblyIndices;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 134679, 134892);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(415, 133839, 134907);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 134923, 134942);

                matchedName = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 134956, 134997);

                return (FirstIndex: -1, SecondIndex: -1);
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 133633, 135008);

                int
                f_415_133790_133822(Microsoft.CodeAnalysis.PEModule
                this_param)
                {
                    this_param.EnsureForwardTypeToAssemblyMap();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 133790, 133822);
                    return 0;
                }


                bool
                f_415_134317_134386(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 134317, 134386);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, (int FirstIndex, int SecondIndex)>
                f_415_134234_134271_I(System.Collections.Generic.Dictionary<string, (int FirstIndex, int SecondIndex)>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 134234, 134271);
                    return return_v;
                }


                bool
                f_415_134683_134763(System.Collections.Generic.Dictionary<string, (int FirstIndex, int SecondIndex)>
                this_param, string
                key, out (int FirstIndex, int SecondIndex)
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 134683, 134763);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 133633, 135008);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 133633, 135008);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal IEnumerable<KeyValuePair<string, (int FirstIndex, int SecondIndex)>> GetForwardedTypes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 135020, 135245);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 135142, 135175);

                f_415_135142_135174(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 135189, 135234);

                return _lazyForwardedTypesToAssemblyIndexMap;
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 135020, 135245);

                int
                f_415_135142_135174(Microsoft.CodeAnalysis.PEModule
                this_param)
                {
                    this_param.EnsureForwardTypeToAssemblyMap();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 135142, 135174);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 135020, 135245);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 135020, 135245);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void EnsureForwardTypeToAssemblyMap()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 135257, 138506);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 135327, 138495) || true) && (_lazyForwardedTypesToAssemblyIndexMap == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 135327, 138495);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 135410, 135500);

                    var
                    typesToAssemblyIndexMap = f_415_135440_135499()
                    ;

                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 135564, 135610);

                        var
                        forwarders = f_415_135581_135609(f_415_135581_135595())
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 135632, 138307);
                            foreach (var handle in f_415_135655_135665_I(forwarders))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 135632, 138307);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 135715, 135782);

                                ExportedType
                                exportedType = f_415_135743_135781(f_415_135743_135757(), handle)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 135808, 135931) || true) && (f_415_135812_135837_M(!exportedType.IsForwarder))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 135808, 135931);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 135895, 135904);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(415, 135808, 135931);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 135959, 136048);

                                AssemblyReferenceHandle
                                refHandle = (AssemblyReferenceHandle)exportedType.Implementation
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 136074, 136187) || true) && (refHandle.IsNil)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 136074, 136187);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 136151, 136160);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(415, 136074, 136187);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 136215, 136243);

                                int
                                referencedAssemblyIndex
                                = default(int);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 136329, 136404);

                                    referencedAssemblyIndex = f_415_136355_136403(this, refHandle);
                                }
                                catch (BadImageFormatException)
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCatch(415, 136457, 136581);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 136545, 136554);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCatch(415, 136457, 136581);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 136609, 136797) || true) && (referencedAssemblyIndex < 0 || (DynAbs.Tracing.TraceSender.Expression_False(415, 136613, 136703) || referencedAssemblyIndex >= this.ReferencedAssemblies.Length))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 136609, 136797);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 136761, 136770);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(415, 136609, 136797);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 136825, 136883);

                                string
                                name = f_415_136839_136882(f_415_136839_136853(), exportedType.Name)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 136909, 136950);

                                StringHandle
                                ns = exportedType.Namespace
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 136976, 137321) || true) && (f_415_136980_136989_M(!ns.IsNil))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 136976, 137321);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 137047, 137101);

                                    string
                                    namespaceString = f_415_137072_137100(f_415_137072_137086(), ns)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 137131, 137294) || true) && (f_415_137135_137157(namespaceString) > 0)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 137131, 137294);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 137227, 137263);

                                        name = namespaceString + "." + name;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 137131, 137294);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(415, 136976, 137321);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 137349, 137391);

                                (int FirstIndex, int SecondIndex)
                                indices
                                = default((int FirstIndex, int SecondIndex));

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 137419, 138284) || true) && (f_415_137423_137477(typesToAssemblyIndexMap, name, out indices))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 137419, 138284);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 137535, 137656);

                                    f_415_137535_137655(indices.FirstIndex >= 0, "Not allowed to store a negative (non-existent) index in typesToAssemblyIndexMap");

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 137760, 138053) || true) && (indices.FirstIndex != referencedAssemblyIndex && (DynAbs.Tracing.TraceSender.Expression_True(415, 137764, 137836) && indices.SecondIndex < 0))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 137760, 138053);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 137902, 137948);

                                        indices.SecondIndex = referencedAssemblyIndex;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 137982, 138022);

                                        typesToAssemblyIndexMap[name] = indices;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(415, 137760, 138053);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(415, 137419, 138284);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 137419, 138284);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 138167, 138257);

                                    f_415_138167_138256(typesToAssemblyIndexMap, name, (FirstIndex: referencedAssemblyIndex, SecondIndex: -1));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(415, 137419, 138284);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(415, 135632, 138307);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(415, 1, 2676);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(415, 1, 2676);
                        }
                    }
                    catch (BadImageFormatException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(415, 138344, 138396);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(415, 138344, 138396);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 138416, 138480);

                    _lazyForwardedTypesToAssemblyIndexMap = typesToAssemblyIndexMap;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(415, 135327, 138495);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 135257, 138506);

                System.Collections.Generic.Dictionary<string, (int FirstIndex, int SecondIndex)>
                f_415_135440_135499()
                {
                    var return_v = new System.Collections.Generic.Dictionary<string, (int FirstIndex, int SecondIndex)>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 135440, 135499);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_415_135581_135595()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 135581, 135595);
                    return return_v;
                }


                System.Reflection.Metadata.ExportedTypeHandleCollection
                f_415_135581_135609(System.Reflection.Metadata.MetadataReader
                this_param)
                {
                    var return_v = this_param.ExportedTypes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 135581, 135609);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_415_135743_135757()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 135743, 135757);
                    return return_v;
                }


                System.Reflection.Metadata.ExportedType
                f_415_135743_135781(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.ExportedTypeHandle
                handle)
                {
                    var return_v = this_param.GetExportedType(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 135743, 135781);
                    return return_v;
                }


                bool
                f_415_135812_135837_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 135812, 135837);
                    return return_v;
                }


                int
                f_415_136355_136403(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.AssemblyReferenceHandle
                assemblyRef)
                {
                    var return_v = this_param.GetAssemblyReferenceIndexOrThrow(assemblyRef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 136355, 136403);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_415_136839_136853()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 136839, 136853);
                    return return_v;
                }


                string
                f_415_136839_136882(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.StringHandle
                handle)
                {
                    var return_v = this_param.GetString(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 136839, 136882);
                    return return_v;
                }


                bool
                f_415_136980_136989_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 136980, 136989);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_415_137072_137086()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 137072, 137086);
                    return return_v;
                }


                string
                f_415_137072_137100(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.StringHandle
                handle)
                {
                    var return_v = this_param.GetString(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 137072, 137100);
                    return return_v;
                }


                int
                f_415_137135_137157(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 137135, 137157);
                    return return_v;
                }


                bool
                f_415_137423_137477(System.Collections.Generic.Dictionary<string, (int FirstIndex, int SecondIndex)>
                this_param, string
                key, out (int FirstIndex, int SecondIndex)
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 137423, 137477);
                    return return_v;
                }


                int
                f_415_137535_137655(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 137535, 137655);
                    return 0;
                }


                int
                f_415_138167_138256(System.Collections.Generic.Dictionary<string, (int FirstIndex, int SecondIndex)>
                this_param, string
                key, (int FirstIndex, int SecondIndex)
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 138167, 138256);
                    return 0;
                }


                System.Reflection.Metadata.ExportedTypeHandleCollection
                f_415_135655_135665_I(System.Reflection.Metadata.ExportedTypeHandleCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 135655, 135665);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 135257, 138506);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 135257, 138506);
            }
        }

        internal IdentifierCollection TypeNames
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 138582, 138670);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 138618, 138655);

                    return f_415_138625_138654(_lazyTypeNameCollection);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(415, 138582, 138670);

                    Microsoft.CodeAnalysis.IdentifierCollection
                    f_415_138625_138654(System.Lazy<Microsoft.CodeAnalysis.IdentifierCollection>
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 138625, 138654);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 138518, 138681);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 138518, 138681);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal IdentifierCollection NamespaceNames
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 138762, 138855);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 138798, 138840);

                    return f_415_138805_138839(_lazyNamespaceNameCollection);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(415, 138762, 138855);

                    Microsoft.CodeAnalysis.IdentifierCollection
                    f_415_138805_138839(System.Lazy<Microsoft.CodeAnalysis.IdentifierCollection>
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 138805, 138839);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 138693, 138866);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 138693, 138866);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal PropertyAccessors GetPropertyMethodsOrThrow(PropertyDefinitionHandle propertyDef)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 138980, 139178);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 139095, 139167);

                return f_415_139102_139151(f_415_139102_139116(), propertyDef).GetAccessors();
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 138980, 139178);

                System.Reflection.Metadata.MetadataReader
                f_415_139102_139116()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 139102, 139116);
                    return return_v;
                }


                System.Reflection.Metadata.PropertyDefinition
                f_415_139102_139151(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.PropertyDefinitionHandle
                handle)
                {
                    var return_v = this_param.GetPropertyDefinition(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 139102, 139151);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 138980, 139178);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 138980, 139178);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal EventAccessors GetEventMethodsOrThrow(EventDefinitionHandle eventDef)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 139292, 139472);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 139395, 139461);

                return f_415_139402_139445(f_415_139402_139416(), eventDef).GetAccessors();
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 139292, 139472);

                System.Reflection.Metadata.MetadataReader
                f_415_139402_139416()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 139402, 139416);
                    return return_v;
                }


                System.Reflection.Metadata.EventDefinition
                f_415_139402_139445(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.EventDefinitionHandle
                handle)
                {
                    var return_v = this_param.GetEventDefinition(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 139402, 139445);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 139292, 139472);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 139292, 139472);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal int GetAssemblyReferenceIndexOrThrow(AssemblyReferenceHandle assemblyRef)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 139586, 139756);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 139693, 139745);

                return f_415_139700_139714().GetRowNumber(assemblyRef) - 1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 139586, 139756);

                System.Reflection.Metadata.MetadataReader
                f_415_139700_139714()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 139700, 139714);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 139586, 139756);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 139586, 139756);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsNested(TypeAttributes flags)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(415, 139768, 139906);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 139844, 139895);

                return (flags & ((TypeAttributes)0x00000006)) != 0;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(415, 139768, 139906);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 139768, 139906);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 139768, 139906);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool HasIL
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 140082, 140120);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 140088, 140118);

                    return f_415_140095_140117();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(415, 140082, 140120);

                    bool
                    f_415_140095_140117()
                    {
                        var return_v = IsEntireImageAvailable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 140095, 140117);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 140038, 140131);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 140038, 140131);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool IsEntireImageAvailable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 140323, 140398);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 140329, 140396);

                    return _peReaderOpt != null && (DynAbs.Tracing.TraceSender.Expression_True(415, 140336, 140395) && f_415_140360_140395(_peReaderOpt));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(415, 140323, 140398);

                    bool
                    f_415_140360_140395(System.Reflection.PortableExecutable.PEReader
                    this_param)
                    {
                        var return_v = this_param.IsEntireImageAvailable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 140360, 140395);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 140262, 140409);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 140262, 140409);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal MethodBodyBlock GetMethodBodyOrThrow(MethodDefinitionHandle methodHandle)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 140506, 141125);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 140686, 140721);

                f_415_140686_140720(_peReaderOpt != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 140737, 140812);

                MethodDefinition
                method = f_415_140763_140811(f_415_140763_140777(), methodHandle)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 140826, 141033) || true) && ((method.ImplAttributes & MethodImplAttributes.CodeTypeMask) != MethodImplAttributes.IL || (DynAbs.Tracing.TraceSender.Expression_False(415, 140830, 140972) || method.RelativeVirtualAddress == 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 140826, 141033);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 141006, 141018);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(415, 140826, 141033);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 141049, 141114);

                return f_415_141056_141113(_peReaderOpt, method.RelativeVirtualAddress);
                DynAbs.Tracing.TraceSender.TraceExitMethod(415, 140506, 141125);

                int
                f_415_140686_140720(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 140686, 140720);
                    return 0;
                }


                System.Reflection.Metadata.MetadataReader
                f_415_140763_140777()
                {
                    var return_v = MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 140763, 140777);
                    return return_v;
                }


                System.Reflection.Metadata.MethodDefinition
                f_415_140763_140811(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.MethodDefinitionHandle
                handle)
                {
                    var return_v = this_param.GetMethodDefinition(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 140763, 140811);
                    return return_v;
                }


                System.Reflection.Metadata.MethodBodyBlock
                f_415_141056_141113(System.Reflection.PortableExecutable.PEReader
                peReader, int
                relativeVirtualAddress)
                {
                    var return_v = peReader.GetMethodBody(relativeVirtualAddress);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 141056, 141113);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 140506, 141125);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 140506, 141125);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool StringEquals(MetadataReader metadataReader, StringHandle nameHandle, string name, bool ignoreCase)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(415, 141204, 141600);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 141347, 141511) || true) && (ignoreCase)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(415, 141347, 141511);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 141395, 141496);

                    return f_415_141402_141495(f_415_141416_141452(metadataReader, nameHandle), name, StringComparison.OrdinalIgnoreCase);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(415, 141347, 141511);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 141527, 141589);

                return metadataReader.StringComparer.Equals(nameHandle, name);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(415, 141204, 141600);

                string
                f_415_141416_141452(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.StringHandle
                handle)
                {
                    var return_v = this_param.GetString(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 141416, 141452);
                    return return_v;
                }


                bool
                f_415_141402_141495(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 141402, 141495);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 141204, 141600);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 141204, 141600);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private sealed class StringTableDecoder : MetadataStringDecoder
        {
            public static readonly StringTableDecoder Instance;

            private StringTableDecoder() : base(f_415_142015_142040_C(f_415_142015_142040()))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(415, 141979, 142045);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(415, 141979, 142045);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 141979, 142045);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 141979, 142045);
                }
            }

            public override unsafe string GetString(byte* bytes, int byteCount)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 142061, 142251);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 142161, 142236);

                    return f_415_142168_142235(f_415_142194_142234(bytes, byteCount));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(415, 142061, 142251);

                    unsafe System.ReadOnlySpan<byte>
                    f_415_142194_142234(byte*
                    pointer, int
                    length)
                    {
                        var return_v = new System.ReadOnlySpan<byte>((void*)pointer, length);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 142194, 142234);
                        return return_v;
                    }


                    string
                    f_415_142168_142235(System.ReadOnlySpan<byte>
                    bytes)
                    {
                        var return_v = StringTable.AddSharedUTF8(bytes);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 142168, 142235);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 142061, 142251);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 142061, 142251);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static StringTableDecoder()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(415, 141797, 142262);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 141927, 141962);
                Instance = f_415_141938_141962(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(415, 141797, 142262);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 141797, 142262);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(415, 141797, 142262);

            static Microsoft.CodeAnalysis.PEModule.StringTableDecoder
            f_415_141938_141962()
            {
                var return_v = new Microsoft.CodeAnalysis.PEModule.StringTableDecoder();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 141938, 141962);
                return return_v;
            }


            static System.Text.Encoding
            f_415_142015_142040()
            {
                var return_v = System.Text.Encoding.UTF8;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(415, 142015, 142040);
                return return_v;
            }


            static System.Text.Encoding
            f_415_142015_142040_C(System.Text.Encoding
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(415, 141979, 142045);
                return return_v;
            }

        }

        public ModuleMetadata GetNonDisposableMetadata()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(415, 142323, 142339);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 142326, 142339);
                return f_415_142326_142339(_owner); DynAbs.Tracing.TraceSender.TraceExitMethod(415, 142323, 142339);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(415, 142323, 142339);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 142323, 142339);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.ModuleMetadata
            f_415_142326_142339(Microsoft.CodeAnalysis.ModuleMetadata
            this_param)
            {
                var return_v = this_param.Copy();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 142326, 142339);
                return return_v;
            }

        }

        static PEModule()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(415, 1012, 142347);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 3678, 3739);
            s_attributeStringValueExtractor = CrackStringInAttributeValue; DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 3812, 3885);
            s_attributeStringAndIntValueExtractor = CrackStringAndIntInAttributeValue; DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 3950, 4013);
            s_attributeBooleanValueExtractor = CrackBooleanInAttributeValue; DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 4078, 4135);
            s_attributeByteValueExtractor = CrackByteInAttributeValue; DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 4201, 4260);
            s_attributeShortValueExtractor = CrackShortInAttributeValue; DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 4324, 4379);
            s_attributeIntValueExtractor = CrackIntInAttributeValue; DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 4444, 4501);
            s_attributeLongValueExtractor = CrackLongInAttributeValue; DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 4616, 4706);
            s_decimalValueInDecimalConstantAttributeExtractor = CrackDecimalInDecimalConstantAttribute; DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 4787, 4854);
            s_attributeBoolArrayValueExtractor = CrackBoolArrayInAttributeValue; DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 4935, 5002);
            s_attributeByteArrayValueExtractor = CrackByteArrayInAttributeValue; DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 5085, 5156);
            s_attributeStringArrayValueExtractor = CrackStringArrayInAttributeValue; DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 5238, 5303);
            s_attributeDeprecatedDataExtractor = CrackDeprecatedAttributeData; DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 5386, 5471);
            s_attributeBoolAndStringArrayValueExtractor = CrackBoolAndStringArrayInAttributeValue; DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 5549, 5624);
            s_attributeBoolAndStringValueExtractor = CrackBoolAndStringInAttributeValue; DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 43161, 43213);
            s_simpleTransformFlags = f_415_43186_43213(true); DynAbs.Tracing.TraceSender.TraceSimpleStatement(415, 45507, 45609);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(415, 1012, 142347);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(415, 1012, 142347);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(415, 1012, 142347);

        static int
        f_415_6740_6827(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 6740, 6827);
            return 0;
        }


        static int
        f_415_6842_6905(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 6842, 6905);
            return 0;
        }


        static System.Lazy<Microsoft.CodeAnalysis.IdentifierCollection>
        f_415_7112_7169(System.Func<Microsoft.CodeAnalysis.IdentifierCollection>
        valueFactory)
        {
            var return_v = new System.Lazy<Microsoft.CodeAnalysis.IdentifierCollection>(valueFactory);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 7112, 7169);
            return return_v;
        }


        static System.Lazy<Microsoft.CodeAnalysis.IdentifierCollection>
        f_415_7215_7277(System.Func<Microsoft.CodeAnalysis.IdentifierCollection>
        valueFactory)
        {
            var return_v = new System.Lazy<Microsoft.CodeAnalysis.IdentifierCollection>(valueFactory);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 7215, 7277);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PEModule.PEHashProvider
        f_415_7326_7354(System.Reflection.PortableExecutable.PEReader
        peReader)
        {
            var return_v = new Microsoft.CodeAnalysis.PEModule.PEHashProvider(peReader);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 7326, 7354);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<bool>
        f_415_43186_43213(bool
        item)
        {
            var return_v = ImmutableArray.Create(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(415, 43186, 43213);
            return return_v;
        }

    }
}
