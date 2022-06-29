// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{

    public struct SubsystemVersion : IEquatable<SubsystemVersion>
    {

        public int Major { get; }

        public int Minor { get; }

        public static SubsystemVersion None
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(166, 1417, 1442);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(166, 1420, 1442);
                    return f_166_1420_1442(); DynAbs.Tracing.TraceSender.TraceExitMethod(166, 1417, 1442);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(166, 1417, 1442);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(166, 1417, 1442);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static SubsystemVersion Windows2000
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(166, 1590, 1619);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(166, 1593, 1619);
                    return f_166_1593_1619(5, 0); DynAbs.Tracing.TraceSender.TraceExitMethod(166, 1590, 1619);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(166, 1590, 1619);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(166, 1590, 1619);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static SubsystemVersion WindowsXP
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(166, 1764, 1793);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(166, 1767, 1793);
                    return f_166_1767_1793(5, 1); DynAbs.Tracing.TraceSender.TraceExitMethod(166, 1764, 1793);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(166, 1764, 1793);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(166, 1764, 1793);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static SubsystemVersion WindowsVista
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(166, 1943, 1972);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(166, 1946, 1972);
                    return f_166_1946_1972(6, 0); DynAbs.Tracing.TraceSender.TraceExitMethod(166, 1943, 1972);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(166, 1943, 1972);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(166, 1943, 1972);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static SubsystemVersion Windows7
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(166, 2114, 2143);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(166, 2117, 2143);
                    return f_166_2117_2143(6, 1); DynAbs.Tracing.TraceSender.TraceExitMethod(166, 2114, 2143);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(166, 2114, 2143);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(166, 2114, 2143);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static SubsystemVersion Windows8
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(166, 2285, 2314);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(166, 2288, 2314);
                    return f_166_2288_2314(6, 2); DynAbs.Tracing.TraceSender.TraceExitMethod(166, 2285, 2314);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(166, 2285, 2314);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(166, 2285, 2314);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private SubsystemVersion(int major, int minor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(166, 2327, 2461);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(166, 2398, 2417);

                this.Major = major;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(166, 2431, 2450);

                this.Minor = minor;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(166, 2327, 2461);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(166, 2327, 2461);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(166, 2327, 2461);
            }
        }

        public static bool TryParse(string str, out SubsystemVersion version)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(166, 2858, 4698);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(166, 2952, 2984);

                version = SubsystemVersion.None;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(166, 2998, 4660) || true) && (!f_166_3003_3033(str))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(166, 2998, 4660);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(166, 3067, 3080);

                    string
                    major
                    = default(string);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(166, 3098, 3112);

                    string?
                    minor
                    = default(string?);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(166, 3132, 3161);

                    int
                    index = f_166_3144_3160(str, '.')
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(166, 3212, 3697) || true) && (index >= 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(166, 3212, 3697);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(166, 3371, 3438) || true) && (f_166_3375_3385(str) == index + 1)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(166, 3371, 3438);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(166, 3425, 3438);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(166, 3371, 3438);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(166, 3462, 3494);

                        major = f_166_3470_3493(str, 0, index);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(166, 3516, 3549);

                        minor = f_166_3524_3548(str, index + 1);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(166, 3212, 3697);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(166, 3212, 3697);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(166, 3631, 3643);

                        major = str;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(166, 3665, 3678);

                        minor = null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(166, 3212, 3697);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(166, 3717, 3732);

                    int
                    majorValue
                    = default(int);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(166, 3752, 4023) || true) && (major != f_166_3765_3777(major) || (DynAbs.Tracing.TraceSender.Expression_False(166, 3756, 3887) || !f_166_3803_3887(major, NumberStyles.None, f_166_3842_3870(), out majorValue)) || (DynAbs.Tracing.TraceSender.Expression_False(166, 3756, 3931) || majorValue >= 65356) || (DynAbs.Tracing.TraceSender.Expression_False(166, 3756, 3949) || majorValue < 0))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(166, 3752, 4023);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(166, 3991, 4004);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(166, 3752, 4023);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(166, 4043, 4062);

                    int
                    minorValue = 0
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(166, 4171, 4540) || true) && (minor != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(166, 4171, 4540);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(166, 4230, 4521) || true) && (minor != f_166_4243_4255(minor) || (DynAbs.Tracing.TraceSender.Expression_False(166, 4234, 4369) || !f_166_4285_4369(minor, NumberStyles.None, f_166_4324_4352(), out minorValue)) || (DynAbs.Tracing.TraceSender.Expression_False(166, 4234, 4417) || minorValue >= 65356) || (DynAbs.Tracing.TraceSender.Expression_False(166, 4234, 4435) || minorValue < 0))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(166, 4230, 4521);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(166, 4485, 4498);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(166, 4230, 4521);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(166, 4171, 4540);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(166, 4560, 4615);

                    version = f_166_4570_4614(majorValue, minorValue);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(166, 4633, 4645);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(166, 2998, 4660);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(166, 4674, 4687);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(166, 2858, 4698);

                bool
                f_166_3003_3033(string
                value)
                {
                    var return_v = string.IsNullOrWhiteSpace(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(166, 3003, 3033);
                    return return_v;
                }


                int
                f_166_3144_3160(string
                this_param, char
                value)
                {
                    var return_v = this_param.IndexOf(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(166, 3144, 3160);
                    return return_v;
                }


                int
                f_166_3375_3385(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(166, 3375, 3385);
                    return return_v;
                }


                string
                f_166_3470_3493(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(166, 3470, 3493);
                    return return_v;
                }


                string
                f_166_3524_3548(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(166, 3524, 3548);
                    return return_v;
                }


                string
                f_166_3765_3777(string
                this_param)
                {
                    var return_v = this_param.Trim();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(166, 3765, 3777);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_166_3842_3870()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(166, 3842, 3870);
                    return return_v;
                }


                bool
                f_166_3803_3887(string
                s, System.Globalization.NumberStyles
                style, System.Globalization.CultureInfo
                provider, out int
                result)
                {
                    var return_v = int.TryParse(s, style, (System.IFormatProvider)provider, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(166, 3803, 3887);
                    return return_v;
                }


                string
                f_166_4243_4255(string
                this_param)
                {
                    var return_v = this_param.Trim();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(166, 4243, 4255);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_166_4324_4352()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(166, 4324, 4352);
                    return return_v;
                }


                bool
                f_166_4285_4369(string
                s, System.Globalization.NumberStyles
                style, System.Globalization.CultureInfo
                provider, out int
                result)
                {
                    var return_v = int.TryParse(s, style, (System.IFormatProvider)provider, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(166, 4285, 4369);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SubsystemVersion
                f_166_4570_4614(int
                major, int
                minor)
                {
                    var return_v = new Microsoft.CodeAnalysis.SubsystemVersion(major, minor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(166, 4570, 4614);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(166, 2858, 4698);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(166, 2858, 4698);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SubsystemVersion Create(int major, int minor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(166, 5062, 5199);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(166, 5146, 5188);

                return f_166_5153_5187(major, minor);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(166, 5062, 5199);

                Microsoft.CodeAnalysis.SubsystemVersion
                f_166_5153_5187(int
                major, int
                minor)
                {
                    var return_v = new Microsoft.CodeAnalysis.SubsystemVersion(major, minor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(166, 5153, 5187);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(166, 5062, 5199);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(166, 5062, 5199);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SubsystemVersion Default(OutputKind outputKind, Platform platform)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(166, 5513, 6327);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(166, 5620, 5683) || true) && (platform == Platform.Arm)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(166, 5620, 5683);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(166, 5667, 5683);

                    return Windows8;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(166, 5620, 5683);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(166, 5699, 6316);

                switch (outputKind)
                {

                    case OutputKind.ConsoleApplication:
                    case OutputKind.DynamicallyLinkedLibrary:
                    case OutputKind.NetModule:
                    case OutputKind.WindowsApplication:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(166, 5699, 6316);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(166, 5964, 5998);

                        return f_166_5971_5997(4, 0);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(166, 5699, 6316);

                    case OutputKind.WindowsRuntimeApplication:
                    case OutputKind.WindowsRuntimeMetadata:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(166, 5699, 6316);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(166, 6137, 6153);

                        return Windows8;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(166, 5699, 6316);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(166, 5699, 6316);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(166, 6203, 6301);

                        throw f_166_6209_6300(f_166_6241_6285(), "outputKind");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(166, 5699, 6316);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(166, 5513, 6327);

                Microsoft.CodeAnalysis.SubsystemVersion
                f_166_5971_5997(int
                major, int
                minor)
                {
                    var return_v = new Microsoft.CodeAnalysis.SubsystemVersion(major, minor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(166, 5971, 5997);
                    return return_v;
                }


                string
                f_166_6241_6285()
                {
                    var return_v = CodeAnalysisResources.OutputKindNotSupported;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(166, 6241, 6285);
                    return return_v;
                }


                System.ArgumentOutOfRangeException
                f_166_6209_6300(string
                paramName, string
                message)
                {
                    var return_v = new System.ArgumentOutOfRangeException(paramName, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(166, 6209, 6300);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(166, 5513, 6327);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(166, 5513, 6327);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool IsValid
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(166, 6491, 6676);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(166, 6527, 6661);

                    return this.Major >= 0 && (DynAbs.Tracing.TraceSender.Expression_True(166, 6534, 6592) && this.Minor >= 0) && (DynAbs.Tracing.TraceSender.Expression_True(166, 6534, 6638) && this.Major < 65536) && (DynAbs.Tracing.TraceSender.Expression_True(166, 6534, 6660) && this.Minor < 65536);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(166, 6491, 6676);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(166, 6447, 6687);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(166, 6447, 6687);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(166, 6699, 6839);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(166, 6764, 6828);

                return obj is SubsystemVersion && (DynAbs.Tracing.TraceSender.Expression_True(166, 6771, 6827) && Equals(obj));
                DynAbs.Tracing.TraceSender.TraceExitMethod(166, 6699, 6839);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(166, 6699, 6839);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(166, 6699, 6839);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(166, 6851, 6992);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(166, 6909, 6981);

                return f_166_6916_6980(f_166_6929_6953(this.Minor), f_166_6955_6979(this.Major));
                DynAbs.Tracing.TraceSender.TraceExitMethod(166, 6851, 6992);

                int
                f_166_6929_6953(int
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(166, 6929, 6953);
                    return return_v;
                }


                int
                f_166_6955_6979(int
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(166, 6955, 6979);
                    return return_v;
                }


                int
                f_166_6916_6980(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(166, 6916, 6980);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(166, 6851, 6992);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(166, 6851, 6992);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool Equals(SubsystemVersion other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(166, 7004, 7144);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(166, 7071, 7133);

                return this.Major == other.Major && (DynAbs.Tracing.TraceSender.Expression_True(166, 7078, 7132) && this.Minor == other.Minor);
                DynAbs.Tracing.TraceSender.TraceExitMethod(166, 7004, 7144);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(166, 7004, 7144);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(166, 7004, 7144);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(166, 7156, 7284);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(166, 7214, 7273);

                return f_166_7221_7272("{0}.{1:00}", this.Major, this.Minor);
                DynAbs.Tracing.TraceSender.TraceExitMethod(166, 7156, 7284);

                string
                f_166_7221_7272(string
                format, int
                arg0, int
                arg1)
                {
                    var return_v = string.Format(format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(166, 7221, 7272);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(166, 7156, 7284);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(166, 7156, 7284);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static SubsystemVersion()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(166, 969, 7291);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(166, 969, 7291);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(166, 969, 7291);
        }

        static Microsoft.CodeAnalysis.SubsystemVersion
        f_166_1420_1442()
        {
            var return_v = new Microsoft.CodeAnalysis.SubsystemVersion();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(166, 1420, 1442);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SubsystemVersion
        f_166_1593_1619(int
        major, int
        minor)
        {
            var return_v = new Microsoft.CodeAnalysis.SubsystemVersion(major, minor);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(166, 1593, 1619);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SubsystemVersion
        f_166_1767_1793(int
        major, int
        minor)
        {
            var return_v = new Microsoft.CodeAnalysis.SubsystemVersion(major, minor);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(166, 1767, 1793);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SubsystemVersion
        f_166_1946_1972(int
        major, int
        minor)
        {
            var return_v = new Microsoft.CodeAnalysis.SubsystemVersion(major, minor);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(166, 1946, 1972);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SubsystemVersion
        f_166_2117_2143(int
        major, int
        minor)
        {
            var return_v = new Microsoft.CodeAnalysis.SubsystemVersion(major, minor);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(166, 2117, 2143);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SubsystemVersion
        f_166_2288_2314(int
        major, int
        minor)
        {
            var return_v = new Microsoft.CodeAnalysis.SubsystemVersion(major, minor);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(166, 2288, 2314);
            return return_v;
        }

    }
}
