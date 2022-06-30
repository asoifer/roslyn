// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.Text
{
    internal class SourceTextComparer : IEqualityComparer<SourceText?>
    {
        public static readonly SourceTextComparer Instance;

        public bool Equals(SourceText? x, SourceText? y)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(721, 489, 788);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(721, 562, 735) || true) && (x == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(721, 562, 735);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(721, 609, 626);

                    return y == null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(721, 562, 735);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(721, 562, 735);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(721, 660, 735) || true) && (y == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(721, 660, 735);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(721, 707, 720);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(721, 660, 735);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(721, 562, 735);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(721, 751, 777);

                return f_721_758_776(x, y);
                DynAbs.Tracing.TraceSender.TraceExitMethod(721, 489, 788);

                bool
                f_721_758_776(Microsoft.CodeAnalysis.Text.SourceText
                this_param, Microsoft.CodeAnalysis.Text.SourceText
                other)
                {
                    var return_v = this_param.ContentEquals(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(721, 758, 776);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(721, 489, 788);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(721, 489, 788);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int GetHashCode(SourceText? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(721, 800, 1347);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(721, 864, 937) || true) && (obj is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(721, 864, 937);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(721, 913, 922);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(721, 864, 937);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(721, 953, 986);

                var
                checksum = f_721_968_985(obj)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(721, 1000, 1074);

                var
                contentsHash = (DynAbs.Tracing.TraceSender.Conditional_F1(721, 1019, 1038) || ((f_721_1019_1038_M(!checksum.IsDefault) && DynAbs.Tracing.TraceSender.Conditional_F2(721, 1041, 1069)) || DynAbs.Tracing.TraceSender.Conditional_F3(721, 1072, 1073))) ? f_721_1041_1069(checksum) : 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(721, 1088, 1161);

                var
                encodingHash = (DynAbs.Tracing.TraceSender.Conditional_F1(721, 1107, 1127) || ((f_721_1107_1119(obj) != null && DynAbs.Tracing.TraceSender.Conditional_F2(721, 1130, 1156)) || DynAbs.Tracing.TraceSender.Conditional_F3(721, 1159, 1160))) ? f_721_1130_1156(f_721_1130_1142(obj)) : 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(721, 1177, 1336);

                return f_721_1184_1335(f_721_1197_1207(obj), f_721_1226_1334(contentsHash, f_721_1270_1333(encodingHash, f_721_1297_1332(f_721_1297_1318(obj)))));
                DynAbs.Tracing.TraceSender.TraceExitMethod(721, 800, 1347);

                System.Collections.Immutable.ImmutableArray<byte>
                f_721_968_985(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.GetChecksum();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(721, 968, 985);
                    return return_v;
                }


                bool
                f_721_1019_1038_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(721, 1019, 1038);
                    return return_v;
                }


                int
                f_721_1041_1069(System.Collections.Immutable.ImmutableArray<byte>
                values)
                {
                    var return_v = Hash.CombineValues(values);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(721, 1041, 1069);
                    return return_v;
                }


                System.Text.Encoding?
                f_721_1107_1119(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Encoding;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(721, 1107, 1119);
                    return return_v;
                }


                System.Text.Encoding
                f_721_1130_1142(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Encoding;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(721, 1130, 1142);
                    return return_v;
                }


                int
                f_721_1130_1156(System.Text.Encoding
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(721, 1130, 1156);
                    return return_v;
                }


                int
                f_721_1197_1207(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(721, 1197, 1207);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                f_721_1297_1318(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.ChecksumAlgorithm;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(721, 1297, 1318);
                    return return_v;
                }


                int
                f_721_1297_1332(Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(721, 1297, 1332);
                    return return_v;
                }


                int
                f_721_1270_1333(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(721, 1270, 1333);
                    return return_v;
                }


                int
                f_721_1226_1334(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(721, 1226, 1334);
                    return return_v;
                }


                int
                f_721_1184_1335(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(721, 1184, 1335);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(721, 800, 1347);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(721, 800, 1347);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SourceTextComparer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(721, 316, 1354);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(721, 316, 1354);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(721, 316, 1354);
        }


        static SourceTextComparer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(721, 316, 1354);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(721, 441, 476);
            Instance = f_721_452_476(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(721, 316, 1354);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(721, 316, 1354);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(721, 316, 1354);

        static Microsoft.CodeAnalysis.Text.SourceTextComparer
        f_721_452_476()
        {
            var return_v = new Microsoft.CodeAnalysis.Text.SourceTextComparer();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(721, 452, 476);
            return return_v;
        }

    }
}
