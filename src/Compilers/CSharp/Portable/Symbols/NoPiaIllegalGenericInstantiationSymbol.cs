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
    internal class NoPiaIllegalGenericInstantiationSymbol : ErrorTypeSymbol
    {
        private readonly ModuleSymbol _exposingModule;

        private readonly NamedTypeSymbol _underlyingSymbol;

        public NoPiaIllegalGenericInstantiationSymbol(ModuleSymbol exposingModule, NamedTypeSymbol underlyingSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10132, 967, 1195);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10132, 878, 893);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10132, 937, 954);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10132, 1100, 1133);

                _exposingModule = exposingModule;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10132, 1147, 1184);

                _underlyingSymbol = underlyingSymbol;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10132, 967, 1195);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10132, 967, 1195);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10132, 967, 1195);
            }
        }

        protected override NamedTypeSymbol WithTupleDataCore(TupleExtraData newData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10132, 1207, 1405);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10132, 1308, 1394);

                return f_10132_1315_1393(_exposingModule, _underlyingSymbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10132, 1207, 1405);

                Microsoft.CodeAnalysis.CSharp.Symbols.NoPiaIllegalGenericInstantiationSymbol
                f_10132_1315_1393(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                exposingModule, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                underlyingSymbol)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.NoPiaIllegalGenericInstantiationSymbol(exposingModule, underlyingSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10132, 1315, 1393);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10132, 1207, 1405);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10132, 1207, 1405);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool MangleName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10132, 1475, 1582);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10132, 1511, 1536);

                    f_10132_1511_1535(f_10132_1524_1529() == 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10132, 1554, 1567);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10132, 1475, 1582);

                    int
                    f_10132_1524_1529()
                    {
                        var return_v = Arity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10132, 1524, 1529);
                        return return_v;
                    }


                    int
                    f_10132_1511_1535(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10132, 1511, 1535);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10132, 1417, 1593);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10132, 1417, 1593);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public NamedTypeSymbol UnderlyingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10132, 1669, 1745);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10132, 1705, 1730);

                    return _underlyingSymbol;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10132, 1669, 1745);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10132, 1605, 1756);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10132, 1605, 1756);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10132, 1835, 2363);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10132, 1871, 2201) || true) && (f_10132_1875_1906(_underlyingSymbol))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10132, 1871, 2201);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10132, 1948, 2028);

                        DiagnosticInfo?
                        underlyingInfo = f_10132_1981_2027(((ErrorTypeSymbol)_underlyingSymbol))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10132, 2052, 2182) || true) && ((object?)underlyingInfo != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10132, 2052, 2182);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10132, 2137, 2159);

                            return underlyingInfo;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10132, 2052, 2182);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10132, 1871, 2201);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10132, 2221, 2348);

                    return f_10132_2228_2347(ErrorCode.ERR_GenericsUsedAcrossAssemblies, _underlyingSymbol, f_10132_2312_2346(_exposingModule));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10132, 1835, 2363);

                    bool
                    f_10132_1875_1906(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    type)
                    {
                        var return_v = type.IsErrorType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10132, 1875, 1906);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.DiagnosticInfo?
                    f_10132_1981_2027(Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ErrorInfo;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10132, 1981, 2027);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    f_10132_2312_2346(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingAssembly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10132, 2312, 2346);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                    f_10132_2228_2347(Microsoft.CodeAnalysis.CSharp.ErrorCode
                    code, params object[]
                    args)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10132, 2228, 2347);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10132, 1768, 2374);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10132, 1768, 2374);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10132, 2386, 2495);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10132, 2444, 2484);

                return f_10132_2451_2483(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10132, 2386, 2495);

                int
                f_10132_2451_2483(Microsoft.CodeAnalysis.CSharp.Symbols.NoPiaIllegalGenericInstantiationSymbol
                o)
                {
                    var return_v = RuntimeHelpers.GetHashCode((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10132, 2451, 2483);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10132, 2386, 2495);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10132, 2386, 2495);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool Equals(TypeSymbol t2, TypeCompareKind comparison)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10132, 2507, 2648);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10132, 2604, 2637);

                return f_10132_2611_2636(this, t2);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10132, 2507, 2648);

                bool
                f_10132_2611_2636(Microsoft.CodeAnalysis.CSharp.Symbols.NoPiaIllegalGenericInstantiationSymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10132, 2611, 2636);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10132, 2507, 2648);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10132, 2507, 2648);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static NoPiaIllegalGenericInstantiationSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10132, 760, 2655);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10132, 760, 2655);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10132, 760, 2655);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10132, 760, 2655);
    }
}
