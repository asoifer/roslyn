// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class ReturnTypeWellKnownAttributeData : CommonReturnTypeWellKnownAttributeData
    {
        private bool _hasMaybeNullAttribute;

        public bool HasMaybeNullAttribute
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10414, 575, 703);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10414, 611, 640);

                    f_10414_611_639(this, expected: true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10414, 658, 688);

                    return _hasMaybeNullAttribute;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10414, 575, 703);

                    int
                    f_10414_611_639(Microsoft.CodeAnalysis.CSharp.Symbols.ReturnTypeWellKnownAttributeData
                    this_param, bool
                    expected)
                    {
                        this_param.VerifySealed(expected: expected);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10414, 611, 639);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10414, 517, 892);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10414, 517, 892);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10414, 717, 881);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10414, 753, 783);

                    f_10414_753_782(this, expected: false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10414, 801, 832);

                    _hasMaybeNullAttribute = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10414, 850, 866);

                    f_10414_850_865(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10414, 717, 881);

                    int
                    f_10414_753_782(Microsoft.CodeAnalysis.CSharp.Symbols.ReturnTypeWellKnownAttributeData
                    this_param, bool
                    expected)
                    {
                        this_param.VerifySealed(expected: expected);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10414, 753, 782);
                        return 0;
                    }


                    int
                    f_10414_850_865(Microsoft.CodeAnalysis.CSharp.Symbols.ReturnTypeWellKnownAttributeData
                    this_param)
                    {
                        this_param.SetDataStored();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10414, 850, 865);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10414, 517, 892);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10414, 517, 892);
                }
            }
        }

        private bool _hasNotNullAttribute;

        public bool HasNotNullAttribute
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10414, 1004, 1130);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10414, 1040, 1069);

                    f_10414_1040_1068(this, expected: true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10414, 1087, 1115);

                    return _hasNotNullAttribute;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10414, 1004, 1130);

                    int
                    f_10414_1040_1068(Microsoft.CodeAnalysis.CSharp.Symbols.ReturnTypeWellKnownAttributeData
                    this_param, bool
                    expected)
                    {
                        this_param.VerifySealed(expected: expected);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10414, 1040, 1068);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10414, 948, 1317);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10414, 948, 1317);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10414, 1144, 1306);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10414, 1180, 1210);

                    f_10414_1180_1209(this, expected: false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10414, 1228, 1257);

                    _hasNotNullAttribute = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10414, 1275, 1291);

                    f_10414_1275_1290(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10414, 1144, 1306);

                    int
                    f_10414_1180_1209(Microsoft.CodeAnalysis.CSharp.Symbols.ReturnTypeWellKnownAttributeData
                    this_param, bool
                    expected)
                    {
                        this_param.VerifySealed(expected: expected);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10414, 1180, 1209);
                        return 0;
                    }


                    int
                    f_10414_1275_1290(Microsoft.CodeAnalysis.CSharp.Symbols.ReturnTypeWellKnownAttributeData
                    this_param)
                    {
                        this_param.SetDataStored();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10414, 1275, 1290);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10414, 948, 1317);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10414, 948, 1317);
                }
            }
        }

        private ImmutableHashSet<string> _notNullIfParameterNotNull;

        public ImmutableHashSet<string> NotNullIfParameterNotNull
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10414, 1514, 1646);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10414, 1550, 1579);

                    f_10414_1550_1578(this, expected: true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10414, 1597, 1631);

                    return _notNullIfParameterNotNull;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10414, 1514, 1646);

                    int
                    f_10414_1550_1578(Microsoft.CodeAnalysis.CSharp.Symbols.ReturnTypeWellKnownAttributeData
                    this_param, bool
                    expected)
                    {
                        this_param.VerifySealed(expected: expected);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10414, 1550, 1578);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10414, 1432, 1657);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10414, 1432, 1657);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public void AddNotNullIfParameterNotNull(string parameterName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10414, 1667, 1971);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10414, 1754, 1784);

                f_10414_1754_1783(this, expected: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10414, 1855, 1930);

                _notNullIfParameterNotNull = f_10414_1884_1929(_notNullIfParameterNotNull, parameterName);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10414, 1944, 1960);

                f_10414_1944_1959(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10414, 1667, 1971);

                int
                f_10414_1754_1783(Microsoft.CodeAnalysis.CSharp.Symbols.ReturnTypeWellKnownAttributeData
                this_param, bool
                expected)
                {
                    this_param.VerifySealed(expected: expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10414, 1754, 1783);
                    return 0;
                }


                System.Collections.Immutable.ImmutableHashSet<string>
                f_10414_1884_1929(System.Collections.Immutable.ImmutableHashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10414, 1884, 1929);
                    return return_v;
                }


                int
                f_10414_1944_1959(Microsoft.CodeAnalysis.CSharp.Symbols.ReturnTypeWellKnownAttributeData
                this_param)
                {
                    this_param.SetDataStored();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10414, 1944, 1959);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10414, 1667, 1971);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10414, 1667, 1971);
            }
        }

        public ReturnTypeWellKnownAttributeData()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(10414, 359, 1978);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10414, 484, 506);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10414, 917, 937);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10414, 1362, 1421);
            this._notNullIfParameterNotNull = ImmutableHashSet<string>.Empty; DynAbs.Tracing.TraceSender.TraceExitConstructor(10414, 359, 1978);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10414, 359, 1978);
        }


        static ReturnTypeWellKnownAttributeData()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10414, 359, 1978);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10414, 359, 1978);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10414, 359, 1978);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10414, 359, 1978);
    }
}
