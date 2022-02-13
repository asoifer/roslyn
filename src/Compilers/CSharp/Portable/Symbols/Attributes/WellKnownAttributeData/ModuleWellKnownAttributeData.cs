// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class ModuleWellKnownAttributeData : CommonModuleWellKnownAttributeData, ISkipLocalsInitAttributeTarget
    {
        private bool _hasSkipLocalsInitAttribute;

        public bool HasSkipLocalsInitAttribute
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10409, 771, 904);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10409, 807, 836);

                    f_10409_807_835(this, expected: true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10409, 854, 889);

                    return _hasSkipLocalsInitAttribute;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10409, 771, 904);

                    int
                    f_10409_807_835(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleWellKnownAttributeData
                    this_param, bool
                    expected)
                    {
                        this_param.VerifySealed(expected: expected);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10409, 807, 835);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10409, 708, 1098);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10409, 708, 1098);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10409, 918, 1087);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10409, 954, 984);

                    f_10409_954_983(this, expected: false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10409, 1002, 1038);

                    _hasSkipLocalsInitAttribute = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10409, 1056, 1072);

                    f_10409_1056_1071(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10409, 918, 1087);

                    int
                    f_10409_954_983(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleWellKnownAttributeData
                    this_param, bool
                    expected)
                    {
                        this_param.VerifySealed(expected: expected);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10409, 954, 983);
                        return 0;
                    }


                    int
                    f_10409_1056_1071(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleWellKnownAttributeData
                    this_param)
                    {
                        this_param.SetDataStored();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10409, 1056, 1071);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10409, 708, 1098);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10409, 708, 1098);
                }
            }
        }

        public ModuleWellKnownAttributeData()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(10409, 480, 1125);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10409, 670, 697);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(10409, 480, 1125);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10409, 480, 1125);
        }


        static ModuleWellKnownAttributeData()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10409, 480, 1125);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10409, 480, 1125);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10409, 480, 1125);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10409, 480, 1125);
    }
}
