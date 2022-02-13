// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Diagnostics;

namespace Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel
{
    internal sealed class NonSourceAssemblySymbol : AssemblySymbol
    {
        private readonly Symbols.AssemblySymbol _underlying;

        public NonSourceAssemblySymbol(Symbols.AssemblySymbol underlying)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10651, 469, 718);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10651, 445, 456);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10651, 559, 594);

                f_10651_559_593(underlying is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10651, 608, 668);

                f_10651_608_667(!(underlying is Symbols.SourceAssemblySymbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10651, 682, 707);

                _underlying = underlying;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10651, 469, 718);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10651, 469, 718);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10651, 469, 718);
            }
        }

        internal override Symbols.AssemblySymbol UnderlyingAssemblySymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10651, 796, 810);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10651, 799, 810);
                    return _underlying; DynAbs.Tracing.TraceSender.TraceExitMethod(10651, 796, 810);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10651, 796, 810);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10651, 796, 810);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override CSharp.Symbol UnderlyingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10651, 870, 884);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10651, 873, 884);
                    return _underlying; DynAbs.Tracing.TraceSender.TraceExitMethod(10651, 870, 884);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10651, 870, 884);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10651, 870, 884);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static NonSourceAssemblySymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10651, 326, 892);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10651, 326, 892);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10651, 326, 892);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10651, 326, 892);

        int
        f_10651_559_593(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10651, 559, 593);
            return 0;
        }


        int
        f_10651_608_667(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10651, 608, 667);
            return 0;
        }

    }
}
