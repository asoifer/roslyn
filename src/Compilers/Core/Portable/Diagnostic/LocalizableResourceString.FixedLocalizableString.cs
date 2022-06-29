// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    public abstract partial class LocalizableString
    {
        private sealed class FixedLocalizableString : LocalizableString
        {
            private static readonly FixedLocalizableString s_empty;

            private readonly string _fixedString;

            public static FixedLocalizableString Create(string? fixedResource)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(192, 735, 1039);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(192, 834, 955) || true) && (f_192_838_879(fixedResource))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(192, 834, 955);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(192, 921, 936);

                        return s_empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(192, 834, 955);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(192, 975, 1024);

                    return f_192_982_1023(fixedResource);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(192, 735, 1039);

                    bool
                    f_192_838_879(string?
                    value)
                    {
                        var return_v = RoslynString.IsNullOrEmpty(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(192, 838, 879);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.LocalizableString.FixedLocalizableString
                    f_192_982_1023(string
                    fixedResource)
                    {
                        var return_v = new Microsoft.CodeAnalysis.LocalizableString.FixedLocalizableString(fixedResource);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(192, 982, 1023);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(192, 735, 1039);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(192, 735, 1039);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private FixedLocalizableString(string fixedResource)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(192, 1055, 1184);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(192, 706, 718);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(192, 1140, 1169);

                    _fixedString = fixedResource;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(192, 1055, 1184);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(192, 1055, 1184);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(192, 1055, 1184);
                }
            }

            protected override string GetText(IFormatProvider? formatProvider)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(192, 1200, 1334);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(192, 1299, 1319);

                    return _fixedString;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(192, 1200, 1334);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(192, 1200, 1334);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(192, 1200, 1334);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            protected override bool AreEqual(object? other)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(192, 1350, 1588);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(192, 1430, 1477);

                    var
                    fixedStr = other as FixedLocalizableString
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(192, 1495, 1573);

                    return fixedStr != null && (DynAbs.Tracing.TraceSender.Expression_True(192, 1502, 1572) && f_192_1522_1572(_fixedString, fixedStr._fixedString));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(192, 1350, 1588);

                    bool
                    f_192_1522_1572(string
                    a, string
                    b)
                    {
                        var return_v = string.Equals(a, b);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(192, 1522, 1572);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(192, 1350, 1588);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(192, 1350, 1588);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            protected override int GetHash()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(192, 1604, 1724);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(192, 1669, 1709);

                    return f_192_1676_1703_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_fixedString, 192, 1676, 1703)?.GetHashCode()) ?? (DynAbs.Tracing.TraceSender.Expression_Null<int?>(192, 1676, 1708) ?? 0);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(192, 1604, 1724);

                    int?
                    f_192_1676_1703_I(int?
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(192, 1676, 1703);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(192, 1604, 1724);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(192, 1604, 1724);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override bool CanThrowExceptions
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(192, 1782, 1790);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(192, 1785, 1790);
                        return false; DynAbs.Tracing.TraceSender.TraceExitMethod(192, 1782, 1790);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(192, 1782, 1790);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(192, 1782, 1790);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static FixedLocalizableString()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(192, 355, 1802);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(192, 615, 665);
                s_empty = f_192_625_665(string.Empty); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(192, 355, 1802);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(192, 355, 1802);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(192, 355, 1802);

            static Microsoft.CodeAnalysis.LocalizableString.FixedLocalizableString
            f_192_625_665(string
            fixedResource)
            {
                var return_v = new Microsoft.CodeAnalysis.LocalizableString.FixedLocalizableString(fixedResource);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(192, 625, 665);
                return return_v;
            }

        }

        public LocalizableString()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(192, 291, 1809);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(192, 291, 1809);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(192, 291, 1809);
        }


        static LocalizableString()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(192, 291, 1809);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(192, 291, 1809);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(192, 291, 1809);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(192, 291, 1809);
    }
}
