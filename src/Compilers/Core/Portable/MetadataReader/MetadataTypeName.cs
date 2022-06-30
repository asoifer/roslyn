// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Immutable;
using System.Diagnostics;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{

    [NonCopyable]
    internal partial struct MetadataTypeName
    {

        private string _fullName;

        private string _namespaceName;

        private string _typeName;

        private string _unmangledTypeName;

        private short _inferredArity;

        private short _forcedArity;

        private bool _useCLSCompliantNameArityEncoding;

        private ImmutableArray<string> _namespaceSegments;

        public static MetadataTypeName FromFullName(string fullName, bool useCLSCompliantNameArityEncoding = false, int forcedArity = -1)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(411, 2670, 3716);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(411, 2824, 2855);

                f_411_2824_2854(fullName != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(411, 2869, 2933);

                f_411_2869_2932(forcedArity >= -1 && (DynAbs.Tracing.TraceSender.Expression_True(411, 2882, 2931) && forcedArity < short.MaxValue));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(411, 2947, 3223);

                f_411_2947_3222(forcedArity == -1 || (DynAbs.Tracing.TraceSender.Expression_False(411, 2960, 3040) || !useCLSCompliantNameArityEncoding) || (DynAbs.Tracing.TraceSender.Expression_False(411, 2960, 3141) || forcedArity == f_411_3085_3141(fullName)), "Conflicting metadata type name resolution options!");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(411, 3239, 3261);

                MetadataTypeName
                name
                = default(MetadataTypeName);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(411, 3277, 3303);

                name._fullName = fullName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(411, 3317, 3344);

                name._namespaceName = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(411, 3358, 3380);

                name._typeName = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(411, 3394, 3425);

                name._unmangledTypeName = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(411, 3439, 3464);

                name._inferredArity = -1;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(411, 3478, 3552);

                name._useCLSCompliantNameArityEncoding = useCLSCompliantNameArityEncoding;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(411, 3566, 3605);

                name._forcedArity = (short)forcedArity;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(411, 3619, 3677);

                name._namespaceSegments = default(ImmutableArray<string>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(411, 3693, 3705);

                return name;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(411, 2670, 3716);

                int
                f_411_2824_2854(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(411, 2824, 2854);
                    return 0;
                }


                int
                f_411_2869_2932(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(411, 2869, 2932);
                    return 0;
                }


                int
                f_411_3085_3141(string
                emittedTypeName)
                {
                    var return_v = MetadataHelpers.InferTypeArityFromMetadataName(emittedTypeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(411, 3085, 3141);
                    return return_v;
                }


                int
                f_411_2947_3222(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(411, 2947, 3222);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(411, 2670, 3716);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(411, 2670, 3716);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static MetadataTypeName FromNamespaceAndTypeName(
                    string namespaceName, string typeName,
                    bool useCLSCompliantNameArityEncoding = false, int forcedArity = -1
                )
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(411, 3728, 4987);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(411, 3953, 3989);

                f_411_3953_3988(namespaceName != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(411, 4003, 4034);

                f_411_4003_4033(typeName != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(411, 4048, 4112);

                f_411_4048_4111(forcedArity >= -1 && (DynAbs.Tracing.TraceSender.Expression_True(411, 4061, 4110) && forcedArity < short.MaxValue));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(411, 4126, 4195);

                f_411_4126_4194(!f_411_4140_4193(typeName, MetadataHelpers.DotDelimiterString));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(411, 4209, 4485);

                f_411_4209_4484(forcedArity == -1 || (DynAbs.Tracing.TraceSender.Expression_False(411, 4222, 4302) || !useCLSCompliantNameArityEncoding) || (DynAbs.Tracing.TraceSender.Expression_False(411, 4222, 4403) || forcedArity == f_411_4347_4403(typeName)), "Conflicting metadata type name resolution options!");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(411, 4501, 4523);

                MetadataTypeName
                name
                = default(MetadataTypeName);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(411, 4539, 4561);

                name._fullName = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(411, 4575, 4611);

                name._namespaceName = namespaceName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(411, 4625, 4651);

                name._typeName = typeName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(411, 4665, 4696);

                name._unmangledTypeName = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(411, 4710, 4735);

                name._inferredArity = -1;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(411, 4749, 4823);

                name._useCLSCompliantNameArityEncoding = useCLSCompliantNameArityEncoding;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(411, 4837, 4876);

                name._forcedArity = (short)forcedArity;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(411, 4890, 4948);

                name._namespaceSegments = default(ImmutableArray<string>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(411, 4964, 4976);

                return name;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(411, 3728, 4987);

                int
                f_411_3953_3988(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(411, 3953, 3988);
                    return 0;
                }


                int
                f_411_4003_4033(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(411, 4003, 4033);
                    return 0;
                }


                int
                f_411_4048_4111(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(411, 4048, 4111);
                    return 0;
                }


                bool
                f_411_4140_4193(string
                this_param, string
                value)
                {
                    var return_v = this_param.Contains(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(411, 4140, 4193);
                    return return_v;
                }


                int
                f_411_4126_4194(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(411, 4126, 4194);
                    return 0;
                }


                int
                f_411_4347_4403(string
                emittedTypeName)
                {
                    var return_v = MetadataHelpers.InferTypeArityFromMetadataName(emittedTypeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(411, 4347, 4403);
                    return return_v;
                }


                int
                f_411_4209_4484(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(411, 4209, 4484);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(411, 3728, 4987);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(411, 3728, 4987);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static MetadataTypeName FromTypeName(string typeName, bool useCLSCompliantNameArityEncoding = false, int forcedArity = -1)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(411, 4999, 6206);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(411, 5153, 5184);

                f_411_5153_5183(typeName != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(411, 5198, 5336);

                f_411_5198_5335(!f_411_5212_5265(typeName, MetadataHelpers.DotDelimiterString) || (DynAbs.Tracing.TraceSender.Expression_False(411, 5211, 5334) || f_411_5269_5329(typeName, MetadataHelpers.MangledNameRegionStartChar) >= 0));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(411, 5350, 5414);

                f_411_5350_5413(forcedArity >= -1 && (DynAbs.Tracing.TraceSender.Expression_True(411, 5363, 5412) && forcedArity < short.MaxValue));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(411, 5428, 5704);

                f_411_5428_5703(forcedArity == -1 || (DynAbs.Tracing.TraceSender.Expression_False(411, 5441, 5521) || !useCLSCompliantNameArityEncoding) || (DynAbs.Tracing.TraceSender.Expression_False(411, 5441, 5622) || forcedArity == f_411_5566_5622(typeName)), "Conflicting metadata type name resolution options!");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(411, 5720, 5742);

                MetadataTypeName
                name
                = default(MetadataTypeName);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(411, 5758, 5784);

                name._fullName = typeName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(411, 5798, 5833);

                name._namespaceName = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(411, 5847, 5873);

                name._typeName = typeName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(411, 5887, 5918);

                name._unmangledTypeName = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(411, 5932, 5957);

                name._inferredArity = -1;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(411, 5971, 6045);

                name._useCLSCompliantNameArityEncoding = useCLSCompliantNameArityEncoding;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(411, 6059, 6098);

                name._forcedArity = (short)forcedArity;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(411, 6112, 6167);

                name._namespaceSegments = ImmutableArray<string>.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(411, 6183, 6195);

                return name;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(411, 4999, 6206);

                int
                f_411_5153_5183(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(411, 5153, 5183);
                    return 0;
                }


                bool
                f_411_5212_5265(string
                this_param, string
                value)
                {
                    var return_v = this_param.Contains(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(411, 5212, 5265);
                    return return_v;
                }


                int
                f_411_5269_5329(string
                this_param, char
                value)
                {
                    var return_v = this_param.IndexOf(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(411, 5269, 5329);
                    return return_v;
                }


                int
                f_411_5198_5335(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(411, 5198, 5335);
                    return 0;
                }


                int
                f_411_5350_5413(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(411, 5350, 5413);
                    return 0;
                }


                int
                f_411_5566_5622(string
                emittedTypeName)
                {
                    var return_v = MetadataHelpers.InferTypeArityFromMetadataName(emittedTypeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(411, 5566, 5622);
                    return return_v;
                }


                int
                f_411_5428_5703(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(411, 5428, 5703);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(411, 4999, 6206);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(411, 4999, 6206);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public string FullName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(411, 6400, 6757);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(411, 6436, 6705) || true) && (_fullName == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(411, 6436, 6705);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(411, 6499, 6536);

                        f_411_6499_6535(_namespaceName != null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(411, 6558, 6590);

                        f_411_6558_6589(_typeName != null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(411, 6612, 6686);

                        _fullName = f_411_6624_6685(_namespaceName, _typeName);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(411, 6436, 6705);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(411, 6725, 6742);

                    return _fullName;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(411, 6400, 6757);

                    int
                    f_411_6499_6535(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(411, 6499, 6535);
                        return 0;
                    }


                    int
                    f_411_6558_6589(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(411, 6558, 6589);
                        return 0;
                    }


                    string
                    f_411_6624_6685(string
                    qualifier, string
                    name)
                    {
                        var return_v = MetadataHelpers.BuildQualifiedName(qualifier, name);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(411, 6624, 6685);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(411, 6353, 6768);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(411, 6353, 6768);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public string NamespaceName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(411, 6959, 7271);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(411, 6995, 7214) || true) && (_namespaceName == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(411, 6995, 7214);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(411, 7063, 7095);

                        f_411_7063_7094(_fullName != null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(411, 7117, 7195);

                        _typeName = f_411_7129_7194(_fullName, out _namespaceName);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(411, 6995, 7214);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(411, 7234, 7256);

                    return _namespaceName;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(411, 6959, 7271);

                    int
                    f_411_7063_7094(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(411, 7063, 7094);
                        return 0;
                    }


                    string
                    f_411_7129_7194(string
                    pstrName, out string
                    qualifier)
                    {
                        var return_v = MetadataHelpers.SplitQualifiedName(pstrName, out qualifier);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(411, 7129, 7194);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(411, 6907, 7282);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(411, 6907, 7282);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public string TypeName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(411, 7494, 7796);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(411, 7530, 7744) || true) && (_typeName == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(411, 7530, 7744);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(411, 7593, 7625);

                        f_411_7593_7624(_fullName != null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(411, 7647, 7725);

                        _typeName = f_411_7659_7724(_fullName, out _namespaceName);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(411, 7530, 7744);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(411, 7764, 7781);

                    return _typeName;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(411, 7494, 7796);

                    int
                    f_411_7593_7624(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(411, 7593, 7624);
                        return 0;
                    }


                    string
                    f_411_7659_7724(string
                    pstrName, out string
                    qualifier)
                    {
                        var return_v = MetadataHelpers.SplitQualifiedName(pstrName, out qualifier);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(411, 7659, 7724);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(411, 7447, 7807);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(411, 7447, 7807);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public string UnmangledTypeName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(411, 8013, 8363);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(411, 8049, 8302) || true) && (_unmangledTypeName == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(411, 8049, 8302);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(411, 8121, 8156);

                        f_411_8121_8155(_inferredArity == -1);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(411, 8178, 8283);

                        _unmangledTypeName = f_411_8199_8282(TypeName, out _inferredArity);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(411, 8049, 8302);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(411, 8322, 8348);

                    return _unmangledTypeName;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(411, 8013, 8363);

                    int
                    f_411_8121_8155(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(411, 8121, 8155);
                        return 0;
                    }


                    string
                    f_411_8199_8282(string
                    emittedTypeName, out short
                    arity)
                    {
                        var return_v = MetadataHelpers.InferTypeArityAndUnmangleMetadataName(emittedTypeName, out arity);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(411, 8199, 8282);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(411, 7957, 8374);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(411, 7957, 8374);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public int InferredArity
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(411, 8618, 8964);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(411, 8654, 8907) || true) && (_inferredArity == -1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(411, 8654, 8907);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(411, 8720, 8761);

                        f_411_8720_8760(_unmangledTypeName == null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(411, 8783, 8888);

                        _unmangledTypeName = f_411_8804_8887(TypeName, out _inferredArity);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(411, 8654, 8907);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(411, 8927, 8949);

                    return _inferredArity;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(411, 8618, 8964);

                    int
                    f_411_8720_8760(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(411, 8720, 8760);
                        return 0;
                    }


                    string
                    f_411_8804_8887(string
                    emittedTypeName, out short
                    arity)
                    {
                        var return_v = MetadataHelpers.InferTypeArityAndUnmangleMetadataName(emittedTypeName, out arity);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(411, 8804, 8887);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(411, 8569, 8975);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(411, 8569, 8975);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsMangled
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(411, 9134, 9210);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(411, 9170, 9195);

                    return InferredArity > 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(411, 9134, 9210);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(411, 9088, 9221);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(411, 9088, 9221);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public readonly bool UseCLSCompliantNameArityEncoding
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(411, 9645, 9737);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(411, 9681, 9722);

                    return _useCLSCompliantNameArityEncoding;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(411, 9645, 9737);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(411, 9567, 9748);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(411, 9567, 9748);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public readonly int ForcedArity
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(411, 10143, 10214);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(411, 10179, 10199);

                    return _forcedArity;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(411, 10143, 10214);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(411, 10087, 10225);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(411, 10087, 10225);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ImmutableArray<string> NamespaceSegments
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(411, 10415, 10676);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(411, 10451, 10615) || true) && (_namespaceSegments.IsDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(411, 10451, 10615);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(411, 10525, 10596);

                        _namespaceSegments = f_411_10546_10595(NamespaceName);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(411, 10451, 10615);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(411, 10635, 10661);

                    return _namespaceSegments;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(411, 10415, 10676);

                    System.Collections.Immutable.ImmutableArray<string>
                    f_411_10546_10595(string
                    name)
                    {
                        var return_v = MetadataHelpers.SplitQualifiedName(name);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(411, 10546, 10595);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(411, 10343, 10687);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(411, 10343, 10687);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public readonly bool IsNull
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(411, 10751, 10848);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(411, 10787, 10833);

                    return _typeName == null && (DynAbs.Tracing.TraceSender.Expression_True(411, 10794, 10832) && _fullName == null);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(411, 10751, 10848);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(411, 10699, 10859);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(411, 10699, 10859);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(411, 10871, 11220);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(411, 10929, 11209) || true) && (IsNull)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(411, 10929, 11209);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(411, 10973, 10989);

                    return "{Null}";
                    DynAbs.Tracing.TraceSender.TraceExitCondition(411, 10929, 11209);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(411, 10929, 11209);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(411, 11055, 11194);

                    return f_411_11062_11193("{{{0},{1},{2},{3}}}", NamespaceName, TypeName, f_411_11124_11167(UseCLSCompliantNameArityEncoding), f_411_11169_11192(_forcedArity));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(411, 10929, 11209);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(411, 10871, 11220);

                string
                f_411_11124_11167(bool
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(411, 11124, 11167);
                    return return_v;
                }


                string
                f_411_11169_11192(short
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(411, 11169, 11192);
                    return return_v;
                }


                string
                f_411_11062_11193(string
                format, params object?[]
                args)
                {
                    var return_v = String.Format(format, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(411, 11062, 11193);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(411, 10871, 11220);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(411, 10871, 11220);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static MetadataTypeName()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(411, 690, 11227);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(411, 690, 11227);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(411, 690, 11227);
        }
    }
}
