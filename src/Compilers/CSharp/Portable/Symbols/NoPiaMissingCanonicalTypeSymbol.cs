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
    internal class NoPiaMissingCanonicalTypeSymbol : ErrorTypeSymbol
    {
        private readonly AssemblySymbol _embeddingAssembly;

        private readonly string _fullTypeName;

        private readonly string _guid;

        private readonly string _scope;

        private readonly string _identifier;

        public NoPiaMissingCanonicalTypeSymbol(
                    AssemblySymbol embeddingAssembly,
                    string fullTypeName,
                    string guid,
                    string scope,
                    string identifier,
                    TupleExtraData? tupleData = null)
        : base(f_10133_1513_1522_C(tupleData))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10133, 1240, 1736);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10133, 1034, 1052);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10133, 1087, 1100);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10133, 1135, 1140);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10133, 1175, 1181);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10133, 1216, 1227);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10133, 1548, 1587);

                _embeddingAssembly = embeddingAssembly;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10133, 1601, 1630);

                _fullTypeName = fullTypeName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10133, 1644, 1657);

                _guid = guid;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10133, 1671, 1686);

                _scope = scope;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10133, 1700, 1725);

                _identifier = identifier;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10133, 1240, 1736);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10133, 1240, 1736);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10133, 1240, 1736);
            }
        }

        protected override NamedTypeSymbol WithTupleDataCore(TupleExtraData newData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10133, 1748, 1975);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10133, 1849, 1964);

                return f_10133_1856_1963(_embeddingAssembly, _fullTypeName, _guid, _scope, _identifier, newData);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10133, 1748, 1975);

                Microsoft.CodeAnalysis.CSharp.Symbols.NoPiaMissingCanonicalTypeSymbol
                f_10133_1856_1963(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                embeddingAssembly, string
                fullTypeName, string
                guid, string
                scope, string
                identifier, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol.TupleExtraData
                tupleData)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.NoPiaMissingCanonicalTypeSymbol(embeddingAssembly, fullTypeName, guid, scope, identifier, tupleData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10133, 1856, 1963);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10133, 1748, 1975);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10133, 1748, 1975);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public AssemblySymbol EmbeddingAssembly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10133, 2051, 2128);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10133, 2087, 2113);

                    return _embeddingAssembly;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10133, 2051, 2128);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10133, 1987, 2139);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10133, 1987, 2139);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public string FullTypeName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10133, 2202, 2274);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10133, 2238, 2259);

                    return _fullTypeName;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10133, 2202, 2274);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10133, 2151, 2285);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10133, 2151, 2285);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool MangleName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10133, 2355, 2501);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10133, 2430, 2455);

                    f_10133_2430_2454(f_10133_2443_2448() == 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10133, 2473, 2486);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10133, 2355, 2501);

                    int
                    f_10133_2443_2448()
                    {
                        var return_v = Arity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10133, 2443, 2448);
                        return return_v;
                    }


                    int
                    f_10133_2430_2454(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10133, 2430, 2454);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10133, 2297, 2512);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10133, 2297, 2512);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public string Guid
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10133, 2567, 2631);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10133, 2603, 2616);

                    return _guid;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10133, 2567, 2631);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10133, 2524, 2642);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10133, 2524, 2642);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public string Scope
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10133, 2698, 2763);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10133, 2734, 2748);

                    return _scope;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10133, 2698, 2763);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10133, 2654, 2774);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10133, 2654, 2774);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public string Identifier
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10133, 2835, 2905);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10133, 2871, 2890);

                    return _identifier;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10133, 2835, 2905);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10133, 2786, 2916);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10133, 2786, 2916);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10133, 2995, 3120);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10133, 3031, 3105);

                    return f_10133_3038_3104(ErrorCode.ERR_NoCanonicalView, _fullTypeName);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10133, 2995, 3120);

                    Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                    f_10133_3038_3104(Microsoft.CodeAnalysis.CSharp.ErrorCode
                    code, params object[]
                    args)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10133, 3038, 3104);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10133, 2928, 3131);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10133, 2928, 3131);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10133, 3143, 3252);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10133, 3201, 3241);

                return f_10133_3208_3240(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10133, 3143, 3252);

                int
                f_10133_3208_3240(Microsoft.CodeAnalysis.CSharp.Symbols.NoPiaMissingCanonicalTypeSymbol
                o)
                {
                    var return_v = RuntimeHelpers.GetHashCode((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10133, 3208, 3240);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10133, 3143, 3252);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10133, 3143, 3252);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool Equals(TypeSymbol t2, TypeCompareKind comparison)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10133, 3264, 3405);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10133, 3361, 3394);

                return f_10133_3368_3393(this, t2);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10133, 3264, 3405);

                bool
                f_10133_3368_3393(Microsoft.CodeAnalysis.CSharp.Symbols.NoPiaMissingCanonicalTypeSymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10133, 3368, 3393);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10133, 3264, 3405);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10133, 3264, 3405);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static NoPiaMissingCanonicalTypeSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10133, 798, 3412);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10133, 798, 3412);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10133, 798, 3412);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10133, 798, 3412);

        static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol.TupleExtraData?
        f_10133_1513_1522_C(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol.TupleExtraData?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10133, 1240, 1736);
            return return_v;
        }

    }
}
