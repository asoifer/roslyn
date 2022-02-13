
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class MethodEarlyWellKnownAttributeData : CommonMethodEarlyWellKnownAttributeData
    {
        private bool _unmanagedCallersOnlyAttributePresent;

        public bool UnmanagedCallersOnlyAttributePresent
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10407, 635, 778);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10407, 671, 700);

                    f_10407_671_699(this, expected: true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10407, 718, 763);

                    return _unmanagedCallersOnlyAttributePresent;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10407, 635, 778);

                    int
                    f_10407_671_699(Microsoft.CodeAnalysis.CSharp.Symbols.MethodEarlyWellKnownAttributeData
                    this_param, bool
                    expected)
                    {
                        this_param.VerifySealed(expected: expected);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10407, 671, 699);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10407, 562, 982);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10407, 562, 982);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10407, 792, 971);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10407, 828, 858);

                    f_10407_828_857(this, expected: false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10407, 876, 922);

                    _unmanagedCallersOnlyAttributePresent = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10407, 940, 956);

                    f_10407_940_955(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10407, 792, 971);

                    int
                    f_10407_828_857(Microsoft.CodeAnalysis.CSharp.Symbols.MethodEarlyWellKnownAttributeData
                    this_param, bool
                    expected)
                    {
                        this_param.VerifySealed(expected: expected);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10407, 828, 857);
                        return 0;
                    }


                    int
                    f_10407_940_955(Microsoft.CodeAnalysis.CSharp.Symbols.MethodEarlyWellKnownAttributeData
                    this_param)
                    {
                        this_param.SetDataStored();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10407, 940, 955);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10407, 562, 982);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10407, 562, 982);
                }
            }
        }

        public MethodEarlyWellKnownAttributeData()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(10407, 387, 989);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10407, 514, 551);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(10407, 387, 989);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10407, 387, 989);
        }


        static MethodEarlyWellKnownAttributeData()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10407, 387, 989);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10407, 387, 989);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10407, 387, 989);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10407, 387, 989);
    }
}
