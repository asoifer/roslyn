// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Test.Utilities;
using Microsoft.Win32;
using Roslyn.Utilities;
using Xunit;

namespace Roslyn.Test.Utilities
{
    public static class ConditionalSkipReason
    {
        public const string
        NoPiaNeedsDesktop = "NoPia is only supported on desktop"
        ;

        public const string
        NetModulesNeedDesktop = "Net Modules are only supported on desktop"
        ;

        public const string
        RestrictedTypesNeedDesktop = "Restricted types are only supported on desktop"
        ;

        public const string
        NativePdbRequiresDesktop = "Native PDB tests can only execute on windows desktop"
        ;

        public const string
        TestExecutionHasNewLineDependency = "Test execution depends on OS specific new lines"
        ;

        public const string
        TestExecutionNeedsDesktopTypes = "Test execution depends on desktop types"
        ;

        public const string
        TestExecutionNeedsWindowsTypes = "Test execution depends on windows only types"
        ;

        public const string
        TestExecutionHasCOMInterop = "Test execution depends on COM Interop"
        ;

        public const string
        TestHasWindowsPaths = "Test depends on Windows style paths"
        ;

        public const string
        TestExecutionNeedsFusion = "Test depends on desktop fusion loader API"
        ;

        public const string
        WinRTNeedsWindowsDesktop = "WinRT is only supported on Windows desktop"
        ;

        public const string
        MonoDefaultInterfaceMethods = "Mono can't execute this default interface method test yet"
        ;

