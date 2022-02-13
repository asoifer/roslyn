// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class SignatureOnlyParameterSymbol : ParameterSymbol
    {
        private readonly TypeWithAnnotations _type;

        private readonly ImmutableArray<CustomModifier> _refCustomModifiers;

        private readonly bool _isParams;

        private readonly RefKind _refKind;

        public SignatureOnlyParameterSymbol(
                    TypeWithAnnotations type,
                    ImmutableArray<CustomModifier> refCustomModifiers,
                    bool isParams,
                    RefKind refKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10153, 828, 1311);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10153, 762, 771);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10153, 807, 815);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10153, 1050, 1090);

                f_10153_1050_1089((object)type.Type != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10153, 1104, 1148);

                f_10153_1104_1147(f_10153_1117_1146_M(!refCustomModifiers.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10153, 1164, 1177);

                _type = type;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10153, 1191, 1232);

                _refCustomModifiers = refCustomModifiers;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10153, 1246, 1267);

                _isParams = isParams;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10153, 1281, 1300);

                _refKind = refKind;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10153, 828, 1311);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10153, 828, 1311);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10153, 828, 1311);
            }
        }

        public override TypeWithAnnotations TypeWithAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10153, 1381, 1402);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10153, 1387, 1400);

                    return _type;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10153, 1381, 1402);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10153, 1323, 1404);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10153, 1323, 1404);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<CustomModifier> RefCustomModifiers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10153, 1484, 1519);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10153, 1490, 1517);

                    return _refCustomModifiers;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10153, 1484, 1519);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10153, 1416, 1521);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10153, 1416, 1521);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsParams
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10153, 1565, 1590);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10153, 1571, 1588);

                    return _isParams;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10153, 1565, 1590);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10153, 1533, 1592);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10153, 1533, 1592);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override RefKind RefKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10153, 1638, 1662);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10153, 1644, 1660);

                    return _refKind;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10153, 1638, 1662);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10153, 1604, 1664);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10153, 1604, 1664);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10153, 1706, 1724);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10153, 1712, 1722);

                    return "";
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10153, 1706, 1724);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10153, 1676, 1726);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10153, 1676, 1726);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsImplicitlyDeclared
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10153, 1782, 1802);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10153, 1788, 1800);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10153, 1782, 1802);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10153, 1738, 1804);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10153, 1738, 1804);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsDiscard
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10153, 1849, 1870);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10153, 1855, 1868);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10153, 1849, 1870);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10153, 1816, 1872);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10153, 1816, 1872);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsMetadataIn
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10153, 1977, 2022);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10153, 1983, 2020);

                    throw f_10153_1989_2019();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10153, 1977, 2022);

                    System.Exception
                    f_10153_1989_2019()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10153, 1989, 2019);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10153, 1939, 2024);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10153, 1939, 2024);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsMetadataOut
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10153, 2075, 2120);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10153, 2081, 2118);

                    throw f_10153_2087_2117();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10153, 2075, 2120);

                    System.Exception
                    f_10153_2087_2117()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10153, 2087, 2117);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10153, 2036, 2122);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10153, 2036, 2122);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override MarshalPseudoCustomAttributeData MarshallingInformation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10153, 2210, 2255);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10153, 2216, 2253);

                    throw f_10153_2222_2252();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10153, 2210, 2255);

                    System.Exception
                    f_10153_2222_2252()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10153, 2222, 2252);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10153, 2134, 2257);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10153, 2134, 2257);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int Ordinal
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10153, 2299, 2344);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10153, 2305, 2342);

                    throw f_10153_2311_2341();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10153, 2299, 2344);

                    System.Exception
                    f_10153_2311_2341()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10153, 2311, 2341);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10153, 2269, 2346);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10153, 2269, 2346);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsMetadataOptional
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10153, 2402, 2447);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10153, 2408, 2445);

                    throw f_10153_2414_2444();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10153, 2402, 2447);

                    System.Exception
                    f_10153_2414_2444()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10153, 2414, 2444);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10153, 2358, 2449);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10153, 2358, 2449);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ConstantValue ExplicitDefaultConstantValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10153, 2524, 2569);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10153, 2530, 2567);

                    throw f_10153_2536_2566();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10153, 2524, 2569);

                    System.Exception
                    f_10153_2536_2566()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10153, 2536, 2566);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10153, 2461, 2571);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10153, 2461, 2571);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsIDispatchConstant
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10153, 2628, 2673);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10153, 2634, 2671);

                    throw f_10153_2640_2670();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10153, 2628, 2673);

                    System.Exception
                    f_10153_2640_2670()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10153, 2640, 2670);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10153, 2583, 2675);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10153, 2583, 2675);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsIUnknownConstant
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10153, 2731, 2776);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10153, 2737, 2774);

                    throw f_10153_2743_2773();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10153, 2731, 2776);

                    System.Exception
                    f_10153_2743_2773()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10153, 2743, 2773);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10153, 2687, 2778);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10153, 2687, 2778);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsCallerFilePath
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10153, 2832, 2877);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10153, 2838, 2875);

                    throw f_10153_2844_2874();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10153, 2832, 2877);

                    System.Exception
                    f_10153_2844_2874()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10153, 2844, 2874);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10153, 2790, 2879);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10153, 2790, 2879);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsCallerLineNumber
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10153, 2935, 2980);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10153, 2941, 2978);

                    throw f_10153_2947_2977();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10153, 2935, 2980);

                    System.Exception
                    f_10153_2947_2977()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10153, 2947, 2977);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10153, 2891, 2982);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10153, 2891, 2982);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsCallerMemberName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10153, 3038, 3083);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10153, 3044, 3081);

                    throw f_10153_3050_3080();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10153, 3038, 3083);

                    System.Exception
                    f_10153_3050_3080()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10153, 3050, 3080);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10153, 2994, 3085);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10153, 2994, 3085);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override FlowAnalysisAnnotations FlowAnalysisAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10153, 3165, 3210);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10153, 3171, 3208);

                    throw f_10153_3177_3207();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10153, 3165, 3210);

                    System.Exception
                    f_10153_3177_3207()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10153, 3177, 3207);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10153, 3097, 3212);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10153, 3097, 3212);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ImmutableHashSet<string> NotNullIfParameterNotNull
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10153, 3295, 3340);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10153, 3301, 3338);

                    throw f_10153_3307_3337();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10153, 3295, 3340);

                    System.Exception
                    f_10153_3307_3337()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10153, 3307, 3337);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10153, 3224, 3342);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10153, 3224, 3342);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Symbol ContainingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10153, 3396, 3441);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10153, 3402, 3439);

                    throw f_10153_3408_3438();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10153, 3396, 3441);

                    System.Exception
                    f_10153_3408_3438()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10153, 3408, 3438);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10153, 3354, 3443);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10153, 3354, 3443);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<Location> Locations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10153, 3508, 3553);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10153, 3514, 3551);

                    throw f_10153_3520_3550();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10153, 3508, 3553);

                    System.Exception
                    f_10153_3520_3550()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10153, 3520, 3550);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10153, 3455, 3555);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10153, 3455, 3555);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<SyntaxReference> DeclaringSyntaxReferences
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10153, 3643, 3688);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10153, 3649, 3686);

                    throw f_10153_3655_3685();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10153, 3643, 3688);

                    System.Exception
                    f_10153_3655_3685()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10153, 3655, 3685);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10153, 3567, 3690);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10153, 3567, 3690);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override AssemblySymbol ContainingAssembly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10153, 3754, 3799);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10153, 3760, 3797);

                    throw f_10153_3766_3796();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10153, 3754, 3799);

                    System.Exception
                    f_10153_3766_3796()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10153, 3766, 3796);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10153, 3702, 3801);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10153, 3702, 3801);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ModuleSymbol ContainingModule
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10153, 3863, 3908);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10153, 3869, 3906);

                    throw f_10153_3875_3905();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10153, 3863, 3908);

                    System.Exception
                    f_10153_3875_3905()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10153, 3875, 3905);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10153, 3813, 3910);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10153, 3813, 3910);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool Equals(Symbol obj, TypeCompareKind compareKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10153, 3980, 4611);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10153, 4073, 4157) || true) && ((object)this == obj)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10153, 4073, 4157);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10153, 4130, 4142);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10153, 4073, 4157);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10153, 4173, 4221);

                var
                other = obj as SignatureOnlyParameterSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10153, 4235, 4600);

                return (object)other != null && (DynAbs.Tracing.TraceSender.Expression_True(10153, 4242, 4344) && f_10153_4284_4344(_type.Type, other._type.Type, compareKind)) && (DynAbs.Tracing.TraceSender.Expression_True(10153, 4242, 4422) && _type.CustomModifiers.Equals(other._type.CustomModifiers)) && (DynAbs.Tracing.TraceSender.Expression_True(10153, 4242, 4503) && _refCustomModifiers.SequenceEqual(other._refCustomModifiers)) && (DynAbs.Tracing.TraceSender.Expression_True(10153, 4242, 4552) && _isParams == other._isParams) && (DynAbs.Tracing.TraceSender.Expression_True(10153, 4242, 4599) && _refKind == other._refKind);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10153, 3980, 4611);

                bool
                f_10153_4284_4344(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10153, 4284, 4344);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10153, 3980, 4611);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10153, 3980, 4611);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10153, 4623, 4987);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10153, 4681, 4976);

                return f_10153_4688_4975(f_10153_4719_4743(_type.Type), f_10153_4762_4974(f_10153_4797_4838(_type.CustomModifiers), f_10153_4861_4973(f_10153_4900_4923(_isParams), f_10153_4950_4972(_refKind))));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10153, 4623, 4987);

                int
                f_10153_4719_4743(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10153, 4719, 4743);
                    return return_v;
                }


                int
                f_10153_4797_4838(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                values)
                {
                    var return_v = Hash.CombineValues(values);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10153, 4797, 4838);
                    return return_v;
                }


                int
                f_10153_4900_4923(bool
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10153, 4900, 4923);
                    return return_v;
                }


                int
                f_10153_4950_4972(Microsoft.CodeAnalysis.RefKind
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10153, 4950, 4972);
                    return return_v;
                }


                int
                f_10153_4861_4973(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10153, 4861, 4973);
                    return return_v;
                }


                int
                f_10153_4762_4974(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10153, 4762, 4974);
                    return return_v;
                }


                int
                f_10153_4688_4975(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10153, 4688, 4975);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10153, 4623, 4987);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10153, 4623, 4987);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SignatureOnlyParameterSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10153, 524, 4994);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10153, 524, 4994);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10153, 524, 4994);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10153, 524, 4994);

        int
        f_10153_1050_1089(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10153, 1050, 1089);
            return 0;
        }


        bool
        f_10153_1117_1146_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10153, 1117, 1146);
            return return_v;
        }


        int
        f_10153_1104_1147(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10153, 1104, 1147);
            return 0;
        }

    }
}
