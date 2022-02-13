// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel
{
    internal sealed class FunctionPointerTypeSymbol : TypeSymbol, IFunctionPointerTypeSymbol
    {
        private readonly Symbols.FunctionPointerTypeSymbol _underlying;

        public FunctionPointerTypeSymbol(Symbols.FunctionPointerTypeSymbol underlying, CodeAnalysis.NullableAnnotation nullableAnnotation)
        : base(f_10642_661_679_C(nullableAnnotation))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10642, 510, 796);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10642, 486, 497);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10642, 705, 746);

                f_10642_705_745(underlying is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10642, 760, 785);

                _underlying = underlying;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10642, 510, 796);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10642, 510, 796);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10642, 510, 796);
            }
        }

        public IMethodSymbol Signature
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10642, 839, 881);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10642, 842, 881);
                    return f_10642_842_881(f_10642_842_863(_underlying)); DynAbs.Tracing.TraceSender.TraceExitMethod(10642, 839, 881);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10642, 839, 881);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10642, 839, 881);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override Symbols.TypeSymbol UnderlyingTypeSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10642, 950, 964);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10642, 953, 964);
                    return _underlying; DynAbs.Tracing.TraceSender.TraceExitMethod(10642, 950, 964);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10642, 950, 964);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10642, 950, 964);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override Symbols.NamespaceOrTypeSymbol UnderlyingNamespaceOrTypeSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10642, 1055, 1069);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10642, 1058, 1069);
                    return _underlying; DynAbs.Tracing.TraceSender.TraceExitMethod(10642, 1055, 1069);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10642, 1055, 1069);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10642, 1055, 1069);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10642, 1129, 1143);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10642, 1132, 1143);
                    return _underlying; DynAbs.Tracing.TraceSender.TraceExitMethod(10642, 1129, 1143);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10642, 1129, 1143);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10642, 1129, 1143);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override void Accept(SymbolVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10642, 1223, 1264);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10642, 1226, 1264);
                f_10642_1226_1264(visitor, this); DynAbs.Tracing.TraceSender.TraceExitMethod(10642, 1223, 1264);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10642, 1223, 1264);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10642, 1223, 1264);
            }

            int
            f_10642_1226_1264(Microsoft.CodeAnalysis.SymbolVisitor
            this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.FunctionPointerTypeSymbol
            symbol)
            {
                this_param.VisitFunctionPointerType((Microsoft.CodeAnalysis.IFunctionPointerTypeSymbol)symbol);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10642, 1226, 1264);
                return 0;
            }

        }

        protected override TResult? Accept<TResult>(SymbolVisitor<TResult> visitor)
                    where TResult : default
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10642, 1277, 1471);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10642, 1414, 1460);

                return f_10642_1421_1459<TResult>(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10642, 1277, 1471);

                TResult?
                f_10642_1421_1459<TResult>(Microsoft.CodeAnalysis.SymbolVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.FunctionPointerTypeSymbol
                symbol)

                {
                    var return_v = this_param.VisitFunctionPointerType((Microsoft.CodeAnalysis.IFunctionPointerTypeSymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10642, 1421, 1459);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10642, 1277, 1471);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10642, 1277, 1471);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override ITypeSymbol WithNullableAnnotation(CodeAnalysis.NullableAnnotation nullableAnnotation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10642, 1483, 1856);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10642, 1613, 1673);

                f_10642_1613_1672(nullableAnnotation != f_10642_1648_1671(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10642, 1687, 1761);

                f_10642_1687_1760(nullableAnnotation != f_10642_1722_1759(_underlying));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10642, 1775, 1845);

                return f_10642_1782_1844(_underlying, nullableAnnotation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10642, 1483, 1856);

                Microsoft.CodeAnalysis.NullableAnnotation
                f_10642_1648_1671(Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.FunctionPointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.NullableAnnotation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10642, 1648, 1671);
                    return return_v;
                }


                int
                f_10642_1613_1672(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10642, 1613, 1672);
                    return 0;
                }


                Microsoft.CodeAnalysis.NullableAnnotation
                f_10642_1722_1759(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.DefaultNullableAnnotation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10642, 1722, 1759);
                    return return_v;
                }


                int
                f_10642_1687_1760(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10642, 1687, 1760);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.FunctionPointerTypeSymbol
                f_10642_1782_1844(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                underlying, Microsoft.CodeAnalysis.NullableAnnotation
                nullableAnnotation)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.FunctionPointerTypeSymbol(underlying, nullableAnnotation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10642, 1782, 1844);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10642, 1483, 1856);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10642, 1483, 1856);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static FunctionPointerTypeSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10642, 330, 1863);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10642, 330, 1863);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10642, 330, 1863);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10642, 330, 1863);

        int
        f_10642_705_745(bool
        b)
        {
            RoslynDebug.Assert(b);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10642, 705, 745);
            return 0;
        }


        static Microsoft.CodeAnalysis.NullableAnnotation
        f_10642_661_679_C(Microsoft.CodeAnalysis.NullableAnnotation
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10642, 510, 796);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
        f_10642_842_863(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
        this_param)
        {
            var return_v = this_param.Signature;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10642, 842, 863);
            return return_v;
        }


        Microsoft.CodeAnalysis.IMethodSymbol?
        f_10642_842_881(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
        symbol)
        {
            var return_v = symbol.GetPublicSymbol();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10642, 842, 881);
            return return_v;
        }

    }
}
