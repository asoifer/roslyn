// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class BoundLocalFunctionStatement
    {
        public BoundBlock? Body
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10559, 425, 455);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10559, 428, 455);
                    return f_10559_428_437() ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.BoundBlock?>(10559, 428, 455) ?? f_10559_441_455()); DynAbs.Tracing.TraceSender.TraceExitMethod(10559, 425, 455);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10559, 395, 458);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10559, 395, 458);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static BoundLocalFunctionStatement()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10559, 328, 465);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10559, 328, 465);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10559, 328, 465);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10559, 328, 465);

        Microsoft.CodeAnalysis.CSharp.BoundBlock?
        f_10559_428_437()
        {
            var return_v = BlockBody;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10559, 428, 437);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.BoundBlock?
        f_10559_441_455()
        {
            var return_v = ExpressionBody;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10559, 441, 455);
            return return_v;
        }

    }
}
