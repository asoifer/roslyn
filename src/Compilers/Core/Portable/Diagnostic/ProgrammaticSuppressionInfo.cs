// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Immutable;

namespace Microsoft.CodeAnalysis.Diagnostics
{
    internal sealed class ProgrammaticSuppressionInfo : IEquatable<ProgrammaticSuppressionInfo?>
    {
        public ImmutableHashSet<(string Id, LocalizableString Justification)> Suppressions { get; }

        internal ProgrammaticSuppressionInfo(ImmutableHashSet<(string Id, LocalizableString Justification)> suppressions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(198, 705, 882);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(198, 602, 693);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(198, 843, 871);

                Suppressions = suppressions;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(198, 705, 882);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(198, 705, 882);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(198, 705, 882);
            }
        }

        public bool Equals(ProgrammaticSuppressionInfo? other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(198, 894, 1182);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(198, 973, 1066) || true) && (f_198_977_1005(this, other))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(198, 973, 1066);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(198, 1039, 1051);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(198, 973, 1066);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(198, 1082, 1171);

                return other != null && (DynAbs.Tracing.TraceSender.Expression_True(198, 1089, 1170) && f_198_1123_1170(f_198_1123_1140(this), f_198_1151_1169(other)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(198, 894, 1182);

                bool
                f_198_977_1005(Microsoft.CodeAnalysis.Diagnostics.ProgrammaticSuppressionInfo
                objA, Microsoft.CodeAnalysis.Diagnostics.ProgrammaticSuppressionInfo?
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object?)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(198, 977, 1005);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableHashSet<(string Id, Microsoft.CodeAnalysis.LocalizableString Justification)>
                f_198_1123_1140(Microsoft.CodeAnalysis.Diagnostics.ProgrammaticSuppressionInfo
                this_param)
                {
                    var return_v = this_param.Suppressions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(198, 1123, 1140);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableHashSet<(string Id, Microsoft.CodeAnalysis.LocalizableString Justification)>
                f_198_1151_1169(Microsoft.CodeAnalysis.Diagnostics.ProgrammaticSuppressionInfo
                this_param)
                {
                    var return_v = this_param.Suppressions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(198, 1151, 1169);
                    return return_v;
                }


                bool
                f_198_1123_1170(System.Collections.Immutable.ImmutableHashSet<(string Id, Microsoft.CodeAnalysis.LocalizableString Justification)>
                this_param, System.Collections.Immutable.ImmutableHashSet<(string Id, Microsoft.CodeAnalysis.LocalizableString Justification)>
                other)
                {
                    var return_v = this_param.SetEquals((System.Collections.Generic.IEnumerable<(string Id, Microsoft.CodeAnalysis.LocalizableString Justification)>)other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(198, 1123, 1170);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(198, 894, 1182);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(198, 894, 1182);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(198, 1194, 1320);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(198, 1259, 1309);

                return f_198_1266_1308(this, obj as ProgrammaticSuppressionInfo);
                DynAbs.Tracing.TraceSender.TraceExitMethod(198, 1194, 1320);

                bool
                f_198_1266_1308(Microsoft.CodeAnalysis.Diagnostics.ProgrammaticSuppressionInfo
                this_param, object?
                other)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.Diagnostics.ProgrammaticSuppressionInfo?)other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(198, 1266, 1308);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(198, 1194, 1320);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(198, 1194, 1320);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(198, 1332, 1427);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(198, 1390, 1416);

                return f_198_1397_1415(f_198_1397_1409());
                DynAbs.Tracing.TraceSender.TraceExitMethod(198, 1332, 1427);

                System.Collections.Immutable.ImmutableHashSet<(string Id, Microsoft.CodeAnalysis.LocalizableString Justification)>
                f_198_1397_1409()
                {
                    var return_v = Suppressions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(198, 1397, 1409);
                    return return_v;
                }


                int
                f_198_1397_1415(System.Collections.Immutable.ImmutableHashSet<(string Id, Microsoft.CodeAnalysis.LocalizableString Justification)>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(198, 1397, 1415);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(198, 1332, 1427);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(198, 1332, 1427);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ProgrammaticSuppressionInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(198, 493, 1434);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(198, 493, 1434);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(198, 493, 1434);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(198, 493, 1434);
    }
}
