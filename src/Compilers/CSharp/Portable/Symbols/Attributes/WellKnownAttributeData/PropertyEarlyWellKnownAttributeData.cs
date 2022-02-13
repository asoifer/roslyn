// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class PropertyEarlyWellKnownAttributeData : CommonPropertyEarlyWellKnownAttributeData
    {
        private string _indexerName;

        public string IndexerName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10412, 818, 936);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10412, 854, 883);

                    f_10412_854_882(this, expected: true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10412, 901, 921);

                    return _indexerName;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10412, 818, 936);

                    int
                    f_10412_854_882(Microsoft.CodeAnalysis.CSharp.Symbols.PropertyEarlyWellKnownAttributeData
                    this_param, bool
                    expected)
                    {
                        this_param.VerifySealed(expected: expected);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10412, 854, 882);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10412, 768, 1458);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10412, 768, 1458);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10412, 950, 1447);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10412, 986, 1016);

                    f_10412_986_1015(this, expected: false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10412, 1034, 1062);

                    f_10412_1034_1061(value != null);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10412, 1288, 1432) || true) && (_indexerName == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10412, 1288, 1432);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10412, 1354, 1375);

                        _indexerName = value;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10412, 1397, 1413);

                        f_10412_1397_1412(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10412, 1288, 1432);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10412, 950, 1447);

                    int
                    f_10412_986_1015(Microsoft.CodeAnalysis.CSharp.Symbols.PropertyEarlyWellKnownAttributeData
                    this_param, bool
                    expected)
                    {
                        this_param.VerifySealed(expected: expected);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10412, 986, 1015);
                        return 0;
                    }


                    int
                    f_10412_1034_1061(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10412, 1034, 1061);
                        return 0;
                    }


                    int
                    f_10412_1397_1412(Microsoft.CodeAnalysis.CSharp.Symbols.PropertyEarlyWellKnownAttributeData
                    this_param)
                    {
                        this_param.SetDataStored();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10412, 1397, 1412);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10412, 768, 1458);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10412, 768, 1458);
                }
            }
        }

        public PropertyEarlyWellKnownAttributeData()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(10412, 572, 1487);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10412, 745, 757);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(10412, 572, 1487);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10412, 572, 1487);
        }


        static PropertyEarlyWellKnownAttributeData()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10412, 572, 1487);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10412, 572, 1487);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10412, 572, 1487);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10412, 572, 1487);
    }
}
