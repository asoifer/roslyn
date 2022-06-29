// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    internal sealed class SourceLocation : Location, IEquatable<SourceLocation?>
    {
        private readonly SyntaxTree _syntaxTree;

        private readonly TextSpan _span;

        public SourceLocation(SyntaxTree syntaxTree, TextSpan span)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(201, 624, 771);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(201, 558, 569);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(201, 708, 733);

                _syntaxTree = syntaxTree;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(201, 747, 760);

                _span = span;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(201, 624, 771);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(201, 624, 771);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(201, 624, 771);
            }
        }

        public SourceLocation(SyntaxNode node)
        : this(f_201_842_857_C(f_201_842_857(node)), f_201_859_868(node))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(201, 783, 891);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(201, 783, 891);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(201, 783, 891);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(201, 783, 891);
            }
        }

        public SourceLocation(in SyntaxToken token)
        : this(f_201_967_984_C(token.SyntaxTree!), token.Span)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(201, 903, 1019);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(201, 903, 1019);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(201, 903, 1019);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(201, 903, 1019);
            }
        }

        public SourceLocation(in SyntaxNodeOrToken nodeOrToken)
        : this(f_201_1107_1130_C(nodeOrToken.SyntaxTree!), nodeOrToken.Span)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(201, 1031, 1232);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(201, 1174, 1221);

                f_201_1174_1220(nodeOrToken.SyntaxTree is object);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(201, 1031, 1232);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(201, 1031, 1232);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(201, 1031, 1232);
            }
        }

        public SourceLocation(in SyntaxTrivia trivia)
        : this(f_201_1310_1328_C(trivia.SyntaxTree!), trivia.Span)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(201, 1244, 1420);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(201, 1367, 1409);

                f_201_1367_1408(trivia.SyntaxTree is object);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(201, 1244, 1420);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(201, 1244, 1420);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(201, 1244, 1420);
            }
        }

        public SourceLocation(SyntaxReference syntaxRef)
        : this(f_201_1501_1521_C(f_201_1501_1521(syntaxRef)), f_201_1523_1537(syntaxRef))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(201, 1432, 1836);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(201, 1432, 1836);
                // If we're using a syntaxref, we don't have a node in hand, so we couldn't get equality
                // on syntax node, so associatedNodeOpt shouldn't be set. We never use this constructor
                // when binding executable code anywhere, so it has no use.
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(201, 1432, 1836);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(201, 1432, 1836);
            }
        }

        public override LocationKind Kind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(201, 1906, 1988);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(201, 1942, 1973);

                    return LocationKind.SourceFile;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(201, 1906, 1988);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(201, 1848, 1999);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(201, 1848, 1999);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override TextSpan SourceSpan
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(201, 2071, 2135);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(201, 2107, 2120);

                    return _span;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(201, 2071, 2135);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(201, 2011, 2146);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(201, 2011, 2146);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override SyntaxTree SourceTree
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(201, 2220, 2290);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(201, 2256, 2275);

                    return _syntaxTree;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(201, 2220, 2290);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(201, 2158, 2301);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(201, 2158, 2301);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override FileLinePositionSpan GetLineSpan()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(201, 2313, 2801);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(201, 2524, 2736) || true) && (_syntaxTree == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(201, 2524, 2736);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(201, 2581, 2641);

                    FileLinePositionSpan
                    result = default(FileLinePositionSpan)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(201, 2659, 2689);

                    f_201_2659_2688(f_201_2672_2687_M(!result.IsValid));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(201, 2707, 2721);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(201, 2524, 2736);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(201, 2752, 2790);

                return f_201_2759_2789(_syntaxTree, _span);
                DynAbs.Tracing.TraceSender.TraceExitMethod(201, 2313, 2801);

                bool
                f_201_2672_2687_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(201, 2672, 2687);
                    return return_v;
                }


                int
                f_201_2659_2688(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(201, 2659, 2688);
                    return 0;
                }


                Microsoft.CodeAnalysis.FileLinePositionSpan
                f_201_2759_2789(Microsoft.CodeAnalysis.SyntaxTree
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = this_param.GetLineSpan(span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(201, 2759, 2789);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(201, 2313, 2801);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(201, 2313, 2801);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override FileLinePositionSpan GetMappedLineSpan()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(201, 2813, 3313);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(201, 3030, 3242) || true) && (_syntaxTree == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(201, 3030, 3242);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(201, 3087, 3147);

                    FileLinePositionSpan
                    result = default(FileLinePositionSpan)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(201, 3165, 3195);

                    f_201_3165_3194(f_201_3178_3193_M(!result.IsValid));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(201, 3213, 3227);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(201, 3030, 3242);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(201, 3258, 3302);

                return f_201_3265_3301(_syntaxTree, _span);
                DynAbs.Tracing.TraceSender.TraceExitMethod(201, 2813, 3313);

                bool
                f_201_3178_3193_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(201, 3178, 3193);
                    return return_v;
                }


                int
                f_201_3165_3194(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(201, 3165, 3194);
                    return 0;
                }


                Microsoft.CodeAnalysis.FileLinePositionSpan
                f_201_3265_3301(Microsoft.CodeAnalysis.SyntaxTree
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = this_param.GetMappedLineSpan(span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(201, 3265, 3301);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(201, 2813, 3313);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(201, 2813, 3313);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool Equals(SourceLocation? other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(201, 3325, 3592);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(201, 3391, 3484) || true) && (f_201_3395_3423(this, other))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(201, 3391, 3484);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(201, 3457, 3469);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(201, 3391, 3484);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(201, 3500, 3581);

                return other != null && (DynAbs.Tracing.TraceSender.Expression_True(201, 3507, 3556) && other._syntaxTree == _syntaxTree) && (DynAbs.Tracing.TraceSender.Expression_True(201, 3507, 3580) && other._span == _span);
                DynAbs.Tracing.TraceSender.TraceExitMethod(201, 3325, 3592);

                bool
                f_201_3395_3423(Microsoft.CodeAnalysis.SourceLocation
                objA, Microsoft.CodeAnalysis.SourceLocation?
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object?)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(201, 3395, 3423);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(201, 3325, 3592);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(201, 3325, 3592);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(201, 3604, 3722);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(201, 3669, 3711);

                return f_201_3676_3710(this, obj as SourceLocation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(201, 3604, 3722);

                bool
                f_201_3676_3710(Microsoft.CodeAnalysis.SourceLocation
                this_param, object?
                other)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.SourceLocation?)other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(201, 3676, 3710);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(201, 3604, 3722);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(201, 3604, 3722);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(201, 3734, 3857);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(201, 3792, 3846);

                return f_201_3799_3845(_syntaxTree, _span.GetHashCode());
                DynAbs.Tracing.TraceSender.TraceExitMethod(201, 3734, 3857);

                int
                f_201_3799_3845(Microsoft.CodeAnalysis.SyntaxTree
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(201, 3799, 3845);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(201, 3734, 3857);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(201, 3734, 3857);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override string GetDebuggerDisplay()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(201, 3869, 4060);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(201, 3940, 4049);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetDebuggerDisplay(), 201, 3947, 3972) + "\"" + f_201_3982_4041(f_201_3982_4004(_syntaxTree), _span.Start, _span.Length) + "\"";
                DynAbs.Tracing.TraceSender.TraceExitMethod(201, 3869, 4060);

                string
                f_201_3982_4004(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(201, 3982, 4004);
                    return return_v;
                }


                string
                f_201_3982_4041(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(201, 3982, 4041);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(201, 3869, 4060);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(201, 3869, 4060);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SourceLocation()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(201, 437, 4067);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(201, 437, 4067);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(201, 437, 4067);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(201, 437, 4067);

        static Microsoft.CodeAnalysis.SyntaxTree
        f_201_842_857(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.SyntaxTree;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(201, 842, 857);
            return return_v;
        }


        static Microsoft.CodeAnalysis.Text.TextSpan
        f_201_859_868(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.Span;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(201, 859, 868);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxTree
        f_201_842_857_C(Microsoft.CodeAnalysis.SyntaxTree
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(201, 783, 891);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxTree
        f_201_967_984_C(Microsoft.CodeAnalysis.SyntaxTree
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(201, 903, 1019);
            return return_v;
        }


        static int
        f_201_1174_1220(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(201, 1174, 1220);
            return 0;
        }


        static Microsoft.CodeAnalysis.SyntaxTree
        f_201_1107_1130_C(Microsoft.CodeAnalysis.SyntaxTree
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(201, 1031, 1232);
            return return_v;
        }


        static int
        f_201_1367_1408(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(201, 1367, 1408);
            return 0;
        }


        static Microsoft.CodeAnalysis.SyntaxTree
        f_201_1310_1328_C(Microsoft.CodeAnalysis.SyntaxTree
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(201, 1244, 1420);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxTree
        f_201_1501_1521(Microsoft.CodeAnalysis.SyntaxReference
        this_param)
        {
            var return_v = this_param.SyntaxTree;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(201, 1501, 1521);
            return return_v;
        }


        static Microsoft.CodeAnalysis.Text.TextSpan
        f_201_1523_1537(Microsoft.CodeAnalysis.SyntaxReference
        this_param)
        {
            var return_v = this_param.Span;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(201, 1523, 1537);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxTree
        f_201_1501_1521_C(Microsoft.CodeAnalysis.SyntaxTree
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(201, 1432, 1836);
            return return_v;
        }

    }
}
