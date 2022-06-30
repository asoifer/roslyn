// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    [DebuggerDisplay("{GetDebuggerDisplay(), nq}")]
    public sealed partial class AssemblyIdentity : IEquatable<AssemblyIdentity>
    {
        private readonly AssemblyContentType _contentType;

        private readonly string _name;

        private readonly Version _version;

        private readonly string _cultureName;

        private readonly ImmutableArray<byte> _publicKey;

        private ImmutableArray<byte> _lazyPublicKeyToken;

        private readonly bool _isRetargetable;

        private string? _lazyDisplayName;

        private int _lazyHashCode;

        internal const int
        PublicKeyTokenSize = 8
        ;

        private AssemblyIdentity(AssemblyIdentity other, Version version)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(420, 1974, 2559);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 1048, 1060);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 1130, 1135);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 1205, 1213);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 1367, 1379);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 1748, 1763);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 1824, 1840);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 1894, 1907);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 2064, 2100);

                f_420_2064_2099((object)other != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 2114, 2152);

                f_420_2114_2151((object)version != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 2168, 2201);

                _contentType = f_420_2183_2200(other);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 2215, 2235);

                _name = other._name;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 2249, 2283);

                _cultureName = other._cultureName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 2297, 2327);

                _publicKey = other._publicKey;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 2341, 2389);

                _lazyPublicKeyToken = other._lazyPublicKeyToken;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 2403, 2443);

                _isRetargetable = other._isRetargetable;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 2459, 2478);

                _version = version;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 2492, 2516);

                _lazyDisplayName = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 2530, 2548);

                _lazyHashCode = 0;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(420, 1974, 2559);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(420, 1974, 2559);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(420, 1974, 2559);
            }
        }

        internal AssemblyIdentity WithVersion(Version version)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(420, 2626, 2695);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 2629, 2695);
                return (DynAbs.Tracing.TraceSender.Conditional_F1(420, 2629, 2650) || (((version == _version) && DynAbs.Tracing.TraceSender.Conditional_F2(420, 2653, 2657)) || DynAbs.Tracing.TraceSender.Conditional_F3(420, 2660, 2695))) ? this : f_420_2660_2695(this, version); DynAbs.Tracing.TraceSender.TraceExitMethod(420, 2626, 2695);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(420, 2626, 2695);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(420, 2626, 2695);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.AssemblyIdentity
            f_420_2660_2695(Microsoft.CodeAnalysis.AssemblyIdentity
            other, System.Version
            version)
            {
                var return_v = new Microsoft.CodeAnalysis.AssemblyIdentity(other, version);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(420, 2660, 2695);
                return return_v;
            }

        }

        public AssemblyIdentity(
                    string? name,
                    Version? version = null,
                    string? cultureName = null,
                    ImmutableArray<byte> publicKeyOrToken = default,
                    bool hasPublicKey = false,
                    bool isRetargetable = false,
                    AssemblyContentType contentType = AssemblyContentType.Default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(420, 4862, 7235);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 1048, 1060);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 1130, 1135);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 1205, 1213);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 1367, 1379);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 1748, 1763);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 1824, 1840);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 1894, 1907);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 5237, 5412) || true) && (!f_420_5242_5262(contentType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(420, 5237, 5412);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 5296, 5397);

                    throw f_420_5302_5396(nameof(contentType), f_420_5355_5395());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(420, 5237, 5412);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 5428, 5605) || true) && (!f_420_5433_5450(name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(420, 5428, 5605);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 5484, 5590);

                    throw f_420_5490_5589(f_420_5512_5574(f_420_5526_5567(), name), nameof(name));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(420, 5428, 5605);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 5621, 5825) || true) && (!f_420_5626_5657(cultureName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(420, 5621, 5825);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 5691, 5810);

                    throw f_420_5697_5809(f_420_5719_5787(f_420_5733_5773(), cultureName), nameof(cultureName));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(420, 5621, 5825);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 5917, 6042) || true) && (!f_420_5922_5938(version))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(420, 5917, 6042);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 5972, 6027);

                    throw f_420_5978_6026(nameof(version));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(420, 5917, 6042);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 6058, 6652) || true) && (hasPublicKey)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(420, 6058, 6652);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 6108, 6318) || true) && (!f_420_6113_6163(publicKeyOrToken))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(420, 6108, 6318);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 6205, 6299);

                        throw f_420_6211_6298(f_420_6233_6271(), nameof(publicKeyOrToken));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(420, 6108, 6318);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(420, 6058, 6652);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(420, 6058, 6652);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 6384, 6637) || true) && (f_420_6388_6422_M(!publicKeyOrToken.IsDefaultOrEmpty) && (DynAbs.Tracing.TraceSender.Expression_True(420, 6388, 6471) && publicKeyOrToken.Length != PublicKeyTokenSize))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(420, 6384, 6637);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 6513, 6618);

                        throw f_420_6519_6617(f_420_6541_6590(), nameof(publicKeyOrToken));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(420, 6384, 6637);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(420, 6058, 6652);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 6668, 6895) || true) && (isRetargetable && (DynAbs.Tracing.TraceSender.Expression_True(420, 6672, 6739) && contentType == AssemblyContentType.WindowsRuntime))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(420, 6668, 6895);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 6773, 6880);

                    throw f_420_6779_6879(f_420_6801_6854(), nameof(isRetargetable));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(420, 6668, 6895);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 6911, 6924);

                _name = name;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 6938, 6972);

                _version = version ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Version?>(420, 6949, 6971) ?? NullVersion);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 6986, 7035);

                _cultureName = f_420_7001_7034(cultureName);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 7049, 7082);

                _isRetargetable = isRetargetable;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 7096, 7123);

                _contentType = contentType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 7137, 7224);

                f_420_7137_7223(publicKeyOrToken, hasPublicKey, out _publicKey, out _lazyPublicKeyToken);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(420, 4862, 7235);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(420, 4862, 7235);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(420, 4862, 7235);
            }
        }

        internal AssemblyIdentity(
                    string name,
                    Version version,
                    string? cultureName,
                    ImmutableArray<byte> publicKeyOrToken,
                    bool hasPublicKey)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(420, 7311, 8219);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 1048, 1060);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 1130, 1135);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 1205, 1213);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 1367, 1379);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 1748, 1763);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 1824, 1840);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 1894, 1907);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 7536, 7563);

                f_420_7536_7562(name != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 7577, 7608);

                f_420_7577_7607(f_420_7590_7606(version));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 7622, 7668);

                f_420_7622_7667(f_420_7635_7666(cultureName));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 7682, 7872);

                f_420_7682_7871((hasPublicKey && (DynAbs.Tracing.TraceSender.Expression_True(420, 7696, 7762) && f_420_7712_7762(publicKeyOrToken))) || (DynAbs.Tracing.TraceSender.Expression_False(420, 7695, 7870) || (!hasPublicKey && (DynAbs.Tracing.TraceSender.Expression_True(420, 7768, 7869) && (publicKeyOrToken.IsDefaultOrEmpty || (DynAbs.Tracing.TraceSender.Expression_False(420, 7786, 7868) || publicKeyOrToken.Length == PublicKeyTokenSize))))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 7888, 7901);

                _name = name;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 7915, 7949);

                _version = version ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Version>(420, 7926, 7948) ?? NullVersion);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 7963, 8012);

                _cultureName = f_420_7978_8011(cultureName);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 8026, 8050);

                _isRetargetable = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 8064, 8107);

                _contentType = AssemblyContentType.Default;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 8121, 8208);

                f_420_8121_8207(publicKeyOrToken, hasPublicKey, out _publicKey, out _lazyPublicKeyToken);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(420, 7311, 8219);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(420, 7311, 8219);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(420, 7311, 8219);
            }
        }

        internal AssemblyIdentity(
                    bool noThrow,
                    string name,
                    Version? version = null,
                    string? cultureName = null,
                    ImmutableArray<byte> publicKeyOrToken = default,
                    bool hasPublicKey = false,
                    bool isRetargetable = false,
                    AssemblyContentType contentType = AssemblyContentType.Default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(420, 8280, 9397);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 1048, 1060);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 1130, 1135);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 1205, 1213);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 1367, 1379);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 1748, 1763);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 1824, 1840);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 1894, 1907);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 8683, 8710);

                f_420_8683_8709(name != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 8724, 8914);

                f_420_8724_8913((hasPublicKey && (DynAbs.Tracing.TraceSender.Expression_True(420, 8738, 8804) && f_420_8754_8804(publicKeyOrToken))) || (DynAbs.Tracing.TraceSender.Expression_False(420, 8737, 8912) || (!hasPublicKey && (DynAbs.Tracing.TraceSender.Expression_True(420, 8810, 8911) && (publicKeyOrToken.IsDefaultOrEmpty || (DynAbs.Tracing.TraceSender.Expression_False(420, 8828, 8910) || publicKeyOrToken.Length == PublicKeyTokenSize))))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 8928, 8950);

                f_420_8928_8949(noThrow);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 8966, 8979);

                _name = name;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 8993, 9027);

                _version = version ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Version?>(420, 9004, 9026) ?? NullVersion);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 9041, 9090);

                _cultureName = f_420_9056_9089(cultureName);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 9104, 9184);

                _contentType = (DynAbs.Tracing.TraceSender.Conditional_F1(420, 9119, 9139) || ((f_420_9119_9139(contentType) && DynAbs.Tracing.TraceSender.Conditional_F2(420, 9142, 9153)) || DynAbs.Tracing.TraceSender.Conditional_F3(420, 9156, 9183))) ? contentType : AssemblyContentType.Default;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 9198, 9285);

                _isRetargetable = isRetargetable && (DynAbs.Tracing.TraceSender.Expression_True(420, 9216, 9284) && _contentType != AssemblyContentType.WindowsRuntime);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 9299, 9386);

                f_420_9299_9385(publicKeyOrToken, hasPublicKey, out _publicKey, out _lazyPublicKeyToken);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(420, 8280, 9397);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(420, 8280, 9397);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(420, 8280, 9397);
            }
        }

        private static string NormalizeCultureName(string? cultureName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(420, 9409, 10398);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 10225, 10387);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(420, 10232, 10340) || ((cultureName == null || (DynAbs.Tracing.TraceSender.Expression_False(420, 10232, 10340) || f_420_10255_10340(f_420_10255_10295(), cultureName, InvariantCultureDisplay)) && DynAbs.Tracing.TraceSender.Conditional_F2(420, 10360, 10372)) || DynAbs.Tracing.TraceSender.Conditional_F3(420, 10375, 10386))) ? string.Empty : cultureName;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(420, 9409, 10398);

                System.StringComparer
                f_420_10255_10295()
                {
                    var return_v = AssemblyIdentityComparer.CultureComparer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(420, 10255, 10295);
                    return return_v;
                }


                bool
                f_420_10255_10340(System.StringComparer
                this_param, string
                x, string
                y)
                {
                    var return_v = this_param.Equals(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(420, 10255, 10340);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(420, 9409, 10398);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(420, 9409, 10398);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void InitializeKey(ImmutableArray<byte> publicKeyOrToken, bool hasPublicKey,
                    out ImmutableArray<byte> publicKey, out ImmutableArray<byte> publicKeyToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(420, 10410, 10935);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 10616, 10924) || true) && (hasPublicKey)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(420, 10616, 10924);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 10666, 10695);

                    publicKey = publicKeyOrToken;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 10713, 10738);

                    publicKeyToken = default;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(420, 10616, 10924);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(420, 10616, 10924);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 10804, 10843);

                    publicKey = ImmutableArray<byte>.Empty;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 10861, 10909);

                    publicKeyToken = publicKeyOrToken.NullToEmpty();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(420, 10616, 10924);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(420, 10410, 10935);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(420, 10410, 10935);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(420, 10410, 10935);
            }
        }

        internal static bool IsValidCultureName(string? name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(420, 10947, 11561);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 11504, 11550);

                return name == null || (DynAbs.Tracing.TraceSender.Expression_False(420, 11511, 11549) || f_420_11527_11545(name, '\0') < 0);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(420, 10947, 11561);

                int
                f_420_11527_11545(string
                this_param, char
                value)
                {
                    var return_v = this_param.IndexOf(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(420, 11527, 11545);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(420, 10947, 11561);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(420, 10947, 11561);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsValidName([NotNullWhen(true)] string? name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(420, 11573, 11735);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 11663, 11724);

                return !f_420_11671_11697(name) && (DynAbs.Tracing.TraceSender.Expression_True(420, 11670, 11723) && f_420_11701_11719(name, '\0') < 0);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(420, 11573, 11735);

                bool
                f_420_11671_11697(string?
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(420, 11671, 11697);
                    return return_v;
                }


                int
                f_420_11701_11719(string
                this_param, char
                value)
                {
                    var return_v = this_param.IndexOf(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(420, 11701, 11719);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(420, 11573, 11735);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(420, 11573, 11735);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static readonly Version NullVersion;

        private static bool IsValid(Version? value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(420, 11830, 12288);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 11898, 12277);

                return value == null
                || (DynAbs.Tracing.TraceSender.Expression_False(420, 11905, 12276) || f_420_11939_11950(value) >= 0
                && (DynAbs.Tracing.TraceSender.Expression_True(420, 11939, 11992) && f_420_11976_11987(value) >= 0
                ) && (DynAbs.Tracing.TraceSender.Expression_True(420, 11939, 12029) && f_420_12013_12024(value) >= 0
                ) && (DynAbs.Tracing.TraceSender.Expression_True(420, 11939, 12069) && f_420_12050_12064(value) >= 0
                ) && (DynAbs.Tracing.TraceSender.Expression_True(420, 11939, 12120) && f_420_12090_12101(value) <= ushort.MaxValue
                ) && (DynAbs.Tracing.TraceSender.Expression_True(420, 11939, 12171) && f_420_12141_12152(value) <= ushort.MaxValue
                ) && (DynAbs.Tracing.TraceSender.Expression_True(420, 11939, 12222) && f_420_12192_12203(value) <= ushort.MaxValue
                ) && (DynAbs.Tracing.TraceSender.Expression_True(420, 11939, 12276) && f_420_12243_12257(value) <= ushort.MaxValue));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(420, 11830, 12288);

                int
                f_420_11939_11950(System.Version
                this_param)
                {
                    var return_v = this_param.Major;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(420, 11939, 11950);
                    return return_v;
                }


                int
                f_420_11976_11987(System.Version
                this_param)
                {
                    var return_v = this_param.Minor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(420, 11976, 11987);
                    return return_v;
                }


                int
                f_420_12013_12024(System.Version
                this_param)
                {
                    var return_v = this_param.Build;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(420, 12013, 12024);
                    return return_v;
                }


                int
                f_420_12050_12064(System.Version
                this_param)
                {
                    var return_v = this_param.Revision;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(420, 12050, 12064);
                    return return_v;
                }


                int
                f_420_12090_12101(System.Version
                this_param)
                {
                    var return_v = this_param.Major;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(420, 12090, 12101);
                    return return_v;
                }


                int
                f_420_12141_12152(System.Version
                this_param)
                {
                    var return_v = this_param.Minor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(420, 12141, 12152);
                    return return_v;
                }


                int
                f_420_12192_12203(System.Version
                this_param)
                {
                    var return_v = this_param.Build;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(420, 12192, 12203);
                    return return_v;
                }


                int
                f_420_12243_12257(System.Version
                this_param)
                {
                    var return_v = this_param.Revision;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(420, 12243, 12257);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(420, 11830, 12288);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(420, 11830, 12288);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsValid(AssemblyContentType value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(420, 12300, 12481);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 12379, 12470);

                return value >= AssemblyContentType.Default && (DynAbs.Tracing.TraceSender.Expression_True(420, 12386, 12469) && value <= AssemblyContentType.WindowsRuntime);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(420, 12300, 12481);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(420, 12300, 12481);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(420, 12300, 12481);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(420, 12607, 12628);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 12613, 12626);

                    return _name;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(420, 12607, 12628);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(420, 12586, 12630);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(420, 12586, 12630);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public Version Version
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(420, 12756, 12780);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 12762, 12778);

                    return _version;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(420, 12756, 12780);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(420, 12731, 12782);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(420, 12731, 12782);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public string CultureName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(420, 12952, 12980);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 12958, 12978);

                    return _cultureName;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(420, 12952, 12980);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(420, 12924, 12982);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(420, 12924, 12982);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public AssemblyNameFlags Flags
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(420, 13132, 13362);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 13168, 13347);

                    return ((DynAbs.Tracing.TraceSender.Conditional_F1(420, 13176, 13191) || ((_isRetargetable && DynAbs.Tracing.TraceSender.Conditional_F2(420, 13194, 13224)) || DynAbs.Tracing.TraceSender.Conditional_F3(420, 13227, 13249))) ? AssemblyNameFlags.Retargetable : AssemblyNameFlags.None) |
                                           ((DynAbs.Tracing.TraceSender.Conditional_F1(420, 13278, 13290) || ((f_420_13278_13290() && DynAbs.Tracing.TraceSender.Conditional_F2(420, 13293, 13320)) || DynAbs.Tracing.TraceSender.Conditional_F3(420, 13323, 13345))) ? AssemblyNameFlags.PublicKey : AssemblyNameFlags.None);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(420, 13132, 13362);

                    bool
                    f_420_13278_13290()
                    {
                        var return_v = HasPublicKey;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(420, 13278, 13290);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(420, 13077, 13373);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(420, 13077, 13373);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public AssemblyContentType ContentType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(420, 13665, 13693);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 13671, 13691);

                    return _contentType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(420, 13665, 13693);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(420, 13602, 13704);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(420, 13602, 13704);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool HasPublicKey
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(420, 13881, 13918);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 13887, 13916);

                    return _publicKey.Length > 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(420, 13881, 13918);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(420, 13832, 13929);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(420, 13832, 13929);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ImmutableArray<byte> PublicKey
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(420, 14089, 14115);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 14095, 14113);

                    return _publicKey;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(420, 14089, 14115);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(420, 14027, 14126);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(420, 14027, 14126);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ImmutableArray<byte> PublicKeyToken
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(420, 14319, 14630);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 14355, 14568) || true) && (_lazyPublicKeyToken.IsDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(420, 14355, 14568);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 14430, 14549);

                        f_420_14430_14548(ref _lazyPublicKeyToken, f_420_14503_14538(_publicKey), default);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(420, 14355, 14568);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 14588, 14615);

                    return _lazyPublicKeyToken;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(420, 14319, 14630);

                    System.Collections.Immutable.ImmutableArray<byte>
                    f_420_14503_14538(System.Collections.Immutable.ImmutableArray<byte>
                    publicKey)
                    {
                        var return_v = CalculatePublicKeyToken(publicKey);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(420, 14503, 14538);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<byte>
                    f_420_14430_14548(ref System.Collections.Immutable.ImmutableArray<byte>
                    location, System.Collections.Immutable.ImmutableArray<byte>
                    value, System.Collections.Immutable.ImmutableArray<byte>
                    comparand)
                    {
                        var return_v = ImmutableInterlocked.InterlockedCompareExchange(ref location, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(420, 14430, 14548);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(420, 14252, 14641);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(420, 14252, 14641);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsStrongName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(420, 14852, 15129);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 14979, 15040);

                    f_420_14979_15039(f_420_14992_15004() || (DynAbs.Tracing.TraceSender.Expression_False(420, 14992, 15038) || f_420_15008_15038_M(!_lazyPublicKeyToken.IsDefault)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 15060, 15114);

                    return f_420_15067_15079() || (DynAbs.Tracing.TraceSender.Expression_False(420, 15067, 15113) || _lazyPublicKeyToken.Length > 0);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(420, 14852, 15129);

                    bool
                    f_420_14992_15004()
                    {
                        var return_v = HasPublicKey;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(420, 14992, 15004);
                        return return_v;
                    }


                    bool
                    f_420_15008_15038_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(420, 15008, 15038);
                        return return_v;
                    }


                    int
                    f_420_14979_15039(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(420, 14979, 15039);
                        return 0;
                    }


                    bool
                    f_420_15067_15079()
                    {
                        var return_v = HasPublicKey;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(420, 15067, 15079);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(420, 14803, 15140);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(420, 14803, 15140);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsRetargetable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(420, 15328, 15359);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 15334, 15357);

                    return _isRetargetable;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(420, 15328, 15359);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(420, 15277, 15370);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(420, 15277, 15370);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static bool IsFullName(AssemblyIdentityParts parts)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(420, 15382, 15702);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 15467, 15592);

                const AssemblyIdentityParts
                nvc = AssemblyIdentityParts.Name | AssemblyIdentityParts.Version | AssemblyIdentityParts.Culture
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 15606, 15691);

                return (parts & nvc) == nvc && (DynAbs.Tracing.TraceSender.Expression_True(420, 15613, 15690) && (parts & AssemblyIdentityParts.PublicKeyOrToken) != 0);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(420, 15382, 15702);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(420, 15382, 15702);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(420, 15382, 15702);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool operator ==(AssemblyIdentity? left, AssemblyIdentity? right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(420, 16083, 16268);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 16187, 16257);

                return f_420_16194_16256(f_420_16194_16236(), left, right);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(420, 16083, 16268);

                System.Collections.Generic.EqualityComparer<Microsoft.CodeAnalysis.AssemblyIdentity>
                f_420_16194_16236()
                {
                    var return_v = EqualityComparer<AssemblyIdentity>.Default;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(420, 16194, 16236);
                    return return_v;
                }


                bool
                f_420_16194_16256(System.Collections.Generic.EqualityComparer<Microsoft.CodeAnalysis.AssemblyIdentity>
                this_param, Microsoft.CodeAnalysis.AssemblyIdentity?
                x, Microsoft.CodeAnalysis.AssemblyIdentity?
                y)
                {
                    var return_v = this_param.Equals(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(420, 16194, 16256);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(420, 16083, 16268);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(420, 16083, 16268);
            }
        }

        public static bool operator !=(AssemblyIdentity? left, AssemblyIdentity? right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(420, 16613, 16752);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 16717, 16741);

                return !(left == right);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(420, 16613, 16752);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(420, 16613, 16752);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(420, 16613, 16752);
            }
        }

        public bool Equals(AssemblyIdentity? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(420, 16992, 17264);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 17058, 17253);

                return !f_420_17066_17092(obj, null) && (DynAbs.Tracing.TraceSender.Expression_True(420, 17065, 17197) && (_lazyHashCode == 0 || (DynAbs.Tracing.TraceSender.Expression_False(420, 17114, 17158) || obj._lazyHashCode == 0) || (DynAbs.Tracing.TraceSender.Expression_False(420, 17114, 17196) || _lazyHashCode == obj._lazyHashCode))
                ) && (DynAbs.Tracing.TraceSender.Expression_True(420, 17065, 17252) && f_420_17218_17244(this, obj) == true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(420, 16992, 17264);

                bool
                f_420_17066_17092(Microsoft.CodeAnalysis.AssemblyIdentity?
                objA, object?
                objB)
                {
                    var return_v = ReferenceEquals((object?)objA, objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(420, 17066, 17092);
                    return return_v;
                }


                bool?
                f_420_17218_17244(Microsoft.CodeAnalysis.AssemblyIdentity
                x, Microsoft.CodeAnalysis.AssemblyIdentity
                y)
                {
                    var return_v = MemberwiseEqual(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(420, 17218, 17244);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(420, 16992, 17264);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(420, 16992, 17264);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(420, 17504, 17619);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 17569, 17608);

                return f_420_17576_17607(this, obj as AssemblyIdentity);
                DynAbs.Tracing.TraceSender.TraceExitMethod(420, 17504, 17619);

                bool
                f_420_17576_17607(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param, object?
                obj)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.AssemblyIdentity?)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(420, 17576, 17607);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(420, 17504, 17619);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(420, 17504, 17619);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(420, 17772, 18368);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 17830, 18320) || true) && (_lazyHashCode == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(420, 17830, 18320);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 18095, 18305);

                    _lazyHashCode =
                    f_420_18132_18304(f_420_18145_18207(f_420_18145_18188(), _name), f_420_18230_18303(f_420_18243_18265(_version), f_420_18267_18302(this)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(420, 17830, 18320);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 18336, 18357);

                return _lazyHashCode;
                DynAbs.Tracing.TraceSender.TraceExitMethod(420, 17772, 18368);

                System.StringComparer
                f_420_18145_18188()
                {
                    var return_v = AssemblyIdentityComparer.SimpleNameComparer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(420, 18145, 18188);
                    return return_v;
                }


                int
                f_420_18145_18207(System.StringComparer
                this_param, string
                obj)
                {
                    var return_v = this_param.GetHashCode(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(420, 18145, 18207);
                    return return_v;
                }


                int
                f_420_18243_18265(System.Version
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(420, 18243, 18265);
                    return return_v;
                }


                int
                f_420_18267_18302(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.GetHashCodeIgnoringNameAndVersion();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(420, 18267, 18302);
                    return return_v;
                }


                int
                f_420_18230_18303(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(420, 18230, 18303);
                    return return_v;
                }


                int
                f_420_18132_18304(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(420, 18132, 18304);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(420, 17772, 18368);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(420, 17772, 18368);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal int GetHashCodeIgnoringNameAndVersion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(420, 18380, 18653);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 18453, 18642);

                return
                f_420_18477_18641(_contentType, f_420_18526_18640(_isRetargetable, f_420_18573_18639(f_420_18573_18613(), _cultureName)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(420, 18380, 18653);

                System.StringComparer
                f_420_18573_18613()
                {
                    var return_v = AssemblyIdentityComparer.CultureComparer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(420, 18573, 18613);
                    return return_v;
                }


                int
                f_420_18573_18639(System.StringComparer
                this_param, string
                obj)
                {
                    var return_v = this_param.GetHashCode(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(420, 18573, 18639);
                    return return_v;
                }


                int
                f_420_18526_18640(bool
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(420, 18526, 18640);
                    return return_v;
                }


                int
                f_420_18477_18641(System.Reflection.AssemblyContentType
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine((int)newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(420, 18477, 18641);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(420, 18380, 18653);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(420, 18380, 18653);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ImmutableArray<byte> CalculatePublicKeyToken(ImmutableArray<byte> publicKey)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(420, 18698, 19402);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 18815, 18875);

                var
                hash = f_420_18826_18874(publicKey)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 18937, 19005);

                f_420_18937_19004(hash.Length == CryptographicHashProvider.Sha1HashSize);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 19108, 19132);

                int
                l = hash.Length - 1
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 19146, 19210);

                var
                result = f_420_19159_19209(PublicKeyTokenSize)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 19233, 19238);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 19224, 19340) || true) && (i < PublicKeyTokenSize)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 19264, 19267)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(420, 19224, 19340))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(420, 19224, 19340);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 19301, 19325);

                        f_420_19301_19324(result, hash[l - i]);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(420, 1, 117);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(420, 1, 117);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 19356, 19391);

                return f_420_19363_19390(result);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(420, 18698, 19402);

                System.Collections.Immutable.ImmutableArray<byte>
                f_420_18826_18874(System.Collections.Immutable.ImmutableArray<byte>
                bytes)
                {
                    var return_v = CryptographicHashProvider.ComputeSha1(bytes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(420, 18826, 18874);
                    return return_v;
                }


                int
                f_420_18937_19004(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(420, 18937, 19004);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<byte>
                f_420_19159_19209(int
                capacity)
                {
                    var return_v = ArrayBuilder<byte>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(420, 19159, 19209);
                    return return_v;
                }


                int
                f_420_19301_19324(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<byte>
                this_param, byte
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(420, 19301, 19324);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_420_19363_19390(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<byte>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(420, 19363, 19390);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(420, 18698, 19402);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(420, 18698, 19402);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool? MemberwiseEqual(AssemblyIdentity x, AssemblyIdentity y)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(420, 19727, 20252);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 19829, 19915) || true) && (f_420_19833_19854(x, y))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(420, 19829, 19915);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 19888, 19900);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(420, 19829, 19915);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 19931, 20066) || true) && (!f_420_19936_20004(f_420_19936_19979(), x._name, y._name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(420, 19931, 20066);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 20038, 20051);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(420, 19931, 20066);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 20082, 20213) || true) && (f_420_20086_20115(x._version, y._version) && (DynAbs.Tracing.TraceSender.Expression_True(420, 20086, 20152) && f_420_20119_20152(x, y)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(420, 20082, 20213);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 20186, 20198);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(420, 20082, 20213);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 20229, 20241);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(420, 19727, 20252);

                bool
                f_420_19833_19854(Microsoft.CodeAnalysis.AssemblyIdentity
                objA, Microsoft.CodeAnalysis.AssemblyIdentity
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(420, 19833, 19854);
                    return return_v;
                }


                System.StringComparer
                f_420_19936_19979()
                {
                    var return_v = AssemblyIdentityComparer.SimpleNameComparer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(420, 19936, 19979);
                    return return_v;
                }


                bool
                f_420_19936_20004(System.StringComparer
                this_param, string
                x, string
                y)
                {
                    var return_v = this_param.Equals(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(420, 19936, 20004);
                    return return_v;
                }


                bool
                f_420_20086_20115(System.Version
                this_param, System.Version
                obj)
                {
                    var return_v = this_param.Equals(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(420, 20086, 20115);
                    return return_v;
                }


                bool
                f_420_20119_20152(Microsoft.CodeAnalysis.AssemblyIdentity
                x, Microsoft.CodeAnalysis.AssemblyIdentity
                y)
                {
                    var return_v = EqualIgnoringNameAndVersion(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(420, 20119, 20152);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(420, 19727, 20252);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(420, 19727, 20252);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool EqualIgnoringNameAndVersion(AssemblyIdentity x, AssemblyIdentity y)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(420, 20264, 20634);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 20377, 20623);

                return
                f_420_20401_20417(x) == f_420_20421_20437(y) && (DynAbs.Tracing.TraceSender.Expression_True(420, 20401, 20488) && f_420_20458_20471(x) == f_420_20475_20488(y)) && (DynAbs.Tracing.TraceSender.Expression_True(420, 20401, 20586) && f_420_20509_20586(f_420_20509_20549(), f_420_20557_20570(x), f_420_20572_20585(y))) && (DynAbs.Tracing.TraceSender.Expression_True(420, 20401, 20622) && f_420_20607_20622(x, y));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(420, 20264, 20634);

                bool
                f_420_20401_20417(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.IsRetargetable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(420, 20401, 20417);
                    return return_v;
                }


                bool
                f_420_20421_20437(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.IsRetargetable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(420, 20421, 20437);
                    return return_v;
                }


                System.Reflection.AssemblyContentType
                f_420_20458_20471(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.ContentType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(420, 20458, 20471);
                    return return_v;
                }


                System.Reflection.AssemblyContentType
                f_420_20475_20488(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.ContentType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(420, 20475, 20488);
                    return return_v;
                }


                System.StringComparer
                f_420_20509_20549()
                {
                    var return_v = AssemblyIdentityComparer.CultureComparer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(420, 20509, 20549);
                    return return_v;
                }


                string
                f_420_20557_20570(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.CultureName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(420, 20557, 20570);
                    return return_v;
                }


                string
                f_420_20572_20585(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.CultureName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(420, 20572, 20585);
                    return return_v;
                }


                bool
                f_420_20509_20586(System.StringComparer
                this_param, string
                x, string
                y)
                {
                    var return_v = this_param.Equals(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(420, 20509, 20586);
                    return return_v;
                }


                bool
                f_420_20607_20622(Microsoft.CodeAnalysis.AssemblyIdentity
                x, Microsoft.CodeAnalysis.AssemblyIdentity
                y)
                {
                    var return_v = KeysEqual(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(420, 20607, 20622);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(420, 20264, 20634);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(420, 20264, 20634);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool KeysEqual(AssemblyIdentity x, AssemblyIdentity y)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(420, 20646, 21637);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 20741, 20776);

                var
                xToken = x._lazyPublicKeyToken
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 20790, 20825);

                var
                yToken = y._lazyPublicKeyToken
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 20928, 21055) || true) && (f_420_20932_20949_M(!xToken.IsDefault) && (DynAbs.Tracing.TraceSender.Expression_True(420, 20932, 20970) && f_420_20953_20970_M(!yToken.IsDefault)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(420, 20928, 21055);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 21004, 21040);

                    return xToken.SequenceEqual(yToken);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(420, 20928, 21055);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 21153, 21290) || true) && (xToken.IsDefault && (DynAbs.Tracing.TraceSender.Expression_True(420, 21157, 21193) && yToken.IsDefault))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(420, 21153, 21290);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 21227, 21275);

                    return x._publicKey.SequenceEqual(y._publicKey);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(420, 21153, 21290);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 21399, 21626) || true) && (xToken.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(420, 21399, 21626);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 21453, 21499);

                    return x.PublicKeyToken.SequenceEqual(yToken);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(420, 21399, 21626);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(420, 21399, 21626);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 21565, 21611);

                    return xToken.SequenceEqual(f_420_21593_21609(y));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(420, 21399, 21626);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(420, 20646, 21637);

                bool
                f_420_20932_20949_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(420, 20932, 20949);
                    return return_v;
                }


                bool
                f_420_20953_20970_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(420, 20953, 20970);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_420_21593_21609(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.PublicKeyToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(420, 21593, 21609);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(420, 20646, 21637);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(420, 20646, 21637);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static AssemblyIdentity FromAssemblyDefinition(Assembly assembly)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(420, 22074, 22367);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 22171, 22290) || true) && (assembly == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(420, 22171, 22290);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 22225, 22275);

                    throw f_420_22231_22274(nameof(assembly));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(420, 22171, 22290);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 22306, 22356);

                return f_420_22313_22355(f_420_22336_22354(assembly));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(420, 22074, 22367);

                System.ArgumentNullException
                f_420_22231_22274(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(420, 22231, 22274);
                    return return_v;
                }


                System.Reflection.AssemblyName
                f_420_22336_22354(System.Reflection.Assembly
                this_param)
                {
                    var return_v = this_param.GetName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(420, 22336, 22354);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_420_22313_22355(System.Reflection.AssemblyName
                name)
                {
                    var return_v = FromAssemblyDefinition(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(420, 22313, 22355);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(420, 22074, 22367);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(420, 22074, 22367);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static AssemblyIdentity FromAssemblyDefinition(AssemblyName name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(420, 22412, 23116);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 22570, 22611);

                var
                publicKeyBytes = f_420_22591_22610(name)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 22625, 22752);

                ImmutableArray<byte>
                publicKey = (DynAbs.Tracing.TraceSender.Conditional_F1(420, 22658, 22682) || (((publicKeyBytes != null) && DynAbs.Tracing.TraceSender.Conditional_F2(420, 22685, 22722)) || DynAbs.Tracing.TraceSender.Conditional_F3(420, 22725, 22751))) ? f_420_22685_22722(publicKeyBytes) : ImmutableArray<byte>.Empty
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 22768, 23105);

                return f_420_22775_23104(f_420_22814_22823(name), f_420_22842_22854(name), f_420_22873_22889(name), publicKey, hasPublicKey: publicKey.Length > 0, isRetargetable: (f_420_23006_23016(name) & AssemblyNameFlags.Retargetable) != 0, contentType: f_420_23087_23103(name));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(420, 22412, 23116);

                byte[]?
                f_420_22591_22610(System.Reflection.AssemblyName
                this_param)
                {
                    var return_v = this_param.GetPublicKey();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(420, 22591, 22610);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_420_22685_22722(params byte[]
                items)
                {
                    var return_v = ImmutableArray.Create(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(420, 22685, 22722);
                    return return_v;
                }


                string?
                f_420_22814_22823(System.Reflection.AssemblyName
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(420, 22814, 22823);
                    return return_v;
                }


                System.Version?
                f_420_22842_22854(System.Reflection.AssemblyName
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(420, 22842, 22854);
                    return return_v;
                }


                string?
                f_420_22873_22889(System.Reflection.AssemblyName
                this_param)
                {
                    var return_v = this_param.CultureName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(420, 22873, 22889);
                    return return_v;
                }


                System.Reflection.AssemblyNameFlags
                f_420_23006_23016(System.Reflection.AssemblyName
                this_param)
                {
                    var return_v = this_param.Flags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(420, 23006, 23016);
                    return return_v;
                }


                System.Reflection.AssemblyContentType
                f_420_23087_23103(System.Reflection.AssemblyName
                this_param)
                {
                    var return_v = this_param.ContentType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(420, 23087, 23103);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_420_22775_23104(string?
                name, System.Version?
                version, string?
                cultureName, System.Collections.Immutable.ImmutableArray<byte>
                publicKeyOrToken, bool
                hasPublicKey, bool
                isRetargetable, System.Reflection.AssemblyContentType
                contentType)
                {
                    var return_v = new Microsoft.CodeAnalysis.AssemblyIdentity(name, version, cultureName, publicKeyOrToken, hasPublicKey: hasPublicKey, isRetargetable: isRetargetable, contentType: contentType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(420, 22775, 23104);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(420, 22412, 23116);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(420, 22412, 23116);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static AssemblyIdentity FromAssemblyReference(AssemblyName name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(420, 23128, 23651);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 23280, 23640);

                return f_420_23287_23639(f_420_23326_23335(name), f_420_23354_23366(name), f_420_23385_23401(name), f_420_23420_23467(f_420_23442_23466(name)), hasPublicKey: false, isRetargetable: (f_420_23541_23551(name) & AssemblyNameFlags.Retargetable) != 0, contentType: f_420_23622_23638(name));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(420, 23128, 23651);

                string?
                f_420_23326_23335(System.Reflection.AssemblyName
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(420, 23326, 23335);
                    return return_v;
                }


                System.Version?
                f_420_23354_23366(System.Reflection.AssemblyName
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(420, 23354, 23366);
                    return return_v;
                }


                string?
                f_420_23385_23401(System.Reflection.AssemblyName
                this_param)
                {
                    var return_v = this_param.CultureName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(420, 23385, 23401);
                    return return_v;
                }


                byte[]?
                f_420_23442_23466(System.Reflection.AssemblyName
                this_param)
                {
                    var return_v = this_param.GetPublicKeyToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(420, 23442, 23466);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_420_23420_23467(params byte[]?
                items)
                {
                    var return_v = ImmutableArray.Create(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(420, 23420, 23467);
                    return return_v;
                }


                System.Reflection.AssemblyNameFlags
                f_420_23541_23551(System.Reflection.AssemblyName
                this_param)
                {
                    var return_v = this_param.Flags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(420, 23541, 23551);
                    return return_v;
                }


                System.Reflection.AssemblyContentType
                f_420_23622_23638(System.Reflection.AssemblyName
                this_param)
                {
                    var return_v = this_param.ContentType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(420, 23622, 23638);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_420_23287_23639(string?
                name, System.Version?
                version, string?
                cultureName, System.Collections.Immutable.ImmutableArray<byte>
                publicKeyOrToken, bool
                hasPublicKey, bool
                isRetargetable, System.Reflection.AssemblyContentType
                contentType)
                {
                    var return_v = new Microsoft.CodeAnalysis.AssemblyIdentity(name, version, cultureName, publicKeyOrToken, hasPublicKey: hasPublicKey, isRetargetable: isRetargetable, contentType: contentType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(420, 23287, 23639);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(420, 23128, 23651);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(420, 23128, 23651);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static AssemblyIdentity()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(420, 763, 23680);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 1939, 1961);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(420, 11780, 11817);
            NullVersion = f_420_11794_11817(0, 0, 0, 0); DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 824, 859);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(421, 21988, 22011);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(420, 763, 23680);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(420, 763, 23680);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(420, 763, 23680);

        static int
        f_420_2064_2099(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(420, 2064, 2099);
            return 0;
        }


        static int
        f_420_2114_2151(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(420, 2114, 2151);
            return 0;
        }


        static System.Reflection.AssemblyContentType
        f_420_2183_2200(Microsoft.CodeAnalysis.AssemblyIdentity
        this_param)
        {
            var return_v = this_param.ContentType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(420, 2183, 2200);
            return return_v;
        }


        static bool
        f_420_5242_5262(System.Reflection.AssemblyContentType
        value)
        {
            var return_v = IsValid(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(420, 5242, 5262);
            return return_v;
        }


        static string
        f_420_5355_5395()
        {
            var return_v = CodeAnalysisResources.InvalidContentType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(420, 5355, 5395);
            return return_v;
        }


        static System.ArgumentOutOfRangeException
        f_420_5302_5396(string
        paramName, string
        message)
        {
            var return_v = new System.ArgumentOutOfRangeException(paramName, message);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(420, 5302, 5396);
            return return_v;
        }


        static bool
        f_420_5433_5450(string?
        name)
        {
            var return_v = IsValidName(name);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(420, 5433, 5450);
            return return_v;
        }


        static string
        f_420_5526_5567()
        {
            var return_v = CodeAnalysisResources.InvalidAssemblyName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(420, 5526, 5567);
            return return_v;
        }


        static string
        f_420_5512_5574(string
        format, string?
        arg0)
        {
            var return_v = string.Format(format, (object?)arg0);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(420, 5512, 5574);
            return return_v;
        }


        static System.ArgumentException
        f_420_5490_5589(string
        message, string
        paramName)
        {
            var return_v = new System.ArgumentException(message, paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(420, 5490, 5589);
            return return_v;
        }


        static bool
        f_420_5626_5657(string?
        name)
        {
            var return_v = IsValidCultureName(name);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(420, 5626, 5657);
            return return_v;
        }


        static string
        f_420_5733_5773()
        {
            var return_v = CodeAnalysisResources.InvalidCultureName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(420, 5733, 5773);
            return return_v;
        }


        static string
        f_420_5719_5787(string
        format, string?
        arg0)
        {
            var return_v = string.Format(format, (object?)arg0);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(420, 5719, 5787);
            return return_v;
        }


        static System.ArgumentException
        f_420_5697_5809(string
        message, string
        paramName)
        {
            var return_v = new System.ArgumentException(message, paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(420, 5697, 5809);
            return return_v;
        }


        static bool
        f_420_5922_5938(System.Version?
        value)
        {
            var return_v = IsValid(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(420, 5922, 5938);
            return return_v;
        }


        static System.ArgumentOutOfRangeException
        f_420_5978_6026(string
        paramName)
        {
            var return_v = new System.ArgumentOutOfRangeException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(420, 5978, 6026);
            return return_v;
        }


        static bool
        f_420_6113_6163(System.Collections.Immutable.ImmutableArray<byte>
        bytes)
        {
            var return_v = MetadataHelpers.IsValidPublicKey(bytes);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(420, 6113, 6163);
            return return_v;
        }


        static string
        f_420_6233_6271()
        {
            var return_v = CodeAnalysisResources.InvalidPublicKey;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(420, 6233, 6271);
            return return_v;
        }


        static System.ArgumentException
        f_420_6211_6298(string
        message, string
        paramName)
        {
            var return_v = new System.ArgumentException(message, paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(420, 6211, 6298);
            return return_v;
        }


        bool
        f_420_6388_6422_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(420, 6388, 6422);
            return return_v;
        }


        static string
        f_420_6541_6590()
        {
            var return_v = CodeAnalysisResources.InvalidSizeOfPublicKeyToken;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(420, 6541, 6590);
            return return_v;
        }


        static System.ArgumentException
        f_420_6519_6617(string
        message, string
        paramName)
        {
            var return_v = new System.ArgumentException(message, paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(420, 6519, 6617);
            return return_v;
        }


        static string
        f_420_6801_6854()
        {
            var return_v = CodeAnalysisResources.WinRTIdentityCantBeRetargetable;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(420, 6801, 6854);
            return return_v;
        }


        static System.ArgumentException
        f_420_6779_6879(string
        message, string
        paramName)
        {
            var return_v = new System.ArgumentException(message, paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(420, 6779, 6879);
            return return_v;
        }


        static string
        f_420_7001_7034(string?
        cultureName)
        {
            var return_v = NormalizeCultureName(cultureName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(420, 7001, 7034);
            return return_v;
        }


        static int
        f_420_7137_7223(System.Collections.Immutable.ImmutableArray<byte>
        publicKeyOrToken, bool
        hasPublicKey, out System.Collections.Immutable.ImmutableArray<byte>
        publicKey, out System.Collections.Immutable.ImmutableArray<byte>
        publicKeyToken)
        {
            InitializeKey(publicKeyOrToken, hasPublicKey, out publicKey, out publicKeyToken);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(420, 7137, 7223);
            return 0;
        }


        static int
        f_420_7536_7562(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(420, 7536, 7562);
            return 0;
        }


        static bool
        f_420_7590_7606(System.Version
        value)
        {
            var return_v = IsValid(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(420, 7590, 7606);
            return return_v;
        }


        static int
        f_420_7577_7607(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(420, 7577, 7607);
            return 0;
        }


        static bool
        f_420_7635_7666(string?
        name)
        {
            var return_v = IsValidCultureName(name);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(420, 7635, 7666);
            return return_v;
        }


        static int
        f_420_7622_7667(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(420, 7622, 7667);
            return 0;
        }


        static bool
        f_420_7712_7762(System.Collections.Immutable.ImmutableArray<byte>
        bytes)
        {
            var return_v = MetadataHelpers.IsValidPublicKey(bytes);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(420, 7712, 7762);
            return return_v;
        }


        static int
        f_420_7682_7871(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(420, 7682, 7871);
            return 0;
        }


        static string
        f_420_7978_8011(string?
        cultureName)
        {
            var return_v = NormalizeCultureName(cultureName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(420, 7978, 8011);
            return return_v;
        }


        static int
        f_420_8121_8207(System.Collections.Immutable.ImmutableArray<byte>
        publicKeyOrToken, bool
        hasPublicKey, out System.Collections.Immutable.ImmutableArray<byte>
        publicKey, out System.Collections.Immutable.ImmutableArray<byte>
        publicKeyToken)
        {
            InitializeKey(publicKeyOrToken, hasPublicKey, out publicKey, out publicKeyToken);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(420, 8121, 8207);
            return 0;
        }


        static int
        f_420_8683_8709(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(420, 8683, 8709);
            return 0;
        }


        static bool
        f_420_8754_8804(System.Collections.Immutable.ImmutableArray<byte>
        bytes)
        {
            var return_v = MetadataHelpers.IsValidPublicKey(bytes);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(420, 8754, 8804);
            return return_v;
        }


        static int
        f_420_8724_8913(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(420, 8724, 8913);
            return 0;
        }


        static int
        f_420_8928_8949(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(420, 8928, 8949);
            return 0;
        }


        static string
        f_420_9056_9089(string?
        cultureName)
        {
            var return_v = NormalizeCultureName(cultureName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(420, 9056, 9089);
            return return_v;
        }


        static bool
        f_420_9119_9139(System.Reflection.AssemblyContentType
        value)
        {
            var return_v = IsValid(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(420, 9119, 9139);
            return return_v;
        }


        static int
        f_420_9299_9385(System.Collections.Immutable.ImmutableArray<byte>
        publicKeyOrToken, bool
        hasPublicKey, out System.Collections.Immutable.ImmutableArray<byte>
        publicKey, out System.Collections.Immutable.ImmutableArray<byte>
        publicKeyToken)
        {
            InitializeKey(publicKeyOrToken, hasPublicKey, out publicKey, out publicKeyToken);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(420, 9299, 9385);
            return 0;
        }


        static System.Version
        f_420_11794_11817(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new System.Version(major, minor, build, revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(420, 11794, 11817);
            return return_v;
        }

    }
}
