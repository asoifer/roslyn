// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Immutable;
using System.Globalization;
using System.Reflection;
using System.Reflection.Metadata;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Microsoft.CodeAnalysis
{
    internal static class MetadataReaderExtensions
    {
        internal static bool GetWinMdVersion(this MetadataReader reader, out int majorVersion, out int minorVersion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(409, 522, 1597);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(409, 655, 1495) || true) && (f_409_659_678(reader) == MetadataKind.WindowsMetadata)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(409, 655, 1495);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(409, 825, 865);

                    const string
                    prefix = "WindowsRuntime "
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(409, 883, 923);

                    string
                    version = f_409_900_922(reader)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(409, 941, 1480) || true) && (f_409_945_997(version, prefix, StringComparison.Ordinal))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(409, 941, 1480);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(409, 1039, 1095);

                        var
                        parts = f_409_1051_1094(f_409_1051_1083(version, f_409_1069_1082(prefix)), '.')
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(409, 1117, 1461) || true) && ((f_409_1122_1134(parts) == 2) && (DynAbs.Tracing.TraceSender.Expression_True(409, 1121, 1258) && f_409_1169_1258(parts[0], NumberStyles.None, f_409_1211_1239(), out majorVersion)) && (DynAbs.Tracing.TraceSender.Expression_True(409, 1121, 1376) && f_409_1287_1376(parts[1], NumberStyles.None, f_409_1329_1357(), out minorVersion)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(409, 1117, 1461);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(409, 1426, 1438);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(409, 1117, 1461);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(409, 941, 1480);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(409, 655, 1495);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(409, 1511, 1528);

                majorVersion = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(409, 1542, 1559);

                minorVersion = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(409, 1573, 1586);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(409, 522, 1597);

                System.Reflection.Metadata.MetadataKind
                f_409_659_678(System.Reflection.Metadata.MetadataReader
                this_param)
                {
                    var return_v = this_param.MetadataKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(409, 659, 678);
                    return return_v;
                }


                string
                f_409_900_922(System.Reflection.Metadata.MetadataReader
                this_param)
                {
                    var return_v = this_param.MetadataVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(409, 900, 922);
                    return return_v;
                }


                bool
                f_409_945_997(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(409, 945, 997);
                    return return_v;
                }


                int
                f_409_1069_1082(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(409, 1069, 1082);
                    return return_v;
                }


                string
                f_409_1051_1083(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(409, 1051, 1083);
                    return return_v;
                }


                string[]
                f_409_1051_1094(string
                this_param, char
                separator)
                {
                    var return_v = this_param.Split(separator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(409, 1051, 1094);
                    return return_v;
                }


                int
                f_409_1122_1134(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(409, 1122, 1134);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_409_1211_1239()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(409, 1211, 1239);
                    return return_v;
                }


                bool
                f_409_1169_1258(string
                s, System.Globalization.NumberStyles
                style, System.Globalization.CultureInfo
                provider, out int
                result)
                {
                    var return_v = int.TryParse(s, style, (System.IFormatProvider)provider, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(409, 1169, 1258);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_409_1329_1357()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(409, 1329, 1357);
                    return return_v;
                }


                bool
                f_409_1287_1376(string
                s, System.Globalization.NumberStyles
                style, System.Globalization.CultureInfo
                provider, out int
                result)
                {
                    var return_v = int.TryParse(s, style, (System.IFormatProvider)provider, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(409, 1287, 1376);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(409, 522, 1597);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(409, 522, 1597);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static AssemblyIdentity ReadAssemblyIdentityOrThrow(this MetadataReader reader)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(409, 1711, 2268);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(409, 1824, 1907) || true) && (f_409_1828_1846_M(!reader.IsAssembly))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(409, 1824, 1907);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(409, 1880, 1892);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(409, 1824, 1907);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(409, 1923, 1972);

                var
                assemblyDef = f_409_1941_1971(reader)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(409, 1988, 2257);

                return f_409_1995_2256(reader, assemblyDef.Version, assemblyDef.Flags, assemblyDef.PublicKey, assemblyDef.Name, assemblyDef.Culture, isReference: false);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(409, 1711, 2268);

                bool
                f_409_1828_1846_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(409, 1828, 1846);
                    return return_v;
                }


                System.Reflection.Metadata.AssemblyDefinition
                f_409_1941_1971(System.Reflection.Metadata.MetadataReader
                this_param)
                {
                    var return_v = this_param.GetAssemblyDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(409, 1941, 1971);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_409_1995_2256(System.Reflection.Metadata.MetadataReader
                reader, System.Version
                version, System.Reflection.AssemblyFlags
                flags, System.Reflection.Metadata.BlobHandle
                publicKey, System.Reflection.Metadata.StringHandle
                name, System.Reflection.Metadata.StringHandle
                culture, bool
                isReference)
                {
                    var return_v = reader.CreateAssemblyIdentityOrThrow(version, flags, publicKey, name, culture, isReference: isReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(409, 1995, 2256);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(409, 1711, 2268);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(409, 1711, 2268);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ImmutableArray<AssemblyIdentity> GetReferencedAssembliesOrThrow(this MetadataReader reader)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(409, 2382, 3335);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(409, 2514, 2603);

                var
                result = f_409_2527_2602(reader.AssemblyReferences.Count)
                ;
                try
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(409, 2653, 3178);
                        foreach (var assemblyRef in f_409_2681_2706_I(f_409_2681_2706(reader)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(409, 2653, 3178);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(409, 2748, 2819);

                            AssemblyReference
                            reference = f_409_2778_2818(reader, assemblyRef)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(409, 2841, 3159);

                            f_409_2841_3158(result, f_409_2852_3157(reader, reference.Version, reference.Flags, reference.PublicKeyOrToken, reference.Name, reference.Culture, isReference: true));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(409, 2653, 3178);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(409, 1, 526);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(409, 1, 526);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(409, 3198, 3226);

                    return f_409_3205_3225(result);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(409, 3255, 3324);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(409, 3295, 3309);

                    f_409_3295_3308(result);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(409, 3255, 3324);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(409, 2382, 3335);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.AssemblyIdentity>
                f_409_2527_2602(int
                capacity)
                {
                    var return_v = ArrayBuilder<AssemblyIdentity>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(409, 2527, 2602);
                    return return_v;
                }


                System.Reflection.Metadata.AssemblyReferenceHandleCollection
                f_409_2681_2706(System.Reflection.Metadata.MetadataReader
                this_param)
                {
                    var return_v = this_param.AssemblyReferences;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(409, 2681, 2706);
                    return return_v;
                }


                System.Reflection.Metadata.AssemblyReference
                f_409_2778_2818(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.AssemblyReferenceHandle
                handle)
                {
                    var return_v = this_param.GetAssemblyReference(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(409, 2778, 2818);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_409_2852_3157(System.Reflection.Metadata.MetadataReader
                reader, System.Version
                version, System.Reflection.AssemblyFlags
                flags, System.Reflection.Metadata.BlobHandle
                publicKey, System.Reflection.Metadata.StringHandle
                name, System.Reflection.Metadata.StringHandle
                culture, bool
                isReference)
                {
                    var return_v = reader.CreateAssemblyIdentityOrThrow(version, flags, publicKey, name, culture, isReference: isReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(409, 2852, 3157);
                    return return_v;
                }


                int
                f_409_2841_3158(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.AssemblyIdentity>
                this_param, Microsoft.CodeAnalysis.AssemblyIdentity
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(409, 2841, 3158);
                    return 0;
                }


                System.Reflection.Metadata.AssemblyReferenceHandleCollection
                f_409_2681_2706_I(System.Reflection.Metadata.AssemblyReferenceHandleCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(409, 2681, 2706);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AssemblyIdentity>
                f_409_3205_3225(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.AssemblyIdentity>
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(409, 3205, 3225);
                    return return_v;
                }


                int
                f_409_3295_3308(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.AssemblyIdentity>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(409, 3295, 3308);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(409, 2382, 3335);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(409, 2382, 3335);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Guid GetModuleVersionIdOrThrow(this MetadataReader reader)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(409, 3449, 3616);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(409, 3548, 3605);

                return f_409_3555_3604(reader, f_409_3570_3598(reader).Mvid);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(409, 3449, 3616);

                System.Reflection.Metadata.ModuleDefinition
                f_409_3570_3598(System.Reflection.Metadata.MetadataReader
                this_param)
                {
                    var return_v = this_param.GetModuleDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(409, 3570, 3598);
                    return return_v;
                }


                System.Guid
                f_409_3555_3604(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.GuidHandle
                handle)
                {
                    var return_v = this_param.GetGuid(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(409, 3555, 3604);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(409, 3449, 3616);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(409, 3449, 3616);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static AssemblyIdentity CreateAssemblyIdentityOrThrow(
                    this MetadataReader reader,
                    Version version,
                    AssemblyFlags flags,
                    BlobHandle publicKey,
                    StringHandle name,
                    StringHandle culture,
                    bool isReference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(409, 3730, 6904);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(409, 4055, 4095);

                string
                nameStr = f_409_4072_4094(reader, name)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(409, 4109, 4314) || true) && (!f_409_4114_4164(nameStr))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(409, 4109, 4314);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(409, 4198, 4299);

                    throw f_409_4204_4298(f_409_4232_4297(f_409_4246_4287(), nameStr));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(409, 4109, 4314);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(409, 4330, 4400);

                string
                cultureName = (DynAbs.Tracing.TraceSender.Conditional_F1(409, 4351, 4364) || ((culture.IsNil && 
                DynAbs.Tracing.TraceSender.Conditional_F2(409, 4367, 4371)) || 
                DynAbs.Tracing.TraceSender.Conditional_F3(409, 4374, 4399))) ? null : f_409_4374_4399(reader, culture)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(409, 4414, 4649) || true) && (cultureName != null && 
                    (DynAbs.Tracing.TraceSender.Expression_True(409, 4418, 4496) && !f_409_4442_4496(cultureName)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(409, 4414, 4649);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(409, 4530, 4634);

                    throw f_409_4536_4633(f_409_4564_4632(f_409_4578_4618(), cultureName));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(409, 4414, 4649);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(409, 4665, 4738);

                ImmutableArray<byte>
                publicKeyOrToken = f_409_4705_4737(reader, publicKey)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(409, 4752, 4770);

                bool
                hasPublicKey
                = default(bool);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(409, 4786, 6286) || true) && (isReference)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(409, 4786, 6286);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(409, 4835, 4889);

                    hasPublicKey = (flags & AssemblyFlags.PublicKey) != 0;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(409, 4907, 5540) || true) && (hasPublicKey)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(409, 4907, 5540);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(409, 4965, 5167) || true) && 
                            (!f_409_4970_5020(publicKeyOrToken))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(409, 4965, 5167);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(409, 5070, 5144);

                            throw f_409_5076_5143(f_409_5104_5142());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(409, 4965, 5167);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(409, 4907, 5540);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(409, 4907, 5540);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(409, 5249, 5521) || true) && 
                            (f_409_5253_5278_M(!publicKeyOrToken.IsEmpty) && 
                            (DynAbs.Tracing.TraceSender.Expression_True(409, 5253, 5369) && 
                            publicKeyOrToken.Length != AssemblyIdentity.PublicKeyTokenSize))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(409, 5249, 5521);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(409, 5419, 5498);

                            throw f_409_5425_5497(f_409_5453_5496());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(409, 5249, 5521);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(409, 4907, 5540);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(409, 4786, 6286);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(409, 4786, 6286);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(409, 6006, 6047);

                    hasPublicKey = f_409_6021_6046_M(!publicKeyOrToken.IsEmpty);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(409, 6065, 6271) || true) && (hasPublicKey && 
                        (DynAbs.Tracing.TraceSender.Expression_True(409, 6069, 6136) && !f_409_6086_6136(publicKeyOrToken)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(409, 6065, 6271);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(409, 6178, 6252);

                        throw f_409_6184_6251(f_409_6212_6250());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(409, 6065, 6271);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(409, 4786, 6286);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(409, 6302, 6428) || true) && (publicKeyOrToken.IsEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(409, 6302, 6428);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(409, 6364, 6413);

                    publicKeyOrToken = default(ImmutableArray<byte>);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(409, 6302, 6428);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(409, 6444, 6893);

                return f_409_6451_6892(name: nameStr, version: version, cultureName: cultureName, publicKeyOrToken: publicKeyOrToken, hasPublicKey: hasPublicKey, isRetargetable: (flags & AssemblyFlags.Retargetable) != 0, 
                    contentType: ((int)(flags & AssemblyFlags.ContentTypeMask) >> 9), noThrow: true);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(409, 3730, 6904);

                string
                f_409_4072_4094(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.StringHandle
                handle)
                {
                    var return_v = this_param.GetString(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(409, 4072, 4094);
                    return return_v;
                }


                bool
                f_409_4114_4164(string
                str)
                {
                    var return_v = MetadataHelpers.IsValidMetadataIdentifier(str);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(409, 4114, 4164);
                    return return_v;
                }


                string
                f_409_4246_4287()
                {
                    var return_v = CodeAnalysisResources.InvalidAssemblyName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(409, 4246, 4287);
                    return return_v;
                }


                string
                f_409_4232_4297(string
                format, string
                arg0)
                {
                    var return_v = string.Format(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(409, 4232, 4297);
                    return return_v;
                }


                System.BadImageFormatException
                f_409_4204_4298(string
                message)
                {
                    var return_v = new System.BadImageFormatException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(409, 4204, 4298);
                    return return_v;
                }


                string
                f_409_4374_4399(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.StringHandle
                handle)
                {
                    var return_v = this_param.GetString(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(409, 4374, 4399);
                    return return_v;
                }


                bool
                f_409_4442_4496(string
                str)
                {
                    var return_v = MetadataHelpers.IsValidMetadataIdentifier(str);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(409, 4442, 4496);
                    return return_v;
                }


                string
                f_409_4578_4618()
                {
                    var return_v = CodeAnalysisResources.InvalidCultureName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(409, 4578, 4618);
                    return return_v;
                }


                string
                f_409_4564_4632(string
                format, string
                arg0)
                {
                    var return_v = string.Format(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(409, 4564, 4632);
                    return return_v;
                }


                System.BadImageFormatException
                f_409_4536_4633(string
                message)
                {
                    var return_v = new System.BadImageFormatException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(409, 4536, 4633);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_409_4705_4737(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.BlobHandle
                handle)
                {
                    var return_v = this_param.GetBlobContent(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(409, 4705, 4737);
                    return return_v;
                }


                bool
                f_409_4970_5020(System.Collections.Immutable.ImmutableArray<byte>
                bytes)
                {
                    var return_v = MetadataHelpers.IsValidPublicKey(bytes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(409, 4970, 5020);
                    return return_v;
                }


                string
                f_409_5104_5142()
                {
                    var return_v = CodeAnalysisResources.InvalidPublicKey;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(409, 5104, 5142);
                    return return_v;
                }


                System.BadImageFormatException
                f_409_5076_5143(string
                message)
                {
                    var return_v = new System.BadImageFormatException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(409, 5076, 5143);
                    return return_v;
                }


                bool
                f_409_5253_5278_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(409, 5253, 5278);
                    return return_v;
                }


                string
                f_409_5453_5496()
                {
                    var return_v = CodeAnalysisResources.InvalidPublicKeyToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(409, 5453, 5496);
                    return return_v;
                }


                System.BadImageFormatException
                f_409_5425_5497(string
                message)
                {
                    var return_v = new System.BadImageFormatException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(409, 5425, 5497);
                    return return_v;
                }


                bool
                f_409_6021_6046_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(409, 6021, 6046);
                    return return_v;
                }


                bool
                f_409_6086_6136(System.Collections.Immutable.ImmutableArray<byte>
                bytes)
                {
                    var return_v = MetadataHelpers.IsValidPublicKey(bytes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(409, 6086, 6136);
                    return return_v;
                }


                string
                f_409_6212_6250()
                {
                    var return_v = CodeAnalysisResources.InvalidPublicKey;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(409, 6212, 6250);
                    return return_v;
                }


                System.BadImageFormatException
                f_409_6184_6251(string
                message)
                {
                    var return_v = new System.BadImageFormatException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(409, 6184, 6251);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_409_6451_6892(string
                name, System.Version
                version, string?
                cultureName, System.Collections.Immutable.ImmutableArray<byte>
                publicKeyOrToken, bool
                hasPublicKey, bool
                isRetargetable, int
                contentType, bool
                noThrow)
                {
                    var return_v = new Microsoft.CodeAnalysis.AssemblyIdentity(name: name, version: version, cultureName: cultureName, publicKeyOrToken: publicKeyOrToken, hasPublicKey: hasPublicKey, isRetargetable: isRetargetable, contentType: (System.Reflection.AssemblyContentType)contentType, noThrow: noThrow);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(409, 6451, 6892);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(409, 3730, 6904);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(409, 3730, 6904);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool DeclaresTheObjectClass(this MetadataReader reader)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(409, 6916, 7068);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(409, 7012, 7057);

                return f_409_7019_7056(reader, IsTheObjectClass);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(409, 6916, 7068);

                bool
                f_409_7019_7056(System.Reflection.Metadata.MetadataReader
                reader, System.Func<System.Reflection.Metadata.MetadataReader, System.Reflection.Metadata.TypeDefinition, bool>
                predicate)
                {
                    var return_v = reader.DeclaresType(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(409, 7019, 7056);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(409, 6916, 7068);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(409, 6916, 7068);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsTheObjectClass(this MetadataReader reader, TypeDefinition typeDef)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(409, 7080, 7315);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(409, 7193, 7304);

                return typeDef.BaseType.IsNil && (DynAbs.Tracing.TraceSender.Expression_True(409, 7200, 7303) &&
                    f_409_7227_7303(ref typeDef, "System", "Object"));
                
                // LAFHIS
                bool f_409_7227_7303(ref TypeDefinition t, string s1, string s2)
                {
                    var b = reader.IsPublicNonInterfaceType(t, s1, s2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(409, 7227, 7303);
                    return b;
                }

                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(409, 7080, 7315);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(409, 7080, 7315);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(409, 7080, 7315);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool DeclaresType(this MetadataReader reader, Func<MetadataReader, TypeDefinition, bool> predicate)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(409, 7327, 7952);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(409, 7467, 7912);
                    foreach (TypeDefinitionHandle handle in f_409_7507_7529_I(f_409_7507_7529(reader)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(409, 7467, 7912);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(409, 7607, 7654);

                            var
                            typeDef = f_409_7621_7653(reader, handle)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(409, 7676, 7791) || true) && (f_409_7680_7706(predicate, reader, typeDef))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(409, 7676, 7791);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(409, 7756, 7768);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(409, 7676, 7791);
                            }
                        }
                        catch (BadImageFormatException)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(409, 7828, 7897);
                            DynAbs.Tracing.TraceSender.TraceExitCatch(409, 7828, 7897);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(409, 7467, 7912);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(409, 1, 446);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(409, 1, 446);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(409, 7928, 7941);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(409, 7327, 7952);

                System.Reflection.Metadata.TypeDefinitionHandleCollection
                f_409_7507_7529(System.Reflection.Metadata.MetadataReader
                this_param)
                {
                    var return_v = this_param.TypeDefinitions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(409, 7507, 7529);
                    return return_v;
                }


                System.Reflection.Metadata.TypeDefinition
                f_409_7621_7653(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                handle)
                {
                    var return_v = this_param.GetTypeDefinition(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(409, 7621, 7653);
                    return return_v;
                }


                bool
                f_409_7680_7706(System.Func<System.Reflection.Metadata.MetadataReader, System.Reflection.Metadata.TypeDefinition, bool>
                this_param, System.Reflection.Metadata.MetadataReader
                arg1, System.Reflection.Metadata.TypeDefinition
                arg2)
                {
                    var return_v = this_param.Invoke(arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(409, 7680, 7706);
                    return return_v;
                }


                System.Reflection.Metadata.TypeDefinitionHandleCollection
                f_409_7507_7529_I(System.Reflection.Metadata.TypeDefinitionHandleCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(409, 7507, 7529);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(409, 7327, 7952);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(409, 7327, 7952);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsPublicNonInterfaceType(this MetadataReader reader, TypeDefinition typeDef, string namespaceName, string typeName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(409, 8066, 8500);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(409, 8227, 8489);

                return (typeDef.Attributes & (TypeAttributes.Public | TypeAttributes.Interface)) == TypeAttributes.Public && 
                    (DynAbs.Tracing.TraceSender.Expression_True(409, 8234, 8405) &&
                    f_409_8337_8406(reader.StringComparer, typeDef.Name, typeName)) && 
                    (DynAbs.Tracing.TraceSender.Expression_True(409, 8234, 8488) &&
                    f_409_8410_8488(reader.StringComparer, typeDef.Namespace, namespaceName));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(409, 8066, 8500);

                // LAFHIS
                bool f_409_8337_8406(MetadataStringComparer m, StringHandle s1, string s2)
                {
                    var b = reader.StringComparer.Equals(s1, s2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(409, 8337, 8406);
                    return b;
                }

                // LAFHIS
                bool f_409_8410_8488(MetadataStringComparer m, StringHandle s1, string s2)
                {
                    var b = reader.StringComparer.Equals(s1, s2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(409, 8410, 8488);
                    return b;
                }
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(409, 8066, 8500);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(409, 8066, 8500);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static MetadataReaderExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(409, 459, 8507);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(409, 459, 8507);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(409, 459, 8507);
        }

    }
}
