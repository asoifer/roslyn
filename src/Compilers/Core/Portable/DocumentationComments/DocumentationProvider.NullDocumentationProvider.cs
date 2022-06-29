// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Microsoft.CodeAnalysis
{
    public partial class DocumentationProvider
    {
        private class NullDocumentationProvider : DocumentationProvider
        {
            protected internal override string GetDocumentationForSymbol(string documentationMemberID, CultureInfo preferredCulture, CancellationToken cancellationToken = default(CancellationToken))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(280, 619, 863);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(280, 838, 848);

                    return "";
                    DynAbs.Tracing.TraceSender.TraceExitMethod(280, 619, 863);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(280, 619, 863);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(280, 619, 863);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override bool Equals(object? obj)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(280, 879, 1085);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(280, 1043, 1070);

                    return (object)this == obj;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(280, 879, 1085);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(280, 879, 1085);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(280, 879, 1085);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override int GetHashCode()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(280, 1101, 1222);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(280, 1167, 1207);

                    return f_280_1174_1206(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(280, 1101, 1222);

                    int
                    f_280_1174_1206(Microsoft.CodeAnalysis.DocumentationProvider.NullDocumentationProvider
                    o)
                    {
                        var return_v = RuntimeHelpers.GetHashCode((object)o);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(280, 1174, 1206);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(280, 1101, 1222);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(280, 1101, 1222);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public NullDocumentationProvider()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(280, 531, 1233);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(280, 531, 1233);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(280, 531, 1233);
            }


            static NullDocumentationProvider()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(280, 531, 1233);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(280, 531, 1233);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(280, 531, 1233);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(280, 531, 1233);
        }
    }
}
