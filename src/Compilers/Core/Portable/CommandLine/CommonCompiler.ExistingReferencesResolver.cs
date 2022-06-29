// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    internal abstract partial class CommonCompiler
    {
        internal sealed class ExistingReferencesResolver : MetadataReferenceResolver, IEquatable<ExistingReferencesResolver>
        {
            private readonly MetadataReferenceResolver _resolver;

            private readonly ImmutableArray<MetadataReference> _availableReferences;

            private readonly Lazy<HashSet<AssemblyIdentity>> _lazyAvailableReferences;

            public ExistingReferencesResolver(MetadataReferenceResolver resolver, ImmutableArray<MetadataReference> availableReferences)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(128, 1219, 2026);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(128, 1019, 1028);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(128, 1178, 1202);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(128, 1376, 1407);

                    f_128_1376_1406(resolver != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(128, 1425, 1467);

                    f_128_1425_1466(availableReferences != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(128, 1487, 1508);

                    _resolver = resolver;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(128, 1526, 1569);

                    _availableReferences = availableReferences;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(128, 1705, 2011);

                    _lazyAvailableReferences = f_128_1732_2010(() => new HashSet<AssemblyIdentity>(
                                        from reference in _availableReferences
                                        let identity = TryGetIdentity(reference)
                                        where identity != null
                                        select identity!));
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(128, 1219, 2026);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(128, 1219, 2026);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(128, 1219, 2026);
                }
            }

            public override ImmutableArray<PortableExecutableReference> ResolveReference(string reference, string? baseFilePath, MetadataReferenceProperties properties)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(128, 2042, 2458);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(128, 2231, 2320);

                    var
                    resolvedReferences = f_128_2256_2319(_resolver, reference, baseFilePath, properties)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(128, 2338, 2443);

                    return resolvedReferences.WhereAsArray(r => _lazyAvailableReferences.Value.Contains(TryGetIdentity(r)!));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(128, 2042, 2458);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.PortableExecutableReference>
                    f_128_2256_2319(Microsoft.CodeAnalysis.MetadataReferenceResolver
                    this_param, string
                    reference, string?
                    baseFilePath, Microsoft.CodeAnalysis.MetadataReferenceProperties
                    properties)
                    {
                        var return_v = this_param.ResolveReference(reference, baseFilePath, properties);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(128, 2256, 2319);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(128, 2042, 2458);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(128, 2042, 2458);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private static AssemblyIdentity? TryGetIdentity(MetadataReference metadataReference)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(128, 2474, 3345);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(128, 2591, 2658);

                    var
                    peReference = metadataReference as PortableExecutableReference
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(128, 2676, 2833) || true) && (peReference == null || (DynAbs.Tracing.TraceSender.Expression_False(128, 2680, 2760) || peReference.Properties.Kind != MetadataImageKind.Assembly))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(128, 2676, 2833);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(128, 2802, 2814);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(128, 2676, 2833);
                    }

                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(128, 2897, 2986);

                        PEAssembly
                        assembly = f_128_2919_2984(((AssemblyMetadata)f_128_2938_2969(peReference)))!
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(128, 3008, 3033);

                        return f_128_3015_3032(assembly);
                    }
                    catch (Exception e) when (e is BadImageFormatException || (DynAbs.Tracing.TraceSender.Expression_False(128, 3096, 3144) || e is IOException))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(128, 3070, 3330);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(128, 3299, 3311);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(128, 3070, 3330);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(128, 2474, 3345);

                    Microsoft.CodeAnalysis.Metadata
                    f_128_2938_2969(Microsoft.CodeAnalysis.PortableExecutableReference
                    this_param)
                    {
                        var return_v = this_param.GetMetadataNoCopy();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(128, 2938, 2969);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PEAssembly?
                    f_128_2919_2984(Microsoft.CodeAnalysis.AssemblyMetadata
                    this_param)
                    {
                        var return_v = this_param.GetAssembly();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(128, 2919, 2984);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.AssemblyIdentity
                    f_128_3015_3032(Microsoft.CodeAnalysis.PEAssembly
                    this_param)
                    {
                        var return_v = this_param.Identity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(128, 3015, 3032);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(128, 2474, 3345);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(128, 2474, 3345);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override int GetHashCode()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(128, 3361, 3473);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(128, 3427, 3458);

                    return f_128_3434_3457(_resolver);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(128, 3361, 3473);

                    int
                    f_128_3434_3457(Microsoft.CodeAnalysis.MetadataReferenceResolver
                    this_param)
                    {
                        var return_v = this_param.GetHashCode();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(128, 3434, 3457);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(128, 3361, 3473);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(128, 3361, 3473);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public bool Equals(ExistingReferencesResolver? other)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(128, 3489, 3779);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(128, 3575, 3764);

                    return
                                        other is object && (DynAbs.Tracing.TraceSender.Expression_True(128, 3603, 3676) && f_128_3643_3676(_resolver, other._resolver)) && (DynAbs.Tracing.TraceSender.Expression_True(128, 3603, 3763) && _availableReferences.SequenceEqual(other._availableReferences));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(128, 3489, 3779);

                    bool
                    f_128_3643_3676(Microsoft.CodeAnalysis.MetadataReferenceResolver
                    this_param, Microsoft.CodeAnalysis.MetadataReferenceResolver
                    other)
                    {
                        var return_v = this_param.Equals((object)other);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(128, 3643, 3676);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(128, 3489, 3779);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(128, 3489, 3779);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override bool Equals(object? other)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(128, 3838, 3895);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(128, 3841, 3895);
                    return other is ExistingReferencesResolver obj && (DynAbs.Tracing.TraceSender.Expression_True(128, 3841, 3895) && f_128_3884_3895(this, obj)); DynAbs.Tracing.TraceSender.TraceExitMethod(128, 3838, 3895);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(128, 3838, 3895);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(128, 3838, 3895);
                }
                throw new System.Exception("Slicer error: unreachable code");

                bool
                f_128_3884_3895(Microsoft.CodeAnalysis.CommonCompiler.ExistingReferencesResolver
                this_param, Microsoft.CodeAnalysis.CommonCompiler.ExistingReferencesResolver
                other)
                {
                    var return_v = this_param.Equals(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(128, 3884, 3895);
                    return return_v;
                }

            }

            static ExistingReferencesResolver()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(128, 835, 3907);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(128, 835, 3907);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(128, 835, 3907);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(128, 835, 3907);

            static int
            f_128_1376_1406(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(128, 1376, 1406);
                return 0;
            }


            static int
            f_128_1425_1466(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(128, 1425, 1466);
                return 0;
            }


            static System.Lazy<System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.AssemblyIdentity>>
            f_128_1732_2010(System.Func<System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.AssemblyIdentity>>
            valueFactory)
            {
                var return_v = new System.Lazy<System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.AssemblyIdentity>>(valueFactory);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(128, 1732, 2010);
                return return_v;
            }

        }
    }
}
