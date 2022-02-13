// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.CodeAnalysis.CSharp
{

    [SuppressMessage("Performance", "CA1067", Justification = "Equality not actually implemented")]
    internal struct MemberResolutionResult<TMember> where TMember : Symbol
    {

        private readonly TMember _member;

        private readonly TMember _leastOverriddenMember;

        private readonly MemberAnalysisResult _result;

        internal MemberResolutionResult(TMember member, TMember leastOverriddenMember, MemberAnalysisResult result)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10871, 796, 1048);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10871, 928, 945);

                _member = member;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10871, 959, 1006);

                _leastOverriddenMember = leastOverriddenMember;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10871, 1020, 1037);

                _result = result;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10871, 796, 1048);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10871, 796, 1048);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10871, 796, 1048);
            }
        }

        internal bool IsNull
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10871, 1105, 1144);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10871, 1111, 1142);

                    return (object)_member == null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10871, 1105, 1144);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10871, 1060, 1155);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10871, 1060, 1155);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool IsNotNull
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10871, 1215, 1254);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10871, 1221, 1252);

                    return (object)_member != null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10871, 1215, 1254);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10871, 1167, 1265);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10871, 1167, 1265);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public TMember Member
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10871, 1433, 1456);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10871, 1439, 1454);

                    return _member;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10871, 1433, 1456);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10871, 1387, 1467);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10871, 1387, 1467);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal TMember LeastOverriddenMember
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10871, 1938, 1976);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10871, 1944, 1974);

                    return _leastOverriddenMember;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10871, 1938, 1976);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10871, 1875, 1987);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10871, 1875, 1987);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public MemberResolutionKind Resolution
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10871, 2209, 2279);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10871, 2245, 2264);

                    return Result.Kind;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10871, 2209, 2279);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10871, 2146, 2290);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10871, 2146, 2290);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsValid
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10871, 2507, 2580);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10871, 2543, 2565);

                    return Result.IsValid;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10871, 2507, 2580);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10871, 2463, 2591);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10871, 2463, 2591);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsApplicable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10871, 2652, 2730);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10871, 2688, 2715);

                    return Result.IsApplicable;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10871, 2652, 2730);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10871, 2603, 2741);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10871, 2603, 2741);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal MemberResolutionResult<TMember> Worse()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10871, 2753, 2941);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10871, 2826, 2930);

                return f_10871_2833_2929(Member, LeastOverriddenMember, MemberAnalysisResult.Worse());
                DynAbs.Tracing.TraceSender.TraceExitMethod(10871, 2753, 2941);

                Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                f_10871_2833_2929(TMember
                member, TMember
                leastOverriddenMember, Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult
                result)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>(member, leastOverriddenMember, result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10871, 2833, 2929);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10871, 2753, 2941);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10871, 2753, 2941);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal MemberResolutionResult<TMember> Worst()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10871, 2953, 3141);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10871, 3026, 3130);

                return f_10871_3033_3129(Member, LeastOverriddenMember, MemberAnalysisResult.Worst());
                DynAbs.Tracing.TraceSender.TraceExitMethod(10871, 2953, 3141);

                Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                f_10871_3033_3129(TMember
                member, TMember
                leastOverriddenMember, Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult
                result)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>(member, leastOverriddenMember, result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10871, 3033, 3129);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10871, 2953, 3141);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10871, 2953, 3141);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool HasUseSiteDiagnosticToReport
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10871, 3220, 3327);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10871, 3256, 3312);

                    return _result.HasUseSiteDiagnosticToReportFor(_member);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10871, 3220, 3327);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10871, 3153, 3338);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10871, 3153, 3338);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal MemberAnalysisResult Result
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10871, 3502, 3525);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10871, 3508, 3523);

                    return _result;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10871, 3502, 3525);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10871, 3441, 3536);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10871, 3441, 3536);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool Equals(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10871, 3548, 3657);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10871, 3612, 3646);

                throw f_10871_3618_3645();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10871, 3548, 3657);

                System.NotSupportedException
                f_10871_3618_3645()
                {
                    var return_v = new System.NotSupportedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10871, 3618, 3645);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10871, 3548, 3657);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10871, 3548, 3657);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10871, 3669, 3772);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10871, 3727, 3761);

                throw f_10871_3733_3760();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10871, 3669, 3772);

                System.NotSupportedException
                f_10871_3733_3760()
                {
                    var return_v = new System.NotSupportedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10871, 3733, 3760);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10871, 3669, 3772);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10871, 3669, 3772);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static MemberResolutionResult()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10871, 449, 3779);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10871, 449, 3779);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10871, 449, 3779);
        }
    }
}
