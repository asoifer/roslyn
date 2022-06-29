// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.Diagnostics
{

    internal readonly struct SourceOrAdditionalFile
            : IEquatable<SourceOrAdditionalFile>
    {

        public SyntaxTree? SourceTree { get; }

        public AdditionalText? AdditionalFile { get; }

        public SourceOrAdditionalFile(SyntaxTree tree)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(267, 831, 967);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(267, 902, 920);

                SourceTree = tree;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(267, 934, 956);

                AdditionalFile = null;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(267, 831, 967);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(267, 831, 967);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(267, 831, 967);
            }
        }

        public SourceOrAdditionalFile(AdditionalText file)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(267, 979, 1119);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(267, 1054, 1076);

                AdditionalFile = file;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(267, 1090, 1108);

                SourceTree = null;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(267, 979, 1119);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(267, 979, 1119);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(267, 979, 1119);
            }
        }

        public override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(267, 1185, 1238);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(267, 1188, 1238);
                return obj is SourceOrAdditionalFile file && (DynAbs.Tracing.TraceSender.Expression_True(267, 1188, 1238) && Equals(file)); DynAbs.Tracing.TraceSender.TraceExitMethod(267, 1185, 1238);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(267, 1185, 1238);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(267, 1185, 1238);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool Equals(SourceOrAdditionalFile other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(267, 1313, 1388);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(267, 1316, 1388);
                return SourceTree == other.SourceTree && (DynAbs.Tracing.TraceSender.Expression_True(267, 1316, 1388) && AdditionalFile == other.AdditionalFile); DynAbs.Tracing.TraceSender.TraceExitMethod(267, 1313, 1388);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(267, 1313, 1388);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(267, 1313, 1388);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool operator ==(SourceOrAdditionalFile left, SourceOrAdditionalFile right)
            => f_267_1507_1526(left, right);

        public static bool operator !=(SourceOrAdditionalFile left, SourceOrAdditionalFile right)
            => !f_267_1646_1665(left, right);

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(267, 1678, 2054);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(267, 1736, 2043) || true) && (SourceTree != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(267, 1736, 2043);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(267, 1792, 1844);

                    return f_267_1799_1843(true, f_267_1818_1842(SourceTree));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(267, 1736, 2043);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(267, 1736, 2043);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(267, 1910, 1953);

                    f_267_1910_1952(AdditionalFile != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(267, 1971, 2028);

                    return f_267_1978_2027(false, f_267_1998_2026(AdditionalFile));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(267, 1736, 2043);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(267, 1678, 2054);

                int
                f_267_1818_1842(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(267, 1818, 1842);
                    return return_v;
                }


                int
                f_267_1799_1843(bool
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(267, 1799, 1843);
                    return return_v;
                }


                int
                f_267_1910_1952(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(267, 1910, 1952);
                    return 0;
                }


                int
                f_267_1998_2026(Microsoft.CodeAnalysis.AdditionalText
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(267, 1998, 2026);
                    return return_v;
                }


                int
                f_267_1978_2027(bool
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(267, 1978, 2027);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(267, 1678, 2054);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(267, 1678, 2054);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static SourceOrAdditionalFile()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(267, 615, 2061);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(267, 615, 2061);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(267, 615, 2061);
        }

        static bool
        f_267_1507_1526(Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile
        objA, Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile
        objB)
        {
            var return_v = Equals((object)objA, (object)objB);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(267, 1507, 1526);
            return return_v;
        }


        static bool
        f_267_1646_1665(Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile
        objA, Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile
        objB)
        {
            var return_v = Equals((object)objA, (object)objB);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(267, 1646, 1665);
            return return_v;
        }

    }
}
