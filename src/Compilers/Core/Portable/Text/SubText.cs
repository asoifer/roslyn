// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Text;

namespace Microsoft.CodeAnalysis.Text
{
    internal sealed class SubText : SourceText
    {
        public SubText(SourceText text, TextSpan span)
        : base(checksumAlgorithm: f_728_556_597_C(f_728_575_597(text)))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(728, 489, 1076);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(728, 1162, 1203);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(728, 623, 734) || true) && (text == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(728, 623, 734);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(728, 673, 719);

                    throw f_728_679_718(nameof(text));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(728, 623, 734);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(728, 750, 991) || true) && (span.Start < 0
                || (DynAbs.Tracing.TraceSender.Expression_False(728, 754, 814) || span.Start >= f_728_803_814(text)) || (DynAbs.Tracing.TraceSender.Expression_False(728, 754, 847) || span.End < 0
                ) || (DynAbs.Tracing.TraceSender.Expression_False(728, 754, 890) || span.End > f_728_879_890(text)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(728, 750, 991);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(728, 924, 976);

                    throw f_728_930_975(nameof(span));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(728, 750, 991);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(728, 1007, 1029);

                UnderlyingText = text;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(728, 1043, 1065);

                UnderlyingSpan = span;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(728, 489, 1076);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(728, 489, 1076);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(728, 489, 1076);
            }
        }

        public override Encoding? Encoding
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(728, 1123, 1149);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(728, 1126, 1149);
                    return f_728_1126_1149(f_728_1126_1140()); DynAbs.Tracing.TraceSender.TraceExitMethod(728, 1123, 1149);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(728, 1123, 1149);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(728, 1123, 1149);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public SourceText UnderlyingText { get; }

        public TextSpan UnderlyingSpan { get; }

        public override int Length
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(728, 1293, 1317);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(728, 1296, 1317);
                    return f_728_1296_1310().Length; DynAbs.Tracing.TraceSender.TraceExitMethod(728, 1293, 1317);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(728, 1293, 1317);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(728, 1293, 1317);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override int StorageSize
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(728, 1388, 1435);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(728, 1394, 1433);

