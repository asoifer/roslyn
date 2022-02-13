// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;

namespace Microsoft.CodeAnalysis.CSharp
{
    /// <summary>
    /// Information about the arguments of a call that can turned into a BoundCall later without recalculating
    /// default arguments.
    /// </summary>
    internal sealed record MethodArgumentInfo(
        MethodSymbol Method,
        ImmutableArray<BoundExpression> Arguments,
        ImmutableArray<int> ArgsToParamsOpt,
        BitVector DefaultArguments,
        bool Expanded)
    {

        public static MethodArgumentInfo CreateParameterlessMethod(MethodSymbol method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10358, 795, 1123);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10358, 899, 940);

                f_10358_899_939(f_10358_912_933(method) == 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10358, 954, 1112);

                return f_10358_961_1111(method, Arguments: ImmutableArray<BoundExpression>.Empty, ArgsToParamsOpt: default, DefaultArguments: default, Expanded: false);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10358, 795, 1123);

                int
                f_10358_912_933(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10358, 912, 933);
                    return return_v;
                }


                int
                f_10358_899_939(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10358, 899, 939);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo
                f_10358_961_1111(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                Method, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                Arguments, System.Collections.Immutable.ImmutableArray<int>
                ArgsToParamsOpt, Microsoft.CodeAnalysis.BitVector
                DefaultArguments, bool
                Expanded)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo(Method, Arguments: Arguments, ArgsToParamsOpt: ArgsToParamsOpt, DefaultArguments: DefaultArguments, Expanded: Expanded);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10358, 961, 1111);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10358, 795, 1123);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10358, 795, 1123);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
