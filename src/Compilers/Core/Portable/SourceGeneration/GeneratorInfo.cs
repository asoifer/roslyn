// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;

namespace Microsoft.CodeAnalysis
{

    internal readonly struct GeneratorInfo
    {

        internal EditCallback<AdditionalFileEdit>? EditCallback { get; }

        internal SyntaxContextReceiverCreator? SyntaxContextReceiverCreator { get; }

        internal Action<GeneratorPostInitializationContext>? PostInitCallback { get; }

        internal bool Initialized { get; }

        internal GeneratorInfo(EditCallback<AdditionalFileEdit>? editCallback, SyntaxContextReceiverCreator? receiverCreator, Action<GeneratorPostInitializationContext>? postInitCallback)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(552, 621, 1008);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(552, 825, 853);

                EditCallback = editCallback;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(552, 867, 914);

                SyntaxContextReceiverCreator = receiverCreator;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(552, 928, 964);

                PostInitCallback = postInitCallback;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(552, 978, 997);

                Initialized = true;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(552, 621, 1008);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(552, 621, 1008);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(552, 621, 1008);
            }
        }
        internal class Builder
        {
            internal EditCallback<AdditionalFileEdit>? EditCallback { get; set; }

            internal SyntaxContextReceiverCreator? SyntaxContextReceiverCreator { get; set; }

            internal Action<GeneratorPostInitializationContext>? PostInitCallback { get; set; }

            public GeneratorInfo ToImmutable()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(552, 1383, 1465);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(552, 1386, 1465);
                    return f_552_1386_1465(f_552_1404_1416(), f_552_1418_1446(), f_552_1448_1464()); DynAbs.Tracing.TraceSender.TraceExitMethod(552, 1383, 1465);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(552, 1383, 1465);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(552, 1383, 1465);
                }
                throw new System.Exception("Slicer error: unreachable code");

                Microsoft.CodeAnalysis.EditCallback<Microsoft.CodeAnalysis.AdditionalFileEdit>?
                f_552_1404_1416()
                {
                    var return_v = EditCallback;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(552, 1404, 1416);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxContextReceiverCreator?
                f_552_1418_1446()
                {
                    var return_v = SyntaxContextReceiverCreator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(552, 1418, 1446);
                    return return_v;
                }


                System.Action<Microsoft.CodeAnalysis.GeneratorPostInitializationContext>?
                f_552_1448_1464()
                {
                    var return_v = PostInitCallback;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(552, 1448, 1464);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GeneratorInfo
                f_552_1386_1465(Microsoft.CodeAnalysis.EditCallback<Microsoft.CodeAnalysis.AdditionalFileEdit>?
                editCallback, Microsoft.CodeAnalysis.SyntaxContextReceiverCreator?
                receiverCreator, System.Action<Microsoft.CodeAnalysis.GeneratorPostInitializationContext>?
                postInitCallback)
                {
                    var return_v = new Microsoft.CodeAnalysis.GeneratorInfo(editCallback, receiverCreator, postInitCallback);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(552, 1386, 1465);
                    return return_v;
                }

            }

            public Builder()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(552, 1020, 1477);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(552, 1067, 1136);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(552, 1152, 1233);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(552, 1249, 1332);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(552, 1020, 1477);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(552, 1020, 1477);
            }


            static Builder()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(552, 1020, 1477);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(552, 1020, 1477);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(552, 1020, 1477);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(552, 1020, 1477);
        }
        static GeneratorInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(552, 266, 1484);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(552, 266, 1484);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(552, 266, 1484);
        }
    }
}
