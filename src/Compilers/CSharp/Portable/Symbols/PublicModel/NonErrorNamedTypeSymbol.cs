// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Diagnostics;

namespace Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel
{
    internal sealed class NonErrorNamedTypeSymbol : NamedTypeSymbol
    {
        private readonly Symbols.NamedTypeSymbol _underlying;

        public NonErrorNamedTypeSymbol(Symbols.NamedTypeSymbol underlying, CodeAnalysis.NullableAnnotation nullableAnnotation)
        : base(f_10650_610_628_C(nullableAnnotation))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10650, 471, 793);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10650, 447, 458);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10650, 654, 689);

                f_10650_654_688(underlying is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10650, 703, 743);

                f_10650_703_742(!f_10650_717_741(underlying));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10650, 757, 782);

                _underlying = underlying;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10650, 471, 793);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10650, 471, 793);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10650, 471, 793);
            }
        }

        protected override ITypeSymbol WithNullableAnnotation(CodeAnalysis.NullableAnnotation nullableAnnotation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10650, 805, 1176);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10650, 935, 1009);

                f_10650_935_1008(nullableAnnotation != f_10650_970_1007(_underlying));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10650, 1023, 1083);

                f_10650_1023_1082(nullableAnnotation != f_10650_1058_1081(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10650, 1097, 1165);

                return f_10650_1104_1164(_underlying, nullableAnnotation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10650, 805, 1176);

                Microsoft.CodeAnalysis.NullableAnnotation
                f_10650_970_1007(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DefaultNullableAnnotation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10650, 970, 1007);
                    return return_v;
                }


                int
                f_10650_935_1008(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10650, 935, 1008);
                    return 0;
                }


                Microsoft.CodeAnalysis.NullableAnnotation
                f_10650_1058_1081(Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.NonErrorNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.NullableAnnotation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10650, 1058, 1081);
                    return return_v;
                }


                int
                f_10650_1023_1082(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10650, 1023, 1082);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.NonErrorNamedTypeSymbol
                f_10650_1104_1164(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                underlying, Microsoft.CodeAnalysis.NullableAnnotation
                nullableAnnotation)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.NonErrorNamedTypeSymbol(underlying, nullableAnnotation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10650, 1104, 1164);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10650, 805, 1176);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10650, 805, 1176);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override CSharp.Symbol UnderlyingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10650, 1237, 1251);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10650, 1240, 1251);
                    return _underlying; DynAbs.Tracing.TraceSender.TraceExitMethod(10650, 1237, 1251);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10650, 1237, 1251);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10650, 1237, 1251);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10650, 1342, 1356);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10650, 1345, 1356);
                    return _underlying; DynAbs.Tracing.TraceSender.TraceExitMethod(10650, 1342, 1356);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10650, 1342, 1356);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10650, 1342, 1356);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10650, 1425, 1439);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10650, 1428, 1439);
                    return _underlying; DynAbs.Tracing.TraceSender.TraceExitMethod(10650, 1425, 1439);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10650, 1425, 1439);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10650, 1425, 1439);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override Symbols.NamedTypeSymbol UnderlyingNamedTypeSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10650, 1518, 1532);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10650, 1521, 1532);
                    return _underlying; DynAbs.Tracing.TraceSender.TraceExitMethod(10650, 1518, 1532);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10650, 1518, 1532);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10650, 1518, 1532);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static NonErrorNamedTypeSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10650, 326, 1540);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10650, 326, 1540);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10650, 326, 1540);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10650, 326, 1540);

        int
        f_10650_654_688(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10650, 654, 688);
            return 0;
        }


        bool
        f_10650_717_741(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        type)
        {
            var return_v = type.IsErrorType();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10650, 717, 741);
            return return_v;
        }


        int
        f_10650_703_742(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10650, 703, 742);
            return 0;
        }


        static Microsoft.CodeAnalysis.NullableAnnotation
        f_10650_610_628_C(Microsoft.CodeAnalysis.NullableAnnotation
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10650, 471, 793);
            return return_v;
        }

    }
}
