// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Diagnostics;

namespace Microsoft.CodeAnalysis.CSharp
{

    internal readonly struct CallingConventionInfo
    {

        internal readonly Cci.CallingConvention CallKind;

        internal readonly ImmutableHashSet<CustomModifier>? UnmanagedCallingConventionTypes;

        public CallingConventionInfo(Cci.CallingConvention callKind, ImmutableHashSet<CustomModifier> unmanagedCallingConventionTypes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10868, 540, 917);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10868, 691, 792);

                f_10868_691_791(f_10868_704_743(unmanagedCallingConventionTypes) || (DynAbs.Tracing.TraceSender.Expression_False(10868, 704, 790) || callKind == Cci.CallingConvention.Unmanaged));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10868, 806, 826);

                CallKind = callKind;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10868, 840, 906);

                UnmanagedCallingConventionTypes = unmanagedCallingConventionTypes;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10868, 540, 917);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10868, 540, 917);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10868, 540, 917);
            }
        }
        static CallingConventionInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10868, 322, 924);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10868, 322, 924);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10868, 322, 924);
        }

        static bool
        f_10868_704_743(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CustomModifier>
        this_param)
        {
            var return_v = this_param.IsEmpty;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10868, 704, 743);
            return return_v;
        }


        static int
        f_10868_691_791(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10868, 691, 791);
            return 0;
        }

    }
}
