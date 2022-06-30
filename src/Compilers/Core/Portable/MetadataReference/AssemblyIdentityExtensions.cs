// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Reflection;

namespace Microsoft.CodeAnalysis
{
    internal static class AssemblyIdentityExtensions
    {
        internal static bool IsWindowsComponent(this AssemblyIdentity identity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(423, 408, 676);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(423, 504, 665);

                return (f_423_512_532(identity) == AssemblyContentType.WindowsRuntime) && (DynAbs.Tracing.TraceSender.Expression_True(423, 511, 664) && f_423_592_664(f_423_592_605(identity), "windows.", StringComparison.OrdinalIgnoreCase));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(423, 408, 676);

                System.Reflection.AssemblyContentType
                f_423_512_532(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.ContentType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(423, 512, 532);
                    return return_v;
                }


                string
                f_423_592_605(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(423, 592, 605);
                    return return_v;
                }


                bool
                f_423_592_664(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(423, 592, 664);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(423, 408, 676);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(423, 408, 676);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsWindowsRuntime(this AssemblyIdentity identity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(423, 716, 985);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(423, 810, 974);

                return (f_423_818_838(identity) == AssemblyContentType.WindowsRuntime) && (DynAbs.Tracing.TraceSender.Expression_True(423, 817, 973) && f_423_898_973(f_423_912_925(identity), "windows", StringComparison.OrdinalIgnoreCase));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(423, 716, 985);

                System.Reflection.AssemblyContentType
                f_423_818_838(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.ContentType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(423, 818, 838);
                    return return_v;
                }


                string
                f_423_912_925(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(423, 912, 925);
                    return return_v;
                }


                bool
                f_423_898_973(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(423, 898, 973);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(423, 716, 985);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(423, 716, 985);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static AssemblyIdentityExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(423, 313, 992);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(423, 313, 992);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(423, 313, 992);
        }

    }
}
