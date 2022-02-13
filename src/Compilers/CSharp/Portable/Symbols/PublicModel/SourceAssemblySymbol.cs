// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Diagnostics;

namespace Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel
{
    internal sealed class SourceAssemblySymbol : AssemblySymbol, ISourceAssemblySymbol
    {
        private readonly Symbols.SourceAssemblySymbol _underlying;

        public SourceAssemblySymbol(Symbols.SourceAssemblySymbol underlying)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10657, 495, 673);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10657, 471, 482);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10657, 588, 623);

                f_10657_588_622(underlying is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10657, 637, 662);

                _underlying = underlying;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10657, 495, 673);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10657, 495, 673);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10657, 495, 673);
            }
        }

        internal override Symbols.AssemblySymbol UnderlyingAssemblySymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10657, 751, 765);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10657, 754, 765);
                    return _underlying; DynAbs.Tracing.TraceSender.TraceExitMethod(10657, 751, 765);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10657, 751, 765);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10657, 751, 765);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10657, 825, 839);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10657, 828, 839);
                    return _underlying; DynAbs.Tracing.TraceSender.TraceExitMethod(10657, 825, 839);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10657, 825, 839);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10657, 825, 839);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Compilation ISourceAssemblySymbol.Compilation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10657, 898, 933);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10657, 901, 933);
                    return f_10657_901_933(_underlying); DynAbs.Tracing.TraceSender.TraceExitMethod(10657, 898, 933);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10657, 898, 933);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10657, 898, 933);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static SourceAssemblySymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10657, 326, 941);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10657, 326, 941);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10657, 326, 941);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10657, 326, 941);

        int
        f_10657_588_622(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10657, 588, 622);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_10657_901_933(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
        this_param)
        {
            var return_v = this_param.DeclaringCompilation;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10657, 901, 933);
            return return_v;
        }

    }
}
