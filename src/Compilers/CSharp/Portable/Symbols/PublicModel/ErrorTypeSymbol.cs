// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Diagnostics;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel
{
    internal sealed class ErrorTypeSymbol : NamedTypeSymbol, IErrorTypeSymbol
    {
        private readonly Symbols.ErrorTypeSymbol _underlying;

        public ErrorTypeSymbol(Symbols.ErrorTypeSymbol underlying, CodeAnalysis.NullableAnnotation nullableAnnotation)
        : base(f_10639_653_671_C(nullableAnnotation))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10639, 522, 788);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10639, 498, 509);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10639, 697, 738);

                f_10639_697_737(underlying is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10639, 752, 777);

                _underlying = underlying;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10639, 522, 788);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10639, 522, 788);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10639, 522, 788);
            }
        }

        protected override ITypeSymbol WithNullableAnnotation(CodeAnalysis.NullableAnnotation nullableAnnotation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10639, 800, 1163);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10639, 930, 1004);

                f_10639_930_1003(nullableAnnotation != f_10639_965_1002(_underlying));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10639, 1018, 1078);

                f_10639_1018_1077(nullableAnnotation != f_10639_1053_1076(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10639, 1092, 1152);

                return f_10639_1099_1151(_underlying, nullableAnnotation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10639, 800, 1163);

                Microsoft.CodeAnalysis.NullableAnnotation
                f_10639_965_1002(Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                this_param)
                {
                    var return_v = this_param.DefaultNullableAnnotation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10639, 965, 1002);
                    return return_v;
                }


                int
                f_10639_930_1003(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10639, 930, 1003);
                    return 0;
                }


                Microsoft.CodeAnalysis.NullableAnnotation
                f_10639_1053_1076(Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.ErrorTypeSymbol
                this_param)
                {
                    var return_v = this_param.NullableAnnotation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10639, 1053, 1076);
                    return return_v;
                }


                int
                f_10639_1018_1077(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10639, 1018, 1077);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.ErrorTypeSymbol
                f_10639_1099_1151(Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                underlying, Microsoft.CodeAnalysis.NullableAnnotation
                nullableAnnotation)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.ErrorTypeSymbol(underlying, nullableAnnotation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10639, 1099, 1151);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10639, 800, 1163);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10639, 800, 1163);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override CSharp.Symbol UnderlyingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10639, 1224, 1238);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10639, 1227, 1238);
                    return _underlying; DynAbs.Tracing.TraceSender.TraceExitMethod(10639, 1224, 1238);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10639, 1224, 1238);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10639, 1224, 1238);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10639, 1329, 1343);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10639, 1332, 1343);
                    return _underlying; DynAbs.Tracing.TraceSender.TraceExitMethod(10639, 1329, 1343);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10639, 1329, 1343);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10639, 1329, 1343);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10639, 1412, 1426);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10639, 1415, 1426);
                    return _underlying; DynAbs.Tracing.TraceSender.TraceExitMethod(10639, 1412, 1426);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10639, 1412, 1426);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10639, 1412, 1426);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10639, 1505, 1519);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10639, 1508, 1519);
                    return _underlying; DynAbs.Tracing.TraceSender.TraceExitMethod(10639, 1505, 1519);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10639, 1505, 1519);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10639, 1505, 1519);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ImmutableArray<ISymbol> IErrorTypeSymbol.CandidateSymbols
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10639, 1590, 1661);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10639, 1593, 1661);
                    return _underlying.CandidateSymbols.SelectAsArray(s => s.GetPublicSymbol()); DynAbs.Tracing.TraceSender.TraceExitMethod(10639, 1590, 1661);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10639, 1590, 1661);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10639, 1590, 1661);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        CandidateReason IErrorTypeSymbol.CandidateReason
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10639, 1723, 1753);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10639, 1726, 1753);
                    return f_10639_1726_1753(_underlying); DynAbs.Tracing.TraceSender.TraceExitMethod(10639, 1723, 1753);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10639, 1723, 1753);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10639, 1723, 1753);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static ErrorTypeSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10639, 367, 1761);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10639, 367, 1761);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10639, 367, 1761);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10639, 367, 1761);

        int
        f_10639_697_737(bool
        b)
        {
            RoslynDebug.Assert(b);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10639, 697, 737);
            return 0;
        }


        static Microsoft.CodeAnalysis.NullableAnnotation
        f_10639_653_671_C(Microsoft.CodeAnalysis.NullableAnnotation
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10639, 522, 788);
            return return_v;
        }


        Microsoft.CodeAnalysis.CandidateReason
        f_10639_1726_1753(Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
        this_param)
        {
            var return_v = this_param.CandidateReason;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10639, 1726, 1753);
            return return_v;
        }

    }
}
