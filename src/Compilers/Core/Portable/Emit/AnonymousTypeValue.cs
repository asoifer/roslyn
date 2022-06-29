// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.Cci;
using System.Diagnostics;

namespace Microsoft.CodeAnalysis.Emit
{

    [DebuggerDisplay("{Name, nq}")]
    internal struct AnonymousTypeValue
    {

        public readonly string Name;

        public readonly int UniqueIndex;

        public readonly ITypeDefinition Type;

        public AnonymousTypeValue(string name, int uniqueIndex, ITypeDefinition type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(284, 543, 852);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(284, 645, 687);

                f_284_645_686(!f_284_659_685(name));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(284, 701, 732);

                f_284_701_731(uniqueIndex >= 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(284, 748, 765);

                this.Name = name;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(284, 779, 810);

                this.UniqueIndex = uniqueIndex;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(284, 824, 841);

                this.Type = type;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(284, 543, 852);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(284, 543, 852);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(284, 543, 852);
            }
        }
        static AnonymousTypeValue()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(284, 326, 859);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(284, 326, 859);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(284, 326, 859);
        }

        static bool
        f_284_659_685(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(284, 659, 685);
            return return_v;
        }


        static int
        f_284_645_686(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(284, 645, 686);
            return 0;
        }


        static int
        f_284_701_731(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(284, 701, 731);
            return 0;
        }

    }
}
