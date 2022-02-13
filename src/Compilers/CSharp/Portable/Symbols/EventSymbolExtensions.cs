// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal static class EventSymbolExtensions
    {
        internal static MethodSymbol GetOwnOrInheritedAccessor(this EventSymbol @event, bool isAdder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10108, 474, 731);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10108, 592, 720);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10108, 599, 606) || ((isAdder
                && DynAbs.Tracing.TraceSender.Conditional_F2(10108, 626, 661)) || DynAbs.Tracing.TraceSender.Conditional_F3(10108, 681, 719))) ? f_10108_626_661(@event) : f_10108_681_719(@event);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10108, 474, 731);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10108_626_661(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                @event)
                {
                    var return_v = @event.GetOwnOrInheritedAddMethod();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10108, 626, 661);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10108_681_719(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                @event)
                {
                    var return_v = @event.GetOwnOrInheritedRemoveMethod();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10108, 681, 719);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10108, 474, 731);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10108, 474, 731);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static EventSymbolExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10108, 414, 738);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10108, 414, 738);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10108, 414, 738);
        }

    }
}
