// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Diagnostics;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class DynamicTypeEraser : AbstractTypeMap
    {
        private readonly TypeSymbol _objectType;

        public DynamicTypeEraser(TypeSymbol objectType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10100, 550, 713);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10100, 526, 537);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10100, 622, 663);

                f_10100_622_662((object)objectType != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10100, 677, 702);

                _objectType = objectType;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10100, 550, 713);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10100, 550, 713);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10100, 550, 713);
            }
        }

        public TypeSymbol EraseDynamic(TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10100, 725, 855);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10100, 797, 844);

                return f_10100_804_824(this, type).AsTypeSymbolOnly();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10100, 725, 855);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10100_804_824(Microsoft.CodeAnalysis.CSharp.Symbols.DynamicTypeEraser
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                previous)
                {
                    var return_v = this_param.SubstituteType(previous);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10100, 804, 824);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10100, 725, 855);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10100, 725, 855);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override TypeSymbol SubstituteDynamicType()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10100, 867, 975);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10100, 945, 964);

                return _objectType;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10100, 867, 975);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10100, 867, 975);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10100, 867, 975);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static DynamicTypeEraser()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10100, 424, 982);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10100, 424, 982);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10100, 424, 982);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10100, 424, 982);

        int
        f_10100_622_662(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10100, 622, 662);
            return 0;
        }

    }
}
