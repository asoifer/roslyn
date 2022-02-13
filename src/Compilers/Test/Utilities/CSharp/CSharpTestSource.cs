// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;

namespace Microsoft.CodeAnalysis.CSharp.Test.Utilities
{

    public readonly struct CSharpTestSource
    {

        public static CSharpTestSource None
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(21004, 732, 761);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21004, 735, 761);
                    return f_21004_735_761(null); DynAbs.Tracing.TraceSender.TraceExitMethod(21004, 732, 761);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21004, 732, 761);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21004, 732, 761);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public object Value { get; }

        private CSharpTestSource(object value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(21004, 814, 902);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21004, 877, 891);

                Value = value;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(21004, 814, 902);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21004, 814, 902);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21004, 814, 902);
            }
        }

        public SyntaxTree[] GetSyntaxTrees(CSharpParseOptions parseOptions, string sourceFileName = "")
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21004, 914, 2190);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21004, 1034, 2179);

                switch (Value)
                {

                    case string source:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21004, 1034, 2179);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21004, 1122, 1208);

                        return new[] { f_21004_1137_1205(source, filename: sourceFileName, parseOptions) };
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21004, 1034, 2179);

                    case string[] sources:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21004, 1034, 2179);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21004, 1270, 1321);

                        f_21004_1270_1320(f_21004_1283_1319(sourceFileName));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21004, 1343, 1394);

                        return f_21004_1350_1393(parseOptions, sources);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21004, 1034, 2179);

                    case SyntaxTree tree:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21004, 1034, 2179);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21004, 1455, 1490);

                        f_21004_1455_1489(parseOptions == null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21004, 1512, 1563);

                        f_21004_1512_1562(f_21004_1525_1561(sourceFileName));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21004, 1585, 1607);

                        return new[] { tree };
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21004, 1034, 2179);

                    case SyntaxTree[] trees:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21004, 1034, 2179);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21004, 1671, 1706);

                        f_21004_1671_1705(parseOptions == null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21004, 1728, 1779);

                        f_21004_1728_1778(f_21004_1741_1777(sourceFileName));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21004, 1801, 1814);

                        return trees;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21004, 1034, 2179);

                    case CSharpTestSource[] testSources:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21004, 1034, 2179);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21004, 1890, 1983);

                        return f_21004_1897_1982(f_21004_1897_1972(testSources, s => s.GetSyntaxTrees(parseOptions, sourceFileName)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21004, 1034, 2179);

                    case null:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21004, 1034, 2179);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21004, 2033, 2066);

                        return f_21004_2040_2065();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21004, 1034, 2179);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21004, 1034, 2179);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21004, 2114, 2164);

                        throw f_21004_2120_2163($"Unexpected value: {Value}");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21004, 1034, 2179);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(21004, 914, 2190);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21004, 914, 2190);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21004, 914, 2190);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static implicit operator CSharpTestSource(string source)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21004, 2266, 2297);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21004, 2269, 2297);
                return f_21004_2269_2297(source); DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21004, 2266, 2297);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21004, 2266, 2297);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21004, 2266, 2297);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static implicit operator CSharpTestSource(string[] source)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21004, 2374, 2405);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21004, 2377, 2405);
                return f_21004_2377_2405(source); DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21004, 2374, 2405);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21004, 2374, 2405);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21004, 2374, 2405);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static implicit operator CSharpTestSource(SyntaxTree source)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21004, 2484, 2515);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21004, 2487, 2515);
                return f_21004_2487_2515(source); DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21004, 2484, 2515);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21004, 2484, 2515);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21004, 2484, 2515);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static implicit operator CSharpTestSource(SyntaxTree[] source)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21004, 2596, 2627);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21004, 2599, 2627);
                return f_21004_2599_2627(source); DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21004, 2596, 2627);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21004, 2596, 2627);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21004, 2596, 2627);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static implicit operator CSharpTestSource(List<SyntaxTree> source)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21004, 2712, 2753);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21004, 2715, 2753);
                return f_21004_2715_2753(f_21004_2736_2752(source)); DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21004, 2712, 2753);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21004, 2712, 2753);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21004, 2712, 2753);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static implicit operator CSharpTestSource(ImmutableArray<SyntaxTree> source)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21004, 2848, 2889);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21004, 2851, 2889);
                return f_21004_2851_2889(source.ToArray()); DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21004, 2848, 2889);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21004, 2848, 2889);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21004, 2848, 2889);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static implicit operator CSharpTestSource(CSharpTestSource[] source)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21004, 2976, 3007);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21004, 2979, 3007);
                return f_21004_2979_3007(source); DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21004, 2976, 3007);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21004, 2976, 3007);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21004, 2976, 3007);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static CSharpTestSource()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(21004, 640, 3015);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(21004, 640, 3015);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21004, 640, 3015);
        }

        static Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource
        f_21004_735_761(object
        value)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21004, 735, 761);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxTree
        f_21004_1137_1205(string
        text, string
        filename, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
        options)
        {
            var return_v = CSharpTestBase.Parse(text, filename: filename, options);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21004, 1137, 1205);
            return return_v;
        }


        bool
        f_21004_1283_1319(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21004, 1283, 1319);
            return return_v;
        }


        int
        f_21004_1270_1320(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21004, 1270, 1320);
            return 0;
        }


        Microsoft.CodeAnalysis.SyntaxTree[]
        f_21004_1350_1393(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
        options, params string[]
        sources)
        {
            var return_v = CSharpTestBase.Parse(options, sources);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21004, 1350, 1393);
            return return_v;
        }


        int
        f_21004_1455_1489(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21004, 1455, 1489);
            return 0;
        }


        bool
        f_21004_1525_1561(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21004, 1525, 1561);
            return return_v;
        }


        int
        f_21004_1512_1562(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21004, 1512, 1562);
            return 0;
        }


        int
        f_21004_1671_1705(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21004, 1671, 1705);
            return 0;
        }


        bool
        f_21004_1741_1777(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21004, 1741, 1777);
            return return_v;
        }


        int
        f_21004_1728_1778(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21004, 1728, 1778);
            return 0;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
        f_21004_1897_1972(Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource[]
        source, System.Func<Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>>
        selector)
        {
            var return_v = source.SelectMany<Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource, Microsoft.CodeAnalysis.SyntaxTree>(selector);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21004, 1897, 1972);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxTree[]
        f_21004_1897_1982(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
        source)
        {
            var return_v = source.ToArray<Microsoft.CodeAnalysis.SyntaxTree>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21004, 1897, 1982);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxTree[]
        f_21004_2040_2065()
        {
            var return_v = Array.Empty<SyntaxTree>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21004, 2040, 2065);
            return return_v;
        }


        System.Exception
        f_21004_2120_2163(string
        message)
        {
            var return_v = new System.Exception(message);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21004, 2120, 2163);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource
        f_21004_2269_2297(string
        value)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource((object)value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21004, 2269, 2297);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource
        f_21004_2377_2405(string[]
        value)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource((object)value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21004, 2377, 2405);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource
        f_21004_2487_2515(Microsoft.CodeAnalysis.SyntaxTree
        value)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource((object)value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21004, 2487, 2515);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource
        f_21004_2599_2627(Microsoft.CodeAnalysis.SyntaxTree[]
        value)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource((object)value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21004, 2599, 2627);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxTree[]
        f_21004_2736_2752(System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxTree>
        this_param)
        {
            var return_v = this_param.ToArray();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21004, 2736, 2752);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource
        f_21004_2715_2753(Microsoft.CodeAnalysis.SyntaxTree[]
        value)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource((object)value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21004, 2715, 2753);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource
        f_21004_2851_2889(Microsoft.CodeAnalysis.SyntaxTree[]
        value)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource((object)value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21004, 2851, 2889);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource
        f_21004_2979_3007(Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource[]
        value)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource((object)value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21004, 2979, 3007);
            return return_v;
        }

    }
}
