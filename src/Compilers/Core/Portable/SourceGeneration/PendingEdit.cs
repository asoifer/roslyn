// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Text;
namespace Microsoft.CodeAnalysis
{
    internal delegate bool EditCallback<T>(GeneratorEditContext context, T edit) where T : PendingEdit;
    internal abstract class PendingEdit
    {
        internal abstract GeneratorDriverState Commit(GeneratorDriverState state);

        internal abstract bool AcceptedBy(GeneratorInfo info);

        internal abstract bool TryApply(GeneratorInfo info, GeneratorEditContext context);

        public PendingEdit()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(557, 634, 927);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(557, 634, 927);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(557, 634, 927);
        }


        static PendingEdit()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(557, 634, 927);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(557, 634, 927);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(557, 634, 927);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(557, 634, 927);
    }
    internal abstract class AdditionalFileEdit : PendingEdit
    {
        public AdditionalFileEdit()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(557, 935, 1005);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(557, 935, 1005);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(557, 935, 1005);
        }


        static AdditionalFileEdit()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(557, 935, 1005);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(557, 935, 1005);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(557, 935, 1005);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(557, 935, 1005);
    }
    internal sealed class AdditionalFileAddedEdit : AdditionalFileEdit
    {
        public AdditionalFileAddedEdit(AdditionalText addedText)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(557, 1096, 1210);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(557, 1222, 1262);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(557, 1177, 1199);

                AddedText = addedText;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(557, 1096, 1210);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(557, 1096, 1210);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(557, 1096, 1210);
            }
        }

        public AdditionalText AddedText { get; }

        internal override GeneratorDriverState Commit(GeneratorDriverState state)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(557, 1348, 1421);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(557, 1351, 1421);
                return state.With(additionalTexts: state.AdditionalTexts.Add(f_557_1405_1419(this))); DynAbs.Tracing.TraceSender.TraceExitMethod(557, 1348, 1421);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(557, 1348, 1421);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(557, 1348, 1421);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.AdditionalText
            f_557_1405_1419(Microsoft.CodeAnalysis.AdditionalFileAddedEdit
            this_param)
            {
                var return_v = this_param.AddedText;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(557, 1405, 1419);
                return return_v;
            }

        }

        internal override bool AcceptedBy(GeneratorInfo info)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(557, 1488, 1518);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(557, 1491, 1518);
                return info.EditCallback is object; DynAbs.Tracing.TraceSender.TraceExitMethod(557, 1488, 1518);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(557, 1488, 1518);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(557, 1488, 1518);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool TryApply(GeneratorInfo info, GeneratorEditContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(557, 1613, 1656);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(557, 1616, 1656);
                return f_557_1616_1656(info.EditCallback!, context, this); 
                DynAbs.Tracing.TraceSender.TraceExitMethod(557, 1613, 1656);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(557, 1613, 1656);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(557, 1613, 1656);
            }
            throw new System.Exception("Slicer error: unreachable code");

            bool
            f_557_1616_1656(EditCallback<AdditionalFileEdit>
            this_param, Microsoft.CodeAnalysis.GeneratorEditContext
            context, Microsoft.CodeAnalysis.AdditionalFileAddedEdit
            edit)
            {
                var return_v = this_param.Invoke(context, (Microsoft.CodeAnalysis.AdditionalFileEdit)edit);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(557, 1616, 1656);
                return return_v;
            }

        }

        static AdditionalFileAddedEdit()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(557, 1013, 1664);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(557, 1013, 1664);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(557, 1013, 1664);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(557, 1013, 1664);
    }
}
