// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel
{
    internal sealed class AliasSymbol : Symbol, IAliasSymbol
    {
        private readonly Symbols.AliasSymbol _underlying;

        public AliasSymbol(Symbols.AliasSymbol underlying)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10634, 437, 603);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10634, 413, 424);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10634, 512, 553);

                f_10634_512_552(underlying is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10634, 567, 592);

                _underlying = underlying;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10634, 437, 603);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10634, 437, 603);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10634, 437, 603);
            }
        }

        internal override CSharp.Symbol UnderlyingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10634, 664, 678);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10634, 667, 678);
                    return _underlying; DynAbs.Tracing.TraceSender.TraceExitMethod(10634, 664, 678);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10634, 664, 678);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10634, 664, 678);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        INamespaceOrTypeSymbol IAliasSymbol.Target
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10634, 758, 853);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10634, 794, 838);

                    return f_10634_801_837(f_10634_801_819(_underlying));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10634, 758, 853);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                    f_10634_801_819(Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                    this_param)
                    {
                        var return_v = this_param.Target;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10634, 801, 819);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.INamespaceOrTypeSymbol?
                    f_10634_801_837(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                    symbol)
                    {
                        var return_v = symbol.GetPublicSymbol();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10634, 801, 837);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10634, 691, 864);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10634, 691, 864);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override void Accept(SymbolVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10634, 911, 1025);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10634, 989, 1014);

                f_10634_989_1013(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10634, 911, 1025);

                int
                f_10634_989_1013(Microsoft.CodeAnalysis.SymbolVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.AliasSymbol
                symbol)
                {
                    this_param.VisitAlias((Microsoft.CodeAnalysis.IAliasSymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10634, 989, 1013);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10634, 911, 1025);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10634, 911, 1025);
            }
        }

        protected override TResult? Accept<TResult>(SymbolVisitor<TResult> visitor)
                    where TResult : default
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10634, 1037, 1217);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10634, 1174, 1206);

                return f_10634_1181_1205<TResult>(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10634, 1037, 1217);

                TResult?
                f_10634_1181_1205<TResult>(Microsoft.CodeAnalysis.SymbolVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.AliasSymbol
                symbol)

                {
                    var return_v = this_param.VisitAlias((Microsoft.CodeAnalysis.IAliasSymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10634, 1181, 1205);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10634, 1037, 1217);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10634, 1037, 1217);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static AliasSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10634, 303, 1246);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10634, 303, 1246);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10634, 303, 1246);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10634, 303, 1246);

        int
        f_10634_512_552(bool
        b)
        {
            RoslynDebug.Assert(b);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10634, 512, 552);
            return 0;
        }

    }
}
