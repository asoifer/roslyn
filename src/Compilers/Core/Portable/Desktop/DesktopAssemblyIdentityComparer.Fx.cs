// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#define NDP4_AUTO_VERSION_ROLLFORWARD

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;

namespace Microsoft.CodeAnalysis
{
    public partial class DesktopAssemblyIdentityComparer
    {
        private sealed class FrameworkAssemblyDictionary : Dictionary<string, FrameworkAssemblyDictionary.Value>
        {
            public FrameworkAssemblyDictionary()
            : base(f_176_782_800_C(f_176_782_800()))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(176, 721, 831);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(176, 721, 831);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(176, 721, 831);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(176, 721, 831);
                }
            }

            public struct Value
            {

                public readonly ImmutableArray<byte> PublicKeyToken;

                public readonly AssemblyVersion Version;

                public Value(ImmutableArray<byte> publicKeyToken, AssemblyVersion version)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterConstructor(176, 1029, 1245);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(176, 1144, 1181);

                        this.PublicKeyToken = publicKeyToken;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(176, 1203, 1226);

                        this.Version = version;
                        DynAbs.Tracing.TraceSender.TraceExitConstructor(176, 1029, 1245);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(176, 1029, 1245);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(176, 1029, 1245);
                    }
                }
                static Value()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(176, 847, 1260);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(176, 847, 1260);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(176, 847, 1260);
                }
            }

            public void Add(
                            string name,
                            ImmutableArray<byte> publicKeyToken,
                            AssemblyVersion version)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(176, 1276, 1512);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(176, 1451, 1497);

                    f_176_1451_1496(this, name, f_176_1461_1495(publicKeyToken, version));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(176, 1276, 1512);

                    Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer.FrameworkAssemblyDictionary.Value
                    f_176_1461_1495(System.Collections.Immutable.ImmutableArray<byte>
                    publicKeyToken, Microsoft.CodeAnalysis.AssemblyVersion
                    version)
                    {
                        var return_v = new Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer.FrameworkAssemblyDictionary.Value(publicKeyToken, version);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 1461, 1495);
                        return return_v;
                    }


                    int
                    f_176_1451_1496(Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer.FrameworkAssemblyDictionary
                    this_param, string
                    key, Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer.FrameworkAssemblyDictionary.Value
                    value)
                    {
                        this_param.Add(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 1451, 1496);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(176, 1276, 1512);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(176, 1276, 1512);
                }
            }

            static FrameworkAssemblyDictionary()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(176, 592, 1523);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(176, 592, 1523);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(176, 592, 1523);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(176, 592, 1523);

            static System.StringComparer
            f_176_782_800()
            {
                var return_v = SimpleNameComparer;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(176, 782, 800);
                return return_v;
            }


            static System.Collections.Generic.IEqualityComparer<string>
            f_176_782_800_C(System.Collections.Generic.IEqualityComparer<string>
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(176, 721, 831);
                return return_v;
            }

        }
        private sealed class FrameworkRetargetingDictionary : Dictionary<FrameworkRetargetingDictionary.Key, List<FrameworkRetargetingDictionary.Value>>
        {
            public FrameworkRetargetingDictionary()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(176, 1704, 1773);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(176, 1704, 1773);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(176, 1704, 1773);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(176, 1704, 1773);
                }
            }

            public struct Key : IEquatable<Key>
            {

                public readonly string Name;

                public readonly ImmutableArray<byte> PublicKeyToken;

                public Key(string name, ImmutableArray<byte> publicKeyToken)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterConstructor(176, 1975, 2171);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(176, 2076, 2093);

                        this.Name = name;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(176, 2115, 2152);

                        this.PublicKeyToken = publicKeyToken;
                        DynAbs.Tracing.TraceSender.TraceExitConstructor(176, 1975, 2171);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(176, 1975, 2171);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(176, 1975, 2171);
                    }
                }

                public bool Equals(Key other)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(176, 2191, 2420);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(176, 2261, 2401);

                        return f_176_2268_2316(f_176_2268_2286(), this.Name, other.Name) && (DynAbs.Tracing.TraceSender.Expression_True(176, 2268, 2400) && this.PublicKeyToken.SequenceEqual(other.PublicKeyToken));
                        DynAbs.Tracing.TraceSender.TraceExitMethod(176, 2191, 2420);

                        System.StringComparer
                        f_176_2268_2286()
                        {
                            var return_v = SimpleNameComparer;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(176, 2268, 2286);
                            return return_v;
                        }


                        bool
                        f_176_2268_2316(System.StringComparer
                        this_param, string
                        x, string
                        y)
                        {
                            var return_v = this_param.Equals(x, y);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 2268, 2316);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(176, 2191, 2420);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(176, 2191, 2420);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public override bool Equals(object? obj)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(176, 2440, 2578);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(176, 2521, 2559);

                        return obj is Key && (DynAbs.Tracing.TraceSender.Expression_True(176, 2528, 2558) && Equals(obj));
                        DynAbs.Tracing.TraceSender.TraceExitMethod(176, 2440, 2578);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(176, 2440, 2578);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(176, 2440, 2578);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public override int GetHashCode()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(176, 2598, 2755);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(176, 2672, 2736);

                        return f_176_2679_2715(f_176_2679_2697(), Name) ^ PublicKeyToken[0];
                        DynAbs.Tracing.TraceSender.TraceExitMethod(176, 2598, 2755);

                        System.StringComparer
                        f_176_2679_2697()
                        {
                            var return_v = SimpleNameComparer;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(176, 2679, 2697);
                            return return_v;
                        }


                        int
                        f_176_2679_2715(System.StringComparer
                        this_param, string
                        obj)
                        {
                            var return_v = this_param.GetHashCode(obj);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 2679, 2715);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(176, 2598, 2755);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(176, 2598, 2755);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                static Key()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(176, 1789, 2770);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(176, 1789, 2770);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(176, 1789, 2770);
                }
            }

            public struct Value
            {

                public readonly AssemblyVersion VersionLow;

                public readonly AssemblyVersion VersionHigh;

                public readonly string NewName;

                public readonly ImmutableArray<byte> NewPublicKeyToken;

                public readonly AssemblyVersion NewVersion;

                public readonly bool IsPortable;

                public Value(
                                    AssemblyVersion versionLow,
                                    AssemblyVersion versionHigh,
                                    string newName,
                                    ImmutableArray<byte> newPublicKeyToken,
                                    AssemblyVersion newVersion,
                                    bool isPortable)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterConstructor(176, 3196, 3817);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(176, 3534, 3558);

                        VersionLow = versionLow;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(176, 3580, 3606);

                        VersionHigh = versionHigh;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(176, 3628, 3646);

                        NewName = newName;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(176, 3668, 3706);

                        NewPublicKeyToken = newPublicKeyToken;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(176, 3728, 3752);

                        NewVersion = newVersion;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(176, 3774, 3798);

                        IsPortable = isPortable;
                        DynAbs.Tracing.TraceSender.TraceExitConstructor(176, 3196, 3817);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(176, 3196, 3817);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(176, 3196, 3817);
                    }
                }
            }

            public void Add(
                            string name,
                            ImmutableArray<byte> publicKeyToken,
                            AssemblyVersion versionLow,
                            object versionHighNull,
                            string newName,
                            ImmutableArray<byte> newPublicKeyToken,
                            AssemblyVersion newVersion)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(176, 3848, 4579);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(176, 4202, 4222);

                    List<Value>?
                    values
                    = default(List<Value>?);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(176, 4240, 4280);

                    var
                    key = f_176_4250_4279(name, publicKeyToken)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(176, 4298, 4429) || true) && (!f_176_4303_4331(this, key, out values))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(176, 4298, 4429);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(176, 4373, 4410);

                        f_176_4373_4409(this, key, values = f_176_4391_4408());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(176, 4298, 4429);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(176, 4449, 4564);

                    f_176_4449_4563(
                                    values, f_176_4460_4562(versionLow, versionHigh: default, newName, newPublicKeyToken, newVersion, isPortable: false));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(176, 3848, 4579);

                    Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer.FrameworkRetargetingDictionary.Key
                    f_176_4250_4279(string
                    name, System.Collections.Immutable.ImmutableArray<byte>
                    publicKeyToken)
                    {
                        var return_v = new Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer.FrameworkRetargetingDictionary.Key(name, publicKeyToken);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 4250, 4279);
                        return return_v;
                    }


                    bool
                    f_176_4303_4331(Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer.FrameworkRetargetingDictionary
                    this_param, Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer.FrameworkRetargetingDictionary.Key
                    key, out System.Collections.Generic.List<Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer.FrameworkRetargetingDictionary.Value>?
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 4303, 4331);
                        return return_v;
                    }


                    System.Collections.Generic.List<Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer.FrameworkRetargetingDictionary.Value>
                    f_176_4391_4408()
                    {
                        var return_v = new System.Collections.Generic.List<Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer.FrameworkRetargetingDictionary.Value>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 4391, 4408);
                        return return_v;
                    }


                    int
                    f_176_4373_4409(Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer.FrameworkRetargetingDictionary
                    this_param, Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer.FrameworkRetargetingDictionary.Key
                    key, System.Collections.Generic.List<Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer.FrameworkRetargetingDictionary.Value>
                    value)
                    {
                        this_param.Add(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 4373, 4409);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer.FrameworkRetargetingDictionary.Value
                    f_176_4460_4562(Microsoft.CodeAnalysis.AssemblyVersion
                    versionLow, Microsoft.CodeAnalysis.AssemblyVersion
                    versionHigh, string
                    newName, System.Collections.Immutable.ImmutableArray<byte>
                    newPublicKeyToken, Microsoft.CodeAnalysis.AssemblyVersion
                    newVersion, bool
                    isPortable)
                    {
                        var return_v = new Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer.FrameworkRetargetingDictionary.Value(versionLow, versionHigh: versionHigh, newName, newPublicKeyToken, newVersion, isPortable: isPortable);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 4460, 4562);
                        return return_v;
                    }


                    int
                    f_176_4449_4563(System.Collections.Generic.List<Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer.FrameworkRetargetingDictionary.Value>
                    this_param, Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer.FrameworkRetargetingDictionary.Value
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 4449, 4563);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(176, 3848, 4579);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(176, 3848, 4579);
                }
            }

            public void Add(
                            string name,
                            ImmutableArray<byte> publicKeyToken,
                            AssemblyVersion versionLow,
                            AssemblyVersion versionHigh,
                            string newName,
                            ImmutableArray<byte> newPublicKeyToken,
                            AssemblyVersion newVersion,
                            bool isPortable)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(176, 4595, 5349);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(176, 4988, 5008);

                    List<Value>?
                    values
                    = default(List<Value>?);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(176, 5026, 5066);

                    var
                    key = f_176_5036_5065(name, publicKeyToken)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(176, 5084, 5215) || true) && (!f_176_5089_5117(this, key, out values))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(176, 5084, 5215);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(176, 5159, 5196);

                        f_176_5159_5195(this, key, values = f_176_5177_5194());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(176, 5084, 5215);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(176, 5235, 5334);

                    f_176_5235_5333(
                                    values, f_176_5246_5332(versionLow, versionHigh, newName, newPublicKeyToken, newVersion, isPortable));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(176, 4595, 5349);

                    Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer.FrameworkRetargetingDictionary.Key
                    f_176_5036_5065(string
                    name, System.Collections.Immutable.ImmutableArray<byte>
                    publicKeyToken)
                    {
                        var return_v = new Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer.FrameworkRetargetingDictionary.Key(name, publicKeyToken);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 5036, 5065);
                        return return_v;
                    }


                    bool
                    f_176_5089_5117(Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer.FrameworkRetargetingDictionary
                    this_param, Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer.FrameworkRetargetingDictionary.Key
                    key, out System.Collections.Generic.List<Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer.FrameworkRetargetingDictionary.Value>?
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 5089, 5117);
                        return return_v;
                    }


                    System.Collections.Generic.List<Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer.FrameworkRetargetingDictionary.Value>
                    f_176_5177_5194()
                    {
                        var return_v = new System.Collections.Generic.List<Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer.FrameworkRetargetingDictionary.Value>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 5177, 5194);
                        return return_v;
                    }


                    int
                    f_176_5159_5195(Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer.FrameworkRetargetingDictionary
                    this_param, Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer.FrameworkRetargetingDictionary.Key
                    key, System.Collections.Generic.List<Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer.FrameworkRetargetingDictionary.Value>
                    value)
                    {
                        this_param.Add(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 5159, 5195);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer.FrameworkRetargetingDictionary.Value
                    f_176_5246_5332(Microsoft.CodeAnalysis.AssemblyVersion
                    versionLow, Microsoft.CodeAnalysis.AssemblyVersion
                    versionHigh, string
                    newName, System.Collections.Immutable.ImmutableArray<byte>
                    newPublicKeyToken, Microsoft.CodeAnalysis.AssemblyVersion
                    newVersion, bool
                    isPortable)
                    {
                        var return_v = new Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer.FrameworkRetargetingDictionary.Value(versionLow, versionHigh, newName, newPublicKeyToken, newVersion, isPortable);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 5246, 5332);
                        return return_v;
                    }


                    int
                    f_176_5235_5333(System.Collections.Generic.List<Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer.FrameworkRetargetingDictionary.Value>
                    this_param, Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer.FrameworkRetargetingDictionary.Value
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 5235, 5333);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(176, 4595, 5349);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(176, 4595, 5349);
                }
            }

            public bool TryGetValue(AssemblyIdentity identity, out Value value)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(176, 5365, 6496);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(176, 5465, 5485);

                    List<Value>?
                    values
                    = default(List<Value>?);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(176, 5503, 5692) || true) && (!f_176_5508_5580(this, f_176_5520_5567(f_176_5528_5541(identity), f_176_5543_5566(identity)), out values))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(176, 5503, 5692);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(176, 5622, 5638);

                        value = default;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(176, 5660, 5673);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(176, 5503, 5692);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(176, 5721, 5726);

                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(176, 5712, 6414) || true) && (i < f_176_5732_5744(values))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(176, 5746, 5749)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(176, 5712, 6414))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(176, 5712, 6414);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(176, 5791, 5809);

                            value = f_176_5799_5808(values, i);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(176, 5831, 5879);

                            var
                            version = (AssemblyVersion)f_176_5862_5878(identity)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(176, 5901, 6395) || true) && (value.VersionHigh.Major == 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(176, 5901, 6395);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(176, 5983, 6043);

                                f_176_5983_6042(value.VersionHigh == default(AssemblyVersion));

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(176, 6069, 6197) || true) && (version == value.VersionLow)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(176, 6069, 6197);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(176, 6158, 6170);

                                    return true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(176, 6069, 6197);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(176, 5901, 6395);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(176, 5901, 6395);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(176, 6247, 6395) || true) && (version >= value.VersionLow && (DynAbs.Tracing.TraceSender.Expression_True(176, 6251, 6310) && version <= value.VersionHigh))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(176, 6247, 6395);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(176, 6360, 6372);

                                    return true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(176, 6247, 6395);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(176, 5901, 6395);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(176, 1, 703);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(176, 1, 703);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(176, 6434, 6450);

                    value = default;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(176, 6468, 6481);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(176, 5365, 6496);

                    string
                    f_176_5528_5541(Microsoft.CodeAnalysis.AssemblyIdentity
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(176, 5528, 5541);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<byte>
                    f_176_5543_5566(Microsoft.CodeAnalysis.AssemblyIdentity
                    this_param)
                    {
                        var return_v = this_param.PublicKeyToken;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(176, 5543, 5566);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer.FrameworkRetargetingDictionary.Key
                    f_176_5520_5567(string
                    name, System.Collections.Immutable.ImmutableArray<byte>
                    publicKeyToken)
                    {
                        var return_v = new Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer.FrameworkRetargetingDictionary.Key(name, publicKeyToken);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 5520, 5567);
                        return return_v;
                    }


                    bool
                    f_176_5508_5580(Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer.FrameworkRetargetingDictionary
                    this_param, Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer.FrameworkRetargetingDictionary.Key
                    key, out System.Collections.Generic.List<Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer.FrameworkRetargetingDictionary.Value>?
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 5508, 5580);
                        return return_v;
                    }


                    int
                    f_176_5732_5744(System.Collections.Generic.List<Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer.FrameworkRetargetingDictionary.Value>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(176, 5732, 5744);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer.FrameworkRetargetingDictionary.Value
                    f_176_5799_5808(System.Collections.Generic.List<Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer.FrameworkRetargetingDictionary.Value>
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(176, 5799, 5808);
                        return return_v;
                    }


                    System.Version
                    f_176_5862_5878(Microsoft.CodeAnalysis.AssemblyIdentity
                    this_param)
                    {
                        var return_v = this_param.Version;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(176, 5862, 5878);
                        return return_v;
                    }


                    int
                    f_176_5983_6042(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(176, 5983, 6042);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(176, 5365, 6496);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(176, 5365, 6496);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static FrameworkRetargetingDictionary()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(176, 1535, 6507);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(176, 1535, 6507);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(176, 1535, 6507);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(176, 1535, 6507);
        }

        private static readonly ImmutableArray<byte> s_NETCF_PUBLIC_KEY_TOKEN_1;

        private static readonly ImmutableArray<byte> s_NETCF_PUBLIC_KEY_TOKEN_2;

        private static readonly ImmutableArray<byte> s_NETCF_PUBLIC_KEY_TOKEN_3;

        private static readonly ImmutableArray<byte> s_SQL_PUBLIC_KEY_TOKEN;

        private static readonly ImmutableArray<byte> s_SQL_MOBILE_PUBLIC_KEY_TOKEN;

        private static readonly ImmutableArray<byte> s_ECMA_PUBLICKEY_STR_L;

        private static readonly ImmutableArray<byte> s_SHAREDLIB_PUBLICKEY_STR_L;

        private static readonly ImmutableArray<byte> s_MICROSOFT_PUBLICKEY_STR_L;

        private static readonly ImmutableArray<byte> s_SILVERLIGHT_PLATFORM_PUBLICKEY_STR_L;

        private static readonly ImmutableArray<byte> s_SILVERLIGHT_PUBLICKEY_STR_L;

        private static readonly ImmutableArray<byte> s_RIA_SERVICES_KEY_TOKEN;

        private static readonly AssemblyVersion s_VER_VS_COMPATIBILITY_ASSEMBLYVERSION_STR_L;

        private static readonly AssemblyVersion s_VER_VS_ASSEMBLYVERSION_STR_L;

        private static readonly AssemblyVersion s_VER_SQL_ASSEMBLYVERSION_STR_L;

        private static readonly AssemblyVersion s_VER_LINQ_ASSEMBLYVERSION_STR_L;

        private static readonly AssemblyVersion s_VER_LINQ_ASSEMBLYVERSION_STR_2_L;

        private static readonly AssemblyVersion s_VER_SQL_ORCAS_ASSEMBLYVERSION_STR_L;

        private static readonly AssemblyVersion s_VER_ASSEMBLYVERSION_STR_L;

        private static readonly AssemblyVersion s_VER_VC_STLCLR_ASSEMBLYVERSION_STR_L;

        private const string
        NULL = null
        ;

        private const bool
        TRUE = true
        ;

        private static readonly FrameworkRetargetingDictionary s_arRetargetPolicy;

        private static readonly FrameworkAssemblyDictionary s_arFxPolicy;
    }
}
