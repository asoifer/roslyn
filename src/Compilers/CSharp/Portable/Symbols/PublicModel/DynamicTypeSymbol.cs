// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel
{
    internal sealed class DynamicTypeSymbol : TypeSymbol, IDynamicTypeSymbol
    {
        private readonly Symbols.DynamicTypeSymbol _underlying;

        public DynamicTypeSymbol(Symbols.DynamicTypeSymbol underlying, CodeAnalysis.NullableAnnotation nullableAnnotation)
        : base(f_10638_621_639_C(nullableAnnotation))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10638, 486, 756);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10638, 462, 473);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10638, 665, 706);

                f_10638_665_705(underlying is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10638, 720, 745);

                _underlying = underlying;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10638, 486, 756);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10638, 486, 756);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10638, 486, 756);
            }
        }

        protected override ITypeSymbol WithNullableAnnotation(CodeAnalysis.NullableAnnotation nullableAnnotation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10638, 768, 1133);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10638, 898, 972);

                f_10638_898_971(nullableAnnotation != f_10638_933_970(_underlying));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10638, 986, 1046);

                f_10638_986_1045(nullableAnnotation != f_10638_1021_1044(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10638, 1060, 1122);

                return f_10638_1067_1121(_underlying, nullableAnnotation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10638, 768, 1133);

                Microsoft.CodeAnalysis.NullableAnnotation
                f_10638_933_970(Microsoft.CodeAnalysis.CSharp.Symbols.DynamicTypeSymbol
                this_param)
                {
                    var return_v = this_param.DefaultNullableAnnotation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10638, 933, 970);
                    return return_v;
                }


                int
                f_10638_898_971(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10638, 898, 971);
                    return 0;
                }


                Microsoft.CodeAnalysis.NullableAnnotation
                f_10638_1021_1044(Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.DynamicTypeSymbol
                this_param)
                {
                    var return_v = this_param.NullableAnnotation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10638, 1021, 1044);
                    return return_v;
                }


                int
                f_10638_986_1045(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10638, 986, 1045);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.DynamicTypeSymbol
                f_10638_1067_1121(Microsoft.CodeAnalysis.CSharp.Symbols.DynamicTypeSymbol
                underlying, Microsoft.CodeAnalysis.NullableAnnotation
                nullableAnnotation)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.DynamicTypeSymbol(underlying, nullableAnnotation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10638, 1067, 1121);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10638, 768, 1133);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10638, 768, 1133);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override CSharp.Symbol UnderlyingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10638, 1194, 1208);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10638, 1197, 1208);
                    return _underlying; DynAbs.Tracing.TraceSender.TraceExitMethod(10638, 1194, 1208);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10638, 1194, 1208);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10638, 1194, 1208);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10638, 1277, 1291);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10638, 1280, 1291);
                    return _underlying; DynAbs.Tracing.TraceSender.TraceExitMethod(10638, 1277, 1291);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10638, 1277, 1291);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10638, 1277, 1291);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10638, 1382, 1396);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10638, 1385, 1396);
                    return _underlying; DynAbs.Tracing.TraceSender.TraceExitMethod(10638, 1382, 1396);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10638, 1382, 1396);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10638, 1382, 1396);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override void Accept(SymbolVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10638, 1444, 1564);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10638, 1522, 1553);

                f_10638_1522_1552(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10638, 1444, 1564);

                int
                f_10638_1522_1552(Microsoft.CodeAnalysis.SymbolVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.DynamicTypeSymbol
                symbol)
                {
                    this_param.VisitDynamicType((Microsoft.CodeAnalysis.IDynamicTypeSymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10638, 1522, 1552);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10638, 1444, 1564);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10638, 1444, 1564);
            }
        }

        protected override TResult? Accept<TResult>(SymbolVisitor<TResult> visitor)
                    where TResult : default
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10638, 1576, 1762);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10638, 1713, 1751);

                return f_10638_1720_1750<TResult>(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10638, 1576, 1762);

                TResult?
                f_10638_1720_1750<TResult>(Microsoft.CodeAnalysis.SymbolVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.DynamicTypeSymbol
                symbol)

                {
                    var return_v = this_param.VisitDynamicType((Microsoft.CodeAnalysis.IDynamicTypeSymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10638, 1720, 1750);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10638, 1576, 1762);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10638, 1576, 1762);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static DynamicTypeSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10638, 330, 1791);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10638, 330, 1791);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10638, 330, 1791);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10638, 330, 1791);

        int
        f_10638_665_705(bool
        b)
        {
            RoslynDebug.Assert(b);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10638, 665, 705);
            return 0;
        }


        static Microsoft.CodeAnalysis.NullableAnnotation
        f_10638_621_639_C(Microsoft.CodeAnalysis.NullableAnnotation
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10638, 486, 756);
            return return_v;
        }

    }
}
