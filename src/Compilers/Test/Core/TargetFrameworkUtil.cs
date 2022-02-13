// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Test.Utilities;
using static TestReferences;
using static Roslyn.Test.Utilities.TestMetadata;

namespace Roslyn.Test.Utilities
{
    public enum TargetFramework
    {
        /// <summary>
        /// Explicit pick a target framework that has no references
        /// </summary>
        Empty,

        NetStandard20,
        NetCoreApp,
        WinRT,

        /// <summary>
        /// Eventually this will be deleted and replaced with NetStandard20. Short term this creates the "standard"
        /// API set across desktop and coreclr 
        /// </summary>
        Standard,
        StandardLatest,
        StandardAndCSharp,
        StandardAndVBRuntime,

        /// <summary>
        /// This is represents the set of tests which must be mscorlib40 on desktop but full net standard on coreclr.
        /// </summary>
        StandardCompat,

        /// <summary>
        /// Compat framework for the default set of references many vb compilations get.
        /// </summary>
        DefaultVb,

        // The flavors of mscorlib we support + extending them with LINQ and dynamic.
        Mscorlib40,
        Mscorlib40Extended,
        Mscorlib40AndSystemCore,
        Mscorlib40AndVBRuntime,
        Mscorlib45,
        Mscorlib45Extended,
        Mscorlib45AndCSharp,
        Mscorlib45AndVBRuntime,
        Mscorlib46,
        Mscorlib46Extended,
        Mscorlib461,
        Mscorlib461Extended,
        DesktopLatestExtended = Mscorlib461Extended,

        /// <summary>
        /// Minimal set of required types (<see cref="NetFx.Minimal.mincorlib"/>).
        /// </summary>
        Minimal,

