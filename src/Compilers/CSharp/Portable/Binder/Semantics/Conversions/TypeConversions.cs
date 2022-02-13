// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Symbols;
using Roslyn.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class TypeConversions : ConversionsBase
    {
        public TypeConversions(AssemblySymbol corLibrary, bool includeNullability = false)
        : this(f_10845_602_612_C(corLibrary), currentRecursionDepth: 0, includeNullability: includeNullability, otherNullabilityOpt: null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10845, 499, 728);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10845, 499, 728);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10845, 499, 728);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10845, 499, 728);
            }
        }

        private TypeConversions(AssemblySymbol corLibrary, int currentRecursionDepth, bool includeNullability, TypeConversions otherNullabilityOpt)
        : base(f_10845_900_910_C(corLibrary), currentRecursionDepth, includeNullability, otherNullabilityOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10845, 740, 997);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10845, 740, 997);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10845, 740, 997);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10845, 740, 997);
            }
        }

        protected override ConversionsBase CreateInstance(int currentRecursionDepth)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10845, 1009, 1235);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10845, 1110, 1224);

                return f_10845_1117_1223(this.corLibrary, currentRecursionDepth, IncludeNullability, otherNullabilityOpt: null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10845, 1009, 1235);

                Microsoft.CodeAnalysis.CSharp.TypeConversions
                f_10845_1117_1223(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                corLibrary, int
                currentRecursionDepth, bool
                includeNullability, Microsoft.CodeAnalysis.CSharp.TypeConversions
                otherNullabilityOpt)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.TypeConversions(corLibrary, currentRecursionDepth, includeNullability, otherNullabilityOpt: otherNullabilityOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10845, 1117, 1223);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10845, 1009, 1235);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10845, 1009, 1235);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override ConversionsBase WithNullabilityCore(bool includeNullability)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10845, 1247, 1519);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10845, 1351, 1406);

                f_10845_1351_1405(IncludeNullability != includeNullability);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10845, 1420, 1508);

                return f_10845_1427_1507(corLibrary, currentRecursionDepth, includeNullability, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10845, 1247, 1519);

                int
                f_10845_1351_1405(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10845, 1351, 1405);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.TypeConversions
                f_10845_1427_1507(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                corLibrary, int
                currentRecursionDepth, bool
                includeNullability, Microsoft.CodeAnalysis.CSharp.TypeConversions
                otherNullabilityOpt)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.TypeConversions(corLibrary, currentRecursionDepth, includeNullability, otherNullabilityOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10845, 1427, 1507);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10845, 1247, 1519);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10845, 1247, 1519);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Conversion GetMethodGroupDelegateConversion(BoundMethodGroup source, TypeSymbol destination, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10845, 1531, 1830);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10845, 1782, 1819);

                throw f_10845_1788_1818();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10845, 1531, 1830);

                System.Exception
                f_10845_1788_1818()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10845, 1788, 1818);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10845, 1531, 1830);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10845, 1531, 1830);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Conversion GetMethodGroupFunctionPointerConversion(BoundMethodGroup source, FunctionPointerTypeSymbol destination, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10845, 1842, 2163);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10845, 2115, 2152);

                throw f_10845_2121_2151();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10845, 1842, 2163);

                System.Exception
                f_10845_2121_2151()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10845, 2121, 2151);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10845, 1842, 2163);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10845, 1842, 2163);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Conversion GetStackAllocConversion(BoundStackAllocArrayCreation sourceExpression, TypeSymbol destination, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10845, 2175, 2496);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10845, 2448, 2485);

                throw f_10845_2454_2484();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10845, 2175, 2496);

                System.Exception
                f_10845_2454_2484()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10845, 2454, 2484);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10845, 2175, 2496);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10845, 2175, 2496);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override Conversion GetInterpolatedStringConversion(BoundInterpolatedString source, TypeSymbol destination, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10845, 2508, 2823);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10845, 2775, 2812);

                throw f_10845_2781_2811();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10845, 2508, 2823);

                System.Exception
                f_10845_2781_2811()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10845, 2781, 2811);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10845, 2508, 2823);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10845, 2508, 2823);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static TypeConversions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10845, 427, 2830);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10845, 427, 2830);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10845, 427, 2830);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10845, 427, 2830);

        static Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        f_10845_602_612_C(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10845, 499, 728);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        f_10845_900_910_C(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10845, 740, 997);
            return return_v;
        }

    }
}