        static ConditionalSkipReason()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25046, 763, 2653);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 841, 897);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 928, 995);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 1026, 1103);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 1134, 1215);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 1246, 1331);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 1559, 1633);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 1943, 2022);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 2055, 2123);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 2154, 2213);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 2244, 2314);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 2347, 2418);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 2556, 2645);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25046, 763, 2653);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 763, 2653);
        }

    }
    public class ConditionalFactAttribute : FactAttribute
    {
        [Obsolete("ConditionalFact should use Reason or AlwaysSkip", error: true)]
        public new string Skip
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25046, 3228, 3253);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 3234, 3251);

                    return DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.Skip, 25046, 3241, 3250);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25046, 3228, 3253);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25046, 3097, 3304);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 3097, 3304);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25046, 3267, 3293);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 3273, 3291);

                    base.Skip = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25046, 3267, 3293);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25046, 3097, 3304);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 3097, 3304);
                }
            }
        }

        public string AlwaysSkip
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25046, 3604, 3629);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 3610, 3627);

                    return DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.Skip, 25046, 3617, 3626);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25046, 3604, 3629);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25046, 3555, 3680);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 3555, 3680);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25046, 3643, 3669);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 3649, 3667);

                    base.Skip = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25046, 3643, 3669);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25046, 3555, 3680);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 3555, 3680);
                }
            }
        }

        public string Reason { get; set; }

        public ConditionalFactAttribute(params Type[] skipConditions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(25046, 3738, 4193);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 3692, 3726);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 3824, 4182);
                    foreach (var skipCondition in f_25046_3854_3868_I(skipConditions))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25046, 3824, 4182);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 3902, 3993);

                        ExecutionCondition
                        condition = (ExecutionCondition)f_25046_3953_3992(skipCondition)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 4011, 4167) || true) && (f_25046_4015_4035(condition))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25046, 4011, 4167);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 4077, 4120);

                            base.Skip = f_25046_4089_4095() ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(25046, 4089, 4119) ?? f_25046_4099_4119(condition));
                            DynAbs.Tracing.TraceSender.TraceBreak(25046, 4142, 4148);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25046, 4011, 4167);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25046, 3824, 4182);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25046, 1, 359);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(25046, 1, 359);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(25046, 3738, 4193);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25046, 3738, 4193);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 3738, 4193);
            }
        }

        static ConditionalFactAttribute()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25046, 2661, 4200);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25046, 2661, 4200);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 2661, 4200);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25046, 2661, 4200);

        static object?
        f_25046_3953_3992(System.Type
        type)
        {
            var return_v = Activator.CreateInstance(type);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25046, 3953, 3992);
            return return_v;
        }


        static bool
        f_25046_4015_4035(Roslyn.Test.Utilities.ExecutionCondition?
        this_param)
        {
            var return_v = this_param.ShouldSkip;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25046, 4015, 4035);
            return return_v;
        }


        string
        f_25046_4089_4095()
        {
            var return_v = Reason;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25046, 4089, 4095);
            return return_v;
        }


        static string
        f_25046_4099_4119(Roslyn.Test.Utilities.ExecutionCondition
        this_param)
        {
            var return_v = this_param.SkipReason;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25046, 4099, 4119);
            return return_v;
        }


        System.Type[]
        f_25046_3854_3868_I(System.Type[]
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25046, 3854, 3868);
            return return_v;
        }

    }
    public class ConditionalTheoryAttribute : TheoryAttribute
    {
        [Obsolete("ConditionalTheory should use Reason or AlwaysSkip")]
        public new string Skip
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25046, 4768, 4793);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 4774, 4791);

                    return DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.Skip, 25046, 4781, 4790);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25046, 4768, 4793);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25046, 4648, 4844);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 4648, 4844);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25046, 4807, 4833);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 4813, 4831);

                    base.Skip = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25046, 4807, 4833);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25046, 4648, 4844);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 4648, 4844);
                }
            }
        }

        public string AlwaysSkip
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25046, 5144, 5169);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 5150, 5167);

                    return DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.Skip, 25046, 5157, 5166);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25046, 5144, 5169);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25046, 5095, 5220);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 5095, 5220);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25046, 5183, 5209);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 5189, 5207);

                    base.Skip = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25046, 5183, 5209);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25046, 5095, 5220);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 5095, 5220);
                }
            }
        }

        public string Reason { get; set; }

        public ConditionalTheoryAttribute(params Type[] skipConditions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(25046, 5278, 5735);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 5232, 5266);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 5366, 5724);
                    foreach (var skipCondition in f_25046_5396_5410_I(skipConditions))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25046, 5366, 5724);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 5444, 5535);

                        ExecutionCondition
                        condition = (ExecutionCondition)f_25046_5495_5534(skipCondition)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 5553, 5709) || true) && (f_25046_5557_5577(condition))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25046, 5553, 5709);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 5619, 5662);

                            base.Skip = f_25046_5631_5637() ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(25046, 5631, 5661) ?? f_25046_5641_5661(condition));
                            DynAbs.Tracing.TraceSender.TraceBreak(25046, 5684, 5690);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25046, 5553, 5709);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25046, 5366, 5724);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25046, 1, 359);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(25046, 1, 359);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(25046, 5278, 5735);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25046, 5278, 5735);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 5278, 5735);
            }
        }

        static ConditionalTheoryAttribute()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25046, 4208, 5742);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25046, 4208, 5742);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 4208, 5742);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25046, 4208, 5742);

        static object?
        f_25046_5495_5534(System.Type
        type)
        {
            var return_v = Activator.CreateInstance(type);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25046, 5495, 5534);
            return return_v;
        }


        static bool
        f_25046_5557_5577(Roslyn.Test.Utilities.ExecutionCondition?
        this_param)
        {
            var return_v = this_param.ShouldSkip;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25046, 5557, 5577);
            return return_v;
        }


        string
        f_25046_5631_5637()
        {
            var return_v = Reason;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25046, 5631, 5637);
            return return_v;
        }


        static string
        f_25046_5641_5661(Roslyn.Test.Utilities.ExecutionCondition
        this_param)
        {
            var return_v = this_param.SkipReason;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25046, 5641, 5661);
            return return_v;
        }


        System.Type[]
        f_25046_5396_5410_I(System.Type[]
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25046, 5396, 5410);
            return return_v;
        }

    }
    public abstract class ExecutionCondition
    {
        public abstract bool ShouldSkip { get; }

        public abstract string SkipReason { get; }

        public ExecutionCondition()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(25046, 5750, 5906);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(25046, 5750, 5906);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 5750, 5906);
        }


        static ExecutionCondition()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25046, 5750, 5906);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25046, 5750, 5906);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 5750, 5906);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25046, 5750, 5906);
    }
    public static class ExecutionConditionUtil
    {
        public static ExecutionArchitecture Architecture
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25046, 6022, 6255);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 6025, 6255);
                    return (IntPtr.Size) switch
                    {
                        4 when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 6070, 6100) && DynAbs.Tracing.TraceSender.Expression_True(25046, 6070, 6100))
            => ExecutionArchitecture.x86,
                        8 when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 6115, 6145) && DynAbs.Tracing.TraceSender.Expression_True(25046, 6115, 6145))
            => ExecutionArchitecture.x64,
                        _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 6160, 6244) && DynAbs.Tracing.TraceSender.Expression_True(25046, 6160, 6244))
            => throw f_25046_6171_6244($"Unrecognized pointer size {IntPtr.Size}")
                    }; DynAbs.Tracing.TraceSender.TraceExitMethod(25046, 6022, 6255);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25046, 6022, 6255);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 6022, 6255);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static ExecutionConfiguration Configuration
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25046, 6317, 6372);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 6344, 6372);
                    return ExecutionConfiguration.Debug; DynAbs.Tracing.TraceSender.TraceExitMethod(25046, 6317, 6372);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25046, 6317, 6372);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 6317, 6372);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static bool IsWindows
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25046, 6523, 6561);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 6526, 6561);
                    return Path.DirectorySeparatorChar == '\\'; DynAbs.Tracing.TraceSender.TraceExitMethod(25046, 6523, 6561);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25046, 6523, 6561);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 6523, 6561);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static bool IsUnix
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25046, 6598, 6611);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 6601, 6611);
                    return f_25046_6601_6611_M(!IsWindows); DynAbs.Tracing.TraceSender.TraceExitMethod(25046, 6598, 6611);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25046, 6598, 6611);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 6598, 6611);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static bool IsMacOS
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25046, 6649, 6699);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 6652, 6699);
                    return f_25046_6652_6699(OSPlatform.OSX); DynAbs.Tracing.TraceSender.TraceExitMethod(25046, 6649, 6699);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25046, 6649, 6699);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 6649, 6699);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static bool IsLinux
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25046, 6737, 6789);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 6740, 6789);
                    return f_25046_6740_6789(OSPlatform.Linux); DynAbs.Tracing.TraceSender.TraceExitMethod(25046, 6737, 6789);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25046, 6737, 6789);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 6737, 6789);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static bool IsDesktop
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25046, 6829, 6865);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 6832, 6865);
                    return f_25046_6832_6865(); DynAbs.Tracing.TraceSender.TraceExitMethod(25046, 6829, 6865);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25046, 6829, 6865);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 6829, 6865);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static bool IsWindowsDesktop
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25046, 6912, 6937);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 6915, 6937);
                    return f_25046_6915_6924() && (DynAbs.Tracing.TraceSender.Expression_True(25046, 6915, 6937) && f_25046_6928_6937()); DynAbs.Tracing.TraceSender.TraceExitMethod(25046, 6912, 6937);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25046, 6912, 6937);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 6912, 6937);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static bool IsMonoDesktop
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25046, 6981, 7020);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 6984, 7020);
                    return f_25046_6984_7012("Mono.Runtime") != null; DynAbs.Tracing.TraceSender.TraceExitMethod(25046, 6981, 7020);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25046, 6981, 7020);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 6981, 7020);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static bool IsMono
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25046, 7057, 7089);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 7060, 7089);
                    return f_25046_7060_7089(); DynAbs.Tracing.TraceSender.TraceExitMethod(25046, 7057, 7089);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25046, 7057, 7089);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 7057, 7089);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static bool IsCoreClr
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25046, 7129, 7142);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 7132, 7142);
                    return f_25046_7132_7142_M(!IsDesktop); DynAbs.Tracing.TraceSender.TraceExitMethod(25046, 7129, 7142);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25046, 7129, 7142);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 7129, 7142);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static bool IsCoreClrUnix
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25046, 7186, 7208);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 7189, 7208);
                    return f_25046_7189_7198() && (DynAbs.Tracing.TraceSender.Expression_True(25046, 7189, 7208) && f_25046_7202_7208()); DynAbs.Tracing.TraceSender.TraceExitMethod(25046, 7186, 7208);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25046, 7186, 7208);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 7186, 7208);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static bool IsMonoOrCoreClr
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25046, 7254, 7276);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 7257, 7276);
                    return f_25046_7257_7263() || (DynAbs.Tracing.TraceSender.Expression_False(25046, 7257, 7276) || f_25046_7267_7276()); DynAbs.Tracing.TraceSender.TraceExitMethod(25046, 7254, 7276);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25046, 7254, 7276);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 7254, 7276);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static bool RuntimeSupportsCovariantReturnsOfClasses
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25046, 7347, 7459);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 7350, 7459);
                    return f_25046_7350_7451_I(f_25046_7350_7412("System.Runtime.CompilerServices.RuntimeFeature").GetField("CovariantReturnsOfClasses")) != null; DynAbs.Tracing.TraceSender.TraceExitMethod(25046, 7347, 7459);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25046, 7347, 7459);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 7347, 7459);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static ExecutionConditionUtil()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25046, 5914, 7467);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25046, 5914, 7467);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 5914, 7467);
        }


        static System.InvalidOperationException
        f_25046_6171_6244(string
        message)
        {
            var return_v = new System.InvalidOperationException(message);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25046, 6171, 6244);
            return return_v;
        }


        static bool
        f_25046_6601_6611_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25046, 6601, 6611);
            return return_v;
        }


        static bool
        f_25046_6652_6699(System.Runtime.InteropServices.OSPlatform
        osPlatform)
        {
            var return_v = RuntimeInformation.IsOSPlatform(osPlatform);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25046, 6652, 6699);
            return return_v;
        }


        static bool
        f_25046_6740_6789(System.Runtime.InteropServices.OSPlatform
        osPlatform)
        {
            var return_v = RuntimeInformation.IsOSPlatform(osPlatform);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25046, 6740, 6789);
            return return_v;
        }


        static bool
        f_25046_6832_6865()
        {
            var return_v = RuntimeUtilities.IsDesktopRuntime;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25046, 6832, 6865);
            return return_v;
        }


        static bool
        f_25046_6915_6924()
        {
            var return_v = IsWindows;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25046, 6915, 6924);
            return return_v;
        }


        static bool
        f_25046_6928_6937()
        {
            var return_v = IsDesktop;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25046, 6928, 6937);
            return return_v;
        }


        static System.Type?
        f_25046_6984_7012(string
        typeName)
        {
            var return_v = Type.GetType(typeName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25046, 6984, 7012);
            return return_v;
        }


        static bool
        f_25046_7060_7089()
        {
            var return_v = MonoHelpers.IsRunningOnMono();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25046, 7060, 7089);
            return return_v;
        }


        static bool
        f_25046_7132_7142_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25046, 7132, 7142);
            return return_v;
        }


        static bool
        f_25046_7189_7198()
        {
            var return_v = IsCoreClr;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25046, 7189, 7198);
            return return_v;
        }


        static bool
        f_25046_7202_7208()
        {
            var return_v = IsUnix;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25046, 7202, 7208);
            return return_v;
        }


        static bool
        f_25046_7257_7263()
        {
            var return_v = IsMono;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25046, 7257, 7263);
            return return_v;
        }


        static bool
        f_25046_7267_7276()
        {
            var return_v = IsCoreClr;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25046, 7267, 7276);
            return return_v;
        }


        static System.Type?
        f_25046_7350_7412(string
        typeName)
        {
            var return_v = Type.GetType(typeName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25046, 7350, 7412);
            return return_v;
        }


        static System.Reflection.FieldInfo?
        f_25046_7350_7451_I(System.Reflection.FieldInfo?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25046, 7350, 7451);
            return return_v;
        }

    }

    public enum ExecutionArchitecture
    {
        x86,
        x64,
    }

    public enum ExecutionConfiguration
    {
        Debug,
        Release,
    }
    public class x86 : ExecutionCondition
    {
        public override bool ShouldSkip
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25046, 7734, 7801);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 7737, 7801);
                    return f_25046_7737_7772() != ExecutionArchitecture.x86; DynAbs.Tracing.TraceSender.TraceExitMethod(25046, 7734, 7801);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25046, 7734, 7801);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 7734, 7801);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string SkipReason
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25046, 7848, 7879);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 7851, 7879);
                    return "Target platform is not x86"; DynAbs.Tracing.TraceSender.TraceExitMethod(25046, 7848, 7879);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25046, 7848, 7879);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 7848, 7879);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public x86()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(25046, 7648, 7887);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(25046, 7648, 7887);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 7648, 7887);
        }


        static x86()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25046, 7648, 7887);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25046, 7648, 7887);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 7648, 7887);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25046, 7648, 7887);

        Roslyn.Test.Utilities.ExecutionArchitecture
        f_25046_7737_7772()
        {
            var return_v = ExecutionConditionUtil.Architecture;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25046, 7737, 7772);
            return return_v;
        }

    }
    public class HasShiftJisDefaultEncoding : ExecutionCondition
    {
        public override bool ShouldSkip
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25046, 8004, 8047);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 8007, 8047);
                    return f_25046_8007_8040_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_25046_8007_8030(0), 25046, 8007, 8040)?.CodePage) != 932; DynAbs.Tracing.TraceSender.TraceExitMethod(25046, 8004, 8047);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25046, 8004, 8047);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 8004, 8047);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string SkipReason
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25046, 8094, 8142);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 8097, 8142);
                    return "OS default codepage is not Shift-JIS (932)."; DynAbs.Tracing.TraceSender.TraceExitMethod(25046, 8094, 8142);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25046, 8094, 8142);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 8094, 8142);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public HasShiftJisDefaultEncoding()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(25046, 7895, 8150);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(25046, 7895, 8150);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 7895, 8150);
        }


        static HasShiftJisDefaultEncoding()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25046, 7895, 8150);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25046, 7895, 8150);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 7895, 8150);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25046, 7895, 8150);

        System.Text.Encoding
        f_25046_8007_8030(int
        codepage)
        {
            var return_v = Encoding.GetEncoding(codepage);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25046, 8007, 8030);
            return return_v;
        }


        int?
        f_25046_8007_8040_M(int?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25046, 8007, 8040);
            return return_v;
        }

    }
    public class HasEnglishDefaultEncoding : ExecutionCondition
    {
        public override bool ShouldSkip
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25046, 8290, 8812);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 8370, 8419);

                        return f_25046_8377_8410_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_25046_8377_8400(0), 25046, 8377, 8410)?.CodePage) != 1252;
                    }
                    catch (EntryPointNotFoundException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(25046, 8456, 8797);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 8765, 8778);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(25046, 8456, 8797);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25046, 8290, 8812);

                    System.Text.Encoding
                    f_25046_8377_8400(int
                    codepage)
                    {
                        var return_v = Encoding.GetEncoding(codepage);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25046, 8377, 8400);
                        return return_v;
                    }


                    int?
                    f_25046_8377_8410_M(int?
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25046, 8377, 8410);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25046, 8234, 8823);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 8234, 8823);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string SkipReason
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25046, 8869, 8914);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 8872, 8914);
                    return "OS default codepage is not Windows-1252."; DynAbs.Tracing.TraceSender.TraceExitMethod(25046, 8869, 8914);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25046, 8869, 8914);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 8869, 8914);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public HasEnglishDefaultEncoding()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(25046, 8158, 8922);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(25046, 8158, 8922);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 8158, 8922);
        }


        static HasEnglishDefaultEncoding()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25046, 8158, 8922);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25046, 8158, 8922);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 8158, 8922);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25046, 8158, 8922);
    }
    public class IsEnglishLocal : ExecutionCondition
    {
        public override bool ShouldSkip
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25046, 9027, 9232);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 9043, 9232);
                    return !f_25046_9044_9130(f_25046_9044_9077(f_25046_9044_9072()), "en", StringComparison.OrdinalIgnoreCase) || (DynAbs.Tracing.TraceSender.Expression_False(25046, 9043, 9232) || !f_25046_9148_9232(f_25046_9148_9179(f_25046_9148_9174()), "en", StringComparison.OrdinalIgnoreCase)); DynAbs.Tracing.TraceSender.TraceExitMethod(25046, 9027, 9232);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25046, 9027, 9232);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 9027, 9232);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string SkipReason
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25046, 9279, 9309);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 9282, 9309);
                    return "Current culture is not en"; DynAbs.Tracing.TraceSender.TraceExitMethod(25046, 9279, 9309);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25046, 9279, 9309);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 9279, 9309);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public IsEnglishLocal()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(25046, 8930, 9317);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(25046, 8930, 9317);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 8930, 9317);
        }


        static IsEnglishLocal()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25046, 8930, 9317);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25046, 8930, 9317);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 8930, 9317);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25046, 8930, 9317);

        System.Globalization.CultureInfo
        f_25046_9044_9072()
        {
            var return_v = CultureInfo.CurrentUICulture;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25046, 9044, 9072);
            return return_v;
        }


        string
        f_25046_9044_9077(System.Globalization.CultureInfo
        this_param)
        {
            var return_v = this_param.Name;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25046, 9044, 9077);
            return return_v;
        }


        static bool
        f_25046_9044_9130(string
        this_param, string
        value, System.StringComparison
        comparisonType)
        {
            var return_v = this_param.StartsWith(value, comparisonType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25046, 9044, 9130);
            return return_v;
        }


        System.Globalization.CultureInfo
        f_25046_9148_9174()
        {
            var return_v = CultureInfo.CurrentCulture;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25046, 9148, 9174);
            return return_v;
        }


        string
        f_25046_9148_9179(System.Globalization.CultureInfo
        this_param)
        {
            var return_v = this_param.Name;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25046, 9148, 9179);
            return return_v;
        }


        static bool
        f_25046_9148_9232(string
        this_param, string
        value, System.StringComparison
        comparisonType)
        {
            var return_v = this_param.StartsWith(value, comparisonType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25046, 9148, 9232);
            return return_v;
        }

    }
    public class IsRelease : ExecutionCondition
    {
        public override bool ShouldSkip
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25046, 9428, 9435);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 9431, 9435);
                    return true; DynAbs.Tracing.TraceSender.TraceExitMethod(25046, 9428, 9435);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25046, 9428, 9435);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 9428, 9435);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string SkipReason
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25046, 9548, 9580);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 9551, 9580);
                    return "Test not supported in DEBUG"; DynAbs.Tracing.TraceSender.TraceExitMethod(25046, 9548, 9580);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25046, 9548, 9580);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 9548, 9580);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public IsRelease()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(25046, 9325, 9588);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(25046, 9325, 9588);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 9325, 9588);
        }


        static IsRelease()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25046, 9325, 9588);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25046, 9325, 9588);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 9325, 9588);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25046, 9325, 9588);
    }
    public class IsDebug : ExecutionCondition
    {
        public override bool ShouldSkip
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25046, 9697, 9705);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 9700, 9705);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(25046, 9697, 9705);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25046, 9697, 9705);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 9697, 9705);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string SkipReason
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25046, 9817, 9851);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 9820, 9851);
                    return "Test not supported in RELEASE"; DynAbs.Tracing.TraceSender.TraceExitMethod(25046, 9817, 9851);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25046, 9817, 9851);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 9817, 9851);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public IsDebug()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(25046, 9596, 9859);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(25046, 9596, 9859);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 9596, 9859);
        }


        static IsDebug()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25046, 9596, 9859);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25046, 9596, 9859);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 9596, 9859);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25046, 9596, 9859);
    }
    public class WindowsOnly : ExecutionCondition
    {
        public override bool ShouldSkip
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25046, 9961, 9997);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 9964, 9997);
                    return f_25046_9964_9997_M(!ExecutionConditionUtil.IsWindows); DynAbs.Tracing.TraceSender.TraceExitMethod(25046, 9961, 9997);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25046, 9961, 9997);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 9961, 9997);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string SkipReason
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25046, 10042, 10082);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 10045, 10082);
                    return "Test not supported on Mac and Linux"; DynAbs.Tracing.TraceSender.TraceExitMethod(25046, 10042, 10082);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25046, 10042, 10082);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 10042, 10082);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public WindowsOnly()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(25046, 9867, 10090);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(25046, 9867, 10090);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 9867, 10090);
        }


        static WindowsOnly()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25046, 9867, 10090);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25046, 9867, 10090);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 9867, 10090);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25046, 9867, 10090);

        static bool
        f_25046_9964_9997_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25046, 9964, 9997);
            return return_v;
        }

    }
    public class WindowsDesktopOnly : ExecutionCondition
    {
        public override bool ShouldSkip
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25046, 10199, 10242);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 10202, 10242);
                    return f_25046_10202_10242_M(!ExecutionConditionUtil.IsWindowsDesktop); DynAbs.Tracing.TraceSender.TraceExitMethod(25046, 10199, 10242);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25046, 10199, 10242);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 10199, 10242);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string SkipReason
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25046, 10287, 10330);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 10290, 10330);
                    return "Test only supported on Windows desktop"; DynAbs.Tracing.TraceSender.TraceExitMethod(25046, 10287, 10330);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25046, 10287, 10330);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 10287, 10330);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public WindowsDesktopOnly()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(25046, 10098, 10338);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(25046, 10098, 10338);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 10098, 10338);
        }


        static WindowsDesktopOnly()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25046, 10098, 10338);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25046, 10098, 10338);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 10098, 10338);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25046, 10098, 10338);

        static bool
        f_25046_10202_10242_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25046, 10202, 10242);
            return return_v;
        }

    }
    public class CovariantReturnRuntimeOnly : ExecutionCondition
    {
        public override bool ShouldSkip
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25046, 10455, 10522);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 10458, 10522);
                    return f_25046_10458_10522_M(!ExecutionConditionUtil.RuntimeSupportsCovariantReturnsOfClasses); DynAbs.Tracing.TraceSender.TraceExitMethod(25046, 10455, 10522);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25046, 10455, 10522);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 10455, 10522);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string SkipReason
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25046, 10567, 10634);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 10570, 10634);
                    return "Test only supported on runtimes that support covariant returns"; DynAbs.Tracing.TraceSender.TraceExitMethod(25046, 10567, 10634);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25046, 10567, 10634);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 10567, 10634);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public CovariantReturnRuntimeOnly()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(25046, 10346, 10642);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(25046, 10346, 10642);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 10346, 10642);
        }


        static CovariantReturnRuntimeOnly()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25046, 10346, 10642);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25046, 10346, 10642);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 10346, 10642);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25046, 10346, 10642);

        static bool
        f_25046_10458_10522_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25046, 10458, 10522);
            return return_v;
        }

    }
    public class UnixLikeOnly : ExecutionCondition
    {
        public override bool ShouldSkip
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25046, 10745, 10781);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 10748, 10781);
                    return f_25046_10748_10781_M(!PathUtilities.IsUnixLikePlatform); DynAbs.Tracing.TraceSender.TraceExitMethod(25046, 10745, 10781);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25046, 10745, 10781);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 10745, 10781);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string SkipReason
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25046, 10826, 10860);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 10829, 10860);
                    return "Test not supported on Windows"; DynAbs.Tracing.TraceSender.TraceExitMethod(25046, 10826, 10860);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25046, 10826, 10860);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 10826, 10860);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public UnixLikeOnly()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(25046, 10650, 10868);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(25046, 10650, 10868);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 10650, 10868);
        }


        static UnixLikeOnly()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25046, 10650, 10868);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25046, 10650, 10868);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 10650, 10868);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25046, 10650, 10868);

        static bool
        f_25046_10748_10781_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25046, 10748, 10781);
            return return_v;
        }

    }
    public class WindowsOrLinuxOnly : ExecutionCondition
    {
        public override bool ShouldSkip
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25046, 10977, 11010);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 10980, 11010);
                    return f_25046_10980_11010(); DynAbs.Tracing.TraceSender.TraceExitMethod(25046, 10977, 11010);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25046, 10977, 11010);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 10977, 11010);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string SkipReason
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25046, 11055, 11087);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 11058, 11087);
                    return "Test not supported on macOS"; DynAbs.Tracing.TraceSender.TraceExitMethod(25046, 11055, 11087);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25046, 11055, 11087);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 11055, 11087);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public WindowsOrLinuxOnly()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(25046, 10876, 11095);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(25046, 10876, 11095);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 10876, 11095);
        }


        static WindowsOrLinuxOnly()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25046, 10876, 11095);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25046, 10876, 11095);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 10876, 11095);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25046, 10876, 11095);

        static bool
        f_25046_10980_11010()
        {
            var return_v = ExecutionConditionUtil.IsMacOS;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25046, 10980, 11010);
            return return_v;
        }

    }
    public class ClrOnly : ExecutionCondition
    {
        public override bool ShouldSkip
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25046, 11193, 11225);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 11196, 11225);
                    return f_25046_11196_11225(); DynAbs.Tracing.TraceSender.TraceExitMethod(25046, 11193, 11225);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25046, 11193, 11225);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 11193, 11225);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string SkipReason
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25046, 11270, 11301);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 11273, 11301);
                    return "Test not supported on Mono"; DynAbs.Tracing.TraceSender.TraceExitMethod(25046, 11270, 11301);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25046, 11270, 11301);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 11270, 11301);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ClrOnly()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(25046, 11103, 11309);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(25046, 11103, 11309);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 11103, 11309);
        }


        static ClrOnly()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25046, 11103, 11309);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25046, 11103, 11309);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 11103, 11309);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25046, 11103, 11309);

        static bool
        f_25046_11196_11225()
        {
            var return_v = MonoHelpers.IsRunningOnMono();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25046, 11196, 11225);
            return return_v;
        }

    }
    public class CoreClrOnly : ExecutionCondition
    {
        public override bool ShouldSkip
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25046, 11411, 11447);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 11414, 11447);
                    return f_25046_11414_11447_M(!ExecutionConditionUtil.IsCoreClr); DynAbs.Tracing.TraceSender.TraceExitMethod(25046, 11411, 11447);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25046, 11411, 11447);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 11411, 11447);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string SkipReason
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25046, 11492, 11527);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 11495, 11527);
                    return "Test only supported on CoreClr"; DynAbs.Tracing.TraceSender.TraceExitMethod(25046, 11492, 11527);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25046, 11492, 11527);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 11492, 11527);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public CoreClrOnly()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(25046, 11317, 11535);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(25046, 11317, 11535);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 11317, 11535);
        }


        static CoreClrOnly()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25046, 11317, 11535);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25046, 11317, 11535);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 11317, 11535);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25046, 11317, 11535);

        static bool
        f_25046_11414_11447_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25046, 11414, 11447);
            return return_v;
        }

    }
    public class DesktopOnly : ExecutionCondition
    {
        public override bool ShouldSkip
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25046, 11637, 11673);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 11640, 11673);
                    return f_25046_11640_11673_M(!ExecutionConditionUtil.IsDesktop); DynAbs.Tracing.TraceSender.TraceExitMethod(25046, 11637, 11673);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25046, 11637, 11673);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 11637, 11673);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string SkipReason
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25046, 11718, 11752);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 11721, 11752);
                    return "Test not supported on CoreCLR"; DynAbs.Tracing.TraceSender.TraceExitMethod(25046, 11718, 11752);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25046, 11718, 11752);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 11718, 11752);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public DesktopOnly()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(25046, 11543, 11760);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(25046, 11543, 11760);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 11543, 11760);
        }


        static DesktopOnly()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25046, 11543, 11760);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25046, 11543, 11760);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 11543, 11760);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25046, 11543, 11760);

        static bool
        f_25046_11640_11673_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25046, 11640, 11673);
            return return_v;
        }

    }
    public class DesktopClrOnly : ExecutionCondition
    {
        public override bool ShouldSkip
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25046, 11865, 11934);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 11868, 11934);
                    return f_25046_11868_11897() || (DynAbs.Tracing.TraceSender.Expression_False(25046, 11868, 11934) || f_25046_11901_11934_M(!ExecutionConditionUtil.IsDesktop)); DynAbs.Tracing.TraceSender.TraceExitMethod(25046, 11865, 11934);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25046, 11865, 11934);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 11865, 11934);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string SkipReason
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25046, 11979, 12021);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 11982, 12021);
                    return "Test not supported on Mono or CoreCLR"; DynAbs.Tracing.TraceSender.TraceExitMethod(25046, 11979, 12021);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25046, 11979, 12021);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 11979, 12021);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public DesktopClrOnly()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(25046, 11768, 12029);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(25046, 11768, 12029);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 11768, 12029);
        }


        static DesktopClrOnly()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25046, 11768, 12029);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25046, 11768, 12029);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 11768, 12029);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25046, 11768, 12029);

        static bool
        f_25046_11868_11897()
        {
            var return_v = MonoHelpers.IsRunningOnMono();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25046, 11868, 11897);
            return return_v;
        }


        static bool
        f_25046_11901_11934_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25046, 11901, 11934);
            return return_v;
        }

    }
    public class MonoOrCoreClrOnly : ExecutionCondition
    {
        public override bool ShouldSkip
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25046, 12137, 12179);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 12140, 12179);
                    return f_25046_12140_12179_M(!ExecutionConditionUtil.IsMonoOrCoreClr); DynAbs.Tracing.TraceSender.TraceExitMethod(25046, 12137, 12179);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25046, 12137, 12179);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 12137, 12179);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string SkipReason
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25046, 12224, 12267);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 12227, 12267);
                    return "Test only supported on Mono or CoreClr"; DynAbs.Tracing.TraceSender.TraceExitMethod(25046, 12224, 12267);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25046, 12224, 12267);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 12224, 12267);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public MonoOrCoreClrOnly()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(25046, 12037, 12275);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(25046, 12037, 12275);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 12037, 12275);
        }


        static MonoOrCoreClrOnly()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25046, 12037, 12275);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25046, 12037, 12275);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 12037, 12275);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25046, 12037, 12275);

        static bool
        f_25046_12140_12179_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25046, 12140, 12179);
            return return_v;
        }

    }
    public class NoIOperationValidation : ExecutionCondition
    {
        public override bool ShouldSkip
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25046, 12388, 12435);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 12391, 12435);
                    return f_25046_12391_12435(); DynAbs.Tracing.TraceSender.TraceExitMethod(25046, 12388, 12435);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25046, 12388, 12435);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 12388, 12435);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string SkipReason
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25046, 12480, 12532);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 12483, 12532);
                    return "Test not supported in TEST_IOPERATION_INTERFACE"; DynAbs.Tracing.TraceSender.TraceExitMethod(25046, 12480, 12532);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25046, 12480, 12532);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 12480, 12532);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public NoIOperationValidation()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(25046, 12283, 12540);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(25046, 12283, 12540);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 12283, 12540);
        }


        static NoIOperationValidation()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25046, 12283, 12540);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25046, 12283, 12540);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 12283, 12540);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25046, 12283, 12540);

        static bool
        f_25046_12391_12435()
        {
            var return_v = CompilationExtensions.EnableVerifyIOperation;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25046, 12391, 12435);
            return return_v;
        }

    }
    public class OSVersionWin8 : ExecutionCondition
    {
        public override bool ShouldSkip
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25046, 12644, 12664);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 12647, 12664);
                    return f_25046_12647_12664_M(!OSVersion.IsWin8); DynAbs.Tracing.TraceSender.TraceExitMethod(25046, 12644, 12664);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25046, 12644, 12664);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 12644, 12664);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string SkipReason
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25046, 12709, 12762);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 12712, 12762);
                    return "Window Version is not at least Win8 (build:9200)"; DynAbs.Tracing.TraceSender.TraceExitMethod(25046, 12709, 12762);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25046, 12709, 12762);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 12709, 12762);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public OSVersionWin8()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(25046, 12548, 12770);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(25046, 12548, 12770);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 12548, 12770);
        }


        static OSVersionWin8()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25046, 12548, 12770);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25046, 12548, 12770);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 12548, 12770);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25046, 12548, 12770);

        static bool
        f_25046_12647_12664_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25046, 12647, 12664);
            return return_v;
        }

    }
    public class Framework35Installed : ExecutionCondition
    {
        public override bool ShouldSkip
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25046, 12905, 13576);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 13540, 13553);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25046, 12905, 13576);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25046, 12849, 13587);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 12849, 13587);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string SkipReason
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25046, 13633, 13673);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 13636, 13673);
                    return ".NET Framework 3.5 is not installed"; DynAbs.Tracing.TraceSender.TraceExitMethod(25046, 13633, 13673);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25046, 13633, 13673);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 13633, 13673);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public Framework35Installed()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(25046, 12778, 13681);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(25046, 12778, 13681);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 12778, 13681);
        }


        static Framework35Installed()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25046, 12778, 13681);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25046, 12778, 13681);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 12778, 13681);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25046, 12778, 13681);
    }
    public class NotFramework45 : ExecutionCondition
    {
        public override bool ShouldSkip
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25046, 13810, 14090);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 13924, 14075);

                    return f_25046_13931_14012(f_25046_13931_14003(typeof(System.Runtime.CompilerServices.ExtensionAttribute))) ==
                    f_25046_14037_14074(f_25046_14037_14065(typeof(object)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25046, 13810, 14090);

                    System.Reflection.TypeInfo
                    f_25046_13931_14003(System.Type
                    type)
                    {
                        var return_v = type.GetTypeInfo();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25046, 13931, 14003);
                        return return_v;
                    }


                    System.Reflection.Assembly
                    f_25046_13931_14012(System.Reflection.TypeInfo
                    this_param)
                    {
                        var return_v = this_param.Assembly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25046, 13931, 14012);
                        return return_v;
                    }


                    System.Reflection.TypeInfo
                    f_25046_14037_14065(System.Type
                    type)
                    {
                        var return_v = type.GetTypeInfo();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25046, 14037, 14065);
                        return return_v;
                    }


                    System.Reflection.Assembly
                    f_25046_14037_14074(System.Reflection.TypeInfo
                    this_param)
                    {
                        var return_v = this_param.Assembly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25046, 14037, 14074);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25046, 13754, 14101);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 13754, 14101);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string SkipReason
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25046, 14147, 14197);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25046, 14150, 14197);
                    return "Test currently not supported on Framework 4.5"; DynAbs.Tracing.TraceSender.TraceExitMethod(25046, 14147, 14197);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25046, 14147, 14197);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 14147, 14197);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public NotFramework45()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(25046, 13689, 14205);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(25046, 13689, 14205);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 13689, 14205);
        }


        static NotFramework45()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25046, 13689, 14205);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25046, 13689, 14205);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25046, 13689, 14205);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25046, 13689, 14205);
    }
}