        /// <summary>
        /// Minimal set of required types and Task implementation (<see cref="NetFx.Minimal.minasync"/>).
        /// </summary>
        MinimalAsync,
    }
    public static class TargetFrameworkUtil
    {
        public static MetadataReference StandardCSharpReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25005, 2346, 2442);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25005, 2349, 2442);
                    return (DynAbs.Tracing.TraceSender.Conditional_F1(25005, 2349, 2382) || ((f_25005_2349_2382() && DynAbs.Tracing.TraceSender.Conditional_F2(25005, 2385, 2417)) || DynAbs.Tracing.TraceSender.Conditional_F3(25005, 2420, 2442))) ? f_25005_2385_2417() : f_25005_2420_2442(); DynAbs.Tracing.TraceSender.TraceExitMethod(25005, 2346, 2442);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25005, 2346, 2442);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25005, 2346, 2442);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static ImmutableArray<MetadataReference> Mscorlib40References
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25005, 2955, 3014);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25005, 2958, 3014);
                    return f_25005_2958_3014(f_25005_2999_3013()); DynAbs.Tracing.TraceSender.TraceExitMethod(25005, 2955, 3014);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25005, 2955, 3014);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25005, 2955, 3014);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static ImmutableArray<MetadataReference> Mscorlib40ExtendedReferences
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25005, 3102, 3193);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25005, 3105, 3193);
                    return f_25005_3105_3193(f_25005_3146_3160(), f_25005_3162_3174(), f_25005_3176_3192()); DynAbs.Tracing.TraceSender.TraceExitMethod(25005, 3102, 3193);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25005, 3102, 3193);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25005, 3102, 3193);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static ImmutableArray<MetadataReference> Mscorlib40andSystemCoreReferences
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25005, 3286, 3363);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25005, 3289, 3363);
                    return f_25005_3289_3363(f_25005_3330_3344(), f_25005_3346_3362()); DynAbs.Tracing.TraceSender.TraceExitMethod(25005, 3286, 3363);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25005, 3286, 3363);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25005, 3286, 3363);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static ImmutableArray<MetadataReference> Mscorlib40andVBRuntimeReferences
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25005, 3455, 3556);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25005, 3458, 3556);
                    return f_25005_3458_3556(f_25005_3499_3513(), f_25005_3515_3527(), f_25005_3529_3555()); DynAbs.Tracing.TraceSender.TraceExitMethod(25005, 3455, 3556);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25005, 3455, 3556);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25005, 3455, 3556);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static ImmutableArray<MetadataReference> Mscorlib45References
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25005, 3636, 3696);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25005, 3639, 3696);
                    return f_25005_3639_3696(f_25005_3680_3695()); DynAbs.Tracing.TraceSender.TraceExitMethod(25005, 3636, 3696);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25005, 3636, 3696);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25005, 3636, 3696);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static ImmutableArray<MetadataReference> Mscorlib45ExtendedReferences
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25005, 3784, 3924);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25005, 3787, 3924);
                    return f_25005_3787_3924(f_25005_3828_3843(), f_25005_3845_3858(), f_25005_3860_3877(), f_25005_3879_3901(), f_25005_3903_3923()); DynAbs.Tracing.TraceSender.TraceExitMethod(25005, 3784, 3924);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25005, 3784, 3924);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25005, 3784, 3924);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static ImmutableArray<MetadataReference> Mscorlib45AndCSharpReferences
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25005, 4013, 4116);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25005, 4016, 4116);
                    return f_25005_4016_4116(f_25005_4057_4072(), f_25005_4074_4091(), f_25005_4093_4115()); DynAbs.Tracing.TraceSender.TraceExitMethod(25005, 4013, 4116);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25005, 4013, 4116);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25005, 4013, 4116);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static ImmutableArray<MetadataReference> Mscorlib45AndVBRuntimeReferences
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25005, 4208, 4312);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25005, 4211, 4312);
                    return f_25005_4211_4312(f_25005_4252_4267(), f_25005_4269_4282(), f_25005_4284_4311()); DynAbs.Tracing.TraceSender.TraceExitMethod(25005, 4208, 4312);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25005, 4208, 4312);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25005, 4208, 4312);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static ImmutableArray<MetadataReference> Mscorlib46References
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25005, 4392, 4452);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25005, 4395, 4452);
                    return f_25005_4395_4452(f_25005_4436_4451()); DynAbs.Tracing.TraceSender.TraceExitMethod(25005, 4392, 4452);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25005, 4392, 4452);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25005, 4392, 4452);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static ImmutableArray<MetadataReference> Mscorlib46ExtendedReferences
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25005, 4540, 4693);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25005, 4543, 4693);
                    return f_25005_4543_4693(f_25005_4584_4599(), f_25005_4601_4614(), f_25005_4616_4646(), f_25005_4648_4670(), f_25005_4672_4692()); DynAbs.Tracing.TraceSender.TraceExitMethod(25005, 4540, 4693);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25005, 4540, 4693);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25005, 4540, 4693);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static ImmutableArray<MetadataReference> Mscorlib461References
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25005, 4774, 4834);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25005, 4777, 4834);
                    return f_25005_4777_4834(f_25005_4818_4833()); DynAbs.Tracing.TraceSender.TraceExitMethod(25005, 4774, 4834);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25005, 4774, 4834);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25005, 4774, 4834);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static ImmutableArray<MetadataReference> Mscorlib461ExtendedReferences
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25005, 4923, 5066);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25005, 4926, 5066);
                    return f_25005_4926_5066(f_25005_4967_4982(), f_25005_4984_4997(), f_25005_4999_5016(), f_25005_5018_5043(), f_25005_5045_5065()); DynAbs.Tracing.TraceSender.TraceExitMethod(25005, 4923, 5066);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25005, 4923, 5066);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25005, 4923, 5066);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static ImmutableArray<MetadataReference> NetStandard20References
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25005, 5149, 5397);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25005, 5152, 5397);
                    return f_25005_5152_5397(f_25005_5193_5218(), f_25005_5220_5242(), f_25005_5244_5271(), f_25005_5273_5297(), f_25005_5299_5333(), f_25005_5335_5359(), f_25005_5361_5396()); DynAbs.Tracing.TraceSender.TraceExitMethod(25005, 5149, 5397);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25005, 5149, 5397);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25005, 5149, 5397);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static ImmutableArray<MetadataReference> NetCoreAppReferences
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25005, 5477, 6008);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25005, 5480, 6008);
                    return f_25005_5480_6008(f_25005_5521_5543(), f_25005_5545_5564(), f_25005_5566_5590(), f_25005_5592_5613(), f_25005_5739_5763(), f_25005_5765_5786(), f_25005_5788_5820(), f_25005_5822_5853(), f_25005_5979_6007()); DynAbs.Tracing.TraceSender.TraceExitMethod(25005, 5477, 6008);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25005, 5477, 6008);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25005, 5477, 6008);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static ImmutableArray<MetadataReference> WinRTReferences
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25005, 6083, 6127);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25005, 6086, 6127);
                    return f_25005_6086_6127(f_25005_6108_6126()); DynAbs.Tracing.TraceSender.TraceExitMethod(25005, 6083, 6127);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25005, 6083, 6127);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25005, 6083, 6127);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static ImmutableArray<MetadataReference> StandardReferences
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25005, 6205, 6298);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25005, 6208, 6298);
                    return (DynAbs.Tracing.TraceSender.Conditional_F1(25005, 6208, 6241) || ((f_25005_6208_6241() && DynAbs.Tracing.TraceSender.Conditional_F2(25005, 6244, 6267)) || DynAbs.Tracing.TraceSender.Conditional_F3(25005, 6270, 6298))) ? f_25005_6244_6267() : f_25005_6270_6298(); DynAbs.Tracing.TraceSender.TraceExitMethod(25005, 6205, 6298);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25005, 6205, 6298);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25005, 6205, 6298);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static ImmutableArray<MetadataReference> StandardLatestReferences
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25005, 6382, 6472);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25005, 6385, 6472);
                    return (DynAbs.Tracing.TraceSender.Conditional_F1(25005, 6385, 6418) || ((f_25005_6385_6418() && DynAbs.Tracing.TraceSender.Conditional_F2(25005, 6421, 6441)) || DynAbs.Tracing.TraceSender.Conditional_F3(25005, 6444, 6472))) ? f_25005_6421_6441() : f_25005_6444_6472(); DynAbs.Tracing.TraceSender.TraceExitMethod(25005, 6382, 6472);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25005, 6382, 6472);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25005, 6382, 6472);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static ImmutableArray<MetadataReference> StandardAndCSharpReferences
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25005, 6559, 6609);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25005, 6562, 6609);
                    return f_25005_6562_6580().Add(f_25005_6585_6608()); DynAbs.Tracing.TraceSender.TraceExitMethod(25005, 6559, 6609);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25005, 6559, 6609);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25005, 6559, 6609);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static ImmutableArray<MetadataReference> StandardAndVBRuntimeReferences
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25005, 6699, 6865);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25005, 6702, 6865);
                    return (DynAbs.Tracing.TraceSender.Conditional_F1(25005, 6702, 6735) || ((f_25005_6702_6735() && DynAbs.Tracing.TraceSender.Conditional_F2(25005, 6738, 6801)) || DynAbs.Tracing.TraceSender.Conditional_F3(25005, 6804, 6865))) ? f_25005_6738_6761().Add(f_25005_6766_6800()) : f_25005_6804_6832().Add(f_25005_6837_6864()); DynAbs.Tracing.TraceSender.TraceExitMethod(25005, 6699, 6865);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25005, 6699, 6865);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25005, 6699, 6865);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static ImmutableArray<MetadataReference> StandardCompatReferences
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25005, 6949, 7034);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25005, 6952, 7034);
                    return (DynAbs.Tracing.TraceSender.Conditional_F1(25005, 6952, 6985) || ((f_25005_6952_6985() && DynAbs.Tracing.TraceSender.Conditional_F2(25005, 6988, 7011)) || DynAbs.Tracing.TraceSender.Conditional_F3(25005, 7014, 7034))) ? f_25005_6988_7011() : f_25005_7014_7034(); DynAbs.Tracing.TraceSender.TraceExitMethod(25005, 6949, 7034);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25005, 6949, 7034);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25005, 6949, 7034);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static ImmutableArray<MetadataReference> DefaultVbReferences
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25005, 7113, 7236);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25005, 7116, 7236);
                    return f_25005_7116_7236(f_25005_7157_7172(), f_25005_7174_7187(), f_25005_7189_7206(), f_25005_7208_7235()); DynAbs.Tracing.TraceSender.TraceExitMethod(25005, 7113, 7236);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25005, 7113, 7236);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25005, 7113, 7236);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static ImmutableArray<MetadataReference> MinimalReferences
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25005, 7313, 7360);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25005, 7316, 7360);
                    return f_25005_7316_7360(f_25005_7338_7359()); DynAbs.Tracing.TraceSender.TraceExitMethod(25005, 7313, 7360);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25005, 7313, 7360);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25005, 7313, 7360);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static ImmutableArray<MetadataReference> MinimalAsyncReferences
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25005, 7442, 7494);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25005, 7445, 7494);
                    return f_25005_7445_7494(f_25005_7467_7493()); DynAbs.Tracing.TraceSender.TraceExitMethod(25005, 7442, 7494);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25005, 7442, 7494);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25005, 7442, 7494);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static ImmutableArray<MetadataReference> GetReferences(TargetFramework targetFramework)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25005, 7602, 9525);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25005, 7605, 9525);
                return targetFramework switch
                {
                    TargetFramework.Empty when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25005, 7652, 7716) && DynAbs.Tracing.TraceSender.Expression_True(25005, 7652, 7716))
        => ImmutableArray<MetadataReference>.Empty,
                    TargetFramework.Mscorlib40 when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25005, 7731, 7781) && DynAbs.Tracing.TraceSender.Expression_True(25005, 7731, 7781))
        => f_25005_7761_7781(),
                    TargetFramework.Mscorlib40Extended when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25005, 7796, 7862) && DynAbs.Tracing.TraceSender.Expression_True(25005, 7796, 7862))
        => f_25005_7834_7862(),
                    TargetFramework.Mscorlib40AndSystemCore when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25005, 7877, 7953) && DynAbs.Tracing.TraceSender.Expression_True(25005, 7877, 7953))
        => f_25005_7920_7953(),
                    TargetFramework.Mscorlib40AndVBRuntime when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25005, 7968, 8042) && DynAbs.Tracing.TraceSender.Expression_True(25005, 7968, 8042))
        => f_25005_8010_8042(),
                    TargetFramework.Mscorlib45 when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25005, 8057, 8107) && DynAbs.Tracing.TraceSender.Expression_True(25005, 8057, 8107))
        => f_25005_8087_8107(),
                    TargetFramework.Mscorlib45Extended when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25005, 8122, 8188) && DynAbs.Tracing.TraceSender.Expression_True(25005, 8122, 8188))
        => f_25005_8160_8188(),
                    TargetFramework.Mscorlib45AndCSharp when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25005, 8203, 8271) && DynAbs.Tracing.TraceSender.Expression_True(25005, 8203, 8271))
        => f_25005_8242_8271(),
                    TargetFramework.Mscorlib45AndVBRuntime when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25005, 8286, 8360) && DynAbs.Tracing.TraceSender.Expression_True(25005, 8286, 8360))
        => f_25005_8328_8360(),
                    TargetFramework.Mscorlib46 when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25005, 8375, 8425) && DynAbs.Tracing.TraceSender.Expression_True(25005, 8375, 8425))
        => f_25005_8405_8425(),
                    TargetFramework.Mscorlib46Extended when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25005, 8440, 8506) && DynAbs.Tracing.TraceSender.Expression_True(25005, 8440, 8506))
        => f_25005_8478_8506(),
                    TargetFramework.Mscorlib461 when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25005, 8521, 8572) && DynAbs.Tracing.TraceSender.Expression_True(25005, 8521, 8572))
        => f_25005_8552_8572(),
                    TargetFramework.Mscorlib461Extended when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25005, 8587, 8655) && DynAbs.Tracing.TraceSender.Expression_True(25005, 8587, 8655))
        => f_25005_8626_8655(),
                    TargetFramework.NetStandard20 when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25005, 8670, 8726) && DynAbs.Tracing.TraceSender.Expression_True(25005, 8670, 8726))
        => f_25005_8703_8726(),
                    TargetFramework.NetCoreApp when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25005, 8741, 8791) && DynAbs.Tracing.TraceSender.Expression_True(25005, 8741, 8791))
        => f_25005_8771_8791(),
                    TargetFramework.WinRT when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25005, 8806, 8846) && DynAbs.Tracing.TraceSender.Expression_True(25005, 8806, 8846))
        => f_25005_8831_8846(),
                    TargetFramework.Standard when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25005, 8861, 8907) && DynAbs.Tracing.TraceSender.Expression_True(25005, 8861, 8907))
        => f_25005_8889_8907(),
                    TargetFramework.StandardLatest when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25005, 8922, 8980) && DynAbs.Tracing.TraceSender.Expression_True(25005, 8922, 8980))
        => f_25005_8956_8980(),
                    TargetFramework.StandardAndCSharp when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25005, 8995, 9059) && DynAbs.Tracing.TraceSender.Expression_True(25005, 8995, 9059))
        => f_25005_9032_9059(),
                    TargetFramework.StandardAndVBRuntime when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25005, 9074, 9144) && DynAbs.Tracing.TraceSender.Expression_True(25005, 9074, 9144))
        => f_25005_9114_9144(),
                    TargetFramework.StandardCompat when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25005, 9159, 9217) && DynAbs.Tracing.TraceSender.Expression_True(25005, 9159, 9217))
        => f_25005_9193_9217(),
                    TargetFramework.DefaultVb when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25005, 9232, 9280) && DynAbs.Tracing.TraceSender.Expression_True(25005, 9232, 9280))
        => f_25005_9261_9280(),
                    TargetFramework.Minimal when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25005, 9295, 9339) && DynAbs.Tracing.TraceSender.Expression_True(25005, 9295, 9339))
        => f_25005_9322_9339(),
                    TargetFramework.MinimalAsync when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25005, 9354, 9408) && DynAbs.Tracing.TraceSender.Expression_True(25005, 9354, 9408))
        => f_25005_9386_9408(),
                    _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25005, 9423, 9513) && DynAbs.Tracing.TraceSender.Expression_True(25005, 9423, 9513))
        => throw f_25005_9434_9513($"Unexpected target framework {targetFramework}"),
                }; DynAbs.Tracing.TraceSender.TraceExitMethod(25005, 7602, 9525);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25005, 7602, 9525);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25005, 7602, 9525);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
            f_25005_7761_7781()
            {
                var return_v = Mscorlib40References;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 7761, 7781);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
            f_25005_7834_7862()
            {
                var return_v = Mscorlib40ExtendedReferences;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 7834, 7862);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
            f_25005_7920_7953()
            {
                var return_v = Mscorlib40andSystemCoreReferences;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 7920, 7953);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
            f_25005_8010_8042()
            {
                var return_v = Mscorlib40andVBRuntimeReferences;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 8010, 8042);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
            f_25005_8087_8107()
            {
                var return_v = Mscorlib45References;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 8087, 8107);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
            f_25005_8160_8188()
            {
                var return_v = Mscorlib45ExtendedReferences;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 8160, 8188);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
            f_25005_8242_8271()
            {
                var return_v = Mscorlib45AndCSharpReferences;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 8242, 8271);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
            f_25005_8328_8360()
            {
                var return_v = Mscorlib45AndVBRuntimeReferences;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 8328, 8360);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
            f_25005_8405_8425()
            {
                var return_v = Mscorlib46References;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 8405, 8425);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
            f_25005_8478_8506()
            {
                var return_v = Mscorlib46ExtendedReferences;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 8478, 8506);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
            f_25005_8552_8572()
            {
                var return_v = Mscorlib46References;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 8552, 8572);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
            f_25005_8626_8655()
            {
                var return_v = Mscorlib461ExtendedReferences;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 8626, 8655);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
            f_25005_8703_8726()
            {
                var return_v = NetStandard20References;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 8703, 8726);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
            f_25005_8771_8791()
            {
                var return_v = NetCoreAppReferences;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 8771, 8791);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
            f_25005_8831_8846()
            {
                var return_v = WinRTReferences;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 8831, 8846);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
            f_25005_8889_8907()
            {
                var return_v = StandardReferences;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 8889, 8907);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
            f_25005_8956_8980()
            {
                var return_v = StandardLatestReferences;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 8956, 8980);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
            f_25005_9032_9059()
            {
                var return_v = StandardAndCSharpReferences;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 9032, 9059);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
            f_25005_9114_9144()
            {
                var return_v = StandardAndVBRuntimeReferences;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 9114, 9144);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
            f_25005_9193_9217()
            {
                var return_v = StandardCompatReferences;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 9193, 9217);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
            f_25005_9261_9280()
            {
                var return_v = DefaultVbReferences;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 9261, 9280);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
            f_25005_9322_9339()
            {
                var return_v = MinimalReferences;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 9322, 9339);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
            f_25005_9386_9408()
            {
                var return_v = MinimalAsyncReferences;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 9386, 9408);
                return return_v;
            }


            System.InvalidOperationException
            f_25005_9434_9513(string
            message)
            {
                var return_v = new System.InvalidOperationException(message);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25005, 9434, 9513);
                return return_v;
            }

        }

        public static ImmutableArray<MetadataReference> GetReferences(TargetFramework tf, IEnumerable<MetadataReference> additionalReferences)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25005, 9538, 12254);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25005, 9697, 9732);

                var
                references = f_25005_9714_9731(tf)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25005, 9746, 9845) || true) && (additionalReferences == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25005, 9746, 9845);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25005, 9812, 9830);

                    return references;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25005, 9746, 9845);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25005, 9861, 9923);

                f_25005_9861_9922(references, additionalReferences);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25005, 9937, 9986);

                return references.AddRange(additionalReferences);

                void checkForDuplicateReferences(ImmutableArray<MetadataReference> refer, IEnumerable<MetadataReference> additRef)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25005, 10413, 11177);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25005, 10560, 10645);

                        var
                        nameSet = f_25005_10574_10644(f_25005_10594_10609(refer), f_25005_10611_10643())
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25005, 10663, 11162);
                            foreach (var r in f_25005_10681_10689_I(additRef))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25005, 10663, 11162);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25005, 10731, 10890) || true) && (refer.Contains(r))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25005, 10731, 10890);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25005, 10802, 10867);

                                    throw f_25005_10808_10866($"Duplicate reference detected {f_25005_10854_10863(r)}");
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25005, 10731, 10890);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25005, 10914, 10936);

                                var
                                name = f_25005_10925_10935(r)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25005, 10958, 11143) || true) && (name != null && (DynAbs.Tracing.TraceSender.Expression_True(25005, 10962, 10996) && !f_25005_10979_10996(nameSet, name)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25005, 10958, 11143);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25005, 11046, 11120);

                                    throw f_25005_11052_11119($"Duplicate reference detected {f_25005_11098_11107(r)} - {name}");
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25005, 10958, 11143);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25005, 10663, 11162);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(25005, 1, 500);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(25005, 1, 500);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(25005, 10413, 11177);

                        System.Collections.Generic.IEnumerable<string>
                        f_25005_10594_10609(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
                        e)
                        {
                            var return_v = getNames((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)e);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25005, 10594, 10609);
                            return return_v;
                        }


                        System.StringComparer
                        f_25005_10611_10643()
                        {
                            var return_v = StringComparer.OrdinalIgnoreCase;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 10611, 10643);
                            return return_v;
                        }


                        System.Collections.Generic.HashSet<string>
                        f_25005_10574_10644(System.Collections.Generic.IEnumerable<string>
                        collection, System.StringComparer
                        comparer)
                        {
                            var return_v = new System.Collections.Generic.HashSet<string>(collection, (System.Collections.Generic.IEqualityComparer<string>)comparer);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25005, 10574, 10644);
                            return return_v;
                        }


                        string?
                        f_25005_10854_10863(Microsoft.CodeAnalysis.MetadataReference
                        this_param)
                        {
                            var return_v = this_param.Display;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 10854, 10863);
                            return return_v;
                        }


                        System.Exception
                        f_25005_10808_10866(string
                        message)
                        {
                            var return_v = new System.Exception(message);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25005, 10808, 10866);
                            return return_v;
                        }


                        string
                        f_25005_10925_10935(Microsoft.CodeAnalysis.MetadataReference
                        m)
                        {
                            var return_v = getName(m);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25005, 10925, 10935);
                            return return_v;
                        }


                        bool
                        f_25005_10979_10996(System.Collections.Generic.HashSet<string>
                        this_param, string
                        item)
                        {
                            var return_v = this_param.Add(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25005, 10979, 10996);
                            return return_v;
                        }


                        string?
                        f_25005_11098_11107(Microsoft.CodeAnalysis.MetadataReference
                        this_param)
                        {
                            var return_v = this_param.Display;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 11098, 11107);
                            return return_v;
                        }


                        System.Exception
                        f_25005_11052_11119(string
                        message)
                        {
                            var return_v = new System.Exception(message);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25005, 11052, 11119);
                            return return_v;
                        }


                        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>
                        f_25005_10681_10689_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25005, 10681, 10689);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25005, 10413, 11177);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25005, 10413, 11177);
                    }
                }

                IEnumerable<string> getNames(IEnumerable<MetadataReference> e)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25005, 11193, 11534);

                        var listYield = new List<String>();
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25005, 11288, 11519);
                            foreach (var r in f_25005_11306_11307_I(e))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25005, 11288, 11519);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25005, 11349, 11371);

                                var
                                name = f_25005_11360_11370(r)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25005, 11393, 11500) || true) && (name != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25005, 11393, 11500);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25005, 11459, 11477);

                                    listYield.Add(name);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25005, 11393, 11500);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25005, 11288, 11519);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(25005, 1, 232);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(25005, 1, 232);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(25005, 11193, 11534);

                        return listYield;

                        string
                        f_25005_11360_11370(Microsoft.CodeAnalysis.MetadataReference
                        m)
                        {
                            var return_v = getName(m);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25005, 11360, 11370);
                            return return_v;
                        }


                        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>
                        f_25005_11306_11307_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25005, 11306, 11307);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25005, 11193, 11534);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25005, 11193, 11534);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                string getName(MetadataReference m)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25005, 11550, 12243);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25005, 11618, 12196) || true) && (m is PortableExecutableReference p && (DynAbs.Tracing.TraceSender.Expression_True(25005, 11622, 11733) && f_25005_11681_11696(p) is AssemblyMetadata assemblyMetadata))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25005, 11618, 12196);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25005, 11827, 11882);

                                var
                                identity = f_25005_11842_11881(f_25005_11842_11872(assemblyMetadata))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25005, 11908, 11930);

                                return f_25005_11915_11929_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(identity, 25005, 11915, 11929)?.Name);
                            }
                            catch (BadImageFormatException)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(25005, 11975, 12177);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25005, 12142, 12154);

                                return null;
                                DynAbs.Tracing.TraceSender.TraceExitCatch(25005, 11975, 12177);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25005, 11618, 12196);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25005, 12216, 12228);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(25005, 11550, 12243);

                        Microsoft.CodeAnalysis.Metadata
                        f_25005_11681_11696(Microsoft.CodeAnalysis.PortableExecutableReference
                        this_param)
                        {
                            var return_v = this_param.GetMetadata();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25005, 11681, 11696);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.PEAssembly?
                        f_25005_11842_11872(Microsoft.CodeAnalysis.AssemblyMetadata
                        this_param)
                        {
                            var return_v = this_param.GetAssembly();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25005, 11842, 11872);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.AssemblyIdentity
                        f_25005_11842_11881(Microsoft.CodeAnalysis.PEAssembly?
                        this_param)
                        {
                            var return_v = this_param.Identity;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 11842, 11881);
                            return return_v;
                        }


                        string?
                        f_25005_11915_11929_M(string?
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 11915, 11929);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25005, 11550, 12243);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25005, 11550, 12243);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25005, 9538, 12254);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
                f_25005_9714_9731(Roslyn.Test.Utilities.TargetFramework
                targetFramework)
                {
                    var return_v = GetReferences(targetFramework);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25005, 9714, 9731);
                    return return_v;
                }


                int
                f_25005_9861_9922(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
                refer, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>
                additRef)
                {
                    checkForDuplicateReferences(refer, additRef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25005, 9861, 9922);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25005, 9538, 12254);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25005, 9538, 12254);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static TargetFrameworkUtil()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25005, 2234, 12261);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25005, 2234, 12261);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25005, 2234, 12261);
        }


        static bool
        f_25005_2349_2382()
        {
            var return_v = RuntimeUtilities.IsCoreClrRuntime;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 2349, 2382);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PortableExecutableReference
        f_25005_2385_2417()
        {
            var return_v = MicrosoftCSharp.Netstandard13Lib;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 2385, 2417);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PortableExecutableReference
        f_25005_2420_2442()
        {
            var return_v = Net451.MicrosoftCSharp;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 2420, 2442);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PortableExecutableReference
        f_25005_2999_3013()
        {
            var return_v = Net40.mscorlib;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 2999, 3013);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
        f_25005_2958_3014(Microsoft.CodeAnalysis.PortableExecutableReference
        item)
        {
            var return_v = ImmutableArray.Create<MetadataReference>((Microsoft.CodeAnalysis.MetadataReference)item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25005, 2958, 3014);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PortableExecutableReference
        f_25005_3146_3160()
        {
            var return_v = Net40.mscorlib;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 3146, 3160);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PortableExecutableReference
        f_25005_3162_3174()
        {
            var return_v = Net40.System;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 3162, 3174);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PortableExecutableReference
        f_25005_3176_3192()
        {
            var return_v = Net40.SystemCore;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 3176, 3192);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
        f_25005_3105_3193(Microsoft.CodeAnalysis.PortableExecutableReference
        item1, Microsoft.CodeAnalysis.PortableExecutableReference
        item2, Microsoft.CodeAnalysis.PortableExecutableReference
        item3)
        {
            var return_v = ImmutableArray.Create<MetadataReference>((Microsoft.CodeAnalysis.MetadataReference)item1, (Microsoft.CodeAnalysis.MetadataReference)item2, (Microsoft.CodeAnalysis.MetadataReference)item3);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25005, 3105, 3193);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PortableExecutableReference
        f_25005_3330_3344()
        {
            var return_v = Net40.mscorlib;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 3330, 3344);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PortableExecutableReference
        f_25005_3346_3362()
        {
            var return_v = Net40.SystemCore;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 3346, 3362);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
        f_25005_3289_3363(Microsoft.CodeAnalysis.PortableExecutableReference
        item1, Microsoft.CodeAnalysis.PortableExecutableReference
        item2)
        {
            var return_v = ImmutableArray.Create<MetadataReference>((Microsoft.CodeAnalysis.MetadataReference)item1, (Microsoft.CodeAnalysis.MetadataReference)item2);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25005, 3289, 3363);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PortableExecutableReference
        f_25005_3499_3513()
        {
            var return_v = Net40.mscorlib;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 3499, 3513);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PortableExecutableReference
        f_25005_3515_3527()
        {
            var return_v = Net40.System;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 3515, 3527);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PortableExecutableReference
        f_25005_3529_3555()
        {
            var return_v = Net40.MicrosoftVisualBasic;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 3529, 3555);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
        f_25005_3458_3556(Microsoft.CodeAnalysis.PortableExecutableReference
        item1, Microsoft.CodeAnalysis.PortableExecutableReference
        item2, Microsoft.CodeAnalysis.PortableExecutableReference
        item3)
        {
            var return_v = ImmutableArray.Create<MetadataReference>((Microsoft.CodeAnalysis.MetadataReference)item1, (Microsoft.CodeAnalysis.MetadataReference)item2, (Microsoft.CodeAnalysis.MetadataReference)item3);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25005, 3458, 3556);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PortableExecutableReference
        f_25005_3680_3695()
        {
            var return_v = Net451.mscorlib;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 3680, 3695);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
        f_25005_3639_3696(Microsoft.CodeAnalysis.PortableExecutableReference
        item)
        {
            var return_v = ImmutableArray.Create<MetadataReference>((Microsoft.CodeAnalysis.MetadataReference)item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25005, 3639, 3696);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PortableExecutableReference
        f_25005_3828_3843()
        {
            var return_v = Net451.mscorlib;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 3828, 3843);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PortableExecutableReference
        f_25005_3845_3858()
        {
            var return_v = Net451.System;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 3845, 3858);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PortableExecutableReference
        f_25005_3860_3877()
        {
            var return_v = Net451.SystemCore;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 3860, 3877);
            return return_v;
        }


        static Microsoft.CodeAnalysis.MetadataReference
        f_25005_3879_3901()
        {
            var return_v = TestBase.ValueTupleRef;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 3879, 3901);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PortableExecutableReference
        f_25005_3903_3923()
        {
            var return_v = Net451.SystemRuntime;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 3903, 3923);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
        f_25005_3787_3924(params Microsoft.CodeAnalysis.MetadataReference[]
        items)
        {
            var return_v = ImmutableArray.Create<MetadataReference>(items);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25005, 3787, 3924);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PortableExecutableReference
        f_25005_4057_4072()
        {
            var return_v = Net451.mscorlib;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 4057, 4072);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PortableExecutableReference
        f_25005_4074_4091()
        {
            var return_v = Net451.SystemCore;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 4074, 4091);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PortableExecutableReference
        f_25005_4093_4115()
        {
            var return_v = Net451.MicrosoftCSharp;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 4093, 4115);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
        f_25005_4016_4116(Microsoft.CodeAnalysis.PortableExecutableReference
        item1, Microsoft.CodeAnalysis.PortableExecutableReference
        item2, Microsoft.CodeAnalysis.PortableExecutableReference
        item3)
        {
            var return_v = ImmutableArray.Create<MetadataReference>((Microsoft.CodeAnalysis.MetadataReference)item1, (Microsoft.CodeAnalysis.MetadataReference)item2, (Microsoft.CodeAnalysis.MetadataReference)item3);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25005, 4016, 4116);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PortableExecutableReference
        f_25005_4252_4267()
        {
            var return_v = Net451.mscorlib;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 4252, 4267);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PortableExecutableReference
        f_25005_4269_4282()
        {
            var return_v = Net451.System;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 4269, 4282);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PortableExecutableReference
        f_25005_4284_4311()
        {
            var return_v = Net451.MicrosoftVisualBasic;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 4284, 4311);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
        f_25005_4211_4312(Microsoft.CodeAnalysis.PortableExecutableReference
        item1, Microsoft.CodeAnalysis.PortableExecutableReference
        item2, Microsoft.CodeAnalysis.PortableExecutableReference
        item3)
        {
            var return_v = ImmutableArray.Create<MetadataReference>((Microsoft.CodeAnalysis.MetadataReference)item1, (Microsoft.CodeAnalysis.MetadataReference)item2, (Microsoft.CodeAnalysis.MetadataReference)item3);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25005, 4211, 4312);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PortableExecutableReference
        f_25005_4436_4451()
        {
            var return_v = Net461.mscorlib;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 4436, 4451);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
        f_25005_4395_4452(Microsoft.CodeAnalysis.PortableExecutableReference
        item)
        {
            var return_v = ImmutableArray.Create<MetadataReference>((Microsoft.CodeAnalysis.MetadataReference)item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25005, 4395, 4452);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PortableExecutableReference
        f_25005_4584_4599()
        {
            var return_v = Net461.mscorlib;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 4584, 4599);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PortableExecutableReference
        f_25005_4601_4614()
        {
            var return_v = Net461.System;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 4601, 4614);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PortableExecutableReference
        f_25005_4616_4646()
        {
            var return_v = TestMetadata.Net461.SystemCore;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 4616, 4646);
            return return_v;
        }


        static Microsoft.CodeAnalysis.MetadataReference
        f_25005_4648_4670()
        {
            var return_v = TestBase.ValueTupleRef;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 4648, 4670);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PortableExecutableReference
        f_25005_4672_4692()
        {
            var return_v = Net461.SystemRuntime;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 4672, 4692);
            return return_v;
        }


       static  System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
        f_25005_4543_4693(params Microsoft.CodeAnalysis.MetadataReference[]
        items)
        {
            var return_v = ImmutableArray.Create<MetadataReference>(items);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25005, 4543, 4693);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PortableExecutableReference
        f_25005_4818_4833()
        {
            var return_v = Net461.mscorlib;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 4818, 4833);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
        f_25005_4777_4834(Microsoft.CodeAnalysis.PortableExecutableReference
        item)
        {
            var return_v = ImmutableArray.Create<MetadataReference>((Microsoft.CodeAnalysis.MetadataReference)item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25005, 4777, 4834);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PortableExecutableReference
        f_25005_4967_4982()
        {
            var return_v = Net461.mscorlib;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 4967, 4982);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PortableExecutableReference
        f_25005_4984_4997()
        {
            var return_v = Net461.System;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 4984, 4997);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PortableExecutableReference
        f_25005_4999_5016()
        {
            var return_v = Net461.SystemCore;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 4999, 5016);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PortableExecutableReference
        f_25005_5018_5043()
        {
            var return_v = NetFx.ValueTuple.tuplelib;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 5018, 5043);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PortableExecutableReference
        f_25005_5045_5065()
        {
            var return_v = Net461.SystemRuntime;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 5045, 5065);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
        f_25005_4926_5066(params Microsoft.CodeAnalysis.MetadataReference[]
        items)
        {
            var return_v = ImmutableArray.Create<MetadataReference>(items);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25005, 4926, 5066);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PortableExecutableReference
        f_25005_5193_5218()
        {
            var return_v = NetStandard20.netstandard;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 5193, 5218);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PortableExecutableReference
        f_25005_5220_5242()
        {
            var return_v = NetStandard20.mscorlib;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 5220, 5242);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PortableExecutableReference
        f_25005_5244_5271()
        {
            var return_v = NetStandard20.SystemRuntime;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 5244, 5271);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PortableExecutableReference
        f_25005_5273_5297()
        {
            var return_v = NetStandard20.SystemCore;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 5273, 5297);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PortableExecutableReference
        f_25005_5299_5333()
        {
            var return_v = NetStandard20.SystemDynamicRuntime;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 5299, 5333);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PortableExecutableReference
        f_25005_5335_5359()
        {
            var return_v = NetStandard20.SystemLinq;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 5335, 5359);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PortableExecutableReference
        f_25005_5361_5396()
        {
            var return_v = NetStandard20.SystemLinqExpressions;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 5361, 5396);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
        f_25005_5152_5397(params Microsoft.CodeAnalysis.MetadataReference[]
        items)
        {
            var return_v = ImmutableArray.Create<MetadataReference>(items);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25005, 5152, 5397);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PortableExecutableReference
        f_25005_5521_5543()
        {
            var return_v = NetCoreApp.netstandard;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 5521, 5543);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PortableExecutableReference
        f_25005_5545_5564()
        {
            var return_v = NetCoreApp.mscorlib;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 5545, 5564);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PortableExecutableReference
        f_25005_5566_5590()
        {
            var return_v = NetCoreApp.SystemRuntime;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 5566, 5590);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PortableExecutableReference
        f_25005_5592_5613()
        {
            var return_v = NetCoreApp.SystemCore;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 5592, 5613);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PortableExecutableReference
        f_25005_5739_5763()
        {
            var return_v = NetCoreApp.SystemConsole;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 5739, 5763);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PortableExecutableReference
        f_25005_5765_5786()
        {
            var return_v = NetCoreApp.SystemLinq;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 5765, 5786);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PortableExecutableReference
        f_25005_5788_5820()
        {
            var return_v = NetCoreApp.SystemLinqExpressions;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 5788, 5820);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PortableExecutableReference
        f_25005_5822_5853()
        {
            var return_v = NetCoreApp.SystemThreadingTasks;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 5822, 5853);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PortableExecutableReference
        f_25005_5979_6007()
        {
            var return_v = NetCoreApp.SystemCollections;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 5979, 6007);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
        f_25005_5480_6008(params Microsoft.CodeAnalysis.MetadataReference[]
        items)
        {
            var return_v = ImmutableArray.Create<MetadataReference>(items);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25005, 5480, 6008);
            return return_v;
        }


        static Microsoft.CodeAnalysis.MetadataReference[]
        f_25005_6108_6126()
        {
            var return_v = TestBase.WinRtRefs;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 6108, 6126);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
        f_25005_6086_6127(params Microsoft.CodeAnalysis.MetadataReference[]
        items)
        {
            var return_v = ImmutableArray.Create(items);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25005, 6086, 6127);
            return return_v;
        }


        static bool
        f_25005_6208_6241()
        {
            var return_v = RuntimeUtilities.IsCoreClrRuntime;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 6208, 6241);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
        f_25005_6244_6267()
        {
            var return_v = NetStandard20References;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 6244, 6267);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
        f_25005_6270_6298()
        {
            var return_v = Mscorlib46ExtendedReferences;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 6270, 6298);
            return return_v;
        }


        static bool
        f_25005_6385_6418()
        {
            var return_v = RuntimeUtilities.IsCoreClrRuntime;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 6385, 6418);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
        f_25005_6421_6441()
        {
            var return_v = NetCoreAppReferences;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 6421, 6441);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
        f_25005_6444_6472()
        {
            var return_v = Mscorlib46ExtendedReferences;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 6444, 6472);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
        f_25005_6562_6580()
        {
            var return_v = StandardReferences;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 6562, 6580);
            return return_v;
        }


        static Microsoft.CodeAnalysis.MetadataReference
        f_25005_6585_6608()
        {
            var return_v = StandardCSharpReference;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 6585, 6608);
            return return_v;
        }


        static bool
        f_25005_6702_6735()
        {
            var return_v = RuntimeUtilities.IsCoreClrRuntime;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 6702, 6735);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
        f_25005_6738_6761()
        {
            var return_v = NetStandard20References;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 6738, 6761);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PortableExecutableReference
        f_25005_6766_6800()
        {
            var return_v = MicrosoftVisualBasic.Netstandard11;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 6766, 6800);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
        f_25005_6804_6832()
        {
            var return_v = Mscorlib46ExtendedReferences;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 6804, 6832);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PortableExecutableReference
        f_25005_6837_6864()
        {
            var return_v = Net461.MicrosoftVisualBasic;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 6837, 6864);
            return return_v;
        }


        static bool
        f_25005_6952_6985()
        {
            var return_v = RuntimeUtilities.IsCoreClrRuntime;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 6952, 6985);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
        f_25005_6988_7011()
        {
            var return_v = NetStandard20References;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 6988, 7011);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
        f_25005_7014_7034()
        {
            var return_v = Mscorlib40References;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 7014, 7034);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PortableExecutableReference
        f_25005_7157_7172()
        {
            var return_v = Net451.mscorlib;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 7157, 7172);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PortableExecutableReference
        f_25005_7174_7187()
        {
            var return_v = Net451.System;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 7174, 7187);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PortableExecutableReference
        f_25005_7189_7206()
        {
            var return_v = Net451.SystemCore;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 7189, 7206);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PortableExecutableReference
        f_25005_7208_7235()
        {
            var return_v = Net451.MicrosoftVisualBasic;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 7208, 7235);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
        f_25005_7116_7236(Microsoft.CodeAnalysis.PortableExecutableReference
        item1, Microsoft.CodeAnalysis.PortableExecutableReference
        item2, Microsoft.CodeAnalysis.PortableExecutableReference
        item3, Microsoft.CodeAnalysis.PortableExecutableReference
        item4)
        {
            var return_v = ImmutableArray.Create<MetadataReference>((Microsoft.CodeAnalysis.MetadataReference)item1, (Microsoft.CodeAnalysis.MetadataReference)item2, (Microsoft.CodeAnalysis.MetadataReference)item3, (Microsoft.CodeAnalysis.MetadataReference)item4);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25005, 7116, 7236);
            return return_v;
        }


        static Microsoft.CodeAnalysis.MetadataReference
        f_25005_7338_7359()
        {
            var return_v = TestBase.MinCorlibRef;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 7338, 7359);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
        f_25005_7316_7360(Microsoft.CodeAnalysis.MetadataReference
        item)
        {
            var return_v = ImmutableArray.Create(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25005, 7316, 7360);
            return return_v;
        }


        static Microsoft.CodeAnalysis.MetadataReference
        f_25005_7467_7493()
        {
            var return_v = TestBase.MinAsyncCorlibRef;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25005, 7467, 7493);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
        f_25005_7445_7494(Microsoft.CodeAnalysis.MetadataReference
        item)
        {
            var return_v = ImmutableArray.Create(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25005, 7445, 7494);
            return return_v;
        }

    }
}
