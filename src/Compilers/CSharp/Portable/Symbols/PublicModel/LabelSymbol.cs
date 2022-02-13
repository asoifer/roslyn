// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel
{
    internal sealed class LabelSymbol : Symbol, ILabelSymbol
    {
        private readonly Symbols.LabelSymbol _underlying;

        public LabelSymbol(Symbols.LabelSymbol underlying)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10643, 437, 603);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10643, 413, 424);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10643, 512, 553);

                f_10643_512_552(underlying is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10643, 567, 592);

                _underlying = underlying;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10643, 437, 603);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10643, 437, 603);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10643, 437, 603);
            }
        }

        internal override CSharp.Symbol UnderlyingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10643, 664, 678);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10643, 667, 678);
                    return _underlying; DynAbs.Tracing.TraceSender.TraceExitMethod(10643, 664, 678);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10643, 664, 678);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10643, 664, 678);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        IMethodSymbol ILabelSymbol.ContainingMethod
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10643, 759, 864);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10643, 795, 849);

                    return f_10643_802_848(f_10643_802_830(_underlying));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10643, 759, 864);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10643_802_830(Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10643, 802, 830);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.IMethodSymbol?
                    f_10643_802_848(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    symbol)
                    {
                        var return_v = symbol.GetPublicSymbol();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10643, 802, 848);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10643, 691, 875);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10643, 691, 875);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override void Accept(SymbolVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10643, 922, 1036);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10643, 1000, 1025);

                f_10643_1000_1024(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10643, 922, 1036);

                int
                f_10643_1000_1024(Microsoft.CodeAnalysis.SymbolVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.LabelSymbol
                symbol)
                {
                    this_param.VisitLabel((Microsoft.CodeAnalysis.ILabelSymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10643, 1000, 1024);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10643, 922, 1036);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10643, 922, 1036);
            }
        }

        protected override TResult? Accept<TResult>(SymbolVisitor<TResult> visitor)
                    where TResult : default
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10643, 1048, 1228);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10643, 1185, 1217);

                return f_10643_1192_1216<TResult>(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10643, 1048, 1228);

                TResult?
                f_10643_1192_1216<TResult>(Microsoft.CodeAnalysis.SymbolVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.LabelSymbol
                symbol)

                {
                    var return_v = this_param.VisitLabel((Microsoft.CodeAnalysis.ILabelSymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10643, 1192, 1216);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10643, 1048, 1228);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10643, 1048, 1228);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static LabelSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10643, 303, 1257);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10643, 303, 1257);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10643, 303, 1257);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10643, 303, 1257);

        int
        f_10643_512_552(bool
        b)
        {
            RoslynDebug.Assert(b);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10643, 512, 552);
            return 0;
        }

    }
}
