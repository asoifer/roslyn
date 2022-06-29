// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;

namespace Microsoft.CodeAnalysis
{

    internal struct AssemblyVersion : IEquatable<AssemblyVersion>, IComparable<AssemblyVersion>
    {

        private readonly ushort _major;

        private readonly ushort _minor;

        private readonly ushort _build;

        private readonly ushort _revision;

        public AssemblyVersion(ushort major, ushort minor, ushort build, ushort revision)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(174, 564, 789);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(174, 670, 685);

                _major = major;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(174, 699, 714);

                _minor = minor;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(174, 728, 743);

                _build = build;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(174, 757, 778);

                _revision = revision;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(174, 564, 789);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(174, 564, 789);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(174, 564, 789);
            }
        }

        public int Major
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(174, 842, 864);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(174, 848, 862);

                    return _major;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(174, 842, 864);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(174, 801, 875);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(174, 801, 875);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public int Minor
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(174, 928, 950);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(174, 934, 948);

                    return _minor;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(174, 928, 950);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(174, 887, 961);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(174, 887, 961);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public int Build
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(174, 1014, 1036);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(174, 1020, 1034);

                    return _build;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(174, 1014, 1036);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(174, 973, 1047);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(174, 973, 1047);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public int Revision
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(174, 1103, 1128);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(174, 1109, 1126);

                    return _revision;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(174, 1103, 1128);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(174, 1059, 1139);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(174, 1059, 1139);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ulong ToInteger()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(174, 1151, 1301);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(174, 1201, 1290);

                return ((ulong)_major << 48) | ((ulong)_minor << 32) | ((ulong)_build << 16) | _revision;
                DynAbs.Tracing.TraceSender.TraceExitMethod(174, 1151, 1301);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(174, 1151, 1301);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(174, 1151, 1301);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int CompareTo(AssemblyVersion other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(174, 1313, 1527);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(174, 1381, 1404);

                var
                left = ToInteger()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(174, 1418, 1448);

                var
                right = other.ToInteger()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(174, 1462, 1516);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(174, 1469, 1484) || (((left == right) && DynAbs.Tracing.TraceSender.Conditional_F2(174, 1487, 1488)) || DynAbs.Tracing.TraceSender.Conditional_F3(174, 1491, 1515))) ? 0 : (DynAbs.Tracing.TraceSender.Conditional_F1(174, 1491, 1505) || (((left < right) && DynAbs.Tracing.TraceSender.Conditional_F2(174, 1508, 1510)) || DynAbs.Tracing.TraceSender.Conditional_F3(174, 1513, 1515))) ? -1 : +1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(174, 1313, 1527);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(174, 1313, 1527);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(174, 1313, 1527);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool Equals(AssemblyVersion other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(174, 1539, 1656);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(174, 1605, 1645);

                return ToInteger() == other.ToInteger();
                DynAbs.Tracing.TraceSender.TraceExitMethod(174, 1539, 1656);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(174, 1539, 1656);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(174, 1539, 1656);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(174, 1668, 1805);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(174, 1732, 1794);

                return obj is AssemblyVersion && (DynAbs.Tracing.TraceSender.Expression_True(174, 1739, 1793) && Equals(obj));
                DynAbs.Tracing.TraceSender.TraceExitMethod(174, 1668, 1805);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(174, 1668, 1805);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(174, 1668, 1805);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(174, 1817, 1998);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(174, 1875, 1987);

                return ((_major & 0x000f) << 28) | ((_minor & 0x00ff) << 20) | ((_build & 0x00ff) << 12) | (_revision & 0x0fff);
                DynAbs.Tracing.TraceSender.TraceExitMethod(174, 1817, 1998);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(174, 1817, 1998);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(174, 1817, 1998);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool operator ==(AssemblyVersion left, AssemblyVersion right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(174, 2010, 2147);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(174, 2110, 2136);

                return left.Equals(right);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(174, 2010, 2147);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(174, 2010, 2147);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(174, 2010, 2147);
            }
        }

        public static bool operator !=(AssemblyVersion left, AssemblyVersion right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(174, 2159, 2297);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(174, 2259, 2286);

                return !left.Equals(right);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(174, 2159, 2297);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(174, 2159, 2297);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(174, 2159, 2297);
            }
        }

        public static bool operator <(AssemblyVersion left, AssemblyVersion right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(174, 2309, 2463);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(174, 2408, 2452);

                return left.ToInteger() < right.ToInteger();
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(174, 2309, 2463);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(174, 2309, 2463);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(174, 2309, 2463);
            }
        }

        public static bool operator <=(AssemblyVersion left, AssemblyVersion right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(174, 2475, 2631);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(174, 2575, 2620);

                return left.ToInteger() <= right.ToInteger();
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(174, 2475, 2631);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(174, 2475, 2631);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(174, 2475, 2631);
            }
        }

        public static bool operator >(AssemblyVersion left, AssemblyVersion right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(174, 2643, 2797);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(174, 2742, 2786);

                return left.ToInteger() > right.ToInteger();
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(174, 2643, 2797);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(174, 2643, 2797);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(174, 2643, 2797);
            }
        }

        public static bool operator >=(AssemblyVersion left, AssemblyVersion right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(174, 2809, 2965);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(174, 2909, 2954);

                return left.ToInteger() >= right.ToInteger();
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(174, 2809, 2965);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(174, 2809, 2965);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(174, 2809, 2965);
            }
        }

        /// <summary>
        /// Converts <see cref="Version"/> to <see cref="AssemblyVersion"/>.
        /// </summary>
        /// <exception cref="InvalidCastException">Major, minor, build or revision number are less than 0 or greater than 0xFFFF.</exception>
        public static explicit operator AssemblyVersion(Version version)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(174, 3245, 3467);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(174, 3334, 3456);

                return f_174_3341_3455((ushort)f_174_3369_3382(version), (ushort)f_174_3392_3405(version), (ushort)f_174_3415_3428(version), (ushort)f_174_3438_3454(version));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(174, 3245, 3467);

                int
                f_174_3369_3382(System.Version
                this_param)
                {
                    var return_v = this_param.Major;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(174, 3369, 3382);
                    return return_v;
                }


                int
                f_174_3392_3405(System.Version
                this_param)
                {
                    var return_v = this_param.Minor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(174, 3392, 3405);
                    return return_v;
                }


                int
                f_174_3415_3428(System.Version
                this_param)
                {
                    var return_v = this_param.Build;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(174, 3415, 3428);
                    return return_v;
                }


                int
                f_174_3438_3454(System.Version
                this_param)
                {
                    var return_v = this_param.Revision;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(174, 3438, 3454);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyVersion
                f_174_3341_3455(int
                major, int
                minor, int
                build, int
                revision)
                {
                    var return_v = new Microsoft.CodeAnalysis.AssemblyVersion((ushort)major, (ushort)minor, (ushort)build, (ushort)revision);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(174, 3341, 3455);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(174, 3245, 3467);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(174, 3245, 3467);
            }
        }
        public static explicit operator Version(AssemblyVersion version)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(174, 3479, 3661);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(174, 3568, 3650);

                return f_174_3575_3649(version.Major, version.Minor, version.Build, version.Revision);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(174, 3479, 3661);

                System.Version
                f_174_3575_3649(int
                major, int
                minor, int
                build, int
                revision)
                {
                    var return_v = new System.Version(major, minor, build, revision);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(174, 3575, 3649);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(174, 3479, 3661);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(174, 3479, 3661);
            }
        }
        static AssemblyVersion()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(174, 287, 3668);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(174, 287, 3668);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(174, 287, 3668);
        }
    }
}
