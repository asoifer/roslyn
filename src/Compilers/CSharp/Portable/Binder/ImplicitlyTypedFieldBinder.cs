// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Symbols;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class ImplicitlyTypedFieldBinder : Binder
    {
        private readonly ConsList<FieldSymbol> _fieldsBeingBound;

        public ImplicitlyTypedFieldBinder(Binder next, ConsList<FieldSymbol> fieldsBeingBound)
        : base(f_10343_846_850_C(next), next.Flags)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10343, 739, 936);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10343, 709, 726);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10343, 888, 925);

                _fieldsBeingBound = fieldsBeingBound;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10343, 739, 936);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10343, 739, 936);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10343, 739, 936);
            }
        }

        internal override ConsList<FieldSymbol> FieldsBeingBound
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10343, 1029, 1105);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10343, 1065, 1090);

                    return _fieldsBeingBound;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10343, 1029, 1105);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10343, 948, 1116);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10343, 948, 1116);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static ImplicitlyTypedFieldBinder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10343, 596, 1123);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10343, 596, 1123);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10343, 596, 1123);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10343, 596, 1123);

        static Microsoft.CodeAnalysis.CSharp.Binder
        f_10343_846_850_C(Microsoft.CodeAnalysis.CSharp.Binder
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10343, 739, 936);
            return return_v;
        }

    }
}
