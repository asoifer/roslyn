// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class NameofBinder : Binder
    {
        private readonly SyntaxNode _nameofArgument;

        public NameofBinder(SyntaxNode nameofArgument, Binder next) : base(f_10360_460_464_C(next))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10360, 393, 534);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10360, 365, 380);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10360, 490, 523);

                _nameofArgument = nameofArgument;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10360, 393, 534);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10360, 393, 534);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10360, 393, 534);
            }
        }

        protected override SyntaxNode EnclosingNameofArgument
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10360, 600, 618);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10360, 603, 618);
                    return _nameofArgument; DynAbs.Tracing.TraceSender.TraceExitMethod(10360, 600, 618);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10360, 600, 618);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10360, 600, 618);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static NameofBinder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10360, 277, 626);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10360, 277, 626);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10360, 277, 626);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10360, 277, 626);

        static Microsoft.CodeAnalysis.CSharp.Binder
        f_10360_460_464_C(Microsoft.CodeAnalysis.CSharp.Binder
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10360, 393, 534);
            return return_v;
        }

    }
}
