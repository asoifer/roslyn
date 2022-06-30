// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Reflection;
using System.Runtime.InteropServices;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    public sealed class DllImportData : Cci.IPlatformInvokeInformation
    {
        private readonly string? _moduleName;

        private readonly string? _entryPointName;

        private readonly MethodImportAttributes _flags;

        internal DllImportData(string? moduleName, string? entryPointName, MethodImportAttributes flags)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(639, 796, 1029);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(639, 584, 595);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(639, 631, 646);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(639, 777, 783);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(639, 917, 942);

                _moduleName = moduleName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(639, 956, 989);

                _entryPointName = entryPointName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(639, 1003, 1018);

                _flags = flags;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(639, 796, 1029);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(639, 796, 1029);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(639, 796, 1029);
            }
        }

        public string? ModuleName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(639, 1219, 1246);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(639, 1225, 1244);

                    return _moduleName;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(639, 1219, 1246);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(639, 1169, 1257);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(639, 1169, 1257);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public string? EntryPointName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(639, 1506, 1537);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(639, 1512, 1535);

                    return _entryPointName;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(639, 1506, 1537);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(639, 1452, 1548);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(639, 1452, 1548);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        MethodImportAttributes Cci.IPlatformInvokeInformation.Flags
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(639, 1644, 1666);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(639, 1650, 1664);

                    return _flags;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(639, 1644, 1666);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(639, 1560, 1677);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(639, 1560, 1677);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool ExactSpelling
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(639, 1981, 2092);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(639, 2017, 2077);

                    return (_flags & MethodImportAttributes.ExactSpelling) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(639, 1981, 2092);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(639, 1931, 2103);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(639, 1931, 2103);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public CharSet CharacterSet
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(639, 2298, 2947);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(639, 2334, 2863);

                    switch (_flags & MethodImportAttributes.CharSetMask)
                    {

                        case MethodImportAttributes.CharSetAnsi:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(639, 2334, 2863);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(639, 2493, 2513);

                            return CharSet.Ansi;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(639, 2334, 2863);

                        case MethodImportAttributes.CharSetUnicode:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(639, 2334, 2863);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(639, 2606, 2629);

                            return CharSet.Unicode;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(639, 2334, 2863);

                        case MethodImportAttributes.CharSetAuto:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(639, 2334, 2863);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(639, 2719, 2753);

                            return Cci.Constants.CharSet_Auto;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(639, 2334, 2863);

                        case 0:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(639, 2334, 2863);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(639, 2810, 2844);

                            return Cci.Constants.CharSet_None;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(639, 2334, 2863);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(639, 2883, 2932);

                    throw f_639_2889_2931(_flags);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(639, 2298, 2947);

                    System.Exception
                    f_639_2889_2931(System.Reflection.MethodImportAttributes
                    o)
                    {
                        var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(639, 2889, 2931);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(639, 2246, 2958);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(639, 2246, 2958);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool SetLastError
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(639, 3195, 3305);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(639, 3231, 3290);

                    return (_flags & MethodImportAttributes.SetLastError) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(639, 3195, 3305);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(639, 3146, 3316);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(639, 3146, 3316);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public CallingConvention CallingConvention
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(639, 3507, 4304);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(639, 3543, 4289);

                    switch (_flags & MethodImportAttributes.CallingConventionMask)
                    {

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(639, 3543, 4289);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(639, 3680, 3712);

                            return CallingConvention.Winapi;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(639, 3543, 4289);

                        case MethodImportAttributes.CallingConventionCDecl:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(639, 3543, 4289);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(639, 3813, 3844);

                            return CallingConvention.Cdecl;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(639, 3543, 4289);

                        case MethodImportAttributes.CallingConventionStdCall:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(639, 3543, 4289);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(639, 3947, 3980);

                            return CallingConvention.StdCall;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(639, 3543, 4289);

                        case MethodImportAttributes.CallingConventionThisCall:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(639, 3543, 4289);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(639, 4084, 4118);

                            return CallingConvention.ThisCall;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(639, 3543, 4289);

                        case MethodImportAttributes.CallingConventionFastCall:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(639, 3543, 4289);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(639, 4222, 4270);

                            return Cci.Constants.CallingConvention_FastCall;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(639, 3543, 4289);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(639, 3507, 4304);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(639, 3440, 4315);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(639, 3440, 4315);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool? BestFitMapping
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(639, 4680, 5120);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(639, 4716, 5105);

                    switch (_flags & MethodImportAttributes.BestFitMappingMask)
                    {

                        case MethodImportAttributes.BestFitMappingEnable:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(639, 4716, 5105);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(639, 4891, 4903);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(639, 4716, 5105);

                        case MethodImportAttributes.BestFitMappingDisable:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(639, 4716, 5105);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(639, 5003, 5016);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(639, 4716, 5105);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(639, 4716, 5105);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(639, 5074, 5086);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(639, 4716, 5105);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(639, 4680, 5120);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(639, 4628, 5131);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(639, 4628, 5131);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool? ThrowOnUnmappableCharacter
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(639, 5431, 5892);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(639, 5467, 5877);

                    switch (_flags & MethodImportAttributes.ThrowOnUnmappableCharMask)
                    {

                        case MethodImportAttributes.ThrowOnUnmappableCharEnable:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(639, 5467, 5877);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(639, 5656, 5668);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(639, 5467, 5877);

                        case MethodImportAttributes.ThrowOnUnmappableCharDisable:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(639, 5467, 5877);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(639, 5775, 5788);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(639, 5467, 5877);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(639, 5467, 5877);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(639, 5846, 5858);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(639, 5467, 5877);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(639, 5431, 5892);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(639, 5367, 5903);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(639, 5367, 5903);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static MethodImportAttributes MakeFlags(bool exactSpelling, CharSet charSet, bool setLastError, CallingConvention callingConvention, bool? useBestFit, bool? throwOnUnmappable)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(639, 5915, 8657);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(639, 6124, 6158);

                MethodImportAttributes
                result = 0
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(639, 6172, 6285) || true) && (exactSpelling)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(639, 6172, 6285);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(639, 6223, 6270);

                    result |= MethodImportAttributes.ExactSpelling;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(639, 6172, 6285);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(639, 6301, 6836);

                switch (charSet)
                {

                    case CharSet.Ansi:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(639, 6301, 6836);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(639, 6390, 6435);

                        result |= MethodImportAttributes.CharSetAnsi;
                        DynAbs.Tracing.TraceSender.TraceBreak(639, 6457, 6463);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(639, 6301, 6836);

                    case CharSet.Unicode:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(639, 6301, 6836);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(639, 6526, 6574);

                        result |= MethodImportAttributes.CharSetUnicode;
                        DynAbs.Tracing.TraceSender.TraceBreak(639, 6596, 6602);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(639, 6301, 6836);

                    case Cci.Constants.CharSet_Auto:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(639, 6301, 6836);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(639, 6676, 6721);

                        result |= MethodImportAttributes.CharSetAuto;
                        DynAbs.Tracing.TraceSender.TraceBreak(639, 6743, 6749);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(639, 6301, 6836);

                        // Dev10: use default without reporting an error
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(639, 6852, 6963) || true) && (setLastError)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(639, 6852, 6963);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(639, 6902, 6948);

                    result |= MethodImportAttributes.SetLastError;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(639, 6852, 6963);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(639, 6979, 7868);

                switch (callingConvention)
                {

                    default: // Dev10: uses default without reporting an error
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(639, 6979, 7868);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(639, 7118, 7175);

                        result |= MethodImportAttributes.CallingConventionWinApi;
                        DynAbs.Tracing.TraceSender.TraceBreak(639, 7197, 7203);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(639, 6979, 7868);

                    case CallingConvention.Cdecl:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(639, 6979, 7868);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(639, 7274, 7330);

                        result |= MethodImportAttributes.CallingConventionCDecl;
                        DynAbs.Tracing.TraceSender.TraceBreak(639, 7352, 7358);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(639, 6979, 7868);

                    case CallingConvention.StdCall:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(639, 6979, 7868);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(639, 7431, 7489);

                        result |= MethodImportAttributes.CallingConventionStdCall;
                        DynAbs.Tracing.TraceSender.TraceBreak(639, 7511, 7517);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(639, 6979, 7868);

                    case CallingConvention.ThisCall:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(639, 6979, 7868);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(639, 7591, 7650);

                        result |= MethodImportAttributes.CallingConventionThisCall;
                        DynAbs.Tracing.TraceSender.TraceBreak(639, 7672, 7678);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(639, 6979, 7868);

                    case Cci.Constants.CallingConvention_FastCall:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(639, 6979, 7868);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(639, 7766, 7825);

                        result |= MethodImportAttributes.CallingConventionFastCall;
                        DynAbs.Tracing.TraceSender.TraceBreak(639, 7847, 7853);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(639, 6979, 7868);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(639, 7884, 8256) || true) && (f_639_7888_7914(throwOnUnmappable))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(639, 7884, 8256);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(639, 7948, 8241) || true) && (f_639_7952_7975(throwOnUnmappable))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(639, 7948, 8241);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(639, 8017, 8078);

                        result |= MethodImportAttributes.ThrowOnUnmappableCharEnable;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(639, 7948, 8241);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(639, 7948, 8241);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(639, 8160, 8222);

                        result |= MethodImportAttributes.ThrowOnUnmappableCharDisable;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(639, 7948, 8241);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(639, 7884, 8256);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(639, 8272, 8616) || true) && (f_639_8276_8295(useBestFit))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(639, 8272, 8616);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(639, 8329, 8601) || true) && (f_639_8333_8349(useBestFit))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(639, 8329, 8601);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(639, 8391, 8445);

                        result |= MethodImportAttributes.BestFitMappingEnable;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(639, 8329, 8601);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(639, 8329, 8601);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(639, 8527, 8582);

                        result |= MethodImportAttributes.BestFitMappingDisable;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(639, 8329, 8601);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(639, 8272, 8616);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(639, 8632, 8646);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(639, 5915, 8657);

                bool
                f_639_7888_7914(bool?
                this_param)
                {
                    var return_v = this_param.HasValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(639, 7888, 7914);
                    return return_v;
                }


                bool
                f_639_7952_7975(bool?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(639, 7952, 7975);
                    return return_v;
                }


                bool
                f_639_8276_8295(bool?
                this_param)
                {
                    var return_v = this_param.HasValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(639, 8276, 8295);
                    return return_v;
                }


                bool
                f_639_8333_8349(bool?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(639, 8333, 8349);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(639, 5915, 8657);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(639, 5915, 8657);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static DllImportData()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(639, 476, 8664);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(639, 476, 8664);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(639, 476, 8664);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(639, 476, 8664);
    }
}
