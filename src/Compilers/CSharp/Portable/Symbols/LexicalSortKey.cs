// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Diagnostics;
using System.Threading;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{

    internal struct LexicalSortKey
    {

        private int _treeOrdinal;

        private int _position;

        public int TreeOrdinal
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10113, 856, 884);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10113, 862, 882);

                    return _treeOrdinal;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10113, 856, 884);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10113, 809, 895);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10113, 809, 895);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public int Position
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10113, 1420, 1445);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10113, 1426, 1443);

                    return _position;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10113, 1420, 1445);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10113, 1376, 1456);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10113, 1376, 1456);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static readonly LexicalSortKey NotInSource;

        public static readonly LexicalSortKey NotInitialized;

        public static LexicalSortKey GetSynthesizedMemberKey(int offset)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10113, 1862, 1956);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10113, 1865, 1956);
                return new LexicalSortKey() { _treeOrdinal = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => int.MaxValue, 10113, 1865, 1956), _position = int.MaxValue - 2 - offset }; DynAbs.Tracing.TraceSender.TraceExitMethod(10113, 1862, 1956);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10113, 1862, 1956);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10113, 1862, 1956);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static readonly LexicalSortKey SynthesizedCtor;

        public static readonly LexicalSortKey SynthesizedCCtor;

        private LexicalSortKey(int treeOrdinal, int position)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10113, 2783, 3021);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10113, 2861, 2889);

                // LAFHIS
                //f_10113_2861_2888(position >= 0);
                Debug.Assert(position >= 0);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10113, 2861, 2888);

                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10113, 2903, 2934);

                // LAFHIS
                //f_10113_2903_2933(treeOrdinal >= 0);
                Debug.Assert(treeOrdinal >= 0);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10113, 2903, 2933);

                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10113, 2948, 2975);

                _treeOrdinal = treeOrdinal;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10113, 2989, 3010);

                _position = position;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10113, 2783, 3021);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10113, 2783, 3021);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10113, 2783, 3021);
            }
        }

        private LexicalSortKey(SyntaxTree tree, int position, CSharpCompilation compilation)
        : this(f_10113_3138_3196_C((DynAbs.Tracing.TraceSender.Conditional_F1(10113, 3138, 3150) || ((tree == null && DynAbs.Tracing.TraceSender.Conditional_F2(10113, 3153, 3155)) || DynAbs.Tracing.TraceSender.Conditional_F3(10113, 3158, 3196))) ? -1 : f_10113_3158_3196(compilation, tree)), position)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10113, 3033, 3229);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10113, 3033, 3229);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10113, 3033, 3229);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10113, 3033, 3229);
            }
        }

        public LexicalSortKey(SyntaxReference syntaxRef, CSharpCompilation compilation)
        : this(f_10113_3341_3361_C(f_10113_3341_3361(syntaxRef)), syntaxRef.Span.Start, compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10113, 3241, 3419);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10113, 3241, 3419);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10113, 3241, 3419);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10113, 3241, 3419);
            }
        }

        // LAFHIS
        public LexicalSortKey(Location location, CSharpCompilation compilation)
        //: this(f_10113_3724_3755_C((SyntaxTree)f_10113_3736_3755(location)), location.SourceSpan.Start, compilation)
        : this(f_10113_3736_3755(location), location.SourceSpan.Start, compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10113, 3632, 3818);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10113, 3632, 3818);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10113, 3632, 3818);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10113, 3632, 3818);
            }
        }

        // LAFHIS
        public LexicalSortKey(CSharpSyntaxNode node, CSharpCompilation compilation)
        //: this(f_10113_4214_4229_C(f_10113_4214_4229(node)), f_10113_4231_4245(node), compilation)
        : this(f_10113_4214_4229(node), f_10113_4231_4245(node), compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10113, 4118, 4281);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10113, 4118, 4281);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10113, 4118, 4281);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10113, 4118, 4281);
            }
        }

        public LexicalSortKey(SyntaxToken token, CSharpCompilation compilation)
        : this(f_10113_4674_4702_C((SyntaxTree)token.SyntaxTree), token.SpanStart, compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10113, 4582, 4755);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10113, 4582, 4755);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10113, 4582, 4755);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10113, 4582, 4755);
            }
        }

        public static int Compare(LexicalSortKey xSortKey, LexicalSortKey ySortKey)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10113, 4875, 5556);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10113, 4975, 4990);

                int
                comparison
                = default(int);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10113, 5006, 5484) || true) && (xSortKey.TreeOrdinal != ySortKey.TreeOrdinal)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10113, 5006, 5484);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10113, 5088, 5308) || true) && (xSortKey.TreeOrdinal < 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10113, 5088, 5308);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10113, 5158, 5167);

                        return 1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10113, 5088, 5308);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10113, 5088, 5308);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10113, 5209, 5308) || true) && (ySortKey.TreeOrdinal < 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10113, 5209, 5308);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10113, 5279, 5289);

                            return -1;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10113, 5209, 5308);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10113, 5088, 5308);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10113, 5328, 5385);

                    comparison = xSortKey.TreeOrdinal - ySortKey.TreeOrdinal;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10113, 5403, 5433);

                    f_10113_5403_5432(comparison != 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10113, 5451, 5469);

                    return comparison;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10113, 5006, 5484);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10113, 5500, 5545);

                return xSortKey.Position - ySortKey.Position;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10113, 4875, 5556);

                int
                f_10113_5403_5432(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10113, 5403, 5432);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10113, 4875, 5556);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10113, 4875, 5556);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static LexicalSortKey First(LexicalSortKey xSortKey, LexicalSortKey ySortKey)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10113, 5568, 5791);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10113, 5677, 5722);

                int
                comparison = Compare(xSortKey, ySortKey)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10113, 5736, 5780);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10113, 5743, 5757) || ((comparison > 0 && DynAbs.Tracing.TraceSender.Conditional_F2(10113, 5760, 5768)) || DynAbs.Tracing.TraceSender.Conditional_F3(10113, 5771, 5779))) ? ySortKey : xSortKey;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10113, 5568, 5791);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10113, 5568, 5791);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10113, 5568, 5791);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool IsInitialized
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10113, 5853, 5945);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10113, 5889, 5930);

                    return f_10113_5896_5924(ref _position) >= 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10113, 5853, 5945);

                    int
                    f_10113_5896_5924(ref int
                    location)
                    {
                        var return_v = Volatile.Read(ref location);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10113, 5896, 5924);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10113, 5803, 5956);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10113, 5803, 5956);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public void SetFrom(LexicalSortKey other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10113, 5968, 6188);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10113, 6034, 6068);

                f_10113_6034_6067(other.IsInitialized);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10113, 6082, 6116);

                _treeOrdinal = other._treeOrdinal;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10113, 6130, 6177);

                f_10113_6130_6176(ref _position, other._position);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10113, 5968, 6188);

                int
                f_10113_6034_6067(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10113, 6034, 6067);
                    return 0;
                }


                int
                f_10113_6130_6176(ref int
                location, int
                value)
                {
                    Volatile.Write(ref location, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10113, 6130, 6176);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10113, 5968, 6188);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10113, 5968, 6188);
            }
        }
        static LexicalSortKey()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10113, 624, 6195);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10113, 1506, 1577);
            NotInSource = new LexicalSortKey() { _treeOrdinal = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => -1, 10113, 1520, 1577), _position = 0 }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10113, 1628, 1703);
            NotInitialized = new LexicalSortKey() { _treeOrdinal = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => -1, 10113, 1645, 1703), _position = -1 }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10113, 2524, 2624);
            SynthesizedCtor = new LexicalSortKey() { _treeOrdinal = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => int.MaxValue, 10113, 2542, 2624), _position = int.MaxValue - 1 }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10113, 2673, 2770);
            SynthesizedCCtor = new LexicalSortKey() { _treeOrdinal = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => int.MaxValue, 10113, 2692, 2770), _position = int.MaxValue }; DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10113, 624, 6195);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10113, 624, 6195);
        }

        int
        f_10113_2861_2888(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10113, 2861, 2888);
            return 0;
        }


        int
        f_10113_2903_2933(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10113, 2903, 2933);
            return 0;
        }


        static int
        f_10113_3158_3196(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param, Microsoft.CodeAnalysis.SyntaxTree
        tree)
        {
            var return_v = this_param.GetSyntaxTreeOrdinal(tree);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10113, 3158, 3196);
            return return_v;
        }


        static int
        f_10113_3138_3196_C(int
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10113, 3033, 3229);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxTree
        f_10113_3341_3361(Microsoft.CodeAnalysis.SyntaxReference
        this_param)
        {
            var return_v = this_param.SyntaxTree;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10113, 3341, 3361);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxTree
        f_10113_3341_3361_C(Microsoft.CodeAnalysis.SyntaxTree
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10113, 3241, 3419);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxTree?
        f_10113_3736_3755(Microsoft.CodeAnalysis.Location
        this_param)
        {
            // LAFHIS
            DynAbs.Tracing.TraceSender.TraceBaseCall(10113, 3632, 3818);

            var return_v = this_param.SourceTree;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10113, 3736, 3755);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxTree?
        f_10113_3724_3755_C(Microsoft.CodeAnalysis.SyntaxTree?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10113, 3632, 3818);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxTree
        f_10113_4214_4229(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
        this_param)
        {
            // LAFHIS
            DynAbs.Tracing.TraceSender.TraceBaseCall(10113, 4118, 4281);

            var return_v = this_param.SyntaxTree;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10113, 4214, 4229);
            return return_v;
        }


        static int
        f_10113_4231_4245(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
        this_param)
        {
            var return_v = this_param.SpanStart;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10113, 4231, 4245);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxTree
        f_10113_4214_4229_C(Microsoft.CodeAnalysis.SyntaxTree
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10113, 4118, 4281);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxTree?
        f_10113_4674_4702_C(Microsoft.CodeAnalysis.SyntaxTree?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10113, 4582, 4755);
            return return_v;
        }

    }
}