                    return f_728_1401_1432(f_728_1401_1420(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(728, 1388, 1435);

                    Microsoft.CodeAnalysis.Text.SourceText
                    f_728_1401_1420(Microsoft.CodeAnalysis.Text.SubText
                    this_param)
                    {
                        var return_v = this_param.UnderlyingText;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(728, 1401, 1420);
                        return return_v;
                    }


                    int
                    f_728_1401_1432(Microsoft.CodeAnalysis.Text.SourceText
                    this_param)
                    {
                        var return_v = this_param.StorageSize;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(728, 1401, 1432);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(728, 1330, 1446);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(728, 1330, 1446);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override SourceText StorageKey
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(728, 1522, 1568);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(728, 1528, 1566);

                    return f_728_1535_1565(f_728_1535_1554(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(728, 1522, 1568);

                    Microsoft.CodeAnalysis.Text.SourceText
                    f_728_1535_1554(Microsoft.CodeAnalysis.Text.SubText
                    this_param)
                    {
                        var return_v = this_param.UnderlyingText;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(728, 1535, 1554);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Text.SourceText
                    f_728_1535_1565(Microsoft.CodeAnalysis.Text.SourceText
                    this_param)
                    {
                        var return_v = this_param.StorageKey;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(728, 1535, 1565);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(728, 1458, 1579);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(728, 1458, 1579);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override char this[int position]
        {

            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(728, 1655, 1940);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(728, 1691, 1850) || true) && (position < 0 || (DynAbs.Tracing.TraceSender.Expression_False(728, 1695, 1733) || position > f_728_1722_1733(this)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(728, 1691, 1850);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(728, 1775, 1831);

                        throw f_728_1781_1830(nameof(position));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(728, 1691, 1850);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(728, 1870, 1925);

                    return f_728_1877_1924(f_728_1877_1891(), f_728_1892_1906().Start + position);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(728, 1655, 1940);

                    int
                    f_728_1722_1733(Microsoft.CodeAnalysis.Text.SubText
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(728, 1722, 1733);
                        return return_v;
                    }


                    System.ArgumentOutOfRangeException
                    f_728_1781_1830(string
                    paramName)
                    {
                        var return_v = new System.ArgumentOutOfRangeException(paramName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(728, 1781, 1830);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Text.SourceText
                    f_728_1877_1891()
                    {
                        var return_v = UnderlyingText;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(728, 1877, 1891);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Text.TextSpan
                    f_728_1892_1906()
                    {
                        var return_v = UnderlyingSpan;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(728, 1892, 1906);
                        return return_v;
                    }


                    char
                    f_728_1877_1924(Microsoft.CodeAnalysis.Text.SourceText
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(728, 1877, 1924);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(728, 1655, 1940);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(728, 1655, 1940);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string ToString(TextSpan span)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(728, 1963, 2154);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(728, 2034, 2053);

                f_728_2034_2052(this, span);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(728, 2069, 2143);

                return f_728_2076_2142(f_728_2076_2090(), f_728_2100_2141(this, span.Start, span.Length));
                DynAbs.Tracing.TraceSender.TraceExitMethod(728, 1963, 2154);

                int
                f_728_2034_2052(Microsoft.CodeAnalysis.Text.SubText
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    this_param.CheckSubSpan(span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(728, 2034, 2052);
                    return 0;
                }


                Microsoft.CodeAnalysis.Text.SourceText
                f_728_2076_2090()
                {
                    var return_v = UnderlyingText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(728, 2076, 2090);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_728_2100_2141(Microsoft.CodeAnalysis.Text.SubText
                this_param, int
                start, int
                length)
                {
                    var return_v = this_param.GetCompositeSpan(start, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(728, 2100, 2141);
                    return return_v;
                }


                string
                f_728_2076_2142(Microsoft.CodeAnalysis.Text.SourceText
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = this_param.ToString(span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(728, 2076, 2142);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(728, 1963, 2154);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(728, 1963, 2154);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override SourceText GetSubText(TextSpan span)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(728, 2166, 2367);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(728, 2243, 2262);

                f_728_2243_2261(this, span);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(728, 2278, 2356);

                return f_728_2285_2355(f_728_2297_2311(), f_728_2313_2354(this, span.Start, span.Length));
                DynAbs.Tracing.TraceSender.TraceExitMethod(728, 2166, 2367);

                int
                f_728_2243_2261(Microsoft.CodeAnalysis.Text.SubText
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    this_param.CheckSubSpan(span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(728, 2243, 2261);
                    return 0;
                }


                Microsoft.CodeAnalysis.Text.SourceText
                f_728_2297_2311()
                {
                    var return_v = UnderlyingText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(728, 2297, 2311);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_728_2313_2354(Microsoft.CodeAnalysis.Text.SubText
                this_param, int
                start, int
                length)
                {
                    var return_v = this_param.GetCompositeSpan(start, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(728, 2313, 2354);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SubText
                f_728_2285_2355(Microsoft.CodeAnalysis.Text.SourceText
                text, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.SubText(text, span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(728, 2285, 2355);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(728, 2166, 2367);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(728, 2166, 2367);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(728, 2379, 2652);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(728, 2501, 2549);

                var
                span = f_728_2512_2548(this, sourceIndex, count)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(728, 2563, 2641);

                f_728_2563_2640(f_728_2563_2577(), span.Start, destination, destinationIndex, span.Length);
                DynAbs.Tracing.TraceSender.TraceExitMethod(728, 2379, 2652);

                Microsoft.CodeAnalysis.Text.TextSpan
                f_728_2512_2548(Microsoft.CodeAnalysis.Text.SubText
                this_param, int
                start, int
                length)
                {
                    var return_v = this_param.GetCompositeSpan(start, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(728, 2512, 2548);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceText
                f_728_2563_2577()
                {
                    var return_v = UnderlyingText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(728, 2563, 2577);
                    return return_v;
                }


                int
                f_728_2563_2640(Microsoft.CodeAnalysis.Text.SourceText
                this_param, int
                sourceIndex, char[]
                destination, int
                destinationIndex, int
                count)
                {
                    this_param.CopyTo(sourceIndex, destination, destinationIndex, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(728, 2563, 2640);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(728, 2379, 2652);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(728, 2379, 2652);
            }
        }

        private TextSpan GetCompositeSpan(int start, int length)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(728, 2664, 3010);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(728, 2745, 2828);

                int
                compositeStart = f_728_2766_2827(f_728_2775_2796(f_728_2775_2789()), f_728_2798_2812().Start + start)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(728, 2842, 2918);

                int
                compositeEnd = f_728_2861_2917(f_728_2870_2891(f_728_2870_2884()), compositeStart + length)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(728, 2932, 2999);

                return f_728_2939_2998(compositeStart, compositeEnd - compositeStart);
                DynAbs.Tracing.TraceSender.TraceExitMethod(728, 2664, 3010);

                Microsoft.CodeAnalysis.Text.SourceText
                f_728_2775_2789()
                {
                    var return_v = UnderlyingText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(728, 2775, 2789);
                    return return_v;
                }


                int
                f_728_2775_2796(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(728, 2775, 2796);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_728_2798_2812()
                {
                    var return_v = UnderlyingSpan;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(728, 2798, 2812);
                    return return_v;
                }


                int
                f_728_2766_2827(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(728, 2766, 2827);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceText
                f_728_2870_2884()
                {
                    var return_v = UnderlyingText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(728, 2870, 2884);
                    return return_v;
                }


                int
                f_728_2870_2891(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(728, 2870, 2891);
                    return return_v;
                }


                int
                f_728_2861_2917(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(728, 2861, 2917);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_728_2939_2998(int
                start, int
                length)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.TextSpan(start, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(728, 2939, 2998);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(728, 2664, 3010);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(728, 2664, 3010);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SubText()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(728, 430, 3017);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(728, 430, 3017);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(728, 430, 3017);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(728, 430, 3017);

        static Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
        f_728_575_597(Microsoft.CodeAnalysis.Text.SourceText
        this_param)
        {
            var return_v = this_param.ChecksumAlgorithm;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(728, 575, 597);
            return return_v;
        }


        static System.ArgumentNullException
        f_728_679_718(string
        paramName)
        {
            var return_v = new System.ArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(728, 679, 718);
            return return_v;
        }


        static int
        f_728_803_814(Microsoft.CodeAnalysis.Text.SourceText
        this_param)
        {
            var return_v = this_param.Length
            ;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(728, 803, 814);
            return return_v;
        }


        static int
        f_728_879_890(Microsoft.CodeAnalysis.Text.SourceText
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(728, 879, 890);
            return return_v;
        }


        static System.ArgumentOutOfRangeException
        f_728_930_975(string
        paramName)
        {
            var return_v = new System.ArgumentOutOfRangeException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(728, 930, 975);
            return return_v;
        }


        static Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
        f_728_556_597_C(Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(728, 489, 1076);
            return return_v;
        }


        Microsoft.CodeAnalysis.Text.SourceText
        f_728_1126_1140()
        {
            var return_v = UnderlyingText;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(728, 1126, 1140);
            return return_v;
        }


        System.Text.Encoding?
        f_728_1126_1149(Microsoft.CodeAnalysis.Text.SourceText
        this_param)
        {
            var return_v = this_param.Encoding;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(728, 1126, 1149);
            return return_v;
        }


        Microsoft.CodeAnalysis.Text.TextSpan
        f_728_1296_1310()
        {
            var return_v = UnderlyingSpan;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(728, 1296, 1310);
            return return_v;
        }

    }
}
