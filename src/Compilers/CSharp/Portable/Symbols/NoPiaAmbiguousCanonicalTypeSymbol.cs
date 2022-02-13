// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal class NoPiaAmbiguousCanonicalTypeSymbol : ErrorTypeSymbol
    {
        private readonly AssemblySymbol _embeddingAssembly;

        private readonly NamedTypeSymbol _firstCandidate;

        private readonly NamedTypeSymbol _secondCandidate;

        public NoPiaAmbiguousCanonicalTypeSymbol(
                    AssemblySymbol embeddingAssembly,
                    NamedTypeSymbol firstCandidate,
                    NamedTypeSymbol secondCandidate,
                    TupleExtraData? tupleData = null)
        : base(f_10131_1308_1317_C(tupleData))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10131, 1061, 1489);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10131, 911, 929);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10131, 973, 988);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10131, 1032, 1048);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10131, 1343, 1382);

                _embeddingAssembly = embeddingAssembly;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10131, 1396, 1429);

                _firstCandidate = firstCandidate;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10131, 1443, 1478);

                _secondCandidate = secondCandidate;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10131, 1061, 1489);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10131, 1061, 1489);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10131, 1061, 1489);
            }
        }

        protected override NamedTypeSymbol WithTupleDataCore(TupleExtraData newData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10131, 1501, 1722);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10131, 1602, 1711);

                return f_10131_1609_1710(_embeddingAssembly, _firstCandidate, _secondCandidate, newData);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10131, 1501, 1722);

                Microsoft.CodeAnalysis.CSharp.Symbols.NoPiaAmbiguousCanonicalTypeSymbol
                f_10131_1609_1710(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                embeddingAssembly, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                firstCandidate, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                secondCandidate, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol.TupleExtraData
                tupleData)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.NoPiaAmbiguousCanonicalTypeSymbol(embeddingAssembly, firstCandidate, secondCandidate, tupleData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10131, 1609, 1710);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10131, 1501, 1722);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10131, 1501, 1722);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool MangleName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10131, 1792, 1899);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10131, 1828, 1853);

                    f_10131_1828_1852(f_10131_1841_1846() == 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10131, 1871, 1884);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10131, 1792, 1899);

                    int
                    f_10131_1841_1846()
                    {
                        var return_v = Arity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10131, 1841, 1846);
                        return return_v;
                    }


                    int
                    f_10131_1828_1852(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10131, 1828, 1852);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10131, 1734, 1910);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10131, 1734, 1910);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public AssemblySymbol EmbeddingAssembly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10131, 1986, 2063);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10131, 2022, 2048);

                    return _embeddingAssembly;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10131, 1986, 2063);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10131, 1922, 2074);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10131, 1922, 2074);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public NamedTypeSymbol FirstCandidate
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10131, 2148, 2222);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10131, 2184, 2207);

                    return _firstCandidate;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10131, 2148, 2222);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10131, 2086, 2233);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10131, 2086, 2233);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public NamedTypeSymbol SecondCandidate
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10131, 2308, 2383);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10131, 2344, 2368);

                    return _secondCandidate;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10131, 2308, 2383);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10131, 2245, 2394);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10131, 2245, 2394);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override DiagnosticInfo ErrorInfo
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10131, 2473, 2600);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10131, 2509, 2585);

                    return f_10131_2516_2584(ErrorCode.ERR_NoCanonicalView, _firstCandidate);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10131, 2473, 2600);

                    Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                    f_10131_2516_2584(Microsoft.CodeAnalysis.CSharp.ErrorCode
                    code, params object[]
                    args)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10131, 2516, 2584);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10131, 2406, 2611);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10131, 2406, 2611);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10131, 2623, 2732);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10131, 2681, 2721);

                return f_10131_2688_2720(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10131, 2623, 2732);

                int
                f_10131_2688_2720(Microsoft.CodeAnalysis.CSharp.Symbols.NoPiaAmbiguousCanonicalTypeSymbol
                o)
                {
                    var return_v = RuntimeHelpers.GetHashCode((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10131, 2688, 2720);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10131, 2623, 2732);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10131, 2623, 2732);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool Equals(TypeSymbol t2, TypeCompareKind comparison)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10131, 2744, 2885);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10131, 2841, 2874);

                return f_10131_2848_2873(this, t2);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10131, 2744, 2885);

                bool
                f_10131_2848_2873(Microsoft.CodeAnalysis.CSharp.Symbols.NoPiaAmbiguousCanonicalTypeSymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10131, 2848, 2873);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10131, 2744, 2885);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10131, 2744, 2885);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static NoPiaAmbiguousCanonicalTypeSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10131, 796, 2892);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10131, 796, 2892);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10131, 796, 2892);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10131, 796, 2892);

        static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol.TupleExtraData?
        f_10131_1308_1317_C(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol.TupleExtraData?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10131, 1061, 1489);
            return return_v;
        }

    }
}
