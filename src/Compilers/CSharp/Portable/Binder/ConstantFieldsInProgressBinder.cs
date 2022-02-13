// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class ConstantFieldsInProgressBinder : Binder
    {
        private readonly ConstantFieldsInProgress _inProgress;

        internal ConstantFieldsInProgressBinder(ConstantFieldsInProgress inProgress, Binder next)
        : base(f_10328_789_793_C(next), BinderFlags.FieldInitializer | next.Flags)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10328, 679, 898);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10328, 655, 666);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10328, 862, 887);

                _inProgress = inProgress;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10328, 679, 898);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10328, 679, 898);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10328, 679, 898);
            }
        }

        internal override ConstantFieldsInProgress ConstantFieldsInProgress
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10328, 1002, 1072);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10328, 1038, 1057);

                    return _inProgress;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10328, 1002, 1072);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10328, 910, 1083);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10328, 910, 1083);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static ConstantFieldsInProgressBinder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10328, 535, 1090);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10328, 535, 1090);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10328, 535, 1090);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10328, 535, 1090);

        static Microsoft.CodeAnalysis.CSharp.Binder
        f_10328_789_793_C(Microsoft.CodeAnalysis.CSharp.Binder
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10328, 679, 898);
            return return_v;
        }

    }
}
