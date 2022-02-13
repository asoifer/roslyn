// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal abstract class LoopBinder : LocalScopeBinder
    {
        private readonly GeneratedLabelSymbol _breakLabel;

        private readonly GeneratedLabelSymbol _continueLabel;

        protected LoopBinder(Binder enclosing)
        : base(f_10357_660_669_C(enclosing))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10357, 601, 822);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10357, 514, 525);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10357, 574, 588);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10357, 695, 743);

                _breakLabel = f_10357_709_742("break");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10357, 757, 811);

                _continueLabel = f_10357_774_810("continue");
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10357, 601, 822);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10357, 601, 822);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10357, 601, 822);
            }
        }

        internal override GeneratedLabelSymbol BreakLabel
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10357, 908, 978);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10357, 944, 963);

                    return _breakLabel;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10357, 908, 978);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10357, 834, 989);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10357, 834, 989);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override GeneratedLabelSymbol ContinueLabel
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10357, 1078, 1151);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10357, 1114, 1136);

                    return _continueLabel;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10357, 1078, 1151);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10357, 1001, 1162);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10357, 1001, 1162);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static LoopBinder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10357, 406, 1169);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10357, 406, 1169);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10357, 406, 1169);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10357, 406, 1169);

        Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
        f_10357_709_742(string
        name)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol(name);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10357, 709, 742);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
        f_10357_774_810(string
        name)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol(name);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10357, 774, 810);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Binder
        f_10357_660_669_C(Microsoft.CodeAnalysis.CSharp.Binder
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10357, 601, 822);
            return return_v;
        }

    }
}
