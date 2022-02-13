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
    internal sealed class TypeWellKnownAttributeData : CommonTypeWellKnownAttributeData, ISkipLocalsInitAttributeTarget
    {
        private NamedTypeSymbol _comImportCoClass;

        public NamedTypeSymbol ComImportCoClass
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10415, 846, 922);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10415, 882, 907);

                    return _comImportCoClass;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10415, 846, 922);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10415, 782, 1226);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10415, 782, 1226);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10415, 936, 1215);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10415, 972, 1002);

                    f_10415_972_1001(this, expected: false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10415, 1020, 1068);

                    f_10415_1020_1067((object)_comImportCoClass == null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10415, 1086, 1122);

                    f_10415_1086_1121((object)value != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10415, 1140, 1166);

                    _comImportCoClass = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10415, 1184, 1200);

                    f_10415_1184_1199(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10415, 936, 1215);

                    int
                    f_10415_972_1001(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWellKnownAttributeData
                    this_param, bool
                    expected)
                    {
                        this_param.VerifySealed(expected: expected);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10415, 972, 1001);
                        return 0;
                    }


                    int
                    f_10415_1020_1067(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10415, 1020, 1067);
                        return 0;
                    }


                    int
                    f_10415_1086_1121(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10415, 1086, 1121);
                        return 0;
                    }


                    int
                    f_10415_1184_1199(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWellKnownAttributeData
                    this_param)
                    {
                        this_param.SetDataStored();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10415, 1184, 1199);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10415, 782, 1226);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10415, 782, 1226);
                }
            }
        }

        private bool _hasSkipLocalsInitAttribute;

        public bool HasSkipLocalsInitAttribute
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10415, 1415, 1548);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10415, 1451, 1480);

                    f_10415_1451_1479(this, expected: true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10415, 1498, 1533);

                    return _hasSkipLocalsInitAttribute;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10415, 1415, 1548);

                    int
                    f_10415_1451_1479(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWellKnownAttributeData
                    this_param, bool
                    expected)
                    {
                        this_param.VerifySealed(expected: expected);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10415, 1451, 1479);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10415, 1352, 1742);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10415, 1352, 1742);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10415, 1562, 1731);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10415, 1598, 1628);

                    f_10415_1598_1627(this, expected: false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10415, 1646, 1682);

                    _hasSkipLocalsInitAttribute = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10415, 1700, 1716);

                    f_10415_1700_1715(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10415, 1562, 1731);

                    int
                    f_10415_1598_1627(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWellKnownAttributeData
                    this_param, bool
                    expected)
                    {
                        this_param.VerifySealed(expected: expected);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10415, 1598, 1627);
                        return 0;
                    }


                    int
                    f_10415_1700_1715(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWellKnownAttributeData
                    this_param)
                    {
                        this_param.SetDataStored();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10415, 1700, 1715);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10415, 1352, 1742);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10415, 1352, 1742);
                }
            }
        }

        public TypeWellKnownAttributeData()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(10415, 562, 1769);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10415, 754, 771);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10415, 1314, 1341);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(10415, 562, 1769);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10415, 562, 1769);
        }


        static TypeWellKnownAttributeData()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10415, 562, 1769);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10415, 562, 1769);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10415, 562, 1769);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10415, 562, 1769);
    }
}
