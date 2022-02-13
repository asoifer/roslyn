// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Diagnostics;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class PlaceholderTypeArgumentSymbol : ErrorTypeSymbol
    {
        private static readonly TypeWithAnnotations s_instance;

        public static ImmutableArray<TypeWithAnnotations> CreateTypeArguments(ImmutableArray<TypeParameterSymbol> typeParameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10144, 865, 1075);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10144, 1011, 1064);

                return typeParameters.SelectAsArray(_ => s_instance);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10144, 865, 1075);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10144, 865, 1075);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10144, 865, 1075);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private PlaceholderTypeArgumentSymbol()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10144, 1087, 1148);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10144, 1087, 1148);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10144, 1087, 1148);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10144, 1087, 1148);
            }
        }

        protected override NamedTypeSymbol WithTupleDataCore(TupleExtraData newData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10144, 1160, 1309);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10144, 1261, 1298);

                throw f_10144_1267_1297();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10144, 1160, 1309);

                System.Exception
                f_10144_1267_1297()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10144, 1267, 1297);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10144, 1160, 1309);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10144, 1160, 1309);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10144, 1373, 1444);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10144, 1409, 1429);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10144, 1373, 1444);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10144, 1321, 1455);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10144, 1321, 1455);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10144, 1525, 1632);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10144, 1561, 1586);

                    f_10144_1561_1585(f_10144_1574_1579() == 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10144, 1604, 1617);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10144, 1525, 1632);

                    int
                    f_10144_1574_1579()
                    {
                        var return_v = Arity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10144, 1574, 1579);
                        return return_v;
                    }


                    int
                    f_10144_1561_1585(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10144, 1561, 1585);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10144, 1467, 1643);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10144, 1467, 1643);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override DiagnosticInfo? ErrorInfo
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10144, 1723, 1786);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10144, 1759, 1771);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10144, 1723, 1786);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10144, 1655, 1797);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10144, 1655, 1797);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool Equals(TypeSymbol t2, TypeCompareKind comparison)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10144, 1809, 1943);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10144, 1906, 1932);

                return (object)t2 == this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10144, 1809, 1943);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10144, 1809, 1943);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10144, 1809, 1943);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10144, 1955, 2096);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10144, 2013, 2085);

                return f_10144_2020_2084(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10144, 1955, 2096);

                int
                f_10144_2020_2084(Microsoft.CodeAnalysis.CSharp.Symbols.PlaceholderTypeArgumentSymbol
                o)
                {
                    var return_v = System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10144, 2020, 2084);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10144, 1955, 2096);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10144, 1955, 2096);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static PlaceholderTypeArgumentSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10144, 646, 2103);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10144, 776, 852);
            s_instance = TypeWithAnnotations.Create(f_10144_816_851()); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10144, 646, 2103);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10144, 646, 2103);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10144, 646, 2103);

        static Microsoft.CodeAnalysis.CSharp.Symbols.PlaceholderTypeArgumentSymbol
        f_10144_816_851()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.PlaceholderTypeArgumentSymbol();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10144, 816, 851);
            return return_v;
        }

    }
}

